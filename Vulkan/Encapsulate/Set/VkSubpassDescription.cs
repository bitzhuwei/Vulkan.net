using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkSubpassDescriptionHelper {

        public static void SetInputAttachment(this VkAttachmentReference value, VkSubpassDescription* info) {
            new[] { value }.SetColorAttachments(info);
        }

        public static void SetInputAttachments(this VkAttachmentReference[] values, VkSubpassDescription* info) {
            IntPtr ptr = (IntPtr)info->pInputAttachments;
            values.Set(ref ptr, ref info->inputAttachmentCount);
            info->pInputAttachments = (VkAttachmentReference*)ptr;
        }

        public static void SetColorAttachment(this VkAttachmentReference value, VkSubpassDescription* info) {
            new[] { value }.SetColorAttachments(info);
        }

        public static void SetColorAttachments(this VkAttachmentReference[] values, VkSubpassDescription* info) {
            IntPtr ptr = (IntPtr)info->pColorAttachments;
            values.Set(ref ptr, ref info->colorAttachmentCount);
            info->pColorAttachments = (VkAttachmentReference*)ptr;
        }

        public static void SetResolveAttachment(this VkAttachmentReference value, VkSubpassDescription* info) {
            new[] { value }.SetColorAttachments(info);
        }

        public static void SetResolveAttachments(this VkAttachmentReference[] values, VkSubpassDescription* info) {
            IntPtr ptr = (IntPtr)info->pResolveAttachments;
            values.Set(ref ptr, ref info->colorAttachmentCount);
            info->pResolveAttachments = (VkAttachmentReference*)ptr;
        }

    }
}
