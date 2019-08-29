using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class SwapchainCreateInfoKhr : IDisposable {
        internal readonly VkSwapchainCreateInfoKhr* info;
        private readonly UnmanagedArray<VkSwapchainCreateInfoKhr> disposable;

        public SwapchainCreateInfoKhr() {
            var disposable = new UnmanagedArray<VkSwapchainCreateInfoKhr>(1);
            var info = (VkSwapchainCreateInfoKhr*)disposable.header;
            info->SType = VkStructureType.SwapchainCreateInfoKhr;
            this.info = info;
            this.disposable = disposable;
        }

        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public VkSwapchainCreateFlagsKhr Flags { get { return info->Flags; } set { info->Flags = value; } }
        public UInt64 Surface { get { return info->Surface; } set { info->Surface = value; } }
        public UInt32 MinImageCount { get { return info->MinImageCount; } set { info->MinImageCount = value; } }
        public VkFormat ImageFormat { get { return info->ImageFormat; } set { info->ImageFormat = value; } }
        public VkColorSpaceKhr ImageColorSpace { get { return info->ImageColorSpace; } set { info->ImageColorSpace = value; } }
        public VkExtent2D ImageExtent { get { return info->ImageExtent; } set { info->ImageExtent = value; } }
        public UInt32 ImageArrayLayers { get { return info->ImageArrayLayers; } set { info->ImageArrayLayers = value; } }
        public VkImageUsageFlags ImageUsage { get { return info->ImageUsage; } set { info->ImageUsage = value; } }
        public VkSharingMode ImageSharingMode { get { return info->ImageSharingMode; } set { info->ImageSharingMode = value; } }
        public UInt32 QueueFamilyIndexCount { get { return info->QueueFamilyIndexCount; } }
        public UInt32[] QueueFamilyIndices {
            get { return Helper.Get<UInt32>(info->QueueFamilyIndices, info->QueueFamilyIndexCount); }
            set { Helper.Set(value, ref info->QueueFamilyIndices, ref info->QueueFamilyIndexCount); }
        }
        public VkSurfaceTransformFlagsKhr PreTransform { get { return info->PreTransform; } set { info->PreTransform = value; } }
        public VkCompositeAlphaFlagsKhr CompositeAlpha { get { return info->CompositeAlpha; } set { info->CompositeAlpha = value; } }
        public VkPresentModeKhr PresentMode { get { return info->PresentMode; } set { info->PresentMode = value; } }
        public VkBool32 Clipped { get { return info->Clipped; } set { info->Clipped = value; } }
        public UInt64 OldSwapchain { get { return info->OldSwapchain; } set { info->OldSwapchain = value; } }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        } // end sub

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~SwapchainCreateInfoKhr() {
            this.Dispose(false);
        }

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
                }

                // Dispose unmanaged resources.
                //Helper.DisposeStructs(ref info->QueueFamilyIndices, ref info->QueueFamilyIndexCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
