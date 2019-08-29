using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class SubmitInfo : IDisposable {
        internal readonly VkSubmitInfo* info;
        private readonly UnmanagedArray<VkSubmitInfo> disposable;

        public SubmitInfo() {
            var disposable = new UnmanagedArray<VkSubmitInfo>(1);
            var info = (VkSubmitInfo*)disposable.header;
            info->SType = VkStructureType.SubmitInfo;
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
        private UInt32 waitDstStageMaskCount;
        public VkPipelineStageFlags[] WaitDstStageMask {
            get {
                int[] values = Helper.Get<int>(info->WaitDstStageMask, waitDstStageMaskCount);
                var result = new VkPipelineStageFlags[values.Length];
                for (int i = 0; i < values.Length; i++) {
                    result[i] = (VkPipelineStageFlags)values[i];
                }

                return result;
            }
            set {
                int[] values = new int[value.Length];
                for (int i = 0; i < value.Length; i++) {
                    values[i] = (int)value[i];
                }
                Helper.Set(values, ref info->WaitDstStageMask, ref waitDstStageMaskCount);
            }
        }
        public UInt32 CommandBufferCount { get { return info->CommandBufferCount; } }
        public IntPtr[] CommandBuffers {
            get { return Helper.Get<IntPtr>(info->CommandBuffers, info->CommandBufferCount); }
            set { Helper.Set(value, ref info->CommandBuffers, ref info->CommandBufferCount); }
        }
        public UInt32 SignalSemaphoreCount { get { return info->SignalSemaphoreCount; } }
        public UInt64[] SignalSemaphores {
            get { return Helper.Get<UInt64>(info->SignalSemaphores, info->SignalSemaphoreCount); }
            set { Helper.Set(value, ref info->SignalSemaphores, ref info->SignalSemaphoreCount); }
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
        ~SubmitInfo() {
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
                //Helper.DisposeStructs(ref info->WaitDstStageMask, ref waitDstStageMaskCount);
                //Helper.DisposeStructs(ref info->CommandBuffers, ref info->CommandBufferCount);
                //Helper.DisposeStructs(ref info->SignalSemaphores, ref info->SignalSemaphoreCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
