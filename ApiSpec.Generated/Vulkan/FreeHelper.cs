using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ApiSpec.Generated {
    public static unsafe class FreeHelper {
        public static void Free(ref VkInstanceCreateInfo info) {
            Free(ref info.ppEnabledExtensionNames, ref info.enabledExtensionCount);
            Free(ref info.ppEnabledLayerNames, ref info.enabledLayerCount);
        }

        public static void Free(ref VkDeviceQueueCreateInfo info) {
            Free(ref info.pQueuePriorities, ref info.queueCount);
        }

        public static void Free(ref VkDeviceCreateInfo info) {
            Free(ref info.ppEnabledExtensionNames, ref info.enabledExtensionCount);
            Free(ref info.ppEnabledLayerNames, ref info.enabledLayerCount);
            var ptr = (IntPtr)info.pQueueCreateInfos;
            Free(ref ptr, ref info.enabledLayerCount); info.pQueueCreateInfos = null;
        }

        public static void Free(ref VkSwapchainCreateInfoKHR info) {
            Free(ref info.pQueueFamilyIndices, ref info.queueFamilyIndexCount);
        }

        public static void Free(ref VkRenderPassCreateInfo info) {
            var ptr = (IntPtr)info.pAttachments;
            Free(ref ptr, ref info.attachmentCount); info.pAttachments = null;
            ptr = (IntPtr)info.pDependencies;
            Free(ref ptr, ref info.dependencyCount); info.pDependencies = null;
            ptr = (IntPtr)info.pSubpasses;
            Free(ref ptr, ref info.subpassCount); info.pSubpasses = null;
        }

        public static void Free(ref VkSubpassDescription info) {
            var ptr = (IntPtr)info.pColorAttachments;
            Free(ref ptr, ref info.colorAttachmentCount); info.pColorAttachments = null;
            ptr = (IntPtr)info.pInputAttachments;
            Free(ref ptr, ref info.inputAttachmentCount); info.pInputAttachments = null;
            Free(ref info.pPreserveAttachments, ref info.preserveAttachmentCount);
        }

        public static void Free(ref VkFramebufferCreateInfo info) {
            var ptr = (IntPtr)info.pAttachments;
            Free(ref ptr, ref info.attachmentCount); info.pAttachments = null;
        }

        public static void Free(ref VkBufferCreateInfo info) {
            Free(ref info.pQueueFamilyIndices, ref info.queueFamilyIndexCount);
        }

        public static void Free(ref VkDescriptorSetLayoutCreateInfo info) {
            var ptr = (IntPtr)info.pBindings;
            Free(ref ptr, ref info.bindingCount); info.pBindings = null;
        }

        public static void Free(ref VkPipelineLayoutCreateInfo info) {
            var ptr = (IntPtr)info.pSetLayouts;
            Free(ref ptr, ref info.setLayoutCount); info.pSetLayouts = null;
            ptr = (IntPtr)info.pPushConstantRanges;
            Free(ref ptr, ref info.pushConstantRangeCount); info.pPushConstantRanges = null;
        }

        public static void Free(ref VkGraphicsPipelineCreateInfo info) {
            var ptr = (IntPtr)info.pStages;
            Free(ref ptr, ref info.stageCount); info.pStages = null;
        }

        public static void Free(ref VkPipelineVertexInputStateCreateInfo info) {
            var ptr = (IntPtr)info.pVertexBindingDescriptions;
            Free(ref ptr, ref info.vertexBindingDescriptionCount); info.pVertexBindingDescriptions = null;
            ptr = (IntPtr)info.pVertexAttributeDescriptions;
            Free(ref ptr, ref info.vertexAttributeDescriptionCount); info.pVertexAttributeDescriptions = null;
        }

        public static void Free(ref VkPipelineColorBlendStateCreateInfo info) {
            var ptr = (IntPtr)info.pAttachments;
            Free(ref ptr, ref info.attachmentCount); info.pAttachments = null;
        }

        public static void Free(ref VkPipelineViewportStateCreateInfo info) {
            var ptr = (IntPtr)info.pViewports;
            Free(ref ptr, ref info.viewportCount); info.pViewports = null;
            ptr = (IntPtr)info.pScissors;
            Free(ref ptr, ref info.scissorCount); info.pScissors = null;
        }

        public static void Free(ref VkShaderModuleCreateInfo info) {
            UInt32 count = (UInt32)info.codeSize;
            Free(ref info.pCode, ref count); info.codeSize = 0;
        }

        public static void Free(ref VkDescriptorSetAllocateInfo info) {
            var ptr = (IntPtr)info.pSetLayouts;
            Free(ref ptr, ref info.descriptorSetCount); info.pSetLayouts = null;
        }

        public static void Free(ref VkDescriptorPoolCreateInfo info) {
            var ptr = (IntPtr)info.pPoolSizes;
            Free(ref ptr, ref info.poolSizeCount); info.pPoolSizes = null;
        }

        public static void Free(ref VkWriteDescriptorSet info) {
            var ptr = (IntPtr)info.pBufferInfo;
            Free(ref ptr, ref info.descriptorCount); info.pBufferInfo = null;
        }

        public static void Free(ref VkRenderPassBeginInfo info) {
            var ptr = (IntPtr)info.pClearValues;
            Free(ref ptr, ref info.clearValueCount); info.pClearValues = null;
        }

        public static void Free(ref VkPipelineShaderStageCreateInfo info) {
            Free(ref info.pName);
        }

        public static void Free(ref Boolean* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Byte* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Int16* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Int32* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Int64* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Char* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref SByte* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref UInt16* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref UInt32* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref UInt64* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Single* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }
        public static void Free(ref Double* names, ref UInt32 count) {
            var target = (IntPtr)names;
            if (target != null) {
                Marshal.FreeHGlobal((IntPtr)target);
            }

            names = null;
            count = 0;
        }

        /// <summary>
        /// Free string in unmanaged memory.
        /// </summary>
        /// <param name="target"></param>
        public static void Free(ref IntPtr target) {
            if (target != IntPtr.Zero) {
                Marshal.FreeHGlobal(target);
                target = IntPtr.Zero;
            }
        }

        /// <summary>
        /// Free strings in unmanaged memory.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="count"></param>
        public static void Free(ref IntPtr* names, ref UInt32 count) {
            IntPtr* target = names;
            UInt32 length = count;
            if (target != null) {
                for (int i = 0; i < length; i++) {
                    Marshal.FreeHGlobal(target[i]);
                }
            }

            names = null;
            count = 0;
        }

        /// <summary>
        /// Free T[] in unmanaged memory.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="count"></param>
        public static void Free(ref IntPtr target, ref UInt32 count) {
            if (target != IntPtr.Zero) {
                Marshal.FreeHGlobal(target);
                target = IntPtr.Zero;
                count = 0;
            }
        }
    }
}
