using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkWriteDescriptorSetHelper {
        public static void Set(this VkDescriptorBufferInfo value, ref VkWriteDescriptorSet info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDescriptorBufferInfo[] values, ref VkWriteDescriptorSet info) {
            IntPtr ptr = (IntPtr)info.pBufferInfo;
            values.Set(ref ptr, ref info.descriptorCount);
            info.pBufferInfo = (VkDescriptorBufferInfo*)ptr;
        }

        public static void Set(this VkDescriptorImageInfo value, ref VkWriteDescriptorSet info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkDescriptorImageInfo[] values, ref VkWriteDescriptorSet info) {
            IntPtr ptr = (IntPtr)info.pImageInfo;
            values.Set(ref ptr, ref info.descriptorCount);
            info.pImageInfo = (VkDescriptorImageInfo*)ptr;
        }

        public static void Set(this VkBufferView value, ref VkWriteDescriptorSet info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkBufferView[] values, ref VkWriteDescriptorSet info) {
            IntPtr ptr = (IntPtr)info.pTexelBufferView;
            values.Set(ref ptr, ref info.descriptorCount);
            info.pTexelBufferView = (VkBufferView*)ptr;
        }
    }
}
