using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDeviceCreateInfoHelper {
        public static void Set(this VkDeviceQueueCreateInfo value, ref VkDeviceCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDeviceQueueCreateInfo[] values, ref VkDeviceCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pQueueCreateInfos;
            values.Set(ref ptr, ref info.queueCreateInfoCount);
            info.pQueueCreateInfos = (VkDeviceQueueCreateInfo*)ptr;
        }
        //public static void Set(this VkSemaphore value, ref VkSubmitInfo info) {
        //    new[] { value }.SetWaitSemaphores(ref info);
        //}

        //public static void Set(this VkSemaphore[] values, ref VkSubmitInfo info) {
        //    IntPtr ptr = (IntPtr)info.pWaitSemaphores;
        //    values.Set(ref ptr, ref info.waitSemaphoreCount);
        //    info.pWaitSemaphores = (VkSemaphore*)ptr;
        //}
    }
}
