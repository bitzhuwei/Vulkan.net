using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo01.Texture {
    /// <summary>
    /// Contains all Vulkan objects that are required to store and use a texture
    /// </summary>
    public struct Texture {
        public VkSampler sampler;
        public VkImage image;
        public VkImageLayout imageLayout;
        public VkDeviceMemory DeviceMemory;
        public VkImageView view;
        public uint width, height;
        public uint mipLevels;
    }

}
