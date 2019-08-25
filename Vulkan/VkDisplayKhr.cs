using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDisplayKhr {
        private readonly VkPhysicalDevice physicalDevice;
        private readonly UInt32 planeIndex;
        public readonly UInt64 handle;

        public static VkResult Create(VkPhysicalDevice physicalDevice, UInt32 planeIndex, out VkDisplayKhr[] displayKhrs) {
            if (physicalDevice == null) { throw new ArgumentNullException("physicalDevice"); }

            UInt32 count;
            VkResult result = vkAPI.vkGetDisplayPlaneSupportedDisplaysKHR(physicalDevice.handle, planeIndex, &count, null).Check();
            var handles = new UInt64[count];
            if (count > 0) {
                fixed (UInt64* pointer = handles) {
                    result = vkAPI.vkGetDisplayPlaneSupportedDisplaysKHR(physicalDevice.handle, planeIndex, &count, pointer).Check();
                }
            }

            displayKhrs = new VkDisplayKhr[count];
            for (int i = 0; i < handles.Length; i++) {
                displayKhrs[i] = new VkDisplayKhr(physicalDevice, planeIndex, handles[i]);
            }

            return result;
        }

        private VkDisplayKhr(VkPhysicalDevice physicalDevice, UInt32 planeIndex, UInt64 handle) {
            this.physicalDevice = physicalDevice;
            this.planeIndex = planeIndex;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkDisplayKhr)}, {handle}";

    }
}

