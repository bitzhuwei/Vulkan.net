using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;

namespace Vulkan_Tutorial {
    unsafe partial class Renderer {

        public void Cleanup() {
            vkDestroyDevice(device, null);

            if (enableValidationLayers) {
                vkAPI.DestroyDebugUtilsMessengerEXT(instance, debugMessenger, null);
            }

            vkDestroyInstance(instance, null);

        }
    }
}
