using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public struct GlobalString {
        public IntPtr pString;

        public GlobalString(String v) {
            if (v != null) {
                this.pString = Marshal.StringToHGlobalAnsi(v);
            }
            else {
                this.pString = IntPtr.Zero;
            }
        }

        public void Set(String v) {
            if (this.pString != IntPtr.Zero) {
                Marshal.FreeHGlobal(this.pString);
            }

            if (v != null) {
                this.pString = Marshal.StringToHGlobalAnsi(v);
            }
        }

        public static implicit operator GlobalString(String v) {
            return new GlobalString(v);
        }

        public static implicit operator String(GlobalString v) {
            String result = null;

            IntPtr p = v.pString;
            if (p != IntPtr.Zero) {
                result = Marshal.PtrToStringAnsi(p);
            }
            return result;
        }

        public override string ToString() {
            String result = this;
            return result != null ? "\"" + result + "\"" : "<null>";
        }
    }
}
