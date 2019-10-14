using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct UInt32sHandle {
        public UInt32 count;
        public UInt32* array;

        public UInt32sHandle(params UInt32[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (UInt32*)ptr;
        }

        public void Set(params UInt32[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (UInt32*)ptr;
        }

        public static implicit operator UInt32sHandle(UInt32 v) {
            return new UInt32sHandle(new UInt32[] { v });
        }

        public static implicit operator UInt32sHandle(UInt32[] v) {
            return new UInt32sHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(UInt32)}[{count}]";
            }
        }
    }
}
