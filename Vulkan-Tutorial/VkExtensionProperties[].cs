using System;
using System.Collections.Generic;
using System.Text;
using Vulkan;

namespace Vulkan_Tutorial {
    public unsafe static partial class Tutorial {
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
