using System;
using System.Runtime.InteropServices;

namespace Vulkan {

    public class VkVersion {
        public static UInt32 Make(uint major, uint minor, uint patch) {
            return (major << 22) | (minor << 12) | patch;
        }

        public static string ToString(uint version) {
            return string.Format("{0}.{1}.{2}", version >> 22, (version >> 12) & 0x3ff, version & 0xfff);
        }
    }
}
