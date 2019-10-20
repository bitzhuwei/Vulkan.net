using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        /// <summary>
        /// Returns global layer properties.
        /// </summary>
        /// <returns></returns>
        public static VkLayerProperties[] InstanceLayerProperties() {
            VkLayerProperties[] result;
            UInt32 count;
            vkAPI.vkEnumerateInstanceLayerProperties(&count, null).Check();
            result = new VkLayerProperties[count];
            if (count > 0) {
                fixed (VkLayerProperties* pointer = result) {
                    vkAPI.vkEnumerateInstanceLayerProperties(&count, pointer).Check();
                }
            }

            return result;
        }
    }
}
