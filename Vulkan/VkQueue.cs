using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkQueue {
        public readonly IntPtr handle;
        public readonly UInt32 queueFamilyIndex;
        public readonly UInt32 queueIndex;

        public static VkQueue Create(VkDevice device, UInt32 queueFamilyIndex, UInt32 queueIndex) {
            if (device == null) { throw new ArgumentNullException("device"); }

            var handle = new IntPtr();
            vkAPI.vkGetDeviceQueue(device.handle, queueFamilyIndex, queueIndex, &handle);

            return new VkQueue(queueFamilyIndex, queueIndex, handle);
        }

        private VkQueue(UInt32 queueFamilyIndex, UInt32 queueIndex, IntPtr handle) {
            this.queueFamilyIndex = queueFamilyIndex;
            this.queueIndex = queueIndex;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkQueue)}, {handle}, {queueFamilyIndex}:{queueIndex}";

        public VkResult WaitIdle() {
            return vkAPI.vkQueueWaitIdle(this.handle);
        }

        public VkResult Submit(VkSubmitInfo[] submits, VkFence fence) {
            if (submits == null || submits.Length == 0) { return VkResult.Incomplete; }

            fixed (VkSubmitInfo* pointer = submits) {
                return vkAPI.vkQueueSubmit(this.handle, (UInt32)submits.Length, pointer, fence.handle).Check();
            }
        }

        public void Submit(ref VkSubmitInfo submit, VkFence fence = null) {
            fixed (VkSubmitInfo* pSubmit = &submit) {
                vkAPI.vkQueueSubmit(this.handle, (UInt32)(pSubmit != null ? 1 : 0), pSubmit, fence != null ? fence.handle : default(UInt64));
            }
        }

        public void PresentKHR(ref VkPresentInfoKhr presentInfo) {
            fixed (VkPresentInfoKhr* pPresentInfo = &presentInfo) {
                vkAPI.vkQueuePresentKHR(this.handle, pPresentInfo).Check();
            }
        }

        public VkResult BindSparse(VkBindSparseInfo[] bindInfos, VkFence fence) {
            fixed (VkBindSparseInfo* pointer = bindInfos) {
                return vkAPI.vkQueueBindSparse(this.handle, (UInt32)bindInfos.Length, pointer, fence.handle).Check();
            }
        }

        public VkResult PresentKhr(ref VkPresentInfoKhr presentInfo) {
            fixed (VkPresentInfoKhr* pointer = &presentInfo) {
                return vkAPI.vkQueuePresentKHR(this.handle, pointer);
            }
        }
    }
}

