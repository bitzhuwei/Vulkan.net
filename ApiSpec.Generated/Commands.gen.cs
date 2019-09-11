using System;
using System.Runtime.InteropServices;

namespace ApiSpec.Generated {
    public unsafe partial class vkAPI {
        const string VulkanLibrary = "vulkan-1";
        // Command: 0
        /// <summary>vkAcquireFullScreenExclusiveModeEXT - Acquire full-screen exclusive mode for a swapchain
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to acquire exclusive full-screen access
        /// for.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquireFullScreenExclusiveModeEXT(
            VkDevice device,
            VkSwapchainKHR swapchain);
        // Command: 1
        /// <summary>vkAcquireNextImage2KHR - Retrieve the index of the next available presentable image
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="pAcquireInfo"> pAcquireInfo is a pointer to a structure of type
        /// VkAcquireNextImageInfoKHR containing parameters of the acquire.</param>
        /// <param name="pImageIndex"> pImageIndex is a pointer to a uint32_t that is set to the
        /// index of the next image to use.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquireNextImage2KHR(
            VkDevice device,
            /*-const-*/ VkAcquireNextImageInfoKHR* pAcquireInfo,
            UInt32* pImageIndex);
        // Command: 2
        /// <summary>vkAcquireNextImageKHR - Retrieve the index of the next available presentable image
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the non-retired swapchain from which an image is
        /// being acquired.</param>
        /// <param name="timeout"> timeout specifies how long the function waits, in nanoseconds, if
        /// no image is available.</param>
        /// <param name="semaphore"> semaphore is VK_NULL_HANDLE or a semaphore to signal.</param>
        /// <param name="fence"> fence is VK_NULL_HANDLE or a fence to signal.</param>
        /// <param name="pImageIndex"> pImageIndex is a pointer to a uint32_t that is set to the
        /// index of the next image to use (i.e. an index into the array of images
        /// returned by vkGetSwapchainImagesKHR).</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquireNextImageKHR(
            VkDevice device,
            VkSwapchainKHR swapchain,
            UInt64 timeout,
            VkSemaphore semaphore,
            VkFence fence,
            UInt32* pImageIndex);
        // Command: 3
        /// <summary>vkAcquireXlibDisplayEXT - Acquire access to a VkDisplayKHR using Xlib
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice The physical device the display is on.</param>
        /// <param name="dpy"> dpy A connection to the X11 server that currently owns
        /// display.</param>
        /// <param name="display"> display The display the caller wishes to control in Vulkan.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquireXlibDisplayEXT(
            VkPhysicalDevice physicalDevice,
            Display* dpy,
            VkDisplayKHR display);
        // Command: 4
        /// <summary>vkAllocateCommandBuffers - Allocate command buffers from an existing command pool
        /// </summary>
        /// <param name="device"> device is the logical device that owns the command pool.</param>
        /// <param name="pAllocateInfo"> pAllocateInfo is a pointer to an instance of the
        /// VkCommandBufferAllocateInfo structure describing parameters of the
        /// allocation.</param>
        /// <param name="pCommandBuffers"> pCommandBuffers is a pointer to an array of VkCommandBuffer
        /// handles in which the resulting command buffer objects are returned.
        /// The array must be at least the length specified by the
        /// commandBufferCount member of pAllocateInfo.
        /// Each allocated command buffer begins in the initial state.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAllocateCommandBuffers(
            VkDevice device,
            /*-const-*/ VkCommandBufferAllocateInfo* pAllocateInfo,
            VkCommandBuffer* pCommandBuffers);
        // Command: 5
        /// <summary>vkAllocateDescriptorSets - Allocate one or more descriptor sets
        /// </summary>
        /// <param name="device"> device is the logical device that owns the descriptor pool.</param>
        /// <param name="pAllocateInfo"> pAllocateInfo is a pointer to an instance of the
        /// VkDescriptorSetAllocateInfo structure describing parameters of the
        /// allocation.</param>
        /// <param name="pDescriptorSets"> pDescriptorSets is a pointer to an array of VkDescriptorSet
        /// handles in which the resulting descriptor set objects are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAllocateDescriptorSets(
            VkDevice device,
            /*-const-*/ VkDescriptorSetAllocateInfo* pAllocateInfo,
            VkDescriptorSet* pDescriptorSets);
        // Command: 6
        /// <summary>vkAllocateMemory - Allocate device memory
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="pAllocateInfo"> pAllocateInfo is a pointer to an instance of the
        /// VkMemoryAllocateInfo structure describing parameters of the
        /// allocation.
        /// A successful returned allocation must use the requested parameters — no substitution is permitted by the implementation.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pMemory"> pMemory is a pointer to a VkDeviceMemory handle in which
        /// information about the allocated memory is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAllocateMemory(
            VkDevice device,
            /*-const-*/ VkMemoryAllocateInfo* pAllocateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDeviceMemory* pMemory);
        // Command: 7
        /// <summary>vkBeginCommandBuffer - Start recording a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the handle of the command buffer which is to be
        /// put in the recording state.</param>
        /// <param name="pBeginInfo"> pBeginInfo is an instance of the VkCommandBufferBeginInfo
        /// structure, which defines additional information about how the command
        /// buffer begins recording.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBeginCommandBuffer(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkCommandBufferBeginInfo* pBeginInfo);
        // Command: 8
        /// <summary>vkBindAccelerationStructureMemoryNV - Bind acceleration structure memory
        /// </summary>
        /// <param name="device"> device is the logical device that owns the acceleration structures
        /// and memory.</param>
        /// <param name="bindInfoCount"> bindInfoCount is the number of elements in pBindInfos.</param>
        /// <param name="pBindInfos"> pBindInfos is a pointer to an array of structures of type
        /// VkBindAccelerationStructureMemoryInfoNV, describing images and
        /// memory to bind.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindAccelerationStructureMemoryNV(
            VkDevice device,
            UInt32 bindInfoCount,
            /*-const-*/ VkBindAccelerationStructureMemoryInfoNV* pBindInfos);
        // Command: 9
        /// <summary>vkBindBufferMemory - Bind device memory to a buffer object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the buffer and memory.</param>
        /// <param name="buffer"> buffer is the buffer to be attached to memory.</param>
        /// <param name="memory"> memory is a VkDeviceMemory object describing the device
        /// memory to attach.</param>
        /// <param name="memoryOffset"> memoryOffset is the start offset of the region of memory
        /// which is to be bound to the buffer.
        /// The number of bytes returned in the
        /// VkMemoryRequirements::size member in memory, starting
        /// from memoryOffset bytes, will be bound to the specified buffer.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindBufferMemory(
            VkDevice device,
            VkBuffer buffer,
            VkDeviceMemory memory,
            VkDeviceSize memoryOffset);
        // Command: 10
        /// <summary>vkBindBufferMemory2 - Bind device memory to buffer objects
        /// </summary>
        /// <param name="device"> device is the logical device that owns the buffers and memory.</param>
        /// <param name="bindInfoCount"> bindInfoCount is the number of elements in pBindInfos.</param>
        /// <param name="pBindInfos"> pBindInfos is a pointer to an array of structures of type
        /// VkBindBufferMemoryInfo, describing buffers and memory to bind.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindBufferMemory2(
            VkDevice device,
            UInt32 bindInfoCount,
            /*-const-*/ VkBindBufferMemoryInfo* pBindInfos);
        // Command: 11
        /// <summary>vkBindImageMemory - Bind device memory to an image object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image and memory.</param>
        /// <param name="image"> image is the image.</param>
        /// <param name="memory"> memory is the VkDeviceMemory object describing the device
        /// memory to attach.</param>
        /// <param name="memoryOffset"> memoryOffset is the start offset of the region of memory
        /// which is to be bound to the image.
        /// The number of bytes returned in the
        /// VkMemoryRequirements::size member in memory, starting
        /// from memoryOffset bytes, will be bound to the specified image.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindImageMemory(
            VkDevice device,
            VkImage image,
            VkDeviceMemory memory,
            VkDeviceSize memoryOffset);
        // Command: 12
        /// <summary>vkBindImageMemory2 - Bind device memory to image objects
        /// </summary>
        /// <param name="device"> device is the logical device that owns the images and memory.</param>
        /// <param name="bindInfoCount"> bindInfoCount is the number of elements in pBindInfos.</param>
        /// <param name="pBindInfos"> pBindInfos is a pointer to an array of structures of type
        /// VkBindImageMemoryInfo, describing images and memory to bind.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindImageMemory2(
            VkDevice device,
            UInt32 bindInfoCount,
            /*-const-*/ VkBindImageMemoryInfo* pBindInfos);
        // Command: 13
        /// <summary>vkCmdBeginConditionalRenderingEXT - Define the beginning of a conditional rendering block
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="pConditionalRenderingBegin"> pConditionalRenderingBegin is a pointer to an instance of the
        /// VkConditionalRenderingBeginInfoEXT structure specifying the
        /// parameters of conditional rendering.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginConditionalRenderingEXT(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);
        // Command: 14
        /// <summary>vkCmdBeginDebugUtilsLabelEXT - Open a command buffer debug label region
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="pLabelInfo"> pLabelInfo is a pointer to an instance of the
        /// VkDebugUtilsLabelEXT structure specifying the parameters of the
        /// label region to open.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginDebugUtilsLabelEXT(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkDebugUtilsLabelEXT* pLabelInfo);
        // Command: 15
        /// <summary>vkCmdBeginQuery - Begin a query
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="queryPool"> queryPool is the query pool that will manage the results of the
        /// query.</param>
        /// <param name="query"> query is the query index within the query pool that will contain
        /// the results.</param>
        /// <param name="flags"> flags is a bitmask of VkQueryControlFlagBits specifying
        /// constraints on the types of queries that can be performed.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQuery(
            VkCommandBuffer commandBuffer,
            VkQueryPool queryPool,
            UInt32 query,
            VkQueryControlFlags flags);
        // Command: 16
        /// <summary>vkCmdBeginQueryIndexedEXT - Begin an indexed query
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="queryPool"> queryPool is the query pool that will manage the results of the
        /// query.</param>
        /// <param name="query"> query is the query index within the query pool that will contain
        /// the results.</param>
        /// <param name="flags"> flags is a bitmask of VkQueryControlFlagBits specifying
        /// constraints on the types of queries that can be performed.</param>
        /// <param name="index"> index is the query type specific index.
        /// When the query type is VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT
        /// the index represents the vertex stream.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQueryIndexedEXT(
            VkCommandBuffer commandBuffer,
            VkQueryPool queryPool,
            UInt32 query,
            VkQueryControlFlags flags,
            UInt32 index);
        // Command: 17
        /// <summary>vkCmdBeginRenderPass - Begin a new render pass
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which to record the
        /// command.</param>
        /// <param name="pRenderPassBegin"> pRenderPassBegin is a pointer to a VkRenderPassBeginInfo
        /// structure (defined below) which specifies the render pass to begin an
        /// instance of, and the framebuffer the instance uses.</param>
        /// <param name="contents"> contents is a VkSubpassContents value specifying how the
        /// commands in the first subpass will be provided.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkRenderPassBeginInfo* pRenderPassBegin,
            VkSubpassContents contents);
        // Command: 18
        /// <summary>vkCmdBeginRenderPass2KHR - Begin a new render pass
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which to record the
        /// command.</param>
        /// <param name="pRenderPassBegin"> pRenderPassBegin is a pointer to a VkRenderPassBeginInfo
        /// structure (defined below) which indicates the render pass to begin an
        /// instance of, and the framebuffer the instance uses.</param>
        /// <param name="pSubpassBeginInfo"> pSubpassBeginInfo is a pointer to a VkSubpassBeginInfoKHR
        /// structure which contains information about the subpass which is about to
        /// begin rendering.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass2KHR(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkRenderPassBeginInfo* pRenderPassBegin,
            /*-const-*/ VkSubpassBeginInfoKHR* pSubpassBeginInfo);
        // Command: 19
        /// <summary>vkCmdBeginTransformFeedbackEXT - Make transform feedback active in the command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="firstCounterBuffer"> firstCounterBuffer is the index of the first transform feedback
        /// buffer corresponding to pCounterBuffers[0] and
        /// pCounterBufferOffsets[0].</param>
        /// <param name="counterBufferCount"> counterBufferCount is the size of the pCounterBuffers and
        /// pCounterBufferOffsets arrays.</param>
        /// <param name="pCounterBuffers"> pCounterBuffers is an optional array of buffer handles to the
        /// counter buffers which contain a 4 byte integer value representing the
        /// byte offset from the start of the corresponding transform feedback
        /// buffer from where to start capturing vertex data.
        /// If the byte offset stored to the counter buffer location was done using
        /// vkCmdEndTransformFeedbackEXT it can be used to resume transform
        /// feedback from the previous location.
        /// If pCounterBuffers is NULL, then transform feedback will start
        /// capturing vertex data to byte offset zero in all bound transform
        /// feedback buffers.
        /// For each element of pCounterBuffers that is VK_NULL_HANDLE,
        /// transform feedback will start capturing vertex data to byte zero in the
        /// corresponding bound transform feedback buffer.</param>
        /// <param name="pCounterBufferOffsets"> pCounterBufferOffsets is an optional array of offsets within each
        /// of the pCounterBuffers where the counter values were previously
        /// written.
        /// The location in each counter buffer at these offsets must be large
        /// enough to contain 4 bytes of data.
        /// This data is the number of bytes captured by the previous transform
        /// feedback to this buffer.
        /// If pCounterBufferOffsets is NULL, then it is assumed the offsets
        /// are zero.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginTransformFeedbackEXT(
            VkCommandBuffer commandBuffer,
            UInt32 firstCounterBuffer,
            UInt32 counterBufferCount,
            /*-const-*/ VkBuffer* pCounterBuffers,
            /*-const-*/ VkDeviceSize* pCounterBufferOffsets);
        // Command: 20
        /// <summary>vkCmdBindDescriptorSets - Binds descriptor sets to a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer that the descriptor sets will
        /// be bound to.</param>
        /// <param name="pipelineBindPoint"> pipelineBindPoint is a VkPipelineBindPoint indicating
        /// whether the descriptors will be used by graphics pipelines or compute
        /// pipelines.
        /// There is a separate set of bind points for each of graphics and compute,
        /// so binding one does not disturb the other.</param>
        /// <param name="layout"> layout is a VkPipelineLayout object used to program the
        /// bindings.</param>
        /// <param name="firstSet"> firstSet is the set number of the first descriptor set to be
        /// bound.</param>
        /// <param name="descriptorSetCount"> descriptorSetCount is the number of elements in the
        /// pDescriptorSets array.</param>
        /// <param name="pDescriptorSets"> pDescriptorSets is an array of handles to VkDescriptorSet
        /// objects describing the descriptor sets to write to.</param>
        /// <param name="dynamicOffsetCount"> dynamicOffsetCount is the number of dynamic offsets in the
        /// pDynamicOffsets array.</param>
        /// <param name="pDynamicOffsets"> pDynamicOffsets is a pointer to an array of uint32_t values
        /// specifying dynamic offsets.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindDescriptorSets(
            VkCommandBuffer commandBuffer,
            VkPipelineBindPoint pipelineBindPoint,
            VkPipelineLayout layout,
            UInt32 firstSet,
            UInt32 descriptorSetCount,
            /*-const-*/ VkDescriptorSet* pDescriptorSets,
            UInt32 dynamicOffsetCount,
            /*-const-*/ UInt32* pDynamicOffsets);
        // Command: 21
        /// <summary>vkCmdBindIndexBuffer - Bind an index buffer to a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer being bound.</param>
        /// <param name="offset"> offset is the starting offset in bytes within buffer used in
        /// index buffer address calculations.</param>
        /// <param name="indexType"> indexType is a VkIndexType value specifying whether indices
        /// are treated as 16 bits or 32 bits.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindIndexBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            VkIndexType indexType);
        // Command: 22
        /// <summary>vkCmdBindPipeline - Bind a pipeline object to a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer that the pipeline will be
        /// bound to.</param>
        /// <param name="pipelineBindPoint"> pipelineBindPoint is a VkPipelineBindPoint value specifying
        /// whether to bind to the compute or graphics bind point.
        /// Binding one does not disturb the other.</param>
        /// <param name="pipeline"> pipeline is the pipeline to be bound.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindPipeline(
            VkCommandBuffer commandBuffer,
            VkPipelineBindPoint pipelineBindPoint,
            VkPipeline pipeline);
        // Command: 23
        /// <summary>vkCmdBindShadingRateImageNV - Bind a shading rate image on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="imageView"> imageView is an image view handle that specifies the shading rate
        /// image.
        /// imageView may be set to VK_NULL_HANDLE, which is equivalent
        /// to specifying a view of an image filled with zero values.</param>
        /// <param name="imageLayout"> imageLayout is the layout that the image subresources accessible
        /// from imageView will be in when the shading rate image is accessed.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindShadingRateImageNV(
            VkCommandBuffer commandBuffer,
            VkImageView imageView,
            VkImageLayout imageLayout);
        // Command: 24
        /// <summary>vkCmdBindTransformFeedbackBuffersEXT - Bind transform feedback buffers to a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="firstBinding"> firstBinding is the index of the first transform feedback binding
        /// whose state is updated by the command.</param>
        /// <param name="bindingCount"> bindingCount is the number of transform feedback bindings whose
        /// state is updated by the command.</param>
        /// <param name="pBuffers"> pBuffers is a pointer to an array of buffer handles.</param>
        /// <param name="pOffsets"> pOffsets is a pointer to an array of buffer offsets.</param>
        /// <param name="pSizes"> pSizes is an optional array of buffer sizes, which specifies the
        /// maximum number of bytes to capture to the corresponding transform
        /// feedback buffer.
        /// If pSizes is NULL, or the value of the pSizes array
        /// element is VK_WHOLE_SIZE, then the maximum bytes captured will be
        /// the size of the corresponding buffer minus the buffer offset.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindTransformFeedbackBuffersEXT(
            VkCommandBuffer commandBuffer,
            UInt32 firstBinding,
            UInt32 bindingCount,
            /*-const-*/ VkBuffer* pBuffers,
            /*-const-*/ VkDeviceSize* pOffsets,
            /*-const-*/ VkDeviceSize* pSizes);
        // Command: 25
        /// <summary>vkCmdBindVertexBuffers - Bind vertex buffers to a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="firstBinding"> firstBinding is the index of the first vertex input binding whose
        /// state is updated by the command.</param>
        /// <param name="bindingCount"> bindingCount is the number of vertex input bindings whose state is
        /// updated by the command.</param>
        /// <param name="pBuffers"> pBuffers is a pointer to an array of buffer handles.</param>
        /// <param name="pOffsets"> pOffsets is a pointer to an array of buffer offsets.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindVertexBuffers(
            VkCommandBuffer commandBuffer,
            UInt32 firstBinding,
            UInt32 bindingCount,
            /*-const-*/ VkBuffer* pBuffers,
            /*-const-*/ VkDeviceSize* pOffsets);
        // Command: 26
        /// <summary>vkCmdBlitImage - Copy regions of an image, potentially performing format conversion,
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="srcImage"> srcImage is the source image.</param>
        /// <param name="srcImageLayout"> srcImageLayout is the layout of the source image subresources for
        /// the blit.</param>
        /// <param name="dstImage"> dstImage is the destination image.</param>
        /// <param name="dstImageLayout"> dstImageLayout is the layout of the destination image subresources
        /// for the blit.</param>
        /// <param name="regionCount"> regionCount is the number of regions to blit.</param>
        /// <param name="pRegions"> pRegions is a pointer to an array of VkImageBlit structures
        /// specifying the regions to blit.</param>
        /// <param name="filter"> filter is a VkFilter specifying the filter to apply if the
        /// blits require scaling.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBlitImage(
            VkCommandBuffer commandBuffer,
            VkImage srcImage,
            VkImageLayout srcImageLayout,
            VkImage dstImage,
            VkImageLayout dstImageLayout,
            UInt32 regionCount,
            /*-const-*/ VkImageBlit* pRegions,
            VkFilter filter);
        // Command: 27
        /// <summary>vkCmdBuildAccelerationStructureNV - Build an acceleration structure
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="pInfo"> pInfo contains the shared information for the acceleration
        /// structure’s structure.</param>
        /// <param name="instanceData"> instanceData is the buffer containing instance data that will be
        /// used to build the acceleration structure as described in
        /// Accelerator structure instances.
        /// This parameter must be NULL for bottom level acceleration structures.</param>
        /// <param name="instanceOffset"> instanceOffset is the offset in bytes (relative to the start of
        /// instanceData) at which the instance data is located.</param>
        /// <param name="update"> update specifies whether to update the dst acceleration
        /// structure with the data in src.</param>
        /// <param name="dst"> dst points to the target acceleration structure for the build.</param>
        /// <param name="src"> src points to an existing acceleration structure that is to be
        /// used to update the dst acceleration structure.</param>
        /// <param name="scratch"> scratch is the VkBuffer that will be used as scratch memory
        /// for the build.</param>
        /// <param name="scratchOffset"> scratchOffset is the offset in bytes relative to the start of
        /// scratch that will be used as a scratch memory.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBuildAccelerationStructureNV(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkAccelerationStructureInfoNV* pInfo,
            VkBuffer instanceData,
            VkDeviceSize instanceOffset,
            VkBool32 update,
            VkAccelerationStructureNV dst,
            VkAccelerationStructureNV src,
            VkBuffer scratch,
            VkDeviceSize scratchOffset);
        // Command: 28
        /// <summary>vkCmdClearAttachments - Clear regions within bound framebuffer attachments
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="attachmentCount"> attachmentCount is the number of entries in the pAttachments
        /// array.</param>
        /// <param name="pAttachments"> pAttachments is a pointer to an array of VkClearAttachment
        /// structures defining the attachments to clear and the clear values to
        /// use.
        /// If any attachment to be cleared in the current subpass is
        /// VK_ATTACHMENT_UNUSED, then the clear has no effect on that
        /// attachment.</param>
        /// <param name="rectCount"> rectCount is the number of entries in the pRects array.</param>
        /// <param name="pRects"> pRects points to an array of VkClearRect structures defining
        /// regions within each selected attachment to clear.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearAttachments(
            VkCommandBuffer commandBuffer,
            UInt32 attachmentCount,
            /*-const-*/ VkClearAttachment* pAttachments,
            UInt32 rectCount,
            /*-const-*/ VkClearRect* pRects);
        // Command: 29
        /// <summary>vkCmdClearColorImage - Clear regions of a color image
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="image"> image is the image to be cleared.</param>
        /// <param name="imageLayout"> imageLayout specifies the current layout of the image subresource
        /// ranges to be cleared, and must be
        /// VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR,
        /// VK_IMAGE_LAYOUT_GENERAL or
        /// VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL.</param>
        /// <param name="pColor"> pColor is a pointer to a VkClearColorValue structure that
        /// contains the values the image subresource ranges will be cleared to (see
        /// html/vkspec.html#clears-values below).</param>
        /// <param name="rangeCount"> rangeCount is the number of image subresource range structures in
        /// pRanges.</param>
        /// <param name="pRanges"> pRanges points to an array of VkImageSubresourceRange
        /// structures that describe a range of mipmap levels, array layers, and
        /// aspects to be cleared, as described in Image
        /// Views.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearColorImage(
            VkCommandBuffer commandBuffer,
            VkImage image,
            VkImageLayout imageLayout,
            /*-const-*/ VkClearColorValue* pColor,
            UInt32 rangeCount,
            /*-const-*/ VkImageSubresourceRange* pRanges);
        // Command: 30
        /// <summary>vkCmdClearDepthStencilImage - Fill regions of a combined depth/stencil image
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="image"> image is the image to be cleared.</param>
        /// <param name="imageLayout"> imageLayout specifies the current layout of the image subresource
        /// ranges to be cleared, and must be VK_IMAGE_LAYOUT_GENERAL or
        /// VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL.</param>
        /// <param name="pDepthStencil"> pDepthStencil is a pointer to a VkClearDepthStencilValue
        /// structure that contains the values the depth and stencil image
        /// subresource ranges will be cleared to (see html/vkspec.html#clears-values below).</param>
        /// <param name="rangeCount"> rangeCount is the number of image subresource range structures in
        /// pRanges.</param>
        /// <param name="pRanges"> pRanges points to an array of VkImageSubresourceRange
        /// structures that describe a range of mipmap levels, array layers, and
        /// aspects to be cleared, as described in Image
        /// Views.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearDepthStencilImage(
            VkCommandBuffer commandBuffer,
            VkImage image,
            VkImageLayout imageLayout,
            /*-const-*/ VkClearDepthStencilValue* pDepthStencil,
            UInt32 rangeCount,
            /*-const-*/ VkImageSubresourceRange* pRanges);
        // Command: 31
        /// <summary>vkCmdCopyAccelerationStructureNV - Copy an acceleration structure
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="dst"> dst points to the target acceleration structure for the copy.</param>
        /// <param name="src"> src points to the source acceleration structure for the copy.</param>
        /// <param name="mode"> mode is a VkCopyAccelerationStructureModeNV value that
        /// specifies additional operations to perform during the copy.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyAccelerationStructureNV(
            VkCommandBuffer commandBuffer,
            VkAccelerationStructureNV dst,
            VkAccelerationStructureNV src,
            VkCopyAccelerationStructureModeNV mode);
        // Command: 32
        /// <summary>vkCmdCopyBuffer - Copy data between buffer regions
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="srcBuffer"> srcBuffer is the source buffer.</param>
        /// <param name="dstBuffer"> dstBuffer is the destination buffer.</param>
        /// <param name="regionCount"> regionCount is the number of regions to copy.</param>
        /// <param name="pRegions"> pRegions is a pointer to an array of VkBufferCopy structures
        /// specifying the regions to copy.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer srcBuffer,
            VkBuffer dstBuffer,
            UInt32 regionCount,
            /*-const-*/ VkBufferCopy* pRegions);
        // Command: 33
        /// <summary>vkCmdCopyBufferToImage - Copy data from a buffer into an image
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="srcBuffer"> srcBuffer is the source buffer.</param>
        /// <param name="dstImage"> dstImage is the destination image.</param>
        /// <param name="dstImageLayout"> dstImageLayout is the layout of the destination image subresources
        /// for the copy.</param>
        /// <param name="regionCount"> regionCount is the number of regions to copy.</param>
        /// <param name="pRegions"> pRegions is a pointer to an array of VkBufferImageCopy
        /// structures specifying the regions to copy.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBufferToImage(
            VkCommandBuffer commandBuffer,
            VkBuffer srcBuffer,
            VkImage dstImage,
            VkImageLayout dstImageLayout,
            UInt32 regionCount,
            /*-const-*/ VkBufferImageCopy* pRegions);
        // Command: 34
        /// <summary>vkCmdCopyImage - Copy data between images
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="srcImage"> srcImage is the source image.</param>
        /// <param name="srcImageLayout"> srcImageLayout is the current layout of the source image
        /// subresource.</param>
        /// <param name="dstImage"> dstImage is the destination image.</param>
        /// <param name="dstImageLayout"> dstImageLayout is the current layout of the destination image
        /// subresource.</param>
        /// <param name="regionCount"> regionCount is the number of regions to copy.</param>
        /// <param name="pRegions"> pRegions is a pointer to an array of VkImageCopy structures
        /// specifying the regions to copy.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImage(
            VkCommandBuffer commandBuffer,
            VkImage srcImage,
            VkImageLayout srcImageLayout,
            VkImage dstImage,
            VkImageLayout dstImageLayout,
            UInt32 regionCount,
            /*-const-*/ VkImageCopy* pRegions);
        // Command: 35
        /// <summary>vkCmdCopyImageToBuffer - Copy image data into a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="srcImage"> srcImage is the source image.</param>
        /// <param name="srcImageLayout"> srcImageLayout is the layout of the source image subresources for
        /// the copy.</param>
        /// <param name="dstBuffer"> dstBuffer is the destination buffer.</param>
        /// <param name="regionCount"> regionCount is the number of regions to copy.</param>
        /// <param name="pRegions"> pRegions is a pointer to an array of VkBufferImageCopy
        /// structures specifying the regions to copy.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImageToBuffer(
            VkCommandBuffer commandBuffer,
            VkImage srcImage,
            VkImageLayout srcImageLayout,
            VkBuffer dstBuffer,
            UInt32 regionCount,
            /*-const-*/ VkBufferImageCopy* pRegions);
        // Command: 36
        /// <summary>vkCmdCopyQueryPoolResults - Copy the results of queries in a query pool to a buffer object
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="queryPool"> queryPool is the query pool managing the queries containing the
        /// desired results.</param>
        /// <param name="firstQuery"> firstQuery is the initial query index.</param>
        /// <param name="queryCount"> queryCount is the number of queries.
        /// firstQuery and queryCount together define a range of
        /// queries.</param>
        /// <param name="dstBuffer"> dstBuffer is a VkBuffer object that will receive the results
        /// of the copy command.</param>
        /// <param name="dstOffset"> dstOffset is an offset into dstBuffer.</param>
        /// <param name="stride"> stride is the stride in bytes between results for individual
        /// queries within dstBuffer.
        /// The required size of the backing memory for dstBuffer is
        /// determined as described above for vkGetQueryPoolResults.</param>
        /// <param name="flags"> flags is a bitmask of VkQueryResultFlagBits specifying how
        /// and when results are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyQueryPoolResults(
            VkCommandBuffer commandBuffer,
            VkQueryPool queryPool,
            UInt32 firstQuery,
            UInt32 queryCount,
            VkBuffer dstBuffer,
            VkDeviceSize dstOffset,
            VkDeviceSize stride,
            VkQueryResultFlags flags);
        // Command: 37
        /// <summary>vkCmdDebugMarkerBeginEXT - Open a command buffer marker region
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="pMarkerInfo"> pMarkerInfo is a pointer to an instance of the
        /// VkDebugMarkerMarkerInfoEXT structure specifying the parameters of
        /// the marker region to open.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerBeginEXT(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
        // Command: 38
        /// <summary>vkCmdDebugMarkerEndEXT - Close a command buffer marker region
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerEndEXT(
            VkCommandBuffer commandBuffer);
        // Command: 39
        /// <summary>vkCmdDebugMarkerInsertEXT - Insert a marker label into a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="pMarkerInfo"> pMarkerInfo is a pointer to an instance of the
        /// VkDebugMarkerMarkerInfoEXT structure specifying the parameters of
        /// the marker to insert.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerInsertEXT(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
        // Command: 40
        /// <summary>vkCmdDispatch - Dispatch compute work items
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="groupCountX"> groupCountX is the number of local workgroups to dispatch in the X
        /// dimension.</param>
        /// <param name="groupCountY"> groupCountY is the number of local workgroups to dispatch in the Y
        /// dimension.</param>
        /// <param name="groupCountZ"> groupCountZ is the number of local workgroups to dispatch in the Z
        /// dimension.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatch(
            VkCommandBuffer commandBuffer,
            UInt32 groupCountX,
            UInt32 groupCountY,
            UInt32 groupCountZ);
        // Command: 41
        /// <summary>vkCmdDispatchBase - Dispatch compute work items
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="baseGroupX"> baseGroupX is the start value for the X component of
        /// WorkgroupId.</param>
        /// <param name="baseGroupY"> baseGroupY is the start value for the Y component of
        /// WorkgroupId.</param>
        /// <param name="baseGroupZ"> baseGroupZ is the start value for the Z component of
        /// WorkgroupId.</param>
        /// <param name="groupCountX"> groupCountX is the number of local workgroups to dispatch in the X
        /// dimension.</param>
        /// <param name="groupCountY"> groupCountY is the number of local workgroups to dispatch in the Y
        /// dimension.</param>
        /// <param name="groupCountZ"> groupCountZ is the number of local workgroups to dispatch in the Z
        /// dimension.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBase(
            VkCommandBuffer commandBuffer,
            UInt32 baseGroupX,
            UInt32 baseGroupY,
            UInt32 baseGroupZ,
            UInt32 groupCountX,
            UInt32 groupCountY,
            UInt32 groupCountZ);
        // Command: 42
        /// <summary>vkCmdDispatchIndirect - Dispatch compute work items using indirect parameters
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing dispatch parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchIndirect(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset);
        // Command: 43
        /// <summary>vkCmdDraw - Draw primitives
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="vertexCount"> vertexCount is the number of vertices to draw.</param>
        /// <param name="instanceCount"> instanceCount is the number of instances to draw.</param>
        /// <param name="firstVertex"> firstVertex is the index of the first vertex to draw.</param>
        /// <param name="firstInstance"> firstInstance is the instance ID of the first instance to draw.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDraw(
            VkCommandBuffer commandBuffer,
            UInt32 vertexCount,
            UInt32 instanceCount,
            UInt32 firstVertex,
            UInt32 firstInstance);
        // Command: 44
        /// <summary>vkCmdDrawIndexed - Issue an indexed draw into a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="indexCount"> indexCount is the number of vertices to draw.</param>
        /// <param name="instanceCount"> instanceCount is the number of instances to draw.</param>
        /// <param name="firstIndex"> firstIndex is the base index within the index buffer.</param>
        /// <param name="vertexOffset"> vertexOffset is the value added to the vertex index before
        /// indexing into the vertex buffer.</param>
        /// <param name="firstInstance"> firstInstance is the instance ID of the first instance to draw.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexed(
            VkCommandBuffer commandBuffer,
            UInt32 indexCount,
            UInt32 instanceCount,
            UInt32 firstIndex,
            Int32 vertexOffset,
            UInt32 firstInstance);
        // Command: 45
        /// <summary>vkCmdDrawIndexedIndirect - Perform an indexed indirect draw
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="drawCount"> drawCount is the number of draws to execute, and can be zero.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirect(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            UInt32 drawCount,
            UInt32 stride);
        // Command: 46
        /// <summary>vkCmdDrawIndexedIndirectCountAMD - Perform an indexed indirect draw with the draw count sourced from a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="countBuffer"> countBuffer is the buffer containing the draw count.</param>
        /// <param name="countBufferOffset"> countBufferOffset is the byte offset into countBuffer where
        /// the draw count begins.</param>
        /// <param name="maxDrawCount"> maxDrawCount specifies the maximum number of draws that will be
        /// executed.
        /// The actual number of executed draw calls is the minimum of the count
        /// specified in countBuffer and maxDrawCount.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            VkBuffer countBuffer,
            VkDeviceSize countBufferOffset,
            UInt32 maxDrawCount,
            UInt32 stride);
        // Command: 47
        /// <summary>vkCmdDrawIndexedIndirectCountKHR - Perform an indexed indirect draw with the draw count sourced from a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="countBuffer"> countBuffer is the buffer containing the draw count.</param>
        /// <param name="countBufferOffset"> countBufferOffset is the byte offset into countBuffer where
        /// the draw count begins.</param>
        /// <param name="maxDrawCount"> maxDrawCount specifies the maximum number of draws that will be
        /// executed.
        /// The actual number of executed draw calls is the minimum of the count
        /// specified in countBuffer and maxDrawCount.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountKHR(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            VkBuffer countBuffer,
            VkDeviceSize countBufferOffset,
            UInt32 maxDrawCount,
            UInt32 stride);
        // Command: 48
        /// <summary>vkCmdDrawIndirect - Issue an indirect draw into a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="drawCount"> drawCount is the number of draws to execute, and can be zero.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirect(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            UInt32 drawCount,
            UInt32 stride);
        // Command: 49
        /// <summary>vkCmdDrawIndirectByteCountEXT - Draw primitives where the vertex count is derived from the counter byte value in the counter buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="instanceCount"> instanceCount is the number of instances to draw.</param>
        /// <param name="firstInstance"> firstInstance is the instance ID of the first instance to draw.</param>
        /// <param name="counterBuffer"> counterBuffer is the buffer handle from where the byte count is
        /// read.</param>
        /// <param name="counterBufferOffset"> counterBufferOffset is the offset into the buffer used to read the
        /// byte count, which is used to calculate the vertex count for this draw
        /// call.</param>
        /// <param name="counterOffset"> counterOffset is subtracted from the byte count read from the
        /// counterBuffer at the counterBufferOffset </param>
        /// <param name="vertexStride"> vertexStride is the stride in bytes between each element of the
        /// vertex data that is used to calculate the vertex count from the counter
        /// value.
        /// This value is typically the same value that was used in the graphics
        /// pipeline state when the transform feedback was captured as the
        /// XfbStride.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectByteCountEXT(
            VkCommandBuffer commandBuffer,
            UInt32 instanceCount,
            UInt32 firstInstance,
            VkBuffer counterBuffer,
            VkDeviceSize counterBufferOffset,
            UInt32 counterOffset,
            UInt32 vertexStride);
        // Command: 50
        /// <summary>vkCmdDrawIndirectCountAMD - Perform an indirect draw with the draw count sourced from a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="countBuffer"> countBuffer is the buffer containing the draw count.</param>
        /// <param name="countBufferOffset"> countBufferOffset is the byte offset into countBuffer where
        /// the draw count begins.</param>
        /// <param name="maxDrawCount"> maxDrawCount specifies the maximum number of draws that will be
        /// executed.
        /// The actual number of executed draw calls is the minimum of the count
        /// specified in countBuffer and maxDrawCount.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountAMD(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            VkBuffer countBuffer,
            VkDeviceSize countBufferOffset,
            UInt32 maxDrawCount,
            UInt32 stride);
        // Command: 51
        /// <summary>vkCmdDrawIndirectCountKHR - Perform an indirect draw with the draw count sourced from a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="countBuffer"> countBuffer is the buffer containing the draw count.</param>
        /// <param name="countBufferOffset"> countBufferOffset is the byte offset into countBuffer where
        /// the draw count begins.</param>
        /// <param name="maxDrawCount"> maxDrawCount specifies the maximum number of draws that will be
        /// executed.
        /// The actual number of executed draw calls is the minimum of the count
        /// specified in countBuffer and maxDrawCount.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountKHR(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            VkBuffer countBuffer,
            VkDeviceSize countBufferOffset,
            UInt32 maxDrawCount,
            UInt32 stride);
        // Command: 52
        /// <summary>vkCmdDrawMeshTasksIndirectCountNV - Perform an indirect mesh tasks draw with the draw count sourced from a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="countBuffer"> countBuffer is the buffer containing the draw count.</param>
        /// <param name="countBufferOffset"> countBufferOffset is the byte offset into countBuffer where
        /// the draw count begins.</param>
        /// <param name="maxDrawCount"> maxDrawCount specifies the maximum number of draws that will be
        /// executed.
        /// The actual number of executed draw calls is the minimum of the count
        /// specified in countBuffer and maxDrawCount.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawMeshTasksIndirectCountNV(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            VkBuffer countBuffer,
            VkDeviceSize countBufferOffset,
            UInt32 maxDrawCount,
            UInt32 stride);
        // Command: 53
        /// <summary>vkCmdDrawMeshTasksIndirectNV - Issue an indirect mesh tasks draw into a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="buffer"> buffer is the buffer containing draw parameters.</param>
        /// <param name="offset"> offset is the byte offset into buffer where parameters
        /// begin.</param>
        /// <param name="drawCount"> drawCount is the number of draws to execute, and can be zero.</param>
        /// <param name="stride"> stride is the byte stride between successive sets of draw
        /// parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawMeshTasksIndirectNV(
            VkCommandBuffer commandBuffer,
            VkBuffer buffer,
            VkDeviceSize offset,
            UInt32 drawCount,
            UInt32 stride);
        // Command: 54
        /// <summary>vkCmdDrawMeshTasksNV - Draw mesh task work items
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="taskCount"> taskCount is the number of local workgroups to dispatch in the X
        /// dimension.
        /// Y and Z dimension are implicitly set to one.</param>
        /// <param name="firstTask"> firstTask is the X component of the first workgroup ID.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawMeshTasksNV(
            VkCommandBuffer commandBuffer,
            UInt32 taskCount,
            UInt32 firstTask);
        // Command: 55
        /// <summary>vkCmdEndConditionalRenderingEXT - Define the end of a conditional rendering block
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndConditionalRenderingEXT(
            VkCommandBuffer commandBuffer);
        // Command: 56
        /// <summary>vkCmdEndDebugUtilsLabelEXT - Close a command buffer label region
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndDebugUtilsLabelEXT(
            VkCommandBuffer commandBuffer);
        // Command: 57
        /// <summary>vkCmdEndQuery - Ends a query
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="queryPool"> queryPool is the query pool that is managing the results of the
        /// query.</param>
        /// <param name="query"> query is the query index within the query pool where the result is
        /// stored.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQuery(
            VkCommandBuffer commandBuffer,
            VkQueryPool queryPool,
            UInt32 query);
        // Command: 58
        /// <summary>vkCmdEndQueryIndexedEXT - Ends a query
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="queryPool"> queryPool is the query pool that is managing the results of the
        /// query.</param>
        /// <param name="query"> query is the query index within the query pool where the result is
        /// stored.</param>
        /// <param name="index"> index is the query type specific index.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQueryIndexedEXT(
            VkCommandBuffer commandBuffer,
            VkQueryPool queryPool,
            UInt32 query,
            UInt32 index);
        // Command: 59
        /// <summary>vkCmdEndRenderPass - End the current render pass
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which to end the current
        /// render pass instance.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass(
            VkCommandBuffer commandBuffer);
        // Command: 60
        /// <summary>vkCmdEndRenderPass2KHR - End the current render pass
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which to end the current
        /// render pass instance.</param>
        /// <param name="pSubpassEndInfo"> pSubpassEndInfo is a pointer to a VkSubpassEndInfoKHR
        /// structure which contains information about how the previous subpass will
        /// be ended.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass2KHR(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkSubpassEndInfoKHR* pSubpassEndInfo);
        // Command: 61
        /// <summary>vkCmdEndTransformFeedbackEXT - Make transform feedback inactive in the command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="firstCounterBuffer"> firstCounterBuffer is the index of the first transform feedback
        /// buffer corresponding to pCounterBuffers[0] and
        /// pCounterBufferOffsets[0].</param>
        /// <param name="counterBufferCount"> counterBufferCount is the size of the pCounterBuffers and
        /// pCounterBufferOffsets arrays.</param>
        /// <param name="pCounterBuffers"> pCounterBuffers is an optional array of buffer handles to the
        /// counter buffers used to record the current byte positions of each
        /// transform feedback buffer where the next vertex output data would be
        /// captured.
        /// This can be used by a subsequent vkCmdBeginTransformFeedbackEXT
        /// call to resume transform feedback capture from this position.
        /// It can also be used by vkCmdDrawIndirectByteCountEXT to determine
        /// the vertex count of the draw call.</param>
        /// <param name="pCounterBufferOffsets"> pCounterBufferOffsets is an optional array of offsets within each
        /// of the pCounterBuffers where the counter values can be written.
        /// The location in each counter buffer at these offsets must be large
        /// enough to contain 4 bytes of data.
        /// The data stored at this location is the byte offset from the start of
        /// the transform feedback buffer binding where the next vertex data would
        /// be written.
        /// If pCounterBufferOffsets is NULL, then it is assumed the offsets
        /// are zero.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndTransformFeedbackEXT(
            VkCommandBuffer commandBuffer,
            UInt32 firstCounterBuffer,
            UInt32 counterBufferCount,
            /*-const-*/ VkBuffer* pCounterBuffers,
            /*-const-*/ VkDeviceSize* pCounterBufferOffsets);
        // Command: 62
        /// <summary>vkCmdExecuteCommands - Execute a secondary command buffer from a primary command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is a handle to a primary command buffer that the
        /// secondary command buffers are executed in.</param>
        /// <param name="commandBufferCount"> commandBufferCount is the length of the pCommandBuffers
        /// array.</param>
        /// <param name="pCommandBuffers"> pCommandBuffers is an array of secondary command buffer handles,
        /// which are recorded to execute in the primary command buffer in the order
        /// they are listed in the array.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdExecuteCommands(
            VkCommandBuffer commandBuffer,
            UInt32 commandBufferCount,
            /*-const-*/ VkCommandBuffer* pCommandBuffers);
        // Command: 63
        /// <summary>vkCmdFillBuffer - Fill a region of a buffer with a fixed value
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="dstBuffer"> dstBuffer is the buffer to be filled.</param>
        /// <param name="dstOffset"> dstOffset is the byte offset into the buffer at which to start
        /// filling, and must be a multiple of 4.</param>
        /// <param name="size"> size is the number of bytes to fill, and must be either a
        /// multiple of 4, or VK_WHOLE_SIZE to fill the range from
        /// offset to the end of the buffer.
        /// If VK_WHOLE_SIZE is used and the remaining size of the buffer is
        /// not a multiple of 4, then the nearest smaller multiple is used.</param>
        /// <param name="data"> data is the 4-byte word written repeatedly to the buffer to fill
        /// size bytes of data.
        /// The data word is written to memory according to the host endianness.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdFillBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer dstBuffer,
            VkDeviceSize dstOffset,
            VkDeviceSize size,
            UInt32 data);
        // Command: 64
        /// <summary>vkCmdInsertDebugUtilsLabelEXT - Insert a label into a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdInsertDebugUtilsLabelEXT(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkDebugUtilsLabelEXT* pLabelInfo);
        // Command: 65
        /// <summary>vkCmdNextSubpass - Transition to the next subpass of a render pass
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which to record the
        /// command.</param>
        /// <param name="contents"> contents specifies how the commands in the next subpass will be
        /// provided, in the same fashion as the corresponding parameter of
        /// vkCmdBeginRenderPass.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass(
            VkCommandBuffer commandBuffer,
            VkSubpassContents contents);
        // Command: 66
        /// <summary>vkCmdNextSubpass2KHR - Transition to the next subpass of a render pass
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which to record the
        /// command.</param>
        /// <param name="pSubpassBeginInfo"> pSubpassBeginInfo is a pointer to a VkSubpassBeginInfoKHR
        /// structure which contains information about the subpass which is about to
        /// begin rendering.</param>
        /// <param name="pSubpassEndInfo"> pSubpassEndInfo is a pointer to a VkSubpassEndInfoKHR
        /// structure which contains information about how the previous subpass will
        /// be ended.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass2KHR(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkSubpassBeginInfoKHR* pSubpassBeginInfo,
            /*-const-*/ VkSubpassEndInfoKHR* pSubpassEndInfo);
        // Command: 67
        /// <summary>vkCmdPipelineBarrier - Insert a memory dependency
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="srcStageMask"> srcStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the source stage
        /// mask.</param>
        /// <param name="dstStageMask"> dstStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the destination
        /// stage mask.</param>
        /// <param name="dependencyFlags"> dependencyFlags is a bitmask of VkDependencyFlagBits
        /// specifying how execution and memory dependencies are formed.</param>
        /// <param name="memoryBarrierCount"> memoryBarrierCount is the length of the pMemoryBarriers
        /// array.</param>
        /// <param name="pMemoryBarriers"> pMemoryBarriers is a pointer to an array of VkMemoryBarrier
        /// structures.</param>
        /// <param name="bufferMemoryBarrierCount"> bufferMemoryBarrierCount is the length of the
        /// pBufferMemoryBarriers array.</param>
        /// <param name="pBufferMemoryBarriers"> pBufferMemoryBarriers is a pointer to an array of
        /// VkBufferMemoryBarrier structures.</param>
        /// <param name="imageMemoryBarrierCount"> imageMemoryBarrierCount is the length of the
        /// pImageMemoryBarriers array.</param>
        /// <param name="pImageMemoryBarriers"> pImageMemoryBarriers is a pointer to an array of
        /// VkImageMemoryBarrier structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPipelineBarrier(
            VkCommandBuffer commandBuffer,
            VkPipelineStageFlags srcStageMask,
            VkPipelineStageFlags dstStageMask,
            VkDependencyFlags dependencyFlags,
            UInt32 memoryBarrierCount,
            /*-const-*/ VkMemoryBarrier* pMemoryBarriers,
            UInt32 bufferMemoryBarrierCount,
            /*-const-*/ VkBufferMemoryBarrier* pBufferMemoryBarriers,
            UInt32 imageMemoryBarrierCount,
            /*-const-*/ VkImageMemoryBarrier* pImageMemoryBarriers);
        // Command: 68
        /// <summary>vkCmdProcessCommandsNVX - Performs the generation of commands on the device
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the primary command buffer in which the
        /// generation process takes space.</param>
        /// <param name="pProcessCommandsInfo"> pProcessCommandsInfo is a pointer to an instance of the
        /// VkCmdProcessCommandsInfoNVX structure containing parameters
        /// affecting the processing of commands.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdProcessCommandsNVX(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo);
        // Command: 69
        /// <summary>vkCmdPushConstants - Update the values of push constants
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer in which the push constant
        /// update will be recorded.</param>
        /// <param name="layout"> layout is the pipeline layout used to program the push constant
        /// updates.</param>
        /// <param name="stageFlags"> stageFlags is a bitmask of VkShaderStageFlagBits specifying
        /// the shader stages that will use the push constants in the updated range.</param>
        /// <param name="offset"> offset is the start offset of the push constant range to update,
        /// in units of bytes.</param>
        /// <param name="size"> size is the size of the push constant range to update, in units of
        /// bytes.</param>
        /// <param name="pValues"> pValues is an array of size bytes containing the new push
        /// constant values.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushConstants(
            VkCommandBuffer commandBuffer,
            VkPipelineLayout layout,
            VkShaderStageFlags stageFlags,
            UInt32 offset,
            UInt32 size,
            /*-const-*/ void* pValues);
        // Command: 70
        /// <summary>vkCmdPushDescriptorSetKHR - Pushes descriptor updates into a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer that the descriptors will be
        /// recorded in.</param>
        /// <param name="pipelineBindPoint"> pipelineBindPoint is a VkPipelineBindPoint indicating
        /// whether the descriptors will be used by graphics pipelines or compute
        /// pipelines.
        /// There is a separate set of push descriptor bindings for each of graphics
        /// and compute, so binding one does not disturb the other.</param>
        /// <param name="layout"> layout is a VkPipelineLayout object used to program the
        /// bindings.</param>
        /// <param name="set"> set is the set number of the descriptor set in the pipeline layout
        /// that will be updated.</param>
        /// <param name="descriptorWriteCount"> descriptorWriteCount is the number of elements in the
        /// pDescriptorWrites array.</param>
        /// <param name="pDescriptorWrites"> pDescriptorWrites is a pointer to an array of
        /// VkWriteDescriptorSet structures describing the descriptors to be
        /// updated.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetKHR(
            VkCommandBuffer commandBuffer,
            VkPipelineBindPoint pipelineBindPoint,
            VkPipelineLayout layout,
            UInt32 set,
            UInt32 descriptorWriteCount,
            /*-const-*/ VkWriteDescriptorSet* pDescriptorWrites);
        // Command: 71
        /// <summary>vkCmdPushDescriptorSetWithTemplateKHR - Pushes descriptor updates into a command buffer using a descriptor update template
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer that the descriptors will be
        /// recorded in.</param>
        /// <param name="descriptorUpdateTemplate"> descriptorUpdateTemplate is a descriptor update template that
        /// defines how to interpret the descriptor information in pData.</param>
        /// <param name="layout"> layout is a VkPipelineLayout object used to program the
        /// bindings.
        /// It must be compatible with the layout used to create the
        /// descriptorUpdateTemplate handle.</param>
        /// <param name="set"> set is the set number of the descriptor set in the pipeline layout
        /// that will be updated.
        /// This must be the same number used to create the
        /// descriptorUpdateTemplate handle.</param>
        /// <param name="pData"> pData points to memory which contains the descriptors for the
        /// templated update.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR(
            VkCommandBuffer commandBuffer,
            VkDescriptorUpdateTemplate descriptorUpdateTemplate,
            VkPipelineLayout layout,
            UInt32 set,
            /*-const-*/ void* pData);
        // Command: 72
        /// <summary>vkCmdReserveSpaceForCommandsNVX - Perform a reservation of command buffer space
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the secondary command buffer in which the space
        /// for device-generated commands is reserved.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdReserveSpaceForCommandsNVX(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo);
        // Command: 73
        /// <summary>vkCmdResetEvent - Reset an event object to non-signaled state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="event"> event is the event that will be unsignaled.</param>
        /// <param name="stageMask"> stageMask is a bitmask of VkPipelineStageFlagBits specifying
        /// the source stage mask used to
        /// determine when the event is unsignaled.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetEvent(
            VkCommandBuffer commandBuffer,
            VkEvent _event,
            VkPipelineStageFlags stageMask);
        // Command: 74
        /// <summary>vkCmdResetQueryPool - Reset queries in a query pool
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which this command will
        /// be recorded.</param>
        /// <param name="queryPool"> queryPool is the handle of the query pool managing the queries
        /// being reset.</param>
        /// <param name="firstQuery"> firstQuery is the initial query index to reset.</param>
        /// <param name="queryCount"> queryCount is the number of queries to reset.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetQueryPool(
            VkCommandBuffer commandBuffer,
            VkQueryPool queryPool,
            UInt32 firstQuery,
            UInt32 queryCount);
        // Command: 75
        /// <summary>vkCmdResolveImage - Resolve regions of an image
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="srcImage"> srcImage is the source image.</param>
        /// <param name="srcImageLayout"> srcImageLayout is the layout of the source image subresources for
        /// the resolve.</param>
        /// <param name="dstImage"> dstImage is the destination image.</param>
        /// <param name="dstImageLayout"> dstImageLayout is the layout of the destination image subresources
        /// for the resolve.</param>
        /// <param name="regionCount"> regionCount is the number of regions to resolve.</param>
        /// <param name="pRegions"> pRegions is a pointer to an array of VkImageResolve
        /// structures specifying the regions to resolve.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResolveImage(
            VkCommandBuffer commandBuffer,
            VkImage srcImage,
            VkImageLayout srcImageLayout,
            VkImage dstImage,
            VkImageLayout dstImageLayout,
            UInt32 regionCount,
            /*-const-*/ VkImageResolve* pRegions);
        // Command: 76
        /// <summary>vkCmdSetBlendConstants - Set the values of blend constants
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetBlendConstants(
            VkCommandBuffer commandBuffer,
            /*-const-*/ float blendConstants[4]);
        // Command: 77
        /// <summary>vkCmdSetCheckpointNV - insert diagnostic checkpoint in command stream
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer that will receive the marker</param>
        /// <param name="pCheckpointMarker"> pCheckpointMarker is an opaque application-provided value that
        /// will be associated with the checkpoint.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetCheckpointNV(
            VkCommandBuffer commandBuffer,
            /*-const-*/ void* pCheckpointMarker);
        // Command: 78
        /// <summary>vkCmdSetCoarseSampleOrderNV - Set sample order for coarse fragments on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="sampleOrderType"> sampleOrderType specifies the mechanism used to order coverage
        /// samples in fragments larger than one pixel.</param>
        /// <param name="customSampleOrderCount"> customSampleOrderCount specifies the number of custom sample
        /// orderings to use when ordering coverage samples.</param>
        /// <param name="pCustomSampleOrders"> pCustomSampleOrders is a pointer to an array of
        /// VkCoarseSampleOrderCustomNV structures, each of which specifies
        /// the coverage sample order for a single combination of fragment area and
        /// coverage sample count.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetCoarseSampleOrderNV(
            VkCommandBuffer commandBuffer,
            VkCoarseSampleOrderTypeNV sampleOrderType,
            UInt32 customSampleOrderCount,
            /*-const-*/ VkCoarseSampleOrderCustomNV* pCustomSampleOrders);
        // Command: 79
        /// <summary>vkCmdSetDepthBias - Set the depth bias dynamic state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="depthBiasConstantFactor"> depthBiasConstantFactor is a scalar factor controlling the
        /// constant depth value added to each fragment.</param>
        /// <param name="depthBiasClamp"> depthBiasClamp is the maximum (or minimum) depth bias of a
        /// fragment.</param>
        /// <param name="depthBiasSlopeFactor"> depthBiasSlopeFactor is a scalar factor applied to a fragment’s
        /// slope in depth bias calculations.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBias(
            VkCommandBuffer commandBuffer,
            float depthBiasConstantFactor,
            float depthBiasClamp,
            float depthBiasSlopeFactor);
        // Command: 80
        /// <summary>vkCmdSetDepthBounds - Set the depth bounds test values for a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="minDepthBounds"> minDepthBounds is the lower bound of the range of depth values
        /// used in the depth bounds test.</param>
        /// <param name="maxDepthBounds"> maxDepthBounds is the upper bound of the range.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBounds(
            VkCommandBuffer commandBuffer,
            float minDepthBounds,
            float maxDepthBounds);
        // Command: 81
        /// <summary>vkCmdSetDeviceMask - Modify device mask of a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is command buffer whose current device mask is
        /// modified.</param>
        /// <param name="deviceMask"> deviceMask is the new value of the current device mask.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMask(
            VkCommandBuffer commandBuffer,
            UInt32 deviceMask);
        // Command: 82
        /// <summary>vkCmdSetDiscardRectangleEXT - Set discard rectangles dynamically
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="firstDiscardRectangle"> firstDiscardRectangle is the index of the first discard rectangle
        /// whose state is updated by the command.</param>
        /// <param name="discardRectangleCount"> discardRectangleCount is the number of discard rectangles whose
        /// state are updated by the command.</param>
        /// <param name="pDiscardRectangles"> pDiscardRectangles is a pointer to an array of VkRect2D
        /// structures specifying discard rectangles.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDiscardRectangleEXT(
            VkCommandBuffer commandBuffer,
            UInt32 firstDiscardRectangle,
            UInt32 discardRectangleCount,
            /*-const-*/ VkRect2D* pDiscardRectangles);
        // Command: 83
        /// <summary>vkCmdSetEvent - Set an event object to signaled state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="event"> event is the event that will be signaled.</param>
        /// <param name="stageMask"> stageMask specifies the source
        /// stage mask used to determine when the event is signaled.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetEvent(
            VkCommandBuffer commandBuffer,
            VkEvent _event,
            VkPipelineStageFlags stageMask);
        // Command: 84
        /// <summary>vkCmdSetExclusiveScissorNV - Set the dynamic exclusive scissor rectangles on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="firstExclusiveScissor"> firstExclusiveScissor is the index of the first exclusive scissor
        /// rectangle whose state is updated by the command.</param>
        /// <param name="exclusiveScissorCount"> exclusiveScissorCount is the number of exclusive scissor
        /// rectangles updated by the command.</param>
        /// <param name="pExclusiveScissors"> pExclusiveScissors is a pointer to an array of VkRect2D
        /// structures defining exclusive scissor rectangles.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetExclusiveScissorNV(
            VkCommandBuffer commandBuffer,
            UInt32 firstExclusiveScissor,
            UInt32 exclusiveScissorCount,
            /*-const-*/ VkRect2D* pExclusiveScissors);
        // Command: 85
        /// <summary>vkCmdSetLineWidth - Set the dynamic line width state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="lineWidth"> lineWidth is the width of rasterized line segments.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineWidth(
            VkCommandBuffer commandBuffer,
            float lineWidth);
        // Command: 86
        /// <summary>vkCmdSetSampleLocationsEXT - Set the dynamic sample locations state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="pSampleLocationsInfo"> pSampleLocationsInfo is the sample locations state to set.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetSampleLocationsEXT(
            VkCommandBuffer commandBuffer,
            /*-const-*/ VkSampleLocationsInfoEXT* pSampleLocationsInfo);
        // Command: 87
        /// <summary>vkCmdSetScissor - Set the dynamic scissor rectangles on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="firstScissor"> firstScissor is the index of the first scissor whose state is
        /// updated by the command.</param>
        /// <param name="scissorCount"> scissorCount is the number of scissors whose rectangles are
        /// updated by the command.</param>
        /// <param name="pScissors"> pScissors is a pointer to an array of VkRect2D structures
        /// defining scissor rectangles.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetScissor(
            VkCommandBuffer commandBuffer,
            UInt32 firstScissor,
            UInt32 scissorCount,
            /*-const-*/ VkRect2D* pScissors);
        // Command: 88
        /// <summary>vkCmdSetStencilCompareMask - Set the stencil compare mask dynamic state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="faceMask"> faceMask is a bitmask of VkStencilFaceFlagBits specifying
        /// the set of stencil state for which to update the compare mask.</param>
        /// <param name="compareMask"> compareMask is the new value to use as the stencil compare mask.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilCompareMask(
            VkCommandBuffer commandBuffer,
            VkStencilFaceFlags faceMask,
            UInt32 compareMask);
        // Command: 89
        /// <summary>vkCmdSetStencilReference - Set the stencil reference dynamic state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="faceMask"> faceMask is a bitmask of VkStencilFaceFlagBits specifying
        /// the set of stencil state for which to update the reference value, as
        /// described above for vkCmdSetStencilCompareMask.</param>
        /// <param name="reference"> reference is the new value to use as the stencil reference value.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilReference(
            VkCommandBuffer commandBuffer,
            VkStencilFaceFlags faceMask,
            UInt32 reference);
        // Command: 90
        /// <summary>vkCmdSetStencilWriteMask - Set the stencil write mask dynamic state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="faceMask"> faceMask is a bitmask of VkStencilFaceFlagBits specifying
        /// the set of stencil state for which to update the write mask, as
        /// described above for vkCmdSetStencilCompareMask.</param>
        /// <param name="writeMask"> writeMask is the new value to use as the stencil write mask.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilWriteMask(
            VkCommandBuffer commandBuffer,
            VkStencilFaceFlags faceMask,
            UInt32 writeMask);
        // Command: 91
        /// <summary>vkCmdSetViewport - Set the viewport on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="firstViewport"> firstViewport is the index of the first viewport whose parameters
        /// are updated by the command.</param>
        /// <param name="viewportCount"> viewportCount is the number of viewports whose parameters are
        /// updated by the command.</param>
        /// <param name="pViewports"> pViewports is a pointer to an array of VkViewport structures
        /// specifying viewport parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewport(
            VkCommandBuffer commandBuffer,
            UInt32 firstViewport,
            UInt32 viewportCount,
            /*-const-*/ VkViewport* pViewports);
        // Command: 92
        /// <summary>vkCmdSetViewportShadingRatePaletteNV - Set shading rate image palettes on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="firstViewport"> firstViewport is the index of the first viewport whose shading
        /// rate palette is updated by the command.</param>
        /// <param name="viewportCount"> viewportCount is the number of viewports whose shading rate
        /// palettes are updated by the command.</param>
        /// <param name="pShadingRatePalettes"> pShadingRatePalettes is a pointer to an array of
        /// VkShadingRatePaletteNV structures defining the palette for each
        /// viewport.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportShadingRatePaletteNV(
            VkCommandBuffer commandBuffer,
            UInt32 firstViewport,
            UInt32 viewportCount,
            /*-const-*/ VkShadingRatePaletteNV* pShadingRatePalettes);
        // Command: 93
        /// <summary>vkCmdSetViewportWScalingNV - Set the viewport W scaling on a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="firstViewport"> firstViewport is the index of the first viewport whose parameters
        /// are updated by the command.</param>
        /// <param name="viewportCount"> viewportCount is the number of viewports whose parameters are
        /// updated by the command.</param>
        /// <param name="pViewportWScalings"> pViewportWScalings is a pointer to an array of
        /// VkViewportWScalingNV structures specifying viewport parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportWScalingNV(
            VkCommandBuffer commandBuffer,
            UInt32 firstViewport,
            UInt32 viewportCount,
            /*-const-*/ VkViewportWScalingNV* pViewportWScalings);
        // Command: 94
        /// <summary>vkCmdTraceRaysNV - Initialize a ray tracing dispatch
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="raygenShaderBindingTableBuffer"> raygenShaderBindingTableBuffer is the buffer object that holds the
        /// shader binding table data for the ray generation shader stage.</param>
        /// <param name="raygenShaderBindingOffset"> raygenShaderBindingOffset is the offset in bytes (relative to
        /// raygenShaderBindingTableBuffer) of the ray generation shader being
        /// used for the trace.</param>
        /// <param name="missShaderBindingTableBuffer"> missShaderBindingTableBuffer is the buffer object that holds the
        /// shader binding table data for the miss shader stage.</param>
        /// <param name="missShaderBindingOffset"> missShaderBindingOffset is the offset in bytes (relative to
        /// missShaderBindingTableBuffer) of the miss shader being used for
        /// the trace.</param>
        /// <param name="missShaderBindingStride"> missShaderBindingStride is the size in bytes of each shader
        /// binding table record in missShaderBindingTableBuffer.</param>
        /// <param name="hitShaderBindingTableBuffer"> hitShaderBindingTableBuffer is the buffer object that holds the
        /// shader binding table data for the hit shader stages.</param>
        /// <param name="hitShaderBindingOffset"> hitShaderBindingOffset is the offset in bytes (relative to
        /// hitShaderBindingTableBuffer) of the hit shader group being used
        /// for the trace.</param>
        /// <param name="hitShaderBindingStride"> hitShaderBindingStride is the size in bytes of each shader binding
        /// table record in hitShaderBindingTableBuffer.</param>
        /// <param name="callableShaderBindingTableBuffer"> callableShaderBindingTableBuffer is the buffer object that holds
        /// the shader binding table data for the callable shader stage.</param>
        /// <param name="callableShaderBindingOffset"> callableShaderBindingOffset is the offset in bytes (relative to
        /// callableShaderBindingTableBuffer) of the callable shader being
        /// used for the trace.</param>
        /// <param name="callableShaderBindingStride"> callableShaderBindingStride is the size in bytes of each shader
        /// binding table record in callableShaderBindingTableBuffer.</param>
        /// <param name="width"> width is the width of the ray trace query dimensions.</param>
        /// <param name="height"> height is height of the ray trace query dimensions.</param>
        /// <param name="depth"> depth is depth of the ray trace query dimensions.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdTraceRaysNV(
            VkCommandBuffer commandBuffer,
            VkBuffer raygenShaderBindingTableBuffer,
            VkDeviceSize raygenShaderBindingOffset,
            VkBuffer missShaderBindingTableBuffer,
            VkDeviceSize missShaderBindingOffset,
            VkDeviceSize missShaderBindingStride,
            VkBuffer hitShaderBindingTableBuffer,
            VkDeviceSize hitShaderBindingOffset,
            VkDeviceSize hitShaderBindingStride,
            VkBuffer callableShaderBindingTableBuffer,
            VkDeviceSize callableShaderBindingOffset,
            VkDeviceSize callableShaderBindingStride,
            UInt32 width,
            UInt32 height,
            UInt32 depth);
        // Command: 95
        /// <summary>vkCmdUpdateBuffer - Update a buffer’s contents from host memory
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="dstBuffer"> dstBuffer is a handle to the buffer to be updated.</param>
        /// <param name="dstOffset"> dstOffset is the byte offset into the buffer to start updating,
        /// and must be a multiple of 4.</param>
        /// <param name="dataSize"> dataSize is the number of bytes to update, and must be a multiple
        /// of 4.</param>
        /// <param name="pData"> pData is a pointer to the source data for the buffer update, and
        /// must be at least dataSize bytes in size.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdUpdateBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer dstBuffer,
            VkDeviceSize dstOffset,
            VkDeviceSize dataSize,
            /*-const-*/ void* pData);
        // Command: 96
        /// <summary>vkCmdWaitEvents - Wait for one or more events and insert a set of memory
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command is
        /// recorded.</param>
        /// <param name="eventCount"> eventCount is the length of the pEvents array.</param>
        /// <param name="pEvents"> pEvents is an array of event object handles to wait on.</param>
        /// <param name="srcStageMask"> srcStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the source stage mask.</param>
        /// <param name="dstStageMask"> dstStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the destination stage
        /// mask.</param>
        /// <param name="memoryBarrierCount"> memoryBarrierCount is the length of the pMemoryBarriers
        /// array.</param>
        /// <param name="pMemoryBarriers"> pMemoryBarriers is a pointer to an array of VkMemoryBarrier
        /// structures.</param>
        /// <param name="bufferMemoryBarrierCount"> bufferMemoryBarrierCount is the length of the
        /// pBufferMemoryBarriers array.</param>
        /// <param name="pBufferMemoryBarriers"> pBufferMemoryBarriers is a pointer to an array of
        /// VkBufferMemoryBarrier structures.</param>
        /// <param name="imageMemoryBarrierCount"> imageMemoryBarrierCount is the length of the
        /// pImageMemoryBarriers array.</param>
        /// <param name="pImageMemoryBarriers"> pImageMemoryBarriers is a pointer to an array of
        /// VkImageMemoryBarrier structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWaitEvents(
            VkCommandBuffer commandBuffer,
            UInt32 _eventCount,
            /*-const-*/ VkEvent* pEvents,
            VkPipelineStageFlags srcStageMask,
            VkPipelineStageFlags dstStageMask,
            UInt32 memoryBarrierCount,
            /*-const-*/ VkMemoryBarrier* pMemoryBarriers,
            UInt32 bufferMemoryBarrierCount,
            /*-const-*/ VkBufferMemoryBarrier* pBufferMemoryBarriers,
            UInt32 imageMemoryBarrierCount,
            /*-const-*/ VkImageMemoryBarrier* pImageMemoryBarriers);
        // Command: 97
        /// <summary>vkCmdWriteAccelerationStructuresPropertiesNV - Write acceleration structure result parameters to query results.
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="accelerationStructureCount"> accelerationStructureCount is the count of acceleration structures
        /// for which to query the property.</param>
        /// <param name="pAccelerationStructures"> pAccelerationStructures points to an array of existing previously
        /// built acceleration structures.</param>
        /// <param name="queryType"> queryType is a VkQueryType value specifying the type of
        /// queries managed by the pool.</param>
        /// <param name="queryPool"> queryPool is the query pool that will manage the results of the
        /// query.</param>
        /// <param name="firstQuery"> firstQuery is the first query index within the query pool that
        /// will contain the accelerationStructureCount number of results.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesNV(
            VkCommandBuffer commandBuffer,
            UInt32 accelerationStructureCount,
            /*-const-*/ VkAccelerationStructureNV* pAccelerationStructures,
            VkQueryType queryType,
            VkQueryPool queryPool,
            UInt32 firstQuery);
        // Command: 98
        /// <summary>vkCmdWriteBufferMarkerAMD - Execute a pipelined write of a marker value into a buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="pipelineStage"> pipelineStage is one of the VkPipelineStageFlagBits values,
        /// specifying the pipeline stage whose completion triggers the marker
        /// write.</param>
        /// <param name="dstBuffer"> dstBuffer is the buffer where the marker will be written to.</param>
        /// <param name="dstOffset"> dstOffset is the byte offset into the buffer where the marker will
        /// be written to.</param>
        /// <param name="marker"> marker is the 32-bit value of the marker.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteBufferMarkerAMD(
            VkCommandBuffer commandBuffer,
            VkPipelineStageFlagBits pipelineStage,
            VkBuffer dstBuffer,
            VkDeviceSize dstOffset,
            UInt32 marker);
        // Command: 99
        /// <summary>vkCmdWriteTimestamp - Write a device timestamp into a query object
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer into which the command will be
        /// recorded.</param>
        /// <param name="pipelineStage"> pipelineStage is one of the VkPipelineStageFlagBits,
        /// specifying a stage of the pipeline.</param>
        /// <param name="queryPool"> queryPool is the query pool that will manage the timestamp.</param>
        /// <param name="query"> query is the query within the query pool that will contain the
        /// timestamp.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteTimestamp(
            VkCommandBuffer commandBuffer,
            VkPipelineStageFlagBits pipelineStage,
            VkQueryPool queryPool,
            UInt32 query);
        // Command: 100
        /// <summary>vkCompileDeferredNV - Deferred compilation of shaders
        /// </summary>
        /// <param name="device"> device is the logical device that contains the ray tracing
        /// pipeline.</param>
        /// <param name="pipeline"> pipeline is the ray tracing pipeline object that contains the
        /// shaders.</param>
        /// <param name="shader"> shader is the index of the shader to compile.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCompileDeferredNV(
            VkDevice device,
            VkPipeline pipeline,
            UInt32 shader);
        // Command: 101
        /// <summary>vkCreateAccelerationStructureNV - Create a new acceleration structure object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the buffer object.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkAccelerationStructureCreateInfoNV structure containing
        /// parameters affecting creation of the acceleration structure.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pAccelerationStructure"> pAccelerationStructure points to a VkAccelerationStructureNV
        /// handle in which the resulting acceleration structure object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateAccelerationStructureNV(
            VkDevice device,
            /*-const-*/ VkAccelerationStructureCreateInfoNV* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkAccelerationStructureNV* pAccelerationStructure);
        // Command: 102
        /// <summary>vkCreateAndroidSurfaceKHR - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for an Android native window
        /// </summary>
        /// <param name="instance"> instance is the instance to associate the surface with.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkAndroidSurfaceCreateInfoKHR structure containing parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateAndroidSurfaceKHR(
            VkInstance instance,
            /*-const-*/ VkAndroidSurfaceCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 103
        /// <summary>vkCreateBuffer - Create a new buffer object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the buffer object.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkBufferCreateInfo structure containing parameters affecting
        /// creation of the buffer.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pBuffer"> pBuffer points to a VkBuffer handle in which the resulting
        /// buffer object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateBuffer(
            VkDevice device,
            /*-const-*/ VkBufferCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkBuffer* pBuffer);
        // Command: 104
        /// <summary>vkCreateBufferView - Create a new buffer view object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the buffer view.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkBufferViewCreateInfo structure containing parameters to be used
        /// to create the buffer.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pView"> pView points to a VkBufferView handle in which the resulting
        /// buffer view object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateBufferView(
            VkDevice device,
            /*-const-*/ VkBufferViewCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkBufferView* pView);
        // Command: 105
        /// <summary>vkCreateCommandPool - Create a new command pool object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the command pool.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkCommandPoolCreateInfo structure specifying the state of the
        /// command pool object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pCommandPool"> pCommandPool points to a VkCommandPool handle in which the
        /// created pool is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateCommandPool(
            VkDevice device,
            /*-const-*/ VkCommandPoolCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkCommandPool* pCommandPool);
        // Command: 106
        /// <summary>vkCreateComputePipelines - Creates a new compute pipeline object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the compute pipelines.</param>
        /// <param name="pipelineCache"> pipelineCache is either VK_NULL_HANDLE, indicating that
        /// pipeline caching is disabled; or the handle of a valid
        /// pipeline cache object, in which case use of that
        /// cache is enabled for the duration of the command.</param>
        /// <param name="createInfoCount"> createInfoCount is the length of the pCreateInfos and
        /// pPipelines arrays.</param>
        /// <param name="pCreateInfos"> pCreateInfos is an array of VkComputePipelineCreateInfo
        /// structures.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pPipelines"> pPipelines is a pointer to an array in which the resulting compute
        /// pipeline objects are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateComputePipelines(
            VkDevice device,
            VkPipelineCache pipelineCache,
            UInt32 createInfoCount,
            /*-const-*/ VkComputePipelineCreateInfo* pCreateInfos,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkPipeline* pPipelines);
        // Command: 107
        /// <summary>vkCreateDebugReportCallbackEXT - Create a debug report callback object
        /// </summary>
        /// <param name="instance"> instance the instance the callback will be logged on.</param>
        /// <param name="pCreateInfo"> pCreateInfo points to a VkDebugReportCallbackCreateInfoEXT
        /// structure which defines the conditions under which this callback will be
        /// called.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pCallback"> pCallback is a pointer to record the
        /// VkDebugReportCallbackEXT object created.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDebugReportCallbackEXT(
            VkInstance instance,
            /*-const-*/ VkDebugReportCallbackCreateInfoEXT* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDebugReportCallbackEXT* pCallback);
        // Command: 108
        /// <summary>vkCreateDebugUtilsMessengerEXT - Create a debug messenger object
        /// </summary>
        /// <param name="instance"> instance the instance the messenger will be used with.</param>
        /// <param name="pCreateInfo"> pCreateInfo points to a VkDebugUtilsMessengerCreateInfoEXT
        /// structure which contains the callback pointer as well as defines the
        /// conditions under which this messenger will trigger the callback.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pMessenger"> pMessenger is a pointer to record the
        /// VkDebugUtilsMessengerEXT object created.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDebugUtilsMessengerEXT(
            VkInstance instance,
            /*-const-*/ VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDebugUtilsMessengerEXT* pMessenger);
        // Command: 109
        /// <summary>vkCreateDescriptorPool - Creates a descriptor pool object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the descriptor pool.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkDescriptorPoolCreateInfo structure specifying the state of the
        /// descriptor pool object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pDescriptorPool"> pDescriptorPool points to a VkDescriptorPool handle in which
        /// the resulting descriptor pool object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorPool(
            VkDevice device,
            /*-const-*/ VkDescriptorPoolCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDescriptorPool* pDescriptorPool);
        // Command: 110
        /// <summary>vkCreateDescriptorSetLayout - Create a new descriptor set layout
        /// </summary>
        /// <param name="device"> device is the logical device that creates the descriptor set
        /// layout.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkDescriptorSetLayoutCreateInfo structure specifying the state of
        /// the descriptor set layout object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pSetLayout"> pSetLayout points to a VkDescriptorSetLayout handle in which
        /// the resulting descriptor set layout object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorSetLayout(
            VkDevice device,
            /*-const-*/ VkDescriptorSetLayoutCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDescriptorSetLayout* pSetLayout);
        // Command: 111
        /// <summary>vkCreateDescriptorUpdateTemplate - Create a new descriptor update template
        /// </summary>
        /// <param name="device"> device is the logical device that creates the descriptor update
        /// template.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkDescriptorUpdateTemplateCreateInfo structure specifying the set
        /// of descriptors to update with a single call to
        /// vkCmdPushDescriptorSetWithTemplateKHR or
        /// vkUpdateDescriptorSetWithTemplate.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pDescriptorUpdateTemplate"> pDescriptorUpdateTemplate points to a
        /// VkDescriptorUpdateTemplate handle in which the resulting
        /// descriptor update template object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorUpdateTemplate(
            VkDevice device,
            /*-const-*/ VkDescriptorUpdateTemplateCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
        // Command: 112
        /// <summary>vkCreateDevice - Create a new device instance
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice
        ///   must be one of the device handles returned from a
        /// call to vkEnumeratePhysicalDevices (see
        /// Physical Device
        /// Enumeration).</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to a VkDeviceCreateInfo structure
        /// containing information about how to create the device.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pDevice"> pDevice points to a handle in which the created VkDevice is
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDevice(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkDeviceCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDevice* pDevice);
        // Command: 113
        /// <summary>vkCreateDisplayModeKHR - Create a display mode
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device associated with
        /// display.</param>
        /// <param name="display"> display is the display to create an additional mode for.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a VkDisplayModeCreateInfoKHR structure
        /// describing the new mode to create.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// display mode object when there is no more specific allocator available
        /// (see Memory Allocation).</param>
        /// <param name="pMode"> pMode returns the handle of the mode created.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDisplayModeKHR(
            VkPhysicalDevice physicalDevice,
            VkDisplayKHR display,
            /*-const-*/ VkDisplayModeCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkDisplayModeKHR* pMode);
        // Command: 114
        /// <summary>vkCreateDisplayPlaneSurfaceKHR - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> structure representing a display plane and mode
        /// </summary>
        /// <param name="instance"> instance is the instance corresponding to the physical device the
        /// targeted display is on.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkDisplaySurfaceCreateInfoKHR structure specifying which mode,
        /// plane, and other parameters to use, as described below.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDisplayPlaneSurfaceKHR(
            VkInstance instance,
            /*-const-*/ VkDisplaySurfaceCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 115
        /// <summary>vkCreateEvent - Create a new event object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the event.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkEventCreateInfo structure which contains information about how
        /// the event is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pEvent"> pEvent points to a handle in which the resulting event object is
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateEvent(
            VkDevice device,
            /*-const-*/ VkEventCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkEvent* pEvent);
        // Command: 116
        /// <summary>vkCreateFence - Create a new fence object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the fence.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkFenceCreateInfo structure which contains information about how
        /// the fence is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pFence"> pFence points to a handle in which the resulting fence object is
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateFence(
            VkDevice device,
            /*-const-*/ VkFenceCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkFence* pFence);
        // Command: 117
        /// <summary>vkCreateFramebuffer - Create a new framebuffer object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the framebuffer.</param>
        /// <param name="pCreateInfo"> pCreateInfo points to a VkFramebufferCreateInfo structure
        /// which describes additional information about framebuffer creation.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pFramebuffer"> pFramebuffer points to a VkFramebuffer handle in which the
        /// resulting framebuffer object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateFramebuffer(
            VkDevice device,
            /*-const-*/ VkFramebufferCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkFramebuffer* pFramebuffer);
        // Command: 118
        /// <summary>vkCreateGraphicsPipelines - Create graphics pipelines
        /// </summary>
        /// <param name="device"> device is the logical device that creates the graphics pipelines.</param>
        /// <param name="pipelineCache"> pipelineCache is either VK_NULL_HANDLE, indicating that
        /// pipeline caching is disabled; or the handle of a valid
        /// pipeline cache object, in which case use of that
        /// cache is enabled for the duration of the command.</param>
        /// <param name="createInfoCount"> createInfoCount is the length of the pCreateInfos and
        /// pPipelines arrays.</param>
        /// <param name="pCreateInfos"> pCreateInfos is an array of VkGraphicsPipelineCreateInfo
        /// structures.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pPipelines"> pPipelines is a pointer to an array in which the resulting
        /// graphics pipeline objects are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateGraphicsPipelines(
            VkDevice device,
            VkPipelineCache pipelineCache,
            UInt32 createInfoCount,
            /*-const-*/ VkGraphicsPipelineCreateInfo* pCreateInfos,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkPipeline* pPipelines);
        // Command: 119
        /// <summary>vkCreateIOSSurfaceMVK - Create a VkSurfaceKHR object for an iOS UIView
        /// </summary>
        /// <param name="instance"> instance is the instance with which to associate the surface.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkIOSSurfaceCreateInfoMVK structure containing parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateIOSSurfaceMVK(
            VkInstance instance,
            /*-const-*/ VkIOSSurfaceCreateInfoMVK* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 120
        /// <summary>vkCreateImage - Create a new image object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the image.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkImageCreateInfo structure containing parameters to be used to
        /// create the image.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pImage"> pImage points to a VkImage handle in which the resulting
        /// image object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateImage(
            VkDevice device,
            /*-const-*/ VkImageCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkImage* pImage);
        // Command: 121
        /// <summary>vkCreateImagePipeSurfaceFUCHSIA - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for a Fuchsia ImagePipe
        /// </summary>
        /// <param name="instance"> instance is the instance to associate with the surface.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkImagePipeSurfaceCreateInfoFUCHSIA structure containing
        /// parameters affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(
            VkInstance instance,
            /*-const-*/ VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 122
        /// <summary>vkCreateImageView - Create an image view from an existing image
        /// </summary>
        /// <param name="device"> device is the logical device that creates the image view.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkImageViewCreateInfo structure containing parameters to be used
        /// to create the image view.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pView"> pView points to a VkImageView handle in which the resulting
        /// image view object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateImageView(
            VkDevice device,
            /*-const-*/ VkImageViewCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkImageView* pView);
        // Command: 123
        /// <summary>vkCreateIndirectCommandsLayoutNVX - Create an indirect command layout object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the indirect command
        /// layout.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkIndirectCommandsLayoutCreateInfoNVX structure containing
        /// parameters affecting creation of the indirect command layout.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pIndirectCommandsLayout"> pIndirectCommandsLayout points to a
        /// VkIndirectCommandsLayoutNVX handle in which the resulting indirect
        /// command layout is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateIndirectCommandsLayoutNVX(
            VkDevice device,
            /*-const-*/ VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout);
        // Command: 124
        /// <summary>vkCreateInstance - Create a new Vulkan instance
        /// </summary>
        /// <param name="pCreateInfo"> pCreateInfo points to an instance of VkInstanceCreateInfo
        /// controlling creation of the instance.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pInstance"> pInstance points a VkInstance handle in which the resulting
        /// instance is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateInstance(
            /*-const-*/ VkInstanceCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkInstance* pInstance);
        // Command: 125
        /// <summary>vkCreateMacOSSurfaceMVK - Create a VkSurfaceKHR object for a macOS NSView
        /// </summary>
        /// <param name="instance"> instance is the instance with which to associate the surface.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkMacOSSurfaceCreateInfoMVK structure containing parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateMacOSSurfaceMVK(
            VkInstance instance,
            /*-const-*/ VkMacOSSurfaceCreateInfoMVK* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 126
        /// <summary>vkCreateMetalSurfaceEXT - Create a VkSurfaceKHR object for CAMetalLayer
        /// </summary>
        /// <param name="instance"> instance is the instance with which to associate the surface.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkMetalSurfaceCreateInfoEXT structure containing the parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateMetalSurfaceEXT(
            VkInstance instance,
            /*-const-*/ VkMetalSurfaceCreateInfoEXT* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 127
        /// <summary>vkCreateObjectTableNVX - Create an object table
        /// </summary>
        /// <param name="device"> device is the logical device that creates the object table.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkObjectTableCreateInfoNVX structure containing parameters
        /// affecting creation of the table.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pObjectTable"> pObjectTable points to a VkObjectTableNVX handle in which
        /// the resulting object table is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateObjectTableNVX(
            VkDevice device,
            /*-const-*/ VkObjectTableCreateInfoNVX* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkObjectTableNVX* pObjectTable);
        // Command: 128
        /// <summary>vkCreatePipelineCache - Creates a new pipeline cache
        /// </summary>
        /// <param name="device"> device is the logical device that creates the pipeline cache
        /// object.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to a VkPipelineCacheCreateInfo
        /// structure that contains the initial parameters for the pipeline cache
        /// object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pPipelineCache"> pPipelineCache is a pointer to a VkPipelineCache handle in
        /// which the resulting pipeline cache object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreatePipelineCache(
            VkDevice device,
            /*-const-*/ VkPipelineCacheCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkPipelineCache* pPipelineCache);
        // Command: 129
        /// <summary>vkCreatePipelineLayout - Creates a new pipeline layout object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the pipeline layout.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkPipelineLayoutCreateInfo structure specifying the state of the
        /// pipeline layout object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pPipelineLayout"> pPipelineLayout points to a VkPipelineLayout handle in which
        /// the resulting pipeline layout object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreatePipelineLayout(
            VkDevice device,
            /*-const-*/ VkPipelineLayoutCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkPipelineLayout* pPipelineLayout);
        // Command: 130
        /// <summary>vkCreateQueryPool - Create a new query pool object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the query pool.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkQueryPoolCreateInfo structure containing the number and type of
        /// queries to be managed by the pool.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pQueryPool"> pQueryPool is a pointer to a VkQueryPool handle in which the
        /// resulting query pool object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateQueryPool(
            VkDevice device,
            /*-const-*/ VkQueryPoolCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkQueryPool* pQueryPool);
        // Command: 131
        /// <summary>vkCreateRayTracingPipelinesNV - Creates a new ray tracing pipeline object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the ray tracing
        /// pipelines.</param>
        /// <param name="pipelineCache"> pipelineCache is either VK_NULL_HANDLE, indicating that
        /// pipeline caching is disabled, or the handle of a valid
        /// pipeline cache object, in which case use of that
        /// cache is enabled for the duration of the command.</param>
        /// <param name="createInfoCount"> createInfoCount is the length of the pCreateInfos and
        /// pPipelines arrays.</param>
        /// <param name="pCreateInfos"> pCreateInfos is an array of VkRayTracingPipelineCreateInfoNV
        /// structures.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pPipelines"> pPipelines is a pointer to an array in which the resulting ray
        /// tracing pipeline objects are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateRayTracingPipelinesNV(
            VkDevice device,
            VkPipelineCache pipelineCache,
            UInt32 createInfoCount,
            /*-const-*/ VkRayTracingPipelineCreateInfoNV* pCreateInfos,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkPipeline* pPipelines);
        // Command: 132
        /// <summary>vkCreateRenderPass - Create a new render pass object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the render pass.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkRenderPassCreateInfo structure that describes the parameters of
        /// the render pass.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pRenderPass"> pRenderPass points to a VkRenderPass handle in which the
        /// resulting render pass object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateRenderPass(
            VkDevice device,
            /*-const-*/ VkRenderPassCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkRenderPass* pRenderPass);
        // Command: 133
        /// <summary>vkCreateRenderPass2KHR - Create a new render pass object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the render pass.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkRenderPassCreateInfo2KHR structure that describes the parameters
        /// of the render pass.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pRenderPass"> pRenderPass points to a VkRenderPass handle in which the
        /// resulting render pass object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateRenderPass2KHR(
            VkDevice device,
            /*-const-*/ VkRenderPassCreateInfo2KHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkRenderPass* pRenderPass);
        // Command: 134
        /// <summary>vkCreateSampler - Create a new sampler object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the sampler.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkSamplerCreateInfo structure specifying the state of the sampler
        /// object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pSampler"> pSampler points to a VkSampler handle in which the resulting
        /// sampler object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSampler(
            VkDevice device,
            /*-const-*/ VkSamplerCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSampler* pSampler);
        // Command: 135
        /// <summary>vkCreateSamplerYcbcrConversion - Create a new Ycbcr conversion
        /// </summary>
        /// <param name="device"> device is the logical device that creates the sampler Y’CBCR
        /// conversion.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkSamplerYcbcrConversionCreateInfo specifying the requested
        /// sampler Y’CBCR conversion.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pYcbcrConversion"> pYcbcrConversion points to a VkSamplerYcbcrConversion handle
        /// in which the resulting sampler Y’CBCR conversion is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSamplerYcbcrConversion(
            VkDevice device,
            /*-const-*/ VkSamplerYcbcrConversionCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSamplerYcbcrConversion* pYcbcrConversion);
        // Command: 136
        /// <summary>vkCreateSemaphore - Create a new queue semaphore object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the semaphore.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkSemaphoreCreateInfo structure which contains information about
        /// how the semaphore is to be created.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pSemaphore"> pSemaphore points to a handle in which the resulting semaphore
        /// object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSemaphore(
            VkDevice device,
            /*-const-*/ VkSemaphoreCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSemaphore* pSemaphore);
        // Command: 137
        /// <summary>vkCreateShaderModule - Creates a new shader module object
        /// </summary>
        /// <param name="device"> device is the logical device that creates the shader module.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkShaderModuleCreateInfo structure.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pShaderModule"> pShaderModule points to a VkShaderModule handle in which the
        /// resulting shader module object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateShaderModule(
            VkDevice device,
            /*-const-*/ VkShaderModuleCreateInfo* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkShaderModule* pShaderModule);
        // Command: 138
        /// <summary>vkCreateSharedSwapchainsKHR - Create multiple swapchains that share presentable images
        /// </summary>
        /// <param name="device"> device is the device to create the swapchains for.</param>
        /// <param name="swapchainCount"> swapchainCount is the number of swapchains to create.</param>
        /// <param name="pCreateInfos"> pCreateInfos is a pointer to an array of
        /// VkSwapchainCreateInfoKHR structures specifying the parameters of
        /// the created swapchains.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// swapchain objects when there is no more specific allocator available
        /// (see Memory Allocation).</param>
        /// <param name="pSwapchains"> pSwapchains is a pointer to an array of VkSwapchainKHR
        /// handles in which the created swapchain objects will be returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSharedSwapchainsKHR(
            VkDevice device,
            UInt32 swapchainCount,
            /*-const-*/ VkSwapchainCreateInfoKHR* pCreateInfos,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSwapchainKHR* pSwapchains);
        // Command: 139
        /// <summary>vkCreateStreamDescriptorSurfaceGGP - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for a Google Games Platform stream
        /// </summary>
        /// <param name="instance"> instance is the instance to associate with the surface.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkStreamDescriptorSurfaceCreateInfoGGP structure containing
        /// parameters that affect the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateStreamDescriptorSurfaceGGP(
            VkInstance instance,
            /*-const-*/ VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 140
        /// <summary>vkCreateSwapchainKHR - Create a swapchain
        /// </summary>
        /// <param name="device"> device is the device to create the swapchain for.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkSwapchainCreateInfoKHR structure specifying the parameters of
        /// the created swapchain.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// swapchain object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSwapchain"> pSwapchain is a pointer to a VkSwapchainKHR handle in which
        /// the created swapchain object will be returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSwapchainKHR(
            VkDevice device,
            /*-const-*/ VkSwapchainCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSwapchainKHR* pSwapchain);
        // Command: 141
        /// <summary>vkCreateValidationCacheEXT - Creates a new validation cache
        /// </summary>
        /// <param name="device"> device is the logical device that creates the validation cache
        /// object.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to a VkValidationCacheCreateInfoEXT
        /// structure that contains the initial parameters for the validation cache
        /// object.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pValidationCache"> pValidationCache is a pointer to a VkValidationCacheEXT
        /// handle in which the resulting validation cache object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateValidationCacheEXT(
            VkDevice device,
            /*-const-*/ VkValidationCacheCreateInfoEXT* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkValidationCacheEXT* pValidationCache);
        // Command: 142
        /// <summary>vkCreateViSurfaceNN - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for a VI layer
        /// </summary>
        /// <param name="instance"> instance is the instance with which to associate the surface.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkViSurfaceCreateInfoNN structure containing parameters affecting
        /// the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateViSurfaceNN(
            VkInstance instance,
            /*-const-*/ VkViSurfaceCreateInfoNN* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 143
        /// <summary>vkCreateWaylandSurfaceKHR - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for a Wayland window
        /// </summary>
        /// <param name="instance"> instance is the instance to associate the surface with.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkWaylandSurfaceCreateInfoKHR structure containing parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateWaylandSurfaceKHR(
            VkInstance instance,
            /*-const-*/ VkWaylandSurfaceCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 144
        /// <summary>vkCreateWin32SurfaceKHR - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for an Win32 native window
        /// </summary>
        /// <param name="instance"> instance is the instance to associate the surface with.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkWin32SurfaceCreateInfoKHR structure containing parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateWin32SurfaceKHR(
            VkInstance instance,
            /*-const-*/ VkWin32SurfaceCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 145
        /// <summary>vkCreateXcbSurfaceKHR - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for a X11 window, using the XCB client-side library
        /// </summary>
        /// <param name="instance"> instance is the instance to associate the surface with.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkXcbSurfaceCreateInfoKHR structure containing parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateXcbSurfaceKHR(
            VkInstance instance,
            /*-const-*/ VkXcbSurfaceCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 146
        /// <summary>vkCreateXlibSurfaceKHR - Create a <a href="#VkSurfaceKHR">VkSurfaceKHR</a> object for an X11 window, using the Xlib client-side library
        /// </summary>
        /// <param name="instance"> instance is the instance to associate the surface with.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkXlibSurfaceCreateInfoKHR structure containing the parameters
        /// affecting the creation of the surface object.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        /// <param name="pSurface"> pSurface points to a VkSurfaceKHR handle in which the
        /// created surface object is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateXlibSurfaceKHR(
            VkInstance instance,
            /*-const-*/ VkXlibSurfaceCreateInfoKHR* pCreateInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);
        // Command: 147
        /// <summary>vkDebugMarkerSetObjectNameEXT - Give a user-friendly name to an object
        /// </summary>
        /// <param name="device"> device is the device that created the object.</param>
        /// <param name="pNameInfo"> pNameInfo is a pointer to an instance of the
        /// VkDebugMarkerObjectNameInfoEXT structure specifying the parameters
        /// of the name to set on the object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDebugMarkerSetObjectNameEXT(
            VkDevice device,
            /*-const-*/ VkDebugMarkerObjectNameInfoEXT* pNameInfo);
        // Command: 148
        /// <summary>vkDebugMarkerSetObjectTagEXT - Attach arbitrary data to an object
        /// </summary>
        /// <param name="device"> device is the device that created the object.</param>
        /// <param name="pTagInfo"> pTagInfo is a pointer to an instance of the
        /// VkDebugMarkerObjectTagInfoEXT structure specifying the parameters
        /// of the tag to attach to the object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDebugMarkerSetObjectTagEXT(
            VkDevice device,
            /*-const-*/ VkDebugMarkerObjectTagInfoEXT* pTagInfo);
        // Command: 149
        /// <summary>vkDebugReportMessageEXT - Inject a message into a debug stream
        /// </summary>
        /// <param name="instance"> instance is the debug stream’s VkInstance.</param>
        /// <param name="flags"> flags specifies the VkDebugReportFlagBitsEXT classification
        /// of this event/message.</param>
        /// <param name="objectType"> objectType is a VkDebugReportObjectTypeEXT specifying the
        /// type of object being used or created at the time the event was
        /// triggered.</param>
        /// <param name="object"> object this is the object where the issue was detected.
        /// object can be VK_NULL_HANDLE if there is no object
        /// associated with the event.</param>
        /// <param name="location"> location is an application defined value.</param>
        /// <param name="messageCode"> messageCode is an application defined value.</param>
        /// <param name="pLayerPrefix"> pLayerPrefix is the abbreviation of the component making this
        /// event/message.</param>
        /// <param name="pMessage"> pMessage is a null-terminated string detailing the trigger
        /// conditions.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugReportMessageEXT(
            VkInstance instance,
            VkDebugReportFlagsEXT flags,
            VkDebugReportObjectTypeEXT _objectType,
            UInt64 _object,
            Int32 location,
            Int32 messageCode,
            IntPtr pLayerPrefix,
            IntPtr pMessage);
        // Command: 150
        /// <summary>vkDestroyAccelerationStructureNV - Destroy an acceleration structure object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the buffer.</param>
        /// <param name="accelerationStructure"> accelerationStructure is the acceleration structure to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyAccelerationStructureNV(
            VkDevice device,
            VkAccelerationStructureNV accelerationStructure,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 151
        /// <summary>vkDestroyBuffer - Destroy a buffer object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the buffer.</param>
        /// <param name="buffer"> buffer is the buffer to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer(
            VkDevice device,
            VkBuffer buffer,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 152
        /// <summary>vkDestroyBufferView - Destroy a buffer view object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the buffer view.</param>
        /// <param name="bufferView"> bufferView is the buffer view to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView(
            VkDevice device,
            VkBufferView bufferView,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 153
        /// <summary>vkDestroyCommandPool - Destroy a command pool object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the command pool.</param>
        /// <param name="commandPool"> commandPool is the handle of the command pool to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool(
            VkDevice device,
            VkCommandPool commandPool,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 154
        /// <summary>vkDestroyDebugReportCallbackEXT - Destroy a debug report callback object
        /// </summary>
        /// <param name="instance"> instance the instance where the callback was created.</param>
        /// <param name="callback"> callback the VkDebugReportCallbackEXT object to destroy.
        /// callback is an externally synchronized object and must not be
        /// used on more than one thread at a time.
        /// This means that vkDestroyDebugReportCallbackEXT must not be
        /// called when a callback is active.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugReportCallbackEXT(
            VkInstance instance,
            VkDebugReportCallbackEXT callback,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 155
        /// <summary>vkDestroyDebugUtilsMessengerEXT - Destroy a debug messenger object
        /// </summary>
        /// <param name="instance"> instance the instance where the callback was created.</param>
        /// <param name="messenger"> messenger the VkDebugUtilsMessengerEXT object to destroy.
        /// messenger is an externally synchronized object and must not be
        /// used on more than one thread at a time.
        /// This means that vkDestroyDebugUtilsMessengerEXT must not be
        /// called when a callback is active.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugUtilsMessengerEXT(
            VkInstance instance,
            VkDebugUtilsMessengerEXT messenger,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 156
        /// <summary>vkDestroyDescriptorPool - Destroy a descriptor pool object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the descriptor pool.</param>
        /// <param name="descriptorPool"> descriptorPool is the descriptor pool to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool(
            VkDevice device,
            VkDescriptorPool descriptorPool,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 157
        /// <summary>vkDestroyDescriptorSetLayout - Destroy a descriptor set layout object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the descriptor set
        /// layout.</param>
        /// <param name="descriptorSetLayout"> descriptorSetLayout is the descriptor set layout to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout(
            VkDevice device,
            VkDescriptorSetLayout descriptorSetLayout,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 158
        /// <summary>vkDestroyDescriptorUpdateTemplate - Destroy a descriptor update template object
        /// </summary>
        /// <param name="device"> device is the logical device that has been used to create the
        /// descriptor update template</param>
        /// <param name="descriptorUpdateTemplate"> descriptorUpdateTemplate is the descriptor update template to
        /// destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorUpdateTemplate(
            VkDevice device,
            VkDescriptorUpdateTemplate descriptorUpdateTemplate,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 159
        /// <summary>vkDestroyDevice - Destroy a logical device
        /// </summary>
        /// <param name="device"> device is the logical device to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice(
            VkDevice device,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 160
        /// <summary>vkDestroyEvent - Destroy an event object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the event.</param>
        /// <param name="event"> event is the handle of the event to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent(
            VkDevice device,
            VkEvent _event,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 161
        /// <summary>vkDestroyFence - Destroy a fence object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the fence.</param>
        /// <param name="fence"> fence is the handle of the fence to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence(
            VkDevice device,
            VkFence fence,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 162
        /// <summary>vkDestroyFramebuffer - Destroy a framebuffer object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the framebuffer.</param>
        /// <param name="framebuffer"> framebuffer is the handle of the framebuffer to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer(
            VkDevice device,
            VkFramebuffer framebuffer,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 163
        /// <summary>vkDestroyImage - Destroy an image object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the image.</param>
        /// <param name="image"> image is the image to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImage(
            VkDevice device,
            VkImage image,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 164
        /// <summary>vkDestroyImageView - Destroy an image view object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the image view.</param>
        /// <param name="imageView"> imageView is the image view to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView(
            VkDevice device,
            VkImageView imageView,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 165
        /// <summary>vkDestroyIndirectCommandsLayoutNVX - Destroy an object table
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the layout.</param>
        /// <param name="indirectCommandsLayout"> indirectCommandsLayout is the table to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX(
            VkDevice device,
            VkIndirectCommandsLayoutNVX indirectCommandsLayout,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 166
        /// <summary>vkDestroyInstance - Destroy an instance of Vulkan
        /// </summary>
        /// <param name="instance"> instance is the handle of the instance to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance(
            VkInstance instance,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 167
        /// <summary>vkDestroyObjectTableNVX - Destroy an object table
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the table.</param>
        /// <param name="objectTable"> objectTable is the table to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyObjectTableNVX(
            VkDevice device,
            VkObjectTableNVX _objectTable,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 168
        /// <summary>vkDestroyPipeline - Destroy a pipeline object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the pipeline.</param>
        /// <param name="pipeline"> pipeline is the handle of the pipeline to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline(
            VkDevice device,
            VkPipeline pipeline,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 169
        /// <summary>vkDestroyPipelineCache - Destroy a pipeline cache object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the pipeline cache
        /// object.</param>
        /// <param name="pipelineCache"> pipelineCache is the handle of the pipeline cache to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache(
            VkDevice device,
            VkPipelineCache pipelineCache,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 170
        /// <summary>vkDestroyPipelineLayout - Destroy a pipeline layout object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the pipeline layout.</param>
        /// <param name="pipelineLayout"> pipelineLayout is the pipeline layout to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout(
            VkDevice device,
            VkPipelineLayout pipelineLayout,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 171
        /// <summary>vkDestroyQueryPool - Destroy a query pool object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the query pool.</param>
        /// <param name="queryPool"> queryPool is the query pool to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool(
            VkDevice device,
            VkQueryPool queryPool,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 172
        /// <summary>vkDestroyRenderPass - Destroy a render pass object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the render pass.</param>
        /// <param name="renderPass"> renderPass is the handle of the render pass to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyRenderPass(
            VkDevice device,
            VkRenderPass renderPass,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 173
        /// <summary>vkDestroySampler - Destroy a sampler object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the sampler.</param>
        /// <param name="sampler"> sampler is the sampler to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler(
            VkDevice device,
            VkSampler sampler,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 174
        /// <summary>vkDestroySamplerYcbcrConversion - Destroy a created Y’CbCr conversion
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the Y’CBCR
        /// conversion.</param>
        /// <param name="ycbcrConversion"> ycbcrConversion is the conversion to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySamplerYcbcrConversion(
            VkDevice device,
            VkSamplerYcbcrConversion ycbcrConversion,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 175
        /// <summary>vkDestroySemaphore - Destroy a semaphore object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the semaphore.</param>
        /// <param name="semaphore"> semaphore is the handle of the semaphore to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore(
            VkDevice device,
            VkSemaphore semaphore,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 176
        /// <summary>vkDestroyShaderModule - Destroy a shader module
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the shader module.</param>
        /// <param name="shaderModule"> shaderModule is the handle of the shader module to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule(
            VkDevice device,
            VkShaderModule shaderModule,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 177
        /// <summary>vkDestroySurfaceKHR - Destroy a VkSurfaceKHR object
        /// </summary>
        /// <param name="instance"> instance is the instance used to create the surface.</param>
        /// <param name="surface"> surface is the surface to destroy.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// surface object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySurfaceKHR(
            VkInstance instance,
            VkSurfaceKHR surface,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 178
        /// <summary>vkDestroySwapchainKHR - Destroy a swapchain object
        /// </summary>
        /// <param name="device"> device is the VkDevice associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to destroy.</param>
        /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the
        /// swapchain object when there is no more specific allocator available (see
        /// Memory Allocation).</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySwapchainKHR(
            VkDevice device,
            VkSwapchainKHR swapchain,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 179
        /// <summary>vkDestroyValidationCacheEXT - Destroy a validation cache object
        /// </summary>
        /// <param name="device"> device is the logical device that destroys the validation cache
        /// object.</param>
        /// <param name="validationCache"> validationCache is the handle of the validation cache to destroy.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyValidationCacheEXT(
            VkDevice device,
            VkValidationCacheEXT validationCache,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 180
        /// <summary>vkDeviceWaitIdle - Wait for a device to become idle
        /// </summary>
        /// <param name="device"> device is the logical device to idle.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDeviceWaitIdle(
            VkDevice device);
        // Command: 181
        /// <summary>vkDisplayPowerControlEXT - Set the power state of a display
        /// </summary>
        /// <param name="device"> device is a logical device associated with display.</param>
        /// <param name="display"> display is the display whose power state is modified.</param>
        /// <param name="pDisplayPowerInfo"> pDisplayPowerInfo is an instance of VkDisplayPowerInfoEXT
        /// specifying the new power state of display.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDisplayPowerControlEXT(
            VkDevice device,
            VkDisplayKHR display,
            /*-const-*/ VkDisplayPowerInfoEXT* pDisplayPowerInfo);
        // Command: 182
        /// <summary>vkEndCommandBuffer - Finish recording a command buffer
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer to complete recording.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEndCommandBuffer(
            VkCommandBuffer commandBuffer);
        // Command: 183
        /// <summary>vkEnumerateDeviceExtensionProperties - Returns properties of available physical device extensions
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be queried.</param>
        /// <param name="pLayerName"> pLayerName is either NULL or a pointer to a null-terminated
        /// UTF-8 string naming the layer to retrieve extensions from.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// extension properties available or queried, and is treated in the same
        /// fashion as the
        /// vkEnumerateInstanceExtensionProperties::pPropertyCount
        /// parameter.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkExtensionProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateDeviceExtensionProperties(
            VkPhysicalDevice physicalDevice,
            IntPtr pLayerName,
            UInt32* pPropertyCount,
            VkExtensionProperties* pProperties);
        // Command: 184
        /// <summary>vkEnumerateDeviceLayerProperties - Returns properties of available physical device layers
        /// </summary>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// layer properties available or queried.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkLayerProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateDeviceLayerProperties(
            VkPhysicalDevice physicalDevice,
            UInt32* pPropertyCount,
            VkLayerProperties* pProperties);
        // Command: 185
        /// <summary>vkEnumerateInstanceExtensionProperties - Returns up to requested number of global extension properties
        /// </summary>
        /// <param name="pLayerName"> pLayerName is either NULL or a pointer to a null-terminated
        /// UTF-8 string naming the layer to retrieve extensions from.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// extension properties available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkExtensionProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateInstanceExtensionProperties(
            IntPtr pLayerName,
            UInt32* pPropertyCount,
            VkExtensionProperties* pProperties);
        // Command: 186
        /// <summary>vkEnumerateInstanceLayerProperties - Returns up to requested number of global layer properties
        /// </summary>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// layer properties available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkLayerProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateInstanceLayerProperties(
            UInt32* pPropertyCount,
            VkLayerProperties* pProperties);
        // Command: 187
        /// <summary>vkEnumerateInstanceVersion - Query instance-level version before instance creation
        /// </summary>
        /// <param name="pApiVersion"> pApiVersion points to a uint32_t, which is the version of
        /// Vulkan supported by instance-level functionality, encoded as described
        /// in html/vkspec.html#extendingvulkan-coreversions-versionnumbers.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateInstanceVersion(
            UInt32* pApiVersion);
        // Command: 188
        /// <summary>vkEnumeratePhysicalDeviceGroups - Enumerates groups of physical devices that can be used to create a single logical device
        /// </summary>
        /// <param name="instance"> instance is a handle to a Vulkan instance previously created with
        /// vkCreateInstance.</param>
        /// <param name="pPhysicalDeviceGroupCount"> pPhysicalDeviceGroupCount is a pointer to an integer related to
        /// the number of device groups available or queried, as described below.</param>
        /// <param name="pPhysicalDeviceGroupProperties"> pPhysicalDeviceGroupProperties is either NULL or a pointer to an
        /// array of VkPhysicalDeviceGroupProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroups(
            VkInstance instance,
            UInt32* pPhysicalDeviceGroupCount,
            VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
        // Command: 189
        /// <summary>vkEnumeratePhysicalDevices - Enumerates the physical devices accessible to a Vulkan instance
        /// </summary>
        /// <param name="instance"> instance is a handle to a Vulkan instance previously created with
        /// vkCreateInstance.</param>
        /// <param name="pPhysicalDeviceCount"> pPhysicalDeviceCount is a pointer to an integer related to the
        /// number of physical devices available or queried, as described below.</param>
        /// <param name="pPhysicalDevices"> pPhysicalDevices is either NULL or a pointer to an array of
        /// VkPhysicalDevice handles.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumeratePhysicalDevices(
            VkInstance instance,
            UInt32* pPhysicalDeviceCount,
            VkPhysicalDevice* pPhysicalDevices);
        // Command: 190
        /// <summary>vkFlushMappedMemoryRanges - Flush mapped memory ranges
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory ranges.</param>
        /// <param name="memoryRangeCount"> memoryRangeCount is the length of the pMemoryRanges array.</param>
        /// <param name="pMemoryRanges"> pMemoryRanges is a pointer to an array of
        /// VkMappedMemoryRange structures describing the memory ranges to
        /// flush.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkFlushMappedMemoryRanges(
            VkDevice device,
            UInt32 memoryRangeCount,
            /*-const-*/ VkMappedMemoryRange* pMemoryRanges);
        // Command: 191
        /// <summary>vkFreeCommandBuffers - Free command buffers
        /// </summary>
        /// <param name="device"> device is the logical device that owns the command pool.</param>
        /// <param name="commandPool"> commandPool is the command pool from which the command buffers
        /// were allocated.</param>
        /// <param name="commandBufferCount"> commandBufferCount is the length of the pCommandBuffers
        /// array.</param>
        /// <param name="pCommandBuffers"> pCommandBuffers is an array of handles of command buffers to free.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers(
            VkDevice device,
            VkCommandPool commandPool,
            UInt32 commandBufferCount,
            /*-const-*/ VkCommandBuffer* pCommandBuffers);
        // Command: 192
        /// <summary>vkFreeDescriptorSets - Free one or more descriptor sets
        /// </summary>
        /// <param name="device"> device is the logical device that owns the descriptor pool.</param>
        /// <param name="descriptorPool"> descriptorPool is the descriptor pool from which the descriptor
        /// sets were allocated.</param>
        /// <param name="descriptorSetCount"> descriptorSetCount is the number of elements in the
        /// pDescriptorSets array.</param>
        /// <param name="pDescriptorSets"> pDescriptorSets is an array of handles to VkDescriptorSet
        /// objects.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkFreeDescriptorSets(
            VkDevice device,
            VkDescriptorPool descriptorPool,
            UInt32 descriptorSetCount,
            /*-const-*/ VkDescriptorSet* pDescriptorSets);
        // Command: 193
        /// <summary>vkFreeMemory - Free device memory
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="memory"> memory is the VkDeviceMemory object to be freed.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory(
            VkDevice device,
            VkDeviceMemory memory,
            /*-const-*/ VkAllocationCallbacks* pAllocator);
        // Command: 194
        /// <summary>vkGetAccelerationStructureHandleNV - Get opaque acceleration structure handle
        /// </summary>
        /// <param name="device"> device is the logical device that owns the acceleration
        /// structures.</param>
        /// <param name="accelerationStructure"> accelerationStructure is the acceleration structure.</param>
        /// <param name="dataSize"> dataSize is the size in bytes of the buffer pointed to by
        /// pData.</param>
        /// <param name="pData"> pData is a pointer to a user-allocated buffer where the results
        /// will be written.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetAccelerationStructureHandleNV(
            VkDevice device,
            VkAccelerationStructureNV accelerationStructure,
            Int32 dataSize,
            void* pData);
        // Command: 195
        /// <summary>vkGetAccelerationStructureMemoryRequirementsNV - Get acceleration structure memory requirements
        /// </summary>
        /// <param name="device"> device is the logical device on which the acceleration structure
        /// was created.</param>
        /// <param name="pInfo"> pInfo specifies the acceleration structure to get memory
        /// requirements for.</param>
        /// <param name="pMemoryRequirements"> pMemoryRequirements returns the requested acceleration structure
        /// memory requirements.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsNV(
            VkDevice device,
            /*-const-*/ VkAccelerationStructureMemoryRequirementsInfoNV* pInfo,
            VkMemoryRequirements2KHR* pMemoryRequirements);
        // Command: 196
        /// <summary>vkGetAndroidHardwareBufferPropertiesANDROID - Get Properties of External Memory Android Hardware Buffers
        /// </summary>
        /// <param name="device"> device is the logical device that will be importing buffer.</param>
        /// <param name="buffer"> buffer is the Android hardware buffer which will be imported.</param>
        /// <param name="pProperties"> pProperties is a pointer to a
        /// VkAndroidHardwareBufferPropertiesANDROID structure in which the
        /// properties of buffer are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID(
            VkDevice device,
            /*-const-*/ /* struct */ AHardwareBuffer* buffer,
            VkAndroidHardwareBufferPropertiesANDROID* pProperties);
        // Command: 197
        /// <summary>vkGetBufferDeviceAddressEXT - Query an address of a buffer
        /// </summary>
        /// <param name="device"> device is the logical device that the buffer was created on.</param>
        /// <param name="pInfo"> pInfo is a pointer to an instance of the
        /// VkBufferDeviceAddressInfoEXT structure specifying the buffer to
        /// retrieve an address for.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkDeviceAddress vkGetBufferDeviceAddressEXT(
            VkDevice device,
            /*-const-*/ VkBufferDeviceAddressInfoEXT* pInfo);
        // Command: 198
        /// <summary>vkGetBufferMemoryRequirements - Returns the memory requirements for specified Vulkan object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the buffer.</param>
        /// <param name="buffer"> buffer is the buffer to query.</param>
        /// <param name="pMemoryRequirements"> pMemoryRequirements points to an instance of the
        /// VkMemoryRequirements structure in which the memory requirements of
        /// the buffer object are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements(
            VkDevice device,
            VkBuffer buffer,
            VkMemoryRequirements* pMemoryRequirements);
        // Command: 199
        /// <summary>vkGetBufferMemoryRequirements2 - Returns the memory requirements for specified Vulkan object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the buffer.</param>
        /// <param name="pInfo"> pInfo is a pointer to an instance of the
        /// VkBufferMemoryRequirementsInfo2 structure containing parameters
        /// required for the memory requirements query.</param>
        /// <param name="pMemoryRequirements"> pMemoryRequirements points to an instance of the
        /// VkMemoryRequirements2 structure in which the memory requirements
        /// of the buffer object are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements2(
            VkDevice device,
            /*-const-*/ VkBufferMemoryRequirementsInfo2* pInfo,
            VkMemoryRequirements2* pMemoryRequirements);
        // Command: 200
        /// <summary>vkGetCalibratedTimestampsEXT - Query calibrated timestamps
        /// </summary>
        /// <param name="device"> device is the logical device used to perform the query.</param>
        /// <param name="timestampCount"> timestampCount is the number of timestamps to query.</param>
        /// <param name="pTimestampInfos"> pTimestampInfos is a pointer to an array of timestampCount
        /// number of structures of type VkCalibratedTimestampInfoEXT,
        /// describing the time domains the calibrated timestamps should be captured
        /// from.</param>
        /// <param name="pTimestamps"> pTimestamps is a pointer to an array of timestampCount
        /// number of 64-bit unsigned integer values in which the requested
        /// calibrated timestamp values are returned.</param>
        /// <param name="pMaxDeviation"> pMaxDeviation is a pointer to a 64-bit unsigned integer value in
        /// which the strictly positive maximum deviation, in nanoseconds, of the
        /// calibrated timestamp values is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetCalibratedTimestampsEXT(
            VkDevice device,
            UInt32 timestampCount,
            /*-const-*/ VkCalibratedTimestampInfoEXT* pTimestampInfos,
            UInt64* pTimestamps,
            UInt64* pMaxDeviation);
        // Command: 201
        /// <summary>vkGetDescriptorSetLayoutSupport - Query whether a descriptor set layout can be created
        /// </summary>
        /// <param name="device"> device is the logical device that would create the descriptor set
        /// layout.</param>
        /// <param name="pCreateInfo"> pCreateInfo is a pointer to an instance of the
        /// VkDescriptorSetLayoutCreateInfo structure specifying the state of
        /// the descriptor set layout object.</param>
        /// <param name="pSupport"> pSupport points to a VkDescriptorSetLayoutSupport structure
        /// in which information about support for the descriptor set layout object
        /// is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDescriptorSetLayoutSupport(
            VkDevice device,
            /*-const-*/ VkDescriptorSetLayoutCreateInfo* pCreateInfo,
            VkDescriptorSetLayoutSupport* pSupport);
        // Command: 202
        /// <summary>vkGetDeviceGroupPeerMemoryFeatures - Query supported peer memory features of a device
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="heapIndex"> heapIndex is the index of the memory heap from which the memory is
        /// allocated.</param>
        /// <param name="localDeviceIndex"> localDeviceIndex is the device index of the physical device that
        /// performs the memory access.</param>
        /// <param name="remoteDeviceIndex"> remoteDeviceIndex is the device index of the physical device that
        /// the memory is allocated for.</param>
        /// <param name="pPeerMemoryFeatures"> pPeerMemoryFeatures is a pointer to a bitmask of
        /// VkPeerMemoryFeatureFlagBits indicating which types of memory
        /// accesses are supported for the combination of heap, local, and remote
        /// devices.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeatures(
            VkDevice device,
            UInt32 heapIndex,
            UInt32 localDeviceIndex,
            UInt32 remoteDeviceIndex,
            VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
        // Command: 203
        /// <summary>vkGetDeviceGroupPresentCapabilitiesKHR - Query present capabilities from other physical devices
        /// </summary>
        /// <param name="device"> device is the logical device.</param>
        /// <param name="pDeviceGroupPresentCapabilities"> pDeviceGroupPresentCapabilities is a pointer to a structure of
        /// type VkDeviceGroupPresentCapabilitiesKHR that is filled with the
        /// logical device’s capabilities.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDeviceGroupPresentCapabilitiesKHR(
            VkDevice device,
            VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);
        // Command: 204
        /// <summary>vkGetDeviceGroupSurfacePresentModes2EXT - Query device group present capabilities for a surface
        /// </summary>
        /// <param name="device"> device is the logical device.</param>
        /// <param name="pSurfaceInfo"> pSurfaceInfo points to an instance of the
        /// VkPhysicalDeviceSurfaceInfo2KHR structure, describing the surface and
        /// other fixed parameters that would be consumed by vkCreateSwapchainKHR.</param>
        /// <param name="pModes"> pModes is a pointer to a value of type
        /// VkDeviceGroupPresentModeFlagsKHR that is filled with the supported
        /// device group present modes for the surface.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModes2EXT(
            VkDevice device,
            /*-const-*/ VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            VkDeviceGroupPresentModeFlagsKHR* pModes);
        // Command: 205
        /// <summary>vkGetDeviceGroupSurfacePresentModesKHR - Query present capabilities for a surface
        /// </summary>
        /// <param name="device"> device is the logical device.</param>
        /// <param name="surface"> surface is the surface.</param>
        /// <param name="pModes"> pModes is a pointer to a value of type
        /// VkDeviceGroupPresentModeFlagsKHR that is filled with the supported
        /// device group present modes for the surface.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModesKHR(
            VkDevice device,
            VkSurfaceKHR surface,
            VkDeviceGroupPresentModeFlagsKHR* pModes);
        // Command: 206
        /// <summary>vkGetDeviceMemoryCommitment - Query the current commitment for a VkDeviceMemory
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="memory"> memory is the memory object being queried.</param>
        /// <param name="pCommittedMemoryInBytes"> pCommittedMemoryInBytes is a pointer to a VkDeviceSize
        /// value in which the number of bytes currently committed is returned, on
        /// success.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceMemoryCommitment(
            VkDevice device,
            VkDeviceMemory memory,
            VkDeviceSize* pCommittedMemoryInBytes);
        // Command: 207
        /// <summary>vkGetDeviceProcAddr - Return a function pointer for a command
        /// </summary>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern PFN_vkVoidFunction vkGetDeviceProcAddr(
            VkDevice device,
            IntPtr pName);
        // Command: 208
        /// <summary>vkGetDeviceQueue - Get a queue handle from a device
        /// </summary>
        /// <param name="device"> device is the logical device that owns the queue.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the index of the queue family to which the
        /// queue belongs.</param>
        /// <param name="queueIndex"> queueIndex is the index within this queue family of the queue to
        /// retrieve.</param>
        /// <param name="pQueue"> pQueue is a pointer to a VkQueue object that will be filled
        /// with the handle for the requested queue.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue(
            VkDevice device,
            UInt32 queueFamilyIndex,
            UInt32 queueIndex,
            VkQueue* pQueue);
        // Command: 209
        /// <summary>vkGetDeviceQueue2 - Get a queue handle from a device
        /// </summary>
        /// <param name="device"> device is the logical device that owns the queue.</param>
        /// <param name="pQueueInfo"> pQueueInfo points to an instance of the VkDeviceQueueInfo2
        /// structure, describing the parameters used to create the device queue.</param>
        /// <param name="pQueue"> pQueue is a pointer to a VkQueue object that will be filled
        /// with the handle for the requested queue.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue2(
            VkDevice device,
            /*-const-*/ VkDeviceQueueInfo2* pQueueInfo,
            VkQueue* pQueue);
        // Command: 210
        /// <summary>vkGetDisplayModeProperties2KHR - Query information about the available display modes.
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device associated with
        /// display.</param>
        /// <param name="display"> display is the display to query.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// display modes available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkDisplayModeProperties2KHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayModeProperties2KHR(
            VkPhysicalDevice physicalDevice,
            VkDisplayKHR display,
            UInt32* pPropertyCount,
            VkDisplayModeProperties2KHR* pProperties);
        // Command: 211
        /// <summary>vkGetDisplayModePropertiesKHR - Query the set of mode properties supported by the display
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device associated with
        /// display.</param>
        /// <param name="display"> display is the display to query.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// display modes available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkDisplayModePropertiesKHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayModePropertiesKHR(
            VkPhysicalDevice physicalDevice,
            VkDisplayKHR display,
            UInt32* pPropertyCount,
            VkDisplayModePropertiesKHR* pProperties);
        // Command: 212
        /// <summary>vkGetDisplayPlaneCapabilities2KHR - Query capabilities of a mode and plane combination
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device associated with
        /// pDisplayPlaneInfo.</param>
        /// <param name="pDisplayPlaneInfo"> pDisplayPlaneInfo is a pointer to an instance of the
        /// VkDisplayPlaneInfo2KHR structure describing the plane and mode.</param>
        /// <param name="pCapabilities"> pCapabilities is a pointer to a
        /// VkDisplayPlaneCapabilities2KHR structure in which the capabilities
        /// are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayPlaneCapabilities2KHR(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo,
            VkDisplayPlaneCapabilities2KHR* pCapabilities);
        // Command: 213
        /// <summary>vkGetDisplayPlaneCapabilitiesKHR - Query capabilities of a mode and plane combination
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device associated with
        /// display </param>
        /// <param name="mode"> mode is the display mode the application intends to program when
        /// using the specified plane.
        /// Note this parameter also implicitly specifies a display.</param>
        /// <param name="planeIndex"> planeIndex is the plane which the application intends to use with
        /// the display, and is less than the number of display planes supported by
        /// the device.</param>
        /// <param name="pCapabilities"> pCapabilities is a pointer to a
        /// VkDisplayPlaneCapabilitiesKHR structure in which the capabilities
        /// are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayPlaneCapabilitiesKHR(
            VkPhysicalDevice physicalDevice,
            VkDisplayModeKHR mode,
            UInt32 planeIndex,
            VkDisplayPlaneCapabilitiesKHR* pCapabilities);
        // Command: 214
        /// <summary>vkGetDisplayPlaneSupportedDisplaysKHR - Query the list of displays a plane supports
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is a physical device.</param>
        /// <param name="planeIndex"> planeIndex is the plane which the application wishes to use, and
        /// must be in the range [0, physical device plane count - 1].</param>
        /// <param name="pDisplayCount"> pDisplayCount is a pointer to an integer related to the number of
        /// displays available or queried, as described below.</param>
        /// <param name="pDisplays"> pDisplays is either NULL or a pointer to an array of
        /// VkDisplayKHR handles.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayPlaneSupportedDisplaysKHR(
            VkPhysicalDevice physicalDevice,
            UInt32 planeIndex,
            UInt32* pDisplayCount,
            VkDisplayKHR* pDisplays);
        // Command: 215
        /// <summary>vkGetEventStatus - Retrieve the status of an event object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the event.</param>
        /// <param name="event"> event is the handle of the event to query.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetEventStatus(
            VkDevice device,
            VkEvent _event);
        // Command: 216
        /// <summary>vkGetFenceFdKHR - Get a POSIX file descriptor handle for a fence
        /// </summary>
        /// <param name="device"> device is the logical device that created the fence being
        /// exported.</param>
        /// <param name="pGetFdInfo"> pGetFdInfo is a pointer to an instance of the
        /// VkFenceGetFdInfoKHR structure containing parameters of the export
        /// operation.</param>
        /// <param name="pFd"> pFd will return the file descriptor representing the fence
        /// payload.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetFenceFdKHR(
            VkDevice device,
            /*-const-*/ VkFenceGetFdInfoKHR* pGetFdInfo,
            int* pFd);
        // Command: 217
        /// <summary>vkGetFenceStatus - Return the status of a fence
        /// </summary>
        /// <param name="device"> device is the logical device that owns the fence.</param>
        /// <param name="fence"> fence is the handle of the fence to query.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetFenceStatus(
            VkDevice device,
            VkFence fence);
        // Command: 218
        /// <summary>vkGetFenceWin32HandleKHR - Get a Windows HANDLE for a fence
        /// </summary>
        /// <param name="device"> device is the logical device that created the fence being
        /// exported.</param>
        /// <param name="pGetWin32HandleInfo"> pGetWin32HandleInfo is a pointer to an instance of the
        /// VkFenceGetWin32HandleInfoKHR structure containing parameters of
        /// the export operation.</param>
        /// <param name="pHandle"> pHandle will return the Windows handle representing the fence
        /// state.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetFenceWin32HandleKHR(
            VkDevice device,
            /*-const-*/ VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo,
            HANDLE* pHandle);
        // Command: 219
        /// <summary>vkGetImageDrmFormatModifierPropertiesEXT - Returns an image’s DRM format modifier
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image.</param>
        /// <param name="image"> image is the queried image.</param>
        /// <param name="pProperties"> pProperties will return properties of the image’s DRM format
        /// modifier.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT(
            VkDevice device,
            VkImage image,
            VkImageDrmFormatModifierPropertiesEXT* pProperties);
        // Command: 220
        /// <summary>vkGetImageMemoryRequirements - Returns the memory requirements for specified Vulkan object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image.</param>
        /// <param name="image"> image is the image to query.</param>
        /// <param name="pMemoryRequirements"> pMemoryRequirements points to an instance of the
        /// VkMemoryRequirements structure in which the memory requirements of
        /// the image object are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements(
            VkDevice device,
            VkImage image,
            VkMemoryRequirements* pMemoryRequirements);
        // Command: 221
        /// <summary>vkGetImageMemoryRequirements2 - Returns the memory requirements for specified Vulkan object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image.</param>
        /// <param name="pInfo"> pInfo is a pointer to an instance of the
        /// VkImageMemoryRequirementsInfo2 structure containing parameters
        /// required for the memory requirements query.</param>
        /// <param name="pMemoryRequirements"> pMemoryRequirements points to an instance of the
        /// VkMemoryRequirements2 structure in which the memory requirements
        /// of the image object are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements2(
            VkDevice device,
            /*-const-*/ VkImageMemoryRequirementsInfo2* pInfo,
            VkMemoryRequirements2* pMemoryRequirements);
        // Command: 222
        /// <summary>vkGetImageSparseMemoryRequirements - Query the memory requirements for a sparse image
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image.</param>
        /// <param name="image"> image is the VkImage object to get the memory requirements
        /// for.</param>
        /// <param name="pSparseMemoryRequirementCount"> pSparseMemoryRequirementCount is a pointer to an integer related
        /// to the number of sparse memory requirements available or queried, as
        /// described below.</param>
        /// <param name="pSparseMemoryRequirements"> pSparseMemoryRequirements is either NULL or a pointer to an
        /// array of VkSparseImageMemoryRequirements structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements(
            VkDevice device,
            VkImage image,
            UInt32* pSparseMemoryRequirementCount,
            VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
        // Command: 223
        /// <summary>vkGetImageSparseMemoryRequirements2 - Query the memory requirements for a sparse image
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image.</param>
        /// <param name="pInfo"> pInfo is a pointer to an instance of the
        /// VkImageSparseMemoryRequirementsInfo2 structure containing
        /// parameters required for the memory requirements query.</param>
        /// <param name="pSparseMemoryRequirementCount"> pSparseMemoryRequirementCount is a pointer to an integer related
        /// to the number of sparse memory requirements available or queried, as
        /// described below.</param>
        /// <param name="pSparseMemoryRequirements"> pSparseMemoryRequirements is either NULL or a pointer to an
        /// array of VkSparseImageMemoryRequirements2 structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements2(
            VkDevice device,
            /*-const-*/ VkImageSparseMemoryRequirementsInfo2* pInfo,
            UInt32* pSparseMemoryRequirementCount,
            VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
        // Command: 224
        /// <summary>vkGetImageSubresourceLayout - Retrieve information about an image subresource
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image.</param>
        /// <param name="image"> image is the image whose layout is being queried.</param>
        /// <param name="pSubresource"> pSubresource is a pointer to a VkImageSubresource structure
        /// selecting a specific image for the image subresource.</param>
        /// <param name="pLayout"> pLayout points to a VkSubresourceLayout structure in which
        /// the layout is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSubresourceLayout(
            VkDevice device,
            VkImage image,
            /*-const-*/ VkImageSubresource* pSubresource,
            VkSubresourceLayout* pLayout);
        // Command: 225
        /// <summary>vkGetImageViewHandleNVX - Get the handle for an image view for a specific descriptor type
        /// </summary>
        /// <param name="device"> device is the logical device that owns the image view.</param>
        /// <param name="pInfo"> pInfo describes the image view to query and type of handle.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern uint32_t vkGetImageViewHandleNVX(
            VkDevice device,
            /*-const-*/ VkImageViewHandleInfoNVX* pInfo);
        // Command: 226
        /// <summary>vkGetInstanceProcAddr - Return a function pointer for a command
        /// </summary>
        /// <param name="instance"> instance is the instance that the function pointer will be
        /// compatible with, or NULL for commands not dependent on any instance.</param>
        /// <param name="pName"> pName is the name of the command to obtain.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern PFN_vkVoidFunction vkGetInstanceProcAddr(
            VkInstance instance,
            IntPtr pName);
        // Command: 227
        /// <summary>vkGetMemoryAndroidHardwareBufferANDROID - Get an Android hardware buffer for a memory object
        /// </summary>
        /// <param name="device"> device is the logical device that created the device memory being
        /// exported.</param>
        /// <param name="pInfo"> pInfo is a pointer to an instance of the
        /// VkMemoryGetAndroidHardwareBufferInfoANDROID structure containing
        /// parameters of the export operation.</param>
        /// <param name="pBuffer"> pBuffer will return an Android hardware buffer representing the
        /// underlying resources of the device memory object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID(
            VkDevice device,
            /*-const-*/ VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo,
            /* struct */ AHardwareBuffer** pBuffer);
        // Command: 228
        /// <summary>vkGetMemoryFdKHR - Get a POSIX file descriptor for a memory object
        /// </summary>
        /// <param name="device"> device is the logical device that created the device memory being
        /// exported.</param>
        /// <param name="pGetFdInfo"> pGetFdInfo is a pointer to an instance of the
        /// VkMemoryGetFdInfoKHR structure containing parameters of the export
        /// operation.</param>
        /// <param name="pFd"> pFd will return a file descriptor representing the underlying
        /// resources of the device memory object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryFdKHR(
            VkDevice device,
            /*-const-*/ VkMemoryGetFdInfoKHR* pGetFdInfo,
            int* pFd);
        // Command: 229
        /// <summary>vkGetMemoryFdPropertiesKHR - Get Properties of External Memory File Descriptors
        /// </summary>
        /// <param name="device"> device is the logical device that will be importing fd.</param>
        /// <param name="handleType"> handleType is the type of the handle fd.</param>
        /// <param name="fd"> fd is the handle which will be imported.</param>
        /// <param name="pMemoryFdProperties"> pMemoryFdProperties is a pointer to a
        /// VkMemoryFdPropertiesKHR structure in which the properties of the
        /// handle fd are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryFdPropertiesKHR(
            VkDevice device,
            VkExternalMemoryHandleTypeFlagBits handleType,
            int fd,
            VkMemoryFdPropertiesKHR* pMemoryFdProperties);
        // Command: 230
        /// <summary>vkGetMemoryHostPointerPropertiesEXT - Get properties of external memory host pointer
        /// </summary>
        /// <param name="device"> device is the logical device that will be importing
        /// pHostPointer.</param>
        /// <param name="handleType"> handleType is the type of the handle pHostPointer.</param>
        /// <param name="pHostPointer"> pHostPointer is the host pointer to import from.</param>
        /// <param name="pMemoryHostPointerProperties"> pMemoryHostPointerProperties is a pointer to a
        /// VkMemoryHostPointerPropertiesEXT structure in which the host
        /// pointer properties are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryHostPointerPropertiesEXT(
            VkDevice device,
            VkExternalMemoryHandleTypeFlagBits handleType,
            /*-const-*/ void* pHostPointer,
            VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);
        // Command: 231
        /// <summary>vkGetMemoryWin32HandleKHR - Get a Windows HANDLE for a memory object
        /// </summary>
        /// <param name="device"> device is the logical device that created the device memory being
        /// exported.</param>
        /// <param name="pGetWin32HandleInfo"> pGetWin32HandleInfo is a pointer to an instance of the
        /// VkMemoryGetWin32HandleInfoKHR structure containing parameters of
        /// the export operation.</param>
        /// <param name="pHandle"> pHandle will return the Windows handle representing the underlying
        /// resources of the device memory object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryWin32HandleKHR(
            VkDevice device,
            /*-const-*/ VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo,
            HANDLE* pHandle);
        // Command: 232
        /// <summary>vkGetMemoryWin32HandleNV - retrieve Win32 handle to a device memory object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="memory"> memory is the VkDeviceMemory object.</param>
        /// <param name="handleType"> handleType is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBitsNV containing a single bit
        /// specifying the type of handle requested.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryWin32HandleNV(
            VkDevice device,
            VkDeviceMemory memory,
            VkExternalMemoryHandleTypeFlagsNV handleType,
            HANDLE* pHandle);
        // Command: 233
        /// <summary>vkGetMemoryWin32HandlePropertiesKHR - Get Properties of External Memory Win32 Handles
        /// </summary>
        /// <param name="device"> device is the logical device that will be importing handle.</param>
        /// <param name="handleType"> handleType is the type of the handle handle.</param>
        /// <param name="handle"> handle is the handle which will be imported.</param>
        /// <param name="pMemoryWin32HandleProperties"> pMemoryWin32HandleProperties will return properties of
        /// handle.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryWin32HandlePropertiesKHR(
            VkDevice device,
            VkExternalMemoryHandleTypeFlagBits handleType,
            HANDLE handle,
            VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
        // Command: 234
        /// <summary>vkGetPastPresentationTimingGOOGLE - Obtain timing of a previously-presented image
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to obtain presentation timing
        /// information duration for.</param>
        /// <param name="pPresentationTimingCount"> pPresentationTimingCount is a pointer to an integer related to the
        /// number of VkPastPresentationTimingGOOGLE structures to query, as
        /// described below.</param>
        /// <param name="pPresentationTimings"> pPresentationTimings is either NULL or a pointer to an array of
        /// VkPastPresentationTimingGOOGLE structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPastPresentationTimingGOOGLE(
            VkDevice device,
            VkSwapchainKHR swapchain,
            UInt32* pPresentationTimingCount,
            VkPastPresentationTimingGOOGLE* pPresentationTimings);
        // Command: 235
        /// <summary>vkGetPhysicalDeviceCalibrateableTimeDomainsEXT - Query calibrateable time domains
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the set
        /// of calibrateable time domains.</param>
        /// <param name="pTimeDomainCount"> pTimeDomainCount is a pointer to an integer related to the number
        /// of calibrateable time domains available or queried, as described below.</param>
        /// <param name="pTimeDomains"> pTimeDomains is either NULL or a pointer to an array of
        /// VkTimeDomainEXT values, indicating the supported calibrateable
        /// time domains.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(
            VkPhysicalDevice physicalDevice,
            UInt32* pTimeDomainCount,
            VkTimeDomainEXT* pTimeDomains);
        // Command: 236
        /// <summary>vkGetPhysicalDeviceCooperativeMatrixPropertiesNV - Returns properties describing what cooperative matrix types are supported
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// cooperative matrix properties available or queried.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkCooperativeMatrixPropertiesNV structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(
            VkPhysicalDevice physicalDevice,
            UInt32* pPropertyCount,
            VkCooperativeMatrixPropertiesNV* pProperties);
        // Command: 237
        /// <summary>vkGetPhysicalDeviceDisplayPlaneProperties2KHR - Query information about the available display planes.
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is a physical device.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// display planes available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkDisplayPlaneProperties2KHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(
            VkPhysicalDevice physicalDevice,
            UInt32* pPropertyCount,
            VkDisplayPlaneProperties2KHR* pProperties);
        // Command: 238
        /// <summary>vkGetPhysicalDeviceDisplayPlanePropertiesKHR - Query the plane properties
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is a physical device.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// display planes available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkDisplayPlanePropertiesKHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(
            VkPhysicalDevice physicalDevice,
            UInt32* pPropertyCount,
            VkDisplayPlanePropertiesKHR* pProperties);
        // Command: 239
        /// <summary>vkGetPhysicalDeviceDisplayProperties2KHR - Query information about the available displays
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is a physical device.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// display devices available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkDisplayProperties2KHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR(
            VkPhysicalDevice physicalDevice,
            UInt32* pPropertyCount,
            VkDisplayProperties2KHR* pProperties);
        // Command: 240
        /// <summary>vkGetPhysicalDeviceDisplayPropertiesKHR - Query information about the available displays
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is a physical device.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// display devices available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkDisplayPropertiesKHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(
            VkPhysicalDevice physicalDevice,
            UInt32* pPropertyCount,
            VkDisplayPropertiesKHR* pProperties);
        // Command: 241
        /// <summary>vkGetPhysicalDeviceExternalBufferProperties - Query external handle types supported by buffers
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// buffer capabilities.</param>
        /// <param name="pExternalBufferInfo"> pExternalBufferInfo points to an instance of the
        /// VkPhysicalDeviceExternalBufferInfo structure, describing the
        /// parameters that would be consumed by vkCreateBuffer.</param>
        /// <param name="pExternalBufferProperties"> pExternalBufferProperties points to an instance of the
        /// VkExternalBufferProperties structure in which capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalBufferProperties(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
            VkExternalBufferProperties* pExternalBufferProperties);
        // Command: 242
        /// <summary>vkGetPhysicalDeviceExternalFenceProperties - Function for querying external fence handle capabilities.
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// fence capabilities.</param>
        /// <param name="pExternalFenceInfo"> pExternalFenceInfo points to an instance of the
        /// VkPhysicalDeviceExternalFenceInfo structure, describing the
        /// parameters that would be consumed by vkCreateFence.</param>
        /// <param name="pExternalFenceProperties"> pExternalFenceProperties points to an instance of the
        /// VkExternalFenceProperties structure in which capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalFenceProperties(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
            VkExternalFenceProperties* pExternalFenceProperties);
        // Command: 243
        /// <summary>vkGetPhysicalDeviceExternalImageFormatPropertiesNV - determine image capabilities compatible with external memory handle types
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// image capabilities</param>
        /// <param name="format"> format is the image format, corresponding to
        /// VkImageCreateInfo::format.</param>
        /// <param name="type"> type is the image type, corresponding to
        /// VkImageCreateInfo::imageType.</param>
        /// <param name="tiling"> tiling is the image tiling, corresponding to
        /// VkImageCreateInfo::tiling.</param>
        /// <param name="usage"> usage is the intended usage of the image, corresponding to
        /// VkImageCreateInfo::usage.</param>
        /// <param name="flags"> flags is a bitmask describing additional parameters of the image,
        /// corresponding to VkImageCreateInfo::flags.</param>
        /// <param name="externalHandleType"> externalHandleType is either one of the bits from
        /// VkExternalMemoryHandleTypeFlagBitsNV, or 0.</param>
        /// <param name="pExternalImageFormatProperties"> pExternalImageFormatProperties points to an instance of the
        /// VkExternalImageFormatPropertiesNV structure in which capabilities
        /// are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(
            VkPhysicalDevice physicalDevice,
            VkFormat format,
            VkImageType type,
            VkImageTiling tiling,
            VkImageUsageFlags usage,
            VkImageCreateFlags flags,
            VkExternalMemoryHandleTypeFlagsNV externalHandleType,
            VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);
        // Command: 244
        /// <summary>vkGetPhysicalDeviceExternalSemaphoreProperties - Function for querying external semaphore handle capabilities.
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// semaphore capabilities.</param>
        /// <param name="pExternalSemaphoreInfo"> pExternalSemaphoreInfo points to an instance of the
        /// VkPhysicalDeviceExternalSemaphoreInfo structure, describing the
        /// parameters that would be consumed by vkCreateSemaphore.</param>
        /// <param name="pExternalSemaphoreProperties"> pExternalSemaphoreProperties points to an instance of the
        /// VkExternalSemaphoreProperties structure in which capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphoreProperties(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
            VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
        // Command: 245
        /// <summary>vkGetPhysicalDeviceFeatures - Reports capabilities of a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// supported features.</param>
        /// <param name="pFeatures"> pFeatures is a pointer to a VkPhysicalDeviceFeatures
        /// structure in which the physical device features are returned.
        /// For each feature, a value of VK_TRUE specifies that the feature is
        /// supported on this physical device, and VK_FALSE specifies that the
        /// feature is not supported.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceFeatures* pFeatures);
        // Command: 246
        /// <summary>vkGetPhysicalDeviceFeatures2 - Reports capabilities of a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// supported features.</param>
        /// <param name="pFeatures"> pFeatures is a pointer to a VkPhysicalDeviceFeatures2
        /// structure in which the physical device features are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures2(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceFeatures2* pFeatures);
        // Command: 247
        /// <summary>vkGetPhysicalDeviceFormatProperties - Lists physical device’s format capabilities
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// format properties.</param>
        /// <param name="format"> format is the format whose properties are queried.</param>
        /// <param name="pFormatProperties"> pFormatProperties is a pointer to a VkFormatProperties
        /// structure in which physical device properties for format are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties(
            VkPhysicalDevice physicalDevice,
            VkFormat format,
            VkFormatProperties* pFormatProperties);
        // Command: 248
        /// <summary>vkGetPhysicalDeviceFormatProperties2 - Lists physical device’s format capabilities
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// format properties.</param>
        /// <param name="format"> format is the format whose properties are queried.</param>
        /// <param name="pFormatProperties"> pFormatProperties is a pointer to a VkFormatProperties2
        /// structure in which physical device properties for format are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties2(
            VkPhysicalDevice physicalDevice,
            VkFormat format,
            VkFormatProperties2* pFormatProperties);
        // Command: 249
        /// <summary>vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX - Returns device-generated commands related properties of a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the physical device whose
        /// properties will be queried.</param>
        /// <param name="pFeatures"> pFeatures points to an instance of the
        /// VkDeviceGeneratedCommandsFeaturesNVX structure, that will be
        /// filled with returned information.</param>
        /// <param name="pLimits"> pLimits points to an instance of the
        /// VkDeviceGeneratedCommandsLimitsNVX structure, that will be filled
        /// with returned information.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(
            VkPhysicalDevice physicalDevice,
            VkDeviceGeneratedCommandsFeaturesNVX* pFeatures,
            VkDeviceGeneratedCommandsLimitsNVX* pLimits);
        // Command: 250
        /// <summary>vkGetPhysicalDeviceImageFormatProperties - Lists physical device’s image format capabilities
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// image capabilities.</param>
        /// <param name="format"> format is a VkFormat value specifying the image format,
        /// corresponding to VkImageCreateInfo::format.</param>
        /// <param name="type"> type is a VkImageType value specifying the image type,
        /// corresponding to VkImageCreateInfo::imageType.</param>
        /// <param name="tiling"> tiling is a VkImageTiling value specifying the image tiling,
        /// corresponding to VkImageCreateInfo::tiling.</param>
        /// <param name="usage"> usage is a bitmask of VkImageUsageFlagBits specifying the
        /// intended usage of the image, corresponding to
        /// VkImageCreateInfo::usage.</param>
        /// <param name="flags"> flags is a bitmask of VkImageCreateFlagBits specifying
        /// additional parameters of the image, corresponding to
        /// VkImageCreateInfo::flags.</param>
        /// <param name="pImageFormatProperties"> pImageFormatProperties points to an instance of the
        /// VkImageFormatProperties structure in which capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties(
            VkPhysicalDevice physicalDevice,
            VkFormat format,
            VkImageType type,
            VkImageTiling tiling,
            VkImageUsageFlags usage,
            VkImageCreateFlags flags,
            VkImageFormatProperties* pImageFormatProperties);
        // Command: 251
        /// <summary>vkGetPhysicalDeviceImageFormatProperties2 - Lists physical device’s image format capabilities
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// image capabilities.</param>
        /// <param name="pImageFormatInfo"> pImageFormatInfo points to an instance of the
        /// VkPhysicalDeviceImageFormatInfo2 structure, describing the
        /// parameters that would be consumed by vkCreateImage.</param>
        /// <param name="pImageFormatProperties"> pImageFormatProperties points to an instance of the
        /// VkImageFormatProperties2 structure in which capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo,
            VkImageFormatProperties2* pImageFormatProperties);
        // Command: 252
        /// <summary>vkGetPhysicalDeviceMemoryProperties - Reports memory information for the specified physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the device to query.</param>
        /// <param name="pMemoryProperties"> pMemoryProperties points to an instance of
        /// VkPhysicalDeviceMemoryProperties structure in which the properties
        /// are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceMemoryProperties* pMemoryProperties);
        // Command: 253
        /// <summary>vkGetPhysicalDeviceMemoryProperties2 - Reports memory information for the specified physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the device to query.</param>
        /// <param name="pMemoryProperties"> pMemoryProperties points to an instance of
        /// VkPhysicalDeviceMemoryProperties2 structure in which the
        /// properties are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
        // Command: 254
        /// <summary>vkGetPhysicalDeviceMultisamplePropertiesEXT - Report sample count specific multisampling capabilities of a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// additional multisampling capabilities.</param>
        /// <param name="samples"> samples is the sample count to query the capabilities for.</param>
        /// <param name="pMultisampleProperties"> pMultisampleProperties is a pointer to a structure of type
        /// VkMultisamplePropertiesEXT, in which information about the
        /// additional multisampling capabilities specific to the sample count is
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT(
            VkPhysicalDevice physicalDevice,
            VkSampleCountFlagBits samples,
            VkMultisamplePropertiesEXT* pMultisampleProperties);
        // Command: 255
        /// <summary>vkGetPhysicalDevicePresentRectanglesKHR - Query present rectangles for a surface on a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="surface"> surface is the surface.</param>
        /// <param name="pRectCount"> pRectCount is a pointer to an integer related to the number of
        /// rectangles available or queried, as described below.</param>
        /// <param name="pRects"> pRects is either NULL or a pointer to an array of VkRect2D
        /// structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDevicePresentRectanglesKHR(
            VkPhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            UInt32* pRectCount,
            VkRect2D* pRects);
        // Command: 256
        /// <summary>vkGetPhysicalDeviceProperties - Returns properties of a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the physical device whose
        /// properties will be queried.</param>
        /// <param name="pProperties"> pProperties points to an instance of the
        /// VkPhysicalDeviceProperties structure, that will be filled with
        /// returned information.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceProperties* pProperties);
        // Command: 257
        /// <summary>vkGetPhysicalDeviceProperties2 - Returns properties of a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the physical device whose
        /// properties will be queried.</param>
        /// <param name="pProperties"> pProperties points to an instance of the
        /// VkPhysicalDeviceProperties2 structure, that will be filled with
        /// returned information.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties2(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceProperties2* pProperties);
        // Command: 258
        /// <summary>vkGetPhysicalDeviceQueueFamilyProperties - Reports properties of the queues of the specified physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the physical device whose
        /// properties will be queried.</param>
        /// <param name="pQueueFamilyPropertyCount"> pQueueFamilyPropertyCount is a pointer to an integer related to
        /// the number of queue families available or queried, as described below.</param>
        /// <param name="pQueueFamilyProperties"> pQueueFamilyProperties is either NULL or a pointer to an array
        /// of VkQueueFamilyProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties(
            VkPhysicalDevice physicalDevice,
            UInt32* pQueueFamilyPropertyCount,
            VkQueueFamilyProperties* pQueueFamilyProperties);
        // Command: 259
        /// <summary>vkGetPhysicalDeviceQueueFamilyProperties2 - Reports properties of the queues of the specified physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the handle to the physical device whose
        /// properties will be queried.</param>
        /// <param name="pQueueFamilyPropertyCount"> pQueueFamilyPropertyCount is a pointer to an integer related to
        /// the number of queue families available or queried, as described in
        /// vkGetPhysicalDeviceQueueFamilyProperties.</param>
        /// <param name="pQueueFamilyProperties"> pQueueFamilyProperties is either NULL or a pointer to an array
        /// of VkQueueFamilyProperties2 structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2(
            VkPhysicalDevice physicalDevice,
            UInt32* pQueueFamilyPropertyCount,
            VkQueueFamilyProperties2* pQueueFamilyProperties);
        // Command: 260
        /// <summary>vkGetPhysicalDeviceSparseImageFormatProperties - Retrieve properties of an image format applied to sparse images
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// sparse image capabilities.</param>
        /// <param name="format"> format is the image format.</param>
        /// <param name="type"> type is the dimensionality of image.</param>
        /// <param name="samples"> samples is the number of samples per texel as defined in
        /// VkSampleCountFlagBits.</param>
        /// <param name="usage"> usage is a bitmask describing the intended usage of the image.</param>
        /// <param name="tiling"> tiling is the tiling arrangement of the texel blocks in memory.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// sparse format properties available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkSparseImageFormatProperties structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(
            VkPhysicalDevice physicalDevice,
            VkFormat format,
            VkImageType type,
            VkSampleCountFlagBits samples,
            VkImageUsageFlags usage,
            VkImageTiling tiling,
            UInt32* pPropertyCount,
            VkSparseImageFormatProperties* pProperties);
        // Command: 261
        /// <summary>vkGetPhysicalDeviceSparseImageFormatProperties2 - Retrieve properties of an image format applied to sparse images
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device from which to query the
        /// sparse image capabilities.</param>
        /// <param name="pFormatInfo"> pFormatInfo is a pointer to a structure of type
        /// VkPhysicalDeviceSparseImageFormatInfo2 containing input parameters
        /// to the command.</param>
        /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of
        /// sparse format properties available or queried, as described below.</param>
        /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of
        /// VkSparseImageFormatProperties2 structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
            UInt32* pPropertyCount,
            VkSparseImageFormatProperties2* pProperties);
        // Command: 262
        /// <summary>vkGetPhysicalDeviceSurfaceCapabilities2EXT - Query surface capabilities
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="surface"> surface is the surface that will be associated with the swapchain.</param>
        /// <param name="pSurfaceCapabilities"> pSurfaceCapabilities is a pointer to an instance of the
        /// VkSurfaceCapabilities2EXT structure in which the capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(
            VkPhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            VkSurfaceCapabilities2EXT* pSurfaceCapabilities);
        // Command: 263
        /// <summary>vkGetPhysicalDeviceSurfaceCapabilities2KHR - Reports capabilities of a surface on a physical device
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="pSurfaceInfo"> pSurfaceInfo points to an instance of the
        /// VkPhysicalDeviceSurfaceInfo2KHR structure, describing the surface
        /// and other fixed parameters that would be consumed by
        /// vkCreateSwapchainKHR.</param>
        /// <param name="pSurfaceCapabilities"> pSurfaceCapabilities points to an instance of the
        /// VkSurfaceCapabilities2KHR structure in which the capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            VkSurfaceCapabilities2KHR* pSurfaceCapabilities);
        // Command: 264
        /// <summary>vkGetPhysicalDeviceSurfaceCapabilitiesKHR - Query surface capabilities
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="surface"> surface is the surface that will be associated with the swapchain.</param>
        /// <param name="pSurfaceCapabilities"> pSurfaceCapabilities is a pointer to an instance of the
        /// VkSurfaceCapabilitiesKHR structure in which the capabilities are
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(
            VkPhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);
        // Command: 265
        /// <summary>vkGetPhysicalDeviceSurfaceFormats2KHR - Query color formats supported by surface
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="pSurfaceInfo"> pSurfaceInfo points to an instance of the
        /// VkPhysicalDeviceSurfaceInfo2KHR structure, describing the surface
        /// and other fixed parameters that would be consumed by
        /// vkCreateSwapchainKHR.</param>
        /// <param name="pSurfaceFormatCount"> pSurfaceFormatCount is a pointer to an integer related to the
        /// number of format tuples available or queried, as described below.</param>
        /// <param name="pSurfaceFormats"> pSurfaceFormats is either NULL or a pointer to an array of
        /// VkSurfaceFormat2KHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            UInt32* pSurfaceFormatCount,
            VkSurfaceFormat2KHR* pSurfaceFormats);
        // Command: 266
        /// <summary>vkGetPhysicalDeviceSurfaceFormatsKHR - Query color formats supported by surface
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="surface"> surface is the surface that will be associated with the swapchain.</param>
        /// <param name="pSurfaceFormatCount"> pSurfaceFormatCount is a pointer to an integer related to the
        /// number of format pairs available or queried, as described below.</param>
        /// <param name="pSurfaceFormats"> pSurfaceFormats is either NULL or a pointer to an array of
        /// VkSurfaceFormatKHR structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(
            VkPhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            UInt32* pSurfaceFormatCount,
            VkSurfaceFormatKHR* pSurfaceFormats);
        // Command: 267
        /// <summary>vkGetPhysicalDeviceSurfacePresentModes2EXT - Query supported presentation modes
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="pSurfaceInfo"> pSurfaceInfo points to an instance of the
        /// VkPhysicalDeviceSurfaceInfo2KHR structure, describing the surface
        /// and other fixed parameters that would be consumed by
        /// vkCreateSwapchainKHR.</param>
        /// <param name="pPresentModeCount"> pPresentModeCount is a pointer to an integer related to the number
        /// of presentation modes available or queried, as described below.</param>
        /// <param name="pPresentModes"> pPresentModes is either NULL or a pointer to an array of
        /// VkPresentModeKHR values, indicating the supported presentation
        /// modes.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(
            VkPhysicalDevice physicalDevice,
            /*-const-*/ VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            UInt32* pPresentModeCount,
            VkPresentModeKHR* pPresentModes);
        // Command: 268
        /// <summary>vkGetPhysicalDeviceSurfacePresentModesKHR - Query supported presentation modes
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device that will be associated with
        /// the swapchain to be created, as described for
        /// vkCreateSwapchainKHR.</param>
        /// <param name="surface"> surface is the surface that will be associated with the swapchain.</param>
        /// <param name="pPresentModeCount"> pPresentModeCount is a pointer to an integer related to the number
        /// of presentation modes available or queried, as described below.</param>
        /// <param name="pPresentModes"> pPresentModes is either NULL or a pointer to an array of
        /// VkPresentModeKHR values, indicating the supported presentation
        /// modes.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(
            VkPhysicalDevice physicalDevice,
            VkSurfaceKHR surface,
            UInt32* pPresentModeCount,
            VkPresentModeKHR* pPresentModes);
        // Command: 269
        /// <summary>vkGetPhysicalDeviceSurfaceSupportKHR - Query if presentation is supported
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the queue family.</param>
        /// <param name="surface"> surface is the surface.</param>
        /// <param name="pSupported"> pSupported is a pointer to a VkBool32, which is set to
        /// VK_TRUE to indicate support, and VK_FALSE otherwise.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR(
            VkPhysicalDevice physicalDevice,
            UInt32 queueFamilyIndex,
            VkSurfaceKHR surface,
            VkBool32* pSupported);
        // Command: 270
        /// <summary>vkGetPhysicalDeviceWaylandPresentationSupportKHR - Query physical device for presentation to Wayland
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the queue family index.</param>
        /// <param name="display"> display is a pointer to the wl_display associated with a
        /// Wayland compositor.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(
            VkPhysicalDevice physicalDevice,
            UInt32 queueFamilyIndex,
            /* struct */ wl_display* display);
        // Command: 271
        /// <summary>vkGetPhysicalDeviceWin32PresentationSupportKHR - query queue family support for presentation on a Win32 display
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the queue family index.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(
            VkPhysicalDevice physicalDevice,
            UInt32 queueFamilyIndex);
        // Command: 272
        /// <summary>vkGetPhysicalDeviceXcbPresentationSupportKHR - Query physical device for presentation to X11 server using XCB
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the queue family index.</param>
        /// <param name="connection"> connection is a pointer to an xcb_connection_t to the X
        /// server.
        /// visual_id is an X11 visual (xcb_visualid_t).</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(
            VkPhysicalDevice physicalDevice,
            UInt32 queueFamilyIndex,
            xcb_connection_t* connection,
            xcb_visualid_t visual_id);
        // Command: 273
        /// <summary>vkGetPhysicalDeviceXlibPresentationSupportKHR - Query physical device for presentation to X11 server using Xlib
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice is the physical device.</param>
        /// <param name="queueFamilyIndex"> queueFamilyIndex is the queue family index.</param>
        /// <param name="dpy"> dpy is a pointer to an Xlib Display connection to the server.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(
            VkPhysicalDevice physicalDevice,
            UInt32 queueFamilyIndex,
            Display* dpy,
            VisualID visualID);
        // Command: 274
        /// <summary>vkGetPipelineCacheData - Get the data store from a pipeline cache
        /// </summary>
        /// <param name="device"> device is the logical device that owns the pipeline cache.</param>
        /// <param name="pipelineCache"> pipelineCache is the pipeline cache to retrieve data from.</param>
        /// <param name="pDataSize"> pDataSize is a pointer to a value related to the amount of data in
        /// the pipeline cache, as described below.</param>
        /// <param name="pData"> pData is either NULL or a pointer to a buffer.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPipelineCacheData(
            VkDevice device,
            VkPipelineCache pipelineCache,
            size_t* pDataSize,
            void* pData);
        // Command: 275
        /// <summary>vkGetQueryPoolResults - Copy results of queries in a query pool to a host memory region
        /// </summary>
        /// <param name="device"> device is the logical device that owns the query pool.</param>
        /// <param name="queryPool"> queryPool is the query pool managing the queries containing the
        /// desired results.</param>
        /// <param name="firstQuery"> firstQuery is the initial query index.</param>
        /// <param name="queryCount"> queryCount is the number of queries.
        /// firstQuery and queryCount together define a range of
        /// queries.
        /// For pipeline statistics queries, each query index in the pool contains
        /// one integer value for each bit that is enabled in
        /// VkQueryPoolCreateInfo::pipelineStatistics when the pool is
        /// created.</param>
        /// <param name="dataSize"> dataSize is the size in bytes of the buffer pointed to by
        /// pData.</param>
        /// <param name="pData"> pData is a pointer to a user-allocated buffer where the results
        /// will be written</param>
        /// <param name="stride"> stride is the stride in bytes between results for individual
        /// queries within pData.</param>
        /// <param name="flags"> flags is a bitmask of VkQueryResultFlagBits specifying how
        /// and when results are returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetQueryPoolResults(
            VkDevice device,
            VkQueryPool queryPool,
            UInt32 firstQuery,
            UInt32 queryCount,
            Int32 dataSize,
            void* pData,
            VkDeviceSize stride,
            VkQueryResultFlags flags);
        // Command: 276
        /// <summary>vkGetQueueCheckpointDataNV - retrieve diagnostic checkpoint data
        /// </summary>
        /// <param name="queue"> queue is the VkQueue object the caller would like to
        /// retrieve checkpoint data for</param>
        /// <param name="pCheckpointDataCount"> pCheckpointDataCount is a pointer to an integer related to the
        /// number of checkpoint markers available or queried, as described below.</param>
        /// <param name="pCheckpointData"> pCheckpointData is either NULL or a pointer to an array of
        /// VkCheckpointDataNV structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetQueueCheckpointDataNV(
            VkQueue queue,
            UInt32* pCheckpointDataCount,
            VkCheckpointDataNV* pCheckpointData);
        // Command: 277
        /// <summary>vkGetRandROutputDisplayEXT - Query the VkDisplayKHR corresponding to an X11 RandR Output
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice The physical device to query the display handle on.</param>
        /// <param name="dpy"> dpy A connection to the X11 server from which rrOutput was
        /// queried.</param>
        /// <param name="rrOutput"> rrOutput An X11 RandR output ID.</param>
        /// <param name="pDisplay"> pDisplay The corresponding VkDisplayKHR handle will be
        /// returned here.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetRandROutputDisplayEXT(
            VkPhysicalDevice physicalDevice,
            Display* dpy,
            RROutput rrOutput,
            VkDisplayKHR* pDisplay);
        // Command: 278
        /// <summary>vkGetRayTracingShaderGroupHandlesNV - Query ray tracing pipeline shader group handles
        /// </summary>
        /// <param name="device"> device is the logical device that contains the ray tracing
        /// pipeline.</param>
        /// <param name="pipeline"> pipeline is the ray tracing pipeline object that contains the
        /// shaders.</param>
        /// <param name="firstGroup"> firstGroup is the index of the first group to retrieve a handle
        /// for from the VkRayTracingShaderGroupCreateInfoNV::pGroups
        /// array.</param>
        /// <param name="groupCount"> groupCount is the number of shader handles to retrieve.</param>
        /// <param name="dataSize"> dataSize is the size in bytes of the buffer pointed to by
        /// pData.</param>
        /// <param name="pData"> pData is a pointer to a user-allocated buffer where the results
        /// will be written.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesNV(
            VkDevice device,
            VkPipeline pipeline,
            UInt32 firstGroup,
            UInt32 groupCount,
            Int32 dataSize,
            void* pData);
        // Command: 279
        /// <summary>vkGetRefreshCycleDurationGOOGLE - Obtain the RC duration of the PE’s display
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to obtain the refresh duration for.</param>
        /// <param name="pDisplayTimingProperties"> pDisplayTimingProperties is a pointer to an instance of the
        /// VkRefreshCycleDurationGOOGLE structure.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetRefreshCycleDurationGOOGLE(
            VkDevice device,
            VkSwapchainKHR swapchain,
            VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);
        // Command: 280
        /// <summary>vkGetRenderAreaGranularity - Returns the granularity for optimal render area
        /// </summary>
        /// <param name="device"> device is the logical device that owns the render pass.</param>
        /// <param name="renderPass"> renderPass is a handle to a render pass.</param>
        /// <param name="pGranularity"> pGranularity points to a VkExtent2D structure in which the
        /// granularity is returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRenderAreaGranularity(
            VkDevice device,
            VkRenderPass renderPass,
            VkExtent2D* pGranularity);
        // Command: 281
        /// <summary>vkGetSemaphoreFdKHR - Get a POSIX file descriptor handle for a semaphore
        /// </summary>
        /// <param name="device"> device is the logical device that created the semaphore being
        /// exported.</param>
        /// <param name="pGetFdInfo"> pGetFdInfo is a pointer to an instance of the
        /// VkSemaphoreGetFdInfoKHR structure containing parameters of the
        /// export operation.</param>
        /// <param name="pFd"> pFd will return the file descriptor representing the semaphore
        /// payload.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSemaphoreFdKHR(
            VkDevice device,
            /*-const-*/ VkSemaphoreGetFdInfoKHR* pGetFdInfo,
            int* pFd);
        // Command: 282
        /// <summary>vkGetSemaphoreWin32HandleKHR - Get a Windows HANDLE for a semaphore
        /// </summary>
        /// <param name="device"> device is the logical device that created the semaphore being
        /// exported.</param>
        /// <param name="pGetWin32HandleInfo"> pGetWin32HandleInfo is a pointer to an instance of the
        /// VkSemaphoreGetWin32HandleInfoKHR structure containing parameters
        /// of the export operation.</param>
        /// <param name="pHandle"> pHandle will return the Windows handle representing the semaphore
        /// state.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSemaphoreWin32HandleKHR(
            VkDevice device,
            /*-const-*/ VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo,
            HANDLE* pHandle);
        // Command: 283
        /// <summary>vkGetShaderInfoAMD - Get information about a shader in a pipeline
        /// </summary>
        /// <param name="device"> device is the device that created pipeline.</param>
        /// <param name="pipeline"> pipeline is the target of the query.</param>
        /// <param name="shaderStage"> shaderStage identifies the particular shader within the pipeline
        /// about which information is being queried.</param>
        /// <param name="infoType"> infoType describes what kind of information is being queried.</param>
        /// <param name="pInfoSize"> pInfoSize is a pointer to a value related to the amount of data
        /// the query returns, as described below.</param>
        /// <param name="pInfo"> pInfo is either NULL or a pointer to a buffer.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetShaderInfoAMD(
            VkDevice device,
            VkPipeline pipeline,
            VkShaderStageFlagBits shaderStage,
            VkShaderInfoTypeAMD infoType,
            size_t* pInfoSize,
            void* pInfo);
        // Command: 284
        /// <summary>vkGetSwapchainCounterEXT - Query the current value of a surface counter
        /// </summary>
        /// <param name="device"> device is the VkDevice associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain from which to query the counter value.</param>
        /// <param name="counter"> counter is the counter to query.</param>
        /// <param name="pCounterValue"> pCounterValue will return the current value of the counter.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSwapchainCounterEXT(
            VkDevice device,
            VkSwapchainKHR swapchain,
            VkSurfaceCounterFlagBitsEXT counter,
            UInt64* pCounterValue);
        // Command: 285
        /// <summary>vkGetSwapchainImagesKHR - Obtain the array of presentable images associated with a swapchain
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to query.</param>
        /// <param name="pSwapchainImageCount"> pSwapchainImageCount is a pointer to an integer related to the
        /// number of presentable images available or queried, as described below.</param>
        /// <param name="pSwapchainImages"> pSwapchainImages is either NULL or a pointer to an array of
        /// VkImage handles.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSwapchainImagesKHR(
            VkDevice device,
            VkSwapchainKHR swapchain,
            UInt32* pSwapchainImageCount,
            VkImage* pSwapchainImages);
        // Command: 286
        /// <summary>vkGetSwapchainStatusKHR - Get a swapchain’s status
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to query.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSwapchainStatusKHR(
            VkDevice device,
            VkSwapchainKHR swapchain);
        // Command: 287
        /// <summary>vkGetValidationCacheDataEXT - Get the data store from a validation cache
        /// </summary>
        /// <param name="device"> device is the logical device that owns the validation cache.</param>
        /// <param name="validationCache"> validationCache is the validation cache to retrieve data from.</param>
        /// <param name="pDataSize"> pDataSize is a pointer to a value related to the amount of data in
        /// the validation cache, as described below.</param>
        /// <param name="pData"> pData is either NULL or a pointer to a buffer.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetValidationCacheDataEXT(
            VkDevice device,
            VkValidationCacheEXT validationCache,
            size_t* pDataSize,
            void* pData);
        // Command: 288
        /// <summary>vkImportFenceFdKHR - Import a fence from a POSIX file descriptor
        /// </summary>
        /// <param name="device"> device is the logical device that created the fence.</param>
        /// <param name="pImportFenceFdInfo"> pImportFenceFdInfo points to a VkImportFenceFdInfoKHR
        /// structure specifying the fence and import parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkImportFenceFdKHR(
            VkDevice device,
            /*-const-*/ VkImportFenceFdInfoKHR* pImportFenceFdInfo);
        // Command: 289
        /// <summary>vkImportFenceWin32HandleKHR - Import a fence from a Windows HANDLE
        /// </summary>
        /// <param name="device"> device is the logical device that created the fence.</param>
        /// <param name="pImportFenceWin32HandleInfo"> pImportFenceWin32HandleInfo points to a
        /// VkImportFenceWin32HandleInfoKHR structure specifying the fence and
        /// import parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkImportFenceWin32HandleKHR(
            VkDevice device,
            /*-const-*/ VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
        // Command: 290
        /// <summary>vkImportSemaphoreFdKHR - Import a semaphore from a POSIX file descriptor
        /// </summary>
        /// <param name="device"> device is the logical device that created the semaphore.</param>
        /// <param name="pImportSemaphoreFdInfo"> pImportSemaphoreFdInfo points to a
        /// VkImportSemaphoreFdInfoKHR structure specifying the semaphore and
        /// import parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkImportSemaphoreFdKHR(
            VkDevice device,
            /*-const-*/ VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);
        // Command: 291
        /// <summary>vkImportSemaphoreWin32HandleKHR - Import a semaphore from a Windows HANDLE
        /// </summary>
        /// <param name="device"> device is the logical device that created the semaphore.</param>
        /// <param name="pImportSemaphoreWin32HandleInfo"> pImportSemaphoreWin32HandleInfo points to a
        /// VkImportSemaphoreWin32HandleInfoKHR structure specifying the
        /// semaphore and import parameters.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkImportSemaphoreWin32HandleKHR(
            VkDevice device,
            /*-const-*/ VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
        // Command: 292
        /// <summary>vkInvalidateMappedMemoryRanges - Invalidate ranges of mapped memory objects
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory ranges.</param>
        /// <param name="memoryRangeCount"> memoryRangeCount is the length of the pMemoryRanges array.</param>
        /// <param name="pMemoryRanges"> pMemoryRanges is a pointer to an array of
        /// VkMappedMemoryRange structures describing the memory ranges to
        /// invalidate.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkInvalidateMappedMemoryRanges(
            VkDevice device,
            UInt32 memoryRangeCount,
            /*-const-*/ VkMappedMemoryRange* pMemoryRanges);
        // Command: 293
        /// <summary>vkMapMemory - Map a memory object into application address space
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="memory"> memory is the VkDeviceMemory object to be mapped.</param>
        /// <param name="offset"> offset is a zero-based byte offset from the beginning of the
        /// memory object.</param>
        /// <param name="size"> size is the size of the memory range to map, or
        /// VK_WHOLE_SIZE to map from offset to the end of the
        /// allocation.</param>
        /// <param name="flags"> flags is reserved for future use.</param>
        /// <param name="ppData"> ppData points to a pointer in which is returned a host-accessible
        /// pointer to the beginning of the mapped range.
        /// This pointer minus offset must be aligned to at least
        /// VkPhysicalDeviceLimits::minMemoryMapAlignment.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkMapMemory(
            VkDevice device,
            VkDeviceMemory memory,
            VkDeviceSize offset,
            VkDeviceSize size,
            VkMemoryMapFlags flags,
            void** ppData);
        // Command: 294
        /// <summary>vkMergePipelineCaches - Combine the data stores of pipeline caches
        /// </summary>
        /// <param name="device"> device is the logical device that owns the pipeline cache objects.</param>
        /// <param name="dstCache"> dstCache is the handle of the pipeline cache to merge results
        /// into.</param>
        /// <param name="srcCacheCount"> srcCacheCount is the length of the pSrcCaches array.</param>
        /// <param name="pSrcCaches"> pSrcCaches is an array of pipeline cache handles, which will be
        /// merged into dstCache.
        /// The previous contents of dstCache are included after the merge.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkMergePipelineCaches(
            VkDevice device,
            VkPipelineCache dstCache,
            UInt32 srcCacheCount,
            /*-const-*/ VkPipelineCache* pSrcCaches);
        // Command: 295
        /// <summary>vkMergeValidationCachesEXT - Combine the data stores of validation caches
        /// </summary>
        /// <param name="device"> device is the logical device that owns the validation cache
        /// objects.</param>
        /// <param name="dstCache"> dstCache is the handle of the validation cache to merge results
        /// into.</param>
        /// <param name="srcCacheCount"> srcCacheCount is the length of the pSrcCaches array.</param>
        /// <param name="pSrcCaches"> pSrcCaches is an array of validation cache handles, which will be
        /// merged into dstCache.
        /// The previous contents of dstCache are included after the merge.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkMergeValidationCachesEXT(
            VkDevice device,
            VkValidationCacheEXT dstCache,
            UInt32 srcCacheCount,
            /*-const-*/ VkValidationCacheEXT* pSrcCaches);
        // Command: 296
        /// <summary>vkQueueBeginDebugUtilsLabelEXT - Open a queue debug label region
        /// </summary>
        /// <param name="queue"> queue is the queue in which to start a debug label region.</param>
        /// <param name="pLabelInfo"> pLabelInfo is a pointer to an instance of the
        /// VkDebugUtilsLabelEXT structure specifying the parameters of the
        /// label region to open.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueBeginDebugUtilsLabelEXT(
            VkQueue queue,
            /*-const-*/ VkDebugUtilsLabelEXT* pLabelInfo);
        // Command: 297
        /// <summary>vkQueueBindSparse - Bind device memory to a sparse resource object
        /// </summary>
        /// <param name="queue"> queue is the queue that the sparse binding operations will be
        /// submitted to.</param>
        /// <param name="bindInfoCount"> bindInfoCount is the number of elements in the pBindInfo
        /// array.</param>
        /// <param name="pBindInfo"> pBindInfo is an array of VkBindSparseInfo structures, each
        /// specifying a sparse binding submission batch.</param>
        /// <param name="fence"> fence is an optional handle to a fence to be signaled.
        /// If fence is not VK_NULL_HANDLE, it defines a
        /// fence signal operation.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueBindSparse(
            VkQueue queue,
            UInt32 bindInfoCount,
            /*-const-*/ VkBindSparseInfo* pBindInfo,
            VkFence fence);
        // Command: 298
        /// <summary>vkQueueEndDebugUtilsLabelEXT - Close a queue debug label region
        /// </summary>
        /// <param name="queue"> queue is the queue in which a debug label region should be closed.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueEndDebugUtilsLabelEXT(
            VkQueue queue);
        // Command: 299
        /// <summary>vkQueueInsertDebugUtilsLabelEXT - Insert a label into a queue
        /// </summary>
        /// <param name="queue"> queue is the queue into which a debug label will be inserted.</param>
        /// <param name="pLabelInfo"> pLabelInfo is a pointer to an instance of the
        /// VkDebugUtilsLabelEXT structure specifying the parameters of the
        /// label to insert.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueInsertDebugUtilsLabelEXT(
            VkQueue queue,
            /*-const-*/ VkDebugUtilsLabelEXT* pLabelInfo);
        // Command: 300
        /// <summary>vkQueuePresentKHR - Queue an image for presentation
        /// </summary>
        /// <param name="queue"> queue is a queue that is capable of presentation to the target
        /// surface’s platform on the same device as the image’s swapchain.</param>
        /// <param name="pPresentInfo"> pPresentInfo is a pointer to an instance of the
        /// VkPresentInfoKHR structure specifying the parameters of the
        /// presentation.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueuePresentKHR(
            VkQueue queue,
            /*-const-*/ VkPresentInfoKHR* pPresentInfo);
        // Command: 301
        /// <summary>vkQueueSubmit - Submits a sequence of semaphores or command buffers to a queue
        /// </summary>
        /// <param name="queue"> queue is the queue that the command buffers will be submitted to.</param>
        /// <param name="submitCount"> submitCount is the number of elements in the pSubmits array.</param>
        /// <param name="pSubmits"> pSubmits is a pointer to an array of VkSubmitInfo
        /// structures, each specifying a command buffer submission batch.</param>
        /// <param name="fence"> fence is an optional handle to a fence to be signaled once all
        /// submitted command buffers have completed execution.
        /// If fence is not VK_NULL_HANDLE, it defines a
        /// fence signal operation.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueSubmit(
            VkQueue queue,
            UInt32 submitCount,
            /*-const-*/ VkSubmitInfo* pSubmits,
            VkFence fence);
        // Command: 302
        /// <summary>vkQueueWaitIdle - Wait for a queue to become idle
        /// </summary>
        /// <param name="queue"> queue is the queue on which to wait.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueWaitIdle(
            VkQueue queue);
        // Command: 303
        /// <summary>vkRegisterDeviceEventEXT - Signal a fence when a device event occurs
        /// </summary>
        /// <param name="device"> device is a logical device on which the event may occur.</param>
        /// <param name="pDeviceEventInfo"> pDeviceEventInfo is a pointer to an instance of the
        /// VkDeviceEventInfoEXT structure describing the event of interest to
        /// the application.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pFence"> pFence points to a handle in which the resulting fence object is
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkRegisterDeviceEventEXT(
            VkDevice device,
            /*-const-*/ VkDeviceEventInfoEXT* pDeviceEventInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkFence* pFence);
        // Command: 304
        /// <summary>vkRegisterDisplayEventEXT - Signal a fence when a display event occurs
        /// </summary>
        /// <param name="device"> device is a logical device associated with display </param>
        /// <param name="display"> display is the display on which the event may occur.</param>
        /// <param name="pDisplayEventInfo"> pDisplayEventInfo is a pointer to an instance of the
        /// VkDisplayEventInfoEXT structure describing the event of interest
        /// to the application.</param>
        /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the
        /// Memory Allocation chapter.</param>
        /// <param name="pFence"> pFence points to a handle in which the resulting fence object is
        /// returned.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkRegisterDisplayEventEXT(
            VkDevice device,
            VkDisplayKHR display,
            /*-const-*/ VkDisplayEventInfoEXT* pDisplayEventInfo,
            /*-const-*/ VkAllocationCallbacks* pAllocator,
            VkFence* pFence);
        // Command: 305
        /// <summary>vkRegisterObjectsNVX - Register resource bindings in an object table
        /// </summary>
        /// <param name="device"> device is the logical device that creates the object table.</param>
        /// <param name="objectTable"> objectTable is the table for which the resources are registered.</param>
        /// <param name="objectCount"> objectCount is the number of resources to register.</param>
        /// <param name="ppObjectTableEntries"> ppObjectTableEntries provides an array for detailed binding
        /// informations, each array element is a pointer to a struct of type
        /// VkObjectTablePipelineEntryNVX,
        /// VkObjectTableDescriptorSetEntryNVX,
        /// VkObjectTableVertexBufferEntryNVX,
        /// VkObjectTableIndexBufferEntryNVX or
        /// VkObjectTablePushConstantEntryNVX (see below for details).</param>
        /// <param name="pObjectIndices"> pObjectIndices are the indices at which each resource is
        /// registered.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkRegisterObjectsNVX(
            VkDevice device,
            VkObjectTableNVX _objectTable,
            UInt32 _objectCount,
            /*-const-*/ VkObjectTableEntryNVX* /*-const-*/ * ppObjectTableEntries,
            /*-const-*/ UInt32* pObjectIndices);
        // Command: 306
        /// <summary>vkReleaseDisplayEXT - Release access to an acquired VkDisplayKHR
        /// </summary>
        /// <param name="physicalDevice"> physicalDevice The physical device the display is on.</param>
        /// <param name="display"> display The display to release control of.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkReleaseDisplayEXT(
            VkPhysicalDevice physicalDevice,
            VkDisplayKHR display);
        // Command: 307
        /// <summary>vkReleaseFullScreenExclusiveModeEXT - Release full-screen exclusive mode from a swapchain
        /// </summary>
        /// <param name="device"> device is the device associated with swapchain.</param>
        /// <param name="swapchain"> swapchain is the swapchain to release exclusive full-screen access
        /// from.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkReleaseFullScreenExclusiveModeEXT(
            VkDevice device,
            VkSwapchainKHR swapchain);
        // Command: 308
        /// <summary>vkResetCommandBuffer - Reset a command buffer to the initial state
        /// </summary>
        /// <param name="commandBuffer"> commandBuffer is the command buffer to reset.
        /// The command buffer can be in any state other than
        /// pending, and is moved into the
        /// initial state.</param>
        /// <param name="flags"> flags is a bitmask of VkCommandBufferResetFlagBits
        /// controlling the reset operation.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetCommandBuffer(
            VkCommandBuffer commandBuffer,
            VkCommandBufferResetFlags flags);
        // Command: 309
        /// <summary>vkResetCommandPool - Reset a command pool
        /// </summary>
        /// <param name="device"> device is the logical device that owns the command pool.</param>
        /// <param name="commandPool"> commandPool is the command pool to reset.</param>
        /// <param name="flags"> flags is a bitmask of VkCommandPoolResetFlagBits controlling
        /// the reset operation.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetCommandPool(
            VkDevice device,
            VkCommandPool commandPool,
            VkCommandPoolResetFlags flags);
        // Command: 310
        /// <summary>vkResetDescriptorPool - Resets a descriptor pool object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the descriptor pool.</param>
        /// <param name="descriptorPool"> descriptorPool is the descriptor pool to be reset.</param>
        /// <param name="flags"> flags is reserved for future use.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetDescriptorPool(
            VkDevice device,
            VkDescriptorPool descriptorPool,
            VkDescriptorPoolResetFlags flags);
        // Command: 311
        /// <summary>vkResetEvent - Reset an event to non-signaled state
        /// </summary>
        /// <param name="device"> device is the logical device that owns the event.</param>
        /// <param name="event"> event is the event to reset.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetEvent(
            VkDevice device,
            VkEvent _event);
        // Command: 312
        /// <summary>vkResetFences - Resets one or more fence objects
        /// </summary>
        /// <param name="device"> device is the logical device that owns the fences.</param>
        /// <param name="fenceCount"> fenceCount is the number of fences to reset.</param>
        /// <param name="pFences"> pFences is a pointer to an array of fence handles to reset.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetFences(
            VkDevice device,
            UInt32 fenceCount,
            /*-const-*/ VkFence* pFences);
        // Command: 313
        /// <summary>vkResetQueryPoolEXT - Reset queries in a query pool
        /// </summary>
        /// <param name="queryPool"> queryPool is the handle of the query pool managing the queries
        /// being reset.</param>
        /// <param name="firstQuery"> firstQuery is the initial query index to reset.</param>
        /// <param name="queryCount"> queryCount is the number of queries to reset.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetQueryPoolEXT(
            VkDevice device,
            VkQueryPool queryPool,
            UInt32 firstQuery,
            UInt32 queryCount);
        // Command: 314
        /// <summary>vkSetDebugUtilsObjectNameEXT - Give a user-friendly name to an object
        /// </summary>
        /// <param name="device"> device is the device that created the object.</param>
        /// <param name="pNameInfo"> pNameInfo is a pointer to an instance of the
        /// VkDebugUtilsObjectNameInfoEXT structure specifying the parameters
        /// of the name to set on the object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkSetDebugUtilsObjectNameEXT(
            VkDevice device,
            /*-const-*/ VkDebugUtilsObjectNameInfoEXT* pNameInfo);
        // Command: 315
        /// <summary>vkSetDebugUtilsObjectTagEXT - Attach arbitrary data to an object
        /// </summary>
        /// <param name="device"> device is the device that created the object.</param>
        /// <param name="pTagInfo"> pTagInfo is a pointer to an instance of the
        /// VkDebugUtilsObjectTagInfoEXT structure specifying the parameters
        /// of the tag to attach to the object.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkSetDebugUtilsObjectTagEXT(
            VkDevice device,
            /*-const-*/ VkDebugUtilsObjectTagInfoEXT* pTagInfo);
        // Command: 316
        /// <summary>vkSetEvent - Set an event to signaled state
        /// </summary>
        /// <param name="device"> device is the logical device that owns the event.</param>
        /// <param name="event"> event is the event to set.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkSetEvent(
            VkDevice device,
            VkEvent _event);
        // Command: 317
        /// <summary>vkSetHdrMetadataEXT - function to set Hdr metadata
        /// </summary>
        /// <param name="device"> device is the logical device where the swapchain(s) were created.</param>
        /// <param name="swapchainCount"> swapchainCount is the number of swapchains included in
        /// pSwapchains.</param>
        /// <param name="pSwapchains"> pSwapchains is a pointer to the array of swapchainCount VkSwapchainKHR handles.</param>
        /// <param name="pMetadata"> pMetadata is a pointer to the array of swapchainCount VkHdrMetadataEXT structures.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetHdrMetadataEXT(
            VkDevice device,
            UInt32 swapchainCount,
            /*-const-*/ VkSwapchainKHR* pSwapchains,
            /*-const-*/ VkHdrMetadataEXT* pMetadata);
        // Command: 318
        /// <summary>vkSetLocalDimmingAMD - Set Local Dimming
        /// </summary>
        /// <param name="device"> device is the device associated with swapChain.</param>
        /// <param name="swapChain"> swapChain handle to enable local dimming.</param>
        /// <param name="localDimmingEnable"> localDimmingEnable specifies whether local dimming is enabled for
        /// the swapchain.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetLocalDimmingAMD(
            VkDevice device,
            VkSwapchainKHR swapChain,
            VkBool32 localDimmingEnable);
        // Command: 319
        /// <summary>vkSubmitDebugUtilsMessageEXT - Inject a message into a debug stream
        /// </summary>
        /// <param name="instance"> instance is the debug stream’s VkInstance.</param>
        /// <param name="messageSeverity"> messageSeverity is the
        /// VkDebugUtilsMessageSeverityFlagBitsEXT severity of this
        /// event/message.</param>
        /// <param name="messageTypes"> messageTypes is a bitmask of
        /// VkDebugUtilsMessageTypeFlagBitsEXT specifying which type of
        /// event(s) to identify with this message.</param>
        /// <param name="pCallbackData"> pCallbackData contains all the callback related data in the
        /// VkDebugUtilsMessengerCallbackDataEXT structure.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSubmitDebugUtilsMessageEXT(
            VkInstance instance,
            VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT messageTypes,
            /*-const-*/ VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
        // Command: 320
        /// <summary>vkTrimCommandPool - Trim a command pool
        /// </summary>
        /// <param name="device"> device is the logical device that owns the command pool.</param>
        /// <param name="commandPool"> commandPool is the command pool to trim.</param>
        /// <param name="flags"> flags is reserved for future use.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkTrimCommandPool(
            VkDevice device,
            VkCommandPool commandPool,
            VkCommandPoolTrimFlags flags);
        // Command: 321
        /// <summary>vkUnmapMemory - Unmap a previously mapped memory object
        /// </summary>
        /// <param name="device"> device is the logical device that owns the memory.</param>
        /// <param name="memory"> memory is the memory object to be unmapped.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory(
            VkDevice device,
            VkDeviceMemory memory);
        // Command: 322
        /// <summary>vkUnregisterObjectsNVX - Unregister resource bindings in an object table
        /// </summary>
        /// <param name="device"> device is the logical device that creates the object table.</param>
        /// <param name="objectTable"> objectTable is the table from which the resources are
        /// unregistered.</param>
        /// <param name="objectCount"> objectCount is the number of resources being removed from the
        /// object table.</param>
        /// <param name="pObjectIndices"> pObjectIndices provides the array of object indices to be removed.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkUnregisterObjectsNVX(
            VkDevice device,
            VkObjectTableNVX _objectTable,
            UInt32 _objectCount,
            /*-const-*/ VkObjectEntryTypeNVX* pObjectEntryTypes,
            /*-const-*/ UInt32* pObjectIndices);
        // Command: 323
        /// <summary>vkUpdateDescriptorSetWithTemplate - Update the contents of a descriptor set object using an update template
        /// </summary>
        /// <param name="device"> device is the logical device that updates the descriptor sets.</param>
        /// <param name="descriptorSet"> descriptorSet is the descriptor set to update</param>
        /// <param name="descriptorUpdateTemplate"> descriptorUpdateTemplate is the VkDescriptorUpdateTemplate
        /// which specifies the update mapping between pData and the
        /// descriptor set to update.</param>
        /// <param name="pData"> pData is a pointer to memory which contains one or more structures
        /// of VkDescriptorImageInfo, VkDescriptorBufferInfo, or
        /// VkBufferView used to write the descriptors.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSetWithTemplate(
            VkDevice device,
            VkDescriptorSet descriptorSet,
            VkDescriptorUpdateTemplate descriptorUpdateTemplate,
            /*-const-*/ void* pData);
        // Command: 324
        /// <summary>vkUpdateDescriptorSets - Update the contents of a descriptor set object
        /// </summary>
        /// <param name="device"> device is the logical device that updates the descriptor sets.</param>
        /// <param name="descriptorWriteCount"> descriptorWriteCount is the number of elements in the
        /// pDescriptorWrites array.</param>
        /// <param name="pDescriptorWrites"> pDescriptorWrites is a pointer to an array of
        /// VkWriteDescriptorSet structures describing the descriptor sets to
        /// write to.</param>
        /// <param name="descriptorCopyCount"> descriptorCopyCount is the number of elements in the
        /// pDescriptorCopies array.</param>
        /// <param name="pDescriptorCopies"> pDescriptorCopies is a pointer to an array of
        /// VkCopyDescriptorSet structures describing the descriptor sets to
        /// copy between.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets(
            VkDevice device,
            UInt32 descriptorWriteCount,
            /*-const-*/ VkWriteDescriptorSet* pDescriptorWrites,
            UInt32 descriptorCopyCount,
            /*-const-*/ VkCopyDescriptorSet* pDescriptorCopies);
        // Command: 325
        /// <summary>vkWaitForFences - Wait for one or more fences to become signaled
        /// </summary>
        /// <param name="device"> device is the logical device that owns the fences.</param>
        /// <param name="fenceCount"> fenceCount is the number of fences to wait on.</param>
        /// <param name="pFences"> pFences is a pointer to an array of fenceCount fence
        /// handles.</param>
        /// <param name="waitAll"> waitAll is the condition that must be satisfied to successfully
        /// unblock the wait.
        /// If waitAll is VK_TRUE, then the condition is that all fences
        /// in pFences are signaled.
        /// Otherwise, the condition is that at least one fence in pFences is
        /// signaled.</param>
        /// <param name="timeout"> timeout is the timeout period in units of nanoseconds.
        /// timeout is adjusted to the closest value allowed by the
        /// implementation-dependent timeout accuracy, which may be substantially
        /// longer than one nanosecond, and may be longer than the requested
        /// period.</param>
        [DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkWaitForFences(
            VkDevice device,
            UInt32 fenceCount,
            /*-const-*/ VkFence* pFences,
            VkBool32 waitAll,
            UInt64 timeout);

    }
}

