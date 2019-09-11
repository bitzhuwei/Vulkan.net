using System;

namespace ApiSpec.Generated {
    // Object Handles: 0
    /// <summary>VkAccelerationStructureNV - Opaque handle to an acceleration structure object
    /// <para>Acceleration structures are an opaque structure that is built by theimplementation to more efficiently perform spatial queries on the providedgeometric data.For this extension, an acceleration structure is either a top-levelacceleration structure containing a set of bottom-level accelerationstructures or a bottom-level acceleration structure containing either a setof axis-aligned bounding boxes for custom geometry or a set of triangles.</para>
    /// <para>Each instance in the top-level acceleration structure contains a referenceto a bottom-level acceleration structure as well as an instance transformplus information required to index into the shader bindings.The top-level acceleration structure is what is bound to the accelerationdescriptor to trace inside the shader in the ray tracing pipeline.</para>
    /// <para>Acceleration structures are represented by VkAccelerationStructureNVhandles:</para>
    /// </summary>
    public struct VkAccelerationStructureNV {
        public UInt64 handle;
    }

    // Object Handles: 1
    /// <summary>VkBuffer - Opaque handle to a buffer object
    /// <para>Buffers represent linear arrays of data which are used for various purposesby binding them to a graphics or compute pipeline via descriptor sets or viacertain commands, or by directly specifying them as parameters to certaincommands.</para>
    /// <para>Buffers are represented by VkBuffer handles:</para>
    /// </summary>
    public struct VkBuffer {
        public UInt64 handle;
    }

    // Object Handles: 2
    /// <summary>VkBufferView - Opaque handle to a buffer view object
    /// <para>A buffer view represents a contiguous range of a buffer and a specificformat to be used to interpret the data.Buffer views are used to enable shaders to access buffer contentsinterpreted as formatted data.In order to create a valid buffer view, the buffer must have been createdwith at least one of the following usage flags:</para>
    /// <para> VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT </para>
    /// <para> VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT </para>
    /// <para>Buffer views are represented by VkBufferView handles:</para>
    /// </summary>
    public struct VkBufferView {
        public UInt64 handle;
    }

    // Object Handles: 3
    /// <summary>VkCommandBuffer - Opaque handle to a command buffer object
    /// <para>Command buffers are objects used to record commands which can besubsequently submitted to a device queue for execution.There are two levels of command buffers - primary command buffers, whichcan execute secondary command buffers, and which are submitted to queues,and secondary command buffers, which can be executed by primary commandbuffers, and which are not directly submitted to queues.</para>
    /// <para>Command buffers are represented by VkCommandBuffer handles:</para>
    /// </summary>
    public struct VkCommandBuffer {
        public UInt64 handle;
    }

    // Object Handles: 4
    /// <summary>VkCommandPool - Opaque handle to a command pool object
    /// <para>Command pools are opaque objects that command buffer memory is allocatedfrom, and which allow the implementation to amortize the cost of resourcecreation across multiple command buffers.Command pools are externally synchronized, meaning that a command pool mustnot be used concurrently in multiple threads.That includes use via recording commands on any command buffers allocatedfrom the pool, as well as operations that allocate, free, and reset commandbuffers or the pool itself.</para>
    /// <para>Command pools are represented by VkCommandPool handles:</para>
    /// </summary>
    public struct VkCommandPool {
        public UInt64 handle;
    }

    // Object Handles: 5
    /// <summary>VkDebugReportCallbackEXT - Opaque handle to a debug report callback object
    /// <para>Debug report callbacks are represented by VkDebugReportCallbackEXThandles:</para>
    /// </summary>
    public struct VkDebugReportCallbackEXT {
        public UInt64 handle;
    }

    // Object Handles: 6
    /// <summary>VkDebugUtilsMessengerEXT - Opaque handle to a debug messenger object
    /// <para>A VkDebugUtilsMessengerEXT is a messenger object which handles passingalong debug messages to a provided debug callback.</para>
    /// </summary>
    public struct VkDebugUtilsMessengerEXT {
        public UInt64 handle;
    }

    // Object Handles: 7
    /// <summary>VkDescriptorPool - Opaque handle to a descriptor pool object
    /// <para>A descriptor pool maintains a pool of descriptors, from which descriptorsets are allocated.Descriptor pools are externally synchronized, meaning that the applicationmust not allocate and/or free descriptor sets from the same pool inmultiple threads simultaneously.</para>
    /// <para>Descriptor pools are represented by VkDescriptorPool handles:</para>
    /// </summary>
    public struct VkDescriptorPool {
        public UInt64 handle;
    }

    // Object Handles: 8
    /// <summary>VkDescriptorSet - Opaque handle to a descriptor set object
    /// <para>Descriptor sets are allocated from descriptor pool objects, and arerepresented by VkDescriptorSet handles:</para>
    /// </summary>
    public struct VkDescriptorSet {
        public UInt64 handle;
    }

    // Object Handles: 9
    /// <summary>VkDescriptorSetLayout - Opaque handle to a descriptor set layout object
    /// <para>A descriptor set layout object is defined by an array of zero or moredescriptor bindings.Each individual descriptor binding is specified by a descriptor type, acount (array size) of the number of descriptors in the binding, a set ofshader stages that can access the binding, and (if using immutablesamplers) an array of sampler descriptors.</para>
    /// <para>Descriptor set layout objects are represented by VkDescriptorSetLayouthandles:</para>
    /// </summary>
    public struct VkDescriptorSetLayout {
        public UInt64 handle;
    }

    // Object Handles: 10
    /// <summary>VkDescriptorUpdateTemplate - Opaque handle to a descriptor update template
    /// <para>A descriptor update template specifies a mapping from descriptor updateinformation in host memory to descriptors in a descriptor set.It is designed to avoid passing redundant information to the driver whenfrequently updating the same set of descriptors in descriptor sets.</para>
    /// <para>Descriptor update template objects are represented byVkDescriptorUpdateTemplate handles:</para>
    /// <para>or the equivalent</para>
    /// </summary>
    public struct VkDescriptorUpdateTemplate {
        public UInt64 handle;
    }

    // Object Handles: 11
    /// <summary>VkDevice - Opaque handle to a device object
    /// <para>Logical devices are represented by VkDevice handles:</para>
    /// </summary>
    public struct VkDevice {
        public UInt64 handle;
    }

    // Object Handles: 12
    /// <summary>VkDeviceMemory - Opaque handle to a device memory object
    /// <para>A Vulkan device operates on data in device memory via memory objects thatare represented in the API by a VkDeviceMemory handle:</para>
    /// </summary>
    public struct VkDeviceMemory {
        public UInt64 handle;
    }

    // Object Handles: 13
    /// <summary>VkDisplayKHR - Opaque handle to a display object
    /// <para>Displays are represented by VkDisplayKHR handles:</para>
    /// </summary>
    public struct VkDisplayKHR {
        public UInt64 handle;
    }

    // Object Handles: 14
    /// <summary>VkDisplayModeKHR - Opaque handle to a display mode object
    /// <para>Display modes are represented by VkDisplayModeKHR handles:</para>
    /// </summary>
    public struct VkDisplayModeKHR {
        public UInt64 handle;
    }

    // Object Handles: 15
    /// <summary>VkEvent - Opaque handle to an event object
    /// <para>Events are a synchronization primitive that can be used to insert afine-grained dependency between commands submitted to the same queue, orbetween the host and a queue.Events must not be used to insert a dependency between commands submittedto different queues.Events have two states - signaled and unsignaled.An application can signal an event, or unsignal it, on either the host orthe device.A device can wait for an event to become signaled before executing furtheroperations.No command exists to wait for an event to become signaled on the host, butthe current state of an event can be queried.</para>
    /// <para>Events are represented by VkEvent handles:</para>
    /// </summary>
    public struct VkEvent {
        public UInt64 handle;
    }

    // Object Handles: 16
    /// <summary>VkFence - Opaque handle to a fence object
    /// <para>Fences are a synchronization primitive that can be used to insert adependency from a queue to the host.Fences have two states - signaled and unsignaled.A fence can be signaled as part of the execution of aqueue submission command.Fences can be unsignaled on the host with vkResetFences.Fences can be waited on by the host with the vkWaitForFences command,and the current state can be queried with vkGetFenceStatus.</para>
    /// <para>As with most objects in Vulkan, fences are an interface to internal datawhich is typically opaque to applications.This internal data is referred to as a fence’s payload.</para>
    /// <para>However, in order to enable communication with agents outside of the currentdevice, it is necessary to be able to export that payload to a commonlyunderstood format, and subsequently import from that format as well.</para>
    /// <para>The internal data of a fence may include a reference to any resources andpending work associated with signal or unsignal operations performed on thatfence object.Mechanisms to import and export that internal data to and from fences areprovided below.These mechanisms indirectly enable applications to share fence state betweentwo or more fences and other synchronization primitives across process andAPI boundaries.</para>
    /// <para>Fences are represented by VkFence handles:</para>
    /// </summary>
    public struct VkFence {
        public UInt64 handle;
    }

    // Object Handles: 17
    /// <summary>VkFramebuffer - Opaque handle to a framebuffer object
    /// <para>Render passes operate in conjunction with framebuffers.Framebuffers represent a collection of specific memory attachments that arender pass instance uses.</para>
    /// <para>Framebuffers are represented by VkFramebuffer handles:</para>
    /// </summary>
    public struct VkFramebuffer {
        public UInt64 handle;
    }

    // Object Handles: 18
    /// <summary>VkImage - Opaque handle to an image object
    /// <para>Images represent multidimensional - up to 3 - arrays of data which can beused for various purposes (e.g. attachments, textures), by binding them to agraphics or compute pipeline via descriptor sets, or by directly specifyingthem as parameters to certain commands.</para>
    /// <para>Images are represented by VkImage handles:</para>
    /// </summary>
    public struct VkImage {
        public UInt64 handle;
    }

    // Object Handles: 19
    /// <summary>VkImageView - Opaque handle to an image view object
    /// <para>Image objects are not directly accessed by pipeline shaders for reading orwriting image data.Instead, image views representing contiguous ranges of the imagesubresources and containing additional metadata are used for that purpose.Views must be created on images of compatible types, and must represent avalid subset of image subresources.</para>
    /// <para>Image views are represented by VkImageView handles:</para>
    /// </summary>
    public struct VkImageView {
        public UInt64 handle;
    }

    // Object Handles: 20
    /// <summary>VkIndirectCommandsLayoutNVX - Opaque handle to an indirect commands layout object
    /// <para>The device-side command generation happens through an iterative processingof an atomic sequence comprised of command tokens, which are represented by:</para>
    /// </summary>
    public struct VkIndirectCommandsLayoutNVX {
        public UInt64 handle;
    }

    // Object Handles: 21
    /// <summary>VkInstance - Opaque handle to an instance object
    /// <para>There is no global state in Vulkan and all per-application state is storedin a VkInstance object.Creating a VkInstance object initializes the Vulkan library and allowsthe application to pass information about itself to the implementation.</para>
    /// <para>Instances are represented by VkInstance handles:</para>
    /// </summary>
    public struct VkInstance {
        public UInt64 handle;
    }

    // Object Handles: 22
    /// <summary>VkObjectTableNVX - Opaque handle to an object table
    /// <para>The device-side bindings are registered inside a table:</para>
    /// </summary>
    public struct VkObjectTableNVX {
        public UInt64 handle;
    }

    // Object Handles: 23
    /// <summary>VkPhysicalDevice - Opaque handle to a physical device object
    /// <para>Vulkan separates the concept of physical and logical devices.A physical device usually represents a single complete implementation ofVulkan (excluding instance-level functionality) available to the host, ofwhich there are a finite number.A logical device represents an instance of that implementation with its ownstate and resources independent of other logical devices.</para>
    /// <para>Physical devices are represented by VkPhysicalDevice handles:</para>
    /// </summary>
    public struct VkPhysicalDevice {
        public UInt64 handle;
    }

    // Object Handles: 24
    /// <summary>VkPipeline - Opaque handle to a pipeline object
    /// <para>Compute, graphics, and ray tracing pipelines are each represented byVkPipeline handles:</para>
    /// </summary>
    public struct VkPipeline {
        public UInt64 handle;
    }

    // Object Handles: 25
    /// <summary>VkPipelineCache - Opaque handle to a pipeline cache object
    /// <para>Pipeline cache objects allow the result of pipeline construction to bereused between pipelines and between runs of an application.Reuse between pipelines is achieved by passing the same pipeline cacheobject when creating multiple related pipelines.Reuse across runs of an application is achieved by retrieving pipeline cachecontents in one run of an application, saving the contents, and using themto preinitialize a pipeline cache on a subsequent run.The contents of the pipeline cache objects are managed by theimplementation.Applications can manage the host memory consumed by a pipeline cache objectand control the amount of data retrieved from a pipeline cache object.</para>
    /// <para>Pipeline cache objects are represented by VkPipelineCache handles:</para>
    /// </summary>
    public struct VkPipelineCache {
        public UInt64 handle;
    }

    // Object Handles: 26
    /// <summary>VkPipelineLayout - Opaque handle to a pipeline layout object
    /// <para>Access to descriptor sets from a pipeline is accomplished through apipeline layout.Zero or more descriptor set layouts and zero or more push constant rangesare combined to form a pipeline layout object which describes the completeset of resources that can be accessed by a pipeline.The pipeline layout represents a sequence of descriptor sets with eachhaving a specific layout.This sequence of layouts is used to determine the interface between shaderstages and shader resources.Each pipeline is created using a pipeline layout.</para>
    /// <para>Pipeline layout objects are represented by VkPipelineLayout handles:</para>
    /// </summary>
    public struct VkPipelineLayout {
        public UInt64 handle;
    }

    // Object Handles: 27
    /// <summary>VkQueryPool - Opaque handle to a query pool object
    /// <para>Queries are managed using query pool objects.Each query pool is a collection of a specific number of queries of aparticular type.</para>
    /// <para>Query pools are represented by VkQueryPool handles:</para>
    /// </summary>
    public struct VkQueryPool {
        public UInt64 handle;
    }

    // Object Handles: 28
    /// <summary>VkQueue - Opaque handle to a queue object
    /// <para>Creating a logical device also creates the queues associated with thatdevice.The queues to create are described by a set of VkDeviceQueueCreateInfostructures that are passed to vkCreateDevice inpQueueCreateInfos.</para>
    /// <para>Queues are represented by VkQueue handles:</para>
    /// </summary>
    public struct VkQueue {
        public UInt64 handle;
    }

    // Object Handles: 29
    /// <summary>VkRenderPass - Opaque handle to a render pass object
    /// <para>A render pass represents a collection of attachments, subpasses, anddependencies between the subpasses, and describes how the attachments areused over the course of the subpasses.The use of a render pass in a command buffer is a render pass instance.</para>
    /// <para>Render passes are represented by VkRenderPass handles:</para>
    /// </summary>
    public struct VkRenderPass {
        public UInt64 handle;
    }

    // Object Handles: 30
    /// <summary>VkSampler - Opaque handle to a sampler object
    /// <para> VkSampler objects represent the state of an image sampler which isused by the implementation to read image data and apply filtering and othertransformations for the shader.</para>
    /// <para>Samplers are represented by VkSampler handles:</para>
    /// </summary>
    public struct VkSampler {
        public UInt64 handle;
    }

    // Object Handles: 31
    /// <summary>VkSamplerYcbcrConversion - Opaque handle to a device-specific sampler Y’C<sub>B</sub>C<sub>R</sub> conversion description
    /// <para>A sampler Y’CBCR conversion is an opaque representation of adevice-specific sampler Y’CBCR conversion description, represented as aVkSamplerYcbcrConversion handle:</para>
    /// <para>or the equivalent</para>
    /// </summary>
    public struct VkSamplerYcbcrConversion {
        public UInt64 handle;
    }

    // Object Handles: 32
    /// <summary>VkSemaphore - Opaque handle to a semaphore object
    /// <para>Semaphores are a synchronization primitive that can be used to insert adependency between batches submitted to queues.Semaphores have two states - signaled and unsignaled.The state of a semaphore can be signaled after execution of a batch ofcommands is completed.A batch can wait for a semaphore to become signaled before it beginsexecution, and the semaphore is also unsignaled before the batch beginsexecution.</para>
    /// <para>As with most objects in Vulkan, semaphores are an interface to internal datawhich is typically opaque to applications.This internal data is referred to as a semaphore’s payload.</para>
    /// <para>However, in order to enable communication with agents outside of the currentdevice, it is necessary to be able to export that payload to a commonlyunderstood format, and subsequently import from that format as well.</para>
    /// <para>The internal data of a semaphore may include a reference to any resourcesand pending work associated with signal or unsignal operations performed onthat semaphore object.Mechanisms to import and export that internal data to and from semaphoresare provided below.These mechanisms indirectly enable applications to share semaphore statebetween two or more semaphores and other synchronization primitives acrossprocess and API boundaries.</para>
    /// <para>Semaphores are represented by VkSemaphore handles:</para>
    /// </summary>
    public struct VkSemaphore {
        public UInt64 handle;
    }

    // Object Handles: 33
    /// <summary>VkShaderModule - Opaque handle to a shader module object
    /// <para> Shader modules contain shader code and one or more entry points.Shaders are selected from a shader module by specifying an entry point aspart of pipeline creation.The stages of a pipeline can use shaders that come from different modules.The shader code defining a shader module must be in the SPIR-V format, asdescribed by the Vulkan Environment for SPIR-V appendix.</para>
    /// <para>Shader modules are represented by VkShaderModule handles:</para>
    /// </summary>
    public struct VkShaderModule {
        public UInt64 handle;
    }

    // Object Handles: 34
    /// <summary>VkSurfaceKHR - Opaque handle to a surface object
    /// <para>Native platform surface or window objects are abstracted by surface objects,which are represented by VkSurfaceKHR handles:</para>
    /// </summary>
    public struct VkSurfaceKHR {
        public UInt64 handle;
    }

    // Object Handles: 35
    /// <summary>VkSwapchainKHR - Opaque handle to a swapchain object
    /// <para>A swapchain object (a.k.a.swapchain) provides the ability to present rendering results to a surface.Swapchain objects are represented by VkSwapchainKHR handles:</para>
    /// </summary>
    public struct VkSwapchainKHR {
        public UInt64 handle;
    }

    // Object Handles: 36
    /// <summary>VkValidationCacheEXT - Opaque handle to a validation cache object
    /// <para>Validation cache objects allow the result of internal validation to bereused, both within a single application run and between multiple runs.Reuse within a single run is achieved by passing the same validation cacheobject when creating supported Vulkan objects.Reuse across runs of an application is achieved by retrieving validationcache contents in one run of an application, saving the contents, and usingthem to preinitialize a validation cache on a subsequent run.The contents of the validation cache objects are managed by the validationlayers.Applications can manage the host memory consumed by a validation cacheobject and control the amount of data retrieved from a validation cacheobject.</para>
    /// <para>Validation cache objects are represented by VkValidationCacheEXThandles:</para>
    /// </summary>
    public struct VkValidationCacheEXT {
        public UInt64 handle;
    }


}
