using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkOffset3D {
        public VkOffset3D(Int32 x, Int32 y, Int32 z) {
            this.x = x; this.y = y; this.z = z;
        }
    }
}
