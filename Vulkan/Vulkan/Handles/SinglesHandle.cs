using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct SinglesHandle {
        public UInt32 count;
        public Single* array;

        public SinglesHandle(params Single[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (Single*)ptr;
        }

        public void Set(params Single[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (Single*)ptr;
        }

        public static implicit operator SinglesHandle(Single v) {
            return new SinglesHandle(new Single[] { v });
        }

        public static implicit operator SinglesHandle(Single[] v) {
            return new SinglesHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(Single)}[{count}]";
            }
        }
    }
}
