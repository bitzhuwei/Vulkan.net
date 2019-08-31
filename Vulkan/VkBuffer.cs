using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkBuffer : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkBufferCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkBuffer vkBuffer) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkBufferCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateBuffer(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            vkBuffer = new VkBuffer(device, callbacks, handle);

            return result;
        }

        internal VkBuffer(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkBuffer)}, {handle}";

        public void GetMemoryRequirements(out VkMemoryRequirements memmoryRequirements) {
            fixed (VkMemoryRequirements* pointer = &memmoryRequirements) {
                vkAPI.vkGetBufferMemoryRequirements(this.device.handle, this.handle, pointer);
            }
        }

        public VkResult Bindmemory(VkDeviceMemory memory, VkDeviceSize memoryOffset) {
            return vkAPI.vkBindBufferMemory(this.device.handle, this.handle, memory.handle, memoryOffset).Check();
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkBuffer() {
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
                vkAPI.vkDestroyBuffer(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

