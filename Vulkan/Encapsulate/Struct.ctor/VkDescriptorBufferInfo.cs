using System;
using System.Collections.Generic;
using System.Text;
using VkDeviceSize = System.UInt64;

namespace Vulkan {
    public unsafe partial struct VkDescriptorBufferInfo {
        /// <summary>
        /// VkDescriptorBufferInfo - Structure specifying descriptor buffer info
        /// </summary>
        /// <param name="buffer">buffer is the buffer resource</param>
        /// <param name="offset">offset is the offset in bytes from the start of buffer.
        /// Access to buffer memory via this descriptor uses addressing that is
        /// relative to this starting offset</param>
        /// <param name="range">range is the size in bytes that is used for this descriptor
        /// update, or VK_WHOLE_SIZE to use the range from offset to the
        /// end of the buffer</param>
        public VkDescriptorBufferInfo(VkBuffer buffer, VkDeviceSize offset, VkDeviceSize range) {
            this.buffer = buffer; this.offset = offset; this.range = range;
        }
    }
}
