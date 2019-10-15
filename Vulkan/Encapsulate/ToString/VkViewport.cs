using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkViewport {
        public override string ToString() {
            return $"x:{x}, y:{y}, w:{width}, h:{height}, minDepth:{minDepth}, maxDepth:{maxDepth}";
        }
    }
}
