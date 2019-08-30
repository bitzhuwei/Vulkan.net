using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkDescriptorSet {
        public readonly VkDevice device;
        public readonly UInt64 handle;

        public static VkResult Allocate(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, out VkDescriptorSet[] DescriptorSets) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            uint count = allocateInfo.DescriptorSetCount;
            var handles = new UInt64[count];
            if (count > 0) {
                fixed (UInt64* pointer = handles) {
                    fixed (VkDescriptorSetAllocateInfo* pAllocateInfo = &allocateInfo) {
                        result = vkAPI.vkAllocateDescriptorSets(device.handle, pAllocateInfo, pointer).Check();
                    }
                }
            }

            DescriptorSets = new VkDescriptorSet[count];
            for (int i = 0; i < count; i++) {
                DescriptorSets[i] = new VkDescriptorSet(device, handles[i]);
            }

            return result;
        }

        internal VkDescriptorSet(VkDevice device, UInt64 handle) {
            this.device = device;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkDescriptorSet)}, {device}, {handle}";

    }
}

