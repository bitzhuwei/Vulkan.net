using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkPipelineColorBlendAttachmentState {
        public override string ToString() {
            return $"mask:{this.colorWriteMask}, blend:{this.blendEnable}";
        }
    }
}
