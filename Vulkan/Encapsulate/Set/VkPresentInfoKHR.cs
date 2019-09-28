using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPresentInfoKHRHelper {
        public static void Set(this VkSwapchainKHR value, VkPresentInfoKHR* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkSwapchainKHR[] values, VkPresentInfoKHR* info) {
            IntPtr ptr = (IntPtr)info->pSwapchains;
            values.Set(ref ptr, ref info->swapchainCount);
            info->pSwapchains = (VkSwapchainKHR*)ptr;
        }

        public static void Set(this VkSemaphore value, VkPresentInfoKHR* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkSemaphore[] values, VkPresentInfoKHR* info) {
            IntPtr ptr = (IntPtr)info->pWaitSemaphores;
            values.Set(ref ptr, ref info->waitSemaphoreCount);
            info->pWaitSemaphores = (VkSemaphore*)ptr;
        }


        public static void Set(this uint value, VkPresentInfoKHR* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this uint[] values, VkPresentInfoKHR* info) {
            IntPtr ptr = (IntPtr)info->pImageIndices;
            values.Set(ref ptr, ref info->swapchainCount);
            info->pImageIndices = (uint*)ptr;
        }
    }
}
