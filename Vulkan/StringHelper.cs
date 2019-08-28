using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
            IntPtr* pointer = (IntPtr*)array.header.ToPointer();
            for (int i = 0; i < strings.Length; i++) {
                IntPtr str = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(strings[i]);
                pointer[i] = str;
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

        public static IntPtr ToPtr(this float[] array) {
            if (array == null || array.Length == 0) { return IntPtr.Zero; }

            var unmanagedArray = new UnmanagedArray<float>(array.Length);
            float* dst = (float*)unmanagedArray.header;
            for (int i = 0; i < unmanagedArray.length; i++) {
                dst[i] = array[i];
            }

            return unmanagedArray.header;
        }

        public static IntPtr ToPtr<T>(this T[] array) where T : struct {
            if (array == null || array.Length == 0) { return IntPtr.Zero; }

            var unmanagedArray = new UnmanagedArray<T>(array.Length);
            byte* dst = (byte*)unmanagedArray.header;
            GCHandle handle = GCHandle.Alloc(array, GCHandleType.Pinned);
            IntPtr address = System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
            byte* src = (byte*)address;
            for (int i = 0; i < unmanagedArray.ByteLength; i++) {
                dst[i] = src[i];
            }
            handle.Free();

            return unmanagedArray.header;
        }
    }

}


