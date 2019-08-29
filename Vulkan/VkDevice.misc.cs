using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDevice {
        public VkQueue GetDeviceQueue(UInt32 queueFamilyIndex, UInt32 queueIndex) {
            return VkQueue.Create(this, queueFamilyIndex, queueIndex);
        }

        public VkResult CreateCommandPool(ref VkCommandPoolCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkCommandPool commandPool) {
            return VkCommandPool.Create(this, ref createInfo, callbacks, out commandPool);
        }

        public VkResult AllocateMemory(ref VkMemoryAllocateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkDeviceMemory memory) {
            return VkDeviceMemory.Create(this, ref createInfo, callbacks, out memory);
        }

        public void UpdateDescriptorSets(VkWriteDescriptorSet[] writes, VkCopyDescriptorSet[] copies) {
            fixed (VkWriteDescriptorSet* pWrites = writes) {
                fixed (VkCopyDescriptorSet* pCopies = copies) {
                    vkAPI.vkUpdateDescriptorSets(this.handle, (UInt32)writes.Length, pWrites, (UInt32)copies.Length, pCopies);
                }
            }
        }

        public void GetImageSparseMemoryRequirements(VkImage image, out VkSparseImageMemoryRequirements[] properties) {
            UInt32 count;
            vkAPI.vkGetImageSparseMemoryRequirements(this.handle, image.handle, &count, null);
            properties = new VkSparseImageMemoryRequirements[count];
            if (count > 0) {
                fixed (VkSparseImageMemoryRequirements* pointer = properties) {
                    vkAPI.vkGetImageSparseMemoryRequirements(this.handle, image.handle, &count, pointer);
                }
            }
        }


        public VkSwapchainKhr CreateSwapchainKHR(ref VkSwapchainCreateInfoKhr createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkSwapchainCreateInfoKhr* pCreateInfo = &createInfo) {
                vkAPI.vkCreateSwapchainKHR(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkSwapchainKhr(this, callbacks, handle);
        }

        public VkImage[] GetSwapchainImagesKHR(VkSwapchainKhr swapchain) {
            UInt32 count;
            vkAPI.vkGetSwapchainImagesKHR(this.handle, swapchain != null ? swapchain.handle : default(UInt64), &count, null).Check();
            if (count <= 0) { return null; }

            var pointers = stackalloc UInt64[(int)count];
            vkAPI.vkGetSwapchainImagesKHR(this.handle, swapchain != null ? swapchain.handle : default(UInt64), &count, pointers).Check();

            if (count <= 0) { return null; }

            var result = new VkImage[count];
            for (int i = 0; i < count; i++) {
                result[i] = new VkImage(this, null, pointers[i]);
            }

            return result;
        }


        public VkRenderPass CreateRenderPass(ref VkRenderPassCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkRenderPassCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateRenderPass(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkRenderPass(this, callbacks, handle);
        }

        public VkImageView CreateImageView(ref VkImageViewCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkImageViewCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateImageView(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkImageView(this, callbacks, handle);
        }

        public VkFramebuffer CreateFramebuffer(ref VkFramebufferCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkFramebufferCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateFramebuffer(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkFramebuffer(this, callbacks, handle);
        }

        public VkFence CreateFence(ref VkFenceCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkFenceCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateFence(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkFence(this, callbacks, handle);
        }


        public VkSemaphore CreateSemaphore(ref VkSemaphoreCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkSemaphoreCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateSemaphore(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkSemaphore(this, callbacks, handle);
        }

        public VkCommandPool CreateCommandPool(ref VkCommandPoolCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkCommandPoolCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateCommandPool(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }
            return new VkCommandPool(this, callbacks, handle);
        }

        public VkCommandBuffer[] AllocateCommandBuffers(ref VkCommandBufferAllocateInfo allocateInfo) {
            if (allocateInfo.CommandBufferCount <= 0)
                return null;

            int count = (int)allocateInfo.CommandBufferCount;
            var array = stackalloc IntPtr[(int)count];
            fixed (VkCommandBufferAllocateInfo* pAllocateInfo = &allocateInfo) {
                vkAPI.vkAllocateCommandBuffers(this.handle, pAllocateInfo, array).Check();
            }

            var result = new VkCommandBuffer[count];
            for (int i = 0; i < count; i++) {
                result[i] = new VkCommandBuffer(this, array[i]);
            }

            return result;
        }

        public UInt32 AcquireNextImageKHR(VkSwapchainKhr swapchain, UInt64 timeout, VkSemaphore semaphore = null, VkFence fence = null) {
            UInt32 imageIndex;
            vkAPI.vkAcquireNextImageKHR(this.handle, swapchain != null ? swapchain.handle : default(UInt64),
                timeout,
                semaphore != null ? semaphore.handle : default(UInt64),
                fence != null ? fence.handle : default(UInt64),
                &imageIndex).Check();

            return imageIndex;
        }

        public void ResetFence(VkFence pFence) {
            fixed (UInt64* pointer = &pFence.handle) {
                vkAPI.vkResetFences(this.handle, (UInt32)(pFence != null ? 1 : 0), pointer).Check();
            }
        }

        public void WaitForFence(VkFence pFence, VkBool32 waitAll, UInt64 timeout) {
            fixed (UInt64* ptrpFence = &pFence.handle) {
                vkAPI.vkWaitForFences(this.handle, (UInt32)(pFence != null ? 1 : 0), ptrpFence, waitAll, timeout).Check();
            }
        }

    }
}

