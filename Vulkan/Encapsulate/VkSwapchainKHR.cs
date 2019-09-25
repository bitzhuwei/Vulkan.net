using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkSwapchainKHRHelper {

        // Command: 285
        /// <summary>vkGetSwapchainImagesKHR - Obtain the array of presentable images associated with a swapchain
        /// </summary>
        /// <param name="swapchain"> swapchain is the swapchain to query.</param>
        /// <param name="device"> device is the device associated with swapchain.</param>
        public static VkImage[] GetImages(this VkSwapchainKHR swapchain, VkDevice device) {
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
