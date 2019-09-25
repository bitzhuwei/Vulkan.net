using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDescriptorPoolSize {
        /// <summary>
        /// VkDescriptorPoolSize - Structure specifying descriptor pool size
        /// </summary>
        /// <param name="type">type is the type of descriptor</param>
        /// <param name="descriptorCount">descriptorCount is the number of descriptors of that type to
        /// allocate.
        /// If type is VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// descriptorCount is the number of bytes to allocate for descriptors
        /// of this type</param>
        public VkDescriptorPoolSize(VkDescriptorType type, UInt32 descriptorCount) {
            this.type = type;
            this.descriptorCount = descriptorCount;
        }

        public override string ToString() {
            return $"pool: {type}[{descriptorCount}]";
        }
    }
}
