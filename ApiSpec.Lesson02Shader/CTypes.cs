using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vulkan;

namespace ApiSpec.Lesson02Shader {
    unsafe class CInstance {
        public readonly VkInstance handle;
        public readonly VkInstanceCreateInfo* info;

        public CInstance(VkInstance handle, VkInstanceCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CSurface {
        public readonly VkSurfaceKHR handle;
        public readonly VkWin32SurfaceCreateInfoKHR* info;

        public CSurface(VkSurfaceKHR handle, VkWin32SurfaceCreateInfoKHR* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CDevice {
        public readonly VkDevice handle;
        public readonly VkDeviceCreateInfo* info;

        public CDevice(VkDevice handle, VkDeviceCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CSwapchain {
        public readonly VkSwapchainKHR handle;
        public readonly VkSwapchainCreateInfoKHR* info;

        public CSwapchain(VkSwapchainKHR handle, VkSwapchainCreateInfoKHR* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CRenderPass {
        public readonly VkRenderPass handle;
        public readonly VkRenderPassCreateInfo* info;

        public CRenderPass(VkRenderPass renderPass, VkRenderPassCreateInfo* info) {
            this.handle = renderPass;
            this.info = info;
        }
    }

    unsafe class CFramebuffer {
        public readonly VkFramebuffer handle;
        public readonly VkFramebufferCreateInfo* info;

        public CFramebuffer(VkFramebuffer handle, VkFramebufferCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CBuffer {
        public readonly VkBuffer handle;
        public readonly VkBufferCreateInfo* info;
        public CDeviceMemory memory;

        public CBuffer(VkBuffer handle, VkBufferCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CDeviceMemory {
        public readonly VkDeviceMemory handle;
        public readonly VkMemoryAllocateInfo* info;

        public CDeviceMemory(VkDeviceMemory handle, VkMemoryAllocateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CDescriptorSetLayout {
        public readonly VkDescriptorSetLayout handle;
        public readonly VkDescriptorSetLayoutCreateInfo* info;

        public CDescriptorSetLayout(VkDescriptorSetLayout handle, VkDescriptorSetLayoutCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CDescriptorPool {
        public readonly VkDescriptorPool handle;
        public readonly VkDescriptorPoolCreateInfo* info;

        public CDescriptorPool(VkDescriptorPool handle, VkDescriptorPoolCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CDescriptorSet {
        public readonly VkDescriptorSet handle;
        public readonly VkDescriptorSetAllocateInfo* info;

        public CDescriptorSet(VkDescriptorSet handle, VkDescriptorSetAllocateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CPipeline {
        public readonly VkPipeline handle;
        public readonly VkGraphicsPipelineCreateInfo* info;

        public CPipeline(VkPipeline handle, VkGraphicsPipelineCreateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }

    unsafe class CCommandBuffer {
        public readonly VkCommandBuffer handle;
        public readonly VkCommandBufferAllocateInfo* info;

        public CCommandBuffer(VkCommandBuffer handle, VkCommandBufferAllocateInfo* info) {
            this.handle = handle;
            this.info = info;
        }
    }
}
