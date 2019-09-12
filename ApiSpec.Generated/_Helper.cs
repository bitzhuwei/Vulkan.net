using System;
using System.Runtime.InteropServices;

namespace ApiSpec.Generated {
    public unsafe static partial class Helper {

        public static string[] Get(IntPtr target, UInt32 count) {
            string[] result = null;
            var pointer = (IntPtr*)(target.ToPointer());
            if (pointer != null) {
                result = new string[count];
                for (int i = 0; i < count; i++) {
                    result[i] = Marshal.PtrToStringAnsi(pointer[i]);
                }
            }
            return result;
        }

        //public static void DisposeStrings(ref IntPtr target, ref UInt32 count) {
        //    var pointer = (IntPtr*)(target.ToPointer());
        //    if (pointer != null) {
        //        for (int i = 0; i < count; i++) {
        //            Marshal.FreeHGlobal(pointer[i]);
        //        }
        //        target = IntPtr.Zero;
        //        count = 0;
        //    }
        //}

        /// <summary>
        /// Set a string to specified <paramref name="target"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target">address of string.</param>
        public static void Set(this string value, ref IntPtr target) {
            {   // free unmanaged memory.
                if (target != IntPtr.Zero) {
                    Marshal.FreeHGlobal(target);
                    target = IntPtr.Zero;
                }
            }
            {
                if (value != null && value.Length > 0) {
                    target = Marshal.StringToHGlobalAnsi(value);
                }
                else {
                    target = IntPtr.Zero;
                }
            }
        }

        /// <summary>
        /// Set an array of strings to specified <paramref name="target"/> and <paramref name="count"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target">address of first element/array.</param>
        /// <param name="count">How many elements?</param>
        public static void Set(this string[] value, ref IntPtr* target, ref UInt32 count) {
            {   // free unmanaged memory.
                if (target != null) {
                    for (int i = 0; i < count; i++) {
                        Marshal.FreeHGlobal(target[i]);
                    }
                }
            }
            {
                int length = value.Length;
                if (length > 0) {
                    int elementSize = Marshal.SizeOf(typeof(IntPtr));
                    int byteLength = (int)(length * elementSize);
                    IntPtr array = Marshal.AllocHGlobal(byteLength);
                    IntPtr* pointer = (IntPtr*)array.ToPointer();
                    for (int i = 0; i < length; i++) {
                        IntPtr str = Marshal.StringToHGlobalAnsi(value[i]);
                        pointer[i] = str;
                    }
                    target = pointer;
                }
                count = (UInt32)length;
            }
        }

        public static T[] Get<T>(IntPtr target, UInt32 count) where T : struct {
            T[] result = null;
            if (target != IntPtr.Zero) {
                result = new T[count];
                if (count > 0) {
                    GCHandle pin = GCHandle.Alloc(result, GCHandleType.Pinned);
                    IntPtr address = Marshal.UnsafeAddrOfPinnedArrayElement(result, 0);
                    var dst = (byte*)address;
                    var src = (byte*)target;
                    int elementSize = Marshal.SizeOf(typeof(T));
                    int byteLength = (int)(count * elementSize);
                    for (int i = 0; i < byteLength; i++) {
                        dst[i] = src[i];
                    }
                    pin.Free();
                }
            }

            return result;
        }

        //public static void DisposeStructs(ref IntPtr target, ref UInt32 count) {
        //    if (target != IntPtr.Zero) {
        //        Marshal.FreeHGlobal(target);
        //        target = IntPtr.Zero;
        //        count = 0;
        //    }
        //}

        /// <summary>
        /// Set an array of structs to specified <paramref name="target"/> and <paramref name="count"/>.
        /// <para>Enumeration types are not allowed to use this method.
        /// If you have to, convert them to byte/short/ushort/int/uint according to their underlying types first.</para>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target">address of first element/array.</param>
        /// <param name="count">How many elements?</param>
        public static void Set<T>(this T[] value, ref IntPtr target, ref UInt32 count) where T : struct {
            {   // free unmanaged memory.
                if (target != IntPtr.Zero) {
                    Marshal.FreeHGlobal(target);
                    target = IntPtr.Zero;
                    count = 0;
                }
            }
            {
                count = (UInt32)value.Length;

                int elementSize = Marshal.SizeOf<T>();
                int byteLength = (int)(count * elementSize);
                IntPtr array = Marshal.AllocHGlobal(byteLength);
                var dst = (byte*)array;
                GCHandle pin = GCHandle.Alloc(value, GCHandleType.Pinned);
                IntPtr address = Marshal.UnsafeAddrOfPinnedArrayElement(value, 0);
                var src = (byte*)address;
                for (int i = 0; i < byteLength; i++) {
                    dst[i] = src[i];
                }
                pin.Free();

                target = array;
            }
        }

        ///// <summary>
        /////
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="structObj"></param>
        ///// <returns></returns>
        //static byte[] ToBytes<T>(this T structObj) where T : struct {
        //    Int32 size = Marshal.SizeOf(structObj);
        //    Byte[] bytes = new Byte[size];
        //    IntPtr buffer = IntPtr.Zero;
        //    try {
        //        buffer = Marshal.AllocHGlobal(size);
        //        Marshal.StructureToPtr(structObj, buffer, false);
        //        Marshal.Copy(buffer, bytes, 0, size);
        //    } finally {
        //        Marshal.FreeHGlobal(buffer);
        //    }

        //    return bytes;
        //}
    }

    public static class ResultHelper {
        public static VkResult Check(this VkResult result) {
            if (result != VkResult.VK_SUCCESS) { throw new ResultException(result); }

            return result;
        }
    }

    public class ResultException : Exception {
        internal VkResult result;

        public VkResult Result {
            get { return result; }
        }

        internal ResultException(VkResult res) {
            result = res;
        }
    }

    public class Version {
        public static UInt32 Make(uint major, uint minor, uint patch) {
            return (major << 22) | (minor << 12) | patch;
        }

        public static string ToString(uint version) {
            return string.Format("{0}.{1}.{2}", version >> 22, (version >> 12) & 0x3ff, version & 0xfff);
        }
    }
}
