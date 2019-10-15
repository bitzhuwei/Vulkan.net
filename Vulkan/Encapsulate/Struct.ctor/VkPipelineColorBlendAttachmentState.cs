using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkPipelineColorBlendAttachmentState {
        /// <summary>
        /// VkPipelineColorBlendAttachmentState - Structure specifying a pipeline color blend attachment state.
        /// </summary>
        /// <param name="colorWriteMask">colorWriteMask is a bitmask of VkColorComponentFlagBits
        /// specifying which of the R, G, B, and/or A components are enabled for
        /// writing, as described for the Color Write
        /// Mask</param>
        /// <param name="blendEnable">blendEnable controls whether blending is enabled for the
        /// corresponding color attachment.
        /// If blending is not enabled, the source fragment’s color for that
        /// attachment is passed through unmodified</param>
        public VkPipelineColorBlendAttachmentState(VkColorComponentFlagBits colorWriteMask, VkBool32 blendEnable) {
            this.alphaBlendOp = 0;
            this.blendEnable = blendEnable;
            this.colorBlendOp = 0;
            this.colorWriteMask = colorWriteMask;
            this.dstAlphaBlendFactor = 0;
            this.dstColorBlendFactor = 0;
            this.srcAlphaBlendFactor = 0;
            this.srcColorBlendFactor = 0;
        }
    }
}
