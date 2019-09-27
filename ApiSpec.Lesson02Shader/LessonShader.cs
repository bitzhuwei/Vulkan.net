using System;
using System.Linq;
using System.Runtime.InteropServices;
using Vulkan;
using static Vulkan.VkStructureType;

namespace ApiSpec.Lesson02Shader {
    unsafe class LessonShader {
        VkInstance vkIntance;
        VkSurfaceKHR vkSurface;
        VkPhysicalDevice vkPhysicalDevice;

        VkDevice vkDevice;
        VkQueue vkQueue;
        VkSwapchainKHR vkSwapchain;
        VkImage[] vkImages;
        VkRenderPass vkRenderPass;
        VkFramebuffer[] vkFramebuffers;
        VkFence vkFence;
        VkSemaphore vkSemaphore;
        //
        VkBuffer vkUniformBuffer;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s.
        /// </summary>
        VkDescriptorSetLayout vkDescriptorSetLayout;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s and <see cref="VkPushConstantRange"/>s.
        /// </summary>
        VkPipelineLayout vkPipelineLayout;
        VkDescriptorSet vkDescriptorSet;

        VkCommandBuffer[] vkCommandBuffers;

        VkBuffer vkBuffer;
        VkDeviceMemory vkDeviceMemory;
        VkDeviceSize uniformSize;

        bool isInitialized = false;

        private float originalWidth;
        private float originalHeight;
        private float width;
        private float height;

        public void UpdateSize() {
            if (width == originalWidth) {
                width = originalWidth / 2;
            }
            else {
                width = originalWidth;
            }
            var uniformBufferData = new AreaUniformBuffer(width, height);
            var length = 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AreaUniformBuffer)) * length;
            VkDevice device = this.vkDevice; VkDeviceMemory deviceMemory = this.vkDeviceMemory;
            {
                IntPtr memPtr = IntPtr.Zero;
                vkAPI.vkMapMemory(device, deviceMemory, new VkDeviceSize(), new VkDeviceSize((UInt64)size), 0, &memPtr);

                System.Runtime.InteropServices.Marshal.StructureToPtr(uniformBufferData, memPtr, false);
                //GCHandle pin = GCHandle.Alloc(uniformBufferData, GCHandleType.Pinned);
                //IntPtr address = pin.AddrOfPinnedObject();
                //var src = (byte*)address;
                //var dst = (byte*)memPtr;
                //for (int i = 0; i < size; i++) {
                //    dst[i] = src[i];
                //}
                //pin.Free();

                //// Flush to make changes visible to the host 
                //var memoryRange = new VkMappedMemoryRange();
                //{
                //    memoryRange.sType = VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE;
                //    memoryRange.memory = deviceMemory;
                //    memoryRange.size = this.uniformSize;
                //}

                //vkAPI.vkFlushMappedMemoryRanges(device, 1, &memoryRange);
                vkAPI.vkUnmapMemory(device, deviceMemory);
            }
        }
        public void Init(IntPtr hwnd, IntPtr processHandle) {
            if (this.isInitialized) { return; }

            this.vkIntance = InitInstance();
            this.vkSurface = InitSurface(this.vkIntance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice(this.vkIntance);
            VkSurfaceFormatKHR surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.vkSurface);


            this.vkDevice = CreateDevice(this.vkPhysicalDevice, this.vkSurface);

            this.vkQueue = this.vkDevice.GetQueue(0, 0);

            VkSurfaceCapabilitiesKHR surfaceCapabilities;
            //this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);
            vkAPI.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.vkPhysicalDevice, this.vkSurface, &surfaceCapabilities).Check();

            this.vkSwapchain = CreateSwapchain(this.vkDevice, this.vkSurface, surfaceFormat, surfaceCapabilities);

            this.vkImages = this.vkDevice.GetSwapchainImages(this.vkSwapchain);

            this.vkRenderPass = CreateRenderPass(this.vkDevice, surfaceFormat);

            this.vkFramebuffers = CreateFramebuffers(this.vkDevice, this.vkImages, surfaceFormat, this.vkRenderPass, surfaceCapabilities);

            this.vkFence = this.vkDevice.CreateFence();
            this.vkSemaphore = this.vkDevice.CreateSemaphore();

            // buffers for vertex data.
            VkBuffer vertexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Vertices, VkBufferUsageFlagBits.VertexBuffer, typeof(float));

            VkBuffer indexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Indexes, VkBufferUsageFlagBits.IndexBuffer, typeof(short));

            var uniformBufferData = new AreaUniformBuffer(40, 50);
            this.originalWidth = 40; this.width = this.originalWidth;
            this.originalHeight = 50; this.height = this.originalHeight;

            this.vkUniformBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, uniformBufferData, VkBufferUsageFlagBits.UniformBuffer, typeof(AreaUniformBuffer));

            this.vkDescriptorSetLayout = CreateDescriptorSetLayout(this.vkDevice);

            this.vkPipelineLayout = CreatePipelineLayout(this.vkDevice, this.vkDescriptorSetLayout);

            var pipelines = CreatePipelines(this.vkDevice, surfaceCapabilities, this.vkRenderPass, this.vkPipelineLayout);

            this.vkDescriptorSet = CreateDescriptorSet(this.vkDevice, this.vkDescriptorSetLayout);

            UpdateDescriptorSets(this.vkDevice, this.vkUniformBuffer, this.vkDescriptorSet);

            this.vkCommandBuffers = CreateCommandBuffers(
                this.vkDevice, this.vkRenderPass, surfaceCapabilities,
                this.vkImages, this.vkFramebuffers, pipelines[0],
                vertexBuffer, indexBuffer, (uint)Logo.Indexes.Length,
                this.vkPipelineLayout, this.vkDescriptorSet);

            this.isInitialized = true;
        }

        VkCommandBuffer[] CreateCommandBuffers(
            VkDevice device, VkRenderPass renderPass, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkImage[] images, VkFramebuffer[] framebuffers, VkPipeline pipeline,
            VkBuffer vertexBuffer, VkBuffer indexBuffer, uint indexLength,
            VkPipelineLayout pipelineLayout, VkDescriptorSet descriptorSet) {
            VkCommandBuffer[] buffers;
            {
                VkCommandPool pool;
                {
                    var info = new VkCommandPoolCreateInfo {
                        sType = CommandPoolCreateInfo,
                        flags = VkCommandPoolCreateFlagBits.ResetCommandBuffer
                    };
                    //var commandPool = device.CreateCommandPool(ref poolInfo);
                    vkAPI.vkCreateCommandPool(device, &info, null, &pool).Check();
                }
                {
                    var info = new VkCommandBufferAllocateInfo {
                        sType = CommandBufferAllocateInfo,
                        level = VkCommandBufferLevel.Primary,
                        commandPool = pool,
                        commandBufferCount = (uint)images.Length
                    };
                    //buffers = device.AllocateCommandBuffers(ref info);
                    buffers = new VkCommandBuffer[info.commandBufferCount];
                    fixed (VkCommandBuffer* pointer = buffers) {
                        vkAPI.vkAllocateCommandBuffers(device, &info, pointer).Check();
                    }
                }
            }

            var cmdBeginInfo = new VkCommandBufferBeginInfo() { sType = CommandBufferBeginInfo };
            for (int i = 0; i < images.Length; i++) {
                VkCommandBuffer cmds = buffers[i];
                //cmds.Begin(ref cmdBeginInfo);
                vkAPI.vkBeginCommandBuffer(cmds, &cmdBeginInfo);
                {
                    var clearValue = new VkClearValue { color = new VkClearColorValue(0.9f, 0.87f, 0.75f, 1.0f) };
                    var info = new VkRenderPassBeginInfo();
                    {
                        info.sType = RenderPassBeginInfo;
                        info.framebuffer = framebuffers[i];
                        info.renderPass = renderPass;
                        clearValue.Set(ref info);
                        info.renderArea = new VkRect2D { extent = surfaceCapabilities.currentExtent };
                    }
                    vkAPI.vkCmdBeginRenderPass(cmds, &info, VkSubpassContents.Inline);
                    {
                        vkAPI.vkCmdBindDescriptorSets(cmds, VkPipelineBindPoint.Graphics,
                            pipelineLayout, 0, 1, &descriptorSet, 0, null);
                        vkAPI.vkCmdBindPipeline(cmds, VkPipelineBindPoint.Graphics, pipeline);
                        var offset = new VkDeviceSize();
                        vkAPI.vkCmdBindVertexBuffers(cmds, 0, 1, &vertexBuffer, &offset);
                        vkAPI.vkCmdBindIndexBuffer(cmds, indexBuffer, offset, VkIndexType.Uint16);
                        vkAPI.vkCmdDrawIndexed(cmds, indexLength, 1, 0, 0, 0);
                    }
                    vkAPI.vkCmdEndRenderPass(cmds);
                }
                vkAPI.vkEndCommandBuffer(cmds);
            }

            return buffers;
        }

        void UpdateDescriptorSets(VkDevice device, VkBuffer uniformBuffer, VkDescriptorSet descriptor) {
            var write = new VkWriteDescriptorSet();
            {
                write.sType = WriteDescriptorSet;
                write.dstSet = descriptor;
                write.descriptorType = VkDescriptorType.UniformBuffer;
                var info = new VkDescriptorBufferInfo(uniformBuffer, 0, 2 * sizeof(float));
                info.Set(ref write);
            }

            //device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { write }, null);
            vkAPI.vkUpdateDescriptorSets(device, 1, &write, 0, null);
        }

        VkDescriptorSet CreateDescriptorSet(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            VkDescriptorPool descriptorPool;
            {
                // this pool can allocate one uniform descriptor.
                var info = new VkDescriptorPoolCreateInfo();
                info.sType = DescriptorPoolCreateInfo;
                var size = new VkDescriptorPoolSize(VkDescriptorType.UniformBuffer, 1);
                size.Set(ref info);
                info.maxSets = 1;
                //descriptorPool = device.CreateDescriptorPool(ref info);
                vkAPI.vkCreateDescriptorPool(device, &info, null, &descriptorPool);
            }
            VkDescriptorSet descriptorSet;
            {
                var info = new VkDescriptorSetAllocateInfo();
                info.sType = DescriptorSetAllocateInfo;
                descriptorSetLayout.Set(ref info);
                info.descriptorPool = descriptorPool;
                vkAPI.vkAllocateDescriptorSets(device, &info, &descriptorSet).Check();
            }

            return descriptorSet;
        }


        VkPipeline[] CreatePipelines(VkDevice device, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkRenderPass renderPass, VkPipelineLayout pipelineLayout) {
            //VkShaderModule vertexShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.vert.spv"));
            VkShaderModule vsModule;
            {
                var info = new VkShaderModuleCreateInfo();
                {
                    info.sType = ShaderModuleCreateInfo;
                    byte[] bytes = LoadResource(@"Shaders\shader.vert.spv");
                    bytes.Set(ref info);
                    info.flags = 0;
                }
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, &info, null, &vsModule);
                Vk.Free(ref info);
            }
            //VkShaderModule fragmentShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.frag.spv"));
            VkShaderModule fsModule;
            {
                var info = new VkShaderModuleCreateInfo();
                {
                    info.sType = ShaderModuleCreateInfo;
                    byte[] bytes = LoadResource(@"Shaders\shader.frag.spv");
                    bytes.Set(ref info);
                    info.flags = 0;
                }
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, &info, null, &fsModule);
                Vk.Free(ref info);
            }
            var vs = new VkPipelineShaderStageCreateInfo();
            {
                vs.sType = PipelineShaderStageCreateInfo;
                vs.stage = VkShaderStageFlagBits.Vertex;
                vs.module = vsModule;
                "main".Set(ref vs.pName);
            }
            var fs = new VkPipelineShaderStageCreateInfo();
            {
                fs.sType = PipelineShaderStageCreateInfo;
                fs.stage = VkShaderStageFlagBits.Fragment;
                fs.module = fsModule;
                "main".Set(ref fs.pName);
            }
            VkPipelineShaderStageCreateInfo[] stages = { vs, fs };
            var viewport = new VkPipelineViewportStateCreateInfo();
            {
                viewport.sType = PipelineViewportStateCreateInfo;
                var vp = new VkViewport(surfaceCapabilities.currentExtent, 0.0f, 1.0f);
                vp.Set(ref viewport);
                var scissor = new VkRect2D(surfaceCapabilities.currentExtent);
                scissor.Set(ref viewport);
            }

            var multisample = new VkPipelineMultisampleStateCreateInfo {
                sType = PipelineMultisampleStateCreateInfo,
                rasterizationSamples = VkSampleCountFlagBits._1
            };
            var colorBlend = new VkPipelineColorBlendStateCreateInfo();
            {
                colorBlend.sType = PipelineColorBlendStateCreateInfo;
                colorBlend.logicOp = VkLogicOp.Copy;
                var blend = new VkPipelineColorBlendAttachmentState(
                    colorWriteMask: VkColorComponentFlagBits.R | VkColorComponentFlagBits.G
                    | VkColorComponentFlagBits.B | VkColorComponentFlagBits.A,
                    blendEnable: false);
                blend.Set(ref colorBlend);
            }
            var rasterization = new VkPipelineRasterizationStateCreateInfo {
                sType = PipelineRasterizationStateCreateInfo,
                polygonMode = VkPolygonMode.Fill,
                cullMode = VkCullModeFlagBits.None,
                frontFace = VkFrontFace.Clockwise,
                lineWidth = 1.0f
            };
            var inputAssem = new VkPipelineInputAssemblyStateCreateInfo {
                sType = PipelineInputAssemblyStateCreateInfo,
                topology = VkPrimitiveTopology.TriangleList
            };
            var input = new VkPipelineVertexInputStateCreateInfo();
            {
                input.sType = PipelineVertexInputStateCreateInfo;
                var binding = new VkVertexInputBindingDescription(
                    binding: 0,
                    stride: 3 * sizeof(float),
                    inputRate: VkVertexInputRate.Vertex);
                binding.Set(ref input);
                var attribute = new VkVertexInputAttributeDescription(0, 0, VkFormat.R32g32b32Sfloat, 0);
                attribute.Set(ref input);
            }

            //VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            VkPipelineCache cache;
            {
                var info = new VkPipelineCacheCreateInfo { sType = PipelineCacheCreateInfo };
                vkAPI.vkCreatePipelineCache(device, &info, null, &cache);
            }
            //var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            //return device.CreateGraphicsPipelines(ref cache, infos);
            VkPipeline pipeline;
            {
                var info = new VkGraphicsPipelineCreateInfo();
                {
                    info.sType = GraphicsPipelineCreateInfo;
                    info.layout = pipelineLayout;
                    info.pViewportState = &viewport;
                    stages.Set(ref info);
                    info.pMultisampleState = &multisample;
                    info.pColorBlendState = &colorBlend;
                    info.pRasterizationState = &rasterization;
                    info.pInputAssemblyState = &inputAssem;
                    info.pVertexInputState = &input;
                    info.renderPass = renderPass;
                }

                vkAPI.vkCreateGraphicsPipelines(device, cache, 1, &info, null, &pipeline);
            }

            Vk.Free(ref vs);
            Vk.Free(ref fs);

            return new VkPipeline[] { pipeline };
        }

        VkPipelineLayout CreatePipelineLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            var info = new VkPipelineLayoutCreateInfo();
            {
                info.sType = PipelineLayoutCreateInfo;
                descriptorSetLayout.Set(ref info);
            }
            //return device.CreatePipelineLayout(ref info);
            VkPipelineLayout layout;
            vkAPI.vkCreatePipelineLayout(device, &info, null, &layout);
            return layout;
        }

        byte[] LoadResource(string name) {
            byte[] bytes = null;
            using (var fs = new System.IO.FileStream(name, System.IO.FileMode.Open)) {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
            }

            return bytes;
        }

        VkDescriptorSetLayout CreateDescriptorSetLayout(VkDevice device) {
            /*
    layout (set = 0, binding = 0) uniform AreaUB
    {
    float width;
    float height;
    } area;
             */
            var info = new VkDescriptorSetLayoutCreateInfo();
            {
                info.sType = DescriptorSetLayoutCreateInfo;
                var binding = new VkDescriptorSetLayoutBinding(
                    binding: 0,
                    descriptorType: VkDescriptorType.UniformBuffer, // uniform 
                    descriptorCount: 1, // single variable, not array.
                    stageFlags: VkShaderStageFlagBits.Vertex); // in a vertex shader.
                binding.Set(ref info);
            }

            //return device.CreateDescriptorSetLayout(ref info);
            VkDescriptorSetLayout layout;
            vkAPI.vkCreateDescriptorSetLayout(device, &info, null, &layout);
            return layout;
        }

        VkBuffer CreateBuffer(VkPhysicalDevice physicalDevice, VkDevice device, object values, VkBufferUsageFlagBits usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            VkBuffer buffer;
            {
                UInt32 index = 0;
                var info = new VkBufferCreateInfo();
                {
                    info.sType = BufferCreateInfo;
                    info.size = new VkDeviceSize((UInt64)size);
                    info.usage = usageFlags;
                    info.sharingMode = VkSharingMode.Exclusive;
                    index.Set(ref info);
                }
                //VkBuffer buffer = device.CreateBuffer(ref info);
                vkAPI.vkCreateBuffer(device, &info, null, &buffer);
            }
            VkDeviceMemory deviceMemory; // = device.AllocateMemory(ref allocInfo);
            VkMemoryRequirements memoryReq;
            //VkMemoryRequirements memoryReq = device.GetBufferMemoryRequirements(buffer);
            vkAPI.vkGetBufferMemoryRequirements(device, buffer, &memoryReq);
            var allocInfo = new VkMemoryAllocateInfo();
            {
                allocInfo.sType = MemoryAllocateInfo;
                allocInfo.allocationSize = memoryReq.size;
                VkPhysicalDeviceMemoryProperties memoryProperties;
                //physicalDevice.GetMemoryProperties(out memoryProperties);
                vkAPI.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memoryProperties);
                allocInfo.memoryTypeIndex = GetMemoryTypeIndex(memoryProperties, memoryReq,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);
                vkAPI.vkAllocateMemory(device, &allocInfo, null, &deviceMemory);
            }
            {
                IntPtr memPtr = IntPtr.Zero;
                vkAPI.vkMapMemory(device, deviceMemory, new VkDeviceSize(), new VkDeviceSize((UInt64)size), 0, &memPtr);

                if (type == typeof(float))
                    System.Runtime.InteropServices.Marshal.Copy(values as float[], 0, memPtr, length);
                else if (type == typeof(short))
                    System.Runtime.InteropServices.Marshal.Copy(values as short[], 0, memPtr, length);
                else if (type == typeof(AreaUniformBuffer)) {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(values, memPtr, false);
                    this.vkBuffer = buffer;
                    this.vkDeviceMemory = deviceMemory;
                    this.uniformSize = memoryReq.size;
                }

                vkAPI.vkUnmapMemory(device, deviceMemory);
            }
            vkAPI.vkBindBufferMemory(device, buffer, deviceMemory, new VkDeviceSize());

            return buffer;
        }

        //VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT
        private uint GetMemoryTypeIndex(VkPhysicalDeviceMemoryProperties memoryProperties, VkMemoryRequirements memoryReq, VkMemoryPropertyFlagBits flags) {
            uint result = 0;
            bool heapIndexSet = false;
            VkMemoryType* memoryTypes = (VkMemoryType*)memoryProperties.memoryTypes;

            for (uint i = 0; i < memoryProperties.memoryTypeCount; i++) {
                if (((memoryReq.memoryTypeBits >> (int)i) & 1) == 1 &&
                    (memoryTypes[i].propertyFlags & flags) == flags) {
                    result = i;
                    heapIndexSet = true;
                    break;
                }
            }

            if (!heapIndexSet)
                result = memoryTypes[0].heapIndex;

            return result;
        }

        struct AreaUniformBuffer {
            public float width;
            public float height;

            public AreaUniformBuffer(float width, float height) {
                this.width = width; this.height = height;
            }
        }

        protected VkFramebuffer[] CreateFramebuffers(VkDevice device, VkImage[] images, VkSurfaceFormatKHR surfaceFormat, VkRenderPass renderPass, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var displayViews = new VkImageView[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = new VkImageViewCreateInfo {
                    sType = ImageViewCreateInfo,
                    image = images[i],
                    viewType = VkImageViewType._2d,
                    format = surfaceFormat.format,
                    components = new VkComponentMapping {
                        r = VkComponentSwizzle.R,
                        g = VkComponentSwizzle.G,
                        b = VkComponentSwizzle.B,
                        a = VkComponentSwizzle.A
                    },
                    subresourceRange = new VkImageSubresourceRange {
                        aspectMask = VkImageAspectFlagBits.Color,
                        levelCount = 1,
                        layerCount = 1
                    }
                };
                //displayViews[i] = device.CreateImageView(ref info);
                VkImageView view;
                vkAPI.vkCreateImageView(device, &info, null, &view).Check();
                displayViews[i] = view;
            }

            var framebuffers = new VkFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = new VkFramebufferCreateInfo();
                {
                    info.sType = FramebufferCreateInfo;
                    info.layers = 1;
                    info.renderPass = renderPass;
                    displayViews[i].Set(ref info);
                    info.width = surfaceCapabilities.currentExtent.width;
                    info.height = surfaceCapabilities.currentExtent.height;
                }
                //framebuffers[i] = device.CreateFramebuffer(ref info);
                VkFramebuffer framebuffer;
                vkAPI.vkCreateFramebuffer(device, &info, null, &framebuffer);
                framebuffers[i] = framebuffer;
            }

            return framebuffers;
        }

        protected VkRenderPass CreateRenderPass(VkDevice device, VkSurfaceFormatKHR surfaceFormat) {
            var info = new VkRenderPassCreateInfo();
            {
                info.sType = RenderPassCreateInfo;
                var attDesc = new VkAttachmentDescription(surfaceFormat.format, VkSampleCountFlagBits._1,
                     VkAttachmentLoadOp.Clear, VkAttachmentStoreOp.Store,
                     VkAttachmentLoadOp.DontCare, VkAttachmentStoreOp.DontCare,
                     VkImageLayout.Undefined, VkImageLayout.PresentSrcKHR, 0);
                attDesc.Set(ref info);
                var subpassDesc = new VkSubpassDescription(VkPipelineBindPoint.Graphics);
                {
                    var attRef = new VkAttachmentReference(VkImageLayout.ColorAttachmentOptimal, 0);
                    attRef.SetColorAttachment(ref subpassDesc);
                }
                subpassDesc.Set(ref info);
            }

            //return device.CreateRenderPass(ref info);
            VkRenderPass renderpass;
            vkAPI.vkCreateRenderPass(device, &info, null, &renderpass).Check();
            return renderpass;
        }

        protected VkSwapchainKHR CreateSwapchain(VkDevice device, VkSurfaceKHR surface, VkSurfaceFormatKHR surfaceFormat, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagBitsKHR.InheritKHR)
                ? VkCompositeAlphaFlagBitsKHR.InheritKHR
                : VkCompositeAlphaFlagBitsKHR.OpaqueKHR;
            UInt32 index = 0;
            var info = new VkSwapchainCreateInfoKHR();
            {
                info.sType = SwapchainCreateInfoKHR;
                info.surface = surface;
                info.minImageCount = surfaceCapabilities.minImageCount;
                info.imageFormat = surfaceFormat.format;
                info.imageColorSpace = surfaceFormat.colorSpace;
                info.imageExtent = surfaceCapabilities.currentExtent;
                info.imageUsage = VkImageUsageFlagBits.ColorAttachment;
                info.preTransform = VkSurfaceTransformFlagBitsKHR.IdentityKHR;
                info.imageArrayLayers = 1;
                info.imageSharingMode = VkSharingMode.Exclusive;
                index.Set(ref info);
                info.presentMode = VkPresentModeKHR.FifoKHR;
                info.compositeAlpha = compositeAlpha;
            }

            //return device.CreateSwapchainKHR(ref info, null);
            VkSwapchainKHR swapchain;
            vkAPI.vkCreateSwapchainKHR(device, &info, null, &swapchain).Check();
            return swapchain;
        }

        protected VkSurfaceFormatKHR SelectFormat(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface) {
            VkSurfaceFormatKHR[] formats;
            //physicalDevice.GetSurfaceFormatsKHR(surface, out formats);
            {
                UInt32 count;
                vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, &count, null).Check();
                formats = new VkSurfaceFormatKHR[count];
                fixed (VkSurfaceFormatKHR* pointer = formats) {
                    vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, &count, pointer).Check();
                }
            }
            foreach (var f in formats)
                if (f.format == VkFormat.R8g8b8a8Unorm || f.format == VkFormat.B8g8r8a8Unorm)
                    return f;

            throw new System.Exception("didn't find the R8G8B8A8Unorm or B8G8R8A8Unorm format");
        }

        private VkDevice CreateDevice(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface) {
            //VkQueueFamilyProperties[] properties = physicalDevice.GetQueueFamilyProperties();
            VkQueueFamilyProperties[] properties = Vk.QueueFamilyProperties(physicalDevice);
            uint index;
            for (index = 0; index < properties.Length; ++index) {
                VkBool32 supported;
                //physicalDevice.GetSurfaceSupportKHR(index, surface, out supported);
                vkAPI.vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, index, surface, &supported).Check();
                if (!supported) { continue; }

                if (properties[index].queueFlags.HasFlag(VkQueueFlagBits.Graphics)) break;
            }

            var queueInfo = new VkDeviceQueueCreateInfo();
            {
                queueInfo.sType = DeviceQueueCreateInfo;
                var priorities = new float[] { 1.0f };
                priorities.Set(ref queueInfo);
                queueInfo.queueFamilyIndex = index;
            }

            var deviceInfo = new VkDeviceCreateInfo();
            {
                deviceInfo.sType = DeviceCreateInfo;
                new[] { "VK_KHR_swapchain" }.SetExtensions(ref deviceInfo);
                queueInfo.Set(ref deviceInfo);
            }

            VkDevice device;
            //physicalDevice.CreateDevice(ref deviceInfo, null, out device);
            vkAPI.vkCreateDevice(physicalDevice, &deviceInfo, null, &device).Check();

            Vk.Free(ref deviceInfo);
            Vk.Free(ref queueInfo);

            return device;
        }

        private VkPhysicalDevice InitPhysicalDevice(VkInstance instance) {

            VkPhysicalDevice[] physicalDevices = Vk.PhysicalDevices(instance);

            return physicalDevices[0];
        }

        private VkSurfaceKHR InitSurface(VkInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKHR {
                sType = Win32SurfaceCreateInfoKHR,
                hwnd = hwnd,
                hinstance = processHandle, //Process.GetCurrentProcess().Handle
            };
            VkSurfaceKHR surface;
            vkAPI.vkCreateWin32SurfaceKHR(instance, &info, null, &surface).Check();
            return surface;
        }

        private VkInstance InitInstance() {
            VkLayerProperties[] layerProperties = Vk.InstanceLayerProperties();

            string[] layers = layerProperties.Any(l => Marshal.PtrToStringAnsi((IntPtr)l.layerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = new VkApplicationInfo();
            {
                appInfo.sType = ApplicationInfo;
                UInt32 version = Vulkan.VkVersion.Make(1, 0, 0);
                appInfo.apiVersion = version;
            }

            var extensions = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" };

            var info = new VkInstanceCreateInfo();
            {
                info.sType = InstanceCreateInfo;
                extensions.SetExtensions(ref info);
                layers.SetLayers(ref info);
                info.pApplicationInfo = &appInfo;
            }

            VkInstance result;
            vkAPI.vkCreateInstance(&info, null, &result).Check();
            Vk.Free(ref info);

            return result;
        }

        private VkSubmitInfo[] submitInfos;
        private VkPresentInfoKHR[] presentInfos;

        private void InitRenderParams() {
            VkSwapchainKHR swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;

            submitInfos = new VkSubmitInfo[2]; presentInfos = new VkPresentInfoKHR[2];
            for (uint index = 0; index < 2; index++) {
                var submitInfo = new VkSubmitInfo();
                {
                    submitInfo.sType = SubmitInfo;
                    semaphore.SetWaitSemaphores(ref submitInfo);
                    VkPipelineStageFlagBits.AllGraphics.Set(ref submitInfo);
                    commandBuffers[index].Set(ref submitInfo);
                }
                submitInfos[index] = submitInfo;
                var presentInfo = new VkPresentInfoKHR();
                {
                    presentInfo.sType = PresentInfoKHR;
                    swapchain.Set(ref presentInfo);
                    index.Set(ref presentInfo);
                }
                presentInfos[index] = presentInfo;
            }
        }

        public void Render() {
            if (!isInitialized) return;

            if (this.submitInfos == null) {
                InitRenderParams();
            }

            VkDevice device = this.vkDevice; VkSwapchainKHR swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkQueue queue = this.vkQueue;
            //uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            UInt32 nextIndex;
            vkAPI.vkAcquireNextImageKHR(device, swapchain, ulong.MaxValue, semaphore, new VkFence(), &nextIndex);
            //device.ResetFence(fence);
            vkAPI.vkResetFences(device, 1, &fence);

            //queue.Submit(ref this.submitInfos[nextIndex], fence);
            VkSubmitInfo submitInfo = this.submitInfos[nextIndex];
            vkAPI.vkQueueSubmit(queue, 1, &submitInfo, fence);
            //device.WaitForFence(fence, true, 100000000);
            vkAPI.vkWaitForFences(device, 1, &fence, new VkBool32(true), 100000000);
            //queue.PresentKHR(ref this.presentInfos[nextIndex]);
            VkPresentInfoKHR presentInfo = this.presentInfos[nextIndex];
            vkAPI.vkQueuePresentKHR(queue, &presentInfo);
        }
    }
}
