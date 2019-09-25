using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkSubpassDescriptionHelper {
        public static void Set(this VkAttachmentReference value, ref VkSubpassDescription info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkAttachmentReference[] values, ref VkSubpassDescription info) {
            IntPtr ptr = (IntPtr)info.pColorAttachments;
            values.Set(ref ptr, ref info.colorAttachmentCount);
            info.pColorAttachments = (VkAttachmentReference*)ptr;
        }
    }
}
