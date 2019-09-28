using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkBufferCreateInfoHelper {
        public static void Set(this UInt32 value, VkBufferCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this UInt32[] values, VkBufferCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pQueueFamilyIndices;
            values.Set(ref ptr, ref info->queueFamilyIndexCount);
            info->pQueueFamilyIndices = (UInt32*)ptr;
        }
    }
}
