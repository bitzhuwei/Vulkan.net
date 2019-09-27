using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineViewportStateCreateInfoHelper {
        public static void Set(this VkViewport value, ref VkPipelineViewportStateCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkViewport[] values, ref VkPipelineViewportStateCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pViewports;
            values.Set(ref ptr, ref info.viewportCount);
            info.pViewports = (VkViewport*)ptr;
        }

        public static void Set(this VkRect2D value, ref VkPipelineViewportStateCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkRect2D[] values, ref VkPipelineViewportStateCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pScissors;
            values.Set(ref ptr, ref info.scissorCount);
            info.pScissors = (VkRect2D*)ptr;
        }
    }
}
