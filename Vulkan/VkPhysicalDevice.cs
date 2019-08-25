using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkPhysicalDevice {
        public readonly IntPtr handle;

        public static VkResult Enumerate(VkInstance instance, out VkPhysicalDevice[] physicalDevices) {
            if (instance == null) { physicalDevices = null; return VkResult.Incomplete; }

            UInt32 count;
            VkResult result = vkAPI.vkEnumeratePhysicalDevices(instance.handle, &count, null).Check();
            var handles = new IntPtr[count];
            if (count > 0) {
                fixed (IntPtr* pointer = handles) {
                    result = vkAPI.vkEnumeratePhysicalDevices(instance.handle, &count, pointer).Check();
                }
            }

            physicalDevices = new VkPhysicalDevice[count];
            for (int i = 0; i < count; i++) {
                physicalDevices[i] = new VkPhysicalDevice(handles[i]);
            }

            return result;
        }

        private VkPhysicalDevice(IntPtr handle) {
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkPhysicalDevice)}, {handle}";

        public VkQueueFamilyProperties[] GetQueueFamilyProperties() {
            UInt32 count;
            vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &count, null);
            var result = new VkQueueFamilyProperties[count];
            if (count > 0) {
                fixed (VkQueueFamilyProperties* pointer = result) {
                    vkAPI.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &count, pointer);
                }
            }

            return result;
        }
    }
}

