//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//using System.Text;

//namespace Vulkan {
//    public static unsafe partial class Vk {
//        public static void Free(VkInstanceCreateInfo* info, bool freeSelf = true) {
//            Free(ref info->ppEnabledExtensionNames, ref info->enabledExtensionCount);
//            Free(ref info->ppEnabledLayerNames, ref info->enabledLayerCount);
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkDeviceQueueCreateInfo* info, bool freeSelf = true) {
//            Free(ref info->pQueuePriorities, ref info->queueCount);
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkDeviceCreateInfo* info, bool freeSelf = true) {
//            Free(ref info->ppEnabledExtensionNames, ref info->enabledExtensionCount);
//            Free(ref info->ppEnabledLayerNames, ref info->enabledLayerCount);
//            var ptr = (IntPtr)info->pQueueCreateInfos;
//            Free(ref ptr, ref info->enabledLayerCount); info->pQueueCreateInfos = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkSwapchainCreateInfoKHR* info, bool freeSelf = true) {
//            Free(ref info->pQueueFamilyIndices, ref info->queueFamilyIndexCount);
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkRenderPassCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pAttachments;
//            Free(ref ptr, ref info->attachmentCount); info->pAttachments = null;
//            ptr = (IntPtr)info->pDependencies;
//            Free(ref ptr, ref info->dependencyCount); info->pDependencies = null;
//            ptr = (IntPtr)info->pSubpasses;
//            Free(ref ptr, ref info->subpassCount); info->pSubpasses = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkSubpassDescription* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pColorAttachments;
//            Free(ref ptr, ref info->colorAttachmentCount); info->pColorAttachments = null;
//            ptr = (IntPtr)info->pInputAttachments;
//            Free(ref ptr, ref info->inputAttachmentCount); info->pInputAttachments = null;
//            Free(ref info->pPreserveAttachments, ref info->preserveAttachmentCount);
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkFramebufferCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pAttachments;
//            Free(ref ptr, ref info->attachmentCount); info->pAttachments = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkBufferCreateInfo* info, bool freeSelf = true) {
//            Free(ref info->pQueueFamilyIndices, ref info->queueFamilyIndexCount);
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkDescriptorSetLayoutCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pBindings;
//            Free(ref ptr, ref info->bindingCount); info->pBindings = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkPipelineLayoutCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pSetLayouts;
//            Free(ref ptr, ref info->setLayoutCount); info->pSetLayouts = null;
//            ptr = (IntPtr)info->pPushConstantRanges;
//            Free(ref ptr, ref info->pushConstantRangeCount); info->pPushConstantRanges = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkGraphicsPipelineCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pStages;
//            Free(ref ptr, ref info->stageCount); info->pStages = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkPipelineVertexInputStateCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pVertexBindingDescriptions;
//            Free(ref ptr, ref info->vertexBindingDescriptionCount); info->pVertexBindingDescriptions = null;
//            ptr = (IntPtr)info->pVertexAttributeDescriptions;
//            Free(ref ptr, ref info->vertexAttributeDescriptionCount); info->pVertexAttributeDescriptions = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkPipelineColorBlendStateCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pAttachments;
//            Free(ref ptr, ref info->attachmentCount); info->pAttachments = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkPipelineViewportStateCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pViewports;
//            Free(ref ptr, ref info->viewportCount); info->pViewports = null;
//            ptr = (IntPtr)info->pScissors;
//            Free(ref ptr, ref info->scissorCount); info->pScissors = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkShaderModuleCreateInfo* info, bool freeSelf = true) {
//            UInt32 count = (UInt32)info->codeSize;
//            Free(ref info->pCode, ref count); info->codeSize = 0;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkDescriptorSetAllocateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pSetLayouts;
//            Free(ref ptr, ref info->descriptorSetCount); info->pSetLayouts = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkDescriptorPoolCreateInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pPoolSizes;
//            Free(ref ptr, ref info->poolSizeCount); info->pPoolSizes = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkWriteDescriptorSet* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pBufferInfo;
//            Free(ref ptr, ref info->descriptorCount); info->pBufferInfo = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkRenderPassBeginInfo* info, bool freeSelf = true) {
//            var ptr = (IntPtr)info->pClearValues;
//            Free(ref ptr, ref info->clearValueCount); info->pClearValues = null;
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(VkPipelineShaderStageCreateInfo* info, bool freeSelf = true) {
//            Free(ref info->pName);
//            if (freeSelf) { Marshal.FreeHGlobal((IntPtr)info); }
//        }

//        public static void Free(ref Boolean* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Byte* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Int16* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Int32* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Int64* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Char* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref SByte* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref UInt16* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref UInt32* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref UInt64* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Single* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }
//        public static void Free(ref Double* names, ref UInt32 count) {
//            var target = (IntPtr)names;
//            if (target != null) {
//                Marshal.FreeHGlobal((IntPtr)target);
//            }

//            names = null;
//            count = 0;
//        }

//        /// <summary>
//        /// Free string in unmanaged memory.
//        /// </summary>
//        /// <param name="target"></param>
//        public static void Free(ref IntPtr target) {
//            if (target != IntPtr.Zero) {
//                Marshal.FreeHGlobal(target);
//                target = IntPtr.Zero;
//            }
//        }

//        /// <summary>
//        /// Free strings in unmanaged memory.
//        /// </summary>
//        /// <param name="names"></param>
//        /// <param name="count"></param>
//        public static void Free(ref IntPtr* names, ref UInt32 count) {
//            IntPtr* target = names;
//            UInt32 length = count;
//            if (target != null) {
//                for (int i = 0; i < length; i++) {
//                    Marshal.FreeHGlobal(target[i]);
//                }
//            }

//            names = null;
//            count = 0;
//        }

//        /// <summary>
//        /// Free T[] in unmanaged memory.
//        /// </summary>
//        /// <param name="target"></param>
//        /// <param name="count"></param>
//        public static void Free(ref IntPtr target, ref UInt32 count) {
//            if (target != IntPtr.Zero) {
//                Marshal.FreeHGlobal(target);
//                target = IntPtr.Zero;
//                count = 0;
//            }
//        }
//    }
//}
