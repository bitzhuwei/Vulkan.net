using System;
using System.Runtime.InteropServices;

namespace Vulkan {

    public unsafe struct VkColorResolveAttachmentsGroup {
        public UInt32 count;
        public VkAttachmentReference* colorAttachments;
        public VkAttachmentReference* resolveAttachments;

        public void SetColorAttachments(params VkAttachmentReference[] value) {
            IntPtr ptr = (IntPtr)this.colorAttachments;
            value.Set(ref ptr, ref this.count);
            this.colorAttachments = (VkAttachmentReference*)ptr;
        }

        //public static implicit operator VkColorResolveAttachmentsHandle(VkAttachmentReference v) {
        //    var result = new VkColorResolveAttachmentsHandle();
        //    result.Set(v);
        //    return result;
        //}

        //public static implicit operator VkColorResolveAttachmentsHandle(VkAttachmentReference[] v) {
        //    var result = new VkColorResolveAttachmentsHandle();
        //    result.Set(v);
        //    return result;
        //}

        public void SetResolveAttachments(params VkAttachmentReference[] value) {
            IntPtr ptr = (IntPtr)this.resolveAttachments;
            value.Set(ref ptr, ref this.count);
            this.resolveAttachments = (VkAttachmentReference*)ptr;
        }

        //public static implicit operator VkColorResolveAttachmentsHandle(VkAttachmentReference v) {
        //    var result = new VkColorResolveAttachmentsHandle();
        //    result.Set(v);
        //    return result;
        //}

        //public static implicit operator VkColorResolveAttachmentsHandle(VkAttachmentReference[] v) {
        //    var result = new VkColorResolveAttachmentsHandle();
        //    result.Set(v);
        //    return result;
        //}

        public override string ToString() {
            if (count == 1) {
                return $"{colorAttachments[0]}, {resolveAttachments[0]}";
            }
            else {
                return $"{nameof(VkAttachmentReference)}[{count}], {nameof(VkAttachmentReference)}[{count}],";
            }
        }
    }

}
