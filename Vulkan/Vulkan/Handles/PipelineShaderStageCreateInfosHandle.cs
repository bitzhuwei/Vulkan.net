using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe struct PipelineShaderStageCreateInfosHandle {
        public UInt32 count;
        public VkPipelineShaderStageCreateInfo* array;

        public PipelineShaderStageCreateInfosHandle(params VkPipelineShaderStageCreateInfo[] value) {
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

        public static implicit operator PipelineShaderStageCreateInfosHandle(VkPipelineShaderStageCreateInfo v) {
            return new PipelineShaderStageCreateInfosHandle(new VkPipelineShaderStageCreateInfo[] { v });
        }

        public static implicit operator PipelineShaderStageCreateInfosHandle(VkPipelineShaderStageCreateInfo[] v) {
            return new PipelineShaderStageCreateInfosHandle(v);
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
}
