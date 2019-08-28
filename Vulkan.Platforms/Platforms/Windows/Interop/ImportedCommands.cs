/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    internal static class NativeMethods {
        const string VulkanLibrary = "vulkan-1";

        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        internal static unsafe extern VkResult vkCreateWin32SurfaceKHR(IntPtr instance, VkWin32SurfaceCreateInfoKhr* pCreateInfo, VkAllocationCallbacks* pAllocator, UInt64* pSurface);

        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        internal static unsafe extern VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(IntPtr physicalDevice, UInt32 queueFamilyIndex);

        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        internal static unsafe extern VkResult vkGetMemoryWin32HandleNV(IntPtr device, UInt64 memory, VkExternalMemoryHandleTypeFlagsNv handleType, IntPtr* pHandle);

    }
}
