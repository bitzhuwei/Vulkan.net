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

        private void CreateLogicalDevice() {
            QueueFamilyIndices indices = findQueueFamilies(physicalDevice);

            var queueCreateInfo = VkDeviceQueueCreateInfo.Alloc();
            queueCreateInfo[0].queueFamilyIndex = indices.graphicsFamily.Value;
            queueCreateInfo[0].queueCount = 1;

            float queuePriority = 1.0f;
            queueCreateInfo[0].pQueuePriorities = &queuePriority;

            var deviceFeatures = VkPhysicalDeviceFeatures.Alloc();

            var createInfo = VkDeviceCreateInfo.Alloc();
            createInfo[0].pQueueCreateInfos = queueCreateInfo;
            createInfo[0].queueCreateInfoCount = 1;

            createInfo[0].pEnabledFeatures = deviceFeatures;

            //createInfo[0].enabledExtensionCount = 0;

            if (enableValidationLayers) {
                //validationLayers.Set(ref createInfo[0].ppEnabledLayerNames, ref createInfo[0].enabledLayerCount);
                createInfo[0].EnabledLayers = validationLayers;
            }

            VkDevice device;
            vkCreateDevice(physicalDevice, createInfo, null, &device).Check();
            this.device = device;

            VkQueue queue;
            vkGetDeviceQueue(device, indices.graphicsFamily.Value, 0, &queue);
            this.graphicsQueue = queue;
        }

    }
}
