using System;
using System.Linq;
using Vulkan;

namespace Lesson02Shader {
    unsafe class LessonShader {
        VkInstance vkIntance;
        VkSurfaceKhr vkSurface;
        VkPhysicalDevice vkPhysicalDevice;

        VkDevice vkDevice;
        VkQueue vkQueue;
        VkSwapchainKhr vkSwapchain;
        VkImage[] vkImages;
        VkRenderPass vkRenderPass;
        VkFramebuffer[] vkFramebuffers;
        VkFence vkFence;
        VkSemaphore vkSemaphore;
        //
        VkBuffer uniformBuffer;
        VkDescriptorSetLayout descriptorSetLayout;
        VkPipelineLayout pipelineLayout;
        VkDescriptorSet[] descriptorSets;

        VkCommandBuffer[] vkCommandBuffers;
        bool isInitialized = false;

        public void Init(IntPtr hwnd, IntPtr processHandle) {
            if (this.isInitialized) { return; }

            this.vkIntance = InitInstance();
            this.vkSurface = InitSurface(this.vkIntance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice();
            VkSurfaceFormatKhr surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.vkSurface);
            VkSurfaceCapabilitiesKhr surfaceCapabilities;
            this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);

            this.vkDevice = InitDevice(this.vkPhysicalDevice, this.vkSurface);

            this.vkQueue = this.vkDevice.GetDeviceQueue(0, 0);
            this.vkSwapchain = CreateSwapchain(this.vkDevice, this.vkSurface, surfaceFormat, surfaceCapabilities);
            this.vkImages = this.vkDevice.GetSwapchainImagesKHR(this.vkSwapchain);
            this.vkRenderPass = CreateRenderPass(this.vkDevice, surfaceFormat);
            this.vkFramebuffers = CreateFramebuffers(this.vkDevice, this.vkImages, surfaceFormat, this.vkRenderPass, surfaceCapabilities);

            var fenceInfo = new VkFenceCreateInfo() { SType = VkStructureType.FenceCreateInfo };
            this.vkFence = this.vkDevice.CreateFence(ref fenceInfo);
            var semaphoreInfo = new VkSemaphoreCreateInfo() { SType = VkStructureType.SemaphoreCreateInfo };
            this.vkSemaphore = this.vkDevice.CreateSemaphore(ref semaphoreInfo);

            // buffers for vertex data.
            VkBuffer vertexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Vertices, VkBufferUsageFlags.VertexBuffer, typeof(float));
            VkBuffer indexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Indexes, VkBufferUsageFlags.IndexBuffer, typeof(short));
            this.uniformBuffer = CreateUniformBuffer(this.vkPhysicalDevice, this.vkDevice, surfaceCapabilities);
            this.descriptorSetLayout = CreateDescriptorSetLayout(this.vkDevice);
            var pipelines = CreatePipelines(this.vkDevice, this.descriptorSetLayout, surfaceCapabilities, this.vkRenderPass, out this.pipelineLayout);
            this.descriptorSets = CreateDescriptorSets(this.vkDevice);
            UpdateDescriptorSets(this.vkDevice);

            this.vkCommandBuffers = CreateCommandBuffers(
                this.vkDevice, this.vkRenderPass, surfaceCapabilities,
                this.vkImages, this.vkFramebuffers, pipelines[0], vertexBuffer, indexBuffer, (uint)Logo.Indexes.Length);

            this.isInitialized = true;
        }

        //VkCommandBuffer[] CreateCommandBuffers(VkDevice device, VkImage[] images, VkFramebuffer[] framebuffers, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
        //    var createPoolInfo = new VkCommandPoolCreateInfo {
        //        SType = VkStructureType.CommandPoolCreateInfo,
        //        Flags = VkCommandPoolCreateFlags.ResetCommandBuffer
        //    };
        //    var commandPool = device.CreateCommandPool(ref createPoolInfo);
        //    var commandBufferAllocateInfo = new VkCommandBufferAllocateInfo {
        //        SType = VkStructureType.CommandBufferAllocateInfo,
        //        Level = VkCommandBufferLevel.Primary,
        //        CommandPool = commandPool.handle,
        //        CommandBufferCount = (uint)images.Length
        //    };
        //    VkCommandBuffer[] buffers = device.AllocateCommandBuffers(ref commandBufferAllocateInfo);
        //    for (int i = 0; i < images.Length; i++) {

        //        var commandBufferBeginInfo = new VkCommandBufferBeginInfo() {
        //            SType = VkStructureType.CommandBufferBeginInfo
        //        };
        //        buffers[i].Begin(ref commandBufferBeginInfo);
        //        {
        //            var renderPassBeginInfo = new VkRenderPassBeginInfo();
        //            {
        //                renderPassBeginInfo.SType = VkStructureType.RenderPassBeginInfo;
        //                renderPassBeginInfo.Framebuffer = framebuffers[i].handle;
        //                renderPassBeginInfo.RenderPass = renderPass.handle;
        //                new VkClearValue[] { new VkClearValue { Color = new VkClearColorValue(0.9f, 0.7f, 0.0f, 1.0f) } }.Set(ref renderPassBeginInfo.ClearValues, ref renderPassBeginInfo.ClearValueCount);
        //                renderPassBeginInfo.RenderArea = new VkRect2D {
        //                    Extent = surfaceCapabilities.CurrentExtent
        //                };
        //            };
        //            buffers[i].CmdBeginRenderPass(ref renderPassBeginInfo, VkSubpassContents.Inline);
        //            {
        //                // nothing to do in this lesson.
        //            }
        //            buffers[i].CmdEndRenderPass();
        //        }
        //        buffers[i].End();
        //    }
        //    return buffers;
        //}

        VkCommandBuffer[] CreateCommandBuffers(
            VkDevice device, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities,
            VkImage[] images, VkFramebuffer[] framebuffers, VkPipeline pipeline,
            VkBuffer vertexBuffer, VkBuffer indexBuffer, uint indexLength) {
            var createPoolInfo = new VkCommandPoolCreateInfo {
                SType = VkStructureType.CommandPoolCreateInfo,
                Flags = VkCommandPoolCreateFlags.ResetCommandBuffer
            };
            var commandPool = device.CreateCommandPool(ref createPoolInfo);
            var commandBufferAllocateInfo = new VkCommandBufferAllocateInfo {
                SType = VkStructureType.CommandBufferAllocateInfo,
                Level = VkCommandBufferLevel.Primary,
                CommandPool = commandPool.handle,
                CommandBufferCount = (uint)images.Length
            };
            var buffers = device.AllocateCommandBuffers(ref commandBufferAllocateInfo);
            var commandBufferBeginInfo = new VkCommandBufferBeginInfo() { SType = VkStructureType.CommandBufferBeginInfo };

            for (int i = 0; i < images.Length; i++) {
                buffers[i].Begin(ref commandBufferBeginInfo);
                var renderPassBeginInfo = new VkRenderPassBeginInfo();
                {
                    renderPassBeginInfo.SType = VkStructureType.RenderPassBeginInfo;
                    renderPassBeginInfo.Framebuffer = framebuffers[i].handle;
                    renderPassBeginInfo.RenderPass = renderPass.handle;
                    new VkClearValue[] { new VkClearValue { Color = new VkClearColorValue(0.9f, 0.87f, 0.75f, 1.0f) } }.Set(ref renderPassBeginInfo.ClearValues, ref renderPassBeginInfo.ClearValueCount);
                    renderPassBeginInfo.RenderArea = new VkRect2D { Extent = surfaceCapabilities.CurrentExtent };
                };
                buffers[i].CmdBeginRenderPass(ref renderPassBeginInfo, VkSubpassContents.Inline);
                buffers[i].CmdBindDescriptorSets(VkPipelineBindPoint.Graphics, pipelineLayout, 0, descriptorSets, null);
                buffers[i].CmdBindPipeline(VkPipelineBindPoint.Graphics, pipeline);
                buffers[i].CmdBindVertexBuffer(0, vertexBuffer, 0);
                buffers[i].CmdBindIndexBuffer(indexBuffer, 0, VkIndexType.Uint16);
                buffers[i].CmdDrawIndexed(indexLength, 1, 0, 0, 0);
                buffers[i].CmdEndRenderPass();
                buffers[i].End();
            }

            return buffers;
        }

        void UpdateDescriptorSets(VkDevice device) {
            var uniformBufferInfo = new VkDescriptorBufferInfo {
                Buffer = uniformBuffer.handle,
                Offset = 0,
                Range = 2 * sizeof(float)
            };
            var writeDescriptorSet = new VkWriteDescriptorSet();
            {
                writeDescriptorSet.SType = VkStructureType.WriteDescriptorSet;
                writeDescriptorSet.DstSet = descriptorSets[0].handle;
                writeDescriptorSet.DescriptorType = VkDescriptorType.UniformBuffer;
                new VkDescriptorBufferInfo[] { uniformBufferInfo }.Set(ref writeDescriptorSet.BufferInfo, ref writeDescriptorSet.DescriptorCount);
            };

            device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { writeDescriptorSet }, null);
        }

        VkDescriptorSet[] CreateDescriptorSets(VkDevice device) {
            var typeCount = new VkDescriptorPoolSize {
                Type = VkDescriptorType.UniformBuffer,
                DescriptorCount = 1
            };
            var descriptorPoolCreateInfo = new VkDescriptorPoolCreateInfo();
            {
                descriptorPoolCreateInfo.SType = VkStructureType.DescriptorPoolCreateInfo;
                new VkDescriptorPoolSize[] { typeCount }.Set(ref descriptorPoolCreateInfo.PoolSizes, ref descriptorPoolCreateInfo.PoolSizeCount);
                descriptorPoolCreateInfo.MaxSets = 1;
            }
            var descriptorPool = device.CreateDescriptorPool(ref descriptorPoolCreateInfo);

            var descriptorSetAllocateInfo = new VkDescriptorSetAllocateInfo();
            {
                descriptorSetAllocateInfo.SType = VkStructureType.DescriptorSetAllocateInfo;
                new UInt64[] { descriptorSetLayout.handle }.Set(ref descriptorSetAllocateInfo.SetLayouts, ref descriptorSetAllocateInfo.DescriptorSetCount);
                descriptorSetAllocateInfo.DescriptorPool = descriptorPool.handle;
            }

            return device.AllocateDescriptorSets(ref descriptorSetAllocateInfo);
        }

        VkPipeline[] CreatePipelines(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkSurfaceCapabilitiesKhr surfaceCapabilities,
            VkRenderPass vkRenderPass, out VkPipelineLayout pipelineLayout) {
            var pipelineLayoutCreateInfo = new VkPipelineLayoutCreateInfo();
            {
                pipelineLayoutCreateInfo.SType = VkStructureType.PipelineLayoutCreateInfo;
                new UInt64[] { descriptorSetLayout.handle }.Set(ref pipelineLayoutCreateInfo.SetLayouts, ref pipelineLayoutCreateInfo.SetLayoutCount);
            }
            pipelineLayout = device.CreatePipelineLayout(ref pipelineLayoutCreateInfo);
            VkShaderModule vertexShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.vert.spv"));
            VkShaderModule fragmentShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.frag.spv"));
            var vs = new VkPipelineShaderStageCreateInfo();
            {
                vs.SType = VkStructureType.PipelineShaderStageCreateInfo;
                vs.Stage = VkShaderStageFlags.Vertex;
                vs.Module = vertexShaderModule.handle;
                "main".Set(ref vs.Name);
            }
            var fs = new VkPipelineShaderStageCreateInfo();
            {
                fs.SType = VkStructureType.PipelineShaderStageCreateInfo;
                fs.Stage = VkShaderStageFlags.Fragment;
                fs.Module = fragmentShaderModule.handle;
                "main".Set(ref fs.Name);
            }
            VkPipelineShaderStageCreateInfo[] pipelineShaderStages = { vs, fs };
            var viewport = new VkViewport {
                MinDepth = 0,
                MaxDepth = 1.0f,
                Width = surfaceCapabilities.CurrentExtent.Width,
                Height = surfaceCapabilities.CurrentExtent.Height
            };
            var scissor = new VkRect2D { Extent = surfaceCapabilities.CurrentExtent };
            var viewportCreateInfo = new VkPipelineViewportStateCreateInfo();
            {
                viewportCreateInfo.SType = VkStructureType.PipelineViewportStateCreateInfo;
                new VkViewport[] { viewport }.Set(ref viewportCreateInfo.Viewports, ref viewportCreateInfo.ViewportCount);
                new VkRect2D[] { scissor }.Set(ref viewportCreateInfo.Scissors, ref viewportCreateInfo.ScissorCount);
            };

            var multisampleCreateInfo = new VkPipelineMultisampleStateCreateInfo {
                SType = VkStructureType.PipelineMultisampleStateCreateInfo,
                RasterizationSamples = VkSampleCountFlags.Count1
            };
            var colorBlendAttachmentState = new VkPipelineColorBlendAttachmentState {
                ColorWriteMask = VkColorComponentFlags.R | VkColorComponentFlags.G | VkColorComponentFlags.B | VkColorComponentFlags.A
            };
            var colorBlendStateCreatInfo = new VkPipelineColorBlendStateCreateInfo();
            {
                colorBlendStateCreatInfo.SType = VkStructureType.PipelineColorBlendStateCreateInfo;
                colorBlendStateCreatInfo.LogicOp = VkLogicOp.Copy;
                new VkPipelineColorBlendAttachmentState[] { colorBlendAttachmentState }.Set(ref colorBlendStateCreatInfo.Attachments, ref colorBlendStateCreatInfo.AttachmentCount);
            };
            var rasterizationStateCreateInfo = new VkPipelineRasterizationStateCreateInfo {
                SType = VkStructureType.PipelineRasterizationStateCreateInfo,
                PolygonMode = VkPolygonMode.Fill,
                CullMode = (uint)VkCullModeFlags.None,
                FrontFace = VkFrontFace.Clockwise,
                LineWidth = 1.0f
            };
            var inputAssemblyStateCreateInfo = new VkPipelineInputAssemblyStateCreateInfo {
                SType = VkStructureType.PipelineInputAssemblyStateCreateInfo,
                Topology = VkPrimitiveTopology.TriangleList
            };
            var vertexInputBindingDescription = new VkVertexInputBindingDescription {
                Stride = 3 * sizeof(float),
                InputRate = VkVertexInputRate.Vertex
            };
            var vertexInputAttributeDescription = new VkVertexInputAttributeDescription {
                Format = VkFormat.R32G32B32Sfloat
            };
            var vertexInputStateCreateInfo = new VkPipelineVertexInputStateCreateInfo();
            {
                vertexInputStateCreateInfo.SType = VkStructureType.PipelineVertexInputStateCreateInfo;
                new VkVertexInputBindingDescription[] { vertexInputBindingDescription }.Set(ref vertexInputStateCreateInfo.VertexBindingDescriptions, ref vertexInputStateCreateInfo.VertexBindingDescriptionCount);
                new VkVertexInputAttributeDescription[] { vertexInputAttributeDescription }.Set(ref vertexInputStateCreateInfo.VertexAttributeDescriptions, ref vertexInputStateCreateInfo.VertexAttributeDescriptionCount);
            };

            var pipelineCreateInfo = new VkGraphicsPipelineCreateInfo();
            {
                pipelineCreateInfo.SType = VkStructureType.GraphicsPipelineCreateInfo;
                pipelineCreateInfo.Layout = pipelineLayout.handle;
                pipelineCreateInfo.ViewportState = (IntPtr)(void*)&viewportCreateInfo;
                pipelineShaderStages.Set(ref pipelineCreateInfo.Stages, ref pipelineCreateInfo.StageCount);
                pipelineCreateInfo.MultisampleState = (IntPtr)(void*)&multisampleCreateInfo;
                pipelineCreateInfo.ColorBlendState = (IntPtr)(void*)&colorBlendStateCreatInfo;
                pipelineCreateInfo.RasterizationState = (IntPtr)(void*)&rasterizationStateCreateInfo;
                pipelineCreateInfo.InputAssemblyState = (IntPtr)(void*)&inputAssemblyStateCreateInfo;
                pipelineCreateInfo.VertexInputState = (IntPtr)(void*)&vertexInputStateCreateInfo;
                pipelineCreateInfo.RenderPass = vkRenderPass.handle;
            };

            var cacheInfo = new VkPipelineCacheCreateInfo() { SType = VkStructureType.PipelineCacheCreateInfo };
            VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            return device.CreateGraphicsPipelines(ref cache, infos);
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
            var layoutBinding = new VkDescriptorSetLayoutBinding();
            {
                layoutBinding.DescriptorType = VkDescriptorType.UniformBuffer;
                layoutBinding.DescriptorCount = 1;
                layoutBinding.StageFlags = VkShaderStageFlags.Vertex;
            }
            var createInfo = new VkDescriptorSetLayoutCreateInfo();
            {
                createInfo.SType = VkStructureType.DescriptorSetLayoutCreateInfo;
                new VkDescriptorSetLayoutBinding[] { layoutBinding }.Set(ref createInfo.Bindings, ref createInfo.BindingCount);
            }

            return device.CreateDescriptorSetLayout(ref createInfo);
        }

        VkBuffer CreateUniformBuffer(VkPhysicalDevice physicalDevice, VkDevice device, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var uniformBufferData = new AreaUniformBuffer() {
                width = surfaceCapabilities.CurrentExtent.Width,
                height = surfaceCapabilities.CurrentExtent.Height
            };

            return CreateBuffer(physicalDevice, device, uniformBufferData, VkBufferUsageFlags.UniformBuffer, typeof(AreaUniformBuffer));
        }

        VkBuffer CreateBuffer(VkPhysicalDevice physicalDevice, VkDevice device, object values, VkBufferUsageFlags usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            var createBufferInfo = new VkBufferCreateInfo();
            {
                createBufferInfo.SType = VkStructureType.BufferCreateInfo;
                createBufferInfo.Size = size;
                createBufferInfo.Usage = usageFlags;
                createBufferInfo.SharingMode = VkSharingMode.Exclusive;
                new uint[] { 0 }.Set(ref createBufferInfo.QueueFamilyIndices, ref createBufferInfo.QueueFamilyIndexCount);
            }
            var buffer = device.CreateBuffer(ref createBufferInfo);
            var memoryReq = device.GetBufferMemoryRequirements(buffer);
            var allocInfo = new VkMemoryAllocateInfo();
            {
                allocInfo.SType = VkStructureType.MemoryAllocateInfo;
                allocInfo.AllocationSize = memoryReq.Size;
            }
            VkPhysicalDeviceMemoryProperties memoryProperties;
            physicalDevice.GetMemoryProperties(out memoryProperties);
            bool heapIndexSet = false;
            VkMemoryType* memoryTypes = &memoryProperties.MemoryTypes0;

            for (uint i = 0; i < memoryProperties.MemoryTypeCount; i++) {
                if (((memoryReq.MemoryTypeBits >> (int)i) & 1) == 1 &&
                    (memoryTypes[i].PropertyFlags & VkMemoryPropertyFlags.HostVisible) == VkMemoryPropertyFlags.HostVisible) {
                    allocInfo.MemoryTypeIndex = i;
                    heapIndexSet = true;
                }
            }

            if (!heapIndexSet)
                allocInfo.MemoryTypeIndex = memoryProperties.MemoryTypes0.HeapIndex;

            VkDeviceMemory deviceMemory = device.AllocateMemory(ref allocInfo);
            IntPtr memPtr;
            device.MapMemory(deviceMemory, 0, size, 0, out memPtr);

            if (type == typeof(float))
                System.Runtime.InteropServices.Marshal.Copy(values as float[], 0, memPtr, length);
            else if (type == typeof(short))
                System.Runtime.InteropServices.Marshal.Copy(values as short[], 0, memPtr, length);
            else if (type == typeof(AreaUniformBuffer))
                System.Runtime.InteropServices.Marshal.StructureToPtr(values, memPtr, false);

            device.UnmapMemory(deviceMemory);
            device.BindBufferMemory(buffer, deviceMemory, 0);

            return buffer;
        }

        struct AreaUniformBuffer {
            public float width;
            public float height;
        };

        protected VkFramebuffer[] CreateFramebuffers(VkDevice device, VkImage[] images, VkSurfaceFormatKhr surfaceFormat, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var displayViews = new VkImageView[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var viewCreateInfo = new VkImageViewCreateInfo {
                    SType = VkStructureType.ImageViewCreateInfo,
                    Image = images[i].handle,
                    ViewType = VkImageViewType.View2D,
                    Format = surfaceFormat.Format,
                    Components = new VkComponentMapping {
                        R = VkComponentSwizzle.R,
                        G = VkComponentSwizzle.G,
                        B = VkComponentSwizzle.B,
                        A = VkComponentSwizzle.A
                    },
                    SubresourceRange = new VkImageSubresourceRange {
                        AspectMask = VkImageAspectFlags.Color,
                        LevelCount = 1,
                        LayerCount = 1
                    }
                };
                displayViews[i] = device.CreateImageView(ref viewCreateInfo);
            }

            var framebuffers = new VkFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var frameBufferCreateInfo = new VkFramebufferCreateInfo();
                {
                    frameBufferCreateInfo.SType = VkStructureType.FramebufferCreateInfo;
                    frameBufferCreateInfo.Layers = 1;
                    frameBufferCreateInfo.RenderPass = renderPass.handle;
                    new UInt64[] { displayViews[i].handle }.Set(ref frameBufferCreateInfo.Attachments, ref frameBufferCreateInfo.AttachmentCount);
                    frameBufferCreateInfo.Width = surfaceCapabilities.CurrentExtent.Width;
                    frameBufferCreateInfo.Height = surfaceCapabilities.CurrentExtent.Height;
                };
                framebuffers[i] = device.CreateFramebuffer(ref frameBufferCreateInfo);
            }

            return framebuffers;
        }

        protected VkRenderPass CreateRenderPass(VkDevice device, VkSurfaceFormatKhr surfaceFormat) {
            var attDesc = new VkAttachmentDescription {
                Format = surfaceFormat.Format,
                Samples = VkSampleCountFlags.Count1,
                LoadOp = VkAttachmentLoadOp.Clear,
                StoreOp = VkAttachmentStoreOp.Store,
                StencilLoadOp = VkAttachmentLoadOp.DontCare,
                StencilStoreOp = VkAttachmentStoreOp.DontCare,
                InitialLayout = VkImageLayout.Undefined,
                FinalLayout = VkImageLayout.PresentSrcKhr
            };
            var attRef = new VkAttachmentReference { Layout = VkImageLayout.ColorAttachmentOptimal };
            var subpassDesc = new VkSubpassDescription();
            {
                subpassDesc.PipelineBindPoint = VkPipelineBindPoint.Graphics;
                new UInt32[] { attRef.Attachment }.Set(ref subpassDesc.ColorAttachments, ref subpassDesc.ColorAttachmentCount);
            };
            var renderPassCreateInfo = new VkRenderPassCreateInfo();
            {
                renderPassCreateInfo.SType = VkStructureType.RenderPassCreateInfo;
                new VkAttachmentDescription[] { attDesc }.Set(ref renderPassCreateInfo.Attachments, ref renderPassCreateInfo.AttachmentCount);
                new VkSubpassDescription[] { subpassDesc }.Set(ref renderPassCreateInfo.Subpasses, ref renderPassCreateInfo.SubpassCount);
            };

            return device.CreateRenderPass(ref renderPassCreateInfo);
        }

        protected VkSwapchainKhr CreateSwapchain(VkDevice device, VkSurfaceKhr surface, VkSurfaceFormatKhr surfaceFormat, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.SupportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKhr.Inherit)
                ? VkCompositeAlphaFlagsKhr.Inherit
                : VkCompositeAlphaFlagsKhr.Opaque;
            var swapchainInfo = new VkSwapchainCreateInfoKhr();
            {
                swapchainInfo.SType = VkStructureType.SwapchainCreateInfoKhr;
                swapchainInfo.Surface = surface.handle;
                swapchainInfo.MinImageCount = surfaceCapabilities.MinImageCount;
                swapchainInfo.ImageFormat = surfaceFormat.Format;
                swapchainInfo.ImageColorSpace = surfaceFormat.ColorSpace;
                swapchainInfo.ImageExtent = surfaceCapabilities.CurrentExtent;
                swapchainInfo.ImageUsage = VkImageUsageFlags.ColorAttachment;
                swapchainInfo.PreTransform = VkSurfaceTransformFlagsKhr.Identity;
                swapchainInfo.ImageArrayLayers = 1;
                swapchainInfo.ImageSharingMode = VkSharingMode.Exclusive;
                new uint[] { 0 }.Set(ref swapchainInfo.QueueFamilyIndices, ref swapchainInfo.QueueFamilyIndexCount);
                swapchainInfo.PresentMode = VkPresentModeKhr.Fifo;
                swapchainInfo.CompositeAlpha = compositeAlpha;
            }

            return device.CreateSwapchainKHR(ref swapchainInfo, null);
        }

        protected VkSurfaceFormatKhr SelectFormat(VkPhysicalDevice physicalDevice, VkSurfaceKhr surface) {
            VkSurfaceFormatKhr[] formats;
            physicalDevice.GetSurfaceFormatsKhr(surface, out formats);
            foreach (var f in formats)
                if (f.Format == VkFormat.R8G8B8A8Unorm || f.Format == VkFormat.B8G8R8A8Unorm)
                    return f;

            throw new System.Exception("didn't find the R8G8B8A8Unorm or B8G8R8A8Unorm format");
        }

        private VkDevice InitDevice(VkPhysicalDevice physicalDevice, VkSurfaceKhr surface) {
            VkQueueFamilyProperties[] properties = physicalDevice.GetQueueFamilyProperties();
            uint index;
            for (index = 0; index < properties.Length; ++index) {
                VkBool32 supported;
                physicalDevice.GetSurfaceSupportKhr(index, surface, out supported);
                if (!supported) { continue; }

                if (properties[index].QueueFlags.HasFlag(VkQueueFlags.QueueGraphics)) break;
            }

            var queueInfo = new VkDeviceQueueCreateInfo();
            {
                queueInfo.SType = VkStructureType.DeviceQueueCreateInfo;
                new float[] { 1.0f }.Set(ref queueInfo.QueuePriorities, ref queueInfo.QueueCount);
                queueInfo.QueueFamilyIndex = index;
            }

            var deviceInfo = new VkDeviceCreateInfo();
            {
                deviceInfo.SType = VkStructureType.DeviceCreateInfo;
                new string[] { "VK_KHR_swapchain" }.Set(ref deviceInfo.EnabledExtensionNames, ref deviceInfo.EnabledExtensionCount);
                new VkDeviceQueueCreateInfo[] { queueInfo }.Set(ref deviceInfo.QueueCreateInfos, ref deviceInfo.QueueCreateInfoCount);
            }

            VkDevice device;
            physicalDevice.CreateDevice(ref deviceInfo, null, out device);

            return device;
        }

        private VkPhysicalDevice InitPhysicalDevice() {
            VkPhysicalDevice[] physicalDevices;
            this.vkIntance.EnumeratePhysicalDevices(out physicalDevices);
            return physicalDevices[0];
        }

        private VkSurfaceKhr InitSurface(VkInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKhr {
                SType = VkStructureType.Win32SurfaceCreateInfoKhr,
                Hwnd = hwnd,
                Hinstance = processHandle, //Process.GetCurrentProcess().Handle
            };
            return instance.CreateWin32SurfaceKHR(ref info, null);
        }

        private VkInstance InitInstance() {
            VkLayerProperties[] layerProperties;
            Layer.EnumerateInstanceLayerProperties(out layerProperties);
            string[] layersToEnable = layerProperties.Any(l => StringHelper.ToStringAnsi(l.LayerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = new VkApplicationInfo();
            {
                appInfo.SType = VkStructureType.ApplicationInfo;
                uint version = Vulkan.Version.Make(1, 0, 0);
                appInfo.ApiVersion = version;
            }

            var extensions = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" };

            var info = new VkInstanceCreateInfo();
            {
                info.SType = VkStructureType.InstanceCreateInfo;
                extensions.Set(ref info.EnabledExtensionNames, ref info.EnabledExtensionCount);
                layersToEnable.Set(ref info.EnabledLayerNames, ref info.EnabledLayerCount);
                info.ApplicationInfo = (IntPtr)(&appInfo);
            }

            VkInstance result;
            VkInstance.Create(ref info, null, out result).Check();

            return result;
        }

        public void Render() {
            if (!isInitialized) return;

            VkDevice device = this.vkDevice; VkSwapchainKhr swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;
            uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            device.ResetFence(fence);

            var submitInfo = new VkSubmitInfo();
            {
                new UInt64[] { semaphore.handle }.Set(ref submitInfo.WaitSemaphores, ref submitInfo.WaitSemaphoreCount);
                // I have to use int instead of enum VkPipelineStageFlags.
                new int[] { (int)VkPipelineStageFlags.AllGraphics }.Set(ref submitInfo.WaitDstStageMask, ref submitInfo.WaitSemaphoreCount);
                new IntPtr[] { commandBuffers[nextIndex].handle }.Set(ref submitInfo.CommandBuffers, ref submitInfo.CommandBufferCount);

            };
            queue.Submit(ref submitInfo, fence);
            device.WaitForFence(fence, true, 100000000);

            var presentInfo = new VkPresentInfoKhr();
            {
                presentInfo.SType = VkStructureType.PresentInfoKhr;
                new UInt64[] { swapchain.handle }.Set(ref presentInfo.Swapchains, ref presentInfo.SwapchainCount);
                new uint[] { nextIndex }.Set(ref presentInfo.ImageIndices, ref presentInfo.SwapchainCount);
            };
            queue.PresentKHR(ref presentInfo);
        }
    }
}
