using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkViewport {
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
        public VkViewport(float x, float y, float width, float height, float minDepth, float maxDepth) {
            this.x = x; this.y = y; this.width = width; this.height = height;
            this.minDepth = minDepth; this.maxDepth = maxDepth;
        }

        public override string ToString() {
            return $"x:{x}, y:{y}, w:{width}, h:{height}, minDepth:{minDepth}, maxDepth:{maxDepth}";
        }
    }
}
