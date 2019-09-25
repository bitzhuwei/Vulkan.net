using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineVertexInputStateCreateInfoHelper {
        public static void Set(this VkVertexInputBindingDescription value, ref VkPipelineVertexInputStateCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkVertexInputBindingDescription[] values, ref VkPipelineVertexInputStateCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pVertexBindingDescriptions;
            values.Set(ref ptr, ref info.vertexBindingDescriptionCount);
            info.pVertexBindingDescriptions = (VkVertexInputBindingDescription*)ptr;
        }
        public static void Set(this VkVertexInputAttributeDescription value, ref VkPipelineVertexInputStateCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkVertexInputAttributeDescription[] values, ref VkPipelineVertexInputStateCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pVertexAttributeDescriptions;
            values.Set(ref ptr, ref info.vertexAttributeDescriptionCount);
            info.pVertexAttributeDescriptions = (VkVertexInputAttributeDescription*)ptr;
        }
    }
}
