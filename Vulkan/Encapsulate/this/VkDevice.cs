using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDevice {
        // Command: 208
        /// <summary>vkGetDeviceQueue - Get a queue handle from a device
        /// </summary>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the index of the queue family to which the
        /// queue belongs.</param>
        /// <param name="queueIndex"> queueIndex is the index within this queue family of the queue to
        /// retrieve.</param>
        public VkQueue GetQueue(UInt32 queueFamilyIndex, UInt32 queueIndex) {
            VkQueue queue;
            vkAPI.vkGetDeviceQueue(this, queueFamilyIndex, queueIndex, &queue);
            return queue;
        }

        // Command: 285
        /// <summary>vkGetSwapchainImagesKHR - Obtain the array of presentable images associated with a swapchain
        /// </summary>
        /// <param name="swapchain"> swapchain is the swapchain to query.</param>
        public VkImage[] GetSwapchainImages(VkSwapchainKHR swapchain) {
            UInt32 count;
            vkAPI.vkGetSwapchainImagesKHR(this, swapchain, &count, null).Check();
            var vkImages = new VkImage[count];
            if (count > 0) {
                fixed (VkImage* pointer = vkImages) {
                    vkAPI.vkGetSwapchainImagesKHR(this, swapchain, &count, pointer).Check();
                }
            }

            return vkImages;
        }
    }
}
