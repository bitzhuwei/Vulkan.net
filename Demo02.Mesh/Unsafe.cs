using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Demo02.Mesh {

    public static unsafe class Unsafe {
        /// <summary>
        /// Copies bytes from the source address to the destination address.
        /// </summary>
        /// <param name="destination">The destination address to copy to.</param>
        /// <param name="source">The source address to copy from.</param>
        /// <param name="byteCount">The number of bytes to copy.</param>
        public static void CopyBlock(IntPtr destination, void* source, uint byteCount) {
            var dst = (byte*)destination;
            var src = (byte*)source;

            for (int i = 0; i < byteCount; i++) {
                dst[i] = src[i];
            }
        }

        /// <summary>
        /// Copies bytes from the source address to the destination address.
        /// </summary>
        /// <param name="destination">The destination address to copy to.</param>
        /// <param name="source">The source address to copy from.</param>
        /// <param name="byteCount">The number of bytes to copy.</param>
        public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) {
            var dst = (byte*)(new IntPtr(destination));
            var src = (byte*)(new IntPtr(source));

            for (int i = 0; i < byteCount; i++) {
                dst[i] = src[i];
            }
        }

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        /// <typeparam name="T">The type of value to copy.</typeparam>
        /// <param name="destination">The location to copy to.</param>
        /// <param name="source">A reference to the value to copy.</param>
        public static void Copy<T>(IntPtr destination, ref T source) {
            int elementSize = Marshal.SizeOf<T>();
            uint byteCount = (uint)(elementSize * 1);
            var dst = (byte*)destination;
            GCHandle pin = GCHandle.Alloc(source, GCHandleType.Pinned);
            var src = (byte*)(pin.AddrOfPinnedObject());

            for (int i = 0; i < byteCount; i++) {
                dst[i] = src[i];
            }

            pin.Free();
        }

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        /// <typeparam name="T">The type of value to copy.</typeparam>
        /// <param name="destination">The location to copy to.</param>
        /// <param name="source">A pointer to the value to copy.</param>
        public static void Copy<T>(ref T destination, IntPtr source) {
            int elementSize = Marshal.SizeOf<T>();
            uint byteCount = (uint)(elementSize * 1);
            var src = (byte*)source;
            GCHandle pin = GCHandle.Alloc(destination, GCHandleType.Pinned);
            var dst = (byte*)(pin.AddrOfPinnedObject());

            for (int i = 0; i < byteCount; i++) {
                dst[i] = src[i];
            }

            pin.Free();
        }

    }
}
