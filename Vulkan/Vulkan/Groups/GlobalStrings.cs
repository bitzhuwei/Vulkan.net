using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct GlobalStrings {
        public UInt32 count;
        public IntPtr pStrings;

        public GlobalStrings(params String[] value) {
            count = 0;
            pStrings = IntPtr.Zero;
            if (value != null) {
                int length = value.Length;
                if (length > 0) {
                    int elementSize = Marshal.SizeOf(typeof(IntPtr));
                    int byteLength = length * elementSize;
                    IntPtr array = Marshal.AllocHGlobal(byteLength);
                    IntPtr* pointer = (IntPtr*)array;
                    for (int i = 0; i < length; i++) {
                        IntPtr str = Marshal.StringToHGlobalAnsi(value[i]);
                        pointer[i] = str;
                    }
                    this.pStrings = (IntPtr)pointer;
                    count = (UInt32)length;
                }
            }
        }

        public void Set(params String[] value) {
            {   // free unmanaged memory.
                IntPtr* target = (IntPtr*)this.pStrings;
                if (target != null) {
                    for (int i = 0; i < this.count; i++) {
                        Marshal.FreeHGlobal(target[i]);
                    }
                }

                this.count = 0;
                this.pStrings = IntPtr.Zero;
            }

            if (value != null) {
                int length = value.Length;
                if (length > 0) {
                    int elementSize = Marshal.SizeOf(typeof(IntPtr));
                    int byteLength = (int)(length * elementSize);
                    IntPtr array = Marshal.AllocHGlobal(byteLength);
                    IntPtr* pointer = (IntPtr*)array;
                    for (int i = 0; i < length; i++) {
                        IntPtr str = Marshal.StringToHGlobalAnsi(value[i]);
                        pointer[i] = str;
                    }
                    this.pStrings = (IntPtr)pointer;
                }
                this.count = (UInt32)length;
            }
        }

        public static implicit operator GlobalStrings(String v) {
            if (v != null) {
                return new GlobalStrings(new String[] { v });
            }
            else {
                return new GlobalStrings(null);
            }
        }

        public static implicit operator GlobalStrings(String[] v) {
            return new GlobalStrings(v);
        }

        public override string ToString() {
            string[] result = null;
            var pointer = (IntPtr*)this.pStrings;
            if (pointer != null) {
                result = new String[count];
                for (int i = 0; i < count; i++) {
                    result[i] = Marshal.PtrToStringAnsi(pointer[i]);
                }
            }
            return String.Concat(result);
        }
    }
}
