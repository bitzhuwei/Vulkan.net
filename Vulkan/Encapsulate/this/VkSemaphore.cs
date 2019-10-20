using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDevice {
        // Command: 136
        /// <summary>vkCreateSemaphore - Create a new queue semaphore object
        /// </summary>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkSemaphoreCreateInfo structure which contains information about
        /// how the semaphore is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        public VkSemaphore CreateSemaphore(VkSemaphoreCreateInfo* pCreateInfo = null, VkAllocationCallbacks* pAllocator = null) {
            VkSemaphore semaphore;
            if (pCreateInfo == null) {
                var info = new VkSemaphoreCreateInfo { sType = VkStructureType.SemaphoreCreateInfo };
                pCreateInfo = &info;
            }

            vkAPI.vkCreateSemaphore(this, pCreateInfo, pAllocator, &semaphore);

            return semaphore;
        }
    }
}
