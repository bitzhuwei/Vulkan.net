using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class FramebufferCreateInfo : IDisposable {
        internal readonly VkFramebufferCreateInfo* info;
        private readonly UnmanagedArray<VkFramebufferCreateInfo> disposable;

        public FramebufferCreateInfo() {
            var disposable = new UnmanagedArray<VkFramebufferCreateInfo>(1);
            var info = (VkFramebufferCreateInfo*)disposable.header;
            info->SType = VkStructureType.FramebufferCreateInfo;
            this.info = info;
            this.disposable = disposable;
        }

        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public UInt32 Flags { get { return info->Flags; } set { info->Flags = value; } }
        public UInt64 RenderPass { get { return info->RenderPass; } set { info->RenderPass = value; } }
        public UInt32 AttachmentCount { get { return info->AttachmentCount; } }
        public UInt64[] Attachments {
            get { return Helper.Get<UInt64>(info->Attachments, info->AttachmentCount); }
            set { Helper.Set(value, ref info->Attachments, ref info->AttachmentCount); }
        }
        public UInt32 Width { get { return info->Width; } set { info->Width = value; } }
        public UInt32 Height { get { return info->Height; } set { info->Height = value; } }
        public UInt32 Layers { get { return info->Layers; } set { info->Layers = value; } }

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
        ~FramebufferCreateInfo() {
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
                //Helper.DisposeStructs(ref info->Attachments, ref info->AttachmentCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
