using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkRenderPassBeginInfoHelper {
        public static void Set(this VkClearValue value, ref VkRenderPassBeginInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkClearValue[] values, ref VkRenderPassBeginInfo info) {
            IntPtr ptr = (IntPtr)info.pClearValues;
            values.Set(ref ptr, ref info.clearValueCount);
            info.pClearValues = (VkClearValue*)ptr;
        }
    }
}
