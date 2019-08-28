using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class RenderPassBeginInfo : IDisposable {
        internal readonly VkRenderPassBeginInfo* info;
        private readonly UnmanagedArray<VkRenderPassBeginInfo> disposable;

        public RenderPassBeginInfo() {
            var disposable = new UnmanagedArray<VkRenderPassBeginInfo>(1);
            var info = (VkRenderPassBeginInfo*)disposable.header;
            info->SType = VkStructureType.RenderPassBeginInfo;
            this.info = info;
            this.disposable = disposable;
        }
        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public UInt64 RenderPass { get { return info->RenderPass; } set { info->RenderPass = value; } }
        public UInt64 Framebuffer { get { return info->Framebuffer; } set { info->Framebuffer = value; } }
        public VkRect2D RenderArea { get { return info->RenderArea; } set { info->RenderArea = value; } }
        public UInt32 ClearValueCount { get { return info->ClearValueCount; } }
        public VkClearValue[] ClearValues {
            get { return Helper.Get<VkClearValue>(info->ClearValues, info->ClearValueCount); }
            set { Helper.Set(value, ref info->ClearValues, ref info->ClearValueCount); }
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
        ~RenderPassBeginInfo() {
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
                //Helper.DisposeStructs(ref info->ClearValues, ref info->ClearValueCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
