using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineColorBlendStateCreateInfoHelper {
        public static void Set(this VkPipelineColorBlendAttachmentState value, VkPipelineColorBlendStateCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkPipelineColorBlendAttachmentState[] values, VkPipelineColorBlendStateCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pAttachments;
            values.Set(ref ptr, ref info->attachmentCount);
            info->pAttachments = (VkPipelineColorBlendAttachmentState*)ptr;
        }
    }
}
