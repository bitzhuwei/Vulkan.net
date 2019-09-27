using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkClearDepthStencilValue {
        public override string ToString() {
            return $"depth:{depth}, stencil:{stencil}";
        }
    }
}
