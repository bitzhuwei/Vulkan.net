using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.HelloVulkan {
    static public class Logo {
        const float value = 1f;
        public static readonly float[] Vertices = {
            // left up, right up.
            -value, -value, -value, value,
            // left down, right down.
             value, -value,  value, value
        };
        public static readonly short[] Indexes = {
            // ieft up triangle.
            0, 1, 2,
            // right down triangle.
            1, 2, 3
        };
    }
}
