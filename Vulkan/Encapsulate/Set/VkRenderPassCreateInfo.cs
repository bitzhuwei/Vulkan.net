using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkRenderPassCreateInfoHelper {
        public static void Set(this VkAttachmentDescription value, VkRenderPassCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkAttachmentDescription[] values, VkRenderPassCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pAttachments;
            values.Set(ref ptr, ref info->attachmentCount);
            info->pAttachments = (VkAttachmentDescription*)ptr;
        }

        public static void Set(this VkSubpassDescription value, VkRenderPassCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkSubpassDescription[] values, VkRenderPassCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pSubpasses;
            values.Set(ref ptr, ref info->subpassCount);
            info->pSubpasses = (VkSubpassDescription*)ptr;
        }

        public static void Set(this VkSubpassDependency value, VkRenderPassCreateInfo* info) {
            new[] { value }.Set(info);
        }

        public static void Set(this VkSubpassDependency[] values, VkRenderPassCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pDependencies;
            values.Set(ref ptr, ref info->dependencyCount);
            info->pDependencies = (VkSubpassDependency*)ptr;
        }
    }
}
