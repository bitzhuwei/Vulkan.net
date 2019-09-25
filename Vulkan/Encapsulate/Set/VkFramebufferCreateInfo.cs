using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkFramebufferCreateInfoHelper {
        public static void Set(this VkImageView value, ref VkFramebufferCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkImageView[] values, ref VkFramebufferCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pAttachments;
            values.Set(ref ptr, ref info.attachmentCount);
            info.pAttachments = (VkImageView*)ptr;
        }
    }
}
