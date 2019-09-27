using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkAttachmentReference {
        /// <summary>
        /// VkAttachmentReference - Structure specifying an attachment reference
        /// </summary>
        /// <param name="layout">layout is a VkImageLayout value specifying the layout the
        /// attachment uses during the subpass</param>
        /// <param name="attachment">attachment is either an integer value identifying an attachment at
        /// the corresponding index in
        /// VkRenderPassCreateInfo::pAttachments, or
        /// VK_ATTACHMENT_UNUSED to signify that this attachment is not used</param>
        public VkAttachmentReference(VkImageLayout layout, UInt32 attachment) {
            this.layout = layout;
            this.attachment = attachment;
        }
    }
}
