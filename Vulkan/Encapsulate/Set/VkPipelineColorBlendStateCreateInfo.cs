using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkPipelineColorBlendStateCreateInfoHelper {
        public static void Set(this VkPipelineColorBlendAttachmentState value, ref VkPipelineColorBlendStateCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkPipelineColorBlendAttachmentState[] values, ref VkPipelineColorBlendStateCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pAttachments;
            values.Set(ref ptr, ref info.attachmentCount);
            info.pAttachments = (VkPipelineColorBlendAttachmentState*)ptr;
        }
    }
}
