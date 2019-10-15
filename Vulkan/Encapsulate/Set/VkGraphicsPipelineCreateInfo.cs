using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkGraphicsPipelineCreateInfoHelper {
        public static void Set(this VkPipelineShaderStageCreateInfo value, VkGraphicsPipelineCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkPipelineShaderStageCreateInfo[] values, VkGraphicsPipelineCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pStages;
            values.Set(ref ptr, ref info->stageCount);
            info->pStages = (VkPipelineShaderStageCreateInfo*)ptr;
        }
    }
}
