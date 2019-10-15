using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {

    public unsafe partial struct VkExtent2D {
        /// <summary>
        /// VkExtent2D - Structure specifying a two-dimensional extent
        /// </summary>
        /// <param name="width">width is the width of the extent</param>
        /// <param name="height">height is the height of the extent</param>
        public VkExtent2D(UInt32 width, UInt32 height) {
            this.width = width; this.height = height;
        }
    }
}
