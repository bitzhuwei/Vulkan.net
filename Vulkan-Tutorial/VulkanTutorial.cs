using StbImageSharp;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;

namespace Vulkan_Tutorial {
    unsafe partial class VulkanTutorial : IDisposable {

        const string logFile = "debugInfo.log";
        const string MODEL_PATH = "models/chalet.obj";
        const string TEXTURE_PATH = "textures/chalet.jpg";

        private static string[] validationLayers = new string[] { "VK_LAYER_KHRONOS_validation" };
        private static string[] deviceExtensions = new string[] { vkAPI.VK_KHR_swapchain };

        const int MAX_FRAMES_IN_FLIGHT = 2;

#if NDEBUG
        bool enableValidationLayers = false;
#else
        bool enableValidationLayers = true;
#endif


        struct QueueFamilyIndices {
            public UInt32? graphicsFamily;
            public UInt32? presentFamily;

            public bool isComplete() {
                return graphicsFamily.HasValue && presentFamily.HasValue;
            }
        }

        struct SwapChainSupportDetails {
            public VkSurfaceCapabilitiesKHR capabilities;
            public VkSurfaceFormatKHR[] formats;
            public VkPresentModeKHR[] presentModes;
        }

        struct Vertex {
            public Vector3 pos;
            public Vector3 color;
            public Vector2 texCoord;

            public static VkVertexInputBindingDescription getBindingDescription() {
                VkVertexInputBindingDescription bindingDescription;
                bindingDescription.binding = 0;
                bindingDescription.stride = (UInt32)Marshal.SizeOf(typeof(Vertex));
                bindingDescription.inputRate = VkVertexInputRate.Vertex;

                return bindingDescription;
            }


            public static VkVertexInputAttributeDescription[] getAttributeDescriptions() {
                var attributeDescriptions = new VkVertexInputAttributeDescription[3];

                attributeDescriptions[0].binding = 0;
                attributeDescriptions[0].location = 0;
                attributeDescriptions[0].format = VkFormat.R32g32b32Sfloat;
                attributeDescriptions[0].offset = 0;

                attributeDescriptions[1].binding = 0;
                attributeDescriptions[1].location = 1;
                attributeDescriptions[1].format = VkFormat.R32g32b32Sfloat;
                attributeDescriptions[1].offset = (UInt32)Marshal.SizeOf(typeof(Vector3));

                attributeDescriptions[2].binding = 0;
                attributeDescriptions[2].location = 2;
                attributeDescriptions[2].format = VkFormat.R32g32Sfloat;
                attributeDescriptions[2].offset = (UInt32)Marshal.SizeOf(typeof(Vector3)) + (UInt32)Marshal.SizeOf(typeof(Vector3)); ;

                return attributeDescriptions;
            }
            //        bool operator ==(const Vertex& other) const {
            //    return pos == other.pos && color == other.color && texCoord == other.texCoord;
            //}
        }

        struct UniformBufferObject {
            public Matrix4x4 model;
            public Matrix4x4 view;
            public Matrix4x4 proj;
        }

        VkInstance instance;
        VkDebugUtilsMessengerEXT debugMessenger;
        VkSurfaceKHR surface;

        VkPhysicalDevice physicalDevice;
        VkDevice device;

        VkQueue graphicsQueue;
        VkQueue presentQueue;

        VkSwapchainKHR swapChain;
        VkImage[] swapChainImages;
        VkFormat swapChainImageFormat;
        VkExtent2D swapChainExtent;
        VkImageView[] swapChainImageViews;
        VkFramebuffer[] swapChainFramebuffers;

        VkRenderPass renderPass;
        VkDescriptorSetLayout descriptorSetLayout;
        VkPipelineLayout pipelineLayout;
        VkPipeline graphicsPipeline;

        VkCommandPool commandPool;

        VkImage depthImage;
        VkDeviceMemory depthImageMemory;
        VkImageView depthImageView;

        UInt32 mipLevels;
        VkImage textureImage;
        VkDeviceMemory textureImageMemory;
        VkImageView textureImageView;
        VkSampler textureSampler;

        Assimp.Vector3D[] vertices;
        List<UInt32> indices;
        VkBuffer vertexBuffer;
        VkDeviceMemory vertexBufferMemory;
        VkBuffer indexBuffer;
        VkDeviceMemory indexBufferMemory;

        VkBuffer[] uniformBuffers;
        VkDeviceMemory[] uniformBuffersMemory;

        VkDescriptorPool descriptorPool;
        VkDescriptorSet[] descriptorSets;

        VkCommandBuffer[] commandBuffers;

        VkSemaphore[] imageAvailableSemaphores;
        VkSemaphore[] renderFinishedSemaphores;
        VkFence[] inFlightFences;
        int currentFrame = 0;

        bool framebufferResized = false;

        public void Init(IntPtr hwnd, IntPtr proecessHandle) {
            this.initVulkan(hwnd, proecessHandle);
        }

        void initVulkan(IntPtr hwnd, IntPtr proecessHandle) {
            createInstance();
            setupDebugMessenger();
            createSurface(hwnd, proecessHandle);
            pickPhysicalDevice();
            createLogicalDevice();
            createSwapChain();
            createImageViews();
            createRenderPass();
            createDescriptorSetLayout();
            createGraphicsPipeline();
            createCommandPool();
            createDepthResources();
            createFramebuffers();
            createTextureImage();
            createTextureImageView();
            createTextureSampler();
            loadModel();
            createVertexBuffer();
            createIndexBuffer();
            createUniformBuffers();
            createDescriptorPool();
            createDescriptorSets();
            createCommandBuffers();
            createSyncObjects();
        }

        public void Render() {
            drawFrame();
        }

        public void Dispose() {
            vkDeviceWaitIdle(device);
            // ...

        }


        void cleanupSwapChain() {
            vkDestroyImageView(device, depthImageView, null);
            vkDestroyImage(device, depthImage, null);
            vkFreeMemory(device, depthImageMemory, null);

            foreach (var framebuffer in swapChainFramebuffers) {
                vkDestroyFramebuffer(device, framebuffer, null);
            }

            fixed (VkCommandBuffer* pointer = commandBuffers) {
                vkFreeCommandBuffers(device, commandPool, (UInt32)commandBuffers.Length, pointer);
            }

            vkDestroyPipeline(device, graphicsPipeline, null);
            vkDestroyPipelineLayout(device, pipelineLayout, null);
            vkDestroyRenderPass(device, renderPass, null);

            foreach (var imageView in swapChainImageViews) {
                vkDestroyImageView(device, imageView, null);
            }

            vkDestroySwapchainKHR(device, swapChain, null);

            for (int i = 0; i < swapChainImages.Length; i++) {
                vkDestroyBuffer(device, uniformBuffers[i], null);
                vkFreeMemory(device, uniformBuffersMemory[i], null);
            }

            vkDestroyDescriptorPool(device, descriptorPool, null);
        }

        void cleanup() {
            cleanupSwapChain();

            vkDestroySampler(device, textureSampler, null);
            vkDestroyImageView(device, textureImageView, null);

            vkDestroyImage(device, textureImage, null);
            vkFreeMemory(device, textureImageMemory, null);

            vkDestroyDescriptorSetLayout(device, descriptorSetLayout, null);

            vkDestroyBuffer(device, indexBuffer, null);
            vkFreeMemory(device, indexBufferMemory, null);

            vkDestroyBuffer(device, vertexBuffer, null);
            vkFreeMemory(device, vertexBufferMemory, null);

            for (int i = 0; i < MAX_FRAMES_IN_FLIGHT; i++) {
                vkDestroySemaphore(device, renderFinishedSemaphores[i], null);
                vkDestroySemaphore(device, imageAvailableSemaphores[i], null);
                vkDestroyFence(device, inFlightFences[i], null);
            }

            vkDestroyCommandPool(device, commandPool, null);

            vkDestroyDevice(device, null);

            if (enableValidationLayers) {
                vkAPI.DestroyDebugUtilsMessengerEXT(instance, debugMessenger, null);
            }

            vkDestroySurfaceKHR(instance, surface, null);
            vkDestroyInstance(instance, null);

            //glfwDestroyWindow(window);

            //glfwTerminate();
        }

        void recreateSwapChain() {
            //int width = 0, height = 0;
            //while (width == 0 || height == 0) {
            //    glfwGetFramebufferSize(window, &width, &height);
            //    glfwWaitEvents();
            //}

            vkDeviceWaitIdle(device);

            cleanupSwapChain();

            createSwapChain();
            createImageViews();
            createRenderPass();
            createGraphicsPipeline();
            createDepthResources();
            createFramebuffers();
            createUniformBuffers();
            createDescriptorPool();
            createDescriptorSets();
            createCommandBuffers();
        }

        void createInstance() {
            if (enableValidationLayers && !checkValidationLayerSupport()) {
                throw new Exception("validation layers requested, but not available!");
            }

            VkApplicationInfo appInfo;
            appInfo.sType = VkStructureType.ApplicationInfo;
            appInfo.pApplicationName = "Hello Triangle";
            appInfo.applicationVersion = VkVersion.Make(1, 0, 0);
            appInfo.pEngineName = "No Engine";
            appInfo.engineVersion = VkVersion.Make(1, 0, 0);
            appInfo.apiVersion = VkVersion.Make(1, 0, 0);

            VkInstanceCreateInfo createInfo;
            createInfo.sType = VkStructureType.InstanceCreateInfo;
            createInfo.pApplicationInfo = &appInfo;

            var extensions = getRequiredExtensions();
            createInfo.EnabledExtensions = extensions;

            var debugCreateInfo = new VkDebugUtilsMessengerCreateInfoEXT();
            if (enableValidationLayers) {
                createInfo.EnabledLayers = validationLayers;

                populateDebugMessengerCreateInfo(ref debugCreateInfo);
                createInfo.pNext = &debugCreateInfo;
            }
            //else {
            //    createInfo.enabledLayerCount = 0;

            //    createInfo.pNext = null;
            //}

            VkInstance instance;
            vkCreateInstance(&createInfo, null, &instance).Check();
            this.instance = instance;
        }

        void populateDebugMessengerCreateInfo(ref VkDebugUtilsMessengerCreateInfoEXT createInfo) {
            createInfo.sType = VkStructureType.DebugUtilsMessengerCreateInfoEXT;
            createInfo.messageSeverity = VkDebugUtilsMessageSeverityFlagBitsEXT.VerboseEXT
                | VkDebugUtilsMessageSeverityFlagBitsEXT.WarningEXT
                | VkDebugUtilsMessageSeverityFlagBitsEXT.ErrorEXT;
            createInfo.messageType = VkDebugUtilsMessageTypeFlagBitsEXT.GeneralEXT
                | VkDebugUtilsMessageTypeFlagBitsEXT.ValidationEXT
                | VkDebugUtilsMessageTypeFlagBitsEXT.PerformanceEXT;
            createInfo.pfnUserCallback = Marshal.GetFunctionPointerForDelegate(
            new PFN_vkDebugUtilsMessengerCallbackEXT(debugCallback));

        }

        void setupDebugMessenger() {
            if (!enableValidationLayers) return;

            var createInfo = new VkDebugUtilsMessengerCreateInfoEXT();
            populateDebugMessengerCreateInfo(ref createInfo);

            VkDebugUtilsMessengerEXT messenger;
            vkAPI.CreateDebugUtilsMessengerEXT(instance, &createInfo, null, &messenger).Check();
            this.debugMessenger = messenger;
        }

        void createSurface(IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKHR { sType = VkStructureType.Win32SurfaceCreateInfoKHR };
            info.hwnd = hwnd;
            info.hinstance = processHandle; //Process.GetCurrentProcess().Handle

            VkSurfaceKHR surface;
            vkAPI.vkCreateWin32SurfaceKHR(instance, &info, null, &surface).Check();
            this.surface = surface;
        }

        void pickPhysicalDevice() {
            var physicalDevices = vkAPI.PhysicalDevices(this.instance);

            foreach (var device in physicalDevices) {
                if (isDeviceSuitable(device)) {
                    physicalDevice = device;
                    break;
                }
            }

            if (physicalDevice == 0ul) {
                throw new Exception("failed to find a suitable GPU!");
            }
        }

        void createLogicalDevice() {
            QueueFamilyIndices indices = findQueueFamilies(physicalDevice);

            var queueCreateInfos = new List<VkDeviceQueueCreateInfo>();
            UInt32[] uniqueQueueFamilies = null;
            if (indices.graphicsFamily.Value != indices.presentFamily.Value) {
                uniqueQueueFamilies = new UInt32[] { indices.graphicsFamily.Value, indices.presentFamily.Value };
            }
            else {
                uniqueQueueFamilies = new UInt32[] { indices.graphicsFamily.Value };
            }

            float queuePriority = 1.0f;
            foreach (var queueFamily in uniqueQueueFamilies) {
                var queueCreateInfo = new VkDeviceQueueCreateInfo();
                queueCreateInfo.sType = VkStructureType.DeviceQueueCreateInfo;
                queueCreateInfo.queueFamilyIndex = queueFamily;
                queueCreateInfo.queuePriorities = queuePriority;
                queueCreateInfos.Add(queueCreateInfo);
            }

            VkPhysicalDeviceFeatures deviceFeatures;
            deviceFeatures.samplerAnisotropy = true;

            VkDeviceCreateInfo createInfo;
            createInfo.sType = VkStructureType.DeviceCreateInfo;
            createInfo.queueCreateInfos = queueCreateInfos.ToArray();
            createInfo.pEnabledFeatures = &deviceFeatures;
            createInfo.EnabledExtensions = deviceExtensions;

            if (enableValidationLayers) {
                createInfo.EnabledLayers = validationLayers;
            }
            //else {
            //    createInfo.enabledLayerCount = 0;
            //}

            VkDevice device;
            vkCreateDevice(physicalDevice, &createInfo, null, &device).Check();
            this.device = device;

            VkQueue graphicsQueue;
            vkGetDeviceQueue(device, indices.graphicsFamily.Value, 0, &graphicsQueue);
            this.graphicsQueue = graphicsQueue;
            VkQueue presentQueue;
            vkGetDeviceQueue(device, indices.presentFamily.Value, 0, &presentQueue);
            this.presentQueue = presentQueue;
        }

        void createSwapChain() {
            SwapChainSupportDetails swapChainSupport = querySwapChainSupport(physicalDevice);

            VkSurfaceFormatKHR surfaceFormat = chooseSwapSurfaceFormat(swapChainSupport.formats);
            VkPresentModeKHR presentMode = chooseSwapPresentMode(swapChainSupport.presentModes);
            VkExtent2D extent = chooseSwapExtent(swapChainSupport.capabilities);

            UInt32 imageCount = swapChainSupport.capabilities.minImageCount + 1;
            if (swapChainSupport.capabilities.maxImageCount > 0 && imageCount > swapChainSupport.capabilities.maxImageCount) {
                imageCount = swapChainSupport.capabilities.maxImageCount;
            }

            VkSwapchainCreateInfoKHR createInfo;
            createInfo.sType = VkStructureType.SwapchainCreateInfoKHR;
            createInfo.surface = surface;
            createInfo.minImageCount = imageCount;
            createInfo.imageFormat = surfaceFormat.format;
            createInfo.imageColorSpace = surfaceFormat.colorSpace;
            createInfo.imageExtent = extent;
            createInfo.imageArrayLayers = 1;
            createInfo.imageUsage = VkImageUsageFlagBits.ColorAttachment;

            QueueFamilyIndices indices = findQueueFamilies(physicalDevice);
            var queueFamilyIndices = new[] { indices.graphicsFamily.Value, indices.presentFamily.Value };

            if (indices.graphicsFamily != indices.presentFamily) {
                createInfo.imageSharingMode = VkSharingMode.Concurrent;
                createInfo.queueFamilyIndices = queueFamilyIndices;
            }
            else {
                createInfo.imageSharingMode = VkSharingMode.Exclusive;
                createInfo.queueFamilyIndices = indices.graphicsFamily.Value;
            }

            createInfo.preTransform = swapChainSupport.capabilities.currentTransform;
            createInfo.compositeAlpha = VkCompositeAlphaFlagBitsKHR.OpaqueKHR;
            createInfo.presentMode = presentMode;
            createInfo.clipped = true;

            VkSwapchainKHR swapchain;
            vkCreateSwapchainKHR(device, &createInfo, null, &swapchain).Check();
            this.swapChain = swapchain;

            vkGetSwapchainImagesKHR(device, swapChain, &imageCount, null);
            swapChainImages = new VkImage[imageCount];
            fixed (VkImage* pointer = swapChainImages)
                vkGetSwapchainImagesKHR(device, swapChain, &imageCount, pointer);

            swapChainImageFormat = surfaceFormat.format;
            swapChainExtent = extent;
        }

        void createImageViews() {
            swapChainImageViews = new VkImageView[swapChainImages.Length];

            for (int i = 0; i < swapChainImages.Length; i++) {
                swapChainImageViews[i] = createImageView(swapChainImages[i], swapChainImageFormat, VkImageAspectFlagBits.Color, 1u);
            }
        }

        void createRenderPass() {
            var colorAttachment = new VkAttachmentDescription();
            colorAttachment.format = swapChainImageFormat;
            colorAttachment.samples = VkSampleCountFlagBits._1;
            colorAttachment.loadOp = VkAttachmentLoadOp.Clear;
            colorAttachment.storeOp = VkAttachmentStoreOp.Store;
            colorAttachment.stencilLoadOp = VkAttachmentLoadOp.DontCare;
            colorAttachment.stencilStoreOp = VkAttachmentStoreOp.DontCare;
            colorAttachment.initialLayout = VkImageLayout.Undefined;
            colorAttachment.finalLayout = VkImageLayout.PresentSrcKHR;

            var depthAttachment = new VkAttachmentDescription();
            depthAttachment.format = findDepthFormat();
            depthAttachment.samples = VkSampleCountFlagBits._1;
            depthAttachment.loadOp = VkAttachmentLoadOp.Clear;
            depthAttachment.storeOp = VkAttachmentStoreOp.DontCare;
            depthAttachment.stencilLoadOp = VkAttachmentLoadOp.DontCare;
            depthAttachment.stencilStoreOp = VkAttachmentStoreOp.DontCare;
            depthAttachment.initialLayout = VkImageLayout.Undefined;
            depthAttachment.finalLayout = VkImageLayout.DepthStencilAttachmentOptimal;

            VkAttachmentReference colorAttachmentRef;
            colorAttachmentRef.attachment = 0;
            colorAttachmentRef.layout = VkImageLayout.ColorAttachmentOptimal;

            VkAttachmentReference depthAttachmentRef;
            depthAttachmentRef.attachment = 1;
            depthAttachmentRef.layout = VkImageLayout.DepthStencilAttachmentOptimal;

            var subpass = new VkSubpassDescription();
            subpass.pipelineBindPoint = VkPipelineBindPoint.Graphics;
            subpass.colorAttachments = colorAttachmentRef;
            subpass.pDepthStencilAttachment = &depthAttachmentRef;

            var dependency = new VkSubpassDependency();
            dependency.srcSubpass = vkAPI.VK_SUBPASS_EXTERNAL;
            dependency.dstSubpass = 0;
            dependency.srcStageMask = VkPipelineStageFlagBits.ColorAttachmentOutput;
            dependency.srcAccessMask = 0;
            dependency.dstStageMask = VkPipelineStageFlagBits.ColorAttachmentOutput;
            dependency.dstAccessMask = VkAccessFlagBits.ColorAttachmentRead | VkAccessFlagBits.ColorAttachmentWrite;

            var attachments = new[] { colorAttachment, depthAttachment };
            VkRenderPassCreateInfo renderPassInfo;
            renderPassInfo.sType = VkStructureType.RenderPassCreateInfo;
            renderPassInfo.attachments = attachments;
            renderPassInfo.subpasses = subpass;
            renderPassInfo.dependencies = dependency;

            VkRenderPass renderPass;
            vkCreateRenderPass(device, &renderPassInfo, null, &renderPass).Check();
            this.renderPass = renderPass;
        }

        void createDescriptorSetLayout() {
            var uboLayoutBinding = new VkDescriptorSetLayoutBinding();
            uboLayoutBinding.binding = 0;
            uboLayoutBinding.descriptorCount = 1;
            uboLayoutBinding.descriptorType = VkDescriptorType.UniformBuffer;
            uboLayoutBinding.stageFlags = VkShaderStageFlagBits.Vertex;

            var samplerLayoutBinding = new VkDescriptorSetLayoutBinding();
            samplerLayoutBinding.binding = 1;
            samplerLayoutBinding.descriptorCount = 1;
            samplerLayoutBinding.descriptorType = VkDescriptorType.CombinedImageSampler;
            samplerLayoutBinding.stageFlags = VkShaderStageFlagBits.Fragment;

            var bindings = new[] { uboLayoutBinding, samplerLayoutBinding };
            var layoutInfo = new VkDescriptorSetLayoutCreateInfo();
            layoutInfo.sType = VkStructureType.DescriptorSetLayoutCreateInfo;
            layoutInfo.bindings = bindings;

            VkDescriptorSetLayout descriptorSetLayout;
            vkCreateDescriptorSetLayout(device, &layoutInfo, null, &descriptorSetLayout).Check();
            this.descriptorSetLayout = descriptorSetLayout;
        }

        void createGraphicsPipeline() {
            var vertShaderCode = File.ReadAllBytes("shaders/shader.vert.spv");
            var fragShaderCode = File.ReadAllBytes("shaders/shader.frag.spv");

            VkShaderModule vertShaderModule = createShaderModule(vertShaderCode);
            VkShaderModule fragShaderModule = createShaderModule(fragShaderCode);

            var vertShaderStageInfo = new VkPipelineShaderStageCreateInfo();
            vertShaderStageInfo.sType = VkStructureType.PipelineShaderStageCreateInfo;
            vertShaderStageInfo.stage = VkShaderStageFlagBits.Vertex;
            vertShaderStageInfo.module = vertShaderModule;
            vertShaderStageInfo.pName = "main";

            var fragShaderStageInfo = new VkPipelineShaderStageCreateInfo();
            fragShaderStageInfo.sType = VkStructureType.PipelineShaderStageCreateInfo;
            fragShaderStageInfo.stage = VkShaderStageFlagBits.Fragment;
            fragShaderStageInfo.module = fragShaderModule;
            fragShaderStageInfo.pName = "main";

            var shaderStages = new[] { vertShaderStageInfo, fragShaderStageInfo };

            var vertexInputInfo = new VkPipelineVertexInputStateCreateInfo();
            vertexInputInfo.sType = VkStructureType.PipelineVertexInputStateCreateInfo;

            var bindingDescription = Vertex.getBindingDescription();
            var attributeDescriptions = Vertex.getAttributeDescriptions();

            vertexInputInfo.vertexBindingDescriptions = bindingDescription;
            vertexInputInfo.vertexAttributeDescriptions = attributeDescriptions;

            var inputAssembly = new VkPipelineInputAssemblyStateCreateInfo();
            inputAssembly.sType = VkStructureType.PipelineInputAssemblyStateCreateInfo;
            inputAssembly.topology = VkPrimitiveTopology.TriangleList;
            inputAssembly.primitiveRestartEnable = false;

            var viewport = new VkViewport();
            viewport.x = 0.0f;
            viewport.y = 0.0f;
            viewport.width = (float)swapChainExtent.width;
            viewport.height = (float)swapChainExtent.height;
            viewport.minDepth = 0.0f;
            viewport.maxDepth = 1.0f;

            VkRect2D scissor = new VkRect2D();
            scissor.extent = swapChainExtent;

            var viewportState = new VkPipelineViewportStateCreateInfo();
            viewportState.sType = VkStructureType.PipelineViewportStateCreateInfo;
            viewportState.viewports = viewport;
            viewportState.scissors = scissor;

            var rasterizer = new VkPipelineRasterizationStateCreateInfo();
            rasterizer.sType = VkStructureType.PipelineRasterizationStateCreateInfo;
            rasterizer.depthClampEnable = false;
            rasterizer.rasterizerDiscardEnable = false;
            rasterizer.polygonMode = VkPolygonMode.Fill;
            rasterizer.lineWidth = 1.0f;
            rasterizer.cullMode = VkCullModeFlagBits.Back;
            rasterizer.frontFace = VkFrontFace.CounterClockwise;
            rasterizer.depthBiasEnable = false;

            var multisampling = new VkPipelineMultisampleStateCreateInfo();
            multisampling.sType = VkStructureType.PipelineMultisampleStateCreateInfo;
            multisampling.sampleShadingEnable = false;
            multisampling.rasterizationSamples = VkSampleCountFlagBits._1;

            var depthStencil = new VkPipelineDepthStencilStateCreateInfo();
            depthStencil.sType = VkStructureType.PipelineDepthStencilStateCreateInfo;
            depthStencil.depthTestEnable = true;
            depthStencil.depthWriteEnable = true;
            depthStencil.depthCompareOp = VkCompareOp.Less;
            depthStencil.depthBoundsTestEnable = false;
            depthStencil.stencilTestEnable = false;

            var colorBlendAttachment = new VkPipelineColorBlendAttachmentState();
            colorBlendAttachment.colorWriteMask = VkColorComponentFlagBits.R
                | VkColorComponentFlagBits.G | VkColorComponentFlagBits.B | VkColorComponentFlagBits.A;
            colorBlendAttachment.blendEnable = false;

            var colorBlending = new VkPipelineColorBlendStateCreateInfo();
            colorBlending.sType = VkStructureType.PipelineColorBlendStateCreateInfo;
            colorBlending.logicOpEnable = false;
            colorBlending.logicOp = VkLogicOp.Copy;
            colorBlending.attachments = colorBlendAttachment;
            colorBlending.blendConstants[0] = 0.0f;
            colorBlending.blendConstants[1] = 0.0f;
            colorBlending.blendConstants[2] = 0.0f;
            colorBlending.blendConstants[3] = 0.0f;

            var pipelineLayoutInfo = new VkPipelineLayoutCreateInfo();
            pipelineLayoutInfo.sType = VkStructureType.PipelineLayoutCreateInfo;
            pipelineLayoutInfo.setLayouts = descriptorSetLayout;

            VkPipelineLayout pipelineLayout;
            vkCreatePipelineLayout(device, &pipelineLayoutInfo, null, &pipelineLayout).Check();
            this.pipelineLayout = pipelineLayout;

            var pipelineInfo = new VkGraphicsPipelineCreateInfo();
            pipelineInfo.sType = VkStructureType.GraphicsPipelineCreateInfo;
            pipelineInfo.stages = shaderStages;
            pipelineInfo.pVertexInputState = &vertexInputInfo;
            pipelineInfo.pInputAssemblyState = &inputAssembly;
            pipelineInfo.pViewportState = &viewportState;
            pipelineInfo.pRasterizationState = &rasterizer;
            pipelineInfo.pMultisampleState = &multisampling;
            pipelineInfo.pDepthStencilState = &depthStencil;
            pipelineInfo.pColorBlendState = &colorBlending;
            pipelineInfo.layout = pipelineLayout;
            pipelineInfo.renderPass = renderPass;
            pipelineInfo.subpass = 0;
            //pipelineInfo.basePipelineHandle = VK_NULL_HANDLE;

            VkPipeline graphicsPipeline;
            vkCreateGraphicsPipelines(device, 0, 1, &pipelineInfo, null, &graphicsPipeline).Check();
            this.graphicsPipeline = graphicsPipeline;

            vkDestroyShaderModule(device, fragShaderModule, null);
            vkDestroyShaderModule(device, vertShaderModule, null);
        }

        void createFramebuffers() {
            swapChainFramebuffers = new VkFramebuffer[swapChainImageViews.Length];

            for (int i = 0; i < swapChainImageViews.Length; i++) {
                var attachments = new[] { swapChainImageViews[i], depthImageView };

                var framebufferInfo = new VkFramebufferCreateInfo();
                framebufferInfo.sType = VkStructureType.FramebufferCreateInfo;
                framebufferInfo.renderPass = renderPass;
                framebufferInfo.attachments = attachments;
                framebufferInfo.width = swapChainExtent.width;
                framebufferInfo.height = swapChainExtent.height;
                framebufferInfo.layers = 1;

                VkFramebuffer framebuffer;
                vkCreateFramebuffer(device, &framebufferInfo, null, &framebuffer).Check();
                swapChainFramebuffers[i] = framebuffer;
            }
        }

        void createCommandPool() {
            QueueFamilyIndices queueFamilyIndices = findQueueFamilies(physicalDevice);

            var poolInfo = new VkCommandPoolCreateInfo();
            poolInfo.sType = VkStructureType.CommandPoolCreateInfo;
            poolInfo.queueFamilyIndex = queueFamilyIndices.graphicsFamily.Value;

            VkCommandPool commandPool;
            vkCreateCommandPool(device, &poolInfo, null, &commandPool).Check();
            this.commandPool = commandPool;
        }

        void createDepthResources() {
            VkFormat depthFormat = findDepthFormat();

            createImage(swapChainExtent.width, swapChainExtent.height, 1, depthFormat, VkImageTiling.Optimal, VkImageUsageFlagBits.DepthStencilAttachment, VkMemoryPropertyFlagBits.DeviceLocal, ref depthImage, ref depthImageMemory);
            depthImageView = createImageView(depthImage, depthFormat, VkImageAspectFlagBits.Depth, 1);
        }

        VkFormat findSupportedFormat(VkFormat[] candidates, VkImageTiling tiling, VkFormatFeatureFlagBits features) {
            foreach (var format in candidates) {
                VkFormatProperties props;
                vkGetPhysicalDeviceFormatProperties(physicalDevice, format, &props);

                if (tiling == VkImageTiling.Linear && (props.linearTilingFeatures & features) == features) {
                    return format;
                }
                else if (tiling == VkImageTiling.Optimal && (props.optimalTilingFeatures & features) == features) {
                    return format;
                }
            }

            throw new Exception("failed to find supported format!");
        }

        VkFormat findDepthFormat() {
            return findSupportedFormat(
                new[] { VkFormat.D32Sfloat, VkFormat.D32SfloatS8Uint, VkFormat.D24UnormS8Uint },
                VkImageTiling.Optimal, VkFormatFeatureFlagBits.DepthStencilAttachment);
        }

        bool hasStencilComponent(VkFormat format) {
            return format == VkFormat.D32SfloatS8Uint || format == VkFormat.D24UnormS8Uint;
        }

        void createTextureImage() {
            Int32 texWidth, texHeight;
            byte[] pixels;
            //stbi_uc* pixels = stbi_load(TEXTURE_PATH.c_str(), &texWidth, &texHeight, &texChannels, STBI_rgb_alpha);
            VkDeviceSize imageSize;
            //mipLevels = static_cast<UInt32>(std::floor(std::log2(std::max(texWidth, texHeight)))) + 1;
            var loader = new ImageStreamLoader();
            ImageResult image = null;
            using (var stream = File.Open(TEXTURE_PATH, FileMode.Open)) {
                image = loader.Load(stream, ColorComponents.RedGreenBlueAlpha);
                pixels = image.Data;
                texWidth = image.Width;
                texHeight = image.Height;
                imageSize = texWidth * texHeight * 4;
                mipLevels = (UInt32)Math.Floor(Math.Log(Math.Max(texWidth, texHeight), 2)) + 1;
            }

            VkBuffer stagingBuffer;
            VkDeviceMemory stagingBufferMemory;
            createBuffer(imageSize, VkBufferUsageFlagBits.TransferSrc, VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent, out stagingBuffer, out stagingBufferMemory);

            IntPtr data;
            vkMapMemory(device, stagingBufferMemory, 0, imageSize, 0, &data);
            //memcpy(data, pixels, static_cast<size_t>(imageSize));
            Marshal.Copy(pixels, 0, data, (int)imageSize.value);
            vkUnmapMemory(device, stagingBufferMemory);

            //stbi_image_free(pixels);

            createImage((UInt32)texWidth, (UInt32)texHeight, mipLevels, VkFormat.R8g8b8a8Unorm, VkImageTiling.Optimal,
                VkImageUsageFlagBits.TransferSrc | VkImageUsageFlagBits.TransferDst | VkImageUsageFlagBits.Sampled,
                VkMemoryPropertyFlagBits.DeviceLocal, ref textureImage, ref textureImageMemory);


            transitionImageLayout(textureImage, VkFormat.R8g8b8a8Unorm, VkImageLayout.Undefined,
                VkImageLayout.TransferDstOptimal, mipLevels);
            copyBufferToImage(stagingBuffer, textureImage, (UInt32)texWidth, (UInt32)texHeight);
            //transitioned to VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL while generating mipmaps

            vkDestroyBuffer(device, stagingBuffer, null);
            vkFreeMemory(device, stagingBufferMemory, null);

            generateMipmaps(textureImage, VkFormat.R8g8b8a8Unorm, texWidth, texHeight, mipLevels);
        }

        void generateMipmaps(VkImage image, VkFormat imageFormat, Int32 texWidth, Int32 texHeight, UInt32 mipLevels) {
            // Check if image format supports linear blitting
            VkFormatProperties formatProperties;
            vkGetPhysicalDeviceFormatProperties(physicalDevice, imageFormat, &formatProperties);

            if (!formatProperties.optimalTilingFeatures.HasFlag(VkFormatFeatureFlagBits.SampledImageFilterLinear)) {
                throw new Exception("texture image format does not support linear blitting!");
            }

            VkCommandBuffer commandBuffer = beginSingleTimeCommands();

            var barrier = new VkImageMemoryBarrier();
            barrier.sType = VkStructureType.ImageMemoryBarrier;
            barrier.image = image;
            barrier.srcQueueFamilyIndex = VK_QUEUE_FAMILY_IGNORED;
            barrier.dstQueueFamilyIndex = VK_QUEUE_FAMILY_IGNORED;
            barrier.subresourceRange.aspectMask = VkImageAspectFlagBits.Color;
            barrier.subresourceRange.baseArrayLayer = 0;
            barrier.subresourceRange.layerCount = 1;
            barrier.subresourceRange.levelCount = 1;

            Int32 mipWidth = texWidth;
            Int32 mipHeight = texHeight;

            for (UInt32 i = 1; i < mipLevels; i++) {
                barrier.subresourceRange.baseMipLevel = i - 1;
                barrier.oldLayout = VkImageLayout.TransferDstOptimal;
                barrier.newLayout = VkImageLayout.TransferSrcOptimal;
                barrier.srcAccessMask = VkAccessFlagBits.TransferWrite;
                barrier.dstAccessMask = VkAccessFlagBits.TransferRead;

                vkCmdPipelineBarrier(commandBuffer,
                    VkPipelineStageFlagBits.Transfer,
                    VkPipelineStageFlagBits.Transfer,
                    0,
                    0, null,
                    0, null,
                    1, &barrier);

                var blit = new VkImageBlit();
                blit.srcOffsets0 = new VkOffset3D(0, 0, 0);
                blit.srcOffsets1 = new VkOffset3D(mipWidth, mipHeight, 1);
                blit.srcSubresource.aspectMask = VkImageAspectFlagBits.Color;
                blit.srcSubresource.mipLevel = i - 1;
                blit.srcSubresource.baseArrayLayer = 0;
                blit.srcSubresource.layerCount = 1;
                blit.dstOffsets0 = new VkOffset3D(0, 0, 0);
                blit.dstOffsets1 = new VkOffset3D(mipWidth > 1 ? mipWidth / 2 : 1, mipHeight > 1 ? mipHeight / 2 : 1, 1);
                blit.dstSubresource.aspectMask = VkImageAspectFlagBits.Color;
                blit.dstSubresource.mipLevel = i;
                blit.dstSubresource.baseArrayLayer = 0;
                blit.dstSubresource.layerCount = 1;

                vkCmdBlitImage(commandBuffer,
                    image, VkImageLayout.TransferSrcOptimal,
                    image, VkImageLayout.TransferDstOptimal,
                    1, &blit,
                    VkFilter.Linear);

                barrier.oldLayout = VkImageLayout.TransferSrcOptimal;
                barrier.newLayout = VkImageLayout.ShaderReadOnlyOptimal;
                barrier.srcAccessMask = VkAccessFlagBits.TransferRead;
                barrier.dstAccessMask = VkAccessFlagBits.ShaderRead;

                vkCmdPipelineBarrier(commandBuffer,
                    VkPipelineStageFlagBits.Transfer,
                    VkPipelineStageFlagBits.FragmentShader,
                    0,
                    0, null,
                    0, null,
                    1, &barrier);

                if (mipWidth > 1) mipWidth /= 2;
                if (mipHeight > 1) mipHeight /= 2;
            }

            barrier.subresourceRange.baseMipLevel = mipLevels - 1;
            barrier.oldLayout = VkImageLayout.TransferDstOptimal;
            barrier.newLayout = VkImageLayout.ShaderReadOnlyOptimal;
            barrier.srcAccessMask = VkAccessFlagBits.TransferWrite;
            barrier.dstAccessMask = VkAccessFlagBits.ShaderRead;

            vkCmdPipelineBarrier(commandBuffer,
                VkPipelineStageFlagBits.Transfer,
                VkPipelineStageFlagBits.FragmentShader,
                0,
                0, null,
                0, null,
                1, &barrier);

            endSingleTimeCommands(commandBuffer);
        }

        void createTextureImageView() {
            textureImageView = createImageView(textureImage, VkFormat.R8g8b8a8Unorm,
                VkImageAspectFlagBits.Color, mipLevels);
        }

        void createTextureSampler() {
            var samplerInfo = new VkSamplerCreateInfo();
            samplerInfo.sType = VkStructureType.SamplerCreateInfo;
            samplerInfo.magFilter = VkFilter.Linear;
            samplerInfo.minFilter = VkFilter.Linear;
            samplerInfo.addressModeU = VkSamplerAddressMode.Repeat;
            samplerInfo.addressModeV = VkSamplerAddressMode.Repeat;
            samplerInfo.addressModeW = VkSamplerAddressMode.Repeat;
            samplerInfo.anisotropyEnable = true;
            samplerInfo.maxAnisotropy = 16;
            samplerInfo.borderColor = VkBorderColor.IntOpaqueBlack;
            samplerInfo.unnormalizedCoordinates = false;
            samplerInfo.compareEnable = false;
            samplerInfo.compareOp = VkCompareOp.Always;
            samplerInfo.mipmapMode = VkSamplerMipmapMode.Linear;
            samplerInfo.minLod = 0;
            samplerInfo.maxLod = mipLevels;
            samplerInfo.mipLodBias = 0;

            VkSampler textureSampler;
            vkCreateSampler(device, &samplerInfo, null, &textureSampler).Check();
            this.textureSampler = textureSampler;
        }

        VkImageView createImageView(VkImage image, VkFormat format, VkImageAspectFlagBits aspectFlags, UInt32 mipLevels) {
            var viewInfo = new VkImageViewCreateInfo();
            viewInfo.sType = VkStructureType.ImageViewCreateInfo;
            viewInfo.image = image;
            viewInfo.viewType = VkImageViewType._2d;
            viewInfo.format = format;
            viewInfo.subresourceRange.aspectMask = aspectFlags;
            viewInfo.subresourceRange.baseMipLevel = 0;
            viewInfo.subresourceRange.levelCount = mipLevels;
            viewInfo.subresourceRange.baseArrayLayer = 0;
            viewInfo.subresourceRange.layerCount = 1;

            VkImageView imageView;
            vkCreateImageView(device, &viewInfo, null, &imageView).Check();

            return imageView;
        }

        void createImage(UInt32 width, UInt32 height, UInt32 mipLevels, VkFormat format, VkImageTiling tiling, VkImageUsageFlagBits usage, VkMemoryPropertyFlagBits properties, ref VkImage image, ref VkDeviceMemory imageMemory) {
            var imageInfo = new VkImageCreateInfo();
            imageInfo.sType = VkStructureType.ImageCreateInfo;
            imageInfo.imageType = VkImageType._2d;
            imageInfo.extent.width = width;
            imageInfo.extent.height = height;
            imageInfo.extent.depth = 1;
            imageInfo.mipLevels = mipLevels;
            imageInfo.arrayLayers = 1;
            imageInfo.format = format;
            imageInfo.tiling = tiling;
            imageInfo.initialLayout = VkImageLayout.Undefined;
            imageInfo.usage = usage;
            imageInfo.samples = VkSampleCountFlagBits._1;
            imageInfo.sharingMode = VkSharingMode.Exclusive;

            {
                VkImage tmpImage;
                vkCreateImage(device, &imageInfo, null, &tmpImage).Check();
                image = tmpImage;
            }

            VkMemoryRequirements memRequirements;
            vkGetImageMemoryRequirements(device, image, &memRequirements);

            var allocInfo = new VkMemoryAllocateInfo();
            allocInfo.sType = VkStructureType.MemoryAllocateInfo;
            allocInfo.allocationSize = memRequirements.size;
            allocInfo.memoryTypeIndex = findMemoryType(memRequirements.memoryTypeBits, properties);

            {
                VkDeviceMemory memory;
                vkAllocateMemory(device, &allocInfo, null, &memory).Check();
                imageMemory = memory;
            }

            vkBindImageMemory(device, image, imageMemory, 0);
        }

        void transitionImageLayout(VkImage image, VkFormat format, VkImageLayout oldLayout, VkImageLayout newLayout, UInt32 mipLevels) {
            VkCommandBuffer commandBuffer = beginSingleTimeCommands();

            var barrier = new VkImageMemoryBarrier();
            barrier.sType = VkStructureType.ImageMemoryBarrier;
            barrier.oldLayout = oldLayout;
            barrier.newLayout = newLayout;
            barrier.srcQueueFamilyIndex = VK_QUEUE_FAMILY_IGNORED;
            barrier.dstQueueFamilyIndex = VK_QUEUE_FAMILY_IGNORED;
            barrier.image = image;
            barrier.subresourceRange.aspectMask = VkImageAspectFlagBits.Color;
            barrier.subresourceRange.baseMipLevel = 0;
            barrier.subresourceRange.levelCount = mipLevels;
            barrier.subresourceRange.baseArrayLayer = 0;
            barrier.subresourceRange.layerCount = 1;

            VkPipelineStageFlagBits sourceStage;
            VkPipelineStageFlagBits destinationStage;

            if (oldLayout == VkImageLayout.Undefined && newLayout == VkImageLayout.TransferDstOptimal) {
                barrier.srcAccessMask = 0;
                barrier.dstAccessMask = VkAccessFlagBits.TransferWrite;

                sourceStage = VkPipelineStageFlagBits.TopOfPipe;
                destinationStage = VkPipelineStageFlagBits.Transfer;
            }
            else if (oldLayout == VkImageLayout.TransferDstOptimal && newLayout == VkImageLayout.ShaderReadOnlyOptimal) {
                barrier.srcAccessMask = VkAccessFlagBits.TransferWrite;
                barrier.dstAccessMask = VkAccessFlagBits.ShaderRead;

                sourceStage = VkPipelineStageFlagBits.Transfer;
                destinationStage = VkPipelineStageFlagBits.FragmentShader;
            }
            else {
                throw new ArgumentException("unsupported layout transition!");
            }

            vkCmdPipelineBarrier(
                commandBuffer,
                sourceStage, destinationStage,
                0,
                0, null,
                0, null,
                1, &barrier
            );

            endSingleTimeCommands(commandBuffer);
        }

        void copyBufferToImage(VkBuffer buffer, VkImage image, UInt32 width, UInt32 height) {
            VkCommandBuffer commandBuffer = beginSingleTimeCommands();

            var region = new VkBufferImageCopy();
            region.bufferOffset = 0;
            region.bufferRowLength = 0;
            region.bufferImageHeight = 0;
            region.imageSubresource.aspectMask = VkImageAspectFlagBits.Color;
            region.imageSubresource.mipLevel = 0;
            region.imageSubresource.baseArrayLayer = 0;
            region.imageSubresource.layerCount = 1;
            region.imageOffset = new VkOffset3D(0, 0, 0);
            region.imageExtent = new VkExtent3D(width, height, 1);

            vkCmdCopyBufferToImage(commandBuffer, buffer, image, VkImageLayout.TransferDstOptimal, 1, &region);

            endSingleTimeCommands(commandBuffer);
        }

        void loadModel() {
            var importer = new Assimp.AssimpContext();
            Assimp.Scene scene = importer.ImportFile(MODEL_PATH, Assimp.PostProcessSteps.JoinIdenticalVertices);
            foreach (var mesh in scene.Meshes) {
                this.vertices = mesh.Vertices.ToArray();

                this.indices = new List<uint>();
                foreach (var item in mesh.Faces) {
                    this.indices.Add((uint)item.Indices[0]);
                    this.indices.Add((uint)item.Indices[1]);
                    this.indices.Add((uint)item.Indices[2]);
                }
            }
        }

        void createVertexBuffer() {
            int bufferSize = sizeof(float) * 3 * this.vertices.Length;

            VkBuffer stagingBuffer;
            VkDeviceMemory stagingBufferMemory;
            createBuffer(bufferSize, VkBufferUsageFlagBits.TransferSrc, VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent, out stagingBuffer, out stagingBufferMemory);

            IntPtr data;
            vkMapMemory(device, stagingBufferMemory, 0, bufferSize, 0, &data);
            //memcpy(data, vertices.data(), (size_t)bufferSize);
            vkAPI.Copy(this.vertices, data);
            vkUnmapMemory(device, stagingBufferMemory);

            createBuffer(bufferSize, VkBufferUsageFlagBits.TransferDst | VkBufferUsageFlagBits.VertexBuffer, VkMemoryPropertyFlagBits.DeviceLocal, out vertexBuffer, out vertexBufferMemory);

            copyBuffer(stagingBuffer, vertexBuffer, bufferSize);

            vkDestroyBuffer(device, stagingBuffer, null);
            vkFreeMemory(device, stagingBufferMemory, null);
        }

        void createIndexBuffer() {
            int bufferSize = sizeof(uint) * indices.Count;

            VkBuffer stagingBuffer;
            VkDeviceMemory stagingBufferMemory;
            createBuffer(bufferSize, VkBufferUsageFlagBits.TransferSrc, VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent, out stagingBuffer, out stagingBufferMemory);

            IntPtr data;
            vkMapMemory(device, stagingBufferMemory, 0, bufferSize, 0, &data);
            //memcpy(data, indices.data(), (size_t)bufferSize);
            vkAPI.Copy(indices.ToArray(), data);
            vkUnmapMemory(device, stagingBufferMemory);

            createBuffer(bufferSize, VkBufferUsageFlagBits.TransferDst | VkBufferUsageFlagBits.IndexBuffer, VkMemoryPropertyFlagBits.DeviceLocal, out indexBuffer, out indexBufferMemory);

            copyBuffer(stagingBuffer, indexBuffer, bufferSize);

            vkDestroyBuffer(device, stagingBuffer, null);
            vkFreeMemory(device, stagingBufferMemory, null);
        }

        void createUniformBuffers() {
            VkDeviceSize bufferSize = sizeof(UniformBufferObject);

            uniformBuffers = new VkBuffer[swapChainImages.Length];
            uniformBuffersMemory = new VkDeviceMemory[swapChainImages.Length];

            for (int i = 0; i < swapChainImages.Length; i++) {
                VkBuffer buffer;
                VkDeviceMemory memory;
                createBuffer(bufferSize, VkBufferUsageFlagBits.UniformBuffer, VkMemoryPropertyFlagBits.HostVisible | VkMemoryPropertyFlagBits.HostCoherent, out buffer, out memory);
                uniformBuffers[i] = buffer;
                uniformBuffersMemory[i] = memory;
            }
        }

        void createDescriptorPool() {
            var poolSizes = new VkDescriptorPoolSize[2];
            poolSizes[0].type = VkDescriptorType.UniformBuffer;
            poolSizes[0].descriptorCount = (UInt32)swapChainImages.Length;
            poolSizes[1].type = VkDescriptorType.CombinedImageSampler;
            poolSizes[1].descriptorCount = (UInt32)swapChainImages.Length;

            var poolInfo = new VkDescriptorPoolCreateInfo();
            poolInfo.sType = VkStructureType.DescriptorPoolCreateInfo;
            poolInfo.poolSizes = poolSizes;
            poolInfo.maxSets = (UInt32)swapChainImages.Length;

            VkDescriptorPool descriptorPool;
            vkCreateDescriptorPool(device, &poolInfo, null, &descriptorPool).Check();
            this.descriptorPool = descriptorPool;
        }

        void createDescriptorSets() {
            var layouts = new VkDescriptorSetLayout[swapChainImages.Length];
            for (int i = 0; i < layouts.Length; i++) {
                layouts[i] = descriptorSetLayout;
            }
            var allocInfo = new VkDescriptorSetAllocateInfo();
            allocInfo.sType = VkStructureType.DescriptorSetAllocateInfo;
            allocInfo.descriptorPool = descriptorPool;
            allocInfo.setLayouts = layouts;

            descriptorSets = new VkDescriptorSet[swapChainImages.Length];
            fixed (VkDescriptorSet* pointer = descriptorSets)
                vkAllocateDescriptorSets(device, &allocInfo, pointer).Check();

            for (int i = 0; i < swapChainImages.Length; i++) {
                var bufferInfo = new VkDescriptorBufferInfo();
                bufferInfo.buffer = uniformBuffers[i];
                bufferInfo.offset = 0;
                bufferInfo.range = sizeof(UniformBufferObject);

                var imageInfo = new VkDescriptorImageInfo();
                imageInfo.imageLayout = VkImageLayout.ShaderReadOnlyOptimal;
                imageInfo.imageView = textureImageView;
                imageInfo.sampler = textureSampler;

                var descriptorWrites = new VkWriteDescriptorSet[2];
                descriptorWrites[0].sType = VkStructureType.WriteDescriptorSet;
                descriptorWrites[0].dstSet = descriptorSets[i];
                descriptorWrites[0].dstBinding = 0;
                descriptorWrites[0].dstArrayElement = 0;
                descriptorWrites[0].data.descriptorType = VkDescriptorType.UniformBuffer;
                descriptorWrites[0].data.Set(bufferInfo);
                descriptorWrites[1].sType = VkStructureType.WriteDescriptorSet;
                descriptorWrites[1].dstSet = descriptorSets[i];
                descriptorWrites[1].dstBinding = 1;
                descriptorWrites[1].dstArrayElement = 0;
                descriptorWrites[1].data.descriptorType = VkDescriptorType.CombinedImageSampler;
                descriptorWrites[1].data.Set(imageInfo);

                fixed (VkWriteDescriptorSet* pointer = descriptorWrites)
                    vkUpdateDescriptorSets(device, 2u, pointer, 0, null);
            }
        }

        void createBuffer(VkDeviceSize size, VkBufferUsageFlagBits usage, VkMemoryPropertyFlagBits properties, out VkBuffer buffer, out VkDeviceMemory bufferMemory) {
            var bufferInfo = new VkBufferCreateInfo();
            bufferInfo.sType = VkStructureType.BufferCreateInfo;
            bufferInfo.size = size;
            bufferInfo.usage = usage;
            bufferInfo.sharingMode = VkSharingMode.Exclusive;
            {
                VkBuffer tmpBuffer;
                vkCreateBuffer(device, &bufferInfo, null, &tmpBuffer).Check();
                buffer = tmpBuffer;
            }

            VkMemoryRequirements memRequirements;
            vkGetBufferMemoryRequirements(device, buffer, &memRequirements);

            var allocInfo = new VkMemoryAllocateInfo();
            allocInfo.sType = VkStructureType.MemoryAllocateInfo;
            allocInfo.allocationSize = memRequirements.size;
            allocInfo.memoryTypeIndex = findMemoryType(memRequirements.memoryTypeBits, properties);

            {
                VkDeviceMemory memory;
                vkAllocateMemory(device, &allocInfo, null, &memory).Check();
                bufferMemory = memory;
            }

            vkBindBufferMemory(device, buffer, bufferMemory, 0);
        }

        VkCommandBuffer beginSingleTimeCommands() {
            var allocInfo = new VkCommandBufferAllocateInfo();
            allocInfo.sType = VkStructureType.CommandBufferAllocateInfo;
            allocInfo.level = VkCommandBufferLevel.Primary;
            allocInfo.commandPool = commandPool;
            allocInfo.commandBufferCount = 1;

            VkCommandBuffer commandBuffer;
            vkAllocateCommandBuffers(device, &allocInfo, &commandBuffer);

            var beginInfo = new VkCommandBufferBeginInfo();
            beginInfo.sType = VkStructureType.CommandBufferBeginInfo;
            beginInfo.flags = VkCommandBufferUsageFlagBits.OneTimeSubmit;

            vkBeginCommandBuffer(commandBuffer, &beginInfo);

            return commandBuffer;
        }

        void endSingleTimeCommands(VkCommandBuffer commandBuffer) {
            vkEndCommandBuffer(commandBuffer);

            var submitInfo = new VkSubmitInfo();
            submitInfo.sType = VkStructureType.SubmitInfo;
            submitInfo.commandBuffers = commandBuffer;

            vkQueueSubmit(graphicsQueue, 1, &submitInfo, 0);
            vkQueueWaitIdle(graphicsQueue);

            vkFreeCommandBuffers(device, commandPool, 1, &commandBuffer);
        }

        void copyBuffer(VkBuffer srcBuffer, VkBuffer dstBuffer, VkDeviceSize size) {
            VkCommandBuffer commandBuffer = beginSingleTimeCommands();

            var copyRegion = new VkBufferCopy();
            copyRegion.size = size;
            vkCmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, 1, &copyRegion);

            endSingleTimeCommands(commandBuffer);
        }

        UInt32 findMemoryType(UInt32 typeFilter, VkMemoryPropertyFlagBits properties) {
            VkPhysicalDeviceMemoryProperties memProperties;
            vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memProperties);

            var types = (VkMemoryType*)memProperties.memoryTypes;
            for (Int32 i = 0; i < memProperties.memoryTypeCount; i++) {
                if (((typeFilter & (1 << i)) != 0)
                    && (types[i].propertyFlags & properties) == properties) {
                    return (UInt32)i;
                }
            }

            throw new Exception("failed to find suitable memory type!");
        }

        void createCommandBuffers() {
            commandBuffers = new VkCommandBuffer[swapChainFramebuffers.Length];

            var allocInfo = new VkCommandBufferAllocateInfo();
            allocInfo.sType = VkStructureType.CommandBufferAllocateInfo;
            allocInfo.commandPool = commandPool;
            allocInfo.level = VkCommandBufferLevel.Primary;
            allocInfo.commandBufferCount = (UInt32)commandBuffers.Length;

            fixed (VkCommandBuffer* pointer = commandBuffers)
                vkAllocateCommandBuffers(device, &allocInfo, pointer).Check();

            for (int i = 0; i < commandBuffers.Length; i++) {
                var beginInfo = new VkCommandBufferBeginInfo();
                beginInfo.sType = VkStructureType.CommandBufferBeginInfo;

                vkBeginCommandBuffer(commandBuffers[i], &beginInfo).Check();

                var renderPassInfo = new VkRenderPassBeginInfo();
                renderPassInfo.sType = VkStructureType.RenderPassBeginInfo;
                renderPassInfo.renderPass = renderPass;
                renderPassInfo.framebuffer = swapChainFramebuffers[i];
                renderPassInfo.renderArea.offset = new VkOffset2D(0, 0);
                renderPassInfo.renderArea.extent = swapChainExtent;

                var clearValues = new VkClearValue[2];
                clearValues[0].color = new VkClearColorValue(0.0f, 0.0f, 0.0f, 1.0f);
                clearValues[1].depthStencil = new VkClearDepthStencilValue(1.0f, 0);
                renderPassInfo.clearValues = clearValues;

                vkCmdBeginRenderPass(commandBuffers[i], &renderPassInfo, VkSubpassContents.Inline);

                vkCmdBindPipeline(commandBuffers[i], VkPipelineBindPoint.Graphics, graphicsPipeline);

                {
                    var buffer = this.vertexBuffer;
                    var offsets = new VkDeviceSize();
                    vkCmdBindVertexBuffers(commandBuffers[i], 0, 1, &buffer, &offsets);
                }

                vkCmdBindIndexBuffer(commandBuffers[i], indexBuffer, 0, VkIndexType.Uint32);

                {
                    var set = descriptorSets[i];
                    vkCmdBindDescriptorSets(commandBuffers[i], VkPipelineBindPoint.Graphics,
                        pipelineLayout, 0, 1, &set, 0, null);
                }

                vkCmdDrawIndexed(commandBuffers[i], (UInt32)indices.Count, 1, 0, 0, 0);

                vkCmdEndRenderPass(commandBuffers[i]);

                vkEndCommandBuffer(commandBuffers[i]).Check();
            }
        }

        void createSyncObjects() {
            imageAvailableSemaphores = new VkSemaphore[MAX_FRAMES_IN_FLIGHT];
            renderFinishedSemaphores = new VkSemaphore[MAX_FRAMES_IN_FLIGHT];
            inFlightFences = new VkFence[MAX_FRAMES_IN_FLIGHT];

            var semaphoreInfo = new VkSemaphoreCreateInfo();
            semaphoreInfo.sType = VkStructureType.SemaphoreCreateInfo;

            var fenceInfo = new VkFenceCreateInfo();
            fenceInfo.sType = VkStructureType.FenceCreateInfo;
            fenceInfo.flags = VkFenceCreateFlagBits.Signaled;

            for (int i = 0; i < MAX_FRAMES_IN_FLIGHT; i++) {
                VkSemaphore semaphore;
                vkCreateSemaphore(device, &semaphoreInfo, null, &semaphore).Check();
                imageAvailableSemaphores[i] = semaphore;
                vkCreateSemaphore(device, &semaphoreInfo, null, &semaphore).Check();
                renderFinishedSemaphores[i] = semaphore;
                VkFence fence;
                vkCreateFence(device, &fenceInfo, null, &fence).Check();
                inFlightFences[i] = fence;
            }
        }

        DateTime startTime = DateTime.Now;
        void updateUniformBuffer(UInt32 currentImage) {
            var currentTime = DateTime.Now;
            float time = (float)(currentTime - startTime).TotalMilliseconds;

            var ubo = new UniformBufferObject();
            //ubo.model = glm::rotate(glm::mat4(1.0f), time * glm::radians(90.0f), glm::vec3(0.0f, 0.0f, 1.0f));
            //ubo.view = glm::lookAt(glm::vec3(2.0f, 2.0f, 2.0f), glm::vec3(0.0f, 0.0f, 0.0f), glm::vec3(0.0f, 0.0f, 1.0f));
            //ubo.proj = glm::perspective(glm::radians(45.0f), swapChainExtent.width / (float)swapChainExtent.height, 0.1f, 10.0f);
            //ubo.proj[1][1] *= -1;

            int size = Marshal.SizeOf(ubo);
            IntPtr data;
            vkMapMemory(device, uniformBuffersMemory[currentImage], 0, size, 0, &data);
            //memcpy(data, &ubo, sizeof(ubo));
            vkAPI.Copy(ref ubo, data);
            vkUnmapMemory(device, uniformBuffersMemory[currentImage]);
        }

        void drawFrame() {
            {
                var fence = inFlightFences[currentFrame];
                vkWaitForFences(device, 1, &fence, true, UInt64.MaxValue);
            }

            UInt32 imageIndex;
            VkResult result = vkAcquireNextImageKHR(device, swapChain, UInt64.MaxValue, imageAvailableSemaphores[currentFrame], 0, &imageIndex);

            if (result == VkResult.ErrorOutOfDateKHR) {
                recreateSwapChain();
                return;
            }
            else if (result != VkResult.Success && result != VkResult.SuboptimalKHR) {
                throw new Exception("failed to acquire swap chain image!");
            }

            updateUniformBuffer(imageIndex);

            var submitInfo = new VkSubmitInfo();
            submitInfo.sType = VkStructureType.SubmitInfo;
            submitInfo.waitSemaphores = imageAvailableSemaphores[currentFrame];
            submitInfo.waitSemaphoresDstStageMasks.Set(VkPipelineStageFlagBits.ColorAttachmentOutput);
            submitInfo.commandBuffers = commandBuffers[imageIndex];
            submitInfo.signalSemaphores = renderFinishedSemaphores[currentFrame];

            {
                var fence = inFlightFences[currentFrame];
                vkWaitForFences(device, 1, &fence, true, UInt64.MaxValue);
                vkResetFences(device, 1, &fence);
            }

            vkQueueSubmit(graphicsQueue, 1, &submitInfo, inFlightFences[currentFrame]).Check();

            var presentInfo = new VkPresentInfoKHR();
            presentInfo.sType = VkStructureType.PresentInfoKHR;
            presentInfo.waitSemaphores = renderFinishedSemaphores[currentFrame];
            presentInfo.swapchains = swapChain;
            presentInfo.swapchainsImages.Set(imageIndex);

            result = vkQueuePresentKHR(presentQueue, &presentInfo);

            if (result == VkResult.ErrorOutOfDateKHR || result == VkResult.SuboptimalKHR || framebufferResized) {
                framebufferResized = false;
                recreateSwapChain();
            }
            else if (result != VkResult.Success) {
                throw new Exception("failed to present swap chain image!");
            }

            currentFrame = (currentFrame + 1) % MAX_FRAMES_IN_FLIGHT;
        }

        VkShaderModule createShaderModule(byte[] code) {
            var createInfo = new VkShaderModuleCreateInfo();
            createInfo.sType = VkStructureType.ShaderModuleCreateInfo;
            createInfo.code = code;

            VkShaderModule shaderModule;
            vkCreateShaderModule(device, &createInfo, null, &shaderModule).Check();

            return shaderModule;
        }

        VkSurfaceFormatKHR chooseSwapSurfaceFormat(VkSurfaceFormatKHR[] availableFormats) {
            foreach (var availableFormat in availableFormats) {
                if (availableFormat.format == VkFormat.B8g8r8a8Unorm && availableFormat.colorSpace == VkColorSpaceKHR.SrgbNonlinearKHR) {
                    return availableFormat;
                }
            }

            return availableFormats[0];
        }

        VkPresentModeKHR chooseSwapPresentMode(VkPresentModeKHR[] availablePresentModes) {
            foreach (var availablePresentMode in availablePresentModes) {
                if (availablePresentMode == VkPresentModeKHR.MailboxKHR) {
                    return availablePresentMode;
                }
            }

            return VkPresentModeKHR.FifoKHR;
        }

        VkExtent2D chooseSwapExtent(VkSurfaceCapabilitiesKHR capabilities) {
            if (capabilities.currentExtent.width != UInt32.MaxValue) {
                return capabilities.currentExtent;
            }
            else {
                uint width = 0, height = 0;
                //glfwGetFramebufferSize(window, &width, &height);
                File.WriteAllText(logFile, "chooseSwapExtent.else{ }");
                VkExtent2D actualExtent = new VkExtent2D(width, height);

                actualExtent.width = (UInt32)Math.Max(capabilities.minImageExtent.width, Math.Min(capabilities.maxImageExtent.width, actualExtent.width));
                actualExtent.height = (UInt32)Math.Max(capabilities.minImageExtent.height, Math.Min(capabilities.maxImageExtent.height, actualExtent.height));

                return actualExtent;
            }
        }

        SwapChainSupportDetails querySwapChainSupport(VkPhysicalDevice device) {
            var details = new SwapChainSupportDetails();
            vkGetPhysicalDeviceSurfaceCapabilitiesKHR(device, surface, &details.capabilities);
            details.formats = vkAPI.Formats(device, surface);
            details.presentModes = vkAPI.PresentModesKHR(device, surface);

            return details;
        }

        bool isDeviceSuitable(VkPhysicalDevice device) {
            QueueFamilyIndices indices = findQueueFamilies(device);

            bool extensionsSupported = checkDeviceExtensionSupport(device);

            bool swapChainAdequate = false;
            if (extensionsSupported) {
                SwapChainSupportDetails swapChainSupport = querySwapChainSupport(device);
                swapChainAdequate = swapChainSupport.formats != null && swapChainSupport.presentModes != null;
            }

            VkPhysicalDeviceFeatures supportedFeatures;
            vkGetPhysicalDeviceFeatures(device, &supportedFeatures);

            return indices.isComplete() && extensionsSupported && swapChainAdequate && supportedFeatures.samplerAnisotropy;
        }

        bool checkDeviceExtensionSupport(VkPhysicalDevice device) {
            VkExtensionProperties[] propertiesArray = vkAPI.DeviceExtensionProperties(device);
            var availableExtensions = new List<string>();
            for (int i = 0; i < propertiesArray.Length; i++) {
                VkExtensionProperties properties = propertiesArray[i];
                string name = Marshal.PtrToStringAnsi((IntPtr)properties.extensionName);
                availableExtensions.Add(name);
            }
            string[] requiredExtensions = deviceExtensions;

            foreach (var item in requiredExtensions) {
                if (!availableExtensions.Contains(item)) { return false; }
            }

            return true;
        }

        QueueFamilyIndices findQueueFamilies(VkPhysicalDevice device) {
            var indices = new QueueFamilyIndices();

            var properties = vkAPI.QueueFamilyProperties(device);
            UInt32 index = 0;
            foreach (var property in properties) {
                if (property.queueCount > 0 && property.queueFlags.HasFlag(VkQueueFlagBits.Graphics)) {
                    indices.graphicsFamily = index;
                }

                VkBool32 presentSupport = false;
                vkGetPhysicalDeviceSurfaceSupportKHR(device, index, surface, &presentSupport).Check();

                if (property.queueCount > 0 && presentSupport) {
                    indices.presentFamily = index;
                }

                if (indices.isComplete()) {
                    break;
                }

                index++;
            }

            return indices;
        }

        string[] getRequiredExtensions() {
            var extensions = new List<string>();
            extensions.Add(vkAPI.VK_KHR_surface);
            extensions.Add(vkAPI.VK_KHR_win32_surface);
            extensions.Add(vkAPI.VK_EXT_debug_report);

            if (enableValidationLayers) {
                extensions.Add(vkAPI.VK_EXT_debug_utils);
            }

            return extensions.ToArray();
        }

        bool checkValidationLayerSupport() {
            var availableLayers = vkAPI.InstanceLayerProperties();

            foreach (var layerName in validationLayers) {
                bool layerFound = false;

                foreach (var layerProperties in availableLayers) {
                    if (layerName == Marshal.PtrToStringAnsi((IntPtr)layerProperties.layerName)) {
                        layerFound = true;
                        break;
                    }
                }

                if (!layerFound) {
                    return false;
                }
            }

            return true;
        }

        //        static byte[] readFile(string filename) {
        //    std::ifstream file(filename, std::ios::ate | std::ios::binary);

        //    if (!file.is_open()) {
        //        throw new Exception("failed to open file!");
        //    }

        //    size_t fileSize = (size_t)file.tellg();
        //    std::vector<char> buffer(fileSize);

        //    file.seekg(0);
        //    file.read(buffer.data(), fileSize);

        //    file.close();

        //    return buffer;
        //}

        static VkBool32 debugCallback(VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageType, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData) {
            string text = string.Format("validation layer: {0}", Marshal.PtrToStringAnsi(pCallbackData->pMessage));
            File.AppendAllText(logFile, text);

            return false;
        }
    }
}
