using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineDynamicStateCreateInfoHelper {
        public static void Set(this VkDynamicState value, ref VkPipelineDynamicStateCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDynamicState[] values, ref VkPipelineDynamicStateCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pDynamicStates;
            values.Set(ref ptr, ref info.dynamicStateCount);
            info.pDynamicStates = (VkDynamicState*)ptr;
        }
    }
}
