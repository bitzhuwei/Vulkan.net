using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo.Mesh {
    // Vertex layout used in this example
    // This must fit input locations of the vertex shader used to render the model
    struct Vertex {
        public Vector3 pos;
        public Vector3 normal;
        public Vector2 uv;
        public Vector3 color;
        public const uint PositionOffset = 0;
        public const uint NormalOffset = 12;
        public const uint UvOffset = 24;
        public const uint ColorOffset = 32;
    };

}
