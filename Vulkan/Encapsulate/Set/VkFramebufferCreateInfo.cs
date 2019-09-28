using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkFramebufferCreateInfoHelper {
        public static void Set(this VkImageView value, VkFramebufferCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkImageView[] values, VkFramebufferCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pAttachments;
            values.Set(ref ptr, ref info->attachmentCount);
            info->pAttachments = (VkImageView*)ptr;
        }
    }
}
