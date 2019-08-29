using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe class DeviceCreateInfo : IDisposable {
        internal readonly VkDeviceCreateInfo* info;
        private readonly UnmanagedArray<VkDeviceCreateInfo> disposable;

        public DeviceCreateInfo() {
            var disposable = new UnmanagedArray<VkDeviceCreateInfo>(1);
            var info = (VkDeviceCreateInfo*)disposable.header;
            info->SType = VkStructureType.DeviceCreateInfo;
            this.info = info;
            this.disposable = disposable;
        }

        public VkStructureType SType { get { return info->SType; } }
        public IntPtr Next { get { return info->Next; } set { info->Next = value; } }
        public UInt32 Flags { get { return info->Flags; } set { info->Flags = value; } }

        public UInt32 QueueCreateInfoCount { get { return info->QueueCreateInfoCount; } }
        public VkDeviceQueueCreateInfo[] QueueCreateInfos {
            get { return Helper.Get<VkDeviceQueueCreateInfo>(info->QueueCreateInfos, info->QueueCreateInfoCount); }
            set { Helper.Set(value, ref info->QueueCreateInfos, ref info->QueueCreateInfoCount); }
        }

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

        public IntPtr EnabledFeatures;

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
        ~DeviceCreateInfo() {
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
                //Helper.DisposeStructs(ref this.info->QueueCreateInfos, ref this.info->QueueCreateInfoCount);
            }
            this.disposedValue = true;
        } // end sub

        #endregion IDisposable Members


    }
}
