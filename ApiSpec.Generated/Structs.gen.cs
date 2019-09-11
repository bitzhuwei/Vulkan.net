using System;

namespace ApiSpec.Generated {
    // Struct: 0
    /// <summary>VkAccelerationStructureCreateInfoNV - Structure specifying the parameters of a newly created acceleration structure object
    /// </summary>
    public unsafe struct VkAccelerationStructureCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> compactedSize is the size from the result of
        /// vkCmdWriteAccelerationStructuresPropertiesNV if this acceleration
        /// structure is going to be the target of a compacting copy.</summary>
        public VkDeviceSize compactedSize;
        /// <summary> info is the VkAccelerationStructureInfoNV structure that
        /// specifies further parameters of the created acceleration structure.</summary>
        public VkAccelerationStructureInfoNV info;
    }
    // Struct: 1
    /// <summary>VkAccelerationStructureInfoNV - Structure specifying the parameters of acceleration structure object
    /// </summary>
    public unsafe struct VkAccelerationStructureInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> type is a VkAccelerationStructureTypeNV value specifying the
        /// type of acceleration structure that will be created.</summary>
        public VkAccelerationStructureTypeNV type;
        /// <summary> flags is a bitmask of VkBuildAccelerationStructureFlagBitsNV
        /// specifying additional parameters of the acceleration structure.</summary>
        public VkBuildAccelerationStructureFlagsNV flags;
        /// <summary> instanceCount specifies the number of instances that will be in
        /// the new acceleration structure.</summary>
        public UInt32 instanceCount;
        /// <summary> geometryCount specifies the number of geometries that will be in
        /// the new acceleration structure.</summary>
        public UInt32 geometryCount;
        /// <summary> pGeometries is an array of VkGeometryNV structures, which
        /// contain the scene data being passed into the acceleration structure.</summary>
        public /*-const-*/ VkGeometryNV* pGeometries;
    }
    // Struct: 2
    /// <summary>VkAccelerationStructureMemoryRequirementsInfoNV - Structure specifying acceleration to query for memory requirements
    /// </summary>
    public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> type selects the type of memory requirement being queried.
        /// VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV
        /// returns the memory requirements for the object itself.
        /// VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV
        /// returns the memory requirements for the scratch memory when doing a
        /// build.
        /// VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV
        /// returns the memory requirements for the scratch memory when doing an
        /// update.</summary>
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        /// <summary> accelerationStructure is the acceleration structure to be queried
        /// for memory requirements.</summary>
        public VkAccelerationStructureNV accelerationStructure;
    }
    // Struct: 3
    /// <summary>VkAcquireNextImageInfoKHR - Structure specifying parameters of the acquire
    /// </summary>
    public unsafe struct VkAcquireNextImageInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> swapchain is a non-retired swapchain from which an image is
        /// acquired.</summary>
        public VkSwapchainKHR swapchain;
        /// <summary> timeout specifies how long the function waits, in nanoseconds, if
        /// no image is available.</summary>
        public UInt64 timeout;
        /// <summary> semaphore is VK_NULL_HANDLE or a semaphore to signal.</summary>
        public VkSemaphore semaphore;
        /// <summary> fence is VK_NULL_HANDLE or a fence to signal.</summary>
        public VkFence fence;
        /// <summary> deviceMask is a mask of physical devices for which the swapchain
        /// image will be ready to use when the semaphore or fence is signaled.</summary>
        public UInt32 deviceMask;
    }
    // Struct: 4
    /// <summary>VkAllocationCallbacks - Structure containing callback function pointers for memory allocation
    /// </summary>
    public unsafe struct VkAllocationCallbacks {
        /// <summary> pUserData is a value to be interpreted by the implementation of
        /// the callbacks.
        /// When any of the callbacks in VkAllocationCallbacks are called, the
        /// Vulkan implementation will pass this value as the first parameter to the
        /// callback.
        /// This value can vary each time an allocator is passed into a command,
        /// even when the same object takes an allocator in multiple commands.</summary>
        public void* pUserData;
        /// <summary> pfnAllocation is a pointer to an application-defined memory
        /// allocation function of type PFN_vkAllocationFunction.</summary>
        public PFN_vkAllocationFunction pfnAllocation;
        /// <summary> pfnReallocation is a pointer to an application-defined memory
        /// reallocation function of type PFN_vkReallocationFunction.</summary>
        public PFN_vkReallocationFunction pfnReallocation;
        /// <summary> pfnFree is a pointer to an application-defined memory free
        /// function of type PFN_vkFreeFunction.</summary>
        public PFN_vkFreeFunction pfnFree;
        /// <summary> pfnInternalAllocation is a pointer to an application-defined
        /// function that is called by the implementation when the implementation
        /// makes internal allocations, and it is of type
        /// PFN_vkInternalAllocationNotification.</summary>
        public PFN_vkInternalAllocationNotification pfnInternalAllocation;
        /// <summary> pfnInternalFree is a pointer to an application-defined function
        /// that is called by the implementation when the implementation frees
        /// internal allocations, and it is of type
        /// PFN_vkInternalFreeNotification.</summary>
        public PFN_vkInternalFreeNotification pfnInternalFree;
    }
    // Struct: 5
    /// <summary>VkAndroidHardwareBufferFormatPropertiesANDROID - Structure describing the image format properties of an Android hardware buffer
    /// </summary>
    public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> format is the Vulkan format corresponding to the Android hardware
        /// buffer’s format, or VK_FORMAT_UNDEFINED if there is not an
        /// equivalent Vulkan format.</summary>
        public VkFormat format;
        /// <summary> externalFormat is an implementation-defined external format
        /// identifier for use with VkExternalFormatANDROID.
        /// It must not be zero.</summary>
        public UInt64 externalFormat;
        /// <summary> formatFeatures describes the capabilities of this external format
        /// when used with an image bound to memory imported from buffer.</summary>
        public VkFormatFeatureFlags formatFeatures;
        /// <summary> samplerYcbcrConversionComponents is the component swizzle that
        /// should be used in VkSamplerYcbcrConversionCreateInfo.</summary>
        public VkComponentMapping samplerYcbcrConversionComponents;
        /// <summary> suggestedYcbcrModel is a suggested color model to use in the
        /// VkSamplerYcbcrConversionCreateInfo.</summary>
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        /// <summary> suggestedYcbcrRange is a suggested numerical value range to use in
        /// VkSamplerYcbcrConversionCreateInfo.</summary>
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        /// <summary> suggestedXChromaOffset is a suggested X chroma offset to use in
        /// VkSamplerYcbcrConversionCreateInfo.</summary>
        public VkChromaLocation suggestedXChromaOffset;
        /// <summary> suggestedYChromaOffset is a suggested Y chroma offset to use in
        /// VkSamplerYcbcrConversionCreateInfo.</summary>
        public VkChromaLocation suggestedYChromaOffset;
    }
    // Struct: 6
    /// <summary>VkAndroidHardwareBufferPropertiesANDROID - Properties of External Memory Android Hardware Buffers
    /// </summary>
    public unsafe struct VkAndroidHardwareBufferPropertiesANDROID {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> allocationSize is the size of the external memory</summary>
        public VkDeviceSize allocationSize;
        /// <summary> memoryTypeBits is a bitmask containing one bit set for every
        /// memory type which the specified Android hardware buffer can be imported
        /// as.</summary>
        public UInt32 memoryTypeBits;
    }
    // Struct: 7
    /// <summary>VkAndroidHardwareBufferUsageANDROID - Struct containing Android hardware buffer usage flags
    /// </summary>
    public unsafe struct VkAndroidHardwareBufferUsageANDROID {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> androidHardwareBufferUsage returns the Android hardware buffer
        /// usage flags.</summary>
        public UInt64 androidHardwareBufferUsage;
    }
    // Struct: 8
    /// <summary>VkAndroidSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Android surface object
    /// </summary>
    public unsafe struct VkAndroidSurfaceCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkAndroidSurfaceCreateFlagsKHR flags;
        /// <summary> window is a pointer to the ANativeWindow to associate the
        /// surface with.</summary>
        public /*-struct-*/ ANativeWindow* window;
    }
    // Struct: 9
    /// <summary>VkApplicationInfo - Structure specifying application info
    /// </summary>
    public unsafe struct VkApplicationInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pApplicationName is NULL or is a pointer to a null-terminated
        /// UTF-8 string containing the name of the application.</summary>
        public IntPtr pApplicationName;
        /// <summary> applicationVersion is an unsigned integer variable containing the
        /// developer-supplied version number of the application.</summary>
        public UInt32 applicationVersion;
        /// <summary> pEngineName is NULL or is a pointer to a null-terminated UTF-8
        /// string containing the name of the engine (if any) used to create the
        /// application.</summary>
        public IntPtr pEngineName;
        /// <summary> engineVersion is an unsigned integer variable containing the
        /// developer-supplied version number of the engine used to create the
        /// application.</summary>
        public UInt32 engineVersion;
        /// <summary> apiVersion
        ///   must be the highest version of Vulkan that the
        /// application is designed to use, encoded as described in
        /// html/vkspec.html#extendingvulkan-coreversions-versionnumbers.
        /// The patch version number specified in apiVersion is ignored when
        /// creating an instance object.
        /// Only the major and minor versions of the instance must match those
        /// requested in apiVersion.</summary>
        public UInt32 apiVersion;
    }
    // Struct: 10
    /// <summary>VkAttachmentDescription - Structure specifying an attachment description
    /// </summary>
    public unsafe struct VkAttachmentDescription {
        /// <summary> flags is a bitmask of VkAttachmentDescriptionFlagBits
        /// specifying additional properties of the attachment.</summary>
        public VkAttachmentDescriptionFlags flags;
        /// <summary> format is a VkFormat value specifying the format of the
        /// image view that will be used for the attachment.</summary>
        public VkFormat format;
        /// <summary> samples is the number of samples of the image as defined in
        /// VkSampleCountFlagBits.</summary>
        public VkSampleCountFlagBits samples;
        /// <summary> loadOp is a VkAttachmentLoadOp value specifying how the
        /// contents of color and depth components of the attachment are treated at
        /// the beginning of the subpass where it is first used.</summary>
        public VkAttachmentLoadOp loadOp;
        /// <summary> storeOp is a VkAttachmentStoreOp value specifying how the
        /// contents of color and depth components of the attachment are treated at
        /// the end of the subpass where it is last used.</summary>
        public VkAttachmentStoreOp storeOp;
        /// <summary> stencilLoadOp is a VkAttachmentLoadOp value specifying how
        /// the contents of stencil components of the attachment are treated at the
        /// beginning of the subpass where it is first used.</summary>
        public VkAttachmentLoadOp stencilLoadOp;
        /// <summary> stencilStoreOp is a VkAttachmentStoreOp value specifying how
        /// the contents of stencil components of the attachment are treated at the
        /// end of the last subpass where it is used.</summary>
        public VkAttachmentStoreOp stencilStoreOp;
        /// <summary> initialLayout is the layout the attachment image subresource will
        /// be in when a render pass instance begins.</summary>
        public VkImageLayout initialLayout;
        /// <summary> finalLayout is the layout the attachment image subresource will be
        /// transitioned to when a render pass instance ends.</summary>
        public VkImageLayout finalLayout;
    }
    // Struct: 11
    /// <summary>VkAttachmentDescription2KHR - Structure specifying an attachment description
    /// </summary>
    public unsafe struct VkAttachmentDescription2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkAttachmentDescriptionFlagBits
        /// specifying additional properties of the attachment.</summary>
        public VkAttachmentDescriptionFlags flags;
        /// <summary> format is a VkFormat value specifying the format of the
        /// image that will be used for the attachment.</summary>
        public VkFormat format;
        /// <summary> samples is the number of samples of the image as defined in
        /// VkSampleCountFlagBits.</summary>
        public VkSampleCountFlagBits samples;
        /// <summary> loadOp is a VkAttachmentLoadOp value specifying how the
        /// contents of color and depth components of the attachment are treated at
        /// the beginning of the subpass where it is first used.</summary>
        public VkAttachmentLoadOp loadOp;
        /// <summary> storeOp is a VkAttachmentStoreOp value specifying how the
        /// contents of color and depth components of the attachment are treated at
        /// the end of the subpass where it is last used.</summary>
        public VkAttachmentStoreOp storeOp;
        /// <summary> stencilLoadOp is a VkAttachmentLoadOp value specifying how
        /// the contents of stencil components of the attachment are treated at the
        /// beginning of the subpass where it is first used.</summary>
        public VkAttachmentLoadOp stencilLoadOp;
        /// <summary> stencilStoreOp is a VkAttachmentStoreOp value specifying how
        /// the contents of stencil components of the attachment are treated at the
        /// end of the last subpass where it is used.</summary>
        public VkAttachmentStoreOp stencilStoreOp;
        /// <summary> initialLayout is the layout the attachment image subresource will
        /// be in when a render pass instance begins.</summary>
        public VkImageLayout initialLayout;
        /// <summary> finalLayout is the layout the attachment image subresource will be
        /// transitioned to when a render pass instance ends.</summary>
        public VkImageLayout finalLayout;
    }
    // Struct: 12
    /// <summary>VkAttachmentReference - Structure specifying an attachment reference
    /// </summary>
    public unsafe struct VkAttachmentReference {
        /// <summary> attachment is either an integer value identifying an attachment at
        /// the corresponding index in
        /// VkRenderPassCreateInfo::pAttachments, or
        /// VK_ATTACHMENT_UNUSED to signify that this attachment is not used.</summary>
        public UInt32 attachment;
        /// <summary> layout is a VkImageLayout value specifying the layout the
        /// attachment uses during the subpass.</summary>
        public VkImageLayout layout;
    }
    // Struct: 13
    /// <summary>VkAttachmentReference2KHR - Structure specifying an attachment reference
    /// </summary>
    public unsafe struct VkAttachmentReference2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> attachment is either an integer value identifying an attachment at
        /// the corresponding index in
        /// VkRenderPassCreateInfo::pAttachments, or
        /// VK_ATTACHMENT_UNUSED to signify that this attachment is not used.</summary>
        public UInt32 attachment;
        /// <summary> layout is a VkImageLayout value specifying the layout the
        /// attachment uses during the subpass.</summary>
        public VkImageLayout layout;
        /// <summary> aspectMask is a mask of which aspect(s) can be accessed within
        /// the specified subpass as an input attachment.</summary>
        public VkImageAspectFlags aspectMask;
    }
    // Struct: 14
    /// <summary>VkAttachmentSampleLocationsEXT - Structure specifying the sample locations state to use in the initial layout transition of attachments
    /// </summary>
    public unsafe struct VkAttachmentSampleLocationsEXT {
        /// <summary> attachmentIndex is the index of the attachment for which the
        /// sample locations state is provided.</summary>
        public UInt32 attachmentIndex;
        /// <summary> sampleLocationsInfo is the sample locations state to use for the
        /// layout transition of the given attachment from the initial layout of the
        /// attachment to the image layout specified for the attachment in the first
        /// subpass using it.</summary>
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }
    // Struct: 15
    /// <summary>VkBaseInStructure - Base structure for a read-only pointer chain
    /// </summary>
    public unsafe struct VkBaseInStructure {
        /// <summary> sType is the structure type of the structure being iterated
        /// through.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to the next structure in a structure
        /// chain.</summary>
        public /*-const-*/ /*-struct-*/ VkBaseInStructure* pNext;
    }
    // Struct: 16
    /// <summary>VkBaseOutStructure - Base structure for a read-only pointer chain
    /// </summary>
    public unsafe struct VkBaseOutStructure {
        /// <summary> sType is the structure type of the structure being iterated
        /// through.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to the next structure in a structure
        /// chain.</summary>
        public /*-struct-*/ VkBaseOutStructure* pNext;
    }
    // Struct: 17
    /// <summary>VkBindAccelerationStructureMemoryInfoNV - Structure specifying acceleration structure memory binding
    /// </summary>
    public unsafe struct VkBindAccelerationStructureMemoryInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> accelerationStructure is the acceleration structure to be attached
        /// to memory.</summary>
        public VkAccelerationStructureNV accelerationStructure;
        /// <summary> memory is a VkDeviceMemory object describing the device
        /// memory to attach.</summary>
        public VkDeviceMemory memory;
        /// <summary> memoryOffset is the start offset of the region of memory that is
        /// to be bound to the acceleration structure.
        /// The number of bytes returned in the
        /// VkMemoryRequirements::size member in memory, starting
        /// from memoryOffset bytes, will be bound to the specified
        /// acceleration structure.</summary>
        public VkDeviceSize memoryOffset;
        /// <summary> deviceIndexCount is the number of elements in
        /// pDeviceIndices.</summary>
        public UInt32 deviceIndexCount;
        /// <summary> pDeviceIndices is a pointer to an array of device indices.</summary>
        public /*-const-*/ UInt32* pDeviceIndices;
    }
    // Struct: 18
    /// <summary>VkBindBufferMemoryDeviceGroupInfo - Structure specifying device within a group to bind to
    /// </summary>
    public unsafe struct VkBindBufferMemoryDeviceGroupInfo {
        public VkStructureType sType;
        /// <summary>If the pNext list of VkBindBufferMemoryInfo includes a
        /// VkBindBufferMemoryDeviceGroupInfo structure, then that structure
        /// determines how memory is bound to buffers across multiple devices in a
        /// device group.</summary>
        public /*-const-*/ void* pNext;
        public UInt32 deviceIndexCount;
        public /*-const-*/ UInt32* pDeviceIndices;
    }
    // Struct: 19
    /// <summary>VkBindBufferMemoryInfo - Structure specifying how to bind a buffer to memory
    /// </summary>
    public unsafe struct VkBindBufferMemoryInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> buffer is the buffer to be attached to memory.</summary>
        public VkBuffer buffer;
        /// <summary> memory is a VkDeviceMemory object describing the device
        /// memory to attach.</summary>
        public VkDeviceMemory memory;
        /// <summary> memoryOffset is the start offset of the region of memory
        /// which is to be bound to the buffer.
        /// The number of bytes returned in the
        /// VkMemoryRequirements::size member in memory, starting
        /// from memoryOffset bytes, will be bound to the specified buffer.</summary>
        public VkDeviceSize memoryOffset;
    }
    // Struct: 20
    /// <summary>VkBindImageMemoryDeviceGroupInfo - Structure specifying device within a group to bind to
    /// </summary>
    public unsafe struct VkBindImageMemoryDeviceGroupInfo {
        public VkStructureType sType;
        /// <summary>If the pNext list of VkBindImageMemoryInfo includes a
        /// VkBindImageMemoryDeviceGroupInfo structure, then that structure
        /// determines how memory is bound to images across multiple devices in a device
        /// group.</summary>
        public /*-const-*/ void* pNext;
        public UInt32 deviceIndexCount;
        public /*-const-*/ UInt32* pDeviceIndices;
        public UInt32 splitInstanceBindRegionCount;
        public /*-const-*/ VkRect2D* pSplitInstanceBindRegions;
    }
    // Struct: 21
    /// <summary>VkBindImageMemoryInfo - Structure specifying how to bind an image to memory
    /// </summary>
    public unsafe struct VkBindImageMemoryInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> image is the image to be attached to memory.</summary>
        public VkImage image;
        /// <summary> memory is a VkDeviceMemory object describing the device
        /// memory to attach.</summary>
        public VkDeviceMemory memory;
        /// <summary> memoryOffset is the start offset of the region of memory
        /// which is to be bound to the image.
        /// The number of bytes returned in the
        /// VkMemoryRequirements::size member in memory, starting
        /// from memoryOffset bytes, will be bound to the specified image.</summary>
        public VkDeviceSize memoryOffset;
    }
    // Struct: 22
    /// <summary>VkBindImageMemorySwapchainInfoKHR - Structure specifying swapchain image memory to bind to
    /// </summary>
    public unsafe struct VkBindImageMemorySwapchainInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> swapchain is VK_NULL_HANDLE or a swapchain handle.</summary>
        public VkSwapchainKHR swapchain;
        /// <summary> imageIndex is an image index within swapchain.</summary>
        public UInt32 imageIndex;
    }
    // Struct: 23
    /// <summary>VkBindImagePlaneMemoryInfo - Structure specifying how to bind an image plane to memory
    /// </summary>
    public unsafe struct VkBindImagePlaneMemoryInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> planeAspect is the aspect of the disjoint image plane to bind.</summary>
        public VkImageAspectFlagBits planeAspect;
    }
    // Struct: 24
    /// <summary>VkBindSparseInfo - Structure specifying a sparse binding operation
    /// </summary>
    public unsafe struct VkBindSparseInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> waitSemaphoreCount is the number of semaphores upon which to wait
        /// before executing the sparse binding operations for the batch.</summary>
        public UInt32 waitSemaphoreCount;
        /// <summary> pWaitSemaphores is a pointer to an array of semaphores upon which
        /// to wait on before the sparse binding operations for this batch begin
        /// execution.
        /// If semaphores to wait on are provided, they define a
        /// semaphore wait operation.</summary>
        public /*-const-*/ VkSemaphore* pWaitSemaphores;
        /// <summary> bufferBindCount is the number of sparse buffer bindings to perform
        /// in the batch.</summary>
        public UInt32 bufferBindCount;
        /// <summary> pBufferBinds is a pointer to an array of
        /// VkSparseBufferMemoryBindInfo structures.</summary>
        public /*-const-*/ VkSparseBufferMemoryBindInfo* pBufferBinds;
        /// <summary> imageOpaqueBindCount is the number of opaque sparse image bindings
        /// to perform.</summary>
        public UInt32 imageOpaqueBindCount;
        /// <summary> pImageOpaqueBinds is a pointer to an array of
        /// VkSparseImageOpaqueMemoryBindInfo structures, indicating opaque
        /// sparse image bindings to perform.</summary>
        public /*-const-*/ VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
        /// <summary> imageBindCount is the number of sparse image bindings to perform.</summary>
        public UInt32 imageBindCount;
        /// <summary> pImageBinds is a pointer to an array of
        /// VkSparseImageMemoryBindInfo structures, indicating sparse image
        /// bindings to perform.</summary>
        public /*-const-*/ VkSparseImageMemoryBindInfo* pImageBinds;
        /// <summary> signalSemaphoreCount is the number of semaphores to be signaled
        /// once the sparse binding operations specified by the structure have
        /// completed execution.</summary>
        public UInt32 signalSemaphoreCount;
        /// <summary> pSignalSemaphores is a pointer to an array of semaphores which
        /// will be signaled when the sparse binding operations for this batch have
        /// completed execution.
        /// If semaphores to be signaled are provided, they define a
        /// semaphore signal operation.</summary>
        public /*-const-*/ VkSemaphore* pSignalSemaphores;
    }
    // Struct: 25
    /// <summary>VkBufferCopy - Structure specifying a buffer copy operation
    /// </summary>
    public unsafe struct VkBufferCopy {
        /// <summary> srcOffset is the starting offset in bytes from the start of
        /// srcBuffer.</summary>
        public VkDeviceSize srcOffset;
        /// <summary> dstOffset is the starting offset in bytes from the start of
        /// dstBuffer.</summary>
        public VkDeviceSize dstOffset;
        /// <summary> size is the number of bytes to copy.</summary>
        public VkDeviceSize size;
    }
    // Struct: 26
    /// <summary>VkBufferCreateInfo - Structure specifying the parameters of a newly created buffer object
    /// </summary>
    public unsafe struct VkBufferCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkBufferCreateFlagBits specifying
        /// additional parameters of the buffer.</summary>
        public VkBufferCreateFlags flags;
        /// <summary> size is the size in bytes of the buffer to be created.</summary>
        public VkDeviceSize size;
        /// <summary> usage is a bitmask of VkBufferUsageFlagBits specifying
        /// allowed usages of the buffer.</summary>
        public VkBufferUsageFlags usage;
        /// <summary> sharingMode is a VkSharingMode value specifying the sharing
        /// mode of the buffer when it will be accessed by multiple queue families.</summary>
        public VkSharingMode sharingMode;
        /// <summary> queueFamilyIndexCount is the number of entries in the
        /// pQueueFamilyIndices array.</summary>
        public UInt32 queueFamilyIndexCount;
        /// <summary> pQueueFamilyIndices is a list of queue families that will access
        /// this buffer (ignored if sharingMode is not
        /// VK_SHARING_MODE_CONCURRENT).</summary>
        public /*-const-*/ UInt32* pQueueFamilyIndices;
    }
    // Struct: 27
    /// <summary>VkBufferDeviceAddressCreateInfoEXT - Request a specific address for a buffer
    /// </summary>
    public unsafe struct VkBufferDeviceAddressCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> deviceAddress is the device address requested for the buffer.</summary>
        public VkDeviceAddress deviceAddress;
    }
    // Struct: 28
    /// <summary>VkBufferDeviceAddressInfoEXT - Structure specifying the buffer to query an address for
    /// </summary>
    public unsafe struct VkBufferDeviceAddressInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> buffer specifies the buffer whose address is being queried.</summary>
        public VkBuffer buffer;
    }
    // Struct: 29
    /// <summary>VkBufferImageCopy - Structure specifying a buffer image copy operation
    /// </summary>
    public unsafe struct VkBufferImageCopy {
        /// <summary> bufferOffset is the offset in bytes from the start of the buffer
        /// object where the image data is copied from or to.</summary>
        public VkDeviceSize bufferOffset;
        /// <summary> bufferRowLength and bufferImageHeight specify in texels a
        /// subregion of a larger two- or three-dimensional image in buffer memory,
        /// and control the addressing calculations.
        /// If either of these values is zero, that aspect of the buffer memory is
        /// considered to be tightly packed according to the imageExtent.</summary>
        public UInt32 bufferRowLength;
        public UInt32 bufferImageHeight;
        /// <summary> imageSubresource is a VkImageSubresourceLayers used to
        /// specify the specific image subresources of the image used for the source
        /// or destination image data.</summary>
        public VkImageSubresourceLayers imageSubresource;
        /// <summary> imageOffset selects the initial x, y, z offsets
        /// in texels of the sub-region of the source or destination image data.</summary>
        public VkOffset3D imageOffset;
        /// <summary> imageExtent is the size in texels of the image to copy in
        /// width, height and depth.</summary>
        public VkExtent3D imageExtent;
    }
    // Struct: 30
    /// <summary>VkBufferMemoryBarrier - Structure specifying a buffer memory barrier
    /// </summary>
    public unsafe struct VkBufferMemoryBarrier {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// source access mask.</summary>
        public VkAccessFlags srcAccessMask;
        /// <summary> dstAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// destination access mask.</summary>
        public VkAccessFlags dstAccessMask;
        /// <summary> srcQueueFamilyIndex is the source queue family for a
        /// queue family ownership transfer.</summary>
        public UInt32 srcQueueFamilyIndex;
        /// <summary> dstQueueFamilyIndex is the destination queue family for a
        /// queue family ownership transfer.</summary>
        public UInt32 dstQueueFamilyIndex;
        /// <summary> buffer is a handle to the buffer whose backing memory is affected
        /// by the barrier.</summary>
        public VkBuffer buffer;
        /// <summary> offset is an offset in bytes into the backing memory for
        /// buffer; this is relative to the base offset as bound to the buffer
        /// (see vkBindBufferMemory).</summary>
        public VkDeviceSize offset;
        /// <summary> size is a size in bytes of the affected area of backing memory for
        /// buffer, or VK_WHOLE_SIZE to use the range from offset
        /// to the end of the buffer.</summary>
        public VkDeviceSize size;
    }
    // Struct: 31
    /// <summary>VkBufferMemoryRequirementsInfo2 - (None)
    /// </summary>
    public unsafe struct VkBufferMemoryRequirementsInfo2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> buffer is the buffer to query.</summary>
        public VkBuffer buffer;
    }
    // Struct: 32
    /// <summary>VkBufferViewCreateInfo - Structure specifying parameters of a newly created buffer view
    /// </summary>
    public unsafe struct VkBufferViewCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkBufferViewCreateFlags flags;
        /// <summary> buffer is a VkBuffer on which the view will be created.</summary>
        public VkBuffer buffer;
        /// <summary> format is a VkFormat describing the format of the data
        /// elements in the buffer.</summary>
        public VkFormat format;
        /// <summary> offset is an offset in bytes from the base address of the buffer.
        /// Accesses to the buffer view from shaders use addressing that is relative
        /// to this starting offset.</summary>
        public VkDeviceSize offset;
        /// <summary> range is a size in bytes of the buffer view.
        /// If range is equal to VK_WHOLE_SIZE, the range from
        /// offset to the end of the buffer is used.
        /// If VK_WHOLE_SIZE is used and the remaining size of the buffer is
        /// not a multiple of the texel block size of
        /// format, the nearest smaller multiple is used.</summary>
        public VkDeviceSize range;
    }
    // Struct: 33
    /// <summary>VkCalibratedTimestampInfoEXT - Structure specifying the input parameters of a calibrated timestamp query
    /// </summary>
    public unsafe struct VkCalibratedTimestampInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> timeDomain is a VkTimeDomainEXT value specifying the time
        /// domain from which the calibrated timestamp value should be returned.</summary>
        public VkTimeDomainEXT timeDomain;
    }
    // Struct: 34
    /// <summary>VkCheckpointDataNV - return structure for command buffer checkpoint data
    /// </summary>
    public unsafe struct VkCheckpointDataNV {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> stage indicates which pipeline stage the checkpoint marker data
        /// refers to.</summary>
        public VkPipelineStageFlagBits stage;
        /// <summary> pCheckpointMarker contains the value of the last checkpoint marker
        /// executed in the stage that stage refers to.</summary>
        public void* pCheckpointMarker;
    }
    // Struct: 35
    /// <summary>VkClearAttachment - Structure specifying a clear attachment
    /// </summary>
    public unsafe struct VkClearAttachment {
        /// <summary> aspectMask is a mask selecting the color, depth and/or stencil
        /// aspects of the attachment to be cleared.</summary>
        public VkImageAspectFlags aspectMask;
        /// <summary> colorAttachment is only meaningful if
        /// VK_IMAGE_ASPECT_COLOR_BIT is set in aspectMask, in which
        /// case it is an index to the pColorAttachments array in the
        /// VkSubpassDescription structure of the current subpass which
        /// selects the color attachment to clear.</summary>
        public UInt32 colorAttachment;
        /// <summary> clearValue is the color or depth/stencil value to clear the
        /// attachment to, as described in Clear Values below.</summary>
        public VkClearValue clearValue;
    }
    // Struct: 36
    /// <summary>VkClearColorValue - Structure specifying a clear color value
    /// </summary>
    /*union*/
    [StructLayout(LayoutKind.Explicit)]
    public struct VkClearColorValue {
        [FieldOffset(0)] public fixed float float32[4];
        [FieldOffset(0)] public fixed Int32 int32[4];
        [FieldOffset(0)] public fixed UInt32 uint32[4];
    }
    // Struct: 37
    /// <summary>VkClearDepthStencilValue - Structure specifying a clear depth stencil value
    /// </summary>
    public unsafe struct VkClearDepthStencilValue {
        /// <summary> depth is the clear value for the depth aspect of the depth/stencil
        /// attachment.
        /// It is a floating-point value which is automatically converted to the
        /// attachment’s format.</summary>
        public float depth;
        /// <summary> stencil is the clear value for the stencil aspect of the
        /// depth/stencil attachment.
        /// It is a 32-bit integer value which is converted to the attachment’s
        /// format by taking the appropriate number of LSBs.</summary>
        public UInt32 stencil;
    }
    // Struct: 38
    /// <summary>VkClearRect - Structure specifying a clear rectangle
    /// </summary>
    public unsafe struct VkClearRect {
        /// <summary> rect is the two-dimensional region to be cleared.</summary>
        public VkRect2D rect;
        /// <summary> baseArrayLayer is the first layer to be cleared.</summary>
        public UInt32 baseArrayLayer;
        /// <summary> layerCount is the number of layers to clear.</summary>
        public UInt32 layerCount;
    }
    // Struct: 39
    /// <summary>VkClearValue - Structure specifying a clear value
    /// </summary>
    /*union*/
    [StructLayout(LayoutKind.Explicit)]
    public struct VkClearValue {
        /// <summary> color specifies the color image clear values to use when clearing
        /// a color image or attachment.</summary>
        [FieldOffset(0)] public VkClearColorValue color;
        /// <summary> depthStencil specifies the depth and stencil clear values to use
        /// when clearing a depth/stencil image or attachment.</summary>
        [FieldOffset(0)] public VkClearDepthStencilValue depthStencil;
    }
    // Struct: 40
    /// <summary>VkCmdProcessCommandsInfoNVX - Structure specifying parameters for the generation of commands
    /// </summary>
    public unsafe struct VkCmdProcessCommandsInfoNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectTable is the VkObjectTableNVX to be used for the
        /// generation process.
        /// Only registered objects at the time
        /// vkCmdReserveSpaceForCommandsNVX is called, will be taken into
        /// account for the reservation.</summary>
        public VkObjectTableNVX _objectTable;
        /// <summary> indirectCommandsLayout is the VkIndirectCommandsLayoutNVX
        /// that provides the command sequence to generate.</summary>
        public VkIndirectCommandsLayoutNVX indirectCommandsLayout;
        /// <summary> indirectCommandsTokenCount defines the number of input tokens
        /// used.</summary>
        public UInt32 indirectCommandsTokenCount;
        /// <summary> pIndirectCommandsTokens provides an array of
        /// VkIndirectCommandsTokenNVX that reference the input data for each
        /// token command.</summary>
        public /*-const-*/ VkIndirectCommandsTokenNVX* pIndirectCommandsTokens;
        /// <summary> maxSequencesCount is the maximum number of sequences for which
        /// command buffer space will be reserved.
        /// If sequencesCountBuffer is VK_NULL_HANDLE, this is also the
        /// actual number of sequences generated.</summary>
        public UInt32 maxSequencesCount;
        /// <summary> targetCommandBuffer
        ///   can be the secondary VkCommandBuffer in
        /// which the commands should be recorded.
        /// If targetCommandBuffer is NULL an implicit reservation as well
        /// as execution takes place on the processing VkCommandBuffer.</summary>
        public VkCommandBuffer targetCommandBuffer;
        /// <summary> sequencesCountBuffer
        ///   can be VkBuffer from which the actual
        /// amount of sequences is sourced from as uint32_t value.</summary>
        public VkBuffer sequencesCountBuffer;
        /// <summary> sequencesCountOffset is the byte offset into
        /// sequencesCountBuffer where the count value is stored.</summary>
        public VkDeviceSize sequencesCountOffset;
        /// <summary> sequencesIndexBuffer
        ///   must be set if
        /// indirectCommandsLayout’s
        /// VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX is set
        /// and provides the used sequence indices as uint32_t array.
        /// Otherwise it must be VK_NULL_HANDLE.</summary>
        public VkBuffer sequencesIndexBuffer;
        /// <summary> sequencesIndexOffset is the byte offset into
        /// sequencesIndexBuffer where the index values start.</summary>
        public VkDeviceSize sequencesIndexOffset;
    }
    // Struct: 41
    /// <summary>VkCmdReserveSpaceForCommandsInfoNVX - Structure specifying parameters for the reservation of command buffer space
    /// </summary>
    public unsafe struct VkCmdReserveSpaceForCommandsInfoNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectTable is the VkObjectTableNVX to be used for the
        /// generation process.
        /// Only registered objects at the time
        /// vkCmdReserveSpaceForCommandsNVX is called, will be taken into
        /// account for the reservation.</summary>
        public VkObjectTableNVX _objectTable;
        /// <summary> indirectCommandsLayout is the VkIndirectCommandsLayoutNVX
        /// that must also be used at generation time.</summary>
        public VkIndirectCommandsLayoutNVX indirectCommandsLayout;
        /// <summary> maxSequencesCount is the maximum number of sequences for which
        /// command buffer space will be reserved.</summary>
        public UInt32 maxSequencesCount;
    }
    // Struct: 42
    /// <summary>VkCoarseSampleLocationNV - Structure specifying parameters controlling shading rate image usage
    /// </summary>
    public unsafe struct VkCoarseSampleLocationNV {
        /// <summary> pixelX is added to the x coordinate of the upper-leftmost pixel of
        /// each fragment to identify the pixel containing the coverage sample.</summary>
        public UInt32 pixelX;
        /// <summary> pixelY is added to the y coordinate of the upper-leftmost pixel of
        /// each fragment to identify the pixel containing the coverage sample.</summary>
        public UInt32 pixelY;
        /// <summary> sample is the number of the coverage sample in the pixel
        /// identified by pixelX and pixelY.</summary>
        public UInt32 sample;
    }
    // Struct: 43
    /// <summary>VkCoarseSampleOrderCustomNV - Structure specifying parameters controlling shading rate image usage
    /// </summary>
    public unsafe struct VkCoarseSampleOrderCustomNV {
        /// <summary> shadingRate is a shading rate palette entry that identifies the
        /// fragment width and height for the combination of fragment area and
        /// per-pixel coverage sample count to control.</summary>
        public VkShadingRatePaletteEntryNV shadingRate;
        /// <summary> sampleCount identifies the per-pixel coverage sample count for the
        /// combination of fragment area and coverage sample count to control.</summary>
        public UInt32 sampleCount;
        /// <summary> sampleLocationCount specifies the number of sample locations in
        /// the custom ordering.</summary>
        public UInt32 sampleLocationCount;
        /// <summary> pSampleLocations is a pointer to an array of
        /// VkCoarseSampleOrderCustomNV structures that specifies the location
        /// of each sample in the custom ordering.</summary>
        public /*-const-*/ VkCoarseSampleLocationNV* pSampleLocations;
    }
    // Struct: 44
    /// <summary>VkCommandBufferAllocateInfo - Structure specifying the allocation parameters for command buffer object
    /// </summary>
    public unsafe struct VkCommandBufferAllocateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> commandPool is the command pool from which the command buffers are
        /// allocated.</summary>
        public VkCommandPool commandPool;
        /// <summary> level is a VkCommandBufferLevel value specifying the command
        /// buffer level.</summary>
        public VkCommandBufferLevel level;
        /// <summary> commandBufferCount is the number of command buffers to allocate
        /// from the pool.</summary>
        public UInt32 commandBufferCount;
    }
    // Struct: 45
    /// <summary>VkCommandBufferBeginInfo - Structure specifying a command buffer begin operation
    /// </summary>
    public unsafe struct VkCommandBufferBeginInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkCommandBufferUsageFlagBits
        /// specifying usage behavior for the command buffer.</summary>
        public VkCommandBufferUsageFlags flags;
        /// <summary> pInheritanceInfo is a pointer to a
        /// VkCommandBufferInheritanceInfo structure, which is used if
        /// commandBuffer is a secondary command buffer.
        /// If this is a primary command buffer, then this value is ignored.</summary>
        public /*-const-*/ VkCommandBufferInheritanceInfo* pInheritanceInfo;
    }
    // Struct: 46
    /// <summary>VkCommandBufferInheritanceConditionalRenderingInfoEXT - Structure specifying command buffer inheritance info
    /// </summary>
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure</summary>
        public /*-const-*/ void* pNext;
        /// <summary> conditionalRenderingEnable specifies whether the command buffer
        /// can be executed while conditional rendering is active in the primary
        /// command buffer.
        /// If this is VK_TRUE, then this command buffer can be executed
        /// whether the primary command buffer has active conditional rendering or
        /// not.
        /// If this is VK_FALSE, then the primary command buffer must not
        /// have conditional rendering active.</summary>
        public VkBool32 conditionalRenderingEnable;
    }
    // Struct: 47
    /// <summary>VkCommandBufferInheritanceInfo - Structure specifying command buffer inheritance info
    /// </summary>
    public unsafe struct VkCommandBufferInheritanceInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> renderPass is a VkRenderPass object defining which render
        /// passes the VkCommandBuffer will be compatible with and can be executed within.
        /// If the VkCommandBuffer will not be executed within a render pass
        /// instance, renderPass is ignored.</summary>
        public VkRenderPass renderPass;
        /// <summary> subpass is the index of the subpass within the render pass
        /// instance that the VkCommandBuffer will be executed within.
        /// If the VkCommandBuffer will not be executed within a render pass
        /// instance, subpass is ignored.</summary>
        public UInt32 subpass;
        /// <summary> framebuffer optionally refers to the VkFramebuffer object
        /// that the VkCommandBuffer will be rendering to if it is executed
        /// within a render pass instance.
        /// It can be VK_NULL_HANDLE if the framebuffer is not known, or if
        /// the VkCommandBuffer will not be executed within a render pass
        /// instance.</summary>
        public VkFramebuffer framebuffer;
        /// <summary> occlusionQueryEnable specifies whether the command buffer can be
        /// executed while an occlusion query is active in the primary command
        /// buffer.
        /// If this is VK_TRUE, then this command buffer can be executed
        /// whether the primary command buffer has an occlusion query active or not.
        /// If this is VK_FALSE, then the primary command buffer must not
        /// have an occlusion query active.</summary>
        public VkBool32 occlusionQueryEnable;
        /// <summary> queryFlags specifies the query flags that can be used by an
        /// active occlusion query in the primary command buffer when this secondary
        /// command buffer is executed.
        /// If this value includes the VK_QUERY_CONTROL_PRECISE_BIT bit, then
        /// the active query can return boolean results or actual sample counts.
        /// If this bit is not set, then the active query must not use the
        /// VK_QUERY_CONTROL_PRECISE_BIT bit.</summary>
        public VkQueryControlFlags queryFlags;
        /// <summary> pipelineStatistics is a bitmask of
        /// VkQueryPipelineStatisticFlagBits specifying the set of pipeline
        /// statistics that can be counted by an active query in the primary
        /// command buffer when this secondary command buffer is executed.
        /// If this value includes a given bit, then this command buffer can be
        /// executed whether the primary command buffer has a pipeline statistics
        /// query active that includes this bit or not.
        /// If this value excludes a given bit, then the active pipeline statistics
        /// query must not be from a query pool that counts that statistic.</summary>
        public VkQueryPipelineStatisticFlags pipelineStatistics;
    }
    // Struct: 48
    /// <summary>VkCommandPoolCreateInfo - Structure specifying parameters of a newly created command pool
    /// </summary>
    public unsafe struct VkCommandPoolCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkCommandPoolCreateFlagBits indicating
        /// usage behavior for the pool and command buffers allocated from it.</summary>
        public VkCommandPoolCreateFlags flags;
        /// <summary> queueFamilyIndex designates a queue family as described in section
        /// Queue Family Properties.
        /// All command buffers allocated from this command pool must be submitted
        /// on queues from the same queue family.</summary>
        public UInt32 queueFamilyIndex;
    }
    // Struct: 49
    /// <summary>VkComponentMapping - Structure specifying a color component mapping
    /// </summary>
    public unsafe struct VkComponentMapping {
        /// <summary> r is a VkComponentSwizzle specifying the component value
        /// placed in the R component of the output vector.</summary>
        public VkComponentSwizzle r;
        /// <summary> g is a VkComponentSwizzle specifying the component value
        /// placed in the G component of the output vector.</summary>
        public VkComponentSwizzle g;
        /// <summary> b is a VkComponentSwizzle specifying the component value
        /// placed in the B component of the output vector.</summary>
        public VkComponentSwizzle b;
        /// <summary> a is a VkComponentSwizzle specifying the component value
        /// placed in the A component of the output vector.</summary>
        public VkComponentSwizzle a;
    }
    // Struct: 50
    /// <summary>VkComputePipelineCreateInfo - Structure specifying parameters of a newly created compute pipeline
    /// </summary>
    public unsafe struct VkComputePipelineCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkPipelineCreateFlagBits specifying
        /// how the pipeline will be generated.</summary>
        public VkPipelineCreateFlags flags;
        /// <summary> stage is a VkPipelineShaderStageCreateInfo describing the
        /// compute shader.</summary>
        public VkPipelineShaderStageCreateInfo stage;
        /// <summary> layout is the description of binding locations used by both the
        /// pipeline and descriptor sets used with the pipeline.</summary>
        public VkPipelineLayout layout;
        /// <summary> basePipelineHandle is a pipeline to derive from</summary>
        public VkPipeline basePipelineHandle;
        /// <summary> basePipelineIndex is an index into the pCreateInfos
        /// parameter to use as a pipeline to derive from</summary>
        public Int32 basePipelineIndex;
    }
    // Struct: 51
    /// <summary>VkConditionalRenderingBeginInfoEXT - Structure specifying conditional rendering begin info
    /// </summary>
    public unsafe struct VkConditionalRenderingBeginInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> buffer is a buffer containing the predicate for conditional
        /// rendering.</summary>
        public VkBuffer buffer;
        /// <summary> offset is the byte offset into buffer where the predicate is
        /// located.</summary>
        public VkDeviceSize offset;
        /// <summary> flags is a bitmask of VkConditionalRenderingFlagsEXT
        /// specifying the behavior of conditional rendering.</summary>
        public VkConditionalRenderingFlagsEXT flags;
    }
    // Struct: 52
    /// <summary>VkConformanceVersionKHR - Structure containing the conformance test suite version the implementation is compliant with
    /// </summary>
    public unsafe struct VkConformanceVersionKHR {
        /// <summary> major is the major version number of the conformance test suite.</summary>
        public byte major;
        /// <summary> minor is the minor version number of the conformance test suite.</summary>
        public byte minor;
        /// <summary> subminor is the subminor version number of the conformance test
        /// suite.</summary>
        public byte subminor;
        /// <summary> patch is the patch version number of the conformance test suite.</summary>
        public byte patch;
    }
    // Struct: 53
    /// <summary>VkCooperativeMatrixPropertiesNV - Structure specifying cooperative matrix properties
    /// </summary>
    public unsafe struct VkCooperativeMatrixPropertiesNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> MSize is the number of rows in matrices A, C, and D.</summary>
        public UInt32 MSize;
        /// <summary> NSize is the number of columns in matrices B, C, D.</summary>
        public UInt32 NSize;
        /// <summary> KSize is the number of columns in matrix A and rows in matrix B.</summary>
        public UInt32 KSize;
        /// <summary> AType is the component type of matrix A, of type
        /// VkComponentTypeNV.</summary>
        public VkComponentTypeNV AType;
        /// <summary> BType is the component type of matrix B, of type
        /// VkComponentTypeNV.</summary>
        public VkComponentTypeNV BType;
        /// <summary> CType is the component type of matrix C, of type
        /// VkComponentTypeNV.</summary>
        public VkComponentTypeNV CType;
        /// <summary> DType is the component type of matrix D, of type
        /// VkComponentTypeNV.</summary>
        public VkComponentTypeNV DType;
        /// <summary> scope is the scope of all the matrix types, of type
        /// VkScopeNV.</summary>
        public VkScopeNV scope;
    }
    // Struct: 54
    /// <summary>VkCopyDescriptorSet - Structure specifying a copy descriptor set operation
    /// </summary>
    public unsafe struct VkCopyDescriptorSet {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcSet, srcBinding, and srcArrayElement are the source
        /// set, binding, and array element, respectively.
        /// If the descriptor binding identified by srcSet and
        /// srcBinding has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// srcArrayElement specifies the starting byte offset within the
        /// binding to copy from.</summary>
        public VkDescriptorSet srcSet;
        public UInt32 srcBinding;
        public UInt32 srcArrayElement;
        /// <summary> dstSet, dstBinding, and dstArrayElement are the
        /// destination set, binding, and array element, respectively.
        /// If the descriptor binding identified by dstSet and
        /// dstBinding has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// dstArrayElement specifies the starting byte offset within the
        /// binding to copy to.</summary>
        public VkDescriptorSet dstSet;
        public UInt32 dstBinding;
        public UInt32 dstArrayElement;
        /// <summary> descriptorCount is the number of descriptors to copy from the
        /// source to destination.
        /// If descriptorCount is greater than the number of remaining array
        /// elements in the source or destination binding, those affect consecutive
        /// bindings in a manner similar to VkWriteDescriptorSet above.
        /// If the descriptor binding identified by srcSet and
        /// srcBinding has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// descriptorCount specifies the number of bytes to copy and the
        /// remaining array elements in the source or destination binding refer to
        /// the remaining number of bytes in those.</summary>
        public UInt32 descriptorCount;
    }
    // Struct: 55
    /// <summary>VkD3D12FenceSubmitInfoKHR - Structure specifying values for Direct3D 12 fence-backed semaphores
    /// </summary>
    public unsafe struct VkD3D12FenceSubmitInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> waitSemaphoreValuesCount is the number of semaphore wait values
        /// specified in pWaitSemaphoreValues.</summary>
        public UInt32 waitSemaphoreValuesCount;
        /// <summary> pWaitSemaphoreValues is an array of length
        /// waitSemaphoreValuesCount containing values for the corresponding
        /// semaphores in VkSubmitInfo::pWaitSemaphores to wait for.</summary>
        public /*-const-*/ UInt64* pWaitSemaphoreValues;
        /// <summary> signalSemaphoreValuesCount is the number of semaphore signal
        /// values specified in pSignalSemaphoreValues.</summary>
        public UInt32 signalSemaphoreValuesCount;
        /// <summary> pSignalSemaphoreValues is an array of length
        /// signalSemaphoreValuesCount containing values for the corresponding
        /// semaphores in VkSubmitInfo::pSignalSemaphores to set when
        /// signaled.</summary>
        public /*-const-*/ UInt64* pSignalSemaphoreValues;
    }
    // Struct: 56
    /// <summary>VkDebugMarkerMarkerInfoEXT - Specify parameters of a command buffer marker region
    /// </summary>
    public unsafe struct VkDebugMarkerMarkerInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pMarkerName is a pointer to a null-terminated UTF-8 string that
        /// contains the name of the marker.</summary>
        public IntPtr pMarkerName;
        public fixed float color[4];
    }
    // Struct: 57
    /// <summary>VkDebugMarkerObjectNameInfoEXT - Specify parameters of a name to give to an object
    /// </summary>
    public unsafe struct VkDebugMarkerObjectNameInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectType is a VkDebugReportObjectTypeEXT specifying the
        /// type of the object to be named.</summary>
        public VkDebugReportObjectTypeEXT _objectType;
        /// <summary> object is the object to be named.</summary>
        public UInt64 _object;
        /// <summary> pObjectName is a null-terminated UTF-8 string specifying the name
        /// to apply to object.</summary>
        public IntPtr pObjectName;
    }
    // Struct: 58
    /// <summary>VkDebugMarkerObjectTagInfoEXT - Specify parameters of a tag to attach to an object
    /// </summary>
    public unsafe struct VkDebugMarkerObjectTagInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectType is a VkDebugReportObjectTypeEXT specifying the
        /// type of the object to be named.</summary>
        public VkDebugReportObjectTypeEXT _objectType;
        /// <summary> object is the object to be tagged.</summary>
        public UInt64 _object;
        /// <summary> tagName is a numerical identifier of the tag.</summary>
        public UInt64 tagName;
        /// <summary> tagSize is the number of bytes of data to attach to the object.</summary>
        public Int32 tagSize;
        /// <summary> pTag is an array of tagSize bytes containing the data to be
        /// associated with the object.</summary>
        public /*-const-*/ void* pTag;
    }
    // Struct: 59
    /// <summary>VkDebugReportCallbackCreateInfoEXT - Structure specifying parameters of a newly created debug report callback
    /// </summary>
    public unsafe struct VkDebugReportCallbackCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkDebugReportFlagBitsEXT specifying
        /// which event(s) will cause this callback to be called.</summary>
        public VkDebugReportFlagsEXT flags;
        /// <summary> pfnCallback is the application callback function to call.</summary>
        public PFN_vkDebugReportCallbackEXT pfnCallback;
        /// <summary> pUserData is user data to be passed to the callback.</summary>
        public void* pUserData;
    }
    // Struct: 60
    /// <summary>VkDebugUtilsLabelEXT - Specify parameters of a label region
    /// </summary>
    public unsafe struct VkDebugUtilsLabelEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pLabelName is a pointer to a null-terminated UTF-8 string that
        /// contains the name of the label.</summary>
        public IntPtr pLabelName;
        public fixed float color[4];
    }
    // Struct: 61
    /// <summary>VkDebugUtilsMessengerCallbackDataEXT - Structure specifying parameters returned to the callback
    /// </summary>
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is 0 and reserved for future use.</summary>
        public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
        /// <summary> pMessageIdName is a null-terminated string that identifies the
        /// particular message ID that is associated with the provided message.
        /// If the message corresponds to a validation layer message, then this
        /// string may contain the portion of the Vulkan specification that is
        /// believed to have been violated.</summary>
        public IntPtr pMessageIdName;
        /// <summary> messageIdNumber is the ID number of the triggering message.
        /// If the message corresponds to a validation layer message, then this
        /// number is related to the internal number associated with the message
        /// being triggered.</summary>
        public Int32 messageIdNumber;
        /// <summary> pMessage is a null-terminated string detailing the trigger
        /// conditions.</summary>
        public IntPtr pMessage;
        /// <summary> queueLabelCount is a count of items contained in the
        /// pQueueLabels array.</summary>
        public UInt32 queueLabelCount;
        /// <summary> pQueueLabels is NULL or a pointer to an array of
        /// VkDebugUtilsLabelEXT active in the current VkQueue at the
        /// time the callback was triggered.
        /// Refer to Queue Labels for more information.</summary>
        public /*-const-*/ VkDebugUtilsLabelEXT* pQueueLabels;
        /// <summary> cmdBufLabelCount is a count of items contained in the
        /// pCmdBufLabels array.</summary>
        public UInt32 cmdBufLabelCount;
        /// <summary> pCmdBufLabels is NULL or a pointer to an array of
        /// VkDebugUtilsLabelEXT active in the current VkCommandBuffer
        /// at the time the callback was triggered.
        /// Refer to Command Buffer Labels for
        /// more information.</summary>
        public /*-const-*/ VkDebugUtilsLabelEXT* pCmdBufLabels;
        /// <summary> objectCount is a count of items contained in the pObjects
        /// array.</summary>
        public UInt32 _objectCount;
        /// <summary> pObjects is a pointer to an array of
        /// VkDebugUtilsObjectNameInfoEXT objects related to the detected
        /// issue.
        /// The array is roughly in order or importance, but the 0th element is
        /// always guaranteed to be the most important object for this message.</summary>
        public /*-const-*/ VkDebugUtilsObjectNameInfoEXT* pObjects;
    }
    // Struct: 62
    /// <summary>VkDebugUtilsMessengerCreateInfoEXT - Structure specifying parameters of a newly created debug messenger
    /// </summary>
    public unsafe struct VkDebugUtilsMessengerCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is 0 and reserved for future use.</summary>
        public VkDebugUtilsMessengerCreateFlagsEXT flags;
        /// <summary> messageSeverity is a bitmask of
        /// VkDebugUtilsMessageSeverityFlagBitsEXT specifying which severity
        /// of event(s) will cause this callback to be called.</summary>
        public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
        /// <summary> messageType is a bitmask of
        /// VkDebugUtilsMessageTypeFlagBitsEXT specifying which type of
        /// event(s) will cause this callback to be called.</summary>
        public VkDebugUtilsMessageTypeFlagsEXT messageType;
        /// <summary> pfnUserCallback is the application callback function to call.</summary>
        public PFN_vkDebugUtilsMessengerCallbackEXT pfnUserCallback;
        /// <summary> pUserData is user data to be passed to the callback.</summary>
        public void* pUserData;
    }
    // Struct: 63
    /// <summary>VkDebugUtilsObjectNameInfoEXT - Specify parameters of a name to give to an object
    /// </summary>
    public unsafe struct VkDebugUtilsObjectNameInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectType is a VkObjectType specifying the type of the
        /// object to be named.</summary>
        public VkObjectType _objectType;
        /// <summary> objectHandle is the object to be named.</summary>
        public UInt64 _objectHandle;
        /// <summary> pObjectName is a null-terminated UTF-8 string specifying the name
        /// to apply to objectHandle.</summary>
        public IntPtr pObjectName;
    }
    // Struct: 64
    /// <summary>VkDebugUtilsObjectTagInfoEXT - Specify parameters of a tag to attach to an object
    /// </summary>
    public unsafe struct VkDebugUtilsObjectTagInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectType is a VkObjectType specifying the type of the
        /// object to be named.</summary>
        public VkObjectType _objectType;
        /// <summary> objectHandle is the object to be tagged.</summary>
        public UInt64 _objectHandle;
        /// <summary> tagName is a numerical identifier of the tag.</summary>
        public UInt64 tagName;
        /// <summary> tagSize is the number of bytes of data to attach to the object.</summary>
        public Int32 tagSize;
        /// <summary> pTag is an array of tagSize bytes containing the data to be
        /// associated with the object.</summary>
        public /*-const-*/ void* pTag;
    }
    // Struct: 65
    /// <summary>VkDedicatedAllocationBufferCreateInfoNV - Specify that a buffer is bound to a dedicated memory resource
    /// </summary>
    public unsafe struct VkDedicatedAllocationBufferCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> dedicatedAllocation specifies whether the buffer will have a
        /// dedicated allocation bound to it.</summary>
        public VkBool32 dedicatedAllocation;
    }
    // Struct: 66
    /// <summary>VkDedicatedAllocationImageCreateInfoNV - Specify that an image is bound to a dedicated memory resource
    /// </summary>
    public unsafe struct VkDedicatedAllocationImageCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> dedicatedAllocation specifies whether the image will have a
        /// dedicated allocation bound to it.</summary>
        public VkBool32 dedicatedAllocation;
    }
    // Struct: 67
    /// <summary>VkDedicatedAllocationMemoryAllocateInfoNV - Specify a dedicated memory allocation resource
    /// </summary>
    public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> image is VK_NULL_HANDLE or a handle of an image which this
        /// memory will be bound to.</summary>
        public VkImage image;
        /// <summary> buffer is VK_NULL_HANDLE or a handle of a buffer which this
        /// memory will be bound to.</summary>
        public VkBuffer buffer;
    }
    // Struct: 68
    /// <summary>VkDescriptorBufferInfo - Structure specifying descriptor buffer info
    /// </summary>
    public unsafe struct VkDescriptorBufferInfo {
        /// <summary> buffer is the buffer resource.</summary>
        public VkBuffer buffer;
        /// <summary> offset is the offset in bytes from the start of buffer.
        /// Access to buffer memory via this descriptor uses addressing that is
        /// relative to this starting offset.</summary>
        public VkDeviceSize offset;
        /// <summary> range is the size in bytes that is used for this descriptor
        /// update, or VK_WHOLE_SIZE to use the range from offset to the
        /// end of the buffer.</summary>
        public VkDeviceSize range;
    }
    // Struct: 69
    /// <summary>VkDescriptorImageInfo - Structure specifying descriptor image info
    /// </summary>
    public unsafe struct VkDescriptorImageInfo {
        /// <summary> sampler is a sampler handle, and is used in descriptor updates for
        /// types VK_DESCRIPTOR_TYPE_SAMPLER and
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER if the binding being
        /// updated does not use immutable samplers.</summary>
        public VkSampler sampler;
        /// <summary> imageView is an image view handle, and is used in descriptor
        /// updates for types VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
        /// VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.</summary>
        public VkImageView imageView;
        /// <summary> imageLayout is the layout that the image subresources accessible
        /// from imageView will be in at the time this descriptor is accessed.
        /// imageLayout is used in descriptor updates for types
        /// VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
        /// VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.</summary>
        public VkImageLayout imageLayout;
    }
    // Struct: 70
    /// <summary>VkDescriptorPoolCreateInfo - Structure specifying parameters of a newly created descriptor pool
    /// </summary>
    public unsafe struct VkDescriptorPoolCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkDescriptorPoolCreateFlagBits
        /// specifying certain supported operations on the pool.</summary>
        public VkDescriptorPoolCreateFlags flags;
        /// <summary> maxSets is the maximum number of descriptor sets that can be
        /// allocated from the pool.</summary>
        public UInt32 maxSets;
        /// <summary> poolSizeCount is the number of elements in pPoolSizes.</summary>
        public UInt32 poolSizeCount;
        /// <summary> pPoolSizes is a pointer to an array of VkDescriptorPoolSize
        /// structures, each containing a descriptor type and number of descriptors
        /// of that type to be allocated in the pool.</summary>
        public /*-const-*/ VkDescriptorPoolSize* pPoolSizes;
    }
    // Struct: 71
    /// <summary>VkDescriptorPoolInlineUniformBlockCreateInfoEXT - Structure specifying the maximum number of inline uniform block bindings of a newly created descriptor pool
    /// </summary>
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> maxInlineUniformBlockBindings is the number of inline uniform
        /// block bindings to allocate.</summary>
        public UInt32 maxInlineUniformBlockBindings;
    }
    // Struct: 72
    /// <summary>VkDescriptorPoolSize - Structure specifying descriptor pool size
    /// </summary>
    public unsafe struct VkDescriptorPoolSize {
        /// <summary> type is the type of descriptor.</summary>
        public VkDescriptorType type;
        /// <summary> descriptorCount is the number of descriptors of that type to
        /// allocate.
        /// If type is VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// descriptorCount is the number of bytes to allocate for descriptors
        /// of this type.</summary>
        public UInt32 descriptorCount;
    }
    // Struct: 73
    /// <summary>VkDescriptorSetAllocateInfo - Structure specifying the allocation parameters for descriptor sets
    /// </summary>
    public unsafe struct VkDescriptorSetAllocateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> descriptorPool is the pool which the sets will be allocated from.</summary>
        public VkDescriptorPool descriptorPool;
        /// <summary> descriptorSetCount determines the number of descriptor sets to be
        /// allocated from the pool.</summary>
        public UInt32 descriptorSetCount;
        /// <summary> pSetLayouts is an array of descriptor set layouts, with each
        /// member specifying how the corresponding descriptor set is allocated.</summary>
        public /*-const-*/ VkDescriptorSetLayout* pSetLayouts;
    }
    // Struct: 74
    /// <summary>VkDescriptorSetLayoutBinding - Structure specifying a descriptor set layout binding
    /// </summary>
    public unsafe struct VkDescriptorSetLayoutBinding {
        /// <summary> binding is the binding number of this entry and corresponds to a
        /// resource of the same binding number in the shader stages.</summary>
        public UInt32 binding;
        /// <summary> descriptorType is a VkDescriptorType specifying which type
        /// of resource descriptors are used for this binding.</summary>
        public VkDescriptorType descriptorType;
        /// <summary> descriptorCount is the number of descriptors contained in the
        /// binding, accessed in a shader as an array
        /// , except if descriptorType is
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT in which case
        /// descriptorCount is the size in bytes of the inline uniform block
        /// .
        /// If descriptorCount is zero this binding entry is reserved and the
        /// resource must not be accessed from any stage via this binding within
        /// any pipeline using the set layout.</summary>
        public UInt32 descriptorCount;
        /// <summary> stageFlags member is a bitmask of VkShaderStageFlagBits
        /// specifying which pipeline shader stages can access a resource for this
        /// binding.
        /// VK_SHADER_STAGE_ALL is a shorthand specifying that all defined
        /// shader stages, including any additional stages defined by extensions,
        /// can access the resource.</summary>
        public VkShaderStageFlags stageFlags;
        public /*-const-*/ VkSampler* pImmutableSamplers;
    }
    // Struct: 75
    /// <summary>VkDescriptorSetLayoutBindingFlagsCreateInfoEXT - Structure specifying creation flags for descriptor set layout bindings
    /// </summary>
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> bindingCount is zero or the number of elements in
        /// pBindingFlags.</summary>
        public UInt32 bindingCount;
        /// <summary> pBindingFlags is a pointer to an array of
        /// VkDescriptorBindingFlagsEXT bitfields, one for each descriptor set
        /// layout binding.</summary>
        public /*-const-*/ VkDescriptorBindingFlagsEXT* pBindingFlags;
    }
    // Struct: 76
    /// <summary>VkDescriptorSetLayoutCreateInfo - Structure specifying parameters of a newly created descriptor set layout
    /// </summary>
    public unsafe struct VkDescriptorSetLayoutCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask
        /// of VkDescriptorSetLayoutCreateFlagBits
        /// specifying options for descriptor set layout creation.</summary>
        public VkDescriptorSetLayoutCreateFlags flags;
        /// <summary> bindingCount is the number of elements in pBindings.</summary>
        public UInt32 bindingCount;
        /// <summary> pBindings is a pointer to an array of
        /// VkDescriptorSetLayoutBinding structures.</summary>
        public /*-const-*/ VkDescriptorSetLayoutBinding* pBindings;
    }
    // Struct: 77
    /// <summary>VkDescriptorSetLayoutSupport - Structure returning information about whether a descriptor set layout can be supported
    /// </summary>
    public unsafe struct VkDescriptorSetLayoutSupport {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> supported specifies whether the descriptor set layout can be
        /// created.</summary>
        public VkBool32 supported;
    }
    // Struct: 78
    /// <summary>VkDescriptorSetVariableDescriptorCountAllocateInfoEXT - Structure specifying additional allocation parameters for descriptor sets
    /// </summary>
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> descriptorSetCount is zero or the number of elements in
        /// pDescriptorCounts.</summary>
        public UInt32 descriptorSetCount;
        /// <summary> pDescriptorCounts is an array of descriptor counts, with each
        /// member specifying the number of descriptors in a variable descriptor
        /// count binding in the corresponding descriptor set being allocated.</summary>
        public /*-const-*/ UInt32* pDescriptorCounts;
    }
    // Struct: 79
    /// <summary>VkDescriptorSetVariableDescriptorCountLayoutSupportEXT - Structure returning information about whether a descriptor set layout can be supported
    /// </summary>
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> maxVariableDescriptorCount indicates the maximum number of
        /// descriptors supported in the highest numbered binding of the layout, if
        /// that binding is variable-sized.
        /// If the highest numbered binding of the layout has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// maxVariableDescriptorCount indicates the maximum byte size
        /// supported for the binding, if that binding is variable-sized.</summary>
        public UInt32 maxVariableDescriptorCount;
    }
    // Struct: 80
    /// <summary>VkDescriptorUpdateTemplateCreateInfo - Structure specifying parameters of a newly created descriptor update template
    /// </summary>
    public unsafe struct VkDescriptorUpdateTemplateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkDescriptorUpdateTemplateCreateFlags flags;
        /// <summary> descriptorUpdateEntryCount is the number of elements in the
        /// pDescriptorUpdateEntries array.</summary>
        public UInt32 descriptorUpdateEntryCount;
        /// <summary> pDescriptorUpdateEntries is a pointer to an array of
        /// VkDescriptorUpdateTemplateEntry structures describing the
        /// descriptors to be updated by the descriptor update template.</summary>
        public /*-const-*/ VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
        /// <summary> templateType Specifies the type of the descriptor update template.
        /// If set to VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET it
        /// can only be used to update descriptor sets with a fixed
        /// descriptorSetLayout.
        /// If set to VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// it can only be used to push descriptor sets using the provided
        /// pipelineBindPoint, pipelineLayout, and set number.</summary>
        public VkDescriptorUpdateTemplateType templateType;
        /// <summary> descriptorSetLayout is the descriptor set layout the parameter
        /// update template will be used with.
        /// All descriptor sets which are going to be updated through the newly
        /// created descriptor update template must be created with this layout.
        /// descriptorSetLayout is the descriptor set layout used to build the
        /// descriptor update template.
        /// All descriptor sets which are going to be updated through the newly
        /// created descriptor update template must be created with a layout that
        /// matches (is the same as, or defined identically to) this layout.
        /// This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET.</summary>
        public VkDescriptorSetLayout descriptorSetLayout;
        /// <summary> pipelineBindPoint is a VkPipelineBindPoint indicating
        /// whether the descriptors will be used by graphics pipelines or compute
        /// pipelines.
        /// This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR </summary>
        public VkPipelineBindPoint pipelineBindPoint;
        /// <summary> pipelineLayout is a VkPipelineLayout object used to program
        /// the bindings.
        /// This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR </summary>
        public VkPipelineLayout pipelineLayout;
        /// <summary> set is the set number of the descriptor set in the pipeline layout
        /// that will be updated.
        /// This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR </summary>
        public UInt32 set;
    }
    // Struct: 81
    /// <summary>VkDescriptorUpdateTemplateEntry - Describes a single descriptor update of the descriptor update template
    /// </summary>
    public unsafe struct VkDescriptorUpdateTemplateEntry {
        /// <summary> dstBinding is the descriptor binding to update when using this
        /// descriptor update template.</summary>
        public UInt32 dstBinding;
        /// <summary> dstArrayElement is the starting element in the array belonging to
        /// dstBinding.
        /// If the descriptor binding identified by srcBinding has a
        /// descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT
        /// then dstArrayElement specifies the starting byte offset to update.</summary>
        public UInt32 dstArrayElement;
        /// <summary> descriptorCount is the number of descriptors to update.
        /// If descriptorCount is greater than the number of remaining array
        /// elements in the destination binding, those affect consecutive bindings
        /// in a manner similar to VkWriteDescriptorSet above.
        /// If the descriptor binding identified by dstBinding has a
        /// descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT
        /// then descriptorCount specifies the number of bytes to update and
        /// the remaining array elements in the destination binding refer to the
        /// remaining number of bytes in it.</summary>
        public UInt32 descriptorCount;
        /// <summary> descriptorType is a VkDescriptorType specifying the type of
        /// the descriptor.</summary>
        public VkDescriptorType descriptorType;
        /// <summary> offset is the offset in bytes of the first binding in the raw data
        /// structure.</summary>
        public Int32 offset;
        /// <summary> stride is the stride in bytes between two consecutive array
        /// elements of the descriptor update informations in the raw data
        /// structure.
        /// The actual pointer ptr for each array element j of update entry i is
        /// computed using the following formula:</summary>
        public Int32 stride;
    }
    // Struct: 82
    /// <summary>VkDeviceCreateInfo - Structure specifying parameters of a newly created device
    /// </summary>
    public unsafe struct VkDeviceCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkDeviceCreateFlags flags;
        /// <summary> queueCreateInfoCount is the unsigned integer size of the
        /// pQueueCreateInfos array.
        /// Refer to the Queue Creation section
        /// below for further details.</summary>
        public UInt32 queueCreateInfoCount;
        /// <summary> pQueueCreateInfos is a pointer to an array of
        /// VkDeviceQueueCreateInfo structures describing the queues that are
        /// requested to be created along with the logical device.
        /// Refer to the Queue Creation section
        /// below for further details.</summary>
        public /*-const-*/ VkDeviceQueueCreateInfo* pQueueCreateInfos;
        /// <summary> enabledLayerCount is deprecated and ignored.</summary>
        public UInt32 enabledLayerCount;
        /// <summary> ppEnabledLayerNames is deprecated and ignored.
        /// See html/vkspec.html#extendingvulkan-layers-devicelayerdeprecation.</summary>
        public IntPtr /*-const-*/ * ppEnabledLayerNames;
        /// <summary> enabledExtensionCount is the number of device extensions to
        /// enable.</summary>
        public UInt32 enabledExtensionCount;
        /// <summary> ppEnabledExtensionNames is a pointer to an array of
        /// enabledExtensionCount null-terminated UTF-8 strings containing the
        /// names of extensions to enable for the created device.
        /// See the html/vkspec.html#extendingvulkan-extensions section for further details.</summary>
        public IntPtr /*-const-*/ * ppEnabledExtensionNames;
        /// <summary> pEnabledFeatures is NULL or a pointer to a
        /// VkPhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled.
        /// Refer to the Features section for further details.</summary>
        public /*-const-*/ VkPhysicalDeviceFeatures* pEnabledFeatures;
    }
    // Struct: 83
    /// <summary>VkDeviceEventInfoEXT - Describe a device event to create
    /// </summary>
    public unsafe struct VkDeviceEventInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        public VkDeviceEventTypeEXT deviceEvent;
    }
    // Struct: 84
    /// <summary>VkDeviceGeneratedCommandsFeaturesNVX - Structure specifying physical device support
    /// </summary>
    public unsafe struct VkDeviceGeneratedCommandsFeaturesNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> computeBindingPointSupport specifies whether the
        /// VkObjectTableNVX supports entries with
        /// VK_OBJECT_ENTRY_USAGE_GRAPHICS_BIT_NVX bit set and
        /// VkIndirectCommandsLayoutNVX supports
        /// VK_PIPELINE_BIND_POINT_COMPUTE.</summary>
        public VkBool32 computeBindingPointSupport;
    }
    // Struct: 85
    /// <summary>VkDeviceGeneratedCommandsLimitsNVX - Structure specifying physical device limits
    /// </summary>
    public unsafe struct VkDeviceGeneratedCommandsLimitsNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> maxIndirectCommandsLayoutTokenCount the maximum number of tokens
        /// in VkIndirectCommandsLayoutNVX.</summary>
        public UInt32 maxIndirectCommandsLayoutTokenCount;
        /// <summary> maxObjectEntryCounts the maximum number of entries per resource
        /// type in VkObjectTableNVX.</summary>
        public UInt32 maxObjectEntryCounts;
        /// <summary> minSequenceCountBufferOffsetAlignment the minimum alignment for
        /// memory addresses optionally used in vkCmdProcessCommandsNVX.</summary>
        public UInt32 minSequenceCountBufferOffsetAlignment;
        /// <summary> minSequenceIndexBufferOffsetAlignment the minimum alignment for
        /// memory addresses optionally used in vkCmdProcessCommandsNVX.</summary>
        public UInt32 minSequenceIndexBufferOffsetAlignment;
        /// <summary> minCommandsTokenBufferOffsetAlignment the minimum alignment for
        /// memory addresses optionally used in vkCmdProcessCommandsNVX.</summary>
        public UInt32 minCommandsTokenBufferOffsetAlignment;
    }
    // Struct: 86
    /// <summary>VkDeviceGroupBindSparseInfo - Structure indicating which instances are bound
    /// </summary>
    public unsafe struct VkDeviceGroupBindSparseInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> resourceDeviceIndex is a device index indicating which instance of
        /// the resource is bound.</summary>
        public UInt32 resourceDeviceIndex;
        /// <summary> memoryDeviceIndex is a device index indicating which instance of
        /// the memory the resource instance is bound to.</summary>
        public UInt32 memoryDeviceIndex;
    }
    // Struct: 87
    /// <summary>VkDeviceGroupCommandBufferBeginInfo - Set the initial device mask for a command buffer
    /// </summary>
    public unsafe struct VkDeviceGroupCommandBufferBeginInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> deviceMask is the initial value of the command buffer’s device
        /// mask.</summary>
        public UInt32 deviceMask;
    }
    // Struct: 88
    /// <summary>VkDeviceGroupDeviceCreateInfo - Create a logical device from multiple physical devices
    /// </summary>
    public unsafe struct VkDeviceGroupDeviceCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> physicalDeviceCount is the number of elements in the
        /// pPhysicalDevices array.</summary>
        public UInt32 physicalDeviceCount;
        /// <summary> pPhysicalDevices is an array of physical device handles belonging
        /// to the same device group.</summary>
        public /*-const-*/ VkPhysicalDevice* pPhysicalDevices;
    }
    // Struct: 89
    /// <summary>VkDeviceGroupPresentCapabilitiesKHR - Present capabilities from other physical devices
    /// </summary>
    public unsafe struct VkDeviceGroupPresentCapabilitiesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        public fixed UInt32 presentMask[VK_MAX_DEVICE_GROUP_SIZE];
        /// <summary> modes is a bitmask of VkDeviceGroupPresentModeFlagBitsKHR
        /// indicating which device group presentation modes are supported.</summary>
        public VkDeviceGroupPresentModeFlagsKHR modes;
    }
    // Struct: 90
    /// <summary>VkDeviceGroupPresentInfoKHR - Mode and mask controlling which physical devices' images are presented
    /// </summary>
    public unsafe struct VkDeviceGroupPresentInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> swapchainCount is zero or the number of elements in
        /// pDeviceMasks.</summary>
        public UInt32 swapchainCount;
        /// <summary> pDeviceMasks is an array of device masks, one for each element of
        /// VkPresentInfoKHR::pSwapchains.</summary>
        public /*-const-*/ UInt32* pDeviceMasks;
        /// <summary> mode is the device group present mode that will be used for this
        /// present.</summary>
        public VkDeviceGroupPresentModeFlagBitsKHR mode;
    }
    // Struct: 91
    /// <summary>VkDeviceGroupRenderPassBeginInfo - Set the initial device mask and render areas for a render pass instance
    /// </summary>
    public unsafe struct VkDeviceGroupRenderPassBeginInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> deviceMask is the device mask for the render pass instance.</summary>
        public UInt32 deviceMask;
        /// <summary> deviceRenderAreaCount is the number of elements in the
        /// pDeviceRenderAreas array.</summary>
        public UInt32 deviceRenderAreaCount;
        /// <summary> pDeviceRenderAreas is an array of structures of type
        /// VkRect2D defining the render area for each physical device.</summary>
        public /*-const-*/ VkRect2D* pDeviceRenderAreas;
    }
    // Struct: 92
    /// <summary>VkDeviceGroupSubmitInfo - Structure indicating which physical devices execute semaphore operations and command buffers
    /// </summary>
    public unsafe struct VkDeviceGroupSubmitInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> waitSemaphoreCount is the number of elements in the
        /// pWaitSemaphoreDeviceIndices array.</summary>
        public UInt32 waitSemaphoreCount;
        /// <summary> pWaitSemaphoreDeviceIndices is an array of device indices
        /// indicating which physical device executes the semaphore wait operation
        /// in the corresponding element of
        /// VkSubmitInfo::pWaitSemaphores.</summary>
        public /*-const-*/ UInt32* pWaitSemaphoreDeviceIndices;
        /// <summary> commandBufferCount is the number of elements in the
        /// pCommandBufferDeviceMasks array.</summary>
        public UInt32 commandBufferCount;
        /// <summary> pCommandBufferDeviceMasks is an array of device masks indicating
        /// which physical devices execute the command buffer in the corresponding
        /// element of VkSubmitInfo::pCommandBuffers.
        /// A physical device executes the command buffer if the corresponding bit
        /// is set in the mask.</summary>
        public /*-const-*/ UInt32* pCommandBufferDeviceMasks;
        /// <summary> signalSemaphoreCount is the number of elements in the
        /// pSignalSemaphoreDeviceIndices array.</summary>
        public UInt32 signalSemaphoreCount;
        /// <summary> pSignalSemaphoreDeviceIndices is an array of device indices
        /// indicating which physical device executes the semaphore signal operation
        /// in the corresponding element of
        /// VkSubmitInfo::pSignalSemaphores.</summary>
        public /*-const-*/ UInt32* pSignalSemaphoreDeviceIndices;
    }
    // Struct: 93
    /// <summary>VkDeviceGroupSwapchainCreateInfoKHR - Structure specifying parameters of a newly created swapchain object
    /// </summary>
    public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> modes is a bitfield of modes that the swapchain can be used with.</summary>
        public VkDeviceGroupPresentModeFlagsKHR modes;
    }
    // Struct: 94
    /// <summary>VkDeviceMemoryOverallocationCreateInfoAMD - Specify memory overallocation behavior for a Vulkan device
    /// </summary>
    public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> overallocationBehavior is the desired overallocation behavior.</summary>
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
    }
    // Struct: 95
    /// <summary>VkDeviceQueueCreateInfo - Structure specifying parameters of a newly created device queue
    /// </summary>
    public unsafe struct VkDeviceQueueCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask indicating behavior of the queue.</summary>
        public VkDeviceQueueCreateFlags flags;
        /// <summary> queueFamilyIndex is an unsigned integer indicating the index of
        /// the queue family to create on this device.
        /// This index corresponds to the index of an element of the
        /// pQueueFamilyProperties array that was returned by
        /// vkGetPhysicalDeviceQueueFamilyProperties.</summary>
        public UInt32 queueFamilyIndex;
        /// <summary> queueCount is an unsigned integer specifying the number of queues
        /// to create in the queue family indicated by queueFamilyIndex.</summary>
        public UInt32 queueCount;
        /// <summary> pQueuePriorities is an array of queueCount normalized
        /// floating point values, specifying priorities of work that will be
        /// submitted to each created queue.
        /// See Queue Priority for more information.</summary>
        public /*-const-*/ float* pQueuePriorities;
    }
    // Struct: 96
    /// <summary>VkDeviceQueueGlobalPriorityCreateInfoEXT - Specify a system wide priority
    /// </summary>
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> globalPriority is the system-wide priority associated to this
        /// queue as specified by VkQueueGlobalPriorityEXT </summary>
        public VkQueueGlobalPriorityEXT globalPriority;
    }
    // Struct: 97
    /// <summary>VkDeviceQueueInfo2 - Structure specifying the parameters used for device queue creation
    /// </summary>
    public unsafe struct VkDeviceQueueInfo2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.
        /// The pNext chain of VkDeviceQueueInfo2 is used to provide
        /// additional image parameters to vkGetDeviceQueue2.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a VkDeviceQueueCreateFlags value indicating the
        /// flags used to create the device queue.</summary>
        public VkDeviceQueueCreateFlags flags;
        /// <summary> queueFamilyIndex is the index of the queue family to which the
        /// queue belongs.</summary>
        public UInt32 queueFamilyIndex;
        /// <summary> queueIndex is the index within this queue family of the queue to
        /// retrieve.</summary>
        public UInt32 queueIndex;
    }
    // Struct: 98
    /// <summary>VkDispatchIndirectCommand - Structure specifying a dispatch indirect command
    /// </summary>
    public unsafe struct VkDispatchIndirectCommand {
        /// <summary> x is the number of local workgroups to dispatch in the X
        /// dimension.</summary>
        public UInt32 x;
        /// <summary> y is the number of local workgroups to dispatch in the Y
        /// dimension.</summary>
        public UInt32 y;
        /// <summary> z is the number of local workgroups to dispatch in the Z
        /// dimension.</summary>
        public UInt32 z;
    }
    // Struct: 99
    /// <summary>VkDisplayEventInfoEXT - Describe a display event to create
    /// </summary>
    public unsafe struct VkDisplayEventInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> displayEvent is a VkDisplayEventTypeEXT specifying when the
        /// fence will be signaled.</summary>
        public VkDisplayEventTypeEXT displayEvent;
    }
    // Struct: 100
    /// <summary>VkDisplayModeCreateInfoKHR - Structure specifying parameters of a newly created display mode object
    /// </summary>
    public unsafe struct VkDisplayModeCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use, and must be zero.</summary>
        public VkDisplayModeCreateFlagsKHR flags;
        /// <summary> parameters is a VkDisplayModeParametersKHR structure
        /// describing the display parameters to use in creating the new mode.
        /// If the parameters are not compatible with the specified display, the
        /// implementation must return VK_ERROR_INITIALIZATION_FAILED.</summary>
        public VkDisplayModeParametersKHR parameters;
    }
    // Struct: 101
    /// <summary>VkDisplayModeParametersKHR - Structure describing display parameters associated with a display mode
    /// </summary>
    public unsafe struct VkDisplayModeParametersKHR {
        /// <summary> visibleRegion is the 2D extents of the visible region.</summary>
        public VkExtent2D visibleRegion;
        /// <summary> refreshRate is a uint32_t that is the number of times the
        /// display is refreshed each second multiplied by 1000.</summary>
        public UInt32 refreshRate;
    }
    // Struct: 102
    /// <summary>VkDisplayModeProperties2KHR - Structure describing an available display mode
    /// </summary>
    public unsafe struct VkDisplayModeProperties2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> displayModeProperties is an instance of the
        /// VkDisplayModePropertiesKHR structure.</summary>
        public VkDisplayModePropertiesKHR displayModeProperties;
    }
    // Struct: 103
    /// <summary>VkDisplayModePropertiesKHR - Structure describing display mode properties
    /// </summary>
    public unsafe struct VkDisplayModePropertiesKHR {
        /// <summary> displayMode is a handle to the display mode described in this
        /// structure.
        /// This handle will be valid for the lifetime of the Vulkan instance.</summary>
        public VkDisplayModeKHR displayMode;
        /// <summary> parameters is a VkDisplayModeParametersKHR structure
        /// describing the display parameters associated with displayMode.</summary>
        public VkDisplayModeParametersKHR parameters;
    }
    // Struct: 104
    /// <summary>VkDisplayNativeHdrSurfaceCapabilitiesAMD - Structure describing display native HDR specific capabilities of a surface
    /// </summary>
    public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> localDimmingSupport specifies whether the surface supports local
        /// dimming.
        /// If this is VK_TRUE, VkSwapchainDisplayNativeHdrCreateInfoAMD can be used to explicitly enable or disable local dimming for the
        /// surface.
        /// Local dimming may also be overriden by vkSetLocalDimmingAMD during
        /// the lifetime of the swapchain.</summary>
        public VkBool32 localDimmingSupport;
    }
    // Struct: 105
    /// <summary>VkDisplayPlaneCapabilities2KHR - Structure describing the capabilities of a mode and plane combination
    /// </summary>
    public unsafe struct VkDisplayPlaneCapabilities2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> capabilities is an instance of the
        /// VkDisplayPlaneCapabilitiesKHR structure.</summary>
        public VkDisplayPlaneCapabilitiesKHR capabilities;
    }
    // Struct: 106
    /// <summary>VkDisplayPlaneCapabilitiesKHR - Structure describing capabilities of a mode and plane combination
    /// </summary>
    public unsafe struct VkDisplayPlaneCapabilitiesKHR {
        /// <summary> supportedAlpha is a bitmask of
        /// VkDisplayPlaneAlphaFlagBitsKHR describing the supported alpha
        /// blending modes.</summary>
        public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
        /// <summary> minSrcPosition is the minimum source rectangle offset supported by
        /// this plane using the specified mode.</summary>
        public VkOffset2D minSrcPosition;
        /// <summary> maxSrcPosition is the maximum source rectangle offset supported by
        /// this plane using the specified mode.
        /// The x and y components of maxSrcPosition must each be
        /// greater than or equal to the x and y components of
        /// minSrcPosition, respectively.</summary>
        public VkOffset2D maxSrcPosition;
        /// <summary> minSrcExtent is the minimum source rectangle size supported by
        /// this plane using the specified mode.</summary>
        public VkExtent2D minSrcExtent;
        /// <summary> maxSrcExtent is the maximum source rectangle size supported by
        /// this plane using the specified mode.</summary>
        public VkExtent2D maxSrcExtent;
        /// <summary> minDstPosition, maxDstPosition, minDstExtent,
        /// maxDstExtent all have similar semantics to their corresponding
        /// *Src* equivalents, but apply to the output region within the mode
        /// rather than the input region within the source image.
        /// Unlike the *Src* offsets, minDstPosition and
        /// maxDstPosition may contain negative values.</summary>
        public VkOffset2D minDstPosition;
        public VkOffset2D maxDstPosition;
        public VkExtent2D minDstExtent;
        public VkExtent2D maxDstExtent;
    }
    // Struct: 107
    /// <summary>VkDisplayPlaneInfo2KHR - Structure defining the intended configuration of a display plane
    /// </summary>
    public unsafe struct VkDisplayPlaneInfo2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> mode is the display mode the application intends to program when
        /// using the specified plane.</summary>
        public VkDisplayModeKHR mode;
        public UInt32 planeIndex;
    }
    // Struct: 108
    /// <summary>VkDisplayPlaneProperties2KHR - Structure describing an available display plane
    /// </summary>
    public unsafe struct VkDisplayPlaneProperties2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> displayPlaneProperties is an instance of the
        /// VkDisplayPlanePropertiesKHR structure.</summary>
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
    }
    // Struct: 109
    /// <summary>VkDisplayPlanePropertiesKHR - Structure describing display plane properties
    /// </summary>
    public unsafe struct VkDisplayPlanePropertiesKHR {
        /// <summary> currentDisplay is the handle of the display the plane is currently
        /// associated with.
        /// If the plane is not currently attached to any displays, this will be
        /// VK_NULL_HANDLE.</summary>
        public VkDisplayKHR currentDisplay;
        /// <summary> currentStackIndex is the current z-order of the plane.
        /// This will be between 0 and the value returned by
        /// vkGetPhysicalDeviceDisplayPlanePropertiesKHR in
        /// pPropertyCount.</summary>
        public UInt32 currentStackIndex;
    }
    // Struct: 110
    /// <summary>VkDisplayPowerInfoEXT - Describe the power state of a display
    /// </summary>
    public unsafe struct VkDisplayPowerInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> powerState is a VkDisplayPowerStateEXT value specifying the
        /// new power state of the display.</summary>
        public VkDisplayPowerStateEXT powerState;
    }
    // Struct: 111
    /// <summary>VkDisplayPresentInfoKHR - Structure describing parameters of a queue presentation to a swapchain
    /// </summary>
    public unsafe struct VkDisplayPresentInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcRect is a rectangular region of pixels to present.
        /// It must be a subset of the image being presented.
        /// If VkDisplayPresentInfoKHR is not specified, this region will be
        /// assumed to be the entire presentable image.</summary>
        public VkRect2D srcRect;
        /// <summary> dstRect is a rectangular region within the visible region of the
        /// swapchain’s display mode.
        /// If VkDisplayPresentInfoKHR is not specified, this region will be
        /// assumed to be the entire visible region of the visible region of the
        /// swapchain’s mode.
        /// If the specified rectangle is a subset of the display mode’s visible
        /// region, content from display planes below the swapchain’s plane will be
        /// visible outside the rectangle.
        /// If there are no planes below the swapchain’s, the area outside the
        /// specified rectangle will be black.
        /// If portions of the specified rectangle are outside of the display’s
        /// visible region, pixels mapping only to those portions of the rectangle
        /// will be discarded.</summary>
        public VkRect2D dstRect;
        /// <summary> persistent: If this is VK_TRUE, the display engine will
        /// enable buffered mode on displays that support it.
        /// This allows the display engine to stop sending content to the display
        /// until a new image is presented.
        /// The display will instead maintain a copy of the last presented image.
        /// This allows less power to be used, but may increase presentation
        /// latency.
        /// If VkDisplayPresentInfoKHR is not specified, persistent mode will
        /// not be used.</summary>
        public VkBool32 persistent;
    }
    // Struct: 112
    /// <summary>VkDisplayProperties2KHR - Structure describing an available display device
    /// </summary>
    public unsafe struct VkDisplayProperties2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> displayProperties is an instance of the
        /// VkDisplayPropertiesKHR structure.</summary>
        public VkDisplayPropertiesKHR displayProperties;
    }
    // Struct: 113
    /// <summary>VkDisplayPropertiesKHR - Structure describing an available display device
    /// </summary>
    public unsafe struct VkDisplayPropertiesKHR {
        /// <summary> display is a handle that is used to refer to the display described
        /// here.
        /// This handle will be valid for the lifetime of the Vulkan instance.</summary>
        public VkDisplayKHR display;
        /// <summary> displayName is a pointer to a NULL-terminated string containing
        /// the name of the display.
        /// Generally, this will be the name provided by the display’s EDID.
        /// It can be NULL if no suitable name is available.
        /// If not NULL, the memory it points to must remain accessible as long
        /// as display is valid.</summary>
        public IntPtr displayName;
        /// <summary> physicalDimensions describes the physical width and height of the
        /// visible portion of the display, in millimeters.</summary>
        public VkExtent2D physicalDimensions;
        /// <summary> physicalResolution describes the physical, native, or preferred
        /// resolution of the display.</summary>
        public VkExtent2D physicalResolution;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkBool32 planeReorderPossible;
        public VkBool32 persistentContent;
    }
    // Struct: 114
    /// <summary>VkDisplaySurfaceCreateInfoKHR - Structure specifying parameters of a newly created display plane surface object
    /// </summary>
    public unsafe struct VkDisplaySurfaceCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use, and must be zero.</summary>
        public VkDisplaySurfaceCreateFlagsKHR flags;
        /// <summary> displayMode is a VkDisplayModeKHR handle specifying the mode
        /// to use when displaying this surface.</summary>
        public VkDisplayModeKHR displayMode;
        /// <summary> planeIndex is the plane on which this surface appears.</summary>
        public UInt32 planeIndex;
        /// <summary> planeStackIndex is the z-order of the plane.</summary>
        public UInt32 planeStackIndex;
        /// <summary> transform is a VkSurfaceTransformFlagBitsKHR value
        /// specifying the transformation to apply to images as part of the scanout
        /// operation.</summary>
        public VkSurfaceTransformFlagBitsKHR transform;
        /// <summary> globalAlpha is the global alpha value.
        /// This value is ignored if alphaMode is not
        /// VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.</summary>
        public float globalAlpha;
        /// <summary> alphaMode is a VkDisplayPlaneAlphaFlagBitsKHR value
        /// specifying the type of alpha blending to use.</summary>
        public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
        /// <summary> imageExtent The size of the presentable images to use with the
        /// surface.</summary>
        public VkExtent2D imageExtent;
    }
    // Struct: 115
    /// <summary>VkDrawIndexedIndirectCommand - Structure specifying a draw indexed indirect command
    /// </summary>
    public unsafe struct VkDrawIndexedIndirectCommand {
        /// <summary> indexCount is the number of vertices to draw.</summary>
        public UInt32 indexCount;
        /// <summary> instanceCount is the number of instances to draw.</summary>
        public UInt32 instanceCount;
        /// <summary> firstIndex is the base index within the index buffer.</summary>
        public UInt32 firstIndex;
        /// <summary> vertexOffset is the value added to the vertex index before
        /// indexing into the vertex buffer.</summary>
        public Int32 vertexOffset;
        /// <summary> firstInstance is the instance ID of the first instance to draw.</summary>
        public UInt32 firstInstance;
    }
    // Struct: 116
    /// <summary>VkDrawIndirectCommand - Structure specifying a draw indirect command
    /// </summary>
    public unsafe struct VkDrawIndirectCommand {
        /// <summary> vertexCount is the number of vertices to draw.</summary>
        public UInt32 vertexCount;
        /// <summary> instanceCount is the number of instances to draw.</summary>
        public UInt32 instanceCount;
        /// <summary> firstVertex is the index of the first vertex to draw.</summary>
        public UInt32 firstVertex;
        /// <summary> firstInstance is the instance ID of the first instance to draw.</summary>
        public UInt32 firstInstance;
    }
    // Struct: 117
    /// <summary>VkDrawMeshTasksIndirectCommandNV - Structure specifying a mesh tasks draw indirect command
    /// </summary>
    public unsafe struct VkDrawMeshTasksIndirectCommandNV {
        /// <summary> taskCount is the number of local workgroups to dispatch in the X
        /// dimension.
        /// Y and Z dimension are implicitly set to one.</summary>
        public UInt32 taskCount;
        /// <summary> firstTask is the X component of the first workgroup ID.</summary>
        public UInt32 firstTask;
    }
    // Struct: 118
    /// <summary>VkDrmFormatModifierPropertiesEXT - Structure specifying properties of a format when combined with a DRM format modifier
    /// </summary>
    public unsafe struct VkDrmFormatModifierPropertiesEXT {
        /// <summary> drmFormatModifier is a Linux DRM format modifier.</summary>
        public UInt64 drmFormatModifier;
        /// <summary> drmFormatModifierPlaneCount is the number of memory planes in
        /// any image created with format and drmFormatModifier.
        /// An image’s memory planecount is distinct from its format planecount,
        /// as explained below.</summary>
        public UInt32 drmFormatModifierPlaneCount;
        /// <summary> drmFormatModifierTilingFeatures is a bitmask of
        /// VkFormatFeatureFlagBits that are supported by any image created
        /// with format and drmFormatModifier.</summary>
        public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
    }
    // Struct: 119
    /// <summary>VkDrmFormatModifierPropertiesListEXT - Structure specifying the list of DRM format modifiers supported for a format
    /// </summary>
    public unsafe struct VkDrmFormatModifierPropertiesListEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> drmFormatModifierCount is an inout parameter related to the number
        /// of modifiers compatible with the format, as described below.</summary>
        public UInt32 drmFormatModifierCount;
        /// <summary> pDrmFormatModifierProperties is either NULL or an array of
        /// VkDrmFormatModifierPropertiesEXT structures.</summary>
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
    }
    // Struct: 120
    /// <summary>VkEventCreateInfo - Structure specifying parameters of a newly created event
    /// </summary>
    public unsafe struct VkEventCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkEventCreateFlags flags;
    }
    // Struct: 121
    /// <summary>VkExportFenceCreateInfo - Structure specifying handle types that can be exported from a fence
    /// </summary>
    public unsafe struct VkExportFenceCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalFenceHandleTypeFlagBits specifying one or more fence
        /// handle types the application can export from the resulting fence.
        /// The application can request multiple handle types for the same fence.</summary>
        public VkExternalFenceHandleTypeFlags handleTypes;
    }
    // Struct: 122
    /// <summary>VkExportFenceWin32HandleInfoKHR - Structure specifying additional attributes of Windows handles exported from a fence
    /// </summary>
    public unsafe struct VkExportFenceWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pAttributes is a pointer to a Windows SECURITY_ATTRIBUTES
        /// structure specifying security attributes of the handle.</summary>
        public /*-const-*/ SECURITY_ATTRIBUTES* pAttributes;
        /// <summary> dwAccess is a DWORD specifying access rights of the handle.</summary>
        public DWORD dwAccess;
        /// <summary> name is a NULL-terminated UTF-16 string to associate with the
        /// underlying synchronization primitive referenced by NT handles exported
        /// from the created fence.</summary>
        public LPCWSTR name;
    }
    // Struct: 123
    /// <summary>VkExportMemoryAllocateInfo - Specify exportable handle types for a device memory object
    /// </summary>
    public unsafe struct VkExportMemoryAllocateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBits specifying one or more memory
        /// handle types the application can export from the resulting allocation.
        /// The application can request multiple handle types for the same
        /// allocation.</summary>
        public VkExternalMemoryHandleTypeFlags handleTypes;
    }
    // Struct: 124
    /// <summary>VkExportMemoryAllocateInfoNV - Specify memory handle types that may be exported
    /// </summary>
    public unsafe struct VkExportMemoryAllocateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBitsNV specifying one or more memory
        /// handle types that may be exported.
        /// Multiple handle types may be requested for the same allocation as long
        /// as they are compatible, as reported by
        /// vkGetPhysicalDeviceExternalImageFormatPropertiesNV.</summary>
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
    }
    // Struct: 125
    /// <summary>VkExportMemoryWin32HandleInfoKHR - Structure specifying additional attributes of Windows handles exported from a memory
    /// </summary>
    public unsafe struct VkExportMemoryWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pAttributes is a pointer to a Windows SECURITY_ATTRIBUTES
        /// structure specifying security attributes of the handle.</summary>
        public /*-const-*/ SECURITY_ATTRIBUTES* pAttributes;
        /// <summary> dwAccess is a DWORD specifying access rights of the handle.</summary>
        public DWORD dwAccess;
        /// <summary> name is a NULL-terminated UTF-16 string to associate with the
        /// underlying resource referenced by NT handles exported from the created
        /// memory.</summary>
        public LPCWSTR name;
    }
    // Struct: 126
    /// <summary>VkExportMemoryWin32HandleInfoNV - specify security attributes and access rights for Win32 memory handles
    /// </summary>
    public unsafe struct VkExportMemoryWin32HandleInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pAttributes is a pointer to a Windows SECURITY_ATTRIBUTES
        /// structure specifying security attributes of the handle.</summary>
        public /*-const-*/ SECURITY_ATTRIBUTES* pAttributes;
        /// <summary> dwAccess is a DWORD specifying access rights of the handle.</summary>
        public DWORD dwAccess;
    }
    // Struct: 127
    /// <summary>VkExportSemaphoreCreateInfo - Structure specifying handle types that can be exported from a semaphore
    /// </summary>
    public unsafe struct VkExportSemaphoreCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalSemaphoreHandleTypeFlagBits specifying one or more
        /// semaphore handle types the application can export from the resulting
        /// semaphore.
        /// The application can request multiple handle types for the same
        /// semaphore.</summary>
        public VkExternalSemaphoreHandleTypeFlags handleTypes;
    }
    // Struct: 128
    /// <summary>VkExportSemaphoreWin32HandleInfoKHR - Structure specifying additional attributes of Windows handles exported from a semaphore
    /// </summary>
    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pAttributes is a pointer to a Windows SECURITY_ATTRIBUTES
        /// structure specifying security attributes of the handle.</summary>
        public /*-const-*/ SECURITY_ATTRIBUTES* pAttributes;
        /// <summary> dwAccess is a DWORD specifying access rights of the handle.</summary>
        public DWORD dwAccess;
        /// <summary> name is a NULL-terminated UTF-16 string to associate with the
        /// underlying synchronization primitive referenced by NT handles exported
        /// from the created semaphore.</summary>
        public LPCWSTR name;
    }
    // Struct: 129
    /// <summary>VkExtensionProperties - Structure specifying an extension properties
    /// </summary>
    public unsafe struct VkExtensionProperties {
        public fixed char extensionName[VK_MAX_EXTENSION_NAME_SIZE];
        /// <summary> specVersion is the version of this extension.
        /// It is an integer, incremented with backward compatible changes.</summary>
        public UInt32 specVersion;
    }
    // Struct: 130
    /// <summary>VkExtent2D - Structure specifying a two-dimensional extent
    /// </summary>
    public unsafe struct VkExtent2D {
        /// <summary> width is the width of the extent.</summary>
        public UInt32 width;
        /// <summary> height is the height of the extent.</summary>
        public UInt32 height;
    }
    // Struct: 131
    /// <summary>VkExtent3D - Structure specifying a three-dimensional extent
    /// </summary>
    public unsafe struct VkExtent3D {
        /// <summary> width is the width of the extent.</summary>
        public UInt32 width;
        /// <summary> height is the height of the extent.</summary>
        public UInt32 height;
        /// <summary> depth is the depth of the extent.</summary>
        public UInt32 depth;
    }
    // Struct: 132
    /// <summary>VkExternalBufferProperties - Structure specifying supported external handle capabilities
    /// </summary>
    public unsafe struct VkExternalBufferProperties {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> externalMemoryProperties is an instance of the
        /// VkExternalMemoryProperties structure specifying various
        /// capabilities of the external handle type when used with the specified
        /// buffer creation parameters.</summary>
        public VkExternalMemoryProperties externalMemoryProperties;
    }
    // Struct: 133
    /// <summary>VkExternalFenceProperties - Structure describing supported external fence handle features
    /// </summary>
    public unsafe struct VkExternalFenceProperties {
        public VkStructureType sType;
        public void* pNext;
        /// <summary> exportFromImportedHandleTypes is a bitmask of
        /// VkExternalFenceHandleTypeFlagBits indicating which types of
        /// imported handle handleType can be exported from.</summary>
        public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
        /// <summary> compatibleHandleTypes is a bitmask of
        /// VkExternalFenceHandleTypeFlagBits specifying handle types which
        /// can be specified at the same time as handleType when creating a
        /// fence.</summary>
        public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
        /// <summary> externalFenceFeatures is a bitmask of
        /// VkExternalFenceFeatureFlagBits indicating the features of
        /// handleType.</summary>
        public VkExternalFenceFeatureFlags externalFenceFeatures;
    }
    // Struct: 134
    /// <summary>VkExternalFormatANDROID - Structure containing an Android hardware buffer external format
    /// </summary>
    public unsafe struct VkExternalFormatANDROID {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> externalFormat is an implementation-defined identifier for the
        /// external format</summary>
        public UInt64 externalFormat;
    }
    // Struct: 135
    /// <summary>VkExternalImageFormatProperties - Structure specifying supported external handle properties
    /// </summary>
    public unsafe struct VkExternalImageFormatProperties {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> externalMemoryProperties is an instance of the
        /// VkExternalMemoryProperties structure specifying various
        /// capabilities of the external handle type when used with the specified
        /// image creation parameters.</summary>
        public VkExternalMemoryProperties externalMemoryProperties;
    }
    // Struct: 136
    /// <summary>VkExternalImageFormatPropertiesNV - Structure specifying external image format properties
    /// </summary>
    public unsafe struct VkExternalImageFormatPropertiesNV {
        /// <summary> imageFormatProperties will be filled in as when calling
        /// vkGetPhysicalDeviceImageFormatProperties, but the values returned
        /// may vary depending on the external handle type requested.</summary>
        public VkImageFormatProperties imageFormatProperties;
        /// <summary> externalMemoryFeatures is a bitmask of
        /// VkExternalMemoryFeatureFlagBitsNV, indicating properties of the
        /// external memory handle type
        /// (vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType)
        /// being queried, or 0 if the external memory handle type is 0.</summary>
        public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
        /// <summary> exportFromImportedHandleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for
        /// every external handle type that may be used to create memory from which
        /// the handles of the type specified in
        /// vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType can be exported, or 0 if the external memory handle type is 0.</summary>
        public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
        /// <summary> compatibleHandleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for
        /// every external handle type that may be specified simultaneously with
        /// the handle type specified by
        /// vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType
        /// when calling vkAllocateMemory, or 0 if the external memory handle
        /// type is 0.
        /// compatibleHandleTypes will always contain
        /// vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType </summary>
        public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }
    // Struct: 137
    /// <summary>VkExternalMemoryBufferCreateInfo - Specify that a buffer may be backed by external memory
    /// </summary>
    public unsafe struct VkExternalMemoryBufferCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBits specifying one or more external
        /// memory handle types.</summary>
        public VkExternalMemoryHandleTypeFlags handleTypes;
    }
    // Struct: 138
    /// <summary>VkExternalMemoryImageCreateInfo - Specify that an image may be backed by external memory
    /// </summary>
    public unsafe struct VkExternalMemoryImageCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBits specifying one or more external
        /// memory handle types.</summary>
        public VkExternalMemoryHandleTypeFlags handleTypes;
    }
    // Struct: 139
    /// <summary>VkExternalMemoryImageCreateInfoNV - Specify that an image may be backed by external memory
    /// </summary>
    public unsafe struct VkExternalMemoryImageCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBitsNV specifying one or more
        /// external memory handle types.</summary>
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
    }
    // Struct: 140
    /// <summary>VkExternalMemoryProperties - Structure specifying external memory handle type capabilities
    /// </summary>
    public unsafe struct VkExternalMemoryProperties {
        /// <summary> externalMemoryFeatures is a bitmask of
        /// VkExternalMemoryFeatureFlagBits specifying the features of
        /// handleType.</summary>
        public VkExternalMemoryFeatureFlags externalMemoryFeatures;
        /// <summary> exportFromImportedHandleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBits specifying which types of
        /// imported handle handleType can be exported from.</summary>
        public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
        /// <summary> compatibleHandleTypes is a bitmask of
        /// VkExternalMemoryHandleTypeFlagBits specifying handle types which
        /// can be specified at the same time as handleType when creating an
        /// image compatible with external memory.</summary>
        public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
    }
    // Struct: 141
    /// <summary>VkExternalSemaphoreProperties - Structure describing supported external semaphore handle features
    /// </summary>
    public unsafe struct VkExternalSemaphoreProperties {
        public VkStructureType sType;
        public void* pNext;
        /// <summary> exportFromImportedHandleTypes is a bitmask of
        /// VkExternalSemaphoreHandleTypeFlagBits specifying which types of
        /// imported handle handleType can be exported from.</summary>
        public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
        /// <summary> compatibleHandleTypes is a bitmask of
        /// VkExternalSemaphoreHandleTypeFlagBits specifying handle types
        /// which can be specified at the same time as handleType when
        /// creating a semaphore.</summary>
        public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
        /// <summary> externalSemaphoreFeatures is a bitmask of
        /// VkExternalSemaphoreFeatureFlagBits describing the features of
        /// handleType.</summary>
        public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
    }
    // Struct: 142
    /// <summary>VkFenceCreateInfo - Structure specifying parameters of a newly created fence
    /// </summary>
    public unsafe struct VkFenceCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkFenceCreateFlagBits specifying the
        /// initial state and behavior of the fence.</summary>
        public VkFenceCreateFlags flags;
    }
    // Struct: 143
    /// <summary>VkFenceGetFdInfoKHR - Structure describing a POSIX FD fence export operation
    /// </summary>
    public unsafe struct VkFenceGetFdInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> fence is the fence from which state will be exported.</summary>
        public VkFence fence;
        /// <summary> handleType is the type of handle requested.</summary>
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    // Struct: 144
    /// <summary>VkFenceGetWin32HandleInfoKHR - Structure describing a Win32 handle fence export operation
    /// </summary>
    public unsafe struct VkFenceGetWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> fence is the fence from which state will be exported.</summary>
        public VkFence fence;
        /// <summary> handleType is the type of handle requested.</summary>
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    // Struct: 145
    /// <summary>VkFilterCubicImageViewImageFormatPropertiesEXT - Structure for querying cubic filtering capabilities of an image view type
    /// </summary>
    public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> filterCubic tells if image format, image type and image view type
        /// can be used with cubic filtering.
        /// This field is set by the implementation.
        /// User-specified value is ignored.</summary>
        public VkBool32 filterCubic;
        /// <summary> filterCubicMinmax tells if image format, image type and image view
        /// type can be used with cubic filtering and minmax filtering.
        /// This field is set by the implementation.
        /// User-specified value is ignored.</summary>
        public VkBool32 filterCubicMinmax;
    }
    // Struct: 146
    /// <summary>VkFormatProperties - Structure specifying image format properties
    /// </summary>
    public unsafe struct VkFormatProperties {
        /// <summary> linearTilingFeatures is a bitmask of VkFormatFeatureFlagBits
        /// specifying features supported by images created with a tiling
        /// parameter of VK_IMAGE_TILING_LINEAR.</summary>
        public VkFormatFeatureFlags linearTilingFeatures;
        /// <summary> optimalTilingFeatures is a bitmask of
        /// VkFormatFeatureFlagBits specifying features supported by images
        /// created with a tiling parameter of VK_IMAGE_TILING_OPTIMAL.</summary>
        public VkFormatFeatureFlags optimalTilingFeatures;
        /// <summary> bufferFeatures is a bitmask of VkFormatFeatureFlagBits
        /// specifying features supported by buffers.</summary>
        public VkFormatFeatureFlags bufferFeatures;
    }
    // Struct: 147
    /// <summary>VkFormatProperties2 - Structure specifying image format properties
    /// </summary>
    public unsafe struct VkFormatProperties2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> formatProperties is a structure of type VkFormatProperties
        /// describing features supported by the requested format.</summary>
        public VkFormatProperties formatProperties;
    }
    // Struct: 148
    /// <summary>VkFramebufferCreateInfo - Structure specifying parameters of a newly created framebuffer
    /// </summary>
    public unsafe struct VkFramebufferCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkFramebufferCreateFlags flags;
        /// <summary> renderPass is a render pass that defines what render passes the
        /// framebuffer will be compatible with.
        /// See Render Pass Compatibility for details.</summary>
        public VkRenderPass renderPass;
        /// <summary> attachmentCount is the number of attachments.</summary>
        public UInt32 attachmentCount;
        /// <summary> pAttachments is an array of VkImageView handles, each of
        /// which will be used as the corresponding attachment in a render pass
        /// instance.</summary>
        public /*-const-*/ VkImageView* pAttachments;
        /// <summary> width, height and layers define the dimensions of the
        /// framebuffer.
        /// If the render pass uses multiview, then layers must be one and
        /// each attachment requires a number of layers that is greater than the
        /// maximum bit index set in the view mask in the subpasses in which it is
        /// used.</summary>
        public UInt32 width;
        public UInt32 height;
        public UInt32 layers;
    }
    // Struct: 149
    /// <summary>VkGeometryAABBNV - Structure specifying axis-aligned bounding box geometry in a bottom-level acceleration structure
    /// </summary>
    public unsafe struct VkGeometryAABBNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> aabbData is the buffer containing axis-aligned bounding box data.</summary>
        public VkBuffer aabbData;
        /// <summary> numAABBs is the number of AABBs in this geometry.</summary>
        public UInt32 numAABBs;
        /// <summary> stride is the stride in bytes between AABBs in aabbData.</summary>
        public UInt32 stride;
        /// <summary> offset is the offset in bytes of the first AABB in aabbData.</summary>
        public VkDeviceSize offset;
    }
    // Struct: 150
    /// <summary>VkGeometryDataNV - Structure specifying geometry in a bottom-level acceleration structure
    /// </summary>
    public unsafe struct VkGeometryDataNV {
        /// <summary> triangles contains triangle data if
        /// VkGeometryNV::geometryType is
        /// VK_GEOMETRY_TYPE_TRIANGLES_NV.</summary>
        public VkGeometryTrianglesNV triangles;
        /// <summary> aabbs contains axis-aligned bounding box data if
        /// VkGeometryNV::geometryType is
        /// VK_GEOMETRY_TYPE_AABBS_NV.</summary>
        public VkGeometryAABBNV aabbs;
    }
    // Struct: 151
    /// <summary>VkGeometryNV - Structure specifying a geometry in a bottom-level acceleration structure
    /// </summary>
    public unsafe struct VkGeometryNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> geometryType describes which type of geometry this
        /// VkGeometryNV refers to.</summary>
        public VkGeometryTypeNV geometryType;
        /// <summary> geometry contains the geometry data as described in
        /// VkGeometryDataNV.</summary>
        public VkGeometryDataNV geometry;
        /// <summary> flags has flags describing options for this geometry.</summary>
        public VkGeometryFlagsNV flags;
    }
    // Struct: 152
    /// <summary>VkGeometryTrianglesNV - Structure specifying a triangle geometry in a bottom-level acceleration structure
    /// </summary>
    public unsafe struct VkGeometryTrianglesNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> vertexData is the buffer containing vertex data for this geometry.</summary>
        public VkBuffer vertexData;
        /// <summary> vertexOffset is the offset in bytes within vertexData
        /// containing vertex data for this geometry.</summary>
        public VkDeviceSize vertexOffset;
        /// <summary> vertexCount is the number of valid vertices.</summary>
        public UInt32 vertexCount;
        /// <summary> vertexStride is the stride in bytes between each vertex.</summary>
        public VkDeviceSize vertexStride;
        /// <summary> vertexFormat is the format of each vertex element.</summary>
        public VkFormat vertexFormat;
        /// <summary> indexData is the buffer containing index data for this geometry.</summary>
        public VkBuffer indexData;
        /// <summary> indexOffset is the offset in bytes within indexData
        /// containing index data for this geometry.</summary>
        public VkDeviceSize indexOffset;
        /// <summary> indexCount is the number of indices to include in this geometry.</summary>
        public UInt32 indexCount;
        /// <summary> indexType is the format of each index.</summary>
        public VkIndexType indexType;
        /// <summary> transformData is a buffer containing optional reference to an
        /// array of 32-bit floats representing a 3x4 row major affine
        /// transformation matrix for this geometry.</summary>
        public VkBuffer transformData;
        /// <summary> transformOffset is the offset in bytes in transformData of
        /// the transform information described above.</summary>
        public VkDeviceSize transformOffset;
    }
    // Struct: 153
    /// <summary>VkGraphicsPipelineCreateInfo - Structure specifying parameters of a newly created graphics pipeline
    /// </summary>
    public unsafe struct VkGraphicsPipelineCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkPipelineCreateFlagBits specifying
        /// how the pipeline will be generated.</summary>
        public VkPipelineCreateFlags flags;
        /// <summary> stageCount is the number of entries in the pStages array.</summary>
        public UInt32 stageCount;
        /// <summary> pStages is an array of size stageCount structures of type
        /// VkPipelineShaderStageCreateInfo describing the set of the shader
        /// stages to be included in the graphics pipeline.</summary>
        public /*-const-*/ VkPipelineShaderStageCreateInfo* pStages;
        /// <summary> pVertexInputState is a pointer to an instance of the
        /// VkPipelineVertexInputStateCreateInfo structure.
        /// It is ignored if the pipeline includes a mesh shader stage.</summary>
        public /*-const-*/ VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        /// <summary> pInputAssemblyState is a pointer to an instance of the
        /// VkPipelineInputAssemblyStateCreateInfo structure which determines
        /// input assembly behavior, as described in Drawing Commands.
        /// It is ignored if the pipeline includes a mesh shader stage.</summary>
        public /*-const-*/ VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        /// <summary> pTessellationState is a pointer to an instance of the
        /// VkPipelineTessellationStateCreateInfo structure, and is ignored if
        /// the pipeline does not include a tessellation control shader stage and
        /// tessellation evaluation shader stage.</summary>
        public /*-const-*/ VkPipelineTessellationStateCreateInfo* pTessellationState;
        /// <summary> pViewportState is a pointer to an instance of the
        /// VkPipelineViewportStateCreateInfo structure, and is ignored if the
        /// pipeline has rasterization disabled.</summary>
        public /*-const-*/ VkPipelineViewportStateCreateInfo* pViewportState;
        /// <summary> pRasterizationState is a pointer to an instance of the
        /// VkPipelineRasterizationStateCreateInfo structure.</summary>
        public /*-const-*/ VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        /// <summary> pMultisampleState is a pointer to an instance of the
        /// VkPipelineMultisampleStateCreateInfo, and is ignored if the
        /// pipeline has rasterization disabled.</summary>
        public /*-const-*/ VkPipelineMultisampleStateCreateInfo* pMultisampleState;
        /// <summary> pDepthStencilState is a pointer to an instance of the
        /// VkPipelineDepthStencilStateCreateInfo structure, and is ignored if
        /// the pipeline has rasterization disabled or if the subpass of the render
        /// pass the pipeline is created against does not use a depth/stencil
        /// attachment.</summary>
        public /*-const-*/ VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
        /// <summary> pColorBlendState is a pointer to an instance of the
        /// VkPipelineColorBlendStateCreateInfo structure, and is ignored if
        /// the pipeline has rasterization disabled or if the subpass of the render
        /// pass the pipeline is created against does not use any color attachments.</summary>
        public /*-const-*/ VkPipelineColorBlendStateCreateInfo* pColorBlendState;
        /// <summary> pDynamicState is a pointer to
        /// VkPipelineDynamicStateCreateInfo and is used to indicate which
        /// properties of the pipeline state object are dynamic and can be changed
        /// independently of the pipeline state.
        /// This can be NULL, which means no state in the pipeline is considered
        /// dynamic.</summary>
        public /*-const-*/ VkPipelineDynamicStateCreateInfo* pDynamicState;
        /// <summary> layout is the description of binding locations used by both the
        /// pipeline and descriptor sets used with the pipeline.</summary>
        public VkPipelineLayout layout;
        /// <summary> renderPass is a handle to a render pass object describing the
        /// environment in which the pipeline will be used; the pipeline must only
        /// be used with an instance of any render pass compatible with the one
        /// provided.
        /// See Render Pass Compatibility for more
        /// information.</summary>
        public VkRenderPass renderPass;
        /// <summary> subpass is the index of the subpass in the render pass where this
        /// pipeline will be used.</summary>
        public UInt32 subpass;
        /// <summary> basePipelineHandle is a pipeline to derive from.</summary>
        public VkPipeline basePipelineHandle;
        /// <summary> basePipelineIndex is an index into the pCreateInfos
        /// parameter to use as a pipeline to derive from.</summary>
        public Int32 basePipelineIndex;
    }
    // Struct: 154
    /// <summary>VkHdrMetadataEXT - structure to specify Hdr metadata
    /// </summary>
    public unsafe struct VkHdrMetadataEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> displayPrimaryRed is the mastering display’s red primary in
        /// chromaticity coordinates</summary>
        public VkXYColorEXT displayPrimaryRed;
        /// <summary> displayPrimaryGreen is the mastering display’s green primary in
        /// chromaticity coordinates</summary>
        public VkXYColorEXT displayPrimaryGreen;
        /// <summary> displayPrimaryBlue is the mastering display’s blue primary in
        /// chromaticity coordinates</summary>
        public VkXYColorEXT displayPrimaryBlue;
        /// <summary> whitePoint is the mastering display’s white-point in chromaticity
        /// coordinates</summary>
        public VkXYColorEXT whitePoint;
        /// <summary> maxLuminance is the maximum luminance of the mastering display in
        /// nits</summary>
        public float maxLuminance;
        /// <summary> minLuminance is the minimum luminance of the mastering display in
        /// nits</summary>
        public float minLuminance;
        /// <summary> maxContentLightLevel is content’s maximum luminance in nits</summary>
        public float maxContentLightLevel;
        /// <summary> maxFrameAverageLightLevel is the maximum frame average light level
        /// in nits</summary>
        public float maxFrameAverageLightLevel;
    }
    // Struct: 155
    /// <summary>VkIOSSurfaceCreateInfoMVK - Structure specifying parameters of a newly created iOS surface object
    /// </summary>
    public unsafe struct VkIOSSurfaceCreateInfoMVK {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkIOSSurfaceCreateFlagsMVK flags;
        /// <summary> pView is a reference to a UIView object which will display
        /// this surface.
        /// This UIView must be backed by a CALayer instance of type
        /// CAMetalLayer.</summary>
        public /*-const-*/ void* pView;
    }
    // Struct: 156
    /// <summary>VkImageBlit - Structure specifying an image blit operation
    /// </summary>
    public unsafe struct VkImageBlit {
        /// <summary> srcSubresource is the subresource to blit from.</summary>
        public VkImageSubresourceLayers srcSubresource;
        public fixed VkOffset3D srcOffsets[2];
        /// <summary> dstSubresource is the subresource to blit into.</summary>
        public VkImageSubresourceLayers dstSubresource;
        public fixed VkOffset3D dstOffsets[2];
    }
    // Struct: 157
    /// <summary>VkImageCopy - Structure specifying an image copy operation
    /// </summary>
    public unsafe struct VkImageCopy {
        /// <summary> srcSubresource and dstSubresource are
        /// VkImageSubresourceLayers structures specifying the image
        /// subresources of the images used for the source and destination image
        /// data, respectively.</summary>
        public VkImageSubresourceLayers srcSubresource;
        /// <summary> srcOffset and dstOffset select the initial x, y,
        /// and z offsets in texels of the sub-regions of the source and
        /// destination image data.</summary>
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        /// <summary> extent is the size in texels of the image to copy in width,
        /// height and depth.</summary>
        public VkExtent3D extent;
    }
    // Struct: 158
    /// <summary>VkImageCreateInfo - Structure specifying the parameters of a newly created image object
    /// </summary>
    public unsafe struct VkImageCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkImageCreateFlagBits describing
        /// additional parameters of the image.</summary>
        public VkImageCreateFlags flags;
        /// <summary> imageType is a VkImageType value specifying the basic
        /// dimensionality of the image.
        /// Layers in array textures do not count as a dimension for the purposes of
        /// the image type.</summary>
        public VkImageType imageType;
        /// <summary> format is a VkFormat describing the format and type of the
        /// texel blocks that will be contained in the image.</summary>
        public VkFormat format;
        /// <summary> extent is a VkExtent3D describing the number of data
        /// elements in each dimension of the base level.</summary>
        public VkExtent3D extent;
        /// <summary> mipLevels describes the number of levels of detail available for
        /// minified sampling of the image.</summary>
        public UInt32 mipLevels;
        /// <summary> arrayLayers is the number of layers in the image.</summary>
        public UInt32 arrayLayers;
        /// <summary> samples is a VkSampleCountFlagBits specifying the number of
        /// samples per texel.</summary>
        public VkSampleCountFlagBits samples;
        /// <summary> tiling is a VkImageTiling value specifying the tiling
        /// arrangement of the texel blocks in memory.</summary>
        public VkImageTiling tiling;
        /// <summary> usage is a bitmask of VkImageUsageFlagBits describing the
        /// intended usage of the image.</summary>
        public VkImageUsageFlags usage;
        /// <summary> sharingMode is a VkSharingMode value specifying the sharing
        /// mode of the image when it will be accessed by multiple queue families.</summary>
        public VkSharingMode sharingMode;
        /// <summary> queueFamilyIndexCount is the number of entries in the
        /// pQueueFamilyIndices array.</summary>
        public UInt32 queueFamilyIndexCount;
        /// <summary> pQueueFamilyIndices is a list of queue families that will access
        /// this image (ignored if sharingMode is not
        /// VK_SHARING_MODE_CONCURRENT).</summary>
        public /*-const-*/ UInt32* pQueueFamilyIndices;
        /// <summary> initialLayout is a VkImageLayout value specifying the
        /// initial VkImageLayout of all image subresources of the image.
        /// See Image Layouts.</summary>
        public VkImageLayout initialLayout;
    }
    // Struct: 159
    /// <summary>VkImageDrmFormatModifierExplicitCreateInfoEXT - Specify that an image be created with the provided DRM format modifier and explicit memory layout
    /// </summary>
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> drmFormatModifier is the Linux DRM format modifier with which
        /// the image will be created.</summary>
        public UInt64 drmFormatModifier;
        /// <summary> drmFormatModifierPlaneCount is the number of memory planes in
        /// the image (as reported by VkDrmFormatModifierPropertiesEXT) as
        /// well as the length of the pPlaneLayouts array.</summary>
        public UInt32 drmFormatModifierPlaneCount;
        /// <summary> pPlaneLayouts is an array of VkSubresourceLayout structures
        /// that describe the image’s memory planes.</summary>
        public /*-const-*/ VkSubresourceLayout* pPlaneLayouts;
    }
    // Struct: 160
    /// <summary>VkImageDrmFormatModifierListCreateInfoEXT - Specify that an image must be created with a DRM format modifier from the provided list
    /// </summary>
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> drmFormatModifierCount is the length of the
        /// pDrmFormatModifiers array.</summary>
        public UInt32 drmFormatModifierCount;
        /// <summary> pDrmFormatModifiers is an array of Linux DRM format modifiers.</summary>
        public /*-const-*/ UInt64* pDrmFormatModifiers;
    }
    // Struct: 161
    /// <summary>VkImageDrmFormatModifierPropertiesEXT - Properties of an image’s Linux DRM format modifier
    /// </summary>
    public unsafe struct VkImageDrmFormatModifierPropertiesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> drmFormatModifier returns the image’s
        /// Linux DRM format modifier.</summary>
        public UInt64 drmFormatModifier;
    }
    // Struct: 162
    /// <summary>VkImageFormatListCreateInfoKHR - Specify that an image <strong class="purple">can</strong> be used with a particular set of formats
    /// </summary>
    public unsafe struct VkImageFormatListCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> viewFormatCount is the number of entries in the pViewFormats
        /// array.</summary>
        public UInt32 viewFormatCount;
        /// <summary> pViewFormats is an array which lists of all formats which can be
        /// used when creating views of this image.</summary>
        public /*-const-*/ VkFormat* pViewFormats;
    }
    // Struct: 163
    /// <summary>VkImageFormatProperties - Structure specifying an image format properties
    /// </summary>
    public unsafe struct VkImageFormatProperties {
        /// <summary> maxExtent are the maximum image dimensions.
        /// See the Allowed Extent Values section
        /// below for how these values are constrained by type.</summary>
        public VkExtent3D maxExtent;
        /// <summary> maxMipLevels is the maximum number of mipmap levels.
        /// maxMipLevels must be equal to the number of levels in the
        /// complete mipmap chain based on the  maxExtent.width ,
        ///  maxExtent.height , and  maxExtent.depth , except
        /// when one of the following conditions is true, in which case it may
        /// instead be 1:</summary>
        public UInt32 maxMipLevels;
        /// <summary> maxArrayLayers is the maximum number of array layers.
        /// maxArrayLayers must be no less than
        /// VkPhysicalDeviceLimits::maxImageArrayLayers, except when one
        /// of the following conditions is true, in which case it may instead be
        /// 1:</summary>
        public UInt32 maxArrayLayers;
        /// <summary> sampleCounts is a bitmask of VkSampleCountFlagBits
        /// specifying all the supported sample counts for this image as described
        /// below.</summary>
        public VkSampleCountFlags sampleCounts;
        /// <summary> maxResourceSize is an upper bound on the total image size in
        /// bytes, inclusive of all image subresources.
        /// Implementations may have an address space limit on total size of a
        /// resource, which is advertised by this property.
        /// maxResourceSize must be at least 231.</summary>
        public VkDeviceSize maxResourceSize;
    }
    // Struct: 164
    /// <summary>VkImageFormatProperties2 - Structure specifying an image format properties
    /// </summary>
    public unsafe struct VkImageFormatProperties2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.
        /// The pNext chain of VkImageFormatProperties2 is used to allow
        /// the specification of additional capabilities to be returned from
        /// vkGetPhysicalDeviceImageFormatProperties2.</summary>
        public void* pNext;
        /// <summary> imageFormatProperties is an instance of a
        /// VkImageFormatProperties structure in which capabilities are
        /// returned.</summary>
        public VkImageFormatProperties imageFormatProperties;
    }
    // Struct: 165
    /// <summary>VkImageMemoryBarrier - Structure specifying the parameters of an image memory barrier
    /// </summary>
    public unsafe struct VkImageMemoryBarrier {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// source access mask.</summary>
        public VkAccessFlags srcAccessMask;
        /// <summary> dstAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// destination access mask.</summary>
        public VkAccessFlags dstAccessMask;
        /// <summary> oldLayout is the old layout in an
        /// image layout transition.</summary>
        public VkImageLayout oldLayout;
        /// <summary> newLayout is the new layout in an
        /// image layout transition.</summary>
        public VkImageLayout newLayout;
        /// <summary> srcQueueFamilyIndex is the source queue family for a
        /// queue family ownership transfer.</summary>
        public UInt32 srcQueueFamilyIndex;
        /// <summary> dstQueueFamilyIndex is the destination queue family for a
        /// queue family ownership transfer.</summary>
        public UInt32 dstQueueFamilyIndex;
        /// <summary> image is a handle to the image affected by this barrier.</summary>
        public VkImage image;
        /// <summary> subresourceRange describes the image
        /// subresource range within image that is affected by this barrier.</summary>
        public VkImageSubresourceRange subresourceRange;
    }
    // Struct: 166
    /// <summary>VkImageMemoryRequirementsInfo2 - (None)
    /// </summary>
    public unsafe struct VkImageMemoryRequirementsInfo2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> image is the image to query.</summary>
        public VkImage image;
    }
    // Struct: 167
    /// <summary>VkImagePipeSurfaceCreateInfoFUCHSIA - Structure specifying parameters of a newly created ImagePipe surface object
    /// </summary>
    public unsafe struct VkImagePipeSurfaceCreateInfoFUCHSIA {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkImagePipeSurfaceCreateFlagsFUCHSIA flags;
        /// <summary> imagePipeHandle is a zx_handle_t referring to the ImagePipe
        /// to associate with the surface.</summary>
        public zx_handle_t imagePipeHandle;
    }
    // Struct: 168
    /// <summary>VkImagePlaneMemoryRequirementsInfo - Structure specifying image plane for memory requirements
    /// </summary>
    public unsafe struct VkImagePlaneMemoryRequirementsInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> planeAspect is the aspect corresponding to the image plane to
        /// query.</summary>
        public VkImageAspectFlagBits planeAspect;
    }
    // Struct: 169
    /// <summary>VkImageResolve - Structure specifying an image resolve operation
    /// </summary>
    public unsafe struct VkImageResolve {
        /// <summary> srcSubresource and dstSubresource are
        /// VkImageSubresourceLayers structures specifying the image
        /// subresources of the images used for the source and destination image
        /// data, respectively.
        /// Resolve of depth/stencil images is not supported.</summary>
        public VkImageSubresourceLayers srcSubresource;
        /// <summary> srcOffset and dstOffset select the initial x, y,
        /// and z offsets in texels of the sub-regions of the source and
        /// destination image data.</summary>
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        /// <summary> extent is the size in texels of the source image to resolve in
        /// width, height and depth.</summary>
        public VkExtent3D extent;
    }
    // Struct: 170
    /// <summary>VkImageSparseMemoryRequirementsInfo2 - (None)
    /// </summary>
    public unsafe struct VkImageSparseMemoryRequirementsInfo2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> image is the image to query.</summary>
        public VkImage image;
    }
    // Struct: 171
    /// <summary>VkImageStencilUsageCreateInfoEXT - Specify separate usage flags for the stencil aspect of a depth-stencil image
    /// </summary>
    public unsafe struct VkImageStencilUsageCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> stencilUsage is a bitmask of VkImageUsageFlagBits describing
        /// the intended usage of the stencil aspect of the image.</summary>
        public VkImageUsageFlags stencilUsage;
    }
    // Struct: 172
    /// <summary>VkImageSubresource - Structure specifying an image subresource
    /// </summary>
    public unsafe struct VkImageSubresource {
        /// <summary> aspectMask is a VkImageAspectFlags selecting the image
        /// aspect.</summary>
        public VkImageAspectFlags aspectMask;
        /// <summary> mipLevel selects the mipmap level.</summary>
        public UInt32 mipLevel;
        /// <summary> arrayLayer selects the array layer.</summary>
        public UInt32 arrayLayer;
    }
    // Struct: 173
    /// <summary>VkImageSubresourceLayers - Structure specifying an image subresource layers
    /// </summary>
    public unsafe struct VkImageSubresourceLayers {
        /// <summary> aspectMask is a combination of VkImageAspectFlagBits,
        /// selecting the color, depth and/or stencil aspects to be copied.</summary>
        public VkImageAspectFlags aspectMask;
        /// <summary> mipLevel is the mipmap level to copy from.</summary>
        public UInt32 mipLevel;
        /// <summary> baseArrayLayer and layerCount are the starting layer and
        /// number of layers to copy.</summary>
        public UInt32 baseArrayLayer;
        public UInt32 layerCount;
    }
    // Struct: 174
    /// <summary>VkImageSubresourceRange - Structure specifying an image subresource range
    /// </summary>
    public unsafe struct VkImageSubresourceRange {
        /// <summary> aspectMask is a bitmask of VkImageAspectFlagBits specifying
        /// which aspect(s) of the image are included in the view.</summary>
        public VkImageAspectFlags aspectMask;
        /// <summary> baseMipLevel is the first mipmap level accessible to the view.</summary>
        public UInt32 baseMipLevel;
        /// <summary> levelCount is the number of mipmap levels (starting from
        /// baseMipLevel) accessible to the view.</summary>
        public UInt32 levelCount;
        /// <summary> baseArrayLayer is the first array layer accessible to the view.</summary>
        public UInt32 baseArrayLayer;
        /// <summary> layerCount is the number of array layers (starting from
        /// baseArrayLayer) accessible to the view.</summary>
        public UInt32 layerCount;
    }
    // Struct: 175
    /// <summary>VkImageSwapchainCreateInfoKHR - Specify that an image will be bound to swapchain memory
    /// </summary>
    public unsafe struct VkImageSwapchainCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> swapchain is VK_NULL_HANDLE or a handle of a swapchain that
        /// the image will be bound to.</summary>
        public VkSwapchainKHR swapchain;
    }
    // Struct: 176
    /// <summary>VkImageViewASTCDecodeModeEXT - Structure describing the ASTC decode mode for an image view
    /// </summary>
    public unsafe struct VkImageViewASTCDecodeModeEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> decodeMode is the intermediate format used to decode ASTC
        /// compressed formats.</summary>
        public VkFormat decodeMode;
    }
    // Struct: 177
    /// <summary>VkImageViewCreateInfo - Structure specifying parameters of a newly created image view
    /// </summary>
    public unsafe struct VkImageViewCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkImageViewCreateFlagBits describing
        /// additional parameters of the image view.</summary>
        public VkImageViewCreateFlags flags;
        /// <summary> image is a VkImage on which the view will be created.</summary>
        public VkImage image;
        /// <summary> viewType is a VkImageViewType value specifying the type of
        /// the image view.</summary>
        public VkImageViewType viewType;
        /// <summary> format is a VkFormat describing the format and type used to
        /// interpret texel blocks in the image.</summary>
        public VkFormat format;
        /// <summary> components is a VkComponentMapping specifies a remapping of
        /// color components (or of depth or stencil components after they have been
        /// converted into color components).</summary>
        public VkComponentMapping components;
        /// <summary> subresourceRange is a VkImageSubresourceRange selecting the
        /// set of mipmap levels and array layers to be accessible to the view.</summary>
        public VkImageSubresourceRange subresourceRange;
    }
    // Struct: 178
    /// <summary>VkImageViewHandleInfoNVX - Structure specifying the image view for handle queries
    /// </summary>
    public unsafe struct VkImageViewHandleInfoNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> imageView is the image view to query.</summary>
        public VkImageView imageView;
        /// <summary> descriptorType is the type of descriptor for which to query a
        /// handle.</summary>
        public VkDescriptorType descriptorType;
        /// <summary> sampler is the sampler to combine with the image view when
        /// generating the handle.</summary>
        public VkSampler sampler;
    }
    // Struct: 179
    /// <summary>VkImageViewUsageCreateInfo - Specify the intended usage of an image view
    /// </summary>
    public unsafe struct VkImageViewUsageCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> usage is a bitmask describing the allowed usages of the image
        /// view.
        /// See VkImageUsageFlagBits for a description of the supported bits.</summary>
        public VkImageUsageFlags usage;
    }
    // Struct: 180
    /// <summary>VkImportAndroidHardwareBufferInfoANDROID - Import memory from an Android hardware buffer
    /// </summary>
    public unsafe struct VkImportAndroidHardwareBufferInfoANDROID {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> buffer is the Android hardware buffer to import.</summary>
        public /*-struct-*/ AHardwareBuffer* buffer;
    }
    // Struct: 181
    /// <summary>VkImportFenceFdInfoKHR - (None)
    /// </summary>
    public unsafe struct VkImportFenceFdInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> fence is the fence into which the payload will be imported.</summary>
        public VkFence fence;
        /// <summary> flags is a bitmask of VkFenceImportFlagBits specifying
        /// additional parameters for the fence payload import operation.</summary>
        public VkFenceImportFlags flags;
        /// <summary> handleType specifies the type of fd.</summary>
        public VkExternalFenceHandleTypeFlagBits handleType;
        /// <summary> fd is the external handle to import.</summary>
        public int fd;
    }
    // Struct: 182
    /// <summary>VkImportFenceWin32HandleInfoKHR - (None)
    /// </summary>
    public unsafe struct VkImportFenceWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> fence is the fence into which the state will be imported.</summary>
        public VkFence fence;
        /// <summary> flags is a bitmask of VkFenceImportFlagBits specifying
        /// additional parameters for the fence payload import operation.</summary>
        public VkFenceImportFlags flags;
        /// <summary> handleType specifies the type of handle.</summary>
        public VkExternalFenceHandleTypeFlagBits handleType;
        /// <summary> handle is the external handle to import, or NULL.</summary>
        public HANDLE handle;
        /// <summary> name is the NULL-terminated UTF-16 string naming the underlying
        /// synchronization primitive to import, or NULL.</summary>
        public LPCWSTR name;
    }
    // Struct: 183
    /// <summary>VkImportMemoryFdInfoKHR - import memory created on the same physical device from a file descriptor
    /// </summary>
    public unsafe struct VkImportMemoryFdInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType specifies the handle type of fd.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
        /// <summary> fd is the external handle to import.</summary>
        public int fd;
    }
    // Struct: 184
    /// <summary>VkImportMemoryHostPointerInfoEXT - import memory from a host pointer
    /// </summary>
    public unsafe struct VkImportMemoryHostPointerInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType specifies the handle type.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
        /// <summary> pHostPointer is the host pointer to import from.</summary>
        public void* pHostPointer;
    }
    // Struct: 185
    /// <summary>VkImportMemoryWin32HandleInfoKHR - import Win32 memory created on the same physical device
    /// </summary>
    public unsafe struct VkImportMemoryWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType specifies the type of handle or name.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
        /// <summary> handle is the external handle to import, or NULL.</summary>
        public HANDLE handle;
        /// <summary> name is a NULL-terminated UTF-16 string naming the underlying
        /// memory resource to import, or NULL.</summary>
        public LPCWSTR name;
    }
    // Struct: 186
    /// <summary>VkImportMemoryWin32HandleInfoNV - import Win32 memory created on the same physical device
    /// </summary>
    public unsafe struct VkImportMemoryWin32HandleInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType is 0 or a VkExternalMemoryHandleTypeFlagBitsNV
        /// value specifying the type of memory handle in handle.</summary>
        public VkExternalMemoryHandleTypeFlagsNV handleType;
        /// <summary> handle is a Windows HANDLE referring to the memory.</summary>
        public HANDLE handle;
    }
    // Struct: 187
    /// <summary>VkImportSemaphoreFdInfoKHR - Structure specifying POSIX file descriptor to import to a semaphore
    /// </summary>
    public unsafe struct VkImportSemaphoreFdInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> semaphore is the semaphore into which the payload will be
        /// imported.</summary>
        public VkSemaphore semaphore;
        /// <summary> flags is a bitmask of VkSemaphoreImportFlagBits specifying
        /// additional parameters for the semaphore payload import operation.</summary>
        public VkSemaphoreImportFlags flags;
        /// <summary> handleType specifies the type of fd.</summary>
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        /// <summary> fd is the external handle to import.</summary>
        public int fd;
    }
    // Struct: 188
    /// <summary>VkImportSemaphoreWin32HandleInfoKHR - Structure specifying Windows handle to import to a semaphore
    /// </summary>
    public unsafe struct VkImportSemaphoreWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> semaphore is the semaphore into which the payload will be
        /// imported.</summary>
        public VkSemaphore semaphore;
        /// <summary> flags is a bitmask of VkSemaphoreImportFlagBits specifying
        /// additional parameters for the semaphore payload import operation.</summary>
        public VkSemaphoreImportFlags flags;
        /// <summary> handleType specifies the type of handle.</summary>
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        /// <summary> handle is the external handle to import, or NULL.</summary>
        public HANDLE handle;
        /// <summary> name is a NULL-terminated UTF-16 string naming the underlying
        /// synchronization primitive to import, or NULL.</summary>
        public LPCWSTR name;
    }
    // Struct: 189
    /// <summary>VkIndirectCommandsLayoutCreateInfoNVX - Structure specifying the parameters of a newly created indirect commands layout object
    /// </summary>
    public unsafe struct VkIndirectCommandsLayoutCreateInfoNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pipelineBindPoint is the VkPipelineBindPoint that this
        /// layout targets.</summary>
        public VkPipelineBindPoint pipelineBindPoint;
        /// <summary> flags is a bitmask of
        /// VkIndirectCommandsLayoutUsageFlagBitsNVX specifying usage hints of
        /// this layout.</summary>
        public VkIndirectCommandsLayoutUsageFlagsNVX flags;
        /// <summary> tokenCount is the length of the individual command sequnce.</summary>
        public UInt32 tokenCount;
        /// <summary> pTokens is an array describing each command token in detail.
        /// See VkIndirectCommandsTokenTypeNVX and
        /// VkIndirectCommandsLayoutTokenNVX below for details.</summary>
        public /*-const-*/ VkIndirectCommandsLayoutTokenNVX* pTokens;
    }
    // Struct: 190
    /// <summary>VkIndirectCommandsLayoutTokenNVX - Struct specifying the details of an indirect command layout token
    /// </summary>
    public unsafe struct VkIndirectCommandsLayoutTokenNVX {
        public VkIndirectCommandsTokenTypeNVX tokenType;
        /// <summary> bindingUnit has a different meaning depending on the type, please
        /// refer pseudo code further down for details.</summary>
        public UInt32 bindingUnit;
        /// <summary> dynamicCount has a different meaning depending on the type, please
        /// refer pseudo code further down for details.</summary>
        public UInt32 dynamicCount;
        /// <summary> divisor defines the rate at which the input data buffers are
        /// accessed.</summary>
        public UInt32 divisor;
    }
    // Struct: 191
    /// <summary>VkIndirectCommandsTokenNVX - Structure specifying parameters for the reservation of command buffer space
    /// </summary>
    public unsafe struct VkIndirectCommandsTokenNVX {
        /// <summary> tokenType specifies the token command type.</summary>
        public VkIndirectCommandsTokenTypeNVX tokenType;
        /// <summary> buffer specifies the VkBuffer storing the functional
        /// arguments for each squence.
        /// These argumetns can be written by the device.</summary>
        public VkBuffer buffer;
        /// <summary> offset specified an offset into buffer where the arguments
        /// start.</summary>
        public VkDeviceSize offset;
    }
    // Struct: 192
    /// <summary>VkInputAttachmentAspectReference - Structure specifying a subpass/input attachment pair and an aspect mask that <strong class="purple">can</strong> be read.
    /// </summary>
    public unsafe struct VkInputAttachmentAspectReference {
        /// <summary> subpass is an index into the pSubpasses array of the parent
        /// VkRenderPassCreateInfo structure.</summary>
        public UInt32 subpass;
        /// <summary> inputAttachmentIndex is an index into the pInputAttachments
        /// of the specified subpass.</summary>
        public UInt32 inputAttachmentIndex;
        /// <summary> aspectMask is a mask of which aspect(s) can be accessed within
        /// the specified subpass.</summary>
        public VkImageAspectFlags aspectMask;
    }
    // Struct: 193
    /// <summary>VkInstanceCreateInfo - Structure specifying parameters of a newly created instance
    /// </summary>
    public unsafe struct VkInstanceCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkInstanceCreateFlags flags;
        /// <summary> pApplicationInfo is NULL or a pointer to an instance of
        /// VkApplicationInfo.
        /// If not NULL, this information helps implementations recognize behavior
        /// inherent to classes of applications.
        /// VkApplicationInfo is defined in detail below.</summary>
        public /*-const-*/ VkApplicationInfo* pApplicationInfo;
        /// <summary> enabledLayerCount is the number of global layers to enable.</summary>
        public UInt32 enabledLayerCount;
        /// <summary> ppEnabledLayerNames is a pointer to an array of
        /// enabledLayerCount null-terminated UTF-8 strings containing the
        /// names of layers to enable for the created instance.
        /// See the html/vkspec.html#extendingvulkan-layers section for further details.</summary>
        public IntPtr /*-const-*/ * ppEnabledLayerNames;
        /// <summary> enabledExtensionCount is the number of global extensions to
        /// enable.</summary>
        public UInt32 enabledExtensionCount;
        /// <summary> ppEnabledExtensionNames is a pointer to an array of
        /// enabledExtensionCount null-terminated UTF-8 strings containing the
        /// names of extensions to enable.</summary>
        public IntPtr /*-const-*/ * ppEnabledExtensionNames;
    }
    // Struct: 194
    /// <summary>VkLayerProperties - Structure specifying layer properties
    /// </summary>
    public unsafe struct VkLayerProperties {
        public fixed char layerName[VK_MAX_EXTENSION_NAME_SIZE];
        /// <summary> specVersion is the Vulkan version the layer was written to,
        /// encoded as described in html/vkspec.html#extendingvulkan-coreversions-versionnumbers.</summary>
        public UInt32 specVersion;
        /// <summary> implementationVersion is the version of this layer.
        /// It is an integer, increasing with backward compatible changes.</summary>
        public UInt32 implementationVersion;
        public fixed char description[VK_MAX_DESCRIPTION_SIZE];
    }
    // Struct: 195
    /// <summary>VkMacOSSurfaceCreateInfoMVK - Structure specifying parameters of a newly created macOS surface object
    /// </summary>
    public unsafe struct VkMacOSSurfaceCreateInfoMVK {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkMacOSSurfaceCreateFlagsMVK flags;
        /// <summary> pView is a reference to a NSView object which will display
        /// this surface.
        /// This NSView must be backed by a CALayer instance of type
        /// CAMetalLayer.</summary>
        public /*-const-*/ void* pView;
    }
    // Struct: 196
    /// <summary>VkMappedMemoryRange - Structure specifying a mapped memory range
    /// </summary>
    public unsafe struct VkMappedMemoryRange {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> memory is the memory object to which this range belongs.</summary>
        public VkDeviceMemory memory;
        /// <summary> offset is the zero-based byte offset from the beginning of the
        /// memory object.</summary>
        public VkDeviceSize offset;
        /// <summary> size is either the size of range, or VK_WHOLE_SIZE to affect
        /// the range from offset to the end of the current mapping of the
        /// allocation.</summary>
        public VkDeviceSize size;
    }
    // Struct: 197
    /// <summary>VkMemoryAllocateFlagsInfo - Structure controlling how many instances of memory will be allocated
    /// </summary>
    public unsafe struct VkMemoryAllocateFlagsInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkMemoryAllocateFlagBits controlling
        /// the allocation.</summary>
        public VkMemoryAllocateFlags flags;
        /// <summary> deviceMask is a mask of physical devices in the logical device,
        /// indicating that memory must be allocated on each device in the mask, if
        /// VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT is set in flags.</summary>
        public UInt32 deviceMask;
    }
    // Struct: 198
    /// <summary>VkMemoryAllocateInfo - Structure containing parameters of a memory allocation
    /// </summary>
    public unsafe struct VkMemoryAllocateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> allocationSize is the size of the allocation in bytes</summary>
        public VkDeviceSize allocationSize;
        /// <summary> memoryTypeIndex is an index identifying a memory type from the
        /// memoryTypes array of the VkPhysicalDeviceMemoryProperties
        /// structure</summary>
        public UInt32 memoryTypeIndex;
    }
    // Struct: 199
    /// <summary>VkMemoryBarrier - Structure specifying a global memory barrier
    /// </summary>
    public unsafe struct VkMemoryBarrier {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// source access mask.</summary>
        public VkAccessFlags srcAccessMask;
        /// <summary> dstAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// destination access mask.</summary>
        public VkAccessFlags dstAccessMask;
    }
    // Struct: 200
    /// <summary>VkMemoryDedicatedAllocateInfo - Specify a dedicated memory allocation resource
    /// </summary>
    public unsafe struct VkMemoryDedicatedAllocateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> image is VK_NULL_HANDLE or a handle of an image which this
        /// memory will be bound to.</summary>
        public VkImage image;
        /// <summary> buffer is VK_NULL_HANDLE or a handle of a buffer which this
        /// memory will be bound to.</summary>
        public VkBuffer buffer;
    }
    // Struct: 201
    /// <summary>VkMemoryDedicatedRequirements - Structure describing dedicated allocation requirements of buffer and image resources
    /// </summary>
    public unsafe struct VkMemoryDedicatedRequirements {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> prefersDedicatedAllocation specifies that the implementation would
        /// prefer a dedicated allocation for this resource.
        /// The application is still free to suballocate the resource but it may
        /// get better performance if a dedicated allocation is used.</summary>
        public VkBool32 prefersDedicatedAllocation;
        /// <summary> requiresDedicatedAllocation specifies that a dedicated allocation
        /// is required for this resource.</summary>
        public VkBool32 requiresDedicatedAllocation;
    }
    // Struct: 202
    /// <summary>VkMemoryFdPropertiesKHR - Properties of External Memory File Descriptors
    /// </summary>
    public unsafe struct VkMemoryFdPropertiesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> memoryTypeBits is a bitmask containing one bit set for every
        /// memory type which the specified file descriptor can be imported as.</summary>
        public UInt32 memoryTypeBits;
    }
    // Struct: 203
    /// <summary>VkMemoryGetAndroidHardwareBufferInfoANDROID - Structure describing an Android hardware buffer memory export operation
    /// </summary>
    public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> memory is the memory object from which the Android hardware buffer
        /// will be exported.</summary>
        public VkDeviceMemory memory;
    }
    // Struct: 204
    /// <summary>VkMemoryGetFdInfoKHR - Structure describing a POSIX FD semaphore export operation
    /// </summary>
    public unsafe struct VkMemoryGetFdInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> memory is the memory object from which the handle will be
        /// exported.</summary>
        public VkDeviceMemory memory;
        /// <summary> handleType is the type of handle requested.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    // Struct: 205
    /// <summary>VkMemoryGetWin32HandleInfoKHR - Structure describing a Win32 handle semaphore export operation
    /// </summary>
    public unsafe struct VkMemoryGetWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> memory is the memory object from which the handle will be
        /// exported.</summary>
        public VkDeviceMemory memory;
        /// <summary> handleType is the type of handle requested.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    // Struct: 206
    /// <summary>VkMemoryHeap - Structure specifying a memory heap
    /// </summary>
    public unsafe struct VkMemoryHeap {
        /// <summary> size is the total memory size in bytes in the heap.</summary>
        public VkDeviceSize size;
        /// <summary> flags is a bitmask of VkMemoryHeapFlagBits specifying
        /// attribute flags for the heap.</summary>
        public VkMemoryHeapFlags flags;
    }
    // Struct: 207
    /// <summary>VkMemoryHostPointerPropertiesEXT - Properties of external memory host pointer
    /// </summary>
    public unsafe struct VkMemoryHostPointerPropertiesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> memoryTypeBits is a bitmask containing one bit set for every
        /// memory type which the specified host pointer can be imported as.</summary>
        public UInt32 memoryTypeBits;
    }
    // Struct: 208
    /// <summary>VkMemoryPriorityAllocateInfoEXT - Specify a memory allocation priority
    /// </summary>
    public unsafe struct VkMemoryPriorityAllocateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> priority is a floating-point value between 0 and 1, indicating
        /// the priority of the allocation relative to other memory allocations.
        /// Larger values are higher priority.
        /// The granularity of the priorities is implementation-dependent.</summary>
        public float priority;
    }
    // Struct: 209
    /// <summary>VkMemoryRequirements - Structure specifying memory requirements
    /// </summary>
    public unsafe struct VkMemoryRequirements {
        /// <summary> size is the size, in bytes, of the memory allocation required for
        /// the resource.</summary>
        public VkDeviceSize size;
        /// <summary> alignment is the alignment, in bytes, of the offset within the
        /// allocation required for the resource.</summary>
        public VkDeviceSize alignment;
        /// <summary> memoryTypeBits is a bitmask and contains one bit set for every
        /// supported memory type for the resource.
        /// Bit i is set if and only if the memory type i in the
        /// VkPhysicalDeviceMemoryProperties structure for the physical device
        /// is supported for the resource.</summary>
        public UInt32 memoryTypeBits;
    }
    // Struct: 210
    /// <summary>VkMemoryRequirements2 - Structure specifying memory requirements
    /// </summary>
    public unsafe struct VkMemoryRequirements2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> memoryRequirements is a structure of type
        /// VkMemoryRequirements describing the memory requirements of the
        /// resource.</summary>
        public VkMemoryRequirements memoryRequirements;
    }
    // Struct: 211
    /// <summary>VkMemoryType - Structure specifying memory type
    /// </summary>
    public unsafe struct VkMemoryType {
        /// <summary> propertyFlags is a bitmask of VkMemoryPropertyFlagBits of
        /// properties for this memory type.</summary>
        public VkMemoryPropertyFlags propertyFlags;
        /// <summary> heapIndex describes which memory heap this memory type corresponds
        /// to, and must be less than memoryHeapCount from the
        /// VkPhysicalDeviceMemoryProperties structure.</summary>
        public UInt32 heapIndex;
    }
    // Struct: 212
    /// <summary>VkMemoryWin32HandlePropertiesKHR - Properties of External Memory Windows Handles
    /// </summary>
    public unsafe struct VkMemoryWin32HandlePropertiesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> memoryTypeBits is a bitmask containing one bit set for every
        /// memory type which the specified windows handle can be imported as.</summary>
        public UInt32 memoryTypeBits;
    }
    // Struct: 213
    /// <summary>VkMetalSurfaceCreateInfoEXT - Structure specifying parameters of a newly created Metal surface object
    /// </summary>
    public unsafe struct VkMetalSurfaceCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkMetalSurfaceCreateFlagsEXT flags;
        /// <summary> pLayer is a reference to a CAMetalLayer object that
        /// represents a renderable surface.</summary>
        public /*-const-*/ CAMetalLayer* pLayer;
    }
    // Struct: 214
    /// <summary>VkMultisamplePropertiesEXT - Structure returning information about sample count specific additional multisampling capabilities
    /// </summary>
    public unsafe struct VkMultisamplePropertiesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> maxSampleLocationGridSize is the maximum size of the pixel grid in
        /// which sample locations can vary.</summary>
        public VkExtent2D maxSampleLocationGridSize;
    }
    // Struct: 215
    /// <summary>VkObjectTableCreateInfoNVX - Structure specifying the parameters of a newly created object table
    /// </summary>
    public unsafe struct VkObjectTableCreateInfoNVX {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> objectCount is the number of entry configurations that the object
        /// table supports.</summary>
        public UInt32 _objectCount;
        /// <summary> pObjectEntryTypes is an array of VkObjectEntryTypeNVX values
        /// providing the entry type of a given configuration.</summary>
        public /*-const-*/ VkObjectEntryTypeNVX* pObjectEntryTypes;
        /// <summary> pObjectEntryCounts is an array of counts of how many objects can
        /// be registered in the table.</summary>
        public /*-const-*/ UInt32* pObjectEntryCounts;
        /// <summary> pObjectEntryUsageFlags is an array of bitmasks of
        /// VkObjectEntryUsageFlagBitsNVX specifying the binding usage of the
        /// entry.</summary>
        public /*-const-*/ VkObjectEntryUsageFlagsNVX* pObjectEntryUsageFlags;
        /// <summary> maxUniformBuffersPerDescriptor is the maximum number of
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC used by any single
        /// registered VkDescriptorSet in this table.</summary>
        public UInt32 maxUniformBuffersPerDescriptor;
        /// <summary> maxStorageBuffersPerDescriptor is the maximum number of
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC used by any single
        /// registered VkDescriptorSet in this table.</summary>
        public UInt32 maxStorageBuffersPerDescriptor;
        /// <summary> maxStorageImagesPerDescriptor is the maximum number of
        /// VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER used by any single
        /// registered VkDescriptorSet in this table.</summary>
        public UInt32 maxStorageImagesPerDescriptor;
        /// <summary> maxSampledImagesPerDescriptor is the maximum number of
        /// VK_DESCRIPTOR_TYPE_SAMPLER,
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
        /// VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT used by any single registered
        /// VkDescriptorSet in this table.</summary>
        public UInt32 maxSampledImagesPerDescriptor;
        /// <summary> maxPipelineLayouts is the maximum number of unique
        /// VkPipelineLayout used by any registered VkDescriptorSet or
        /// VkPipeline in this table.</summary>
        public UInt32 maxPipelineLayouts;
    }
    // Struct: 216
    /// <summary>VkObjectTableDescriptorSetEntryNVX - Parameters of an object table descriptor set entry
    /// </summary>
    public unsafe struct VkObjectTableDescriptorSetEntryNVX {
        public VkObjectEntryTypeNVX type;
        public VkObjectEntryUsageFlagsNVX flags;
        /// <summary> pipelineLayout specifies the VkPipelineLayout that the
        /// descriptorSet is used with.</summary>
        public VkPipelineLayout pipelineLayout;
        /// <summary> descriptorSet specifies the VkDescriptorSet that can be
        /// bound with this entry.</summary>
        public VkDescriptorSet descriptorSet;
    }
    // Struct: 217
    /// <summary>VkObjectTableEntryNVX - Common parameters of an object table resource entry
    /// </summary>
    public unsafe struct VkObjectTableEntryNVX {
        /// <summary> type defines the entry type</summary>
        public VkObjectEntryTypeNVX type;
        /// <summary> flags defines which VkPipelineBindPoint the resource can be
        /// used with.
        /// Some entry types allow only a single flag to be set.</summary>
        public VkObjectEntryUsageFlagsNVX flags;
    }
    // Struct: 218
    /// <summary>VkObjectTableIndexBufferEntryNVX - Parameters of an object table index buffer entry
    /// </summary>
    public unsafe struct VkObjectTableIndexBufferEntryNVX {
        public VkObjectEntryTypeNVX type;
        public VkObjectEntryUsageFlagsNVX flags;
        /// <summary> buffer specifies the VkBuffer that can be bound as index
        /// buffer</summary>
        public VkBuffer buffer;
        /// <summary> indexType specifies the VkIndexType used with this index
        /// buffer</summary>
        public VkIndexType indexType;
    }
    // Struct: 219
    /// <summary>VkObjectTablePipelineEntryNVX - Parameters of an object table pipeline entry
    /// </summary>
    public unsafe struct VkObjectTablePipelineEntryNVX {
        public VkObjectEntryTypeNVX type;
        public VkObjectEntryUsageFlagsNVX flags;
        /// <summary> pipeline specifies the VkPipeline that this resource entry
        /// references.</summary>
        public VkPipeline pipeline;
    }
    // Struct: 220
    /// <summary>VkObjectTablePushConstantEntryNVX - Parameters of an object table push constant entry
    /// </summary>
    public unsafe struct VkObjectTablePushConstantEntryNVX {
        public VkObjectEntryTypeNVX type;
        public VkObjectEntryUsageFlagsNVX flags;
        /// <summary> pipelineLayout specifies the VkPipelineLayout that the
        /// pushconstants are used with</summary>
        public VkPipelineLayout pipelineLayout;
        /// <summary> stageFlags specifies the VkShaderStageFlags that the
        /// pushconstants are used with</summary>
        public VkShaderStageFlags stageFlags;
    }
    // Struct: 221
    /// <summary>VkObjectTableVertexBufferEntryNVX - Parameters of an object table vertex buffer entry
    /// </summary>
    public unsafe struct VkObjectTableVertexBufferEntryNVX {
        public VkObjectEntryTypeNVX type;
        public VkObjectEntryUsageFlagsNVX flags;
        /// <summary> buffer specifies the VkBuffer that can be bound as vertex
        /// bufer</summary>
        public VkBuffer buffer;
    }
    // Struct: 222
    /// <summary>VkOffset2D - Structure specifying a two-dimensional offset
    /// </summary>
    public unsafe struct VkOffset2D {
        /// <summary> x is the x offset.</summary>
        public Int32 x;
        /// <summary> y is the y offset.</summary>
        public Int32 y;
    }
    // Struct: 223
    /// <summary>VkOffset3D - Structure specifying a three-dimensional offset
    /// </summary>
    public unsafe struct VkOffset3D {
        /// <summary> x is the x offset.</summary>
        public Int32 x;
        /// <summary> y is the y offset.</summary>
        public Int32 y;
        /// <summary> z is the z offset.</summary>
        public Int32 z;
    }
    // Struct: 224
    /// <summary>VkPastPresentationTimingGOOGLE - Structure containing timing information about a previously-presented image
    /// </summary>
    public unsafe struct VkPastPresentationTimingGOOGLE {
        /// <summary> presentID is an application-provided value that was given to a
        /// previous vkQueuePresentKHR command via
        /// VkPresentTimeGOOGLE::presentID (see below).
        /// It can be used to uniquely identify a previous present with the
        /// vkQueuePresentKHR command.</summary>
        public UInt32 presentID;
        /// <summary> desiredPresentTime is an application-provided value that was given
        /// to a previous vkQueuePresentKHR command via
        /// VkPresentTimeGOOGLE::desiredPresentTime.
        /// If non-zero, it was used by the application to indicate that an image
        /// not be presented any sooner than desiredPresentTime.</summary>
        public UInt64 desiredPresentTime;
        /// <summary> actualPresentTime is the time when the image of the
        /// swapchain was actually displayed.</summary>
        public UInt64 actualPresentTime;
        /// <summary> earliestPresentTime is the time when the image of the
        /// swapchain could have been displayed.
        /// This may differ from actualPresentTime if the application
        /// requested that the image be presented no sooner than
        /// VkPresentTimeGOOGLE::desiredPresentTime.</summary>
        public UInt64 earliestPresentTime;
        /// <summary> presentMargin is an indication of how early the
        /// vkQueuePresentKHR command was processed compared to how soon it
        /// needed to be processed, and still be presented at
        /// earliestPresentTime.</summary>
        public UInt64 presentMargin;
    }
    // Struct: 225
    /// <summary>VkPhysicalDevice16BitStorageFeatures - Structure describing features supported by VK_KHR_16bit_storage
    /// </summary>
    public unsafe struct VkPhysicalDevice16BitStorageFeatures {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   storageBuffer16BitAccess
        /// specifies whether objects in the StorageBuffer
        /// or PhysicalStorageBufferEXT
        /// storage class with the Block decoration can have 16-bit integer
        /// and 16-bit floating-point members.
        /// If this feature is not enabled, 16-bit integer or 16-bit floating-point
        /// members must not be used in such objects.
        /// This also specifies whether shader modules can declare the
        /// StorageBuffer16BitAccess capability.</summary>
        public VkBool32 storageBuffer16BitAccess;
        /// <summary>  
        ///   uniformAndStorageBuffer16BitAccess specifies whether objects in
        /// the Uniform storage class with the Block decoration and in the
        /// StorageBuffer
        /// or PhysicalStorageBufferEXT
        /// storage class with the same decoration can have 16-bit integer and
        /// 16-bit floating-point members.
        /// If this feature is not enabled, 16-bit integer or 16-bit floating-point
        /// members must not be used in such objects.
        /// This also specifies whether shader modules can declare the
        /// UniformAndStorageBuffer16BitAccess capability.</summary>
        public VkBool32 uniformAndStorageBuffer16BitAccess;
        /// <summary>  
        ///   storagePushConstant16 specifies
        /// whether objects in the PushConstant storage class can have 16-bit
        /// integer and 16-bit floating-point members.
        /// If this feature is not enabled, 16-bit integer or floating-point members
        /// must not be used in such objects.
        /// This also specifies whether shader modules can declare the
        /// StoragePushConstant16 capability.</summary>
        public VkBool32 storagePushConstant16;
        /// <summary>  
        ///   storageInputOutput16 specifies
        /// whether objects in the Input and Output storage classes can
        /// have 16-bit integer and 16-bit floating-point members.
        /// If this feature is not enabled, 16-bit integer or 16-bit floating-point
        /// members must not be used in such objects.
        /// This also specifies whether shader modules can declare the
        /// StorageInputOutput16 capability.</summary>
        public VkBool32 storageInputOutput16;
    }
    // Struct: 226
    /// <summary>VkPhysicalDevice8BitStorageFeaturesKHR - Structure describing features supported by VK_KHR_8bit_storage
    /// </summary>
    public unsafe struct VkPhysicalDevice8BitStorageFeaturesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   storageBuffer8BitAccess
        /// indicates whether objects in the StorageBuffer
        /// or PhysicalStorageBufferEXT
        /// storage class with the Block decoration can have 8-bit integer
        /// members.
        /// If this feature is not enabled, 8-bit integer members must not be used
        /// in such objects.
        /// This also indicates whether shader modules can declare the
        /// StorageBuffer8BitAccess capability.</summary>
        public VkBool32 storageBuffer8BitAccess;
        /// <summary>  
        ///   uniformAndStorageBuffer8BitAccess indicates whether objects in the
        /// Uniform storage class with the Block decoration and in the
        /// StorageBuffer
        /// or PhysicalStorageBufferEXT
        /// storage class with the same decoration can have 8-bit integer members.
        /// If this feature is not enabled, 8-bit integer members must not be used
        /// in such objects.
        /// This also indicates whether shader modules can declare the
        /// UniformAndStorageBuffer8BitAccess capability.</summary>
        public VkBool32 uniformAndStorageBuffer8BitAccess;
        /// <summary>  
        ///   storagePushConstant8 indicates
        /// whether objects in the PushConstant storage class can have 8-bit
        /// integer members.
        /// If this feature is not enabled, 8-bit integer members must not be used
        /// in such objects.
        /// This also indicates whether shader modules can declare the
        /// StoragePushConstant8 capability.</summary>
        public VkBool32 storagePushConstant8;
    }
    // Struct: 227
    /// <summary>VkPhysicalDeviceASTCDecodeFeaturesEXT - Structure describing ASTC decode mode features
    /// </summary>
    public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 decodeModeSharedExponent;
    }
    // Struct: 228
    /// <summary>VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT - Structure describing advanced blending features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 advancedBlendCoherentOperations;
    }
    // Struct: 229
    /// <summary>VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT - Structure describing advanced blending limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 advancedBlendMaxColorAttachments;
        public VkBool32 advancedBlendIndependentBlend;
        public VkBool32 advancedBlendNonPremultipliedSrcColor;
        public VkBool32 advancedBlendNonPremultipliedDstColor;
        public VkBool32 advancedBlendCorrelatedOverlap;
        public VkBool32 advancedBlendAllOperations;
    }
    // Struct: 230
    /// <summary>VkPhysicalDeviceBufferDeviceAddressFeaturesEXT - Structure describing buffer address features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
    }
    // Struct: 231
    /// <summary>VkPhysicalDeviceComputeShaderDerivativesFeaturesNV - Structure describing compute shader derivative features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 computeDerivativeGroupQuads;
        public VkBool32 computeDerivativeGroupLinear;
    }
    // Struct: 232
    /// <summary>VkPhysicalDeviceConditionalRenderingFeaturesEXT - Structure describing if a secondary command buffer can be executed if conditional rendering is active in the primary command buffer
    /// </summary>
    public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   conditionalRendering specifies
        /// whether conditional rendering is supported.</summary>
        public VkBool32 conditionalRendering;
        /// <summary>  
        ///   inheritedConditionalRendering specifies whether a secondary
        /// command buffer can be executed while conditional rendering is active in
        /// the primary command buffer.</summary>
        public VkBool32 inheritedConditionalRendering;
    }
    // Struct: 233
    /// <summary>VkPhysicalDeviceConservativeRasterizationPropertiesEXT - Structure describing conservative raster properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public float primitiveOverestimationSize;
        public float maxExtraPrimitiveOverestimationSize;
        public float extraPrimitiveOverestimationSizeGranularity;
        public VkBool32 primitiveUnderestimation;
        public VkBool32 conservativePointAndLineRasterization;
        public VkBool32 degenerateTrianglesRasterized;
        public VkBool32 degenerateLinesRasterized;
        public VkBool32 fullyCoveredFragmentShaderInputVariable;
        public VkBool32 conservativeRasterizationPostDepthCoverage;
    }
    // Struct: 234
    /// <summary>VkPhysicalDeviceCooperativeMatrixFeaturesNV - Structure describing cooperative matrix features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cooperativeMatrix;
        public VkBool32 cooperativeMatrixRobustBufferAccess;
    }
    // Struct: 235
    /// <summary>VkPhysicalDeviceCooperativeMatrixPropertiesNV - Structure describing cooperative matrix properties supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags cooperativeMatrixSupportedStages;
    }
    // Struct: 236
    /// <summary>VkPhysicalDeviceCornerSampledImageFeaturesNV - Structure describing corner sampled image features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cornerSampledImage;
    }
    // Struct: 237
    /// <summary>VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV - Structure describing dedicated allocation image aliasing features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocationImageAliasing;
    }
    // Struct: 238
    /// <summary>VkPhysicalDeviceDepthClipEnableFeaturesEXT - Structure indicating support for explicit enable of depth clip
    /// </summary>
    public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthClipEnable;
    }
    // Struct: 239
    /// <summary>VkPhysicalDeviceDepthStencilResolvePropertiesKHR - Structure describing depth/stencil resolve properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlagsKHR supportedDepthResolveModes;
        public VkResolveModeFlagsKHR supportedStencilResolveModes;
        public VkBool32 independentResolveNone;
        public VkBool32 independentResolve;
    }
    // Struct: 240
    /// <summary>VkPhysicalDeviceDescriptorIndexingFeaturesEXT - Structure describing descriptor indexing features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32 shaderSampledImageArrayNonUniformIndexing;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageImageArrayNonUniformIndexing;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUpdateUnusedWhilePending;
        public VkBool32 descriptorBindingPartiallyBound;
        public VkBool32 descriptorBindingVariableDescriptorCount;
        public VkBool32 runtimeDescriptorArray;
    }
    // Struct: 241
    /// <summary>VkPhysicalDeviceDescriptorIndexingPropertiesEXT - Structure describing descriptor indexing properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxUpdateAfterBindDescriptorsInAllPools;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
        public VkBool32 robustBufferAccessUpdateAfterBind;
        public VkBool32 quadDivergentImplicitLod;
        public UInt32 maxPerStageDescriptorUpdateAfterBindSamplers;
        public UInt32 maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public UInt32 maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public UInt32 maxPerStageDescriptorUpdateAfterBindSampledImages;
        public UInt32 maxPerStageDescriptorUpdateAfterBindStorageImages;
        public UInt32 maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public UInt32 maxPerStageUpdateAfterBindResources;
        public UInt32 maxDescriptorSetUpdateAfterBindSamplers;
        public UInt32 maxDescriptorSetUpdateAfterBindUniformBuffers;
        public UInt32 maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public UInt32 maxDescriptorSetUpdateAfterBindStorageBuffers;
        public UInt32 maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public UInt32 maxDescriptorSetUpdateAfterBindSampledImages;
        public UInt32 maxDescriptorSetUpdateAfterBindStorageImages;
        public UInt32 maxDescriptorSetUpdateAfterBindInputAttachments;
    }
    // Struct: 242
    /// <summary>VkPhysicalDeviceDiscardRectanglePropertiesEXT - Structure describing discard rectangle limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxDiscardRectangles;
    }
    // Struct: 243
    /// <summary>VkPhysicalDeviceDriverPropertiesKHR - Structure containing driver identification information
    /// </summary>
    public unsafe struct VkPhysicalDeviceDriverPropertiesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension specific structure.</summary>
        public void* pNext;
        /// <summary> driverID is a unique identifier for the driver of the physical
        /// device.</summary>
        public VkDriverIdKHR driverID;
        public fixed char driverName[VK_MAX_DRIVER_NAME_SIZE_KHR];
        public fixed char driverInfo[VK_MAX_DRIVER_INFO_SIZE_KHR];
        /// <summary> conformanceVersion is the version of the Vulkan conformance test
        /// this driver is conformant against (see VkConformanceVersionKHR).</summary>
        public VkConformanceVersionKHR conformanceVersion;
    }
    // Struct: 244
    /// <summary>VkPhysicalDeviceExclusiveScissorFeaturesNV - Structure describing exclusive scissor features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 exclusiveScissor;
    }
    // Struct: 245
    /// <summary>VkPhysicalDeviceExternalBufferInfo - Structure specifying buffer creation parameters
    /// </summary>
    public unsafe struct VkPhysicalDeviceExternalBufferInfo {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkBufferCreateFlagBits describing
        /// additional parameters of the buffer, corresponding to
        /// VkBufferCreateInfo::flags.</summary>
        public VkBufferCreateFlags flags;
        /// <summary> usage is a bitmask of VkBufferUsageFlagBits describing the
        /// intended usage of the buffer, corresponding to
        /// VkBufferCreateInfo::usage.</summary>
        public VkBufferUsageFlags usage;
        /// <summary> handleType is a VkExternalMemoryHandleTypeFlagBits value
        /// specifying the memory handle type that will be used with the memory
        /// associated with the buffer.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    // Struct: 246
    /// <summary>VkPhysicalDeviceExternalFenceInfo - Structure specifying fence creation parameters.
    /// </summary>
    public unsafe struct VkPhysicalDeviceExternalFenceInfo {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType is a VkExternalFenceHandleTypeFlagBits value
        /// indicating an external fence handle type for which capabilities will be
        /// returned.</summary>
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    // Struct: 247
    /// <summary>VkPhysicalDeviceExternalImageFormatInfo - Structure specifying external image creation parameters
    /// </summary>
    public unsafe struct VkPhysicalDeviceExternalImageFormatInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType is a VkExternalMemoryHandleTypeFlagBits value
        /// specifying the memory handle type that will be used with the memory
        /// associated with the image.</summary>
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    // Struct: 248
    /// <summary>VkPhysicalDeviceExternalMemoryHostPropertiesEXT - Structure describing external memory host pointer limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceSize minImportedHostPointerAlignment;
    }
    // Struct: 249
    /// <summary>VkPhysicalDeviceExternalSemaphoreInfo - Structure specifying semaphore creation parameters.
    /// </summary>
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> handleType is a VkExternalSemaphoreHandleTypeFlagBits value
        /// specifying the external semaphore handle type for which capabilities
        /// will be returned.</summary>
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    // Struct: 250
    /// <summary>VkPhysicalDeviceFeatures - Structure describing the fine-grained features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceFeatures {
        public VkBool32 robustBufferAccess;
        public VkBool32 fullDrawIndexUint32;
        public VkBool32 imageCubeArray;
        public VkBool32 independentBlend;
        public VkBool32 geometryShader;
        public VkBool32 tessellationShader;
        public VkBool32 sampleRateShading;
        public VkBool32 dualSrcBlend;
        public VkBool32 logicOp;
        public VkBool32 multiDrawIndirect;
        public VkBool32 drawIndirectFirstInstance;
        public VkBool32 depthClamp;
        public VkBool32 depthBiasClamp;
        public VkBool32 fillModeNonSolid;
        public VkBool32 depthBounds;
        public VkBool32 wideLines;
        public VkBool32 largePoints;
        public VkBool32 alphaToOne;
        public VkBool32 multiViewport;
        public VkBool32 samplerAnisotropy;
        public VkBool32 textureCompressionETC2;
        public VkBool32 textureCompressionASTC_LDR;
        public VkBool32 textureCompressionBC;
        public VkBool32 occlusionQueryPrecise;
        public VkBool32 pipelineStatisticsQuery;
        public VkBool32 vertexPipelineStoresAndAtomics;
        public VkBool32 fragmentStoresAndAtomics;
        public VkBool32 shaderTessellationAndGeometryPointSize;
        public VkBool32 shaderImageGatherExtended;
        public VkBool32 shaderStorageImageExtendedFormats;
        public VkBool32 shaderStorageImageMultisample;
        public VkBool32 shaderStorageImageReadWithoutFormat;
        public VkBool32 shaderStorageImageWriteWithoutFormat;
        public VkBool32 shaderUniformBufferArrayDynamicIndexing;
        public VkBool32 shaderSampledImageArrayDynamicIndexing;
        public VkBool32 shaderStorageBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageImageArrayDynamicIndexing;
        public VkBool32 shaderClipDistance;
        public VkBool32 shaderCullDistance;
        public VkBool32 shaderFloat64;
        public VkBool32 shaderInt64;
        public VkBool32 shaderInt16;
        public VkBool32 shaderResourceResidency;
        public VkBool32 shaderResourceMinLod;
        public VkBool32 sparseBinding;
        public VkBool32 sparseResidencyBuffer;
        public VkBool32 sparseResidencyImage2D;
        public VkBool32 sparseResidencyImage3D;
        public VkBool32 sparseResidency2Samples;
        public VkBool32 sparseResidency4Samples;
        public VkBool32 sparseResidency8Samples;
        public VkBool32 sparseResidency16Samples;
        public VkBool32 sparseResidencyAliased;
        public VkBool32 variableMultisampleRate;
        public VkBool32 inheritedQueries;
    }
    // Struct: 251
    /// <summary>VkPhysicalDeviceFeatures2 - Structure describing the fine-grained features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceFeatures2 {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceFeatures features;
    }
    // Struct: 252
    /// <summary>VkPhysicalDeviceFloat16Int8FeaturesKHR - Structure describing features supported by VK_KHR_shader_float16_int8
    /// </summary>
    public unsafe struct VkPhysicalDeviceFloat16Int8FeaturesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   shaderFloat16 indicates whether 16-bit
        /// floats (halfs) are supported in shader code.
        /// This also indicates whether shader modules can declare the Float16
        /// capability.</summary>
        public VkBool32 shaderFloat16;
        /// <summary>  
        ///   shaderInt8 indicates whether 8-bit
        /// integers (signed and unsigned) are supported in shader code.
        /// This also indicates whether shader modules can declare the Int8
        /// capability.</summary>
        public VkBool32 shaderInt8;
    }
    // Struct: 253
    /// <summary>VkPhysicalDeviceFloatControlsPropertiesKHR - Structure describing properties supported by VK_KHR_shader_float_controls
    /// </summary>
    public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR {
        public VkStructureType sType;
        public void* pNext;
        /// <summary>  
        ///   separateDenormSettings is a
        /// boolean value indicating whether the implementation supports separate
        /// settings for 16-bit and 64-bit denormals.</summary>
        public VkBool32 separateDenormSettings;
        /// <summary>  
        ///   separateRoundingModeSettings is a boolean value indicating whether
        /// the implementation supports separate rounding modes for 16-bit and
        /// 64-bit floating point instructions.</summary>
        public VkBool32 separateRoundingModeSettings;
        /// <summary>  
        ///   shaderSignedZeroInfNanPreserveFloat16 is a boolean value
        /// indicating whether sign of a zero, Nans and
        /// \(\pm\infty\) can be preserved in 16-bit floating-point
        /// computations.
        /// It also indicates whether the SignedZeroInfNanPreserve execution
        /// mode can be used for 16-bit floating-point types.</summary>
        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
        /// <summary>  
        ///   shaderSignedZeroInfNanPreserveFloat32 is a boolean value
        /// indicating whether sign of a zero, Nans and
        /// \(\pm\infty\) can be preserved in 32-bit floating-point
        /// computations.
        /// It also indicates whether the SignedZeroInfNanPreserve execution
        /// mode can be used for 32-bit floating-point types.</summary>
        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
        /// <summary>  
        ///   shaderSignedZeroInfNanPreserveFloat64 is a boolean value
        /// indicating whether sign of a zero, Nans and
        /// \(\pm\infty\) can be preserved in 64-bit floating-point
        /// computations.
        /// It also indicates whether the SignedZeroInfNanPreserve execution
        /// mode can be used for 64-bit floating-point types.</summary>
        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
        /// <summary>  
        ///   shaderDenormPreserveFloat16 is a boolean value indicating whether
        /// denormals can be preserved in 16-bit floating-point computations.
        /// It also indicates whether the DenormPreserve execution mode can be
        /// used for 16-bit floating-point types.</summary>
        public VkBool32 shaderDenormPreserveFloat16;
        /// <summary>  
        ///   shaderDenormPreserveFloat32 is a boolean value indicating whether
        /// denormals can be preserved in 32-bit floating-point computations.
        /// It also indicates whether the DenormPreserve execution mode can be
        /// used for 32-bit floating-point types.</summary>
        public VkBool32 shaderDenormPreserveFloat32;
        /// <summary>  
        ///   shaderDenormPreserveFloat64 is a boolean value indicating whether
        /// denormals can be preserved in 64-bit floating-point computations.
        /// It also indicates whether the DenormPreserve execution mode can be
        /// used for 64-bit floating-point types.</summary>
        public VkBool32 shaderDenormPreserveFloat64;
        /// <summary>  
        ///   shaderDenormFlushToZeroFloat16 is a boolean value indicating
        /// whether denormals can be flushed to zero in 16-bit floating-point
        /// computations.
        /// It also indicates whether the DenormFlushToZero execution mode can
        /// be used for 16-bit floating-point types.</summary>
        public VkBool32 shaderDenormFlushToZeroFloat16;
        /// <summary>  
        ///   shaderDenormFlushToZeroFloat32 is a boolean value indicating
        /// whether denormals can be flushed to zero in 32-bit floating-point
        /// computations.
        /// It also indicates whether the DenormFlushToZero execution mode can
        /// be used for 32-bit floating-point types.</summary>
        public VkBool32 shaderDenormFlushToZeroFloat32;
        /// <summary>  
        ///   shaderDenormFlushToZeroFloat64 is a boolean value indicating
        /// whether denormals can be flushed to zero in 64-bit floating-point
        /// computations.
        /// It also indicates whether the DenormFlushToZero execution mode can
        /// be used for 64-bit floating-point types.</summary>
        public VkBool32 shaderDenormFlushToZeroFloat64;
        /// <summary>  
        ///   shaderRoundingModeRTEFloat16 is a boolean value indicating whether
        /// an implementation supports the round-to-nearest-even rounding mode for
        /// 16-bit floating-point arithmetic and conversion instructions.
        /// It also indicates whether the RoundingModeRTE execution mode can
        /// be used for 16-bit floating-point types.</summary>
        public VkBool32 shaderRoundingModeRTEFloat16;
        /// <summary>  
        ///   shaderRoundingModeRTEFloat32 is a boolean value indicating whether
        /// an implementation supports the round-to-nearest-even rounding mode for
        /// 32-bit floating-point arithmetic and conversion instructions.
        /// It also indicates whether the RoundingModeRTE execution mode can
        /// be used for 32-bit floating-point types.</summary>
        public VkBool32 shaderRoundingModeRTEFloat32;
        /// <summary>  
        ///   shaderRoundingModeRTEFloat64 is a boolean value indicating whether
        /// an implementation supports the round-to-nearest-even rounding mode for
        /// 64-bit floating-point arithmetic and conversion instructions.
        /// It also indicates whether the RoundingModeRTE execution mode can
        /// be used for 64-bit floating-point types.</summary>
        public VkBool32 shaderRoundingModeRTEFloat64;
        /// <summary>  
        ///   shaderRoundingModeRTZFloat16 is a boolean value indicating whether
        /// an implementation supports the round-towards-zero rounding mode for
        /// 16-bit floating-point arithmetic and conversion instructions.
        /// It also indicates whether the RoundingModeRTZ execution mode can
        /// be used for 16-bit floating-point types.</summary>
        public VkBool32 shaderRoundingModeRTZFloat16;
        /// <summary>  
        ///   shaderRoundingModeRTZFloat32 is a boolean value indicating whether
        /// an implementation supports the round-towards-zero rounding mode for
        /// 32-bit floating-point arithmetic and conversion instructions.
        /// It also indicates whether the RoundingModeRTZ execution mode can
        /// be used for 32-bit floating-point types.</summary>
        public VkBool32 shaderRoundingModeRTZFloat32;
        /// <summary>  
        ///   shaderRoundingModeRTZFloat64 is a boolean value indicating whether
        /// an implementation supports the round-towards-zero rounding mode for
        /// 64-bit floating-point arithmetic and conversion instructions.
        /// It also indicates whether the RoundingModeRTZ execution mode can
        /// be used for 64-bit floating-point types.</summary>
        public VkBool32 shaderRoundingModeRTZFloat64;
    }
    // Struct: 254
    /// <summary>VkPhysicalDeviceFragmentDensityMapFeaturesEXT - Structure describing fragment density map features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMap;
        public VkBool32 fragmentDensityMapDynamic;
        public VkBool32 fragmentDensityMapNonSubsampledImages;
    }
    // Struct: 255
    /// <summary>VkPhysicalDeviceFragmentDensityMapPropertiesEXT - Structure describing fragment density map properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentDensityTexelSize;
        public VkExtent2D maxFragmentDensityTexelSize;
        public VkBool32 fragmentDensityInvocations;
    }
    // Struct: 256
    /// <summary>VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV - Structure describing barycentric support in fragment shaders that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShaderBarycentric;
    }
    // Struct: 257
    /// <summary>VkPhysicalDeviceGroupProperties - Structure specifying physical device group properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceGroupProperties {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> physicalDeviceCount is the number of physical devices in the
        /// group.</summary>
        public UInt32 physicalDeviceCount;
        public fixed VkPhysicalDevice physicalDevices[VK_MAX_DEVICE_GROUP_SIZE];
        /// <summary> subsetAllocation specifies whether logical devices created from
        /// the group support allocating device memory on a subset of devices, via
        /// the deviceMask member of the VkMemoryAllocateFlagsInfo.
        /// If this is VK_FALSE, then all device memory allocations are made
        /// across all physical devices in the group.
        /// If physicalDeviceCount is 1, then subsetAllocation must
        /// be VK_FALSE.</summary>
        public VkBool32 subsetAllocation;
    }
    // Struct: 258
    /// <summary>VkPhysicalDeviceHostQueryResetFeaturesEXT - Structure describing whether queries can be reset from the host
    /// </summary>
    public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hostQueryReset;
    }
    // Struct: 259
    /// <summary>VkPhysicalDeviceIDProperties - Structure specifying IDs related to the physical device
    /// </summary>
    public unsafe struct VkPhysicalDeviceIDProperties {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        public fixed byte deviceUUID[VK_UUID_SIZE];
        public fixed byte driverUUID[VK_UUID_SIZE];
        public fixed byte deviceLUID[VK_LUID_SIZE];
        /// <summary> deviceNodeMask is a bitfield identifying the node within a linked
        /// device adapter corresponding to the device.</summary>
        public UInt32 deviceNodeMask;
        /// <summary> deviceLUIDValid is a boolean value that will be VK_TRUE if
        /// deviceLUID contains a valid LUID and deviceNodeMask contains
        /// a valid node mask, and VK_FALSE if they do not.</summary>
        public VkBool32 deviceLUIDValid;
    }
    // Struct: 260
    /// <summary>VkPhysicalDeviceImageDrmFormatModifierInfoEXT - Structure specifying a DRM format modifier as image creation parameter
    /// </summary>
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> drmFormatModifier is the image’s Linux DRM format modifier,
        /// corresponding to
        /// VkImageDrmFormatModifierExplicitCreateInfoEXT::modifier or
        /// to VkImageDrmFormatModifierListCreateInfoEXT::pModifiers.</summary>
        public UInt64 drmFormatModifier;
        /// <summary> sharingMode specifies how the image will be accessed by multiple
        /// queue families.</summary>
        public VkSharingMode sharingMode;
        /// <summary> queueFamilyIndexCount is the number of entries in the
        /// pQueueFamilyIndices array.</summary>
        public UInt32 queueFamilyIndexCount;
        /// <summary> pQueueFamilyIndices is a list of queue families that will access
        /// the image (ignored if sharingMode is not
        /// VK_SHARING_MODE_CONCURRENT).</summary>
        public /*-const-*/ UInt32* pQueueFamilyIndices;
    }
    // Struct: 261
    /// <summary>VkPhysicalDeviceImageFormatInfo2 - Structure specifying image creation parameters
    /// </summary>
    public unsafe struct VkPhysicalDeviceImageFormatInfo2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.
        /// The pNext chain of VkPhysicalDeviceImageFormatInfo2 is used
        /// to provide additional image parameters to
        /// vkGetPhysicalDeviceImageFormatProperties2.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> format is a VkFormat value indicating the image format,
        /// corresponding to VkImageCreateInfo::format.</summary>
        public VkFormat format;
        /// <summary> type is a VkImageType value indicating the image type,
        /// corresponding to VkImageCreateInfo::imageType.</summary>
        public VkImageType type;
        /// <summary> tiling is a VkImageTiling value indicating the image tiling,
        /// corresponding to VkImageCreateInfo::tiling.</summary>
        public VkImageTiling tiling;
        /// <summary> usage is a bitmask of VkImageUsageFlagBits indicating the
        /// intended usage of the image, corresponding to
        /// VkImageCreateInfo::usage.</summary>
        public VkImageUsageFlags usage;
        /// <summary> flags is a bitmask of VkImageCreateFlagBits indicating
        /// additional parameters of the image, corresponding to
        /// VkImageCreateInfo::flags.</summary>
        public VkImageCreateFlags flags;
    }
    // Struct: 262
    /// <summary>VkPhysicalDeviceImageViewImageFormatInfoEXT - Structure for providing image view type
    /// </summary>
    public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> imageViewType is a VkImageViewType value specifying the type
        /// of the image view.</summary>
        public VkImageViewType imageViewType;
    }
    // Struct: 263
    /// <summary>VkPhysicalDeviceInlineUniformBlockFeaturesEXT - Structure describing inline uniform block features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 inlineUniformBlock;
        public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
    }
    // Struct: 264
    /// <summary>VkPhysicalDeviceInlineUniformBlockPropertiesEXT - Structure describing inline uniform block properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxInlineUniformBlockSize;
        public UInt32 maxPerStageDescriptorInlineUniformBlocks;
        public UInt32 maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public UInt32 maxDescriptorSetInlineUniformBlocks;
        public UInt32 maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }
    // Struct: 265
    /// <summary>VkPhysicalDeviceLimits - Structure reporting implementation-dependent physical device limits
    /// </summary>
    public unsafe struct VkPhysicalDeviceLimits {
        /// <summary>  
        ///   maxImageDimension1D is the maximum
        /// dimension (width) supported for all images created with an
        /// imageType of VK_IMAGE_TYPE_1D.</summary>
        public UInt32 maxImageDimension1D;
        /// <summary>  
        ///   maxImageDimension2D is the maximum
        /// dimension (width or height) supported for all images created
        /// with an imageType of VK_IMAGE_TYPE_2D and without
        /// VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in flags.</summary>
        public UInt32 maxImageDimension2D;
        /// <summary>  
        ///   maxImageDimension3D is the maximum
        /// dimension (width, height, or depth) supported for all
        /// images created with an imageType of VK_IMAGE_TYPE_3D.</summary>
        public UInt32 maxImageDimension3D;
        /// <summary>  
        ///   maxImageDimensionCube is the
        /// maximum dimension (width or height) supported for all images
        /// created with an imageType of VK_IMAGE_TYPE_2D and with
        /// VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in flags.</summary>
        public UInt32 maxImageDimensionCube;
        /// <summary>  
        ///   maxImageArrayLayers is the maximum
        /// number of layers (arrayLayers) for an image.</summary>
        public UInt32 maxImageArrayLayers;
        /// <summary>  
        ///   maxTexelBufferElements is the
        /// maximum number of addressable texels for a buffer view created on a
        /// buffer which was created with the
        /// VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the usage
        /// member of the VkBufferCreateInfo structure.</summary>
        public UInt32 maxTexelBufferElements;
        /// <summary>  
        ///   maxUniformBufferRange is the
        /// maximum value that can be specified in the range member of any
        /// VkDescriptorBufferInfo structures passed to a call to
        /// vkUpdateDescriptorSets for descriptors of type
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.</summary>
        public UInt32 maxUniformBufferRange;
        /// <summary>  
        ///   maxStorageBufferRange is the
        /// maximum value that can be specified in the range member of any
        /// VkDescriptorBufferInfo structures passed to a call to
        /// vkUpdateDescriptorSets for descriptors of type
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.</summary>
        public UInt32 maxStorageBufferRange;
        /// <summary>  
        ///   maxPushConstantsSize is the
        /// maximum size, in bytes, of the pool of push constant memory.
        /// For each of the push constant ranges indicated by the
        /// pPushConstantRanges member of the VkPipelineLayoutCreateInfo
        /// structure, (offset +  size) must be less than or
        /// equal to this limit.</summary>
        public UInt32 maxPushConstantsSize;
        /// <summary>  
        ///   maxMemoryAllocationCount is
        /// the maximum number of device memory allocations, as created by
        /// vkAllocateMemory, which can simultaneously exist.</summary>
        public UInt32 maxMemoryAllocationCount;
        /// <summary>  
        ///   maxSamplerAllocationCount is
        /// the maximum number of sampler objects, as created by
        /// vkCreateSampler, which can simultaneously exist on a device.</summary>
        public UInt32 maxSamplerAllocationCount;
        /// <summary>  
        ///   bufferImageGranularity is the
        /// granularity, in bytes, at which buffer or linear image resources, and
        /// optimal image resources can be bound to adjacent offsets in the same
        /// VkDeviceMemory object without aliasing.
        /// See Buffer-Image Granularity for
        /// more details.</summary>
        public VkDeviceSize bufferImageGranularity;
        /// <summary>  
        ///   sparseAddressSpaceSize is the
        /// total amount of address space available, in bytes, for sparse memory
        /// resources.
        /// This is an upper bound on the sum of the size of all sparse resources,
        /// regardless of whether any memory is bound to them.</summary>
        public VkDeviceSize sparseAddressSpaceSize;
        /// <summary>  
        ///   maxBoundDescriptorSets is the
        /// maximum number of descriptor sets that can be simultaneously used by a
        /// pipeline.
        /// All DescriptorSet decorations in shader modules must have a value
        /// less than maxBoundDescriptorSets.
        /// See html/vkspec.html#descriptorsets-sets.</summary>
        public UInt32 maxBoundDescriptorSets;
        /// <summary>  
        ///   maxPerStageDescriptorSamplers is the maximum number of samplers
        /// that can be accessible to a single shader stage in a pipeline layout.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_SAMPLER or
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// A descriptor is accessible to a shader stage when the stageFlags
        /// member of the VkDescriptorSetLayoutBinding structure has the bit
        /// for that shader stage set.
        /// See html/vkspec.html#descriptorsets-sampler and
        /// html/vkspec.html#descriptorsets-combinedimagesampler.</summary>
        public UInt32 maxPerStageDescriptorSamplers;
        /// <summary>  
        ///   maxPerStageDescriptorUniformBuffers is the maximum number of
        /// uniform buffers that can be accessible to a single shader stage in a
        /// pipeline layout.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// A descriptor is accessible to a shader stage when the stageFlags
        /// member of the VkDescriptorSetLayoutBinding structure has the bit
        /// for that shader stage set.
        /// See html/vkspec.html#descriptorsets-uniformbuffer and
        /// html/vkspec.html#descriptorsets-uniformbufferdynamic.</summary>
        public UInt32 maxPerStageDescriptorUniformBuffers;
        /// <summary>  
        ///   maxPerStageDescriptorStorageBuffers is the maximum number of
        /// storage buffers that can be accessible to a single shader stage in a
        /// pipeline layout.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// A descriptor is accessible to a pipeline shader stage when the
        /// stageFlags member of the VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set.
        /// See html/vkspec.html#descriptorsets-storagebuffer and
        /// html/vkspec.html#descriptorsets-storagebufferdynamic.</summary>
        public UInt32 maxPerStageDescriptorStorageBuffers;
        /// <summary>  
        ///   maxPerStageDescriptorSampledImages is the maximum number of
        /// sampled images that can be accessible to a single shader stage in a
        /// pipeline layout.
        /// Descriptors with a type of
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// A descriptor is accessible to a pipeline shader stage when the
        /// stageFlags member of the VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set.
        /// See html/vkspec.html#descriptorsets-combinedimagesampler,
        /// html/vkspec.html#descriptorsets-sampledimage, and
        /// html/vkspec.html#descriptorsets-uniformtexelbuffer.</summary>
        public UInt32 maxPerStageDescriptorSampledImages;
        /// <summary>  
        ///   maxPerStageDescriptorStorageImages is the maximum number of
        /// storage images that can be accessible to a single shader stage in a
        /// pipeline layout.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// A descriptor is accessible to a pipeline shader stage when the
        /// stageFlags member of the VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set.
        /// See html/vkspec.html#descriptorsets-storageimage, and
        /// html/vkspec.html#descriptorsets-storagetexelbuffer.</summary>
        public UInt32 maxPerStageDescriptorStorageImages;
        /// <summary>  
        ///   maxPerStageDescriptorInputAttachments is the maximum number of
        /// input attachments that can be accessible to a single shader stage in a
        /// pipeline layout.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT
        /// count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// A descriptor is accessible to a pipeline shader stage when the
        /// stageFlags member of the VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set.
        /// These are only supported for the fragment stage.
        /// See html/vkspec.html#descriptorsets-inputattachment.</summary>
        public UInt32 maxPerStageDescriptorInputAttachments;
        /// <summary>  
        ///   maxPerStageResources is the
        /// maximum number of resources that can be accessible to a single shader
        /// stage in a pipeline layout.
        /// Descriptors with a type of
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER,
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER,
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER,
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER,
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC,
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, or
        /// VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// For the fragment shader stage the framebuffer color attachments also
        /// count against this limit.</summary>
        public UInt32 maxPerStageResources;
        /// <summary>  
        ///   maxDescriptorSetSamplers is
        /// the maximum number of samplers that can be included in descriptor
        /// bindings in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_SAMPLER or
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-sampler and
        /// html/vkspec.html#descriptorsets-combinedimagesampler.</summary>
        public UInt32 maxDescriptorSetSamplers;
        /// <summary>  
        ///   maxDescriptorSetUniformBuffers is the maximum number of uniform
        /// buffers that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-uniformbuffer and
        /// html/vkspec.html#descriptorsets-uniformbufferdynamic.</summary>
        public UInt32 maxDescriptorSetUniformBuffers;
        /// <summary>  
        ///   maxDescriptorSetUniformBuffersDynamic is the maximum number of
        /// dynamic uniform buffers that can be included in descriptor bindings in
        /// a pipeline layout across all pipeline shader stages and descriptor set
        /// numbers.
        /// Descriptors with a type of
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-uniformbufferdynamic.</summary>
        public UInt32 maxDescriptorSetUniformBuffersDynamic;
        /// <summary>  
        ///   maxDescriptorSetStorageBuffers is the maximum number of storage
        /// buffers that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-storagebuffer and
        /// html/vkspec.html#descriptorsets-storagebufferdynamic.</summary>
        public UInt32 maxDescriptorSetStorageBuffers;
        /// <summary>  
        ///   maxDescriptorSetStorageBuffersDynamic is the maximum number of
        /// dynamic storage buffers that can be included in descriptor bindings in
        /// a pipeline layout across all pipeline shader stages and descriptor set
        /// numbers.
        /// Descriptors with a type of
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-storagebufferdynamic.</summary>
        public UInt32 maxDescriptorSetStorageBuffersDynamic;
        /// <summary>  
        ///   maxDescriptorSetSampledImages is the maximum number of sampled
        /// images that can be included in descriptor bindings in a pipeline layout
        /// across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-combinedimagesampler,
        /// html/vkspec.html#descriptorsets-sampledimage, and
        /// html/vkspec.html#descriptorsets-uniformtexelbuffer.</summary>
        public UInt32 maxDescriptorSetSampledImages;
        /// <summary>  
        ///   maxDescriptorSetStorageImages is the maximum number of storage
        /// images that can be included in descriptor bindings in a pipeline layout
        /// across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-storageimage, and
        /// html/vkspec.html#descriptorsets-storagetexelbuffer.</summary>
        public UInt32 maxDescriptorSetStorageImages;
        /// <summary>  
        ///   maxDescriptorSetInputAttachments is the maximum number of input
        /// attachments that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT
        /// count against this limit.
        /// Only descriptors in descriptor set layouts created without the
        /// VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT bit
        /// set count against this limit.
        /// See html/vkspec.html#descriptorsets-inputattachment.</summary>
        public UInt32 maxDescriptorSetInputAttachments;
        /// <summary>  
        ///   maxVertexInputAttributes is
        /// the maximum number of vertex input attributes that can be specified for
        /// a graphics pipeline.
        /// These are described in the array of
        /// VkVertexInputAttributeDescription structures that are provided at
        /// graphics pipeline creation time via the
        /// pVertexAttributeDescriptions member of the
        /// VkPipelineVertexInputStateCreateInfo structure.
        /// See html/vkspec.html#fxvertex-attrib and html/vkspec.html#fxvertex-input.</summary>
        public UInt32 maxVertexInputAttributes;
        /// <summary>  
        ///   maxVertexInputBindings is the
        /// maximum number of vertex buffers that can be specified for providing
        /// vertex attributes to a graphics pipeline.
        /// These are described in the array of
        /// VkVertexInputBindingDescription structures that are provided at
        /// graphics pipeline creation time via the pVertexBindingDescriptions
        /// member of the VkPipelineVertexInputStateCreateInfo structure.
        /// The binding member of VkVertexInputBindingDescription must
        /// be less than this limit.
        /// See html/vkspec.html#fxvertex-input.</summary>
        public UInt32 maxVertexInputBindings;
        /// <summary>  
        ///   maxVertexInputAttributeOffset is the maximum vertex input
        /// attribute offset that can be added to the vertex input binding stride.
        /// The offset member of the VkVertexInputAttributeDescription
        /// structure must be less than or equal to this limit.
        /// See html/vkspec.html#fxvertex-input.</summary>
        public UInt32 maxVertexInputAttributeOffset;
        /// <summary>  
        ///   maxVertexInputBindingStride
        /// is the maximum vertex input binding stride that can be specified in a
        /// vertex input binding.
        /// The stride member of the VkVertexInputBindingDescription
        /// structure must be less than or equal to this limit.
        /// See html/vkspec.html#fxvertex-input.</summary>
        public UInt32 maxVertexInputBindingStride;
        /// <summary>  
        ///   maxVertexOutputComponents is
        /// the maximum number of components of output variables which can be
        /// output by a vertex shader.
        /// See html/vkspec.html#shaders-vertex.</summary>
        public UInt32 maxVertexOutputComponents;
        /// <summary>  
        ///   maxTessellationGenerationLevel is the maximum tessellation
        /// generation level supported by the fixed-function tessellation primitive
        /// generator.
        /// See html/vkspec.html#tessellation.</summary>
        public UInt32 maxTessellationGenerationLevel;
        /// <summary>  
        ///   maxTessellationPatchSize is
        /// the maximum patch size, in vertices, of patches that can be processed
        /// by the tessellation control shader and tessellation primitive generator.
        /// The patchControlPoints member of the
        /// VkPipelineTessellationStateCreateInfo structure specified at
        /// pipeline creation time and the value provided in the OutputVertices
        /// execution mode of shader modules must be less than or equal to this
        /// limit.
        /// See html/vkspec.html#tessellation.</summary>
        public UInt32 maxTessellationPatchSize;
        /// <summary>  
        ///   maxTessellationControlPerVertexInputComponents is the maximum
        /// number of components of input variables which can be provided as
        /// per-vertex inputs to the tessellation control shader stage.</summary>
        public UInt32 maxTessellationControlPerVertexInputComponents;
        /// <summary>  
        ///   maxTessellationControlPerVertexOutputComponents is the maximum
        /// number of components of per-vertex output variables which can be output
        /// from the tessellation control shader stage.</summary>
        public UInt32 maxTessellationControlPerVertexOutputComponents;
        /// <summary>  
        ///   maxTessellationControlPerPatchOutputComponents is the maximum
        /// number of components of per-patch output variables which can be output
        /// from the tessellation control shader stage.</summary>
        public UInt32 maxTessellationControlPerPatchOutputComponents;
        /// <summary>  
        ///   maxTessellationControlTotalOutputComponents is the maximum total
        /// number of components of per-vertex and per-patch output variables which
        /// can be output from the tessellation control shader stage.</summary>
        public UInt32 maxTessellationControlTotalOutputComponents;
        /// <summary>  
        ///   maxTessellationEvaluationInputComponents is the maximum number of
        /// components of input variables which can be provided as per-vertex
        /// inputs to the tessellation evaluation shader stage.</summary>
        public UInt32 maxTessellationEvaluationInputComponents;
        /// <summary>  
        ///   maxTessellationEvaluationOutputComponents is the maximum number of
        /// components of per-vertex output variables which can be output from the
        /// tessellation evaluation shader stage.</summary>
        public UInt32 maxTessellationEvaluationOutputComponents;
        /// <summary>  
        ///   maxGeometryShaderInvocations is the maximum invocation count
        /// supported for instanced geometry shaders.
        /// The value provided in the Invocations execution mode of shader
        /// modules must be less than or equal to this limit.
        /// See html/vkspec.html#geometry.</summary>
        public UInt32 maxGeometryShaderInvocations;
        /// <summary>  
        ///   maxGeometryInputComponents
        /// is the maximum number of components of input variables which can be
        /// provided as inputs to the geometry shader stage.</summary>
        public UInt32 maxGeometryInputComponents;
        /// <summary>  
        ///   maxGeometryOutputComponents
        /// is the maximum number of components of output variables which can be
        /// output from the geometry shader stage.</summary>
        public UInt32 maxGeometryOutputComponents;
        /// <summary>  
        ///   maxGeometryOutputVertices is
        /// the maximum number of vertices which can be emitted by any geometry
        /// shader.</summary>
        public UInt32 maxGeometryOutputVertices;
        /// <summary>  
        ///   maxGeometryTotalOutputComponents is the maximum total number of
        /// components of output, across all emitted vertices, which can be output
        /// from the geometry shader stage.</summary>
        public UInt32 maxGeometryTotalOutputComponents;
        /// <summary>  
        ///   maxFragmentInputComponents
        /// is the maximum number of components of input variables which can be
        /// provided as inputs to the fragment shader stage.</summary>
        public UInt32 maxFragmentInputComponents;
        /// <summary>  
        ///   maxFragmentOutputAttachments is the maximum number of output
        /// attachments which can be written to by the fragment shader stage.</summary>
        public UInt32 maxFragmentOutputAttachments;
        /// <summary>  
        ///   maxFragmentDualSrcAttachments is the maximum number of output
        /// attachments which can be written to by the fragment shader stage when
        /// blending is enabled and one of the dual source blend modes is in use.
        /// See html/vkspec.html#framebuffer-dsb and dualSrcBlend.</summary>
        public UInt32 maxFragmentDualSrcAttachments;
        /// <summary>  
        ///   maxFragmentCombinedOutputResources is the total number of storage
        /// buffers, storage images, and output buffers which can be used in the
        /// fragment shader stage.</summary>
        public UInt32 maxFragmentCombinedOutputResources;
        /// <summary>  
        ///   maxComputeSharedMemorySize
        /// is the maximum total storage size, in bytes, available for variables
        /// declared with the Workgroup storage class in shader modules (or
        /// with the shared storage qualifier in GLSL) in the compute shader
        /// stage.
        /// The amount of storage consumed by the variables declared with the
        /// Workgroup storage class is implementation-dependent.
        /// However, the amount of storage consumed may not exceed the largest block
        /// size that would be obtained if all active variables declared with
        /// Workgroup storage class were assigned offsets in an arbitrary order
        /// by successively taking the smallest valid offset according to the
        /// Standard Storage Buffer Layout
        /// rules.
        /// (This is equivalent to using the GLSL std430 layout rules.)</summary>
        public UInt32 maxComputeSharedMemorySize;
        public fixed UInt32 maxComputeWorkGroupCount[3];
        /// <summary>  
        ///   maxComputeWorkGroupInvocations is the maximum total number of
        /// compute shader invocations in a single local workgroup.
        /// The product of the X, Y, and Z sizes as specified by the LocalSize
        /// execution mode in shader modules and by the object decorated by the
        /// WorkgroupSize decoration must be less than or equal to this limit.</summary>
        public UInt32 maxComputeWorkGroupInvocations;
        public fixed UInt32 maxComputeWorkGroupSize[3];
        /// <summary>  
        ///   subPixelPrecisionBits is the
        /// number of bits of subpixel precision in framebuffer coordinates
        /// xf  and yf .
        /// See html/vkspec.html#primsrast.</summary>
        public UInt32 subPixelPrecisionBits;
        /// <summary>  
        ///   subTexelPrecisionBits is the
        /// number of bits of precision in the division along an axis of an image
        /// used for minification and magnification filters.
        /// 2 subTexelPrecisionBits   is the actual number of divisions
        /// along each axis of the image represented.
        /// Sub-texel values calculated during image sampling will snap to these
        /// locations when generating the filtered results.</summary>
        public UInt32 subTexelPrecisionBits;
        /// <summary>  
        ///   mipmapPrecisionBits is the number
        /// of bits of division that the LOD calculation for mipmap fetching get
        /// snapped to when determining the contribution from each mip level to the
        /// mip filtered results.
        /// 2 mipmapPrecisionBits   is the actual number of divisions.</summary>
        public UInt32 mipmapPrecisionBits;
        /// <summary>  
        ///   maxDrawIndexedIndexValue is
        /// the maximum index value that can be used for indexed draw calls when
        /// using 32-bit indices.
        /// This excludes the primitive restart index value of 0xFFFFFFFF.
        /// See fullDrawIndexUint32.</summary>
        public UInt32 maxDrawIndexedIndexValue;
        /// <summary>  
        ///   maxDrawIndirectCount is the
        /// maximum draw count that is supported for indirect draw calls.
        /// See multiDrawIndirect.</summary>
        public UInt32 maxDrawIndirectCount;
        /// <summary>  
        ///   maxSamplerLodBias is the maximum
        /// absolute sampler LOD bias.
        /// The sum of the mipLodBias member of the VkSamplerCreateInfo
        /// structure and the Bias operand of image sampling operations in
        /// shader modules (or 0 if no Bias operand is provided to an image
        /// sampling operation) are clamped to the range
        /// [-maxSamplerLodBias,+maxSamplerLodBias].
        /// See html/vkspec.html#samplers-mipLodBias.</summary>
        public float maxSamplerLodBias;
        /// <summary>  
        ///   maxSamplerAnisotropy is the
        /// maximum degree of sampler anisotropy.
        /// The maximum degree of anisotropic filtering used for an image sampling
        /// operation is the minimum of the maxAnisotropy member of the
        /// VkSamplerCreateInfo structure and this limit.
        /// See html/vkspec.html#samplers-maxAnisotropy.</summary>
        public float maxSamplerAnisotropy;
        /// <summary>  
        ///   maxViewports is the maximum number of
        /// active viewports.
        /// The viewportCount member of the
        /// VkPipelineViewportStateCreateInfo structure that is provided at
        /// pipeline creation must be less than or equal to this limit.</summary>
        public UInt32 maxViewports;
        public fixed UInt32 maxViewportDimensions[2];
        public fixed float viewportBoundsRange[2];
        /// <summary>  
        ///   viewportSubPixelBits is the number
        /// of bits of subpixel precision for viewport bounds.
        /// The subpixel precision that floating-point viewport bounds are
        /// interpreted at is given by this limit.</summary>
        public UInt32 viewportSubPixelBits;
        /// <summary>  
        ///   minMemoryMapAlignment is the
        /// minimum required alignment, in bytes, of host visible memory
        /// allocations within the host address space.
        /// When mapping a memory allocation with vkMapMemory, subtracting
        /// offset bytes from the returned pointer will always produce an
        /// integer multiple of this limit.
        /// See html/vkspec.html#memory-device-hostaccess.</summary>
        public Int32 minMemoryMapAlignment;
        /// <summary>  
        ///   minTexelBufferOffsetAlignment is the minimum required alignment,
        /// in bytes, for the offset member of the
        /// VkBufferViewCreateInfo structure for texel buffers.
        /// When a buffer view is created for a buffer which was created with
        /// VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the usage
        /// member of the VkBufferCreateInfo structure, the offset must
        /// be an integer multiple of this limit.</summary>
        public VkDeviceSize minTexelBufferOffsetAlignment;
        /// <summary>  
        ///   minUniformBufferOffsetAlignment is the minimum required
        /// alignment, in bytes, for the offset member of the
        /// VkDescriptorBufferInfo structure for uniform buffers.
        /// When a descriptor of type VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC is updated, the
        /// offset must be an integer multiple of this limit.
        /// Similarly, dynamic offsets for uniform buffers must be multiples of
        /// this limit.</summary>
        public VkDeviceSize minUniformBufferOffsetAlignment;
        /// <summary>  
        ///   minStorageBufferOffsetAlignment is the minimum required
        /// alignment, in bytes, for the offset member of the
        /// VkDescriptorBufferInfo structure for storage buffers.
        /// When a descriptor of type VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC is updated, the
        /// offset must be an integer multiple of this limit.
        /// Similarly, dynamic offsets for storage buffers must be multiples of
        /// this limit.</summary>
        public VkDeviceSize minStorageBufferOffsetAlignment;
        /// <summary>  
        ///   minTexelOffset is the minimum offset
        /// value for the ConstOffset image operand of any of the
        /// OpImageSample* or OpImageFetch* image instructions.</summary>
        public Int32 minTexelOffset;
        /// <summary>  
        ///   maxTexelOffset is the maximum offset
        /// value for the ConstOffset image operand of any of the
        /// OpImageSample* or OpImageFetch* image instructions.</summary>
        public UInt32 maxTexelOffset;
        /// <summary>  
        ///   minTexelGatherOffset is the
        /// minimum offset value for the Offset or ConstOffsets image
        /// operands of any of the OpImage*Gather image instructions.</summary>
        public Int32 minTexelGatherOffset;
        /// <summary>  
        ///   maxTexelGatherOffset is the
        /// maximum offset value for the Offset or ConstOffsets image
        /// operands of any of the OpImage*Gather image instructions.</summary>
        public UInt32 maxTexelGatherOffset;
        /// <summary>  
        ///   minInterpolationOffset is the
        /// minimum negative offset value for the offset operand of the
        /// InterpolateAtOffset extended instruction.</summary>
        public float minInterpolationOffset;
        /// <summary>  
        ///   maxInterpolationOffset is the
        /// maximum positive offset value for the offset operand of the
        /// InterpolateAtOffset extended instruction.</summary>
        public float maxInterpolationOffset;
        /// <summary>  
        ///   subPixelInterpolationOffsetBits is the number of subpixel
        /// fractional bits that the x and y offsets to the
        /// InterpolateAtOffset extended instruction may be rounded to as
        /// fixed-point values.</summary>
        public UInt32 subPixelInterpolationOffsetBits;
        /// <summary>  
        ///   maxFramebufferWidth is the maximum
        /// width for a framebuffer.
        /// The width member of the VkFramebufferCreateInfo structure
        /// must be less than or equal to this limit.</summary>
        public UInt32 maxFramebufferWidth;
        /// <summary>  
        ///   maxFramebufferHeight is the
        /// maximum height for a framebuffer.
        /// The height member of the VkFramebufferCreateInfo structure
        /// must be less than or equal to this limit.</summary>
        public UInt32 maxFramebufferHeight;
        /// <summary>  
        ///   maxFramebufferLayers is the
        /// maximum layer count for a layered framebuffer.
        /// The layers member of the VkFramebufferCreateInfo structure
        /// must be less than or equal to this limit.</summary>
        public UInt32 maxFramebufferLayers;
        /// <summary>  
        ///   framebufferColorSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the color sample counts that are
        /// supported for all framebuffer color attachments with floating- or
        /// fixed-point formats.
        /// There is no limit that specifies the color sample counts that are
        /// supported for all color attachments with integer formats.</summary>
        public VkSampleCountFlags framebufferColorSampleCounts;
        /// <summary>  
        ///   framebufferDepthSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the supported depth sample counts
        /// for all framebuffer depth/stencil attachments, when the format includes
        /// a depth component.</summary>
        public VkSampleCountFlags framebufferDepthSampleCounts;
        /// <summary> framebufferStencilSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the supported stencil sample
        /// counts for all framebuffer depth/stencil attachments, when the format
        /// includes a stencil component.</summary>
        public VkSampleCountFlags framebufferStencilSampleCounts;
        /// <summary> framebufferNoAttachmentsSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the supported sample counts for a
        /// framebuffer with no attachments.</summary>
        public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
        /// <summary>  
        ///   maxColorAttachments is the maximum
        /// number of color attachments that can be used by a subpass in a render
        /// pass.
        /// The colorAttachmentCount member of the VkSubpassDescription
        /// structure must be less than or equal to this limit.</summary>
        public UInt32 maxColorAttachments;
        /// <summary>  
        ///   sampledImageColorSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the sample counts supported for
        /// all 2D images created with VK_IMAGE_TILING_OPTIMAL, usage
        /// containing VK_IMAGE_USAGE_SAMPLED_BIT, and a non-integer color
        /// format.</summary>
        public VkSampleCountFlags sampledImageColorSampleCounts;
        /// <summary>  
        ///   sampledImageIntegerSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the sample counts supported for
        /// all 2D images created with VK_IMAGE_TILING_OPTIMAL, usage
        /// containing VK_IMAGE_USAGE_SAMPLED_BIT, and an integer color
        /// format.</summary>
        public VkSampleCountFlags sampledImageIntegerSampleCounts;
        /// <summary>  
        ///   sampledImageDepthSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the sample counts supported for
        /// all 2D images created with VK_IMAGE_TILING_OPTIMAL, usage
        /// containing VK_IMAGE_USAGE_SAMPLED_BIT, and a depth format.</summary>
        public VkSampleCountFlags sampledImageDepthSampleCounts;
        /// <summary>  
        ///   sampledImageStencilSampleCounts is a bitmask1 of
        /// VkSampleCountFlagBits indicating the sample supported for all 2D
        /// images created with VK_IMAGE_TILING_OPTIMAL, usage
        /// containing VK_IMAGE_USAGE_SAMPLED_BIT, and a stencil format.</summary>
        public VkSampleCountFlags sampledImageStencilSampleCounts;
        /// <summary>  
        ///   storageImageSampleCounts is a
        /// bitmask1 of VkSampleCountFlagBits indicating the sample counts
        /// supported for all 2D images created with VK_IMAGE_TILING_OPTIMAL,
        /// and usage containing VK_IMAGE_USAGE_STORAGE_BIT.</summary>
        public VkSampleCountFlags storageImageSampleCounts;
        /// <summary>  
        ///   maxSampleMaskWords is the maximum
        /// number of array elements of a variable decorated with the
        /// SampleMask built-in decoration.</summary>
        public UInt32 maxSampleMaskWords;
        /// <summary>  
        ///   timestampComputeAndGraphics
        /// specifies support for timestamps on all graphics and compute queues.
        /// If this limit is set to VK_TRUE, all queues that advertise the
        /// VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT in the
        /// VkQueueFamilyProperties::queueFlags support
        /// VkQueueFamilyProperties::timestampValidBits of at least 36.
        /// See Timestamp Queries.</summary>
        public VkBool32 timestampComputeAndGraphics;
        /// <summary>  
        ///   timestampPeriod is the number of
        /// nanoseconds required for a timestamp query to be incremented by 1.
        /// See Timestamp Queries.</summary>
        public float timestampPeriod;
        /// <summary>  
        ///   maxClipDistances is the maximum number
        /// of clip distances that can be used in a single shader stage.
        /// The size of any array declared with the ClipDistance built-in
        /// decoration in a shader module must be less than or equal to this limit.</summary>
        public UInt32 maxClipDistances;
        /// <summary>  
        ///   maxCullDistances is the maximum number
        /// of cull distances that can be used in a single shader stage.
        /// The size of any array declared with the CullDistance built-in
        /// decoration in a shader module must be less than or equal to this limit.</summary>
        public UInt32 maxCullDistances;
        /// <summary>  
        ///   maxCombinedClipAndCullDistances is the maximum combined number of
        /// clip and cull distances that can be used in a single shader stage.
        /// The sum of the sizes of any pair of arrays declared with the
        /// ClipDistance and CullDistance built-in decoration used by a
        /// single shader stage in a shader module must be less than or equal to
        /// this limit.</summary>
        public UInt32 maxCombinedClipAndCullDistances;
        /// <summary>  
        ///   discreteQueuePriorities is the
        /// number of discrete priorities that can be assigned to a queue based on
        /// the value of each member of
        /// VkDeviceQueueCreateInfo::pQueuePriorities.
        /// This must be at least 2, and levels must be spread evenly over the
        /// range, with at least one level at 1.0, and another at 0.0.
        /// See html/vkspec.html#devsandqueues-priority.</summary>
        public UInt32 discreteQueuePriorities;
        public fixed float pointSizeRange[2];
        public fixed float lineWidthRange[2];
        /// <summary>  
        ///   pointSizeGranularity is the
        /// granularity of supported point sizes.
        /// Not all point sizes in the range defined by pointSizeRange are
        /// supported.
        /// This limit specifies the granularity (or increment) between successive
        /// supported point sizes.</summary>
        public float pointSizeGranularity;
        /// <summary>  
        ///   lineWidthGranularity is the
        /// granularity of supported line widths.
        /// Not all line widths in the range defined by lineWidthRange are
        /// supported.
        /// This limit specifies the granularity (or increment) between successive
        /// supported line widths.</summary>
        public float lineWidthGranularity;
        /// <summary>  
        ///   strictLines specifies whether lines are
        /// rasterized according to the preferred method of rasterization.
        /// If set to VK_FALSE, lines may be rasterized under a relaxed set
        /// of rules.
        /// If set to VK_TRUE, lines are rasterized as per the strict
        /// definition.
        /// See Basic Line Segment Rasterization.</summary>
        public VkBool32 strictLines;
        /// <summary>  
        ///   standardSampleLocations
        /// specifies whether rasterization uses the standard sample locations as
        /// documented in Multisampling.
        /// If set to VK_TRUE, the implementation uses the documented sample
        /// locations.
        /// If set to VK_FALSE, the implementation may use different sample
        /// locations.</summary>
        public VkBool32 standardSampleLocations;
        /// <summary>  
        ///   optimalBufferCopyOffsetAlignment is the optimal buffer offset
        /// alignment in bytes for vkCmdCopyBufferToImage and
        /// vkCmdCopyImageToBuffer.
        /// The per texel alignment requirements are enforced, but applications
        /// should use the optimal alignment for optimal performance and power use.</summary>
        public VkDeviceSize optimalBufferCopyOffsetAlignment;
        /// <summary>  
        ///   optimalBufferCopyRowPitchAlignment is the optimal buffer row pitch
        /// alignment in bytes for vkCmdCopyBufferToImage and
        /// vkCmdCopyImageToBuffer.
        /// Row pitch is the number of bytes between texels with the same X
        /// coordinate in adjacent rows (Y coordinates differ by one).
        /// The per texel alignment requirements are enforced, but applications
        /// should use the optimal alignment for optimal performance and power use.</summary>
        public VkDeviceSize optimalBufferCopyRowPitchAlignment;
        /// <summary>  
        ///   nonCoherentAtomSize is the size and
        /// alignment in bytes that bounds concurrent access to
        /// host-mapped device memory.</summary>
        public VkDeviceSize nonCoherentAtomSize;
    }
    // Struct: 266
    /// <summary>VkPhysicalDeviceMaintenance3Properties - Structure describing descriptor set properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceMaintenance3Properties {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxPerSetDescriptors;
        public VkDeviceSize maxMemoryAllocationSize;
    }
    // Struct: 267
    /// <summary>VkPhysicalDeviceMemoryBudgetPropertiesEXT - Structure specifying physical device memory budget and usage
    /// </summary>
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        public fixed VkDeviceSize heapBudget[VK_MAX_MEMORY_HEAPS];
        public fixed VkDeviceSize heapUsage[VK_MAX_MEMORY_HEAPS];
    }
    // Struct: 268
    /// <summary>VkPhysicalDeviceMemoryPriorityFeaturesEXT - Structure describing memory priority features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 memoryPriority;
    }
    // Struct: 269
    /// <summary>VkPhysicalDeviceMemoryProperties - Structure specifying physical device memory properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceMemoryProperties {
        /// <summary> memoryTypeCount is the number of valid elements in the
        /// memoryTypes array.</summary>
        public UInt32 memoryTypeCount;
        public fixed VkMemoryType memoryTypes[VK_MAX_MEMORY_TYPES];
        /// <summary> memoryHeapCount is the number of valid elements in the
        /// memoryHeaps array.</summary>
        public UInt32 memoryHeapCount;
        public fixed VkMemoryHeap memoryHeaps[VK_MAX_MEMORY_HEAPS];
    }
    // Struct: 270
    /// <summary>VkPhysicalDeviceMemoryProperties2 - Structure specifying physical device memory properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceMemoryProperties2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> memoryProperties is a structure of type
        /// VkPhysicalDeviceMemoryProperties which is populated with the same
        /// values as in vkGetPhysicalDeviceMemoryProperties.</summary>
        public VkPhysicalDeviceMemoryProperties memoryProperties;
    }
    // Struct: 271
    /// <summary>VkPhysicalDeviceMeshShaderFeaturesNV - Structure describing mesh shading features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        /// <summary>  
        ///   taskShader indicates whether the task
        /// shader stage is supported.</summary>
        public VkBool32 taskShader;
        /// <summary>  
        ///   meshShader indicates whether the mesh
        /// shader stage is supported.</summary>
        public VkBool32 meshShader;
    }
    // Struct: 272
    /// <summary>VkPhysicalDeviceMeshShaderPropertiesNV - Structure describing mesh shading properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxDrawMeshTasksCount;
        public UInt32 maxTaskWorkGroupInvocations;
        public fixed UInt32 maxTaskWorkGroupSize[3];
        public UInt32 maxTaskTotalMemorySize;
        public UInt32 maxTaskOutputCount;
        public UInt32 maxMeshWorkGroupInvocations;
        public fixed UInt32 maxMeshWorkGroupSize[3];
        public UInt32 maxMeshTotalMemorySize;
        public UInt32 maxMeshOutputVertices;
        public UInt32 maxMeshOutputPrimitives;
        public UInt32 maxMeshMultiviewViewCount;
        public UInt32 meshOutputPerVertexGranularity;
        public UInt32 meshOutputPerPrimitiveGranularity;
    }
    // Struct: 273
    /// <summary>VkPhysicalDeviceMultiviewFeatures - Structure describing multiview features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceMultiviewFeatures {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiview;
        public VkBool32 multiviewGeometryShader;
        public VkBool32 multiviewTessellationShader;
    }
    // Struct: 274
    /// <summary>VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX - Structure describing multiview limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perViewPositionAllComponents;
    }
    // Struct: 275
    /// <summary>VkPhysicalDeviceMultiviewProperties - Structure describing multiview limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceMultiviewProperties {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxMultiviewViewCount;
        public UInt32 maxMultiviewInstanceIndex;
    }
    // Struct: 276
    /// <summary>VkPhysicalDevicePCIBusInfoPropertiesEXT - Structure containing PCI bus information of a physical device
    /// </summary>
    public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> pciDomain is the PCI bus domain.</summary>
        public UInt32 pciDomain;
        /// <summary> pciBus is the PCI bus identifier.</summary>
        public UInt32 pciBus;
        /// <summary> pciDevice is the PCI device identifier.</summary>
        public UInt32 pciDevice;
        /// <summary> pciFunction is the PCI device function identifier.</summary>
        public UInt32 pciFunction;
    }
    // Struct: 277
    /// <summary>VkPhysicalDevicePointClippingProperties - Structure describing the point clipping behavior supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDevicePointClippingProperties {
        public VkStructureType sType;
        public void* pNext;
        public VkPointClippingBehavior pointClippingBehavior;
    }
    // Struct: 278
    /// <summary>VkPhysicalDeviceProperties - Structure specifying physical device properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceProperties {
        /// <summary> apiVersion is the version of Vulkan supported by the device,
        /// encoded as described in html/vkspec.html#extendingvulkan-coreversions-versionnumbers.</summary>
        public UInt32 apiVersion;
        /// <summary> driverVersion is the vendor-specified version of the driver.</summary>
        public UInt32 driverVersion;
        /// <summary> vendorID is a unique identifier for the vendor (see below) of
        /// the physical device.</summary>
        public UInt32 vendorID;
        /// <summary> deviceID is a unique identifier for the physical device among
        /// devices available from the vendor.</summary>
        public UInt32 deviceID;
        /// <summary> deviceType is a VkPhysicalDeviceType specifying the type of
        /// device.</summary>
        public VkPhysicalDeviceType deviceType;
        public fixed char deviceName[VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
        public fixed byte pipelineCacheUUID[VK_UUID_SIZE];
        /// <summary> limits is the VkPhysicalDeviceLimits structure which
        /// specifies device-specific limits of the physical device.
        /// See Limits for details.</summary>
        public VkPhysicalDeviceLimits limits;
        /// <summary> sparseProperties is the VkPhysicalDeviceSparseProperties
        /// structure which specifies various sparse related properties of the
        /// physical device.
        /// See Sparse Properties for details.</summary>
        public VkPhysicalDeviceSparseProperties sparseProperties;
    }
    // Struct: 279
    /// <summary>VkPhysicalDeviceProperties2 - Structure specifying physical device properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceProperties2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> properties is a structure of type VkPhysicalDeviceProperties
        /// describing the properties of the physical device.
        /// This structure is written with the same values as if it were written by
        /// vkGetPhysicalDeviceProperties.</summary>
        public VkPhysicalDeviceProperties properties;
    }
    // Struct: 280
    /// <summary>VkPhysicalDeviceProtectedMemoryFeatures - Structure describing protected memory features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures {
        public VkStructureType sType;
        public void* pNext;
        /// <summary>  
        ///   protectedMemory specifies
        /// whether protected memory is supported.</summary>
        public VkBool32 protectedMemory;
    }
    // Struct: 281
    /// <summary>VkPhysicalDeviceProtectedMemoryProperties - Structure describing protected memory properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceProtectedMemoryProperties {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> protectedNoFault specifies the behavior of the implementation when
        /// protected memory access rules are
        /// broken.
        /// If protectedNoFault is VK_TRUE, breaking those rules will
        /// not result in process termination or device loss.</summary>
        public VkBool32 protectedNoFault;
    }
    // Struct: 282
    /// <summary>VkPhysicalDevicePushDescriptorPropertiesKHR - Structure describing push descriptor limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxPushDescriptors;
    }
    // Struct: 283
    /// <summary>VkPhysicalDeviceRayTracingPropertiesNV - Properties of the physical device for ray tracing
    /// </summary>
    public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> shaderGroupHandleSize size in bytes of the shader header.</summary>
        public UInt32 shaderGroupHandleSize;
        /// <summary> maxRecursionDepth is the maximum number of levels of recursion
        /// allowed in a trace command.</summary>
        public UInt32 maxRecursionDepth;
        /// <summary> maxShaderGroupStride is the maximum stride in bytes allowed
        /// between shader groups in the SBT.</summary>
        public UInt32 maxShaderGroupStride;
        /// <summary> shaderGroupBaseAlignment is the required alignment in bytes for
        /// the base of the SBTs.</summary>
        public UInt32 shaderGroupBaseAlignment;
        /// <summary> maxGeometryCount is the maximum number of geometries in the bottom
        /// level acceleration structure.</summary>
        public UInt64 maxGeometryCount;
        /// <summary> maxInstanceCount is the maximum number of instances in the top
        /// level acceleration structure.</summary>
        public UInt64 maxInstanceCount;
        /// <summary> maxTriangleCount is the maximum number of triangles in all
        /// geometries in the bottom level acceleration structure.</summary>
        public UInt64 maxTriangleCount;
        /// <summary> maxDescriptorSetAccelerationStructures is the maximum number of
        /// acceleration structure descriptors that are allowed in a descriptor set.</summary>
        public UInt32 maxDescriptorSetAccelerationStructures;
    }
    // Struct: 284
    /// <summary>VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV - Structure describing the representative fragment test features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTest;
    }
    // Struct: 285
    /// <summary>VkPhysicalDeviceSampleLocationsPropertiesEXT - Structure describing sample location limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleLocationSampleCounts;
        public VkExtent2D maxSampleLocationGridSize;
        public fixed float sampleLocationCoordinateRange[2];
        public UInt32 sampleLocationSubPixelBits;
        public VkBool32 variableSampleLocations;
    }
    // Struct: 286
    /// <summary>VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT - Structure describing sampler filter minmax limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 filterMinmaxSingleComponentFormats;
        public VkBool32 filterMinmaxImageComponentMapping;
    }
    // Struct: 287
    /// <summary>VkPhysicalDeviceSamplerYcbcrConversionFeatures - Structure describing Y’CbCr conversion features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 samplerYcbcrConversion;
    }
    // Struct: 288
    /// <summary>VkPhysicalDeviceScalarBlockLayoutFeaturesEXT - Structure indicating support for scalar block layouts
    /// </summary>
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 scalarBlockLayout;
    }
    // Struct: 289
    /// <summary>VkPhysicalDeviceShaderAtomicInt64FeaturesKHR - Structure describing features supported by VK_KHR_shader_atomic_int64
    /// </summary>
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   shaderBufferInt64Atomics
        /// indicates whether shaders can support 64-bit unsigned and signed
        /// integer atomic operations on buffers.</summary>
        public VkBool32 shaderBufferInt64Atomics;
        /// <summary>  
        ///   shaderSharedInt64Atomics
        /// indicates whether shaders can support 64-bit unsigned and signed
        /// integer atomic operations on shared memory.</summary>
        public VkBool32 shaderSharedInt64Atomics;
    }
    // Struct: 290
    /// <summary>VkPhysicalDeviceShaderCorePropertiesAMD - Structure describing shader core properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 shaderEngineCount;
        public UInt32 shaderArraysPerEngineCount;
        public UInt32 computeUnitsPerShaderArray;
        public UInt32 simdPerComputeUnit;
        public UInt32 wavefrontsPerSimd;
        public UInt32 wavefrontSize;
        public UInt32 sgprsPerSimd;
        public UInt32 minSgprAllocation;
        public UInt32 maxSgprAllocation;
        public UInt32 sgprAllocationGranularity;
        public UInt32 vgprsPerSimd;
        public UInt32 minVgprAllocation;
        public UInt32 maxVgprAllocation;
        public UInt32 vgprAllocationGranularity;
    }
    // Struct: 291
    /// <summary>VkPhysicalDeviceShaderDrawParametersFeatures - Structure describing shader draw parameter features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures {
        public VkStructureType sType;
        public void* pNext;
        /// <summary>  
        ///   shaderDrawParameters specifies
        /// whether shader draw parameters are supported.</summary>
        public VkBool32 shaderDrawParameters;
    }
    // Struct: 292
    /// <summary>VkPhysicalDeviceShaderImageFootprintFeaturesNV - Structure describing shader image footprint features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        /// <summary>  
        ///   imageFootprint specifies whether the
        /// implementation supports the ImageFootprintNV SPIR-V capability.</summary>
        public VkBool32 imageFootprint;
    }
    // Struct: 293
    /// <summary>VkPhysicalDeviceShadingRateImageFeaturesNV - Structure describing shading rate image features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shadingRateImage;
        public VkBool32 shadingRateCoarseSampleOrder;
    }
    // Struct: 294
    /// <summary>VkPhysicalDeviceShadingRateImagePropertiesNV - Structure describing shading rate image limits that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D shadingRateTexelSize;
        public UInt32 shadingRatePaletteSize;
        public UInt32 shadingRateMaxCoarseSamples;
    }
    // Struct: 295
    /// <summary>VkPhysicalDeviceSparseImageFormatInfo2 - Structure specifying sparse image format inputs
    /// </summary>
    public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> format is the image format.</summary>
        public VkFormat format;
        /// <summary> type is the dimensionality of image.</summary>
        public VkImageType type;
        /// <summary> samples is the number of samples per texel as defined in
        /// VkSampleCountFlagBits.</summary>
        public VkSampleCountFlagBits samples;
        /// <summary> usage is a bitmask describing the intended usage of the image.</summary>
        public VkImageUsageFlags usage;
        /// <summary> tiling is the tiling arrangement of the texel blocks in memory.</summary>
        public VkImageTiling tiling;
    }
    // Struct: 296
    /// <summary>VkPhysicalDeviceSparseProperties - Structure specifying physical device sparse memory properties
    /// </summary>
    public unsafe struct VkPhysicalDeviceSparseProperties {
        /// <summary> residencyStandard2DBlockShape is VK_TRUE if the physical
        /// device will access all single-sample 2D sparse resources using the
        /// standard sparse image block shapes (based on image format), as described
        /// in the Standard Sparse Image
        /// Block Shapes (Single Sample) table.
        /// If this property is not supported the value returned in the
        /// imageGranularity member of the VkSparseImageFormatProperties
        /// structure for single-sample 2D images is not required to match the
        /// standard sparse image block dimensions listed in the table.</summary>
        public VkBool32 residencyStandard2DBlockShape;
        /// <summary> residencyStandard2DMultisampleBlockShape is VK_TRUE if the
        /// physical device will access all multisample 2D sparse resources using
        /// the standard sparse image block shapes (based on image format), as
        /// described in the Standard Sparse
        /// Image Block Shapes (MSAA) table.
        /// If this property is not supported, the value returned in the
        /// imageGranularity member of the VkSparseImageFormatProperties
        /// structure for multisample 2D images is not required to match the
        /// standard sparse image block dimensions listed in the table.</summary>
        public VkBool32 residencyStandard2DMultisampleBlockShape;
        /// <summary> residencyStandard3DBlockShape is VK_TRUE if the physical
        /// device will access all 3D sparse resources using the standard sparse
        /// image block shapes (based on image format), as described in the
        /// Standard Sparse Image Block
        /// Shapes (Single Sample) table.
        /// If this property is not supported, the value returned in the
        /// imageGranularity member of the VkSparseImageFormatProperties
        /// structure for 3D images is not required to match the standard sparse
        /// image block dimensions listed in the table.</summary>
        public VkBool32 residencyStandard3DBlockShape;
        /// <summary> residencyAlignedMipSize is VK_TRUE if images with mip level
        /// dimensions that are not integer multiples of the corresponding
        /// dimensions of the sparse image block may be placed in the mip tail.
        /// If this property is not reported, only mip levels with dimensions
        /// smaller than the imageGranularity member of the
        /// VkSparseImageFormatProperties structure will be placed in the mip
        /// tail.
        /// If this property is reported the implementation is allowed to return
        /// VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT in the flags
        /// member of VkSparseImageFormatProperties, indicating that mip level
        /// dimensions that are not integer multiples of the corresponding
        /// dimensions of the sparse image block will be placed in the mip tail.</summary>
        public VkBool32 residencyAlignedMipSize;
        /// <summary> residencyNonResidentStrict specifies whether the physical device
        /// can consistently access non-resident regions of a resource.
        /// If this property is VK_TRUE, access to non-resident regions of
        /// resources will be guaranteed to return values as if the resource were
        /// populated with 0; writes to non-resident regions will be discarded.</summary>
        public VkBool32 residencyNonResidentStrict;
    }
    // Struct: 297
    /// <summary>VkPhysicalDeviceSubgroupProperties - Structure describing subgroup support for an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceSubgroupProperties {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 subgroupSize;
        public VkShaderStageFlags supportedStages;
        public VkSubgroupFeatureFlags supportedOperations;
        public VkBool32 quadOperationsInAllStages;
    }
    // Struct: 298
    /// <summary>VkPhysicalDeviceSurfaceInfo2KHR - Structure specifying a surface and related swapchain creation parameters
    /// </summary>
    public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> surface is the surface that will be associated with the swapchain.</summary>
        public VkSurfaceKHR surface;
    }
    // Struct: 299
    /// <summary>VkPhysicalDeviceTransformFeedbackFeaturesEXT - Structure describing transform feedback features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 transformFeedback;
        public VkBool32 geometryStreams;
    }
    // Struct: 300
    /// <summary>VkPhysicalDeviceTransformFeedbackPropertiesEXT - Structure describing transform feedback properties that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxTransformFeedbackStreams;
        public UInt32 maxTransformFeedbackBuffers;
        public VkDeviceSize maxTransformFeedbackBufferSize;
        public UInt32 maxTransformFeedbackStreamDataSize;
        public UInt32 maxTransformFeedbackBufferDataSize;
        public UInt32 maxTransformFeedbackBufferDataStride;
        public VkBool32 transformFeedbackQueries;
        public VkBool32 transformFeedbackStreamsLinesTriangles;
        public VkBool32 transformFeedbackRasterizationStreamSelect;
        public VkBool32 transformFeedbackDraw;
    }
    // Struct: 301
    /// <summary>VkPhysicalDeviceVariablePointersFeatures - Structure describing variable pointers features that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceVariablePointersFeatures {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 variablePointersStorageBuffer;
        public VkBool32 variablePointers;
    }
    // Struct: 302
    /// <summary>VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT - Structure describing if fetching of vertex attribute may be repeated for instanced rendering
    /// </summary>
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   vertexAttributeInstanceRateDivisor specifies whether vertex
        /// attribute fetching may be repeated in case of instanced rendering.</summary>
        public VkBool32 vertexAttributeInstanceRateDivisor;
        /// <summary>  
        ///   vertexAttributeInstanceRateZeroDivisor specifies whether a zero
        /// value for VkVertexInputBindingDivisorDescriptionEXT::divisor
        /// is supported.</summary>
        public VkBool32 vertexAttributeInstanceRateZeroDivisor;
    }
    // Struct: 303
    /// <summary>VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT - Structure describing max value of vertex attribute divisor that can be supported by an implementation
    /// </summary>
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 maxVertexAttribDivisor;
    }
    // Struct: 304
    /// <summary>VkPhysicalDeviceVulkanMemoryModelFeaturesKHR - Structure describing features supported by VK_KHR_vulkan_memory_model
    /// </summary>
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary>  
        ///   vulkanMemoryModel indicates whether
        /// the Vulkan Memory Model is supported, as defined in
        /// Vulkan Memory Model.
        /// This also indicates whether shader modules can declare the
        /// VulkanMemoryModelKHR capability.</summary>
        public VkBool32 vulkanMemoryModel;
        /// <summary>  
        ///   vulkanMemoryModelDeviceScope indicates whether the Vulkan Memory
        /// Model can use Device scope synchronization.
        /// This also indicates whether shader modules can declare the
        /// VulkanMemoryModelDeviceScopeKHR capability.</summary>
        public VkBool32 vulkanMemoryModelDeviceScope;
        /// <summary>  
        ///   vulkanMemoryModelAvailabilityVisibilityChains indicates whether
        /// the Vulkan Memory Model can use availability and visibility chains with more than one element.</summary>
        public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
    }
    // Struct: 305
    /// <summary>VkPhysicalDeviceYcbcrImageArraysFeaturesEXT - Structure describing extended Y
    /// </summary>
    public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcrImageArrays;
    }
    // Struct: 306
    /// <summary>VkPipelineCacheCreateInfo - Structure specifying parameters of a newly created pipeline cache
    /// </summary>
    public unsafe struct VkPipelineCacheCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineCacheCreateFlags flags;
        /// <summary> initialDataSize is the number of bytes in pInitialData.
        /// If initialDataSize is zero, the pipeline cache will initially be
        /// empty.</summary>
        public Int32 initialDataSize;
        /// <summary> pInitialData is a pointer to previously retrieved pipeline cache
        /// data.
        /// If the pipeline cache data is incompatible (as defined below) with the
        /// device, the pipeline cache will be initially empty.
        /// If initialDataSize is zero, pInitialData is ignored.</summary>
        public /*-const-*/ void* pInitialData;
    }
    // Struct: 307
    /// <summary>VkPipelineColorBlendAdvancedStateCreateInfoEXT - Structure specifying parameters that affect advanced blend operations
    /// </summary>
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcPremultiplied specifies whether the source color of the blend
        /// operation is treated as premultiplied.</summary>
        public VkBool32 srcPremultiplied;
        /// <summary> dstPremultiplied specifies whether the destination color of the
        /// blend operation is treated as premultiplied.</summary>
        public VkBool32 dstPremultiplied;
        /// <summary> blendOverlap is a VkBlendOverlapEXT value specifying how the
        /// source and destination sample’s coverage is correlated.</summary>
        public VkBlendOverlapEXT blendOverlap;
    }
    // Struct: 308
    /// <summary>VkPipelineColorBlendAttachmentState - Structure specifying a pipeline color blend attachment state
    /// </summary>
    public unsafe struct VkPipelineColorBlendAttachmentState {
        /// <summary> blendEnable controls whether blending is enabled for the
        /// corresponding color attachment.
        /// If blending is not enabled, the source fragment’s color for that
        /// attachment is passed through unmodified.</summary>
        public VkBool32 blendEnable;
        /// <summary> srcColorBlendFactor selects which blend factor is used to
        /// determine the source factors (Sr,Sg,Sb).</summary>
        public VkBlendFactor srcColorBlendFactor;
        /// <summary> dstColorBlendFactor selects which blend factor is used to
        /// determine the destination factors (Dr,Dg,Db).</summary>
        public VkBlendFactor dstColorBlendFactor;
        /// <summary> colorBlendOp selects which blend operation is used to calculate
        /// the RGB values to write to the color attachment.</summary>
        public VkBlendOp colorBlendOp;
        /// <summary> srcAlphaBlendFactor selects which blend factor is used to
        /// determine the source factor Sa .</summary>
        public VkBlendFactor srcAlphaBlendFactor;
        /// <summary> dstAlphaBlendFactor selects which blend factor is used to
        /// determine the destination factor Da .</summary>
        public VkBlendFactor dstAlphaBlendFactor;
        /// <summary> alphaBlendOp selects which blend operation is use to calculate the
        /// alpha values to write to the color attachment.</summary>
        public VkBlendOp alphaBlendOp;
        /// <summary> colorWriteMask is a bitmask of VkColorComponentFlagBits
        /// specifying which of the R, G, B, and/or A components are enabled for
        /// writing, as described for the Color Write
        /// Mask.</summary>
        public VkColorComponentFlags colorWriteMask;
    }
    // Struct: 309
    /// <summary>VkPipelineColorBlendStateCreateInfo - Structure specifying parameters of a newly created pipeline color blend state
    /// </summary>
    public unsafe struct VkPipelineColorBlendStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineColorBlendStateCreateFlags flags;
        /// <summary> logicOpEnable controls whether to apply Logical Operations.</summary>
        public VkBool32 logicOpEnable;
        /// <summary> logicOp selects which logical operation to apply.</summary>
        public VkLogicOp logicOp;
        /// <summary> attachmentCount is the number of
        /// VkPipelineColorBlendAttachmentState elements in
        /// pAttachments.
        /// This value must equal the colorAttachmentCount for the subpass in
        /// which this pipeline is used.</summary>
        public UInt32 attachmentCount;
        /// <summary> pAttachments: is a pointer to array of per target attachment
        /// states.</summary>
        public /*-const-*/ VkPipelineColorBlendAttachmentState* pAttachments;
        public fixed float blendConstants[4];
    }
    // Struct: 310
    /// <summary>VkPipelineCoverageModulationStateCreateInfoNV - Structure specifying parameters controlling coverage modulation
    /// </summary>
    public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineCoverageModulationStateCreateFlagsNV flags;
        /// <summary> coverageModulationMode controls which color components are
        /// modulated and is of type VkCoverageModulationModeNV.</summary>
        public VkCoverageModulationModeNV coverageModulationMode;
        /// <summary> coverageModulationTableEnable controls whether the modulation
        /// factor is looked up from a table in pCoverageModulationTable.</summary>
        public VkBool32 coverageModulationTableEnable;
        /// <summary> coverageModulationTableCount is the number of elements in
        /// pCoverageModulationTable.</summary>
        public UInt32 coverageModulationTableCount;
        /// <summary> pCoverageModulationTable is a table of modulation factors
        /// containing a value for each number of covered samples.</summary>
        public /*-const-*/ float* pCoverageModulationTable;
    }
    // Struct: 311
    /// <summary>VkPipelineCoverageToColorStateCreateInfoNV - Structure specifying whether fragment coverage replaces a color
    /// </summary>
    public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineCoverageToColorStateCreateFlagsNV flags;
        /// <summary> coverageToColorEnable controls whether the fragment coverage value
        /// replaces a fragment color output.</summary>
        public VkBool32 coverageToColorEnable;
        /// <summary> coverageToColorLocation controls which fragment shader color
        /// output value is replaced.</summary>
        public UInt32 coverageToColorLocation;
    }
    // Struct: 312
    /// <summary>VkPipelineCreationFeedbackCreateInfoEXT - Request for feedback about the creation of a pipeline
    /// </summary>
    public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> pPipelineCreationFeedback is a pointer to a
        /// VkPipelineCreationFeedbackEXT structure.</summary>
        public VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
        /// <summary> pipelineStageCreationFeedbackCount is the number of elements in
        /// pPipelineStageCreationFeedbacks.</summary>
        public UInt32 pipelineStageCreationFeedbackCount;
        /// <summary> pPipelineStageCreationFeedbacks is an array of size
        /// pipelineStageCreationFeedbackCount of
        /// VkPipelineCreationFeedbackEXT structures.</summary>
        public VkPipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks;
    }
    // Struct: 313
    /// <summary>VkPipelineCreationFeedbackEXT - Feedback about the creation of a pipeline or pipeline stage
    /// </summary>
    public unsafe struct VkPipelineCreationFeedbackEXT {
        /// <summary> flags is a bitmask of VkPipelineCreationFeedbackFlagBitsEXT
        /// providing feedback about the creation of a pipeline or of a pipeline
        /// stage.</summary>
        public VkPipelineCreationFeedbackFlagsEXT flags;
        /// <summary> duration is the duration spent creating a pipeline or pipeline
        /// stage in nanoseconds.</summary>
        public UInt64 duration;
    }
    // Struct: 314
    /// <summary>VkPipelineDepthStencilStateCreateInfo - Structure specifying parameters of a newly created pipeline depth stencil state
    /// </summary>
    public unsafe struct VkPipelineDepthStencilStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineDepthStencilStateCreateFlags flags;
        /// <summary> depthTestEnable controls whether depth testing
        /// is enabled.</summary>
        public VkBool32 depthTestEnable;
        /// <summary> depthWriteEnable controls whether depth
        /// writes are enabled when depthTestEnable is VK_TRUE.
        /// Depth writes are always disabled when depthTestEnable is
        /// VK_FALSE.</summary>
        public VkBool32 depthWriteEnable;
        /// <summary> depthCompareOp is the comparison operator used in the
        /// depth test.</summary>
        public VkCompareOp depthCompareOp;
        /// <summary> depthBoundsTestEnable controls whether depth bounds
        /// testing is enabled.</summary>
        public VkBool32 depthBoundsTestEnable;
        /// <summary> stencilTestEnable controls whether stencil
        /// testing is enabled.</summary>
        public VkBool32 stencilTestEnable;
        /// <summary> front and back control the parameters of the
        /// stencil test.</summary>
        public VkStencilOpState front;
        public VkStencilOpState back;
        /// <summary> minDepthBounds and maxDepthBounds define the range of values
        /// used in the depth bounds test.</summary>
        public float minDepthBounds;
        public float maxDepthBounds;
    }
    // Struct: 315
    /// <summary>VkPipelineDiscardRectangleStateCreateInfoEXT - Structure specifying discard rectangle
    /// </summary>
    public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
        /// <summary> discardRectangleMode is the mode used to determine whether
        /// fragments that lie within the discard rectangle are discarded or not.</summary>
        public VkDiscardRectangleModeEXT discardRectangleMode;
        /// <summary> discardRectangleCount is the number of discard rectangles used by
        /// the pipeline.</summary>
        public UInt32 discardRectangleCount;
        /// <summary> pDiscardRectangles is a pointer to an array of VkRect2D
        /// structures, defining the discard rectangles.
        /// If the discard rectangle state is dynamic, this member is ignored.</summary>
        public /*-const-*/ VkRect2D* pDiscardRectangles;
    }
    // Struct: 316
    /// <summary>VkPipelineDynamicStateCreateInfo - Structure specifying parameters of a newly created pipeline dynamic state
    /// </summary>
    public unsafe struct VkPipelineDynamicStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineDynamicStateCreateFlags flags;
        /// <summary> dynamicStateCount is the number of elements in the
        /// pDynamicStates array.</summary>
        public UInt32 dynamicStateCount;
        /// <summary> pDynamicStates is an array of VkDynamicState values
        /// specifying which pieces of pipeline state will use the values from
        /// dynamic state commands rather than from pipeline state creation info.</summary>
        public /*-const-*/ VkDynamicState* pDynamicStates;
    }
    // Struct: 317
    /// <summary>VkPipelineInputAssemblyStateCreateInfo - Structure specifying parameters of a newly created pipeline input assembly state
    /// </summary>
    public unsafe struct VkPipelineInputAssemblyStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineInputAssemblyStateCreateFlags flags;
        /// <summary> topology is a VkPrimitiveTopology defining the primitive
        /// topology, as described below.</summary>
        public VkPrimitiveTopology topology;
        /// <summary> primitiveRestartEnable controls whether a special vertex index
        /// value is treated as restarting the assembly of primitives.
        /// This enable only applies to indexed draws (vkCmdDrawIndexed and
        /// vkCmdDrawIndexedIndirect), and the special index value is either
        /// 0xFFFFFFFF when the indexType parameter of
        /// vkCmdBindIndexBuffer is equal to VK_INDEX_TYPE_UINT32, or
        /// 0xFFFF when indexType is equal to VK_INDEX_TYPE_UINT16.
        /// Primitive restart is not allowed for “list” topologies.</summary>
        public VkBool32 primitiveRestartEnable;
    }
    // Struct: 318
    /// <summary>VkPipelineLayoutCreateInfo - Structure specifying the parameters of a newly created pipeline layout object
    /// </summary>
    public unsafe struct VkPipelineLayoutCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineLayoutCreateFlags flags;
        /// <summary> setLayoutCount is the number of descriptor sets included in the
        /// pipeline layout.</summary>
        public UInt32 setLayoutCount;
        /// <summary> pSetLayouts is a pointer to an array of
        /// VkDescriptorSetLayout objects.</summary>
        public /*-const-*/ VkDescriptorSetLayout* pSetLayouts;
        /// <summary> pushConstantRangeCount is the number of push constant ranges
        /// included in the pipeline layout.</summary>
        public UInt32 pushConstantRangeCount;
        /// <summary> pPushConstantRanges is a pointer to an array of
        /// VkPushConstantRange structures defining a set of push constant
        /// ranges for use in a single pipeline layout.
        /// In addition to descriptor set layouts, a pipeline layout also describes
        /// how many push constants can be accessed by each stage of the pipeline.</summary>
        public /*-const-*/ VkPushConstantRange* pPushConstantRanges;
    }
    // Struct: 319
    /// <summary>VkPipelineMultisampleStateCreateInfo - Structure specifying parameters of a newly created pipeline multisample state
    /// </summary>
    public unsafe struct VkPipelineMultisampleStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineMultisampleStateCreateFlags flags;
        /// <summary> rasterizationSamples is a VkSampleCountFlagBits specifying
        /// the number of samples used in rasterization.</summary>
        public VkSampleCountFlagBits rasterizationSamples;
        /// <summary> sampleShadingEnable
        ///   can be used to enable
        /// Sample Shading.</summary>
        public VkBool32 sampleShadingEnable;
        /// <summary> minSampleShading specifies a minimum fraction of sample shading if
        /// sampleShadingEnable is set to VK_TRUE.</summary>
        public float minSampleShading;
        /// <summary> pSampleMask is a bitmask of static coverage information that is
        /// ANDed with the coverage information generated during rasterization, as
        /// described in Sample Mask.</summary>
        public /*-const-*/ VkSampleMask* pSampleMask;
        /// <summary> alphaToCoverageEnable controls whether a temporary coverage value
        /// is generated based on the alpha component of the fragment’s first color
        /// output as specified in the Multisample Coverage
        /// section.</summary>
        public VkBool32 alphaToCoverageEnable;
        /// <summary> alphaToOneEnable controls whether the alpha component of the
        /// fragment’s first color output is replaced with one as described in
        /// Multisample Coverage.</summary>
        public VkBool32 alphaToOneEnable;
    }
    // Struct: 320
    /// <summary>VkPipelineRasterizationConservativeStateCreateInfoEXT - Structure specifying conservative raster state
    /// </summary>
    public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
        /// <summary> conservativeRasterizationMode is the conservative rasterization
        /// mode to use.</summary>
        public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
        /// <summary> extraPrimitiveOverestimationSize is the extra size in pixels to
        /// increase the generating primitive during conservative rasterization at
        /// each of its edges in X and Y equally in screen space beyond the base
        /// overestimation specified in
        /// VkPhysicalDeviceConservativeRasterizationPropertiesEXT::primitiveOverestimationSize.</summary>
        public float extraPrimitiveOverestimationSize;
    }
    // Struct: 321
    /// <summary>VkPipelineRasterizationDepthClipStateCreateInfoEXT - Structure specifying depth clipping state
    /// </summary>
    public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        /// <summary> depthClipEnable controls whether depth clipping is enabled as
        /// described in Primitive Clipping.</summary>
        public VkBool32 depthClipEnable;
    }
    // Struct: 322
    /// <summary>VkPipelineRasterizationStateCreateInfo - Structure specifying parameters of a newly created pipeline rasterization state
    /// </summary>
    public unsafe struct VkPipelineRasterizationStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineRasterizationStateCreateFlags flags;
        /// <summary> depthClampEnable controls whether to clamp the fragment’s depth
        /// values as described in Depth Test.
        /// If the pipeline is not created with
        /// VkPipelineRasterizationDepthClipStateCreateInfoEXT present then
        /// enabling depth clamp will also disable clipping primitives to the z
        /// planes of the frustrum as described in Primitive Clipping.
        /// Otherwise depth clipping is controlled by the state set in
        /// VkPipelineRasterizationDepthClipStateCreateInfoEXT.</summary>
        public VkBool32 depthClampEnable;
        /// <summary> rasterizerDiscardEnable controls whether primitives are discarded
        /// immediately before the rasterization stage.</summary>
        public VkBool32 rasterizerDiscardEnable;
        /// <summary> polygonMode is the triangle rendering mode.
        /// See VkPolygonMode.</summary>
        public VkPolygonMode polygonMode;
        /// <summary> cullMode is the triangle facing direction used for primitive
        /// culling.
        /// See VkCullModeFlagBits.</summary>
        public VkCullModeFlags cullMode;
        /// <summary> frontFace is a VkFrontFace value specifying the front-facing
        /// triangle orientation to be used for culling.</summary>
        public VkFrontFace frontFace;
        /// <summary> depthBiasEnable controls whether to bias fragment depth values.</summary>
        public VkBool32 depthBiasEnable;
        /// <summary> depthBiasConstantFactor is a scalar factor controlling the
        /// constant depth value added to each fragment.</summary>
        public float depthBiasConstantFactor;
        /// <summary> depthBiasClamp is the maximum (or minimum) depth bias of a
        /// fragment.</summary>
        public float depthBiasClamp;
        /// <summary> depthBiasSlopeFactor is a scalar factor applied to a fragment’s
        /// slope in depth bias calculations.</summary>
        public float depthBiasSlopeFactor;
        /// <summary> lineWidth is the width of rasterized line segments.</summary>
        public float lineWidth;
    }
    // Struct: 323
    /// <summary>VkPipelineRasterizationStateRasterizationOrderAMD - Structure defining rasterization order for a graphics pipeline
    /// </summary>
    public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> rasterizationOrder is a VkRasterizationOrderAMD value
        /// specifying the primitive rasterization order to use.</summary>
        public VkRasterizationOrderAMD rasterizationOrder;
    }
    // Struct: 324
    /// <summary>VkPipelineRasterizationStateStreamCreateInfoEXT - Structure defining the geometry stream used for rasterization
    /// </summary>
    public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        /// <summary> rasterizationStream is the vertex stream selected for
        /// rasterization.</summary>
        public UInt32 rasterizationStream;
    }
    // Struct: 325
    /// <summary>VkPipelineRepresentativeFragmentTestStateCreateInfoNV - Structure specifying representative fragment test
    /// </summary>
    public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> representativeFragmentTestEnable controls whether the
        /// representative fragment test is enabled.</summary>
        public VkBool32 representativeFragmentTestEnable;
    }
    // Struct: 326
    /// <summary>VkPipelineSampleLocationsStateCreateInfoEXT - Structure specifying sample locations for a pipeline
    /// </summary>
    public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> sampleLocationsEnable controls whether custom sample locations are
        /// used.
        /// If sampleLocationsEnable is VK_FALSE, the default sample
        /// locations are used and the values specified in sampleLocationsInfo
        /// are ignored.</summary>
        public VkBool32 sampleLocationsEnable;
        /// <summary> sampleLocationsInfo is the sample locations to use during
        /// rasterization if sampleLocationsEnable is VK_TRUE and the
        /// graphics pipeline is not created with
        /// VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT.</summary>
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }
    // Struct: 327
    /// <summary>VkPipelineShaderStageCreateInfo - Structure specifying parameters of a newly created pipeline shader stage
    /// </summary>
    public unsafe struct VkPipelineShaderStageCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineShaderStageCreateFlags flags;
        /// <summary> stage is a VkShaderStageFlagBits value specifying a single
        /// pipeline stage.</summary>
        public VkShaderStageFlagBits stage;
        /// <summary> module is a VkShaderModule object that contains the shader
        /// for this stage.</summary>
        public VkShaderModule module;
        /// <summary> pName is a pointer to a null-terminated UTF-8 string specifying
        /// the entry point name of the shader for this stage.</summary>
        public IntPtr pName;
        /// <summary> pSpecializationInfo is a pointer to VkSpecializationInfo, as
        /// described in Specialization
        /// Constants, and can be NULL.</summary>
        public /*-const-*/ VkSpecializationInfo* pSpecializationInfo;
    }
    // Struct: 328
    /// <summary>VkPipelineTessellationDomainOriginStateCreateInfo - Structure specifying the orientation of the tessellation domain
    /// </summary>
    public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> domainOrigin controls the origin of the tessellation domain space,
        /// and is of type VkTessellationDomainOrigin.</summary>
        public VkTessellationDomainOrigin domainOrigin;
    }
    // Struct: 329
    /// <summary>VkPipelineTessellationStateCreateInfo - Structure specifying parameters of a newly created pipeline tessellation state
    /// </summary>
    public unsafe struct VkPipelineTessellationStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineTessellationStateCreateFlags flags;
        /// <summary> patchControlPoints number of control points per patch.</summary>
        public UInt32 patchControlPoints;
    }
    // Struct: 330
    /// <summary>VkPipelineVertexInputDivisorStateCreateInfoEXT - Structure specifying vertex attributes assignment during instanced rendering
    /// </summary>
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT {
        /// <summary> sType is the type of this structure</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure</summary>
        public /*-const-*/ void* pNext;
        /// <summary> vertexBindingDivisorCount is the number of elements in the
        /// pVertexBindingDivisors array.</summary>
        public UInt32 vertexBindingDivisorCount;
        /// <summary> pVertexBindingDivisors is a pointer to an array of
        /// VkVertexInputBindingDivisorDescriptionEXT structures, which
        /// specifies the divisor value for each binding.</summary>
        public /*-const-*/ VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
    }
    // Struct: 331
    /// <summary>VkPipelineVertexInputStateCreateInfo - Structure specifying parameters of a newly created pipeline vertex input state
    /// </summary>
    public unsafe struct VkPipelineVertexInputStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineVertexInputStateCreateFlags flags;
        /// <summary> vertexBindingDescriptionCount is the number of vertex binding
        /// descriptions provided in pVertexBindingDescriptions.</summary>
        public UInt32 vertexBindingDescriptionCount;
        /// <summary> pVertexBindingDescriptions is a pointer to an array of
        /// VkVertexInputBindingDescription structures.</summary>
        public /*-const-*/ VkVertexInputBindingDescription* pVertexBindingDescriptions;
        /// <summary> vertexAttributeDescriptionCount is the number of vertex attribute
        /// descriptions provided in pVertexAttributeDescriptions.</summary>
        public UInt32 vertexAttributeDescriptionCount;
        /// <summary> pVertexAttributeDescriptions is a pointer to an array of
        /// VkVertexInputAttributeDescription structures.</summary>
        public /*-const-*/ VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
    }
    // Struct: 332
    /// <summary>VkPipelineViewportCoarseSampleOrderStateCreateInfoNV - Structure specifying parameters controlling sample order in coarse fragments
    /// </summary>
    public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> sampleOrderType specifies the mechanism used to order coverage
        /// samples in fragments larger than one pixel.</summary>
        public VkCoarseSampleOrderTypeNV sampleOrderType;
        /// <summary> customSampleOrderCount specifies the number of custom sample
        /// orderings to use when ordering coverage samples.</summary>
        public UInt32 customSampleOrderCount;
        /// <summary> pCustomSampleOrders is a pointer to an array of
        /// VkCoarseSampleOrderCustomNV structures, each of which specifies
        /// the coverage sample order for a single combination of fragment area and
        /// coverage sample count.</summary>
        public /*-const-*/ VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
    }
    // Struct: 333
    /// <summary>VkPipelineViewportExclusiveScissorStateCreateInfoNV - Structure specifying parameters controlling exclusive scissor testing
    /// </summary>
    public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> exclusiveScissorCount is the number of exclusive scissor
        /// rectangles used by the pipeline.</summary>
        public UInt32 exclusiveScissorCount;
        /// <summary> pExclusiveScissors is a pointer to an array of VkRect2D
        /// structures defining exclusive scissor rectangles.
        /// If the exclusive scissor state is dynamic, this member is ignored.</summary>
        public /*-const-*/ VkRect2D* pExclusiveScissors;
    }
    // Struct: 334
    /// <summary>VkPipelineViewportShadingRateImageStateCreateInfoNV - Structure specifying parameters controlling shading rate image usage
    /// </summary>
    public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> shadingRateImageEnable specifies whether shading rate image and
        /// palettes are used during rasterization.</summary>
        public VkBool32 shadingRateImageEnable;
        /// <summary> viewportCount specifies the number of per-viewport palettes used
        /// to translate values stored in shading rate images.</summary>
        public UInt32 viewportCount;
        /// <summary> pShadingRatePalettes is a pointer to an array of
        /// VkShadingRatePaletteNV structures defining the palette for each
        /// viewport.
        /// If the shading rate palette state is dynamic, this member is ignored.</summary>
        public /*-const-*/ VkShadingRatePaletteNV* pShadingRatePalettes;
    }
    // Struct: 335
    /// <summary>VkPipelineViewportStateCreateInfo - Structure specifying parameters of a newly created pipeline viewport state
    /// </summary>
    public unsafe struct VkPipelineViewportStateCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineViewportStateCreateFlags flags;
        /// <summary> viewportCount is the number of viewports used by the pipeline.</summary>
        public UInt32 viewportCount;
        /// <summary> pViewports is a pointer to an array of VkViewport
        /// structures, defining the viewport transforms.
        /// If the viewport state is dynamic, this member is ignored.</summary>
        public /*-const-*/ VkViewport* pViewports;
        /// <summary> scissorCount is the number of scissors and
        /// must match the number of viewports.</summary>
        public UInt32 scissorCount;
        /// <summary> pScissors is a pointer to an array of VkRect2D structures
        /// which define the rectangular bounds of the scissor for the corresponding
        /// viewport.
        /// If the scissor state is dynamic, this member is ignored.</summary>
        public /*-const-*/ VkRect2D* pScissors;
    }
    // Struct: 336
    /// <summary>VkPipelineViewportSwizzleStateCreateInfoNV - Structure specifying swizzle applied to primitive clip coordinates
    /// </summary>
    public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
        /// <summary> viewportCount is the number of viewport swizzles used by the
        /// pipeline.</summary>
        public UInt32 viewportCount;
        /// <summary> pViewportSwizzles is a pointer to an array of
        /// VkViewportSwizzleNV structures, defining the viewport swizzles.</summary>
        public /*-const-*/ VkViewportSwizzleNV* pViewportSwizzles;
    }
    // Struct: 337
    /// <summary>VkPipelineViewportWScalingStateCreateInfoNV - Structure specifying parameters of a newly created pipeline viewport W scaling state
    /// </summary>
    public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> viewportWScalingEnable controls whether viewport W scaling is
        /// enabled.</summary>
        public VkBool32 viewportWScalingEnable;
        /// <summary> viewportCount is the number of viewports used by W scaling, and
        /// must match the number of viewports in the pipeline if viewport W
        /// scaling is enabled.</summary>
        public UInt32 viewportCount;
        /// <summary> pViewportWScalings is a pointer to an array of
        /// VkViewportWScalingNV structures, which define the W scaling
        /// parameters for the corresponding viewport.
        /// If the viewport W scaling state is dynamic, this member is ignored.</summary>
        public /*-const-*/ VkViewportWScalingNV* pViewportWScalings;
    }
    // Struct: 338
    /// <summary>VkPresentFrameTokenGGP - The Google Games Platform frame token
    /// </summary>
    public unsafe struct VkPresentFrameTokenGGP {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> frameToken is the Google Games Platform frame token.</summary>
        public GgpFrameToken frameToken;
    }
    // Struct: 339
    /// <summary>VkPresentInfoKHR - Structure describing parameters of a queue presentation
    /// </summary>
    public unsafe struct VkPresentInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> waitSemaphoreCount is the number of semaphores to wait for before
        /// issuing the present request.
        /// The number may be zero.</summary>
        public UInt32 waitSemaphoreCount;
        /// <summary> pWaitSemaphores, if not NULL, is an array of VkSemaphore
        /// objects with waitSemaphoreCount entries, and specifies the
        /// semaphores to wait for before issuing the present request.</summary>
        public /*-const-*/ VkSemaphore* pWaitSemaphores;
        /// <summary> swapchainCount is the number of swapchains being presented to by
        /// this command.</summary>
        public UInt32 swapchainCount;
        /// <summary> pSwapchains is an array of VkSwapchainKHR objects with
        /// swapchainCount entries.
        /// A given swapchain must not appear in this list more than once.</summary>
        public /*-const-*/ VkSwapchainKHR* pSwapchains;
        /// <summary> pImageIndices is an array of indices into the array of each
        /// swapchain’s presentable images, with swapchainCount entries.
        /// Each entry in this array identifies the image to present on the
        /// corresponding entry in the pSwapchains array.</summary>
        public /*-const-*/ UInt32* pImageIndices;
        /// <summary> pResults is an array of VkResult typed elements with
        /// swapchainCount entries.
        /// Applications that do not need per-swapchain results can use NULL for
        /// pResults.
        /// If non-NULL, each entry in pResults will be set to the
        /// VkResult for presenting the swapchain corresponding to the same
        /// index in pSwapchains.</summary>
        public VkResult* pResults;
    }
    // Struct: 340
    /// <summary>VkPresentRegionKHR - Structure containing rectangular region changed by vkQueuePresentKHR for a given VkImage
    /// </summary>
    public unsafe struct VkPresentRegionKHR {
        /// <summary> rectangleCount is the number of rectangles in pRectangles,
        /// or zero if the entire image has changed and should be presented.</summary>
        public UInt32 rectangleCount;
        /// <summary> pRectangles is either NULL or a pointer to an array of
        /// VkRectLayerKHR structures.
        /// The VkRectLayerKHR structure is the framebuffer coordinates, plus
        /// layer, of a portion of a presentable image that has changed and must be
        /// presented.
        /// If non-NULL, each entry in pRectangles is a rectangle of the
        /// given image that has changed since the last image was presented to the
        /// given swapchain.</summary>
        public /*-const-*/ VkRectLayerKHR* pRectangles;
    }
    // Struct: 341
    /// <summary>VkPresentRegionsKHR - Structure hint of rectangular regions changed by vkQueuePresentKHR
    /// </summary>
    public unsafe struct VkPresentRegionsKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> swapchainCount is the number of swapchains being presented to by
        /// this command.</summary>
        public UInt32 swapchainCount;
        /// <summary> pRegions is NULL or a pointer to an array of
        /// VkPresentRegionKHR elements with swapchainCount entries.
        /// If not NULL, each element of pRegions contains the region that
        /// has changed since the last present to the swapchain in the corresponding
        /// entry in the VkPresentInfoKHR::pSwapchains array.</summary>
        public /*-const-*/ VkPresentRegionKHR* pRegions;
    }
    // Struct: 342
    /// <summary>VkPresentTimeGOOGLE - The earliest time image should be presented
    /// </summary>
    public unsafe struct VkPresentTimeGOOGLE {
        /// <summary> presentID is an application-provided identification value, that
        /// can be used with the results of
        /// vkGetPastPresentationTimingGOOGLE, in order to uniquely identify
        /// this present.
        /// In order to be useful to the application, it should be unique within
        /// some period of time that is meaningful to the application.</summary>
        public UInt32 presentID;
        /// <summary> desiredPresentTime specifies that the image given should not be
        /// displayed to the user any earlier than this time.
        /// desiredPresentTime is a time in nanoseconds, relative to a
        /// monotonically-increasing clock (e.g. CLOCK_MONOTONIC (see
        /// clock_gettime(2)) on Android and Linux).
        /// A value of zero specifies that the presentation engine may display the
        /// image at any time.
        /// This is useful when the application desires to provide presentID,
        /// but does not need a specific desiredPresentTime.</summary>
        public UInt64 desiredPresentTime;
    }
    // Struct: 343
    /// <summary>VkPresentTimesInfoGOOGLE - The earliest time each image should be presented
    /// </summary>
    public unsafe struct VkPresentTimesInfoGOOGLE {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> swapchainCount is the number of swapchains being presented to by
        /// this command.</summary>
        public UInt32 swapchainCount;
        /// <summary> pTimes is NULL or a pointer to an array of
        /// VkPresentTimeGOOGLE elements with swapchainCount entries.
        /// If not NULL, each element of pTimes contains the earliest time
        /// to present the image corresponding to the entry in the
        /// VkPresentInfoKHR::pImageIndices array.</summary>
        public /*-const-*/ VkPresentTimeGOOGLE* pTimes;
    }
    // Struct: 344
    /// <summary>VkProtectedSubmitInfo - Structure indicating whether the submission is protected
    /// </summary>
    public unsafe struct VkProtectedSubmitInfo {
        public VkStructureType sType;
        public /*-const-*/ void* pNext;
        /// <summary> protectedSubmit specifies whether the batch is protected.
        /// If protectedSubmit is VK_TRUE, the batch is protected.
        /// If protectedSubmit is VK_FALSE, the batch is unprotected.
        /// If the VkSubmitInfo::pNext chain does not contain this
        /// structure, the batch is unprotected.</summary>
        public VkBool32 protectedSubmit;
    }
    // Struct: 345
    /// <summary>VkPushConstantRange - Structure specifying a push constant range
    /// </summary>
    public unsafe struct VkPushConstantRange {
        /// <summary> stageFlags is a set of stage flags describing the shader stages
        /// that will access a range of push constants.
        /// If a particular stage is not included in the range, then accessing
        /// members of that range of push constants from the corresponding shader
        /// stage will return undefined values.</summary>
        public VkShaderStageFlags stageFlags;
        /// <summary> offset and size are the start offset and size, respectively,
        /// consumed by the range.
        /// Both offset and size are in units of bytes and must be a
        /// multiple of 4.
        /// The layout of the push constant variables is specified in the shader.</summary>
        public UInt32 offset;
        public UInt32 size;
    }
    // Struct: 346
    /// <summary>VkQueryPoolCreateInfo - Structure specifying parameters of a newly created query pool
    /// </summary>
    public unsafe struct VkQueryPoolCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkQueryPoolCreateFlags flags;
        /// <summary> queryType is a VkQueryType value specifying the type of
        /// queries managed by the pool.</summary>
        public VkQueryType queryType;
        /// <summary> queryCount is the number of queries managed by the pool.</summary>
        public UInt32 queryCount;
        /// <summary> pipelineStatistics is a bitmask of
        /// VkQueryPipelineStatisticFlagBits specifying which counters will be
        /// returned in queries on the new pool, as described below in
        /// html/vkspec.html#queries-pipestats.</summary>
        public VkQueryPipelineStatisticFlags pipelineStatistics;
    }
    // Struct: 347
    /// <summary>VkQueueFamilyCheckpointPropertiesNV - return structure for queue family checkpoint info query
    /// </summary>
    public unsafe struct VkQueueFamilyCheckpointPropertiesNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> checkpointExecutionStageMask is a mask indicating which pipeline
        /// stages the implementation can execute checkpoint markers in.</summary>
        public VkPipelineStageFlags checkpointExecutionStageMask;
    }
    // Struct: 348
    /// <summary>VkQueueFamilyProperties - Structure providing information about a queue family
    /// </summary>
    public unsafe struct VkQueueFamilyProperties {
        /// <summary> queueFlags is a bitmask of VkQueueFlagBits indicating
        /// capabilities of the queues in this queue family.</summary>
        public VkQueueFlags queueFlags;
        /// <summary> queueCount is the unsigned integer count of queues in this queue
        /// family.
        /// Each queue family must support at least one queue.</summary>
        public UInt32 queueCount;
        /// <summary> timestampValidBits is the unsigned integer count of meaningful
        /// bits in the timestamps written via vkCmdWriteTimestamp.
        /// The valid range for the count is 36..64 bits, or a value of 0,
        /// indicating no support for timestamps.
        /// Bits outside the valid range are guaranteed to be zeros.</summary>
        public UInt32 timestampValidBits;
        /// <summary> minImageTransferGranularity is the minimum granularity supported
        /// for image transfer operations on the queues in this queue family.</summary>
        public VkExtent3D minImageTransferGranularity;
    }
    // Struct: 349
    /// <summary>VkQueueFamilyProperties2 - Structure providing information about a queue family
    /// </summary>
    public unsafe struct VkQueueFamilyProperties2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> queueFamilyProperties is a structure of type
        /// VkQueueFamilyProperties which is populated with the same values as
        /// in vkGetPhysicalDeviceQueueFamilyProperties.</summary>
        public VkQueueFamilyProperties queueFamilyProperties;
    }
    // Struct: 350
    /// <summary>VkRayTracingPipelineCreateInfoNV - Structure specifying parameters of a newly created ray tracing pipeline
    /// </summary>
    public unsafe struct VkRayTracingPipelineCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkPipelineCreateFlagBits specifying
        /// how the pipeline will be generated.</summary>
        public VkPipelineCreateFlags flags;
        /// <summary> stageCount is the number of entries in the pStages array.</summary>
        public UInt32 stageCount;
        /// <summary> pStages is an array of size stageCount structures of type
        /// VkPipelineShaderStageCreateInfo describing the set of the shader
        /// stages to be included in the ray tracing pipeline.</summary>
        public /*-const-*/ VkPipelineShaderStageCreateInfo* pStages;
        /// <summary> groupCount is the number of entries in the pGroups array.</summary>
        public UInt32 groupCount;
        /// <summary> pGroups is an array of size groupCount structures of type
        /// VkRayTracingShaderGroupCreateInfoNV describing the set of the
        /// shader stages to be included in each shader group in the ray tracing
        /// pipeline.</summary>
        public /*-const-*/ VkRayTracingShaderGroupCreateInfoNV* pGroups;
        /// <summary> maxRecursionDepth is the maximum recursion that will be called
        /// from this pipeline.</summary>
        public UInt32 maxRecursionDepth;
        /// <summary> layout is the description of binding locations used by both the
        /// pipeline and descriptor sets used with the pipeline.</summary>
        public VkPipelineLayout layout;
        /// <summary> basePipelineHandle is a pipeline to derive from.</summary>
        public VkPipeline basePipelineHandle;
        /// <summary> basePipelineIndex is an index into the pCreateInfos
        /// parameter to use as a pipeline to derive from.</summary>
        public Int32 basePipelineIndex;
    }
    // Struct: 351
    /// <summary>VkRayTracingShaderGroupCreateInfoNV - Structure specifying shaders in a shader group
    /// </summary>
    public unsafe struct VkRayTracingShaderGroupCreateInfoNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> type is the type of hit group specified in this structure.</summary>
        public VkRayTracingShaderGroupTypeNV type;
        /// <summary> generalShader is the index of the ray generation, miss, or
        /// callable shader from
        /// VkRayTracingPipelineCreateInfoNV::pStages in the group if
        /// the shader group has type of
        /// VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV and
        /// VK_SHADER_UNUSED_NV otherwise.</summary>
        public UInt32 generalShader;
        /// <summary> closestHitShader is the optional index of the closest hit shader
        /// from VkRayTracingPipelineCreateInfoNV::pStages in the group
        /// if the shader group has type of
        /// VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV or
        /// VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV and
        /// VK_SHADER_UNUSED_NV otherwise.</summary>
        public UInt32 closestHitShader;
        /// <summary> anyHitShader is the optional index of the any-hit shader from
        /// VkRayTracingPipelineCreateInfoNV::pStages in the group if
        /// the shader group has type of
        /// VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV or
        /// VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV and
        /// VK_SHADER_UNUSED_NV otherwise.</summary>
        public UInt32 anyHitShader;
        /// <summary> intersectionShader is the index of the intersection shader from
        /// VkRayTracingPipelineCreateInfoNV::pStages in the group if
        /// the shader group has type of
        /// VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV and
        /// VK_SHADER_UNUSED_NV otherwise.</summary>
        public UInt32 intersectionShader;
    }
    // Struct: 352
    /// <summary>VkRect2D - Structure specifying a two-dimensional subregion
    /// </summary>
    public unsafe struct VkRect2D {
        /// <summary> offset is a VkOffset2D specifying the rectangle offset.</summary>
        public VkOffset2D offset;
        /// <summary> extent is a VkExtent2D specifying the rectangle extent.</summary>
        public VkExtent2D extent;
    }
    // Struct: 353
    /// <summary>VkRectLayerKHR - Structure containing a rectangle, including layer, changed by vkQueuePresentKHR for a given VkImage
    /// </summary>
    public unsafe struct VkRectLayerKHR {
        /// <summary> offset is the origin of the rectangle, in pixels.</summary>
        public VkOffset2D offset;
        /// <summary> extent is the size of the rectangle, in pixels.</summary>
        public VkExtent2D extent;
        /// <summary> layer is the layer of the image.
        /// For images with only one layer, the value of layer must be 0.</summary>
        public UInt32 layer;
    }
    // Struct: 354
    /// <summary>VkRefreshCycleDurationGOOGLE - Structure containing the RC duration of a display
    /// </summary>
    public unsafe struct VkRefreshCycleDurationGOOGLE {
        /// <summary> refreshDuration is the number of nanoseconds from the start of one
        /// refresh cycle to the next.</summary>
        public UInt64 refreshDuration;
    }
    // Struct: 355
    /// <summary>VkRenderPassBeginInfo - Structure specifying render pass begin info
    /// </summary>
    public unsafe struct VkRenderPassBeginInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> renderPass is the render pass to begin an instance of.</summary>
        public VkRenderPass renderPass;
        /// <summary> framebuffer is the framebuffer containing the attachments that are
        /// used with the render pass.</summary>
        public VkFramebuffer framebuffer;
        /// <summary> renderArea is the render area that is affected by the render pass
        /// instance, and is described in more detail below.</summary>
        public VkRect2D renderArea;
        /// <summary> clearValueCount is the number of elements in pClearValues.</summary>
        public UInt32 clearValueCount;
        /// <summary> pClearValues is an array of VkClearValue structures that
        /// contains clear values for each attachment, if the attachment uses a
        /// loadOp value of VK_ATTACHMENT_LOAD_OP_CLEAR or if the
        /// attachment has a depth/stencil format and uses a stencilLoadOp
        /// value of VK_ATTACHMENT_LOAD_OP_CLEAR.
        /// The array is indexed by attachment number.
        /// Only elements corresponding to cleared attachments are used.
        /// Other elements of pClearValues are ignored.</summary>
        public /*-const-*/ VkClearValue* pClearValues;
    }
    // Struct: 356
    /// <summary>VkRenderPassCreateInfo - Structure specifying parameters of a newly created render pass
    /// </summary>
    public unsafe struct VkRenderPassCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkRenderPassCreateFlags flags;
        /// <summary> attachmentCount is the number of attachments used by this render
        /// pass.</summary>
        public UInt32 attachmentCount;
        /// <summary> pAttachments points to an array of attachmentCount VkAttachmentDescription structures describing the attachments used
        /// by the render pass.</summary>
        public /*-const-*/ VkAttachmentDescription* pAttachments;
        /// <summary> subpassCount is the number of subpasses to create.</summary>
        public UInt32 subpassCount;
        /// <summary> pSubpasses points to an array of subpassCount VkSubpassDescription structures describing each subpass.</summary>
        public /*-const-*/ VkSubpassDescription* pSubpasses;
        /// <summary> dependencyCount is the number of memory dependencies between pairs
        /// of subpasses.</summary>
        public UInt32 dependencyCount;
        /// <summary> pDependencies points to an array of dependencyCount VkSubpassDependency structures describing dependencies between
        /// pairs of subpasses.</summary>
        public /*-const-*/ VkSubpassDependency* pDependencies;
    }
    // Struct: 357
    /// <summary>VkRenderPassCreateInfo2KHR - Structure specifying parameters of a newly created render pass
    /// </summary>
    public unsafe struct VkRenderPassCreateInfo2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkRenderPassCreateFlags flags;
        /// <summary> attachmentCount is the number of attachments used by this render
        /// pass.</summary>
        public UInt32 attachmentCount;
        /// <summary> pAttachments points to an array of attachmentCount VkAttachmentDescription2KHR structures describing the attachments
        /// used by the render pass.</summary>
        public /*-const-*/ VkAttachmentDescription2KHR* pAttachments;
        /// <summary> subpassCount is the number of subpasses to create.</summary>
        public UInt32 subpassCount;
        /// <summary> pSubpasses points to an array of subpassCount VkSubpassDescription2KHR structures describing each subpass.</summary>
        public /*-const-*/ VkSubpassDescription2KHR* pSubpasses;
        /// <summary> dependencyCount is the number of dependencies between pairs of
        /// subpasses.</summary>
        public UInt32 dependencyCount;
        /// <summary> pDependencies points to an array of dependencyCount VkSubpassDependency2KHR structures describing dependencies between
        /// pairs of subpasses.</summary>
        public /*-const-*/ VkSubpassDependency2KHR* pDependencies;
        /// <summary> correlatedViewMaskCount is the number of correlation masks.</summary>
        public UInt32 correlatedViewMaskCount;
        /// <summary> pCorrelatedViewMasks is an array of view masks indicating sets of
        /// views that may be more efficient to render concurrently.</summary>
        public /*-const-*/ UInt32* pCorrelatedViewMasks;
    }
    // Struct: 358
    /// <summary>VkRenderPassFragmentDensityMapCreateInfoEXT - Structure containing fragment density map attachment for render pass
    /// </summary>
    public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> fragmentDensityMapAttachment is the fragment density map to use
        /// for the render pass.</summary>
        public VkAttachmentReference fragmentDensityMapAttachment;
    }
    // Struct: 359
    /// <summary>VkRenderPassInputAttachmentAspectCreateInfo - Structure specifying, for a given subpass/input attachment pair, which aspect <strong class="purple">can</strong> be read.
    /// </summary>
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> aspectReferenceCount is the number of elements in the
        /// pAspectReferences array.</summary>
        public UInt32 aspectReferenceCount;
        /// <summary> pAspectReferences points to an array of aspectReferenceCount
        /// number of VkInputAttachmentAspectReference structures describing
        /// which aspect(s) can be accessed for a given input attachment within a
        /// given subpass.</summary>
        public /*-const-*/ VkInputAttachmentAspectReference* pAspectReferences;
    }
    // Struct: 360
    /// <summary>VkRenderPassMultiviewCreateInfo - Structure containing multiview info for all subpasses
    /// </summary>
    public unsafe struct VkRenderPassMultiviewCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> subpassCount is zero or is the number of subpasses in the render
        /// pass.</summary>
        public UInt32 subpassCount;
        /// <summary> pViewMasks points to an array of subpassCount number of view
        /// masks, where each mask is a bitfield of view indices describing which
        /// views rendering is broadcast to in each subpass, when multiview is
        /// enabled.
        /// If subpassCount is zero, each view mask is treated as zero.</summary>
        public /*-const-*/ UInt32* pViewMasks;
        /// <summary> dependencyCount is zero or the number of dependencies in the
        /// render pass.</summary>
        public UInt32 dependencyCount;
        /// <summary> pViewOffsets points to an array of dependencyCount view
        /// offsets, one for each dependency.
        /// If dependencyCount is zero, each dependency’s view offset is
        /// treated as zero.
        /// Each view offset controls which views in the source subpass the views in
        /// the destination subpass depend on.</summary>
        public /*-const-*/ Int32* pViewOffsets;
        /// <summary> correlationMaskCount is zero or a number of correlation masks.</summary>
        public UInt32 correlationMaskCount;
        /// <summary> pCorrelationMasks is an array of view masks indicating sets of
        /// views that may be more efficient to render concurrently.</summary>
        public /*-const-*/ UInt32* pCorrelationMasks;
    }
    // Struct: 361
    /// <summary>VkRenderPassSampleLocationsBeginInfoEXT - Structure specifying sample locations to use for the layout transition of custom sample locations compatible depth/stencil attachments
    /// </summary>
    public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> attachmentInitialSampleLocationsCount is the number of elements in
        /// the pAttachmentInitialSampleLocations array.</summary>
        public UInt32 attachmentInitialSampleLocationsCount;
        /// <summary> pAttachmentInitialSampleLocations is an array of
        /// attachmentInitialSampleLocationsCount VkAttachmentSampleLocationsEXT structures specifying the
        /// attachment indices and their corresponding sample location state.
        /// Each element of pAttachmentInitialSampleLocations can specify the
        /// sample location state to use in the automatic layout transition
        /// performed to transition a depth/stencil attachment from the initial
        /// layout of the attachment to the image layout specified for the
        /// attachment in the first subpass using it.</summary>
        public /*-const-*/ VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        /// <summary> postSubpassSampleLocationsCount is the number of elements in the
        /// pPostSubpassSampleLocations array.</summary>
        public UInt32 postSubpassSampleLocationsCount;
        /// <summary> pPostSubpassSampleLocations is an array of
        /// postSubpassSampleLocationsCount VkSubpassSampleLocationsEXT
        /// structures specifying the subpass indices and their corresponding sample
        /// location state.
        /// Each element of pPostSubpassSampleLocations can specify the
        /// sample location state to use in the automatic layout transition
        /// performed to transition the depth/stencil attachment used by the
        /// specified subpass to the image layout specified in a dependent subpass
        /// or to the final layout of the attachment in case the specified subpass
        /// is the last subpass using that attachment.
        /// In addition, if
        /// VkPhysicalDeviceSampleLocationsPropertiesEXT::variableSampleLocations
        /// is VK_FALSE, each element of pPostSubpassSampleLocations must specify the sample location state that matches the sample
        /// locations used by all pipelines that will be bound to a command buffer
        /// during the specified subpass.
        /// If variableSampleLocations is VK_TRUE, the sample locations
        /// used for rasterization do not depend on
        /// pPostSubpassSampleLocations.</summary>
        public /*-const-*/ VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
    }
    // Struct: 362
    /// <summary>VkSampleLocationEXT - Structure specifying the coordinates of a sample location
    /// </summary>
    public unsafe struct VkSampleLocationEXT {
        /// <summary> x is the horizontal coordinate of the sample’s location.</summary>
        public float x;
        /// <summary> y is the vertical coordinate of the sample’s location.</summary>
        public float y;
    }
    // Struct: 363
    /// <summary>VkSampleLocationsInfoEXT - Structure specifying a set of sample locations
    /// </summary>
    public unsafe struct VkSampleLocationsInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> sampleLocationsPerPixel is a VkSampleCountFlagBits
        /// specifying the number of sample locations per pixel.</summary>
        public VkSampleCountFlagBits sampleLocationsPerPixel;
        /// <summary> sampleLocationGridSize is the size of the sample location grid to
        /// select custom sample locations for.</summary>
        public VkExtent2D sampleLocationGridSize;
        /// <summary> sampleLocationsCount is the number of sample locations in
        /// pSampleLocations.</summary>
        public UInt32 sampleLocationsCount;
        /// <summary> pSampleLocations is an array of sampleLocationsCount VkSampleLocationEXT structures.</summary>
        public /*-const-*/ VkSampleLocationEXT* pSampleLocations;
    }
    // Struct: 364
    /// <summary>VkSamplerCreateInfo - Structure specifying parameters of a newly created sampler
    /// </summary>
    public unsafe struct VkSamplerCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkSamplerCreateFlagBits describing
        /// additional parameters of the sampler.</summary>
        public VkSamplerCreateFlags flags;
        /// <summary> magFilter is a VkFilter value specifying the magnification
        /// filter to apply to lookups.</summary>
        public VkFilter magFilter;
        /// <summary> minFilter is a VkFilter value specifying the minification
        /// filter to apply to lookups.</summary>
        public VkFilter minFilter;
        /// <summary> mipmapMode is a VkSamplerMipmapMode value specifying the
        /// mipmap filter to apply to lookups.</summary>
        public VkSamplerMipmapMode mipmapMode;
        /// <summary> addressModeU is a VkSamplerAddressMode value specifying the
        /// addressing mode for outside [0..1] range for U coordinate.</summary>
        public VkSamplerAddressMode addressModeU;
        /// <summary> addressModeV is a VkSamplerAddressMode value specifying the
        /// addressing mode for outside [0..1] range for V coordinate.</summary>
        public VkSamplerAddressMode addressModeV;
        /// <summary> addressModeW is a VkSamplerAddressMode value specifying the
        /// addressing mode for outside [0..1] range for W coordinate.</summary>
        public VkSamplerAddressMode addressModeW;
        /// <summary>  
        ///   mipLodBias is the bias to be added to
        /// mipmap LOD (level-of-detail) calculation and bias provided by image
        /// sampling functions in SPIR-V, as described in the
        /// Level-of-Detail Operation
        /// section.</summary>
        public float mipLodBias;
        /// <summary>  
        ///   anisotropyEnable is VK_TRUE to
        /// enable anisotropic filtering, as described in the
        /// Texel Anisotropic Filtering
        /// section, or VK_FALSE otherwise.</summary>
        public VkBool32 anisotropyEnable;
        /// <summary> maxAnisotropy is the anisotropy value clamp used by the sampler
        /// when anisotropyEnable is VK_TRUE.
        /// If anisotropyEnable is VK_FALSE, maxAnisotropy is
        /// ignored.</summary>
        public float maxAnisotropy;
        /// <summary> compareEnable is VK_TRUE to enable comparison against a
        /// reference value during lookups, or VK_FALSE otherwise.</summary>
        public VkBool32 compareEnable;
        /// <summary> compareOp is a VkCompareOp value specifying the comparison
        /// function to apply to fetched data before filtering as described in the
        /// Depth Compare Operation section.</summary>
        public VkCompareOp compareOp;
        /// <summary> minLod and maxLod are the values used to clamp the computed
        /// LOD value, as described in the Level-of-Detail Operation section.</summary>
        public float minLod;
        public float maxLod;
        /// <summary> borderColor is a VkBorderColor value specifying the
        /// predefined border color to use.</summary>
        public VkBorderColor borderColor;
        /// <summary>  
        ///   unnormalizedCoordinates
        /// controls whether to use unnormalized or normalized texel coordinates to
        /// address texels of the image.
        /// When set to VK_TRUE, the range of the image coordinates used to
        /// lookup the texel is in the range of zero to the image dimensions for x,
        /// y and z.
        /// When set to VK_FALSE the range of image coordinates is zero to
        /// one.</summary>
        public VkBool32 unnormalizedCoordinates;
    }
    // Struct: 365
    /// <summary>VkSamplerReductionModeCreateInfoEXT - Structure specifying sampler reduction mode
    /// </summary>
    public unsafe struct VkSamplerReductionModeCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> reductionMode is an enum of type VkSamplerReductionModeEXT
        /// that controls how texture filtering combines texel values.</summary>
        public VkSamplerReductionModeEXT reductionMode;
    }
    // Struct: 366
    /// <summary>VkSamplerYcbcrConversionCreateInfo - Structure specifying the parameters of the newly created conversion
    /// </summary>
    public unsafe struct VkSamplerYcbcrConversionCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> format is the format of the image from which color information
        /// will be retrieved.</summary>
        public VkFormat format;
        /// <summary> ycbcrModel describes the color matrix for conversion between color
        /// models.</summary>
        public VkSamplerYcbcrModelConversion ycbcrModel;
        /// <summary> ycbcrRange describes whether the encoded values have headroom and
        /// foot room, or whether the encoding uses the full numerical range.</summary>
        public VkSamplerYcbcrRange ycbcrRange;
        /// <summary> components applies a swizzle based on VkComponentSwizzle
        /// enums prior to range expansion and color model conversion.</summary>
        public VkComponentMapping components;
        /// <summary> xChromaOffset describes the
        /// sample location associated with
        /// downsampled chroma channels in the x dimension.
        /// xChromaOffset has no effect for formats in which chroma channels
        /// are the same resolution as the luma channel.</summary>
        public VkChromaLocation xChromaOffset;
        /// <summary> yChromaOffset describes the
        /// sample location associated with
        /// downsampled chroma channels in the y dimension.
        /// yChromaOffset has no effect for formats in which the chroma
        /// channels are not downsampled vertically.</summary>
        public VkChromaLocation yChromaOffset;
        /// <summary> chromaFilter is the filter for chroma reconstruction.</summary>
        public VkFilter chromaFilter;
        /// <summary> forceExplicitReconstruction
        ///   can be used to ensure that
        /// reconstruction is done explicitly, if supported.</summary>
        public VkBool32 forceExplicitReconstruction;
    }
    // Struct: 367
    /// <summary>VkSamplerYcbcrConversionImageFormatProperties - Structure specifying combined image sampler descriptor count for multi-planar images
    /// </summary>
    public unsafe struct VkSamplerYcbcrConversionImageFormatProperties {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> combinedImageSamplerDescriptorCount is the number of combined
        /// image sampler descriptors that the implementation uses to access the
        /// format.</summary>
        public UInt32 combinedImageSamplerDescriptorCount;
    }
    // Struct: 368
    /// <summary>VkSamplerYcbcrConversionInfo - Structure specifying Y’CbCr conversion to a sampler or image view
    /// </summary>
    public unsafe struct VkSamplerYcbcrConversionInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> conversion is a VkSamplerYcbcrConversion handle created with
        /// vkCreateSamplerYcbcrConversion.</summary>
        public VkSamplerYcbcrConversion conversion;
    }
    // Struct: 369
    /// <summary>VkSemaphoreCreateInfo - Structure specifying parameters of a newly created semaphore
    /// </summary>
    public unsafe struct VkSemaphoreCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkSemaphoreCreateFlags flags;
    }
    // Struct: 370
    /// <summary>VkSemaphoreGetFdInfoKHR - Structure describing a POSIX FD semaphore export operation
    /// </summary>
    public unsafe struct VkSemaphoreGetFdInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> semaphore is the semaphore from which state will be exported.</summary>
        public VkSemaphore semaphore;
        /// <summary> handleType is the type of handle requested.</summary>
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    // Struct: 371
    /// <summary>VkSemaphoreGetWin32HandleInfoKHR - Structure describing a Win32 handle semaphore export operation
    /// </summary>
    public unsafe struct VkSemaphoreGetWin32HandleInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> semaphore is the semaphore from which state will be exported.</summary>
        public VkSemaphore semaphore;
        /// <summary> handleType is the type of handle requested.</summary>
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    // Struct: 372
    /// <summary>VkShaderModuleCreateInfo - Structure specifying parameters of a newly created shader module
    /// </summary>
    public unsafe struct VkShaderModuleCreateInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkShaderModuleCreateFlags flags;
        /// <summary> codeSize is the size, in bytes, of the code pointed to by
        /// pCode.</summary>
        public Int32 codeSize;
        /// <summary> pCode points to code that is used to create the shader module.
        /// The type and format of the code is determined from the content of the
        /// memory addressed by pCode.</summary>
        public /*-const-*/ UInt32* pCode;
    }
    // Struct: 373
    /// <summary>VkShaderModuleValidationCacheCreateInfoEXT - Specify validation cache to use during shader module creation
    /// </summary>
    public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> validationCache is the validation cache object from which the
        /// results of prior validation attempts will be written, and to which new
        /// validation results for this VkShaderModule will be written (if not
        /// already present).</summary>
        public VkValidationCacheEXT validationCache;
    }
    // Struct: 374
    /// <summary>VkShaderResourceUsageAMD - Resource usage information about a particular shader within a pipeline
    /// </summary>
    public unsafe struct VkShaderResourceUsageAMD {
        /// <summary> numUsedVgprs is the number of vector instruction general-purpose
        /// registers used by this shader.</summary>
        public UInt32 numUsedVgprs;
        /// <summary> numUsedSgprs is the number of scalar instruction general-purpose
        /// registers used by this shader.</summary>
        public UInt32 numUsedSgprs;
        /// <summary> ldsSizePerLocalWorkGroup is the maximum local data store size per
        /// work group in bytes.</summary>
        public UInt32 ldsSizePerLocalWorkGroup;
        /// <summary> ldsUsageSizeInBytes is the LDS usage size in bytes per work group
        /// by this shader.</summary>
        public Int32 ldsUsageSizeInBytes;
        /// <summary> scratchMemUsageInBytes is the scratch memory usage in bytes by
        /// this shader.</summary>
        public Int32 scratchMemUsageInBytes;
    }
    // Struct: 375
    /// <summary>VkShaderStatisticsInfoAMD - Statistical information about a particular shader within a pipeline
    /// </summary>
    public unsafe struct VkShaderStatisticsInfoAMD {
        /// <summary> shaderStageMask are the combination of logical shader stages
        /// contained within this shader.</summary>
        public VkShaderStageFlags shaderStageMask;
        /// <summary> resourceUsage is an instance of VkShaderResourceUsageAMD
        /// describing internal physical device resources used by this shader.</summary>
        public VkShaderResourceUsageAMD resourceUsage;
        /// <summary> numPhysicalVgprs is the maximum number of vector instruction
        /// general-purpose registers (VGPRs) available to the physical device.</summary>
        public UInt32 numPhysicalVgprs;
        /// <summary> numPhysicalSgprs is the maximum number of scalar instruction
        /// general-purpose registers (SGPRs) available to the physical device.</summary>
        public UInt32 numPhysicalSgprs;
        /// <summary> numAvailableVgprs is the maximum limit of VGPRs made available to
        /// the shader compiler.</summary>
        public UInt32 numAvailableVgprs;
        /// <summary> numAvailableSgprs is the maximum limit of SGPRs made available to
        /// the shader compiler.</summary>
        public UInt32 numAvailableSgprs;
        public fixed UInt32 computeWorkGroupSize[3];
    }
    // Struct: 376
    /// <summary>VkShadingRatePaletteNV - Structure specifying a single shading rate palette
    /// </summary>
    public unsafe struct VkShadingRatePaletteNV {
        /// <summary> shadingRatePaletteEntryCount specifies the number of entries in
        /// the shading rate image palette.</summary>
        public UInt32 shadingRatePaletteEntryCount;
        /// <summary> pShadingRatePaletteEntries is a pointer to an array of
        /// VkShadingRatePaletteEntryNV enums defining the shading rate for
        /// each palette entry.</summary>
        public /*-const-*/ VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
    }
    // Struct: 377
    /// <summary>VkSharedPresentSurfaceCapabilitiesKHR - structure describing capabilities of a surface for shared presentation
    /// </summary>
    public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> sharedPresentSupportedUsageFlags is a bitmask of
        /// VkImageUsageFlagBits representing the ways the application can
        /// use the shared presentable image from a swapchain created with
        /// VkPresentModeKHR set to
        /// VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR or
        /// VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR for the surface on
        /// the specified device.
        /// VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT must be included in the set
        /// but implementations may support additional usages.</summary>
        public VkImageUsageFlags sharedPresentSupportedUsageFlags;
    }
    // Struct: 378
    /// <summary>VkSparseBufferMemoryBindInfo - Structure specifying a sparse buffer memory bind operation
    /// </summary>
    public unsafe struct VkSparseBufferMemoryBindInfo {
        /// <summary> buffer is the VkBuffer object to be bound.</summary>
        public VkBuffer buffer;
        /// <summary> bindCount is the number of VkSparseMemoryBind structures in
        /// the pBinds array.</summary>
        public UInt32 bindCount;
        /// <summary> pBinds is a pointer to array of VkSparseMemoryBind
        /// structures.</summary>
        public /*-const-*/ VkSparseMemoryBind* pBinds;
    }
    // Struct: 379
    /// <summary>VkSparseImageFormatProperties - Structure specifying sparse image format properties
    /// </summary>
    public unsafe struct VkSparseImageFormatProperties {
        /// <summary> aspectMask is a bitmask VkImageAspectFlagBits specifying
        /// which aspects of the image the properties apply to.</summary>
        public VkImageAspectFlags aspectMask;
        /// <summary> imageGranularity is the width, height, and depth of the sparse
        /// image block in texels or compressed texel blocks.</summary>
        public VkExtent3D imageGranularity;
        /// <summary> flags is a bitmask of VkSparseImageFormatFlagBits specifying
        /// additional information about the sparse resource.</summary>
        public VkSparseImageFormatFlags flags;
    }
    // Struct: 380
    /// <summary>VkSparseImageFormatProperties2 - Structure specifying sparse image format properties
    /// </summary>
    public unsafe struct VkSparseImageFormatProperties2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> properties is a structure of type
        /// VkSparseImageFormatProperties which is populated with the same
        /// values as in vkGetPhysicalDeviceSparseImageFormatProperties.</summary>
        public VkSparseImageFormatProperties properties;
    }
    // Struct: 381
    /// <summary>VkSparseImageMemoryBind - Structure specifying sparse image memory bind
    /// </summary>
    public unsafe struct VkSparseImageMemoryBind {
        /// <summary> subresource is the image aspect and region of interest in the
        /// image.</summary>
        public VkImageSubresource subresource;
        /// <summary> offset are the coordinates of the first texel within the image
        /// subresource to bind.</summary>
        public VkOffset3D offset;
        /// <summary> extent is the size in texels of the region within the image
        /// subresource to bind.
        /// The extent must be a multiple of the sparse image block dimensions,
        /// except when binding sparse image blocks along the edge of an image
        /// subresource it can instead be such that any coordinate of
        ///  offset +  extent  equals the corresponding
        /// dimensions of the image subresource.</summary>
        public VkExtent3D extent;
        /// <summary> memory is the VkDeviceMemory object that the sparse image
        /// blocks of the image are bound to.
        /// If memory is VK_NULL_HANDLE, the sparse image blocks are
        /// unbound.</summary>
        public VkDeviceMemory memory;
        /// <summary> memoryOffset is an offset into VkDeviceMemory object.
        /// If memory is VK_NULL_HANDLE, this value is ignored.</summary>
        public VkDeviceSize memoryOffset;
        /// <summary> flags are sparse memory binding flags.</summary>
        public VkSparseMemoryBindFlags flags;
    }
    // Struct: 382
    /// <summary>VkSparseImageMemoryBindInfo - Structure specifying sparse image memory bind info
    /// </summary>
    public unsafe struct VkSparseImageMemoryBindInfo {
        /// <summary> image is the VkImage object to be bound</summary>
        public VkImage image;
        /// <summary> bindCount is the number of VkSparseImageMemoryBind
        /// structures in pBinds array</summary>
        public UInt32 bindCount;
        /// <summary> pBinds is a pointer to array of VkSparseImageMemoryBind
        /// structures</summary>
        public /*-const-*/ VkSparseImageMemoryBind* pBinds;
    }
    // Struct: 383
    /// <summary>VkSparseImageMemoryRequirements - Structure specifying sparse image memory requirements
    /// </summary>
    public unsafe struct VkSparseImageMemoryRequirements {
        public VkSparseImageFormatProperties formatProperties;
        /// <summary> imageMipTailFirstLod is the first mip level at which image
        /// subresources are included in the mip tail region.</summary>
        public UInt32 imageMipTailFirstLod;
        /// <summary> imageMipTailSize is the memory size (in bytes) of the mip tail
        /// region.
        /// If formatProperties.flags contains
        /// VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT, this is the size of the
        /// whole mip tail, otherwise this is the size of the mip tail of a single
        /// array layer.
        /// This value is guaranteed to be a multiple of the sparse block size in
        /// bytes.</summary>
        public VkDeviceSize imageMipTailSize;
        /// <summary> imageMipTailOffset is the opaque memory offset used with
        /// VkSparseImageOpaqueMemoryBindInfo to bind the mip tail region(s).</summary>
        public VkDeviceSize imageMipTailOffset;
        /// <summary> imageMipTailStride is the offset stride between each array-layer’s
        /// mip tail, if formatProperties.flags does not contain
        /// VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT (otherwise the value is
        /// undefined).</summary>
        public VkDeviceSize imageMipTailStride;
    }
    // Struct: 384
    /// <summary>VkSparseImageMemoryRequirements2 - (None)
    /// </summary>
    public unsafe struct VkSparseImageMemoryRequirements2 {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> memoryRequirements is a structure of type
        /// VkSparseImageMemoryRequirements describing the memory requirements
        /// of the sparse image.</summary>
        public VkSparseImageMemoryRequirements memoryRequirements;
    }
    // Struct: 385
    /// <summary>VkSparseImageOpaqueMemoryBindInfo - Structure specifying sparse image opaque memory bind info
    /// </summary>
    public unsafe struct VkSparseImageOpaqueMemoryBindInfo {
        /// <summary> image is the VkImage object to be bound.</summary>
        public VkImage image;
        /// <summary> bindCount is the number of VkSparseMemoryBind structures in
        /// the pBinds array.</summary>
        public UInt32 bindCount;
        /// <summary> pBinds is a pointer to array of VkSparseMemoryBind
        /// structures.</summary>
        public /*-const-*/ VkSparseMemoryBind* pBinds;
    }
    // Struct: 386
    /// <summary>VkSparseMemoryBind - Structure specifying a sparse memory bind operation
    /// </summary>
    public unsafe struct VkSparseMemoryBind {
        /// <summary> resourceOffset is the offset into the resource.</summary>
        public VkDeviceSize resourceOffset;
        /// <summary> size is the size of the memory region to be bound.</summary>
        public VkDeviceSize size;
        /// <summary> memory is the VkDeviceMemory object that the range of the
        /// resource is bound to.
        /// If memory is VK_NULL_HANDLE, the range is unbound.</summary>
        public VkDeviceMemory memory;
        /// <summary> memoryOffset is the offset into the VkDeviceMemory object to
        /// bind the resource range to.
        /// If memory is VK_NULL_HANDLE, this value is ignored.</summary>
        public VkDeviceSize memoryOffset;
        /// <summary> flags is a bitmask of VkSparseMemoryBindFlagBits specifying
        /// usage of the binding operation.</summary>
        public VkSparseMemoryBindFlags flags;
    }
    // Struct: 387
    /// <summary>VkSpecializationInfo - Structure specifying specialization info
    /// </summary>
    public unsafe struct VkSpecializationInfo {
        /// <summary> mapEntryCount is the number of entries in the pMapEntries
        /// array.</summary>
        public UInt32 mapEntryCount;
        /// <summary> pMapEntries is a pointer to an array of
        /// VkSpecializationMapEntry which maps constant IDs to offsets in
        /// pData.</summary>
        public /*-const-*/ VkSpecializationMapEntry* pMapEntries;
        /// <summary> dataSize is the byte size of the pData buffer.</summary>
        public Int32 dataSize;
        /// <summary> pData contains the actual constant values to specialize with.</summary>
        public /*-const-*/ void* pData;
    }
    // Struct: 388
    /// <summary>VkSpecializationMapEntry - Structure specifying a specialization map entry
    /// </summary>
    public unsafe struct VkSpecializationMapEntry {
        /// <summary> constantID is the ID of the specialization constant in SPIR-V.</summary>
        public UInt32    /*-const-*/antID;
        /// <summary> offset is the byte offset of the specialization constant value
        /// within the supplied data buffer.</summary>
        public UInt32 offset;
        /// <summary> size is the byte size of the specialization constant value within
        /// the supplied data buffer.</summary>
        public Int32 size;
    }
    // Struct: 389
    /// <summary>VkStencilOpState - Structure specifying stencil operation state
    /// </summary>
    public unsafe struct VkStencilOpState {
        /// <summary> failOp is a VkStencilOp value specifying the action
        /// performed on samples that fail the stencil test.</summary>
        public VkStencilOp failOp;
        /// <summary> passOp is a VkStencilOp value specifying the action
        /// performed on samples that pass both the depth and stencil tests.</summary>
        public VkStencilOp passOp;
        /// <summary> depthFailOp is a VkStencilOp value specifying the action
        /// performed on samples that pass the stencil test and fail the depth test.</summary>
        public VkStencilOp depthFailOp;
        /// <summary> compareOp is a VkCompareOp value specifying the comparison
        /// operator used in the stencil test.</summary>
        public VkCompareOp compareOp;
        /// <summary> compareMask selects the bits of the unsigned integer stencil
        /// values participating in the stencil test.</summary>
        public UInt32 compareMask;
        /// <summary> writeMask selects the bits of the unsigned integer stencil values
        /// updated by the stencil test in the stencil framebuffer attachment.</summary>
        public UInt32 writeMask;
        /// <summary> reference is an integer reference value that is used in the
        /// unsigned stencil comparison.</summary>
        public UInt32 reference;
    }
    // Struct: 390
    /// <summary>VkStreamDescriptorSurfaceCreateInfoGGP - Structure specifying parameters of a newly created Google Games Platform stream surface object
    /// </summary>
    public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkStreamDescriptorSurfaceCreateFlagsGGP flags;
        /// <summary> streamDescriptor is a GgpStreamDescriptor referring to the
        /// GGP stream descriptor to associate with the surface.</summary>
        public GgpStreamDescriptor streamDescriptor;
    }
    // Struct: 391
    /// <summary>VkSubmitInfo - Structure specifying a queue submit operation
    /// </summary>
    public unsafe struct VkSubmitInfo {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> waitSemaphoreCount is the number of semaphores upon which to wait
        /// before executing the command buffers for the batch.</summary>
        public UInt32 waitSemaphoreCount;
        /// <summary> pWaitSemaphores is a pointer to an array of semaphores upon which
        /// to wait before the command buffers for this batch begin execution.
        /// If semaphores to wait on are provided, they define a
        /// semaphore wait operation.</summary>
        public /*-const-*/ VkSemaphore* pWaitSemaphores;
        /// <summary> pWaitDstStageMask is a pointer to an array of pipeline stages at
        /// which each corresponding semaphore wait will occur.</summary>
        public /*-const-*/ VkPipelineStageFlags* pWaitDstStageMask;
        /// <summary> commandBufferCount is the number of command buffers to execute in
        /// the batch.</summary>
        public UInt32 commandBufferCount;
        /// <summary> pCommandBuffers is a pointer to an array of command buffers to
        /// execute in the batch.</summary>
        public /*-const-*/ VkCommandBuffer* pCommandBuffers;
        /// <summary> signalSemaphoreCount is the number of semaphores to be signaled
        /// once the commands specified in pCommandBuffers have completed
        /// execution.</summary>
        public UInt32 signalSemaphoreCount;
        /// <summary> pSignalSemaphores is a pointer to an array of semaphores which
        /// will be signaled when the command buffers for this batch have completed
        /// execution.
        /// If semaphores to be signaled are provided, they define a
        /// semaphore signal operation.</summary>
        public /*-const-*/ VkSemaphore* pSignalSemaphores;
    }
    // Struct: 392
    /// <summary>VkSubpassBeginInfoKHR - Structure specifying subpass begin info
    /// </summary>
    public unsafe struct VkSubpassBeginInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> contents is a VkSubpassContents value specifying how the
        /// commands in the next subpass will be provided.</summary>
        public VkSubpassContents contents;
    }
    // Struct: 393
    /// <summary>VkSubpassDependency - Structure specifying a subpass dependency
    /// </summary>
    public unsafe struct VkSubpassDependency {
        /// <summary> srcSubpass is the subpass index of the first subpass in the
        /// dependency, or VK_SUBPASS_EXTERNAL.</summary>
        public UInt32 srcSubpass;
        /// <summary> dstSubpass is the subpass index of the second subpass in the
        /// dependency, or VK_SUBPASS_EXTERNAL.</summary>
        public UInt32 dstSubpass;
        /// <summary> srcStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the source stage
        /// mask.</summary>
        public VkPipelineStageFlags srcStageMask;
        /// <summary> dstStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the destination
        /// stage mask </summary>
        public VkPipelineStageFlags dstStageMask;
        /// <summary> srcAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// source access mask.</summary>
        public VkAccessFlags srcAccessMask;
        /// <summary> dstAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// destination access mask.</summary>
        public VkAccessFlags dstAccessMask;
        /// <summary> dependencyFlags is a bitmask of VkDependencyFlagBits.</summary>
        public VkDependencyFlags dependencyFlags;
    }
    // Struct: 394
    /// <summary>VkSubpassDependency2KHR - Structure specifying a subpass dependency
    /// </summary>
    public unsafe struct VkSubpassDependency2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> srcSubpass is the subpass index of the first subpass in the
        /// dependency, or VK_SUBPASS_EXTERNAL.</summary>
        public UInt32 srcSubpass;
        /// <summary> dstSubpass is the subpass index of the second subpass in the
        /// dependency, or VK_SUBPASS_EXTERNAL.</summary>
        public UInt32 dstSubpass;
        /// <summary> srcStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the source stage
        /// mask.</summary>
        public VkPipelineStageFlags srcStageMask;
        /// <summary> dstStageMask is a bitmask of VkPipelineStageFlagBits
        /// specifying the destination
        /// stage mask </summary>
        public VkPipelineStageFlags dstStageMask;
        /// <summary> srcAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// source access mask.</summary>
        public VkAccessFlags srcAccessMask;
        /// <summary> dstAccessMask is a bitmask of VkAccessFlagBits specifying a
        /// destination access mask.</summary>
        public VkAccessFlags dstAccessMask;
        /// <summary> dependencyFlags is a bitmask of VkDependencyFlagBits.</summary>
        public VkDependencyFlags dependencyFlags;
        /// <summary> viewOffset controls which views in the source subpass the views in
        /// the destination subpass depend on.</summary>
        public Int32 viewOffset;
    }
    // Struct: 395
    /// <summary>VkSubpassDescription - Structure specifying a subpass description
    /// </summary>
    public unsafe struct VkSubpassDescription {
        /// <summary> flags is a bitmask of VkSubpassDescriptionFlagBits
        /// specifying usage of the subpass.</summary>
        public VkSubpassDescriptionFlags flags;
        /// <summary> pipelineBindPoint is a VkPipelineBindPoint value specifying
        /// the pipeline type supported for this subpass.</summary>
        public VkPipelineBindPoint pipelineBindPoint;
        /// <summary> inputAttachmentCount is the number of input attachments.</summary>
        public UInt32 inputAttachmentCount;
        /// <summary> pInputAttachments is an array of VkAttachmentReference
        /// structures defining the input attachments for this subpass and their
        /// layouts.</summary>
        public /*-const-*/ VkAttachmentReference* pInputAttachments;
        /// <summary> colorAttachmentCount is the number of color attachments.</summary>
        public UInt32 colorAttachmentCount;
        /// <summary> pColorAttachments is an array of VkAttachmentReference
        /// structures defining the color attachments for this subpass and their
        /// layouts.</summary>
        public /*-const-*/ VkAttachmentReference* pColorAttachments;
        /// <summary> pResolveAttachments is an optional array of
        /// colorAttachmentCount VkAttachmentReference structures
        /// defining the resolve attachments for this subpass and their layouts.</summary>
        public /*-const-*/ VkAttachmentReference* pResolveAttachments;
        /// <summary> pDepthStencilAttachment is a pointer to a
        /// VkAttachmentReference specifying the depth/stencil attachment for
        /// this subpass and its layout.</summary>
        public /*-const-*/ VkAttachmentReference* pDepthStencilAttachment;
        /// <summary> preserveAttachmentCount is the number of preserved attachments.</summary>
        public UInt32 preserveAttachmentCount;
        /// <summary> pPreserveAttachments is an array of preserveAttachmentCount
        /// render pass attachment indices identifying attachments that are not used
        /// by this subpass, but whose contents must be preserved throughout the
        /// subpass.</summary>
        public /*-const-*/ UInt32* pPreserveAttachments;
    }
    // Struct: 396
    /// <summary>VkSubpassDescription2KHR - Structure specifying a subpass description
    /// </summary>
    public unsafe struct VkSubpassDescription2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkSubpassDescriptionFlagBits
        /// specifying usage of the subpass.</summary>
        public VkSubpassDescriptionFlags flags;
        /// <summary> pipelineBindPoint is a VkPipelineBindPoint value specifying
        /// the pipeline type supported for this subpass.</summary>
        public VkPipelineBindPoint pipelineBindPoint;
        /// <summary> viewMask is a bitfield of view indices describing which views
        /// rendering is broadcast to in this subpass, when multiview is enabled.</summary>
        public UInt32 viewMask;
        /// <summary> inputAttachmentCount is the number of input attachments.</summary>
        public UInt32 inputAttachmentCount;
        /// <summary> pInputAttachments is an array of VkAttachmentReference2KHR
        /// structures defining the input attachments for this subpass and their
        /// layouts.</summary>
        public /*-const-*/ VkAttachmentReference2KHR* pInputAttachments;
        /// <summary> colorAttachmentCount is the number of color attachments.</summary>
        public UInt32 colorAttachmentCount;
        /// <summary> pColorAttachments is an array of VkAttachmentReference2KHR
        /// structures defining the color attachments for this subpass and their
        /// layouts.</summary>
        public /*-const-*/ VkAttachmentReference2KHR* pColorAttachments;
        /// <summary> pResolveAttachments is an optional array of
        /// colorAttachmentCount VkAttachmentReference2KHR structures
        /// defining the resolve attachments for this subpass and their layouts.</summary>
        public /*-const-*/ VkAttachmentReference2KHR* pResolveAttachments;
        /// <summary> pDepthStencilAttachment is a pointer to a
        /// VkAttachmentReference2KHR specifying the depth/stencil attachment
        /// for this subpass and its layout.</summary>
        public /*-const-*/ VkAttachmentReference2KHR* pDepthStencilAttachment;
        /// <summary> preserveAttachmentCount is the number of preserved attachments.</summary>
        public UInt32 preserveAttachmentCount;
        /// <summary> pPreserveAttachments is an array of preserveAttachmentCount
        /// render pass attachment indices identifying attachments that are not used
        /// by this subpass, but whose contents must be preserved throughout the
        /// subpass.</summary>
        public /*-const-*/ UInt32* pPreserveAttachments;
    }
    // Struct: 397
    /// <summary>VkSubpassDescriptionDepthStencilResolveKHR - Structure specifying depth/stencil resolve operations for a subpass
    /// </summary>
    public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> depthResolveMode is a bitmask of VkResolveModeFlagBitsKHR
        /// describing the depth resolve mode.</summary>
        public VkResolveModeFlagBitsKHR depthResolveMode;
        /// <summary> stencilResolveMode is a bitmask of VkResolveModeFlagBitsKHR
        /// describing the stencil resolve mode.</summary>
        public VkResolveModeFlagBitsKHR stencilResolveMode;
        /// <summary> pDepthStencilResolveAttachment is an optional
        /// VkAttachmentReference structure defining the depth/stencil resolve
        /// attachment for this subpass and its layout.</summary>
        public /*-const-*/ VkAttachmentReference2KHR* pDepthStencilResolveAttachment;
    }
    // Struct: 398
    /// <summary>VkSubpassEndInfoKHR - Structure specifying subpass end info
    /// </summary>
    public unsafe struct VkSubpassEndInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
    }
    // Struct: 399
    /// <summary>VkSubpassSampleLocationsEXT - Structure specifying the sample locations state to use for layout transitions of attachments performed after a given subpass
    /// </summary>
    public unsafe struct VkSubpassSampleLocationsEXT {
        /// <summary> subpassIndex is the index of the subpass for which the sample
        /// locations state is provided.</summary>
        public UInt32 subpassIndex;
        /// <summary> sampleLocationsInfo is the sample locations state to use for the
        /// layout transition of the depth/stencil attachment away from the image
        /// layout the attachment is used with in the subpass specified in
        /// subpassIndex.</summary>
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }
    // Struct: 400
    /// <summary>VkSubresourceLayout - Structure specifying subresource layout
    /// </summary>
    public unsafe struct VkSubresourceLayout {
        /// <summary> offset is the byte offset from the start of the image
        /// or the plane
        /// where the image subresource begins.</summary>
        public VkDeviceSize offset;
        /// <summary> size is the size in bytes of the image subresource.
        /// size includes any extra memory that is required based on
        /// rowPitch.</summary>
        public VkDeviceSize size;
        /// <summary> rowPitch describes the number of bytes between each row of texels
        /// in an image.</summary>
        public VkDeviceSize rowPitch;
        /// <summary> arrayPitch describes the number of bytes between each array layer
        /// of an image.</summary>
        public VkDeviceSize arrayPitch;
        /// <summary> depthPitch describes the number of bytes between each slice of 3D
        /// image.</summary>
        public VkDeviceSize depthPitch;
    }
    // Struct: 401
    /// <summary>VkSurfaceCapabilities2EXT - Structure describing capabilities of a surface
    /// </summary>
    public unsafe struct VkSurfaceCapabilities2EXT {
        public VkStructureType sType;
        public void* pNext;
        public UInt32 minImageCount;
        public UInt32 maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public UInt32 maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagBitsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        public VkImageUsageFlags supportedUsageFlags;
        public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
    }
    // Struct: 402
    /// <summary>VkSurfaceCapabilities2KHR - Structure describing capabilities of a surface
    /// </summary>
    public unsafe struct VkSurfaceCapabilities2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> surfaceCapabilities is a structure of type
        /// VkSurfaceCapabilitiesKHR describing the capabilities of the
        /// specified surface.</summary>
        public VkSurfaceCapabilitiesKHR surfaceCapabilities;
    }
    // Struct: 403
    /// <summary>VkSurfaceCapabilitiesFullScreenExclusiveEXT - Structure describing full screen exclusive capabilities of a surface
    /// </summary>
    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        public VkBool32 fullScreenExclusiveSupported;
    }
    // Struct: 404
    /// <summary>VkSurfaceCapabilitiesKHR - Structure describing capabilities of a surface
    /// </summary>
    public unsafe struct VkSurfaceCapabilitiesKHR {
        /// <summary> minImageCount is the minimum number of images the specified device
        /// supports for a swapchain created for the surface, and will be at least
        /// one.</summary>
        public UInt32 minImageCount;
        /// <summary> maxImageCount is the maximum number of images the specified device
        /// supports for a swapchain created for the surface, and will be either 0,
        /// or greater than or equal to minImageCount.
        /// A value of 0 means that there is no limit on the number of images,
        /// though there may be limits related to the total amount of memory used
        /// by presentable images.</summary>
        public UInt32 maxImageCount;
        /// <summary> currentExtent is the current width and height of the surface, or
        /// the special value (0xFFFFFFFF, 0xFFFFFFFF) indicating that the
        /// surface size will be determined by the extent of a swapchain targeting
        /// the surface.</summary>
        public VkExtent2D currentExtent;
        /// <summary> minImageExtent contains the smallest valid swapchain extent for
        /// the surface on the specified device.
        /// The width and height of the extent will each be less than or
        /// equal to the corresponding width and height of
        /// currentExtent, unless currentExtent has the special value
        /// described above.</summary>
        public VkExtent2D minImageExtent;
        /// <summary> maxImageExtent contains the largest valid swapchain extent for the
        /// surface on the specified device.
        /// The width and height of the extent will each be greater than
        /// or equal to the corresponding width and height of
        /// minImageExtent.
        /// The width and height of the extent will each be greater than
        /// or equal to the corresponding width and height of
        /// currentExtent, unless currentExtent has the special value
        /// described above.</summary>
        public VkExtent2D maxImageExtent;
        /// <summary> maxImageArrayLayers is the maximum number of layers presentable
        /// images can have for a swapchain created for this device and surface,
        /// and will be at least one.</summary>
        public UInt32 maxImageArrayLayers;
        /// <summary> supportedTransforms is a bitmask of
        /// VkSurfaceTransformFlagBitsKHR indicating the presentation
        /// transforms supported for the surface on the specified device.
        /// At least one bit will be set.</summary>
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        /// <summary> currentTransform is VkSurfaceTransformFlagBitsKHR value
        /// indicating the surface’s current transform relative to the presentation
        /// engine’s natural orientation.</summary>
        public VkSurfaceTransformFlagBitsKHR currentTransform;
        /// <summary> supportedCompositeAlpha is a bitmask of
        /// VkCompositeAlphaFlagBitsKHR, representing the alpha compositing
        /// modes supported by the presentation engine for the surface on the
        /// specified device, and at least one bit will be set.
        /// Opaque composition can be achieved in any alpha compositing mode by
        /// either using an image format that has no alpha component, or by ensuring
        /// that all pixels in the presentable images have an alpha value of 1.0.</summary>
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        /// <summary> supportedUsageFlags is a bitmask of VkImageUsageFlagBits
        /// representing the ways the application can use the presentable images of
        /// a swapchain created
        /// with VkPresentModeKHR set to VK_PRESENT_MODE_IMMEDIATE_KHR,
        /// VK_PRESENT_MODE_MAILBOX_KHR, VK_PRESENT_MODE_FIFO_KHR or
        /// VK_PRESENT_MODE_FIFO_RELAXED_KHR
        /// for the surface on the specified device.
        /// VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT must be included in the set
        /// but implementations may support additional usages.</summary>
        public VkImageUsageFlags supportedUsageFlags;
    }
    // Struct: 405
    /// <summary>VkSurfaceFormat2KHR - Structure describing a supported swapchain format tuple
    /// </summary>
    public unsafe struct VkSurfaceFormat2KHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> surfaceFormat is an instance of VkSurfaceFormatKHR
        /// describing a format-color space pair that is compatible with the
        /// specified surface.</summary>
        public VkSurfaceFormatKHR surfaceFormat;
    }
    // Struct: 406
    /// <summary>VkSurfaceFormatKHR - Structure describing a supported swapchain format-color space pair
    /// </summary>
    public unsafe struct VkSurfaceFormatKHR {
        /// <summary> format is a VkFormat that is compatible with the specified
        /// surface.</summary>
        public VkFormat format;
        /// <summary> colorSpace is a presentation VkColorSpaceKHR that is
        /// compatible with the surface.</summary>
        public VkColorSpaceKHR colorSpace;
    }
    // Struct: 407
    /// <summary>VkSurfaceFullScreenExclusiveInfoEXT - Structure specifying the preferred full-screen transition behavior
    /// </summary>
    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public void* pNext;
        /// <summary> fullScreenExclusive is a VkFullScreenExclusiveEXT value
        /// specifying the preferred full-screen transition behavior.</summary>
        public VkFullScreenExclusiveEXT fullScreenExclusive;
    }
    // Struct: 408
    /// <summary>VkSurfaceFullScreenExclusiveWin32InfoEXT - Structure specifying additional creation parameters specific to Win32 fullscreen exclusive mode
    /// </summary>
    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> hmonitor is the Win32 HMONITOR handle identifying the display
        /// to create the surface with.</summary>
        public HMONITOR hmonitor;
    }
    // Struct: 409
    /// <summary>VkSurfaceProtectedCapabilitiesKHR - Structure describing capability of a surface to be protected
    /// </summary>
    public unsafe struct VkSurfaceProtectedCapabilitiesKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> supportsProtected specifies whether a protected swapchain created
        /// from VkPhysicalDeviceSurfaceInfo2KHR::surface for a
        /// particular windowing system can be displayed on screen or not.
        /// If supportsProtected is VK_TRUE, then creation of swapchains
        /// with the VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR flag set must be
        /// supported for surface.</summary>
        public VkBool32 supportsProtected;
    }
    // Struct: 410
    /// <summary>VkSwapchainCounterCreateInfoEXT - Specify the surface counters desired
    /// </summary>
    public unsafe struct VkSwapchainCounterCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> surfaceCounters is a bitmask of VkSurfaceCounterFlagBitsEXT
        /// specifying surface counters to enable for the swapchain.</summary>
        public VkSurfaceCounterFlagsEXT surfaceCounters;
    }
    // Struct: 411
    /// <summary>VkSwapchainCreateInfoKHR - Structure specifying parameters of a newly created swapchain object
    /// </summary>
    public unsafe struct VkSwapchainCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is a bitmask of VkSwapchainCreateFlagBitsKHR
        /// indicating parameters of the swapchain creation.</summary>
        public VkSwapchainCreateFlagsKHR flags;
        /// <summary> surface is the surface onto which the swapchain will present
        /// images.
        /// If the creation succeeds, the swapchain becomes associated with
        /// surface.</summary>
        public VkSurfaceKHR surface;
        /// <summary> minImageCount is the minimum number of presentable images that the
        /// application needs.
        /// The implementation will either create the swapchain with at least that
        /// many images, or it will fail to create the swapchain.</summary>
        public UInt32 minImageCount;
        /// <summary> imageFormat is a VkFormat value specifying the format the
        /// swapchain image(s) will be created with.</summary>
        public VkFormat imageFormat;
        /// <summary> imageColorSpace is a VkColorSpaceKHR value specifying the
        /// way the swapchain interprets image data.</summary>
        public VkColorSpaceKHR imageColorSpace;
        /// <summary> imageExtent is the size (in pixels) of the swapchain image(s).
        /// The behavior is platform-dependent if the image extent does not match
        /// the surface’s currentExtent as returned by
        /// vkGetPhysicalDeviceSurfaceCapabilitiesKHR.</summary>
        public VkExtent2D imageExtent;
        public UInt32 imageArrayLayers;
        public VkImageUsageFlags imageUsage;
        public VkSharingMode imageSharingMode;
        public UInt32 queueFamilyIndexCount;
        public /*-const-*/ UInt32* pQueueFamilyIndices;
        public VkSurfaceTransformFlagBitsKHR preTransform;
        public VkCompositeAlphaFlagBitsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public VkBool32 clipped;
        public VkSwapchainKHR oldSwapchain;
    }
    // Struct: 412
    /// <summary>VkSwapchainDisplayNativeHdrCreateInfoAMD - Structure specifying display native HDR parameters of a newly created swapchain object
    /// </summary>
    public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> localDimmingEnable specifies whether local dimming is enabled for
        /// the swapchain.</summary>
        public VkBool32 localDimmingEnable;
    }
    // Struct: 413
    /// <summary>VkTextureLODGatherFormatPropertiesAMD - Structure informing whether or not texture gather bias/LOD functionality is supported for a given image format and a given physical device.
    /// </summary>
    public unsafe struct VkTextureLODGatherFormatPropertiesAMD {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL.</summary>
        public void* pNext;
        /// <summary> supportsTextureGatherLODBiasAMD tells if the image format can be
        /// used with texture gather bias/LOD functions, as introduced by the
        ///  html/vkspec.html#VK_AMD_texture_gather_bias_lod  extension.
        /// This field is set by the implementation.
        /// User-specified value is ignored.</summary>
        public VkBool32 supportsTextureGatherLODBiasAMD;
    }
    // Struct: 414
    /// <summary>VkValidationCacheCreateInfoEXT - Structure specifying parameters of a newly created validation cache
    /// </summary>
    public unsafe struct VkValidationCacheCreateInfoEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkValidationCacheCreateFlagsEXT flags;
        /// <summary> initialDataSize is the number of bytes in pInitialData.
        /// If initialDataSize is zero, the validation cache will initially be
        /// empty.</summary>
        public Int32 initialDataSize;
        /// <summary> pInitialData is a pointer to previously retrieved validation cache
        /// data.
        /// If the validation cache data is incompatible (as defined below) with the
        /// device, the validation cache will be initially empty.
        /// If initialDataSize is zero, pInitialData is ignored.</summary>
        public /*-const-*/ void* pInitialData;
    }
    // Struct: 415
    /// <summary>VkValidationFeaturesEXT - Specify validation features to enable or disable for a Vulkan instance
    /// </summary>
    public unsafe struct VkValidationFeaturesEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> enabledValidationFeatureCount is the number of features to enable.</summary>
        public UInt32 enabledValidationFeatureCount;
        /// <summary> pEnabledValidationFeatures is a pointer to an array of
        /// VkValidationFeatureEnableEXT values specifying the validation
        /// features to be enabled.</summary>
        public /*-const-*/ VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
        /// <summary> disabledValidationFeatureCount is the number of features to
        /// disable.</summary>
        public UInt32 disabledValidationFeatureCount;
        /// <summary> pDisabledValidationFeatures is a pointer to an array of
        /// VkValidationFeatureDisableEXT values specifying the validation
        /// features to be disabled.</summary>
        public /*-const-*/ VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
    }
    // Struct: 416
    /// <summary>VkValidationFlagsEXT - Specify validation checks to disable for a Vulkan instance
    /// </summary>
    public unsafe struct VkValidationFlagsEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> disabledValidationCheckCount is the number of checks to disable.</summary>
        public UInt32 disabledValidationCheckCount;
        /// <summary> pDisabledValidationChecks is a pointer to an array of
        /// VkValidationCheckEXT values specifying the validation checks to be
        /// disabled.</summary>
        public /*-const-*/ VkValidationCheckEXT* pDisabledValidationChecks;
    }
    // Struct: 417
    /// <summary>VkVertexInputAttributeDescription - Structure specifying vertex input attribute description
    /// </summary>
    public unsafe struct VkVertexInputAttributeDescription {
        /// <summary> location is the shader binding location number for this attribute.</summary>
        public UInt32 location;
        /// <summary> binding is the binding number which this attribute takes its data
        /// from.</summary>
        public UInt32 binding;
        /// <summary> format is the size and type of the vertex attribute data.</summary>
        public VkFormat format;
        /// <summary> offset is a byte offset of this attribute relative to the start of
        /// an element in the vertex input binding.</summary>
        public UInt32 offset;
    }
    // Struct: 418
    /// <summary>VkVertexInputBindingDescription - Structure specifying vertex input binding description
    /// </summary>
    public unsafe struct VkVertexInputBindingDescription {
        /// <summary> binding is the binding number that this structure describes.</summary>
        public UInt32 binding;
        /// <summary> stride is the distance in bytes between two consecutive elements
        /// within the buffer.</summary>
        public UInt32 stride;
        /// <summary> inputRate is a VkVertexInputRate value specifying whether
        /// vertex attribute addressing is a function of the vertex index or of the
        /// instance index.</summary>
        public VkVertexInputRate inputRate;
    }
    // Struct: 419
    /// <summary>VkVertexInputBindingDivisorDescriptionEXT - Structure specifying a divisor used in instanced rendering
    /// </summary>
    public unsafe struct VkVertexInputBindingDivisorDescriptionEXT {
        /// <summary> binding is the binding number for which the divisor is specified.</summary>
        public UInt32 binding;
        /// <summary> divisor is the number of successive instances that will use the
        /// same value of the vertex attribute when instanced rendering is enabled.
        /// For example, if the divisor is N, the same vertex attribute will applied
        /// to N successive instances before moving on to the next vertex attribute.
        /// The maximum value of divisor is implementation dependent and can be
        /// queried using
        /// VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT::maxVertexAttribDivisor.
        /// A value of 0 can be used for the divisor if the
        ///  vertexAttributeInstanceRateZeroDivisor 
        /// feature is enabled.
        /// In this case, the same vertex attribute will be applied to all
        /// instances.</summary>
        public UInt32 divisor;
    }
    // Struct: 420
    /// <summary>VkViSurfaceCreateInfoNN - Structure specifying parameters of a newly created VI surface object
    /// </summary>
    public unsafe struct VkViSurfaceCreateInfoNN {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkViSurfaceCreateFlagsNN flags;
        /// <summary> window is the nn::vi::NativeWindowHandle for the
        /// nn::vi::Layer with which to associate the surface.</summary>
        public void* window;
    }
    // Struct: 421
    /// <summary>VkViewport - Structure specifying a viewport
    /// </summary>
    public unsafe struct VkViewport {
        /// <summary> x and y are the viewport’s upper left corner (x,y).</summary>
        public float x;
        public float y;
        /// <summary> width and height are the viewport’s width and height,
        /// respectively.</summary>
        public float width;
        public float height;
        /// <summary> minDepth and maxDepth are the depth range for the viewport.
        /// It is valid for minDepth to be greater than or equal to
        /// maxDepth.</summary>
        public float minDepth;
        public float maxDepth;
    }
    // Struct: 422
    /// <summary>VkViewportSwizzleNV - Structure specifying a viewport swizzle
    /// </summary>
    public unsafe struct VkViewportSwizzleNV {
        /// <summary> x is a VkViewportCoordinateSwizzleNV value specifying the
        /// swizzle operation to apply to the x component of the primitive</summary>
        public VkViewportCoordinateSwizzleNV x;
        /// <summary> y is a VkViewportCoordinateSwizzleNV value specifying the
        /// swizzle operation to apply to the y component of the primitive</summary>
        public VkViewportCoordinateSwizzleNV y;
        /// <summary> z is a VkViewportCoordinateSwizzleNV value specifying the
        /// swizzle operation to apply to the z component of the primitive</summary>
        public VkViewportCoordinateSwizzleNV z;
        /// <summary> w is a VkViewportCoordinateSwizzleNV value specifying the
        /// swizzle operation to apply to the w component of the primitive</summary>
        public VkViewportCoordinateSwizzleNV w;
    }
    // Struct: 423
    /// <summary>VkViewportWScalingNV - Structure specifying a viewport
    /// </summary>
    public unsafe struct VkViewportWScalingNV {
        /// <summary> xcoeff and ycoeff are the viewport’s W scaling factor for x
        /// and y respectively.</summary>
        public float xcoeff;
        public float ycoeff;
    }
    // Struct: 424
    /// <summary>VkWaylandSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Wayland surface object
    /// </summary>
    public unsafe struct VkWaylandSurfaceCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkWaylandSurfaceCreateFlagsKHR flags;
        /// <summary> display and surface are pointers to the Wayland
        /// wl_display and wl_surface to associate the surface with.</summary>
        public /*-struct-*/ wl_display* display;
        public /*-struct-*/ wl_surface* surface;
    }
    // Struct: 425
    /// <summary>VkWin32KeyedMutexAcquireReleaseInfoKHR - Use the Windows keyed mutex mechanism to synchronize work
    /// </summary>
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR {
        public VkStructureType sType;
        public /*-const-*/ void* pNext;
        /// <summary> acquireCount is the number of entries in the pAcquireSyncs,
        /// pAcquireKeys, and pAcquireTimeoutMilliseconds arrays.</summary>
        public UInt32 acquireCount;
        /// <summary> pAcquireSyncs is a pointer to an array of VkDeviceMemory
        /// objects which were imported from Direct3D 11 resources.</summary>
        public /*-const-*/ VkDeviceMemory* pAcquireSyncs;
        /// <summary> pAcquireKeys is a pointer to an array of mutex key values to wait
        /// for prior to beginning the submitted work.
        /// Entries refer to the keyed mutex associated with the corresponding
        /// entries in pAcquireSyncs.</summary>
        public /*-const-*/ UInt64* pAcquireKeys;
        public /*-const-*/ UInt32* pAcquireTimeouts;
        /// <summary> releaseCount is the number of entries in the pReleaseSyncs
        /// and pReleaseKeys arrays.</summary>
        public UInt32 releaseCount;
        /// <summary> pReleaseSyncs is a pointer to an array of VkDeviceMemory
        /// objects which were imported from Direct3D 11 resources.</summary>
        public /*-const-*/ VkDeviceMemory* pReleaseSyncs;
        /// <summary> pReleaseKeys is a pointer to an array of mutex key values to set
        /// when the submitted work has completed.
        /// Entries refer to the keyed mutex associated with the corresponding
        /// entries in pReleaseSyncs.</summary>
        public /*-const-*/ UInt64* pReleaseKeys;
    }
    // Struct: 426
    /// <summary>VkWin32KeyedMutexAcquireReleaseInfoNV - use Windows keyex mutex mechanism to synchronize work
    /// </summary>
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV {
        public VkStructureType sType;
        public /*-const-*/ void* pNext;
        /// <summary> acquireCount is the number of entries in the pAcquireSyncs,
        /// pAcquireKeys, and pAcquireTimeoutMilliseconds arrays.</summary>
        public UInt32 acquireCount;
        /// <summary> pAcquireSyncs is a pointer to an array of VkDeviceMemory
        /// objects which were imported from Direct3D 11 resources.</summary>
        public /*-const-*/ VkDeviceMemory* pAcquireSyncs;
        /// <summary> pAcquireKeys is a pointer to an array of mutex key values to wait
        /// for prior to beginning the submitted work.
        /// Entries refer to the keyed mutex associated with the corresponding
        /// entries in pAcquireSyncs.</summary>
        public /*-const-*/ UInt64* pAcquireKeys;
        /// <summary> pAcquireTimeoutMilliseconds is an array of timeout values, in
        /// millisecond units, for each acquire specified in pAcquireKeys.</summary>
        public /*-const-*/ UInt32* pAcquireTimeoutMilliseconds;
        /// <summary> releaseCount is the number of entries in the pReleaseSyncs
        /// and pReleaseKeys arrays.</summary>
        public UInt32 releaseCount;
        /// <summary> pReleaseSyncs is a pointer to an array of VkDeviceMemory
        /// objects which were imported from Direct3D 11 resources.</summary>
        public /*-const-*/ VkDeviceMemory* pReleaseSyncs;
        /// <summary> pReleaseKeys is a pointer to an array of mutex key values to set
        /// when the submitted work has completed.
        /// Entries refer to the keyed mutex associated with the corresponding
        /// entries in pReleaseSyncs.</summary>
        public /*-const-*/ UInt64* pReleaseKeys;
    }
    // Struct: 427
    /// <summary>VkWin32SurfaceCreateInfoKHR - Structure specifying parameters of a newly created Win32 surface object
    /// </summary>
    public unsafe struct VkWin32SurfaceCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkWin32SurfaceCreateFlagsKHR flags;
        /// <summary> hinstance and hwnd are the Win32 HINSTANCE and
        /// HWND for the window to associate the surface with.</summary>
        public HINSTANCE hinstance;
        public HWND hwnd;
    }
    // Struct: 428
    /// <summary>VkWriteDescriptorSet - Structure specifying the parameters of a descriptor set write operation
    /// </summary>
    public unsafe struct VkWriteDescriptorSet {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> dstSet is the destination descriptor set to update.</summary>
        public VkDescriptorSet dstSet;
        /// <summary> dstBinding is the descriptor binding within that set.</summary>
        public UInt32 dstBinding;
        /// <summary> dstArrayElement is the starting element in that array.
        /// If the descriptor binding identified by dstSet and
        /// dstBinding has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// dstArrayElement specifies the starting byte offset within the
        /// binding.</summary>
        public UInt32 dstArrayElement;
        /// <summary> descriptorCount is the number of descriptors to update (the number
        /// of elements in pImageInfo, pBufferInfo, or
        /// pTexelBufferView
        /// , or a value matching the dataSize member of an instance of
        /// VkWriteDescriptorSetInlineUniformBlockEXT in the pNext chain
        /// , or a value matching the accelerationStructureCount of an
        /// instance of VkWriteDescriptorSetAccelerationStructureNV in the
        /// pNext chain
        /// ).
        /// If the descriptor binding identified by dstSet and
        /// dstBinding has a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT then
        /// descriptorCount specifies the number of bytes to update.</summary>
        public UInt32 descriptorCount;
        /// <summary> descriptorType is a VkDescriptorType specifying the type of
        /// each descriptor in pImageInfo, pBufferInfo, or
        /// pTexelBufferView, as described below.
        /// It must be the same type as that specified in
        /// VkDescriptorSetLayoutBinding for dstSet at dstBinding.
        /// The type of the descriptor also controls which array the descriptors are
        /// taken from.</summary>
        public VkDescriptorType descriptorType;
        /// <summary> pImageInfo points to an array of VkDescriptorImageInfo
        /// structures or is ignored, as described below.</summary>
        public /*-const-*/ VkDescriptorImageInfo* pImageInfo;
        /// <summary> pBufferInfo points to an array of VkDescriptorBufferInfo
        /// structures or is ignored, as described below.</summary>
        public /*-const-*/ VkDescriptorBufferInfo* pBufferInfo;
        /// <summary> pTexelBufferView points to an array of VkBufferView handles
        /// as described in the Buffer Views section or
        /// is ignored, as described below.</summary>
        public /*-const-*/ VkBufferView* pTexelBufferView;
    }
    // Struct: 429
    /// <summary>VkWriteDescriptorSetAccelerationStructureNV - Structure specifying acceleration to query for memory requirements
    /// </summary>
    public unsafe struct VkWriteDescriptorSetAccelerationStructureNV {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> accelerationStructureCount is the number of elements in
        /// pAccelerationStructures.</summary>
        public UInt32 accelerationStructureCount;
        /// <summary> pAccelerationStructures are the acceleration structures to update.</summary>
        public /*-const-*/ VkAccelerationStructureNV* pAccelerationStructures;
    }
    // Struct: 430
    /// <summary>VkWriteDescriptorSetInlineUniformBlockEXT - Structure specifying inline uniform block data
    /// </summary>
    public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> dataSize is the number of bytes of inline uniform block data
        /// pointed to by pData.</summary>
        public UInt32 dataSize;
        /// <summary> pData is a pointer to dataSize number of bytes of data to
        /// write to the inline uniform block.</summary>
        public /*-const-*/ void* pData;
    }
    // Struct: 431
    /// <summary>VkXYColorEXT - structure to specify X,Y chromaticity coordinates
    /// </summary>
    public unsafe struct VkXYColorEXT {
        public float x;
        public float y;
    }
    // Struct: 432
    /// <summary>VkXcbSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Xcb surface object
    /// </summary>
    public unsafe struct VkXcbSurfaceCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkXcbSurfaceCreateFlagsKHR flags;
        /// <summary> connection is a pointer to an xcb_connection_t to the X
        /// server.</summary>
        public xcb_connection_t* connection;
        /// <summary> window is the xcb_window_t for the X11 window to associate
        /// the surface with.</summary>
        public xcb_window_t window;
    }
    // Struct: 433
    /// <summary>VkXlibSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Xlib surface object
    /// </summary>
    public unsafe struct VkXlibSurfaceCreateInfoKHR {
        /// <summary> sType is the type of this structure.</summary>
        public VkStructureType sType;
        /// <summary> pNext is NULL or a pointer to an extension-specific structure.</summary>
        public /*-const-*/ void* pNext;
        /// <summary> flags is reserved for future use.</summary>
        public VkXlibSurfaceCreateFlagsKHR flags;
        /// <summary> dpy is a pointer to an Xlib Display connection to the X
        /// server.</summary>
        public Display* dpy;
        /// <summary> window is an Xlib Window to associate the surface with.</summary>
        public Window window;
    }

}
