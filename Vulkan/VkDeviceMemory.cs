using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDeviceMemory : IDisposable {
        private readonly VkDevice device;
        public readonly UInt64 handle;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkMemoryAllocateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkDeviceMemory memory) {
            if (device == null) { throw new ArgumentException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkMemoryAllocateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkAllocateMemory(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            memory = new VkDeviceMemory(device, callbacks, handle);

            return result;
        }

        private VkDeviceMemory(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkDeviceMemory)}, {handle}, {callbacks}";

        public VkResult MapMemory(VkDeviceSize offset, VkDeviceSize size, uint flags, out IntPtr data) {
            fixed (IntPtr* pointer = &data) {
                return vkAPI.vkMapMemory(this.device.handle, this.handle, offset, size, flags, pointer).Check();
            }
        }

        public VkResult FlushMappedMemoryRanges(params VkMappedMemoryRange[] memoryRanges) {
            if (memoryRanges == null || memoryRanges.Length == 0) { return VkResult.Incomplete; }

            fixed (VkMappedMemoryRange* pointer = memoryRanges) {
                return vkAPI.vkFlushMappedMemoryRanges(this.device.handle, (UInt32)memoryRanges.Length, pointer).Check();
            }
        }

        public VkResult InvalidateMappedMemoryRanges(params VkMappedMemoryRange[] memoryRanges) {
            if (memoryRanges == null || memoryRanges.Length == 0) { return VkResult.Incomplete; }

            fixed (VkMappedMemoryRange* pointer = memoryRanges) {
                return vkAPI.vkInvalidateMappedMemoryRanges(this.device.handle, (UInt32)memoryRanges.Length, pointer).Check();
            }
        }

        public void UnmapMemory() {
            vkAPI.vkUnmapMemory(this.device.handle, this.handle);
        }

        public void GetCommitment(out VkDeviceSize committedMemoryInBytes) {
            fixed (VkDeviceSize* pointer = &committedMemoryInBytes) {
                vkAPI.vkGetDeviceMemoryCommitment(this.device.handle, this.handle, pointer);
            }
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkDeviceMemory() {
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
                vkAPI.vkFreeMemory(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

