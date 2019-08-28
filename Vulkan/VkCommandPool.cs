using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkCommandPool : IDisposable {
        public readonly VkDevice device;
        public readonly UInt64 handle;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkCommandPoolCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkCommandPool commandPool) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkCommandPoolCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateCommandPool(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            commandPool = new VkCommandPool(device, callbacks, handle);

            return result;
        }

        public VkCommandPool(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkCommandPool)}, {handle}, {callbacks}";

        public void Reset(VkCommandPoolResetFlags flags) {
            vkAPI.vkResetCommandPool(this.device.handle, this.handle, flags);
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkCommandPool() {
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
                VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
                vkAPI.vkDestroyCommandPool(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

