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

#if NDEBUG
        bool enableValidationLayers = false;
#else
        bool enableValidationLayers = true;
#endif
        static readonly string[] validationLayers = new string[] {
            "VK_LAYER_KHRONOS_validation"
        };

        bool checkValidationLayerSupport() {
            VkLayerProperties[] availableLayers = Vk.InstanceLayerProperties();
            foreach (var layerName in validationLayers) {
                bool layerFound = false;

                foreach (var layerProperties in availableLayers) {
                    if (Marshal.PtrToStringAnsi((IntPtr)layerProperties.layerName) == layerName) {
                        layerFound = true;
                        break;
                    }
                }

                if (!layerFound) {
                    return false;
                }
            }

            return true;
        }

        static VkBool32 debugCallback(
            VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagBitsEXT messageType,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
            void* pUserData) {

            Console.WriteLine($"validation layer: {Marshal.PtrToStringAnsi(pCallbackData->pMessage)}");

            return false;
        }

        void populateDebugMessengerCreateInfo(VkDebugUtilsMessengerCreateInfoEXT* createInfo) {
            createInfo[0].messageSeverity = VkDebugUtilsMessageSeverityFlagBitsEXT.VerboseEXT
                | VkDebugUtilsMessageSeverityFlagBitsEXT.WarningEXT
                | VkDebugUtilsMessageSeverityFlagBitsEXT.ErrorEXT;
            createInfo[0].messageType = VkDebugUtilsMessageTypeFlagBitsEXT.GeneralEXT
                | VkDebugUtilsMessageTypeFlagBitsEXT.ValidationEXT
                | VkDebugUtilsMessageTypeFlagBitsEXT.PerformanceEXT;
            createInfo[0].pfnUserCallback = Marshal.GetFunctionPointerForDelegate(
                new PFN_vkDebugUtilsMessengerCallbackEXT(debugCallback));
        }

        private void CreateInstance() {
            if (enableValidationLayers && (!checkValidationLayerSupport())) {
                throw new Exception("validation layers requested, but not available!");
            }

            var appInfo = VkApplicationInfo.Alloc();
            //"Hello Triangle".Set(ref appInfo[0].pApplicationName);
            appInfo[0].pApplicationName = "Hello Triangle";
            appInfo[0].applicationVersion = VkVersion.Make(1, 0, 0);
            //"No Engine".Set(ref appInfo[0].pEngineName);
            appInfo[0].pEngineName = "No Engine";
            appInfo[0].engineVersion = VkVersion.Make(1, 0, 0);
            appInfo[0].apiVersion = VkVersion.Make(1, 0, 0);

            var createInfo = VkInstanceCreateInfo.Alloc();
            createInfo[0].pApplicationInfo = appInfo;

            string[] extensions;
            if (enableValidationLayers) {
                extensions = new string[] {
                    Vk.VK_KHR_surface, Vk.VK_KHR_win32_surface,
                    Vk.VK_EXT_debug_report, Vk.VK_EXT_debug_utils
                };
            }
            else {
                extensions = new string[] {
                    Vk.VK_KHR_surface, Vk.VK_KHR_win32_surface,
                    Vk.VK_EXT_debug_report
                };
            }
            //extensions.Set(ref createInfo[0].ppEnabledExtensionNames, ref createInfo[0].enabledExtensionCount);
            createInfo[0].EnabledExtensions = extensions;

            //    ? new[] { "VK_LAYER_LUNARG_standard_validation" }
            if (enableValidationLayers) {
                //validationLayers.Set(ref createInfo[0].ppEnabledLayerNames, ref createInfo[0].enabledLayerCount);
                createInfo[0].EnabledLayers = validationLayers;
            }

            var debugCreateInfo = VkDebugUtilsMessengerCreateInfoEXT.Alloc();
            if (enableValidationLayers) {
                populateDebugMessengerCreateInfo(debugCreateInfo);
                createInfo[0].pNext = debugCreateInfo;
            }

            VkInstance instance;
            vkCreateInstance(createInfo, null, &instance).Check();
            this.instance = instance;
        }
    }
}
