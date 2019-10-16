using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkSubpassDescription {
        /// <summary>
        /// VkSubpassDescription - Structure specifying a subpass description
        /// </summary>
        /// <param name="pipelineBindPoint">pipelineBindPoint is a VkPipelineBindPoint value specifying
        /// the pipeline type supported for this subpass</param>
        /// <param name="flags">flags is a bitmask of VkSubpassDescriptionFlagBits
        /// specifying usage of the subpass</param>
        public VkSubpassDescription(VkPipelineBindPoint pipelineBindPoint,
            VkSubpassDescriptionFlagBits flags = 0) {
            this.pipelineBindPoint = pipelineBindPoint;
            this.inputAttachments = new VkAttachmentReferenceGroup();
            this.colorAttachments = null;// new VkAttachmentReferencesGroup();
            this.colorResolveAttachments = new VkColorResolveAttachmentGroup();
            this.pDepthStencilAttachment = null;
            this.preserveAttachments = new UInt32Group();
            this.flags = flags;
        }
    }
}
