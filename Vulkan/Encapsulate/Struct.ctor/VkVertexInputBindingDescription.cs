using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkVertexInputBindingDescription {
        /// <summary>
        /// VkVertexInputBindingDescription - Structure specifying vertex input binding description.
        /// </summary>
        /// <param name="binding">binding is the binding number that this structure describes.</param>
        /// <param name="stride">stride is the distance in bytes between two consecutive elements
        /// within the buffer.</param>
        /// <param name="inputRate">inputRate is a VkVertexInputRate value specifying whether
        /// vertex attribute addressing is a function of the vertex index or of the
        /// instance index.</param>
        public VkVertexInputBindingDescription(UInt32 binding, UInt32 stride, VkVertexInputRate inputRate) {
            this.binding = binding; this.stride = stride; this.inputRate = inputRate;
        }
    }
}
