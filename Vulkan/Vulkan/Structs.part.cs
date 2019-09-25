using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkClearColorValue {
        public VkClearColorValue(float r, float g, float b, float a) {
            fixed (float* p = this.float32) {
                p[0] = r;
                p[1] = g;
                p[2] = b;
                p[3] = a;
            }
        }

        public VkClearColorValue(Int32 r, Int32 g, Int32 b, Int32 a) {
            fixed (Int32* p = this.int32) {
                p[0] = r;
                p[1] = g;
                p[2] = b;
                p[3] = a;
            }
        }

        public VkClearColorValue(UInt32 r, UInt32 g, UInt32 b, UInt32 a) {
            fixed (UInt32* p = this.uint32) {
                p[0] = r;
                p[1] = g;
                p[2] = b;
                p[3] = a;
            }
        }
    }
}
