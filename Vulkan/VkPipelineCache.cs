using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkPipelineCache : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkPipelineCache pipelineCache) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkPipelineCacheCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreatePipelineCache(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            pipelineCache = new VkPipelineCache(device, callbacks, handle);

            return result;
        }

        internal VkPipelineCache(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkPipelineCache)}, {handle}";

        public VkResult Merge(params VkPipelineCache[] srcCaches) {
            if (srcCaches == null || srcCaches.Length == 0) { return VkResult.Incomplete; }

            var handles = new UInt64[srcCaches.Length];
            for (int i = 0; i < handles.Length; i++) {
                handles[i] = srcCaches[i].handle;
            }

            fixed (UInt64* pointer = handles) {
                return vkAPI.vkMergePipelineCaches(this.device.handle, this.handle, (UInt32)handles.Length, pointer).Check();
            }
        }

        public VkResult GetData(out byte[] data) {
            UInt32 size;
            vkAPI.vkGetPipelineCacheData(this.device.handle, this.handle, &size, null).Check();
            data = new byte[size];
            fixed (byte* pointer = data) {
                return vkAPI.vkGetPipelineCacheData(this.device.handle, this.handle, &size, pointer).Check();
            }
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkPipelineCache() {
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
                vkAPI.vkDestroyPipelineCache(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

