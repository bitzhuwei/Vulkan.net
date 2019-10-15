using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using static Vulkan.vkAPI;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Demo.RadialBlur {
    /// <summary>
    /// 
    /// </summary>
    public unsafe class RadialBlurDemo : DemoBase {

        public const uint VK_SUBPASS_EXTERNAL = (~0U);

        private const uint VERTEX_BUFFER_BIND_ID = 0;
        private const int FB_DIM = 512;
        private const VkFormat FB_COLOR_FORMAT = VkFormat.R8g8b8a8Unorm;// VK_FORMAT_R8G8B8A8_UNORM;

        bool blur = true;
        bool displayTexture = true;// false;

        vksTexture2D textures_gradient = new vksTexture2D();

        // Vertex layout for the models
        vksVertexLayout vertexLayout = new vksVertexLayout(
            VertexComponent.VERTEX_COMPONENT_POSITION,
            VertexComponent.VERTEX_COMPONENT_UV,
            VertexComponent.VERTEX_COMPONENT_COLOR,
            VertexComponent.VERTEX_COMPONENT_NORMAL);

        vksModel model = new vksModel();

        VkPipelineVertexInputStateCreateInfo* inputInfo;
        VkVertexInputBindingDescription[] bindingDescs;
        VkVertexInputAttributeDescription* attributeDescs;

        vksBuffer uniformBufferScene = new vksBuffer();
        vksBuffer uniformBufferBlurParams = new vksBuffer();

        struct UboVS {
            public Matrix4x4 projection;
            public Matrix4x4 model;
            public float gradientPos;
        }

        UboVS uboScene;

        struct UboBlurParams {
            public float radialBlurScale;
            public float radialBlurStrength;
            public Vector2 radialOrigin;
        }

        UboBlurParams uboBlurParams = new UboBlurParams() {
            radialBlurScale = 0.35f,
            radialBlurStrength = 0.75f,
            radialOrigin = new Vector2(0.5f, 0.5f)
        };

        VkPipeline pipelineRadialBlur;
        VkPipeline pipelineColorPass;
        VkPipeline pipelinePhongPass;
        VkPipeline pipelineOffscreenDisplay;

        VkPipelineLayout pipelineLayoutRadialBlur;
        VkPipelineLayout pipelineLayoutScene;

        VkDescriptorSet setRadialBlur;
        VkDescriptorSet setScene;

        VkDescriptorSetLayout setLayoutRadialBlur;
        VkDescriptorSetLayout setLayoutScene;

        // Framebuffer for offscreen rendering
        struct FrameBufferAttachment {
            public VkImage image;
            public VkDeviceMemory mem;
            public VkImageView view;
        }

        struct OffscreenPass {
            public uint width, height;
            public VkFramebuffer framebuffer;
            public FrameBufferAttachment colorAttachment, depthAttachment;
            public VkRenderPass renderPass;
            public VkSampler sampler;
            public VkDescriptorImageInfo descriptorImage;
            public VkCommandBuffer commandBuffer;
            // Semaphore used to synchronize between offscreen and final scene render pass
            public VkSemaphore semaphore;
        }

        OffscreenPass offscreenPass;

        public RadialBlurDemo() {
            zoom = -10.0f;
            rotation = new Vector3(-16.25f, -28.75f, 0.0f);
            title = "Vulkan Example - Radial blur";
        }

        public void Dispose() {
            // Clean up used Vulkan resources 
            // Note : Inherited destructor cleans up resources stored in base class

            // Frame buffer

            // Color attachment
            vkDestroyImageView(device, offscreenPass.colorAttachment.view, null);
            vkDestroyImage(device, offscreenPass.colorAttachment.image, null);
            vkFreeMemory(device, offscreenPass.colorAttachment.mem, null);

            // Depth attachment
            vkDestroyImageView(device, offscreenPass.depthAttachment.view, null);
            vkDestroyImage(device, offscreenPass.depthAttachment.image, null);
            vkFreeMemory(device, offscreenPass.depthAttachment.mem, null);

            vkDestroyRenderPass(device, offscreenPass.renderPass, null);
            vkDestroySampler(device, offscreenPass.sampler, null);
            vkDestroyFramebuffer(device, offscreenPass.framebuffer, null);

            vkDestroyPipeline(device, pipelineRadialBlur, null);
            vkDestroyPipeline(device, pipelinePhongPass, null);
            vkDestroyPipeline(device, pipelineColorPass, null);
            vkDestroyPipeline(device, pipelineOffscreenDisplay, null);

            vkDestroyPipelineLayout(device, pipelineLayoutRadialBlur, null);
            vkDestroyPipelineLayout(device, pipelineLayoutScene, null);

            vkDestroyDescriptorSetLayout(device, setLayoutScene, null);
            vkDestroyDescriptorSetLayout(device, setLayoutRadialBlur, null);

            model.destroy();

            uniformBufferScene.destroy();
            uniformBufferBlurParams.destroy();

            VkCommandBuffer cmdBuffer;
            vkFreeCommandBuffers(device, cmdPool, 1, &cmdBuffer);
            offscreenPass.commandBuffer = cmdBuffer;
            vkDestroySemaphore(device, offscreenPass.semaphore, null);

            textures_gradient.destroy();
        }

        // Setup the offscreen framebuffer for rendering the blurred scene
        // The color attachment of this framebuffer will then be used to sample frame in the fragment shader of the final pass
        void prepareOffscreen() {
            offscreenPass.width = FB_DIM;
            offscreenPass.height = FB_DIM;

            // Find a suitable depth format
            VkFormat fbDepthFormat;
            VkBool32 validDepthFormat = Tools.getSupportedDepthFormat(physicalDevice, &fbDepthFormat);
            Debug.Assert(validDepthFormat);

            // Color attachment
            var imageInfo = VkImageCreateInfo.Alloc();
            imageInfo->imageType = VkImageType._2d;// VK_IMAGE_TYPE_2D;
            imageInfo->format = FB_COLOR_FORMAT;
            imageInfo->extent.width = (uint)offscreenPass.width;
            imageInfo->extent.height = (uint)offscreenPass.height;
            imageInfo->extent.depth = 1;
            imageInfo->mipLevels = 1;
            imageInfo->arrayLayers = 1;
            imageInfo->samples = VkSampleCountFlagBits._1;// VK_SAMPLE_COUNT_1_BIT;
            imageInfo->tiling = VkImageTiling.Optimal;// VK_IMAGE_TILING_OPTIMAL;
            // We will sample directly from the color attachment
            imageInfo->usage = VkImageUsageFlagBits.ColorAttachment | VkImageUsageFlagBits.Sampled;
            //VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT | VK_IMAGE_USAGE_SAMPLED_BIT;

            var memAlloc = VkMemoryAllocateInfo.Alloc();
            VkMemoryRequirements memReqs;

            {
                VkImage image;
                vkCreateImage(device, imageInfo, null, &image);
                offscreenPass.colorAttachment.image = image;
            }
            vkGetImageMemoryRequirements(device, offscreenPass.colorAttachment.image, &memReqs);
            memAlloc->allocationSize = memReqs.size;
            memAlloc->memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits,
                VkMemoryPropertyFlagBits.DeviceLocal);
            //VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT);
            {
                VkDeviceMemory memory;
                vkAllocateMemory(device, memAlloc, null, &memory);
                offscreenPass.colorAttachment.mem = memory;
            }
            vkBindImageMemory(device, offscreenPass.colorAttachment.image, offscreenPass.colorAttachment.mem, 0);

            var colorViewInfo = VkImageViewCreateInfo.Alloc();
            colorViewInfo->viewType = VkImageViewType._2d;// VK_IMAGE_VIEW_TYPE_2D;
            colorViewInfo->format = FB_COLOR_FORMAT;
            colorViewInfo->subresourceRange = new VkImageSubresourceRange();
            colorViewInfo->subresourceRange.aspectMask = VkImageAspectFlagBits.Color;// VK_IMAGE_ASPECT_COLOR_BIT;
            colorViewInfo->subresourceRange.baseMipLevel = 0;
            colorViewInfo->subresourceRange.levelCount = 1;
            colorViewInfo->subresourceRange.baseArrayLayer = 0;
            colorViewInfo->subresourceRange.layerCount = 1;
            colorViewInfo->image = offscreenPass.colorAttachment.image;
            {
                VkImageView view;
                vkCreateImageView(device, colorViewInfo, null, &view);
                offscreenPass.colorAttachment.view = view;
            }

            // Create sampler to sample from the attachment in the fragment shader
            var samplerInfo = VkSamplerCreateInfo.Alloc();
            samplerInfo->magFilter = VkFilter.Linear;// VK_FILTER_LINEAR;
            samplerInfo->minFilter = VkFilter.Linear;// VK_FILTER_LINEAR;
            samplerInfo->mipmapMode = VkSamplerMipmapMode.Linear;// VK_SAMPLER_MIPMAP_MODE_LINEAR;
            samplerInfo->addressModeU = VkSamplerAddressMode.ClampToEdge;// VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE;
            samplerInfo->addressModeV = samplerInfo->addressModeU;
            samplerInfo->addressModeW = samplerInfo->addressModeU;
            samplerInfo->mipLodBias = 0.0f;
            samplerInfo->maxAnisotropy = 0;
            samplerInfo->minLod = 0.0f;
            samplerInfo->maxLod = 1.0f;
            samplerInfo->borderColor = VkBorderColor.FloatOpaqueWhite;// VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE;
            {
                VkSampler sampler;
                vkCreateSampler(device, samplerInfo, null, &sampler);
                offscreenPass.sampler = sampler;
            }

            // Depth stencil attachment
            imageInfo->format = fbDepthFormat;
            imageInfo->usage = VkImageUsageFlagBits.DepthStencilAttachment;// VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT;

            {
                VkImage image;
                vkCreateImage(device, imageInfo, null, &image);
                offscreenPass.depthAttachment.image = image;
            }
            vkGetImageMemoryRequirements(device, offscreenPass.depthAttachment.image, &memReqs);
            memAlloc->allocationSize = memReqs.size;
            memAlloc->memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits,
                VkMemoryPropertyFlagBits.DeviceLocal);
            //VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT);
            {
                VkDeviceMemory memory;
                vkAllocateMemory(device, memAlloc, null, &memory);
                offscreenPass.depthAttachment.mem = memory;
            }
            vkBindImageMemory(device, offscreenPass.depthAttachment.image, offscreenPass.depthAttachment.mem, 0);

            var depthViewInfo = VkImageViewCreateInfo.Alloc();
            depthViewInfo->viewType = VkImageViewType._2d;// VK_IMAGE_VIEW_TYPE_2D;
            depthViewInfo->format = fbDepthFormat;
            depthViewInfo->flags = 0;
            depthViewInfo->subresourceRange = new VkImageSubresourceRange();
            depthViewInfo->subresourceRange.aspectMask = VkImageAspectFlagBits.Depth | VkImageAspectFlagBits.Stencil;
            //VK_IMAGE_ASPECT_DEPTH_BIT | VK_IMAGE_ASPECT_STENCIL_BIT;
            depthViewInfo->subresourceRange.baseMipLevel = 0;
            depthViewInfo->subresourceRange.levelCount = 1;
            depthViewInfo->subresourceRange.baseArrayLayer = 0;
            depthViewInfo->subresourceRange.layerCount = 1;
            depthViewInfo->image = offscreenPass.depthAttachment.image;
            {
                VkImageView view;
                vkCreateImageView(device, depthViewInfo, null, &view);
                offscreenPass.depthAttachment.view = view;
            }

            // Create a separate render pass for the offscreen rendering as it may differ from the one used for scene rendering

            var attchmentDescriptions = new VkAttachmentDescription[2];
            // Color attachment
            attchmentDescriptions[0].format = FB_COLOR_FORMAT;
            attchmentDescriptions[0].samples = VkSampleCountFlagBits._1;// VK_SAMPLE_COUNT_1_BIT;
            attchmentDescriptions[0].loadOp = VkAttachmentLoadOp.Clear;// VK_ATTACHMENT_LOAD_OP_CLEAR;
            attchmentDescriptions[0].storeOp = VkAttachmentStoreOp.Store;// VK_ATTACHMENT_STORE_OP_STORE;
            attchmentDescriptions[0].stencilLoadOp = VkAttachmentLoadOp.DontCare;// VK_ATTACHMENT_LOAD_OP_DONT_CARE;
            attchmentDescriptions[0].stencilStoreOp = VkAttachmentStoreOp.DontCare;// VK_ATTACHMENT_STORE_OP_DONT_CARE;
            attchmentDescriptions[0].initialLayout = VkImageLayout.Undefined;// VK_IMAGE_LAYOUT_UNDEFINED;
            attchmentDescriptions[0].finalLayout = VkImageLayout.ShaderReadOnlyOptimal;// VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL;
            // Depth attachment
            attchmentDescriptions[1].format = fbDepthFormat;
            attchmentDescriptions[1].samples = VkSampleCountFlagBits._1;// VK_SAMPLE_COUNT_1_BIT;
            attchmentDescriptions[1].loadOp = VkAttachmentLoadOp.Clear;// VK_ATTACHMENT_LOAD_OP_CLEAR;
            attchmentDescriptions[1].storeOp = VkAttachmentStoreOp.DontCare;// VK_ATTACHMENT_STORE_OP_DONT_CARE;
            attchmentDescriptions[1].stencilLoadOp = VkAttachmentLoadOp.DontCare;// VK_ATTACHMENT_LOAD_OP_DONT_CARE;
            attchmentDescriptions[1].stencilStoreOp = VkAttachmentStoreOp.DontCare;// VK_ATTACHMENT_STORE_OP_DONT_CARE;
            attchmentDescriptions[1].initialLayout = VkImageLayout.Undefined;// VK_IMAGE_LAYOUT_UNDEFINED;
            attchmentDescriptions[1].finalLayout = VkImageLayout.DepthStencilAttachmentOptimal;// VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL;

            var colorReference = new VkAttachmentReference {
                attachment = 0,
                layout = VkImageLayout.ColorAttachmentOptimal// VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL
            };
            var depthReference = new VkAttachmentReference {
                attachment = 1,
                layout = VkImageLayout.DepthStencilAttachmentOptimal// VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL
            };

            VkSubpassDescription subpassDescription = new VkSubpassDescription();
            subpassDescription.pipelineBindPoint = VkPipelineBindPoint.Graphics;// VK_PIPELINE_BIND_POINT_GRAPHICS;
            subpassDescription.colorAttachmentCount = 1;
            subpassDescription.pColorAttachments = &colorReference;
            subpassDescription.pDepthStencilAttachment = &depthReference;

            // Use subpass dependencies for layout transitions
            var dependencies = new VkSubpassDependency[2];
            dependencies[0].srcSubpass = VK_SUBPASS_EXTERNAL;
            dependencies[0].dstSubpass = 0;
            dependencies[0].srcStageMask = VkPipelineStageFlagBits.BottomOfPipe;// VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT;
            dependencies[0].dstStageMask = VkPipelineStageFlagBits.ColorAttachmentOutput;// VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
            dependencies[0].srcAccessMask = VkAccessFlagBits.MemoryRead;// VK_ACCESS_MEMORY_READ_BIT;
            dependencies[0].dstAccessMask = VkAccessFlagBits.ColorAttachmentRead | VkAccessFlagBits.ColorAttachmentWrite;
            //VK_ACCESS_COLOR_ATTACHMENT_READ_BIT | VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT;
            dependencies[0].dependencyFlags = VkDependencyFlagBits.ByRegion;// VK_DEPENDENCY_BY_REGION_BIT;
            dependencies[1].srcSubpass = 0;
            dependencies[1].dstSubpass = VK_SUBPASS_EXTERNAL;
            dependencies[1].srcStageMask = VkPipelineStageFlagBits.ColorAttachmentOutput;// VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
            dependencies[1].dstStageMask = VkPipelineStageFlagBits.BottomOfPipe;// VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT;
            dependencies[1].srcAccessMask = VkAccessFlagBits.ColorAttachmentRead | VkAccessFlagBits.ColorAttachmentWrite;
            //VK_ACCESS_COLOR_ATTACHMENT_READ_BIT | VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT;
            dependencies[1].dstAccessMask = VkAccessFlagBits.MemoryRead;// VK_ACCESS_MEMORY_READ_BIT;
            dependencies[1].dependencyFlags = VkDependencyFlagBits.ByRegion;// VK_DEPENDENCY_BY_REGION_BIT;

            // Create the actual renderpass
            var renderPassInfo = VkRenderPassCreateInfo.Alloc();
            //renderPassInfo->attachmentCount = attchmentDescriptions.Length;
            //renderPassInfo->pAttachments = &attchmentDescriptions.First;
            attchmentDescriptions.Set(renderPassInfo);
            renderPassInfo->subpassCount = 1;
            renderPassInfo->pSubpasses = &subpassDescription;
            //renderPassInfo->dependencyCount = dependencies.Count;
            //renderPassInfo->pDependencies = &dependencies.First;
            dependencies.Set(renderPassInfo);
            {
                VkRenderPass renderPass;
                vkCreateRenderPass(device, renderPassInfo, null, &renderPass);
                offscreenPass.renderPass = renderPass;
            }

            var attachments = new VkImageView[]{
                offscreenPass.colorAttachment.view,
                offscreenPass.depthAttachment.view
            };

            var framebufferInfo = VkFramebufferCreateInfo.Alloc();
            framebufferInfo->renderPass = offscreenPass.renderPass;
            framebufferInfo->attachments = attachments;
            framebufferInfo->width = (uint)offscreenPass.width;
            framebufferInfo->height = (uint)offscreenPass.height;
            framebufferInfo->layers = 1;
            {
                VkFramebuffer framebuffer;
                vkCreateFramebuffer(device, framebufferInfo, null, &framebuffer);
                offscreenPass.framebuffer = framebuffer;
            }

            // Fill a descriptor for later use in a descriptor set 
            offscreenPass.descriptorImage.imageLayout = VkImageLayout.ShaderReadOnlyOptimal;// VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL;
            offscreenPass.descriptorImage.imageView = offscreenPass.colorAttachment.view;
            offscreenPass.descriptorImage.sampler = offscreenPass.sampler;
        }

        // Sets up the command buffer that renders the scene to the offscreen frame buffer
        void buildOffscreenCommandBuffer() {
            if (offscreenPass.commandBuffer.handle == 0) {
                offscreenPass.commandBuffer = createCommandBuffer(
                    VkCommandBufferLevel.Primary //VK_COMMAND_BUFFER_LEVEL_PRIMARY
                    , false);
            }
            if (offscreenPass.semaphore.handle == 0) {
                var semaphoreCreateInfo = VkSemaphoreCreateInfo.Alloc();
                VkSemaphore semaphore;
                vkCreateSemaphore(device, semaphoreCreateInfo, null, &semaphore);
                offscreenPass.semaphore = semaphore;
            }

            var cmdBufInfo = VkCommandBufferBeginInfo.Alloc();
            var clearValues = new VkClearValue[2];
            clearValues[0].color = defaultClearColor;
            clearValues[1].depthStencil = new VkClearDepthStencilValue { depth = 1.0f, stencil = 0 };

            var renderPassBeginInfo = VkRenderPassBeginInfo.Alloc();
            renderPassBeginInfo->renderPass = offscreenPass.renderPass;
            renderPassBeginInfo->framebuffer = offscreenPass.framebuffer;
            renderPassBeginInfo->renderArea.extent.width = offscreenPass.width;
            renderPassBeginInfo->renderArea.extent.height = offscreenPass.height;
            //renderPassBeginInfo->clearValueCount = 2;
            //renderPassBeginInfo->pClearValues = &clearValues.First;
            clearValues.Set(renderPassBeginInfo);

            vkBeginCommandBuffer(offscreenPass.commandBuffer, cmdBufInfo);

            VkViewport viewport = new VkViewport(offscreenPass.width, offscreenPass.height, 0.0f, 1.0f);
            vkCmdSetViewport(offscreenPass.commandBuffer, 0, 1, &viewport);

            VkRect2D scissor = new VkRect2D(0, 0, offscreenPass.width, offscreenPass.height);
            vkCmdSetScissor(offscreenPass.commandBuffer, 0, 1, &scissor);

            vkCmdBeginRenderPass(offscreenPass.commandBuffer, renderPassBeginInfo, VkSubpassContents.Inline);// VK_SUBPASS_CONTENTS_INLINE);

            {
                VkDescriptorSet set = setScene;
                vkCmdBindDescriptorSets(offscreenPass.commandBuffer, VkPipelineBindPoint.Graphics,// VK_PIPELINE_BIND_POINT_GRAPHICS,
                    pipelineLayoutScene, 0, 1, &set, 0, null);
            }
            vkCmdBindPipeline(offscreenPass.commandBuffer, VkPipelineBindPoint.Graphics, // VK_PIPELINE_BIND_POINT_GRAPHICS,
                pipelineColorPass);
            {
                VkBuffer buffer = model.vertices.buffer;
                VkDeviceSize offset = 0;
                vkCmdBindVertexBuffers(offscreenPass.commandBuffer, VERTEX_BUFFER_BIND_ID, 1, &buffer, &offset);
            }
            vkCmdBindIndexBuffer(offscreenPass.commandBuffer, model.indices.buffer, 0, VkIndexType.Uint32);// VK_INDEX_TYPE_UINT32);
            vkCmdDrawIndexed(offscreenPass.commandBuffer, model.indexCount, 1, 0, 0, 0);

            vkCmdEndRenderPass(offscreenPass.commandBuffer);

            vkEndCommandBuffer(offscreenPass.commandBuffer);
        }

        void reBuildCommandBuffers() {
            if (!checkCommandBuffers()) {
                destroyCommandBuffers();
                createCommandBuffers();
            }
            buildCommandBuffers();
        }

        protected override void buildCommandBuffers() {
            var cmdBufInfo = VkCommandBufferBeginInfo.Alloc();

            var clearValues = new VkClearValue[2];
            clearValues[0].color = defaultClearColor;
            clearValues[1].depthStencil = new VkClearDepthStencilValue { depth = 1.0f, stencil = 0 };

            var renderPassBeginInfo = VkRenderPassBeginInfo.Alloc();
            renderPassBeginInfo->renderPass = renderPass;
            renderPassBeginInfo->renderArea.offset.x = 0;
            renderPassBeginInfo->renderArea.offset.y = 0;
            renderPassBeginInfo->renderArea.extent.width = width;
            renderPassBeginInfo->renderArea.extent.height = height;
            //renderPassBeginInfo->clearValueCount = 2;
            //renderPassBeginInfo->pClearValues = &clearValues.First;
            clearValues.Set(renderPassBeginInfo);

            for (int i = 0; i < drawCmdBuffers.Length; ++i) {
                // Set target frame buffer
                renderPassBeginInfo->framebuffer = frameBuffers[i];

                vkBeginCommandBuffer(drawCmdBuffers[i], cmdBufInfo);

                vkCmdBeginRenderPass(drawCmdBuffers[i], renderPassBeginInfo, VkSubpassContents.Inline);// VK_SUBPASS_CONTENTS_INLINE);

                VkViewport viewport = new VkViewport(width, height, 0.0f, 1.0f);
                vkCmdSetViewport(drawCmdBuffers[i], 0, 1, &viewport);

                VkRect2D scissor = new VkRect2D(0, 0, width, height);
                vkCmdSetScissor(drawCmdBuffers[i], 0, 1, &scissor);

                // 3D scene
                {
                    VkDescriptorSet set = setScene;
                    vkCmdBindDescriptorSets(drawCmdBuffers[i], VkPipelineBindPoint.Graphics,// VK_PIPELINE_BIND_POINT_GRAPHICS, 
                    pipelineLayoutScene, 0, 1, &set, 0, null);
                }
                vkCmdBindPipeline(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, // VK_PIPELINE_BIND_POINT_GRAPHICS, 
                    pipelinePhongPass);
                {
                    VkBuffer buffer = model.vertices.buffer;
                    VkDeviceSize offset = 0;
                    vkCmdBindVertexBuffers(drawCmdBuffers[i], VERTEX_BUFFER_BIND_ID, 1, &buffer, &offset);
                }
                vkCmdBindIndexBuffer(drawCmdBuffers[i], model.indices.buffer, 0, VkIndexType.Uint32);// VK_INDEX_TYPE_UINT32);
                vkCmdDrawIndexed(drawCmdBuffers[i], model.indexCount, 1, 0, 0, 0);

                // Fullscreen triangle (clipped to a quad) with radial blur
                if (blur) {
                    {
                        VkDescriptorSet set = setRadialBlur;
                        vkCmdBindDescriptorSets(drawCmdBuffers[i], VkPipelineBindPoint.Graphics,// VK_PIPELINE_BIND_POINT_GRAPHICS, 
                            pipelineLayoutRadialBlur, 0, 1, &set, 0, null);
                    }
                    vkCmdBindPipeline(drawCmdBuffers[i], VkPipelineBindPoint.Graphics,// VK_PIPELINE_BIND_POINT_GRAPHICS, 
                        (displayTexture) ? pipelineOffscreenDisplay : pipelineRadialBlur);
                    vkCmdDraw(drawCmdBuffers[i], 3, 1, 0, 0);
                }

                vkCmdEndRenderPass(drawCmdBuffers[i]);

                vkEndCommandBuffer(drawCmdBuffers[i]);
            }
        }

        void loadAssets() {
            model.loadFromFile(getAssetPath() + "models/glowsphere.dae", vertexLayout, 0.05f, vulkanDevice, queue);
            textures_gradient.loadFromFile(getAssetPath() + "textures/particle_gradient_rgba.ktx",
                VkFormat.R8g8b8a8Unorm,// VK_FORMAT_R8G8B8A8_UNORM, 
                vulkanDevice, queue);
        }

        void setupVertexDescriptions() {
            // Binding description
            bindingDescs = new VkVertexInputBindingDescription[1];
            bindingDescs[0].binding = VERTEX_BUFFER_BIND_ID;
            bindingDescs[0].stride = vertexLayout.stride();
            bindingDescs[0].inputRate = VkVertexInputRate.Vertex;// VK_VERTEX_INPUT_RATE_VERTEX;

            // Attribute descriptions
            attributeDescs = VkVertexInputAttributeDescription.Alloc(4);
            // Location 0 : Position
            attributeDescs[0].binding = VERTEX_BUFFER_BIND_ID;
            attributeDescs[0].location = 0;
            attributeDescs[0].format = VkFormat.R32g32b32Sfloat;// VK_FORMAT_R32G32B32_SFLOAT,
            attributeDescs[0].offset = 0;
            // Location 1 : Texture coordinates
            attributeDescs[1].binding = VERTEX_BUFFER_BIND_ID;
            attributeDescs[1].location = 1;
            attributeDescs[1].format = VkFormat.R32g32Sfloat;// VK_FORMAT_R32G32_SFLOAT,
            attributeDescs[1].offset = sizeof(float) * 3;
            // Location 2 : Color
            attributeDescs[2].binding = VERTEX_BUFFER_BIND_ID;
            attributeDescs[2].location = 2;
            attributeDescs[2].format = VkFormat.R32g32b32Sfloat;// VK_FORMAT_R32G32B32_SFLOAT,
            attributeDescs[2].offset = sizeof(float) * 5;
            // Location 3 : Normal
            attributeDescs[3].binding = VERTEX_BUFFER_BIND_ID;
            attributeDescs[3].location = 3;
            attributeDescs[3].format = VkFormat.R32g32b32Sfloat;// VK_FORMAT_R32G32B32_SFLOAT,
            attributeDescs[3].offset = sizeof(float) * 8;

            inputInfo = VkPipelineVertexInputStateCreateInfo.Alloc();
            //inputInfo->vertexBindingDescriptionCount = (uint)bindingDescs.Length;
            //inputInfo->pVertexBindingDescriptions = bindingDescs;
            bindingDescs.Set(inputInfo);
            inputInfo->vertexAttributeDescriptionCount = 4;//(uint)attributeDescs.Length;
            inputInfo->pVertexAttributeDescriptions = attributeDescs;
            //attributeDescs.Set(inputInfo);
        }

        void setupDescriptorPool() {
            // Example uses three ubos and one image sampler
            var poolSizes = new VkDescriptorPoolSize[2];
            poolSizes[0].type = VkDescriptorType.UniformBuffer;
            poolSizes[0].descriptorCount = 4;
            poolSizes[1].type = VkDescriptorType.CombinedImageSampler;
            poolSizes[1].descriptorCount = 6;

            var descriptorPoolInfo = VkDescriptorPoolCreateInfo.Alloc();
            descriptorPoolInfo->poolSizes = poolSizes;
            descriptorPoolInfo->maxSets = 2;

            VkDescriptorPool pool;
            vkCreateDescriptorPool(device, descriptorPoolInfo, null, &pool);
            this.descriptorPool = pool;
            Marshal.FreeHGlobal((IntPtr)descriptorPoolInfo);
        }

        void setupDescriptorSetLayout() {
            // Scene rendering
            {
                var bindings = new VkDescriptorSetLayoutBinding[]
                {
                    // Binding 0: Vertex shader uniform buffer
                    new VkDescriptorSetLayoutBinding {
                        binding = 0,
                        descriptorType = VkDescriptorType.UniformBuffer, descriptorCount = 1,
                        stageFlags = VkShaderStageFlagBits.Vertex
                    },
                    // Binding 1: Fragment shader image sampler
                    new VkDescriptorSetLayoutBinding {
                        binding = 1,
                        descriptorType = VkDescriptorType.CombinedImageSampler, descriptorCount = 1,
                        stageFlags = VkShaderStageFlagBits.Fragment
                    },
                    // Binding 2: Fragment shader uniform buffer
                    new VkDescriptorSetLayoutBinding {
                        binding = 2,
                        descriptorType = VkDescriptorType.UniformBuffer, descriptorCount = 1,
                        stageFlags = VkShaderStageFlagBits.Fragment
                    },
                };

                var layoutInfo = VkDescriptorSetLayoutCreateInfo.Alloc();
                layoutInfo->bindings = bindings;
                {
                    VkDescriptorSetLayout layout;
                    vkCreateDescriptorSetLayout(device, layoutInfo, null, &layout);
                    this.setLayoutScene = layout;
                }
                {
                    var dsl = setLayoutScene;
                    var pPipelineLayoutCreateInfo = VkPipelineLayoutCreateInfo.Alloc();
                    dsl.Set(pPipelineLayoutCreateInfo);
                    VkPipelineLayout pipelineLayout;
                    vkCreatePipelineLayout(device, pPipelineLayoutCreateInfo, null, &pipelineLayout);
                    this.pipelineLayoutScene = pipelineLayout;
                }
            }
            // Fullscreen radial blur
            {
                var bindings = new VkDescriptorSetLayoutBinding[]
                {
                    // Binding 0 : Vertex shader uniform buffer
                    new VkDescriptorSetLayoutBinding {
                        binding = 0,
                        descriptorType = VkDescriptorType.UniformBuffer, descriptorCount = 1,
                        stageFlags = VkShaderStageFlagBits.Fragment
                    },
                    // Binding 0: Fragment shader image sampler
                    new VkDescriptorSetLayoutBinding {
                        binding = 1,
                        descriptorType = VkDescriptorType.CombinedImageSampler, descriptorCount = 1,
                        stageFlags = VkShaderStageFlagBits.Fragment
                    },
                };
                var layoutInfo = VkDescriptorSetLayoutCreateInfo.Alloc();
                layoutInfo->bindings = bindings;
                {
                    VkDescriptorSetLayout layout;
                    vkCreateDescriptorSetLayout(device, layoutInfo, null, &layout);
                    this.setLayoutRadialBlur = layout;
                }
                {
                    var dsl = setLayoutRadialBlur;
                    var pPipelineLayoutCreateInfo = VkPipelineLayoutCreateInfo.Alloc();
                    dsl.Set(pPipelineLayoutCreateInfo);
                    VkPipelineLayout pipelineLayout;
                    vkCreatePipelineLayout(device, pPipelineLayoutCreateInfo, null, &pipelineLayout);
                    this.pipelineLayoutRadialBlur = pipelineLayout;
                }
            }
        }

        void setupDescriptorSet() {
            // Scene rendering
            {
                VkDescriptorSetLayout dsl = setLayoutScene;
                var info = VkDescriptorSetAllocateInfo.Alloc();
                info->setLayouts = dsl;
                info->descriptorPool = descriptorPool;
                VkDescriptorSet set;
                vkAllocateDescriptorSets(device, info, &set);
                this.setScene = set;
            }
            {
                var descriptor0 = uniformBufferScene.descriptor;
                var descriptor1 = textures_gradient.descriptor;
                var writes = VkWriteDescriptorSet.Alloc(2);
                {
                    // Binding 0: Vertex shader uniform buffer
                    writes[0].dstSet = setScene;
                    writes[0].descriptorType = VkDescriptorType.UniformBuffer;
                    writes[0].dstBinding = 0;
                    descriptor0.Set(writes);
                    // Binding 1: Color gradient sampler
                    writes[1].dstSet = setScene;
                    writes[1].descriptorType = VkDescriptorType.CombinedImageSampler;
                    writes[1].dstBinding = 1;
                    descriptor1.Set(&(writes[1]));
                }
                vkUpdateDescriptorSets(device, 2, writes, 0, null);
            }

            // Fullscreen radial blur
            {
                VkDescriptorSetLayout dsl = setLayoutRadialBlur;
                var info = VkDescriptorSetAllocateInfo.Alloc();
                info->setLayouts = dsl;
                info->descriptorPool = descriptorPool;
                VkDescriptorSet set;
                vkAllocateDescriptorSets(device, info, &set);
                this.setRadialBlur = set;
            }
            {
                VkDescriptorBufferInfo descriptor0 = uniformBufferBlurParams.descriptor;
                VkDescriptorImageInfo descriptor1 = offscreenPass.descriptorImage;
                var writes = VkWriteDescriptorSet.Alloc(2);
                {
                    // Binding 0: Vertex shader uniform buffer
                    writes[0].dstSet = setRadialBlur;
                    writes[0].descriptorType = VkDescriptorType.UniformBuffer;
                    writes[0].dstBinding = 0;
                    descriptor0.Set(writes);
                    // Binding 0: Fragment shader texture sampler
                    writes[1].dstSet = setRadialBlur;
                    writes[1].descriptorType = VkDescriptorType.CombinedImageSampler;
                    writes[1].dstBinding = 1;
                    descriptor1.Set(&(writes[1]));
                }
                vkUpdateDescriptorSets(device, 2, writes, 0, null);
            }
        }

        void preparePipelines() {
            var inputAssemblyState = VkPipelineInputAssemblyStateCreateInfo.Alloc();
            inputAssemblyState->topology = VkPrimitiveTopology.TriangleList;
            inputAssemblyState->primitiveRestartEnable = false;

            var rasterizationState = VkPipelineRasterizationStateCreateInfo.Alloc();
            rasterizationState->polygonMode = VkPolygonMode.Fill;
            rasterizationState->cullMode = VkCullModeFlagBits.None;
            rasterizationState->frontFace = VkFrontFace.CounterClockwise;
            rasterizationState->lineWidth = 1.0f;

            var blendAttachmentState = VkPipelineColorBlendAttachmentState.Alloc();
            blendAttachmentState->colorWriteMask = (VkColorComponentFlagBits)0xf;
            blendAttachmentState->blendEnable = false;

            var colorBlendState = VkPipelineColorBlendStateCreateInfo.Alloc();
            colorBlendState->pAttachments = blendAttachmentState;
            colorBlendState->attachmentCount = 1;
            //(*blendAttachmentState).Set(colorBlendState);

            var depthStencilState = VkPipelineDepthStencilStateCreateInfo.Alloc();
            depthStencilState->depthTestEnable = true;
            depthStencilState->depthWriteEnable = true;
            depthStencilState->depthCompareOp = VkCompareOp.LessOrEqual;
            depthStencilState->front = depthStencilState->back;
            depthStencilState->back.compareOp = VkCompareOp.Always;

            var viewportState = VkPipelineViewportStateCreateInfo.Alloc();
            viewportState->viewportCount = 1;
            viewportState->scissorCount = 1;

            var multisampleState = VkPipelineMultisampleStateCreateInfo.Alloc();
            multisampleState->rasterizationSamples = VkSampleCountFlagBits._1;

            var dynamicStateEnables = new VkDynamicState[] { VkDynamicState.Viewport, VkDynamicState.Scissor };
            var dynamicState = VkPipelineDynamicStateCreateInfo.Alloc();
            dynamicStateEnables.Set(dynamicState);

            var shaderStages = VkPipelineShaderStageCreateInfo.Alloc(2);

            var pipelineCreateInfo = VkGraphicsPipelineCreateInfo.Alloc();
            pipelineCreateInfo->layout = pipelineLayoutRadialBlur;
            pipelineCreateInfo->renderPass = renderPass;
            pipelineCreateInfo->basePipelineIndex = -1;
            pipelineCreateInfo->pInputAssemblyState = inputAssemblyState;
            pipelineCreateInfo->pRasterizationState = rasterizationState;
            pipelineCreateInfo->pColorBlendState = colorBlendState;
            pipelineCreateInfo->pMultisampleState = multisampleState;
            pipelineCreateInfo->pViewportState = viewportState;
            pipelineCreateInfo->pDepthStencilState = depthStencilState;
            pipelineCreateInfo->pDynamicState = dynamicState;
            pipelineCreateInfo->stageCount = 2;
            pipelineCreateInfo->pStages = shaderStages;

            // Radial blur pipeline
            shaderStages[0] = loadShader(getAssetPath() + "shaders/radialblur/radialblur.vert.spv", VkShaderStageFlagBits.Vertex);
            shaderStages[1] = loadShader(getAssetPath() + "shaders/radialblur/radialblur.frag.spv", VkShaderStageFlagBits.Fragment);
            // Empty vertex input state
            var emptyInputState = VkPipelineVertexInputStateCreateInfo.Alloc();
            pipelineCreateInfo->pVertexInputState = emptyInputState;
            pipelineCreateInfo->layout = pipelineLayoutRadialBlur;
            // Additive blending
            blendAttachmentState->colorWriteMask = (VkColorComponentFlagBits)0xF;
            blendAttachmentState->blendEnable = true;
            blendAttachmentState->colorBlendOp = VkBlendOp.Add;
            blendAttachmentState->srcColorBlendFactor = VkBlendFactor.One;
            blendAttachmentState->dstColorBlendFactor = VkBlendFactor.One;
            blendAttachmentState->alphaBlendOp = VkBlendOp.Add;
            blendAttachmentState->srcAlphaBlendFactor = VkBlendFactor.SrcAlpha;
            blendAttachmentState->dstAlphaBlendFactor = VkBlendFactor.DstAlpha;
            {
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, pipelineCreateInfo, null, &pipeline);
                this.pipelineRadialBlur = pipeline;
            }

            // No blending (for debug display)
            blendAttachmentState->blendEnable = false;
            {
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, pipelineCreateInfo, null, &pipeline);
                this.pipelineOffscreenDisplay = pipeline;
            }

            // Phong pass
            pipelineCreateInfo->layout = pipelineLayoutScene;
            shaderStages[0] = loadShader(getAssetPath() + "shaders/radialblur/phongpass.vert.spv", VkShaderStageFlagBits.Vertex);
            shaderStages[1] = loadShader(getAssetPath() + "shaders/radialblur/phongpass.frag.spv", VkShaderStageFlagBits.Fragment);
            pipelineCreateInfo->pVertexInputState = inputInfo;
            blendAttachmentState->blendEnable = false;
            depthStencilState->depthWriteEnable = true;
            {
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, pipelineCreateInfo, null, &pipeline);
                this.pipelinePhongPass = pipeline;
            }

            // Color only pass (offscreen blur base)
            shaderStages[0] = loadShader(getAssetPath() + "shaders/radialblur/colorpass.vert.spv", VkShaderStageFlagBits.Vertex);
            shaderStages[1] = loadShader(getAssetPath() + "shaders/radialblur/colorpass.frag.spv", VkShaderStageFlagBits.Fragment);
            pipelineCreateInfo->renderPass = offscreenPass.renderPass;
            {
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, pipelineCreateInfo, null, &pipeline);
                this.pipelineColorPass = pipeline;
            }
        }

        // Prepare and initialize uniform buffer containing shader uniforms
        void prepareUniformBuffers() {
            // Phong and color pass vertex shader uniform buffer
            vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                uniformBufferScene,
                (ulong)sizeof(UboVS));

            // Fullscreen radial blur parameters
            var blurParamsLocal = uboBlurParams;
            vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                uniformBufferBlurParams,
                (ulong)sizeof(UboBlurParams),
                &blurParamsLocal);

            // Map persistent
            uniformBufferScene.map();
            uniformBufferBlurParams.map();

            updateUniformBuffersScene();
        }


        // Update uniform buffers for rendering the 3D scene
        void updateUniformBuffersScene() {
            uboScene.projection = Matrix4x4.CreatePerspectiveFieldOfView(Util.DegreesToRadians(45.0f), (float)width / (float)height, 1.0f, 256.0f);
            Matrix4x4 viewMatrix = Matrix4x4.CreateTranslation(0, 0, zoom);

            uboScene.model = Matrix4x4.Identity;
            uboScene.model = viewMatrix * uboScene.model * Matrix4x4.CreateTranslation(cameraPos);
            uboScene.model = Matrix4x4.CreateRotationX(Util.DegreesToRadians(rotation.X)) * uboScene.model;
            uboScene.model = Matrix4x4.CreateRotationY(Util.DegreesToRadians(rotation.Y)) * uboScene.model;
            //uboScene.model = Matrix4x4.CreateRotationX(Util.DegreesToRadians(timer * 360.0f)) * uboScene.model;
            uboScene.model = Matrix4x4.CreateRotationZ(Util.DegreesToRadians(rotation.Z)) * uboScene.model;

            if (!paused) {
                uboScene.gradientPos += frameTimer * 0.1f;
            }

            var local = uboScene;
            Unsafe.CopyBlock(uniformBufferScene.mapped, &local, (uint)sizeof(UboVS));
        }

        void draw() {
            prepareFrame();

            // Offscreen rendering

            // Wait for swap chain presentation to finish
            submitInfo->pWaitSemaphores = &((Semaphores*)semaphores.header)->PresentComplete;
            // Signal ready with offscreen semaphore
            var signalSemaphore = offscreenPass.semaphore;
            submitInfo->pSignalSemaphores = &signalSemaphore;

            // Submit work
            submitInfo->commandBufferCount = 1;
            var commandBuffer = offscreenPass.commandBuffer;
            submitInfo->pCommandBuffers = &commandBuffer;
            vkQueueSubmit(queue, 1, submitInfo, new VkFence());

            // Scene rendering

            // Wait for offscreen semaphore
            VkSemaphore semaphore = offscreenPass.semaphore;
            submitInfo->pWaitSemaphores = &semaphore;
            // Signal ready with render complete semaphpre
            submitInfo->pSignalSemaphores = &((Semaphores*)semaphores.header)->RenderComplete;

            // Submit work
            VkCommandBuffer cmdBuffer = drawCmdBuffers[currentBuffer];
            submitInfo->pCommandBuffers = &cmdBuffer;
            vkQueueSubmit(queue, 1, submitInfo, new VkFence());

            submitFrame();
        }

        public override void Init(Control canvas) {
            base.Init(canvas);
            loadAssets();
            prepareOffscreen();
            setupVertexDescriptions();
            prepareUniformBuffers();
            setupDescriptorSetLayout();
            preparePipelines();
            setupDescriptorPool();
            setupDescriptorSet();
            buildCommandBuffers();
            buildOffscreenCommandBuffer();
            prepared = true;
        }


        public override void Render() {
            if (!prepared)
                return;
            base.Render();
            draw();
            if (!paused) {
                updateUniformBuffersScene();
            }
        }

        protected override void viewChanged() {
            updateUniformBuffersScene();
        }

        void toggleBlur() {
            blur = !blur;
            updateUniformBuffersScene();
            reBuildCommandBuffers();
        }

        void toggleTextureDisplay() {
            displayTexture = !displayTexture;
            reBuildCommandBuffers();
        }
    }
}
