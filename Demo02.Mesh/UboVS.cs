using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo02.Mesh {
    /// <summary>
    /// layout (binding = 0) uniform UBO in vertex shader.
    /// </summary>
    struct UboVS {
        public System.Numerics.Matrix4x4 projection;
        public System.Numerics.Matrix4x4 model;
        public Vector4 lightPos;
    }

}
