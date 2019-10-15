using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public struct StringHandle {
        public IntPtr pString;

        public StringHandle(String v) {
            this.pString = Marshal.StringToHGlobalAnsi(v);
        }

        public void Set(String v) {
            if (this.pString != IntPtr.Zero) {
                Marshal.FreeHGlobal(this.pString);
            }

            this.pString = Marshal.StringToHGlobalAnsi(v);
        }

        public static implicit operator StringHandle(String v) {
            return new StringHandle() { pString = Marshal.StringToHGlobalAnsi(v) };
        }

        public static implicit operator String(StringHandle v) {
            String result = null;

            IntPtr p = v.pString;
            if (p != IntPtr.Zero) {
                result = Marshal.PtrToStringAnsi(p);
            }
            return result;
        }

        public override string ToString() {
            String result = this;
            return result != null ? result : "<null>";
        }
    }
}
