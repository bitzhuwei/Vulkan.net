using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkClearDepthStencilValue {
        /// <summary>
        /// VkClearDepthStencilValue - Structure specifying a clear depth stencil value
        /// </summary>
        /// <param name="depth">depth is the clear value for the depth aspect of the depth/stencil
        /// attachment.
        /// It is a floating-point value which is automatically converted to the
        /// attachment’s format</param>
        /// <param name="stencil">stencil is the clear value for the stencil aspect of the
        /// depth/stencil attachment.
        /// It is a 32-bit integer value which is converted to the attachment’s
        /// format by taking the appropriate number of LSBs</param>
        public VkClearDepthStencilValue(float depth, UInt32 stencil) {
            this.depth = depth; this.stencil = stencil;
        }

    }
}
