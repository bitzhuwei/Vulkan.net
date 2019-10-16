using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct VkDescriptorPoolSizesGroup {
        public UInt32 count;
        public VkDescriptorPoolSize* array;

        public VkDescriptorPoolSizesGroup(params VkDescriptorPoolSize[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorPoolSize*)ptr;
        }

        public void Set(params VkDescriptorPoolSize[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorPoolSize*)ptr;
        }

        public static implicit operator VkDescriptorPoolSizesGroup(VkDescriptorPoolSize v) {
            return new VkDescriptorPoolSizesGroup(new VkDescriptorPoolSize[] { v });
        }

        public static implicit operator VkDescriptorPoolSizesGroup(VkDescriptorPoolSize[] v) {
            return new VkDescriptorPoolSizesGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDescriptorPoolSize)}[{count}]";
            }
        }
    }

    public unsafe struct VkDescriptorSetLayoutBindingsGroup {
        public UInt32 count;
        public VkDescriptorSetLayoutBinding* array;

        public VkDescriptorSetLayoutBindingsGroup(params VkDescriptorSetLayoutBinding[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayoutBinding*)ptr;
        }

        public void Set(params VkDescriptorSetLayoutBinding[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayoutBinding*)ptr;
        }

        public static implicit operator VkDescriptorSetLayoutBindingsGroup(VkDescriptorSetLayoutBinding v) {
            return new VkDescriptorSetLayoutBindingsGroup(new VkDescriptorSetLayoutBinding[] { v });
        }

        public static implicit operator VkDescriptorSetLayoutBindingsGroup(VkDescriptorSetLayoutBinding[] v) {
            return new VkDescriptorSetLayoutBindingsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDescriptorSetLayoutBinding)}[{count}]";
            }
        }
    }

    public unsafe struct VkDescriptorSetLayoutsGroup {
        public UInt32 count;
        public VkDescriptorSetLayout* array;

        public VkDescriptorSetLayoutsGroup(params VkDescriptorSetLayout[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayout*)ptr;
        }

        public void Set(params VkDescriptorSetLayout[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayout*)ptr;
        }

        public static implicit operator VkDescriptorSetLayoutsGroup(VkDescriptorSetLayout v) {
            return new VkDescriptorSetLayoutsGroup(new VkDescriptorSetLayout[] { v });
        }

        public static implicit operator VkDescriptorSetLayoutsGroup(VkDescriptorSetLayout[] v) {
            return new VkDescriptorSetLayoutsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDescriptorSetLayout)}[{count}]";
            }
        }
    }

    public unsafe struct VkDeviceQueueCreateInfosGroup {
        public UInt32 count;
        public VkDeviceQueueCreateInfo* array;

        public VkDeviceQueueCreateInfosGroup(params VkDeviceQueueCreateInfo[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDeviceQueueCreateInfo*)ptr;
        }

        public void Set(params VkDeviceQueueCreateInfo[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDeviceQueueCreateInfo*)ptr;
        }

        public static implicit operator VkDeviceQueueCreateInfosGroup(VkDeviceQueueCreateInfo v) {
            return new VkDeviceQueueCreateInfosGroup(new VkDeviceQueueCreateInfo[] { v });
        }

        public static implicit operator VkDeviceQueueCreateInfosGroup(VkDeviceQueueCreateInfo[] v) {
            return new VkDeviceQueueCreateInfosGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDeviceQueueCreateInfo)}[{count}]";
            }
        }
    }

    public unsafe struct VkDynamicStatesGroup {
        public UInt32 count;
        public VkDynamicState* array;

        public VkDynamicStatesGroup(params VkDynamicState[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDynamicState*)ptr;
        }

        public void Set(params VkDynamicState[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDynamicState*)ptr;
        }

        public static implicit operator VkDynamicStatesGroup(VkDynamicState v) {
            return new VkDynamicStatesGroup(new VkDynamicState[] { v });
        }

        public static implicit operator VkDynamicStatesGroup(VkDynamicState[] v) {
            return new VkDynamicStatesGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkDynamicState)}[{count}]";
            }
        }
    }

    public unsafe struct VkPipelineColorBlendAttachmentStatesGroup {
        public UInt32 count;
        public VkPipelineColorBlendAttachmentState* array;

        public VkPipelineColorBlendAttachmentStatesGroup(params VkPipelineColorBlendAttachmentState[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPipelineColorBlendAttachmentState*)ptr;
        }

        public void Set(params VkPipelineColorBlendAttachmentState[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPipelineColorBlendAttachmentState*)ptr;
        }

        public static implicit operator VkPipelineColorBlendAttachmentStatesGroup(VkPipelineColorBlendAttachmentState v) {
            return new VkPipelineColorBlendAttachmentStatesGroup(new VkPipelineColorBlendAttachmentState[] { v });
        }

        public static implicit operator VkPipelineColorBlendAttachmentStatesGroup(VkPipelineColorBlendAttachmentState[] v) {
            return new VkPipelineColorBlendAttachmentStatesGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkPipelineColorBlendAttachmentState)}[{count}]";
            }
        }
    }

    public unsafe struct VkPipelineShaderStageCreateInfosGroup {
        public UInt32 count;
        public VkPipelineShaderStageCreateInfo* array;

        public VkPipelineShaderStageCreateInfosGroup(params VkPipelineShaderStageCreateInfo[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPipelineShaderStageCreateInfo*)ptr;
        }

        public void Set(params VkPipelineShaderStageCreateInfo[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPipelineShaderStageCreateInfo*)ptr;
        }

        public static implicit operator VkPipelineShaderStageCreateInfosGroup(VkPipelineShaderStageCreateInfo v) {
            return new VkPipelineShaderStageCreateInfosGroup(new VkPipelineShaderStageCreateInfo[] { v });
        }

        public static implicit operator VkPipelineShaderStageCreateInfosGroup(VkPipelineShaderStageCreateInfo[] v) {
            return new VkPipelineShaderStageCreateInfosGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkPipelineShaderStageCreateInfo)}[{count}]";
            }
        }
    }

    public unsafe struct VkRect2DsGroup {
        public UInt32 count;
        public VkRect2D* array;

        public VkRect2DsGroup(params VkRect2D[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkRect2D*)ptr;
        }

        public void Set(params VkRect2D[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkRect2D*)ptr;
        }

        public static implicit operator VkRect2DsGroup(VkRect2D v) {
            return new VkRect2DsGroup(new VkRect2D[] { v });
        }

        public static implicit operator VkRect2DsGroup(VkRect2D[] v) {
            return new VkRect2DsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkRect2D)}[{count}]";
            }
        }
    }

    public unsafe struct VkVertexInputAttributeDescriptionsGroup {
        public UInt32 count;
        public VkVertexInputAttributeDescription* array;

        public VkVertexInputAttributeDescriptionsGroup(params VkVertexInputAttributeDescription[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkVertexInputAttributeDescription*)ptr;
        }

        public void Set(params VkVertexInputAttributeDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkVertexInputAttributeDescription*)ptr;
        }

        public static implicit operator VkVertexInputAttributeDescriptionsGroup(VkVertexInputAttributeDescription v) {
            return new VkVertexInputAttributeDescriptionsGroup(new VkVertexInputAttributeDescription[] { v });
        }

        public static implicit operator VkVertexInputAttributeDescriptionsGroup(VkVertexInputAttributeDescription[] v) {
            return new VkVertexInputAttributeDescriptionsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkVertexInputAttributeDescription)}[{count}]";
            }
        }
    }

    public unsafe struct VkVertexInputBindingDescriptionsGroup {
        public UInt32 count;
        public VkVertexInputBindingDescription* array;

        public VkVertexInputBindingDescriptionsGroup(params VkVertexInputBindingDescription[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkVertexInputBindingDescription*)ptr;
        }

        public void Set(params VkVertexInputBindingDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkVertexInputBindingDescription*)ptr;
        }

        public static implicit operator VkVertexInputBindingDescriptionsGroup(VkVertexInputBindingDescription v) {
            return new VkVertexInputBindingDescriptionsGroup(new VkVertexInputBindingDescription[] { v });
        }

        public static implicit operator VkVertexInputBindingDescriptionsGroup(VkVertexInputBindingDescription[] v) {
            return new VkVertexInputBindingDescriptionsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkVertexInputBindingDescription)}[{count}]";
            }
        }
    }

    public unsafe struct VkViewportsGroup {
        public UInt32 count;
        public VkViewport* array;

        public VkViewportsGroup(params VkViewport[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkViewport*)ptr;
        }

        public void Set(params VkViewport[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkViewport*)ptr;
        }

        public static implicit operator VkViewportsGroup(VkViewport v) {
            return new VkViewportsGroup(new VkViewport[] { v });
        }

        public static implicit operator VkViewportsGroup(VkViewport[] v) {
            return new VkViewportsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkViewport)}[{count}]";
            }
        }
    }

    public unsafe struct VkImageViewsGroup {
        public UInt32 count;
        public VkImageView* array;

        public VkImageViewsGroup(params VkImageView[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkImageView*)ptr;
        }

        public void Set(params VkImageView[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkImageView*)ptr;
        }

        public static implicit operator VkImageViewsGroup(VkImageView v) {
            return new VkImageViewsGroup(new VkImageView[] { v });
        }

        public static implicit operator VkImageViewsGroup(VkImageView[] v) {
            return new VkImageViewsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkImageView)}[{count}]";
            }
        }
    }

    public unsafe struct VkSwapchainKHRsGroup {
        public UInt32 count;
        public VkSwapchainKHR* array;

        public VkSwapchainKHRsGroup(params VkSwapchainKHR[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSwapchainKHR*)ptr;
        }

        public void Set(params VkSwapchainKHR[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSwapchainKHR*)ptr;
        }

        public static implicit operator VkSwapchainKHRsGroup(VkSwapchainKHR v) {
            return new VkSwapchainKHRsGroup(new VkSwapchainKHR[] { v });
        }

        public static implicit operator VkSwapchainKHRsGroup(VkSwapchainKHR[] v) {
            return new VkSwapchainKHRsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkSwapchainKHR)}[{count}]";
            }
        }
    }

    public unsafe struct VkSemaphoresGroup {
        public UInt32 count;
        public VkSemaphore* array;

        public VkSemaphoresGroup(params VkSemaphore[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSemaphore*)ptr;
        }

        public void Set(params VkSemaphore[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSemaphore*)ptr;
        }

        public static implicit operator VkSemaphoresGroup(VkSemaphore v) {
            return new VkSemaphoresGroup(new VkSemaphore[] { v });
        }

        public static implicit operator VkSemaphoresGroup(VkSemaphore[] v) {
            return new VkSemaphoresGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkSemaphore)}[{count}]";
            }
        }
    }

    public unsafe struct VkClearValuesGroup {
        public UInt32 count;
        public VkClearValue* array;

        public VkClearValuesGroup(params VkClearValue[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkClearValue*)ptr;
        }

        public void Set(params VkClearValue[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkClearValue*)ptr;
        }

        public static implicit operator VkClearValuesGroup(VkClearValue v) {
            return new VkClearValuesGroup(new VkClearValue[] { v });
        }

        public static implicit operator VkClearValuesGroup(VkClearValue[] v) {
            return new VkClearValuesGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkClearValue)}[{count}]";
            }
        }
    }

    public unsafe struct VkAttachmentDescriptionsGroup {
        public UInt32 count;
        public VkAttachmentDescription* array;

        public VkAttachmentDescriptionsGroup(params VkAttachmentDescription[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkAttachmentDescription*)ptr;
        }

        public void Set(params VkAttachmentDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkAttachmentDescription*)ptr;
        }

        public static implicit operator VkAttachmentDescriptionsGroup(VkAttachmentDescription v) {
            return new VkAttachmentDescriptionsGroup(new VkAttachmentDescription[] { v });
        }

        public static implicit operator VkAttachmentDescriptionsGroup(VkAttachmentDescription[] v) {
            return new VkAttachmentDescriptionsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkAttachmentDescription)}[{count}]";
            }
        }
    }

    public unsafe struct VkSubpassDescriptionsGroup {
        public UInt32 count;
        public VkSubpassDescription* array;

        public VkSubpassDescriptionsGroup(params VkSubpassDescription[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSubpassDescription*)ptr;
        }

        public void Set(params VkSubpassDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSubpassDescription*)ptr;
        }

        public static implicit operator VkSubpassDescriptionsGroup(VkSubpassDescription v) {
            return new VkSubpassDescriptionsGroup(new VkSubpassDescription[] { v });
        }

        public static implicit operator VkSubpassDescriptionsGroup(VkSubpassDescription[] v) {
            return new VkSubpassDescriptionsGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkSubpassDescription)}[{count}]";
            }
        }
    }

    public unsafe struct VkSubpassDependencysGroup {
        public UInt32 count;
        public VkSubpassDependency* array;

        public VkSubpassDependencysGroup(params VkSubpassDependency[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSubpassDependency*)ptr;
        }

        public void Set(params VkSubpassDependency[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSubpassDependency*)ptr;
        }

        public static implicit operator VkSubpassDependencysGroup(VkSubpassDependency v) {
            return new VkSubpassDependencysGroup(new VkSubpassDependency[] { v });
        }

        public static implicit operator VkSubpassDependencysGroup(VkSubpassDependency[] v) {
            return new VkSubpassDependencysGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkSubpassDependency)}[{count}]";
            }
        }
    }

    public unsafe struct VkCommandBuffersGroup {
        public UInt32 count;
        public VkCommandBuffer* array;

        public VkCommandBuffersGroup(params VkCommandBuffer[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkCommandBuffer*)ptr;
        }

        public void Set(params VkCommandBuffer[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkCommandBuffer*)ptr;
        }

        public static implicit operator VkCommandBuffersGroup(VkCommandBuffer v) {
            return new VkCommandBuffersGroup(new VkCommandBuffer[] { v });
        }

        public static implicit operator VkCommandBuffersGroup(VkCommandBuffer[] v) {
            return new VkCommandBuffersGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkCommandBuffer)}[{count}]";
            }
        }
    }

    public unsafe struct VkAttachmentReferencesGroup {
        public UInt32 count;
        public VkAttachmentReference* array;

        public VkAttachmentReferencesGroup(params VkAttachmentReference[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (VkAttachmentReference*)ptr;
        }

        public void Set(params VkAttachmentReference[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkAttachmentReference*)ptr;
        }

        public static implicit operator VkAttachmentReferencesGroup(VkAttachmentReference v) {
            return new VkAttachmentReferencesGroup(new VkAttachmentReference[] { v });
        }

        public static implicit operator VkAttachmentReferencesGroup(VkAttachmentReference[] v) {
            return new VkAttachmentReferencesGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkAttachmentReference)}[{count}]";
            }
        }
    }

    public unsafe struct SinglesGroup {
        public UInt32 count;
        public Single* array;

        public SinglesGroup(params Single[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (Single*)ptr;
        }

        public void Set(params Single[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (Single*)ptr;
        }

        public static implicit operator SinglesGroup(Single v) {
            return new SinglesGroup(new Single[] { v });
        }

        public static implicit operator SinglesGroup(Single[] v) {
            return new SinglesGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(Single)}[{count}]";
            }
        }
    }

    public unsafe struct UInt32sGroup {
        public UInt32 count;
        public UInt32* array;

        public UInt32sGroup(params UInt32[] value) {
            count = 0;
            array = null;
            IntPtr ptr = IntPtr.Zero;
            value.Set(ref ptr, ref this.count);
            this.array = (UInt32*)ptr;
        }

        public void Set(params UInt32[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (UInt32*)ptr;
        }

        public static implicit operator UInt32sGroup(UInt32 v) {
            return new UInt32sGroup(new UInt32[] { v });
        }

        public static implicit operator UInt32sGroup(UInt32[] v) {
            return new UInt32sGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(UInt32)}[{count}]";
            }
        }
    }

}

