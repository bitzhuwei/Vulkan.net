using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkGraphicsPipelineCreateInfoHelper {
        public static void Set(this VkPipelineShaderStageCreateInfo value, ref VkGraphicsPipelineCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkPipelineShaderStageCreateInfo[] values, ref VkGraphicsPipelineCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pStages;
            values.Set(ref ptr, ref info.stageCount);
            info.pStages = (VkPipelineShaderStageCreateInfo*)ptr;
        }
    }
}
