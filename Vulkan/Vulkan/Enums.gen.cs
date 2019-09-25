using System;

namespace Vulkan {
    // Enum: 0
    /// <summary>VkAccelerationStructureMemoryRequirementsTypeNV - Acceleration structure memory requirement type</summary>
    public enum VkAccelerationStructureMemoryRequirementsTypeNV {
        ObjectNv = 0,
        BuildScratchNv = 1,
        UpdateScratchNv = 2,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 1
    /// <summary>VkAccelerationStructureTypeNV - Type of acceleration structure</summary>
    public enum VkAccelerationStructureTypeNV {
        TopLevelNv = 0,
        BottomLevelNv = 1,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 2
    /// <summary>VkAccessFlagBits - Bitmask specifying memory access types that will participate in a memory dependency</summary>
    [Flags]
    public enum VkAccessFlagBits {
        IndirectCommandRead = 0x00000001,
        IndexRead = 0x00000002,
        VertexAttributeRead = 0x00000004,
        UniformRead = 0x00000008,
        InputAttachmentRead = 0x00000010,
        ShaderRead = 0x00000020,
        ShaderWrite = 0x00000040,
        ColorAttachmentRead = 0x00000080,
        ColorAttachmentWrite = 0x00000100,
        DepthStencilAttachmentRead = 0x00000200,
        DepthStencilAttachmentWrite = 0x00000400,
        TransferRead = 0x00000800,
        TransferWrite = 0x00001000,
        HostRead = 0x00002000,
        HostWrite = 0x00004000,
        MemoryRead = 0x00008000,
        MemoryWrite = 0x00010000,
        TransformFeedbackWriteExt = 0x02000000,
        TransformFeedbackCounterReadExt = 0x04000000,
        TransformFeedbackCounterWriteExt = 0x08000000,
        ConditionalRenderingReadExt = 0x00100000,
        CommandProcessReadNvx = 0x00020000,
        CommandProcessWriteNvx = 0x00040000,
        ColorAttachmentReadNoncoherentExt = 0x00080000,
        ShadingRateImageReadNv = 0x00800000,
        AccelerationStructureReadNv = 0x00200000,
        AccelerationStructureWriteNv = 0x00400000,
        FragmentDensityMapReadExt = 0x01000000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 3
    /// <summary>VkAttachmentDescriptionFlagBits - Bitmask specifying additional properties of an attachment</summary>
    [Flags]
    public enum VkAttachmentDescriptionFlagBits {
        MayAlias = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 4
    /// <summary>VkAttachmentLoadOp - Specify how contents of an attachment are treated at the beginning of a subpass</summary>
    public enum VkAttachmentLoadOp {
        Load = 0,
        Clear = 1,
        DontCare = 2,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 5
    /// <summary>VkAttachmentStoreOp - Specify how contents of an attachment are treated at the end of a subpass</summary>
    public enum VkAttachmentStoreOp {
        Store = 0,
        DontCare = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 6
    /// <summary>VkBlendFactor - Framebuffer blending factors</summary>
    public enum VkBlendFactor {
        Zero = 0,
        One = 1,
        SrcColor = 2,
        OneMinusSrcColor = 3,
        DstColor = 4,
        OneMinusDstColor = 5,
        SrcAlpha = 6,
        OneMinusSrcAlpha = 7,
        DstAlpha = 8,
        OneMinusDstAlpha = 9,
        ConstantColor = 10,
        OneMinusConstantColor = 11,
        ConstantAlpha = 12,
        OneMinusConstantAlpha = 13,
        SrcAlphaSaturate = 14,
        Src1Color = 15,
        OneMinusSrc1Color = 16,
        Src1Alpha = 17,
        OneMinusSrc1Alpha = 18,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 7
    /// <summary>VkBlendOp - Framebuffer blending operations</summary>
    public enum VkBlendOp {
        Add = 0,
        Subtract = 1,
        ReverseSubtract = 2,
        Min = 3,
        Max = 4,
        ZeroExt = 1000148000,
        SrcExt = 1000148001,
        DstExt = 1000148002,
        SrcOverExt = 1000148003,
        DstOverExt = 1000148004,
        SrcInExt = 1000148005,
        DstInExt = 1000148006,
        SrcOutExt = 1000148007,
        DstOutExt = 1000148008,
        SrcAtopExt = 1000148009,
        DstAtopExt = 1000148010,
        XorExt = 1000148011,
        MultiplyExt = 1000148012,
        ScreenExt = 1000148013,
        OverlayExt = 1000148014,
        DarkenExt = 1000148015,
        LightenExt = 1000148016,
        ColordodgeExt = 1000148017,
        ColorburnExt = 1000148018,
        HardlightExt = 1000148019,
        SoftlightExt = 1000148020,
        DifferenceExt = 1000148021,
        ExclusionExt = 1000148022,
        InvertExt = 1000148023,
        InvertRgbExt = 1000148024,
        LineardodgeExt = 1000148025,
        LinearburnExt = 1000148026,
        VividlightExt = 1000148027,
        LinearlightExt = 1000148028,
        PinlightExt = 1000148029,
        HardmixExt = 1000148030,
        HslHueExt = 1000148031,
        HslSaturationExt = 1000148032,
        HslColorExt = 1000148033,
        HslLuminosityExt = 1000148034,
        PlusExt = 1000148035,
        PlusClampedExt = 1000148036,
        PlusClampedAlphaExt = 1000148037,
        PlusDarkerExt = 1000148038,
        MinusExt = 1000148039,
        MinusClampedExt = 1000148040,
        ContrastExt = 1000148041,
        InvertOvgExt = 1000148042,
        RedExt = 1000148043,
        GreenExt = 1000148044,
        BlueExt = 1000148045,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 8
    /// <summary>VkBlendOverlapEXT - Enumerant specifying the blend overlap parameter</summary>
    public enum VkBlendOverlapEXT {
        UncorrelatedExt = 0,
        DisjointExt = 1,
        ConjointExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 9
    /// <summary>VkBorderColor - Specify border color used for texture lookups</summary>
    public enum VkBorderColor {
        FloatTransparentBlack = 0,
        IntTransparentBlack = 1,
        FloatOpaqueBlack = 2,
        IntOpaqueBlack = 3,
        FloatOpaqueWhite = 4,
        IntOpaqueWhite = 5,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 10
    /// <summary>VkBufferCreateFlagBits - Bitmask specifying additional parameters of a buffer</summary>
    [Flags]
    public enum VkBufferCreateFlagBits {
        SparseBinding = 0x00000001,
        SparseResidency = 0x00000002,
        SparseAliased = 0x00000004,
        Protected = 0x00000008,
        DeviceAddressCaptureReplayExt = 0x00000010,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 11
    /// <summary>VkBufferUsageFlagBits - Bitmask specifying allowed usage of a buffer</summary>
    [Flags]
    public enum VkBufferUsageFlagBits {
        TransferSrc = 0x00000001,
        TransferDst = 0x00000002,
        UniformTexelBuffer = 0x00000004,
        StorageTexelBuffer = 0x00000008,
        UniformBuffer = 0x00000010,
        StorageBuffer = 0x00000020,
        IndexBuffer = 0x00000040,
        VertexBuffer = 0x00000080,
        IndirectBuffer = 0x00000100,
        TransformFeedbackBufferExt = 0x00000800,
        TransformFeedbackCounterBufferExt = 0x00001000,
        ConditionalRenderingExt = 0x00000200,
        RayTracingNv = 0x00000400,
        ShaderDeviceAddressExt = 0x00020000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 12
    /// <summary>VkBuildAccelerationStructureFlagBitsNV - Bitmask specifying additional parameters for acceleration structure builds</summary>
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsNV {
        AllowUpdateNv = 0x00000001,
        AllowCompactionNv = 0x00000002,
        PreferFastTraceNv = 0x00000004,
        PreferFastBuildNv = 0x00000008,
        LowMemoryNv = 0x00000010,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 13
    /// <summary>VkChromaLocation - Position of downsampled chroma samples</summary>
    public enum VkChromaLocation {
        CositedEven = 0,
        Midpoint = 1,
        CositedEvenKHR = CositedEven,
        MidpointKHR = Midpoint,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 14
    /// <summary>VkCoarseSampleOrderTypeNV - Shading rate image sample ordering types</summary>
    public enum VkCoarseSampleOrderTypeNV {
        DefaultNv = 0,
        CustomNv = 1,
        PixelMajorNv = 2,
        SampleMajorNv = 3,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 15
    /// <summary>VkColorComponentFlagBits - Bitmask controlling which components are written to the framebuffer</summary>
    [Flags]
    public enum VkColorComponentFlagBits {
        R = 0x00000001,
        G = 0x00000002,
        B = 0x00000004,
        A = 0x00000008,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 16
    /// <summary>VkColorSpaceKHR - supported color space of the presentation engine</summary>
    public enum VkColorSpaceKHR {
        SrgbNonlinearKHR = 0,
        DisplayP3NonlinearExt = 1000104001,
        ExtendedSrgbLinearExt = 1000104002,
        DciP3LinearExt = 1000104003,
        DciP3NonlinearExt = 1000104004,
        Bt709LinearExt = 1000104005,
        Bt709NonlinearExt = 1000104006,
        Bt2020LinearExt = 1000104007,
        Hdr10St2084Ext = 1000104008,
        DolbyvisionExt = 1000104009,
        Hdr10HlgExt = 1000104010,
        AdobergbLinearExt = 1000104011,
        AdobergbNonlinearExt = 1000104012,
        PassThroughExt = 1000104013,
        ExtendedSrgbNonlinearExt = 1000104014,
        DisplayNativeAmd = 1000213000,
        // [Duplicated] SrgbNonlinearKHR = SrgbNonlinearKHR,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 17
    /// <summary>VkCommandBufferLevel - Enumerant specifying a command buffer level</summary>
    public enum VkCommandBufferLevel {
        Primary = 0,
        Secondary = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 18
    /// <summary>VkCommandBufferResetFlagBits - Bitmask controlling behavior of a command buffer reset</summary>
    [Flags]
    public enum VkCommandBufferResetFlagBits {
        ReleaseResources = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 19
    /// <summary>VkCommandBufferUsageFlagBits - Bitmask specifying usage behavior for command buffer</summary>
    [Flags]
    public enum VkCommandBufferUsageFlagBits {
        OneTimeSubmit = 0x00000001,
        RenderPassContinue = 0x00000002,
        SimultaneousUse = 0x00000004,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 20
    /// <summary>VkCommandPoolCreateFlagBits - Bitmask specifying usage behavior for a command pool</summary>
    [Flags]
    public enum VkCommandPoolCreateFlagBits {
        Transient = 0x00000001,
        ResetCommandBuffer = 0x00000002,
        Protected = 0x00000004,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 21
    /// <summary>VkCommandPoolResetFlagBits - Bitmask controlling behavior of a command pool reset</summary>
    [Flags]
    public enum VkCommandPoolResetFlagBits {
        ReleaseResources = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 22
    /// <summary>VkCompareOp - Stencil comparison function</summary>
    public enum VkCompareOp {
        Never = 0,
        Less = 1,
        Equal = 2,
        LessOrEqual = 3,
        Greater = 4,
        NotEqual = 5,
        GreaterOrEqual = 6,
        Always = 7,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 23
    /// <summary>VkComponentSwizzle - Specify how a component is swizzled</summary>
    public enum VkComponentSwizzle {
        Identity = 0,
        Zero = 1,
        One = 2,
        R = 3,
        G = 4,
        B = 5,
        A = 6,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 24
    /// <summary>VkComponentTypeNV - Specify SPIR-V cooperative matrix component type</summary>
    public enum VkComponentTypeNV {
        Float16Nv = 0,
        Float32Nv = 1,
        Float64Nv = 2,
        Sint8Nv = 3,
        Sint16Nv = 4,
        Sint32Nv = 5,
        Sint64Nv = 6,
        Uint8Nv = 7,
        Uint16Nv = 8,
        Uint32Nv = 9,
        Uint64Nv = 10,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 25
    /// <summary>VkCompositeAlphaFlagBitsKHR - alpha compositing modes supported on a device</summary>
    [Flags]
    public enum VkCompositeAlphaFlagBitsKHR {
        OpaqueKHR = 0x00000001,
        PreMultipliedKHR = 0x00000002,
        PostMultipliedKHR = 0x00000004,
        InheritKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 26
    /// <summary>VkConditionalRenderingFlagBitsEXT - Specify the behavior of conditional rendering</summary>
    [Flags]
    public enum VkConditionalRenderingFlagBitsEXT {
        InvertedExt = 0x00000001,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 27
    /// <summary>VkConservativeRasterizationModeEXT - Specify the conservative rasterization mode</summary>
    public enum VkConservativeRasterizationModeEXT {
        DisabledExt = 0,
        OverestimateExt = 1,
        UnderestimateExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 28
    /// <summary>VkCopyAccelerationStructureModeNV - Acceleration structure copy mode</summary>
    public enum VkCopyAccelerationStructureModeNV {
        CloneNv = 0,
        CompactNv = 1,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 29
    /// <summary>VkCoverageModulationModeNV - Specify the discard rectangle mode</summary>
    public enum VkCoverageModulationModeNV {
        NoneNv = 0,
        RgbNv = 1,
        AlphaNv = 2,
        RgbaNv = 3,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 30
    /// <summary>VkCullModeFlagBits - Bitmask controlling triangle culling</summary>
    [Flags]
    public enum VkCullModeFlagBits {
        None = 0,
        Front = 0x00000001,
        Back = 0x00000002,
        FrontAndBack = 0x00000003,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 31
    /// <summary>VkDebugReportFlagBitsEXT - Bitmask specifying events which cause a debug report callback</summary>
    [Flags]
    public enum VkDebugReportFlagBitsEXT {
        InformationExt = 0x00000001,
        WarningExt = 0x00000002,
        PerformanceWarningExt = 0x00000004,
        ErrorExt = 0x00000008,
        DebugExt = 0x00000010,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 32
    /// <summary>VkDebugReportObjectTypeEXT - Specify the type of an object handle</summary>
    public enum VkDebugReportObjectTypeEXT {
        UnknownExt = 0,
        InstanceExt = 1,
        PhysicalDeviceExt = 2,
        DeviceExt = 3,
        QueueExt = 4,
        SemaphoreExt = 5,
        CommandBufferExt = 6,
        FenceExt = 7,
        DeviceMemoryExt = 8,
        BufferExt = 9,
        ImageExt = 10,
        EventExt = 11,
        QueryPoolExt = 12,
        BufferViewExt = 13,
        ImageViewExt = 14,
        ShaderModuleExt = 15,
        PipelineCacheExt = 16,
        PipelineLayoutExt = 17,
        RenderPassExt = 18,
        PipelineExt = 19,
        DescriptorSetLayoutExt = 20,
        SamplerExt = 21,
        DescriptorPoolExt = 22,
        DescriptorSetExt = 23,
        FramebufferExt = 24,
        CommandPoolExt = 25,
        SurfaceKhrExt = 26,
        SwapchainKhrExt = 27,
        DebugReportCallbackExtExt = 28,
        DisplayKhrExt = 29,
        DisplayModeKhrExt = 30,
        ObjectTableNvxExt = 31,
        IndirectCommandsLayoutNvxExt = 32,
        ValidationCacheExtExt = 33,
        SamplerYcbcrConversionExt = 1000156000,
        DescriptorUpdateTemplateExt = 1000085000,
        AccelerationStructureNvExt = 1000165000,
        DebugReportExt = DebugReportCallbackExtExt,
        ValidationCacheExt = ValidationCacheExtExt,
        DescriptorUpdateTemplateKhrExt = DescriptorUpdateTemplateExt,
        SamplerYcbcrConversionKhrExt = SamplerYcbcrConversionExt,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 33
    /// <summary>VkDebugUtilsMessageSeverityFlagBitsEXT - Bitmask specifying which severities of events cause a debug messenger callback</summary>
    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagBitsEXT {
        VerboseExt = 0x00000001,
        InfoExt = 0x00000010,
        WarningExt = 0x00000100,
        ErrorExt = 0x00001000,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 34
    /// <summary>VkDebugUtilsMessageTypeFlagBitsEXT - Bitmask specifying which types of events cause a debug messenger callback</summary>
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT {
        GeneralExt = 0x00000001,
        ValidationExt = 0x00000002,
        PerformanceExt = 0x00000004,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 35
    /// <summary>VkDependencyFlagBits - Bitmask specifying how execution and memory dependencies are formed</summary>
    [Flags]
    public enum VkDependencyFlagBits {
        ByRegion = 0x00000001,
        DeviceGroup = 0x00000004,
        ViewLocal = 0x00000002,
        ViewLocalKHR = ViewLocal,
        DeviceGroupKHR = DeviceGroup,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 36
    /// <summary>VkDescriptorBindingFlagBitsEXT - Bitmask specifying descriptor set layout binding properties</summary>
    [Flags]
    public enum VkDescriptorBindingFlagBitsEXT {
        UpdateAfterBindExt = 0x00000001,
        UpdateUnusedWhilePendingExt = 0x00000002,
        PartiallyBoundExt = 0x00000004,
        VariableDescriptorCountExt = 0x00000008,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 37
    /// <summary>VkDescriptorPoolCreateFlagBits - Bitmask specifying certain supported operations on a descriptor pool</summary>
    [Flags]
    public enum VkDescriptorPoolCreateFlagBits {
        FreeDescriptorSet = 0x00000001,
        UpdateAfterBindExt = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 38
    /// <summary>VkDescriptorSetLayoutCreateFlagBits - Bitmask specifying descriptor set layout properties</summary>
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits {
        PushDescriptorKHR = 0x00000001,
        UpdateAfterBindPoolExt = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 39
    /// <summary>VkDescriptorType - Specifies the type of a descriptor in a descriptor set</summary>
    public enum VkDescriptorType {
        Sampler = 0,
        CombinedImageSampler = 1,
        SampledImage = 2,
        StorageImage = 3,
        UniformTexelBuffer = 4,
        StorageTexelBuffer = 5,
        UniformBuffer = 6,
        StorageBuffer = 7,
        UniformBufferDynamic = 8,
        StorageBufferDynamic = 9,
        InputAttachment = 10,
        InlineUniformBlockExt = 1000138000,
        AccelerationStructureNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 40
    /// <summary>VkDescriptorUpdateTemplateType - Indicates the valid usage of the descriptor update template</summary>
    public enum VkDescriptorUpdateTemplateType {
        DescriptorSet = 0,
        PushDescriptorsKHR = 1,
        DescriptorSetKHR = DescriptorSet,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 41
    /// <summary>VkDeviceEventTypeEXT - Events that can occur on a device object</summary>
    public enum VkDeviceEventTypeEXT {
        DisplayHotplugExt = 0,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 42
    /// <summary>VkDeviceGroupPresentModeFlagBitsKHR - Bitmask specifying supported device group present modes</summary>
    [Flags]
    public enum VkDeviceGroupPresentModeFlagBitsKHR {
        LocalKHR = 0x00000001,
        RemoteKHR = 0x00000002,
        SumKHR = 0x00000004,
        LocalMultiDeviceKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 43
    /// <summary>VkDeviceQueueCreateFlagBits - Bitmask specifying behavior of the queue</summary>
    [Flags]
    public enum VkDeviceQueueCreateFlagBits {
        Protected = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 44
    /// <summary>VkDiscardRectangleModeEXT - Specify the discard rectangle mode</summary>
    public enum VkDiscardRectangleModeEXT {
        InclusiveExt = 0,
        ExclusiveExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 45
    /// <summary>VkDisplayEventTypeEXT - Events that can occur on a display object</summary>
    public enum VkDisplayEventTypeEXT {
        FirstPixelOutExt = 0,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 46
    /// <summary>VkDisplayPlaneAlphaFlagBitsKHR - Alpha blending type</summary>
    [Flags]
    public enum VkDisplayPlaneAlphaFlagBitsKHR {
        OpaqueKHR = 0x00000001,
        GlobalKHR = 0x00000002,
        PerPixelKHR = 0x00000004,
        PerPixelPremultipliedKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 47
    /// <summary>VkDisplayPowerStateEXT - Possible power states for a display</summary>
    public enum VkDisplayPowerStateEXT {
        OffExt = 0,
        SuspendExt = 1,
        OnExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 48
    /// <summary>VkDriverIdKHR - Khronos driver IDs</summary>
    public enum VkDriverIdKHR {
        AmdProprietaryKHR = 1,
        AmdOpenSourceKHR = 2,
        MesaRadvKHR = 3,
        NvidiaProprietaryKHR = 4,
        IntelProprietaryWindowsKHR = 5,
        IntelOpenSourceMesaKHR = 6,
        ImaginationProprietaryKHR = 7,
        QualcommProprietaryKHR = 8,
        ArmProprietaryKHR = 9,
        GooglePastelKHR = 10,
        GgpProprietaryKHR = 11,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 49
    /// <summary>VkDynamicState - Indicate which dynamic state is taken from dynamic state commands</summary>
    public enum VkDynamicState {
        Viewport = 0,
        Scissor = 1,
        LineWidth = 2,
        DepthBias = 3,
        BlendConstants = 4,
        DepthBounds = 5,
        StencilCompareMask = 6,
        StencilWriteMask = 7,
        StencilReference = 8,
        ViewportWScalingNv = 1000087000,
        DiscardRectangleExt = 1000099000,
        SampleLocationsExt = 1000143000,
        ViewportShadingRatePaletteNv = 1000164004,
        ViewportCoarseSampleOrderNv = 1000164006,
        ExclusiveScissorNv = 1000205001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 50
    /// <summary>VkExternalFenceFeatureFlagBits - Bitfield describing features of an external fence handle type</summary>
    [Flags]
    public enum VkExternalFenceFeatureFlagBits {
        Exportable = 0x00000001,
        Importable = 0x00000002,
        ExportableKHR = Exportable,
        ImportableKHR = Importable,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 51
    /// <summary>VkExternalFenceHandleTypeFlagBits - Bitmask of valid external fence handle types</summary>
    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits {
        OpaqueFd = 0x00000001,
        OpaqueWin32 = 0x00000002,
        OpaqueWin32Kmt = 0x00000004,
        SyncFd = 0x00000008,
        OpaqueFdKHR = OpaqueFd,
        OpaqueWin32KHR = OpaqueWin32,
        OpaqueWin32KmtKHR = OpaqueWin32Kmt,
        SyncFdKHR = SyncFd,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 52
    /// <summary>VkExternalMemoryFeatureFlagBits - Bitmask specifying features of an external memory handle type</summary>
    [Flags]
    public enum VkExternalMemoryFeatureFlagBits {
        DedicatedOnly = 0x00000001,
        Exportable = 0x00000002,
        Importable = 0x00000004,
        DedicatedOnlyKHR = DedicatedOnly,
        ExportableKHR = Exportable,
        ImportableKHR = Importable,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 53
    /// <summary>VkExternalMemoryFeatureFlagBitsNV - Bitmask specifying external memory features</summary>
    [Flags]
    public enum VkExternalMemoryFeatureFlagBitsNV {
        DedicatedOnlyNv = 0x00000001,
        ExportableNv = 0x00000002,
        ImportableNv = 0x00000004,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 54
    /// <summary>VkExternalMemoryHandleTypeFlagBits - Bit specifying external memory handle types</summary>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits {
        OpaqueFd = 0x00000001,
        OpaqueWin32 = 0x00000002,
        OpaqueWin32Kmt = 0x00000004,
        D3d11Texture = 0x00000008,
        D3d11TextureKmt = 0x00000010,
        D3d12Heap = 0x00000020,
        D3d12Resource = 0x00000040,
        DmaBufExt = 0x00000200,
        AndroidHardwareBufferAndroid = 0x00000400,
        HostAllocationExt = 0x00000080,
        HostMappedForeignMemoryExt = 0x00000100,
        OpaqueFdKHR = OpaqueFd,
        OpaqueWin32KHR = OpaqueWin32,
        OpaqueWin32KmtKHR = OpaqueWin32Kmt,
        D3d11TextureKHR = D3d11Texture,
        D3d11TextureKmtKHR = D3d11TextureKmt,
        D3d12HeapKHR = D3d12Heap,
        D3d12ResourceKHR = D3d12Resource,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 55
    /// <summary>VkExternalMemoryHandleTypeFlagBitsNV - Bitmask specifying external memory handle types</summary>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBitsNV {
        OpaqueWin32Nv = 0x00000001,
        OpaqueWin32KmtNv = 0x00000002,
        D3d11ImageNv = 0x00000004,
        D3d11ImageKmtNv = 0x00000008,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 56
    /// <summary>VkExternalSemaphoreFeatureFlagBits - Bitfield describing features of an external semaphore handle type</summary>
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits {
        Exportable = 0x00000001,
        Importable = 0x00000002,
        ExportableKHR = Exportable,
        ImportableKHR = Importable,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 57
    /// <summary>VkExternalSemaphoreHandleTypeFlagBits - Bitmask of valid external semaphore handle types</summary>
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagBits {
        OpaqueFd = 0x00000001,
        OpaqueWin32 = 0x00000002,
        OpaqueWin32Kmt = 0x00000004,
        D3d12Fence = 0x00000008,
        SyncFd = 0x00000010,
        OpaqueFdKHR = OpaqueFd,
        OpaqueWin32KHR = OpaqueWin32,
        OpaqueWin32KmtKHR = OpaqueWin32Kmt,
        D3d12FenceKHR = D3d12Fence,
        SyncFdKHR = SyncFd,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 58
    /// <summary>VkFenceCreateFlagBits - Bitmask specifying initial state and behavior of a fence</summary>
    [Flags]
    public enum VkFenceCreateFlagBits {
        Signaled = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 59
    /// <summary>VkFenceImportFlagBits - Bitmask specifying additional parameters of fence payload import</summary>
    [Flags]
    public enum VkFenceImportFlagBits {
        Temporary = 0x00000001,
        TemporaryKHR = Temporary,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 60
    /// <summary>VkFilter - Specify filters used for texture lookups</summary>
    public enum VkFilter {
        Nearest = 0,
        Linear = 1,
        CubicImg = 1000015000,
        CubicExt = CubicImg,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 61
    /// <summary>VkFormat - Available image formats</summary>
    public enum VkFormat {
        Undefined = 0,
        R4g4UnormPack8 = 1,
        R4g4b4a4UnormPack16 = 2,
        B4g4r4a4UnormPack16 = 3,
        R5g6b5UnormPack16 = 4,
        B5g6r5UnormPack16 = 5,
        R5g5b5a1UnormPack16 = 6,
        B5g5r5a1UnormPack16 = 7,
        A1r5g5b5UnormPack16 = 8,
        R8Unorm = 9,
        R8Snorm = 10,
        R8Uscaled = 11,
        R8Sscaled = 12,
        R8Uint = 13,
        R8Sint = 14,
        R8Srgb = 15,
        R8g8Unorm = 16,
        R8g8Snorm = 17,
        R8g8Uscaled = 18,
        R8g8Sscaled = 19,
        R8g8Uint = 20,
        R8g8Sint = 21,
        R8g8Srgb = 22,
        R8g8b8Unorm = 23,
        R8g8b8Snorm = 24,
        R8g8b8Uscaled = 25,
        R8g8b8Sscaled = 26,
        R8g8b8Uint = 27,
        R8g8b8Sint = 28,
        R8g8b8Srgb = 29,
        B8g8r8Unorm = 30,
        B8g8r8Snorm = 31,
        B8g8r8Uscaled = 32,
        B8g8r8Sscaled = 33,
        B8g8r8Uint = 34,
        B8g8r8Sint = 35,
        B8g8r8Srgb = 36,
        R8g8b8a8Unorm = 37,
        R8g8b8a8Snorm = 38,
        R8g8b8a8Uscaled = 39,
        R8g8b8a8Sscaled = 40,
        R8g8b8a8Uint = 41,
        R8g8b8a8Sint = 42,
        R8g8b8a8Srgb = 43,
        B8g8r8a8Unorm = 44,
        B8g8r8a8Snorm = 45,
        B8g8r8a8Uscaled = 46,
        B8g8r8a8Sscaled = 47,
        B8g8r8a8Uint = 48,
        B8g8r8a8Sint = 49,
        B8g8r8a8Srgb = 50,
        A8b8g8r8UnormPack32 = 51,
        A8b8g8r8SnormPack32 = 52,
        A8b8g8r8UscaledPack32 = 53,
        A8b8g8r8SscaledPack32 = 54,
        A8b8g8r8UintPack32 = 55,
        A8b8g8r8SintPack32 = 56,
        A8b8g8r8SrgbPack32 = 57,
        A2r10g10b10UnormPack32 = 58,
        A2r10g10b10SnormPack32 = 59,
        A2r10g10b10UscaledPack32 = 60,
        A2r10g10b10SscaledPack32 = 61,
        A2r10g10b10UintPack32 = 62,
        A2r10g10b10SintPack32 = 63,
        A2b10g10r10UnormPack32 = 64,
        A2b10g10r10SnormPack32 = 65,
        A2b10g10r10UscaledPack32 = 66,
        A2b10g10r10SscaledPack32 = 67,
        A2b10g10r10UintPack32 = 68,
        A2b10g10r10SintPack32 = 69,
        R16Unorm = 70,
        R16Snorm = 71,
        R16Uscaled = 72,
        R16Sscaled = 73,
        R16Uint = 74,
        R16Sint = 75,
        R16Sfloat = 76,
        R16g16Unorm = 77,
        R16g16Snorm = 78,
        R16g16Uscaled = 79,
        R16g16Sscaled = 80,
        R16g16Uint = 81,
        R16g16Sint = 82,
        R16g16Sfloat = 83,
        R16g16b16Unorm = 84,
        R16g16b16Snorm = 85,
        R16g16b16Uscaled = 86,
        R16g16b16Sscaled = 87,
        R16g16b16Uint = 88,
        R16g16b16Sint = 89,
        R16g16b16Sfloat = 90,
        R16g16b16a16Unorm = 91,
        R16g16b16a16Snorm = 92,
        R16g16b16a16Uscaled = 93,
        R16g16b16a16Sscaled = 94,
        R16g16b16a16Uint = 95,
        R16g16b16a16Sint = 96,
        R16g16b16a16Sfloat = 97,
        R32Uint = 98,
        R32Sint = 99,
        R32Sfloat = 100,
        R32g32Uint = 101,
        R32g32Sint = 102,
        R32g32Sfloat = 103,
        R32g32b32Uint = 104,
        R32g32b32Sint = 105,
        R32g32b32Sfloat = 106,
        R32g32b32a32Uint = 107,
        R32g32b32a32Sint = 108,
        R32g32b32a32Sfloat = 109,
        R64Uint = 110,
        R64Sint = 111,
        R64Sfloat = 112,
        R64g64Uint = 113,
        R64g64Sint = 114,
        R64g64Sfloat = 115,
        R64g64b64Uint = 116,
        R64g64b64Sint = 117,
        R64g64b64Sfloat = 118,
        R64g64b64a64Uint = 119,
        R64g64b64a64Sint = 120,
        R64g64b64a64Sfloat = 121,
        B10g11r11UfloatPack32 = 122,
        E5b9g9r9UfloatPack32 = 123,
        D16Unorm = 124,
        X8D24UnormPack32 = 125,
        D32Sfloat = 126,
        S8Uint = 127,
        D16UnormS8Uint = 128,
        D24UnormS8Uint = 129,
        D32SfloatS8Uint = 130,
        Bc1RgbUnormBlock = 131,
        Bc1RgbSrgbBlock = 132,
        Bc1RgbaUnormBlock = 133,
        Bc1RgbaSrgbBlock = 134,
        Bc2UnormBlock = 135,
        Bc2SrgbBlock = 136,
        Bc3UnormBlock = 137,
        Bc3SrgbBlock = 138,
        Bc4UnormBlock = 139,
        Bc4SnormBlock = 140,
        Bc5UnormBlock = 141,
        Bc5SnormBlock = 142,
        Bc6hUfloatBlock = 143,
        Bc6hSfloatBlock = 144,
        Bc7UnormBlock = 145,
        Bc7SrgbBlock = 146,
        Etc2R8g8b8UnormBlock = 147,
        Etc2R8g8b8SrgbBlock = 148,
        Etc2R8g8b8a1UnormBlock = 149,
        Etc2R8g8b8a1SrgbBlock = 150,
        Etc2R8g8b8a8UnormBlock = 151,
        Etc2R8g8b8a8SrgbBlock = 152,
        EacR11UnormBlock = 153,
        EacR11SnormBlock = 154,
        EacR11g11UnormBlock = 155,
        EacR11g11SnormBlock = 156,
        Astc4x4UnormBlock = 157,
        Astc4x4SrgbBlock = 158,
        Astc5x4UnormBlock = 159,
        Astc5x4SrgbBlock = 160,
        Astc5x5UnormBlock = 161,
        Astc5x5SrgbBlock = 162,
        Astc6x5UnormBlock = 163,
        Astc6x5SrgbBlock = 164,
        Astc6x6UnormBlock = 165,
        Astc6x6SrgbBlock = 166,
        Astc8x5UnormBlock = 167,
        Astc8x5SrgbBlock = 168,
        Astc8x6UnormBlock = 169,
        Astc8x6SrgbBlock = 170,
        Astc8x8UnormBlock = 171,
        Astc8x8SrgbBlock = 172,
        Astc10x5UnormBlock = 173,
        Astc10x5SrgbBlock = 174,
        Astc10x6UnormBlock = 175,
        Astc10x6SrgbBlock = 176,
        Astc10x8UnormBlock = 177,
        Astc10x8SrgbBlock = 178,
        Astc10x10UnormBlock = 179,
        Astc10x10SrgbBlock = 180,
        Astc12x10UnormBlock = 181,
        Astc12x10SrgbBlock = 182,
        Astc12x12UnormBlock = 183,
        Astc12x12SrgbBlock = 184,
        G8b8g8r8422Unorm = 1000156000,
        B8g8r8g8422Unorm = 1000156001,
        G8B8R83plane420Unorm = 1000156002,
        G8B8r82plane420Unorm = 1000156003,
        G8B8R83plane422Unorm = 1000156004,
        G8B8r82plane422Unorm = 1000156005,
        G8B8R83plane444Unorm = 1000156006,
        R10x6UnormPack16 = 1000156007,
        R10x6g10x6Unorm2pack16 = 1000156008,
        R10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
        G10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
        B10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
        G10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
        G10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
        G10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
        G10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
        G10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
        R12x4UnormPack16 = 1000156017,
        R12x4g12x4Unorm2pack16 = 1000156018,
        R12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
        G12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
        B12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
        G12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
        G12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
        G12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
        G12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
        G12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
        G16b16g16r16422Unorm = 1000156027,
        B16g16r16g16422Unorm = 1000156028,
        G16B16R163plane420Unorm = 1000156029,
        G16B16r162plane420Unorm = 1000156030,
        G16B16R163plane422Unorm = 1000156031,
        G16B16r162plane422Unorm = 1000156032,
        G16B16R163plane444Unorm = 1000156033,
        Pvrtc12bppUnormBlockImg = 1000054000,
        Pvrtc14bppUnormBlockImg = 1000054001,
        Pvrtc22bppUnormBlockImg = 1000054002,
        Pvrtc24bppUnormBlockImg = 1000054003,
        Pvrtc12bppSrgbBlockImg = 1000054004,
        Pvrtc14bppSrgbBlockImg = 1000054005,
        Pvrtc22bppSrgbBlockImg = 1000054006,
        Pvrtc24bppSrgbBlockImg = 1000054007,
        G8b8g8r8422UnormKHR = G8b8g8r8422Unorm,
        B8g8r8g8422UnormKHR = B8g8r8g8422Unorm,
        G8B8R83plane420UnormKHR = G8B8R83plane420Unorm,
        G8B8r82plane420UnormKHR = G8B8r82plane420Unorm,
        G8B8R83plane422UnormKHR = G8B8R83plane422Unorm,
        G8B8r82plane422UnormKHR = G8B8r82plane422Unorm,
        G8B8R83plane444UnormKHR = G8B8R83plane444Unorm,
        R10x6UnormPack16KHR = R10x6UnormPack16,
        R10x6g10x6Unorm2pack16KHR = R10x6g10x6Unorm2pack16,
        R10x6g10x6b10x6a10x6Unorm4pack16KHR = R10x6g10x6b10x6a10x6Unorm4pack16,
        G10x6b10x6g10x6r10x6422Unorm4pack16KHR = G10x6b10x6g10x6r10x6422Unorm4pack16,
        B10x6g10x6r10x6g10x6422Unorm4pack16KHR = B10x6g10x6r10x6g10x6422Unorm4pack16,
        G10x6B10x6R10x63plane420Unorm3pack16KHR = G10x6B10x6R10x63plane420Unorm3pack16,
        G10x6B10x6r10x62plane420Unorm3pack16KHR = G10x6B10x6r10x62plane420Unorm3pack16,
        G10x6B10x6R10x63plane422Unorm3pack16KHR = G10x6B10x6R10x63plane422Unorm3pack16,
        G10x6B10x6r10x62plane422Unorm3pack16KHR = G10x6B10x6r10x62plane422Unorm3pack16,
        G10x6B10x6R10x63plane444Unorm3pack16KHR = G10x6B10x6R10x63plane444Unorm3pack16,
        R12x4UnormPack16KHR = R12x4UnormPack16,
        R12x4g12x4Unorm2pack16KHR = R12x4g12x4Unorm2pack16,
        R12x4g12x4b12x4a12x4Unorm4pack16KHR = R12x4g12x4b12x4a12x4Unorm4pack16,
        G12x4b12x4g12x4r12x4422Unorm4pack16KHR = G12x4b12x4g12x4r12x4422Unorm4pack16,
        B12x4g12x4r12x4g12x4422Unorm4pack16KHR = B12x4g12x4r12x4g12x4422Unorm4pack16,
        G12x4B12x4R12x43plane420Unorm3pack16KHR = G12x4B12x4R12x43plane420Unorm3pack16,
        G12x4B12x4r12x42plane420Unorm3pack16KHR = G12x4B12x4r12x42plane420Unorm3pack16,
        G12x4B12x4R12x43plane422Unorm3pack16KHR = G12x4B12x4R12x43plane422Unorm3pack16,
        G12x4B12x4r12x42plane422Unorm3pack16KHR = G12x4B12x4r12x42plane422Unorm3pack16,
        G12x4B12x4R12x43plane444Unorm3pack16KHR = G12x4B12x4R12x43plane444Unorm3pack16,
        G16b16g16r16422UnormKHR = G16b16g16r16422Unorm,
        B16g16r16g16422UnormKHR = B16g16r16g16422Unorm,
        G16B16R163plane420UnormKHR = G16B16R163plane420Unorm,
        G16B16r162plane420UnormKHR = G16B16r162plane420Unorm,
        G16B16R163plane422UnormKHR = G16B16R163plane422Unorm,
        G16B16r162plane422UnormKHR = G16B16r162plane422Unorm,
        G16B16R163plane444UnormKHR = G16B16R163plane444Unorm,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 62
    /// <summary>VkFormatFeatureFlagBits - Bitmask specifying features supported by a buffer</summary>
    [Flags]
    public enum VkFormatFeatureFlagBits {
        SampledImage = 0x00000001,
        StorageImage = 0x00000002,
        StorageImageAtomic = 0x00000004,
        UniformTexelBuffer = 0x00000008,
        StorageTexelBuffer = 0x00000010,
        StorageTexelBufferAtomic = 0x00000020,
        VertexBuffer = 0x00000040,
        ColorAttachment = 0x00000080,
        ColorAttachmentBlend = 0x00000100,
        DepthStencilAttachment = 0x00000200,
        BlitSrc = 0x00000400,
        BlitDst = 0x00000800,
        SampledImageFilterLinear = 0x00001000,
        TransferSrc = 0x00004000,
        TransferDst = 0x00008000,
        MidpointChromaSamples = 0x00020000,
        SampledImageYcbcrConversionLinearFilter = 0x00040000,
        SampledImageYcbcrConversionSeparateReconstructionFilter = 0x00080000,
        SampledImageYcbcrConversionChromaReconstructionExplicit = 0x00100000,
        SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 0x00200000,
        Disjoint = 0x00400000,
        CositedChromaSamples = 0x00800000,
        SampledImageFilterCubicImg = 0x00002000,
        SampledImageFilterMinmaxExt = 0x00010000,
        FragmentDensityMapExt = 0x01000000,
        TransferSrcKHR = TransferSrc,
        TransferDstKHR = TransferDst,
        MidpointChromaSamplesKHR = MidpointChromaSamples,
        SampledImageYcbcrConversionLinearFilterKHR = SampledImageYcbcrConversionLinearFilter,
        SampledImageYcbcrConversionSeparateReconstructionFilterKHR = SampledImageYcbcrConversionSeparateReconstructionFilter,
        SampledImageYcbcrConversionChromaReconstructionExplicitKHR = SampledImageYcbcrConversionChromaReconstructionExplicit,
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableKHR = SampledImageYcbcrConversionChromaReconstructionExplicitForceable,
        DisjointKHR = Disjoint,
        CositedChromaSamplesKHR = CositedChromaSamples,
        SampledImageFilterCubicExt = SampledImageFilterCubicImg,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 63
    /// <summary>VkFrontFace - Interpret polygon front-facing orientation</summary>
    public enum VkFrontFace {
        CounterClockwise = 0,
        Clockwise = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 64
    /// <summary>VkFullScreenExclusiveEXT - Hint values an application can specify affecting full-screen transition behavior</summary>
    public enum VkFullScreenExclusiveEXT {
        DefaultExt = 0,
        AllowedExt = 1,
        DisallowedExt = 2,
        ApplicationControlledExt = 3,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 65
    /// <summary>VkGeometryFlagBitsNV - Bitmask specifying additional parameters for a geometry</summary>
    [Flags]
    public enum VkGeometryFlagBitsNV {
        OpaqueNv = 0x00000001,
        NoDuplicateAnyHitInvocationNv = 0x00000002,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 66
    /// <summary>VkGeometryInstanceFlagBitsNV - Instance flag bits</summary>
    [Flags]
    public enum VkGeometryInstanceFlagBitsNV {
        TriangleCullDisableNv = 0x00000001,
        TriangleFrontCounterclockwiseNv = 0x00000002,
        ForceOpaqueNv = 0x00000004,
        ForceNoOpaqueNv = 0x00000008,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 67
    /// <summary>VkGeometryTypeNV - Enum specifying which type of geometry is provided</summary>
    public enum VkGeometryTypeNV {
        TrianglesNv = 0,
        AabbsNv = 1,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 68
    /// <summary>VkImageAspectFlagBits - Bitmask specifying which aspects of an image are included in a view</summary>
    [Flags]
    public enum VkImageAspectFlagBits {
        Color = 0x00000001,
        Depth = 0x00000002,
        Stencil = 0x00000004,
        Metadata = 0x00000008,
        Plane0 = 0x00000010,
        Plane1 = 0x00000020,
        Plane2 = 0x00000040,
        MemoryPlane0Ext = 0x00000080,
        MemoryPlane1Ext = 0x00000100,
        MemoryPlane2Ext = 0x00000200,
        MemoryPlane3Ext = 0x00000400,
        Plane0KHR = Plane0,
        Plane1KHR = Plane1,
        Plane2KHR = Plane2,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 69
    /// <summary>VkImageCreateFlagBits - Bitmask specifying additional parameters of an image</summary>
    [Flags]
    public enum VkImageCreateFlagBits {
        SparseBinding = 0x00000001,
        SparseResidency = 0x00000002,
        SparseAliased = 0x00000004,
        MutableFormat = 0x00000008,
        CubeCompatible = 0x00000010,
        Alias = 0x00000400,
        SplitInstanceBindRegions = 0x00000040,
        _2dArrayCompatible = 0x00000020,
        BlockTexelViewCompatible = 0x00000080,
        ExtendedUsage = 0x00000100,
        Protected = 0x00000800,
        Disjoint = 0x00000200,
        CornerSampledNv = 0x00002000,
        SampleLocationsCompatibleDepthExt = 0x00001000,
        SubsampledExt = 0x00004000,
        SplitInstanceBindRegionsKHR = SplitInstanceBindRegions,
        _2dArrayCompatibleKHR = _2dArrayCompatible,
        BlockTexelViewCompatibleKHR = BlockTexelViewCompatible,
        ExtendedUsageKHR = ExtendedUsage,
        DisjointKHR = Disjoint,
        AliasKHR = Alias,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 70
    /// <summary>VkImageLayout - Layout of image and image subresources</summary>
    public enum VkImageLayout {
        Undefined = 0,
        General = 1,
        ColorAttachmentOptimal = 2,
        DepthStencilAttachmentOptimal = 3,
        DepthStencilReadOnlyOptimal = 4,
        ShaderReadOnlyOptimal = 5,
        TransferSrcOptimal = 6,
        TransferDstOptimal = 7,
        Preinitialized = 8,
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,
        PresentSrcKHR = 1000001002,
        SharedPresentKHR = 1000111000,
        ShadingRateOptimalNv = 1000164003,
        FragmentDensityMapOptimalExt = 1000218000,
        DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,
        DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 71
    /// <summary>VkImageTiling - Specifies the tiling arrangement of data in an image</summary>
    public enum VkImageTiling {
        Optimal = 0,
        Linear = 1,
        DrmFormatModifierExt = 1000158000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 72
    /// <summary>VkImageType - Specifies the type of an image object</summary>
    public enum VkImageType {
        _1d = 0,
        _2d = 1,
        _3d = 2,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 73
    /// <summary>VkImageUsageFlagBits - Bitmask specifying intended usage of an image</summary>
    [Flags]
    public enum VkImageUsageFlagBits {
        TransferSrc = 0x00000001,
        TransferDst = 0x00000002,
        Sampled = 0x00000004,
        Storage = 0x00000008,
        ColorAttachment = 0x00000010,
        DepthStencilAttachment = 0x00000020,
        TransientAttachment = 0x00000040,
        InputAttachment = 0x00000080,
        ShadingRateImageNv = 0x00000100,
        FragmentDensityMapExt = 0x00000200,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 74
    /// <summary>VkImageViewCreateFlagBits - Bitmask specifying additional parameters of an image view</summary>
    [Flags]
    public enum VkImageViewCreateFlagBits {
        FragmentDensityMapDynamicExt = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 75
    /// <summary>VkImageViewType - Image view types</summary>
    public enum VkImageViewType {
        _1d = 0,
        _2d = 1,
        _3d = 2,
        Cube = 3,
        _1dArray = 4,
        _2dArray = 5,
        CubeArray = 6,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 76
    /// <summary>VkIndexType - Type of index buffer indices</summary>
    public enum VkIndexType {
        Uint16 = 0,
        Uint32 = 1,
        NoneNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 77
    /// <summary>VkIndirectCommandsLayoutUsageFlagBitsNVX - Bitmask specifying allowed usage of an indirect commands layout</summary>
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagBitsNVX {
        UnorderedSequencesNvx = 0x00000001,
        SparseSequencesNvx = 0x00000002,
        EmptyExecutionsNvx = 0x00000004,
        IndexedSequencesNvx = 0x00000008,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 78
    /// <summary>VkIndirectCommandsTokenTypeNVX - Enum specifying</summary>
    public enum VkIndirectCommandsTokenTypeNVX {
        PipelineNvx = 0,
        DescriptorSetNvx = 1,
        IndexBufferNvx = 2,
        VertexBufferNvx = 3,
        PushConstantNvx = 4,
        DrawIndexedNvx = 5,
        DrawNvx = 6,
        DispatchNvx = 7,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 79
    /// <summary>VkInternalAllocationType - Allocation type</summary>
    public enum VkInternalAllocationType {
        Executable = 0,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 80
    /// <summary>VkLogicOp - Framebuffer logical operations</summary>
    public enum VkLogicOp {
        Clear = 0,
        And = 1,
        AndReverse = 2,
        Copy = 3,
        AndInverted = 4,
        NoOp = 5,
        Xor = 6,
        Or = 7,
        Nor = 8,
        Equivalent = 9,
        Invert = 10,
        OrReverse = 11,
        CopyInverted = 12,
        OrInverted = 13,
        Nand = 14,
        Set = 15,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 81
    /// <summary>VkMemoryAllocateFlagBits - Bitmask specifying flags for a device memory allocation</summary>
    [Flags]
    public enum VkMemoryAllocateFlagBits {
        DeviceMask = 0x00000001,
        DeviceMaskKHR = DeviceMask,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 82
    /// <summary>VkMemoryHeapFlagBits - Bitmask specifying attribute flags for a heap</summary>
    [Flags]
    public enum VkMemoryHeapFlagBits {
        DeviceLocal = 0x00000001,
        MultiInstance = 0x00000002,
        MultiInstanceKHR = MultiInstance,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 83
    /// <summary>VkMemoryOverallocationBehaviorAMD - Specify memory overallocation behavior</summary>
    public enum VkMemoryOverallocationBehaviorAMD {
        DefaultAmd = 0,
        AllowedAmd = 1,
        DisallowedAmd = 2,
        MaxEnumAmd = 0x7FFFFFFF,
    }
    // Enum: 84
    /// <summary>VkMemoryPropertyFlagBits - Bitmask specifying properties for a memory type</summary>
    [Flags]
    public enum VkMemoryPropertyFlagBits {
        DeviceLocal = 0x00000001,
        HostVisible = 0x00000002,
        HostCoherent = 0x00000004,
        HostCached = 0x00000008,
        LazilyAllocated = 0x00000010,
        Protected = 0x00000020,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 85
    /// <summary>VkObjectEntryTypeNVX - Enum specifying object table entry type</summary>
    public enum VkObjectEntryTypeNVX {
        DescriptorSetNvx = 0,
        PipelineNvx = 1,
        IndexBufferNvx = 2,
        VertexBufferNvx = 3,
        PushConstantNvx = 4,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 86
    /// <summary>VkObjectEntryUsageFlagBitsNVX - Bitmask specifying allowed usage of an object entry</summary>
    [Flags]
    public enum VkObjectEntryUsageFlagBitsNVX {
        GraphicsNvx = 0x00000001,
        ComputeNvx = 0x00000002,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 87
    /// <summary>VkObjectType - Specify an enumeration to track object handle types</summary>
    public enum VkObjectType {
        Unknown = 0,
        Instance = 1,
        PhysicalDevice = 2,
        Device = 3,
        Queue = 4,
        Semaphore = 5,
        CommandBuffer = 6,
        Fence = 7,
        DeviceMemory = 8,
        Buffer = 9,
        Image = 10,
        Event = 11,
        QueryPool = 12,
        BufferView = 13,
        ImageView = 14,
        ShaderModule = 15,
        PipelineCache = 16,
        PipelineLayout = 17,
        RenderPass = 18,
        Pipeline = 19,
        DescriptorSetLayout = 20,
        Sampler = 21,
        DescriptorPool = 22,
        DescriptorSet = 23,
        Framebuffer = 24,
        CommandPool = 25,
        SamplerYcbcrConversion = 1000156000,
        DescriptorUpdateTemplate = 1000085000,
        SurfaceKHR = 1000000000,
        SwapchainKHR = 1000001000,
        DisplayKHR = 1000002000,
        DisplayModeKHR = 1000002001,
        DebugReportCallbackExt = 1000011000,
        ObjectTableNvx = 1000086000,
        IndirectCommandsLayoutNvx = 1000086001,
        DebugUtilsMessengerExt = 1000128000,
        ValidationCacheExt = 1000160000,
        AccelerationStructureNv = 1000165000,
        DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,
        SamplerYcbcrConversionKHR = SamplerYcbcrConversion,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 88
    /// <summary>VkPeerMemoryFeatureFlagBits - Bitmask specifying supported peer memory features</summary>
    [Flags]
    public enum VkPeerMemoryFeatureFlagBits {
        CopySrc = 0x00000001,
        CopyDst = 0x00000002,
        GenericSrc = 0x00000004,
        GenericDst = 0x00000008,
        CopySrcKHR = CopySrc,
        CopyDstKHR = CopyDst,
        GenericSrcKHR = GenericSrc,
        GenericDstKHR = GenericDst,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 89
    /// <summary>VkPhysicalDeviceType - Supported physical device types</summary>
    public enum VkPhysicalDeviceType {
        Other = 0,
        IntegratedGpu = 1,
        DiscreteGpu = 2,
        VirtualGpu = 3,
        Cpu = 4,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 90
    /// <summary>VkPipelineBindPoint - Specify the bind point of a pipeline object to a command buffer</summary>
    public enum VkPipelineBindPoint {
        Graphics = 0,
        Compute = 1,
        RayTracingNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 91
    /// <summary>VkPipelineCacheHeaderVersion - Encode pipeline cache version</summary>
    public enum VkPipelineCacheHeaderVersion {
        One = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 92
    /// <summary>VkPipelineCreateFlagBits - Bitmask controlling how a pipeline is created</summary>
    [Flags]
    public enum VkPipelineCreateFlagBits {
        DisableOptimization = 0x00000001,
        AllowDerivatives = 0x00000002,
        Derivative = 0x00000004,
        ViewIndexFromDeviceIndex = 0x00000008,
        DispatchBase = 0x00000010,
        DeferCompileNv = 0x00000020,
        ViewIndexFromDeviceIndexKHR = ViewIndexFromDeviceIndex,
        DispatchBaseKHR = DispatchBase,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 93
    /// <summary>VkPipelineCreationFeedbackFlagBitsEXT - Bitmask specifying pipeline or pipeline stage creation feedback</summary>
    [Flags]
    public enum VkPipelineCreationFeedbackFlagBitsEXT {
        ValidExt = 0x00000001,
        ApplicationPipelineCacheHitExt = 0x00000002,
        BasePipelineAccelerationExt = 0x00000004,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 94
    /// <summary>VkPipelineStageFlagBits - Bitmask specifying pipeline stages</summary>
    [Flags]
    public enum VkPipelineStageFlagBits {
        TopOfPipe = 0x00000001,
        DrawIndirect = 0x00000002,
        VertexInput = 0x00000004,
        VertexShader = 0x00000008,
        TessellationControlShader = 0x00000010,
        TessellationEvaluationShader = 0x00000020,
        GeometryShader = 0x00000040,
        FragmentShader = 0x00000080,
        EarlyFragmentTests = 0x00000100,
        LateFragmentTests = 0x00000200,
        ColorAttachmentOutput = 0x00000400,
        ComputeShader = 0x00000800,
        Transfer = 0x00001000,
        BottomOfPipe = 0x00002000,
        Host = 0x00004000,
        AllGraphics = 0x00008000,
        AllCommands = 0x00010000,
        TransformFeedbackExt = 0x01000000,
        ConditionalRenderingExt = 0x00040000,
        CommandProcessNvx = 0x00020000,
        ShadingRateImageNv = 0x00400000,
        RayTracingShaderNv = 0x00200000,
        AccelerationStructureBuildNv = 0x02000000,
        TaskShaderNv = 0x00080000,
        MeshShaderNv = 0x00100000,
        FragmentDensityProcessExt = 0x00800000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 95
    /// <summary>VkPointClippingBehavior - Enum specifying the point clipping behavior</summary>
    public enum VkPointClippingBehavior {
        AllClipPlanes = 0,
        UserClipPlanesOnly = 1,
        AllClipPlanesKHR = AllClipPlanes,
        UserClipPlanesOnlyKHR = UserClipPlanesOnly,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 96
    /// <summary>VkPolygonMode - Control polygon rasterization mode</summary>
    public enum VkPolygonMode {
        Fill = 0,
        Line = 1,
        Point = 2,
        FillRectangleNv = 1000153000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 97
    /// <summary>VkPresentModeKHR - presentation mode supported for a surface</summary>
    public enum VkPresentModeKHR {
        ImmediateKHR = 0,
        MailboxKHR = 1,
        FifoKHR = 2,
        FifoRelaxedKHR = 3,
        SharedDemandRefreshKHR = 1000111000,
        SharedContinuousRefreshKHR = 1000111001,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 98
    /// <summary>VkPrimitiveTopology - Supported primitive topologies</summary>
    public enum VkPrimitiveTopology {
        PointList = 0,
        LineList = 1,
        LineStrip = 2,
        TriangleList = 3,
        TriangleStrip = 4,
        TriangleFan = 5,
        LineListWithAdjacency = 6,
        LineStripWithAdjacency = 7,
        TriangleListWithAdjacency = 8,
        TriangleStripWithAdjacency = 9,
        PatchList = 10,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 99
    /// <summary>VkQueryControlFlagBits - Bitmask specifying constraints on a query</summary>
    [Flags]
    public enum VkQueryControlFlagBits {
        Precise = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 100
    /// <summary>VkQueryPipelineStatisticFlagBits - Bitmask specifying queried pipeline statistics</summary>
    [Flags]
    public enum VkQueryPipelineStatisticFlagBits {
        InputAssemblyVertices = 0x00000001,
        InputAssemblyPrimitives = 0x00000002,
        VertexShaderInvocations = 0x00000004,
        GeometryShaderInvocations = 0x00000008,
        GeometryShaderPrimitives = 0x00000010,
        ClippingInvocations = 0x00000020,
        ClippingPrimitives = 0x00000040,
        FragmentShaderInvocations = 0x00000080,
        TessellationControlShaderPatches = 0x00000100,
        TessellationEvaluationShaderInvocations = 0x00000200,
        ComputeShaderInvocations = 0x00000400,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 101
    /// <summary>VkQueryResultFlagBits - Bitmask specifying how and when query results are returned</summary>
    [Flags]
    public enum VkQueryResultFlagBits {
        _64 = 0x00000001,
        Wait = 0x00000002,
        WithAvailability = 0x00000004,
        Partial = 0x00000008,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 102
    /// <summary>VkQueryType - Specify the type of queries managed by a query pool</summary>
    public enum VkQueryType {
        Occlusion = 0,
        PipelineStatistics = 1,
        Timestamp = 2,
        TransformFeedbackStreamExt = 1000028004,
        AccelerationStructureCompactedSizeNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 103
    /// <summary>VkQueueFlagBits - Bitmask specifying capabilities of queues in a queue family</summary>
    [Flags]
    public enum VkQueueFlagBits {
        Graphics = 0x00000001,
        Compute = 0x00000002,
        Transfer = 0x00000004,
        SparseBinding = 0x00000008,
        Protected = 0x00000010,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 104
    /// <summary>VkQueueGlobalPriorityEXT - Values specifying a system-wide queue priority</summary>
    public enum VkQueueGlobalPriorityEXT {
        LowExt = 128,
        MediumExt = 256,
        HighExt = 512,
        RealtimeExt = 1024,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 105
    /// <summary>VkRasterizationOrderAMD - Specify rasterization order for a graphics pipeline</summary>
    public enum VkRasterizationOrderAMD {
        StrictAmd = 0,
        RelaxedAmd = 1,
        MaxEnumAmd = 0x7FFFFFFF,
    }
    // Enum: 106
    /// <summary>VkRayTracingShaderGroupTypeNV - Shader group types</summary>
    public enum VkRayTracingShaderGroupTypeNV {
        GeneralNv = 0,
        TrianglesHitGroupNv = 1,
        ProceduralHitGroupNv = 2,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 107
    /// <summary>VkResolveModeFlagBitsKHR - Bitmask indicating supported depth and stencil resolve modes</summary>
    [Flags]
    public enum VkResolveModeFlagBitsKHR {
        NoneKHR = 0,
        SampleZeroKHR = 0x00000001,
        AverageKHR = 0x00000002,
        MinKHR = 0x00000004,
        MaxKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 108
    /// <summary>VkResult - Vulkan command return codes</summary>
    public enum VkResult {
        Success = 0,
        NotReady = 1,
        Timeout = 2,
        EventSet = 3,
        EventReset = 4,
        Incomplete = 5,
        ErrorOutOfHostMemory = -1,
        ErrorOutOfDeviceMemory = -2,
        ErrorInitializationFailed = -3,
        ErrorDeviceLost = -4,
        ErrorMemoryMapFailed = -5,
        ErrorLayerNotPresent = -6,
        ErrorExtensionNotPresent = -7,
        ErrorFeatureNotPresent = -8,
        ErrorIncompatibleDriver = -9,
        ErrorTooManyObjects = -10,
        ErrorFormatNotSupported = -11,
        ErrorFragmentedPool = -12,
        ErrorOutOfPoolMemory = -1000069000,
        ErrorInvalidExternalHandle = -1000072003,
        ErrorSurfaceLostKHR = -1000000000,
        ErrorNativeWindowInUseKHR = -1000000001,
        SuboptimalKHR = 1000001003,
        ErrorOutOfDateKHR = -1000001004,
        ErrorIncompatibleDisplayKHR = -1000003001,
        ErrorValidationFailedExt = -1000011001,
        ErrorInvalidShaderNv = -1000012000,
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
        ErrorFragmentationExt = -1000161000,
        ErrorNotPermittedExt = -1000174001,
        ErrorInvalidDeviceAddressExt = -1000244000,
        ErrorFullScreenExclusiveModeLostExt = -1000255000,
        ErrorOutOfPoolMemoryKHR = ErrorOutOfPoolMemory,
        ErrorInvalidExternalHandleKHR = ErrorInvalidExternalHandle,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 109
    /// <summary>VkSampleCountFlagBits - Bitmask specifying sample counts supported for an image used for storage operations</summary>
    [Flags]
    public enum VkSampleCountFlagBits {
        _1 = 0x00000001,
        _2 = 0x00000002,
        _4 = 0x00000004,
        _8 = 0x00000008,
        _16 = 0x00000010,
        _32 = 0x00000020,
        _64 = 0x00000040,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 110
    /// <summary>VkSamplerAddressMode - Specify behavior of sampling with texture coordinates outside an image</summary>
    public enum VkSamplerAddressMode {
        Repeat = 0,
        MirroredRepeat = 1,
        ClampToEdge = 2,
        ClampToBorder = 3,
        MirrorClampToEdge = 4,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 111
    /// <summary>VkSamplerCreateFlagBits - Bitmask specifying additional parameters of sampler</summary>
    [Flags]
    public enum VkSamplerCreateFlagBits {
        SubsampledExt = 0x00000001,
        SubsampledCoarseReconstructionExt = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 112
    /// <summary>VkSamplerMipmapMode - Specify mipmap mode used for texture lookups</summary>
    public enum VkSamplerMipmapMode {
        Nearest = 0,
        Linear = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 113
    /// <summary>VkSamplerReductionModeEXT - Specify reduction mode for texture filtering</summary>
    public enum VkSamplerReductionModeEXT {
        WeightedAverageExt = 0,
        MinExt = 1,
        MaxExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 114
    /// <summary>VkSamplerYcbcrModelConversion - Color model component of a color space</summary>
    public enum VkSamplerYcbcrModelConversion {
        RgbIdentity = 0,
        YcbcrIdentity = 1,
        Ycbcr709 = 2,
        Ycbcr601 = 3,
        Ycbcr2020 = 4,
        RgbIdentityKHR = RgbIdentity,
        YcbcrIdentityKHR = YcbcrIdentity,
        Ycbcr709KHR = Ycbcr709,
        Ycbcr601KHR = Ycbcr601,
        Ycbcr2020KHR = Ycbcr2020,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 115
    /// <summary>VkSamplerYcbcrRange - Range of encoded values in a color space</summary>
    public enum VkSamplerYcbcrRange {
        ItuFull = 0,
        ItuNarrow = 1,
        ItuFullKHR = ItuFull,
        ItuNarrowKHR = ItuNarrow,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 116
    /// <summary>VkScopeNV - Specify SPIR-V scope</summary>
    public enum VkScopeNV {
        DeviceNv = 1,
        WorkgroupNv = 2,
        SubgroupNv = 3,
        QueueFamilyNv = 5,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 117
    /// <summary>VkSemaphoreImportFlagBits - Bitmask specifying additional parameters of semaphore payload import</summary>
    [Flags]
    public enum VkSemaphoreImportFlagBits {
        Temporary = 0x00000001,
        TemporaryKHR = Temporary,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 118
    /// <summary>VkShaderInfoTypeAMD - Enum specifying which type of shader info to query</summary>
    public enum VkShaderInfoTypeAMD {
        StatisticsAmd = 0,
        BinaryAmd = 1,
        DisassemblyAmd = 2,
        MaxEnumAmd = 0x7FFFFFFF,
    }
    // Enum: 119
    /// <summary>VkShaderStageFlagBits - Bitmask specifying a pipeline stage</summary>
    [Flags]
    public enum VkShaderStageFlagBits {
        Vertex = 0x00000001,
        TessellationControl = 0x00000002,
        TessellationEvaluation = 0x00000004,
        Geometry = 0x00000008,
        Fragment = 0x00000010,
        Compute = 0x00000020,
        AllGraphics = 0x0000001F,
        All = 0x7FFFFFFF,
        RaygenNv = 0x00000100,
        AnyHitNv = 0x00000200,
        ClosestHitNv = 0x00000400,
        MissNv = 0x00000800,
        IntersectionNv = 0x00001000,
        CallableNv = 0x00002000,
        TaskNv = 0x00000040,
        MeshNv = 0x00000080,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 120
    /// <summary>VkShadingRatePaletteEntryNV - Shading rate image palette entry types</summary>
    public enum VkShadingRatePaletteEntryNV {
        NoInvocationsNv = 0,
        _16InvocationsPerPixelNv = 1,
        _8InvocationsPerPixelNv = 2,
        _4InvocationsPerPixelNv = 3,
        _2InvocationsPerPixelNv = 4,
        _1InvocationPerPixelNv = 5,
        _1InvocationPer2x1PixelsNv = 6,
        _1InvocationPer1x2PixelsNv = 7,
        _1InvocationPer2x2PixelsNv = 8,
        _1InvocationPer4x2PixelsNv = 9,
        _1InvocationPer2x4PixelsNv = 10,
        _1InvocationPer4x4PixelsNv = 11,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 121
    /// <summary>VkSharingMode - Buffer and image sharing modes</summary>
    public enum VkSharingMode {
        Exclusive = 0,
        Concurrent = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 122
    /// <summary>VkSparseImageFormatFlagBits - Bitmask specifying additional information about a sparse image resource</summary>
    [Flags]
    public enum VkSparseImageFormatFlagBits {
        SingleMiptail = 0x00000001,
        AlignedMipSize = 0x00000002,
        NonstandardBlockSize = 0x00000004,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 123
    /// <summary>VkSparseMemoryBindFlagBits - Bitmask specifying usage of a sparse memory binding operation</summary>
    [Flags]
    public enum VkSparseMemoryBindFlagBits {
        Metadata = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 124
    /// <summary>VkStencilFaceFlagBits - Bitmask specifying sets of stencil state for which to update the compare mask</summary>
    [Flags]
    public enum VkStencilFaceFlagBits {
        Front = 0x00000001,
        Back = 0x00000002,
        FrontAndBack = 0x00000003,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 125
    /// <summary>VkStencilOp - Stencil comparison function</summary>
    public enum VkStencilOp {
        Keep = 0,
        Zero = 1,
        Replace = 2,
        IncrementAndClamp = 3,
        DecrementAndClamp = 4,
        Invert = 5,
        IncrementAndWrap = 6,
        DecrementAndWrap = 7,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 126
    /// <summary>VkStructureType - Vulkan structure types (<code>stype</code>)</summary>
    public enum VkStructureType {
        ApplicationInfo = 0,
        InstanceCreateInfo = 1,
        DeviceQueueCreateInfo = 2,
        DeviceCreateInfo = 3,
        SubmitInfo = 4,
        MemoryAllocateInfo = 5,
        MappedMemoryRange = 6,
        BindSparseInfo = 7,
        FenceCreateInfo = 8,
        SemaphoreCreateInfo = 9,
        EventCreateInfo = 10,
        QueryPoolCreateInfo = 11,
        BufferCreateInfo = 12,
        BufferViewCreateInfo = 13,
        ImageCreateInfo = 14,
        ImageViewCreateInfo = 15,
        ShaderModuleCreateInfo = 16,
        PipelineCacheCreateInfo = 17,
        PipelineShaderStageCreateInfo = 18,
        PipelineVertexInputStateCreateInfo = 19,
        PipelineInputAssemblyStateCreateInfo = 20,
        PipelineTessellationStateCreateInfo = 21,
        PipelineViewportStateCreateInfo = 22,
        PipelineRasterizationStateCreateInfo = 23,
        PipelineMultisampleStateCreateInfo = 24,
        PipelineDepthStencilStateCreateInfo = 25,
        PipelineColorBlendStateCreateInfo = 26,
        PipelineDynamicStateCreateInfo = 27,
        GraphicsPipelineCreateInfo = 28,
        ComputePipelineCreateInfo = 29,
        PipelineLayoutCreateInfo = 30,
        SamplerCreateInfo = 31,
        DescriptorSetLayoutCreateInfo = 32,
        DescriptorPoolCreateInfo = 33,
        DescriptorSetAllocateInfo = 34,
        WriteDescriptorSet = 35,
        CopyDescriptorSet = 36,
        FramebufferCreateInfo = 37,
        RenderPassCreateInfo = 38,
        CommandPoolCreateInfo = 39,
        CommandBufferAllocateInfo = 40,
        CommandBufferInheritanceInfo = 41,
        CommandBufferBeginInfo = 42,
        RenderPassBeginInfo = 43,
        BufferMemoryBarrier = 44,
        ImageMemoryBarrier = 45,
        MemoryBarrier = 46,
        LoaderInstanceCreateInfo = 47,
        LoaderDeviceCreateInfo = 48,
        PhysicalDeviceSubgroupProperties = 1000094000,
        BindBufferMemoryInfo = 1000157000,
        BindImageMemoryInfo = 1000157001,
        PhysicalDevice16bitStorageFeatures = 1000083000,
        MemoryDedicatedRequirements = 1000127000,
        MemoryDedicatedAllocateInfo = 1000127001,
        MemoryAllocateFlagsInfo = 1000060000,
        DeviceGroupRenderPassBeginInfo = 1000060003,
        DeviceGroupCommandBufferBeginInfo = 1000060004,
        DeviceGroupSubmitInfo = 1000060005,
        DeviceGroupBindSparseInfo = 1000060006,
        BindBufferMemoryDeviceGroupInfo = 1000060013,
        BindImageMemoryDeviceGroupInfo = 1000060014,
        PhysicalDeviceGroupProperties = 1000070000,
        DeviceGroupDeviceCreateInfo = 1000070001,
        BufferMemoryRequirementsInfo2 = 1000146000,
        ImageMemoryRequirementsInfo2 = 1000146001,
        ImageSparseMemoryRequirementsInfo2 = 1000146002,
        MemoryRequirements2 = 1000146003,
        SparseImageMemoryRequirements2 = 1000146004,
        PhysicalDeviceFeatures2 = 1000059000,
        PhysicalDeviceProperties2 = 1000059001,
        FormatProperties2 = 1000059002,
        ImageFormatProperties2 = 1000059003,
        PhysicalDeviceImageFormatInfo2 = 1000059004,
        QueueFamilyProperties2 = 1000059005,
        PhysicalDeviceMemoryProperties2 = 1000059006,
        SparseImageFormatProperties2 = 1000059007,
        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        PhysicalDevicePointClippingProperties = 1000117000,
        RenderPassInputAttachmentAspectCreateInfo = 1000117001,
        ImageViewUsageCreateInfo = 1000117002,
        PipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        RenderPassMultiviewCreateInfo = 1000053000,
        PhysicalDeviceMultiviewFeatures = 1000053001,
        PhysicalDeviceMultiviewProperties = 1000053002,
        PhysicalDeviceVariablePointersFeatures = 1000120000,
        ProtectedSubmitInfo = 1000145000,
        PhysicalDeviceProtectedMemoryFeatures = 1000145001,
        PhysicalDeviceProtectedMemoryProperties = 1000145002,
        DeviceQueueInfo2 = 1000145003,
        SamplerYcbcrConversionCreateInfo = 1000156000,
        SamplerYcbcrConversionInfo = 1000156001,
        BindImagePlaneMemoryInfo = 1000156002,
        ImagePlaneMemoryRequirementsInfo = 1000156003,
        PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        SamplerYcbcrConversionImageFormatProperties = 1000156005,
        DescriptorUpdateTemplateCreateInfo = 1000085000,
        PhysicalDeviceExternalImageFormatInfo = 1000071000,
        ExternalImageFormatProperties = 1000071001,
        PhysicalDeviceExternalBufferInfo = 1000071002,
        ExternalBufferProperties = 1000071003,
        PhysicalDeviceIdProperties = 1000071004,
        ExternalMemoryBufferCreateInfo = 1000072000,
        ExternalMemoryImageCreateInfo = 1000072001,
        ExportMemoryAllocateInfo = 1000072002,
        PhysicalDeviceExternalFenceInfo = 1000112000,
        ExternalFenceProperties = 1000112001,
        ExportFenceCreateInfo = 1000113000,
        ExportSemaphoreCreateInfo = 1000077000,
        PhysicalDeviceExternalSemaphoreInfo = 1000076000,
        ExternalSemaphoreProperties = 1000076001,
        PhysicalDeviceMaintenance3Properties = 1000168000,
        DescriptorSetLayoutSupport = 1000168001,
        PhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        SwapchainCreateInfoKHR = 1000001000,
        PresentInfoKHR = 1000001001,
        DeviceGroupPresentCapabilitiesKHR = 1000060007,
        ImageSwapchainCreateInfoKHR = 1000060008,
        BindImageMemorySwapchainInfoKHR = 1000060009,
        AcquireNextImageInfoKHR = 1000060010,
        DeviceGroupPresentInfoKHR = 1000060011,
        DeviceGroupSwapchainCreateInfoKHR = 1000060012,
        DisplayModeCreateInfoKHR = 1000002000,
        DisplaySurfaceCreateInfoKHR = 1000002001,
        DisplayPresentInfoKHR = 1000003000,
        XlibSurfaceCreateInfoKHR = 1000004000,
        XcbSurfaceCreateInfoKHR = 1000005000,
        WaylandSurfaceCreateInfoKHR = 1000006000,
        AndroidSurfaceCreateInfoKHR = 1000008000,
        Win32SurfaceCreateInfoKHR = 1000009000,
        DebugReportCallbackCreateInfoExt = 1000011000,
        PipelineRasterizationStateRasterizationOrderAmd = 1000018000,
        DebugMarkerObjectNameInfoExt = 1000022000,
        DebugMarkerObjectTagInfoExt = 1000022001,
        DebugMarkerMarkerInfoExt = 1000022002,
        DedicatedAllocationImageCreateInfoNv = 1000026000,
        DedicatedAllocationBufferCreateInfoNv = 1000026001,
        DedicatedAllocationMemoryAllocateInfoNv = 1000026002,
        PhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
        PhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
        PipelineRasterizationStateStreamCreateInfoExt = 1000028002,
        ImageViewHandleInfoNvx = 1000030000,
        TextureLodGatherFormatPropertiesAmd = 1000041000,
        StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        PhysicalDeviceCornerSampledImageFeaturesNv = 1000050000,
        ExternalMemoryImageCreateInfoNv = 1000056000,
        ExportMemoryAllocateInfoNv = 1000056001,
        ImportMemoryWin32HandleInfoNv = 1000057000,
        ExportMemoryWin32HandleInfoNv = 1000057001,
        Win32KeyedMutexAcquireReleaseInfoNv = 1000058000,
        ValidationFlagsExt = 1000061000,
        ViSurfaceCreateInfoNn = 1000062000,
        ImageViewAstcDecodeModeExt = 1000067000,
        PhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
        ImportMemoryWin32HandleInfoKHR = 1000073000,
        ExportMemoryWin32HandleInfoKHR = 1000073001,
        MemoryWin32HandlePropertiesKHR = 1000073002,
        MemoryGetWin32HandleInfoKHR = 1000073003,
        ImportMemoryFdInfoKHR = 1000074000,
        MemoryFdPropertiesKHR = 1000074001,
        MemoryGetFdInfoKHR = 1000074002,
        Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
        ImportSemaphoreWin32HandleInfoKHR = 1000078000,
        ExportSemaphoreWin32HandleInfoKHR = 1000078001,
        D3d12FenceSubmitInfoKHR = 1000078002,
        SemaphoreGetWin32HandleInfoKHR = 1000078003,
        ImportSemaphoreFdInfoKHR = 1000079000,
        SemaphoreGetFdInfoKHR = 1000079001,
        PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
        CommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
        PhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
        ConditionalRenderingBeginInfoExt = 1000081002,
        PhysicalDeviceFloat16Int8FeaturesKHR = 1000082000,
        PresentRegionsKHR = 1000084000,
        ObjectTableCreateInfoNvx = 1000086000,
        IndirectCommandsLayoutCreateInfoNvx = 1000086001,
        CmdProcessCommandsInfoNvx = 1000086002,
        CmdReserveSpaceForCommandsInfoNvx = 1000086003,
        DeviceGeneratedCommandsLimitsNvx = 1000086004,
        DeviceGeneratedCommandsFeaturesNvx = 1000086005,
        PipelineViewportWScalingStateCreateInfoNv = 1000087000,
        SurfaceCapabilities2Ext = 1000090000,
        DisplayPowerInfoExt = 1000091000,
        DeviceEventInfoExt = 1000091001,
        DisplayEventInfoExt = 1000091002,
        SwapchainCounterCreateInfoExt = 1000091003,
        PresentTimesInfoGoogle = 1000092000,
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
        PipelineViewportSwizzleStateCreateInfoNv = 1000098000,
        PhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
        PipelineDiscardRectangleStateCreateInfoExt = 1000099001,
        PhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
        PipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
        PhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
        PipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
        HdrMetadataExt = 1000105000,
        AttachmentDescription2KHR = 1000109000,
        AttachmentReference2KHR = 1000109001,
        SubpassDescription2KHR = 1000109002,
        SubpassDependency2KHR = 1000109003,
        RenderPassCreateInfo2KHR = 1000109004,
        SubpassBeginInfoKHR = 1000109005,
        SubpassEndInfoKHR = 1000109006,
        SharedPresentSurfaceCapabilitiesKHR = 1000111000,
        ImportFenceWin32HandleInfoKHR = 1000114000,
        ExportFenceWin32HandleInfoKHR = 1000114001,
        FenceGetWin32HandleInfoKHR = 1000114002,
        ImportFenceFdInfoKHR = 1000115000,
        FenceGetFdInfoKHR = 1000115001,
        PhysicalDeviceSurfaceInfo2KHR = 1000119000,
        SurfaceCapabilities2KHR = 1000119001,
        SurfaceFormat2KHR = 1000119002,
        DisplayProperties2KHR = 1000121000,
        DisplayPlaneProperties2KHR = 1000121001,
        DisplayModeProperties2KHR = 1000121002,
        DisplayPlaneInfo2KHR = 1000121003,
        DisplayPlaneCapabilities2KHR = 1000121004,
        IosSurfaceCreateInfoMvk = 1000122000,
        MacosSurfaceCreateInfoMvk = 1000123000,
        DebugUtilsObjectNameInfoExt = 1000128000,
        DebugUtilsObjectTagInfoExt = 1000128001,
        DebugUtilsLabelExt = 1000128002,
        DebugUtilsMessengerCallbackDataExt = 1000128003,
        DebugUtilsMessengerCreateInfoExt = 1000128004,
        AndroidHardwareBufferUsageAndroid = 1000129000,
        AndroidHardwareBufferPropertiesAndroid = 1000129001,
        AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        ImportAndroidHardwareBufferInfoAndroid = 1000129003,
        MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        ExternalFormatAndroid = 1000129005,
        PhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
        SamplerReductionModeCreateInfoExt = 1000130001,
        PhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
        PhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
        WriteDescriptorSetInlineUniformBlockExt = 1000138002,
        DescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
        SampleLocationsInfoExt = 1000143000,
        RenderPassSampleLocationsBeginInfoExt = 1000143001,
        PipelineSampleLocationsStateCreateInfoExt = 1000143002,
        PhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
        MultisamplePropertiesExt = 1000143004,
        ImageFormatListCreateInfoKHR = 1000147000,
        PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
        PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
        PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
        PipelineCoverageToColorStateCreateInfoNv = 1000149000,
        PipelineCoverageModulationStateCreateInfoNv = 1000152000,
        DrmFormatModifierPropertiesListExt = 1000158000,
        DrmFormatModifierPropertiesExt = 1000158001,
        PhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
        ImageDrmFormatModifierListCreateInfoExt = 1000158003,
        ImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
        ImageDrmFormatModifierPropertiesExt = 1000158005,
        ValidationCacheCreateInfoExt = 1000160000,
        ShaderModuleValidationCacheCreateInfoExt = 1000160001,
        DescriptorSetLayoutBindingFlagsCreateInfoExt = 1000161000,
        PhysicalDeviceDescriptorIndexingFeaturesExt = 1000161001,
        PhysicalDeviceDescriptorIndexingPropertiesExt = 1000161002,
        DescriptorSetVariableDescriptorCountAllocateInfoExt = 1000161003,
        DescriptorSetVariableDescriptorCountLayoutSupportExt = 1000161004,
        PipelineViewportShadingRateImageStateCreateInfoNv = 1000164000,
        PhysicalDeviceShadingRateImageFeaturesNv = 1000164001,
        PhysicalDeviceShadingRateImagePropertiesNv = 1000164002,
        PipelineViewportCoarseSampleOrderStateCreateInfoNv = 1000164005,
        RayTracingPipelineCreateInfoNv = 1000165000,
        AccelerationStructureCreateInfoNv = 1000165001,
        GeometryNv = 1000165003,
        GeometryTrianglesNv = 1000165004,
        GeometryAabbNv = 1000165005,
        BindAccelerationStructureMemoryInfoNv = 1000165006,
        WriteDescriptorSetAccelerationStructureNv = 1000165007,
        AccelerationStructureMemoryRequirementsInfoNv = 1000165008,
        PhysicalDeviceRayTracingPropertiesNv = 1000165009,
        RayTracingShaderGroupCreateInfoNv = 1000165011,
        AccelerationStructureInfoNv = 1000165012,
        PhysicalDeviceRepresentativeFragmentTestFeaturesNv = 1000166000,
        PipelineRepresentativeFragmentTestStateCreateInfoNv = 1000166001,
        PhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
        FilterCubicImageViewImageFormatPropertiesExt = 1000170001,
        DeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
        PhysicalDevice8bitStorageFeaturesKHR = 1000177000,
        ImportMemoryHostPointerInfoExt = 1000178000,
        MemoryHostPointerPropertiesExt = 1000178001,
        PhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
        PhysicalDeviceShaderAtomicInt64FeaturesKHR = 1000180000,
        CalibratedTimestampInfoExt = 1000184000,
        PhysicalDeviceShaderCorePropertiesAmd = 1000185000,
        DeviceMemoryOverallocationCreateInfoAmd = 1000189000,
        PhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
        PipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
        PhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
        PresentFrameTokenGgp = 1000191000,
        PipelineCreationFeedbackCreateInfoExt = 1000192000,
        PhysicalDeviceDriverPropertiesKHR = 1000196000,
        PhysicalDeviceFloatControlsPropertiesKHR = 1000197000,
        PhysicalDeviceDepthStencilResolvePropertiesKHR = 1000199000,
        SubpassDescriptionDepthStencilResolveKHR = 1000199001,
        PhysicalDeviceComputeShaderDerivativesFeaturesNv = 1000201000,
        PhysicalDeviceMeshShaderFeaturesNv = 1000202000,
        PhysicalDeviceMeshShaderPropertiesNv = 1000202001,
        PhysicalDeviceFragmentShaderBarycentricFeaturesNv = 1000203000,
        PhysicalDeviceShaderImageFootprintFeaturesNv = 1000204000,
        PipelineViewportExclusiveScissorStateCreateInfoNv = 1000205000,
        PhysicalDeviceExclusiveScissorFeaturesNv = 1000205002,
        CheckpointDataNv = 1000206000,
        QueueFamilyCheckpointPropertiesNv = 1000206001,
        PhysicalDeviceVulkanMemoryModelFeaturesKHR = 1000211000,
        PhysicalDevicePciBusInfoPropertiesExt = 1000212000,
        DisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
        SwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
        ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        MetalSurfaceCreateInfoExt = 1000217000,
        PhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
        PhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
        RenderPassFragmentDensityMapCreateInfoExt = 1000218002,
        PhysicalDeviceScalarBlockLayoutFeaturesExt = 1000221000,
        PhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
        PhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
        MemoryPriorityAllocateInfoExt = 1000238001,
        SurfaceProtectedCapabilitiesKHR = 1000239000,
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv = 1000240000,
        PhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
        BufferDeviceAddressInfoExt = 1000244001,
        BufferDeviceAddressCreateInfoExt = 1000244002,
        ImageStencilUsageCreateInfoExt = 1000246000,
        ValidationFeaturesExt = 1000247000,
        PhysicalDeviceCooperativeMatrixFeaturesNv = 1000249000,
        CooperativeMatrixPropertiesNv = 1000249001,
        PhysicalDeviceCooperativeMatrixPropertiesNv = 1000249002,
        PhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
        SurfaceFullScreenExclusiveInfoExt = 1000255000,
        SurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
        SurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
        PhysicalDeviceHostQueryResetFeaturesExt = 1000261000,
        PhysicalDeviceVariablePointerFeatures = PhysicalDeviceVariablePointersFeatures,
        PhysicalDeviceShaderDrawParameterFeatures = PhysicalDeviceShaderDrawParametersFeatures,
        DebugReportCreateInfoExt = DebugReportCallbackCreateInfoExt,
        RenderPassMultiviewCreateInfoKHR = RenderPassMultiviewCreateInfo,
        PhysicalDeviceMultiviewFeaturesKHR = PhysicalDeviceMultiviewFeatures,
        PhysicalDeviceMultiviewPropertiesKHR = PhysicalDeviceMultiviewProperties,
        PhysicalDeviceFeatures2KHR = PhysicalDeviceFeatures2,
        PhysicalDeviceProperties2KHR = PhysicalDeviceProperties2,
        FormatProperties2KHR = FormatProperties2,
        ImageFormatProperties2KHR = ImageFormatProperties2,
        PhysicalDeviceImageFormatInfo2KHR = PhysicalDeviceImageFormatInfo2,
        QueueFamilyProperties2KHR = QueueFamilyProperties2,
        PhysicalDeviceMemoryProperties2KHR = PhysicalDeviceMemoryProperties2,
        SparseImageFormatProperties2KHR = SparseImageFormatProperties2,
        PhysicalDeviceSparseImageFormatInfo2KHR = PhysicalDeviceSparseImageFormatInfo2,
        MemoryAllocateFlagsInfoKHR = MemoryAllocateFlagsInfo,
        DeviceGroupRenderPassBeginInfoKHR = DeviceGroupRenderPassBeginInfo,
        DeviceGroupCommandBufferBeginInfoKHR = DeviceGroupCommandBufferBeginInfo,
        DeviceGroupSubmitInfoKHR = DeviceGroupSubmitInfo,
        DeviceGroupBindSparseInfoKHR = DeviceGroupBindSparseInfo,
        BindBufferMemoryDeviceGroupInfoKHR = BindBufferMemoryDeviceGroupInfo,
        BindImageMemoryDeviceGroupInfoKHR = BindImageMemoryDeviceGroupInfo,
        PhysicalDeviceGroupPropertiesKHR = PhysicalDeviceGroupProperties,
        DeviceGroupDeviceCreateInfoKHR = DeviceGroupDeviceCreateInfo,
        PhysicalDeviceExternalImageFormatInfoKHR = PhysicalDeviceExternalImageFormatInfo,
        ExternalImageFormatPropertiesKHR = ExternalImageFormatProperties,
        PhysicalDeviceExternalBufferInfoKHR = PhysicalDeviceExternalBufferInfo,
        ExternalBufferPropertiesKHR = ExternalBufferProperties,
        PhysicalDeviceIdPropertiesKHR = PhysicalDeviceIdProperties,
        ExternalMemoryBufferCreateInfoKHR = ExternalMemoryBufferCreateInfo,
        ExternalMemoryImageCreateInfoKHR = ExternalMemoryImageCreateInfo,
        ExportMemoryAllocateInfoKHR = ExportMemoryAllocateInfo,
        PhysicalDeviceExternalSemaphoreInfoKHR = PhysicalDeviceExternalSemaphoreInfo,
        ExternalSemaphorePropertiesKHR = ExternalSemaphoreProperties,
        ExportSemaphoreCreateInfoKHR = ExportSemaphoreCreateInfo,
        PhysicalDevice16bitStorageFeaturesKHR = PhysicalDevice16bitStorageFeatures,
        DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,
        // [Duplicated] SurfaceCapabilities2Ext = SurfaceCapabilities2Ext,
        PhysicalDeviceExternalFenceInfoKHR = PhysicalDeviceExternalFenceInfo,
        ExternalFencePropertiesKHR = ExternalFenceProperties,
        ExportFenceCreateInfoKHR = ExportFenceCreateInfo,
        PhysicalDevicePointClippingPropertiesKHR = PhysicalDevicePointClippingProperties,
        RenderPassInputAttachmentAspectCreateInfoKHR = RenderPassInputAttachmentAspectCreateInfo,
        ImageViewUsageCreateInfoKHR = ImageViewUsageCreateInfo,
        PipelineTessellationDomainOriginStateCreateInfoKHR = PipelineTessellationDomainOriginStateCreateInfo,
        PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointerFeatures,
        PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointerFeatures,
        MemoryDedicatedRequirementsKHR = MemoryDedicatedRequirements,
        MemoryDedicatedAllocateInfoKHR = MemoryDedicatedAllocateInfo,
        BufferMemoryRequirementsInfo2KHR = BufferMemoryRequirementsInfo2,
        ImageMemoryRequirementsInfo2KHR = ImageMemoryRequirementsInfo2,
        ImageSparseMemoryRequirementsInfo2KHR = ImageSparseMemoryRequirementsInfo2,
        MemoryRequirements2KHR = MemoryRequirements2,
        SparseImageMemoryRequirements2KHR = SparseImageMemoryRequirements2,
        SamplerYcbcrConversionCreateInfoKHR = SamplerYcbcrConversionCreateInfo,
        SamplerYcbcrConversionInfoKHR = SamplerYcbcrConversionInfo,
        BindImagePlaneMemoryInfoKHR = BindImagePlaneMemoryInfo,
        ImagePlaneMemoryRequirementsInfoKHR = ImagePlaneMemoryRequirementsInfo,
        PhysicalDeviceSamplerYcbcrConversionFeaturesKHR = PhysicalDeviceSamplerYcbcrConversionFeatures,
        SamplerYcbcrConversionImageFormatPropertiesKHR = SamplerYcbcrConversionImageFormatProperties,
        BindBufferMemoryInfoKHR = BindBufferMemoryInfo,
        BindImageMemoryInfoKHR = BindImageMemoryInfo,
        PhysicalDeviceMaintenance3PropertiesKHR = PhysicalDeviceMaintenance3Properties,
        DescriptorSetLayoutSupportKHR = DescriptorSetLayoutSupport,
        PhysicalDeviceBufferAddressFeaturesExt = PhysicalDeviceBufferDeviceAddressFeaturesExt,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 127
    /// <summary>VkSubgroupFeatureFlagBits - Enum describing what subgroup operations are supported</summary>
    [Flags]
    public enum VkSubgroupFeatureFlagBits {
        Basic = 0x00000001,
        Vote = 0x00000002,
        Arithmetic = 0x00000004,
        Ballot = 0x00000008,
        Shuffle = 0x00000010,
        ShuffleRelative = 0x00000020,
        Clustered = 0x00000040,
        Quad = 0x00000080,
        PartitionedNv = 0x00000100,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 128
    /// <summary>VkSubpassContents - Specify how commands in the first subpass of a render pass are provided</summary>
    public enum VkSubpassContents {
        Inline = 0,
        SecondaryCommandBuffers = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 129
    /// <summary>VkSubpassDescriptionFlagBits - Bitmask specifying usage of a subpass</summary>
    [Flags]
    public enum VkSubpassDescriptionFlagBits {
        PerViewAttributesNvx = 0x00000001,
        PerViewPositionXOnlyNvx = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 130
    /// <summary>VkSurfaceCounterFlagBitsEXT - Surface-relative counter types</summary>
    [Flags]
    public enum VkSurfaceCounterFlagBitsEXT {
        VblankExt = 0x00000001,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 131
    /// <summary>VkSurfaceTransformFlagBitsKHR - presentation transforms supported on a device</summary>
    [Flags]
    public enum VkSurfaceTransformFlagBitsKHR {
        IdentityKHR = 0x00000001,
        Rotate90KHR = 0x00000002,
        Rotate180KHR = 0x00000004,
        Rotate270KHR = 0x00000008,
        HorizontalMirrorKHR = 0x00000010,
        HorizontalMirrorRotate90KHR = 0x00000020,
        HorizontalMirrorRotate180KHR = 0x00000040,
        HorizontalMirrorRotate270KHR = 0x00000080,
        InheritKHR = 0x00000100,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 132
    /// <summary>VkSwapchainCreateFlagBitsKHR - Bitmask controlling swapchain creation</summary>
    [Flags]
    public enum VkSwapchainCreateFlagBitsKHR {
        SplitInstanceBindRegionsKHR = 0x00000001,
        ProtectedKHR = 0x00000002,
        MutableFormatKHR = 0x00000004,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 133
    /// <summary>VkSystemAllocationScope - Allocation scope</summary>
    public enum VkSystemAllocationScope {
        Command = 0,
        Object = 1,
        Cache = 2,
        Device = 3,
        Instance = 4,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 134
    /// <summary>VkTessellationDomainOrigin - Enum describing tessellation domain origin</summary>
    public enum VkTessellationDomainOrigin {
        UpperLeft = 0,
        LowerLeft = 1,
        UpperLeftKHR = UpperLeft,
        LowerLeftKHR = LowerLeft,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 135
    /// <summary>VkTimeDomainEXT - Supported time domains</summary>
    public enum VkTimeDomainEXT {
        DeviceExt = 0,
        ClockMonotonicExt = 1,
        ClockMonotonicRawExt = 2,
        QueryPerformanceCounterExt = 3,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 136
    /// <summary>VkValidationCacheHeaderVersionEXT - Encode validation cache version</summary>
    public enum VkValidationCacheHeaderVersionEXT {
        OneExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 137
    /// <summary>VkValidationCheckEXT - Specify validation checks to disable</summary>
    public enum VkValidationCheckEXT {
        AllExt = 0,
        ShadersExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 138
    /// <summary>VkValidationFeatureDisableEXT - Specify validation features to disable</summary>
    public enum VkValidationFeatureDisableEXT {
        AllExt = 0,
        ShadersExt = 1,
        ThreadSafetyExt = 2,
        ApiParametersExt = 3,
        ObjectLifetimesExt = 4,
        CoreChecksExt = 5,
        UniqueHandlesExt = 6,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 139
    /// <summary>VkValidationFeatureEnableEXT - Specify validation features to enable</summary>
    public enum VkValidationFeatureEnableEXT {
        GpuAssistedExt = 0,
        GpuAssistedReserveBindingSlotExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 140
    /// <summary>VkVendorId - Khronos vendor IDs</summary>
    public enum VkVendorId {
        Viv = 0x10001,
        Vsi = 0x10002,
        Kazan = 0x10003,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 141
    /// <summary>VkVertexInputRate - Specify rate at which vertex attributes are pulled from buffers</summary>
    public enum VkVertexInputRate {
        Vertex = 0,
        Instance = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 142
    /// <summary>VkViewportCoordinateSwizzleNV - Specify how a viewport coordinate is swizzled</summary>
    public enum VkViewportCoordinateSwizzleNV {
        PositiveXNv = 0,
        NegativeXNv = 1,
        PositiveYNv = 2,
        NegativeYNv = 3,
        PositiveZNv = 4,
        NegativeZNv = 5,
        PositiveWNv = 6,
        NegativeWNv = 7,
        MaxEnumNv = 0x7FFFFFFF,
    }

}
