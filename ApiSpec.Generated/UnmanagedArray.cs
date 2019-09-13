using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ApiSpec.Generated {
    /// <summary>
    /// unmanaged array.
    /// <para>Similar to array in <code>int array[Length];</code></para>
    /// </summary>
    public unsafe class UnmanagedArray<T> : IDisposable where T : struct {
        /// <summary>
        /// 此非托管数组中的数据在内存中的起始地址
        /// Start position of array; Head of array; first element's position of array.
        /// <para>Similar to <code>array</code> in <code>int array[Length];</code></para>
        /// </summary>
        public readonly IntPtr header;

        /// <summary>
        /// How many elements?
        /// <para>Similar to <code>Length</code> in <code>int array[Length];</code></para>
        /// </summary>
        public readonly int length;

        /// <summary>
        /// 单个元素的字节数。
        /// <para>How manay bytes for one element of array?</para>
        /// </summary>
        protected int elementSize;

        /// <summary>
        /// 申请到的字节数。（元素的总数 * 单个元素的字节数）。
        /// <para>How many bytes for total array?</para>
        /// <para>Length * elementSize</para>
        /// </summary>
        public int ByteLength {
            get { return (this.length * this.elementSize); }
        }

        /// <summary>
        /// unmanaged array.
        /// </summary>
        /// <param name="elementCount"></param>
        public UnmanagedArray(int elementCount, bool reset = true) {
            Debug.Assert(elementCount > 0);

            int elementSize = Marshal.SizeOf(typeof(T));
            int memSize = elementCount * elementSize;
            this.header = Marshal.AllocHGlobal(memSize);
            this.length = elementCount;
            this.elementSize = elementSize;

            if (reset) {
                byte* bytes = (byte*)this.header;
                int byteLength = this.length * this.elementSize;
                for (int i = 0; i < byteLength; i++) {
                    bytes[i] = 0;
                }
            }
        }

        /// <summary>
        /// Make sure that an unmanaged memory will be freed.
        /// </summary>
        /// <param name="header"></param>
        /// <param name="elementCount"></param>
        public UnmanagedArray(IntPtr header, int elementCount, bool reset = true) {
            Debug.Assert(header != IntPtr.Zero && elementCount > 0);

            int elementSize = Marshal.SizeOf(typeof(T));
            this.header = header;
            this.length = elementCount;
            this.elementSize = elementSize;

            if (reset) {
                byte* bytes = (byte*)this.header;
                int byteLength = this.length * this.elementSize;
                for (int i = 0; i < byteLength; i++) {
                    bytes[i] = 0;
                }
            }
        }

        //// Do not try to use less effitient way of accessing elements as we're using Vulkan.
        //// 既然要用Vulkan，就不要试图才用低效的方式了。
        ///// <summary>
        ///// gets/sets element's value at specified <paramref name="index"/>.
        ///// <para>Please use unsafe way when dealing with big data for efficiency purpose.</para>
        ///// 获取或设置索引为<paramref name="index"/>的元素。
        ///// <para>如果要处理的元素数目较大，请使用unsafe方式（为提高效率）。</para>
        ///// </summary>
        ///// <param name="index"></param>
        ///// <returns></returns>
        //public unsafe T this[int index] {
        //    get {
        //        if (index < 0 || index >= this.length)
        //            throw new IndexOutOfRangeException("index of UnmanagedArray is out of range");

        //        var pItem = new IntPtr(this.header.ToInt64() + (index * elementSize));
        //        var obj = Marshal.PtrToStructure(pItem, typeof(T));
        //        T result = (T)obj;
        //        //T result = Marshal.PtrToStructure<T>(pItem);// works in .net 4.5.1
        //        return result;
        //    }
        //    set {
        //        if (index < 0 || index >= this.length)
        //            throw new IndexOutOfRangeException("index of UnmanagedArray is out of range");

        //        var pItem = new IntPtr(this.header.ToInt64() + (index * elementSize));
        //        Marshal.StructureToPtr(value, pItem, true);
        //        //Marshal.StructureToPtr<T>(value, pItem, true);// works in .net 4.5.1
        //    }
        //}

        /// <summary>
        /// return string.Format("head: {0}, element count: {1}, byte length: {2}",
        ///     this.Header, this.Length, this.ByteLength);
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return string.Format("head: {0}, element count: {1}, byte length: {2}",
                this.header, this.length, this.ByteLength);
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        } // end sub

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~UnmanagedArray() {
            this.Dispose(false);
        }

        /// <summary>
        /// Backing field to track whether Dispose has been called.
        /// </summary>
        private bool disposedValue = false;

        /// <summary>
        /// Dispose managed and unmanaged resources of this instance.
        /// </summary>
        /// <param name="disposing">If disposing equals true, managed and unmanaged resources can be disposed. If disposing equals false, only unmanaged resources can be disposed. </param>
        private void Dispose(bool disposing) {
            if (this.disposedValue == false) {
                if (disposing) {
                    // Dispose managed resources.
                }

                // Dispose unmanaged resources.
                Marshal.FreeHGlobal(this.header);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}