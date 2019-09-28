using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkRenderPassBeginInfoHelper {
        public static void Set(this VkClearValue value, VkRenderPassBeginInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkClearValue[] values, VkRenderPassBeginInfo* info) {
            IntPtr ptr = (IntPtr)info->pClearValues;
            values.Set(ref ptr, ref info->clearValueCount);
            info->pClearValues = (VkClearValue*)ptr;
        }
    }
}
