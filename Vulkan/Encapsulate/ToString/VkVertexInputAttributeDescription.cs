using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkVertexInputAttributeDescription {
        public override string ToString() {
            return $"loc:{location}, binding:{binding}, format:{format}, offset:{offset}";
        }
    }
}
