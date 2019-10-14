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

namespace Demo.DynamicUniformBuffer {
    /// <summary>
    /// 
    /// </summary>
    public unsafe class DynamicUniformBufferExample : DemoBase {
        private const uint VERTEX_BUFFER_BIND_ID = 0;
        private const uint OBJECT_INSTANCES = 125;

        VkPipelineVertexInputStateCreateInfo* vertices_inputState;
        VkVertexInputBindingDescription[] vbindingDescs;
        VkVertexInputAttributeDescription[] vAttrDescs;

        vksBuffer vertexBuffer = new vksBuffer();
        vksBuffer indexBuffer = new vksBuffer();
        uint indexCount;

        vksBuffer uniformBuffers_view = new vksBuffer();
        vksBuffer uniformBuffers_dynamic = new vksBuffer();

        UboVS uboVS;
        // Store random per-object rotations
        Vector3[] rotations = new Vector3[OBJECT_INSTANCES];
        Vector3[] rotationSpeeds = new Vector3[OBJECT_INSTANCES];

        // One big uniform buffer that contains all matrices
        // Note that we need to manually allocate the data to cope for GPU-specific uniform buffer offset alignments
        Matrix4x4* uboDataDynamic_model;

        VkPipeline pipeline;
        VkPipelineLayout pipelineLayout;
        VkDescriptorSet descriptorSet;
        VkDescriptorSetLayout descriptorSetLayout;
        float animationTimer = 0.0f;

        IntPtr dynamicAlignment;

        public DynamicUniformBufferExample() {
            title = "Vulkan Example - Dynamic uniform buffers";
            // enableTextOverlay = true;
            camera.type = Camera.CameraType.lookat;
            camera.setPosition(new Vector3(0.0f, 0.0f, -30.0f));
            camera.setRotation(new Vector3(0.0f));
            camera.setPerspective(60.0f, (float)width / (float)height, 0.1f, 256.0f);
        }


        public void Dispose() {
            if (uboDataDynamic_model != null) {
                Marshal.FreeHGlobal((IntPtr)uboDataDynamic_model);
            }

            // Clean up used Vulkan resources 
            // Note : Inherited destructor cleans up resources stored in base class
            vkDestroyPipeline(device, pipeline, null);

            vkDestroyPipelineLayout(device, pipelineLayout, null);
            vkDestroyDescriptorSetLayout(device, descriptorSetLayout, null);

            vertexBuffer.destroy();
            indexBuffer.destroy();

            uniformBuffers_view.destroy();
            uniformBuffers_dynamic.destroy();
        }


        protected override void buildCommandBuffers() {
            var cmdBufInfo = new VkCommandBufferBeginInfo();
            cmdBufInfo.sType = CommandBufferBeginInfo;

            var clearValues = new VkClearValue[2];
            clearValues[0].color = defaultClearColor;
            clearValues[1].depthStencil = new VkClearDepthStencilValue(1.0f, 0);

            var info = new VkRenderPassBeginInfo();
            info.sType = RenderPassBeginInfo;
            info.renderPass = renderPass;
            info.renderArea.offset.x = 0;
            info.renderArea.offset.y = 0;
            info.renderArea.extent.width = width;
            info.renderArea.extent.height = height;
            clearValues.Set(&info);

            for (int i = 0; i < drawCmdBuffers.Length; ++i) {
                info.framebuffer = frameBuffers[i];

                vkBeginCommandBuffer(drawCmdBuffers[i], &cmdBufInfo);

                vkCmdBeginRenderPass(drawCmdBuffers[i], &info, VkSubpassContents.Inline);

                var viewport = new VkViewport(0, 0, width, height, 0.0f, 1.0f);
                vkCmdSetViewport(drawCmdBuffers[i], 0, 1, &viewport);

                var scissor = new VkRect2D(0, 0, width, height);
                vkCmdSetScissor(drawCmdBuffers[i], 0, 1, &scissor);

                vkCmdBindPipeline(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, pipeline);

                VkDeviceSize offsets = 0;
                VkBuffer buffer = vertexBuffer.buffer;
                vkCmdBindVertexBuffers(drawCmdBuffers[i], VERTEX_BUFFER_BIND_ID, 1, &buffer, &offsets);
                vkCmdBindIndexBuffer(drawCmdBuffers[i], indexBuffer.buffer, 0, VkIndexType.Uint32);

                // Render multiple objects using different model matrices by dynamically offsetting into one uniform buffer
                for (uint j = 0; j < OBJECT_INSTANCES; j++) {
                    // One dynamic offset per dynamic descriptor to offset into the ubo containing all model matrices
                    uint dynamicOffset = j * (uint)(dynamicAlignment);
                    // Bind the descriptor set for rendering a mesh using the dynamic offset
                    VkDescriptorSet set = descriptorSet;
                    vkCmdBindDescriptorSets(drawCmdBuffers[i], VkPipelineBindPoint.Graphics,
                        pipelineLayout, 0, 1, &set, 1, &dynamicOffset);

                    vkCmdDrawIndexed(drawCmdBuffers[i], indexCount, 1, 0, 0, 0);
                }

                vkCmdEndRenderPass(drawCmdBuffers[i]);

                vkEndCommandBuffer(drawCmdBuffers[i]);
            }
        }

        public override void Init(Control canvas) {
            base.Init(canvas);
            generateCube();
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
            base.Render();

            updateDynamicUniformBuffer();

            prepareFrame();

            // Command buffer to be sumitted to the queue
            drawCmdBuffers[currentBuffer].Set(submitInfo);

            // Submit to queue
            vkQueueSubmit(queue, 1, submitInfo, new VkFence());

            submitFrame();
        }

        void generateCube() {
            // Setup vertices indices for a colored cube
            var vertices = new Vertex[]
            {
                new Vertex { pos = new Vector3(-1.0f, -1.0f, 1.0f),  color = new Vector3(1.0f, 0.0f, 0.0f) },
                new Vertex { pos = new Vector3(1.0f, -1.0f, 1.0f),   color = new Vector3(0.0f, 1.0f, 0.0f) },
                new Vertex { pos = new Vector3(1.0f, 1.0f, 1.0f),    color = new Vector3(0.0f, 0.0f, 1.0f) },
                new Vertex { pos = new Vector3(-1.0f, 1.0f, 1.0f),   color = new Vector3(0.0f, 0.0f, 0.0f) },
                new Vertex { pos = new Vector3(-1.0f, -1.0f, -1.0f), color = new Vector3(1.0f, 0.0f, 0.0f) },
                new Vertex { pos = new Vector3(1.0f, -1.0f, -1.0f),  color = new Vector3(0.0f, 1.0f, 0.0f) },
                new Vertex { pos = new Vector3(1.0f, 1.0f, -1.0f),   color = new Vector3(0.0f, 0.0f, 1.0f) },
                new Vertex { pos = new Vector3(-1.0f, 1.0f, -1.0f),  color = new Vector3(0.0f, 0.0f, 0.0f) }
            };

            var indices = new uint[]
            {
                0,1,2, 2,3,0, 1,5,6, 6,2,1, 7,6,5, 5,4,7, 4,0,3, 3,7,4, 4,5,1, 1,0,4, 3,2,6, 6,7,3,
            };

            indexCount = (uint)indices.Length;

            // Create buffers
            // For the sake of simplicity we won't stage the vertex data to the gpu memory
            // Vertex buffer
            fixed (void* pointer = vertices) {
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.VertexBuffer,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                    vertexBuffer,
                    (ulong)(vertices.Length * sizeof(Vertex)),
                    pointer);
            }
            // Index buffer
            fixed (void* pointer = indices) {
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.IndexBuffer,
                    VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                    indexBuffer,
                    (ulong)(indices.Length * sizeof(uint)),
                    pointer);
            }
        }

        void setupVertexDescriptions() {
            // Binding description
            vbindingDescs = new VkVertexInputBindingDescription[]
            {
                new VkVertexInputBindingDescription(
                    binding: VERTEX_BUFFER_BIND_ID,
                    stride: (uint)sizeof(Vertex),
                    inputRate: VkVertexInputRate.Vertex)
            };

            // Attribute descriptions
            vAttrDescs = new VkVertexInputAttributeDescription[] {
                // layout (location = 0) in vec3 inPos;
                new VkVertexInputAttributeDescription(
                    location: 0,
                    binding: VERTEX_BUFFER_BIND_ID,
                    format: VkFormat.R32g32b32Sfloat,
                    offset: 0),
                // layout (location = 1) in vec3 inColor;
                new VkVertexInputAttributeDescription(
                    location: 1,
                    binding: VERTEX_BUFFER_BIND_ID,
                    format: VkFormat.R32g32b32Sfloat,
                    offset: (uint)sizeof(Vector3)),
            };

            vertices_inputState = VkPipelineVertexInputStateCreateInfo.Alloc();
            vbindingDescs.Set(vertices_inputState);
            vAttrDescs.Set(vertices_inputState);
        }

        void setupDescriptorPool() {
            // Example uses one ubo and one image sampler
            var poolSizes = new VkDescriptorPoolSize[] {
                new VkDescriptorPoolSize(VkDescriptorType.UniformBuffer, 1),
                new VkDescriptorPoolSize(VkDescriptorType.UniformBufferDynamic, 1),
                new VkDescriptorPoolSize(VkDescriptorType.CombinedImageSampler, 1),
            };

            var info = new VkDescriptorPoolCreateInfo();
            info.sType = DescriptorPoolCreateInfo;
            info.poolSizes = poolSizes;
            info.maxSets = 2;

            VkDescriptorPool pool;
            vkCreateDescriptorPool(device, &info, null, &pool);
            this.descriptorPool = pool;
        }

        void setupDescriptorSetLayout() {
            var bindings = new VkDescriptorSetLayoutBinding[] {
                // layout (binding = 0) uniform UboView 
                new VkDescriptorSetLayoutBinding(0, VkDescriptorType.UniformBuffer, 1, VkShaderStageFlagBits.Vertex),
                // layout (binding = 1) uniform UboInstance 
                new VkDescriptorSetLayoutBinding(1, VkDescriptorType.UniformBufferDynamic, 1, VkShaderStageFlagBits.Vertex),
                // no matching uniform sampler2D in shader.
                new VkDescriptorSetLayoutBinding(2, VkDescriptorType.CombinedImageSampler, 1, VkShaderStageFlagBits.Fragment),
            };

            var descriptorLayoutInfo = new VkDescriptorSetLayoutCreateInfo();
            descriptorLayoutInfo.sType = DescriptorSetLayoutCreateInfo;
            descriptorLayoutInfo.bindings = bindings;

            VkDescriptorSetLayout layout;
            vkCreateDescriptorSetLayout(device, &descriptorLayoutInfo, null, &layout);
            this.descriptorSetLayout = layout;

            VkPipelineLayoutCreateInfo info = new VkPipelineLayoutCreateInfo();
            info.sType = PipelineLayoutCreateInfo;
            layout.Set(&info);

            VkPipelineLayout pipelineLayout;
            vkCreatePipelineLayout(device, &info, null, &pipelineLayout);
            this.pipelineLayout = pipelineLayout;
        }

        void setupDescriptorSet() {
            var allocInfo = new VkDescriptorSetAllocateInfo();
            allocInfo.sType = DescriptorSetAllocateInfo;
            allocInfo.descriptorPool = descriptorPool;
            allocInfo.setLayouts = descriptorSetLayout;

            VkDescriptorSet set;
            vkAllocateDescriptorSets(device, &allocInfo, &set);
            this.descriptorSet = set;

            VkDescriptorBufferInfo descriptor0 = uniformBuffers_view.descriptor;
            VkDescriptorBufferInfo descriptor1 = uniformBuffers_dynamic.descriptor;
            var writeDescriptorSets = new VkWriteDescriptorSet[] {
                // Binding 0 : Projection/View matrix uniform buffer            
                new VkWriteDescriptorSet(){
                    sType = WriteDescriptorSet,
                    dstSet = descriptorSet,
                    descriptorType = VkDescriptorType.UniformBuffer,
                    dstBinding = 0,
                    pBufferInfo = &descriptor0,
                    descriptorCount = 1
                    // descriptor0.Set(ref write);
                },
                // Binding 1 : Instance matrix as dynamic uniform buffer
                new VkWriteDescriptorSet() {
                    sType = WriteDescriptorSet,
                    dstSet = descriptorSet,
                    descriptorType = VkDescriptorType.UniformBufferDynamic,
                    dstBinding = 1,
                    pBufferInfo = &descriptor1,
                    descriptorCount = 1
                    // descriptor1.Set(ref write);
                }
            };

            fixed (VkWriteDescriptorSet* pointer = writeDescriptorSets) {
                vkUpdateDescriptorSets(device, (UInt32)writeDescriptorSets.Length, pointer, 0, null);
            }
        }

        void preparePipelines() {
            var inputAssemblyState = new VkPipelineInputAssemblyStateCreateInfo();
            inputAssemblyState.sType = PipelineInputAssemblyStateCreateInfo;
            inputAssemblyState.topology = VkPrimitiveTopology.TriangleList;
            inputAssemblyState.primitiveRestartEnable = false;

            var rasterizationState = new VkPipelineRasterizationStateCreateInfo();
            rasterizationState.sType = PipelineRasterizationStateCreateInfo;
            rasterizationState.polygonMode = VkPolygonMode.Fill;
            rasterizationState.cullMode = VkCullModeFlagBits.None;
            rasterizationState.frontFace = VkFrontFace.CounterClockwise;

            var blendAttachmentState = new VkPipelineColorBlendAttachmentState(
                (VkColorComponentFlagBits)0xf, false);

            var colorBlendState = new VkPipelineColorBlendStateCreateInfo();
            colorBlendState.sType = PipelineColorBlendStateCreateInfo;
            blendAttachmentState.Set(&colorBlendState);

            var depthStencilState = new VkPipelineDepthStencilStateCreateInfo();
            depthStencilState.sType = PipelineDepthStencilStateCreateInfo;
            depthStencilState.depthTestEnable = true;
            depthStencilState.depthWriteEnable = true;
            depthStencilState.depthCompareOp = VkCompareOp.LessOrEqual;

            var viewportState = new VkPipelineViewportStateCreateInfo();
            viewportState.sType = PipelineViewportStateCreateInfo;
            viewportState.viewportCount = 1;
            viewportState.scissorCount = 1;

            var multisampleState = new VkPipelineMultisampleStateCreateInfo();
            multisampleState.sType = PipelineMultisampleStateCreateInfo;
            multisampleState.rasterizationSamples = VkSampleCountFlagBits._1;

            var dynamicStateEnables = new VkDynamicState[]{
                VkDynamicState.Viewport,
                VkDynamicState.Scissor,
            };

            var dynamicState = new VkPipelineDynamicStateCreateInfo();
            dynamicState.sType = PipelineDynamicStateCreateInfo;
            dynamicStateEnables.Set(&dynamicState);

            // Load shaders
            var shaderStages = new VkPipelineShaderStageCreateInfo[]{
                loadShader(getAssetPath() + "shaders/dynamicuniformbuffer/base.vert.spv",  VkShaderStageFlagBits.Vertex),
                loadShader(getAssetPath() + "shaders/dynamicuniformbuffer/base.frag.spv",  VkShaderStageFlagBits.Fragment)
            };

            var info = new VkGraphicsPipelineCreateInfo();
            info.sType = GraphicsPipelineCreateInfo;
            info.layout = pipelineLayout;
            info.renderPass = renderPass;
            info.pVertexInputState = vertices_inputState;
            info.pInputAssemblyState = &inputAssemblyState;
            info.pRasterizationState = &rasterizationState;
            info.pColorBlendState = &colorBlendState;
            info.pMultisampleState = &multisampleState;
            info.pViewportState = &viewportState;
            info.pDepthStencilState = &depthStencilState;
            info.pDynamicState = &dynamicState;
            info.stages = shaderStages;

            VkPipeline pipeline;
            vkCreateGraphicsPipelines(device, pipelineCache, 1, &info, null, &pipeline);
            this.pipeline = pipeline;
        }

        // Prepare and initialize uniform buffer containing shader uniforms
        void prepareUniformBuffers() {
            // Allocate data for the dynamic uniform buffer object
            // We allocate this manually as the alignment of the offset differs between GPUs

            // Calculate required alignment depending on device limits
            ulong uboAlignment = vulkanDevice.properties.limits.minUniformBufferOffsetAlignment;
            dynamicAlignment = (IntPtr)(((ulong)sizeof(Matrix4x4) / uboAlignment) * uboAlignment + (((ulong)sizeof(Matrix4x4) % uboAlignment) > 0 ? uboAlignment : 0));

            IntPtr bufferSize = (IntPtr)(OBJECT_INSTANCES * (ulong)dynamicAlignment);

            uboDataDynamic_model = (Matrix4x4*)Marshal.AllocHGlobal(bufferSize);
            Debug.Assert(uboDataDynamic_model != null);

            Console.WriteLine("minUniformBufferOffsetAlignment = " + uboAlignment);
            Console.WriteLine("dynamicAlignment = " + dynamicAlignment);

            // Vertex shader uniform buffer block

            // Static shared uniform buffer object with projection and view matrix
            vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                uniformBuffers_view,
                (ulong)sizeof(UboVS));

            // Uniform buffer object with per-object matrices
            vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible,
                uniformBuffers_dynamic,
                (ulong)bufferSize);

            // Map persistent
            uniformBuffers_view.map();
            uniformBuffers_dynamic.map();

            // Prepare per-object matrices with offsets and random rotations
            Random rndGen = new Random();
            Func<Random, float> rndDist = rand => (float)(rand.NextDouble() * 2 - 1.0);
            for (uint i = 0; i < OBJECT_INSTANCES; i++) {
                rotations[i] = new Vector3(rndDist(rndGen), rndDist(rndGen), rndDist(rndGen)) * 2.0f * (float)Math.PI;
                rotationSpeeds[i] = new Vector3(rndDist(rndGen), rndDist(rndGen), rndDist(rndGen));
            }

            updateUniformBuffers();
            updateDynamicUniformBuffer(true);
        }

        void updateUniformBuffers() {
            // Fixed ubo with projection and view matrices
            uboVS.projection = camera.matrices_perspective;
            uboVS.view = camera.matrices_view;

            var local = uboVS;
            Unsafe.CopyBlock(uniformBuffers_view.mapped, &local, (uint)sizeof(UboVS));
        }

        void updateDynamicUniformBuffer(bool force = false) {
            // Update at max. 60 fps
            animationTimer += (frameTimer * 1.0f);
            if ((animationTimer <= 1.0f / 60.0f) && (!force)) {
                return;
            }

            // Dynamic ubo with per-object model matrices indexed by offsets in the command buffer
            uint dim = (uint)(Math.Pow(OBJECT_INSTANCES, (1.0f / 3.0f)));
            Vector3 offset = new Vector3(5.0f);

            for (uint x = 0; x < dim; x++) {
                for (uint y = 0; y < dim; y++) {
                    for (uint z = 0; z < dim; z++) {
                        uint index = x * dim * dim + y * dim + z;

                        // Aligned offset
                        Matrix4x4* modelMat = (Matrix4x4*)(((ulong)uboDataDynamic_model + (index * (ulong)dynamicAlignment)));

                        // Update rotations
                        rotations[index] += animationTimer * rotationSpeeds[index];

                        // Update matrices
                        Vector3 pos = new Vector3(-((dim * offset.X) / 2.0f) + offset.X / 2.0f + x * offset.X, -((dim * offset.Y) / 2.0f) + offset.Y / 2.0f + y * offset.Y, -((dim * offset.Z) / 2.0f) + offset.Z / 2.0f + z * offset.Z);
                        *modelMat = Matrix4x4.CreateTranslation(pos);
                        *modelMat = Matrix4x4.CreateRotationX(Util.DegreesToRadians(rotations[index].X)) * *modelMat;
                        *modelMat = Matrix4x4.CreateRotationY(Util.DegreesToRadians(rotations[index].Y)) * *modelMat;
                        *modelMat = Matrix4x4.CreateRotationZ(Util.DegreesToRadians(rotations[index].Z)) * *modelMat;
                    }
                }
            }

            animationTimer = 0.0f;

            Unsafe.CopyBlock(uniformBuffers_dynamic.mapped, uboDataDynamic_model, (uint)uniformBuffers_dynamic.size);
            // Flush to make changes visible to the host 
            //VkMappedMemoryRange memoryRange = Initializers.mappedMemoryRange();
            //memoryRange.memory = uniformBuffers_dynamic.memory;
            //memoryRange.size = uniformBuffers_dynamic.size;
            //vkFlushMappedMemoryRanges(device, 1, &memoryRange);
        }
    }
}
