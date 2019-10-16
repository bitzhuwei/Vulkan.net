using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public struct StringGroup {
        public IntPtr pString;

        public StringGroup(String v) {
            this.pString = Marshal.StringToHGlobalAnsi(v);
        }

        public void Set(String v) {
            if (this.pString != IntPtr.Zero) {
                Marshal.FreeHGlobal(this.pString);
            }

            this.pString = Marshal.StringToHGlobalAnsi(v);
        }

        public static implicit operator StringGroup(String v) {
            return new StringGroup() { pString = Marshal.StringToHGlobalAnsi(v) };
        }

        public static implicit operator String(StringGroup v) {
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
