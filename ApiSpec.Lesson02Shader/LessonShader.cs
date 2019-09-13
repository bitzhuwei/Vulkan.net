using System;
using System.Linq;
using System.Runtime.InteropServices;
using ApiSpec.Generated;

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
        VkDescriptorSet[] vkDescriptorSets;

        VkCommandBuffer[] vkCommandBuffers;
        bool isInitialized = false;

        public void Init(IntPtr hwnd, IntPtr processHandle) {
            if (this.isInitialized) { return; }

            this.vkIntance = InitInstance();
            this.vkSurface = InitSurface(this.vkIntance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice(this.vkIntance);
            VkSurfaceFormatKHR surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.vkSurface);

            VkSurfaceCapabilitiesKHR surfaceCapabilities;
            //this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);
            vkAPI.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.vkPhysicalDevice, this.vkSurface, &surfaceCapabilities);

            this.vkDevice = CreateDevice(this.vkPhysicalDevice, this.vkSurface);

            //this.vkQueue = this.vkDevice.GetDeviceQueue(0, 0);
            {
                VkQueue queue;
                vkAPI.vkGetDeviceQueue(this.vkDevice, 0, 0, &queue);
                this.vkQueue = queue;
            }
            this.vkSwapchain = CreateSwapchain(this.vkDevice, this.vkSurface, surfaceFormat, surfaceCapabilities);
            //this.vkImages = this.vkDevice.GetSwapchainImagesKHR(this.vkSwapchain);
            {
                UInt32 count;
                vkAPI.vkGetSwapchainImagesKHR(this.vkDevice, this.vkSwapchain, &count, null);
                this.vkImages = new VkImage[count];
                if (count > 0) {
                    fixed (VkImage* pointer = this.vkImages) {
                        vkAPI.vkGetSwapchainImagesKHR(this.vkDevice, this.vkSwapchain, &count, pointer);
                    }
                }
            }
            this.vkRenderPass = CreateRenderPass(this.vkDevice, surfaceFormat);
            this.vkFramebuffers = CreateFramebuffers(this.vkDevice, this.vkImages, surfaceFormat, this.vkRenderPass, surfaceCapabilities);

            //this.vkFence = this.vkDevice.CreateFence(ref fenceInfo);
            {
                VkFence fence;
                var info = new VkFenceCreateInfo { sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO };
                vkAPI.vkCreateFence(this.vkDevice, &info, null, &fence);
                this.vkFence = fence;
            }
            //this.vkSemaphore = this.vkDevice.CreateSemaphore(ref semaphoreInfo);
            {
                VkSemaphore semaphore;
                var info = new VkSemaphoreCreateInfo { sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO };
                vkAPI.vkCreateSemaphore(this.vkDevice, &info, null, &semaphore);
                this.vkSemaphore = semaphore;
            }

            // buffers for vertex data.
            VkBuffer vertexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Vertices, VkBufferUsageFlagBits.VK_BUFFER_USAGE_VERTEX_BUFFER_BIT, typeof(float));
            VkBuffer indexBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, Logo.Indexes, VkBufferUsageFlagBits.VK_BUFFER_USAGE_INDEX_BUFFER_BIT, typeof(short));
            var uniformBufferData = new AreaUniformBuffer(surfaceCapabilities.currentExtent.width, surfaceCapabilities.currentExtent.height);
            this.vkUniformBuffer = CreateBuffer(this.vkPhysicalDevice, this.vkDevice, uniformBufferData, VkBufferUsageFlagBits.VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, typeof(AreaUniformBuffer));

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
            VkDevice device, VkRenderPass renderPass, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkImage[] images, VkFramebuffer[] framebuffers, VkPipeline pipeline,
            VkBuffer vertexBuffer, VkBuffer indexBuffer, uint indexLength,
            VkPipelineLayout pipelineLayout, VkDescriptorSet[] descriptorSets) {
            VkCommandBuffer[] buffers;
            {
                VkCommandPool pool;
                {
                    var info = new VkCommandPoolCreateInfo {
                        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO,
                        flags = VkCommandPoolCreateFlagBits.VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT
                    };
                    //var commandPool = device.CreateCommandPool(ref poolInfo);
                    vkAPI.vkCreateCommandPool(device, &info, null, &pool);
                }
                {
                    var info = new VkCommandBufferAllocateInfo {
                        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO,
                        level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY,
                        commandPool = pool,
                        commandBufferCount = (uint)images.Length
                    };
                    //buffers = device.AllocateCommandBuffers(ref info);
                    buffers = new VkCommandBuffer[info.commandBufferCount];
                    fixed (VkCommandBuffer* pointer = buffers) {
                        vkAPI.vkAllocateCommandBuffers(device, &info, pointer);
                    }
                }
            }

            var cmdBeginInfo = new VkCommandBufferBeginInfo() { sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO };
            for (int i = 0; i < images.Length; i++) {
                VkCommandBuffer cmds = buffers[i];
                //cmds.Begin(ref cmdBeginInfo);
                vkAPI.vkBeginCommandBuffer(cmds, &cmdBeginInfo);
                {
                    var color = new VkClearColorValue();
                    color.float32[0] = 0.9f; color.float32[1] = 0.87f; color.float32[2] = 0.75f; color.float32[3] = 1.0f;
                    var clearValue = new VkClearValue { color = color };
                    var clearValues = new[] { clearValue };
                    var info = new VkRenderPassBeginInfo();
                    {
                        info.sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO;
                        info.framebuffer = framebuffers[i];
                        info.renderPass = renderPass;
                        //var ptr = IntPtr.Zero;
                        //clearValues.Set(ref ptr, ref info.clearValueCount);
                        //info.pClearValues = (VkClearValue*)ptr;
                        info.pClearValues = &clearValue; info.clearValueCount = 1;
                        info.renderArea = new VkRect2D { extent = surfaceCapabilities.currentExtent };
                    }
                    vkAPI.vkCmdBeginRenderPass(cmds, &info, VkSubpassContents.VK_SUBPASS_CONTENTS_INLINE);
                    {
                        fixed (VkDescriptorSet* sets = descriptorSets) {
                            vkAPI.vkCmdBindDescriptorSets(cmds, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS,
                                pipelineLayout, 0, (UInt32)descriptorSets.Length, sets, 0, null);
                        }
                        vkAPI.vkCmdBindPipeline(cmds, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS, pipeline);
                        var offset = new VkDeviceSize();
                        vkAPI.vkCmdBindVertexBuffers(cmds, 0, 1, &vertexBuffer, &offset);
                        vkAPI.vkCmdBindIndexBuffer(cmds, indexBuffer, offset, VkIndexType.VK_INDEX_TYPE_UINT16);
                        vkAPI.vkCmdDrawIndexed(cmds, indexLength, 1, 0, 0, 0);
                    }
                    vkAPI.vkCmdEndRenderPass(cmds);
                }
                vkAPI.vkEndCommandBuffer(cmds);
            }

            return buffers;
        }

        void UpdateDescriptorSets(VkDevice device, VkBuffer uniformBuffer, VkDescriptorSet[] descriptorSets) {
            var info = new VkDescriptorBufferInfo {
                buffer = uniformBuffer,
                offset = new VkDeviceSize(0),
                range = new VkDeviceSize(2 * sizeof(float))
            };
            var write = new VkWriteDescriptorSet();
            {
                write.sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET;
                write.dstSet = descriptorSets[0];
                write.descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER;
                //var ptr = (IntPtr)write.pBufferInfo;
                //new VkDescriptorBufferInfo[] { info }.Set(ref ptr, ref write.descriptorCount);
                //write.pBufferInfo = (VkDescriptorBufferInfo*)ptr;
                write.pBufferInfo = &info; write.descriptorCount = 1;
            }

            //device.UpdateDescriptorSets(new VkWriteDescriptorSet[] { write }, null);
            vkAPI.vkUpdateDescriptorSets(device, 1, &write, 0, null);
        }

        VkDescriptorSet[] CreateDescriptorSets(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            VkDescriptorPool descriptorPool;
            {
                // this pool can allocate one uniform descriptor.
                var size = new VkDescriptorPoolSize {
                    type = VkDescriptorType.VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER,
                    descriptorCount = 1
                };
                var info = new VkDescriptorPoolCreateInfo();
                {
                    info.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO;
                    //var ptr = (IntPtr)info.PoolSizes;
                    //new VkDescriptorPoolSize[] { size }.Set(ref info.PoolSizes, ref info.PoolSizeCount);
                    //info.PoolSizes = (VkDescriptorPoolSize*)ptr;
                    info.pPoolSizes = &size; info.poolSizeCount = 1;
                    info.maxSets = 1;
                }
                //descriptorPool = device.CreateDescriptorPool(ref info);
                vkAPI.vkCreateDescriptorPool(device, &info, null, &descriptorPool);
            }
            VkDescriptorSet[] sets;
            {
                var info = new VkDescriptorSetAllocateInfo();
                {
                    info.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO;
                    //var ptr = (IntPtr)info.SetLayouts;
                    //new UInt64[] { descriptorSetLayout.handle }.Set(ref info.SetLayouts, ref info.DescriptorSetCount);
                    //info.PoolSizes = (UInt64*)ptr;
                    info.pSetLayouts = &descriptorSetLayout; info.descriptorSetCount = 1;
                    info.descriptorPool = descriptorPool;
                }
                //sets = device.AllocateDescriptorSets(ref info);
                {
                    sets = new VkDescriptorSet[info.descriptorSetCount];
                    fixed (VkDescriptorSet* pointer = sets) {
                        vkAPI.vkAllocateDescriptorSets(device, &info, pointer).Check();
                    }
                }
            }

            return sets;
        }


        VkPipeline[] CreatePipelines(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkSurfaceCapabilitiesKHR surfaceCapabilities,
            VkRenderPass renderPass, VkPipelineLayout pipelineLayout) {
            //VkShaderModule vertexShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.vert.spv"));
            VkShaderModule vsModule;
            {
                var info = new VkShaderModuleCreateInfo();
                {
                    info.sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO;
                    //UInt32 size = 0;
                    //shaderCode.Set(ref info.Code, ref size); info.CodeSize = (UIntPtr)size;
                    byte[] bytes = LoadResource(@"Shaders\shader.vert.spv");
                    var ptr = IntPtr.Zero; UInt32 size = 0;
                    bytes.Set(ref ptr, ref size);
                    info.pCode = (UInt32*)ptr; info.codeSize = (int)size;
                    //info.flags = 0;
                }
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, &info, null, &vsModule);
                FreeHelper.Free(ref info);
            }
            //VkShaderModule fragmentShaderModule = device.CreateShaderModule(LoadResource(@"Shaders\shader.frag.spv"));
            VkShaderModule fsModule;
            {
                var info = new VkShaderModuleCreateInfo();
                {
                    info.sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO;
                    //UInt32 size = 0;
                    //shaderCode.Set(ref info.Code, ref size); info.CodeSize = (UIntPtr)size;
                    byte[] bytes = LoadResource(@"Shaders\shader.frag.spv");
                    var ptr = IntPtr.Zero; UInt32 size = 0;
                    bytes.Set(ref ptr, ref size);
                    info.pCode = (UInt32*)ptr; info.codeSize = (int)size;
                    //info.flags = 0;
                }
                //vkAPI.vkCreateShaderModule(device, bytes);
                vkAPI.vkCreateShaderModule(device, &info, null, &fsModule);
                FreeHelper.Free(ref info);
            }
            var vs = new VkPipelineShaderStageCreateInfo();
            {
                vs.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;
                vs.stage = VkShaderStageFlagBits.VK_SHADER_STAGE_VERTEX_BIT;
                vs.module = vsModule;
                "main".Set(ref vs.pName);
            }
            var fs = new VkPipelineShaderStageCreateInfo();
            {
                fs.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;
                fs.stage = VkShaderStageFlagBits.VK_SHADER_STAGE_FRAGMENT_BIT;
                fs.module = fsModule;
                "main".Set(ref fs.pName);
            }
            VkPipelineShaderStageCreateInfo[] pipelineShaderStages = { vs, fs };
            var viewport = new VkViewport {
                minDepth = 0,
                maxDepth = 1.0f,
                width = surfaceCapabilities.currentExtent.width,
                height = surfaceCapabilities.currentExtent.height
            };
            var scissor = new VkRect2D { extent = surfaceCapabilities.currentExtent };
            var viewportCreateInfo = new VkPipelineViewportStateCreateInfo();
            {
                viewportCreateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO;
                //new VkViewport[] { viewport }.Set(ref viewportCreateInfo.Viewports, ref viewportCreateInfo.ViewportCount);
                viewportCreateInfo.pViewports = &viewport; viewportCreateInfo.viewportCount = 1;
                //new VkRect2D[] { scissor }.Set(ref viewportCreateInfo.Scissors, ref viewportCreateInfo.ScissorCount);
                viewportCreateInfo.pScissors = &scissor; viewportCreateInfo.scissorCount = 1;
            }

            var multisampleCreateInfo = new VkPipelineMultisampleStateCreateInfo {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO,
                rasterizationSamples = VkSampleCountFlagBits.VK_SAMPLE_COUNT_1_BIT
            };
            var colorBlendAttachmentState = new VkPipelineColorBlendAttachmentState {
                colorWriteMask = VkColorComponentFlagBits.VK_COLOR_COMPONENT_R_BIT
                | VkColorComponentFlagBits.VK_COLOR_COMPONENT_G_BIT
                | VkColorComponentFlagBits.VK_COLOR_COMPONENT_B_BIT
                | VkColorComponentFlagBits.VK_COLOR_COMPONENT_A_BIT
            };
            var colorBlendStateCreatInfo = new VkPipelineColorBlendStateCreateInfo();
            {
                colorBlendStateCreatInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO;
                colorBlendStateCreatInfo.logicOp = VkLogicOp.VK_LOGIC_OP_COPY;
                //new VkPipelineColorBlendAttachmentState[] { colorBlendAttachmentState }.Set(ref colorBlendStateCreatInfo.Attachments, ref colorBlendStateCreatInfo.AttachmentCount);
                colorBlendStateCreatInfo.pAttachments = &colorBlendAttachmentState; colorBlendStateCreatInfo.attachmentCount = 1;
            }
            var rasterizationStateCreateInfo = new VkPipelineRasterizationStateCreateInfo {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO,
                polygonMode = VkPolygonMode.VK_POLYGON_MODE_FILL,
                cullMode = VkCullModeFlagBits.VK_CULL_MODE_NONE,
                frontFace = VkFrontFace.VK_FRONT_FACE_CLOCKWISE,
                lineWidth = 1.0f
            };
            var inputAssemblyStateCreateInfo = new VkPipelineInputAssemblyStateCreateInfo {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO,
                topology = VkPrimitiveTopology.VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST
            };
            var vertexInputBindingDescription = new VkVertexInputBindingDescription {
                stride = 3 * sizeof(float),
                inputRate = VkVertexInputRate.VK_VERTEX_INPUT_RATE_VERTEX
            };
            var vertexInputAttributeDescription = new VkVertexInputAttributeDescription {
                format = VkFormat.VK_FORMAT_R32G32B32_SFLOAT
            };
            var vertexInputStateCreateInfo = new VkPipelineVertexInputStateCreateInfo();
            {
                vertexInputStateCreateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO;
                //new VkVertexInputBindingDescription[] { vertexInputBindingDescription }.Set(ref vertexInputStateCreateInfo.VertexBindingDescriptions, ref vertexInputStateCreateInfo.VertexBindingDescriptionCount);
                vertexInputStateCreateInfo.pVertexBindingDescriptions = &vertexInputBindingDescription;
                vertexInputStateCreateInfo.vertexBindingDescriptionCount = 1;
                //new VkVertexInputAttributeDescription[] { vertexInputAttributeDescription }.Set(ref vertexInputStateCreateInfo.VertexAttributeDescriptions, ref vertexInputStateCreateInfo.VertexAttributeDescriptionCount);
                vertexInputStateCreateInfo.pVertexAttributeDescriptions = &vertexInputAttributeDescription;
                vertexInputStateCreateInfo.vertexAttributeDescriptionCount = 1;
            }

            var pipelineCreateInfo = new VkGraphicsPipelineCreateInfo();
            {
                pipelineCreateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO;
                pipelineCreateInfo.layout = pipelineLayout;
                pipelineCreateInfo.pViewportState = &viewportCreateInfo;

                //pipelineShaderStages.Set(ref pipelineCreateInfo.Stages, ref pipelineCreateInfo.StageCount);
                var ptr = IntPtr.Zero;
                pipelineShaderStages.Set(ref ptr, ref pipelineCreateInfo.stageCount);
                pipelineCreateInfo.pStages = (VkPipelineShaderStageCreateInfo*)ptr;

                pipelineCreateInfo.pMultisampleState = &multisampleCreateInfo;
                pipelineCreateInfo.pColorBlendState = &colorBlendStateCreatInfo;
                pipelineCreateInfo.pRasterizationState = &rasterizationStateCreateInfo;
                pipelineCreateInfo.pInputAssemblyState = &inputAssemblyStateCreateInfo;
                pipelineCreateInfo.pVertexInputState = &vertexInputStateCreateInfo;
                pipelineCreateInfo.renderPass = renderPass;
            }

            var cacheInfo = new VkPipelineCacheCreateInfo { sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO };
            //VkPipelineCache cache = device.CreatePipelineCache(ref cacheInfo);
            VkPipelineCache cache;
            vkAPI.vkCreatePipelineCache(device, &cacheInfo, null, &cache);
            //var infos = new VkGraphicsPipelineCreateInfo[] { pipelineCreateInfo };
            //return device.CreateGraphicsPipelines(ref cache, infos);
            VkPipeline pipeline;
            vkAPI.vkCreateGraphicsPipelines(device, cache, 1, &pipelineCreateInfo, null, &pipeline);

            FreeHelper.Free(ref vs);
            FreeHelper.Free(ref fs);

            return new VkPipeline[] { pipeline };
        }

        VkPipelineLayout CreatePipelineLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout) {
            var info = new VkPipelineLayoutCreateInfo();
            {
                info.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO;
                //new UInt64[] { descriptorSetLayout.handle }.Set(ref info.SetLayouts, ref info.SetLayoutCount);
                info.pSetLayouts = &descriptorSetLayout; info.setLayoutCount = 1;
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
            var layoutBinding = new VkDescriptorSetLayoutBinding();
            {
                layoutBinding.descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER; // uniform
                layoutBinding.descriptorCount = 1; // single variable, not array.
                layoutBinding.stageFlags = VkShaderStageFlagBits.VK_SHADER_STAGE_VERTEX_BIT; // in vertex shader.
            }
            var info = new VkDescriptorSetLayoutCreateInfo();
            {
                info.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO;
                //new VkDescriptorSetLayoutBinding[] { layoutBinding }.Set(ref info.Bindings, ref info.BindingCount);
                info.pBindings = &layoutBinding; info.bindingCount = 1;
            }

            //return device.CreateDescriptorSetLayout(ref info);
            VkDescriptorSetLayout layout;
            vkAPI.vkCreateDescriptorSetLayout(device, &info, null, &layout);
            return layout;
        }

        VkBuffer CreateUniformBuffer(VkPhysicalDevice physicalDevice, VkDevice device, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var uniformBufferData = new AreaUniformBuffer {
                width = surfaceCapabilities.currentExtent.width,
                height = surfaceCapabilities.currentExtent.height
            };

            return CreateBuffer(physicalDevice, device, uniformBufferData, VkBufferUsageFlagBits.VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, typeof(AreaUniformBuffer));
        }

        VkBuffer CreateBuffer(VkPhysicalDevice physicalDevice, VkDevice device, object values, VkBufferUsageFlagBits usageFlags, System.Type type) {
            var array = values as System.Array;
            var length = (array != null) ? array.Length : 1;
            var size = System.Runtime.InteropServices.Marshal.SizeOf(type) * length;
            var info = new VkBufferCreateInfo();
            UInt32 index = 0;
            {
                info.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
                info.size = new VkDeviceSize((UInt64)size);
                info.usage = usageFlags;
                info.sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
                //new uint[] { index }.Set(ref info.QueueFamilyIndices, ref info.QueueFamilyIndexCount);
                info.pQueueFamilyIndices = &index; info.queueFamilyIndexCount = 1;
            }
            //VkBuffer buffer = device.CreateBuffer(ref info);
            VkBuffer buffer;
            vkAPI.vkCreateBuffer(device, &info, null, &buffer);
            //VkMemoryRequirements memoryReq = device.GetBufferMemoryRequirements(buffer);
            VkMemoryRequirements memoryReq;
            vkAPI.vkGetBufferMemoryRequirements(device, buffer, &memoryReq);
            var allocInfo = new VkMemoryAllocateInfo();
            {
                allocInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
                allocInfo.allocationSize = memoryReq.size;
            }
            VkPhysicalDeviceMemoryProperties memoryProperties;
            //physicalDevice.GetMemoryProperties(out memoryProperties);
            vkAPI.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memoryProperties);
            bool heapIndexSet = false;
            VkMemoryType* memoryTypes = (VkMemoryType*)memoryProperties.memoryTypes;

            for (uint i = 0; i < memoryProperties.memoryTypeCount; i++) {
                if (((memoryReq.memoryTypeBits >> (int)i) & 1) == 1 &&
                    (memoryTypes[i].propertyFlags & VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT) == VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT) {
                    allocInfo.memoryTypeIndex = i;
                    heapIndexSet = true;
                }
            }

            if (!heapIndexSet)
                allocInfo.memoryTypeIndex = memoryTypes[0].heapIndex;

            VkDeviceMemory deviceMemory; // = device.AllocateMemory(ref allocInfo);
            vkAPI.vkAllocateMemory(device, &allocInfo, null, &deviceMemory);
            //IntPtr memPtr;
            //device.MapMemory(deviceMemory, 0, size, 0, out memPtr);
            IntPtr memPtr = IntPtr.Zero;
            vkAPI.vkMapMemory(device, deviceMemory, new VkDeviceSize(), new VkDeviceSize((UInt64)size), 0, &memPtr);

            if (type == typeof(float))
                System.Runtime.InteropServices.Marshal.Copy(values as float[], 0, memPtr, length);
            else if (type == typeof(short))
                System.Runtime.InteropServices.Marshal.Copy(values as short[], 0, memPtr, length);
            else if (type == typeof(AreaUniformBuffer))
                System.Runtime.InteropServices.Marshal.StructureToPtr(values, memPtr, false);

            //device.UnmapMemory(deviceMemory);
            vkAPI.vkUnmapMemory(device, deviceMemory);
            //device.BindBufferMemory(buffer, deviceMemory, 0);
            vkAPI.vkBindBufferMemory(device, buffer, deviceMemory, new VkDeviceSize());

            return buffer;
        }

        struct AreaUniformBuffer {
            public float width;
            public float height;

            public AreaUniformBuffer(float width, float height) {
                this.width = height; this.height = height;
            }
        }

        protected VkFramebuffer[] CreateFramebuffers(VkDevice device, VkImage[] images, VkSurfaceFormatKHR surfaceFormat, VkRenderPass renderPass, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var displayViews = new VkImageView[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var info = new VkImageViewCreateInfo {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO,
                    image = images[i],
                    viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D,
                    format = surfaceFormat.format,
                    components = new VkComponentMapping {
                        r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_R,
                        g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_G,
                        b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_B,
                        a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_A
                    },
                    subresourceRange = new VkImageSubresourceRange {
                        aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                        levelCount = 1,
                        layerCount = 1
                    }
                };
                //displayViews[i] = device.CreateImageView(ref info);
                VkImageView view;
                vkAPI.vkCreateImageView(device, &info, null, &view);
                displayViews[i] = view;
            }

            var framebuffers = new VkFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                VkImageView view;
                var info = new VkFramebufferCreateInfo();
                {
                    info.sType = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO;
                    info.layers = 1;
                    info.renderPass = renderPass;
                    view = displayViews[i];
                    //new UInt64[] { displayViews[i].handle }.Set(ref info.Attachments, ref info.AttachmentCount);
                    info.pAttachments = &view; info.attachmentCount = 1;
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
            var attDesc = new VkAttachmentDescription {
                format = surfaceFormat.format,
                samples = VkSampleCountFlagBits.VK_SAMPLE_COUNT_1_BIT,
                loadOp = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_CLEAR,
                storeOp = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_STORE,
                stencilLoadOp = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_DONT_CARE,
                stencilStoreOp = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_DONT_CARE,
                initialLayout = VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
                finalLayout = VkImageLayout.VK_IMAGE_LAYOUT_PRESENT_SRC_KHR
            };
            var attRef = new VkAttachmentReference { layout = VkImageLayout.VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL };
            var subpassDesc = new VkSubpassDescription();
            {
                subpassDesc.pipelineBindPoint = VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS;
                //new UInt32[] { attRef.Attachment }.Set(ref subpassDesc.ColorAttachments, ref subpassDesc.ColorAttachmentCount);
                subpassDesc.pColorAttachments = &attRef; subpassDesc.colorAttachmentCount = 1;
            }
            var info = new VkRenderPassCreateInfo();
            {
                info.sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO;
                //new VkAttachmentDescription[] { attDesc }.Set(ref info.Attachments, ref info.AttachmentCount);
                info.pAttachments = &attDesc; info.attachmentCount = 1;
                //new VkSubpassDescription[] { subpassDesc }.Set(ref info.Subpasses, ref info.SubpassCount);
                info.pSubpasses = &subpassDesc; info.subpassCount = 1;
            }

            //return device.CreateRenderPass(ref info);
            VkRenderPass renderpass;
            vkAPI.vkCreateRenderPass(device, &info, null, &renderpass);
            return renderpass;
        }

        protected VkSwapchainKHR CreateSwapchain(VkDevice device, VkSurfaceKHR surface, VkSurfaceFormatKHR surfaceFormat, VkSurfaceCapabilitiesKHR surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.supportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagBitsKHR.VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR)
                ? VkCompositeAlphaFlagBitsKHR.VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR
                : VkCompositeAlphaFlagBitsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR;
            UInt32 index = 0;
            var info = new VkSwapchainCreateInfoKHR();
            {
                info.sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR;
                info.surface = surface;
                info.minImageCount = surfaceCapabilities.minImageCount;
                info.imageFormat = surfaceFormat.format;
                info.imageColorSpace = surfaceFormat.colorSpace;
                info.imageExtent = surfaceCapabilities.currentExtent;
                info.imageUsage = VkImageUsageFlagBits.VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT;
                info.preTransform = VkSurfaceTransformFlagBitsKHR.VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR;
                info.imageArrayLayers = 1;
                info.imageSharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
                //new UInt32[] { 0 }.Set(ref info.QueueFamilyIndices, ref info.QueueFamilyIndexCount);
                info.pQueueFamilyIndices = &index; info.queueFamilyIndexCount = 1;
                info.presentMode = VkPresentModeKHR.VK_PRESENT_MODE_FIFO_KHR;
                info.compositeAlpha = compositeAlpha;
            }

            //return device.CreateSwapchainKHR(ref info, null);
            VkSwapchainKHR swapchain;
            vkAPI.vkCreateSwapchainKHR(device, &info, null, &swapchain);
            return swapchain;
        }

        protected VkSurfaceFormatKHR SelectFormat(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface) {
            VkSurfaceFormatKHR[] formats;
            //physicalDevice.GetSurfaceFormatsKHR(surface, out formats);
            {
                UInt32 count;
                vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, &count, null);
                formats = new VkSurfaceFormatKHR[count];
                fixed (VkSurfaceFormatKHR* pointer = formats) {
                    vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, &count, pointer);
                }
            }
            foreach (var f in formats)
                if (f.format == VkFormat.VK_FORMAT_R8G8B8A8_UNORM || f.format == VkFormat.VK_FORMAT_B8G8R8A8_UNORM)
                    return f;

            throw new System.Exception("didn't find the R8G8B8A8Unorm or B8G8R8A8Unorm format");
        }

        private VkDevice CreateDevice(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface) {
            //VkQueueFamilyProperties[] properties = physicalDevice.GetQueueFamilyProperties();
            VkQueueFamilyProperties[] properties;
            {
                UInt32 count;
                vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &count, null);
                properties = new VkQueueFamilyProperties[count];
                fixed (VkQueueFamilyProperties* pointer = properties) {
                    vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &count, pointer);
                }
            }
            uint index;
            for (index = 0; index < properties.Length; ++index) {
                VkBool32 supported;
                //physicalDevice.GetSurfaceSupportKHR(index, surface, out supported);
                vkAPI.vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, index, surface, &supported);
                if (!supported) { continue; }

                if (properties[index].queueFlags.HasFlag(VkQueueFlagBits.VK_QUEUE_GRAPHICS_BIT)) break;
            }

            //float priority = 1.0f;
            var priorities = new float[] { 1.0f };
            var queueInfo = new VkDeviceQueueCreateInfo();
            {
                queueInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO;
                //queueInfo.pQueuePriorities = &priority; queueInfo.queueCount = 1;
                new float[] { 1.0f }.Set(ref queueInfo.pQueuePriorities, ref queueInfo.queueCount);
                queueInfo.queueFamilyIndex = index;
            }

            var deviceInfo = new VkDeviceCreateInfo();
            //IntPtr name = IntPtr.Zero; "VK_KHR_swapchain".Set(ref name);
            {
                deviceInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO;

                //deviceInfo.ppEnabledExtensionNames = &name; deviceInfo.enabledExtensionCount = 1;
                new string[] { "VK_KHR_swapchain" }.Set(ref deviceInfo.ppEnabledExtensionNames, ref deviceInfo.enabledExtensionCount);

                //deviceInfo.pQueueCreateInfos = &queueInfo; deviceInfo.queueCreateInfoCount = 1;
                IntPtr ptr = IntPtr.Zero;
                new VkDeviceQueueCreateInfo[] { queueInfo }.Set(ref ptr, ref deviceInfo.queueCreateInfoCount);
                deviceInfo.pQueueCreateInfos = (VkDeviceQueueCreateInfo*)ptr;
            }

            VkDevice device;
            //physicalDevice.CreateDevice(ref deviceInfo, null, out device);
            vkAPI.vkCreateDevice(physicalDevice, &deviceInfo, null, &device);

            FreeHelper.Free(ref deviceInfo);
            FreeHelper.Free(ref queueInfo);

            return device;
        }

        private VkPhysicalDevice InitPhysicalDevice(VkInstance instance) {
            VkPhysicalDevice[] physicalDevices;
            //instance.EnumeratePhysicalDevices(out physicalDevices);
            {
                UInt32 count;
                vkAPI.vkEnumeratePhysicalDevices(instance, &count, null);
                physicalDevices = new VkPhysicalDevice[count];
                if (count > 0) {
                    fixed (VkPhysicalDevice* pointer = physicalDevices) {
                        vkAPI.vkEnumeratePhysicalDevices(instance, &count, pointer);
                    }
                }
            }
            return physicalDevices[0];
        }

        private VkSurfaceKHR InitSurface(VkInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKHR {
                sType = VkStructureType.VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR,
                hwnd = hwnd,
                hinstance = processHandle, //Process.GetCurrentProcess().Handle
            };
            //return instance.CreateWin32SurfaceKHR(ref info, null);
            //VkSurfaceKHR surface;
            VkSurfaceKHR surface;
            vkAPI.vkCreateWin32SurfaceKHR(instance, &info, null, &surface);
            return surface;
        }

        private VkInstance InitInstance() {
            VkLayerProperties[] layerProperties;
            //Layer.EnumerateInstanceLayerProperties(out layerProperties);
            {
                UInt32 count;
                vkAPI.vkEnumerateInstanceLayerProperties(&count, null).Check();
                layerProperties = new VkLayerProperties[count];
                if (count > 0) {
                    fixed (VkLayerProperties* pointer = layerProperties) {
                        vkAPI.vkEnumerateInstanceLayerProperties(&count, pointer).Check();
                    }
                }
            }

            string[] layersToEnable = layerProperties.Any(l => Marshal.PtrToStringAnsi((IntPtr)l.layerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = new VkApplicationInfo();
            {
                appInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO;
                UInt32 version = ApiSpec.Generated.Version.Make(1, 0, 0);
                appInfo.apiVersion = version;
            }

            var extensions = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" };

            var info = new VkInstanceCreateInfo();
            {
                info.sType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO;
                extensions.Set(ref info.ppEnabledExtensionNames, ref info.enabledExtensionCount);
                layersToEnable.Set(ref info.ppEnabledLayerNames, ref info.enabledLayerCount);
                info.pApplicationInfo = &appInfo;
            }

            VkInstance result;
            //VkInstance.Create(ref info, null, out result).Check();
            vkAPI.vkCreateInstance(&info, null, &result).Check();
            FreeHelper.Free(ref info);

            return result;
        }

        private VkSubmitInfo[] submitInfos;
        private VkPresentInfoKHR[] presentInfos;

        private void InitRenderParams() {
            VkDevice device = this.vkDevice; VkSwapchainKHR swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;

            submitInfos = new VkSubmitInfo[2]; presentInfos = new VkPresentInfoKHR[2];
            for (uint index = 0; index < 2; index++) {
                var submitInfo = new VkSubmitInfo();
                {
                    IntPtr ptr = IntPtr.Zero;
                    new[] { semaphore }.Set(ref ptr, ref submitInfo.waitSemaphoreCount);
                    submitInfo.pWaitSemaphores = (VkSemaphore*)ptr;

                    // I have to use int instead of enum VkPipelineStageFlags.
                    ptr = IntPtr.Zero;
                    new[] { (int)VkPipelineStageFlagBits.VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT }.Set(ref ptr, ref submitInfo.waitSemaphoreCount);
                    submitInfo.pWaitDstStageMask = (VkPipelineStageFlagBits*)ptr;

                    ptr = IntPtr.Zero;
                    new[] { commandBuffers[index] }.Set(ref ptr, ref submitInfo.commandBufferCount);
                    submitInfo.pCommandBuffers = (VkCommandBuffer*)ptr;
                }
                submitInfos[index] = submitInfo;
                var presentInfo = new VkPresentInfoKHR();
                {
                    presentInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_INFO_KHR;

                    IntPtr ptr = IntPtr.Zero;
                    new[] { swapchain }.Set(ref ptr, ref presentInfo.swapchainCount);
                    presentInfo.pSwapchains = (VkSwapchainKHR*)ptr;

                    ptr = IntPtr.Zero;
                    new[] { index }.Set(ref presentInfo.pImageIndices, ref presentInfo.swapchainCount);
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
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
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
