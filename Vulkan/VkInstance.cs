using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkInstance : IDisposable {
        public readonly IntPtr handle;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(ref VkInstanceCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkInstance instance) {
            VkResult result = VkResult.Success;
            var handle = new IntPtr();
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkInstanceCreateInfo* pCreateInfo = &createInfo) {
                vkAPI.vkCreateInstance(pCreateInfo, pAllocator, &handle).Check();
            }

            instance = new VkInstance(callbacks, handle);

            return result;
        }

        private VkInstance(UnmanagedArray<VkAllocationCallbacks> callbacks, IntPtr handle) {
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkInstance)}, {handle}, {callbacks}";

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkInstance() {
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
                vkAPI.vkDestroyInstance(this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

