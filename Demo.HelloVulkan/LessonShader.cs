using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Vulkan;
using static Vulkan.VkStructureType;
using static Vulkan.vkAPI;
using System.IO;

namespace Demo.HelloVulkan {
    unsafe class LessonShader {
        const float value = 1f;
        static readonly float[] Vertices = {
            // left up, right up.
            -value, -value, -value, value,
            // left down, right down.
             value, -value,  value, value
        };
        static readonly short[] Indexes = {
            // ieft up triangle.
            0, 1, 2,
            // right down triangle.
            1, 2, 3
        };

        VkInstance instance;
        VkDebugReportCallbackEXT debugReportcallback;
        VkSurfaceKHR surface;
        VkPhysicalDevice vkPhysicalDevice;

        VkDevice device;
        VkQueue vkQueue;
        VkSwapchainKHR swapchain;
        VkImage[] vkImages;
        VkRenderPass renderPass;
        VkFramebuffer[] framebuffers;
        VkFence vkFence;
        VkSemaphore vkSemaphore;
        //
        VkBuffer uniformBuffer;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s.
        /// </summary>
        VkDescriptorSetLayout descriptorSetLayout;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s and <see cref="VkPushConstantRange"/>s.
        /// </summary>
        VkPipelineLayout vkPipelineLayout;
        VkDescriptorSet descriptorSet;

        VkCommandBuffer[] commandBuffers;

        VkBuffer vkBuffer;
        VkDeviceMemory vkDeviceMemory;
        UInt64 uniformSize;

        bool isInitialized = false;

        private float originalWidth;
        private float originalHeight;
        private float width;
        private float height;

        public void UpdateSize() {
            if (width == originalWidth) {
                width = originalWidth / 2;
                height = originalHeight / 2;
            }
            else {
                width = originalWidth;
                height = originalHeight;
            }
            var uniformBufferData = new AreaUniformBuffer(width, height);
            var length = 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AreaUniformBuffer)) * length;
            VkDevice device = this.device; VkDeviceMemory deviceMemory = this.vkDeviceMemory;
            {
                IntPtr memPtr = IntPtr.Zero;
                vkAPI.vkMapMemory(device, deviceMemory, 0, (UInt64)size, 0, &memPtr).Check();

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

            this.instance = InitInstance();
            InitDebugCallback(this.instance);
            this.surface = InitSurface(this.instance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice(this.instance);
            VkSurfaceFormatKHR surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.surface);

            this.device = CreateDevice(this.vkPhysicalDevice, this.surface);

            this.vkQueue = this.device.GetQueue(0, 0);

            VkSurfaceCapabilitiesKHR surfaceCapabilities;
            //this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);
            vkAPI.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.vkPhysicalDevice, this.surface, &surfaceCapabilities).Check();

            this.swapchain = CreateSwapchain(this.device, this.surface, surfaceFormat, surfaceCapabilities);

            this.vkImages = this.device.GetSwapchainImages(this.swapchain);

            this.renderPass = CreateRenderPass(this.device, surfaceFormat);

            this.framebuffers = CreateFramebuffers(this.device, this.vkImages, surfaceFormat, this.renderPass, surfaceCapabilities);

            this.vkFence = this.device.CreateFence();
            this.vkSemaphore = this.device.CreateSemaphore();

            // buffers for vertex data.
            VkBuffer vertexBuffer = CreateBuffer(this.vkPhysicalDevice, this.device, Vertices, VkBufferUsageFlagBits.VertexBuffer, typeof(float));

            VkBuffer indexBuffer = CreateBuffer(this.vkPhysicalDevice, this.device, Indexes, VkBufferUsageFlagBits.IndexBuffer, typeof(short));

            var uniformBufferData = new AreaUniformBuffer(1, 1);
            this.originalWidth = 1; this.width = this.originalWidth;
            this.originalHeight = 1; this.height = this.originalHeight;

            this.uniformBuffer = CreateBuffer(this.vkPhysicalDevice, this.device, uniformBufferData, VkBufferUsageFlagBits.UniformBuffer, typeof(AreaUniformBuffer));

            this.descriptorSetLayout = CreateDescriptorSetLayout(this.device);

            this.vkPipelineLayout = CreatePipelineLayout(this.device, this.descriptorSetLayout);

            VkPipeline pipeline = CreatePipeline(this.device, surfaceCapabilities, this.renderPass, this.vkPipelineLayout);

            this.descriptorSet = CreateDescriptorSet(this.device, this.descriptorSetLayout);

            UpdateDescriptorSets(this.device, this.uniformBuffer, this.descriptorSet);

            this.commandBuffers = CreateCommandBuffers(
                this.device, this.renderPass, surfaceCapabilities,
                this.vkImages, this.framebuffers, pipeline,
                vertexBuffer, indexBuffer, (uint)Indexes.Length,
                this.vkPipelineLayout, this.descriptorSet);

            this.isInitialized = true;
        }

        /// <summary>
        /// Application-defined debug report callback function.
        /// </summary>
        /// <param name="flags">flags specifies the VkDebugReportFlagBitsEXT that triggered
        /// this callback</param>
        /// <param name="objectType">objectType is a VkDebugReportObjectTypeEXT value specifying
        /// the type of object being used or created at the time the event was
        /// triggered</param>
        /// <param name="objectHandle">object is the object where the issue was detected.
        /// If objectType is VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT,
        /// object is undefined</param>
        /// <param name="location">location is a component (layer, driver, loader) defined value that
        /// specifies the location of the trigger.
        /// This is an optional value</param>
        /// <param name="messageCode">summary>messageCode is a layer-defined value indicating what test
        /// triggered this callback</param>
        /// <param name="layerPrefix">pLayerPrefix is a null-terminated string that is an abbreviation
        /// of the name of the component making the callback.
        /// pLayerPrefix is only valid for the duration of the callback</param>
        /// <param name="message">pMessage is a null-terminated string detailing the trigger
        /// conditions.
        /// pMessage is only valid for the duration of the callback</param>
        /// <param name="userData">pUserData is the user data given when the
        /// VkDebugReportCallbackEXT was created</param>
        /// <returns></returns>
        private VkBool32 DebugCallback(VkDebugReportFlagBitsEXT flags,
            VkDebugReportObjectTypeEXT objectType,
            UInt64 objectHandle, Int32 location, Int32 messageCode,
            IntPtr layerPrefix, IntPtr message, IntPtr userData) {
            string text = $"{flags}: {Marshal.PtrToStringAnsi(message)}";
            Debug.WriteLine(text);
            using (var sw = new StreamWriter(debugFilename, true)) {
                sw.WriteLine(text);
            }
            return true;
        }

        string debugFilename = "HelloVulkanDump.log";


        //IntPtr ptrCallback;
        private void InitDebugCallback(VkInstance instance) {
            var delDebugCallback = new PFN_vkDebugReportCallbackEXT(DebugCallback);
            //var info = new VkDebugReportCallbackCreateInfoEXT { sType = VkStructureType.DebugReportCallbackCreateInfoEXT };
            VkDebugReportCallbackCreateInfoEXT info;
            info.sType = VkStructureType.DebugReportCallbackCreateInfoEXT;
            info.flags = VkDebugReportFlagBitsEXT.DebugEXT | VkDebugReportFlagBitsEXT.ErrorEXT
                | VkDebugReportFlagBitsEXT.PerformanceWarningEXT | VkDebugReportFlagBitsEXT.WarningEXT
                | VkDebugReportFlagBitsEXT.InformationEXT;
            var ptrCallback = Marshal.GetFunctionPointerForDelegate(delDebugCallback);
            info.pfnCallback = ptrCallback;

            VkDebugReportCallbackEXT callback;
            vkAPI.CreateDebugReportCallbackEXT(instance, &info, null, &callback).Check();
            // or: instance.CreateDebugReportCallbackEXT(&info, null, &callback).Check();
            this.debugReportcallback = callback;
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
                    var info = new VkCommandPoolCreateInfo { sType = VkStructureType.CommandPoolCreateInfo };
                    info.flags = VkCommandPoolCreateFlagBits.ResetCommandBuffer;
                    //var commandPool = device.CreateCommandPool(ref poolInfo);
                    vkCreateCommandPool(device, &info, null, &pool).Check();
                }
                {
                    var info = new VkCommandBufferAllocateInfo { sType = VkStructureType.CommandBufferAllocateInfo };
                    info.level = VkCommandBufferLevel.Primary;
                    info.commandPool = pool;
                    info.commandBufferCount = (uint)images.Length;
                    //buffers = device.AllocateCommandBuffers(ref info);
                    buffers = new VkCommandBuffer[info.commandBufferCount];
                    fixed (VkCommandBuffer* pointer = buffers) {
                        vkAPI.vkAllocateCommandBuffers(device, &info, pointer).Check();
                    }
                }
            }

            var cmdBeginInfo = new VkCommandBufferBeginInfo { sType = VkStructureType.CommandBufferBeginInfo };
            var clearValue = new VkClearValue { color = new VkClearColorValue(0.9f, 0.87f, 0.75f, 1.0f) };
            var begin = new VkRenderPassBeginInfo { sType = VkStructureType.RenderPassBeginInfo };
            begin.renderPass = renderPass;
            begin.clearValues = clearValue;
            begin.renderArea = new VkRect2D { extent = surfaceCapabilities.currentExtent };
            for (int i = 0; i < images.Length; i++) {
                VkCommandBuffer cmds = buffers[i];
                //cmds.Begin(ref cmdBeginInfo);
                vkAPI.vkBeginCommandBuffer(cmds, &cmdBeginInfo).Check();
                begin.framebuffer = framebuffers[i];
                vkAPI.vkCmdBeginRenderPass(cmds, &begin, VkSubpassContents.Inline);
                vkAPI.vkCmdBindDescriptorSets(cmds, VkPipelineBindPoint.Graphics, pipelineLayout,
                    0, 1, &descriptorSet,
                    0, null);
                vkAPI.vkCmdBindPipeline(cmds, VkPipelineBindPoint.Graphics, pipeline);
                VkDeviceSize offset = 0;
                vkAPI.vkCmdBindVertexBuffers(cmds, 0, 1, &vertexBuffer, &offset);
                vkAPI.vkCmdBindIndexBuffer(cmds, indexBuffer, offset, VkIndexType.Uint16);
                vkAPI.vkCmdDrawIndexed(cmds, indexLength, 1, 0, 0, 0);
                vkAPI.vkCmdEndRenderPass(cmds);
                vkAPI.vkEndCommandBuffer(cmds).Check();
            }

            begin.Free();

            return buffers;
        }

        void UpdateDescriptorSets(VkDevice device, VkBuffer uniformBuffer, VkDescriptorSet descriptorSet) {
            var write = new VkWriteDescriptorSet { sType = VkStructureType.WriteDescriptorSet };
            write.dstSet = descriptorSet;
            write.data.descriptorType = VkDescriptorType.UniformBuffer;
            var info = new VkDescriptorBufferInfo(uniformBuffer, 0, 2 * sizeof(float));
            write.data.Set(info);

            //device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { write }, null);
            vkAPI.vkUpdateDescriptorSets(device, 1, &write, 0, null);

            write.Free();
        }

        VkDescriptorSet CreateDescriptorSet(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            VkDescriptorPool descriptorPool;
            {
                // this pool can allocate one uniform descriptor.
                var info = new VkDescriptorPoolCreateInfo { sType = VkStructureType.DescriptorPoolCreateInfo };
                var size = new VkDescriptorPoolSize(VkDescriptorType.UniformBuffer, 1);
                info.poolSizes = size;
                info.maxSets = 1;
                vkAPI.vkCreateDescriptorPool(device, &info, null, &descriptorPool).Check();
                info.Free();
            }
            VkDescriptorSet descriptorSet;
            {
                var info = new VkDescriptorSetAllocateInfo { sType = VkStructureType.DescriptorSetAllocateInfo };
                info.setLayouts = descriptorSetLayout;
                info.descriptorPool = descriptorPool;
                vkAPI.vkAllocateDescriptorSets(device, &info, &descriptorSet).Check();
                info.Free();
            }

            return descriptorSet;
        }


        VkPipeline CreatePipeline(VkDevice device, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkRenderPass renderPass, VkPipelineLayout pipelineLayout) {
            //VkShaderModule vertexShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.vert.spv"));
            VkShaderModule vsModule;
            {
                var info = new VkShaderModuleCreateInfo { sType = VkStructureType.ShaderModuleCreateInfo };
                byte[] bytes = LoadResource(@"Shaders\shader.vert.spv");
                info.code = bytes;
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, &info, null, &vsModule).Check();
                info.Free();
            }
            //VkShaderModule fragmentShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.frag.spv"));
            VkShaderModule fsModule;
            {
                var info = new VkShaderModuleCreateInfo { sType = VkStructureType.ShaderModuleCreateInfo };
                byte[] bytes = LoadResource(@"Shaders\shader.frag.spv");
                info.code = bytes;
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, &info, null, &fsModule).Check();
                info.Free();
            }
            var shaderStages = new VkPipelineShaderStageCreateInfo[2];
            {
                shaderStages[0].sType = VkStructureType.PipelineShaderStageCreateInfo;
                shaderStages[0].stage = VkShaderStageFlagBits.Vertex;
                shaderStages[0].module = vsModule;
                //"main".Set(ref shaderStages[0].pName);
                shaderStages[0].pName = "main";
                shaderStages[1].sType = VkStructureType.PipelineShaderStageCreateInfo;
                shaderStages[1].stage = VkShaderStageFlagBits.Fragment;
                shaderStages[1].module = fsModule;
                //"main".Set(ref shaderStages[1].pName);
                shaderStages[1].pName = "main";
            }
            var viewport = new VkPipelineViewportStateCreateInfo { sType = VkStructureType.PipelineViewportStateCreateInfo };
            viewport.viewports = new VkViewport(surfaceCapabilities.currentExtent, 0.0f, 1.0f);
            viewport.scissors = new VkRect2D(surfaceCapabilities.currentExtent);

            var multisample = new VkPipelineMultisampleStateCreateInfo { sType = VkStructureType.PipelineMultisampleStateCreateInfo };
            multisample.rasterizationSamples = VkSampleCountFlagBits._1;

            var colorBlend = new VkPipelineColorBlendStateCreateInfo { sType = VkStructureType.PipelineColorBlendStateCreateInfo };
            colorBlend.logicOp = VkLogicOp.Copy;
            var blend = new VkPipelineColorBlendAttachmentState(
                colorWriteMask: VkColorComponentFlagBits.R | VkColorComponentFlagBits.G
                | VkColorComponentFlagBits.B | VkColorComponentFlagBits.A,
                blendEnable: false);
            colorBlend.attachments = blend;

            var rasterization = new VkPipelineRasterizationStateCreateInfo { sType = VkStructureType.PipelineRasterizationStateCreateInfo };
            rasterization.polygonMode = VkPolygonMode.Fill;
            rasterization.cullMode = VkCullModeFlagBits.None;
            rasterization.frontFace = VkFrontFace.Clockwise;
            rasterization.lineWidth = 1.0f;

            var inputAssem = new VkPipelineInputAssemblyStateCreateInfo { sType = VkStructureType.PipelineInputAssemblyStateCreateInfo };
            inputAssem.topology = VkPrimitiveTopology.TriangleList;

            var input = new VkPipelineVertexInputStateCreateInfo { sType = VkStructureType.PipelineVertexInputStateCreateInfo };
            // static readonly float[] Vertices = { .. }
            input.vertexBindingDescriptions = new VkVertexInputBindingDescription(
                binding: 0,
                stride: 2 * sizeof(float),
                inputRate: VkVertexInputRate.Vertex);
            // layout(location = 0) in vec2 inPos;
            input.vertexAttributeDescriptions = new VkVertexInputAttributeDescription(
                location: 0,
                binding: 0,
                format: VkFormat.R32g32Sfloat,
                offset: 0);

            //VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            VkPipelineCache cache;
            {
                var info = VkPipelineCacheCreateInfo.Alloc();
                vkAPI.vkCreatePipelineCache(device, info, null, &cache).Check();
                Marshal.FreeHGlobal((IntPtr)info);
            }
            //var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            //return device.CreateGraphicsPipelines(ref cache, infos);
            VkPipeline pipeline;
            {
                var info = new VkGraphicsPipelineCreateInfo { sType = VkStructureType.GraphicsPipelineCreateInfo };
                info.layout = pipelineLayout;
                info.pViewportState = &viewport;
                info.stages = shaderStages;
                info.pMultisampleState = &multisample;
                info.pColorBlendState = &colorBlend;
                info.pRasterizationState = &rasterization;
                info.pInputAssemblyState = &inputAssem;
                info.pVertexInputState = &input;
                info.renderPass = renderPass;
                vkAPI.vkCreateGraphicsPipelines(device, cache, 1, &info, null, &pipeline).Check();
                info.Free();
            }

            shaderStages[0].Free();
            shaderStages[1].Free();
            viewport.Free();
            colorBlend.Free();
            input.Free();

            return pipeline;
        }

        VkPipelineLayout CreatePipelineLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            var info = new VkPipelineLayoutCreateInfo { sType = VkStructureType.PipelineLayoutCreateInfo };
            info.setLayouts = descriptorSetLayout;
            //return device.CreatePipelineLayout(ref info);
            VkPipelineLayout layout;
            vkAPI.vkCreatePipelineLayout(device, &info, null, &layout).Check();
            info.Free();

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
            var info = new VkDescriptorSetLayoutCreateInfo { sType = VkStructureType.DescriptorSetLayoutCreateInfo };
            info.bindings = new VkDescriptorSetLayoutBinding(
                binding: 0,
                descriptorType: VkDescriptorType.UniformBuffer, // uniform 
                descriptorCount: 1, // single variable, not array.
                stageFlags: VkShaderStageFlagBits.Vertex); // in a vertex shader.

            //return device.CreateDescriptorSetLayout(ref info);
            VkDescriptorSetLayout layout;
            vkAPI.vkCreateDescriptorSetLayout(device, &info, null, &layout).Check();
            info.Free();

            return layout;
        }

        VkBuffer CreateBuffer(VkPhysicalDevice physicalDevice, VkDevice device, object values, VkBufferUsageFlagBits usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            VkBuffer buffer;
            {
                UInt32 index = 0;
                var info = new VkBufferCreateInfo { sType = VkStructureType.BufferCreateInfo };
                info.size = (UInt64)size;
                info.usage = usageFlags;
                info.sharingMode = VkSharingMode.Exclusive;
                info.queueFamilyIndices = index;
                //VkBuffer buffer = device.CreateBuffer(ref info);
                vkAPI.vkCreateBuffer(device, &info, null, &buffer).Check();
                info.Free();
            }
            VkDeviceMemory deviceMemory; // = device.AllocateMemory(ref allocInfo);
            VkMemoryRequirements memoryReq;
            //VkMemoryRequirements memoryReq = device.GetBufferMemoryRequirements(buffer);
            vkAPI.vkGetBufferMemoryRequirements(device, buffer, &memoryReq);
            var allocInfo = new VkMemoryAllocateInfo { sType = VkStructureType.MemoryAllocateInfo };
            {
                allocInfo.allocationSize = memoryReq.size;
                VkPhysicalDeviceMemoryProperties memoryProperties;
                vkAPI.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memoryProperties);
                allocInfo.memoryTypeIndex = GetMemoryTypeIndex(memoryProperties, memoryReq,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);
                vkAPI.vkAllocateMemory(device, &allocInfo, null, &deviceMemory).Check();
            }
            {
                IntPtr memPtr = IntPtr.Zero;
                vkAPI.vkMapMemory(device, deviceMemory, 0, (UInt64)size, 0, &memPtr).Check();

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
            vkAPI.vkBindBufferMemory(device, buffer, deviceMemory, 0).Check();

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

        protected VkFramebuffer[] CreateFramebuffers(VkDevice device, VkImage[] images,
            VkSurfaceFormatKHR surfaceFormat, VkRenderPass renderPass,
            VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var displayViews = new VkImageView[images.Length];
            var viewInfo = new VkImageViewCreateInfo { sType = VkStructureType.ImageViewCreateInfo };
            viewInfo.viewType = VkImageViewType._2d;
            viewInfo.format = surfaceFormat.format;
            viewInfo.components = new VkComponentMapping {
                r = VkComponentSwizzle.R,
                g = VkComponentSwizzle.G,
                b = VkComponentSwizzle.B,
                a = VkComponentSwizzle.A
            };
            viewInfo.subresourceRange = new VkImageSubresourceRange {
                aspectMask = VkImageAspectFlagBits.Color,
                levelCount = 1,
                layerCount = 1
            };
            for (int i = 0; i < images.Length; i++) {
                viewInfo.image = images[i];
                //displayViews[i] = device.CreateImageView(ref info);
                VkImageView view;
                vkAPI.vkCreateImageView(device, &viewInfo, null, &view).Check();
                displayViews[i] = view;
            }

            var framebuffers = new VkFramebuffer[images.Length];
            var fbInfo = new VkFramebufferCreateInfo { sType = VkStructureType.FramebufferCreateInfo };
            fbInfo.layers = 1;
            fbInfo.renderPass = renderPass;
            fbInfo.width = surfaceCapabilities.currentExtent.width;
            fbInfo.height = surfaceCapabilities.currentExtent.height;
            for (int i = 0; i < images.Length; i++) {
                fbInfo.attachments = displayViews[i];
                //framebuffers[i] = device.CreateFramebuffer(ref info);
                VkFramebuffer framebuffer;
                vkAPI.vkCreateFramebuffer(device, &fbInfo, null, &framebuffer).Check();
                framebuffers[i] = framebuffer;
            }

            fbInfo.Free();

            return framebuffers;
        }

        protected VkRenderPass CreateRenderPass(VkDevice device, VkSurfaceFormatKHR surfaceFormat) {
            var attDesc = new VkAttachmentDescription(surfaceFormat.format, VkSampleCountFlagBits._1,
                 VkAttachmentLoadOp.Clear, VkAttachmentStoreOp.Store,
                 VkAttachmentLoadOp.DontCare, VkAttachmentStoreOp.DontCare,
                 VkImageLayout.Undefined, VkImageLayout.PresentSrcKHR, 0);
            var subpassDesc = new VkSubpassDescription(VkPipelineBindPoint.Graphics);
            subpassDesc.colorAttachments = new VkAttachmentReference(VkImageLayout.ColorAttachmentOptimal, 0);
            var info = new VkRenderPassCreateInfo { sType = VkStructureType.RenderPassCreateInfo };
            info.attachments = attDesc;
            info.subpasses = subpassDesc;

            //return device.CreateRenderPass(ref info);
            VkRenderPass renderPass;
            vkAPI.vkCreateRenderPass(device, &info, null, &renderPass).Check();

            info.Free();
            subpassDesc.Free();

            return renderPass;
        }

        protected VkSwapchainKHR CreateSwapchain(VkDevice device, VkSurfaceKHR surface,
            VkSurfaceFormatKHR surfaceFormat, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.supportedCompositeAlpha.HasFlag(
                VkCompositeAlphaFlagBitsKHR.InheritKHR)
                ? VkCompositeAlphaFlagBitsKHR.InheritKHR
                : VkCompositeAlphaFlagBitsKHR.OpaqueKHR;
            UInt32 index = 0;
            var info = new VkSwapchainCreateInfoKHR { sType = VkStructureType.SwapchainCreateInfoKHR };
            info.surface = surface;
            info.minImageCount = surfaceCapabilities.minImageCount;
            info.imageFormat = surfaceFormat.format;
            info.imageColorSpace = surfaceFormat.colorSpace;
            info.imageExtent = surfaceCapabilities.currentExtent;
            info.imageUsage = VkImageUsageFlagBits.ColorAttachment;
            info.preTransform = VkSurfaceTransformFlagBitsKHR.IdentityKHR;
            info.imageArrayLayers = 1;
            info.imageSharingMode = VkSharingMode.Exclusive;
            info.queueFamilyIndices = index;
            info.presentMode = VkPresentModeKHR.FifoKHR;
            info.compositeAlpha = compositeAlpha;
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
            VkQueueFamilyProperties[] properties = vkAPI.QueueFamilyProperties(physicalDevice);
            uint index;
            for (index = 0; index < properties.Length; ++index) {
                VkBool32 supported;
                //physicalDevice.GetSurfaceSupportKHR(index, surface, out supported);
                vkAPI.vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, index, surface, &supported).Check();
                if (!supported) { continue; }

                if (properties[index].queueFlags.HasFlag(VkQueueFlagBits.Graphics)) break;
            }

            var queueInfo = new VkDeviceQueueCreateInfo { sType = VkStructureType.DeviceQueueCreateInfo };
            queueInfo.queuePriorities = 1.0f;
            queueInfo.queueFamilyIndex = index;

            var info = new VkDeviceCreateInfo { sType = VkStructureType.DeviceCreateInfo };
            info.EnabledExtensions = vkAPI.VK_KHR_swapchain;
            info.queueCreateInfos = queueInfo;

            VkDevice vkDevice;
            //physicalDevice.CreateDevice(ref deviceInfo, null, out device);
            vkAPI.vkCreateDevice(physicalDevice, &info, null, &vkDevice).Check();

            info.Free();
            queueInfo.Free();

            return vkDevice;
        }

        private VkPhysicalDevice InitPhysicalDevice(VkInstance instance) {

            VkPhysicalDevice[] physicalDevices = vkAPI.PhysicalDevices(instance);

            return physicalDevices[0];
        }

        private VkSurfaceKHR InitSurface(VkInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKHR { sType = VkStructureType.Win32SurfaceCreateInfoKHR };
            info.hwnd = hwnd;
            info.hinstance = processHandle; //Process.GetCurrentProcess().Handle

            VkSurfaceKHR vkSurface;
            vkAPI.vkCreateWin32SurfaceKHR(instance, &info, null, &vkSurface).Check();

            return vkSurface;
        }

        private const string VK_LAYER_LUNARG_standard_validation = "VK_LAYER_LUNARG_standard_validation";
        private VkInstance InitInstance() {
            var extensions = new string[] { vkAPI.VK_KHR_surface, vkAPI.VK_KHR_win32_surface, vkAPI.VK_EXT_debug_report };

            VkLayerProperties[] layerProperties = vkAPI.InstanceLayerProperties();
            string layers = layerProperties.Any(
                l => Marshal.PtrToStringAnsi((IntPtr)l.layerName) == VK_LAYER_LUNARG_standard_validation)
                ? VK_LAYER_LUNARG_standard_validation
                : null;

            var appInfo = new VkApplicationInfo { sType = VkStructureType.ApplicationInfo };
            appInfo.apiVersion = Vulkan.VkVersion.Make(1, 0, 0);
            appInfo.pApplicationName = "Hello Vulkan";
            appInfo.pEngineName = "Hello Engine";

            var info = new VkInstanceCreateInfo { sType = VkStructureType.InstanceCreateInfo };
            info.EnabledExtensions = extensions;
            info.EnabledLayers = layers;
            info.pApplicationInfo = &appInfo;

            VkInstance vkInstance;
            vkAPI.vkCreateInstance(&info, null, &vkInstance).Check();

            info.Free();
            appInfo.Free();

            return vkInstance;
        }

        private VkSubmitInfo* submitInfos;
        private VkPresentInfoKHR* presentInfos;

        private void InitRenderParams() {
            VkSwapchainKHR swapchain = this.swapchain;
            VkSemaphore semaphore = this.vkSemaphore;
            VkCommandBuffer[] commandBuffers = this.commandBuffers;

            submitInfos = VkSubmitInfo.Alloc(2);
            presentInfos = VkPresentInfoKHR.Alloc(2);
            for (uint index = 0; index < 2; index++) {
                //submitInfos[index].waitSemaphoresDstStageMasks.Set(semaphore);
                submitInfos[index].waitSemaphores = semaphore;
                submitInfos[index].waitSemaphoresDstStageMasks.Set(VkPipelineStageFlagBits.AllGraphics);
                submitInfos[index].commandBuffers = commandBuffers[index];

                presentInfos[index].swapchains = swapchain;
                //presentInfo->swapchainsImages.Set(swapchain);
                presentInfos[index].swapchainsImages.Set(index);
            }
        }

        public void Render() {
            if (!isInitialized) return;

            if (this.submitInfos == null) {
                InitRenderParams();
            }

            VkDevice device = this.device; VkSwapchainKHR swapchain = this.swapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkQueue queue = this.vkQueue;
            //uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            UInt32 nextIndex;
            vkAPI.vkAcquireNextImageKHR(device, swapchain, ulong.MaxValue,
                semaphore, new VkFence(), &nextIndex).Check();
            //device.ResetFence(fence);
            vkAPI.vkResetFences(device, 1, &fence).Check();

            //queue.Submit(ref this.submitInfos[nextIndex], fence);
            //VkSubmitInfo submitInfo = this.submitInfos[nextIndex];
            //vkAPI.vkQueueSubmit(queue, 1, &submitInfo, fence).Check();
            vkAPI.vkQueueSubmit(queue, 1, &this.submitInfos[nextIndex], fence).Check();
            //device.WaitForFence(fence, true, 100000000);
            vkAPI.vkWaitForFences(device, 1, &fence, true, 100000000).Check();
            //queue.PresentKHR(ref this.presentInfos[nextIndex]);
            //VkPresentInfoKHR presentInfo = this.presentInfos[nextIndex];
            //vkAPI.vkQueuePresentKHR(queue, &presentInfo).Check();
            vkAPI.vkQueuePresentKHR(queue, &this.presentInfos[nextIndex]).Check();
        }
    }
}
