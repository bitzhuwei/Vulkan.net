using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkComponentMapping {
        /// <summary>
        /// VkViewport - Structure specifying a viewport.
        /// </summary>
        /// <param name="x">x and y are the viewport’s upper left corner (x,y).</param>
        /// <param name="y">x and y are the viewport’s upper left corner (x,y).</param>
        /// <param name="width">width and height are the viewport’s width and height,
        /// respectively.</param>
        /// <param name="height">width and height are the viewport’s width and height,
        /// respectively.</param>
        /// <param name="minDepth">minDepth and maxDepth are the depth range for the viewport.
        /// It is valid for minDepth to be greater than or equal to
        /// maxDepth.</param>
        /// <param name="maxDepth">minDepth and maxDepth are the depth range for the viewport.
        /// It is valid for minDepth to be greater than or equal to
        /// maxDepth.</param>
        public VkComponentMapping(VkComponentSwizzle r, VkComponentSwizzle g, VkComponentSwizzle b, VkComponentSwizzle a) {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    }
}
