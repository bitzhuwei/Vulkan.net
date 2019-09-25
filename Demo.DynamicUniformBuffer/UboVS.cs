using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo.DynamicUniformBuffer {
    struct UboVS {
        public Matrix4x4 projection;
        public Matrix4x4 view;
    }

}
