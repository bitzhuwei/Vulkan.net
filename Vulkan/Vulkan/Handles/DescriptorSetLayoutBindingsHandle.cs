using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct DescriptorSetLayoutBindingsHandle {
        public UInt32 count;
        public VkDescriptorSetLayoutBinding* array;

        public DescriptorSetLayoutBindingsHandle(params VkDescriptorSetLayoutBinding[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayoutBinding*)ptr;
        }

        public void Set(params VkDescriptorSetLayoutBinding[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayoutBinding*)ptr;
        }

        public static implicit operator DescriptorSetLayoutBindingsHandle(VkDescriptorSetLayoutBinding v) {
            return new DescriptorSetLayoutBindingsHandle(new VkDescriptorSetLayoutBinding[] { v });
        }

        public static implicit operator DescriptorSetLayoutBindingsHandle(VkDescriptorSetLayoutBinding[] v) {
            return new DescriptorSetLayoutBindingsHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDescriptorSetLayoutBinding)}[{count}]";
            }
        }
    }
}
