using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial class vkAPI {
        private static vkCreateDebugReportCallbackEXT delCreateDebugReportCallbackEXT;
        // Command: 107
        /// <summary>vkCreateDebugReportCallback - Create a debug report callback object
        /// </summary>
        /// <param name="instance"> instance the instance the callback will be logged on.</param>
        /// <param name="pCreateInfo"> pCreateInfo points to a VkDebugReportCallbackCreateInfoEXT
        /// structure which defines the conditions under which this callback will be
        /// called.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pCallback"> pCallback is a pointer to record the
        /// VkDebugReportCallbackEXT object created.</param>
        public static VkResult vkCreateDebugReportCallback(
            VkInstance instance,
            /*-const-*/ VkDebugReportCallbackCreateInfoEXT* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDebugReportCallbackEXT* pCallback) {
            if (delCreateDebugReportCallbackEXT == null) {
                IntPtr procHandle = vkAPI.vkGetInstanceProcAddr(instance, "vkCreateDebugReportCallbackEXT");
                delCreateDebugReportCallbackEXT = (vkCreateDebugReportCallbackEXT)Marshal.GetDelegateForFunctionPointer(procHandle, typeof(vkCreateDebugReportCallbackEXT));
            }

            if (delCreateDebugReportCallbackEXT != null) {
                return delCreateDebugReportCallbackEXT(instance, pCreateInfo, pAllocator, pCallback);
            }
            else {
                return VkResult.ErrorExtensionNotPresent;
            }
        }

    }
}
