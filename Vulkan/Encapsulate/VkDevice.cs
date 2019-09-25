using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDeviceHelper {
        // Command: 208
        /// <summary>vkGetDeviceQueue - Get a queue handle from a device
        /// </summary>
        /// <param name="device"> device is the logical device that owns the queue.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the index of the queue family to which the
        /// queue belongs.</param>
        /// <param name="queueIndex"> queueIndex is the index within this queue family of the queue to
        /// retrieve.</param>
        public static VkQueue GetQueue(this VkDevice device, UInt32 queueFamilyIndex, UInt32 queueIndex) {
            VkQueue queue;
            vkAPI.vkGetDeviceQueue(device, queueFamilyIndex, queueIndex, &queue);
            return queue;
        }

        // Command: 285
        /// <summary>vkGetSwapchainImagesKHR - Obtain the array of presentable images associated with a swapchain
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to query.</param>
        public static VkImage[] GetSwapchainImages(this VkDevice device, VkSwapchainKHR swapchain) {
            UInt32 count;
            vkAPI.vkGetSwapchainImagesKHR(device, swapchain, &count, null).Check();
            var vkImages = new VkImage[count];
            if (count > 0) {
                fixed (VkImage* pointer = vkImages) {
                    vkAPI.vkGetSwapchainImagesKHR(device, swapchain, &count, pointer).Check();
                }
            }

            return vkImages;
        }
    }
}
