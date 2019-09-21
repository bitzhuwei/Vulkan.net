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
    /// Vertex layout for this example
    /// </summary>
    public struct Vertex {
        public Vector3 pos;
        public Vector2 uv;
        public Vector3 normal;

        /// <summary>
        /// 0 : | pos
        /// </summary>
        public const uint PositionOffset = 0;
        /// <summary>
        /// 12 : pos | uv
        /// </summary>
        public const uint UvOffset = 12;
        /// <summary>
        /// 20 : pos uv | normal
        /// </summary>
        public const uint NormalOffset = 20;
    }

}
