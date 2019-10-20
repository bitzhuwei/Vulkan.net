using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Vulkan {

    public static unsafe partial class vkAPI {
        /// <summary>
        /// Copies bytes from the source address to the destination address.
        /// </summary>
        /// <param name="source">The source address to copy from.</param>
        /// <param name="destination">The destination address to copy to.</param>
        /// <param name="byteCount">The number of bytes to copy.</param>
        public static void Copy(IntPtr source, IntPtr destination, uint byteCount) {
            var src = (byte*)source;
            var dst = (byte*)destination;

            for (int i = 0; i < byteCount; i++) {
                dst[i] = src[i];
            }
        }

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        /// <typeparam name="T">The type of value to copy.</typeparam>
        /// <param name="source">A reference to the value to copy.</param>
        /// <param name="destination">The location to copy to.</param>
        public static void Copy<T>(ref T source, IntPtr destination) where T : struct {
            int elementSize = Marshal.SizeOf<T>();
            uint byteCount = (uint)(elementSize * 1);
            GCHandle pin = GCHandle.Alloc(source, GCHandleType.Pinned);
            var src = pin.AddrOfPinnedObject();
            Copy(src, destination, byteCount);
            pin.Free();
        }

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        /// <typeparam name="T">The type of value to copy.</typeparam>
        /// <param name="source">A reference to the value to copy.</param>
        /// <param name="destination">The location to copy to.</param>
        public static void Copy<T>(T[] source, IntPtr destination) where T : struct {
            int elementSize = Marshal.SizeOf<T>();
            uint byteCount = (uint)(elementSize * source.Length);
            GCHandle pin = GCHandle.Alloc(source, GCHandleType.Pinned);
            IntPtr src = pin.AddrOfPinnedObject();
            Copy(src, destination, byteCount);
            pin.Free();
        }

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        /// <typeparam name="T">The type of value to copy.</typeparam>
        /// <param name="source">A pointer to the value to copy.</param>
        /// <param name="destination">The location to copy to.</param>
        public static void Copy<T>(IntPtr source, ref T destination) where T : struct {
            int elementSize = Marshal.SizeOf<T>();
            uint byteCount = (uint)(elementSize * 1);
            GCHandle pin = GCHandle.Alloc(destination, GCHandleType.Pinned);
            IntPtr dst = pin.AddrOfPinnedObject();
            Copy(source, dst, byteCount);
            pin.Free();
        }

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        /// <typeparam name="T">The type of value to copy.</typeparam>
        /// <param name="source">A reference to the value to copy.</param>
        /// <param name="destination">The location to copy to.</param>
        public static void Copy<T>(IntPtr source, ref T[] destination) where T : struct {
            int elementSize = Marshal.SizeOf<T>();
            uint byteCount = (uint)(elementSize * destination.Length);
            GCHandle pin = GCHandle.Alloc(destination, GCHandleType.Pinned);
            IntPtr dst = pin.AddrOfPinnedObject();
            Copy(source, dst, byteCount);
            pin.Free();
        }
    }
}
