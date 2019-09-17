using System;
using System.Collections.Generic;
using System.Text;

namespace ApiSpec.Generated {
    public unsafe static class VkFenceHelper {

        // Command: 116
        /// <summary>vkCreateFence - Create a new fence object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the fence.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkFenceCreateInfo structure which contains information about how
        /// the fence is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        public static VkFence CreateFence(this VkDevice device, VkFenceCreateInfo* pCreateInfo = null, VkAllocationCallbacks* pAllocator = null) {
            VkFence fence;
            if (pCreateInfo == null) {
                var info = new VkFenceCreateInfo { sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO };
                pCreateInfo = &info;
            }

            vkAPI.vkCreateFence(device, pCreateInfo, pAllocator, &fence);

            return fence;
        }
    }
}
