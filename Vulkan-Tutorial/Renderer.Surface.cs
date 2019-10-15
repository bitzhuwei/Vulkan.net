using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;

namespace Vulkan_Tutorial {
    unsafe partial class Renderer {

        private void CreateSurface(IntPtr handle) {
            var info = VkWin32SurfaceCreateInfoKHR.Alloc();
            info[0].hwnd = handle;
            info[0].hinstance = Process.GetCurrentProcess().Handle;

            VkSurfaceKHR surface;
            vkCreateWin32SurfaceKHR(instance, null, null, &surface).Check();
            this.surface = surface;
        }

    }
}
