using System;

namespace Vulkan {
    // PFN: 0
    /// <summary>PFN_vkAllocationFunction - Application-defined memory allocation function</summary>
    public unsafe delegate void* PFN_vkAllocationFunction(
    /// <summary>pUserData is the value specified for
    /// VkAllocationCallbacks::pUserData in the allocator specified
    /// by the application.</summary>
    void* pUserData,
    /// <summary>size is the size in bytes of the requested allocation.</summary>
    Int32 size,
    /// <summary>alignment is the requested alignment of the allocation in bytes
    /// and must be a power of two.</summary>
    Int32 alignment,
    /// <summary>allocationScope is a VkSystemAllocationScope value
    /// specifying the allocation scope of the lifetime of the allocation, as
    /// described here.</summary>
    VkSystemAllocationScope allocationScope);
    // PFN: 1
    /// <summary>PFN_vkDebugReportCallbackEXT - Application-defined debug report callback function</summary>
    public unsafe delegate VkBool32 PFN_vkDebugReportCallbackEXT(
    /// <summary>flags specifies the VkDebugReportFlagBitsEXT that triggered
    /// this callback.</summary>
    VkDebugReportFlagBitsEXT flags,
    /// <summary>objectType is a VkDebugReportObjectTypeEXT value specifying
    /// the type of object being used or created at the time the event was
    /// triggered.</summary>
    VkDebugReportObjectTypeEXT _objectType,
    /// <summary>object is the object where the issue was detected.
    /// If objectType is VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT,
    /// object is undefined.</summary>
    UInt64 _object,
    /// <summary>location is a component (layer, driver, loader) defined value that
    /// specifies the location of the trigger.
    /// This is an optional value.</summary>
    Int32 location,
    /// <summary>messageCode is a layer-defined value indicating what test
    /// triggered this callback.</summary>
    Int32 messageCode,
    /// <summary>pLayerPrefix is a null-terminated string that is an abbreviation
    /// of the name of the component making the callback.
    /// pLayerPrefix is only valid for the duration of the callback.</summary>
    IntPtr pLayerPrefix,
    /// <summary>pMessage is a null-terminated string detailing the trigger
    /// conditions.
    /// pMessage is only valid for the duration of the callback.</summary>
    IntPtr pMessage,
    /// <summary>pUserData is the user data given when the
    /// VkDebugReportCallbackEXT was created.</summary>
    IntPtr pUserData);
    // PFN: 2
    /// <summary>PFN_vkDebugUtilsMessengerCallbackEXT - Application-defined debug messenger callback function</summary>
    public unsafe delegate VkBool32 PFN_vkDebugUtilsMessengerCallbackEXT(
    /// <summary>messageSeverity specifies the
    /// VkDebugUtilsMessageSeverityFlagBitsEXT that triggered this
    /// callback.</summary>
    VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity,
    /// <summary>messageTypes is a bitmask of
    /// VkDebugUtilsMessageTypeFlagBitsEXT specifying which type of
    /// event(s) triggered this callback.</summary>
    VkDebugUtilsMessageTypeFlagBitsEXT messageTypes,
        /// <summary>pCallbackData contains all the callback related data in the
        /// VkDebugUtilsMessengerCallbackDataEXT structure.</summary>
        /*-const-*/ VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
    /// <summary>pUserData is the user data provided when the
    /// VkDebugUtilsMessengerEXT was created.</summary>
    void* pUserData);
    // PFN: 3
    /// <summary>PFN_vkFreeFunction - Application-defined memory free function</summary>
    public unsafe delegate void PFN_vkFreeFunction(
    /// <summary>pUserData is the value specified for
    /// VkAllocationCallbacks::pUserData in the allocator specified
    /// by the application.</summary>
    void* pUserData,
    /// <summary>pMemory is the allocation to be freed.</summary>
    void* pMemory);
    // PFN: 4
    /// <summary>PFN_vkInternalAllocationNotification - Application-defined memory allocation notification function</summary>
    public unsafe delegate void PFN_vkInternalAllocationNotification(
    /// <summary>pUserData is the value specified for
    /// VkAllocationCallbacks::pUserData in the allocator specified
    /// by the application.</summary>
    void* pUserData,
    /// <summary>size is the requested size of an allocation.</summary>
    Int32 size,
    /// <summary>allocationType is a VkInternalAllocationType value
    /// specifying the requested type of an allocation.</summary>
    VkInternalAllocationType allocationType,
    /// <summary>allocationScope is a VkSystemAllocationScope value
    /// specifying the allocation scope of the lifetime of the allocation, as
    /// described here.</summary>
    VkSystemAllocationScope allocationScope);
    // PFN: 5
    /// <summary>PFN_vkInternalFreeNotification - Application-defined memory free notification function</summary>
    public unsafe delegate void PFN_vkInternalFreeNotification(
    /// <summary>pUserData is the value specified for
    /// VkAllocationCallbacks::pUserData in the allocator specified
    /// by the application.</summary>
    void* pUserData,
    /// <summary>size is the requested size of an allocation.</summary>
    Int32 size,
    /// <summary>allocationType is a VkInternalAllocationType value
    /// specifying the requested type of an allocation.</summary>
    VkInternalAllocationType allocationType,
    /// <summary>allocationScope is a VkSystemAllocationScope value
    /// specifying the allocation scope of the lifetime of the allocation, as
    /// described here.</summary>
    VkSystemAllocationScope allocationScope);
    // PFN: 6
    /// <summary>PFN_vkReallocationFunction - Application-defined memory reallocation function</summary>
    public unsafe delegate void* PFN_vkReallocationFunction(
    /// <summary>pUserData is the value specified for
    /// VkAllocationCallbacks::pUserData in the allocator specified
    /// by the application.</summary>
    void* pUserData,
    /// <summary>pOriginal
    ///   must be either NULL or a pointer previously returned
    /// by pfnReallocation or pfnAllocation of the same allocator.</summary>
    void* pOriginal,
    /// <summary>size is the size in bytes of the requested allocation.</summary>
    Int32 size,
    /// <summary>alignment is the requested alignment of the allocation in bytes
    /// and must be a power of two.</summary>
    Int32 alignment,
    /// <summary>allocationScope is a VkSystemAllocationScope value
    /// specifying the allocation scope of the lifetime of the allocation, as
    /// described here.</summary>
    VkSystemAllocationScope allocationScope);
    // PFN: 7
    /// <summary>PFN_vkVoidFunction - Dummy function pointer type returned by queries</summary>
    public unsafe delegate void PFN_vkVoidFunction(
    );

}
