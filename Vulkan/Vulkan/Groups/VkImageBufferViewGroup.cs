using System;
using System.Runtime.InteropServices;

namespace Vulkan {

    public unsafe struct VkImageBufferViewGroup {
        /// <summary> count is the number of descriptors to update (the number
        /// of elements in pImageInfo, pBufferInfo, or
        /// pTexelBufferView
        /// , or a value matching the dataSize member of an instance of
        /// VkWriteDescriptorSetInlineUniformBlockEXT in the pNext chain
        /// , or a value matching the accelerationStructureCount of an
        /// instance of VkWriteDescriptorSetAccelerationStructureNV in the
        /// pNext chain
        /// ).
        /// If the descriptor binding identified by dstSet and
        /// dstBinding has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// descriptorCount specifies the number of bytes to update.</summary>
        public UInt32 count;
        /// <summary> descriptorType is a VkDescriptorType specifying the type of
        /// each descriptor in pImageInfo, pBufferInfo, or
        /// pTexelBufferView, as described below.
        /// It must be the same type as that specified in
        /// VkDescriptorSetLayoutBinding for dstSet at dstBinding.
        /// The type of the descriptor also controls which array the descriptors are
        /// taken from.</summary>
        public VkDescriptorType descriptorType;
        /// <summary> pImageInfo points to an array of VkDescriptorImageInfo
        /// structures or is ignored, as described below.</summary>
        public /*-const-*/ VkDescriptorImageInfo* imageInfo;
        /// <summary> pBufferInfo points to an array of VkDescriptorBufferInfo
        /// structures or is ignored, as described below.</summary>
        public /*-const-*/ VkDescriptorBufferInfo* bufferInfo;
        /// <summary> pTexelBufferView points to an array of VkBufferView handles
        /// as described in the Buffer Views section or
        /// is ignored, as described below.</summary>
        public /*-const-*/ VkBufferView* texelBufferView;

        public void Set(params VkDescriptorImageInfo[] value) {
            IntPtr ptr = (IntPtr)this.imageInfo;
            value.Set(ref ptr, ref this.count);
            this.imageInfo = (VkDescriptorImageInfo*)ptr;
        }

        public void Set(params VkDescriptorBufferInfo[] value) {
            IntPtr ptr = (IntPtr)this.bufferInfo;
            value.Set(ref ptr, ref this.count);
            this.bufferInfo = (VkDescriptorBufferInfo*)ptr;
        }

        public void Set(params VkBufferView[] value) {
            IntPtr ptr = (IntPtr)this.texelBufferView;
            value.Set(ref ptr, ref this.count);
            this.texelBufferView = (VkBufferView*)ptr;
        }

        /// <summary>
        /// Free unmanaged memory and reset all members to 0.
        /// </summary>
        public void Reset() {
            {
                UInt32 count = this.count;
                IntPtr ptr = (IntPtr)this.imageInfo;
                Helper.Set<VkDescriptorImageInfo>(null, ref ptr, ref count);
                this.imageInfo = (VkDescriptorImageInfo*)ptr;
            }
            {
                UInt32 count = this.count;
                IntPtr ptr = (IntPtr)this.bufferInfo;
                Helper.Set<VkDescriptorBufferInfo>(null, ref ptr, ref count);
                this.bufferInfo = (VkDescriptorBufferInfo*)ptr;
            }
            {
                UInt32 count = this.count;
                IntPtr ptr = (IntPtr)this.texelBufferView;
                Helper.Set<VkBufferView>(null, ref ptr, ref count);
                this.texelBufferView = (VkBufferView*)ptr;
            }
            {
                this.count = 0;
            }
        }

        public override string ToString() {
            if (count == 1) {
                return $"{descriptorType}, {imageInfo[0]}, {bufferInfo[0]}, {texelBufferView[0]}";
            }
            else {
                return $"{nameof(VkDescriptorImageInfo)}[{count}], {nameof(VkDescriptorBufferInfo)}[{count}], {nameof(VkBufferView)}[{count}]";
            }
        }
    }

}
