﻿using System;
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
        VkBuffer vkUniformBuffer;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s.
        /// </summary>
        VkDescriptorSetLayout vkDescriptorSetLayout;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s and <see cref="VkPushConstantRange"/>s.
        /// </summary>
        VkPipelineLayout vkPipelineLayout;
        VkDescriptorSet[] vkDescriptorSets;

        VkCommandBuffer[] vkCommandBuffers;
        bool isInitialized = false;;

        public void Init(IntPtr hwnd, IntPtr processHandle) {
            if (this.isInitialized) { return; }

            this.vkIntance = InitInstance();
            this.vkSurface = InitSurface(this.vkIntance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice(this.vkIntance);
            VkSurfaceFormatKhr surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.vkSurface);
            VkSurfaceCapabilitiesKhr surfaceCapabilities;
            this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);

            this.vkDevice = CreateDevice(this.vkPhysicalDevice, this.vkSurface);

            this.vkQueue = this.vkDevice.GetDeviceQueue(0, 0);
            this.vkSwapchain = CreateSwapchain(this.vkDevice, this.vkSurface, surfaceFormat, surfaceCapabilities);
            this.vkImages = this.vkDevice.GetSwapchainImagesKHR(this.vkSwapchain);
            this.vkRenderPass = CreateRenderPass(this.vkDevice, surfaceFormat);
            this.vkFramebuffers = CreateFramebuffers(this.vkDevice, this.vkImages, surfaceFormat, this.vkRenderPass, surfaceCapabilities);

            var fenceInfo = new VkFenceCreateInfo { SType = VkStructureType.FenceCreateInfo };
            this.vkFence = this.vkDevice.CreateFence(ref fenceInfo);
            var semaphoreInfo = new VkSemaphoreCreateInfo { SType = VkStructureType.SemaphoreCreateInfo };
            this.vkSemaphore = this.vkDevice.CreateSemaphore(ref semaphoreInfo);

            // buffers for vertex data.
            VkBuffer vertexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Vertices, VkBufferUsageFlags.VertexBuffer, typeof(float));
            VkBuffer indexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Indexes, VkBufferUsageFlags.IndexBuffer, typeof(short));
            var uniformBufferData = new AreaUniformBuffer(surfaceCapabilities.CurrentExtent.Width, surfaceCapabilities.CurrentExtent.Height);
            this.vkUniformBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, uniformBufferData, VkBufferUsageFlags.UniformBuffer, typeof(AreaUniformBuffer));

            this.vkDescriptorSetLayout = CreateDescriptorSetLayout(this.vkDevice);
            this.vkPipelineLayout = CreatePipelineLayout(this.vkDevice, this.vkDescriptorSetLayout);
            var pipelines = CreatePipelines(this.vkDevice, this.vkDescriptorSetLayout, surfaceCapabilities, this.vkRenderPass, this.vkPipelineLayout);
            this.vkDescriptorSets = CreateDescriptorSets(this.vkDevice, this.vkDescriptorSetLayout);
            UpdateDescriptorSets(this.vkDevice, this.vkUniformBuffer, this.vkDescriptorSets);

            this.vkCommandBuffers = CreateCommandBuffers(
                this.vkDevice, this.vkRenderPass, surfaceCapabilities,
                this.vkImages, this.vkFramebuffers, pipelines[0],
                vertexBuffer, indexBuffer, (uint)Logo.Indexes.Length,
                this.vkPipelineLayout, this.vkDescriptorSets);

            this.isInitialized = true;
        }

        VkCommandBuffer[] CreateCommandBuffers(
            VkDevice device, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities,
            VkImage[] images, VkFramebuffer[] framebuffers, VkPipeline pipeline,
            VkBuffer vertexBuffer, VkBuffer indexBuffer, uint indexLength,
            VkPipelineLayout pipelineLayout, VkDescriptorSet[] descriptorSets) {
            VkCommandBuffer[] buffers;
            {
                var poolInfo = new VkCommandPoolCreateInfo {
                    SType = VkStructureType.CommandPoolCreateInfo,
                    Flags = VkCommandPoolCreateFlags.ResetCommandBuffer
                };
                var commandPool = device.CreateCommandPool(ref poolInfo);
                var info = new VkCommandBufferAllocateInfo {
                    SType = VkStructureType.CommandBufferAllocateInfo,
                    Level = VkCommandBufferLevel.Primary,
                    CommandPool = commandPool.handle,
                    CommandBufferCount = (uint)images.Length
                };
                buffers = device.AllocateCommandBuffers(ref info);
            }

            var cmdBeginInfo = new VkCommandBufferBeginInfo() { SType = VkStructureType.CommandBufferBeginInfo };
            for (int i = 0; i < images.Length; i++) {
                VkCommandBuffer cmds = buffers[i];
                cmds.Begin(ref cmdBeginInfo);
                {
                    var info = new VkRenderPassBeginInfo();
                    {
                        info.SType = VkStructureType.RenderPassBeginInfo;
                        info.Framebuffer = framebuffers[i].handle;
                        info.RenderPass = renderPass.handle;
                        new VkClearValue[] { new VkClearValue { Color = new VkClearColorValue(0.9f, 0.87f, 0.75f, 1.0f) } }.Set(ref info.ClearValues, ref info.ClearValueCount);
                        info.RenderArea = new VkRect2D { Extent = surfaceCapabilities.CurrentExtent };
                    }
                    cmds.CmdBeginRenderPass(ref info, VkSubpassContents.Inline);
                    {
                        cmds.CmdBindDescriptorSets(VkPipelineBindPoint.Graphics, pipelineLayout, 0, descriptorSets, null);
                        cmds.CmdBindPipeline(VkPipelineBindPoint.Graphics, pipeline);
                        cmds.CmdBindVertexBuffer(0, vertexBuffer, 0);
                        cmds.CmdBindIndexBuffer(indexBuffer, 0, VkIndexType.Uint16);
                        cmds.CmdDrawIndexed(indexLength, 1, 0, 0, 0);
                    }
                    cmds.CmdEndRenderPass();
                }
                cmds.End();
            }

            return buffers;
        }

        void UpdateDescriptorSets(VkDevice device, VkBuffer uniformBuffer, VkDescriptorSet[] descriptorSets) {
            var info = new VkDescriptorBufferInfo {
                Buffer = uniformBuffer.handle,
                Offset = 0,
                Range = 2 * sizeof(float)
            };
            var writeDescriptorSet = new VkWriteDescriptorSet();
            {
                writeDescriptorSet.SType = VkStructureType.WriteDescriptorSet;
                writeDescriptorSet.DstSet = descriptorSets[0].handle;
                writeDescriptorSet.DescriptorType = VkDescriptorType.UniformBuffer;
                new VkDescriptorBufferInfo[] { info }.Set(ref writeDescriptorSet.BufferInfo, ref writeDescriptorSet.DescriptorCount);
            }

            device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { writeDescriptorSet }, null);
        }

        VkDescriptorSet[] CreateDescriptorSets(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            VkDescriptorPool descriptorPool;
            {
                // this pool can allocate one uniform descriptor.
                var typeCount = new VkDescriptorPoolSize {
                    Type = VkDescriptorType.UniformBuffer,
                    DescriptorCount = 1
                };
                var info = new VkDescriptorPoolCreateInfo();
                {
                    info.SType = VkStructureType.DescriptorPoolCreateInfo;
                    new VkDescriptorPoolSize[] { typeCount }.Set(ref info.PoolSizes, ref info.PoolSizeCount);
                    info.MaxSets = 1;
                }
                descriptorPool = device.CreateDescriptorPool(ref info);
            }
            VkDescriptorSet[] sets;
            {
                var info = new VkDescriptorSetAllocateInfo();
                {
                    info.SType = VkStructureType.DescriptorSetAllocateInfo;
                    new UInt64[] { descriptorSetLayout.handle }.Set(ref info.SetLayouts, ref info.DescriptorSetCount);
                    info.DescriptorPool = descriptorPool.handle;
                }

                sets = device.AllocateDescriptorSets(ref info);
            }

            return sets;
        }


        VkPipeline[] CreatePipelines(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkSurfaceCapabilitiesKhr surfaceCapabilities,
            VkRenderPass renderPass, VkPipelineLayout pipelineLayout) {
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
            }

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
            }
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
            }

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
                pipelineCreateInfo.RenderPass = renderPass.handle;
            }

            var cacheInfo = new VkPipelineCacheCreateInfo { SType = VkStructureType.PipelineCacheCreateInfo };
            VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            return device.CreateGraphicsPipelines(ref cache, infos);
        }

        VkPipelineLayout CreatePipelineLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            var info = new VkPipelineLayoutCreateInfo();
            {
                info.SType = VkStructureType.PipelineLayoutCreateInfo;
                new UInt64[] { descriptorSetLayout.handle }.Set(ref info.SetLayouts, ref info.SetLayoutCount);
            }
            return device.CreatePipelineLayout(ref info);
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
            var layoutBinding = new VkDescriptorSetLayoutBinding();
            {
                layoutBinding.DescriptorType = VkDescriptorType.UniformBuffer; // uniform
                layoutBinding.DescriptorCount = 1; // single variable, not array.
                layoutBinding.StageFlags = VkShaderStageFlags.Vertex; // in vertex shader.
            }
            var info = new VkDescriptorSetLayoutCreateInfo();
            {
                info.SType = VkStructureType.DescriptorSetLayoutCreateInfo;
                new VkDescriptorSetLayoutBinding[] { layoutBinding }.Set(ref info.Bindings, ref info.BindingCount);
            }

            return device.CreateDescriptorSetLayout(ref info);
        }

        VkBuffer CreateUniformBuffer(VkPhysicalDevice physicalDevice, VkDevice device, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var uniformBufferData = new AreaUniformBuffer {
                width = surfaceCapabilities.CurrentExtent.Width,
                height = surfaceCapabilities.CurrentExtent.Height
            };

            return CreateBuffer(physicalDevice, device, uniformBufferData, VkBufferUsageFlags.UniformBuffer, typeof(AreaUniformBuffer));
        }

        VkBuffer CreateBuffer(VkPhysicalDevice physicalDevice, VkDevice device, object values, VkBufferUsageFlags usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            var info = new VkBufferCreateInfo();
            {
                info.SType = VkStructureType.BufferCreateInfo;
                info.Size = size;
                info.Usage = usageFlags;
                info.SharingMode = VkSharingMode.Exclusive;
                new uint[] { 0 }.Set(ref info.QueueFamilyIndices, ref info.QueueFamilyIndexCount);
            }
            var buffer = device.CreateBuffer(ref info);
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

            public AreaUniformBuffer(float width, float height) {
                this.width = height; this.height = height;
            }
        }

        protected VkFramebuffer[] CreateFramebuffers(VkDevice device, VkImage[] images, VkSurfaceFormatKhr surfaceFormat, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var displayViews = new VkImageView[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = new VkImageViewCreateInfo {
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
                displayViews[i] = device.CreateImageView(ref info);
            }

            var framebuffers = new VkFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = new VkFramebufferCreateInfo();
                {
                    info.SType = VkStructureType.FramebufferCreateInfo;
                    info.Layers = 1;
                    info.RenderPass = renderPass.handle;
                    new UInt64[] { displayViews[i].handle }.Set(ref info.Attachments, ref info.AttachmentCount);
                    info.Width = surfaceCapabilities.CurrentExtent.Width;
                    info.Height = surfaceCapabilities.CurrentExtent.Height;
                }
                framebuffers[i] = device.CreateFramebuffer(ref info);
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
            }
            var info = new VkRenderPassCreateInfo();
            {
                info.SType = VkStructureType.RenderPassCreateInfo;
                new VkAttachmentDescription[] { attDesc }.Set(ref info.Attachments, ref info.AttachmentCount);
                new VkSubpassDescription[] { subpassDesc }.Set(ref info.Subpasses, ref info.SubpassCount);
            }

            return device.CreateRenderPass(ref info);
        }

        protected VkSwapchainKhr CreateSwapchain(VkDevice device, VkSurfaceKhr surface, VkSurfaceFormatKhr surfaceFormat, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.SupportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKhr.Inherit)
                ? VkCompositeAlphaFlagsKhr.Inherit
                : VkCompositeAlphaFlagsKhr.Opaque;
            var info = new VkSwapchainCreateInfoKhr();
            {
                info.SType = VkStructureType.SwapchainCreateInfoKhr;
                info.Surface = surface.handle;
                info.MinImageCount = surfaceCapabilities.MinImageCount;
                info.ImageFormat = surfaceFormat.Format;
                info.ImageColorSpace = surfaceFormat.ColorSpace;
                info.ImageExtent = surfaceCapabilities.CurrentExtent;
                info.ImageUsage = VkImageUsageFlags.ColorAttachment;
                info.PreTransform = VkSurfaceTransformFlagsKhr.Identity;
                info.ImageArrayLayers = 1;
                info.ImageSharingMode = VkSharingMode.Exclusive;
                new UInt32[] { 0 }.Set(ref info.QueueFamilyIndices, ref info.QueueFamilyIndexCount);
                info.PresentMode = VkPresentModeKhr.Fifo;
                info.CompositeAlpha = compositeAlpha;
            }

            return device.CreateSwapchainKHR(ref info, null);
        }

        protected VkSurfaceFormatKhr SelectFormat(VkPhysicalDevice physicalDevice, VkSurfaceKhr surface) {
            VkSurfaceFormatKhr[] formats;
            physicalDevice.GetSurfaceFormatsKhr(surface, out formats);
            foreach (var f in formats)
                if (f.Format == VkFormat.R8G8B8A8Unorm || f.Format == VkFormat.B8G8R8A8Unorm)
                    return f;

            throw new System.Exception("didn't find the R8G8B8A8Unorm or B8G8R8A8Unorm format");
        }

        private VkDevice CreateDevice(VkPhysicalDevice physicalDevice, VkSurfaceKhr surface) {
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

        private VkPhysicalDevice InitPhysicalDevice(VkInstance instance) {
            VkPhysicalDevice[] physicalDevices;
            instance.EnumeratePhysicalDevices(out physicalDevices);
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
                UInt32 version = Vulkan.Version.Make(1, 0, 0);
                appInfo.ApiVersion = version;
            }

            var extensions = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" };

            var info = new VkInstanceCreateInfo();
            {
                info.SType = VkStructureType.InstanceCreateInfo;
                extensions.Set(ref info.EnabledExtensionNames, ref info.EnabledExtensionCount);
                layersToEnable.Set(ref info.EnabledLayerNames, ref info.EnabledLayerCount);
                info.ApplicationInfo = &appInfo;
            }

            VkInstance result;
            VkInstance.Create(ref info, null, out result).Check();

            return result;
        }

        private VkSubmitInfo[] submitInfos;
        private VkPresentInfoKhr[] presentInfos;

        private void InitRenderParams() {
            VkDevice device = this.vkDevice; VkSwapchainKhr swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;

            submitInfos = new VkSubmitInfo[2]; presentInfos = new VkPresentInfoKhr[2];
            for (uint index = 0; index < 2; index++) {
                var submitInfo = new VkSubmitInfo();
                {
                    new UInt64[] { semaphore.handle }.Set(ref submitInfo.WaitSemaphores, ref submitInfo.WaitSemaphoreCount);
                    // I have to use int instead of enum VkPipelineStageFlags.
                    new int[] { (int)VkPipelineStageFlags.AllGraphics }.Set(ref submitInfo.WaitDstStageMask, ref submitInfo.WaitSemaphoreCount);
                    new IntPtr[] { commandBuffers[index].handle }.Set(ref submitInfo.CommandBuffers, ref submitInfo.CommandBufferCount);
                }
                submitInfos[index] = submitInfo;
                var presentInfo = new VkPresentInfoKhr();
                {
                    presentInfo.SType = VkStructureType.PresentInfoKhr;
                    new UInt64[] { swapchain.handle }.Set(ref presentInfo.Swapchains, ref presentInfo.SwapchainCount);
                    new uint[] { index }.Set(ref presentInfo.ImageIndices, ref presentInfo.SwapchainCount);
                }
                presentInfos[index] = presentInfo;
            }
        }

        public void Render() {
            if (!isInitialized) return;
            if (this.submitInfos == null) {
                InitRenderParams();
            }

            VkDevice device = this.vkDevice; VkSwapchainKhr swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;
            uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            device.ResetFence(fence);

            queue.Submit(ref this.submitInfos[nextIndex], fence);
            device.WaitForFence(fence, true, 100000000);
            queue.PresentKHR(ref this.presentInfos[nextIndex]);
        }
    }
}
