using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo.Texture {
    public unsafe static class VkPhysicalDeviceMemoryPropertiesEx {
        public static VkMemoryType GetMemoryType(this VkPhysicalDeviceMemoryProperties memoryProperties, uint index) {
            //return (&memoryProperties.memoryTypes_0)[index];
            var types = (VkMemoryType*)memoryProperties.memoryTypes;
            return types[index];
        }
    }
}
