using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDeviceQueueCreateInfoHelper {
        public static void Set(this float value, ref VkDeviceQueueCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this float[] values, ref VkDeviceQueueCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pQueuePriorities;
            values.Set(ref ptr, ref info.queueCount);
            info.pQueuePriorities = (float*)ptr;
        }
    }
}
