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

namespace Demo.Texture {
    // Vertex layout for this example
    public struct Vertex {
        public Vector3 pos;
        public Vector2 uv;
        public Vector3 normal;

        /// <summary>
        /// 0 : | pos
        /// </summary>
        public const uint PositionOffset = 0;
        /// <summary>
        /// 12 : pos | uv
        /// </summary>
        public const uint UvOffset = 12;
        /// <summary>
        /// 20 : pos | uv | normal
        /// </summary>
        public const uint NormalOffset = 20;
    };

    /// <summary>
    /// 
    /// </summary>
    public unsafe class TextureExample : DemoBase {
        // Contains all Vulkan objects that are required to store and use a texture
        // Note that this repository contains a texture class (VulkanTexture.hpp) that encapsulates texture loading functionality in a class that is used in subsequent demos
        public struct Texture {
            public VkSampler sampler;
            public VkImage image;
            public VkImageLayout imageLayout;
            public VkDeviceMemory DeviceMemory;
            public VkImageView view;
            public uint width, height;
            public uint mipLevels;
        }

        Texture texture;

        public class VertexDescription {
            public VkPipelineVertexInputStateCreateInfo* inputState;
            public VkVertexInputBindingDescription* bindingDescriptions;
            public VkVertexInputAttributeDescription* attributeDescriptions;
        }

        VertexDescription vDescription = new VertexDescription();

        vksBuffer vertexBuffer = new vksBuffer();
        vksBuffer indexBuffer = new vksBuffer();
        uint indexCount;

        /// <summary>
        /// uniform buffer object in vertex shader.
        /// </summary>
        vksBuffer uniformBufferVS = new vksBuffer();

        /// <summary>
        /// layout (binding = 0) uniform UBO in vertex shader.
        /// </summary>
        public struct UboVS {
            public Matrix4x4 projection;
            public Matrix4x4 model;
            public Vector4 viewPos;
            public float lodBias;
        }

        /// <summary>
        /// layout (binding = 0) uniform UBO in vertex shader.
        /// </summary>
        UboVS uboVS;
        VkPipeline pipeline;

        VkDescriptorSetLayout layout;
        VkDescriptorSet descriptorSet;
        VkPipelineLayout pipelineLayout;
        /// <summary>
        /// 0
        /// </summary>
        private const uint VERTEX_BUFFER_BIND_ID = 0;

        public TextureExample() {
            zoom = -2.5f;
            rotation = new Vector3(0.0f, 15.0f, 0.0f);
            title = "Vulkan Example - Texture loading";
            // enableTextOverlay = true;
        }

        public void Dispose() {
            // Clean up used Vulkan resources 
            // Note : Inherited destructor cleans up resources stored in base class

            destroyTextureImage(texture);

            vkDestroyPipeline(device, pipeline, null);

            vkDestroyPipelineLayout(device, pipelineLayout, null);
            vkDestroyDescriptorSetLayout(device, layout, null);

            vertexBuffer.destroy();
            indexBuffer.destroy();
            uniformBufferVS.destroy();
        }

        // Create an image memory barrier for changing the layout of
        // an image and put it into an active command buffer
        void setImageLayout(
            VkCommandBuffer cmdBuffer,
            VkImage image,
            VkImageAspectFlagBits aspectMask,
            VkImageLayout oldImageLayout,
            VkImageLayout newImageLayout,
            VkImageSubresourceRange subresourceRange) {
            // Create an image barrier object
            var barrier = VkImageMemoryBarrier.Alloc();
            barrier[0].oldLayout = oldImageLayout;
            barrier[0].newLayout = newImageLayout;
            barrier[0].image = image;
            barrier[0].subresourceRange = subresourceRange;

            // Only sets masks for layouts used in this example
            // For a more complete version that can be used with other layouts see vks::tools::setImageLayout

            // Source layouts (old)
            switch (oldImageLayout) {
                case VkImageLayout.Undefined:
                    // Only valid as initial layout, memory contents are not preserved
                    // Can be accessed directly, no source dependency required
                    barrier[0].srcAccessMask = 0;
                    break;
                case VkImageLayout.Preinitialized:
                    // Only valid as initial layout for linear images, preserves memory contents
                    // Make sure host writes to the image have been finished
                    barrier[0].srcAccessMask = VkAccessFlagBits.HostWrite;
                    break;
                case VkImageLayout.TransferDstOptimal:
                    // Old layout is transfer destination
                    // Make sure any writes to the image have been finished
                    barrier[0].srcAccessMask = VkAccessFlagBits.TransferWrite;
                    break;
            }

            // Target layouts (new)
            switch (newImageLayout) {
                case VkImageLayout.TransferSrcOptimal:
                    // Transfer source (copy, blit)
                    // Make sure any reads from the image have been finished
                    barrier[0].dstAccessMask = VkAccessFlagBits.TransferRead;
                    break;
                case VkImageLayout.TransferDstOptimal:
                    // Transfer destination (copy, blit)
                    // Make sure any writes to the image have been finished
                    barrier[0].dstAccessMask = VkAccessFlagBits.TransferWrite;
                    break;
                case VkImageLayout.ShaderReadOnlyOptimal:
                    // Shader read (sampler, input attachment)
                    barrier[0].dstAccessMask = VkAccessFlagBits.ShaderRead;
                    break;
            }

            // Put barrier on top of pipeline
            VkPipelineStageFlagBits srcStageFlags = VkPipelineStageFlagBits.TopOfPipe;
            VkPipelineStageFlagBits destStageFlags = VkPipelineStageFlagBits.TopOfPipe;

            // Put barrier inside setup command buffer
            vkCmdPipelineBarrier(
                cmdBuffer,
                srcStageFlags,
                destStageFlags,
                0,//VkDependencyFlagBits.None,
                0, null,
                0, null,
                1, barrier);
        }

        void loadTexture(string fileName, VkFormat format, bool forceLinearTiling) {
            KtxFile tex2D;
            using (var fs = File.OpenRead(fileName)) {
                tex2D = KtxFile.Load(fs, false);
            }

            texture.width = tex2D.Header.PixelWidth;
            texture.height = tex2D.Header.PixelHeight;
            texture.mipLevels = tex2D.Header.NumberOfMipmapLevels;

            // Get Device properites for the requested texture format
            VkFormatProperties formatProperties;
            vkGetPhysicalDeviceFormatProperties(physicalDevice, format, &formatProperties);

            // Only use linear tiling if requested (and supported by the Device)
            // Support for linear tiling is mostly limited, so prefer to use
            // optimal tiling instead
            // On most implementations linear tiling will only support a very
            // limited amount of formats and features (mip maps, cubemaps, arrays, etc.)
            uint useStaging = 1;

            // Only use linear tiling if forced
            if (forceLinearTiling) {
                // Don't use linear if format is not supported for (linear) shader sampling
                useStaging = ((formatProperties.linearTilingFeatures & VkFormatFeatureFlagBits.SampledImage)
                    != VkFormatFeatureFlagBits.SampledImage) ? 1u : 0u;
            }


            if (useStaging == 1) {
                // Create a host-visible staging buffer that contains the raw image data

                VkBuffer stagingBuffer;
                {
                    var info = VkBufferCreateInfo.Alloc();
                    info[0].size = tex2D.GetTotalSize();
                    // This buffer is used as a transfer source for the buffer copy
                    info[0].usage = VkBufferUsageFlagBits.TransferSrc;
                    info[0].sharingMode = VkSharingMode.Exclusive;
                    vkCreateBuffer(device, info, null, &stagingBuffer);
                }
                VkDeviceMemory stagingMemory;
                {
                    // Get memory requirements for the staging buffer (alignment, memory type bits)
                    var memReqs = new VkMemoryRequirements();
                    vkGetBufferMemoryRequirements(device, stagingBuffer, &memReqs);
                    var memAllocInfo = VkMemoryAllocateInfo.Alloc();
                    memAllocInfo[0].allocationSize = memReqs.size;
                    // Get memory type index for a host visible buffer
                    memAllocInfo[0].memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits,
                        VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);

                    vkAllocateMemory(device, memAllocInfo, null, &stagingMemory);
                    vkBindBufferMemory(device, stagingBuffer, stagingMemory, 0);

                    // Copy texture data into staging buffer
                    IntPtr data;
                    vkMapMemory(device, stagingMemory, 0, memReqs.size, 0, &data);
                    byte[] allData = tex2D.GetAllTextureData();
                    fixed (byte* tex2DDataPtr = &allData[0]) {
                        Unsafe.CopyBlock(data, tex2DDataPtr, (uint)allData.Length);
                    }
                    vkUnmapMemory(device, stagingMemory);
                }
                // Setup buffer copy regions for each mip level
                var copys = VkBufferImageCopy.Alloc((int)texture.mipLevels);
                for (uint i = 0, offset = 0; i < texture.mipLevels; i++) {
                    copys[i].imageSubresource.aspectMask = VkImageAspectFlagBits.Color;
                    copys[i].imageSubresource.mipLevel = i;
                    copys[i].imageSubresource.baseArrayLayer = 0;
                    copys[i].imageSubresource.layerCount = 1;
                    copys[i].imageExtent.width = tex2D.Faces[0].Mipmaps[i].Width;
                    copys[i].imageExtent.height = tex2D.Faces[0].Mipmaps[i].Height;
                    copys[i].imageExtent.depth = 1;
                    copys[i].bufferOffset = offset;

                    offset += tex2D.Faces[0].Mipmaps[i].SizeInBytes;
                }
                {
                    // Create optimal tiled target image
                    var info = VkImageCreateInfo.Alloc();
                    info[0].imageType = VkImageType._2d;//.Image2D;
                    info[0].format = format;
                    info[0].mipLevels = texture.mipLevels;
                    info[0].arrayLayers = 1;
                    info[0].samples = VkSampleCountFlagBits._1;//.Count1;
                    info[0].tiling = VkImageTiling.Optimal;
                    info[0].sharingMode = VkSharingMode.Exclusive;
                    // Set initial layout of the image to undefined
                    info[0].initialLayout = VkImageLayout.Undefined;
                    info[0].extent = new VkExtent3D { width = texture.width, height = texture.height, depth = 1 };
                    info[0].usage = VkImageUsageFlagBits.TransferDst | VkImageUsageFlagBits.Sampled;
                    {
                        VkImage image;
                        vkCreateImage(device, info, null, &image);
                        texture.image = image;
                    }
                    var memReqs = new VkMemoryRequirements();
                    vkGetImageMemoryRequirements(device, texture.image, &memReqs);

                    var memAllocInfo = VkMemoryAllocateInfo.Alloc();
                    memAllocInfo[0].allocationSize = memReqs.size;
                    memAllocInfo[0].memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits, VkMemoryPropertyFlagBits.DeviceLocal);
                    {
                        VkDeviceMemory memory;
                        vkAllocateMemory(device, memAllocInfo, null, &memory);
                        texture.DeviceMemory = memory;
                    }
                    vkBindImageMemory(device, texture.image, texture.DeviceMemory, 0);
                }
                VkCommandBuffer copyCmd = base.createCommandBuffer(VkCommandBufferLevel.Primary, true);

                // Image barrier for optimal image

                // The sub resource range describes the regions of the image we will be transition
                var subresourceRange = new VkImageSubresourceRange();
                // Image only contains color data
                subresourceRange.aspectMask = VkImageAspectFlagBits.Color;
                // Start at first mip level
                subresourceRange.baseMipLevel = 0;
                // We will transition on all mip levels
                subresourceRange.levelCount = texture.mipLevels;
                // The 2D texture only has one layer
                subresourceRange.layerCount = 1;

                // Optimal image will be used as destination for the copy, so we must transfer from our
                // initial undefined image layout to the transfer destination layout
                setImageLayout(
                    copyCmd,
                    texture.image,
                     VkImageAspectFlagBits.Color,
                     VkImageLayout.Undefined,
                     VkImageLayout.TransferDstOptimal,
                    subresourceRange);

                // Copy mip levels from staging buffer
                vkCmdCopyBufferToImage(
                    copyCmd,
                    stagingBuffer,
                    texture.image,
                     VkImageLayout.TransferDstOptimal,
                    texture.mipLevels,
                    copys);

                // Change texture image layout to shader read after all mip levels have been copied
                texture.imageLayout = VkImageLayout.ShaderReadOnlyOptimal;
                setImageLayout(
                    copyCmd,
                    texture.image,
                    VkImageAspectFlagBits.Color,
                    VkImageLayout.TransferDstOptimal,
                    texture.imageLayout,
                    subresourceRange);

                flushCommandBuffer(copyCmd, queue, true);

                // Clean up staging resources
                vkFreeMemory(device, stagingMemory, null);
                vkDestroyBuffer(device, stagingBuffer, null);
            }
            else {
                throw new NotImplementedException();

                /*
                // Prefer using optimal tiling, as linear tiling 
                // may support only a small set of features 
                // depending on implementation (e.g. no mip maps, only one layer, etc.)

                VkImage mappableImage;
                VkDeviceMemory mappableMemory;

                // Load mip map level 0 to linear tiling image
                VkImageCreateInfo imageCreateInfo = Initializers.imageCreateInfo();
                imageCreateInfo.imageType = VkImageType._2d;
                imageCreateInfo.format = format;
                imageCreateInfo.mipLevels = 1;
                imageCreateInfo.arrayLayers = 1;
                imageCreateInfo.samples = VkSampleCountFlagBits._1;
                imageCreateInfo.tiling = VkImageTiling.Linear;
                imageCreateInfo.usage = VkImageUsageFlagBits.Sampled;
                imageCreateInfo.sharingMode = VkSharingMode.Exclusive;
                imageCreateInfo.initialLayout = VkImageLayout.Preinitialized;
                imageCreateInfo.extent = new VkExtent3D { width = texture.width, height = texture.height, depth = 1 };
                Util.CheckResult(vkCreateImage(Device, &imageCreateInfo, null, &mappableImage));

                // Get memory requirements for this image 
                // like size and alignment
                vkGetImageMemoryRequirements(Device, mappableImage, &memReqs);
                // Set memory allocation size to required memory size
                memAllocInfo.allocationSize = memReqs.size;

                // Get memory type that can be mapped to host memory
                memAllocInfo.memoryTypeIndex = VulkanDevice.GetMemoryType(memReqs.memoryTypeBits,  VkMemoryPropertyFlagBits.HostVisible |  VkMemoryPropertyFlagBits.HostCoherent);

                // Allocate host memory
                Util.CheckResult(vkAllocateMemory(Device, &memAllocInfo, null, &mappableMemory));

                // Bind allocated image for use
                Util.CheckResult(vkBindImageMemory(Device, mappableImage, mappableMemory, 0));

                // Get sub resource layout
                // Mip map count, array layer, etc.
                VkImageSubresource subRes = new VkImageSubresource();
                subRes.aspectMask =  VkImageAspectFlagBits.Color;

                VkSubresourceLayout subResLayout;
                void* data;

                // Get sub resources layout 
                // Includes row pitch, size offsets, etc.
                vkGetImageSubresourceLayout(Device, mappableImage, &subRes, &subResLayout);

                // Map image memory
                Util.CheckResult(vkMapMemory(Device, mappableMemory, 0, memReqs.size, 0, &data));

                // Copy image data into memory
                memcpy(data, tex2D[subRes.mipLevel].data(), tex2D[subRes.mipLevel].size());

                vkUnmapMemory(Device, mappableMemory);

                // Linear tiled images don't need to be staged
                // and can be directly used as textures
                texture.image = mappableImage;
                texture.DeviceMemory = mappableMemory;
                texture.imageLayout = VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL;

                VkCommandBuffer copyCmd = VulkanExampleBase::createCommandBuffer(VK_COMMAND_BUFFER_LEVEL_PRIMARY, true);

                // Setup image memory barrier transfer image to shader read layout

                // The sub resource range describes the regions of the image we will be transition
                VkImageSubresourceRange subresourceRange = { };
                // Image only contains color data
                subresourceRange.aspectMask = VK_IMAGE_ASPECT_COLOR_BIT;
                // Start at first mip level
                subresourceRange.baseMipLevel = 0;
                // Only one mip level, most implementations won't support more for linear tiled images
                subresourceRange.levelCount = 1;
                // The 2D texture only has one layer
                subresourceRange.layerCount = 1;

                setImageLayout(
                    copyCmd,
                    texture.image,
                    VK_IMAGE_ASPECT_COLOR_BIT,
                    VK_IMAGE_LAYOUT_PREINITIALIZED,
                    texture.imageLayout,
                    subresourceRange);

                VulkanExampleBase::flushCommandBuffer(copyCmd, queue, true);
                */
            }

            {
                // Create sampler
                // In Vulkan textures are accessed by samplers
                // This separates all the sampling information from the 
                // texture data
                // This means you could have multiple sampler objects
                // for the same texture with different settings
                // Similar to the samplers available with OpenGL 3.3
                var info = VkSamplerCreateInfo.Alloc();
                info[0].magFilter = VkFilter.Linear;
                info[0].minFilter = VkFilter.Linear;
                info[0].mipmapMode = VkSamplerMipmapMode.Linear;
                info[0].addressModeU = VkSamplerAddressMode.Repeat;
                info[0].addressModeV = VkSamplerAddressMode.Repeat;
                info[0].addressModeW = VkSamplerAddressMode.Repeat;
                info[0].mipLodBias = 0.0f;
                info[0].compareOp = VkCompareOp.Never;
                info[0].minLod = 0.0f;
                // Set max level-of-detail to mip level count of the texture
                info[0].maxLod = (useStaging == 1) ? (float)texture.mipLevels : 0.0f;
                // Enable anisotropic filtering
                // This feature is optional, so we must check if it's supported on the Device
                if (vulkanDevice.features.samplerAnisotropy == true) {
                    // Use max. level of anisotropy for this example
                    info[0].maxAnisotropy = vulkanDevice.properties.limits.maxSamplerAnisotropy;
                    info[0].anisotropyEnable = true;
                }
                else {
                    // The Device does not support anisotropic filtering
                    info[0].maxAnisotropy = 1.0f;
                    info[0].anisotropyEnable = false;
                }
                info[0].borderColor = VkBorderColor.FloatOpaqueWhite;
                {
                    VkSampler sampler;
                    vkCreateSampler(device, info, null, &sampler);
                    texture.sampler = sampler;
                }
            }
            {
                // Create image view
                // Textures are not directly accessed by the shaders and
                // are abstracted by image views containing additional
                // information and sub resource ranges
                var info = VkImageViewCreateInfo.Alloc();
                info[0].viewType = VkImageViewType._2d;//.Image2D;
                info[0].format = format;
                info[0].components = new VkComponentMapping { r = VkComponentSwizzle.R, g = VkComponentSwizzle.G, b = VkComponentSwizzle.B, a = VkComponentSwizzle.A };
                // The subresource range describes the set of mip levels (and array layers) that can be accessed through this image view
                // It's possible to create multiple image views for a single image referring to different (and/or overlapping) ranges of the image
                info[0].subresourceRange.aspectMask = VkImageAspectFlagBits.Color;
                info[0].subresourceRange.baseMipLevel = 0;
                info[0].subresourceRange.baseArrayLayer = 0;
                info[0].subresourceRange.layerCount = 1;
                // Linear tiling usually won't support mip maps
                // Only set mip map count if optimal tiling is used
                info[0].subresourceRange.levelCount = (useStaging == 1) ? texture.mipLevels : 1;
                // The view will be based on the texture's image
                info[0].image = texture.image;
                {
                    VkImageView view;
                    vkCreateImageView(device, info, null, &view);
                    texture.view = view;
                }
            }
        }

        // Free all Vulkan resources used a texture object
        void destroyTextureImage(Texture texture) {
            vkDestroyImageView(device, texture.view, null);
            vkDestroyImage(device, texture.image, null);
            vkDestroySampler(device, texture.sampler, null);
            vkFreeMemory(device, texture.DeviceMemory, null);
        }

        void loadTextures() {
            // Vulkan core supports three different compressed texture formats
            // As the support differs between implemementations we need to check Device features and select a proper format and file
            string filename;
            VkFormat format;
            if (DeviceFeatures.textureCompressionBC == true) {
                filename = "metalplate01_bc2_unorm.ktx";
                format = VkFormat.Bc2UnormBlock;
            }
            else if (DeviceFeatures.textureCompressionASTC_LDR == true) {
                filename = "metalplate01_astc_8x8_unorm.ktx";
                format = VkFormat.Astc8x8UnormBlock;
            }
            else if (DeviceFeatures.textureCompressionETC2 == true) {
                filename = "metalplate01_etc2_unorm.ktx";
                format = VkFormat.Etc2R8g8b8a8UnormBlock;
            }
            else {
                throw new InvalidOperationException("Device does not support any compressed texture format!");
            }

            loadTexture(getAssetPath() + "textures/" + filename, format, false);
        }

        protected override void buildCommandBuffers() {
            var cmdInfo = VkCommandBufferBeginInfo.Alloc();

            var clearValues = VkClearValue.Alloc(2);
            clearValues[0].color = defaultClearColor;
            clearValues[1].depthStencil = new VkClearDepthStencilValue() { depth = 1.0f, stencil = 0 };

            var info = VkRenderPassBeginInfo.Alloc();
            info[0].renderPass = renderPass;
            info[0].renderArea.offset.x = 0;
            info[0].renderArea.offset.y = 0;
            info[0].renderArea.extent.width = width;
            info[0].renderArea.extent.height = height;
            info[0].clearValueCount = 2;
            info[0].pClearValues = clearValues;

            for (int i = 0; i < drawCmdBuffers.Length; ++i) {
                // Set target frame buffer
                info[0].framebuffer = frameBuffers[i];

                vkBeginCommandBuffer(drawCmdBuffers[i], cmdInfo);

                vkCmdBeginRenderPass(drawCmdBuffers[i], info, VkSubpassContents.Inline);

                VkViewport viewport = new VkViewport((float)width, (float)height, 0.0f, 1.0f);
                vkCmdSetViewport(drawCmdBuffers[i], 0, 1, &viewport);

                VkRect2D scissor = new VkRect2D(0, 0, width, height);
                vkCmdSetScissor(drawCmdBuffers[i], 0, 1, &scissor);
                {
                    VkDescriptorSet set = descriptorSet;
                    vkCmdBindDescriptorSets(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, pipelineLayout,
                        0, 1, &set, 0, null);
                }
                vkCmdBindPipeline(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, pipeline);

                {
                    VkDeviceSize offsets = 0;
                    VkBuffer buffer = vertexBuffer.buffer;
                    vkCmdBindVertexBuffers(drawCmdBuffers[i], VERTEX_BUFFER_BIND_ID, 1,
                        &buffer, &offsets);
                }
                vkCmdBindIndexBuffer(drawCmdBuffers[i], indexBuffer.buffer, 0, VkIndexType.Uint32);

                vkCmdDrawIndexed(drawCmdBuffers[i], indexCount, 1, 0, 0, 0);

                vkCmdEndRenderPass(drawCmdBuffers[i]);

                vkEndCommandBuffer(drawCmdBuffers[i]);
            }
        }

        void draw() {
            base.prepareFrame();

            // Command buffer to be sumitted to the queue
            submitInfo[0].commandBufferCount = 1;
            var cmdBuffer = drawCmdBuffers[currentBuffer];
            submitInfo[0].pCommandBuffers = &cmdBuffer;

            // Submit to queue
            vkQueueSubmit(queue, 1, submitInfo, new VkFence());

            submitFrame();
        }

        void generateQuad() {
            // Setup vertices for a single uv-mapped quad made from two triangles
            var vertices = new Vertex[]
            {
                new Vertex() { pos = new Vector3(1.0f,  1.0f, 0.0f), uv = new Vector2(1.0f, 1.0f), normal = new Vector3(0.0f, 0.0f, 1.0f) },
                new Vertex() { pos = new Vector3(-1.0f,  1.0f, 0.0f), uv = new Vector2(0.0f, 1.0f), normal = new Vector3(0.0f, 0.0f, 1.0f) },
                new Vertex() { pos = new Vector3(-1.0f, -1.0f, 0.0f), uv = new Vector2(0.0f, 0.0f), normal = new Vector3(0.0f, 0.0f, 1.0f) },
                new Vertex() { pos = new Vector3(1.0f, -1.0f, 0.0f), uv = new Vector2(1.0f, 0.0f), normal = new Vector3(0.0f, 0.0f, 1.0f) },
            };

            // Setup indices
            var indices = new uint[] { 0, 1, 2, 2, 3, 0 };
            indexCount = (uint)indices.Length;

            // Create buffers
            // For the sake of simplicity we won't stage the vertex data to the gpu memory
            // Vertex buffer
            fixed (void* data = vertices) {
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.VertexBuffer,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                    vertexBuffer,
                    (ulong)(vertices.Length * sizeof(Vertex)),
                    data);
            }
            // Index buffer
            fixed (void* data = indices) {
                vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.IndexBuffer,
                VkMemoryPropertyFlagBits.HostCoherent | VkMemoryPropertyFlagBits.HostCoherent,
                indexBuffer,
                (ulong)(indices.Length * sizeof(uint)),
                data);
            }
        }

        void setupVertexDescriptions() {
            // Binding description
            vDescription.bindingDescriptions = VkVertexInputBindingDescription.Alloc();
            vDescription.bindingDescriptions[0].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.bindingDescriptions[0].stride = (uint)sizeof(Vertex);
            vDescription.bindingDescriptions[0].inputRate = VkVertexInputRate.Vertex;

            // Attribute descriptions
            // Describes memory layout and shader positions
            vDescription.attributeDescriptions = VkVertexInputAttributeDescription.Alloc(3);
            // Location 0 : Position
            vDescription.attributeDescriptions[0].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.attributeDescriptions[0].location = 0;
            vDescription.attributeDescriptions[0].format = VkFormat.R32g32b32Sfloat;
            vDescription.attributeDescriptions[0].offset = Vertex.PositionOffset;
            // Location 1 : Texture coordinates
            vDescription.attributeDescriptions[1].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.attributeDescriptions[1].location = 1;
            vDescription.attributeDescriptions[1].format = VkFormat.R32g32Sfloat;
            vDescription.attributeDescriptions[1].offset = Vertex.UvOffset;
            // Location 1 : Vertex normal
            vDescription.attributeDescriptions[2].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.attributeDescriptions[2].location = 2;
            vDescription.attributeDescriptions[2].format = VkFormat.R32g32b32Sfloat;
            vDescription.attributeDescriptions[2].offset = Vertex.NormalOffset;

            vDescription.inputState = VkPipelineVertexInputStateCreateInfo.Alloc();
            vDescription.inputState[0].vertexBindingDescriptionCount = 1;
            vDescription.inputState[0].pVertexBindingDescriptions = vDescription.bindingDescriptions;
            vDescription.inputState[0].vertexAttributeDescriptionCount = 3;
            vDescription.inputState[0].pVertexAttributeDescriptions = vDescription.attributeDescriptions;
        }

        void setupDescriptorPool() {
            // Example uses one ubo and one image sampler
            var poolSizes = new VkDescriptorPoolSize[2];
            poolSizes[0].type = VkDescriptorType.UniformBuffer;
            poolSizes[0].descriptorCount = 1;
            poolSizes[1].type = VkDescriptorType.CombinedImageSampler;
            poolSizes[1].descriptorCount = 1;

            var poolInfo = VkDescriptorPoolCreateInfo.Alloc();
            poolInfo[0].poolSizes = poolSizes;
            poolInfo[0].maxSets = 2;
            {
                VkDescriptorPool pool;
                vkCreateDescriptorPool(device, poolInfo, null, &pool);
                descriptorPool = pool;
            }
        }

        void setupDescriptorSetLayout() {
            var bindings = VkDescriptorSetLayoutBinding.Alloc(2);
            {
                // Binding 0 : Vertex shader uniform buffer
                bindings[0].binding = 0;
                bindings[0].descriptorType = VkDescriptorType.UniformBuffer;
                bindings[0].descriptorCount = 1;
                bindings[0].stageFlags = VkShaderStageFlagBits.Vertex;
                // Binding 1 : Fragment shader image sampler
                bindings[1].binding = 1;
                bindings[1].descriptorType = VkDescriptorType.CombinedImageSampler;
                bindings[1].descriptorCount = 1;
                bindings[1].stageFlags = VkShaderStageFlagBits.Fragment;
            }

            {
                var info = VkDescriptorSetLayoutCreateInfo.Alloc();
                info[0].bindings.count = 2;
                info[0].bindings.array = bindings;
                VkDescriptorSetLayout layout;
                vkCreateDescriptorSetLayout(device, info, null, &layout);
                this.layout = layout;
            }

            {
                VkDescriptorSetLayout layout = this.layout;
                var info = VkPipelineLayoutCreateInfo.Alloc();
                info[0].setLayoutCount = 1;
                info[0].pSetLayouts = &layout;
                VkPipelineLayout pipelineLayout;
                vkCreatePipelineLayout(device, info, null, &pipelineLayout);
                this.pipelineLayout = pipelineLayout;
            }
        }

        void setupDescriptorSet() {
            VkDescriptorSetLayout layout = this.layout;
            var allocInfo = VkDescriptorSetAllocateInfo.Alloc();
            allocInfo[0].descriptorPool = descriptorPool;
            allocInfo[0].setLayouts = layout;
            {
                VkDescriptorSet set;
                vkAllocateDescriptorSets(device, allocInfo, &set);
                this.descriptorSet = set;
            }

            // Setup a descriptor image info for the current texture to be used as a combined image sampler
            VkDescriptorImageInfo imageInfo;
            imageInfo.imageView = texture.view;             // The image's view (images are never directly accessed by the shader, but rather through views defining subresources)
            imageInfo.sampler = texture.sampler;            //  The sampler (Telling the pipeline how to sample the texture, including repeat, border, etc.)
            imageInfo.imageLayout = texture.imageLayout;    //  The current layout of the image (Note: Should always fit the actual use, e.g. shader read)

            VkDescriptorBufferInfo bufferInfo = uniformBufferVS.descriptor;
            var writes = VkWriteDescriptorSet.Alloc(2);
            {
                // Binding 0 : Vertex shader uniform buffer
                writes[0].dstSet = descriptorSet;
                writes[0].dstBinding = 0;
                writes[0].descriptorType = VkDescriptorType.UniformBuffer;
                writes[0].descriptorCount = 1;
                writes[0].pBufferInfo = &bufferInfo;
                // Binding 1 : Fragment shader texture sampler
                //  Fragment shader: layout (binding = 1) uniform sampler2D samplerColor;
                writes[1].dstSet = descriptorSet;
                writes[1].dstBinding = 1;
                writes[1].descriptorType = VkDescriptorType.CombinedImageSampler;
                writes[1].descriptorCount = 1;
                writes[1].pImageInfo = &imageInfo;
            }
            vkUpdateDescriptorSets(device, 2, writes, 0, null);
        }

        void preparePipelines() {
            var inputAssemblyState = VkPipelineInputAssemblyStateCreateInfo.Alloc();
            inputAssemblyState[0].topology = VkPrimitiveTopology.TriangleList;
            inputAssemblyState[0].primitiveRestartEnable = false;

            var rasterizationState = VkPipelineRasterizationStateCreateInfo.Alloc();
            rasterizationState[0].polygonMode = VkPolygonMode.Fill;
            rasterizationState[0].cullMode = VkCullModeFlagBits.None;
            rasterizationState[0].frontFace = VkFrontFace.CounterClockwise;
            rasterizationState[0].depthClampEnable = false;
            rasterizationState[0].lineWidth = 1.0f;

            var blendAttachmentState = VkPipelineColorBlendAttachmentState.Alloc();
            blendAttachmentState[0].colorWriteMask = (VkColorComponentFlagBits)0xf;
            blendAttachmentState[0].blendEnable = false;

            var colorBlendState = VkPipelineColorBlendStateCreateInfo.Alloc();
            colorBlendState[0].pAttachments = blendAttachmentState;
            colorBlendState[0].attachmentCount = 1;

            var depthStencilState = VkPipelineDepthStencilStateCreateInfo.Alloc();
            depthStencilState[0].depthTestEnable = true;
            depthStencilState[0].depthWriteEnable = true;
            depthStencilState[0].depthCompareOp = VkCompareOp.LessOrEqual;
            depthStencilState[0].front = depthStencilState[0].back;
            depthStencilState[0].back.compareOp = VkCompareOp.Always;

            var viewportState = VkPipelineViewportStateCreateInfo.Alloc();
            viewportState[0].viewportCount = 1;
            viewportState[0].scissorCount = 1;

            var multisampleState = VkPipelineMultisampleStateCreateInfo.Alloc();
            multisampleState[0].rasterizationSamples = VkSampleCountFlagBits._1;

            var dynamicStateEnables = new VkDynamicState[] {
                VkDynamicState.Viewport,
                VkDynamicState.Scissor
            };
            var dynamicState = VkPipelineDynamicStateCreateInfo.Alloc();
            dynamicStateEnables.Set(dynamicState);

            // Load shaders
            var shaderStages = VkPipelineShaderStageCreateInfo.Alloc(2);

            shaderStages[0] = loadShader(getAssetPath() + "shaders/texture/texture.vert.spv", VkShaderStageFlagBits.Vertex);
            shaderStages[1] = loadShader(getAssetPath() + "shaders/texture/texture.frag.spv", VkShaderStageFlagBits.Fragment);

            var pipelineCreateInfo = VkGraphicsPipelineCreateInfo.Alloc();
            pipelineCreateInfo[0].layout = pipelineLayout;
            pipelineCreateInfo[0].renderPass = renderPass;
            pipelineCreateInfo[0].basePipelineIndex = -1;

            var vertexInputState = vDescription.inputState;
            pipelineCreateInfo[0].pVertexInputState = vertexInputState;
            pipelineCreateInfo[0].pInputAssemblyState = inputAssemblyState;
            pipelineCreateInfo[0].pRasterizationState = rasterizationState;
            pipelineCreateInfo[0].pColorBlendState = colorBlendState;
            pipelineCreateInfo[0].pMultisampleState = multisampleState;
            pipelineCreateInfo[0].pViewportState = viewportState;
            pipelineCreateInfo[0].pDepthStencilState = depthStencilState;
            pipelineCreateInfo[0].pDynamicState = dynamicState;
            pipelineCreateInfo[0].stageCount = 2;
            pipelineCreateInfo[0].pStages = shaderStages;
            {
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, pipelineCreateInfo, null, &pipeline);
                this.pipeline = pipeline;
            }
        }

        // Prepare and initialize uniform buffer containing shader uniforms
        void prepareUniformBuffers() {
            var localUboVS = uboVS;
            // Vertex shader uniform buffer block
            vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                uniformBufferVS,
                (uint)sizeof(UboVS),
                &localUboVS);

            updateUniformBuffers();
        }

        void updateUniformBuffers() {
            // Vertex shader
            uboVS.projection = Matrix4x4.CreatePerspectiveFieldOfView(Util.DegreesToRadians(60f), width / (float)height, 0.1f, 256.0f);
            Matrix4x4 viewMatrix = Matrix4x4.CreateTranslation(new Vector3(0f, 0f, zoom));

            uboVS.model = viewMatrix * Matrix4x4.CreateTranslation(cameraPos);
            uboVS.model = Matrix4x4.CreateRotationX(Util.DegreesToRadians(rotation.X)) * uboVS.model;
            uboVS.model = Matrix4x4.CreateRotationY(Util.DegreesToRadians(rotation.Y)) * uboVS.model;
            uboVS.model = Matrix4x4.CreateRotationZ(Util.DegreesToRadians(rotation.Z)) * uboVS.model;

            uboVS.viewPos = new Vector4(0.0f, 0.0f, -zoom, 0.0f);

            uniformBufferVS.map();
            var local = uboVS;
            Unsafe.CopyBlock(uniformBufferVS.mapped, &local, (uint)sizeof(UboVS));
            uniformBufferVS.unmap();
        }



        public override void Init(Control canvas) {
            base.Init(canvas);
            loadTextures();
            generateQuad();
            setupVertexDescriptions();
            prepareUniformBuffers();
            setupDescriptorSetLayout();
            preparePipelines();
            setupDescriptorPool();
            setupDescriptorSet();
            buildCommandBuffers();

            prepared = true;
        }

        public override void Render() {
            if (!prepared)
                return;

            base.Render();
            draw();
        }

        protected override void viewChanged() {
            updateUniformBuffers();
        }

        void changeLodBias(float delta) {
            uboVS.lodBias += delta;
            if (uboVS.lodBias < 0.0f) {
                uboVS.lodBias = 0.0f;
            }
            if (uboVS.lodBias > texture.mipLevels) {
                uboVS.lodBias = (float)texture.mipLevels;
            }
            updateUniformBuffers();
            // updateTextOverlay();
        }

        protected void keyPressed(Keys keyCode) {
            switch (keyCode) {
                case Keys.Add:
                    changeLodBias(0.1f);
                    break;
                case Keys.OemMinus:
                    changeLodBias(-0.1f);
                    break;
            }
        }


    }
}
