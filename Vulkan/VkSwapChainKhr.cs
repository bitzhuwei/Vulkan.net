using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkSwapchainKhr : IDisposable {
        public readonly UInt64 handle;
        private VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

#if DEBUG
        public IntPtr Next;
        public VkSwapchainCreateFlagsKhr Flags;
        public UInt64 Surface;
        public UInt32 MinImageCount;
        public VkFormat ImageFormat;
        public VkColorSpaceKhr ImageColorSpace;
        public VkExtent2D ImageExtent;
        public UInt32 ImageArrayLayers;
        public VkImageUsageFlags ImageUsage;
        public VkSharingMode ImageSharingMode;
        public UInt32[] QueueFamilyIndices;
        public VkSurfaceTransformFlagsKhr PreTransform;
        public VkCompositeAlphaFlagsKhr CompositeAlpha;
        public VkPresentModeKhr PresentMode;
        public VkBool32 Clipped;
        public UInt64 OldSwapchain;

        internal static void Fill(VkSwapchainKhr swapchain, ref VkSwapchainCreateInfoKhr createInfo) {
            swapchain.Next = createInfo.Next; swapchain.Flags = createInfo.Flags; swapchain.Surface = createInfo.Surface;
            swapchain.MinImageCount = createInfo.MinImageCount; swapchain.ImageFormat = createInfo.ImageFormat;
            swapchain.ImageColorSpace = createInfo.ImageColorSpace; swapchain.ImageExtent = createInfo.ImageExtent;
            swapchain.ImageArrayLayers = createInfo.ImageArrayLayers; swapchain.ImageUsage = createInfo.ImageUsage;
            swapchain.ImageSharingMode = createInfo.ImageSharingMode;
            swapchain.QueueFamilyIndices = Helper.Get<UInt32>(createInfo.QueueFamilyIndices, createInfo.QueueFamilyIndexCount);
            swapchain.PreTransform = createInfo.PreTransform; swapchain.CompositeAlpha = createInfo.CompositeAlpha;
            swapchain.PresentMode = createInfo.PresentMode; swapchain.Clipped = createInfo.Clipped;
            swapchain.OldSwapchain = createInfo.OldSwapchain;
        }
#endif

        public static VkResult Create(VkDevice device, ref VkSwapchainCreateInfoKhr createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkSwapchainKhr swapchain) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkSwapchainCreateInfoKhr* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateSwapchainKHR(device.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            swapchain = new VkSwapchainKhr(device, callbacks, handle);
#if DEBUG
            Fill(swapchain, ref createInfo);
#endif
            return result;
        }

        public static VkResult CreateShared(VkDevice device, ref VkSwapchainCreateInfoKhr[] createInfos, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkSwapchainKhr[] swapchains) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            var handles = new UInt64[createInfos.Length];
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkSwapchainCreateInfoKhr* pCreateInfos = createInfos) {
                fixed (UInt64* pointer = handles)
                    result = vkAPI.vkCreateSharedSwapchainsKHR(device.handle, (UInt32)createInfos.Length, pCreateInfos, pAllocator, pointer).Check();
            }

            swapchains = new VkSwapchainKhr[handles.Length];
            for (int i = 0; i < handles.Length; i++) {
                swapchains[i] = new VkSwapchainKhr(device, callbacks, handles[i]);
#if DEBUG
                Fill(swapchains[i], ref createInfos[i]);
#endif
            }

            return result;
        }

        internal VkSwapchainKhr(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkSwapchainKhr)}, {handle}";

        public VkResult GetImagesKhr(out VkImage[] swapchainImages) {
            UInt32 count;
            VkResult result = vkAPI.vkGetSwapchainImagesKHR(this.device.handle, this.handle, &count, null).Check();
            var handles = new UInt64[count];
            if (count > 0) {
                fixed (UInt64* pointer = handles) {
                    result = vkAPI.vkGetSwapchainImagesKHR(this.device.handle, this.handle, &count, pointer).Check();
                }
            }

            swapchainImages = new VkImage[count];
            for (int i = 0; i < count; i++) {
                swapchainImages[i] = new VkImage(this.device, null, handles[i]);
            }

            return result;
        }

        public VkResult AcquireNextImageKhr(UInt64 timeout, VkSemaphore semaphore, VkFence fence, out UInt32 imageIndex) {
            fixed (UInt32* pointer = &imageIndex) {
                return vkAPI.vkAcquireNextImageKHR(this.device.handle, this.handle, timeout, semaphore.handle, fence.handle, pointer);
            }
        }

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkSwapchainKhr() {
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
                //VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
                //vkAPI.vkDestroySwapchainKHR(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}
