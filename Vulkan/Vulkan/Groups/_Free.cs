using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe partial struct VkInstanceCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.EnabledExtensions.Set(null);
            this.EnabledLayers.Set(null);
        }
    }

    public unsafe partial struct VkApplicationInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.pApplicationName.Set(null);
            this.pEngineName.Set(null);
        }
    }

    public unsafe partial struct VkDeviceQueueCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.queuePriorities.Set(null);
        }
    }

    public unsafe partial struct VkDeviceCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.EnabledExtensions.Set(null);
            this.EnabledLayers.Set(null);
            this.queueCreateInfos.Set(null);
        }
    }

    public unsafe partial struct VkSwapchainCreateInfoKHR {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.queueFamilyIndices.Set(null);
        }
    }

    public unsafe partial struct VkRenderPassCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.attachments.Set(null);
            this.subpasses.Set(null);
            this.dependencies.Set(null);
        }
    }

    public unsafe partial struct VkSubpassDescription {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.inputAttachments.Set(null);
            this.colorResolveAttachments.Reset();
            this.preserveAttachments.Set(null);
        }
    }

    public unsafe partial struct VkFramebufferCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.attachments.Set(null);
        }
    }

    public unsafe partial struct VkBufferCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.queueFamilyIndices.Set(null);
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.bindings.Set(null);
        }
    }

    public unsafe partial struct VkPipelineLayoutCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.setLayouts.Set(null);
            this.pushConstantRanges.Set(null);
        }
    }

    public unsafe partial struct VkGraphicsPipelineCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.stages.Set(null);
        }
    }

    public unsafe partial struct VkPipelineVertexInputStateCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.vertexBindingDescriptions.Set(null);
            this.vertexAttributeDescriptions.Set(null);
        }
    }

    public unsafe partial struct VkPipelineColorBlendStateCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.attachments.Set(null);
        }
    }

    public unsafe partial struct VkPipelineViewportStateCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.viewports.Set(null);
            this.scissors.Set(null);
        }
    }

    public unsafe partial struct VkShaderModuleCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.code.Set(null);
        }
    }

    public unsafe partial struct VkDescriptorSetAllocateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.setLayouts.Set(null);
        }
    }

    public unsafe partial struct VkDescriptorPoolCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.poolSizes.Set(null);
        }
    }

    public unsafe partial struct VkWriteDescriptorSet {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.data.Reset();
        }
    }

    public unsafe partial struct VkRenderPassBeginInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.clearValues.Set(null);
        }
    }

    public unsafe partial struct VkPipelineShaderStageCreateInfo {
        /// <summary>
        /// Free unmanaged memory and set all related members to 0.
        /// </summary>
        public void Free() {
            this.pName.Set(null);
        }
    }

    //public static unsafe partial class Vk {

    //    public static void Free(ref Boolean* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Byte* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Int16* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Int32* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Int64* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Char* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref SByte* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref UInt16* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref UInt32* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref UInt64* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Single* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }
    //    public static void Free(ref Double* names, ref UInt32 count) {
    //        var target = (IntPtr)names;
    //        if (target != null) {
    //            Marshal.FreeHGlobal((IntPtr)target);
    //        }

    //        names = null;
    //        count = 0;
    //    }

    //    /// <summary>
    //    /// Free string in unmanaged memory.
    //    /// </summary>
    //    /// <param name="target"></param>
    //    public static void Free(ref IntPtr target) {
    //        if (target != IntPtr.Zero) {
    //            Marshal.FreeHGlobal(target);
    //            target = IntPtr.Zero;
    //        }
    //    }

    //    /// <summary>
    //    /// Free strings in unmanaged memory.
    //    /// </summary>
    //    /// <param name="names"></param>
    //    /// <param name="count"></param>
    //    public static void Free(ref IntPtr* names, ref UInt32 count) {
    //        IntPtr* target = names;
    //        UInt32 length = count;
    //        if (target != null) {
    //            for (int i = 0; i < length; i++) {
    //                Marshal.FreeHGlobal(target[i]);
    //            }
    //        }

    //        names = null;
    //        count = 0;
    //    }

    //    /// <summary>
    //    /// Free T[] in unmanaged memory.
    //    /// </summary>
    //    /// <param name="target"></param>
    //    /// <param name="count"></param>
    //    public static void Free(ref IntPtr target, ref UInt32 count) {
    //        if (target != IntPtr.Zero) {
    //            Marshal.FreeHGlobal(target);
    //            target = IntPtr.Zero;
    //            count = 0;
    //        }
    //    }
    //}
}
