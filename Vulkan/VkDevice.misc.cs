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
    }
}

