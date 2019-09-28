using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe static class VkShaderModuleCreateInfoHelper {
        public static void Set(this byte[] values, VkShaderModuleCreateInfo* info) {
            IntPtr ptr = (IntPtr)info->pCode;
            UInt32 size = (UInt32)info->codeSize;
            values.Set(ref ptr, ref size);
            info->pCode = (UInt32*)ptr; info->codeSize = (int)size;
        }
    }
}
