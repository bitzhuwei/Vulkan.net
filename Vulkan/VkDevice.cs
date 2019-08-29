using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDevice : IDisposable {
        public readonly IntPtr handle;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkDevice device) {
            if (physicalDevice == null) { throw new ArgumentNullException("physicalDevice"); }

            VkResult result = VkResult.Success;
            var handle = new IntPtr();
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDeviceCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateDevice(physicalDevice.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            device = new VkDevice(callbacks, handle);
            return result;
        }

        private VkDevice(UnmanagedArray<VkAllocationCallbacks> callbacks, IntPtr handle) {
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkDevice)}, {handle}, {callbacks}";

        public VkResult WaitIdle() {
            return vkAPI.vkDeviceWaitIdle(this.handle);
        }

        public void GetRenderAreaGranularity(VkRenderPass renderPass, out VkExtent2D pGranularity) {
            if (renderPass == null) { throw new ArgumentNullException("renderPass"); }

            fixed (VkExtent2D* pointer = &pGranularity) {
                vkAPI.vkGetRenderAreaGranularity(this.handle, renderPass.handle, pointer);
            }
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkDevice() {
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
                vkAPI.vkDestroyDevice(this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

