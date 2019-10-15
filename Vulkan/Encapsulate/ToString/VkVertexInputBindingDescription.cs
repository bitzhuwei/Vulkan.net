using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkVertexInputBindingDescription {
        public override string ToString() {
            return $"binding:{binding}, stride:{stride}, rate:{inputRate}";
        }
    }
}
