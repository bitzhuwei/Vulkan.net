using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPresentInfoKHRHelper {
        public static void Set(this VkSwapchainKHR value, ref VkPresentInfoKHR info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkSwapchainKHR[] values, ref VkPresentInfoKHR info) {
            IntPtr ptr = (IntPtr)info.pSwapchains;
            values.Set(ref ptr, ref info.swapchainCount);
            info.pSwapchains = (VkSwapchainKHR*)ptr;
        }

        public static void Set(this VkSemaphore value, ref VkPresentInfoKHR info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkSemaphore[] values, ref VkPresentInfoKHR info) {
            IntPtr ptr = (IntPtr)info.pWaitSemaphores;
            values.Set(ref ptr, ref info.waitSemaphoreCount);
            info.pWaitSemaphores = (VkSemaphore*)ptr;
        }


        public static void Set(this uint value, ref VkPresentInfoKHR info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this uint[] values, ref VkPresentInfoKHR info) {
            IntPtr ptr = (IntPtr)info.pImageIndices;
            values.Set(ref ptr, ref info.swapchainCount);
            info.pImageIndices = (uint*)ptr;
        }
    }
}
