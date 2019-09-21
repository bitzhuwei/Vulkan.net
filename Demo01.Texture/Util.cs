using System;
using Vulkan;

namespace Demo01.Texture {
    public static class Util {
        public static VkResult CheckResult(this VkResult result) {
            if (result != VkResult.Success) {
                throw new InvalidOperationException("Call failed.");
            }

            return result;
        }

        public static float DegreesToRadians(float degrees) {
            return degrees * (float)Math.PI / 180f;
        }
    }
}
