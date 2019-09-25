using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDescriptorSetLayoutBinding {
        /// <summary>
        /// VkDescriptorSetLayoutBinding - Structure specifying a descriptor set layout binding
        /// </summary>
        /// <param name="binding">binding is the binding number of this entry and corresponds to a
        /// resource of the same binding number in the shader stages</param>
        /// <param name="descriptorType">descriptorType is a VkDescriptorType specifying which type
        /// of resource descriptors are used for this binding</param>
        /// <param name="descriptorCount">descriptorCount is the number of descriptors contained in the
        /// binding, accessed in a shader as an array
        /// , except if descriptorType is
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT in which case
        /// descriptorCount is the size in bytes of the inline uniform block
        /// .
        /// If descriptorCount is zero this binding entry is reserved and the
        /// resource must not be accessed from any stage via this binding within
        /// any pipeline using the set layout</param>
        /// <param name="stageFlags">stageFlags member is a bitmask of VkShaderStageFlagBits
        /// specifying which pipeline shader stages can access a resource for this
        /// binding.
        /// VK_SHADER_STAGE_ALL is a shorthand specifying that all defined
        /// shader stages, including any additional stages defined by extensions,
        /// can access the resource</param>
        public VkDescriptorSetLayoutBinding(UInt32 binding, VkDescriptorType descriptorType, UInt32 descriptorCount, VkShaderStageFlagBits stageFlags) {
            this.binding = binding; this.descriptorType = descriptorType;
            this.descriptorCount = descriptorCount; this.stageFlags = stageFlags;
            this.pImmutableSamplers = null;
        }

        public override string ToString() {
            return $"binding:{binding}, type:{descriptorType}, count:{descriptorCount}, offset:{stageFlags}";
        }
    }
}
