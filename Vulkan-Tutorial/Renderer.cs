using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;

namespace Vulkan_Tutorial {
    unsafe partial class Renderer : IDisposable {
        const string MODEL_PATH = "models/chalet.obj";
        const string TEXTURE_PATH = "textures/chalet.jpg";

        private static string[] validationLayers = new string[] { "VK_LAYER_KHRONOS_validation" };
        private static string[] deviceExtensions = new string[] { vkAPI.VK_KHR_swapchain };

        const int MAX_FRAMES_IN_FLIGHT = 2;

#if NDEBUG
        const bool enableValidationLayers = false;
#else
        const bool enableValidationLayers = true;
#endif


        struct QueueFamilyIndices {
            public UInt32? graphicsFamily;
            public UInt32? presentFamily;

            bool isComplete() {
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

            static VkVertexInputBindingDescription getBindingDescription() {
                VkVertexInputBindingDescription bindingDescription;
                bindingDescription.binding = 0;
                bindingDescription.stride = (UInt32)Marshal.SizeOf(typeof(Vertex));
                bindingDescription.inputRate = VkVertexInputRate.Vertex;

                return bindingDescription;
            }


            static VkVertexInputAttributeDescription[] getAttributeDescriptions() {
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

        List<Vertex> vertices;
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

        void initVulkan() {
            createInstance();
            setupDebugMessenger();
            createSurface();
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

        public void drawFrame() {
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

    }
}
