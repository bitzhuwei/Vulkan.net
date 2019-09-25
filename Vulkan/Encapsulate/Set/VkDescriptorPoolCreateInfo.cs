using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDescriptorPoolCreateInfoHelper {
        public static void Set(this VkDescriptorPoolSize value, ref VkDescriptorPoolCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDescriptorPoolSize[] values, ref VkDescriptorPoolCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pPoolSizes;
            values.Set(ref ptr, ref info.poolSizeCount);
            info.pPoolSizes = (VkDescriptorPoolSize*)ptr;
        }
    }
}
