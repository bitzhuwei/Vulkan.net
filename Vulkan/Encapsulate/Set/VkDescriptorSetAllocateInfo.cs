using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDescriptorSetAllocateInfoHelper {
        public static void Set(this VkDescriptorSetLayout value, VkDescriptorSetAllocateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDescriptorSetLayout[] values, VkDescriptorSetAllocateInfo* info) {
            IntPtr ptr = (IntPtr)info->pSetLayouts;
            values.Set(ref ptr, ref info->descriptorSetCount);
            info->pSetLayouts = (VkDescriptorSetLayout*)ptr;
        }
    }
}
