using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkInstance {
        public VkResult EnumeratePhysicalDevices(out VkPhysicalDevice[] physicalDevices) {
            return VkPhysicalDevice.Enumerate(this, out physicalDevices);
        }

    }
}

