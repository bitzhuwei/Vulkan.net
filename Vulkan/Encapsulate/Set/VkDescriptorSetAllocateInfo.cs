using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDescriptorSetAllocateInfoHelper {
        public static void Set(this VkDescriptorSetLayout value, ref VkDescriptorSetAllocateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDescriptorSetLayout[] values, ref VkDescriptorSetAllocateInfo info) {
            IntPtr ptr = (IntPtr)info.pSetLayouts;
            values.Set(ref ptr, ref info.descriptorSetCount);
            info.pSetLayouts = (VkDescriptorSetLayout*)ptr;
        }
    }
}
