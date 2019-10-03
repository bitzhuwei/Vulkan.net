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

        /// <summary>
        /// VkRect2D - Structure specifying a two-dimensional subregion
        /// </summary>
        /// <param name="offset">specifying the rectangle offset</param>
        /// <param name="extent">specifying the rectangle extent</param>
        public VkRect2D(VkOffset2D offset, VkExtent2D extent) {
            this.offset = offset; this.extent = extent;
        }

        /// <summary>
        /// VkRect2D - Structure specifying a two-dimensional subregion
        /// </summary>
        /// <param name="offset">specifying the rectangle offset</param>
        public VkRect2D(VkOffset2D offset) {
            this.offset = offset; this.extent = new VkExtent2D();
        }

        /// <summary>
        /// VkRect2D - Structure specifying a two-dimensional subregion
        /// </summary>
        /// <param name="extent">specifying the rectangle extent</param>
        public VkRect2D(VkExtent2D extent) {
            this.offset = new VkOffset2D(); this.extent = extent;
        }
    }
}
