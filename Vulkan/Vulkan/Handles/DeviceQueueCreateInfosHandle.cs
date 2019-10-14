using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct DeviceQueueCreateInfosHandle {
        public UInt32 count;
        public VkDeviceQueueCreateInfo* array;

        public DeviceQueueCreateInfosHandle(params VkDeviceQueueCreateInfo[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDeviceQueueCreateInfo*)ptr;
        }

        public void Set(params VkDeviceQueueCreateInfo[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDeviceQueueCreateInfo*)ptr;
        }

        public static implicit operator DeviceQueueCreateInfosHandle(VkDeviceQueueCreateInfo v) {
            return new DeviceQueueCreateInfosHandle(new VkDeviceQueueCreateInfo[] { v });
        }

        public static implicit operator DeviceQueueCreateInfosHandle(VkDeviceQueueCreateInfo[] v) {
            return new DeviceQueueCreateInfosHandle(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDeviceQueueCreateInfo)}[{count}]";
            }
        }
    }
}
