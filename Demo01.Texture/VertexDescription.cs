using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using System.Numerics;

namespace Demo01.Texture {
    public class VertexDescription {
        public VkPipelineVertexInputStateCreateInfo inputState;
        //public NativeList<VkVertexInputBindingDescription> bindingDescriptions = new NativeList<VkVertexInputBindingDescription>();
        public VkVertexInputBindingDescription[] bindingDescriptions;
        //public NativeList<VkVertexInputAttributeDescription> attributeDescriptions = new NativeList<VkVertexInputAttributeDescription>();
        public VkVertexInputAttributeDescription[] attributeDescriptions;
    }

}
