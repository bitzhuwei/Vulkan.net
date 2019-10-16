using System;
using System.Runtime.InteropServices;

namespace Vulkan {

    public unsafe struct VkSemaphorePipelineStageGroup {
        public UInt32 count;
        public VkSemaphore* waitSemaphores;
        public VkPipelineStageFlagBits* waitDstStageMask;

        public void Set(params VkSemaphore[] value) {
            IntPtr ptr = (IntPtr)this.waitSemaphores;
            value.Set(ref ptr, ref this.count);
            this.waitSemaphores = (VkSemaphore*)ptr;
        }

        //public static implicit operator VkSemaphoresPipelineStagesHandle(VkSemaphore v) {
        //    var result = new VkSemaphoresPipelineStagesHandle();
        //    result.Set(v);
        //    return result;
        //}

        //public static implicit operator VkSemaphoresPipelineStagesHandle(VkSemaphore[] v) {
        //    var result = new VkSemaphoresPipelineStagesHandle();
        //    result.Set(v);
        //    return result;
        //}

        public void Set(params VkPipelineStageFlagBits[] value) {
            IntPtr ptr = (IntPtr)this.waitDstStageMask;
            value.Set(ref ptr, ref this.count);
            this.waitDstStageMask = (VkPipelineStageFlagBits*)ptr;
        }

        //public static implicit operator VkSemaphoresPipelineStagesHandle(VkPipelineStageFlagBits v) {
        //    var result = new VkSemaphoresPipelineStagesHandle();
        //    result.Set(v);
        //    return result;
        //}

        //public static implicit operator VkSemaphoresPipelineStagesHandle(VkPipelineStageFlagBits[] v) {
        //    var result = new VkSemaphoresPipelineStagesHandle();
        //    result.Set(v);
        //    return result;
        //}

        /// <summary>
        /// Free unmanaged memory and reset all members to 0.
        /// </summary>
        public void Reset() {
            {
                UInt32 count = this.count;
                IntPtr ptr = (IntPtr)this.waitSemaphores;
                Helper.Set<VkSemaphore>(null, ref ptr, ref count);
                this.waitSemaphores = (VkSemaphore*)ptr;
            }
            {
                UInt32 count = this.count;
                IntPtr ptr = (IntPtr)this.waitDstStageMask;
                Helper.Set<VkPipelineStageFlagBits>(null, ref ptr, ref count);
                this.waitDstStageMask = (VkPipelineStageFlagBits*)ptr;
            }
            {
                this.count = 0;
            }
        }

        public override string ToString() {
            if (count == 1) {
                return $"{waitSemaphores[0]}, {waitDstStageMask[0]}";
            }
            else {
                return $"{nameof(VkSemaphore)}[{count}], {nameof(VkPipelineStageFlagBits)}[{count}],";
            }
        }
    }

}
