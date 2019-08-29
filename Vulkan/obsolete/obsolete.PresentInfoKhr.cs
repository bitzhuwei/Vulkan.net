using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class PresentInfoKhr : IDisposable {
        internal readonly VkPresentInfoKhr* info;
        private readonly UnmanagedArray<VkPresentInfoKhr> disposable;

        public PresentInfoKhr() {
            var disposable = new UnmanagedArray<VkPresentInfoKhr>(1);
            var info = (VkPresentInfoKhr*)disposable.header;
            info->SType = VkStructureType.PresentInfoKhr;
            this.info = info;
            this.disposable = disposable;
        }

        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public UInt32 WaitSemaphoreCount { get { return info->WaitSemaphoreCount; } }
        public UInt64[] WaitSemaphores {
            get { return Helper.Get<UInt64>(info->WaitSemaphores, info->WaitSemaphoreCount); }
            set { Helper.Set(value, ref info->WaitSemaphores, ref info->WaitSemaphoreCount); }
        }
        public UInt32 SwapchainCount { get { return info->SwapchainCount; } }
        public UInt64[] Swapchains {
            get { return Helper.Get<UInt64>(info->Swapchains, info->SwapchainCount); }
            set { Helper.Set(value, ref info->Swapchains, ref info->SwapchainCount); }
        }
        private UInt32 imageIndexCount;
        public UInt32[] ImageIndices {
            get { return Helper.Get<UInt32>(info->ImageIndices, imageIndexCount); }
            set { Helper.Set(value, ref info->ImageIndices, ref imageIndexCount); }
        }

        public IntPtr Results;

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
        ~PresentInfoKhr() {
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
                //Helper.DisposeStructs(ref info->WaitSemaphores, ref info->WaitSemaphoreCount);
                //Helper.DisposeStructs(ref info->Swapchains, ref info->SwapchainCount);
                //Helper.DisposeStructs(ref info->ImageIndices, ref imageIndexCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
