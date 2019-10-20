using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        /// <summary>
        /// Returns global layer properties.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static VkPhysicalDevice[] PhysicalDevices(this VkInstance instance) {
            VkPhysicalDevice[] result;
            UInt32 count;
            vkAPI.vkEnumeratePhysicalDevices(instance, &count, null).Check();
            result = new VkPhysicalDevice[count];
            if (count > 0) {
                fixed (VkPhysicalDevice* pointer = result) {
                    vkAPI.vkEnumeratePhysicalDevices(instance, &count, pointer).Check();
                }
            }

            return result;
        }
    }
}
