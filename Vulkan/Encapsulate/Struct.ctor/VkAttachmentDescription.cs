using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkAttachmentDescription {
        /// <summary>
        /// VkAttachmentDescription - Structure specifying an attachment description.
        /// </summary>
        /// <param name="format">format is a VkFormat value specifying the format of the
        /// image view that will be used for the attachment</param>
        /// <param name="samples">samples is the number of samples of the image as defined in
        /// VkSampleCountFlagBits</param>
        /// <param name="loadOp">loadOp is a VkAttachmentLoadOp value specifying how the
        /// contents of color and depth components of the attachment are treated at
        /// the beginning of the subpass where it is first used</param>
        /// <param name="storeOp">storeOp is a VkAttachmentStoreOp value specifying how the
        /// contents of color and depth components of the attachment are treated at
        /// the end of the subpass where it is last used</param>
        /// <param name="stencilLoadOp">stencilLoadOp is a VkAttachmentLoadOp value specifying how
        /// the contents of stencil components of the attachment are treated at the
        /// beginning of the subpass where it is first used</param>
        /// <param name="stencilStoreOp">stencilStoreOp is a VkAttachmentStoreOp value specifying how
        /// the contents of stencil components of the attachment are treated at the
        /// end of the last subpass where it is used</param>
        /// <param name="initialLayout">initialLayout is the layout the attachment image subresource will
        /// be in when a render pass instance begins</param>
        /// <param name="finalLayout">finalLayout is the layout the attachment image subresource will be
        /// transitioned to when a render pass instance ends</param>
        /// <param name="flags">flags is a bitmask of VkAttachmentDescriptionFlagBits
        /// specifying additional properties of the attachment</param>
        public VkAttachmentDescription(VkFormat format, VkSampleCountFlagBits samples,
           VkAttachmentLoadOp loadOp, VkAttachmentStoreOp storeOp,
           VkAttachmentLoadOp stencilLoadOp, VkAttachmentStoreOp stencilStoreOp,
           VkImageLayout initialLayout, VkImageLayout finalLayout,
           VkAttachmentDescriptionFlagBits flags = 0) {
            this.format = format; this.samples = samples;
            this.loadOp = loadOp; this.storeOp = storeOp;
            this.stencilLoadOp = stencilLoadOp; this.stencilStoreOp = stencilStoreOp;
            this.initialLayout = initialLayout; this.finalLayout = finalLayout;
            this.flags = flags;
        }
    }
}
