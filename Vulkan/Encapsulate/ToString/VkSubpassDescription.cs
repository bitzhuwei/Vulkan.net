using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkSubpassDescription {
        public override string ToString() {
            return $"{pipelineBindPoint}, {flags}";
        }
    }
}
