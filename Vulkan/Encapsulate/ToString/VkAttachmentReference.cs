using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkAttachmentReference {
        public override string ToString() => $"{layout}, {attachment}";
    }
}
