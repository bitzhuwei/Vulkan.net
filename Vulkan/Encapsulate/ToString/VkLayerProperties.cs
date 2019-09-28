using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkLayerProperties {
        public override string ToString() {
            string layerName;
            fixed (byte* pointer = this.layerName) {
                layerName = Marshal.PtrToStringAnsi((IntPtr)pointer);
            }
            string desc;
            fixed (byte* pointer = this.description) {
                desc = Marshal.PtrToStringAnsi((IntPtr)pointer);
            }

            return $"{layerName}, {desc}, {specVersion}";
        }

    }
}
