using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        /// <summary>
        /// </summary>
        /// <param name="device"></param>
        /// <param name="surface"></param>
        /// <returns></returns>
        public static VkSurfaceFormatKHR[] Formats(this VkPhysicalDevice device, VkSurfaceKHR surface) {
            VkSurfaceFormatKHR[] result;
            UInt32 count;
            vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface, &count, null);
            result = new VkSurfaceFormatKHR[count];
            if (count != 0) {
                fixed (VkSurfaceFormatKHR* pointer = result) {
                    vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface, &count, pointer);
                }
            }

            return result;
        }
    }
}
