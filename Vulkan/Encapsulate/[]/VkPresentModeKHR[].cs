using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        /// <summary>
        /// Returns global layer properties.
        /// </summary>
        /// <returns></returns>
        public static VkPresentModeKHR[] PresentModesKHR(VkPhysicalDevice device, VkSurfaceKHR surface) {
            VkPresentModeKHR[] result;
            UInt32 count;
            vkGetPhysicalDeviceSurfacePresentModesKHR(device, surface, &count, null);
            result = new VkPresentModeKHR[count];
            if (count > 0) {
                fixed (VkPresentModeKHR* pointer = result) {
                    vkGetPhysicalDeviceSurfacePresentModesKHR(device, surface, &count, pointer);
                }
            }

            return result;
        }
    }
}
