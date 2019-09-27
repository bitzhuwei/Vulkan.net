using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDeviceCreateInfoHelper {
        public static void Set(this VkDeviceQueueCreateInfo value, ref VkDeviceCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDeviceQueueCreateInfo[] values, ref VkDeviceCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pQueueCreateInfos;
            values.Set(ref ptr, ref info.queueCreateInfoCount);
            info.pQueueCreateInfos = (VkDeviceQueueCreateInfo*)ptr;
        }

        public static void SetExtensions(this string[] values, ref VkDeviceCreateInfo info) {
            values.Set(ref info.ppEnabledExtensionNames, ref info.enabledExtensionCount);
        }

        public static void SetLayers(this string[] values, ref VkDeviceCreateInfo info) {
            values.Set(ref info.ppEnabledLayerNames, ref info.enabledLayerCount);
        }

    }
}
