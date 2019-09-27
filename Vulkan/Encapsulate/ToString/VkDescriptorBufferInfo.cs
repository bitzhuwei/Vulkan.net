using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDescriptorBufferInfo {
        public override string ToString() {
            return $"{buffer}, {offset}, {range}";
        }
    }
}
