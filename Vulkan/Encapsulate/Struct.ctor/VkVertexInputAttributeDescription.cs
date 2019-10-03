using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkVertexInputAttributeDescription {
        /// <summary>
        /// VkVertexInputAttributeDescription - Structure specifying vertex input attribute description.
        /// </summary>
        /// <param name="location">location is the shader binding location number for this attribute.</param>
        /// <param name="binding">binding is the binding number which this attribute takes its data
        /// from</param>
        /// <param name="format">format is the size and type of the vertex attribute data.</param>
        /// <param name="offset">offset is a byte offset of this attribute relative to the start of
        /// an element in the vertex input binding.</param>
        public VkVertexInputAttributeDescription(UInt32 location, UInt32 binding, VkFormat format, UInt32 offset) {
            this.location = location; this.binding = binding;
            this.format = format; this.offset = offset;
        }
    }
}
