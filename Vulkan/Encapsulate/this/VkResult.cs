using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public static class VkResultHelper {
        public static VkResult Check(this VkResult result) {
            if (result != VkResult.Success) { throw new ResultException(result); }

            return result;
        }
    }

    public class ResultException : Exception {
        internal VkResult result;

        public VkResult Result {
            get { return result; }
        }

        internal ResultException(VkResult res) {
            result = res;
        }
    }
}
