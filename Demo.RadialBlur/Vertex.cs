using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo.RadialBlur {
    // Vertex layout for this example
    struct Vertex {
        public Vector3 pos;
        public Vector3 color;
    };
}
