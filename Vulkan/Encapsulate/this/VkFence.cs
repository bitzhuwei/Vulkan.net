using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDevice {
        // Command: 116
        /// <summary>vkCreateFence - Create a new fence object
        /// </summary>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkFenceCreateInfo structure which contains information about how
        /// the fence is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        public VkFence CreateFence(VkFenceCreateInfo* pCreateInfo = null, VkAllocationCallbacks* pAllocator = null) {
            VkFence fence;
            if (pCreateInfo == null) {
                var info = new VkFenceCreateInfo { sType = VkStructureType.FenceCreateInfo };
                pCreateInfo = &info;
            }

            vkAPI.vkCreateFence(this, pCreateInfo, pAllocator, &fence);

            return fence;
        }
    }
}
