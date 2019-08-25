using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkFence : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkFenceCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkFence fence) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkFenceCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateFence(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            fence = new VkFence(device, callbacks, handle);

            return result;
        }

        private VkFence(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkFence)}, {handle}";

        public VkResult GetStatus() {
            return vkAPI.vkGetFenceStatus(this.device.handle, this.handle).Check();
        }

        public VkResult Reset() {
            UInt64 handle = this.handle;
            return vkAPI.vkResetFences(this.device.handle, 1, &handle).Check();
        }

        public static VkResult Reset(VkDevice device, params VkFence[] fences) {
            if (device == null || fences == null || fences.Length == 0) { return VkResult.Incomplete; }

            var handles = new UInt64[fences.Length];
            for (int i = 0; i < handles.Length; i++) {
                handles[i] = fences[i].handle;
            }

            fixed (UInt64* pointer = handles) {
                return vkAPI.vkResetFences(device.handle, (UInt32)handles.Length, pointer).Check();
            }
        }

        public VkResult WaitForFences(VkBool32 waitAll, UInt64 timeout, params VkFence[] fences) {
            var handles = new UInt64[fences.Length];
            for (int i = 0; i < handles.Length; i++) {
                handles[i] = fences[i].handle;
            }

            fixed (UInt64* pointer = handles) {
                return vkAPI.vkWaitForFences(this.device.handle, (UInt32)handles.Length, pointer, waitAll, timeout);
            }
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkFence() {
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
                vkAPI.vkDestroyFence(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

