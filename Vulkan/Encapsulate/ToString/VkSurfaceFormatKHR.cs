using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkSurfaceFormatKHR {
        public override string ToString() {
            return $"{format}, {colorSpace}";
        }
    }
}
