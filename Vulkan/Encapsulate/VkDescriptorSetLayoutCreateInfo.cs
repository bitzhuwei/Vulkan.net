using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkDescriptorSetLayoutCreateInfoHelper {
        public static void Set(this VkDescriptorSetLayoutBinding value, ref VkDescriptorSetLayoutCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDescriptorSetLayoutBinding[] values, ref VkDescriptorSetLayoutCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pBindings;
            values.Set(ref ptr, ref info.bindingCount);
            info.pBindings = (VkDescriptorSetLayoutBinding*)ptr;
        }
    }
}
