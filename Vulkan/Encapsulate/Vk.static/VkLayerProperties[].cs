using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class Vk {
        /// <summary>
        /// Returns global layer properties.
        /// </summary>
        /// <returns></returns>
        public static VkLayerProperties[] InstanceLayerProperties() {
            VkLayerProperties[] layerProperties;
            UInt32 count;
            vkAPI.vkEnumerateInstanceLayerProperties(&count, null).Check();
            layerProperties = new VkLayerProperties[count];
            if (count > 0) {
                fixed (VkLayerProperties* pointer = layerProperties) {
                    vkAPI.vkEnumerateInstanceLayerProperties(&count, pointer).Check();
                }
            }

            return layerProperties;
        }
    }
}
