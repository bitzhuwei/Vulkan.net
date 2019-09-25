using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkExtent3D {
        /// <summary>
        /// VkExtent3D - Structure specifying a three-dimensional extent
        /// </summary>
        /// <param name="width">width is the width of the extent</param>
        /// <param name="height">height is the height of the extent</param>
        /// <param name="depth">depth is the depth of the extent</param>
        public VkExtent3D(UInt32 width, UInt32 height, UInt32 depth) {
            this.width = width; this.height = height; this.depth = depth;
        }

        public override string ToString() {
            return $"w: {width}, h: {height}, d: {depth}";
        }

    }
}
