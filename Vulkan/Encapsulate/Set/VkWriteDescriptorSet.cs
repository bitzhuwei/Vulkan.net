using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkWriteDescriptorSetHelper {
        public static void Set(this VkDescriptorBufferInfo value, VkWriteDescriptorSet* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDescriptorBufferInfo[] values, VkWriteDescriptorSet* info) {
            IntPtr ptr = (IntPtr)info->pBufferInfo;
            values.Set(ref ptr, ref info->descriptorCount);
            info->pBufferInfo = (VkDescriptorBufferInfo*)ptr;
        }

        public static void Set(this VkDescriptorImageInfo value, VkWriteDescriptorSet* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkDescriptorImageInfo[] values, VkWriteDescriptorSet* info) {
            IntPtr ptr = (IntPtr)info->pImageInfo;
            values.Set(ref ptr, ref info->descriptorCount);
            info->pImageInfo = (VkDescriptorImageInfo*)ptr;
        }

        public static void Set(this VkBufferView value, VkWriteDescriptorSet* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkBufferView[] values, VkWriteDescriptorSet* info) {
            IntPtr ptr = (IntPtr)info->pTexelBufferView;
            values.Set(ref ptr, ref info->descriptorCount);
            info->pTexelBufferView = (VkBufferView*)ptr;
        }
    }
}
