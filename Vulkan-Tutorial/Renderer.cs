using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;

namespace Vulkan_Tutorial {
    unsafe partial class Renderer {

        private VkInstance instance;
        private VkDebugUtilsMessengerEXT debugMessenger;
        VkSurfaceKHR surface;

        VkPhysicalDevice physicalDevice;
        VkDevice device;

        VkQueue graphicsQueue;
        VkQueue presentQueue;

        public void Render() {

        }
    }
}
