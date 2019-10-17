using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;

namespace Vulkan_Tutorial {
    unsafe partial class Renderer {
        struct QueueFamilyIndices {
            public UInt32? graphicsFamily;
            public UInt32? presentFamily;

            public bool isComplete() {
                return graphicsFamily.HasValue && presentFamily.HasValue;
            }
        }

        private void PickPhysicalDevice() {
            VkPhysicalDevice[] devices = vkAPI.PhysicalDevices(instance);
            foreach (var device in devices) {
                if (isDeviceSuitable(device)) {
                    physicalDevice = device;
                    break;
                }
            }

            if (physicalDevice == 0u) {
                throw new Exception("failed to find a suitable GPU!");
            }
        }


        bool isDeviceSuitable(VkPhysicalDevice device) {
            QueueFamilyIndices indices = findQueueFamilies(device);

            return indices.isComplete();
        }

        QueueFamilyIndices findQueueFamilies(VkPhysicalDevice device) {
            var indices = new QueueFamilyIndices();

            UInt32 queueFamilyCount = 0;
            vkGetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, null);

            var queueFamilies = new VkQueueFamilyProperties[queueFamilyCount];
            fixed (VkQueueFamilyProperties* pointer = queueFamilies) {
                vkGetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, pointer);
            }

            uint i = 0;
            foreach (var queueFamily in queueFamilies) {
                if (queueFamily.queueCount > 0 && queueFamily.queueFlags.HasFlag(VkQueueFlagBits.Graphics)) {
                    indices.graphicsFamily = i;
                }

                if (indices.isComplete()) {
                    break;
                }

                i++;
            }

            return indices;
        }

    }
}
