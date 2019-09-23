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
using Assimp;
using System.Windows.Forms;

namespace Demo02.Mesh {
    /// <summary>
    /// 
    /// </summary>
    public unsafe class MeshDemo : DemoBase {
        private const uint VERTEX_BUFFER_BIND_ID = 0;
        bool wireframe = false;
        vksTexture2D textures_colorMap = new vksTexture2D();

        VkPipelineVertexInputStateCreateInfo vertices_inputState;
        VkVertexInputBindingDescription[] vertices_bindingDescriptions;
        VkVertexInputAttributeDescription[] vertices_attributeDescriptions;

        // Contains all Vulkan resources required to represent vertex and index buffers for a model
        // This is for demonstration and learning purposes, the other examples use a model loader class for easy access
        VkBuffer model_vertices_buffer;
        VkDeviceMemory model_vertices_memory;

        int model_indices_count;
        VkBuffer model_indices_buffer;
        VkDeviceMemory model_indices_memory;

        // Destroys all Vulkan resources created for this model
        void destroyModel(VkDevice Device) {
            vkDestroyBuffer(Device, model_vertices_buffer, null);
            vkFreeMemory(Device, model_vertices_memory, null);
            vkDestroyBuffer(Device, model_indices_buffer, null);
            vkFreeMemory(Device, model_indices_memory, null);
        }

        vksBuffer uniformBuffers_scene = new vksBuffer();

        UboVS uboVS = new UboVS() { lightPos = new Vector4(25.0f, 5.0f, 5.0f, 1.0f) };
        VkPipeline pipelines_solid;
        VkPipeline pipelines_wireframe;

        VkPipelineLayout pipelineLayout;
        VkDescriptorSet descriptorSet;
        VkDescriptorSetLayout descriptorSetLayout;


        public MeshDemo() {
            zoom = -5.5f;
            zoomSpeed = 20.5f;
            rotationSpeed = 0.5f;
            rotation = new Vector3(-0.5f, -112.75f, 0.0f);
            cameraPos = new Vector3(0.1f, 1.1f, 0.0f);
            title = "Vulkan Example - Model rendering";
        }

        public void Dispose() {
            // Clean up used Vulkan resources 
            // Note : Inherited destructor cleans up resources stored in base class
            vkDestroyPipeline(device, pipelines_solid, null);
            if (pipelines_wireframe.handle != 0) {
                vkDestroyPipeline(device, pipelines_wireframe, null);
            }

            vkDestroyPipelineLayout(device, pipelineLayout, null);
            vkDestroyDescriptorSetLayout(device, descriptorSetLayout, null);

            destroyModel(device);

            textures_colorMap.destroy();
            uniformBuffers_scene.destroy();
        }

        protected override void getEnabledFeatures() {
            // Fill mode non solid is required for wireframe display
            if (DeviceFeatures.fillModeNonSolid == true) {
                var features = enabledFeatures;
                features.fillModeNonSolid = true;
                enabledFeatures = features;
            };
        }

        void reBuildCommandBuffers() {
            if (!checkCommandBuffers()) {
                destroyCommandBuffers();
                createCommandBuffers();
            }
            buildCommandBuffers();
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
            clearValues.Set(ref renderPassBeginInfo);

            for (int i = 0; i < drawCmdBuffers.Length; ++i) {
                // Set target frame buffer
                renderPassBeginInfo.framebuffer = frameBuffers[i];

                vkBeginCommandBuffer(drawCmdBuffers[i], &cmdBufInfo);

                vkCmdBeginRenderPass(drawCmdBuffers[i], &renderPassBeginInfo, VkSubpassContents.Inline);

                VkViewport viewport = new VkViewport();
                viewport.width = width; viewport.height = height; viewport.minDepth = 0.0f; viewport.maxDepth = 1.0f;
                vkCmdSetViewport(drawCmdBuffers[i], 0, 1, &viewport);

                VkRect2D scissor = new VkRect2D();
                scissor.extent.width = width; scissor.extent.height = height; scissor.offset.x = 0; scissor.offset.y = 0;
                vkCmdSetScissor(drawCmdBuffers[i], 0, 1, &scissor);

                {
                    VkDescriptorSet set = descriptorSet;
                    vkCmdBindDescriptorSets(drawCmdBuffers[i], VkPipelineBindPoint.Graphics,
                        pipelineLayout, 0, 1, &set, 0, null);
                }
                vkCmdBindPipeline(drawCmdBuffers[i], VkPipelineBindPoint.Graphics, wireframe ? pipelines_wireframe : pipelines_solid);

                ulong offsets = 0;
                // Bind mesh vertex buffer
                {
                    VkBuffer buffer = model_vertices_buffer;
                    VkDeviceSize offset = offsets;
                    vkCmdBindVertexBuffers(drawCmdBuffers[i], VERTEX_BUFFER_BIND_ID, 1, &buffer, &offset);
                }
                // Bind mesh index buffer
                vkCmdBindIndexBuffer(drawCmdBuffers[i], model_indices_buffer, 0, VkIndexType.Uint32);
                // Render mesh vertex buffer using it's indices
                vkCmdDrawIndexed(drawCmdBuffers[i], (uint)model_indices_count, 1, 0, 0, 0);

                vkCmdEndRenderPass(drawCmdBuffers[i]);

                vkEndCommandBuffer(drawCmdBuffers[i]);
            }
        }

        // Load a model from file using the ASSIMP model loader and generate all resources required to render the model
        void loadModel(string filename) {
            // Load the model from file using ASSIMP

            // Flags for loading the mesh
            PostProcessSteps assimpFlags = PostProcessSteps.FlipWindingOrder | PostProcessSteps.Triangulate | PostProcessSteps.PreTransformVertices;

            var scene = new AssimpContext().ImportFile(filename, assimpFlags);

            // Generate vertex buffer from ASSIMP scene data
            float scale = 1.0f;
            var vertexBuffer = new List<Vertex>();

            // Iterate through all meshes in the file and extract the vertex components
            for (int m = 0; m < scene.MeshCount; m++) {
                for (int v = 0; v < scene.Meshes[(int)m].VertexCount; v++) {
                    Vertex vertex;
                    Assimp.Mesh mesh = scene.Meshes[m];

                    // Use glm make_* functions to convert ASSIMP vectors to glm vectors
                    vertex.pos = new Vector3(mesh.Vertices[v].X, mesh.Vertices[v].Y, mesh.Vertices[v].Z) * scale;
                    vertex.normal = new Vector3(mesh.Normals[v].X, mesh.Normals[v].Y, mesh.Normals[v].Z);
                    // Texture coordinates and colors may have multiple channels, we only use the first [0] one
                    vertex.uv = new Vector2(mesh.TextureCoordinateChannels[0][v].X, mesh.TextureCoordinateChannels[0][v].Y);
                    // Mesh may not have vertex colors
                    if (mesh.HasVertexColors(0)) {
                        vertex.color = new Vector3(mesh.VertexColorChannels[0][v].R, mesh.VertexColorChannels[0][v].G, mesh.VertexColorChannels[0][v].B);
                    }
                    else {
                        vertex.color = new Vector3(1f);
                    }

                    // Vulkan uses a right-handed NDC (contrary to OpenGL), so simply flip Y-Axis
                    vertex.pos.Y *= -1.0f;

                    vertexBuffer.Add(vertex);
                }
            }
            ulong vertexBufferSize = (ulong)(vertexBuffer.Count * sizeof(Vertex));

            // Generate index buffer from ASSIMP scene data
            var indexBuffer = new List<uint>();
            for (int m = 0; m < scene.MeshCount; m++) {
                uint indexBase = (uint)indexBuffer.Count;
                for (int f = 0; f < scene.Meshes[m].FaceCount; f++) {
                    // We assume that all faces are triangulated
                    for (int i = 0; i < 3; i++) {
                        indexBuffer.Add((uint)scene.Meshes[m].Faces[f].Indices[i] + indexBase);
                    }
                }
            }
            ulong indexBufferSize = (ulong)(indexBuffer.Count * sizeof(uint));
            model_indices_count = (int)indexBuffer.Count;

            // Static mesh should always be Device local

            bool useStaging = true;

            if (useStaging) {

                VkBuffer vertexStaging_buffer;
                VkDeviceMemory vertexStaging_memory;
                VkBuffer indexStaging_buffer;
                VkDeviceMemory indexStaging_memory;

                // Create staging buffers
                // Vertex data
                fixed (Vertex* pointer = vertexBuffer.ToArray()) {
                    vulkanDevice.createBuffer(
                        VkBufferUsageFlagBits.TransferSrc,
                        VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                        vertexBufferSize,
                        &vertexStaging_buffer,
                        &vertexStaging_memory,
                        pointer);
                }
                // Index data
                fixed (uint* pointer = indexBuffer.ToArray()) {
                    vulkanDevice.createBuffer(
                        VkBufferUsageFlagBits.TransferSrc,
                        VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                        indexBufferSize,
                        &indexStaging_buffer,
                        &indexStaging_memory,
                        pointer);
                }

                // Create Device local buffers
                // Vertex buffer
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.VertexBuffer | VkBufferUsageFlagBits.TransferDst,
                    VkMemoryPropertyFlagBits.DeviceLocal,
                    vertexBufferSize,
                    out model_vertices_buffer,
                    out model_vertices_memory);
                // Index buffer
                vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.IndexBuffer | VkBufferUsageFlagBits.TransferDst,
                    VkMemoryPropertyFlagBits.DeviceLocal,
                    indexBufferSize,
                    out model_indices_buffer,
                    out model_indices_memory);

                // Copy from staging buffers
                VkCommandBuffer copyCmd = createCommandBuffer(VkCommandBufferLevel.Primary, true);

                VkBufferCopy copyRegion = new VkBufferCopy();

                copyRegion.size = vertexBufferSize;

                vkCmdCopyBuffer(
                    copyCmd,
                    vertexStaging_buffer,
                    model_vertices_buffer,
                    1,
                    &copyRegion);

                copyRegion.size = indexBufferSize;

                vkCmdCopyBuffer(
                    copyCmd,
                    indexStaging_buffer,
                    model_indices_buffer,
                    1,
                    &copyRegion);

                flushCommandBuffer(copyCmd, queue, true);


                vkDestroyBuffer(device, vertexStaging_buffer, null);

                vkFreeMemory(device, vertexStaging_memory, null);

                vkDestroyBuffer(device, indexStaging_buffer, null);

                vkFreeMemory(device, indexStaging_memory, null);
            }
            else {
                // Vertex buffer
                fixed (Vertex* pointer = vertexBuffer.ToArray()) {
                    vulkanDevice.createBuffer(
                    VkBufferUsageFlagBits.VertexBuffer,
                    VkMemoryPropertyFlagBits.HostVisible,
                    vertexBufferSize,
                    out model_vertices_buffer,
                    out model_vertices_memory,
                    pointer);
                }
                // Index buffer
                fixed (uint* pointer = indexBuffer.ToArray()) {
                    vulkanDevice.createBuffer(
                        VkBufferUsageFlagBits.IndexBuffer,
                        VkMemoryPropertyFlagBits.HostVisible,
                        indexBufferSize,
                        out model_indices_buffer,
                        out model_indices_memory,
                        pointer);
                }
            }
        }

        void loadAssets() {
            loadModel(getAssetPath() + "models/voyager/voyager.dae");
            if (DeviceFeatures.textureCompressionBC == true) {
                textures_colorMap.loadFromFile(getAssetPath() + "models/voyager/voyager_bc3_unorm.ktx", VkFormat.Bc3UnormBlock, vulkanDevice, queue);
            }
            else if (DeviceFeatures.textureCompressionASTC_LDR == true) {
                textures_colorMap.loadFromFile(getAssetPath() + "models/voyager/voyager_astc_8x8_unorm.ktx", VkFormat.Astc8x8UnormBlock, vulkanDevice, queue);
            }
            else if (DeviceFeatures.textureCompressionETC2 == true) {
                textures_colorMap.loadFromFile(getAssetPath() + "models/voyager/voyager_etc2_unorm.ktx", VkFormat.Etc2R8g8b8a8UnormBlock, vulkanDevice, queue);
            }
            else {
                throw new InvalidOperationException("Device does not support any compressed texture format!");
            }
        }

        void setupVertexDescriptions() {
            // Binding description
            vertices_bindingDescriptions = new VkVertexInputBindingDescription[1];
            vertices_bindingDescriptions[0] = new VkVertexInputBindingDescription();
            vertices_bindingDescriptions[0].binding = VERTEX_BUFFER_BIND_ID;
            vertices_bindingDescriptions[0].stride = (uint)sizeof(Vertex);
            vertices_bindingDescriptions[0].inputRate = VkVertexInputRate.Vertex;

            // Attribute descriptions
            // Describes memory layout and shader positions
            vertices_attributeDescriptions = new VkVertexInputAttributeDescription[4];
            // Location 0 : Position
            vertices_attributeDescriptions[0] = new VkVertexInputAttributeDescription();
            vertices_attributeDescriptions[0].binding = VERTEX_BUFFER_BIND_ID;
            vertices_attributeDescriptions[0].location = 0;
            vertices_attributeDescriptions[0].format = VkFormat.R32g32b32Sfloat;
            vertices_attributeDescriptions[0].offset = Vertex.PositionOffset;
            // Location 1 : Normal
            vertices_attributeDescriptions[1] = new VkVertexInputAttributeDescription();
            vertices_attributeDescriptions[1].binding = VERTEX_BUFFER_BIND_ID;
            vertices_attributeDescriptions[1].location = 1;
            vertices_attributeDescriptions[1].format = VkFormat.R32g32b32Sfloat;
            vertices_attributeDescriptions[1].offset = Vertex.NormalOffset;
            // Location 2 : Texture coordinates
            vertices_attributeDescriptions[2] = new VkVertexInputAttributeDescription();
            vertices_attributeDescriptions[2].binding = VERTEX_BUFFER_BIND_ID;
            vertices_attributeDescriptions[2].location = 2;
            vertices_attributeDescriptions[2].format = VkFormat.R32g32Sfloat;
            vertices_attributeDescriptions[2].offset = Vertex.UvOffset;
            // Location 3 : Color
            vertices_attributeDescriptions[3] = new VkVertexInputAttributeDescription();
            vertices_attributeDescriptions[3].binding = VERTEX_BUFFER_BIND_ID;
            vertices_attributeDescriptions[3].location = 3;
            vertices_attributeDescriptions[3].format = VkFormat.R32g32b32Sfloat;
            vertices_attributeDescriptions[3].offset = Vertex.ColorOffset;

            vertices_inputState = new VkPipelineVertexInputStateCreateInfo();
            vertices_inputState.sType = PipelineVertexInputStateCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                vertices_bindingDescriptions.Set(ref ptr, ref vertices_inputState.vertexBindingDescriptionCount);
                vertices_inputState.pVertexBindingDescriptions = (VkVertexInputBindingDescription*)ptr;
            }
            {
                IntPtr ptr = IntPtr.Zero;
                vertices_attributeDescriptions.Set(ref ptr, ref vertices_inputState.vertexAttributeDescriptionCount);
                vertices_inputState.pVertexAttributeDescriptions = (VkVertexInputAttributeDescription*)ptr;
            }
        }

        void setupDescriptorPool() {
            // Example uses one ubo and one combined image sampler
            var poolSizes = new VkDescriptorPoolSize[2];
            poolSizes[0] = new VkDescriptorPoolSize();
            poolSizes[0].type = VkDescriptorType.UniformBuffer;
            poolSizes[0].descriptorCount = 1;
            poolSizes[1] = new VkDescriptorPoolSize();
            poolSizes[1].type = VkDescriptorType.CombinedImageSampler;
            poolSizes[1].descriptorCount = 1;

            VkDescriptorPoolCreateInfo descriptorPoolInfo = new VkDescriptorPoolCreateInfo();
            descriptorPoolInfo.sType = DescriptorPoolCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                poolSizes.Set(ref ptr, ref descriptorPoolInfo.poolSizeCount);
                descriptorPoolInfo.pPoolSizes = (VkDescriptorPoolSize*)ptr;
            }
            descriptorPoolInfo.maxSets = 1;

            {
                VkDescriptorPool pool;
                vkCreateDescriptorPool(device, &descriptorPoolInfo, null, &pool);
                this.descriptorPool = pool;
            }
        }

        void setupDescriptorSetLayout() {
            var setLayoutBindings = new VkDescriptorSetLayoutBinding[2];
            // Binding 0 : Vertex shader uniform buffer
            setLayoutBindings[0] = new VkDescriptorSetLayoutBinding();
            setLayoutBindings[0].descriptorType = VkDescriptorType.UniformBuffer;
            setLayoutBindings[0].stageFlags = VkShaderStageFlagBits.Vertex;
            setLayoutBindings[0].binding = 0;
            setLayoutBindings[0].descriptorCount = 1;
            // Binding 1 : Fragment shader combined sampler
            setLayoutBindings[1] = new VkDescriptorSetLayoutBinding();
            setLayoutBindings[1].descriptorType = VkDescriptorType.CombinedImageSampler;
            setLayoutBindings[1].stageFlags = VkShaderStageFlagBits.Fragment;
            setLayoutBindings[1].binding = 1;
            setLayoutBindings[1].descriptorCount = 1;

            VkDescriptorSetLayoutCreateInfo descriptorLayout = new VkDescriptorSetLayoutCreateInfo();
            descriptorLayout.sType = DescriptorSetLayoutCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                setLayoutBindings.Set(ref ptr, ref descriptorLayout.bindingCount);
                descriptorLayout.pBindings = (VkDescriptorSetLayoutBinding*)ptr;
            }

            VkDescriptorSetLayout dsl;
            vkCreateDescriptorSetLayout(device, &descriptorLayout, null, &dsl);
            this.descriptorSetLayout = dsl;

            VkPipelineLayoutCreateInfo pPipelineLayoutCreateInfo = new VkPipelineLayoutCreateInfo();
            pPipelineLayoutCreateInfo.sType = PipelineLayoutCreateInfo;
            pPipelineLayoutCreateInfo.pSetLayouts = &dsl;
            pPipelineLayoutCreateInfo.setLayoutCount = 1;

            {
                VkPipelineLayout layout;
                vkCreatePipelineLayout(device, &pPipelineLayoutCreateInfo, null, &layout);
                this.pipelineLayout = layout;
            }
        }

        void setupDescriptorSet() {
            VkDescriptorSetLayout dsl = descriptorSetLayout;
            VkDescriptorSetAllocateInfo allocInfo = new VkDescriptorSetAllocateInfo();
            allocInfo.sType = DescriptorSetAllocateInfo;
            allocInfo.descriptorPool = descriptorPool;
            allocInfo.pSetLayouts = &dsl;
            allocInfo.descriptorSetCount = 1;

            {
                VkDescriptorSet set;
                vkAllocateDescriptorSets(device, &allocInfo, &set);
                this.descriptorSet = set;
            }

            VkDescriptorImageInfo texDescriptor = new VkDescriptorImageInfo();
            texDescriptor.sampler = textures_colorMap.sampler;
            texDescriptor.imageView = textures_colorMap.view;
            texDescriptor.imageLayout = VkImageLayout.General;

            VkDescriptorBufferInfo temp = uniformBuffers_scene.descriptor;
            var writeDescriptorSets = new VkWriteDescriptorSet[2];
            // Binding 0 : Vertex shader uniform buffer
            writeDescriptorSets[0] = new VkWriteDescriptorSet();
            writeDescriptorSets[0].sType = WriteDescriptorSet;
            writeDescriptorSets[0].dstSet = descriptorSet;
            writeDescriptorSets[0].descriptorType = VkDescriptorType.UniformBuffer;
            writeDescriptorSets[0].dstBinding = 0;
            writeDescriptorSets[0].pBufferInfo = &temp;
            writeDescriptorSets[0].descriptorCount = 1;
            // Binding 1 : Color map 
            writeDescriptorSets[1] = new VkWriteDescriptorSet();
            writeDescriptorSets[1].sType = WriteDescriptorSet;
            writeDescriptorSets[1].dstSet = descriptorSet;
            writeDescriptorSets[1].descriptorType = VkDescriptorType.CombinedImageSampler;
            writeDescriptorSets[1].dstBinding = 1;
            writeDescriptorSets[1].pImageInfo = &texDescriptor;
            writeDescriptorSets[1].descriptorCount = 1;

            fixed (VkWriteDescriptorSet* pointer = writeDescriptorSets) {
                vkUpdateDescriptorSets(device, (UInt32)writeDescriptorSets.Length, pointer, 0, null);
            }
        }

        void preparePipelines() {
            var inputAssemblyState = new VkPipelineInputAssemblyStateCreateInfo();
            inputAssemblyState.sType = PipelineInputAssemblyStateCreateInfo;
            inputAssemblyState.topology = VkPrimitiveTopology.TriangleList;
            inputAssemblyState.flags = 0;
            inputAssemblyState.primitiveRestartEnable = false;

            var rasterizationState = new VkPipelineRasterizationStateCreateInfo();
            rasterizationState.sType = PipelineRasterizationStateCreateInfo;
            rasterizationState.polygonMode = VkPolygonMode.Fill;
            rasterizationState.cullMode = VkCullModeFlagBits.Back;
            rasterizationState.frontFace = VkFrontFace.Clockwise;
            rasterizationState.flags = 0;

            var blendAttachmentState = new VkPipelineColorBlendAttachmentState();
            blendAttachmentState.colorWriteMask = (VkColorComponentFlagBits)0xf;
            blendAttachmentState.blendEnable = false;

            var colorBlendState = new VkPipelineColorBlendStateCreateInfo();
            colorBlendState.sType = PipelineColorBlendStateCreateInfo;
            colorBlendState.attachmentCount = 1;
            colorBlendState.pAttachments = &blendAttachmentState;

            var depthStencilState = new VkPipelineDepthStencilStateCreateInfo();
            depthStencilState.sType = PipelineDepthStencilStateCreateInfo;
            depthStencilState.depthTestEnable = true;
            depthStencilState.depthWriteEnable = true;
            depthStencilState.depthCompareOp = VkCompareOp.LessOrEqual;

            var viewportState = new VkPipelineViewportStateCreateInfo();
            viewportState.sType = PipelineViewportStateCreateInfo;
            viewportState.viewportCount = 1;
            viewportState.scissorCount = 1;
            viewportState.flags = 0;

            var multisampleState = new VkPipelineMultisampleStateCreateInfo();
            multisampleState.sType = PipelineMultisampleStateCreateInfo;
            multisampleState.rasterizationSamples = VkSampleCountFlagBits._1;
            multisampleState.flags = 0;

            var dynamicStateEnables = new VkDynamicState[2];
            dynamicStateEnables[0] = VkDynamicState.Viewport;
            dynamicStateEnables[1] = VkDynamicState.Scissor;
            VkPipelineDynamicStateCreateInfo dynamicState = new VkPipelineDynamicStateCreateInfo();
            dynamicState.sType = PipelineDynamicStateCreateInfo;
            {
                IntPtr ptr = IntPtr.Zero;
                dynamicStateEnables.Set(ref ptr, ref dynamicState.dynamicStateCount);
                dynamicState.pDynamicStates = (VkDynamicState*)ptr;
            }
            dynamicState.flags = 0;

            // Solid rendering pipeline
            // Load shaders
            var shaderStages = new VkPipelineShaderStageCreateInfo[2];
            shaderStages[0] = loadShader(getAssetPath() + "shaders/mesh/mesh.vert.spv", VkShaderStageFlagBits.Vertex);
            shaderStages[1] = loadShader(getAssetPath() + "shaders/mesh/mesh.frag.spv", VkShaderStageFlagBits.Fragment);

            VkGraphicsPipelineCreateInfo pipelineCreateInfo = new VkGraphicsPipelineCreateInfo();
            pipelineCreateInfo.sType = GraphicsPipelineCreateInfo;
            pipelineCreateInfo.layout = pipelineLayout;
            pipelineCreateInfo.renderPass = renderPass;
            pipelineCreateInfo.flags = 0;

            var via = vertices_inputState;
            pipelineCreateInfo.pVertexInputState = &via;
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

            {
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, &pipelineCreateInfo, null, &pipeline);
                this.pipelines_solid = pipeline;
            }

            // Wire frame rendering pipeline
            if (DeviceFeatures.fillModeNonSolid == true) {
                rasterizationState.polygonMode = VkPolygonMode.Line;
                rasterizationState.lineWidth = 1.0f;
                VkPipeline pipeline;
                vkCreateGraphicsPipelines(device, pipelineCache, 1, &pipelineCreateInfo, null, &pipeline);
                this.pipelines_wireframe = pipeline;
            }
        }

        // Prepare and initialize uniform buffer containing shader uniforms
        void prepareUniformBuffers() {
            // Vertex shader uniform buffer block
            vulkanDevice.createBuffer(
                VkBufferUsageFlagBits.UniformBuffer,
                VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent,
                uniformBuffers_scene,
                (uint)sizeof(UboVS));

            // Map persistent
            uniformBuffers_scene.map();

            updateUniformBuffers();
        }

        void updateUniformBuffers() {
            uboVS.projection = System.Numerics.Matrix4x4.CreatePerspectiveFieldOfView(Util.DegreesToRadians(60.0f), (float)width / (float)height, 0.1f, 256.0f);
            System.Numerics.Matrix4x4 viewMatrix = System.Numerics.Matrix4x4.CreateTranslation(0.0f, 0.0f, zoom);

            uboVS.model = viewMatrix * System.Numerics.Matrix4x4.CreateTranslation(cameraPos);
            uboVS.model = System.Numerics.Matrix4x4.CreateRotationX(Util.DegreesToRadians(rotation.X)) * uboVS.model;
            uboVS.model = System.Numerics.Matrix4x4.CreateRotationY(Util.DegreesToRadians(rotation.Y)) * uboVS.model;
            uboVS.model = System.Numerics.Matrix4x4.CreateRotationZ(Util.DegreesToRadians(rotation.Z)) * uboVS.model;

            Unsafe.Copy(uniformBuffers_scene.mapped, ref uboVS);
        }

        public override void Init(Control canvas) {
            base.Init(canvas);

            loadAssets();
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

            if (!prepared) { return; }

            prepareFrame();

            // Command buffer to be sumitted to the Queue
            //submitInfo.commandBufferCount = 1;
            //submitInfo.pCommandBuffers = (VkCommandBuffer*)drawCmdBuffers.GetAddress(currentBuffer);
            VkCommandBuffer buffer = drawCmdBuffers[currentBuffer];
            IntPtr ptr = (IntPtr)submitInfo.pCommandBuffers;
            new[] { buffer }.Set(ref ptr, ref submitInfo.commandBufferCount);
            submitInfo.pCommandBuffers = (VkCommandBuffer*)ptr;

            VkSubmitInfo info = submitInfo;
            // Submit to Queue
            vkQueueSubmit(queue, 1, &info, new VkFence());

            submitFrame();
        }

        protected override void viewChanged() {
            updateUniformBuffers();
        }

        //protected override void keyPressed(Key keyCode) {
        //    switch (keyCode) {
        //        case Key.W:
        //            if (DeviceFeatures.fillModeNonSolid == 1) {
        //                wireframe = !wireframe;
        //                reBuildCommandBuffers();
        //            }
        //            break;
        //    }
        //}



    }
}

