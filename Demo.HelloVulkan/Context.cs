using System;
using System.Collections.Generic;
using System.Text;
using Vulkan;

namespace Demo.HelloVulkan {
    public unsafe struct Context {
        public readonly VkInstance instance;
        public readonly VkPhysicalDevice physicalDevice;
        public readonly VkSurfaceKHR surface;

        public Context(VkInstance instance, VkPhysicalDevice physicalDevice, VkSurfaceKHR surface) {
            this.instance = instance;
            this.physicalDevice = physicalDevice;
            this.surface = surface;
        }

        public override string ToString() {
            return $"{instance}, {physicalDevice}, {surface}";
        }
    }
}
