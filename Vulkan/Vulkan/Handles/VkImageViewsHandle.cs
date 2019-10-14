using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct VkImageViewsHandle {
        public UInt32 count;
        public VkImageView* array;

        public VkImageViewsHandle(params VkImageView[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkImageView*)ptr;
        }

        public void Set(params VkImageView[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkImageView*)ptr;
        }

        public static implicit operator VkImageViewsHandle(VkImageView v) {
            return new VkImageViewsHandle(new VkImageView[] { v });
        }

        public static implicit operator VkImageViewsHandle(VkImageView[] v) {
            return new VkImageViewsHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkImageView)}[{count}]";
            }
        }
    }
}
