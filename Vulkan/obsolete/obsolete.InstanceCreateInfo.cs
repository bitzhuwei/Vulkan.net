using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class InstanceCreateInfo : IDisposable {
        internal readonly VkInstanceCreateInfo* info;
        private readonly UnmanagedArray<VkInstanceCreateInfo> disposable;

        public InstanceCreateInfo() {
            var disposable = new UnmanagedArray<VkInstanceCreateInfo>(1);
            var info = (VkInstanceCreateInfo*)disposable.header;
            info->SType = VkStructureType.InstanceCreateInfo;
            this.info = info;
            this.disposable = disposable;
        }
        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public UInt32 Flags { get { return info->Flags; } set { info->Flags = value; } }
        public VkApplicationInfo* ApplicationInfo { get { return (VkApplicationInfo*)info->ApplicationInfo; } set { info->ApplicationInfo = (IntPtr)((void*)value); } }
        public UInt32 EnabledLayerCount { get { return info->EnabledLayerCount; } }
        public string[] EnabledLayerNames {
            get { return Helper.Get(info->EnabledLayerNames, info->EnabledLayerCount); }
            set { Helper.Set(value, ref info->EnabledLayerNames, ref info->EnabledLayerCount); }
        }
        public UInt32 EnabledExtensionCount { get { return info->EnabledExtensionCount; } }
        public string[] EnabledExtensionNames {
            get { return Helper.Get(info->EnabledExtensionNames, info->EnabledExtensionCount); }
            set { Helper.Set(value, ref info->EnabledExtensionNames, ref info->EnabledExtensionCount); }
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
        ~InstanceCreateInfo() {
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
                //Helper.DisposeStrings(ref info->EnabledLayerNames, ref info->EnabledLayerCount);
                //Helper.DisposeStrings(ref info->EnabledExtensionNames, ref info->EnabledExtensionCount);
            }

            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members

    }
}
