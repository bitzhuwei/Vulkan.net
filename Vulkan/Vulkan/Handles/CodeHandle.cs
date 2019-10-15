using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct CodeHandle {
        public Int32 codeSize;
        public UInt32* pCode;

        public CodeHandle(params byte[] value) {
            this.codeSize = 0;
            this.pCode = null;
            IntPtr ptr = IntPtr.Zero; UInt32 size = 0;
            value.Set(ref ptr, ref size);
            this.codeSize = (int)size; this.pCode = (UInt32*)ptr;
        }

        public void Set(params byte[] value) {
            IntPtr ptr = IntPtr.Zero; UInt32 size = 0;
            value.Set(ref ptr, ref size);
            this.codeSize = (int)size; this.pCode = (UInt32*)ptr;
        }

        public static implicit operator CodeHandle(byte[] v) {
            return new CodeHandle(v);
        }

        public override string ToString() {
            return $"Code[{codeSize}]";
        }
    }
}
