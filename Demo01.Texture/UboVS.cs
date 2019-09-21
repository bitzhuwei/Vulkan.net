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
    /// layout (binding = 0) uniform UBO in vertex shader.
    /// </summary>
    public struct UboVS {
        public Matrix4x4 projection;
        public Matrix4x4 model;
        public Vector4 viewPos;
        public float lodBias;
    }

}
