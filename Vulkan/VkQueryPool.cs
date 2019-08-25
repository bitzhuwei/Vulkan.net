using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkQueryPool : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkQueryPoolCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkQueryPool vkQueryPool) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkQueryPoolCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateQueryPool(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            vkQueryPool = new VkQueryPool(device, callbacks, handle);

            return result;
        }

        private VkQueryPool(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkQueryPool)}, {handle}";

        public void CmdResetQueryPool(UInt32 firstQuery, UInt32 queryCount) {
            vkAPI.vkCmdResetQueryPool(this.device.handle, this.handle, firstQuery, queryCount);
        }

        public void CmdBeginQuery(UInt32 entry, VkQueryControlFlags flags) {
            vkAPI.vkCmdBeginQuery(this.device.handle, this.handle, entry, flags);
        }

        public void CmdEndQuery(UInt32 query) {
            vkAPI.vkCmdEndQuery(this.device.handle, this.handle, query);
        }

        public VkResult GetResults(UInt32 firstQuery, UInt32 queryCount, UIntPtr dataSize, IntPtr data, VkDeviceSize stride, VkQueryResultFlags flags) {
            return vkAPI.vkGetQueryPoolResults(this.device.handle, this.handle, firstQuery, queryCount, dataSize, data, stride, flags).Check();
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkQueryPool() {
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
                vkAPI.vkDestroyQueryPool(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

