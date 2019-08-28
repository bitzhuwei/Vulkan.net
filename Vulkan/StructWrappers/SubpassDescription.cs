using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class SubpassDescription : IDisposable {
        public readonly VkSubpassDescription* info;
        private readonly UnmanagedArray<VkSubpassDescription> disposable;

        public SubpassDescription() {
            var disposable = new UnmanagedArray<VkSubpassDescription>(1);
            var info = (VkSubpassDescription*)disposable.header;
            //info->SType = ..;
            this.info = info;
            this.disposable = disposable;
        }

        public VkSubpassDescriptionFlags Flags { get { return info->Flags; } set { info->Flags = value; } }
        public VkPipelineBindPoint PipelineBindPoint { get { return info->PipelineBindPoint; } set { info->PipelineBindPoint = value; } }
        public UInt32 InputAttachmentCount { get { return info->InputAttachmentCount; } }
        public IntPtr[] InputAttachments {
            get { return Helper.Get<IntPtr>(info->InputAttachments, info->InputAttachmentCount); }
            set { Helper.Set(value, ref info->InputAttachments, ref info->InputAttachmentCount); }
        }
        public UInt32 ColorAttachmentCount { get { return info->ColorAttachmentCount; } }
        public UInt32[] ColorAttachments {
            get { return Helper.Get<UInt32>(info->ColorAttachments, info->ColorAttachmentCount); }
            set { Helper.Set(value, ref info->ColorAttachments, ref info->ColorAttachmentCount); }
        }
        public IntPtr ResolveAttachments { get { return info->ResolveAttachments; } set { info->ResolveAttachments = value; } }
        public IntPtr DepthStencilAttachment { get { return info->DepthStencilAttachment; } set { info->DepthStencilAttachment = value; } }
        public UInt32 PreserveAttachmentCount { get { return info->PreserveAttachmentCount; } }
        public IntPtr[] PreserveAttachments {
            get { return Helper.Get<IntPtr>(info->PreserveAttachments, info->PreserveAttachmentCount); }
            set { Helper.Set(value, ref info->PreserveAttachments, ref info->PreserveAttachmentCount); }
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
        ~SubpassDescription() {
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
                //Helper.DisposeStructs(ref info->InputAttachments, ref info->InputAttachmentCount);
                //Helper.DisposeStructs(ref info->ColorAttachments, ref info->ColorAttachmentCount);
                //Helper.DisposeStructs(ref info->PreserveAttachments, ref info->PreserveAttachmentCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
