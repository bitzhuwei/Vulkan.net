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

namespace Demo01.Texture {
    /// <summary>
    /// 
    /// </summary>
    public unsafe class TextureDemo : DemoBase {

        Texture texture;
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
        UboVS uboVS;
        VkPipeline pipeline;

        VkDescriptorSetLayout layout;
        VkDescriptorSet descriptorSet;
        VkPipelineLayout pipelineLayout;
        /// <summary>
        /// 0
        /// </summary>
        private const uint VERTEX_BUFFER_BIND_ID = 0;

        public TextureDemo() {
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
            VkImageMemoryBarrier barrier = new VkImageMemoryBarrier();
            barrier.sType = ImageMemoryBarrier;
            barrier.oldLayout = oldImageLayout;
            barrier.newLayout = newImageLayout;
            barrier.image = image;
            barrier.subresourceRange = subresourceRange;

            // Only sets masks for layouts used in this example
            // For a more complete version that can be used with other layouts see vks::tools::setImageLayout

            // Source layouts (old)
            switch (oldImageLayout) {
                case VkImageLayout.Undefined:
                    // Only valid as initial layout, memory contents are not preserved
                    // Can be accessed directly, no source dependency required
                    barrier.srcAccessMask = 0;
                    break;
                case VkImageLayout.Preinitialized:
                    // Only valid as initial layout for linear images, preserves memory contents
                    // Make sure host writes to the image have been finished
                    barrier.srcAccessMask = VkAccessFlagBits.HostWrite;
                    break;
                case VkImageLayout.TransferDstOptimal:
                    // Old layout is transfer destination
                    // Make sure any writes to the image have been finished
                    barrier.srcAccessMask = VkAccessFlagBits.TransferWrite;
                    break;
            }

            // Target layouts (new)
            switch (newImageLayout) {
                case VkImageLayout.TransferSrcOptimal:
                    // Transfer source (copy, blit)
                    // Make sure any reads from the image have been finished
                    barrier.dstAccessMask = VkAccessFlagBits.TransferRead;
                    break;
                case VkImageLayout.TransferDstOptimal:
                    // Transfer destination (copy, blit)
                    // Make sure any writes to the image have been finished
                    barrier.dstAccessMask = VkAccessFlagBits.TransferWrite;
                    break;
                case VkImageLayout.ShaderReadOnlyOptimal:
                    // Shader read (sampler, input attachment)
                    barrier.dstAccessMask = VkAccessFlagBits.ShaderRead;
                    break;
            }

            // Put barrier on top of pipeline
            var srcStageFlags = VkPipelineStageFlagBits.TopOfPipe;
            var destStageFlags = VkPipelineStageFlagBits.TopOfPipe;

            // Put barrier inside setup command buffer
            vkCmdPipelineBarrier(
                cmdBuffer,
                srcStageFlags,
                destStageFlags,
                0,
                0, null,
                0, null,
                1, &barrier);
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
                useStaging = ((formatProperties.linearTilingFeatures
                    & VkFormatFeatureFlagBits.SampledImage)
                    != VkFormatFeatureFlagBits.SampledImage) ? 1u : 0u;
            }

            VkMemoryAllocateInfo memAllocInfo = new VkMemoryAllocateInfo();
            memAllocInfo.sType = MemoryAllocateInfo;
            VkMemoryRequirements memReqs = new VkMemoryRequirements();

            if (useStaging == 1) {
                // Create a host-visible staging buffer that contains the raw image data
                VkBuffer stagingBuffer;
                VkDeviceMemory stagingMemory;

                VkBufferCreateInfo bufferCreateInfo = new VkBufferCreateInfo();
                bufferCreateInfo.sType = BufferCreateInfo;
                bufferCreateInfo.size = tex2D.GetTotalSize();
                // This buffer is used as a transfer source for the buffer copy
                bufferCreateInfo.usage = VkBufferUsageFlagBits.TransferSrc;
                bufferCreateInfo.sharingMode = VkSharingMode.Exclusive;

                vkCreateBuffer(device, &bufferCreateInfo, null, &stagingBuffer);

                // Get memory requirements for the staging buffer (alignment, memory type bits)
                vkGetBufferMemoryRequirements(device, stagingBuffer, &memReqs);

                memAllocInfo.allocationSize = memReqs.size;
                // Get memory type index for a host visible buffer
                memAllocInfo.memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);

                Util.CheckResult(vkAllocateMemory(device, &memAllocInfo, null, &stagingMemory));
                Util.CheckResult(vkBindBufferMemory(device, stagingBuffer, stagingMemory, 0));

                // Copy texture data into staging buffer
                IntPtr data;
                Util.CheckResult(vkMapMemory(device, stagingMemory, 0, memReqs.size, 0, &data));
                byte[] allData = tex2D.GetAllTextureData();
                fixed (byte* tex2DDataPtr = &allData[0]) {
                    Unsafe.CopyBlock(data, tex2DDataPtr, (uint)allData.Length);
                }
                vkUnmapMemory(device, stagingMemory);

                // Setup buffer copy regions for each mip level
                List<VkBufferImageCopy> bufferCopyRegions = new List<VkBufferImageCopy>();
                uint offset = 0;

                for (uint i = 0; i < texture.mipLevels; i++) {
                    VkBufferImageCopy bufferCopyRegion = new VkBufferImageCopy();
                    bufferCopyRegion.imageSubresource.aspectMask = VkImageAspectFlagBits.Color;
                    bufferCopyRegion.imageSubresource.mipLevel = i;
                    bufferCopyRegion.imageSubresource.baseArrayLayer = 0;
                    bufferCopyRegion.imageSubresource.layerCount = 1;
                    bufferCopyRegion.imageExtent.width = tex2D.Faces[0].Mipmaps[i].Width;
                    bufferCopyRegion.imageExtent.height = tex2D.Faces[0].Mipmaps[i].Height;
                    bufferCopyRegion.imageExtent.depth = 1;
                    bufferCopyRegion.bufferOffset = offset;

                    bufferCopyRegions.Add(bufferCopyRegion);

                    offset += tex2D.Faces[0].Mipmaps[i].SizeInBytes;
                }
                {
                    // Create optimal tiled target image
                    VkImageCreateInfo info = new VkImageCreateInfo();
                    info.sType = ImageCreateInfo;
                    info.imageType = VkImageType._2d;
                    info.format = format;
                    info.mipLevels = texture.mipLevels;
                    info.arrayLayers = 1;
                    info.samples = VkSampleCountFlagBits._1;
                    info.tiling = VkImageTiling.Optimal;
                    info.sharingMode = VkSharingMode.Exclusive;
                    // Set initial layout of the image to undefined
                    info.initialLayout = VkImageLayout.Undefined;
                    info.extent = new VkExtent3D { width = texture.width, height = texture.height, depth = 1 };
                    info.usage = VkImageUsageFlagBits.TransferDst | VkImageUsageFlagBits.Sampled;

                    {
                        VkImage image;
                        vkCreateImage(device, &info, null, &image);
                        texture.image = image;
                    }
                    vkGetImageMemoryRequirements(device, texture.image, &memReqs);

                    memAllocInfo.allocationSize = memReqs.size;
                    memAllocInfo.memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits,
                        VkMemoryPropertyFlagBits.DeviceLocal);

                    {
                        VkDeviceMemory memory;
                        vkAllocateMemory(device, &memAllocInfo, null, &memory);
                        texture.DeviceMemory = memory;
                    }
                    vkBindImageMemory(device, texture.image, texture.DeviceMemory, 0);
                }
                VkCommandBuffer copyCmd = base.createCommandBuffer(VkCommandBufferLevel.Primary, true);

                // Image barrier for optimal image

                // The sub resource range describes the regions of the image we will be transition
                VkImageSubresourceRange subresourceRange = new VkImageSubresourceRange();
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
                fixed (VkBufferImageCopy* pointer = bufferCopyRegions.ToArray()) {
                    vkCmdCopyBufferToImage(
                        copyCmd,
                        stagingBuffer,
                        texture.image,
                        VkImageLayout.TransferDstOptimal,
                        (UInt32)bufferCopyRegions.Count,
                        pointer);
                }

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
                //throw new NotImplementedException();

                // Prefer using optimal tiling, as linear tiling 
                // may support only a small set of features 
                // depending on implementation (e.g. no mip maps, only one layer, etc.)

                VkImage mappableImage;
                VkDeviceMemory mappableMemory;

                // Load mip map level 0 to linear tiling image
                VkImageCreateInfo imageCreateInfo = new VkImageCreateInfo();
                imageCreateInfo.sType = ImageCreateInfo;
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
                vkCreateImage(device, &imageCreateInfo, null, &mappableImage);

                // Get memory requirements for this image 
                // like size and alignment
                vkGetImageMemoryRequirements(device, mappableImage, &memReqs);
                // Set memory allocation size to required memory size
                memAllocInfo.allocationSize = memReqs.size;

                // Get memory type that can be mapped to host memory
                memAllocInfo.memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);

                // Allocate host memory
                Util.CheckResult(vkAllocateMemory(device, &memAllocInfo, null, &mappableMemory));

                // Bind allocated image for use
                Util.CheckResult(vkBindImageMemory(device, mappableImage, mappableMemory, 0));

                // Get sub resource layout
                // Mip map count, array layer, etc.
                VkImageSubresource subRes = new VkImageSubresource();
                subRes.aspectMask = VkImageAspectFlagBits.Color;

                VkSubresourceLayout subResLayout;

                // Get sub resources layout 
                // Includes row pitch, size offsets, etc.
                vkGetImageSubresourceLayout(device, mappableImage, &subRes, &subResLayout);

                IntPtr data;
                // Map image memory
                vkMapMemory(device, mappableMemory, 0, memReqs.size, 0, &data);

                // Copy image data into memory
                //memcpy(data, tex2D[subRes.mipLevel].data(), tex2D[subRes.mipLevel].size());
                byte[] allData = tex2D.GetAllTextureData();
                fixed (byte* tex2DDataPtr = &allData[0]) {
                    Unsafe.CopyBlock(data, tex2DDataPtr, (uint)allData.Length);
                }

                vkUnmapMemory(device, mappableMemory);

                // Linear tiled images don't need to be staged
                // and can be directly used as textures
                texture.image = mappableImage;
                texture.DeviceMemory = mappableMemory;
                texture.imageLayout = VkImageLayout.ShaderReadOnlyOptimal;

                VkCommandBuffer copyCmd = base.createCommandBuffer(VkCommandBufferLevel.Primary, true);

                // Setup image memory barrier transfer image to shader read layout

                // The sub resource range describes the regions of the image we will be transition
                VkImageSubresourceRange subresourceRange = new VkImageSubresourceRange();
                // Image only contains color data
                subresourceRange.aspectMask = VkImageAspectFlagBits.Color;
                // Start at first mip level
                subresourceRange.baseMipLevel = 0;
                // Only one mip level, most implementations won't support more for linear tiled images
                subresourceRange.levelCount = 1;
                // The 2D texture only has one layer
                subresourceRange.layerCount = 1;

                setImageLayout(
                    copyCmd,
                    texture.image,
                    VkImageAspectFlagBits.Color,
                    VkImageLayout.Preinitialized,
                    texture.imageLayout,
                    subresourceRange);

                base.flushCommandBuffer(copyCmd, queue, true);
            }

            {
                // Create sampler
                // In Vulkan textures are accessed by samplers
                // This separates all the sampling information from the 
                // texture data
                // This means you could have multiple sampler objects
                // for the same texture with different settings
                // Similar to the samplers available with OpenGL 3.3
                VkSamplerCreateInfo info = new VkSamplerCreateInfo();
                info.sType = SamplerCreateInfo;
                info.magFilter = VkFilter.Linear;
                info.minFilter = VkFilter.Linear;
                info.mipmapMode = VkSamplerMipmapMode.Linear;
                info.addressModeU = VkSamplerAddressMode.Repeat;
                info.addressModeV = VkSamplerAddressMode.Repeat;
                info.addressModeW = VkSamplerAddressMode.Repeat;
                info.mipLodBias = 0.0f;
                info.compareOp = VkCompareOp.Never;
                info.minLod = 0.0f;
                // Set max level-of-detail to mip level count of the texture
                info.maxLod = (useStaging == 1) ? (float)texture.mipLevels : 0.0f;
                // Enable anisotropic filtering
                // This feature is optional, so we must check if it's supported on the Device
                if (vulkanDevice.features.samplerAnisotropy == true) {
                    // Use max. level of anisotropy for this example
                    info.maxAnisotropy = vulkanDevice.properties.limits.maxSamplerAnisotropy;
                    info.anisotropyEnable = true;
                }
                else {
                    // The Device does not support anisotropic filtering
                    info.maxAnisotropy = 1.0f;
                    info.anisotropyEnable = false;
                }
                info.borderColor = VkBorderColor.FloatOpaqueWhite;
                {
                    VkSampler sampler;
                    vkCreateSampler(device, &info, null, &sampler);
                    texture.sampler = sampler;
                }
            }
            {
                // Create image view
                // Textures are not directly accessed by the shaders and
                // are abstracted by image views containing additional
                // information and sub resource ranges
                VkImageViewCreateInfo info = new VkImageViewCreateInfo();
                info.sType = ImageViewCreateInfo;
                info.viewType = VkImageViewType._2d;
                info.format = format;
                info.components = new VkComponentMapping {
                    r = VkComponentSwizzle.R,
                    g = VkComponentSwizzle.G,
                    b = VkComponentSwizzle.B,
                    a = VkComponentSwizzle.A
                };
                // The subresource range describes the set of mip levels (and array layers) that can be accessed through this image view
                // It's possible to create multiple image views for a single image referring to different (and/or overlapping) ranges of the image
                info.subresourceRange.aspectMask = VkImageAspectFlagBits.Color;
                info.subresourceRange.baseMipLevel = 0;
                info.subresourceRange.baseArrayLayer = 0;
                info.subresourceRange.layerCount = 1;
                // Linear tiling usually won't support mip maps
                // Only set mip map count if optimal tiling is used
                info.subresourceRange.levelCount = (useStaging == 1) ? texture.mipLevels : 1;
                // The view will be based on the texture's image
                info.image = texture.image;
                {
                    VkImageView view;
                    vkCreateImageView(device, &info, null, &view);
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

            string fullname = getAssetPath() + "textures/" + filename;
            loadTexture(fullname, format, false);
        }

        protected override void buildCommandBuffers() {
            VkCommandBufferBeginInfo cmdBufInfo = new VkCommandBufferBeginInfo();
            cmdBufInfo.sType = CommandBufferBeginInfo;

            var clearValues = new VkClearValue[2];
            clearValues[0].color = defaultClearColor;
            clearValues[1].depthStencil = new VkClearDepthStencilValue() { depth = 1.0f, stencil = 0 };

            VkRenderPassBeginInfo renderPassBeginInfo = new VkRenderPassBeginInfo();
            renderPassBeginInfo.sType = RenderPassBeginInfo;
            renderPassBeginInfo.renderPass = renderPass;
            renderPassBeginInfo.renderArea.offset.x = 0;
            renderPassBeginInfo.renderArea.offset.y = 0;
            renderPassBeginInfo.renderArea.extent.width = width;
            renderPassBeginInfo.renderArea.extent.height = height;
            //renderPassBeginInfo.clearValueCount = 2;
            //renderPassBeginInfo.pClearValues = (VkClearValue*)Unsafe.AsPointer(ref clearValues);
            {
                IntPtr ptr = IntPtr.Zero;
                clearValues.Set(ref ptr, ref renderPassBeginInfo.clearValueCount);
                renderPassBeginInfo.pClearValues = (VkClearValue*)ptr;
            }

            for (int i = 0; i < drawCmdBuffers.Length; ++i) {
                // Set target frame buffer
                renderPassBeginInfo.framebuffer = frameBuffers[i];

                Util.CheckResult(vkBeginCommandBuffer(drawCmdBuffers[i], &cmdBufInfo));

                vkCmdBeginRenderPass(drawCmdBuffers[i], &renderPassBeginInfo, VkSubpassContents.Inline);

                VkViewport viewport = new VkViewport();
                viewport.width = width; viewport.height = height; viewport.minDepth = 0.0f; viewport.maxDepth = 1.0f;
                vkCmdSetViewport(drawCmdBuffers[i], 0, 1, &viewport);

                VkRect2D scissor = new VkRect2D();
                scissor.extent.width = width; scissor.extent.height = height;
                scissor.offset.x = 0; scissor.offset.y = 0;
                vkCmdSetScissor(drawCmdBuffers[i], 0, 1, &scissor);

                VkDescriptorSet set = this.descriptorSet;
                vkCmdBindDescriptorSets(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, pipelineLayout, 0, 1, &set, 0, null);
                vkCmdBindPipeline(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, pipeline);

                VkDeviceSize offsets = 0;
                VkBuffer buffer = vertexBuffer.buffer;
                vkCmdBindVertexBuffers(drawCmdBuffers[i], VERTEX_BUFFER_BIND_ID, 1, &buffer, &offsets);
                vkCmdBindIndexBuffer(drawCmdBuffers[i], indexBuffer.buffer, 0, VkIndexType.Uint32);

                vkCmdDrawIndexed(drawCmdBuffers[i], indexCount, 1, 0, 0, 0);

                vkCmdEndRenderPass(drawCmdBuffers[i]);

                Util.CheckResult(vkEndCommandBuffer(drawCmdBuffers[i]));
            }
        }

        void draw() {
            base.prepareFrame();

            // Command buffer to be sumitted to the queue
            submitInfo.commandBufferCount = 1;
            VkCommandBuffer buffer = drawCmdBuffers[currentBuffer];
            submitInfo.pCommandBuffers = &buffer;

            VkSubmitInfo info = submitInfo;
            // Submit to queue
            vkQueueSubmit(queue, 1, &info, new VkFence());

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
            indexCount = (UInt32)indices.Length;

            // Create buffers
            // For the sake of simplicity we won't stage the vertex data to the gpu memory
            // Vertex buffer
            fixed (void* data = vertices) {
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.VertexBuffer,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                    vertexBuffer,
                    (UInt64)(vertices.Length * sizeof(Vertex)),
                    data);
            }
            // Index buffer
            fixed (void* data = indices) {
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.IndexBuffer,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                    indexBuffer,
                    (UInt64)indices.Length * sizeof(uint),
                    data);
            }
        }

        void setupVertexDescriptions() {
            // Binding description
            //vDescription.bindingDescriptions.Count = 1;
            vDescription.bindingDescriptions = new VkVertexInputBindingDescription[1];
            vDescription.bindingDescriptions[0] = new VkVertexInputBindingDescription();
            vDescription.bindingDescriptions[0].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.bindingDescriptions[0].stride = (uint)sizeof(Vertex);
            vDescription.bindingDescriptions[0].inputRate = VkVertexInputRate.Vertex;

            // Attribute descriptions
            // Describes memory layout and shader positions
            vDescription.attributeDescriptions = new VkVertexInputAttributeDescription[3];
            // Location 0 : Position
            vDescription.attributeDescriptions[0] = new VkVertexInputAttributeDescription();
            vDescription.attributeDescriptions[0].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.attributeDescriptions[0].location = 0;
            vDescription.attributeDescriptions[0].format = VkFormat.R32g32b32Sfloat;
            vDescription.attributeDescriptions[0].binding = Vertex.PositionOffset;
            // Location 1 : Texture coordinates
            vDescription.attributeDescriptions[1].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.attributeDescriptions[1].location = 1;
            vDescription.attributeDescriptions[1].format = VkFormat.R32g32Sfloat;
            vDescription.attributeDescriptions[1].binding = Vertex.UvOffset;
            // Location 2 : Vertex normal
            vDescription.attributeDescriptions[2].binding = VERTEX_BUFFER_BIND_ID;
            vDescription.attributeDescriptions[2].location = 2;
            vDescription.attributeDescriptions[2].format = VkFormat.R32g32b32Sfloat;
            vDescription.attributeDescriptions[2].binding = Vertex.NormalOffset;

            vDescription.inputState = new VkPipelineVertexInputStateCreateInfo();
            vDescription.inputState.sType = PipelineVertexInputStateCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                vDescription.bindingDescriptions.Set(ref ptr, ref vDescription.inputState.vertexBindingDescriptionCount);
                vDescription.inputState.pVertexBindingDescriptions = (VkVertexInputBindingDescription*)ptr;
            }
            {
                IntPtr ptr = IntPtr.Zero;
                vDescription.attributeDescriptions.Set(ref ptr, ref vDescription.inputState.vertexAttributeDescriptionCount);
                vDescription.inputState.pVertexAttributeDescriptions = (VkVertexInputAttributeDescription*)ptr;
            }
        }

        void setupDescriptorPool() {
            // Example uses one ubo and one image sampler
            var poolSizes = new VkDescriptorPoolSize[2];
            poolSizes[0] = new VkDescriptorPoolSize();
            poolSizes[0].type = VkDescriptorType.UniformBuffer;
            poolSizes[0].descriptorCount = 1;
            poolSizes[1].type = VkDescriptorType.CombinedImageSampler;
            poolSizes[1].descriptorCount = 1;

            VkDescriptorPoolCreateInfo descriptorPoolInfo = new VkDescriptorPoolCreateInfo();
            descriptorPoolInfo.sType = DescriptorPoolCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                poolSizes.Set(ref ptr, ref descriptorPoolInfo.poolSizeCount);
                descriptorPoolInfo.pPoolSizes = (VkDescriptorPoolSize*)ptr;
            }
            descriptorPoolInfo.maxSets = 2;

            VkDescriptorPool pool;
            vkCreateDescriptorPool(device, &descriptorPoolInfo, null, &pool);
            this.descriptorPool = pool;
        }

        void setupDescriptorSetLayout() {
            var bindings = new VkDescriptorSetLayoutBinding[2];
            // Binding 0 : Vertex shader uniform buffer
            bindings[0].descriptorType = VkDescriptorType.UniformBuffer;
            bindings[0].stageFlags = VkShaderStageFlagBits.Vertex;
            bindings[0].binding = 0;
            bindings[0].descriptorCount = 1;
            // Binding 1 : Fragment shader image sampler
            bindings[1].descriptorType = VkDescriptorType.CombinedImageSampler;
            bindings[1].stageFlags = VkShaderStageFlagBits.Fragment;
            bindings[1].binding = 1;
            bindings[1].descriptorCount = 1;

            VkDescriptorSetLayoutCreateInfo info = new VkDescriptorSetLayoutCreateInfo();
            info.sType = DescriptorSetLayoutCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                bindings.Set(ref ptr, ref info.bindingCount);
                info.pBindings = (VkDescriptorSetLayoutBinding*)ptr;
            }

            VkDescriptorSetLayout dslayout;
            vkCreateDescriptorSetLayout(device, &info, null, &dslayout);
            this.layout = dslayout;

            VkPipelineLayoutCreateInfo pPipelineLayoutCreateInfo = new VkPipelineLayoutCreateInfo();
            pPipelineLayoutCreateInfo.sType = PipelineLayoutCreateInfo;
            pPipelineLayoutCreateInfo.pSetLayouts = &dslayout;
            pPipelineLayoutCreateInfo.setLayoutCount = 1;

            VkPipelineLayout pipelineLayout;
            vkCreatePipelineLayout(device, &pPipelineLayoutCreateInfo, null, &pipelineLayout);
            this.pipelineLayout = pipelineLayout;
        }

        void setupDescriptorSet() {
            VkDescriptorSetLayout layout = this.layout;
            VkDescriptorSetAllocateInfo allocInfo = new VkDescriptorSetAllocateInfo();
            allocInfo.sType = DescriptorSetAllocateInfo;
            allocInfo.descriptorPool = descriptorPool;
            allocInfo.pSetLayouts = &layout;
            allocInfo.descriptorSetCount = 1;

            VkDescriptorSet set;
            vkAllocateDescriptorSets(device, &allocInfo, &set);
            this.descriptorSet = set;

            // Setup a descriptor image info for the current texture to be used as a combined image sampler
            VkDescriptorImageInfo info;
            info.imageView = texture.view;             // The image's view (images are never directly accessed by the shader, but rather through views defining subresources)
            info.sampler = texture.sampler;            //  The sampler (Telling the pipeline how to sample the texture, including repeat, border, etc.)
            info.imageLayout = texture.imageLayout;    //  The current layout of the image (Note: Should always fit the actual use, e.g. shader read)

            VkDescriptorBufferInfo descriptor = uniformBufferVS.descriptor;
            var writeDescriptorSets = new VkWriteDescriptorSet[2];
            // Binding 0 : Vertex shader uniform buffer
            writeDescriptorSets[0].sType = WriteDescriptorSet;
            writeDescriptorSets[0].dstSet = descriptorSet;
            writeDescriptorSets[0].descriptorType = VkDescriptorType.UniformBuffer;
            writeDescriptorSets[0].dstBinding = 0;
            writeDescriptorSets[0].pBufferInfo = &descriptor;
            writeDescriptorSets[0].descriptorCount = 1;
            // Binding 1 : Fragment shader texture sampler
            //  Fragment shader: layout (binding = 1) uniform sampler2D samplerColor;
            writeDescriptorSets[1].sType = WriteDescriptorSet;
            writeDescriptorSets[1].dstSet = descriptorSet;
            // The descriptor set will use a combined image sampler (sampler and image could be split)
            writeDescriptorSets[1].descriptorType = VkDescriptorType.CombinedImageSampler;
            // Shader binding point 1
            writeDescriptorSets[1].dstBinding = 1;
            // Pointer to the descriptor image for our texture
            writeDescriptorSets[1].pImageInfo = &info;
            writeDescriptorSets[1].descriptorCount = 1;

            fixed (VkWriteDescriptorSet* pointer = writeDescriptorSets) {
                vkUpdateDescriptorSets(device, (UInt32)writeDescriptorSets.Length, pointer, 0, null);
            }
        }

        void preparePipelines() {
            VkPipelineInputAssemblyStateCreateInfo inputAssemblyState = new VkPipelineInputAssemblyStateCreateInfo();
            inputAssemblyState.sType = PipelineInputAssemblyStateCreateInfo;
            inputAssemblyState.topology = VkPrimitiveTopology.TriangleList;
            inputAssemblyState.flags = 0;
            inputAssemblyState.primitiveRestartEnable = false;

            VkPipelineRasterizationStateCreateInfo rasterizationState = new VkPipelineRasterizationStateCreateInfo();
            rasterizationState.sType = PipelineRasterizationStateCreateInfo;
            rasterizationState.polygonMode = VkPolygonMode.Fill;
            rasterizationState.cullMode = VkCullModeFlagBits.None;
            rasterizationState.frontFace = VkFrontFace.CounterClockwise;
            rasterizationState.flags = 0;

            VkPipelineColorBlendAttachmentState blendAttachmentState = new VkPipelineColorBlendAttachmentState();
            blendAttachmentState.colorWriteMask = (VkColorComponentFlagBits)0xf;
            blendAttachmentState.blendEnable = false;

            VkPipelineColorBlendStateCreateInfo colorBlendState = new VkPipelineColorBlendStateCreateInfo();
            colorBlendState.sType = PipelineColorBlendStateCreateInfo;
            colorBlendState.pAttachments = &blendAttachmentState;
            colorBlendState.attachmentCount = 1;

            VkPipelineDepthStencilStateCreateInfo depthStencilState = new VkPipelineDepthStencilStateCreateInfo();
            depthStencilState.sType = PipelineDepthStencilStateCreateInfo;
            depthStencilState.depthTestEnable = true;
            depthStencilState.depthWriteEnable = true;
            depthStencilState.depthCompareOp = VkCompareOp.LessOrEqual;

            VkPipelineViewportStateCreateInfo viewportState = new VkPipelineViewportStateCreateInfo();
            viewportState.sType = PipelineViewportStateCreateInfo;
            viewportState.viewportCount = 1;
            viewportState.scissorCount = 1;
            viewportState.flags = 0;

            VkPipelineMultisampleStateCreateInfo multisampleState = new VkPipelineMultisampleStateCreateInfo();
            multisampleState.sType = PipelineMultisampleStateCreateInfo;
            multisampleState.rasterizationSamples = VkSampleCountFlagBits._1;
            multisampleState.flags = 0;

            var dynamicStateEnables = new VkDynamicState[2];
            dynamicStateEnables[0] = VkDynamicState.Viewport;
            dynamicStateEnables[1] = VkDynamicState.Scissor;
            VkPipelineDynamicStateCreateInfo dynamicState = new VkPipelineDynamicStateCreateInfo();
            dynamicState.sType = PipelineDynamicStateCreateInfo;
            dynamicState.flags = 0;
            {
                IntPtr ptr = IntPtr.Zero;
                dynamicStateEnables.Set(ref ptr, ref dynamicState.dynamicStateCount);
                dynamicState.pDynamicStates = (VkDynamicState*)ptr;
            }

            // Load shaders
            var shaderStages = new VkPipelineShaderStageCreateInfo[2];
            string vertName = getAssetPath() + "shaders/texture/texture.vert.spv";
            shaderStages[0] = loadShader(vertName, VkShaderStageFlagBits.Vertex);
            string fragName = getAssetPath() + "shaders/texture/texture.frag.spv";
            shaderStages[1] = loadShader(fragName, VkShaderStageFlagBits.Fragment);

            VkGraphicsPipelineCreateInfo pipelineCreateInfo = new VkGraphicsPipelineCreateInfo();
            pipelineCreateInfo.sType = GraphicsPipelineCreateInfo;
            pipelineCreateInfo.layout = pipelineLayout;
            pipelineCreateInfo.renderPass = renderPass;
            pipelineCreateInfo.flags = 0;

            var vertexInputState = vDescription.inputState;
            pipelineCreateInfo.pVertexInputState = &vertexInputState;
            pipelineCreateInfo.pInputAssemblyState = &inputAssemblyState;
            pipelineCreateInfo.pRasterizationState = &rasterizationState;
            pipelineCreateInfo.pColorBlendState = &colorBlendState;
            pipelineCreateInfo.pMultisampleState = &multisampleState;
            pipelineCreateInfo.pViewportState = &viewportState;
            pipelineCreateInfo.pDepthStencilState = &depthStencilState;
            pipelineCreateInfo.pDynamicState = &dynamicState;
            {
                IntPtr ptr = IntPtr.Zero;
                shaderStages.Set(ref ptr, ref pipelineCreateInfo.stageCount);
                pipelineCreateInfo.pStages = (VkPipelineShaderStageCreateInfo*)ptr;
            }

            VkPipeline pipeline;
            vkCreateGraphicsPipelines(device, pipelineCache, 1, &pipelineCreateInfo, null, &pipeline);
            this.pipeline = pipeline;
        }

        // Prepare and initialize uniform buffer containing shader uniforms
        void prepareUniformBuffers() {
            var localUboVS = uboVS;
            // Vertex shader uniform buffer block
            Util.CheckResult(vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                uniformBufferVS,
                (uint)sizeof(UboVS),
                &localUboVS));

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

            Util.CheckResult(uniformBufferVS.map());
            var local = uboVS;
            Unsafe.CopyBlock(uniformBufferVS.mapped, &local, (uint)sizeof(UboVS));
            uniformBufferVS.unmap();
        }


        public override void Prepare() {
            base.Prepare();
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

        protected override void render() {
            if (!prepared)
                return;

            base.render();
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

        //protected override void keyPressed(Key keyCode) {
        //    switch (keyCode) {
        //        case Key.KeypadAdd:
        //            changeLodBias(0.1f);
        //            break;
        //        case Key.KeypadSubtract:
        //            changeLodBias(-0.1f);
        //            break;
        //    }
        //}

        /*
        virtual void getOverlayText(VulkanTextOverlay* textOverlay)
        {
            std::stringstream ss;
            ss << std::setprecision(2) << std::fixed << uboVS.lodBias;
            textOverlay->addText("LOD bias: " + ss.str() + " (numpad +/- to change)", 5.0f, 85.0f, VulkanTextOverlay::alignLeft);
        }
        */


    }
}
