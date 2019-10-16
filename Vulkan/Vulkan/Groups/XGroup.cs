﻿using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct VkDescriptorPoolSizeGroup {
        public UInt32 count;
        public VkDescriptorPoolSize* array;

        public VkDescriptorPoolSizeGroup(params VkDescriptorPoolSize[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkDescriptorPoolSize*)ptr;
			}
        }

        public void Set(params VkDescriptorPoolSize[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorPoolSize*)ptr;
        }

        public static implicit operator VkDescriptorPoolSizeGroup(VkDescriptorPoolSize v) {
            return new VkDescriptorPoolSizeGroup(new VkDescriptorPoolSize[] { v });
        }

        public static implicit operator VkDescriptorPoolSizeGroup(VkDescriptorPoolSize[] v) {
            return new VkDescriptorPoolSizeGroup(v);
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

    public unsafe struct VkDescriptorSetLayoutBindingGroup {
        public UInt32 count;
        public VkDescriptorSetLayoutBinding* array;

        public VkDescriptorSetLayoutBindingGroup(params VkDescriptorSetLayoutBinding[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkDescriptorSetLayoutBinding*)ptr;
			}
        }

        public void Set(params VkDescriptorSetLayoutBinding[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayoutBinding*)ptr;
        }

        public static implicit operator VkDescriptorSetLayoutBindingGroup(VkDescriptorSetLayoutBinding v) {
            return new VkDescriptorSetLayoutBindingGroup(new VkDescriptorSetLayoutBinding[] { v });
        }

        public static implicit operator VkDescriptorSetLayoutBindingGroup(VkDescriptorSetLayoutBinding[] v) {
            return new VkDescriptorSetLayoutBindingGroup(v);
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

    public unsafe struct VkDescriptorSetLayoutGroup {
        public UInt32 count;
        public VkDescriptorSetLayout* array;

        public VkDescriptorSetLayoutGroup(params VkDescriptorSetLayout[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkDescriptorSetLayout*)ptr;
			}
        }

        public void Set(params VkDescriptorSetLayout[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDescriptorSetLayout*)ptr;
        }

        public static implicit operator VkDescriptorSetLayoutGroup(VkDescriptorSetLayout v) {
            return new VkDescriptorSetLayoutGroup(new VkDescriptorSetLayout[] { v });
        }

        public static implicit operator VkDescriptorSetLayoutGroup(VkDescriptorSetLayout[] v) {
            return new VkDescriptorSetLayoutGroup(v);
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

    public unsafe struct VkDeviceQueueCreateInfoGroup {
        public UInt32 count;
        public VkDeviceQueueCreateInfo* array;

        public VkDeviceQueueCreateInfoGroup(params VkDeviceQueueCreateInfo[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkDeviceQueueCreateInfo*)ptr;
			}
        }

        public void Set(params VkDeviceQueueCreateInfo[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDeviceQueueCreateInfo*)ptr;
        }

        public static implicit operator VkDeviceQueueCreateInfoGroup(VkDeviceQueueCreateInfo v) {
            return new VkDeviceQueueCreateInfoGroup(new VkDeviceQueueCreateInfo[] { v });
        }

        public static implicit operator VkDeviceQueueCreateInfoGroup(VkDeviceQueueCreateInfo[] v) {
            return new VkDeviceQueueCreateInfoGroup(v);
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

    public unsafe struct VkDynamicStateGroup {
        public UInt32 count;
        public VkDynamicState* array;

        public VkDynamicStateGroup(params VkDynamicState[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkDynamicState*)ptr;
			}
        }

        public void Set(params VkDynamicState[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkDynamicState*)ptr;
        }

        public static implicit operator VkDynamicStateGroup(VkDynamicState v) {
            return new VkDynamicStateGroup(new VkDynamicState[] { v });
        }

        public static implicit operator VkDynamicStateGroup(VkDynamicState[] v) {
            return new VkDynamicStateGroup(v);
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

    public unsafe struct VkPipelineColorBlendAttachmentStateGroup {
        public UInt32 count;
        public VkPipelineColorBlendAttachmentState* array;

        public VkPipelineColorBlendAttachmentStateGroup(params VkPipelineColorBlendAttachmentState[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkPipelineColorBlendAttachmentState*)ptr;
			}
        }

        public void Set(params VkPipelineColorBlendAttachmentState[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPipelineColorBlendAttachmentState*)ptr;
        }

        public static implicit operator VkPipelineColorBlendAttachmentStateGroup(VkPipelineColorBlendAttachmentState v) {
            return new VkPipelineColorBlendAttachmentStateGroup(new VkPipelineColorBlendAttachmentState[] { v });
        }

        public static implicit operator VkPipelineColorBlendAttachmentStateGroup(VkPipelineColorBlendAttachmentState[] v) {
            return new VkPipelineColorBlendAttachmentStateGroup(v);
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

    public unsafe struct VkPipelineShaderStageCreateInfoGroup {
        public UInt32 count;
        public VkPipelineShaderStageCreateInfo* array;

        public VkPipelineShaderStageCreateInfoGroup(params VkPipelineShaderStageCreateInfo[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkPipelineShaderStageCreateInfo*)ptr;
			}
        }

        public void Set(params VkPipelineShaderStageCreateInfo[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPipelineShaderStageCreateInfo*)ptr;
        }

        public static implicit operator VkPipelineShaderStageCreateInfoGroup(VkPipelineShaderStageCreateInfo v) {
            return new VkPipelineShaderStageCreateInfoGroup(new VkPipelineShaderStageCreateInfo[] { v });
        }

        public static implicit operator VkPipelineShaderStageCreateInfoGroup(VkPipelineShaderStageCreateInfo[] v) {
            return new VkPipelineShaderStageCreateInfoGroup(v);
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

    public unsafe struct VkRect2DGroup {
        public UInt32 count;
        public VkRect2D* array;

        public VkRect2DGroup(params VkRect2D[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkRect2D*)ptr;
			}
        }

        public void Set(params VkRect2D[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkRect2D*)ptr;
        }

        public static implicit operator VkRect2DGroup(VkRect2D v) {
            return new VkRect2DGroup(new VkRect2D[] { v });
        }

        public static implicit operator VkRect2DGroup(VkRect2D[] v) {
            return new VkRect2DGroup(v);
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

    public unsafe struct VkVertexInputAttributeDescriptionGroup {
        public UInt32 count;
        public VkVertexInputAttributeDescription* array;

        public VkVertexInputAttributeDescriptionGroup(params VkVertexInputAttributeDescription[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkVertexInputAttributeDescription*)ptr;
			}
        }

        public void Set(params VkVertexInputAttributeDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkVertexInputAttributeDescription*)ptr;
        }

        public static implicit operator VkVertexInputAttributeDescriptionGroup(VkVertexInputAttributeDescription v) {
            return new VkVertexInputAttributeDescriptionGroup(new VkVertexInputAttributeDescription[] { v });
        }

        public static implicit operator VkVertexInputAttributeDescriptionGroup(VkVertexInputAttributeDescription[] v) {
            return new VkVertexInputAttributeDescriptionGroup(v);
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

    public unsafe struct VkVertexInputBindingDescriptionGroup {
        public UInt32 count;
        public VkVertexInputBindingDescription* array;

        public VkVertexInputBindingDescriptionGroup(params VkVertexInputBindingDescription[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkVertexInputBindingDescription*)ptr;
			}
        }

        public void Set(params VkVertexInputBindingDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkVertexInputBindingDescription*)ptr;
        }

        public static implicit operator VkVertexInputBindingDescriptionGroup(VkVertexInputBindingDescription v) {
            return new VkVertexInputBindingDescriptionGroup(new VkVertexInputBindingDescription[] { v });
        }

        public static implicit operator VkVertexInputBindingDescriptionGroup(VkVertexInputBindingDescription[] v) {
            return new VkVertexInputBindingDescriptionGroup(v);
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

    public unsafe struct VkViewportGroup {
        public UInt32 count;
        public VkViewport* array;

        public VkViewportGroup(params VkViewport[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkViewport*)ptr;
			}
        }

        public void Set(params VkViewport[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkViewport*)ptr;
        }

        public static implicit operator VkViewportGroup(VkViewport v) {
            return new VkViewportGroup(new VkViewport[] { v });
        }

        public static implicit operator VkViewportGroup(VkViewport[] v) {
            return new VkViewportGroup(v);
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

    public unsafe struct VkImageViewGroup {
        public UInt32 count;
        public VkImageView* array;

        public VkImageViewGroup(params VkImageView[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkImageView*)ptr;
			}
        }

        public void Set(params VkImageView[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkImageView*)ptr;
        }

        public static implicit operator VkImageViewGroup(VkImageView v) {
            return new VkImageViewGroup(new VkImageView[] { v });
        }

        public static implicit operator VkImageViewGroup(VkImageView[] v) {
            return new VkImageViewGroup(v);
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

    public unsafe struct VkSwapchainKHRGroup {
        public UInt32 count;
        public VkSwapchainKHR* array;

        public VkSwapchainKHRGroup(params VkSwapchainKHR[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkSwapchainKHR*)ptr;
			}
        }

        public void Set(params VkSwapchainKHR[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSwapchainKHR*)ptr;
        }

        public static implicit operator VkSwapchainKHRGroup(VkSwapchainKHR v) {
            return new VkSwapchainKHRGroup(new VkSwapchainKHR[] { v });
        }

        public static implicit operator VkSwapchainKHRGroup(VkSwapchainKHR[] v) {
            return new VkSwapchainKHRGroup(v);
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

    public unsafe struct VkSemaphoreGroup {
        public UInt32 count;
        public VkSemaphore* array;

        public VkSemaphoreGroup(params VkSemaphore[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkSemaphore*)ptr;
			}
        }

        public void Set(params VkSemaphore[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSemaphore*)ptr;
        }

        public static implicit operator VkSemaphoreGroup(VkSemaphore v) {
            return new VkSemaphoreGroup(new VkSemaphore[] { v });
        }

        public static implicit operator VkSemaphoreGroup(VkSemaphore[] v) {
            return new VkSemaphoreGroup(v);
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

    public unsafe struct VkClearValueGroup {
        public UInt32 count;
        public VkClearValue* array;

        public VkClearValueGroup(params VkClearValue[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkClearValue*)ptr;
			}
        }

        public void Set(params VkClearValue[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkClearValue*)ptr;
        }

        public static implicit operator VkClearValueGroup(VkClearValue v) {
            return new VkClearValueGroup(new VkClearValue[] { v });
        }

        public static implicit operator VkClearValueGroup(VkClearValue[] v) {
            return new VkClearValueGroup(v);
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

    public unsafe struct VkAttachmentDescriptionGroup {
        public UInt32 count;
        public VkAttachmentDescription* array;

        public VkAttachmentDescriptionGroup(params VkAttachmentDescription[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkAttachmentDescription*)ptr;
			}
        }

        public void Set(params VkAttachmentDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkAttachmentDescription*)ptr;
        }

        public static implicit operator VkAttachmentDescriptionGroup(VkAttachmentDescription v) {
            return new VkAttachmentDescriptionGroup(new VkAttachmentDescription[] { v });
        }

        public static implicit operator VkAttachmentDescriptionGroup(VkAttachmentDescription[] v) {
            return new VkAttachmentDescriptionGroup(v);
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

    public unsafe struct VkSubpassDescriptionGroup {
        public UInt32 count;
        public VkSubpassDescription* array;

        public VkSubpassDescriptionGroup(params VkSubpassDescription[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkSubpassDescription*)ptr;
			}
        }

        public void Set(params VkSubpassDescription[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSubpassDescription*)ptr;
        }

        public static implicit operator VkSubpassDescriptionGroup(VkSubpassDescription v) {
            return new VkSubpassDescriptionGroup(new VkSubpassDescription[] { v });
        }

        public static implicit operator VkSubpassDescriptionGroup(VkSubpassDescription[] v) {
            return new VkSubpassDescriptionGroup(v);
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

    public unsafe struct VkSubpassDependencyGroup {
        public UInt32 count;
        public VkSubpassDependency* array;

        public VkSubpassDependencyGroup(params VkSubpassDependency[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkSubpassDependency*)ptr;
			}
        }

        public void Set(params VkSubpassDependency[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkSubpassDependency*)ptr;
        }

        public static implicit operator VkSubpassDependencyGroup(VkSubpassDependency v) {
            return new VkSubpassDependencyGroup(new VkSubpassDependency[] { v });
        }

        public static implicit operator VkSubpassDependencyGroup(VkSubpassDependency[] v) {
            return new VkSubpassDependencyGroup(v);
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

    public unsafe struct VkCommandBufferGroup {
        public UInt32 count;
        public VkCommandBuffer* array;

        public VkCommandBufferGroup(params VkCommandBuffer[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkCommandBuffer*)ptr;
			}
        }

        public void Set(params VkCommandBuffer[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkCommandBuffer*)ptr;
        }

        public static implicit operator VkCommandBufferGroup(VkCommandBuffer v) {
            return new VkCommandBufferGroup(new VkCommandBuffer[] { v });
        }

        public static implicit operator VkCommandBufferGroup(VkCommandBuffer[] v) {
            return new VkCommandBufferGroup(v);
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

    public unsafe struct VkAttachmentReferenceGroup {
        public UInt32 count;
        public VkAttachmentReference* array;

        public VkAttachmentReferenceGroup(params VkAttachmentReference[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkAttachmentReference*)ptr;
			}
        }

        public void Set(params VkAttachmentReference[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkAttachmentReference*)ptr;
        }

        public static implicit operator VkAttachmentReferenceGroup(VkAttachmentReference v) {
            return new VkAttachmentReferenceGroup(new VkAttachmentReference[] { v });
        }

        public static implicit operator VkAttachmentReferenceGroup(VkAttachmentReference[] v) {
            return new VkAttachmentReferenceGroup(v);
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

    public unsafe struct VkPushConstantRangeGroup {
        public UInt32 count;
        public VkPushConstantRange* array;

        public VkPushConstantRangeGroup(params VkPushConstantRange[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (VkPushConstantRange*)ptr;
			}
        }

        public void Set(params VkPushConstantRange[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (VkPushConstantRange*)ptr;
        }

        public static implicit operator VkPushConstantRangeGroup(VkPushConstantRange v) {
            return new VkPushConstantRangeGroup(new VkPushConstantRange[] { v });
        }

        public static implicit operator VkPushConstantRangeGroup(VkPushConstantRange[] v) {
            return new VkPushConstantRangeGroup(v);
        }

        public override string ToString() {
            if (count == 1) {
                return $"{array[0]}";
            }
            else {
                return $"{nameof(VkPushConstantRange)}[{count}]";
            }
        }
    }

    public unsafe struct SingleGroup {
        public UInt32 count;
        public Single* array;

        public SingleGroup(params Single[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (Single*)ptr;
			}
        }

        public void Set(params Single[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (Single*)ptr;
        }

        public static implicit operator SingleGroup(Single v) {
            return new SingleGroup(new Single[] { v });
        }

        public static implicit operator SingleGroup(Single[] v) {
            return new SingleGroup(v);
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

    public unsafe struct UInt32Group {
        public UInt32 count;
        public UInt32* array;

        public UInt32Group(params UInt32[] value) {
            count = 0;
            array = null;
			if (value != null) {
				IntPtr ptr = IntPtr.Zero;
				value.Set(ref ptr, ref this.count);
				this.array = (UInt32*)ptr;
			}
        }

        public void Set(params UInt32[] value) {
            IntPtr ptr = (IntPtr)this.array;
            value.Set(ref ptr, ref this.count);
            this.array = (UInt32*)ptr;
        }

        public static implicit operator UInt32Group(UInt32 v) {
            return new UInt32Group(new UInt32[] { v });
        }

        public static implicit operator UInt32Group(UInt32[] v) {
            return new UInt32Group(v);
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
