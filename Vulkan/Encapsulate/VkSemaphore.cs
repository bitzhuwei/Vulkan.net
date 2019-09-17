using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkSemaphoreHelper {

        // Command: 136
        /// <summary>vkCreateSemaphore - Create a new queue semaphore object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the semaphore.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkSemaphoreCreateInfo structure which contains information about
        /// how the semaphore is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        public static VkSemaphore CreateSemaphore(this VkDevice device, VkSemaphoreCreateInfo* pCreateInfo = null, VkAllocationCallbacks* pAllocator = null) {
            VkSemaphore semaphore;
            if (pCreateInfo == null) {
                var info = new VkSemaphoreCreateInfo { sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO };
                pCreateInfo = &info;
            }

            vkAPI.vkCreateSemaphore(device, pCreateInfo, pAllocator, &semaphore);

            return semaphore;
        }
    }
}
