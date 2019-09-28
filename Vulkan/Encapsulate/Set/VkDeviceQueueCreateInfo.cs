using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDeviceQueueCreateInfoHelper {
        public static void Set(this float value, VkDeviceQueueCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this float[] values, VkDeviceQueueCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pQueuePriorities;
            values.Set(ref ptr, ref info->queueCount);
            info->pQueuePriorities = (float*)ptr;
        }
    }
}
