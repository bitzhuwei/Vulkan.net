using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo.Texture {
    public static class Strings {
        public const string VK_KHR_SURFACE_EXTENSION_NAME = "VK_KHR_surface";
        public const string VK_KHR_WIN32_SURFACE_EXTENSION_NAME = "VK_KHR_win32_surface";
        public const string VK_KHR_XCB_SURFACE_EXTENSION_NAME = "VK_KHR_xcb_surface";
        public const string VK_KHR_XLIB_SURFACE_EXTENSION_NAME = "VK_KHR_xlib_surface";
        public const string VK_KHR_SWAPCHAIN_EXTENSION_NAME = "VK_KHR_swapchain";
        public const string VK_EXT_DEBUG_REPORT_EXTENSION_NAME = "VK_EXT_debug_report";
        public const string StandardValidationLayeName = "VK_LAYER_LUNARG_standard_validation";
        public const string main = "main";
    }

}
