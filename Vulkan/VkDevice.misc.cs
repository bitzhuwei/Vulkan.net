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
            UInt32 writeLength = (UInt32)(writes != null ? writes.Length : 0);
            UInt32 copiesLength = (UInt32)(copies != null ? copies.Length : 0);
            fixed (VkWriteDescriptorSet* pWrites = writes) {
                fixed (VkCopyDescriptorSet* pCopies = copies) {
                    vkAPI.vkUpdateDescriptorSets(this.handle, writeLength, pWrites, copiesLength, pCopies);
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

            var swapchain = new VkSwapchainKhr(this, callbacks, handle);
#if DEBUG
            VkSwapchainKhr.Fill(swapchain, ref createInfo);
#endif
            return swapchain;
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

            var renderPass = new VkRenderPass(this, callbacks, handle);
#if DEBUG
            VkRenderPass.Fill(renderPass, createInfo);
#endif

            return renderPass;
        }

        public VkImageView CreateImageView(ref VkImageViewCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkImageViewCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateImageView(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            var imageView = new VkImageView(this, callbacks, handle);
#if DEBUG
            VkImageView.Fill(imageView, createInfo);
#endif
            return imageView;
        }

        public VkFramebuffer CreateFramebuffer(ref VkFramebufferCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkFramebufferCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateFramebuffer(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            var framebuffer = new VkFramebuffer(this, callbacks, handle);
#if DEBUG
            VkFramebuffer.Fill(framebuffer, createInfo);
#endif 

            return framebuffer;
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

        public VkBuffer CreateBuffer(ref VkBufferCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkBufferCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateBuffer(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkBuffer(this, callbacks, handle);
        }

        public VkMemoryRequirements GetBufferMemoryRequirements(VkBuffer buffer) {
            var result = new VkMemoryRequirements();
            vkAPI.vkGetBufferMemoryRequirements(this.handle, buffer != null ? buffer.handle : default(UInt64), &result);

            return result;
        }

        public VkDeviceMemory AllocateMemory(ref VkMemoryAllocateInfo allocateInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkMemoryAllocateInfo* pAllocateInfo = &allocateInfo) {
                vkAPI.vkAllocateMemory(this.handle, pAllocateInfo, pAllocator, &handle).Check();
            }

            return new VkDeviceMemory(this, callbacks, handle);
        }

        public VkResult MapMemory(VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, UInt32 flags, out IntPtr data) {
            IntPtr ppData = new IntPtr();
            VkResult result = vkAPI.vkMapMemory(this.handle, memory != null ? memory.handle : default(UInt64), offset, size, flags, &ppData).Check();
            data = ppData;

            return result;
        }

        public void UnmapMemory(VkDeviceMemory memory) {
            vkAPI.vkUnmapMemory(this.handle, memory != null ? memory.handle : default(UInt64));
        }

        public VkResult BindBufferMemory(VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset) {
            return vkAPI.vkBindBufferMemory(this.handle, buffer != null ? buffer.handle : default(UInt64), memory != null ? memory.handle : default(UInt64), memoryOffset).Check();
        }

        public VkDescriptorSetLayout CreateDescriptorSetLayout(ref VkDescriptorSetLayoutCreateInfo createInfo,
            UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDescriptorSetLayoutCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateDescriptorSetLayout(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkDescriptorSetLayout(this, callbacks, handle);
        }

        public VkPipelineLayout CreatePipelineLayout(ref VkPipelineLayoutCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkPipelineLayoutCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreatePipelineLayout(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkPipelineLayout(this, callbacks, handle);
        }

        public VkShaderModule CreateShaderModule(ref VkShaderModuleCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkShaderModuleCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateShaderModule(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkShaderModule(this, callbacks, handle);
        }

        public VkShaderModule CreateShaderModule(byte[] shaderCode, uint flags = 0, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            var createInfo = new VkShaderModuleCreateInfo();
            {
                createInfo.SType = VkStructureType.ShaderModuleCreateInfo;
                UInt32 size = 0;
                shaderCode.Set(ref createInfo.Code, ref size); createInfo.CodeSize = (UIntPtr)size;
                createInfo.Flags = flags;
            }
            return CreateShaderModule(ref createInfo, callbacks);
        }

        public VkPipelineCache CreatePipelineCache(ref VkPipelineCacheCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkPipelineCacheCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreatePipelineCache(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkPipelineCache(this, callbacks, handle);
        }

        public VkPipeline[] CreateGraphicsPipelines(ref VkPipelineCache pipelineCache, VkGraphicsPipelineCreateInfo[] createInfos, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            int length = createInfos.Length;
            if (length <= 0) return null;

            var handles = stackalloc UInt64[length];
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkGraphicsPipelineCreateInfo* pCreateInfos = createInfos) {
                vkAPI.vkCreateGraphicsPipelines(this.handle, pipelineCache.handle, (UInt32)length, pCreateInfos, pAllocator, handles).Check();
            }

            var arr = new VkPipeline[length];
            for (int i = 0; i < length; i++) {
                arr[i] = new VkPipeline(this, callbacks, handles[i]);
            }

            return arr;
        }

        public VkDescriptorPool CreateDescriptorPool(ref VkDescriptorPoolCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDescriptorPoolCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateDescriptorPool(this.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            return new VkDescriptorPool(this, callbacks, handle);
        }

        public VkDescriptorSet[] AllocateDescriptorSets(ref VkDescriptorSetAllocateInfo allocateInfo) {
            int length = (int)allocateInfo.DescriptorSetCount;
            if (length <= 0) return null;

            var handles = stackalloc UInt64[length];
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDescriptorSetAllocateInfo* pAllocateInfo = &allocateInfo) {
                vkAPI.vkAllocateDescriptorSets(this.handle, pAllocateInfo, handles).Check();
            }

            var arr = new VkDescriptorSet[length];
            for (int i = 0; i < length; i++) {
                arr[i] = new VkDescriptorSet(this, handles[i]);
            }

            return arr;
        }
    }
}
