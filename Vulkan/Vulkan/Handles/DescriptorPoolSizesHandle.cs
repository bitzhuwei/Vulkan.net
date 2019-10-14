using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct DescriptorPoolSizesHandle {
        public UInt32 count;
        public VkDescriptorPoolSize* array;

        public DescriptorPoolSizesHandle(params VkDescriptorPoolSize[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorPoolSize*)ptr;
        }

        public void Set(params VkDescriptorPoolSize[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorPoolSize*)ptr;
        }

        public static implicit operator DescriptorPoolSizesHandle(VkDescriptorPoolSize v) {
            return new DescriptorPoolSizesHandle(new VkDescriptorPoolSize[] { v });
        }

        public static implicit operator DescriptorPoolSizesHandle(VkDescriptorPoolSize[] v) {
            return new DescriptorPoolSizesHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDescriptorPoolSize)}[{count}]";
            }
        }
    }
}
