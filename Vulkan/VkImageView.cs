using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkImageView : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

#if DEBUG
        public IntPtr Next;
        public UInt32 Flags;
        public UInt64 Image;
        public VkImageViewType ViewType;
        public VkFormat Format;
        public VkComponentMapping Components;
        public VkImageSubresourceRange SubresourceRange;

        internal static void Fill(VkImageView imageView, VkImageViewCreateInfo createInfo) {
            imageView.Next = createInfo.Next; imageView.Flags = createInfo.Flags;
            imageView.Image = createInfo.Image; imageView.ViewType = createInfo.ViewType;
            imageView.Format = createInfo.Format; imageView.Components = createInfo.Components;
            imageView.SubresourceRange = createInfo.SubresourceRange;
        }
#endif 

        public static VkResult Create(VkDevice device, ref VkImageViewCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkImageView imageView) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkImageViewCreateInfo* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateImageView(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            imageView = new VkImageView(device, callbacks, handle);
#if DEBUG
            VkImageView.Fill(imageView, createInfo);
#endif 
            return result;
        }

        public VkImageView(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkImageView)}, {handle}";

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkImageView() {
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
                vkAPI.vkDestroyImageView(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}
