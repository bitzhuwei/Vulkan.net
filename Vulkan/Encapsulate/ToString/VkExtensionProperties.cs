using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkExtensionProperties {
        public override string ToString() {
            string name;
            fixed (byte* pointer = this.extensionName) {
                name = Marshal.PtrToStringAnsi((IntPtr)pointer);
            }

            return $"{name}, {specVersion}";
        }

    }
}
