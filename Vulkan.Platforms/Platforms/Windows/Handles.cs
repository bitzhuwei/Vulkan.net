using System;

namespace Vulkan {
    public unsafe static class InstanceExtension {
        public static VkSurfaceKhr CreateWin32SurfaceKHR(this VkInstance instance, ref VkWin32SurfaceCreateInfoKhr createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks = null) {
            UInt64 pointer;
            VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
            fixed (VkWin32SurfaceCreateInfoKhr* pCreateInfo = &createInfo) {
                NativeMethods.vkCreateWin32SurfaceKHR(instance.handle, pCreateInfo, pAllocator, &pointer).Check();
            }

            return new VkSurfaceKhr(instance, callbacks, pointer);
        }
    }

    public unsafe static class PhysicalDeviceExtension {
        public static VkBool32 GetWin32PresentationSupportKHR(this VkPhysicalDevice physicalDevice, UInt32 queueFamilyIndex) {
            return NativeMethods.vkGetPhysicalDeviceWin32PresentationSupportKHR(physicalDevice.handle, queueFamilyIndex);
        }
    }

    public unsafe static class DeviceExtension {
        public static IntPtr GetMemoryWin32HandleNV(this VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNv handleType) {
            var pHandle = new IntPtr();
            NativeMethods.vkGetMemoryWin32HandleNV(device.handle, memory != null ? memory.handle : default(UInt64), handleType, &pHandle).Check();

            return pHandle;
        }
    }

}
