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

        string debugFilename = "HelloVulkanDump.txt";

        PFN_vkDebugReportCallbackEXT delDebugCallback;

        private void InitDebugCallback(VkInstance instance) {
            if (delDebugCallback == null) {
                delDebugCallback = new PFN_vkDebugReportCallbackEXT(DebugCallback);
            }
            var info = VkDebugReportCallbackCreateInfoEXT.Alloc();
            info->flags = VkDebugReportFlagBitsEXT.DebugExt | VkDebugReportFlagBitsEXT.ErrorExt
                | VkDebugReportFlagBitsEXT.PerformanceWarningExt | VkDebugReportFlagBitsEXT.WarningExt
                | VkDebugReportFlagBitsEXT.InformationExt;
            info->pfnCallback = Marshal.GetFunctionPointerForDelegate(delDebugCallback);

            VkDebugReportCallbackEXT callback;
            vkCreateDebugReportCallback(instance, info, null, &callback).Check();
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
                    var info = VkCommandPoolCreateInfo.Alloc();
                    info->flags = VkCommandPoolCreateFlagBits.ResetCommandBuffer;
                    //var commandPool = device.CreateCommandPool(ref poolInfo);
                    vkCreateCommandPool(device, info, null, &pool).Check();
                }
                {
                    var info = VkCommandBufferAllocateInfo.Alloc();
                    info->level = VkCommandBufferLevel.Primary;
                    info->commandPool = pool;
                    info->commandBufferCount = (uint)images.Length;
                    //buffers = device.AllocateCommandBuffers(ref info);
                    buffers = new VkCommandBuffer[info->commandBufferCount];
                    fixed (VkCommandBuffer* pointer = buffers) {
                        vkAPI.vkAllocateCommandBuffers(device, info, pointer).Check();
                    }
                }
            }

            var cmdBeginInfo = VkCommandBufferBeginInfo.Alloc();
            var clearValue = new VkClearValue { color = new VkClearColorValue(0.9f, 0.87f, 0.75f, 1.0f) };
            var begin = VkRenderPassBeginInfo.Alloc();
            begin->renderPass = renderPass;
            clearValue.Set(begin);
            begin->renderArea = new VkRect2D { extent = surfaceCapabilities.currentExtent };
            for (int i = 0; i < images.Length; i++) {
                VkCommandBuffer cmds = buffers[i];
                //cmds.Begin(ref cmdBeginInfo);
                vkAPI.vkBeginCommandBuffer(cmds, cmdBeginInfo).Check();
                begin->framebuffer = framebuffers[i];
                vkAPI.vkCmdBeginRenderPass(cmds, begin, VkSubpassContents.Inline);
                {
                    vkAPI.vkCmdBindDescriptorSets(cmds, VkPipelineBindPoint.Graphics,
                        pipelineLayout, 0, 1, &descriptorSet, 0, null);
                    vkAPI.vkCmdBindPipeline(cmds, VkPipelineBindPoint.Graphics, pipeline);
                    VkDeviceSize offset = 0;
                    vkAPI.vkCmdBindVertexBuffers(cmds, 0, 1, &vertexBuffer, &offset);
                    vkAPI.vkCmdBindIndexBuffer(cmds, indexBuffer, offset, VkIndexType.Uint16);
                    vkAPI.vkCmdDrawIndexed(cmds, indexLength, 1, 0, 0, 0);
                }
                vkAPI.vkCmdEndRenderPass(cmds);
                vkAPI.vkEndCommandBuffer(cmds).Check();
            }

            return buffers;
        }

        void UpdateDescriptorSets(VkDevice device, VkBuffer uniformBuffer, VkDescriptorSet descriptorSet) {
            var write = VkWriteDescriptorSet.Alloc();
            write->dstSet = descriptorSet;
            write->descriptorType = VkDescriptorType.UniformBuffer;
            var info = new VkDescriptorBufferInfo(uniformBuffer, 0, 2 * sizeof(float));
            info.Set(write);

            //device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { write }, null);
            vkAPI.vkUpdateDescriptorSets(device, 1, write, 0, null);
        }

        VkDescriptorSet CreateDescriptorSet(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            VkDescriptorPool descriptorPool;
            {
                // this pool can allocate one uniform descriptor.
                var info = VkDescriptorPoolCreateInfo.Alloc();
                var size = new VkDescriptorPoolSize(VkDescriptorType.UniformBuffer, 1);
                size.Set(info);
                info->maxSets = 1;
                vkAPI.vkCreateDescriptorPool(device, info, null, &descriptorPool).Check();
            }
            VkDescriptorSet descriptorSet;
            {
                var info = VkDescriptorSetAllocateInfo.Alloc();
                descriptorSetLayout.Set(info);
                info->descriptorPool = descriptorPool;
                vkAPI.vkAllocateDescriptorSets(device, info, &descriptorSet).Check().Check();
            }

            return descriptorSet;
        }


        VkPipeline CreatePipeline(VkDevice device, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkRenderPass renderPass, VkPipelineLayout pipelineLayout) {
            //VkShaderModule vertexShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.vert.spv"));
            VkShaderModule vsModule;
            {
                var info = VkShaderModuleCreateInfo.Alloc();
                byte[] bytes = LoadResource(@"Shaders\shader.vert.spv");
                bytes.Set(info);
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, info, null, &vsModule).Check();
            }
            //VkShaderModule fragmentShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.frag.spv"));
            VkShaderModule fsModule;
            {
                var info = VkShaderModuleCreateInfo.Alloc();
                byte[] bytes = LoadResource(@"Shaders\shader.frag.spv");
                bytes.Set(info);
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, info, null, &fsModule).Check();
            }
            var shaderStages = VkPipelineShaderStageCreateInfo.Alloc(2);
            {
                shaderStages[0].stage = VkShaderStageFlagBits.Vertex;
                shaderStages[0].module = vsModule;
                "main".Set(ref shaderStages[0].pName);
                shaderStages[1].stage = VkShaderStageFlagBits.Fragment;
                shaderStages[1].module = fsModule;
                "main".Set(ref shaderStages[1].pName);
            }
            var viewport = VkPipelineViewportStateCreateInfo.Alloc();
            {
                var vp = new VkViewport(surfaceCapabilities.currentExtent, 0.0f, 1.0f);
                vp.Set(viewport);
                var scissor = new VkRect2D(surfaceCapabilities.currentExtent);
                scissor.Set(viewport);
            }

            var multisample = VkPipelineMultisampleStateCreateInfo.Alloc();
            multisample->rasterizationSamples = VkSampleCountFlagBits._1;

            var colorBlend = VkPipelineColorBlendStateCreateInfo.Alloc();
            colorBlend->logicOp = VkLogicOp.Copy;
            var blend = new VkPipelineColorBlendAttachmentState(
                colorWriteMask: VkColorComponentFlagBits.R | VkColorComponentFlagBits.G
                | VkColorComponentFlagBits.B | VkColorComponentFlagBits.A,
                blendEnable: false);
            blend.Set(colorBlend);

            var rasterization = VkPipelineRasterizationStateCreateInfo.Alloc();
            rasterization->polygonMode = VkPolygonMode.Fill;
            rasterization->cullMode = VkCullModeFlagBits.None;
            rasterization->frontFace = VkFrontFace.Clockwise;
            rasterization->lineWidth = 1.0f;

            var inputAssem = VkPipelineInputAssemblyStateCreateInfo.Alloc();
            inputAssem->topology = VkPrimitiveTopology.TriangleList;

            var input = VkPipelineVertexInputStateCreateInfo.Alloc();
            {
                // static readonly float[] Vertices = { .. }
                var binding = new VkVertexInputBindingDescription(
                    binding: 0,
                    stride: 2 * sizeof(float),
                    inputRate: VkVertexInputRate.Vertex);
                binding.Set(input);
                // layout(location = 0) in vec2 inPos;
                var attribute = new VkVertexInputAttributeDescription(
                    location: 0,
                    binding: 0,
                    format: VkFormat.R32g32Sfloat,
                    offset: 0);
                attribute.Set(input);
            }

            //VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            VkPipelineCache cache;
            {
                var info = VkPipelineCacheCreateInfo.Alloc();
                vkAPI.vkCreatePipelineCache(device, info, null, &cache).Check();
            }
            //var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            //return device.CreateGraphicsPipelines(ref cache, infos);
            VkPipeline pipeline;
            {
                var info = VkGraphicsPipelineCreateInfo.Alloc();
                info->layout = pipelineLayout;
                info->pViewportState = viewport;
                info->pStages = shaderStages; info->stageCount = 2;
                info->pMultisampleState = multisample;
                info->pColorBlendState = colorBlend;
                info->pRasterizationState = rasterization;
                info->pInputAssemblyState = inputAssem;
                info->pVertexInputState = input;
                info->renderPass = renderPass;
                vkAPI.vkCreateGraphicsPipelines(device, cache, 1, info, null, &pipeline).Check();
            }

            return pipeline;
        }

        VkPipelineLayout CreatePipelineLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            var info = VkPipelineLayoutCreateInfo.Alloc();
            {
                descriptorSetLayout.Set(info);
            }
            //return device.CreatePipelineLayout(ref info);
            VkPipelineLayout layout;
            vkAPI.vkCreatePipelineLayout(device, info, null, &layout).Check();
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
            var info = VkDescriptorSetLayoutCreateInfo.Alloc();
            {
                var binding = new VkDescriptorSetLayoutBinding(
                    binding: 0,
                    descriptorType: VkDescriptorType.UniformBuffer, // uniform 
                    descriptorCount: 1, // single variable, not array.
                    stageFlags: VkShaderStageFlagBits.Vertex); // in a vertex shader.
                binding.Set(info);
            }

            //return device.CreateDescriptorSetLayout(ref info);
            VkDescriptorSetLayout layout;
            vkAPI.vkCreateDescriptorSetLayout(device, info, null, &layout).Check();
            return layout;
        }

        VkBuffer CreateBuffer(VkPhysicalDevice physicalDevice, VkDevice device, object values, VkBufferUsageFlagBits usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            VkBuffer buffer;
            {
                UInt32 index = 0;
                var info = VkBufferCreateInfo.Alloc();
                {
                    info->size = (UInt64)size;
                    info->usage = usageFlags;
                    info->sharingMode = VkSharingMode.Exclusive;
                    index.Set(info);
                }
                //VkBuffer buffer = device.CreateBuffer(ref info);
                vkAPI.vkCreateBuffer(device, info, null, &buffer).Check();
            }
            VkDeviceMemory deviceMemory; // = device.AllocateMemory(ref allocInfo);
            VkMemoryRequirements memoryReq;
            //VkMemoryRequirements memoryReq = device.GetBufferMemoryRequirements(buffer);
            vkAPI.vkGetBufferMemoryRequirements(device, buffer, &memoryReq);
            var allocInfo = VkMemoryAllocateInfo.Alloc();
            {
                allocInfo->allocationSize = memoryReq.size;
                VkPhysicalDeviceMemoryProperties memoryProperties;
                vkAPI.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memoryProperties);
                allocInfo->memoryTypeIndex = GetMemoryTypeIndex(memoryProperties, memoryReq,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);
                vkAPI.vkAllocateMemory(device, allocInfo, null, &deviceMemory).Check();
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
            for (int i = 0; i < images.Length; i++) {
                var info = VkImageViewCreateInfo.Alloc();
                info->image = images[i];
                info->viewType = VkImageViewType._2d;
                info->format = surfaceFormat.format;
                info->components = new VkComponentMapping {
                    r = VkComponentSwizzle.R,
                    g = VkComponentSwizzle.G,
                    b = VkComponentSwizzle.B,
                    a = VkComponentSwizzle.A
                };
                info->subresourceRange = new VkImageSubresourceRange {
                    aspectMask = VkImageAspectFlagBits.Color,
                    levelCount = 1,
                    layerCount = 1
                };
                //displayViews[i] = device.CreateImageView(ref info);
                VkImageView view;
                vkAPI.vkCreateImageView(device, info, null, &view).Check();
                displayViews[i] = view;
            }

            var framebuffers = new VkFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = VkFramebufferCreateInfo.Alloc();
                info->layers = 1;
                info->renderPass = renderPass;
                displayViews[i].Set(info);
                info->width = surfaceCapabilities.currentExtent.width;
                info->height = surfaceCapabilities.currentExtent.height;
                //framebuffers[i] = device.CreateFramebuffer(ref info);
                VkFramebuffer framebuffer;
                vkAPI.vkCreateFramebuffer(device, info, null, &framebuffer).Check();
                framebuffers[i] = framebuffer;
            }

            return framebuffers;
        }

        protected VkRenderPass CreateRenderPass(VkDevice device, VkSurfaceFormatKHR surfaceFormat) {
            var info = VkRenderPassCreateInfo.Alloc();
            {
                var attDesc = new VkAttachmentDescription(surfaceFormat.format, VkSampleCountFlagBits._1,
                     VkAttachmentLoadOp.Clear, VkAttachmentStoreOp.Store,
                     VkAttachmentLoadOp.DontCare, VkAttachmentStoreOp.DontCare,
                     VkImageLayout.Undefined, VkImageLayout.PresentSrcKHR, 0);
                attDesc.Set(info);
                var subpassDesc = new VkSubpassDescription(VkPipelineBindPoint.Graphics);
                {
                    var attRef = new VkAttachmentReference(VkImageLayout.ColorAttachmentOptimal, 0);
                    attRef.SetColorAttachment(&subpassDesc);
                }
                subpassDesc.Set(info);
            }

            //return device.CreateRenderPass(ref info);
            VkRenderPass renderPass;
            vkAPI.vkCreateRenderPass(device, info, null, &renderPass).Check();
            return renderPass;
        }

        protected VkSwapchainKHR CreateSwapchain(VkDevice device, VkSurfaceKHR surface,
            VkSurfaceFormatKHR surfaceFormat, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.supportedCompositeAlpha.HasFlag(
                VkCompositeAlphaFlagBitsKHR.InheritKHR)
                ? VkCompositeAlphaFlagBitsKHR.InheritKHR
                : VkCompositeAlphaFlagBitsKHR.OpaqueKHR;
            UInt32 index = 0;
            var info = VkSwapchainCreateInfoKHR.Alloc();
            info->surface = surface;
            info->minImageCount = surfaceCapabilities.minImageCount;
            info->imageFormat = surfaceFormat.format;
            info->imageColorSpace = surfaceFormat.colorSpace;
            info->imageExtent = surfaceCapabilities.currentExtent;
            info->imageUsage = VkImageUsageFlagBits.ColorAttachment;
            info->preTransform = VkSurfaceTransformFlagBitsKHR.IdentityKHR;
            info->imageArrayLayers = 1;
            info->imageSharingMode = VkSharingMode.Exclusive;
            index.Set(info);
            info->presentMode = VkPresentModeKHR.FifoKHR;
            info->compositeAlpha = compositeAlpha;
            //return device.CreateSwapchainKHR(ref info, null);
            VkSwapchainKHR swapchain;
            vkAPI.vkCreateSwapchainKHR(device, info, null, &swapchain).Check();
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

            var queueInfo = VkDeviceQueueCreateInfo.Alloc();
            {
                var priorities = new float[] { 1.0f };
                priorities.Set(queueInfo);
                queueInfo->queueFamilyIndex = index;
            }

            var info = VkDeviceCreateInfo.Alloc();
            {
                new[] { Vk.VK_KHR_swapchain }.SetExtensions(info);
                //queueInfo->Set(info);
                info->pQueueCreateInfos = queueInfo; info->queueCreateInfoCount = 1;
            }

            VkDevice vkDevice;
            //physicalDevice.CreateDevice(ref deviceInfo, null, out device);
            vkAPI.vkCreateDevice(physicalDevice, info, null, &vkDevice).Check();

            return vkDevice;
        }

        private VkPhysicalDevice InitPhysicalDevice(VkInstance instance) {

            VkPhysicalDevice[] physicalDevices = Vk.PhysicalDevices(instance);

            return physicalDevices[0];
        }

        private VkSurfaceKHR InitSurface(VkInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = VkWin32SurfaceCreateInfoKHR.Alloc();
            info->hwnd = hwnd;
            info->hinstance = processHandle; //Process.GetCurrentProcess().Handle

            VkSurfaceKHR vkSurface;
            vkAPI.vkCreateWin32SurfaceKHR(instance, info, null, &vkSurface).Check();

            return vkSurface;
        }

        private VkInstance InitInstance() {
            var extensions = new string[] { Vk.VK_KHR_surface, Vk.VK_KHR_win32_surface, Vk.VK_EXT_debug_report };

            VkLayerProperties[] layerProperties = Vk.InstanceLayerProperties();
            string[] layers = layerProperties.Any(
                l => Marshal.PtrToStringAnsi((IntPtr)l.layerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = VkApplicationInfo.Alloc();
            UInt32 version = Vulkan.VkVersion.Make(1, 0, 0);
            appInfo->apiVersion = version;

            var info = VkInstanceCreateInfo.Alloc();
            extensions.SetExtensions(info);
            layers.SetLayers(info);
            info->pApplicationInfo = appInfo;

            VkInstance vkInstance;
            vkAPI.vkCreateInstance(info, null, &vkInstance).Check();

            return vkInstance;
        }

        private VkSubmitInfo*[] submitInfos;
        private VkPresentInfoKHR*[] presentInfos;

        private void InitRenderParams() {
            VkSwapchainKHR swapchain = this.swapchain;
            VkSemaphore semaphore = this.vkSemaphore;
            VkCommandBuffer[] commandBuffers = this.commandBuffers;

            submitInfos = new VkSubmitInfo*[2]; presentInfos = new VkPresentInfoKHR*[2];
            for (uint index = 0; index < 2; index++) {
                var submitInfo = VkSubmitInfo.Alloc();
                semaphore.SetWaitSemaphores(submitInfo);
                VkPipelineStageFlagBits.AllGraphics.Set(submitInfo);
                commandBuffers[index].Set(submitInfo);
                submitInfos[index] = submitInfo;

                var presentInfo = VkPresentInfoKHR.Alloc();
                swapchain.Set(presentInfo);
                index.Set(presentInfo);
                presentInfos[index] = presentInfo;
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
            VkSubmitInfo* submitInfo = this.submitInfos[nextIndex];
            vkAPI.vkQueueSubmit(queue, 1, submitInfo, fence).Check();
            //device.WaitForFence(fence, true, 100000000);
            vkAPI.vkWaitForFences(device, 1, &fence, new VkBool32(true), 100000000).Check();
            //queue.PresentKHR(ref this.presentInfos[nextIndex]);
            VkPresentInfoKHR* presentInfo = this.presentInfos[nextIndex];
            vkAPI.vkQueuePresentKHR(queue, presentInfo).Check();
        }
    }
}
