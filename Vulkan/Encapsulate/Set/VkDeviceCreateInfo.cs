using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDeviceCreateInfoHelper {
        public static void Set(this VkDeviceQueueCreateInfo value, VkDeviceCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDeviceQueueCreateInfo[] values, VkDeviceCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pQueueCreateInfos;
            values.Set(ref ptr, ref info->queueCreateInfoCount);
            info->pQueueCreateInfos = (VkDeviceQueueCreateInfo*)ptr;
        }

        public static void SetExtensions(this string[] values, VkDeviceCreateInfo* info) {
            values.Set(ref info->ppEnabledExtensionNames, ref info->enabledExtensionCount);
        }

        public static void SetLayers(this string[] values, VkDeviceCreateInfo* info) {
            values.Set(ref info->ppEnabledLayerNames, ref info->enabledLayerCount);
        }

    }
}
