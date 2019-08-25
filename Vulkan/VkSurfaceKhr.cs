using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkSurfaceKhr {
        public readonly VkInstance instance;
        public readonly UInt64 handle;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkInstance instance, ref VkDisplaySurfaceCreateInfoKhr createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkSurfaceKhr SurfaceKhr) {
            if (instance == null) { throw new ArgumentNullException("instance"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDisplaySurfaceCreateInfoKhr* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateDisplayPlaneSurfaceKHR(instance.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            SurfaceKhr = new VkSurfaceKhr(instance, callbacks, handle);
            return result;
        }

        private VkSurfaceKhr(VkInstance instance, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.instance = instance;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkSurfaceKhr)}, {handle}, {callbacks}";

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkSurfaceKhr() {
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
                vkAPI.vkDestroySurfaceKHR(this.instance.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

