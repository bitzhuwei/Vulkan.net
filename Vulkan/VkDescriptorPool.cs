using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDescriptorPool : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkDescriptorPool vkDescriptorPool) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDescriptorPoolCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateDescriptorPool(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            vkDescriptorPool = new VkDescriptorPool(device, callbacks, handle);

            return result;
        }

        private VkDescriptorPool(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkDescriptorPool)}, {handle}";

        public void Free(params VkDescriptorSet[] DescriptorSets) {
            if (DescriptorSets == null || DescriptorSets.Length == 0) { return; }

            var buffers = new UInt64[DescriptorSets.Length];
            for (int i = 0; i < DescriptorSets.Length; i++) {
                buffers[i] = DescriptorSets[i].handle;
            }
            fixed (UInt64* pointer = buffers) {
                vkAPI.vkFreeDescriptorSets(this.device.handle, this.handle, (UInt32)DescriptorSets.Length, pointer);
            }
        }

        public VkResult Reset(UInt32 flags) {
            return vkAPI.vkResetDescriptorPool(this.device.handle, this.handle, flags);
        }
        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkDescriptorPool() {
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
                vkAPI.vkDestroyDescriptorPool(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

