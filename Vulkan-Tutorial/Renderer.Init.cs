using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;

namespace Vulkan_Tutorial {
    unsafe partial class Renderer {

        public void Init(IntPtr canvas) {
            //vkEnumerateInstanceExtensionProperties
            VkExtensionProperties[] properties = Tutorial.InstanceExtensionProperties();
            Console.WriteLine($"{properties.Length} extensions supported.");

            CreateInstance();
            SetupDebugMessenger();
            PickPhysicalDevice();
            CreateLogicalDevice();
        }

    }
}
