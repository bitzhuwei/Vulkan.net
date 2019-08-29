using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class RenderPassCreateInfo : IDisposable {
        internal readonly VkRenderPassCreateInfo* info;
        private readonly UnmanagedArray<VkRenderPassCreateInfo> disposable;

        public RenderPassCreateInfo() {
            var disposable = new UnmanagedArray<VkRenderPassCreateInfo>(1);
            var info = (VkRenderPassCreateInfo*)disposable.header;
            info->SType = VkStructureType.RenderPassCreateInfo;
            this.info = info;
            this.disposable = disposable;
        }

        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public UInt32 Flags { get { return info->Flags; } set { info->Flags = value; } }
        public UInt32 AttachmentCount { get { return info->AttachmentCount; } }
        public VkAttachmentDescription[] Attachments {
            get { return Helper.Get<VkAttachmentDescription>(info->Attachments, info->AttachmentCount); }
            set { Helper.Set(value, ref info->Attachments, ref info->AttachmentCount); }
        }
        public UInt32 SubpassCount { get { return info->SubpassCount; } }
        public VkSubpassDescription[] Subpasses {
            get { return Helper.Get<VkSubpassDescription>(info->Subpasses, info->SubpassCount); }
            set { Helper.Set(value, ref info->Subpasses, ref info->SubpassCount); }
        }
        public UInt32 DependencyCount { get { return info->DependencyCount; } }
        public VkSubpassDependency[] Dependencies {
            get { return Helper.Get<VkSubpassDependency>(info->Dependencies, info->DependencyCount); }
            set { Helper.Set(value, ref info->Dependencies, ref info->DependencyCount); }
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
        ~RenderPassCreateInfo() {
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
                //Helper.DisposeStructs(ref info->Subpasses, ref info->SubpassCount);
                //Helper.DisposeStructs(ref info->Dependencies, ref info->DependencyCount);

                this.disposedValue = true;
            } // end sub

            #endregion IDisposable Members

        }
    }
}

