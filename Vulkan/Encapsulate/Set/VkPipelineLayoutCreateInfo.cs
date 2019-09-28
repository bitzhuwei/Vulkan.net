using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineLayoutCreateInfoHelper {
        public static void Set(this VkDescriptorSetLayout value, VkPipelineLayoutCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDescriptorSetLayout[] values, VkPipelineLayoutCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pSetLayouts;
            values.Set(ref ptr, ref info->setLayoutCount);
            info->pSetLayouts = (VkDescriptorSetLayout*)ptr;
        }
    }
}
