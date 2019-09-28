using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDescriptorSetLayoutCreateInfoHelper {
        public static void Set(this VkDescriptorSetLayoutBinding value, VkDescriptorSetLayoutCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDescriptorSetLayoutBinding[] values, VkDescriptorSetLayoutCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pBindings;
            values.Set(ref ptr, ref info->bindingCount);
            info->pBindings = (VkDescriptorSetLayoutBinding*)ptr;
        }
    }
}
