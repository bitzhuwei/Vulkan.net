using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkCommandBuffer {
        public readonly VkDevice device;
        public readonly IntPtr handle;

        public static VkResult Allocate(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, out VkCommandBuffer[] commandBuffers) {
            if (device == null) { throw new ArgumentNullException("device"); }

            VkResult result = VkResult.Success;
            uint count = allocateInfo.CommandBufferCount;
            var handles = new IntPtr[count];
            if (count > 0) {
                fixed (IntPtr* pointer = handles) {
                    fixed (VkCommandBufferAllocateInfo* pAllocateInfo = &allocateInfo) {
                        result = vkAPI.vkAllocateCommandBuffers(device.handle, pAllocateInfo, pointer).Check();
                    }
                }
            }

            commandBuffers = new VkCommandBuffer[count];
            for (int i = 0; i < count; i++) {
                commandBuffers[i] = new VkCommandBuffer(device, handles[i]);
            }

            return result;
        }

        public VkCommandBuffer(VkDevice device, IntPtr handle) {
            this.device = device;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkCommandBuffer)}, {device}, {handle}";

        public void Reset(VkCommandBufferResetFlags flags) {
            vkAPI.vkResetCommandBuffer(this.handle, flags);
        }

        public void Free(VkCommandPool commandPool) {
            fixed (IntPtr* pointer = &this.handle) {
                vkAPI.vkFreeCommandBuffers(this.device.handle, commandPool != null ? commandPool.handle : default(UInt64), 1, pointer);
            }
        }

        //public static void Free(IntPtr device, VkCommandPool commandPool, params IntPtr[] commandBuffers) {
        //    if (commandBuffers == null || commandBuffers.Length == 0) { return; }

        //    fixed (IntPtr* pointer = commandBuffers) {
        //        vkAPI.vkFreeCommandBuffers(device, commandPool != null ? commandPool.handle : default(UInt64), (UInt32)commandBuffers.Length, pointer);
        //    }
        //}

        public static void Free(VkDevice device, VkCommandPool commandPool, params VkCommandBuffer[] commandBuffers) {
            if (commandBuffers == null || commandBuffers.Length == 0) { return; }

            var buffers = new IntPtr[commandBuffers.Length];
            for (int i = 0; i < commandBuffers.Length; i++) {
                buffers[i] = commandBuffers[i].handle;
            }
            fixed (IntPtr* pointer = buffers) {
                vkAPI.vkFreeCommandBuffers(device.handle, commandPool != null ? commandPool.handle : default(UInt64), (UInt32)commandBuffers.Length, pointer);
            }
        }

        public VkResult Begin(VkCommandBufferBeginInfo* beginInfo) {
            return vkAPI.vkBeginCommandBuffer(this.handle, beginInfo).Check();
        }

        public VkResult End() {
            return vkAPI.vkEndCommandBuffer(this.handle).Check();
        }

        public void CmdExecuteCommands(params VkCommandBuffer[] commandBuffers) {
            if (commandBuffers == null || commandBuffers.Length == 0) { return; }

            var buffers = new IntPtr[commandBuffers.Length];
            for (int i = 0; i < commandBuffers.Length; i++) {
                buffers[i] = commandBuffers[i].handle;
            }
            fixed (IntPtr* pointer = buffers) {
                vkAPI.vkCmdExecuteCommands(this.handle, (UInt32)buffers.Length, pointer);
            }
        }


        public VkResult CmdSet(VkEvent vkEvent, VkPipelineStageFlags stageMask) {
            return vkAPI.vkCmdSetEvent(this.handle, vkEvent.handle, stageMask).Check();
        }

        public VkResult CmdReset(VkEvent vkEvent, VkPipelineStageFlags stageMask) {
            return vkAPI.vkCmdResetEvent(this.handle, vkEvent.handle, stageMask).Check();
        }

        public void CmdBeginRenderPass(ref VkRenderPassBeginInfo begin, VkSubpassContents contents) {
            fixed (VkRenderPassBeginInfo* pBegin = &begin) {
                vkAPI.vkCmdBeginRenderPass(this.handle, pBegin, contents);
            }
        }

        public void CmdNextSubpass(VkSubpassContents contents) {
            vkAPI.vkCmdNextSubpass(this.handle, contents);
        }

        public void CmdEndRenderPass() {
            vkAPI.vkCmdEndRenderPass(this.handle);
        }

        public void CmdBindPipeline(VkPipelineBindPoint bindPoint, VkPipeline pipeline) {
            if (pipeline == null) { return; }

            vkAPI.vkCmdBindPipeline(this.handle, bindPoint, pipeline.handle);
        }

        public void CmdBindDescriptorSets(VkPipelineBindPoint bindPoint, VkPipelineLayout layout, UInt32 firstSet, VkDescriptorSet[] sets, UInt32[] offsets) {
            var handles = new UInt64[sets.Length];
            for (int i = 0; i < handles.Length; i++) {
                handles[i] = sets[i].handle;
            }

            fixed (UInt64* pSets = handles) {
                fixed (UInt32* pOffsets = offsets) {
                    vkAPI.vkCmdBindDescriptorSets(this.handle, bindPoint, layout.handle, firstSet, (UInt32)sets.Length, pSets, (UInt32)offsets.Length, pOffsets);
                }
            }
        }

        public void CmdPushConstants(VkPipelineLayout layout, VkShaderStageFlags stageFlags, UInt32 offset, UInt32 size, IntPtr pValues) {
            vkAPI.vkCmdPushConstants(this.handle, layout.handle, stageFlags, offset, size, pValues);
        }

        public void CmdResetQueryPool(VkQueryPool queryPool, UInt32 firstQuery, UInt32 queryCount) {
            vkAPI.vkCmdResetQueryPool(this.handle, queryPool.handle, firstQuery, queryCount);
        }

        public void CmdBeginQuery(VkQueryPool queryPool, UInt32 entry, VkQueryControlFlags flags) {
            vkAPI.vkCmdBeginQuery(this.handle, queryPool.handle, entry, flags);
        }

        public void CmdEndQuery(VkQueryPool queryPool, UInt32 query) {
            vkAPI.vkCmdEndQuery(this.handle, queryPool.handle, query);
        }

        public void CmdCopyResults(VkQueryPool queryPool, UInt32 firstQuery, UInt32 queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags) {
            vkAPI.vkCmdCopyQueryPoolResults(this.handle, queryPool.handle, firstQuery, queryCount, dstBuffer != null ? dstBuffer.handle : default(UInt64), dstOffset, stride, flags);
        }

        public void CmdWriteTimestamp(VkPipelineStageFlags stage, VkQueryPool queryPool, UInt32 query) {
            vkAPI.vkCmdWriteTimestamp(this.handle, stage, queryPool.handle, query);
        }

        /// <summary>
        /// Outside a render pass Instance.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="layout"></param>
        /// <param name="color"></param>
        /// <param name="ranges"></param>
        public void CmdClearColorImage(VkImage image, VkImageLayout layout, ref VkClearColorValue color, VkImageSubresourceRange[] ranges) {
            fixed (VkClearColorValue* pColor = &color) {
                fixed (VkImageSubresourceRange* pRanges = ranges) {
                    vkAPI.vkCmdClearColorImage(this.handle, image.handle, layout, pColor, (UInt32)ranges.Length, pRanges);
                }
            }
        }

        /// <summary>
        /// Outside a Render Pass Instance.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="layout"></param>
        /// <param name="depthStencil"></param>
        /// <param name="ranges"></param>
        public void CmdClearDepthStencilImage(VkImage image, VkImageLayout layout, ref VkClearDepthStencilValue depthStencil, VkImageSubresourceRange[] ranges) {
            fixed (VkClearDepthStencilValue* pDepthStencil = &depthStencil) {
                fixed (VkImageSubresourceRange* pRanges = ranges) {
                    vkAPI.vkCmdClearDepthStencilImage(this.handle, image.handle, layout, pDepthStencil, (UInt32)ranges.Length, pRanges);
                }
            }
        }

        /// <summary>
        /// Inside a Render Pass Instance.
        /// </summary>
        /// <param name="attachments"></param>
        /// <param name="rects"></param>
        public void CmdClearAttachmetns(VkClearAttachment[] attachments, VkClearRect[] rects) {
            fixed (VkClearAttachment* pAttachments = attachments) {
                fixed (VkClearRect* pRects = rects) {
                    vkAPI.vkCmdClearAttachments(this.handle, (UInt32)attachments.Length, pAttachments, (UInt32)rects.Length, pRects);
                }
            }
        }

        public void CmdFillBuffer(VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, UInt32 data) {
            vkAPI.vkCmdFillBuffer(this.handle, dstBuffer.handle, dstOffset, size, data);
        }

        public void CmdUpdateBuffer(VkBuffer dstBuffer, VkDeviceSize dstOffset, UInt32[] data) {
            fixed (UInt32* pData = data) {
                vkAPI.vkCmdUpdateBuffer(this.handle, dstBuffer.handle, dstOffset, data.Length, pData);
            }
        }

        public void CmdCopyBuffer(VkBuffer srcBuffer, VkBuffer dstBuffer, VkBufferCopy[] regions) {
            fixed (VkBufferCopy* pRegions = regions) {
                vkAPI.vkCmdCopyBuffer(this.handle, srcBuffer.handle, dstBuffer.handle, (UInt32)regions.Length, pRegions);
            }
        }

        public void CmdCopyImage(VkImage srcImage, VkImageLayout srcLayout, VkImage dstImage, VkImageLayout dstLayout, VkImageCopy[] regions) {
            fixed (VkImageCopy* pRegions = regions) {
                vkAPI.vkCmdCopyImage(this.handle, srcImage.handle, srcLayout, dstImage.handle, dstLayout, (UInt32)regions.Length, pRegions);
            }
        }

        public void CmdCopyBufferToImage(VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstLayout, VkBufferImageCopy[] regions) {
            fixed (VkBufferImageCopy* pRegions = regions) {
                vkAPI.vkCmdCopyBufferToImage(this.handle, srcBuffer.handle, dstImage.handle, dstLayout, (UInt32)regions.Length, pRegions);
            }
        }

        public void CmdCopyImageToBuffer(VkImage srcImage, VkImageLayout srcLayout, VkBuffer dstBuffer, VkBufferImageCopy[] regions) {
            fixed (VkBufferImageCopy* pRegions = regions) {
                vkAPI.vkCmdCopyImageToBuffer(this.handle, srcImage.handle, srcLayout, dstBuffer.handle, (UInt32)regions.Length, pRegions);
            }
        }

        public void CmdBlitImage(VkImage srcImage, VkImageLayout srcLayout, VkImage dstImage, VkImageLayout dstLayout, VkImageBlit[] regions, VkFilter filter) {
            fixed (VkImageBlit* pRegions = regions) {
                vkAPI.vkCmdBlitImage(this.handle, srcImage.handle, srcLayout, dstImage.handle, dstLayout, (UInt32)regions.Length, pRegions, filter);
            }
        }

        public void CmdResolveImage(VkImage srcImage, VkImageLayout srcLayout, VkImage dstImage, VkImageLayout dstLayout, VkImageResolve[] regions) {
            fixed (VkImageResolve* pRegions = regions) {
                vkAPI.vkCmdResolveImage(this.handle, srcImage.handle, srcLayout, dstImage.handle, dstLayout, (UInt32)regions.Length, pRegions);
            }
        }

        public void CmdBindIndexBuffer(VkBuffer vkBuffer, VkDeviceSize offset, VkIndexType indexType) {
            vkAPI.vkCmdBindIndexBuffer(this.handle, vkBuffer != null ? vkBuffer.handle : default(UInt64), offset, indexType);
        }

        public void CmdDraw(UInt32 vertexCount, UInt32 instanceCount, UInt32 firstVertex, UInt32 firstInstance) {
            vkAPI.vkCmdDraw(this.handle, vertexCount, instanceCount, firstVertex, firstInstance);
        }

        public void CmdDrawIndexed(UInt32 indexCount, UInt32 instanceCount, UInt32 firstIndex, Int32 vertexOffset, UInt32 firstInstance) {
            vkAPI.vkCmdDrawIndexed(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }

        public void CmdDrawIndirect(UInt32 indexCount, UInt32 instanceCount, UInt32 firstIndex, Int32 vertexOffset, UInt32 firstInstance) {
            vkAPI.vkCmdDrawIndexed(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        public void CmdDrawIndirect(VkBuffer vkBuffer, VkDeviceSize offset, UInt32 drawCount, UInt32 stride) {
            vkAPI.vkCmdDrawIndirect(this.handle, vkBuffer != null ? vkBuffer.handle : default(UInt64), offset, drawCount, stride);
        }

        public void CmdDrawIndexedIndirect(VkBuffer vkBuffer, VkDeviceSize offset, UInt32 drawCount, UInt32 stride) {
            vkAPI.vkCmdDrawIndexedIndirect(this.handle, vkBuffer != null ? vkBuffer.handle : default(UInt64), offset, drawCount, stride);
        }

        public void CmdBindVertexBuffers(UInt32 firstBinding, VkBuffer[] vkBuffers, VkDeviceSize[] offsets) {
            var handles = new UInt64[vkBuffers.Length];
            for (int i = 0; i < handles.Length; i++) {
                handles[i] = vkBuffers[i].handle;
            }
            fixed (UInt64* pBuffers = handles) {
                fixed (VkDeviceSize* pOffsets = offsets) {
                    vkAPI.vkCmdBindVertexBuffers(this.handle, firstBinding, (UInt32)vkBuffers.Length, pBuffers, pOffsets);
                }
            }
        }

        public void CmdSetViewport(UInt32 firstViewport, VkViewport[] viewports) {
            fixed (VkViewport* pViewports = viewports) {
                vkAPI.vkCmdSetViewport(this.handle, firstViewport, (UInt32)viewports.Length, pViewports);
            }
        }

        public void CmdSetLineWidth(float lineWidth) {
            vkAPI.vkCmdSetLineWidth(this.handle, lineWidth);
        }

        public void CmdSetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasFactor) {
            vkAPI.vkCmdSetDepthBias(this.handle, depthBiasConstantFactor, depthBiasClamp, depthBiasFactor);
        }

        public void CmdSetBlendConstants(float r, float g, float b, float a) {
            var constants = new float[] { r, g, b, a };
            fixed (float* pointer = constants) {
                vkAPI.vkCmdSetBlendConstants(this.handle, pointer);
            }
        }

        public void CmdSetScissor(UInt32 firstScissor, VkRect2D[] scissors) {
            fixed (VkRect2D* pointer = scissors) {
                vkAPI.vkCmdSetScissor(this.handle, firstScissor, (UInt32)scissors.Length, pointer);
            }
        }

        public void CmdSetDepthBounds(float min, float max) {
            vkAPI.vkCmdSetDepthBounds(this.handle, min, max);
        }

        public void CmdSetStencilCompareMask(VkStencilFaceFlags flags, UInt32 compareMask) {
            vkAPI.vkCmdSetStencilCompareMask(this.handle, flags, compareMask);
        }

        public void CmdSetStencilWriteMask(VkStencilFaceFlags flags, UInt32 writeMask) {
            vkAPI.vkCmdSetStencilWriteMask(this.handle, flags, writeMask);
        }

        public void CmdSetStencilReference(VkStencilFaceFlags flags, UInt32 reference) {
            vkAPI.vkCmdSetStencilReference(this.handle, flags, reference);
        }

        public void CmdDispatch(UInt32 x, UInt32 y, UInt32 z) {
            vkAPI.vkCmdDispatch(this.handle, x, y, z);
        }

        public void CmdDispatchIndirect(VkBuffer buffer, VkDeviceSize offset) {
            vkAPI.vkCmdDispatchIndirect(this.handle, buffer.handle, offset);
        }

        public void CmdWaitEvents(VkEvent[] events, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkMemoryBarrier[] memoryBarriers, VkBufferMemoryBarrier[] bufferMemoryBarriers, VkImageMemoryBarrier[] imageMemoryBarriers) {
            var handles = new UInt64[events.Length];
            for (int i = 0; i < events.Length; i++) {
                handles[i] = events[i].handle;
            }

            fixed (UInt64* pEvents = handles) {
                fixed (VkMemoryBarrier* pMemoryBarriers = memoryBarriers) {
                    fixed (VkBufferMemoryBarrier* pBuffers = bufferMemoryBarriers) {
                        fixed (VkImageMemoryBarrier* pImages = imageMemoryBarriers) {
                            vkAPI.vkCmdWaitEvents(this.handle, (UInt32)events.Length, pEvents, srcStageMask, dstStageMask, (UInt32)memoryBarriers.Length, pMemoryBarriers, (UInt32)bufferMemoryBarriers.Length, pBuffers, (UInt32)imageMemoryBarriers.Length, pImages);
                        }
                    }
                }
            }
        }

        public void CmdPipelineBarrier(VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, VkMemoryBarrier[] memoryBarriers, VkBufferMemoryBarrier[] bufferMemoryBarriers, VkImageMemoryBarrier[] imageMemoryBarriers) {
            fixed (VkMemoryBarrier* pMemoryBarriers = memoryBarriers) {
                fixed (VkBufferMemoryBarrier* pBuffers = bufferMemoryBarriers) {
                    fixed (VkImageMemoryBarrier* pImages = imageMemoryBarriers) {
                        vkAPI.vkCmdPipelineBarrier(this.handle, srcStageMask, dstStageMask, dependencyFlags, (UInt32)memoryBarriers.Length, pMemoryBarriers, (UInt32)bufferMemoryBarriers.Length, pBuffers, (UInt32)imageMemoryBarriers.Length, pImages);
                    }
                }
            }
        }
    }
}

