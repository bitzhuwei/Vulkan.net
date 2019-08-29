using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkPhysicalDevice {
        public VkResult CreateDevice(ref VkDeviceCreateInfo createInfo, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkDevice device) {
            return VkDevice.Create(this, ref createInfo, callbacks, out device);
        }

        public void GetMemoryProperties(out VkPhysicalDeviceMemoryProperties memoryProperties) {
            fixed (VkPhysicalDeviceMemoryProperties* pointer = &memoryProperties) {
                vkAPI.vkGetPhysicalDeviceMemoryProperties(this.handle, pointer);
            }
        }

        public void GetSparseImageFormatProperties(VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, out VkSparseImageFormatProperties[] properties) {
            UInt32 count;
            vkAPI.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &count, null);
            properties = new VkSparseImageFormatProperties[count];
            if (count > 0) {
                fixed (VkSparseImageFormatProperties* pointer = properties) {
                    vkAPI.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &count, pointer);
                }
            }
        }

        public VkResult GetDisplayProperties(out VkDisplayPropertiesKhr[] properties) {
            UInt32 count;
            VkResult result = vkAPI.vkGetPhysicalDeviceDisplayPropertiesKHR(this.handle, &count, null).Check();
            properties = new VkDisplayPropertiesKhr[count];
            if (count > 0) {
                fixed (VkDisplayPropertiesKhr* pointer = properties) {
                    result = vkAPI.vkGetPhysicalDeviceDisplayPropertiesKHR(this.handle, &count, pointer).Check();
                }
            }

            return result;
        }

        public VkResult GetDisplayPlaneProperties(out VkDisplayPlanePropertiesKhr[] properties) {
            UInt32 count;
            VkResult result = vkAPI.vkGetPhysicalDeviceDisplayPlanePropertiesKHR(this.handle, &count, null).Check();
            properties = new VkDisplayPlanePropertiesKhr[count];
            if (count > 0) {
                fixed (VkDisplayPlanePropertiesKhr* pointer = properties) {
                    result = vkAPI.vkGetPhysicalDeviceDisplayPlanePropertiesKHR(this.handle, &count, pointer).Check();
                }
            }

            return result;
        }

        public VkResult GetDisplayPlaneSupportedDisplaysKhr(UInt32 planeIndex, out VkDisplayKhr[] displayKhrs) {
            return VkDisplayKhr.Create(this, planeIndex, out displayKhrs);
        }

        public VkResult GetDisplayPlaneSupportedDisplaysKhr(VkDisplayKhr displayKhr, out VkDisplayModePropertiesKhr[] properties) {
            UInt32 count;
            VkResult result = vkAPI.vkGetDisplayModePropertiesKHR(this.handle, displayKhr.handle, &count, null).Check();
            properties = new VkDisplayModePropertiesKhr[count];
            if (count > 0) {
                fixed (VkDisplayModePropertiesKhr* pointer = properties) {
                    result = vkAPI.vkGetDisplayModePropertiesKHR(this.handle, displayKhr.handle, &count, pointer).Check();
                }
            }

            return result;
        }

        public VkResult GetDisplayPlaneCapabilitiesKhr(VkDisplayModeKhr mode, UInt32 planeIndex, out VkDisplayPlaneCapabilitiesKhr capabilities) {
            fixed (VkDisplayPlaneCapabilitiesKhr* pointer = &capabilities) {
                return vkAPI.vkGetDisplayPlaneCapabilitiesKHR(this.handle, mode.handle, planeIndex, pointer).Check();
            }
        }

        public VkResult GetSurfaceSupportKhr(UInt32 queueFamilyIndex, VkSurfaceKhr surface, out VkBool32 supported) {
            fixed (VkBool32* pointer = &supported) {
                return vkAPI.vkGetPhysicalDeviceSurfaceSupportKHR(this.handle, queueFamilyIndex, surface.handle, pointer).Check();
            }
        }

        public VkResult GetSurfaceCapabilitiesKhr(VkSurfaceKhr surface, out VkSurfaceCapabilitiesKhr capabilities) {
            fixed (VkSurfaceCapabilitiesKhr* pointer = &capabilities) {
                return vkAPI.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.handle, surface.handle, pointer).Check();
            }
        }

        public VkResult GetSurfaceFormatsKhr(VkSurfaceKhr surface, out VkSurfaceFormatKhr[] formats) {
            UInt32 count;
            VkResult result = vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(this.handle, surface.handle, &count, null).Check();
            formats = new VkSurfaceFormatKhr[count];
            if (count > 0) {
                fixed (VkSurfaceFormatKhr* pointer = formats) {
                    result = vkAPI.vkGetPhysicalDeviceSurfaceFormatsKHR(this.handle, surface.handle, &count, pointer).Check();
                }
            }

            return result;
        }

        public VkResult GetSurfacePresentModesKhr(VkSurfaceKhr surface, out VkPresentModeKhr[] modes) {
            UInt32 count;
            VkResult result = vkAPI.vkGetPhysicalDeviceSurfacePresentModesKHR(this.handle, surface.handle, &count, null).Check();
            modes = new VkPresentModeKhr[count];
            if (count > 0) {
                fixed (VkPresentModeKhr* pointer = modes) {
                    result = vkAPI.vkGetPhysicalDeviceSurfacePresentModesKHR(this.handle, surface.handle, &count, pointer).Check();
                }
            }

            return result;
        }

        public VkResult EnumerateDeviceLayerProperties(out VkLayerProperties[] layerProperties) {
            UInt32 count;
            VkResult result = vkAPI.vkEnumerateDeviceLayerProperties(this.handle, &count, null).Check();
            layerProperties = new VkLayerProperties[count];
            if (count > 0) {
                fixed (VkLayerProperties* pointer = layerProperties) {
                    result = vkAPI.vkEnumerateDeviceLayerProperties(this.handle, &count, pointer).Check();
                }
            }

            return result;
        }

        public VkResult EnumerateDeviceExtensionProperties(string layerName, out VkExtensionProperties[] layerProperties) {
            UInt32 count;
            VkResult result = vkAPI.vkEnumerateDeviceExtensionProperties(this.handle, layerName, &count, null).Check();
            layerProperties = new VkExtensionProperties[count];
            fixed (VkExtensionProperties* pointer = layerProperties) {
                result = vkAPI.vkEnumerateDeviceExtensionProperties(this.handle, layerName, &count, pointer).Check();
            }

            return result;
        }

        public void GetFeatures(out VkPhysicalDeviceFeatures features) {
            fixed (VkPhysicalDeviceFeatures* pointer = &features) {
                vkAPI.vkGetPhysicalDeviceFeatures(this.handle, pointer);
            }
        }

        public void GetFormatProperties(VkFormat format, out VkFormatProperties formatProperties) {
            fixed (VkFormatProperties* pointer = &formatProperties) {
                vkAPI.vkGetPhysicalDeviceFormatProperties(this.handle, format, pointer);
            }
        }

        public VkResult GetImageFormatProperties(VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties) {
            fixed (VkImageFormatProperties* pointer = &imageFormatProperties) {
                return vkAPI.vkGetPhysicalDeviceImageFormatProperties(this.handle, format, type, tiling, usage, flags, pointer);
            }
        }
    }
}

