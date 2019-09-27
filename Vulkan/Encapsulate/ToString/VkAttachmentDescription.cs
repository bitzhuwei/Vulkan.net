using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkAttachmentDescription {
        public override string ToString() {
            return $"{format}, {samples}, ({loadOp}, {storeOp}), ({stencilLoadOp}, {stencilStoreOp}), ({initialLayout}, {finalLayout}), {flags}";
        }
    }
}
