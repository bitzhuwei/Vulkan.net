using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkSubmitInfoHelper {

        public static void SetWaitSemaphores(this VkSemaphore value, VkSubmitInfo* info) {
            new[] { value }.SetWaitSemaphores(info);
        }

        public static void SetWaitSemaphores(this VkSemaphore[] values, VkSubmitInfo* info) {
            IntPtr ptr = (IntPtr)info->pWaitSemaphores;
            values.Set(ref ptr, ref info->waitSemaphoreCount);
            info->pWaitSemaphores = (VkSemaphore*)ptr;
        }

        public static void Set(this VkPipelineStageFlagBits value, VkSubmitInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkPipelineStageFlagBits[] values, VkSubmitInfo* info) {
            IntPtr ptr = (IntPtr)info->pWaitDstStageMask;
            values.Set(ref ptr, ref info->waitSemaphoreCount);
            info->pWaitDstStageMask = (VkPipelineStageFlagBits*)ptr;
        }

        public static void Set(this VkCommandBuffer value, VkSubmitInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkCommandBuffer[] values, VkSubmitInfo* info) {
            IntPtr ptr = (IntPtr)info->pCommandBuffers;
            values.Set(ref ptr, ref info->commandBufferCount);
            info->pCommandBuffers = (VkCommandBuffer*)ptr;
        }

        public static void SetSignalSemaphores(this VkSemaphore value, VkSubmitInfo* info) {
            new[] { value }.SetSignalSemaphores(info);
        }

        public static void SetSignalSemaphores(this VkSemaphore[] values, VkSubmitInfo* info) {
            IntPtr ptr = (IntPtr)info->pSignalSemaphores;
            values.Set(ref ptr, ref info->signalSemaphoreCount);
            info->pSignalSemaphores = (VkSemaphore*)ptr;
        }
    }
}
