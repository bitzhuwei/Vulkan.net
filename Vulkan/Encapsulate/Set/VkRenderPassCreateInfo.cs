using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkRenderPassCreateInfoHelper {
        public static void Set(this VkAttachmentDescription value, ref VkRenderPassCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkAttachmentDescription[] values, ref VkRenderPassCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pAttachments;
            values.Set(ref ptr, ref info.attachmentCount);
            info.pAttachments = (VkAttachmentDescription*)ptr;
        }

        public static void Set(this VkSubpassDescription value, ref VkRenderPassCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkSubpassDescription[] values, ref VkRenderPassCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pSubpasses;
            values.Set(ref ptr, ref info.subpassCount);
            info.pSubpasses = (VkSubpassDescription*)ptr;
        }

        public static void Set(this VkSubpassDependency value, ref VkRenderPassCreateInfo info) {
            new[] { value }.Set(ref info);
        }

        public static void Set(this VkSubpassDependency[] values, ref VkRenderPassCreateInfo info) {
            IntPtr ptr = (IntPtr)info.pDependencies;
            values.Set(ref ptr, ref info.dependencyCount);
            info.pDependencies = (VkSubpassDependency*)ptr;
        }
    }
}
