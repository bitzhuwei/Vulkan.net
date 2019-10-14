using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct DescriptorSetLayoutsHandle {
        public UInt32 count;
        public VkDescriptorSetLayout* array;

        public DescriptorSetLayoutsHandle(params VkDescriptorSetLayout[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayout*)ptr;
        }

        public void Set(params VkDescriptorSetLayout[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayout*)ptr;
        }

        public static implicit operator DescriptorSetLayoutsHandle(VkDescriptorSetLayout v) {
            return new DescriptorSetLayoutsHandle(new VkDescriptorSetLayout[] { v });
        }

        public static implicit operator DescriptorSetLayoutsHandle(VkDescriptorSetLayout[] v) {
            return new DescriptorSetLayoutsHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDescriptorSetLayout)}[{count}]";
            }
        }
    }
}
