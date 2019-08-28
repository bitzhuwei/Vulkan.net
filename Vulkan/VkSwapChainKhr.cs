using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkSwapchainKhr : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkSwapchainCreateInfoKhr createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkSwapchainKhr swapchainKhr) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkSwapchainCreateInfoKhr* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateSwapchainKHR(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            swapchainKhr = new VkSwapchainKhr(device, callbacks, handle);

            return result;
        }

        public static VkResult CreateShared(VkDevice device, ref VkSwapchainCreateInfoKhr[] createInfos, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkSwapchainKhr[] swapchainKhrs) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            var handles = new UInt64[createInfos.Length];
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkSwapchainCreateInfoKhr* pCreateInfos = createInfos) {
                fixed (UInt64* pointer = handles)
                    result = vkAPI.vkCreateSharedSwapchainsKHR(device.handle, (UInt32)createInfos.Length, pCreateInfos, pAllocator, pointer).Check();
            }

            swapchainKhrs = new VkSwapchainKhr[handles.Length];
            for (int i = 0; i < handles.Length; i++) {
                swapchainKhrs[i] = new VkSwapchainKhr(device, callbacks, handles[i]);
            }

            return result;
        }

        internal VkSwapchainKhr(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkSwapchainKhr)}, {handle}";

        public VkResult GetImagesKhr(out VkImage[] swapchainImages) {
            UInt32 count;
            VkResult result = vkAPI.vkGetSwapchainImagesKHR(this.device.handle, this.handle, &count, null).Check();
            var handles = new UInt64[count];
            if (count > 0) {
                fixed (UInt64* pointer = handles) {
                    result = vkAPI.vkGetSwapchainImagesKHR(this.device.handle, this.handle, &count, pointer).Check();
                }
            }

            swapchainImages = new VkImage[count];
            for (int i = 0; i < count; i++) {
                swapchainImages[i] = new VkImage(this.device, null, handles[i]);
            }

            return result;
        }

        public VkResult AcquireNextImageKhr(UInt64 timeout, VkSemaphore semaphore, VkFence fence, out UInt32 imageIndex) {
            fixed (UInt32* pointer = &imageIndex) {
                return vkAPI.vkAcquireNextImageKHR(this.device.handle, this.handle, timeout, semaphore.handle, fence.handle, pointer);
            }
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkSwapchainKhr() {
            this.Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        } // end sub

        /// <summary>
        /// Backing field to track whether Dispose has been called.
        /// </summary>
        private bool disposedValue = false;

        /// <summary>
        /// Dispose managed and unmanaged resources of this instance.
        /// </summary>
        /// <param name="disposing">If disposing equals true, managed and unmanaged resources can be disposed. If disposing equals false, only unmanaged resources can be disposed. </param>
        private void Dispose(bool disposing) {
            if (this.disposedValue == false) {
                if (disposing) {
                    // Dispose managed resources.
                    //DisposeManagedResources();
                }

                // Dispose unmanaged resources.
                //VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
                //vkAPI.vkDestroySwapchainKHR(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

