using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkComponentMapping {
        public override string ToString() {
            return $"{r}, {g}, {b}, {a}";
        }
    }
}
