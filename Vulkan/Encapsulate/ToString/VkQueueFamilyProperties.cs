using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkQueueFamilyProperties {
        public override string ToString() {
            return $"fllags:{queueFlags}, count:{queueCount}, time:{timestampValidBits}, min:{minImageTransferGranularity}";
        }
    }
}
