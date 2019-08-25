using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDisplayModeKhr {
        private readonly VkPhysicalDevice physicalDevice;
        private readonly VkDisplayKhr displayKhr;
        public readonly UInt64 handle;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;

        public static VkResult Create(VkPhysicalDevice physicalDevice, VkDisplayKhr displayKhr, ref VkDisplayModeCreateInfoKhr createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkDisplayModeKhr displayModeKhr) {
            if (physicalDevice == null) { throw new ArgumentNullException("physicalDevice"); }
            if (displayKhr == null) { throw new ArgumentNullException("displayKhr"); }

            VkResult result;
            UInt64 handle;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkDisplayModeCreateInfoKhr* pCreateInfo = &createInfo) {
                result = vkAPI.vkCreateDisplayModeKHR(physicalDevice.handle, displayKhr.handle, pCreateInfo, pAllocator, &handle).Check();
            }

            displayModeKhr = new VkDisplayModeKhr(physicalDevice, displayKhr, callbacks, handle);

            return result;
        }

        private VkDisplayModeKhr(VkPhysicalDevice physicalDevice, VkDisplayKhr displayKhr, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.physicalDevice = physicalDevice;
            this.displayKhr = displayKhr;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkDisplayModeKhr)}, {handle}";

    }
}

