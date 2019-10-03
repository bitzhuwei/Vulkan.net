using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkDescriptorSetLayoutBinding {
        public override string ToString() {
            return $"binding:{binding}, type:{descriptorType}, count:{descriptorCount}, offset:{stageFlags}";
        }
    }
}
