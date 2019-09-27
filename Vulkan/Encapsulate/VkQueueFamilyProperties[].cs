using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class Vk {
        /// <summary>
        /// Reports properties of the queues of the specified physical device.
        /// </summary>
        /// <param name="physicalDevice"></param>
        /// <returns></returns>
        public static VkQueueFamilyProperties[] QueueFamilyProperties(this VkPhysicalDevice physicalDevice) {
            VkQueueFamilyProperties[] properties;
            {
                UInt32 count;
                vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &count, null);
                properties = new VkQueueFamilyProperties[count];
                fixed (VkQueueFamilyProperties* pointer = properties) {
                    vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &count, pointer);
                }
            }

            return properties;
        }
    }
}
