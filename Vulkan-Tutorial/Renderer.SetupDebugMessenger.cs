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

        //private static vkCreateDebugUtilsMessengerEXT delCreateDebugUtilsMessengerEXT;
        //static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance,
        //    VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo,
        //    VkAllocationCallbacks* pAllocator,
        //    VkDebugUtilsMessengerEXT* pDebugMessenger) {
        //    if (delCreateDebugUtilsMessengerEXT == null) {
        //        IntPtr procHandle = vkAPI.vkGetInstanceProcAddr(instance, "vkCreateDebugReportCallbackEXT");
        //        delCreateDebugUtilsMessengerEXT = (vkCreateDebugUtilsMessengerEXT)Marshal.GetDelegateForFunctionPointer(procHandle, typeof(vkCreateDebugUtilsMessengerEXT));
        //    }

        //    if (delCreateDebugUtilsMessengerEXT != null) {
        //        return delCreateDebugUtilsMessengerEXT(instance, pCreateInfo, pAllocator, pDebugMessenger);
        //    }
        //    else {
        //        return VkResult.ErrorExtensionNotPresent;
        //    }
        //}

        //private static vkDestroyDebugUtilsMessengerEXT delDestroyDebugUtilsMessengerEXT;
        //static void DestroyDebugUtilsMessengerEXT(VkInstance instance,
        //     VkDebugUtilsMessengerEXT debugMessenger,
        //     VkAllocationCallbacks* pAllocator) {
        //    if (delDestroyDebugUtilsMessengerEXT == null) {
        //        IntPtr procHandle = vkAPI.vkGetInstanceProcAddr(instance, "vkCreateDebugReportCallbackEXT");
        //        delDestroyDebugUtilsMessengerEXT = (vkDestroyDebugUtilsMessengerEXT)Marshal.GetDelegateForFunctionPointer(procHandle, typeof(vkDestroyDebugUtilsMessengerEXT));
        //    }

        //    if (delDestroyDebugUtilsMessengerEXT != null) {
        //        delDestroyDebugUtilsMessengerEXT(instance, debugMessenger, pAllocator);
        //    }
        //}

        private void SetupDebugMessenger() {
            if (!enableValidationLayers) return;

            var createInfo = VkDebugUtilsMessengerCreateInfoEXT.Alloc();
            populateDebugMessengerCreateInfo(createInfo);

            VkDebugUtilsMessengerEXT handle;
            vkAPI.CreateDebugUtilsMessengerEXT(instance, createInfo, null, &handle);
            this.debugMessenger = handle;
        }
    }
}
