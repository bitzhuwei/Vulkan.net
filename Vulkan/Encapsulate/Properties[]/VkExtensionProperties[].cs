using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        /// <summary>
        /// Returns global layer properties.
        /// </summary>
        /// <returns></returns>
        public static VkExtensionProperties[] InstanceExtensionProperties() {
            VkExtensionProperties[] layerProperties;
            UInt32 count;
            vkAPI.vkEnumerateInstanceExtensionProperties(IntPtr.Zero, &count, null).Check();
            layerProperties = new VkExtensionProperties[count];
            if (count > 0) {
                fixed (VkExtensionProperties* pointer = layerProperties) {
                    vkAPI.vkEnumerateInstanceExtensionProperties(IntPtr.Zero, &count, pointer).Check();
                }
            }

            return layerProperties;
        }
    }
}
