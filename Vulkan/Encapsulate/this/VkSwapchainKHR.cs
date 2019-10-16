using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkSwapchainKHR {
        // Command: 285
        /// <summary>vkGetSwapchainImagesKHR - Obtain the array of presentable images associated with a swapchain
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        public VkImage[] GetImages(VkDevice device) {
            UInt32 count;
            vkAPI.vkGetSwapchainImagesKHR(device, this, &count, null).Check();
            var vkImages = new VkImage[count];
            if (count > 0) {
                fixed (VkImage* pointer = vkImages) {
                    vkAPI.vkGetSwapchainImagesKHR(device, this, &count, pointer).Check();
                }
            }

            return vkImages;
        }
    }
}
