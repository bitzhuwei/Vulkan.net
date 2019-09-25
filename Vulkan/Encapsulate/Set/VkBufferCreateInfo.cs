using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkBufferCreateInfoHelper {
        public static void Set(this UInt32 value, ref VkBufferCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this UInt32[] values, ref VkBufferCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pQueueFamilyIndices;
            values.Set(ref ptr, ref info.queueFamilyIndexCount);
            info.pQueueFamilyIndices = (UInt32*)ptr;
        }
    }
}
