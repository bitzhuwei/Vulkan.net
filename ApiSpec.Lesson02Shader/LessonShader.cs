using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Vulkan;
using static Vulkan.VkStructureType;
using static Vulkan.vkAPI;

namespace ApiSpec.Lesson02Shader {
    unsafe class LessonShader {
        CInstance instance;
        VkDebugReportCallbackEXT callback;
        CSurface surface;
        VkPhysicalDevice vkPhysicalDevice;

        CDevice device;
        VkQueue vkQueue;
        CSwapchain swapchain;
        VkImage[] vkImages;
        CRenderPass renderPass;
        CFramebuffer[] framebuffers;
        VkFence vkFence;
        VkSemaphore vkSemaphore;
        //
        CBuffer uniformBuffer;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s.
        /// </summary>
        CDescriptorSetLayout descriptorSetLayout;
        /// <summary>
        /// container of <see cref="VkDescriptorSetLayoutBinding"/>s and <see cref="VkPushConstantRange"/>s.
        /// </summary>
        VkPipelineLayout vkPipelineLayout;
        CDescriptorSet descriptorSet;

        CCommandBuffer[] commandBuffers;

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
            VkDevice device = this.device.handle; VkDeviceMemory deviceMemory = this.vkDeviceMemory;
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

            this.instance = InitInstance();
            InitDebugCallback(this.instance);
            this.surface = InitSurface(this.instance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice(this.instance);
            VkSurfaceFormatKHR surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.surface);


            this.device = CreateDevice(this.vkPhysicalDevice, this.surface);

            this.vkQueue = this.device.handle.GetQueue(0, 0);

            VkSurfaceCapabilitiesKHR surfaceCapabilities;
            //this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);
            vkAPI.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.vkPhysicalDevice, this.surface.handle, &surfaceCapabilities).Check();

            this.swapchain = CreateSwapchain(this.device, this.surface, surfaceFormat, surfaceCapabilities);

            this.vkImages = this.device.handle.GetSwapchainImages(this.swapchain.handle);

            this.renderPass = CreateRenderPass(this.device, surfaceFormat);

            this.framebuffers = CreateFramebuffers(this.device, this.vkImages, surfaceFormat, this.renderPass, surfaceCapabilities);

            this.vkFence = this.device.handle.CreateFence();
            this.vkSemaphore = this.device.handle.CreateSemaphore();

            // buffers for vertex data.
            CBuffer vertexBuffer = CreateBuffer(this.vkPhysicalDevice, this.device, Logo.Vertices, VkBufferUsageFlagBits.VertexBuffer, typeof(float));

            CBuffer indexBuffer = CreateBuffer(this.vkPhysicalDevice, this.device, Logo.Indexes, VkBufferUsageFlagBits.IndexBuffer, typeof(short));

            var uniformBufferData = new AreaUniformBuffer(40, 50);
            this.originalWidth = 40; this.width = this.originalWidth;
            this.originalHeight = 50; this.height = this.originalHeight;

            this.uniformBuffer = CreateBuffer(this.vkPhysicalDevice, this.device, uniformBufferData, VkBufferUsageFlagBits.UniformBuffer, typeof(AreaUniformBuffer));

            this.descriptorSetLayout = CreateDescriptorSetLayout(this.device);

            this.vkPipelineLayout = CreatePipelineLayout(this.device, this.descriptorSetLayout);

            CPipeline pipeline = CreatePipeline(this.device, surfaceCapabilities, this.renderPass, this.vkPipelineLayout);

            this.descriptorSet = CreateDescriptorSet(this.device, this.descriptorSetLayout);

            UpdateDescriptorSets(this.device, this.uniformBuffer, this.descriptorSet);

            this.commandBuffers = CreateCommandBuffers(
                this.device, this.renderPass, surfaceCapabilities,
                this.vkImages, this.framebuffers, pipeline,
                vertexBuffer, indexBuffer, (uint)Logo.Indexes.Length,
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
        private VkBool32 DebugCallback(VkDebugReportFlagBitsEXT flags, VkDebugReportObjectTypeEXT objectType,
            UInt64 objectHandle, Int32 location, Int32 messageCode,
            IntPtr layerPrefix, IntPtr message, IntPtr userData) {
            string text = $"{flags}: {Marshal.PtrToStringAnsi(message)}";
            Debug.WriteLine(text);
            return true;
        }

        PFN_vkDebugReportCallbackEXT delDebugCallback;

        private void InitDebugCallback(CInstance instance) {
            if (delDebugCallback == null) {
                delDebugCallback = new PFN_vkDebugReportCallbackEXT(DebugCallback);
            }
            var info = VkDebugReportCallbackCreateInfoEXT.Alloc();
            info->flags = VkDebugReportFlagBitsEXT.DebugExt | VkDebugReportFlagBitsEXT.ErrorExt
                | VkDebugReportFlagBitsEXT.PerformanceWarningExt | VkDebugReportFlagBitsEXT.WarningExt
                | VkDebugReportFlagBitsEXT.InformationExt;
            info->pfnCallback = Marshal.GetFunctionPointerForDelegate(delDebugCallback);

            VkDebugReportCallbackEXT callback;
            IntPtr procHandle = vkAPI.vkGetInstanceProcAddr(instance.handle, "vkCreateDebugReportCallbackEXT");
            var proc = (vkCreateDebugReportCallbackEXT)Marshal.GetDelegateForFunctionPointer(procHandle, typeof(vkCreateDebugReportCallbackEXT));
            if (proc != null) {
                proc(instance.handle, info, null, &callback).Check();
                this.callback = callback;
            }
            // TODO: make delegate.
            //vkAPI.vkCreateDebugReportCallbackEXT(instance.handle, info, null, &callback).Check();
        }
        //public unsafe delegate VkResult vkCreateDebugReportCallbackEXT(VkInstance instance,
        //    VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator,
        //    VkDebugReportCallbackEXT* pCallback);

        CCommandBuffer[] CreateCommandBuffers(
            CDevice device, CRenderPass renderPass, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkImage[] images, CFramebuffer[] framebuffers, CPipeline pipeline,
            CBuffer vertexBuffer, CBuffer indexBuffer, uint indexLength,
            VkPipelineLayout pipelineLayout, CDescriptorSet descriptorSet) {
            CCommandBuffer[] buffers;
            {
                VkCommandPool pool;
                {
                    var info = VkCommandPoolCreateInfo.Alloc();
                    info->flags = VkCommandPoolCreateFlagBits.ResetCommandBuffer;
                    //var commandPool = device.CreateCommandPool(ref poolInfo);
                    vkAPI.vkCreateCommandPool(device.handle, info, null, &pool).Check();
                }
                {
                    var info = VkCommandBufferAllocateInfo.Alloc();
                    info->level = VkCommandBufferLevel.Primary;
                    info->commandPool = pool;
                    info->commandBufferCount = (uint)images.Length;
                    //buffers = device.AllocateCommandBuffers(ref info);
                    var handles = new VkCommandBuffer[info->commandBufferCount];
                    fixed (VkCommandBuffer* pointer = handles) {
                        vkAPI.vkAllocateCommandBuffers(device.handle, info, pointer).Check();
                    }
                    buffers = new CCommandBuffer[handles.Length];
                    for (int i = 0; i < buffers.Length; i++) {
                        buffers[i] = new CCommandBuffer(handles[i], info);
                    }
                }
            }

            var cmdBeginInfo = VkCommandBufferBeginInfo.Alloc();
            for (int i = 0; i < images.Length; i++) {
                VkCommandBuffer cmds = buffers[i].handle;
                //cmds.Begin(ref cmdBeginInfo);
                vkAPI.vkBeginCommandBuffer(cmds, cmdBeginInfo);
                {
                    var clearValue = new VkClearValue { color = new VkClearColorValue(0.9f, 0.87f, 0.75f, 1.0f) };
                    var info = VkRenderPassBeginInfo.Alloc();
                    info->framebuffer = framebuffers[i].handle;
                    info->renderPass = renderPass.handle;
                    clearValue.Set(info);
                    info->renderArea = new VkRect2D { extent = surfaceCapabilities.currentExtent };
                    vkAPI.vkCmdBeginRenderPass(cmds, info, VkSubpassContents.Inline);
                    {
                        {
                            var handle = descriptorSet.handle;
                            vkAPI.vkCmdBindDescriptorSets(cmds, VkPipelineBindPoint.Graphics,
                                pipelineLayout, 0, 1, &handle, 0, null);
                        }
                        vkAPI.vkCmdBindPipeline(cmds, VkPipelineBindPoint.Graphics, pipeline.handle);
                        var offset = new VkDeviceSize();
                        {
                            var handle = vertexBuffer.handle;
                            vkAPI.vkCmdBindVertexBuffers(cmds, 0, 1, &handle, &offset);
                        }
                        vkAPI.vkCmdBindIndexBuffer(cmds, indexBuffer.handle, offset, VkIndexType.Uint16);
                        vkAPI.vkCmdDrawIndexed(cmds, indexLength, 1, 0, 0, 0);
                    }
                    vkAPI.vkCmdEndRenderPass(cmds);
                }
                vkAPI.vkEndCommandBuffer(cmds);
            }

            return buffers;
        }

        void UpdateDescriptorSets(CDevice device, CBuffer uniformBuffer, CDescriptorSet descriptorSet) {
            var write = VkWriteDescriptorSet.Alloc();
            write->dstSet = descriptorSet.handle;
            write->descriptorType = VkDescriptorType.UniformBuffer;
            var info = new VkDescriptorBufferInfo(uniformBuffer.handle, 0, 2 * sizeof(float));
            info.Set(write);

            //device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { write }, null);
            vkAPI.vkUpdateDescriptorSets(device.handle, 1, write, 0, null);
        }

        CDescriptorSet CreateDescriptorSet(CDevice device, CDescriptorSetLayout descriptorSetLayout) {
            CDescriptorPool descriptorPool;
            {
                // this pool can allocate one uniform descriptor.
                var info = VkDescriptorPoolCreateInfo.Alloc();
                var size = new VkDescriptorPoolSize(VkDescriptorType.UniformBuffer, 1);
                size.Set(info);
                info->maxSets = 1;
                VkDescriptorPool handle;
                vkAPI.vkCreateDescriptorPool(device.handle, info, null, &handle);
                descriptorPool = new CDescriptorPool(handle, info);
            }
            CDescriptorSet descriptorSet;
            {
                var info = VkDescriptorSetAllocateInfo.Alloc();
                descriptorSetLayout.handle.Set(info);
                info->descriptorPool = descriptorPool.handle;
                VkDescriptorSet handle;
                vkAPI.vkAllocateDescriptorSets(device.handle, info, &handle).Check();
                descriptorSet = new CDescriptorSet(handle, info);
            }

            return descriptorSet;
        }


        CPipeline CreatePipeline(CDevice device, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            CRenderPass renderPass, VkPipelineLayout pipelineLayout) {
            //VkShaderModule vertexShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.vert.spv"));
            VkShaderModule vsModule;
            {
                var info = VkShaderModuleCreateInfo.Alloc();
                byte[] bytes = LoadResource(@"Shaders\shader.vert.spv");
                bytes.Set(info);
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device.handle, info, null, &vsModule);
                Vk.Free(info);
            }
            //VkShaderModule fragmentShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.frag.spv"));
            VkShaderModule fsModule;
            {
                var info = VkShaderModuleCreateInfo.Alloc();
                byte[] bytes = LoadResource(@"Shaders\shader.frag.spv");
                bytes.Set(info);
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device.handle, info, null, &fsModule);
                Vk.Free(info);
            }
            var vs = VkPipelineShaderStageCreateInfo.Alloc();
            {
                vs->stage = VkShaderStageFlagBits.Vertex;
                vs->module = vsModule;
                "main".Set(ref vs->pName);
            }
            var fs = VkPipelineShaderStageCreateInfo.Alloc();
            {
                fs->stage = VkShaderStageFlagBits.Fragment;
                fs->module = fsModule;
                "main".Set(ref fs->pName);
            }
            VkPipelineShaderStageCreateInfo[] stages = { *vs, *fs };
            var viewport = VkPipelineViewportStateCreateInfo.Alloc();
            {
                var vp = new VkViewport(surfaceCapabilities.currentExtent, 0.0f, 1.0f);
                vp.Set(viewport);
                var scissor = new VkRect2D(surfaceCapabilities.currentExtent);
                scissor.Set(viewport);
            }

            var multisample = VkPipelineMultisampleStateCreateInfo.Alloc();
            {
                multisample->rasterizationSamples = VkSampleCountFlagBits._1;
            }
            var colorBlend = VkPipelineColorBlendStateCreateInfo.Alloc();
            {
                colorBlend->logicOp = VkLogicOp.Copy;
                var blend = new VkPipelineColorBlendAttachmentState(
                    colorWriteMask: VkColorComponentFlagBits.R | VkColorComponentFlagBits.G
                    | VkColorComponentFlagBits.B | VkColorComponentFlagBits.A,
                    blendEnable: false);
                blend.Set(colorBlend);
            }
            var rasterization = VkPipelineRasterizationStateCreateInfo.Alloc();
            {
                rasterization->polygonMode = VkPolygonMode.Fill;
                rasterization->cullMode = VkCullModeFlagBits.None;
                rasterization->frontFace = VkFrontFace.Clockwise;
                rasterization->lineWidth = 1.0f;
            }
            var inputAssem = VkPipelineInputAssemblyStateCreateInfo.Alloc();
            {
                inputAssem->topology = VkPrimitiveTopology.TriangleList;
            }
            var input = VkPipelineVertexInputStateCreateInfo.Alloc();
            {
                var binding = new VkVertexInputBindingDescription(
                    binding: 0,
                    stride: 3 * sizeof(float),
                    inputRate: VkVertexInputRate.Vertex);
                binding.Set(input);
                var attribute = new VkVertexInputAttributeDescription(0, 0, VkFormat.R32g32b32Sfloat, 0);
                attribute.Set(input);
            }

            //VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            VkPipelineCache cache;
            {
                var info = VkPipelineCacheCreateInfo.Alloc();
                vkAPI.vkCreatePipelineCache(device.handle, info, null, &cache);
            }
            //var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            //return device.CreateGraphicsPipelines(ref cache, infos);
            CPipeline pipeline;
            {
                var info = VkGraphicsPipelineCreateInfo.Alloc();
                {
                    info->layout = pipelineLayout;
                    info->pViewportState = viewport;
                    stages.Set(info);
                    info->pMultisampleState = multisample;
                    info->pColorBlendState = colorBlend;
                    info->pRasterizationState = rasterization;
                    info->pInputAssemblyState = inputAssem;
                    info->pVertexInputState = input;
                    info->renderPass = renderPass.handle;
                }

                VkPipeline handle;
                vkAPI.vkCreateGraphicsPipelines(device.handle, cache, 1, info, null, &handle);
                pipeline = new CPipeline(handle, info);
            }

            return pipeline;
        }

        VkPipelineLayout CreatePipelineLayout(CDevice device, CDescriptorSetLayout descriptorSetLayout) {
            var info = VkPipelineLayoutCreateInfo.Alloc();
            {
                descriptorSetLayout.handle.Set(info);
            }
            //return device.CreatePipelineLayout(ref info);
            VkPipelineLayout layout;
            vkAPI.vkCreatePipelineLayout(device.handle, info, null, &layout);
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

        CDescriptorSetLayout CreateDescriptorSetLayout(CDevice device) {
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
            VkDescriptorSetLayout handle;
            vkAPI.vkCreateDescriptorSetLayout(device.handle, info, null, &handle);
            return new CDescriptorSetLayout(handle, info);
        }

        CBuffer CreateBuffer(VkPhysicalDevice physicalDevice, CDevice device, object values, VkBufferUsageFlagBits usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            CBuffer buffer;
            {
                UInt32 index = 0;
                var info = VkBufferCreateInfo.Alloc();
                {
                    info->size = new VkDeviceSize((UInt64)size);
                    info->usage = usageFlags;
                    info->sharingMode = VkSharingMode.Exclusive;
                    index.Set(info);
                }
                //VkBuffer buffer = device.CreateBuffer(ref info);
                VkBuffer vkBuffer;
                vkAPI.vkCreateBuffer(device.handle, info, null, &vkBuffer);
                buffer = new CBuffer(vkBuffer, info);
            }
            CDeviceMemory deviceMemory; // = device.AllocateMemory(ref allocInfo);
            VkMemoryRequirements memoryReq;
            //VkMemoryRequirements memoryReq = device.GetBufferMemoryRequirements(buffer);
            vkAPI.vkGetBufferMemoryRequirements(device.handle, buffer.handle, &memoryReq);
            var allocInfo = VkMemoryAllocateInfo.Alloc();
            {
                allocInfo->allocationSize = memoryReq.size;
                VkPhysicalDeviceMemoryProperties memoryProperties;
                //physicalDevice.GetMemoryProperties(out memoryProperties);
                vkAPI.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memoryProperties);
                allocInfo->memoryTypeIndex = GetMemoryTypeIndex(memoryProperties, memoryReq,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent);
                VkDeviceMemory memory;
                vkAPI.vkAllocateMemory(device.handle, allocInfo, null, &memory);
                deviceMemory = new CDeviceMemory(memory, allocInfo);
            }
            {
                IntPtr memPtr = IntPtr.Zero;
                vkAPI.vkMapMemory(device.handle, deviceMemory.handle, new VkDeviceSize(), new VkDeviceSize((UInt64)size), 0, &memPtr);

                if (type == typeof(float))
                    System.Runtime.InteropServices.Marshal.Copy(values as float[], 0, memPtr, length);
                else if (type == typeof(short))
                    System.Runtime.InteropServices.Marshal.Copy(values as short[], 0, memPtr, length);
                else if (type == typeof(AreaUniformBuffer)) {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(values, memPtr, false);
                    this.vkBuffer = buffer.handle;
                    this.vkDeviceMemory = deviceMemory.handle;
                    this.uniformSize = memoryReq.size;
                }

                vkAPI.vkUnmapMemory(device.handle, deviceMemory.handle);
            }
            vkAPI.vkBindBufferMemory(device.handle, buffer.handle, deviceMemory.handle, new VkDeviceSize());
            buffer.memory = deviceMemory;

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

        protected CFramebuffer[] CreateFramebuffers(CDevice device, VkImage[] images, VkSurfaceFormatKHR surfaceFormat, CRenderPass renderPass, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
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
                vkAPI.vkCreateImageView(device.handle, info, null, &view).Check();
                displayViews[i] = view;
            }

            var framebuffers = new VkFramebuffer[images.Length];
            var result = new CFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = VkFramebufferCreateInfo.Alloc();
                info->layers = 1;
                info->renderPass = renderPass.handle;
                displayViews[i].Set(info);
                info->width = surfaceCapabilities.currentExtent.width;
                info->height = surfaceCapabilities.currentExtent.height;
                //framebuffers[i] = device.CreateFramebuffer(ref info);
                VkFramebuffer framebuffer;
                vkAPI.vkCreateFramebuffer(device.handle, info, null, &framebuffer);
                framebuffers[i] = framebuffer;
                result[i] = new CFramebuffer(framebuffers[i], info);
            }

            return result;
        }

        protected CRenderPass CreateRenderPass(CDevice device, VkSurfaceFormatKHR surfaceFormat) {
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
            VkRenderPass renderpass;
            vkAPI.vkCreateRenderPass(device.handle, info, null, &renderpass).Check();
            return new CRenderPass(renderpass, info);
        }

        protected CSwapchain CreateSwapchain(CDevice device, CSurface surface, VkSurfaceFormatKHR surfaceFormat, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagBitsKHR.InheritKHR)
                ? VkCompositeAlphaFlagBitsKHR.InheritKHR
                : VkCompositeAlphaFlagBitsKHR.OpaqueKHR;
            UInt32 index = 0;
            var info = VkSwapchainCreateInfoKHR.Alloc();
            info->surface = surface.handle;
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
            VkSwapchainKHR handle;
            vkAPI.vkCreateSwapchainKHR(device.handle, info, null, &handle).Check();
            return new CSwapchain(handle, info);
        }

        protected VkSurfaceFormatKHR SelectFormat(VkPhysicalDevice physicalDevice, CSurface surface) {
            VkSurfaceFormatKHR[] formats;
            //physicalDevice.GetSurfaceFormatsKHR(surface, out formats);
            {
                UInt32 count;
                vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface.handle, &count, null).Check();
                formats = new VkSurfaceFormatKHR[count];
                fixed (VkSurfaceFormatKHR* pointer = formats) {
                    vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface.handle, &count, pointer).Check();
                }
            }
            foreach (var f in formats)
                if (f.format == VkFormat.R8g8b8a8Unorm || f.format == VkFormat.B8g8r8a8Unorm)
                    return f;

            throw new System.Exception("didn't find the R8G8B8A8Unorm or B8G8R8A8Unorm format");
        }

        private CDevice CreateDevice(VkPhysicalDevice physicalDevice, CSurface surface) {
            //VkQueueFamilyProperties[] properties = physicalDevice.GetQueueFamilyProperties();
            VkQueueFamilyProperties[] properties = Vk.QueueFamilyProperties(physicalDevice);
            uint index;
            for (index = 0; index < properties.Length; ++index) {
                VkBool32 supported;
                //physicalDevice.GetSurfaceSupportKHR(index, surface, out supported);
                vkAPI.vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, index, surface.handle, &supported).Check();
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
                new[] { "VK_KHR_swapchain" }.SetExtensions(info);
                //queueInfo->Set(info);
                info->pQueueCreateInfos = queueInfo; info->queueCreateInfoCount = 1;
            }

            VkDevice vkDevice;
            //physicalDevice.CreateDevice(ref deviceInfo, null, out device);
            vkAPI.vkCreateDevice(physicalDevice, info, null, &vkDevice).Check();

            return new CDevice(vkDevice, info);
        }

        private VkPhysicalDevice InitPhysicalDevice(CInstance instance) {

            VkPhysicalDevice[] physicalDevices = Vk.PhysicalDevices(instance.handle);

            return physicalDevices[0];
        }

        private CSurface InitSurface(CInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = VkWin32SurfaceCreateInfoKHR.Alloc();
            info->hwnd = hwnd;
            info->hinstance = processHandle; //Process.GetCurrentProcess().Handle
            VkSurfaceKHR vkSurface;
            vkAPI.vkCreateWin32SurfaceKHR(instance.handle, info, null, &vkSurface).Check();
            return new CSurface(vkSurface, info);
        }

        private CInstance InitInstance() {
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

            return new CInstance(vkInstance, info);
        }

        private VkSubmitInfo*[] submitInfos;
        private VkPresentInfoKHR*[] presentInfos;

        private void InitRenderParams() {
            VkSwapchainKHR swapchain = this.swapchain.handle;
            VkSemaphore semaphore = this.vkSemaphore;
            CCommandBuffer[] commandBuffers = this.commandBuffers;

            submitInfos = new VkSubmitInfo*[2]; presentInfos = new VkPresentInfoKHR*[2];
            for (uint index = 0; index < 2; index++) {
                var submitInfo = VkSubmitInfo.Alloc();
                semaphore.SetWaitSemaphores(submitInfo);
                VkPipelineStageFlagBits.AllGraphics.Set(submitInfo);
                commandBuffers[index].handle.Set(submitInfo);
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

            VkDevice device = this.device.handle; VkSwapchainKHR swapchain = this.swapchain.handle;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkQueue queue = this.vkQueue;
            //uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            UInt32 nextIndex;
            vkAPI.vkAcquireNextImageKHR(device, swapchain, ulong.MaxValue, semaphore, new VkFence(), &nextIndex);
            //device.ResetFence(fence);
            vkAPI.vkResetFences(device, 1, &fence);

            //queue.Submit(ref this.submitInfos[nextIndex], fence);
            VkSubmitInfo* submitInfo = this.submitInfos[nextIndex];
            vkAPI.vkQueueSubmit(queue, 1, submitInfo, fence);
            //device.WaitForFence(fence, true, 100000000);
            vkAPI.vkWaitForFences(device, 1, &fence, new VkBool32(true), 100000000);
            //queue.PresentKHR(ref this.presentInfos[nextIndex]);
            VkPresentInfoKHR* presentInfo = this.presentInfos[nextIndex];
            vkAPI.vkQueuePresentKHR(queue, presentInfo);
        }
    }
}
