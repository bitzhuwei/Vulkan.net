using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkOffset2D {
        public VkOffset2D(Int32 x, Int32 y) {
            this.x = x; this.y = y;
        }
    }
}
