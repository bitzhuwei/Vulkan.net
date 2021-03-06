﻿using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct CodeGroup {
        public Int32 codeSize;
        public UInt32* pCode;

        public CodeGroup(params byte[] value) {
            this.codeSize = 0;
            this.pCode = null;
            if (value != null) {
                IntPtr ptr = IntPtr.Zero; UInt32 size = 0;
                value.Set(ref ptr, ref size);
                this.codeSize = (int)size; this.pCode = (UInt32*)ptr;
            }
        }

        public void Set(byte[] value) {
            IntPtr ptr = (IntPtr)this.pCode; UInt32 size = 0;
            value.Set(ref ptr, ref size);
            this.pCode = (UInt32*)ptr; this.codeSize = (int)size;
        }

        public static implicit operator CodeGroup(byte[] v) {
            return new CodeGroup(v);
        }

        public override string ToString() {
            return $"Code[{codeSize}]";
        }
    }
}
