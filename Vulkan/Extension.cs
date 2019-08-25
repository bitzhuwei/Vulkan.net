using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class Extension {
        private Extension() { }

        public static VkResult EnumerateInstanceExtensionProperties(string layerName, out VkExtensionProperties[] layerProperties) {
            UInt32 count;
            VkResult result = vkAPI.vkEnumerateInstanceExtensionProperties(layerName, &count, null).Check();
            layerProperties = new VkExtensionProperties[count];
            fixed (VkExtensionProperties* pointer = layerProperties) {
                result = vkAPI.vkEnumerateInstanceExtensionProperties(layerName, &count, pointer).Check();
            }

            return result;
        }
    }
}

