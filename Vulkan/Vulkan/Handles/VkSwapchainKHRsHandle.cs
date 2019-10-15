using System;
using System.Runtime.InteropServices;

namespace Vulkan {

    public unsafe struct VkSwapchainKHRsUInt32sHandle {
        public UInt32 count;
        public VkSwapchainKHR* swapchains;
        public UInt32* imageIndices;

        public void Set(params VkSwapchainKHR[] value) {
            IntPtr ptr = (IntPtr)this.swapchains;
            value.Set(ref ptr, ref this.count);
            this.swapchains = (VkSwapchainKHR*)ptr;
        }

        //public static implicit operator VkSwapchainKHRsUInt32sHandle(VkSwapchainKHR v) {
        //    var result = new VkSwapchainKHRsUInt32sHandle();
        //    result.Set(v);
        //    return result;
        //}

        //public static implicit operator VkSwapchainKHRsUInt32sHandle(VkSwapchainKHR[] v) {
        //    var result = new VkSwapchainKHRsUInt32sHandle();
        //    result.Set(v);
        //    return result;
        //}

        public void Set(params UInt32[] value) {
            IntPtr ptr = (IntPtr)this.imageIndices;
            value.Set(ref ptr, ref this.count);
            this.imageIndices = (UInt32*)ptr;
        }

        //public static implicit operator VkSwapchainKHRsUInt32sHandle(UInt32 v) {
        //    var result = new VkSwapchainKHRsUInt32sHandle();
        //    result.Set(v);
        //    return result;
        //}

        //public static implicit operator VkSwapchainKHRsUInt32sHandle(UInt32[] v) {
        //    var result = new VkSwapchainKHRsUInt32sHandle();
        //    result.Set(v);
        //    return result;
        //}

        public override string ToString() {
            if (count == 1) {
                return $"{swapchains[0]}, {imageIndices[0]}";
            }
            else {
                return $"{nameof(VkSwapchainKHR)}[{count}], {nameof(UInt32)}[{count}],";
            }
        }
    }

}
