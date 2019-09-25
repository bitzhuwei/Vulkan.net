using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkRect2D {
        /// <summary>
        /// VkRect2D - Structure specifying a two-dimensional subregion
        /// </summary>
        /// <param name="x">specifying the rectangle offset</param>
        /// <param name="y">specifying the rectangle offset</param>
        /// <param name="width">specifying the rectangle extent</param>
        /// <param name="height">specifying the rectangle extent</param>
        public VkRect2D(int x, int y, uint width, uint height) {
            this.offset.x = x; this.offset.y = y; this.extent.width = width; this.extent.height = height;
        }

        public override string ToString() {
            return $"x:{offset.x}, y:{offset.y}, w:{extent.width}, h:{extent.height}";
        }
    }
}
