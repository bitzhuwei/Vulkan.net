using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineDynamicStateCreateInfoHelper {
        public static void Set(this VkDynamicState value, VkPipelineDynamicStateCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDynamicState[] values, VkPipelineDynamicStateCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pDynamicStates;
            values.Set(ref ptr, ref info->dynamicStateCount);
            info->pDynamicStates = (VkDynamicState*)ptr;
        }
    }
}
