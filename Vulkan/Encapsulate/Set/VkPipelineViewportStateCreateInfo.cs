using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineViewportStateCreateInfoHelper {
        public static void Set(this VkViewport value, VkPipelineViewportStateCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkViewport[] values, VkPipelineViewportStateCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pViewports;
            values.Set(ref ptr, ref info->viewportCount);
            info->pViewports = (VkViewport*)ptr;
        }

        public static void Set(this VkRect2D value, VkPipelineViewportStateCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkRect2D[] values, VkPipelineViewportStateCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pScissors;
            values.Set(ref ptr, ref info->scissorCount);
            info->pScissors = (VkRect2D*)ptr;
        }
    }
}
