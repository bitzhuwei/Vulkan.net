using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;

namespace Lesson01lear {
    unsafe class LessonClear {
        VkInstance vkIntance;
        VkPhysicalDevice vkPhysicalDevice;
        VkDevice vkDevice;
        VkQueue vkQueue;

        public void Init() {
            InitInstance();

        }

        private void InitInstance() {
            VkLayerProperties[] layerProperties;
            Layer.EnumerateInstanceLayerProperties(out layerProperties).Check();

            var layersToEnable = layerProperties.Any(l => StringHelper.ToStringAnsi(l.LayerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = new UnmanagedArray<VkApplicationInfo>(1);
            {
                var item = (VkApplicationInfo*)appInfo.header;
                item->ApiVersion = Vulkan.Version.Make(1, 0, 0);
            }
            var info = new VkInstanceCreateInfo {
                EnabledExtensionNames = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" }.ToPtr(),
                EnabledLayerNames = layersToEnable.ToPtr(),
                ApplicationInfo = appInfo.header
            };

            VkInstance.Create(ref info, null, out this.vkIntance).Check();

            //this.vkInstance.EnableDebug(DebugCallback);
        }

        public void Render() {

        }
    }
}
