using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        /// <summary>
        /// Reports properties of the queues of the specified physical device.
        /// </summary>
        /// <param name="physicalDevice"></param>
        /// <returns></returns>
        public static VkQueueFamilyProperties[] QueueFamilyProperties(this VkPhysicalDevice physicalDevice) {
            VkQueueFamilyProperties[] result;
            UInt32 count;
            vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &count, null);
            result = new VkQueueFamilyProperties[count];
            if (count > 0) {
                fixed (VkQueueFamilyProperties* pointer = result) {
                    vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &count, pointer);
                }
            }

            return result;
        }
    }
}
