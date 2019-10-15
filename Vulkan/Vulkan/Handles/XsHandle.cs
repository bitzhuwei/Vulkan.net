using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct VkDescriptorPoolSizesHandle {
        public UInt32 count;
        public VkDescriptorPoolSize* array;

        public VkDescriptorPoolSizesHandle(params VkDescriptorPoolSize[] value) {
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

        public static implicit operator VkDescriptorPoolSizesHandle(VkDescriptorPoolSize v) {
            return new VkDescriptorPoolSizesHandle(new VkDescriptorPoolSize[] { v });
        }

        public static implicit operator VkDescriptorPoolSizesHandle(VkDescriptorPoolSize[] v) {
            return new VkDescriptorPoolSizesHandle(v);
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

    public unsafe struct VkDescriptorSetLayoutBindingsHandle {
        public UInt32 count;
        public VkDescriptorSetLayoutBinding* array;

        public VkDescriptorSetLayoutBindingsHandle(params VkDescriptorSetLayoutBinding[] value) {
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

        public static implicit operator VkDescriptorSetLayoutBindingsHandle(VkDescriptorSetLayoutBinding v) {
            return new VkDescriptorSetLayoutBindingsHandle(new VkDescriptorSetLayoutBinding[] { v });
        }

        public static implicit operator VkDescriptorSetLayoutBindingsHandle(VkDescriptorSetLayoutBinding[] v) {
            return new VkDescriptorSetLayoutBindingsHandle(v);
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

    public unsafe struct VkDescriptorSetLayoutsHandle {
        public UInt32 count;
        public VkDescriptorSetLayout* array;

        public VkDescriptorSetLayoutsHandle(params VkDescriptorSetLayout[] value) {
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

        public static implicit operator VkDescriptorSetLayoutsHandle(VkDescriptorSetLayout v) {
            return new VkDescriptorSetLayoutsHandle(new VkDescriptorSetLayout[] { v });
        }

        public static implicit operator VkDescriptorSetLayoutsHandle(VkDescriptorSetLayout[] v) {
            return new VkDescriptorSetLayoutsHandle(v);
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

    public unsafe struct VkDeviceQueueCreateInfosHandle {
        public UInt32 count;
        public VkDeviceQueueCreateInfo* array;

        public VkDeviceQueueCreateInfosHandle(params VkDeviceQueueCreateInfo[] value) {
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

        public static implicit operator VkDeviceQueueCreateInfosHandle(VkDeviceQueueCreateInfo v) {
            return new VkDeviceQueueCreateInfosHandle(new VkDeviceQueueCreateInfo[] { v });
        }

        public static implicit operator VkDeviceQueueCreateInfosHandle(VkDeviceQueueCreateInfo[] v) {
            return new VkDeviceQueueCreateInfosHandle(v);
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

    public unsafe struct VkDynamicStatesHandle {
        public UInt32 count;
        public VkDynamicState* array;

        public VkDynamicStatesHandle(params VkDynamicState[] value) {
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

        public static implicit operator VkDynamicStatesHandle(VkDynamicState v) {
            return new VkDynamicStatesHandle(new VkDynamicState[] { v });
        }

        public static implicit operator VkDynamicStatesHandle(VkDynamicState[] v) {
            return new VkDynamicStatesHandle(v);
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

    public unsafe struct VkPipelineColorBlendAttachmentStatesHandle {
        public UInt32 count;
        public VkPipelineColorBlendAttachmentState* array;

        public VkPipelineColorBlendAttachmentStatesHandle(params VkPipelineColorBlendAttachmentState[] value) {
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

        public static implicit operator VkPipelineColorBlendAttachmentStatesHandle(VkPipelineColorBlendAttachmentState v) {
            return new VkPipelineColorBlendAttachmentStatesHandle(new VkPipelineColorBlendAttachmentState[] { v });
        }

        public static implicit operator VkPipelineColorBlendAttachmentStatesHandle(VkPipelineColorBlendAttachmentState[] v) {
            return new VkPipelineColorBlendAttachmentStatesHandle(v);
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

    public unsafe struct VkPipelineShaderStageCreateInfosHandle {
        public UInt32 count;
        public VkPipelineShaderStageCreateInfo* array;

        public VkPipelineShaderStageCreateInfosHandle(params VkPipelineShaderStageCreateInfo[] value) {
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

        public static implicit operator VkPipelineShaderStageCreateInfosHandle(VkPipelineShaderStageCreateInfo v) {
            return new VkPipelineShaderStageCreateInfosHandle(new VkPipelineShaderStageCreateInfo[] { v });
        }

        public static implicit operator VkPipelineShaderStageCreateInfosHandle(VkPipelineShaderStageCreateInfo[] v) {
            return new VkPipelineShaderStageCreateInfosHandle(v);
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

    public unsafe struct VkRect2DsHandle {
        public UInt32 count;
        public VkRect2D* array;

        public VkRect2DsHandle(params VkRect2D[] value) {
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

        public static implicit operator VkRect2DsHandle(VkRect2D v) {
            return new VkRect2DsHandle(new VkRect2D[] { v });
        }

        public static implicit operator VkRect2DsHandle(VkRect2D[] v) {
            return new VkRect2DsHandle(v);
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

    public unsafe struct VkVertexInputAttributeDescriptionsHandle {
        public UInt32 count;
        public VkVertexInputAttributeDescription* array;

        public VkVertexInputAttributeDescriptionsHandle(params VkVertexInputAttributeDescription[] value) {
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

        public static implicit operator VkVertexInputAttributeDescriptionsHandle(VkVertexInputAttributeDescription v) {
            return new VkVertexInputAttributeDescriptionsHandle(new VkVertexInputAttributeDescription[] { v });
        }

        public static implicit operator VkVertexInputAttributeDescriptionsHandle(VkVertexInputAttributeDescription[] v) {
            return new VkVertexInputAttributeDescriptionsHandle(v);
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

    public unsafe struct VkVertexInputBindingDescriptionsHandle {
        public UInt32 count;
        public VkVertexInputBindingDescription* array;

        public VkVertexInputBindingDescriptionsHandle(params VkVertexInputBindingDescription[] value) {
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

        public static implicit operator VkVertexInputBindingDescriptionsHandle(VkVertexInputBindingDescription v) {
            return new VkVertexInputBindingDescriptionsHandle(new VkVertexInputBindingDescription[] { v });
        }

        public static implicit operator VkVertexInputBindingDescriptionsHandle(VkVertexInputBindingDescription[] v) {
            return new VkVertexInputBindingDescriptionsHandle(v);
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

    public unsafe struct VkViewportsHandle {
        public UInt32 count;
        public VkViewport* array;

        public VkViewportsHandle(params VkViewport[] value) {
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

        public static implicit operator VkViewportsHandle(VkViewport v) {
            return new VkViewportsHandle(new VkViewport[] { v });
        }

        public static implicit operator VkViewportsHandle(VkViewport[] v) {
            return new VkViewportsHandle(v);
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

    public unsafe struct VkImageViewsHandle {
        public UInt32 count;
        public VkImageView* array;

        public VkImageViewsHandle(params VkImageView[] value) {
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

        public static implicit operator VkImageViewsHandle(VkImageView v) {
            return new VkImageViewsHandle(new VkImageView[] { v });
        }

        public static implicit operator VkImageViewsHandle(VkImageView[] v) {
            return new VkImageViewsHandle(v);
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

    public unsafe struct VkSwapchainKHRsHandle {
        public UInt32 count;
        public VkSwapchainKHR* array;

        public VkSwapchainKHRsHandle(params VkSwapchainKHR[] value) {
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

        public static implicit operator VkSwapchainKHRsHandle(VkSwapchainKHR v) {
            return new VkSwapchainKHRsHandle(new VkSwapchainKHR[] { v });
        }

        public static implicit operator VkSwapchainKHRsHandle(VkSwapchainKHR[] v) {
            return new VkSwapchainKHRsHandle(v);
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

    public unsafe struct VkSemaphoresHandle {
        public UInt32 count;
        public VkSemaphore* array;

        public VkSemaphoresHandle(params VkSemaphore[] value) {
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

        public static implicit operator VkSemaphoresHandle(VkSemaphore v) {
            return new VkSemaphoresHandle(new VkSemaphore[] { v });
        }

        public static implicit operator VkSemaphoresHandle(VkSemaphore[] v) {
            return new VkSemaphoresHandle(v);
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

    public unsafe struct SinglesHandle {
        public UInt32 count;
        public Single* array;

        public SinglesHandle(params Single[] value) {
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

        public static implicit operator SinglesHandle(Single v) {
            return new SinglesHandle(new Single[] { v });
        }

        public static implicit operator SinglesHandle(Single[] v) {
            return new SinglesHandle(v);
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

    public unsafe struct UInt32sHandle {
        public UInt32 count;
        public UInt32* array;

        public UInt32sHandle(params UInt32[] value) {
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

        public static implicit operator UInt32sHandle(UInt32 v) {
            return new UInt32sHandle(new UInt32[] { v });
        }

        public static implicit operator UInt32sHandle(UInt32[] v) {
            return new UInt32sHandle(v);
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

