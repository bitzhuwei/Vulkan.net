using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        public static VkExtensionProperties[] InstanceExtensionProperties(string layerName = null) {
            VkExtensionProperties[] result;
            IntPtr pLayerName = Marshal.StringToHGlobalAnsi(layerName);
            UInt32 count;
            vkAPI.vkEnumerateInstanceExtensionProperties(pLayerName, &count, null).Check();
            result = new VkExtensionProperties[count];
            if (count > 0) {
                fixed (VkExtensionProperties* pointer = result) {
                    vkAPI.vkEnumerateInstanceExtensionProperties(pLayerName, &count, pointer).Check();
                }
            }

            Marshal.FreeHGlobal(pLayerName);

            return result;
        }

        public static VkExtensionProperties[] DeviceExtensionProperties(this VkPhysicalDevice device, string layerName = null) {
            VkExtensionProperties[] result;
            IntPtr pLayerName = Marshal.StringToHGlobalAnsi(layerName);
            UInt32 count;
            vkAPI.vkEnumerateDeviceExtensionProperties(device, pLayerName, &count, null).Check();
            result = new VkExtensionProperties[count];
            if (count > 0) {
                fixed (VkExtensionProperties* pointer = result) {
                    vkAPI.vkEnumerateDeviceExtensionProperties(device, pLayerName, &count, pointer).Check();
                }
            }

            Marshal.FreeHGlobal(pLayerName);

            return result;
        }
    }
}
