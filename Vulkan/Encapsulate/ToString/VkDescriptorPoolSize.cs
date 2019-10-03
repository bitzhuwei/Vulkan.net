using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDescriptorPoolSize {
        public override string ToString() {
            return $"pool: {type}[{descriptorCount}]";
        }
    }
}
