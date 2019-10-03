using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkRect2D {
        public override string ToString() {
            return $"x:{offset.x}, y:{offset.y}, w:{extent.width}, h:{extent.height}";
        }
    }
}
