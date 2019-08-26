using System;
using System.Collections.Generic;

namespace Vulkan {
    public unsafe static class StringHelper {
        public static string ToStringAnsi(this byte[] bytes) {
            fixed (byte* pointer = bytes) {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi((IntPtr)pointer);
            }
        }

        public static string ToStringAnsi(byte* bytes) {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi((IntPtr)bytes);
        }

        public static byte[] ToBytes(string str) {
            return System.Text.UTF8Encoding.UTF8.GetBytes(str);
        }

        public static IntPtr ToPtr(this string[] strings) {
            if (strings == null || strings.Length == 0) { return IntPtr.Zero; }

            var array = new UnmanagedArray<IntPtr>(strings.Length);
            fixed (IntPtr* pointer = &array.header) {
                for (int i = 0; i < strings.Length; i++) {
                    pointer[i] = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(strings[i]);
                }
            }

            return array.header;
        }

        public static string[] ToStrings(this IntPtr header, int count) {
            if (header == IntPtr.Zero) { return null; }

            var strings = new string[count];
            IntPtr* pointer = &header;
            for (int i = 0; i < count; i++) {
                strings[i] = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(pointer[i]);
            }

            return strings;
        }
    }

}


