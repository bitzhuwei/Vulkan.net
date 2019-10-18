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
            VkSurfaceFormatKHR[] result = null;
            {
                UInt32 count;
                vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface, &count, null);

                if (count != 0) {
                    result = new VkSurfaceFormatKHR[count];
                    fixed (VkSurfaceFormatKHR* pointer = result) {
                        vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface, &count, pointer);
                    }
                }
            }

            return result;
        }
    }
}
