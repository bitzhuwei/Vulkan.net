using System;

namespace Vulkan {
    // Enum: 0
    /// <summary>VkAccelerationStructureMemoryRequirementsTypeNV - Acceleration structure memory requirement type</summary>
    public enum VkAccelerationStructureMemoryRequirementsTypeNV {
        /// <summary>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV
        /// requests the memory requirement for the VkAccelerationStructureNV
        /// backing store.</summary>
        ObjectNv = 0,
        /// <summary>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV
        /// requests the memory requirement for scratch space during the initial
        /// build.</summary>
        BuildScratchNv = 1,
        /// <summary>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV
        /// requests the memory requirement for scratch space during an update.</summary>
        UpdateScratchNv = 2,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 1
    /// <summary>VkAccelerationStructureTypeNV - Type of acceleration structure</summary>
    public enum VkAccelerationStructureTypeNV {
        /// <summary>VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV is a top-level
        /// acceleration structure containing instance data referring to
        /// bottom-level level acceleration structures.</summary>
        TopLevelNv = 0,
        /// <summary>VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV is a bottom-level
        /// acceleration structure containing the AABBs or geometry to be
        /// intersected.</summary>
        BottomLevelNv = 1,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 2
    /// <summary>VkAccessFlagBits - Bitmask specifying memory access types that will participate in a memory dependency</summary>
    [Flags]
    public enum VkAccessFlagBits {
        /// <summary>VK_ACCESS_INDIRECT_COMMAND_READ_BIT specifies read access to
        /// indirect command data read as part of an indirect drawing or dispatch
        /// command.</summary>
        IndirectCommandRead = 0x00000001,
        /// <summary>VK_ACCESS_INDEX_READ_BIT specifies read access to an index buffer
        /// as part of an indexed drawing command, bound by
        /// vkCmdBindIndexBuffer.</summary>
        IndexRead = 0x00000002,
        /// <summary>VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT specifies read access to a
        /// vertex buffer as part of a drawing command, bound by
        /// vkCmdBindVertexBuffers.</summary>
        VertexAttributeRead = 0x00000004,
        /// <summary>VK_ACCESS_UNIFORM_READ_BIT specifies read access to a
        /// uniform buffer.</summary>
        UniformRead = 0x00000008,
        /// <summary>VK_ACCESS_INPUT_ATTACHMENT_READ_BIT specifies read access to an
        /// input attachment within a render pass during fragment
        /// shading.</summary>
        InputAttachmentRead = 0x00000010,
        /// <summary>VK_ACCESS_SHADER_READ_BIT specifies read access to a
        /// storage buffer,
        /// physical storage buffer,
        /// uniform texel buffer,
        /// storage texel buffer,
        /// sampled image, or
        /// storage image.</summary>
        ShaderRead = 0x00000020,
        /// <summary>VK_ACCESS_SHADER_WRITE_BIT specifies write access to a
        /// storage buffer,
        /// physical storage buffer,
        /// storage texel buffer, or
        /// storage image.</summary>
        ShaderWrite = 0x00000040,
        /// <summary>VK_ACCESS_COLOR_ATTACHMENT_READ_BIT specifies read access to a
        /// color attachment, such as via blending, logic operations, or via certain
        /// subpass load operations.
        /// It does not include advanced blend
        /// operations.</summary>
        ColorAttachmentRead = 0x00000080,
        /// <summary>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT specifies write access to a
        /// color, resolve, or depth/stencil resolve attachment
        /// during a render pass or via certain
        /// subpass load and store operations.</summary>
        ColorAttachmentWrite = 0x00000100,
        /// <summary>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT specifies read access
        /// to a depth/stencil attachment, via depth or stencil operations or via certain
        /// subpass load operations.</summary>
        DepthStencilAttachmentRead = 0x00000200,
        /// <summary>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT specifies write
        /// access to a depth/stencil attachment, via
        /// depth or stencil operations or via certain
        /// subpass load and store operations.</summary>
        DepthStencilAttachmentWrite = 0x00000400,
        /// <summary>VK_ACCESS_TRANSFER_READ_BIT specifies read access to an image or
        /// buffer in a copy operation.</summary>
        TransferRead = 0x00000800,
        /// <summary>VK_ACCESS_TRANSFER_WRITE_BIT specifies write access to an image or
        /// buffer in a clear or copy operation.</summary>
        TransferWrite = 0x00001000,
        /// <summary>VK_ACCESS_HOST_READ_BIT specifies read access by a host operation.
        /// Accesses of this type are not performed through a resource, but directly
        /// on memory.</summary>
        HostRead = 0x00002000,
        /// <summary>VK_ACCESS_HOST_WRITE_BIT specifies write access by a host
        /// operation.
        /// Accesses of this type are not performed through a resource, but directly
        /// on memory.</summary>
        HostWrite = 0x00004000,
        /// <summary>VK_ACCESS_MEMORY_READ_BIT specifies read access via non-specific
        /// entities.
        /// These entities include the Vulkan device and host, but may also include
        /// entities external to the Vulkan device or otherwise not part of the core
        /// Vulkan pipeline.
        /// When included in a destination access mask, makes all available writes
        /// visible to all future read accesses on entities known to the Vulkan
        /// device.</summary>
        MemoryRead = 0x00008000,
        /// <summary>VK_ACCESS_MEMORY_WRITE_BIT specifies write access via non-specific
        /// entities.
        /// These entities include the Vulkan device and host, but may also include
        /// entities external to the Vulkan device or otherwise not part of the core
        /// Vulkan pipeline.
        /// When included in a source access mask, all writes that are performed by
        /// entities known to the Vulkan device are made available.
        /// When included in a destination access mask, makes all available writes
        /// visible to all future write accesses on entities known to the Vulkan
        /// device.</summary>
        MemoryWrite = 0x00010000,
        /// <summary>VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT specifies write access
        /// to a transform feedback buffer made when transform feedback is active.</summary>
        TransformFeedbackWriteExt = 0x02000000,
        /// <summary>VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT specifies read
        /// access to a transform feedback counter buffer which is read when
        /// vkCmdBeginTransformFeedbackEXT executes.</summary>
        TransformFeedbackCounterReadExt = 0x04000000,
        /// <summary>VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT specifies write
        /// access to a transform feedback counter buffer which is written when
        /// vkCmdEndTransformFeedbackEXT executes.</summary>
        TransformFeedbackCounterWriteExt = 0x08000000,
        /// <summary>VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT specifies read access
        /// to a predicate as part of conditional rendering.</summary>
        ConditionalRenderingReadExt = 0x00100000,
        /// <summary>VK_ACCESS_COMMAND_PROCESS_READ_BIT_NVX specifies reads from
        /// VkBuffer inputs to vkCmdProcessCommandsNVX.</summary>
        CommandProcessReadNvx = 0x00020000,
        /// <summary>VK_ACCESS_COMMAND_PROCESS_WRITE_BIT_NVX specifies writes to the
        /// target command buffer in vkCmdProcessCommandsNVX.</summary>
        CommandProcessWriteNvx = 0x00040000,
        /// <summary>VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT is similar to
        /// VK_ACCESS_COLOR_ATTACHMENT_READ_BIT, but also includes
        /// advanced blend operations.</summary>
        ColorAttachmentReadNoncoherentExt = 0x00080000,
        /// <summary>VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV specifies read access to
        /// a shading rate image as part of a drawing command, as bound by
        /// vkCmdBindShadingRateImageNV.</summary>
        ShadingRateImageReadNv = 0x00800000,
        /// <summary>VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV specifies read access
        /// to an acceleration structure as part of a trace or build command.</summary>
        AccelerationStructureReadNv = 0x00200000,
        /// <summary>VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV specifies write
        /// access to an acceleration structure as part of a build command.</summary>
        AccelerationStructureWriteNv = 0x00400000,
        /// <summary>VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT specifies read access
        /// to a fragment density map
        /// attachment during dynamic fragment density
        /// map operations</summary>
        FragmentDensityMapReadExt = 0x01000000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 3
    /// <summary>VkAttachmentDescriptionFlagBits - Bitmask specifying additional properties of an attachment</summary>
    [Flags]
    public enum VkAttachmentDescriptionFlagBits {
        /// <summary>VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT specifies that the
        /// attachment aliases the same device memory as other attachments.</summary>
        MayAlias = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 4
    /// <summary>VkAttachmentLoadOp - Specify how contents of an attachment are treated at the beginning of a subpass</summary>
    public enum VkAttachmentLoadOp {
        /// <summary>VK_ATTACHMENT_LOAD_OP_LOAD specifies that the previous contents of
        /// the image within the render area will be preserved.
        /// For attachments with a depth/stencil format, this uses the access type
        /// VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT.
        /// For attachments with a color format, this uses the access type
        /// VK_ACCESS_COLOR_ATTACHMENT_READ_BIT.</summary>
        Load = 0,
        /// <summary>VK_ATTACHMENT_LOAD_OP_CLEAR specifies that the contents within the
        /// render area will be cleared to a uniform value, which is specified when
        /// a render pass instance is begun.
        /// For attachments with a depth/stencil format, this uses the access type
        /// VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT.
        /// For attachments with a color format, this uses the access type
        /// VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.</summary>
        Clear = 1,
        /// <summary>VK_ATTACHMENT_LOAD_OP_DONT_CARE specifies that the previous
        /// contents within the area need not be preserved; the contents of the
        /// attachment will be undefined inside the render area.
        /// For attachments with a depth/stencil format, this uses the access type
        /// VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT.
        /// For attachments with a color format, this uses the access type
        /// VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.</summary>
        DontCare = 2,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 5
    /// <summary>VkAttachmentStoreOp - Specify how contents of an attachment are treated at the end of a subpass</summary>
    public enum VkAttachmentStoreOp {
        /// <summary>VK_ATTACHMENT_STORE_OP_STORE specifies the contents generated
        /// during the render pass and within the render area are written to memory.
        /// For attachments with a depth/stencil format, this uses the access type
        /// VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT.
        /// For attachments with a color format, this uses the access type
        /// VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.</summary>
        Store = 0,
        /// <summary>VK_ATTACHMENT_STORE_OP_DONT_CARE specifies the contents within the
        /// render area are not needed after rendering, and may be discarded; the
        /// contents of the attachment will be undefined inside the render area.
        /// For attachments with a depth/stencil format, this uses the access type
        /// VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT.
        /// For attachments with a color format, this uses the access type
        /// VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.</summary>
        DontCare = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 6
    /// <summary>VkBlendFactor - Framebuffer blending factors</summary>
    public enum VkBlendFactor {
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ZERO</summary>
        Zero = 0,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE</summary>
        One = 1,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_SRC_COLOR</summary>
        SrcColor = 2,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR</summary>
        OneMinusSrcColor = 3,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_DST_COLOR</summary>
        DstColor = 4,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR</summary>
        OneMinusDstColor = 5,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_SRC_ALPHA</summary>
        SrcAlpha = 6,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA</summary>
        OneMinusSrcAlpha = 7,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_DST_ALPHA</summary>
        DstAlpha = 8,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA</summary>
        OneMinusDstAlpha = 9,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_CONSTANT_COLOR</summary>
        ConstantColor = 10,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR</summary>
        OneMinusConstantColor = 11,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_CONSTANT_ALPHA</summary>
        ConstantAlpha = 12,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA</summary>
        OneMinusConstantAlpha = 13,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_SRC_ALPHA_SATURATE</summary>
        SrcAlphaSaturate = 14,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_SRC1_COLOR</summary>
        Src1Color = 15,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR</summary>
        OneMinusSrc1Color = 16,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_SRC1_ALPHA</summary>
        Src1Alpha = 17,
        /// <summary>class="tableblock"
        ///   VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA</summary>
        OneMinusSrc1Alpha = 18,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 7
    /// <summary>VkBlendOp - Framebuffer blending operations</summary>
    public enum VkBlendOp {
        /// <summary>class="tableblock"
        ///   VK_BLEND_OP_ADD</summary>
        Add = 0,
        /// <summary>class="tableblock"
        ///   VK_BLEND_OP_SUBTRACT</summary>
        Subtract = 1,
        /// <summary>class="tableblock"
        ///   VK_BLEND_OP_REVERSE_SUBTRACT</summary>
        ReverseSubtract = 2,
        /// <summary>class="tableblock"
        ///   VK_BLEND_OP_MIN</summary>
        Min = 3,
        /// <summary>class="tableblock"
        ///   VK_BLEND_OP_MAX</summary>
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
        /// <summary>VK_BLEND_OVERLAP_UNCORRELATED_EXT specifies that there is no
        /// correlation between the source and destination coverage.</summary>
        UncorrelatedExt = 0,
        /// <summary>VK_BLEND_OVERLAP_DISJOINT_EXT specifies that the source and
        /// destination coverage are considered to have minimal overlap.</summary>
        DisjointExt = 1,
        /// <summary>VK_BLEND_OVERLAP_CONJOINT_EXT specifies that the source and
        /// destination coverage are considered to have maximal overlap.</summary>
        ConjointExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 9
    /// <summary>VkBorderColor - Specify border color used for texture lookups</summary>
    public enum VkBorderColor {
        /// <summary>VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK specifies a transparent,
        /// floating-point format, black color.</summary>
        FloatTransparentBlack = 0,
        /// <summary>VK_BORDER_COLOR_INT_TRANSPARENT_BLACK specifies a transparent,
        /// integer format, black color.</summary>
        IntTransparentBlack = 1,
        /// <summary>VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK specifies an opaque,
        /// floating-point format, black color.</summary>
        FloatOpaqueBlack = 2,
        /// <summary>VK_BORDER_COLOR_INT_OPAQUE_BLACK specifies an opaque, integer
        /// format, black color.</summary>
        IntOpaqueBlack = 3,
        /// <summary>VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE specifies an opaque,
        /// floating-point format, white color.</summary>
        FloatOpaqueWhite = 4,
        /// <summary>VK_BORDER_COLOR_INT_OPAQUE_WHITE specifies an opaque, integer
        /// format, white color.</summary>
        IntOpaqueWhite = 5,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 10
    /// <summary>VkBufferCreateFlagBits - Bitmask specifying additional parameters of a buffer</summary>
    [Flags]
    public enum VkBufferCreateFlagBits {
        /// <summary>VK_BUFFER_CREATE_SPARSE_BINDING_BIT specifies that the buffer will
        /// be backed using sparse memory binding.</summary>
        SparseBinding = 0x00000001,
        /// <summary>VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT specifies that the buffer
        /// can be partially backed using sparse memory binding.
        /// Buffers created with this flag must also be created with the
        /// VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.</summary>
        SparseResidency = 0x00000002,
        /// <summary>VK_BUFFER_CREATE_SPARSE_ALIASED_BIT specifies that the buffer will
        /// be backed using sparse memory binding with memory ranges that might also
        /// simultaneously be backing another buffer (or another portion of the same
        /// buffer).
        /// Buffers created with this flag must also be created with the
        /// VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.</summary>
        SparseAliased = 0x00000004,
        /// <summary>VK_BUFFER_CREATE_PROTECTED_BIT specifies that the buffer is a
        /// protected buffer.</summary>
        Protected = 0x00000008,
        /// <summary>VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT specifies
        /// that the buffer¡¯s address can be saved and reused on a subsequent run
        /// (e.g. for trace capture and replay), see
        /// VkBufferDeviceAddressCreateInfoEXT for more detail.</summary>
        DeviceAddressCaptureReplayExt = 0x00000010,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 11
    /// <summary>VkBufferUsageFlagBits - Bitmask specifying allowed usage of a buffer</summary>
    [Flags]
    public enum VkBufferUsageFlagBits {
        /// <summary>VK_BUFFER_USAGE_TRANSFER_SRC_BIT specifies that the buffer can be
        /// used as the source of a transfer command (see the definition of
        /// VK_PIPELINE_STAGE_TRANSFER_BIT).</summary>
        TransferSrc = 0x00000001,
        /// <summary>VK_BUFFER_USAGE_TRANSFER_DST_BIT specifies that the buffer can be
        /// used as the destination of a transfer command.</summary>
        TransferDst = 0x00000002,
        /// <summary>VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT specifies that the buffer
        /// can be used to create a VkBufferView suitable for occupying a
        /// VkDescriptorSet slot of type
        /// VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER.</summary>
        UniformTexelBuffer = 0x00000004,
        /// <summary>VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT specifies that the buffer
        /// can be used to create a VkBufferView suitable for occupying a
        /// VkDescriptorSet slot of type
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER.</summary>
        StorageTexelBuffer = 0x00000008,
        /// <summary>VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT specifies that the buffer can
        /// be used in a VkDescriptorBufferInfo suitable for occupying a
        /// VkDescriptorSet slot either of type
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.</summary>
        UniformBuffer = 0x00000010,
        /// <summary>VK_BUFFER_USAGE_STORAGE_BUFFER_BIT specifies that the buffer can
        /// be used in a VkDescriptorBufferInfo suitable for occupying a
        /// VkDescriptorSet slot either of type
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.</summary>
        StorageBuffer = 0x00000020,
        /// <summary>VK_BUFFER_USAGE_INDEX_BUFFER_BIT specifies that the buffer is
        /// suitable for passing as the buffer parameter to
        /// vkCmdBindIndexBuffer.</summary>
        IndexBuffer = 0x00000040,
        /// <summary>VK_BUFFER_USAGE_VERTEX_BUFFER_BIT specifies that the buffer is
        /// suitable for passing as an element of the pBuffers array to
        /// vkCmdBindVertexBuffers.</summary>
        VertexBuffer = 0x00000080,
        /// <summary>VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT specifies that the buffer is
        /// suitable for passing as the buffer parameter to
        /// vkCmdDrawIndirect, vkCmdDrawIndexedIndirect,
        /// vkCmdDrawMeshTasksIndirectNV,
        /// vkCmdDrawMeshTasksIndirectCountNV,
        /// or vkCmdDispatchIndirect.
        /// It is also suitable for passing as the buffer member of
        /// VkIndirectCommandsTokenNVX, or sequencesCountBuffer or
        /// sequencesIndexBuffer member of VkCmdProcessCommandsInfoNVX</summary>
        IndirectBuffer = 0x00000100,
        /// <summary>VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT specifies that
        /// the buffer is suitable for using for binding as a transform feedback
        /// buffer with vkCmdBindTransformFeedbackBuffersEXT.</summary>
        TransformFeedbackBufferExt = 0x00000800,
        /// <summary>VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT
        /// specifies that the buffer is suitable for using as a counter buffer with
        /// vkCmdBeginTransformFeedbackEXT and
        /// vkCmdEndTransformFeedbackEXT.</summary>
        TransformFeedbackCounterBufferExt = 0x00001000,
        /// <summary>VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT specifies that the
        /// buffer is suitable for passing as the buffer parameter to
        /// vkCmdBeginConditionalRenderingEXT.</summary>
        ConditionalRenderingExt = 0x00000200,
        /// <summary>VK_BUFFER_USAGE_RAY_TRACING_BIT_NV specifies that the buffer is
        /// suitable for use in vkCmdTraceRaysNV and
        /// vkCmdBuildAccelerationStructureNV.</summary>
        RayTracingNv = 0x00000400,
        /// <summary>VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT specifies that the
        /// buffer can be used to retrieve a buffer device address via
        /// vkGetBufferDeviceAddressEXT and use that address to access the
        /// buffer¡¯s memory from a shader.</summary>
        ShaderDeviceAddressExt = 0x00020000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 12
    /// <summary>VkBuildAccelerationStructureFlagBitsNV - Bitmask specifying additional parameters for acceleration structure builds</summary>
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsNV {
        /// <summary>VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV indicates that
        /// the specified acceleration structure can be updated with update
        /// of VK_TRUE in vkCmdBuildAccelerationStructureNV.</summary>
        AllowUpdateNv = 0x00000001,
        /// <summary>VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV indicates
        /// that the specified acceleration structure can act as the source for
        /// vkCmdCopyAccelerationStructureNV with mode of
        /// VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV to produce a
        /// compacted acceleration structure.</summary>
        AllowCompactionNv = 0x00000002,
        /// <summary>VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV indicates
        /// that the given acceleration structure build should prioritize trace
        /// performance over build time.</summary>
        PreferFastTraceNv = 0x00000004,
        /// <summary>VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV indicates
        /// that the given acceleration structure build should prioritize build
        /// time over trace performance.</summary>
        PreferFastBuildNv = 0x00000008,
        /// <summary>VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV indicates that
        /// this acceleration structure should minimize the size of the scratch
        /// memory and the final result build, potentially at the expense of build
        /// time or trace performance.</summary>
        LowMemoryNv = 0x00000010,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 13
    /// <summary>VkChromaLocation - Position of downsampled chroma samples</summary>
    public enum VkChromaLocation {
        /// <summary>VK_CHROMA_LOCATION_COSITED_EVEN specifies that downsampled chroma
        /// samples are aligned with luma samples with even coordinates.</summary>
        CositedEven = 0,
        /// <summary>VK_CHROMA_LOCATION_MIDPOINT specifies that downsampled chroma
        /// samples are located half way between each even luma sample and the
        /// nearest higher odd luma sample.</summary>
        Midpoint = 1,
        CositedEvenKHR = CositedEven,
        MidpointKHR = Midpoint,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 14
    /// <summary>VkCoarseSampleOrderTypeNV - Shading rate image sample ordering types</summary>
    public enum VkCoarseSampleOrderTypeNV {
        /// <summary>VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV specifies that coverage
        /// samples will be ordered in an implementation-dependent manner.</summary>
        DefaultNv = 0,
        /// <summary>VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV specifies that coverage
        /// samples will be ordered according to the array of custom orderings
        /// provided in either the pCustomSampleOrders member of
        /// VkPipelineViewportCoarseSampleOrderStateCreateInfoNV or the
        /// pCustomSampleOrders member of vkCmdSetCoarseSampleOrderNV.</summary>
        CustomNv = 1,
        /// <summary>VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV specifies that coverage
        /// samples will be ordered sequentially, sorted first by pixel coordinate
        /// (in row-major order) and then by coverage sample number.</summary>
        PixelMajorNv = 2,
        /// <summary>VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV specifies that
        /// coverage samples will be ordered sequentially, sorted first by coverage
        /// sample number and then by pixel coordinate (in row-major order).</summary>
        SampleMajorNv = 3,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 15
    /// <summary>VkColorComponentFlagBits - Bitmask controlling which components are written to the framebuffer</summary>
    [Flags]
    public enum VkColorComponentFlagBits {
        /// <summary>VK_COLOR_COMPONENT_R_BIT specifies that the R value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        R = 0x00000001,
        /// <summary>VK_COLOR_COMPONENT_G_BIT specifies that the G value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        G = 0x00000002,
        /// <summary>VK_COLOR_COMPONENT_B_BIT specifies that the B value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        B = 0x00000004,
        /// <summary>VK_COLOR_COMPONENT_A_BIT specifies that the A value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        A = 0x00000008,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 16
    /// <summary>VkColorSpaceKHR - supported color space of the presentation engine</summary>
    public enum VkColorSpaceKHR {
        /// <summary>VK_COLOR_SPACE_SRGB_NONLINEAR_KHR specifies support for the sRGB
        /// color space.</summary>
        SrgbNonlinearKHR = 0,
        /// <summary>VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT specifies support for the
        /// Display-P3 color space and applies an sRGB-like transfer function
        /// (defined below).</summary>
        DisplayP3NonlinearExt = 1000104001,
        /// <summary>VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT specifies support for the
        /// extended sRGB color space and applies a linear transfer function.</summary>
        ExtendedSrgbLinearExt = 1000104002,
        /// <summary>VK_COLOR_SPACE_DCI_P3_LINEAR_EXT specifies support for the DCI-P3
        /// color space and applies a linear OETF.</summary>
        DciP3LinearExt = 1000104003,
        /// <summary>VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT specifies support for the
        /// DCI-P3 color space and applies the Gamma 2.6 OETF.</summary>
        DciP3NonlinearExt = 1000104004,
        /// <summary>VK_COLOR_SPACE_BT709_LINEAR_EXT specifies support for the BT709
        /// color space and applies a linear OETF.</summary>
        Bt709LinearExt = 1000104005,
        /// <summary>VK_COLOR_SPACE_BT709_NONLINEAR_EXT specifies support for the BT709
        /// color space and applies the SMPTE 170M OETF.</summary>
        Bt709NonlinearExt = 1000104006,
        /// <summary>VK_COLOR_SPACE_BT2020_LINEAR_EXT specifies support for the BT2020
        /// color space and applies a linear OETF.</summary>
        Bt2020LinearExt = 1000104007,
        /// <summary>VK_COLOR_SPACE_HDR10_ST2084_EXT specifies support for the HDR10
        /// (BT2020 color) space and applies the SMPTE ST2084 Perceptual Quantizer
        /// (PQ) OETF.</summary>
        Hdr10St2084Ext = 1000104008,
        /// <summary>VK_COLOR_SPACE_DOLBYVISION_EXT specifies support for the Dolby
        /// Vision (BT2020 color space), proprietary encoding, and applies the SMPTE
        /// ST2084 OETF.</summary>
        DolbyvisionExt = 1000104009,
        /// <summary>VK_COLOR_SPACE_HDR10_HLG_EXT specifies support for the HDR10
        /// (BT2020 color space) and applies the Hybrid Log Gamma (HLG) OETF.</summary>
        Hdr10HlgExt = 1000104010,
        /// <summary>VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT specifies support for the
        /// AdobeRGB color space and applies a linear OETF.</summary>
        AdobergbLinearExt = 1000104011,
        /// <summary>VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT specifies support for the
        /// AdobeRGB color space and applies the Gamma 2.2 OETF.</summary>
        AdobergbNonlinearExt = 1000104012,
        /// <summary>VK_COLOR_SPACE_PASS_THROUGH_EXT specifies that color components
        /// are used ¡°as is¡±.
        /// This is intended to allow applications to supply data for color spaces
        /// not described here.</summary>
        PassThroughExt = 1000104013,
        /// <summary>VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT specifies support for
        /// the extended sRGB color space and applies an sRGB transfer function.</summary>
        ExtendedSrgbNonlinearExt = 1000104014,
        /// <summary>VK_COLOR_SPACE_DISPLAY_NATIVE_AMD specifies support for the
        /// display¡¯s native color space.
        /// This matches the color space expectations of AMD¡¯s FreeSync2 standard,
        /// for displays supporting it.</summary>
        DisplayNativeAmd = 1000213000,

        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 17
    /// <summary>VkCommandBufferLevel - Enumerant specifying a command buffer level</summary>
    public enum VkCommandBufferLevel {
        /// <summary>VK_COMMAND_BUFFER_LEVEL_PRIMARY specifies a primary command
        /// buffer.</summary>
        Primary = 0,
        /// <summary>VK_COMMAND_BUFFER_LEVEL_SECONDARY specifies a secondary command
        /// buffer.</summary>
        Secondary = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 18
    /// <summary>VkCommandBufferResetFlagBits - Bitmask controlling behavior of a command buffer reset</summary>
    [Flags]
    public enum VkCommandBufferResetFlagBits {
        /// <summary>VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT specifies that most
        /// or all memory resources currently owned by the command buffer should be
        /// returned to the parent command pool.
        /// If this flag is not set, then the command buffer may hold onto memory
        /// resources and reuse them when recording commands.
        /// commandBuffer is moved to the initial
        /// state.</summary>
        ReleaseResources = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 19
    /// <summary>VkCommandBufferUsageFlagBits - Bitmask specifying usage behavior for command buffer</summary>
    [Flags]
    public enum VkCommandBufferUsageFlagBits {
        /// <summary>VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT specifies that each
        /// recording of the command buffer will only be submitted once, and the
        /// command buffer will be reset and recorded again between each submission.</summary>
        OneTimeSubmit = 0x00000001,
        /// <summary>VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT specifies that a
        /// secondary command buffer is considered to be entirely inside a render
        /// pass.
        /// If this is a primary command buffer, then this bit is ignored.</summary>
        RenderPassContinue = 0x00000002,
        /// <summary>VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT specifies that a
        /// command buffer can be resubmitted to a queue while it is in the
        /// pending state, and recorded into multiple primary command buffers.</summary>
        SimultaneousUse = 0x00000004,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 20
    /// <summary>VkCommandPoolCreateFlagBits - Bitmask specifying usage behavior for a command pool</summary>
    [Flags]
    public enum VkCommandPoolCreateFlagBits {
        /// <summary>VK_COMMAND_POOL_CREATE_TRANSIENT_BIT specifies that command
        /// buffers allocated from the pool will be short-lived, meaning that they
        /// will be reset or freed in a relatively short timeframe.
        /// This flag may be used by the implementation to control memory
        /// allocation behavior within the pool.</summary>
        Transient = 0x00000001,
        /// <summary>VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT allows any command
        /// buffer allocated from a pool to be individually reset to the
        /// initial state; either by calling
        /// vkResetCommandBuffer, or via the implicit reset when calling
        /// vkBeginCommandBuffer.
        /// If this flag is not set on a pool, then vkResetCommandBuffermust
        /// not be called for any command buffer allocated from that pool.</summary>
        ResetCommandBuffer = 0x00000002,
        /// <summary>VK_COMMAND_POOL_CREATE_PROTECTED_BIT specifies that command
        /// buffers allocated from the pool are protected command buffers.
        /// If the protected memory feature is not enabled, the
        /// VK_COMMAND_POOL_CREATE_PROTECTED_BIT bit of flagsmust not
        /// be set.</summary>
        Protected = 0x00000004,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 21
    /// <summary>VkCommandPoolResetFlagBits - Bitmask controlling behavior of a command pool reset</summary>
    [Flags]
    public enum VkCommandPoolResetFlagBits {
        /// <summary>VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT specifies that
        /// resetting a command pool recycles all of the resources from the command
        /// pool back to the system.</summary>
        ReleaseResources = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 22
    /// <summary>VkCompareOp - Stencil comparison function</summary>
    public enum VkCompareOp {
        /// <summary>VK_COMPARE_OP_NEVER specifies that the test never passes.</summary>
        Never = 0,
        /// <summary>VK_COMPARE_OP_LESS specifies that the test passes when R &lt;
        /// S.</summary>
        Less = 1,
        /// <summary>VK_COMPARE_OP_EQUAL specifies that the test passes when R =
        /// S.</summary>
        Equal = 2,
        /// <summary>VK_COMPARE_OP_LESS_OR_EQUAL specifies that the test passes when
        /// R ¡Ü S.</summary>
        LessOrEqual = 3,
        /// <summary>VK_COMPARE_OP_GREATER specifies that the test passes when R &gt;
        /// S.</summary>
        Greater = 4,
        /// <summary>VK_COMPARE_OP_NOT_EQUAL specifies that the test passes when R
        /// ¡Ù S.</summary>
        NotEqual = 5,
        /// <summary>VK_COMPARE_OP_GREATER_OR_EQUAL specifies that the test passes when
        /// R ¡Ý S.</summary>
        GreaterOrEqual = 6,
        /// <summary>VK_COMPARE_OP_ALWAYS specifies that the test always passes.</summary>
        Always = 7,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 23
    /// <summary>VkComponentSwizzle - Specify how a component is swizzled</summary>
    public enum VkComponentSwizzle {
        /// <summary>VK_COMPONENT_SWIZZLE_IDENTITY specifies that the component is set
        /// to the identity swizzle.</summary>
        Identity = 0,
        /// <summary>VK_COMPONENT_SWIZZLE_ZERO specifies that the component is set to
        /// zero.</summary>
        Zero = 1,
        /// <summary>VK_COMPONENT_SWIZZLE_ONE specifies that the component is set to
        /// either 1 or 1.0, depending on whether the type of the image view format
        /// is integer or floating-point respectively, as determined by the
        /// Format Definition section for each
        /// VkFormat.</summary>
        One = 2,
        /// <summary>VK_COMPONENT_SWIZZLE_R specifies that the component is set to the
        /// value of the R component of the image.</summary>
        R = 3,
        /// <summary>VK_COMPONENT_SWIZZLE_G specifies that the component is set to the
        /// value of the G component of the image.</summary>
        G = 4,
        /// <summary>VK_COMPONENT_SWIZZLE_B specifies that the component is set to the
        /// value of the B component of the image.</summary>
        B = 5,
        /// <summary>VK_COMPONENT_SWIZZLE_A specifies that the component is set to the
        /// value of the A component of the image.</summary>
        A = 6,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 24
    /// <summary>VkComponentTypeNV - Specify SPIR-V cooperative matrix component type</summary>
    public enum VkComponentTypeNV {
        /// <summary>VK_COMPONENT_TYPE_FLOAT16_NV corresponds to SPIR-V
        /// OpTypeFloat 16.</summary>
        Float16Nv = 0,
        /// <summary>VK_COMPONENT_TYPE_FLOAT32_NV corresponds to SPIR-V
        /// OpTypeFloat 32.</summary>
        Float32Nv = 1,
        /// <summary>VK_COMPONENT_TYPE_FLOAT64_NV corresponds to SPIR-V
        /// OpTypeFloat 64.</summary>
        Float64Nv = 2,
        /// <summary>VK_COMPONENT_TYPE_SINT8_NV corresponds to SPIR-V OpTypeInt 8
        /// 1.</summary>
        Sint8Nv = 3,
        /// <summary>VK_COMPONENT_TYPE_SINT16_NV corresponds to SPIR-V OpTypeInt
        /// 16 1.</summary>
        Sint16Nv = 4,
        /// <summary>VK_COMPONENT_TYPE_SINT32_NV corresponds to SPIR-V OpTypeInt
        /// 32 1.</summary>
        Sint32Nv = 5,
        /// <summary>VK_COMPONENT_TYPE_SINT64_NV corresponds to SPIR-V OpTypeInt
        /// 64 1.</summary>
        Sint64Nv = 6,
        /// <summary>VK_COMPONENT_TYPE_UINT8_NV corresponds to SPIR-V OpTypeInt 8
        /// 0.</summary>
        Uint8Nv = 7,
        /// <summary>VK_COMPONENT_TYPE_UINT16_NV corresponds to SPIR-V OpTypeInt
        /// 16 0.</summary>
        Uint16Nv = 8,
        /// <summary>VK_COMPONENT_TYPE_UINT32_NV corresponds to SPIR-V OpTypeInt
        /// 32 0.</summary>
        Uint32Nv = 9,
        /// <summary>VK_COMPONENT_TYPE_UINT64_NV corresponds to SPIR-V OpTypeInt
        /// 64 0.</summary>
        Uint64Nv = 10,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 25
    /// <summary>VkCompositeAlphaFlagBitsKHR - alpha compositing modes supported on a device</summary>
    [Flags]
    public enum VkCompositeAlphaFlagBitsKHR {
        /// <summary>VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR: The alpha channel, if it
        /// exists, of the images is ignored in the compositing process.
        /// Instead, the image is treated as if it has a constant alpha of 1.0.</summary>
        OpaqueKHR = 0x00000001,
        /// <summary>VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR: The alpha channel, if
        /// it exists, of the images is respected in the compositing process.
        /// The non-alpha channels of the image are expected to already be
        /// multiplied by the alpha channel by the application.</summary>
        PreMultipliedKHR = 0x00000002,
        /// <summary>VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR: The alpha channel, if
        /// it exists, of the images is respected in the compositing process.
        /// The non-alpha channels of the image are not expected to already be
        /// multiplied by the alpha channel by the application; instead, the
        /// compositor will multiply the non-alpha channels of the image by the
        /// alpha channel during compositing.</summary>
        PostMultipliedKHR = 0x00000004,
        /// <summary>VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR: The way in which the
        /// presentation engine treats the alpha channel in the images is unknown to
        /// the Vulkan API.
        /// Instead, the application is responsible for setting the composite alpha
        /// blending mode using native window system commands.
        /// If the application does not set the blending mode using native window
        /// system commands, then a platform-specific default will be used.</summary>
        InheritKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 26
    /// <summary>VkConditionalRenderingFlagBitsEXT - Specify the behavior of conditional rendering</summary>
    [Flags]
    public enum VkConditionalRenderingFlagBitsEXT {
        /// <summary>VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT specifies the condition
        /// used to determine whether to discard rendering commands or not.
        /// That is, if the 32-bit predicate read from buffer memory at
        /// offset is zero, the rendering commands are not discarded, and if
        /// non zero, then they are discarded.</summary>
        InvertedExt = 0x00000001,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 27
    /// <summary>VkConservativeRasterizationModeEXT - Specify the conservative rasterization mode</summary>
    public enum VkConservativeRasterizationModeEXT {
        /// <summary>VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT specifies that
        /// conservative rasterization is disabled and rasterization proceeds as
        /// normal.</summary>
        DisabledExt = 0,
        /// <summary>VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT specifies that
        /// conservative rasterization is enabled in overestimation mode.</summary>
        OverestimateExt = 1,
        /// <summary>VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT specifies
        /// that conservative rasterization is enabled in underestimation mode.</summary>
        UnderestimateExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 28
    /// <summary>VkCopyAccelerationStructureModeNV - Acceleration structure copy mode</summary>
    public enum VkCopyAccelerationStructureModeNV {
        /// <summary>VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV creates a direct copy
        /// of the acceleration structure specified in src into the one
        /// specified by dst.
        /// The dst acceleration structure must have been created with the
        /// same parameters as src.</summary>
        CloneNv = 0,
        /// <summary>VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV creates a more
        /// compact version of an acceleration structure src into dst.
        /// The acceleration structure dstmust have been created with a
        /// compactedSize corresponding to the one returned by
        /// vkCmdWriteAccelerationStructuresPropertiesNV after the build of
        /// the acceleration structure specified by src.</summary>
        CompactNv = 1,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 29
    /// <summary>VkCoverageModulationModeNV - Specify the discard rectangle mode</summary>
    public enum VkCoverageModulationModeNV {
        /// <summary>VK_COVERAGE_MODULATION_MODE_NONE_NV specifies that no components
        /// are multiplied by the modulation factor.</summary>
        NoneNv = 0,
        /// <summary>VK_COVERAGE_MODULATION_MODE_RGB_NV specifies that the red, green,
        /// and blue components are multiplied by the modulation factor.</summary>
        RgbNv = 1,
        /// <summary>VK_COVERAGE_MODULATION_MODE_ALPHA_NV specifies that the alpha
        /// component is multiplied by the modulation factor.</summary>
        AlphaNv = 2,
        /// <summary>VK_COVERAGE_MODULATION_MODE_RGBA_NV specifies that all components
        /// are multiplied by the modulation factor.</summary>
        RgbaNv = 3,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 30
    /// <summary>VkCullModeFlagBits - Bitmask controlling triangle culling</summary>
    [Flags]
    public enum VkCullModeFlagBits {
        /// <summary>VK_CULL_MODE_NONE specifies that no triangles are discarded</summary>
        None = 0,
        /// <summary>VK_CULL_MODE_FRONT_BIT specifies that front-facing triangles are
        /// discarded</summary>
        Front = 0x00000001,
        /// <summary>VK_CULL_MODE_BACK_BIT specifies that back-facing triangles are
        /// discarded</summary>
        Back = 0x00000002,
        /// <summary>VK_CULL_MODE_FRONT_AND_BACK specifies that all triangles are
        /// discarded.</summary>
        FrontAndBack = 0x00000003,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 31
    /// <summary>VkDebugReportFlagBitsEXT - Bitmask specifying events which cause a debug report callback</summary>
    [Flags]
    public enum VkDebugReportFlagBitsEXT {
        /// <summary>VK_DEBUG_REPORT_INFORMATION_BIT_EXT specifies an informational
        /// message such as resource details that may be handy when debugging an
        /// application.</summary>
        InformationExt = 0x00000001,
        /// <summary>VK_DEBUG_REPORT_WARNING_BIT_EXT specifies use of Vulkan that may
        /// expose an app bug.
        /// Such cases may not be immediately harmful, such as a fragment shader
        /// outputting to a location with no attachment.
        /// Other cases may point to behavior that is almost certainly bad when
        /// unintended such as using an image whose memory has not been filled.
        /// In general if you see a warning but you know that the behavior is
        /// intended/desired, then simply ignore the warning.</summary>
        WarningExt = 0x00000002,
        /// <summary>VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT specifies a
        /// potentially non-optimal use of Vulkan, e.g. using
        /// vkCmdClearColorImage when setting
        /// VkAttachmentDescription::loadOp to
        /// VK_ATTACHMENT_LOAD_OP_CLEAR would have worked.</summary>
        PerformanceWarningExt = 0x00000004,
        /// <summary>VK_DEBUG_REPORT_ERROR_BIT_EXT specifies that the application has
        /// violated a valid usage condition of the specification.</summary>
        ErrorExt = 0x00000008,
        /// <summary>VK_DEBUG_REPORT_DEBUG_BIT_EXT specifies diagnostic information
        /// from the implementation and layers.</summary>
        DebugExt = 0x00000010,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 32
    /// <summary>VkDebugReportObjectTypeEXT - Specify the type of an object handle</summary>
    public enum VkDebugReportObjectTypeEXT {
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT</summary>
        UnknownExt = 0,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT</summary>
        InstanceExt = 1,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT</summary>
        PhysicalDeviceExt = 2,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT</summary>
        DeviceExt = 3,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT</summary>
        QueueExt = 4,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT</summary>
        SemaphoreExt = 5,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT</summary>
        CommandBufferExt = 6,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT</summary>
        FenceExt = 7,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT</summary>
        DeviceMemoryExt = 8,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT</summary>
        BufferExt = 9,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT</summary>
        ImageExt = 10,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT</summary>
        EventExt = 11,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT</summary>
        QueryPoolExt = 12,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT</summary>
        BufferViewExt = 13,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT</summary>
        ImageViewExt = 14,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT</summary>
        ShaderModuleExt = 15,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT</summary>
        PipelineCacheExt = 16,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT</summary>
        PipelineLayoutExt = 17,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT</summary>
        RenderPassExt = 18,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT</summary>
        PipelineExt = 19,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT</summary>
        DescriptorSetLayoutExt = 20,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT</summary>
        SamplerExt = 21,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT</summary>
        DescriptorPoolExt = 22,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT</summary>
        DescriptorSetExt = 23,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT</summary>
        FramebufferExt = 24,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT</summary>
        CommandPoolExt = 25,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT</summary>
        SurfaceKhrExt = 26,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT</summary>
        SwapchainKhrExt = 27,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT</summary>
        DebugReportCallbackExtExt = 28,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT</summary>
        DisplayKhrExt = 29,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT</summary>
        DisplayModeKhrExt = 30,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_OBJECT_TABLE_NVX_EXT</summary>
        ObjectTableNvxExt = 31,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX_EXT</summary>
        IndirectCommandsLayoutNvxExt = 32,
        ValidationCacheExtExt = 33,
        SamplerYcbcrConversionExt = 1000156000,
        /// <summary>class="tableblock"
        ///   VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT</summary>
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
        /// <summary>VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT specifies the most
        /// verbose output indicating all diagnostic messages from the Vulkan
        /// loader, layers, and drivers should be captured.</summary>
        VerboseExt = 0x00000001,
        /// <summary>VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT specifies an
        /// informational message such as resource details that may be handy when
        /// debugging an application.</summary>
        InfoExt = 0x00000010,
        /// <summary>VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT specifies use of
        /// Vulkan that may expose an app bug.
        /// Such cases may not be immediately harmful, such as a fragment shader
        /// outputting to a location with no attachment.
        /// Other cases may point to behavior that is almost certainly bad when
        /// unintended such as using an image whose memory has not been filled.
        /// In general if you see a warning but you know that the behavior is
        /// intended/desired, then simply ignore the warning.</summary>
        WarningExt = 0x00000100,
        /// <summary>VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT specifies that the
        /// application has violated a valid usage condition of the specification.</summary>
        ErrorExt = 0x00001000,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 34
    /// <summary>VkDebugUtilsMessageTypeFlagBitsEXT - Bitmask specifying which types of events cause a debug messenger callback</summary>
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT {
        /// <summary>VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT specifies that some
        /// general event has occurred.
        /// This is typically a non-specification, non-performance event.</summary>
        GeneralExt = 0x00000001,
        /// <summary>VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT specifies that
        /// something has occurred during validation against the Vulkan
        /// specification that may indicate invalid behavior.</summary>
        ValidationExt = 0x00000002,
        /// <summary>VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT specifies a
        /// potentially non-optimal use of Vulkan, e.g. using
        /// vkCmdClearColorImage when setting
        /// VkAttachmentDescription::loadOp to
        /// VK_ATTACHMENT_LOAD_OP_CLEAR would have worked.</summary>
        PerformanceExt = 0x00000004,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 35
    /// <summary>VkDependencyFlagBits - Bitmask specifying how execution and memory dependencies are formed</summary>
    [Flags]
    public enum VkDependencyFlagBits {
        /// <summary>VK_DEPENDENCY_BY_REGION_BIT specifies that dependencies will be
        /// framebuffer-local.</summary>
        ByRegion = 0x00000001,
        /// <summary>VK_DEPENDENCY_DEVICE_GROUP_BIT specifies that dependencies are
        /// non-device-local
        /// dependency.</summary>
        DeviceGroup = 0x00000004,
        /// <summary>VK_DEPENDENCY_VIEW_LOCAL_BIT specifies that a
        /// subpass
        /// has more than one view.</summary>
        ViewLocal = 0x00000002,
        ViewLocalKHR = ViewLocal,
        DeviceGroupKHR = DeviceGroup,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 36
    /// <summary>VkDescriptorBindingFlagBitsEXT - Bitmask specifying descriptor set layout binding properties</summary>
    [Flags]
    public enum VkDescriptorBindingFlagBitsEXT {
        /// <summary>VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT indicates that if
        /// descriptors in this binding are updated between when the descriptor set
        /// is bound in a command buffer and when that command buffer is submitted
        /// to a queue, then the submission will use the most recently set
        /// descriptors for this binding and the updates do not invalidate the
        /// command buffer.
        /// Descriptor bindings created with this flag are also partially exempt
        /// from the external synchronization requirement in
        /// vkUpdateDescriptorSetWithTemplateKHR and
        /// vkUpdateDescriptorSets.
        /// They can be updated concurrently with the set being bound to a command
        /// buffer in another thread, but not concurrently with the set being reset
        /// or freed.</summary>
        UpdateAfterBindExt = 0x00000001,
        /// <summary>VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT
        /// indicates that descriptors in this binding can be updated after a
        /// command buffer has bound this descriptor set, or while a command buffer
        /// that uses this descriptor set is pending execution, as long as the
        /// descriptors that are updated are not used by those command buffers.
        /// If VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT is also set, then
        /// descriptors can be updated as long as they are not dynamically used by
        /// any shader invocations.
        /// If VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT is not set, then
        /// descriptors can be updated as long as they are not statically used by
        /// any shader invocations.</summary>
        UpdateUnusedWhilePendingExt = 0x00000002,
        /// <summary>VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT indicates that
        /// descriptors in this binding that are not dynamically used need not
        /// contain valid descriptors at the time the descriptors are consumed.
        /// A descriptor is dynamically used if any shader invocation executes an
        /// instruction that performs any memory access using the descriptor.</summary>
        PartiallyBoundExt = 0x00000004,
        /// <summary>VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT indicates
        /// that this descriptor binding has a variable size that will be specified
        /// when a descriptor set is allocated using this layout.
        /// The value of descriptorCount is treated as an upper bound on the
        /// size of the binding.
        /// This must only be used for the last binding in the descriptor set
        /// layout (i.e. the binding with the largest value of binding).
        /// For the purposes of counting against limits such as
        /// maxDescriptorSet* and maxPerStageDescriptor*, the full value
        /// of descriptorCount is counted
        /// , except for descriptor bindings with a descriptor type of
        /// VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT where
        /// descriptorCount specifies the upper bound on the byte size of the
        /// binding, thus it counts against the maxInlineUniformBlockSize limit instead.
        /// .</summary>
        VariableDescriptorCountExt = 0x00000008,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 37
    /// <summary>VkDescriptorPoolCreateFlagBits - Bitmask specifying certain supported operations on a descriptor pool</summary>
    [Flags]
    public enum VkDescriptorPoolCreateFlagBits {
        /// <summary>VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT specifies that
        /// descriptor sets can return their individual allocations to the pool,
        /// i.e. all of vkAllocateDescriptorSets, vkFreeDescriptorSets,
        /// and vkResetDescriptorPool are allowed.
        /// Otherwise, descriptor sets allocated from the pool must not be
        /// individually freed back to the pool, i.e. only
        /// vkAllocateDescriptorSets and vkResetDescriptorPool are
        /// allowed.</summary>
        FreeDescriptorSet = 0x00000001,
        /// <summary>VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT specifies that
        /// descriptor sets allocated from this pool can include bindings with the
        /// VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT bit set.
        /// It is valid to allocate descriptor sets that have bindings that do not
        /// set the VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT bit from a
        /// pool that has VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT
        /// set.</summary>
        UpdateAfterBindExt = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 38
    /// <summary>VkDescriptorSetLayoutCreateFlagBits - Bitmask specifying descriptor set layout properties</summary>
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits {
        /// <summary>VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR specifies
        /// that descriptor sets must not be allocated using this layout, and
        /// descriptors are instead pushed by vkCmdPushDescriptorSetKHR.</summary>
        PushDescriptorKHR = 0x00000001,
        /// <summary>VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT
        /// specifies that descriptor sets using this layout must be allocated from
        /// a descriptor pool created with the
        /// VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT bit set.
        /// Descriptor set layouts created with this bit set have alternate limits
        /// for the maximum number of descriptors per-stage and per-pipeline layout.
        /// The non-UpdateAfterBind limits only count descriptors in sets created
        /// without this flag.
        /// The UpdateAfterBind limits count all descriptors, but the limits may be
        /// higher than the non-UpdateAfterBind limits.</summary>
        UpdateAfterBindPoolExt = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 39
    /// <summary>VkDescriptorType - Specifies the type of a descriptor in a descriptor set</summary>
    public enum VkDescriptorType {
        /// <summary>VK_DESCRIPTOR_TYPE_SAMPLER specifies a sampler descriptor.</summary>
        Sampler = 0,
        /// <summary>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER specifies a
        /// combined image sampler
        /// descriptor.</summary>
        CombinedImageSampler = 1,
        /// <summary>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE specifies a
        /// sampled image descriptor.</summary>
        SampledImage = 2,
        /// <summary>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE specifies a
        /// storage image descriptor.</summary>
        StorageImage = 3,
        /// <summary>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER specifies a
        /// uniform texel buffer descriptor.</summary>
        UniformTexelBuffer = 4,
        /// <summary>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER specifies a
        /// storage texel buffer descriptor.</summary>
        StorageTexelBuffer = 5,
        /// <summary>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER specifies a
        /// uniform buffer descriptor.</summary>
        UniformBuffer = 6,
        /// <summary>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER specifies a
        /// storage buffer descriptor.</summary>
        StorageBuffer = 7,
        /// <summary>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC specifies a
        /// dynamic uniform buffer
        /// descriptor.</summary>
        UniformBufferDynamic = 8,
        /// <summary>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC specifies a
        /// dynamic storage buffer
        /// descriptor.</summary>
        StorageBufferDynamic = 9,
        /// <summary>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT specifies an
        /// input attachment descriptor.</summary>
        InputAttachment = 10,
        /// <summary>VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT specifies an
        /// inline uniform block.</summary>
        InlineUniformBlockExt = 1000138000,
        AccelerationStructureNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 40
    /// <summary>VkDescriptorUpdateTemplateType - Indicates the valid usage of the descriptor update template</summary>
    public enum VkDescriptorUpdateTemplateType {
        /// <summary>VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET specifies that
        /// the descriptor update template will be used for descriptor set updates
        /// only.</summary>
        DescriptorSet = 0,
        /// <summary>VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR specifies
        /// that the descriptor update template will be used for push descriptor
        /// updates only.</summary>
        PushDescriptorsKHR = 1,
        DescriptorSetKHR = DescriptorSet,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 41
    /// <summary>VkDeviceEventTypeEXT - Events that can occur on a device object</summary>
    public enum VkDeviceEventTypeEXT {
        /// <summary>VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT specifies that the fence
        /// is signaled when a display is plugged into or unplugged from the
        /// specified device.
        /// Applications can use this notification to determine when they need to
        /// re-enumerate the available displays on a device.</summary>
        DisplayHotplugExt = 0,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 42
    /// <summary>VkDeviceGroupPresentModeFlagBitsKHR - Bitmask specifying supported device group present modes</summary>
    [Flags]
    public enum VkDeviceGroupPresentModeFlagBitsKHR {
        /// <summary>VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR specifies that any
        /// physical device with a presentation engine can present its own
        /// swapchain images.</summary>
        LocalKHR = 0x00000001,
        /// <summary>VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR specifies that any
        /// physical device with a presentation engine can present swapchain images
        /// from any physical device in its presentMask.</summary>
        RemoteKHR = 0x00000002,
        /// <summary>VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR specifies that any
        /// physical device with a presentation engine can present the sum of
        /// swapchain images from any physical devices in its presentMask.</summary>
        SumKHR = 0x00000004,
        /// <summary>VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR specifies
        /// that multiple physical devices with a presentation engine can each
        /// present their own swapchain images.</summary>
        LocalMultiDeviceKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 43
    /// <summary>VkDeviceQueueCreateFlagBits - Bitmask specifying behavior of the queue</summary>
    [Flags]
    public enum VkDeviceQueueCreateFlagBits {
        /// <summary>VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT specifies that the device
        /// queue is a protected-capable queue.
        /// If the protected memory feature is not enabled, the
        /// VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT bit of flagsmust not
        /// be set.</summary>
        Protected = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 44
    /// <summary>VkDiscardRectangleModeEXT - Specify the discard rectangle mode</summary>
    public enum VkDiscardRectangleModeEXT {
        /// <summary>VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT specifies that a fragment
        /// within any discard rectangle satisfies the test.</summary>
        InclusiveExt = 0,
        /// <summary>VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT specifies that a fragment
        /// not within any of the discard rectangles satisfies the test.</summary>
        ExclusiveExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 45
    /// <summary>VkDisplayEventTypeEXT - Events that can occur on a display object</summary>
    public enum VkDisplayEventTypeEXT {
        /// <summary>VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT specifies that the fence
        /// is signaled when the first pixel of the next display refresh cycle
        /// leaves the display engine for the display.</summary>
        FirstPixelOutExt = 0,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 46
    /// <summary>VkDisplayPlaneAlphaFlagBitsKHR - Alpha blending type</summary>
    [Flags]
    public enum VkDisplayPlaneAlphaFlagBitsKHR {
        /// <summary>VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR specifies that the source
        /// image will be treated as opaque.</summary>
        OpaqueKHR = 0x00000001,
        /// <summary>VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR specifies that a global
        /// alpha value must be specified that will be applied to all pixels in the
        /// source image.</summary>
        GlobalKHR = 0x00000002,
        /// <summary>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR specifies that the alpha
        /// value will be determined by the alpha channel of the source image¡¯s
        /// pixels.
        /// If the source format contains no alpha values, no blending will be
        /// applied.
        /// The source alpha values are not premultiplied into the source image¡¯s
        /// other color channels.</summary>
        PerPixelKHR = 0x00000004,
        /// <summary>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR is
        /// equivalent to VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR, except the
        /// source alpha values are assumed to be premultiplied into the source
        /// image¡¯s other color channels.</summary>
        PerPixelPremultipliedKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 47
    /// <summary>VkDisplayPowerStateEXT - Possible power states for a display</summary>
    public enum VkDisplayPowerStateEXT {
        /// <summary>VK_DISPLAY_POWER_STATE_OFF_EXT specifies that the display is
        /// powered down.</summary>
        OffExt = 0,
        /// <summary>VK_DISPLAY_POWER_STATE_SUSPEND_EXT specifies that the display is
        /// put into a low power mode, from which it may be able to transition back
        /// to VK_DISPLAY_POWER_STATE_ON_EXT more quickly than if it were in
        /// VK_DISPLAY_POWER_STATE_OFF_EXT.
        /// This state may be the same as VK_DISPLAY_POWER_STATE_OFF_EXT.</summary>
        SuspendExt = 1,
        /// <summary>VK_DISPLAY_POWER_STATE_ON_EXT specifies that the display is
        /// powered on.</summary>
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
        /// <summary>VK_DYNAMIC_STATE_VIEWPORT specifies that the pViewports
        /// state in VkPipelineViewportStateCreateInfo will be ignored and
        /// must be set dynamically with vkCmdSetViewport before any draw
        /// commands.
        /// The number of viewports used by a pipeline is still specified by the
        /// viewportCount member of VkPipelineViewportStateCreateInfo.</summary>
        Viewport = 0,
        /// <summary>VK_DYNAMIC_STATE_SCISSOR specifies that the pScissors state
        /// in VkPipelineViewportStateCreateInfo will be ignored and must be
        /// set dynamically with vkCmdSetScissor before any draw commands.
        /// The number of scissor rectangles used by a pipeline is still specified
        /// by the scissorCount member of
        /// VkPipelineViewportStateCreateInfo.</summary>
        Scissor = 1,
        /// <summary>VK_DYNAMIC_STATE_LINE_WIDTH specifies that the lineWidth
        /// state in VkPipelineRasterizationStateCreateInfo will be ignored
        /// and must be set dynamically with vkCmdSetLineWidth before any
        /// draw commands that generate line primitives for the rasterizer.</summary>
        LineWidth = 2,
        /// <summary>VK_DYNAMIC_STATE_DEPTH_BIAS specifies that the
        /// depthBiasConstantFactor, depthBiasClamp and
        /// depthBiasSlopeFactor states in
        /// VkPipelineRasterizationStateCreateInfo will be ignored and must
        /// be set dynamically with vkCmdSetDepthBias before any draws are
        /// performed with depthBiasEnable in
        /// VkPipelineRasterizationStateCreateInfo set to VK_TRUE.</summary>
        DepthBias = 3,
        /// <summary>VK_DYNAMIC_STATE_BLEND_CONSTANTS specifies that the
        /// blendConstants state in VkPipelineColorBlendStateCreateInfo
        /// will be ignored and must be set dynamically with
        /// vkCmdSetBlendConstants before any draws are performed with a
        /// pipeline state with VkPipelineColorBlendAttachmentState member
        /// blendEnable set to VK_TRUE and any of the blend functions
        /// using a constant blend color.</summary>
        BlendConstants = 4,
        /// <summary>VK_DYNAMIC_STATE_DEPTH_BOUNDS specifies that the
        /// minDepthBounds and maxDepthBounds states of
        /// VkPipelineDepthStencilStateCreateInfo will be ignored and must be
        /// set dynamically with vkCmdSetDepthBounds before any draws are
        /// performed with a pipeline state with
        /// VkPipelineDepthStencilStateCreateInfo member
        /// depthBoundsTestEnable set to VK_TRUE.</summary>
        DepthBounds = 5,
        /// <summary>VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK specifies that the
        /// compareMask state in VkPipelineDepthStencilStateCreateInfo
        /// for both front and back will be ignored and must be set
        /// dynamically with vkCmdSetStencilCompareMask before any draws are
        /// performed with a pipeline state with
        /// VkPipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE</summary>
        StencilCompareMask = 6,
        /// <summary>VK_DYNAMIC_STATE_STENCIL_WRITE_MASK specifies that the
        /// writeMask state in VkPipelineDepthStencilStateCreateInfo for
        /// both front and back will be ignored and must be set
        /// dynamically with vkCmdSetStencilWriteMask before any draws are
        /// performed with a pipeline state with
        /// VkPipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE</summary>
        StencilWriteMask = 7,
        /// <summary>VK_DYNAMIC_STATE_STENCIL_REFERENCE specifies that the
        /// reference state in VkPipelineDepthStencilStateCreateInfo for
        /// both front and back will be ignored and must be set
        /// dynamically with vkCmdSetStencilReference before any draws are
        /// performed with a pipeline state with
        /// VkPipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE</summary>
        StencilReference = 8,
        /// <summary>VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV specifies that the
        /// pViewportScalings state in
        /// VkPipelineViewportWScalingStateCreateInfoNV will be ignored and
        /// must be set dynamically with vkCmdSetViewportWScalingNV before
        /// any draws are performed with a pipeline state with
        /// VkPipelineViewportWScalingStateCreateInfoNV member
        /// viewportScalingEnable set to VK_TRUE</summary>
        ViewportWScalingNv = 1000087000,
        /// <summary>VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT specifies that the
        /// pDiscardRectangles state in
        /// VkPipelineDiscardRectangleStateCreateInfoEXT will be ignored and
        /// must be set dynamically with vkCmdSetDiscardRectangleEXT before
        /// any draw or clear commands.
        /// The VkDiscardRectangleModeEXT and the number of active discard
        /// rectangles is still specified by the discardRectangleMode and
        /// discardRectangleCount members of
        /// VkPipelineDiscardRectangleStateCreateInfoEXT.</summary>
        DiscardRectangleExt = 1000099000,
        /// <summary>VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT specifies that the
        /// sampleLocationsInfo state in
        /// VkPipelineSampleLocationsStateCreateInfoEXT will be ignored and
        /// must be set dynamically with vkCmdSetSampleLocationsEXT before
        /// any draw or clear commands.
        /// Enabling custom sample locations is still indicated by the
        /// sampleLocationsEnable member of
        /// VkPipelineSampleLocationsStateCreateInfoEXT.</summary>
        SampleLocationsExt = 1000143000,
        /// <summary>VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV specifies that
        /// the pShadingRatePalettes state in
        /// VkPipelineViewportShadingRateImageStateCreateInfoNV will be
        /// ignored and must be set dynamically with
        /// vkCmdSetViewportShadingRatePaletteNV before any draw commands.</summary>
        ViewportShadingRatePaletteNv = 1000164004,
        /// <summary>VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV specifies that
        /// the coarse sample order state in
        /// VkPipelineViewportCoarseSampleOrderStateCreateInfoNV will be
        /// ignored and must be set dynamically with
        /// vkCmdSetCoarseSampleOrderNV before any draw commands.</summary>
        ViewportCoarseSampleOrderNv = 1000164006,
        /// <summary>VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV specifies that the
        /// pExclusiveScissors state in
        /// VkPipelineViewportExclusiveScissorStateCreateInfoNV will be
        /// ignored and must be set dynamically with
        /// vkCmdSetExclusiveScissorNV before any draw commands.
        /// The number of exclusive scissor rectangles used by a pipeline is still
        /// specified by the exclusiveScissorCount member of
        /// VkPipelineViewportExclusiveScissorStateCreateInfoNV.</summary>
        ExclusiveScissorNv = 1000205001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 50
    /// <summary>VkExternalFenceFeatureFlagBits - Bitfield describing features of an external fence handle type</summary>
    [Flags]
    public enum VkExternalFenceFeatureFlagBits {
        /// <summary>VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT specifies handles of this
        /// type can be exported from Vulkan fence objects.</summary>
        Exportable = 0x00000001,
        /// <summary>VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT specifies handles of this
        /// type can be imported to Vulkan fence objects.</summary>
        Importable = 0x00000002,
        ExportableKHR = Exportable,
        ImportableKHR = Importable,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 51
    /// <summary>VkExternalFenceHandleTypeFlagBits - Bitmask of valid external fence handle types</summary>
    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits {
        /// <summary>VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX file
        /// descriptor handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It must be compatible with the POSIX system calls dup, dup2,
        /// close, and the non-standard system call dup3.
        /// Additionally, it must be transportable over a socket using an
        /// SCM_RIGHTS control message.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan fence object.</summary>
        OpaqueFd = 0x00000001,
        /// <summary>VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT
        /// handle that has only limited valid usage outside of Vulkan and other
        /// compatible APIs.
        /// It must be compatible with the functions DuplicateHandle,
        /// CloseHandle, CompareObjectHandles, GetHandleInformation,
        /// and SetHandleInformation.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan fence object.</summary>
        OpaqueWin32 = 0x00000002,
        /// <summary>VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a
        /// global share handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It is not compatible with any native APIs.
        /// It does not own a reference to the underlying synchronization primitive
        /// represented by its Vulkan fence object, and will therefore become
        /// invalid when all Vulkan fence objects associated with it are destroyed.</summary>
        OpaqueWin32Kmt = 0x00000004,
        /// <summary>VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT specifies a POSIX file
        /// descriptor handle to a Linux Sync File or Android Fence.
        /// It can be used with any native API accepting a valid sync file or fence
        /// as input.
        /// It owns a reference to the underlying synchronization primitive
        /// associated with the file descriptor.
        /// Implementations which support importing this handle type must accept
        /// any type of sync or fence FD supported by the native system they are
        /// running on.</summary>
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
        /// <summary>VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT specifies that
        /// images or buffers created with the specified parameters and handle type
        /// must use the mechanisms defined by VkMemoryDedicatedRequirements
        /// and VkMemoryDedicatedAllocateInfo to create (or import) a
        /// dedicated allocation for the image or buffer.</summary>
        DedicatedOnly = 0x00000001,
        /// <summary>VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT specifies that handles
        /// of this type can be exported from Vulkan memory objects.</summary>
        Exportable = 0x00000002,
        /// <summary>VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT specifies that handles
        /// of this type can be imported as Vulkan memory objects.</summary>
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
        /// <summary>VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV specifies that
        /// external memory of the specified type must be created as a dedicated
        /// allocation when used in the manner specified.</summary>
        DedicatedOnlyNv = 0x00000001,
        /// <summary>VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV specifies that the
        /// implementation supports exporting handles of the specified type.</summary>
        ExportableNv = 0x00000002,
        /// <summary>VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV specifies that the
        /// implementation supports importing handles of the specified type.</summary>
        ImportableNv = 0x00000004,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 54
    /// <summary>VkExternalMemoryHandleTypeFlagBits - Bit specifying external memory handle types</summary>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits {
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX
        /// file descriptor handle that has only limited valid usage outside of
        /// Vulkan and other compatible APIs.
        /// It must be compatible with the POSIX system calls dup, dup2,
        /// close, and the non-standard system call dup3.
        /// Additionally, it must be transportable over a socket using an
        /// SCM_RIGHTS control message.
        /// It owns a reference to the underlying memory resource represented by its
        /// Vulkan memory object.</summary>
        OpaqueFd = 0x00000001,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT
        /// handle that has only limited valid usage outside of Vulkan and other
        /// compatible APIs.
        /// It must be compatible with the functions DuplicateHandle,
        /// CloseHandle, CompareObjectHandles, GetHandleInformation,
        /// and SetHandleInformation.
        /// It owns a reference to the underlying memory resource represented by its
        /// Vulkan memory object.</summary>
        OpaqueWin32 = 0x00000002,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a
        /// global share handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It is not compatible with any native APIs.
        /// It does not own a reference to the underlying memory resource
        /// represented its Vulkan memory object, and will therefore become invalid
        /// when all Vulkan memory objects associated with it are destroyed.</summary>
        OpaqueWin32Kmt = 0x00000004,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT specifies an NT
        /// handle returned by IDXGIResource1::CreateSharedHandle
        /// referring to a Direct3D 10 or 11 texture resource.
        /// It owns a reference to the memory used by the Direct3D resource.</summary>
        D3d11Texture = 0x00000008,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT specifies a
        /// global share handle returned by IDXGIResource::GetSharedHandle
        /// referring to a Direct3D 10 or 11 texture resource.
        /// It does not own a reference to the underlying Direct3D resource, and
        /// will therefore become invalid when all Vulkan memory objects and
        /// Direct3D resources associated with it are destroyed.</summary>
        D3d11TextureKmt = 0x00000010,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT specifies an NT
        /// handle returned by ID3D12Device::CreateSharedHandle referring
        /// to a Direct3D 12 heap resource.
        /// It owns a reference to the resources used by the Direct3D heap.</summary>
        D3d12Heap = 0x00000020,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT specifies an NT
        /// handle returned by ID3D12Device::CreateSharedHandle referring
        /// to a Direct3D 12 committed resource.
        /// It owns a reference to the memory used by the Direct3D resource.</summary>
        D3d12Resource = 0x00000040,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT is a file
        /// descriptor for a Linux dma_buf.
        /// It owns a reference to the underlying memory resource represented by its
        /// Vulkan memory object.</summary>
        DmaBufExt = 0x00000200,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID
        /// specifies an AHardwareBuffer object defined by the Android NDK.
        /// See Android Hardware Buffers
        /// for more details of this handle type.</summary>
        AndroidHardwareBufferAndroid = 0x00000400,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT specifies a
        /// host pointer returned by a host memory allocation command.
        /// It does not own a reference to the underlying memory resource, and will
        /// therefore become invalid if the host memory is freed.</summary>
        HostAllocationExt = 0x00000080,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT
        /// specifies a host pointer to host mapped foreign memory.
        /// It does not own a reference to the underlying memory resource, and will
        /// therefore become invalid if the foreign memory is unmapped or otherwise
        /// becomes no longer available.</summary>
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
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV specifies a
        /// handle to memory returned by vkGetMemoryWin32HandleNV, or one
        /// duplicated from such a handle using DuplicateHandle().</summary>
        OpaqueWin32Nv = 0x00000001,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV specifies a
        /// handle to memory returned by vkGetMemoryWin32HandleNV.</summary>
        OpaqueWin32KmtNv = 0x00000002,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV specifies a
        /// valid NT handle to memory returned by
        /// IDXGIResource1::CreateSharedHandle, or a handle duplicated from such a
        /// handle using DuplicateHandle().</summary>
        D3d11ImageNv = 0x00000004,
        /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV specifies a
        /// handle to memory returned by IDXGIResource::GetSharedHandle().</summary>
        D3d11ImageKmtNv = 0x00000008,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 56
    /// <summary>VkExternalSemaphoreFeatureFlagBits - Bitfield describing features of an external semaphore handle type</summary>
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits {
        /// <summary>VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT specifies that
        /// handles of this type can be exported from Vulkan semaphore objects.</summary>
        Exportable = 0x00000001,
        /// <summary>VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT specifies that
        /// handles of this type can be imported as Vulkan semaphore objects.</summary>
        Importable = 0x00000002,
        ExportableKHR = Exportable,
        ImportableKHR = Importable,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 57
    /// <summary>VkExternalSemaphoreHandleTypeFlagBits - Bitmask of valid external semaphore handle types</summary>
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagBits {
        /// <summary>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX
        /// file descriptor handle that has only limited valid usage outside of
        /// Vulkan and other compatible APIs.
        /// It must be compatible with the POSIX system calls dup, dup2,
        /// close, and the non-standard system call dup3.
        /// Additionally, it must be transportable over a socket using an
        /// SCM_RIGHTS control message.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan semaphore object.</summary>
        OpaqueFd = 0x00000001,
        /// <summary>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT
        /// handle that has only limited valid usage outside of Vulkan and other
        /// compatible APIs.
        /// It must be compatible with the functions DuplicateHandle,
        /// CloseHandle, CompareObjectHandles, GetHandleInformation,
        /// and SetHandleInformation.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan semaphore object.</summary>
        OpaqueWin32 = 0x00000002,
        /// <summary>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a
        /// global share handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It is not compatible with any native APIs.
        /// It does not own a reference to the underlying synchronization primitive
        /// represented its Vulkan semaphore object, and will therefore become
        /// invalid when all Vulkan semaphore objects associated with it are
        /// destroyed.</summary>
        OpaqueWin32Kmt = 0x00000004,
        /// <summary>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT specifies an NT
        /// handle returned by ID3D12Device::CreateSharedHandle referring
        /// to a Direct3D 12 fence.
        /// It owns a reference to the underlying synchronization primitive
        /// associated with the Direct3D fence.</summary>
        D3d12Fence = 0x00000008,
        /// <summary>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT specifies a POSIX
        /// file descriptor handle to a Linux Sync File or Android Fence object.
        /// It can be used with any native API accepting a valid sync file or fence
        /// as input.
        /// It owns a reference to the underlying synchronization primitive
        /// associated with the file descriptor.
        /// Implementations which support importing this handle type must accept
        /// any type of sync or fence FD supported by the native system they are
        /// running on.</summary>
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
        /// <summary>VK_FENCE_CREATE_SIGNALED_BIT specifies that the fence object is
        /// created in the signaled state.
        /// Otherwise, it is created in the unsignaled state.</summary>
        Signaled = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 59
    /// <summary>VkFenceImportFlagBits - Bitmask specifying additional parameters of fence payload import</summary>
    [Flags]
    public enum VkFenceImportFlagBits {
        /// <summary>VK_FENCE_IMPORT_TEMPORARY_BIT specifies that the fence payload
        /// will be imported only temporarily, as described in
        /// Importing Fence Payloads,
        /// regardless of the permanence of handleType.</summary>
        Temporary = 0x00000001,
        TemporaryKHR = Temporary,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 60
    /// <summary>VkFilter - Specify filters used for texture lookups</summary>
    public enum VkFilter {
        /// <summary>VK_FILTER_NEAREST specifies nearest filtering.</summary>
        Nearest = 0,
        /// <summary>VK_FILTER_LINEAR specifies linear filtering.</summary>
        Linear = 1,
        CubicImg = 1000015000,
        /// <summary>VK_FILTER_CUBIC_EXT specifies cubic filtering.</summary>
        CubicExt = CubicImg,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 61
    /// <summary>VkFormat - Available image formats</summary>
    public enum VkFormat {
        /// <summary>VK_FORMAT_UNDEFINED specifies that the format is not specified.</summary>
        Undefined = 0,
        /// <summary>VK_FORMAT_R4G4_UNORM_PACK8 specifies a two-component, 8-bit packed
        /// unsigned normalized format that has a 4-bit R component in bits 4..7,
        /// and a 4-bit G component in bits 0..3.</summary>
        R4g4UnormPack8 = 1,
        /// <summary>VK_FORMAT_R4G4B4A4_UNORM_PACK16 specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 4-bit R component in bits
        /// 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in bits
        /// 4..7, and a 4-bit A component in bits 0..3.</summary>
        R4g4b4a4UnormPack16 = 2,
        /// <summary>VK_FORMAT_B4G4R4A4_UNORM_PACK16 specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 4-bit B component in bits
        /// 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in bits
        /// 4..7, and a 4-bit A component in bits 0..3.</summary>
        B4g4r4a4UnormPack16 = 3,
        /// <summary>VK_FORMAT_R5G6B5_UNORM_PACK16 specifies a three-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit R component in bits
        /// 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component in
        /// bits 0..4.</summary>
        R5g6b5UnormPack16 = 4,
        /// <summary>VK_FORMAT_B5G6R5_UNORM_PACK16 specifies a three-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit B component in bits
        /// 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component in
        /// bits 0..4.</summary>
        B5g6r5UnormPack16 = 5,
        /// <summary>VK_FORMAT_R5G5B5A1_UNORM_PACK16 specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit R component in bits
        /// 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in bits
        /// 1..5, and a 1-bit A component in bit 0.</summary>
        R5g5b5a1UnormPack16 = 6,
        /// <summary>VK_FORMAT_B5G5R5A1_UNORM_PACK16 specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit B component in bits
        /// 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in bits
        /// 1..5, and a 1-bit A component in bit 0.</summary>
        B5g5r5a1UnormPack16 = 7,
        /// <summary>VK_FORMAT_A1R5G5B5_UNORM_PACK16 specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 1-bit A component in bit
        /// 15, a 5-bit R component in bits 10..14, a 5-bit G component in bits
        /// 5..9, and a 5-bit B component in bits 0..4.</summary>
        A1r5g5b5UnormPack16 = 8,
        /// <summary>VK_FORMAT_R8_UNORM specifies a one-component, 8-bit unsigned
        /// normalized format that has a single 8-bit R component.</summary>
        R8Unorm = 9,
        /// <summary>VK_FORMAT_R8_SNORM specifies a one-component, 8-bit signed
        /// normalized format that has a single 8-bit R component.</summary>
        R8Snorm = 10,
        /// <summary>VK_FORMAT_R8_USCALED specifies a one-component, 8-bit unsigned
        /// scaled integer format that has a single 8-bit R component.</summary>
        R8Uscaled = 11,
        /// <summary>VK_FORMAT_R8_SSCALED specifies a one-component, 8-bit signed
        /// scaled integer format that has a single 8-bit R component.</summary>
        R8Sscaled = 12,
        /// <summary>VK_FORMAT_R8_UINT specifies a one-component, 8-bit unsigned
        /// integer format that has a single 8-bit R component.</summary>
        R8Uint = 13,
        /// <summary>VK_FORMAT_R8_SINT specifies a one-component, 8-bit signed integer
        /// format that has a single 8-bit R component.</summary>
        R8Sint = 14,
        /// <summary>VK_FORMAT_R8_SRGB specifies a one-component, 8-bit unsigned
        /// normalized format that has a single 8-bit R component stored with sRGB
        /// nonlinear encoding.</summary>
        R8Srgb = 15,
        /// <summary>VK_FORMAT_R8G8_UNORM specifies a two-component, 16-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, and an 8-bit
        /// G component in byte 1.</summary>
        R8g8Unorm = 16,
        /// <summary>VK_FORMAT_R8G8_SNORM specifies a two-component, 16-bit signed
        /// normalized format that has an 8-bit R component in byte 0, and an 8-bit
        /// G component in byte 1.</summary>
        R8g8Snorm = 17,
        /// <summary>VK_FORMAT_R8G8_USCALED specifies a two-component, 16-bit unsigned
        /// scaled integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.</summary>
        R8g8Uscaled = 18,
        /// <summary>VK_FORMAT_R8G8_SSCALED specifies a two-component, 16-bit signed
        /// scaled integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.</summary>
        R8g8Sscaled = 19,
        /// <summary>VK_FORMAT_R8G8_UINT specifies a two-component, 16-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.</summary>
        R8g8Uint = 20,
        /// <summary>VK_FORMAT_R8G8_SINT specifies a two-component, 16-bit signed
        /// integer format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.</summary>
        R8g8Sint = 21,
        /// <summary>VK_FORMAT_R8G8_SRGB specifies a two-component, 16-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, and an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1.</summary>
        R8g8Srgb = 22,
        /// <summary>VK_FORMAT_R8G8B8_UNORM specifies a three-component, 24-bit
        /// unsigned normalized format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, and an 8-bit B component in byte 2.</summary>
        R8g8b8Unorm = 23,
        /// <summary>VK_FORMAT_R8G8B8_SNORM specifies a three-component, 24-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        R8g8b8Snorm = 24,
        /// <summary>VK_FORMAT_R8G8B8_USCALED specifies a three-component, 24-bit
        /// unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit B component in byte 2.</summary>
        R8g8b8Uscaled = 25,
        /// <summary>VK_FORMAT_R8G8B8_SSCALED specifies a three-component, 24-bit
        /// signed scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        R8g8b8Sscaled = 26,
        /// <summary>VK_FORMAT_R8G8B8_UINT specifies a three-component, 24-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        R8g8b8Uint = 27,
        /// <summary>VK_FORMAT_R8G8B8_SINT specifies a three-component, 24-bit signed
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        R8g8b8Sint = 28,
        /// <summary>VK_FORMAT_R8G8B8_SRGB specifies a three-component, 24-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 2.</summary>
        R8g8b8Srgb = 29,
        /// <summary>VK_FORMAT_B8G8R8_UNORM specifies a three-component, 24-bit
        /// unsigned normalized format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, and an 8-bit R component in byte 2.</summary>
        B8g8r8Unorm = 30,
        /// <summary>VK_FORMAT_B8G8R8_SNORM specifies a three-component, 24-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        B8g8r8Snorm = 31,
        /// <summary>VK_FORMAT_B8G8R8_USCALED specifies a three-component, 24-bit
        /// unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit R component in byte 2.</summary>
        B8g8r8Uscaled = 32,
        /// <summary>VK_FORMAT_B8G8R8_SSCALED specifies a three-component, 24-bit
        /// signed scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        B8g8r8Sscaled = 33,
        /// <summary>VK_FORMAT_B8G8R8_UINT specifies a three-component, 24-bit unsigned
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        B8g8r8Uint = 34,
        /// <summary>VK_FORMAT_B8G8R8_SINT specifies a three-component, 24-bit signed
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        B8g8r8Sint = 35,
        /// <summary>VK_FORMAT_B8G8R8_SRGB specifies a three-component, 24-bit unsigned
        /// normalized format that has an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 2.</summary>
        B8g8r8Srgb = 36,
        /// <summary>VK_FORMAT_R8G8B8A8_UNORM specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit B component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        R8g8b8a8Unorm = 37,
        /// <summary>VK_FORMAT_R8G8B8A8_SNORM specifies a four-component, 32-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        R8g8b8a8Snorm = 38,
        /// <summary>VK_FORMAT_R8G8B8A8_USCALED specifies a four-component, 32-bit
        /// unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        R8g8b8a8Uscaled = 39,
        /// <summary>VK_FORMAT_R8G8B8A8_SSCALED specifies a four-component, 32-bit
        /// signed scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        R8g8b8a8Sscaled = 40,
        /// <summary>VK_FORMAT_R8G8B8A8_UINT specifies a four-component, 32-bit
        /// unsigned integer format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit B component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        R8g8b8a8Uint = 41,
        /// <summary>VK_FORMAT_R8G8B8A8_SINT specifies a four-component, 32-bit signed
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        R8g8b8a8Sint = 42,
        /// <summary>VK_FORMAT_R8G8B8A8_SRGB specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit R component stored with
        /// sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.</summary>
        R8g8b8a8Srgb = 43,
        /// <summary>VK_FORMAT_B8G8R8A8_UNORM specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit R component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        B8g8r8a8Unorm = 44,
        /// <summary>VK_FORMAT_B8G8R8A8_SNORM specifies a four-component, 32-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        B8g8r8a8Snorm = 45,
        /// <summary>VK_FORMAT_B8G8R8A8_USCALED specifies a four-component, 32-bit
        /// unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        B8g8r8a8Uscaled = 46,
        /// <summary>VK_FORMAT_B8G8R8A8_SSCALED specifies a four-component, 32-bit
        /// signed scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        B8g8r8a8Sscaled = 47,
        /// <summary>VK_FORMAT_B8G8R8A8_UINT specifies a four-component, 32-bit
        /// unsigned integer format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit R component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        B8g8r8a8Uint = 48,
        /// <summary>VK_FORMAT_B8G8R8A8_SINT specifies a four-component, 32-bit signed
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        B8g8r8a8Sint = 49,
        /// <summary>VK_FORMAT_B8G8R8A8_SRGB specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit B component stored with
        /// sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.</summary>
        B8g8r8a8Srgb = 50,
        /// <summary>VK_FORMAT_A8B8G8R8_UNORM_PACK32 specifies a four-component, 32-bit
        /// packed unsigned normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        A8b8g8r8UnormPack32 = 51,
        /// <summary>VK_FORMAT_A8B8G8R8_SNORM_PACK32 specifies a four-component, 32-bit
        /// packed signed normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        A8b8g8r8SnormPack32 = 52,
        /// <summary>VK_FORMAT_A8B8G8R8_USCALED_PACK32 specifies a four-component,
        /// 32-bit packed unsigned scaled integer format that has an 8-bit A
        /// component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit
        /// G component in bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        A8b8g8r8UscaledPack32 = 53,
        /// <summary>VK_FORMAT_A8B8G8R8_SSCALED_PACK32 specifies a four-component,
        /// 32-bit packed signed scaled integer format that has an 8-bit A component
        /// in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        A8b8g8r8SscaledPack32 = 54,
        /// <summary>VK_FORMAT_A8B8G8R8_UINT_PACK32 specifies a four-component, 32-bit
        /// packed unsigned integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        A8b8g8r8UintPack32 = 55,
        /// <summary>VK_FORMAT_A8B8G8R8_SINT_PACK32 specifies a four-component, 32-bit
        /// packed signed integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        A8b8g8r8SintPack32 = 56,
        /// <summary>VK_FORMAT_A8B8G8R8_SRGB_PACK32 specifies a four-component, 32-bit
        /// packed unsigned normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component stored with sRGB nonlinear encoding in bits
        /// 16..23, an 8-bit G component stored with sRGB nonlinear encoding in bits
        /// 8..15, and an 8-bit R component stored with sRGB nonlinear encoding in
        /// bits 0..7.</summary>
        A8b8g8r8SrgbPack32 = 57,
        /// <summary>VK_FORMAT_A2R10G10B10_UNORM_PACK32 specifies a four-component,
        /// 32-bit packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        A2r10g10b10UnormPack32 = 58,
        /// <summary>VK_FORMAT_A2R10G10B10_SNORM_PACK32 specifies a four-component,
        /// 32-bit packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        A2r10g10b10SnormPack32 = 59,
        /// <summary>VK_FORMAT_A2R10G10B10_USCALED_PACK32 specifies a four-component,
        /// 32-bit packed unsigned scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit
        /// G component in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        A2r10g10b10UscaledPack32 = 60,
        /// <summary>VK_FORMAT_A2R10G10B10_SSCALED_PACK32 specifies a four-component,
        /// 32-bit packed signed scaled integer format that has a 2-bit A component
        /// in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        A2r10g10b10SscaledPack32 = 61,
        /// <summary>VK_FORMAT_A2R10G10B10_UINT_PACK32 specifies a four-component,
        /// 32-bit packed unsigned integer format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        A2r10g10b10UintPack32 = 62,
        /// <summary>VK_FORMAT_A2R10G10B10_SINT_PACK32 specifies a four-component,
        /// 32-bit packed signed integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in
        /// bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        A2r10g10b10SintPack32 = 63,
        /// <summary>VK_FORMAT_A2B10G10R10_UNORM_PACK32 specifies a four-component,
        /// 32-bit packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        A2b10g10r10UnormPack32 = 64,
        /// <summary>VK_FORMAT_A2B10G10R10_SNORM_PACK32 specifies a four-component,
        /// 32-bit packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        A2b10g10r10SnormPack32 = 65,
        /// <summary>VK_FORMAT_A2B10G10R10_USCALED_PACK32 specifies a four-component,
        /// 32-bit packed unsigned scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit
        /// G component in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        A2b10g10r10UscaledPack32 = 66,
        /// <summary>VK_FORMAT_A2B10G10R10_SSCALED_PACK32 specifies a four-component,
        /// 32-bit packed signed scaled integer format that has a 2-bit A component
        /// in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        A2b10g10r10SscaledPack32 = 67,
        /// <summary>VK_FORMAT_A2B10G10R10_UINT_PACK32 specifies a four-component,
        /// 32-bit packed unsigned integer format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        A2b10g10r10UintPack32 = 68,
        /// <summary>VK_FORMAT_A2B10G10R10_SINT_PACK32 specifies a four-component,
        /// 32-bit packed signed integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in
        /// bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        A2b10g10r10SintPack32 = 69,
        /// <summary>VK_FORMAT_R16_UNORM specifies a one-component, 16-bit unsigned
        /// normalized format that has a single 16-bit R component.</summary>
        R16Unorm = 70,
        /// <summary>VK_FORMAT_R16_SNORM specifies a one-component, 16-bit signed
        /// normalized format that has a single 16-bit R component.</summary>
        R16Snorm = 71,
        /// <summary>VK_FORMAT_R16_USCALED specifies a one-component, 16-bit unsigned
        /// scaled integer format that has a single 16-bit R component.</summary>
        R16Uscaled = 72,
        /// <summary>VK_FORMAT_R16_SSCALED specifies a one-component, 16-bit signed
        /// scaled integer format that has a single 16-bit R component.</summary>
        R16Sscaled = 73,
        /// <summary>VK_FORMAT_R16_UINT specifies a one-component, 16-bit unsigned
        /// integer format that has a single 16-bit R component.</summary>
        R16Uint = 74,
        /// <summary>VK_FORMAT_R16_SINT specifies a one-component, 16-bit signed
        /// integer format that has a single 16-bit R component.</summary>
        R16Sint = 75,
        /// <summary>VK_FORMAT_R16_SFLOAT specifies a one-component, 16-bit signed
        /// floating-point format that has a single 16-bit R component.</summary>
        R16Sfloat = 76,
        /// <summary>VK_FORMAT_R16G16_UNORM specifies a two-component, 32-bit unsigned
        /// normalized format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        R16g16Unorm = 77,
        /// <summary>VK_FORMAT_R16G16_SNORM specifies a two-component, 32-bit signed
        /// normalized format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        R16g16Snorm = 78,
        /// <summary>VK_FORMAT_R16G16_USCALED specifies a two-component, 32-bit
        /// unsigned scaled integer format that has a 16-bit R component in bytes
        /// 0..1, and a 16-bit G component in bytes 2..3.</summary>
        R16g16Uscaled = 79,
        /// <summary>VK_FORMAT_R16G16_SSCALED specifies a two-component, 32-bit signed
        /// scaled integer format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        R16g16Sscaled = 80,
        /// <summary>VK_FORMAT_R16G16_UINT specifies a two-component, 32-bit unsigned
        /// integer format that has a 16-bit R component in bytes 0..1, and a 16-bit
        /// G component in bytes 2..3.</summary>
        R16g16Uint = 81,
        /// <summary>VK_FORMAT_R16G16_SINT specifies a two-component, 32-bit signed
        /// integer format that has a 16-bit R component in bytes 0..1, and a 16-bit
        /// G component in bytes 2..3.</summary>
        R16g16Sint = 82,
        /// <summary>VK_FORMAT_R16G16_SFLOAT specifies a two-component, 32-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        R16g16Sfloat = 83,
        /// <summary>VK_FORMAT_R16G16B16_UNORM specifies a three-component, 48-bit
        /// unsigned normalized format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        R16g16b16Unorm = 84,
        /// <summary>VK_FORMAT_R16G16B16_SNORM specifies a three-component, 48-bit
        /// signed normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        R16g16b16Snorm = 85,
        /// <summary>VK_FORMAT_R16G16B16_USCALED specifies a three-component, 48-bit
        /// unsigned scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.</summary>
        R16g16b16Uscaled = 86,
        /// <summary>VK_FORMAT_R16G16B16_SSCALED specifies a three-component, 48-bit
        /// signed scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.</summary>
        R16g16b16Sscaled = 87,
        /// <summary>VK_FORMAT_R16G16B16_UINT specifies a three-component, 48-bit
        /// unsigned integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        R16g16b16Uint = 88,
        /// <summary>VK_FORMAT_R16G16B16_SINT specifies a three-component, 48-bit
        /// signed integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        R16g16b16Sint = 89,
        /// <summary>VK_FORMAT_R16G16B16_SFLOAT specifies a three-component, 48-bit
        /// signed floating-point format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.</summary>
        R16g16b16Sfloat = 90,
        /// <summary>VK_FORMAT_R16G16B16A16_UNORM specifies a four-component, 64-bit
        /// unsigned normalized format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Unorm = 91,
        /// <summary>VK_FORMAT_R16G16B16A16_SNORM specifies a four-component, 64-bit
        /// signed normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Snorm = 92,
        /// <summary>VK_FORMAT_R16G16B16A16_USCALED specifies a four-component, 64-bit
        /// unsigned scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Uscaled = 93,
        /// <summary>VK_FORMAT_R16G16B16A16_SSCALED specifies a four-component, 64-bit
        /// signed scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Sscaled = 94,
        /// <summary>VK_FORMAT_R16G16B16A16_UINT specifies a four-component, 64-bit
        /// unsigned integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Uint = 95,
        /// <summary>VK_FORMAT_R16G16B16A16_SINT specifies a four-component, 64-bit
        /// signed integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Sint = 96,
        /// <summary>VK_FORMAT_R16G16B16A16_SFLOAT specifies a four-component, 64-bit
        /// signed floating-point format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.</summary>
        R16g16b16a16Sfloat = 97,
        /// <summary>VK_FORMAT_R32_UINT specifies a one-component, 32-bit unsigned
        /// integer format that has a single 32-bit R component.</summary>
        R32Uint = 98,
        /// <summary>VK_FORMAT_R32_SINT specifies a one-component, 32-bit signed
        /// integer format that has a single 32-bit R component.</summary>
        R32Sint = 99,
        /// <summary>VK_FORMAT_R32_SFLOAT specifies a one-component, 32-bit signed
        /// floating-point format that has a single 32-bit R component.</summary>
        R32Sfloat = 100,
        /// <summary>VK_FORMAT_R32G32_UINT specifies a two-component, 64-bit unsigned
        /// integer format that has a 32-bit R component in bytes 0..3, and a 32-bit
        /// G component in bytes 4..7.</summary>
        R32g32Uint = 101,
        /// <summary>VK_FORMAT_R32G32_SINT specifies a two-component, 64-bit signed
        /// integer format that has a 32-bit R component in bytes 0..3, and a 32-bit
        /// G component in bytes 4..7.</summary>
        R32g32Sint = 102,
        /// <summary>VK_FORMAT_R32G32_SFLOAT specifies a two-component, 64-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3, and a
        /// 32-bit G component in bytes 4..7.</summary>
        R32g32Sfloat = 103,
        /// <summary>VK_FORMAT_R32G32B32_UINT specifies a three-component, 96-bit
        /// unsigned integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.</summary>
        R32g32b32Uint = 104,
        /// <summary>VK_FORMAT_R32G32B32_SINT specifies a three-component, 96-bit
        /// signed integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.</summary>
        R32g32b32Sint = 105,
        /// <summary>VK_FORMAT_R32G32B32_SFLOAT specifies a three-component, 96-bit
        /// signed floating-point format that has a 32-bit R component in bytes
        /// 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in
        /// bytes 8..11.</summary>
        R32g32b32Sfloat = 106,
        /// <summary>VK_FORMAT_R32G32B32A32_UINT specifies a four-component, 128-bit
        /// unsigned integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11,
        /// and a 32-bit A component in bytes 12..15.</summary>
        R32g32b32a32Uint = 107,
        /// <summary>VK_FORMAT_R32G32B32A32_SINT specifies a four-component, 128-bit
        /// signed integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11,
        /// and a 32-bit A component in bytes 12..15.</summary>
        R32g32b32a32Sint = 108,
        /// <summary>VK_FORMAT_R32G32B32A32_SFLOAT specifies a four-component, 128-bit
        /// signed floating-point format that has a 32-bit R component in bytes
        /// 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes
        /// 8..11, and a 32-bit A component in bytes 12..15.</summary>
        R32g32b32a32Sfloat = 109,
        /// <summary>VK_FORMAT_R64_UINT specifies a one-component, 64-bit unsigned
        /// integer format that has a single 64-bit R component.</summary>
        R64Uint = 110,
        /// <summary>VK_FORMAT_R64_SINT specifies a one-component, 64-bit signed
        /// integer format that has a single 64-bit R component.</summary>
        R64Sint = 111,
        /// <summary>VK_FORMAT_R64_SFLOAT specifies a one-component, 64-bit signed
        /// floating-point format that has a single 64-bit R component.</summary>
        R64Sfloat = 112,
        /// <summary>VK_FORMAT_R64G64_UINT specifies a two-component, 128-bit unsigned
        /// integer format that has a 64-bit R component in bytes 0..7, and a 64-bit
        /// G component in bytes 8..15.</summary>
        R64g64Uint = 113,
        /// <summary>VK_FORMAT_R64G64_SINT specifies a two-component, 128-bit signed
        /// integer format that has a 64-bit R component in bytes 0..7, and a 64-bit
        /// G component in bytes 8..15.</summary>
        R64g64Sint = 114,
        /// <summary>VK_FORMAT_R64G64_SFLOAT specifies a two-component, 128-bit signed
        /// floating-point format that has a 64-bit R component in bytes 0..7, and a
        /// 64-bit G component in bytes 8..15.</summary>
        R64g64Sfloat = 115,
        /// <summary>VK_FORMAT_R64G64B64_UINT specifies a three-component, 192-bit
        /// unsigned integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in bytes
        /// 16..23.</summary>
        R64g64b64Uint = 116,
        /// <summary>VK_FORMAT_R64G64B64_SINT specifies a three-component, 192-bit
        /// signed integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in bytes
        /// 16..23.</summary>
        R64g64b64Sint = 117,
        /// <summary>VK_FORMAT_R64G64B64_SFLOAT specifies a three-component, 192-bit
        /// signed floating-point format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in
        /// bytes 16..23.</summary>
        R64g64b64Sfloat = 118,
        /// <summary>VK_FORMAT_R64G64B64A64_UINT specifies a four-component, 256-bit
        /// unsigned integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23,
        /// and a 64-bit A component in bytes 24..31.</summary>
        R64g64b64a64Uint = 119,
        /// <summary>VK_FORMAT_R64G64B64A64_SINT specifies a four-component, 256-bit
        /// signed integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23,
        /// and a 64-bit A component in bytes 24..31.</summary>
        R64g64b64a64Sint = 120,
        /// <summary>VK_FORMAT_R64G64B64A64_SFLOAT specifies a four-component, 256-bit
        /// signed floating-point format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes
        /// 16..23, and a 64-bit A component in bytes 24..31.</summary>
        R64g64b64a64Sfloat = 121,
        /// <summary>VK_FORMAT_B10G11R11_UFLOAT_PACK32 specifies a three-component,
        /// 32-bit packed unsigned floating-point format that has a 10-bit B
        /// component in bits 22..31, an 11-bit G component in bits 11..21, an
        /// 11-bit R component in bits 0..10.
        /// See html/vkspec.html#fundamentals-fp10 and html/vkspec.html#fundamentals-fp11.</summary>
        B10g11r11UfloatPack32 = 122,
        /// <summary>VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 specifies a three-component,
        /// 32-bit packed unsigned floating-point format that has a 5-bit shared
        /// exponent in bits 27..31, a 9-bit B component mantissa in bits 18..26, a
        /// 9-bit G component mantissa in bits 9..17, and a 9-bit R component
        /// mantissa in bits 0..8.</summary>
        E5b9g9r9UfloatPack32 = 123,
        /// <summary>VK_FORMAT_D16_UNORM specifies a one-component, 16-bit unsigned
        /// normalized format that has a single 16-bit depth component.</summary>
        D16Unorm = 124,
        /// <summary>VK_FORMAT_X8_D24_UNORM_PACK32 specifies a two-component, 32-bit
        /// format that has 24 unsigned normalized bits in the depth component and,
        /// optionally:, 8 bits that are unused.</summary>
        X8D24UnormPack32 = 125,
        /// <summary>VK_FORMAT_D32_SFLOAT specifies a one-component, 32-bit signed
        /// floating-point format that has 32-bits in the depth component.</summary>
        D32Sfloat = 126,
        /// <summary>VK_FORMAT_S8_UINT specifies a one-component, 8-bit unsigned
        /// integer format that has 8-bits in the stencil component.</summary>
        S8Uint = 127,
        /// <summary>VK_FORMAT_D16_UNORM_S8_UINT specifies a two-component, 24-bit
        /// format that has 16 unsigned normalized bits in the depth component and 8
        /// unsigned integer bits in the stencil component.</summary>
        D16UnormS8Uint = 128,
        /// <summary>VK_FORMAT_D24_UNORM_S8_UINT specifies a two-component, 32-bit
        /// packed format that has 8 unsigned integer bits in the stencil component,
        /// and 24 unsigned normalized bits in the depth component.</summary>
        D24UnormS8Uint = 129,
        /// <summary>VK_FORMAT_D32_SFLOAT_S8_UINT specifies a two-component format that
        /// has 32 signed float bits in the depth component and 8 unsigned integer
        /// bits in the stencil component.
        /// There are optionally: 24-bits that are unused.</summary>
        D32SfloatS8Uint = 130,
        /// <summary>VK_FORMAT_BC1_RGB_UNORM_BLOCK specifies a three-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data.
        /// This format has no alpha and is considered opaque.</summary>
        Bc1RgbUnormBlock = 131,
        /// <summary>VK_FORMAT_BC1_RGB_SRGB_BLOCK specifies a three-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding.
        /// This format has no alpha and is considered opaque.</summary>
        Bc1RgbSrgbBlock = 132,
        /// <summary>VK_FORMAT_BC1_RGBA_UNORM_BLOCK specifies a four-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data, and
        /// provides 1 bit of alpha.</summary>
        Bc1RgbaUnormBlock = 133,
        /// <summary>VK_FORMAT_BC1_RGBA_SRGB_BLOCK specifies a four-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding, and provides 1 bit of alpha.</summary>
        Bc1RgbaSrgbBlock = 134,
        /// <summary>VK_FORMAT_BC2_UNORM_BLOCK specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values.</summary>
        Bc2UnormBlock = 135,
        /// <summary>VK_FORMAT_BC2_SRGB_BLOCK specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values with sRGB nonlinear encoding.</summary>
        Bc2SrgbBlock = 136,
        /// <summary>VK_FORMAT_BC3_UNORM_BLOCK specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values.</summary>
        Bc3UnormBlock = 137,
        /// <summary>VK_FORMAT_BC3_SRGB_BLOCK specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values with sRGB nonlinear encoding.</summary>
        Bc3SrgbBlock = 138,
        /// <summary>VK_FORMAT_BC4_UNORM_BLOCK specifies a one-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized red texel data.</summary>
        Bc4UnormBlock = 139,
        /// <summary>VK_FORMAT_BC4_SNORM_BLOCK specifies a one-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of signed normalized red texel data.</summary>
        Bc4SnormBlock = 140,
        /// <summary>VK_FORMAT_BC5_UNORM_BLOCK specifies a two-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RG texel data with
        /// the first 64 bits encoding red values followed by 64 bits encoding green
        /// values.</summary>
        Bc5UnormBlock = 141,
        /// <summary>VK_FORMAT_BC5_SNORM_BLOCK specifies a two-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of signed normalized RG texel data with
        /// the first 64 bits encoding red values followed by 64 bits encoding green
        /// values.</summary>
        Bc5SnormBlock = 142,
        /// <summary>VK_FORMAT_BC6H_UFLOAT_BLOCK specifies a three-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned floating-point RGB texel data.</summary>
        Bc6hUfloatBlock = 143,
        /// <summary>VK_FORMAT_BC6H_SFLOAT_BLOCK specifies a three-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of signed floating-point RGB texel data.</summary>
        Bc6hSfloatBlock = 144,
        /// <summary>VK_FORMAT_BC7_UNORM_BLOCK specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RGBA texel data.</summary>
        Bc7UnormBlock = 145,
        /// <summary>VK_FORMAT_BC7_SRGB_BLOCK specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4¡Á4 rectangle of unsigned normalized RGBA texel data
        /// with sRGB nonlinear encoding applied to the RGB components.</summary>
        Bc7SrgbBlock = 146,
        /// <summary>VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK specifies a three-component,
        /// ETC2 compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data.
        /// This format has no alpha and is considered opaque.</summary>
        Etc2R8g8b8UnormBlock = 147,
        /// <summary>VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK specifies a three-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding.
        /// This format has no alpha and is considered opaque.</summary>
        Etc2R8g8b8SrgbBlock = 148,
        /// <summary>VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK specifies a four-component,
        /// ETC2 compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data, and
        /// provides 1 bit of alpha.</summary>
        Etc2R8g8b8a1UnormBlock = 149,
        /// <summary>VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK specifies a four-component,
        /// ETC2 compressed format where each 64-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding, and provides 1 bit of alpha.</summary>
        Etc2R8g8b8a1SrgbBlock = 150,
        /// <summary>VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK specifies a four-component,
        /// ETC2 compressed format where each 128-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding RGB
        /// values.</summary>
        Etc2R8g8b8a8UnormBlock = 151,
        /// <summary>VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK specifies a four-component,
        /// ETC2 compressed format where each 128-bit compressed texel block encodes
        /// a 4¡Á4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding RGB
        /// values with sRGB nonlinear encoding applied.</summary>
        Etc2R8g8b8a8SrgbBlock = 152,
        /// <summary>VK_FORMAT_EAC_R11_UNORM_BLOCK specifies a one-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of unsigned normalized red texel data.</summary>
        EacR11UnormBlock = 153,
        /// <summary>VK_FORMAT_EAC_R11_SNORM_BLOCK specifies a one-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of signed normalized red texel data.</summary>
        EacR11SnormBlock = 154,
        /// <summary>VK_FORMAT_EAC_R11G11_UNORM_BLOCK specifies a two-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of unsigned normalized RG texel data with the first
        /// 64 bits encoding red values followed by 64 bits encoding green values.</summary>
        EacR11g11UnormBlock = 155,
        /// <summary>VK_FORMAT_EAC_R11G11_SNORM_BLOCK specifies a two-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of signed normalized RG texel data with the first 64
        /// bits encoding red values followed by 64 bits encoding green values.</summary>
        EacR11g11SnormBlock = 156,
        /// <summary>VK_FORMAT_ASTC_4x4_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc4x4UnormBlock = 157,
        /// <summary>VK_FORMAT_ASTC_4x4_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4¡Á4 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc4x4SrgbBlock = 158,
        /// <summary>VK_FORMAT_ASTC_5x4_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5¡Á4 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc5x4UnormBlock = 159,
        /// <summary>VK_FORMAT_ASTC_5x4_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5¡Á4 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc5x4SrgbBlock = 160,
        /// <summary>VK_FORMAT_ASTC_5x5_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5¡Á5 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc5x5UnormBlock = 161,
        /// <summary>VK_FORMAT_ASTC_5x5_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5¡Á5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc5x5SrgbBlock = 162,
        /// <summary>VK_FORMAT_ASTC_6x5_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6¡Á5 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc6x5UnormBlock = 163,
        /// <summary>VK_FORMAT_ASTC_6x5_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6¡Á5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc6x5SrgbBlock = 164,
        /// <summary>VK_FORMAT_ASTC_6x6_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6¡Á6 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc6x6UnormBlock = 165,
        /// <summary>VK_FORMAT_ASTC_6x6_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6¡Á6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc6x6SrgbBlock = 166,
        /// <summary>VK_FORMAT_ASTC_8x5_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8¡Á5 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc8x5UnormBlock = 167,
        /// <summary>VK_FORMAT_ASTC_8x5_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8¡Á5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc8x5SrgbBlock = 168,
        /// <summary>VK_FORMAT_ASTC_8x6_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8¡Á6 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc8x6UnormBlock = 169,
        /// <summary>VK_FORMAT_ASTC_8x6_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8¡Á6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc8x6SrgbBlock = 170,
        /// <summary>VK_FORMAT_ASTC_8x8_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8¡Á8 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc8x8UnormBlock = 171,
        /// <summary>VK_FORMAT_ASTC_8x8_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8¡Á8 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc8x8SrgbBlock = 172,
        /// <summary>VK_FORMAT_ASTC_10x5_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á5 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc10x5UnormBlock = 173,
        /// <summary>VK_FORMAT_ASTC_10x5_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc10x5SrgbBlock = 174,
        /// <summary>VK_FORMAT_ASTC_10x6_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á6 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc10x6UnormBlock = 175,
        /// <summary>VK_FORMAT_ASTC_10x6_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc10x6SrgbBlock = 176,
        /// <summary>VK_FORMAT_ASTC_10x8_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á8 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc10x8UnormBlock = 177,
        /// <summary>VK_FORMAT_ASTC_10x8_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á8 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc10x8SrgbBlock = 178,
        /// <summary>VK_FORMAT_ASTC_10x10_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á10 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc10x10UnormBlock = 179,
        /// <summary>VK_FORMAT_ASTC_10x10_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10¡Á10 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc10x10SrgbBlock = 180,
        /// <summary>VK_FORMAT_ASTC_12x10_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12¡Á10 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc12x10UnormBlock = 181,
        /// <summary>VK_FORMAT_ASTC_12x10_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12¡Á10 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc12x10SrgbBlock = 182,
        /// <summary>VK_FORMAT_ASTC_12x12_UNORM_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12¡Á12 rectangle of unsigned normalized RGBA texel data.</summary>
        Astc12x12UnormBlock = 183,
        /// <summary>VK_FORMAT_ASTC_12x12_SRGB_BLOCK specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12¡Á12 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        Astc12x12SrgbBlock = 184,
        /// <summary>VK_FORMAT_G8B8G8R8_422_UNORM specifies a four-component, 32-bit
        /// format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2¡Á1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has an 8-bit G component for the even i coordinate in byte
        /// 0, an 8-bit B component in byte 1, an 8-bit G component for the odd i
        /// coordinate in byte 2, and an 8-bit R component in byte 3.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        G8b8g8r8422Unorm = 1000156000,
        /// <summary>VK_FORMAT_B8G8R8G8_422_UNORM specifies a four-component, 32-bit
        /// format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2¡Á1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has an 8-bit B component in byte 0, an 8-bit G component for
        /// the even i coordinate in byte 1, an 8-bit R component in byte 2, and
        /// an 8-bit G component for the odd i coordinate in byte 3.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        B8g8r8g8422Unorm = 1000156001,
        /// <summary>VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM specifies an unsigned
        /// normalized multi-planar format that has an 8-bit G component in plane
        /// 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2.
        /// The horizontal and vertical dimensions of the R and B planes are halved
        /// relative to the image dimensions, and each R and B component is shared
        /// with the G components for which \(\lfloor i_G \times 0.5
        /// \rfloor = i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B
        /// = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G8B8R83plane420Unorm = 1000156002,
        /// <summary>VK_FORMAT_G8_B8R8_2PLANE_420_UNORM specifies an unsigned
        /// normalized multi-planar format that has an 8-bit G component in plane
        /// 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B
        /// component in byte 0 and an 8-bit R component in byte 1.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G8B8r82plane420Unorm = 1000156003,
        /// <summary>VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM specifies an unsigned
        /// normalized multi-planar format that has an 8-bit G component in plane
        /// 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G8B8R83plane422Unorm = 1000156004,
        /// <summary>VK_FORMAT_G8_B8R8_2PLANE_422_UNORM specifies an unsigned
        /// normalized multi-planar format that has an 8-bit G component in plane
        /// 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B
        /// component in byte 0 and an 8-bit R component in byte 1.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G8B8r82plane422Unorm = 1000156005,
        /// <summary>VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM specifies an unsigned
        /// normalized multi-planar format that has an 8-bit G component in plane
        /// 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.</summary>
        G8B8R83plane444Unorm = 1000156006,
        /// <summary>VK_FORMAT_R10X6_UNORM_PACK16 specifies a one-component, 16-bit
        /// unsigned normalized format that has a single 10-bit R component in the
        /// top 10 bits of a 16-bit word, with the bottom 6 bits set to 0.</summary>
        R10x6UnormPack16 = 1000156007,
        /// <summary>VK_FORMAT_R10X6G10X6_UNORM_2PACK16 specifies a two-component,
        /// 32-bit unsigned normalized format that has a 10-bit R component in the
        /// top 10 bits of the word in bytes 0..1, and a 10-bit G component in the
        /// top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each
        /// word set to 0.</summary>
        R10x6g10x6Unorm2pack16 = 1000156008,
        /// <summary>VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 specifies a
        /// four-component, 64-bit unsigned normalized format that has a 10-bit R
        /// component in the top 10 bits of the word in bytes 0..1, a 10-bit G
        /// component in the top 10 bits of the word in bytes 2..3, a 10-bit B
        /// component in the top 10 bits of the word in bytes 4..5, and a 10-bit A
        /// component in the top 10 bits of the word in bytes 6..7, with the bottom
        /// 6 bits of each word set to 0.</summary>
        R10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
        /// <summary>VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2¡Á1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 10-bit G component for the even i coordinate in the
        /// top 10 bits of the word in bytes 0..1, a 10-bit B component in the top
        /// 10 bits of the word in bytes 2..3, a 10-bit G component for the odd i
        /// coordinate in the top 10 bits of the word in bytes 4..5, and a 10-bit R
        /// component in the top 10 bits of the word in bytes 6..7, with the bottom
        /// 6 bits of each word set to 0.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        G10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
        /// <summary>VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2¡Á1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 10-bit B component in the top 10 bits of the word in
        /// bytes 0..1, a 10-bit G component for the even i coordinate in the top
        /// 10 bits of the word in bytes 2..3, a 10-bit R component in the top 10
        /// bits of the word in bytes 4..5, and a 10-bit G component for the odd i
        /// coordinate in the top 10 bits of the word in bytes 6..7, with the bottom
        /// 6 bits of each word set to 0.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        B10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
        /// <summary>VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component
        /// in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R
        /// component in the top 10 bits of each 16-bit word of plane 2, with the
        /// bottom 6 bits of each word set to 0.
        /// The horizontal and vertical dimensions of the R and B planes are halved
        /// relative to the image dimensions, and each R and B component is shared
        /// with the G components for which \(\lfloor i_G \times 0.5
        /// \rfloor = i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B
        /// = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
        /// <summary>VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits
        /// of the word in bytes 0..1, and a 10-bit R component in the top 10 bits
        /// of the word in bytes 2..3, the bottom 6 bits of each word set to 0.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
        /// <summary>VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component
        /// in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R
        /// component in the top 10 bits of each 16-bit word of plane 2, with the
        /// bottom 6 bits of each word set to 0.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
        /// <summary>VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits
        /// of the word in bytes 0..1, and a 10-bit R component in the top 10 bits
        /// of the word in bytes 2..3, the bottom 6 bits of each word set to 0.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
        /// <summary>VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component
        /// in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R
        /// component in the top 10 bits of each 16-bit word of plane 2, with the
        /// bottom 6 bits of each word set to 0.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.</summary>
        G10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
        /// <summary>VK_FORMAT_R12X4_UNORM_PACK16 specifies a one-component, 16-bit
        /// unsigned normalized format that has a single 12-bit R component in the
        /// top 12 bits of a 16-bit word, with the bottom 4 bits set to 0.</summary>
        R12x4UnormPack16 = 1000156017,
        /// <summary>VK_FORMAT_R12X4G12X4_UNORM_2PACK16 specifies a two-component,
        /// 32-bit unsigned normalized format that has a 12-bit R component in the
        /// top 12 bits of the word in bytes 0..1, and a 12-bit G component in the
        /// top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each
        /// word set to 0.</summary>
        R12x4g12x4Unorm2pack16 = 1000156018,
        /// <summary>VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 specifies a
        /// four-component, 64-bit unsigned normalized format that has a 12-bit R
        /// component in the top 12 bits of the word in bytes 0..1, a 12-bit G
        /// component in the top 12 bits of the word in bytes 2..3, a 12-bit B
        /// component in the top 12 bits of the word in bytes 4..5, and a 12-bit A
        /// component in the top 12 bits of the word in bytes 6..7, with the bottom
        /// 4 bits of each word set to 0.</summary>
        R12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
        /// <summary>VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2¡Á1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 12-bit G component for the even i coordinate in the
        /// top 12 bits of the word in bytes 0..1, a 12-bit B component in the top
        /// 12 bits of the word in bytes 2..3, a 12-bit G component for the odd i
        /// coordinate in the top 12 bits of the word in bytes 4..5, and a 12-bit R
        /// component in the top 12 bits of the word in bytes 6..7, with the bottom
        /// 4 bits of each word set to 0.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        G12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
        /// <summary>VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2¡Á1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 12-bit B component in the top 12 bits of the word in
        /// bytes 0..1, a 12-bit G component for the even i coordinate in the top
        /// 12 bits of the word in bytes 2..3, a 12-bit R component in the top 12
        /// bits of the word in bytes 4..5, and a 12-bit G component for the odd i
        /// coordinate in the top 12 bits of the word in bytes 6..7, with the bottom
        /// 4 bits of each word set to 0.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        B12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
        /// <summary>VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component
        /// in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R
        /// component in the top 12 bits of each 16-bit word of plane 2, with the
        /// bottom 4 bits of each word set to 0.
        /// The horizontal and vertical dimensions of the R and B planes are halved
        /// relative to the image dimensions, and each R and B component is shared
        /// with the G components for which \(\lfloor i_G \times 0.5
        /// \rfloor = i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B
        /// = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
        /// <summary>VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits
        /// of the word in bytes 0..1, and a 12-bit R component in the top 12 bits
        /// of the word in bytes 2..3, the bottom 4 bits of each word set to 0.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
        /// <summary>VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component
        /// in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R
        /// component in the top 12 bits of each 16-bit word of plane 2, with the
        /// bottom 4 bits of each word set to 0.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
        /// <summary>VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits
        /// of the word in bytes 0..1, and a 12-bit R component in the top 12 bits
        /// of the word in bytes 2..3, the bottom 4 bits of each word set to 0.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
        /// <summary>VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 specifies an
        /// unsigned normalized multi-planar format that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component
        /// in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R
        /// component in the top 12 bits of each 16-bit word of plane 2, with the
        /// bottom 4 bits of each word set to 0.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.</summary>
        G12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
        /// <summary>VK_FORMAT_G16B16G16R16_422_UNORM specifies a four-component,
        /// 64-bit format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2¡Á1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 16-bit G component for the even i coordinate in the
        /// word in bytes 0..1, a 16-bit B component in the word in bytes 2..3, a
        /// 16-bit G component for the odd i coordinate in the word in bytes 4..5,
        /// and a 16-bit R component in the word in bytes 6..7.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        G16b16g16r16422Unorm = 1000156027,
        /// <summary>VK_FORMAT_B16G16R16G16_422_UNORM specifies a four-component,
        /// 64-bit format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2¡Á1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each i coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 16-bit B component in the word in bytes 0..1, a 16-bit
        /// G component for the even i coordinate in the word in bytes 2..3, a
        /// 16-bit R component in the word in bytes 4..5, and a 16-bit G component
        /// for the odd i coordinate in the word in bytes 6..7.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2¡Á1 compressed texel block.</summary>
        B16g16r16g16422Unorm = 1000156028,
        /// <summary>VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM specifies an unsigned
        /// normalized multi-planar format that has a 16-bit G component in each
        /// 16-bit word of plane 0, a 16-bit B component in each 16-bit word of
        /// plane 1, and a 16-bit R component in each 16-bit word of plane 2.
        /// The horizontal and vertical dimensions of the R and B planes are halved
        /// relative to the image dimensions, and each R and B component is shared
        /// with the G components for which \(\lfloor i_G \times 0.5
        /// \rfloor = i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B
        /// = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G16B16R163plane420Unorm = 1000156029,
        /// <summary>VK_FORMAT_G16_B16R16_2PLANE_420_UNORM specifies an unsigned
        /// normalized multi-planar format that has a 16-bit G component in each
        /// 16-bit word of plane 0, and a two-component, 32-bit BR plane 1
        /// consisting of a 16-bit B component in the word in bytes 0..1, and a
        /// 16-bit R component in the word in bytes 2..3.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width and height that is a
        /// multiple of two.</summary>
        G16B16r162plane420Unorm = 1000156030,
        /// <summary>VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM specifies an unsigned
        /// normalized multi-planar format that has a 16-bit G component in each
        /// 16-bit word of plane 0, a 16-bit B component in each 16-bit word of
        /// plane 1, and a 16-bit R component in each 16-bit word of plane 2.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G16B16R163plane422Unorm = 1000156031,
        /// <summary>VK_FORMAT_G16_B16R16_2PLANE_422_UNORM specifies an unsigned
        /// normalized multi-planar format that has a 16-bit G component in each
        /// 16-bit word of plane 0, and a two-component, 32-bit BR plane 1
        /// consisting of a 16-bit B component in the word in bytes 0..1, and a
        /// 16-bit R component in the word in bytes 2..3.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane, and
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the BR plane.
        /// Images in this format must be defined with a width that is a multiple
        /// of two.</summary>
        G16B16r162plane422Unorm = 1000156032,
        /// <summary>VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM specifies an unsigned
        /// normalized multi-planar format that has a 16-bit G component in each
        /// 16-bit word of plane 0, a 16-bit B component in each 16-bit word of
        /// plane 1, and a 16-bit R component in each 16-bit word of plane 2.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via vkGetImageSubresourceLayout, using
        /// VK_IMAGE_ASPECT_PLANE_0_BIT for the G plane,
        /// VK_IMAGE_ASPECT_PLANE_1_BIT for the B plane, and
        /// VK_IMAGE_ASPECT_PLANE_2_BIT for the R plane.</summary>
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
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT specifies that an image view
        /// can be sampled from.</summary>
        SampledImage = 0x00000001,
        /// <summary>VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT specifies that an image view
        /// can be used as a storage images.</summary>
        StorageImage = 0x00000002,
        /// <summary>VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT specifies that an image
        /// view can be used as storage image that supports atomic operations.</summary>
        StorageImageAtomic = 0x00000004,
        /// <summary>VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT specifies that the
        /// format can be used to create a buffer view that can be bound to a
        /// VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.</summary>
        UniformTexelBuffer = 0x00000008,
        /// <summary>VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT specifies that the
        /// format can be used to create a buffer view that can be bound to a
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.</summary>
        StorageTexelBuffer = 0x00000010,
        /// <summary>VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT specifies that
        /// atomic operations are supported on
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.</summary>
        StorageTexelBufferAtomic = 0x00000020,
        /// <summary>VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT specifies that the format can
        /// be used as a vertex attribute format
        /// (VkVertexInputAttributeDescription::format).</summary>
        VertexBuffer = 0x00000040,
        /// <summary>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT specifies that an image
        /// view can be used as a framebuffer color attachment and as an input
        /// attachment.</summary>
        ColorAttachment = 0x00000080,
        /// <summary>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT specifies that an
        /// image view can be used as a framebuffer color attachment that supports
        /// blending and as an input attachment.</summary>
        ColorAttachmentBlend = 0x00000100,
        /// <summary>VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT specifies that an
        /// image view can be used as a framebuffer depth/stencil attachment and as
        /// an input attachment.</summary>
        DepthStencilAttachment = 0x00000200,
        /// <summary>VK_FORMAT_FEATURE_BLIT_SRC_BIT specifies that an image can be
        /// used as srcImage for the vkCmdBlitImage command.</summary>
        BlitSrc = 0x00000400,
        /// <summary>VK_FORMAT_FEATURE_BLIT_DST_BIT specifies that an image can be
        /// used as dstImage for the vkCmdBlitImage command.</summary>
        BlitDst = 0x00000800,
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT specifies that
        /// if VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is also set, an image view
        /// can be used with a sampler that has either of magFilter or
        /// minFilter set to VK_FILTER_LINEAR, or mipmapMode set
        /// to VK_SAMPLER_MIPMAP_MODE_LINEAR.
        /// If VK_FORMAT_FEATURE_BLIT_SRC_BIT is also set, an image can be
        /// used as the srcImage to vkCmdBlitImage with a filter
        /// of VK_FILTER_LINEAR.
        /// This bit must only be exposed for formats that also support the
        /// VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or
        /// VK_FORMAT_FEATURE_BLIT_SRC_BIT.</summary>
        SampledImageFilterLinear = 0x00001000,
        /// <summary>VK_FORMAT_FEATURE_TRANSFER_SRC_BIT specifies that an image can be
        /// used as a source image for copy commands.</summary>
        TransferSrc = 0x00004000,
        /// <summary>VK_FORMAT_FEATURE_TRANSFER_DST_BIT specifies that an image can be
        /// used as a destination image for copy commands and clear commands.</summary>
        TransferDst = 0x00008000,
        /// <summary>VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT specifies that an
        /// application can define a sampler Y¡¯CBCR
        /// conversion using this format as a source, and that an image of this
        /// format can be used with a VkSamplerYcbcrConversionCreateInfoxChromaOffset and/or yChromaOffset of
        /// VK_CHROMA_LOCATION_MIDPOINT.
        /// Otherwise both xChromaOffset and yChromaOffsetmust be
        /// VK_CHROMA_LOCATION_COSITED_EVEN.
        /// If a format does not incorporate chroma downsampling (it is not a
        /// ¡°422¡± or ¡°420¡± format) but the implementation supports sampler
        /// Y¡¯CBCR conversion for this format, the implementation must set
        /// VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT.</summary>
        MidpointChromaSamples = 0x00020000,
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT
        /// specifies that the format can do linear sampler filtering
        /// (min/magFilter) whilst sampler Y¡¯CBCR conversion is enabled.</summary>
        SampledImageYcbcrConversionLinearFilter = 0x00040000,
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT
        /// specifies that the format can have different chroma, min, and mag
        /// filters.</summary>
        SampledImageYcbcrConversionSeparateReconstructionFilter = 0x00080000,
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT
        /// specifies that reconstruction is explicit, as described in
        /// html/vkspec.html#textures-chroma-reconstruction.
        /// If this bit is not present, reconstruction is implicit by default.</summary>
        SampledImageYcbcrConversionChromaReconstructionExplicit = 0x00100000,
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT
        /// specifies that reconstruction can be forcibly made explicit by setting
        /// VkSamplerYcbcrConversionCreateInfo::forceExplicitReconstruction
        /// to VK_TRUE.</summary>
        SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 0x00200000,
        /// <summary>VK_FORMAT_FEATURE_DISJOINT_BIT specifies that a multi-planar image
        /// can have the VK_IMAGE_CREATE_DISJOINT_BIT set during image
        /// creation.
        /// An implementation must not set VK_FORMAT_FEATURE_DISJOINT_BIT for
        /// single-plane formats.</summary>
        Disjoint = 0x00400000,
        /// <summary>VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT specifies that an
        /// application can define a sampler Y¡¯CBCR
        /// conversion using this format as a source, and that an image of this
        /// format can be used with a VkSamplerYcbcrConversionCreateInfoxChromaOffset and/or yChromaOffset of
        /// VK_CHROMA_LOCATION_COSITED_EVEN.
        /// Otherwise both xChromaOffset and yChromaOffsetmust be
        /// VK_CHROMA_LOCATION_MIDPOINT.
        /// If neither VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT nor
        /// VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT is set, the
        /// application must not define a sampler
        /// Y¡¯CBCR conversion using this format as a source.</summary>
        CositedChromaSamples = 0x00800000,
        SampledImageFilterCubicImg = 0x00002000,
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT specifies
        /// VkImagecan be used as a sampled image with a min or max
        /// VkSamplerReductionModeEXT.
        /// This bit must only be exposed for formats that also support the
        /// VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT.</summary>
        SampledImageFilterMinmaxExt = 0x00010000,
        /// <summary>VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT specifies that an
        /// image view can be used as a
        /// fragment density map
        /// attachment.</summary>
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
        /// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT specifies
        /// that VkImagecan be used with a sampler that has either of
        /// magFilter or minFilter set to VK_FILTER_CUBIC_EXT, or
        /// be the source image for a blit with filter set to
        /// VK_FILTER_CUBIC_EXT.
        /// This bit must only be exposed for formats that also support the
        /// VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT.
        /// If the format being queried is a depth/stencil format, this only
        /// specifies that the depth aspect is cubic filterable.</summary>
        SampledImageFilterCubicExt = SampledImageFilterCubicImg,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 63
    /// <summary>VkFrontFace - Interpret polygon front-facing orientation</summary>
    public enum VkFrontFace {
        /// <summary>VK_FRONT_FACE_COUNTER_CLOCKWISE specifies that a triangle with
        /// positive area is considered front-facing.</summary>
        CounterClockwise = 0,
        /// <summary>VK_FRONT_FACE_CLOCKWISE specifies that a triangle with negative
        /// area is considered front-facing.</summary>
        Clockwise = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 64
    /// <summary>VkFullScreenExclusiveEXT - Hint values an application can specify affecting full-screen transition behavior</summary>
    public enum VkFullScreenExclusiveEXT {
        /// <summary>VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT indicates the implementation
        /// should determine the appropriate full-screen method by whatever means
        /// it deems appropriate.</summary>
        DefaultExt = 0,
        /// <summary>VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT indicates the implementation
        /// may use full-screen exclusive mechanisms when available.
        /// Such mechanisms may result in better performance and/or the
        /// availability of different presentation capabilities, but may require a
        /// more disruptive transition during swapchain initialization, first
        /// presentation and/or destruction.</summary>
        AllowedExt = 1,
        /// <summary>VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT indicates the
        /// implementation should avoid using full-screen mechanisms which rely on
        /// disruptive transitions.</summary>
        DisallowedExt = 2,
        /// <summary>VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT indicates the
        /// application will manage full-screen exclusive mode by using the
        /// vkAcquireFullScreenExclusiveModeEXT and
        /// vkReleaseFullScreenExclusiveModeEXT commands.</summary>
        ApplicationControlledExt = 3,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 65
    /// <summary>VkGeometryFlagBitsNV - Bitmask specifying additional parameters for a geometry</summary>
    [Flags]
    public enum VkGeometryFlagBitsNV {
        /// <summary>VK_GEOMETRY_OPAQUE_BIT_NV indicates that this geometry does not
        /// invoke the any-hit shaders even if present in a hit group.</summary>
        OpaqueNv = 0x00000001,
        /// <summary>VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV indicates that
        /// the implementation must only call the any-hit shader a single time for
        /// each primitive in this geometry.
        /// If this bit is absent an implementation may invoke the any-hit shader
        /// more than once for this geometry.</summary>
        NoDuplicateAnyHitInvocationNv = 0x00000002,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 66
    /// <summary>VkGeometryInstanceFlagBitsNV - Instance flag bits</summary>
    [Flags]
    public enum VkGeometryInstanceFlagBitsNV {
        /// <summary>VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV disables face
        /// culling for this instance.</summary>
        TriangleCullDisableNv = 0x00000001,
        /// <summary>VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV
        /// indicates that the front face of the triangle for culling purposes is
        /// the face that is counter clockwise in object space relative to the ray
        /// origin.
        /// Because the facing is determined in object space, an instance transform
        /// matrix does not change the winding, but a geometry transform does.</summary>
        TriangleFrontCounterclockwiseNv = 0x00000002,
        /// <summary>VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV causes this instance to
        /// act as though VK_GEOMETRY_OPAQUE_BIT_NV were specified on all
        /// geometries referenced by this instance.
        /// This behavior can be overridden by the ray flag
        /// gl_RayFlagsNoOpaqueNV.</summary>
        ForceOpaqueNv = 0x00000004,
        /// <summary>VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV causes this instance
        /// to act as though VK_GEOMETRY_OPAQUE_BIT_NV were not specified on
        /// all geometries referenced by this instance.
        /// This behavior can be overridden by the ray flag
        /// gl_RayFlagsOpaqueNV.</summary>
        ForceNoOpaqueNv = 0x00000008,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 67
    /// <summary>VkGeometryTypeNV - Enum specifying which type of geometry is provided</summary>
    public enum VkGeometryTypeNV {
        /// <summary>VK_GEOMETRY_TYPE_TRIANGLES_NV indicates that the triangles
        /// of VkGeometryDataNV contains valid data.</summary>
        TrianglesNv = 0,
        /// <summary>VK_GEOMETRY_TYPE_AABBS_NV indicates that the aabbs of
        /// VkGeometryDataNV contains valid data.</summary>
        AabbsNv = 1,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 68
    /// <summary>VkImageAspectFlagBits - Bitmask specifying which aspects of an image are included in a view</summary>
    [Flags]
    public enum VkImageAspectFlagBits {
        /// <summary>VK_IMAGE_ASPECT_COLOR_BIT specifies the color aspect.</summary>
        Color = 0x00000001,
        /// <summary>VK_IMAGE_ASPECT_DEPTH_BIT specifies the depth aspect.</summary>
        Depth = 0x00000002,
        /// <summary>VK_IMAGE_ASPECT_STENCIL_BIT specifies the stencil aspect.</summary>
        Stencil = 0x00000004,
        /// <summary>VK_IMAGE_ASPECT_METADATA_BIT specifies the metadata aspect, used
        /// for sparse sparse resource operations.</summary>
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
        /// <summary>VK_IMAGE_CREATE_SPARSE_BINDING_BIT specifies that the image will
        /// be backed using sparse memory binding.</summary>
        SparseBinding = 0x00000001,
        /// <summary>VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT specifies that the image can
        /// be partially backed using sparse memory binding.
        /// Images created with this flag must also be created with the
        /// VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag.</summary>
        SparseResidency = 0x00000002,
        /// <summary>VK_IMAGE_CREATE_SPARSE_ALIASED_BIT specifies that the image will
        /// be backed using sparse memory binding with memory ranges that might also
        /// simultaneously be backing another image (or another portion of the same
        /// image).
        /// Images created with this flag must also be created with the
        /// VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag</summary>
        SparseAliased = 0x00000004,
        /// <summary>VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT specifies that the image can
        /// be used to create a VkImageView with a different format from the
        /// image.
        /// For multi-planar formats,
        /// VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT specifies that a
        /// VkImageView can be created of a plane of the image.</summary>
        MutableFormat = 0x00000008,
        /// <summary>VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT specifies that the image can
        /// be used to create a VkImageView of type
        /// VK_IMAGE_VIEW_TYPE_CUBE or VK_IMAGE_VIEW_TYPE_CUBE_ARRAY.</summary>
        CubeCompatible = 0x00000010,
        /// <summary>VK_IMAGE_CREATE_ALIAS_BIT specifies that two images created with
        ///     the same creation parameters and aliased to the same memory can
        ///     interpret the contents of the memory consistently with each other,
        ///     subject to the rules described in the Memory
        ///     Aliasing section.
        ///     This flag further specifies that each plane of a disjoint image can
        ///     share an in-memory non-linear representation with single-plane images,
        ///     and that a single-plane image can share an in-memory non-linear
        ///     representation with a plane of a multi-planar disjoint image, according
        ///     to the rules in html/vkspec.html#formats-compatible-planes.
        ///     If the pNext chain includes a
        /// VkExternalMemoryImageCreateInfo
        /// or
        /// VkExternalMemoryImageCreateInfoNV
        ///     structure whose handleTypes member is not 0, it is as if
        ///     VK_IMAGE_CREATE_ALIAS_BIT is set.</summary>
        Alias = 0x00000400,
        /// <summary>VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT specifies that the
        /// image can be used with a non-zero value of the
        /// splitInstanceBindRegionCount member of a
        /// VkBindImageMemoryDeviceGroupInfo structure passed into
        /// vkBindImageMemory2.
        /// This flag also has the effect of making the image use the standard
        /// sparse image block dimensions.</summary>
        SplitInstanceBindRegions = 0x00000040,
        /// <summary>VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT specifies that the image
        /// can be used to create a VkImageView of type
        /// VK_IMAGE_VIEW_TYPE_2D or VK_IMAGE_VIEW_TYPE_2D_ARRAY.</summary>
        _2dArrayCompatible = 0x00000020,
        /// <summary>VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT specifies that the
        /// image having a compressed format can be used to create a
        /// VkImageView with an uncompressed format where each texel in the
        /// image view corresponds to a compressed texel block of the image.</summary>
        BlockTexelViewCompatible = 0x00000080,
        /// <summary>VK_IMAGE_CREATE_EXTENDED_USAGE_BIT specifies that the image can
        /// be created with usage flags that are not supported for the format the
        /// image is created with but are supported for at least one format a
        /// VkImageView created from the image can have.</summary>
        ExtendedUsage = 0x00000100,
        /// <summary>VK_IMAGE_CREATE_PROTECTED_BIT specifies that the image is a
        /// protected image.</summary>
        Protected = 0x00000800,
        /// <summary>VK_IMAGE_CREATE_DISJOINT_BIT specifies that an image with a
        /// multi-planar formatmust
        /// have each plane separately bound to memory, rather than having a single
        /// memory binding for the whole image; the presence of this bit
        /// distinguishes a disjoint image from an image without this bit set.</summary>
        Disjoint = 0x00000200,
        /// <summary>VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV specifies that the image is
        /// a corner-sampled image.</summary>
        CornerSampledNv = 0x00002000,
        /// <summary>VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT
        /// specifies that an image with a depth or depth/stencil format can be
        /// used with custom sample locations when used as a depth/stencil
        /// attachment.</summary>
        SampleLocationsCompatibleDepthExt = 0x00001000,
        /// <summary>VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT specifies that an image can be
        /// in a subsampled format which may be more optimal when written as an
        /// attachment by a render pass that has a fragment density map attachment.
        /// Accessing a subsampled image has additional considerations:</summary>
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
        /// <summary>VK_IMAGE_LAYOUT_UNDEFINED does not support device access.
        /// This layout must only be used as the initialLayout member of
        /// VkImageCreateInfo or VkAttachmentDescription, or as the
        /// oldLayout in an image transition.
        /// When transitioning out of this layout, the contents of the memory are
        /// not guaranteed to be preserved.</summary>
        Undefined = 0,
        /// <summary>VK_IMAGE_LAYOUT_GENERAL supports all types of device access.</summary>
        General = 1,
        /// <summary>VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL
        ///   must only be used as a
        /// color or resolve attachment in a VkFramebuffer.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT usage bit enabled.</summary>
        ColorAttachmentOptimal = 2,
        /// <summary>VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL
        ///   must only be
        /// used as a depth/stencil
        /// or depth/stencil resolve
        /// attachment in a VkFramebuffer.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled.</summary>
        DepthStencilAttachmentOptimal = 3,
        /// <summary>VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL
        ///   must only be used
        /// as a read-only depth/stencil attachment in a VkFramebuffer and/or
        /// as a read-only image in a shader (which can be read as a sampled image,
        /// combined image/sampler and/or input attachment).
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled.
        /// Only image views created with a usage value including
        /// VK_IMAGE_USAGE_SAMPLED_BITcan be used as a sampled image or
        /// combined image/sampler in a shader.
        /// Similarly, only image views created with a usage value including
        /// VK_IMAGE_USAGE_INPUT_ATTACHMENT_BITcan be used as input
        /// attachments.</summary>
        DepthStencilReadOnlyOptimal = 4,
        /// <summary>VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL
        ///   must only be used as a
        /// read-only image in a shader (which can be read as a sampled image,
        /// combined image/sampler and/or input attachment).
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_SAMPLED_BIT or
        /// VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT usage bit enabled.</summary>
        ShaderReadOnlyOptimal = 5,
        /// <summary>VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL
        ///   must only be used as a
        /// source image of a transfer command (see the definition of
        /// VK_PIPELINE_STAGE_TRANSFER_BIT).
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_TRANSFER_SRC_BIT usage bit enabled.</summary>
        TransferSrcOptimal = 6,
        /// <summary>VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL
        ///   must only be used as a
        /// destination image of a transfer command.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_TRANSFER_DST_BIT usage bit enabled.</summary>
        TransferDstOptimal = 7,
        /// <summary>VK_IMAGE_LAYOUT_PREINITIALIZED does not support device access.
        /// This layout must only be used as the initialLayout member of
        /// VkImageCreateInfo or VkAttachmentDescription, or as the
        /// oldLayout in an image transition.
        /// When transitioning out of this layout, the contents of the memory are
        /// preserved.
        /// This layout is intended to be used as the initial layout for an image
        /// whose contents are written by the host, and hence the data can be
        /// written to memory immediately, without first executing a layout
        /// transition.
        /// Currently, VK_IMAGE_LAYOUT_PREINITIALIZED is only useful with
        /// linear images because there is not a
        /// standard layout defined for VK_IMAGE_TILING_OPTIMAL images.</summary>
        Preinitialized = 8,
        /// <summary>VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL: must
        /// only be used as a depth/stencil attachment in a VkFramebuffer,
        /// where the depth aspect is read-only, and/or as a read-only image in a
        /// shader (which can be read as a sampled image, combined image/sampler
        /// and/or input attachment) where only the depth aspect is accessed.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled.
        /// Only image views created with a usage value including
        /// VK_IMAGE_USAGE_SAMPLED_BITcan be used as a sampled image or
        /// combined image/sampler in a shader.
        /// Similarly, only image views created with a usage value including
        /// VK_IMAGE_USAGE_INPUT_ATTACHMENT_BITcan be used as input
        /// attachments.</summary>
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,
        /// <summary>VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL: must
        /// only be used as a depth/stencil attachment in a VkFramebuffer,
        /// where the stencil aspect is read-only, and/or as a read-only image in a
        /// shader (which can be read as a sampled image, combined image/sampler
        /// and/or input attachment) where only the stencil aspect is accessed.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled.
        /// Only image views created with a usage value including
        /// VK_IMAGE_USAGE_SAMPLED_BITcan be used as a sampled image or
        /// combined image/sampler in a shader.
        /// Similarly, only image views created with a usage value including
        /// VK_IMAGE_USAGE_INPUT_ATTACHMENT_BITcan be used as input
        /// attachments.</summary>
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,
        /// <summary>VK_IMAGE_LAYOUT_PRESENT_SRC_KHR
        ///   must only be used for presenting
        /// a presentable image for display.
        /// A swapchain¡¯s image must be transitioned to this layout before calling
        /// vkQueuePresentKHR, and must be transitioned away from this layout
        /// after calling vkAcquireNextImageKHR.</summary>
        PresentSrcKHR = 1000001002,
        /// <summary>VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR is valid only for shared
        /// presentable images, and must be used for any usage the image supports.</summary>
        SharedPresentKHR = 1000111000,
        /// <summary>VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV
        ///   must only be used as a
        /// read-only shading-rate-image.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV usage bit enabled.</summary>
        ShadingRateOptimalNv = 1000164003,
        /// <summary>VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT
        ///   must only be
        /// used as a fragment density map attachment in a VkRenderPass.
        /// This layout is valid only for image subresources of images created with
        /// the VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT usage bit enabled.</summary>
        FragmentDensityMapOptimalExt = 1000218000,
        DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,
        DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 71
    /// <summary>VkImageTiling - Specifies the tiling arrangement of data in an image</summary>
    public enum VkImageTiling {
        /// <summary>VK_IMAGE_TILING_OPTIMAL specifies optimal tiling (texels are laid
        /// out in an implementation-dependent arrangement, for more optimal memory
        /// access).</summary>
        Optimal = 0,
        /// <summary>VK_IMAGE_TILING_LINEAR specifies linear tiling (texels are laid
        /// out in memory in row-major order, possibly with some padding on each
        /// row).</summary>
        Linear = 1,
        /// <summary>VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT indicates that the image¡¯s
        /// tiling is defined by a Linux DRM format
        /// modifier.
        /// The modifier is specified at image creation with
        /// VkImageDrmFormatModifierListCreateInfoEXT or
        /// VkImageDrmFormatModifierExplicitCreateInfoEXT, and can be queried
        /// with vkGetImageDrmFormatModifierPropertiesEXT.</summary>
        DrmFormatModifierExt = 1000158000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 72
    /// <summary>VkImageType - Specifies the type of an image object</summary>
    public enum VkImageType {
        /// <summary>VK_IMAGE_TYPE_1D specifies a one-dimensional image.</summary>
        _1d = 0,
        /// <summary>VK_IMAGE_TYPE_2D specifies a two-dimensional image.</summary>
        _2d = 1,
        /// <summary>VK_IMAGE_TYPE_3D specifies a three-dimensional image.</summary>
        _3d = 2,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 73
    /// <summary>VkImageUsageFlagBits - Bitmask specifying intended usage of an image</summary>
    [Flags]
    public enum VkImageUsageFlagBits {
        /// <summary>VK_IMAGE_USAGE_TRANSFER_SRC_BIT specifies that the image can be
        /// used as the source of a transfer command.</summary>
        TransferSrc = 0x00000001,
        /// <summary>VK_IMAGE_USAGE_TRANSFER_DST_BIT specifies that the image can be
        /// used as the destination of a transfer command.</summary>
        TransferDst = 0x00000002,
        /// <summary>VK_IMAGE_USAGE_SAMPLED_BIT specifies that the image can be used
        /// to create a VkImageView suitable for occupying a
        /// VkDescriptorSet slot either of type
        /// VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE or
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and be sampled by a
        /// shader.</summary>
        Sampled = 0x00000004,
        /// <summary>VK_IMAGE_USAGE_STORAGE_BIT specifies that the image can be used
        /// to create a VkImageView suitable for occupying a
        /// VkDescriptorSet slot of type
        /// VK_DESCRIPTOR_TYPE_STORAGE_IMAGE.</summary>
        Storage = 0x00000008,
        /// <summary>VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT specifies that the image can
        /// be used to create a VkImageView suitable for use as a color or
        /// resolve attachment in a VkFramebuffer.</summary>
        ColorAttachment = 0x00000010,
        /// <summary>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT specifies that the
        /// image can be used to create a VkImageView suitable for use as a
        /// depth/stencil
        /// or depth/stencil resolve
        /// attachment in a VkFramebuffer.</summary>
        DepthStencilAttachment = 0x00000020,
        /// <summary>VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT specifies that the memory
        /// bound to this image will have been allocated with the
        /// VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT (see html/vkspec.html#memory for more
        /// detail).
        /// This bit can be set for any image that can be used to create a
        /// VkImageView suitable for use as a color, resolve, depth/stencil,
        /// or input attachment.</summary>
        TransientAttachment = 0x00000040,
        /// <summary>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT specifies that the image can
        /// be used to create a VkImageView suitable for occupying
        /// VkDescriptorSet slot of type
        /// VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT; be read from a shader as an
        /// input attachment; and be used as an input attachment in a framebuffer.</summary>
        InputAttachment = 0x00000080,
        /// <summary>VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV specifies that the image
        /// can be used to create a VkImageView suitable for use as a
        /// shading rate image.</summary>
        ShadingRateImageNv = 0x00000100,
        FragmentDensityMapExt = 0x00000200,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 74
    /// <summary>VkImageViewCreateFlagBits - Bitmask specifying additional parameters of an image view</summary>
    [Flags]
    public enum VkImageViewCreateFlagBits {
        /// <summary>VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT
        /// prohibits the implementation from accessing the fragment density map by
        /// the host during vkCmdBeginRenderPass as the contents are expected
        /// to change after recording</summary>
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
        /// <summary>VK_INDEX_TYPE_UINT16 specifies that indices are 16-bit unsigned
        /// integer values.</summary>
        Uint16 = 0,
        /// <summary>VK_INDEX_TYPE_UINT32 specifies that indices are 32-bit unsigned
        /// integer values.</summary>
        Uint32 = 1,
        /// <summary>VK_INDEX_TYPE_NONE_NV specifies that no indices are provided.</summary>
        NoneNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 77
    /// <summary>VkIndirectCommandsLayoutUsageFlagBitsNVX - Bitmask specifying allowed usage of an indirect commands layout</summary>
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagBitsNVX {
        /// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVX
        /// specifies that the processing of sequences can happen at an
        /// implementation-dependent order, which is not guaranteed to be coherent
        /// across multiple invocations.</summary>
        UnorderedSequencesNvx = 0x00000001,
        /// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_SPARSE_SEQUENCES_BIT_NVX
        /// specifies that there is likely a high difference between allocated
        /// number of sequences and actually used.</summary>
        SparseSequencesNvx = 0x00000002,
        /// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EMPTY_EXECUTIONS_BIT_NVX
        /// specifies that there are likely many draw or dispatch calls that are
        /// zero-sized (zero grid dimension, no primitives to render).</summary>
        EmptyExecutionsNvx = 0x00000004,
        /// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX
        /// specifies that the input data for the sequences is not implicitly
        /// indexed from 0..sequencesUsed but a user provided VkBuffer
        /// encoding the index is provided.</summary>
        IndexedSequencesNvx = 0x00000008,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 78
    /// <summary>VkIndirectCommandsTokenTypeNVX - Enum specifying</summary>
    public enum VkIndirectCommandsTokenTypeNVX {
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NVX</summary>
        PipelineNvx = 0,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_DESCRIPTOR_SET_NVX</summary>
        DescriptorSetNvx = 1,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NVX</summary>
        IndexBufferNvx = 2,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NVX</summary>
        VertexBufferNvx = 3,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NVX</summary>
        PushConstantNvx = 4,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NVX</summary>
        DrawIndexedNvx = 5,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NVX</summary>
        DrawNvx = 6,
        /// <summary>class="tableblock"
        ///   VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NVX</summary>
        DispatchNvx = 7,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 79
    /// <summary>VkInternalAllocationType - Allocation type</summary>
    public enum VkInternalAllocationType {
        /// <summary>VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE specifies that the
        /// allocation is intended for execution by the host.</summary>
        Executable = 0,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 80
    /// <summary>VkLogicOp - Framebuffer logical operations</summary>
    public enum VkLogicOp {
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_CLEAR</summary>
        Clear = 0,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_AND</summary>
        And = 1,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_AND_REVERSE</summary>
        AndReverse = 2,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_COPY</summary>
        Copy = 3,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_AND_INVERTED</summary>
        AndInverted = 4,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_NO_OP</summary>
        NoOp = 5,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_XOR</summary>
        Xor = 6,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_OR</summary>
        Or = 7,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_NOR</summary>
        Nor = 8,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_EQUIVALENT</summary>
        Equivalent = 9,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_INVERT</summary>
        Invert = 10,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_OR_REVERSE</summary>
        OrReverse = 11,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_COPY_INVERTED</summary>
        CopyInverted = 12,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_OR_INVERTED</summary>
        OrInverted = 13,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_NAND</summary>
        Nand = 14,
        /// <summary>class="tableblock"
        ///   VK_LOGIC_OP_SET</summary>
        Set = 15,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 81
    /// <summary>VkMemoryAllocateFlagBits - Bitmask specifying flags for a device memory allocation</summary>
    [Flags]
    public enum VkMemoryAllocateFlagBits {
        /// <summary>VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT specifies that memory will be
        /// allocated for the devices in
        /// VkMemoryAllocateFlagsInfo::deviceMask.</summary>
        DeviceMask = 0x00000001,
        DeviceMaskKHR = DeviceMask,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 82
    /// <summary>VkMemoryHeapFlagBits - Bitmask specifying attribute flags for a heap</summary>
    [Flags]
    public enum VkMemoryHeapFlagBits {
        /// <summary>VK_MEMORY_HEAP_DEVICE_LOCAL_BIT specifies that the heap
        /// corresponds to device local memory.
        /// Device local memory may have different performance characteristics than
        /// host local memory, and may support different memory property flags.</summary>
        DeviceLocal = 0x00000001,
        /// <summary>VK_MEMORY_HEAP_MULTI_INSTANCE_BIT specifies that in a logical
        /// device representing more than one physical device, there is a
        /// per-physical device instance of the heap memory.
        /// By default, an allocation from such a heap will be replicated to each
        /// physical device¡¯s instance of the heap.</summary>
        MultiInstance = 0x00000002,
        MultiInstanceKHR = MultiInstance,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 83
    /// <summary>VkMemoryOverallocationBehaviorAMD - Specify memory overallocation behavior</summary>
    public enum VkMemoryOverallocationBehaviorAMD {
        /// <summary>VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD lets the
        /// implementation decide if overallocation should be allowed.</summary>
        DefaultAmd = 0,
        /// <summary>VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD specifies
        /// overallocation is allowed if platform permits.</summary>
        AllowedAmd = 1,
        /// <summary>VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD specifies the
        /// application is not allowed to allocate device memory beyond the heap
        /// sizes reported by VkPhysicalDeviceMemoryProperties.
        /// Allocations that are not explicitly made by the application within the
        /// scope of the Vulkan instance are not accounted for.</summary>
        DisallowedAmd = 2,
        MaxEnumAmd = 0x7FFFFFFF,
    }
    // Enum: 84
    /// <summary>VkMemoryPropertyFlagBits - Bitmask specifying properties for a memory type</summary>
    [Flags]
    public enum VkMemoryPropertyFlagBits {
        /// <summary>VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT bit specifies that memory
        /// allocated with this type is the most efficient for device access.
        /// This property will be set if and only if the memory type belongs to a
        /// heap with the VK_MEMORY_HEAP_DEVICE_LOCAL_BIT set.</summary>
        DeviceLocal = 0x00000001,
        /// <summary>VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT bit specifies that memory
        /// allocated with this type can be mapped for host access using
        /// vkMapMemory.</summary>
        HostVisible = 0x00000002,
        /// <summary>VK_MEMORY_PROPERTY_HOST_COHERENT_BIT bit specifies that the host
        /// cache management commands vkFlushMappedMemoryRanges and
        /// vkInvalidateMappedMemoryRanges are not needed to flush host writes
        /// to the device or make device writes visible to the host, respectively.</summary>
        HostCoherent = 0x00000004,
        /// <summary>VK_MEMORY_PROPERTY_HOST_CACHED_BIT bit specifies that memory
        /// allocated with this type is cached on the host.
        /// Host memory accesses to uncached memory are slower than to cached
        /// memory, however uncached memory is always host coherent.</summary>
        HostCached = 0x00000008,
        /// <summary>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT bit specifies that the
        /// memory type only allows device access to the memory.
        /// Memory types must not have both
        /// VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT and
        /// VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT set.
        /// Additionally, the object¡¯s backing memory may be provided by the
        /// implementation lazily as specified in Lazily Allocated Memory.</summary>
        LazilyAllocated = 0x00000010,
        /// <summary>VK_MEMORY_PROPERTY_PROTECTED_BIT bit specifies that the memory
        /// type only allows device access to the memory, and allows protected queue
        /// operations to access the memory.
        /// Memory types must not have VK_MEMORY_PROPERTY_PROTECTED_BIT set
        /// and any of VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT set, or
        /// VK_MEMORY_PROPERTY_HOST_COHERENT_BIT set, or
        /// VK_MEMORY_PROPERTY_HOST_CACHED_BIT set.</summary>
        Protected = 0x00000020,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 85
    /// <summary>VkObjectEntryTypeNVX - Enum specifying object table entry type</summary>
    public enum VkObjectEntryTypeNVX {
        /// <summary>VK_OBJECT_ENTRY_TYPE_DESCRIPTOR_SET_NVX specifies a
        /// VkDescriptorSet resource entry that is registered via
        /// VkObjectTableDescriptorSetEntryNVX.</summary>
        DescriptorSetNvx = 0,
        /// <summary>VK_OBJECT_ENTRY_TYPE_PIPELINE_NVX specifies a VkPipeline
        /// resource entry that is registered via
        /// VkObjectTablePipelineEntryNVX.</summary>
        PipelineNvx = 1,
        /// <summary>VK_OBJECT_ENTRY_TYPE_INDEX_BUFFER_NVX specifies a VkBuffer
        /// resource entry that is registered via
        /// VkObjectTableIndexBufferEntryNVX.</summary>
        IndexBufferNvx = 2,
        /// <summary>VK_OBJECT_ENTRY_TYPE_VERTEX_BUFFER_NVX specifies a VkBuffer
        /// resource entry that is registered via
        /// VkObjectTableVertexBufferEntryNVX.</summary>
        VertexBufferNvx = 3,
        /// <summary>VK_OBJECT_ENTRY_TYPE_PUSH_CONSTANT_NVX specifies the resource
        /// entry is registered via VkObjectTablePushConstantEntryNVX.</summary>
        PushConstantNvx = 4,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 86
    /// <summary>VkObjectEntryUsageFlagBitsNVX - Bitmask specifying allowed usage of an object entry</summary>
    [Flags]
    public enum VkObjectEntryUsageFlagBitsNVX {
        /// <summary>VK_OBJECT_ENTRY_USAGE_GRAPHICS_BIT_NVX specifies that the resource
        /// is bound to VK_PIPELINE_BIND_POINT_GRAPHICS</summary>
        GraphicsNvx = 0x00000001,
        /// <summary>VK_OBJECT_ENTRY_USAGE_COMPUTE_BIT_NVX specifies that the resource
        /// is bound to VK_PIPELINE_BIND_POINT_COMPUTE</summary>
        ComputeNvx = 0x00000002,
        MaxEnumNvx = 0x7FFFFFFF,
    }
    // Enum: 87
    /// <summary>VkObjectType - Specify an enumeration to track object handle types</summary>
    public enum VkObjectType {
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_UNKNOWN</summary>
        Unknown = 0,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_INSTANCE</summary>
        Instance = 1,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_PHYSICAL_DEVICE</summary>
        PhysicalDevice = 2,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DEVICE</summary>
        Device = 3,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_QUEUE</summary>
        Queue = 4,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_SEMAPHORE</summary>
        Semaphore = 5,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_COMMAND_BUFFER</summary>
        CommandBuffer = 6,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_FENCE</summary>
        Fence = 7,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DEVICE_MEMORY</summary>
        DeviceMemory = 8,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_BUFFER</summary>
        Buffer = 9,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_IMAGE</summary>
        Image = 10,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_EVENT</summary>
        Event = 11,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_QUERY_POOL</summary>
        QueryPool = 12,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_BUFFER_VIEW</summary>
        BufferView = 13,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_IMAGE_VIEW</summary>
        ImageView = 14,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_SHADER_MODULE</summary>
        ShaderModule = 15,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_PIPELINE_CACHE</summary>
        PipelineCache = 16,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_PIPELINE_LAYOUT</summary>
        PipelineLayout = 17,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_RENDER_PASS</summary>
        RenderPass = 18,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_PIPELINE</summary>
        Pipeline = 19,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT</summary>
        DescriptorSetLayout = 20,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_SAMPLER</summary>
        Sampler = 21,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DESCRIPTOR_POOL</summary>
        DescriptorPool = 22,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DESCRIPTOR_SET</summary>
        DescriptorSet = 23,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_FRAMEBUFFER</summary>
        Framebuffer = 24,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_COMMAND_POOL</summary>
        CommandPool = 25,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION</summary>
        SamplerYcbcrConversion = 1000156000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE</summary>
        DescriptorUpdateTemplate = 1000085000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_SURFACE_KHR</summary>
        SurfaceKHR = 1000000000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_SWAPCHAIN_KHR</summary>
        SwapchainKHR = 1000001000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DISPLAY_KHR</summary>
        DisplayKHR = 1000002000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DISPLAY_MODE_KHR</summary>
        DisplayModeKHR = 1000002001,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT</summary>
        DebugReportCallbackExt = 1000011000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_OBJECT_TABLE_NVX</summary>
        ObjectTableNvx = 1000086000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX</summary>
        IndirectCommandsLayoutNvx = 1000086001,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT</summary>
        DebugUtilsMessengerExt = 1000128000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_VALIDATION_CACHE_EXT</summary>
        ValidationCacheExt = 1000160000,
        /// <summary>class="tableblock"
        ///   VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV</summary>
        AccelerationStructureNv = 1000165000,
        DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,
        SamplerYcbcrConversionKHR = SamplerYcbcrConversion,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 88
    /// <summary>VkPeerMemoryFeatureFlagBits - Bitmask specifying supported peer memory features</summary>
    [Flags]
    public enum VkPeerMemoryFeatureFlagBits {
        /// <summary>VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT specifies that the memory can
        /// be accessed as the source of a vkCmdCopyBuffer,
        /// vkCmdCopyImage, vkCmdCopyBufferToImage, or
        /// vkCmdCopyImageToBuffer command.</summary>
        CopySrc = 0x00000001,
        /// <summary>VK_PEER_MEMORY_FEATURE_COPY_DST_BIT specifies that the memory can
        /// be accessed as the destination of a vkCmdCopyBuffer,
        /// vkCmdCopyImage, vkCmdCopyBufferToImage, or
        /// vkCmdCopyImageToBuffer command.</summary>
        CopyDst = 0x00000002,
        /// <summary>VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT specifies that the memory
        /// can be read as any memory access type.</summary>
        GenericSrc = 0x00000004,
        /// <summary>VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT specifies that the memory
        /// can be written as any memory access type.
        /// Shader atomics are considered to be writes.</summary>
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
        /// <summary>VK_PHYSICAL_DEVICE_TYPE_OTHER - the device does not match any
        /// other available types.</summary>
        Other = 0,
        /// <summary>VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU - the device is typically
        /// one embedded in or tightly coupled with the host.</summary>
        IntegratedGpu = 1,
        /// <summary>VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU - the device is typically a
        /// separate processor connected to the host via an interlink.</summary>
        DiscreteGpu = 2,
        /// <summary>VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU - the device is typically a
        /// virtual node in a virtualization environment.</summary>
        VirtualGpu = 3,
        /// <summary>VK_PHYSICAL_DEVICE_TYPE_CPU - the device is typically running on
        /// the same processors as the host.</summary>
        Cpu = 4,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 90
    /// <summary>VkPipelineBindPoint - Specify the bind point of a pipeline object to a command buffer</summary>
    public enum VkPipelineBindPoint {
        /// <summary>VK_PIPELINE_BIND_POINT_GRAPHICS specifies binding as a graphics
        /// pipeline.</summary>
        Graphics = 0,
        /// <summary>VK_PIPELINE_BIND_POINT_COMPUTE specifies binding as a compute
        /// pipeline.</summary>
        Compute = 1,
        /// <summary>VK_PIPELINE_BIND_POINT_RAY_TRACING_NV specifies binding as a ray
        /// tracing pipeline.</summary>
        RayTracingNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 91
    /// <summary>VkPipelineCacheHeaderVersion - Encode pipeline cache version</summary>
    public enum VkPipelineCacheHeaderVersion {
        /// <summary>VK_PIPELINE_CACHE_HEADER_VERSION_ONE specifies version one of the
        /// pipeline cache.</summary>
        One = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 92
    /// <summary>VkPipelineCreateFlagBits - Bitmask controlling how a pipeline is created</summary>
    [Flags]
    public enum VkPipelineCreateFlagBits {
        /// <summary>VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that the
        /// created pipeline will not be optimized.
        /// Using this flag may reduce the time taken to create the pipeline.</summary>
        DisableOptimization = 0x00000001,
        /// <summary>VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the
        /// pipeline to be created is allowed to be the parent of a pipeline that
        /// will be created in a subsequent call to vkCreateGraphicsPipelines
        /// or vkCreateComputePipelines.</summary>
        AllowDerivatives = 0x00000002,
        /// <summary>VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline to
        /// be created will be a child of a previously created parent pipeline.</summary>
        Derivative = 0x00000004,
        /// <summary>VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT specifies that
        /// any shader input variables decorated as ViewIndex will be assigned
        /// values as if they were decorated as DeviceIndex.</summary>
        ViewIndexFromDeviceIndex = 0x00000008,
        /// <summary>VK_PIPELINE_CREATE_DISPATCH_BASE specifies that a compute pipeline
        /// can be used with vkCmdDispatchBase with a non-zero base
        /// workgroup.</summary>
        DispatchBase = 0x00000010,
        /// <summary>VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV specifies that a pipeline
        /// is created with all shaders in the deferred state.
        /// Before using the pipeline the application must call
        /// vkCompileDeferredNV exactly once on each shader in the pipeline
        /// before using the pipeline.</summary>
        DeferCompileNv = 0x00000020,
        ViewIndexFromDeviceIndexKHR = ViewIndexFromDeviceIndex,
        DispatchBaseKHR = DispatchBase,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 93
    /// <summary>VkPipelineCreationFeedbackFlagBitsEXT - Bitmask specifying pipeline or pipeline stage creation feedback</summary>
    [Flags]
    public enum VkPipelineCreationFeedbackFlagBitsEXT {
        /// <summary>VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT indicates that the
        /// feedback information is valid.</summary>
        ValidExt = 0x00000001,
        /// <summary>VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT
        /// indicates that a readily usable pipeline or pipeline stage was found in
        /// the pipelineCache specified by the application in the pipeline
        /// creation command.</summary>
        ApplicationPipelineCacheHitExt = 0x00000002,
        /// <summary>VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT
        /// indicates that the base pipeline specified by the
        /// basePipelineHandle or basePipelineIndex member of the
        /// Vk*PipelineCreateInfo structure was used to accelerate the
        /// creation of the pipeline.</summary>
        BasePipelineAccelerationExt = 0x00000004,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 94
    /// <summary>VkPipelineStageFlagBits - Bitmask specifying pipeline stages</summary>
    [Flags]
    public enum VkPipelineStageFlagBits {
        /// <summary>VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT specifies the stage of the
        /// pipeline where any commands are initially received by the queue.</summary>
        TopOfPipe = 0x00000001,
        /// <summary>VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT specifies the stage of the
        /// pipeline where Draw/DispatchIndirect data structures are consumed.
        /// This stage also includes reading commands written by
        /// vkCmdProcessCommandsNVX.</summary>
        DrawIndirect = 0x00000002,
        /// <summary>VK_PIPELINE_STAGE_VERTEX_INPUT_BIT specifies the stage of the
        /// pipeline where vertex and index buffers are consumed.</summary>
        VertexInput = 0x00000004,
        /// <summary>VK_PIPELINE_STAGE_VERTEX_SHADER_BIT specifies the vertex shader
        /// stage.</summary>
        VertexShader = 0x00000008,
        /// <summary>VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT specifies the
        /// tessellation control shader stage.</summary>
        TessellationControlShader = 0x00000010,
        /// <summary>VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT specifies the
        /// tessellation evaluation shader stage.</summary>
        TessellationEvaluationShader = 0x00000020,
        /// <summary>VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT specifies the geometry
        /// shader stage.</summary>
        GeometryShader = 0x00000040,
        /// <summary>VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT specifies the fragment
        /// shader stage.</summary>
        FragmentShader = 0x00000080,
        /// <summary>VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT specifies the stage of
        /// the pipeline where early fragment tests (depth and stencil tests before
        /// fragment shading) are performed.
        /// This stage also includes subpass load
        /// operations for framebuffer attachments with a depth/stencil format.</summary>
        EarlyFragmentTests = 0x00000100,
        /// <summary>VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT specifies the stage of
        /// the pipeline where late fragment tests (depth and stencil tests after
        /// fragment shading) are performed.
        /// This stage also includes subpass store
        /// operations for framebuffer attachments with a depth/stencil format.</summary>
        LateFragmentTests = 0x00000200,
        /// <summary>VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT specifies the stage
        /// of the pipeline after blending where the final color values are output
        /// from the pipeline.
        /// This stage also includes subpass load and
        /// store operations and multisample resolve operations for framebuffer
        /// attachments with a color
        /// or depth/stencil
        /// format.</summary>
        ColorAttachmentOutput = 0x00000400,
        /// <summary>VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT specifies the execution of a
        /// compute shader.</summary>
        ComputeShader = 0x00000800,
        /// <summary>
        ///   VK_PIPELINE_STAGE_TRANSFER_BIT specifies the execution of copy
        /// commands.
        /// This includes the operations resulting from all copy
        /// commands, clear commands (with the exception of
        /// vkCmdClearAttachments), and vkCmdCopyQueryPoolResults.</summary>
        Transfer = 0x00001000,
        /// <summary>VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT specifies the final stage in
        /// the pipeline where operations generated by all commands complete
        /// execution.</summary>
        BottomOfPipe = 0x00002000,
        /// <summary>VK_PIPELINE_STAGE_HOST_BIT specifies a pseudo-stage indicating
        /// execution on the host of reads/writes of device memory.
        /// This stage is not invoked by any commands recorded in a command buffer.</summary>
        Host = 0x00004000,
        /// <summary>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT specifies the execution of all
        /// graphics pipeline stages, and is equivalent to the logical OR of:</summary>
        AllGraphics = 0x00008000,
        /// <summary>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT is equivalent to the logical OR
        /// of every other pipeline stage flag that is supported on the queue it is
        /// used with.</summary>
        AllCommands = 0x00010000,
        /// <summary>VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT</summary>
        TransformFeedbackExt = 0x01000000,
        /// <summary>VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT</summary>
        ConditionalRenderingExt = 0x00040000,
        /// <summary>VK_PIPELINE_STAGE_COMMAND_PROCESS_BIT_NVX specifies the stage of
        /// the pipeline where device-side generation of commands via
        /// vkCmdProcessCommandsNVX is handled.</summary>
        CommandProcessNvx = 0x00020000,
        /// <summary>VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV</summary>
        ShadingRateImageNv = 0x00400000,
        /// <summary>VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV specifies the
        /// execution of the ray tracing shader stages.</summary>
        RayTracingShaderNv = 0x00200000,
        /// <summary>VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV specifies
        /// the execution of vkCmdBuildAccelerationStructureNV,
        /// vkCmdCopyAccelerationStructureNV, and
        /// vkCmdWriteAccelerationStructuresPropertiesNV.</summary>
        AccelerationStructureBuildNv = 0x02000000,
        /// <summary>VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV specifies the task shader
        /// stage.</summary>
        TaskShaderNv = 0x00080000,
        /// <summary>VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV specifies the mesh shader
        /// stage.</summary>
        MeshShaderNv = 0x00100000,
        /// <summary>VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT</summary>
        FragmentDensityProcessExt = 0x00800000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 95
    /// <summary>VkPointClippingBehavior - Enum specifying the point clipping behavior</summary>
    public enum VkPointClippingBehavior {
        /// <summary>VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES specifies that the
        /// primitive is discarded if the vertex lies outside any clip plane,
        /// including the planes bounding the view volume.</summary>
        AllClipPlanes = 0,
        /// <summary>VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY specifies that
        /// the primitive is discarded only if the vertex lies outside any user clip
        /// plane.</summary>
        UserClipPlanesOnly = 1,
        AllClipPlanesKHR = AllClipPlanes,
        UserClipPlanesOnlyKHR = UserClipPlanesOnly,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 96
    /// <summary>VkPolygonMode - Control polygon rasterization mode</summary>
    public enum VkPolygonMode {
        /// <summary>VK_POLYGON_MODE_FILL specifies that polygons are rendered using
        /// the polygon rasterization rules in this section.</summary>
        Fill = 0,
        /// <summary>VK_POLYGON_MODE_LINE specifies that polygon edges are drawn as
        /// line segments.</summary>
        Line = 1,
        /// <summary>VK_POLYGON_MODE_POINT specifies that polygon vertices are drawn as
        /// points.</summary>
        Point = 2,
        /// <summary>VK_POLYGON_MODE_FILL_RECTANGLE_NV specifies that polygons are
        /// rendered using polygon rasterization rules, modified to consider a
        /// sample within the primitive if the sample location is inside the
        /// axis-aligned bounding box of the triangle after projection.
        /// Note that the barycentric weights used in attribute interpolation can
        /// extend outside the range [0,1] when these primitives are shaded.
        /// Special treatment is given to a sample position on the boundary edge of
        /// the bounding box.
        /// In such a case, if two rectangles lie on either side of a common edge
        /// (with identical endpoints) on which a sample position lies, then exactly
        /// one of the triangles must produce a fragment that covers that sample
        /// during rasterization.</summary>
        FillRectangleNv = 1000153000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 97
    /// <summary>VkPresentModeKHR - presentation mode supported for a surface</summary>
    public enum VkPresentModeKHR {
        /// <summary>VK_PRESENT_MODE_IMMEDIATE_KHR specifies that the presentation
        /// engine does not wait for a vertical blanking period to update the
        /// current image, meaning this mode may result in visible tearing.
        /// No internal queuing of presentation requests is needed, as the requests
        /// are applied immediately.</summary>
        ImmediateKHR = 0,
        /// <summary>VK_PRESENT_MODE_MAILBOX_KHR specifies that the presentation engine
        /// waits for the next vertical blanking period to update the current image.
        /// Tearing cannot be observed.
        /// An internal single-entry queue is used to hold pending presentation
        /// requests.
        /// If the queue is full when a new presentation request is received, the
        /// new request replaces the existing entry, and any images associated with
        /// the prior entry become available for re-use by the application.
        /// One request is removed from the queue and processed during each vertical
        /// blanking period in which the queue is non-empty.</summary>
        MailboxKHR = 1,
        /// <summary>VK_PRESENT_MODE_FIFO_KHR specifies that the presentation engine
        /// waits for the next vertical blanking period to update the current image.
        /// Tearing cannot be observed.
        /// An internal queue is used to hold pending presentation requests.
        /// New requests are appended to the end of the queue, and one request is
        /// removed from the beginning of the queue and processed during each
        /// vertical blanking period in which the queue is non-empty.
        /// This is the only value of presentMode that is required to be
        /// supported.</summary>
        FifoKHR = 2,
        /// <summary>VK_PRESENT_MODE_FIFO_RELAXED_KHR specifies that the presentation
        /// engine generally waits for the next vertical blanking period to update
        /// the current image.
        /// If a vertical blanking period has already passed since the last update
        /// of the current image then the presentation engine does not wait for
        /// another vertical blanking period for the update, meaning this mode may
        /// result in visible tearing in this case.
        /// This mode is useful for reducing visual stutter with an application that
        /// will mostly present a new image before the next vertical blanking
        /// period, but may occasionally be late, and present a new image just after
        /// the next vertical blanking period.
        /// An internal queue is used to hold pending presentation requests.
        /// New requests are appended to the end of the queue, and one request is
        /// removed from the beginning of the queue and processed during or after
        /// each vertical blanking period in which the queue is non-empty.</summary>
        FifoRelaxedKHR = 3,
        /// <summary>VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR specifies that the
        /// presentation engine and application have concurrent access to a single
        /// image, which is referred to as a shared presentable image.
        /// The presentation engine is only required to update the current image
        /// after a new presentation request is received.
        /// Therefore the application must make a presentation request whenever an
        /// update is required.
        /// However, the presentation engine may update the current image at any
        /// point, meaning this mode may result in visible tearing.</summary>
        SharedDemandRefreshKHR = 1000111000,
        /// <summary>VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR specifies that the
        /// presentation engine and application have concurrent access to a single
        /// image, which is referred to as a shared presentable image.
        /// The presentation engine periodically updates the current image on its
        /// regular refresh cycle.
        /// The application is only required to make one initial presentation
        /// request, after which the presentation engine must update the current
        /// image without any need for further presentation requests.
        /// The application can indicate the image contents have been updated by
        /// making a presentation request, but this does not guarantee the timing of
        /// when it will be updated.
        /// This mode may result in visible tearing if rendering to the image is
        /// not timed correctly.</summary>
        SharedContinuousRefreshKHR = 1000111001,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 98
    /// <summary>VkPrimitiveTopology - Supported primitive topologies</summary>
    public enum VkPrimitiveTopology {
        /// <summary>VK_PRIMITIVE_TOPOLOGY_POINT_LIST specifies a series of
        /// separate point primitives.</summary>
        PointList = 0,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_LIST specifies a series of
        /// separate line primitives.</summary>
        LineList = 1,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_STRIP specifies a series of
        /// connected line primitives with consecutive lines
        /// sharing a vertex.</summary>
        LineStrip = 2,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST specifies a series of
        /// separate triangle primitives.</summary>
        TriangleList = 3,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP specifies a series of
        /// connected triangle primitives with
        /// consecutive triangles sharing an edge.</summary>
        TriangleStrip = 4,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN specifies a series of
        /// connected triangle primitives with all
        /// triangles sharing a common vertex.</summary>
        TriangleFan = 5,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY specifies a series
        /// separate line primitives with
        /// adjacency.</summary>
        LineListWithAdjacency = 6,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY specifies a series
        /// connected line primitives with
        /// adjacency, with consecutive primitives sharing three vertices.</summary>
        LineStripWithAdjacency = 7,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY specifies a
        /// series separate triangle primitives
        /// with adjacency.</summary>
        TriangleListWithAdjacency = 8,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY specifies
        /// connected triangle primitives with
        /// adjacency, with consecutive triangles sharing an edge.</summary>
        TriangleStripWithAdjacency = 9,
        /// <summary>VK_PRIMITIVE_TOPOLOGY_PATCH_LIST specifies
        /// separate patch primitives.</summary>
        PatchList = 10,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 99
    /// <summary>VkQueryControlFlagBits - Bitmask specifying constraints on a query</summary>
    [Flags]
    public enum VkQueryControlFlagBits {
        /// <summary>VK_QUERY_CONTROL_PRECISE_BIT specifies the precision of
        /// occlusion queries.</summary>
        Precise = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 100
    /// <summary>VkQueryPipelineStatisticFlagBits - Bitmask specifying queried pipeline statistics</summary>
    [Flags]
    public enum VkQueryPipelineStatisticFlagBits {
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT specifies
        /// that queries managed by the pool will count the number of vertices
        /// processed by the input assembly stage.
        /// Vertices corresponding to incomplete primitives may contribute to the
        /// count.</summary>
        InputAssemblyVertices = 0x00000001,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT
        /// specifies that queries managed by the pool will count the number of
        /// primitives processed by the input assembly stage.
        /// If primitive restart is enabled, restarting the primitive topology has
        /// no effect on the count.
        /// Incomplete primitives may be counted.</summary>
        InputAssemblyPrimitives = 0x00000002,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT
        /// specifies that queries managed by the pool will count the number of
        /// vertex shader invocations.
        /// This counter¡¯s value is incremented each time a vertex shader is
        /// invoked.</summary>
        VertexShaderInvocations = 0x00000004,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT
        /// specifies that queries managed by the pool will count the number of
        /// geometry shader invocations.
        /// This counter¡¯s value is incremented each time a geometry shader is
        /// invoked.
        /// In the case of instanced geometry shaders, the
        /// geometry shader invocations count is incremented for each separate
        /// instanced invocation.</summary>
        GeometryShaderInvocations = 0x00000008,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT
        /// specifies that queries managed by the pool will count the number of
        /// primitives generated by geometry shader invocations.
        /// The counter¡¯s value is incremented each time the geometry shader emits a
        /// primitive.
        /// Restarting primitive topology using the SPIR-V instructions
        /// OpEndPrimitive or OpEndStreamPrimitive has no effect on the
        /// geometry shader output primitives count.</summary>
        GeometryShaderPrimitives = 0x00000010,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT specifies
        /// that queries managed by the pool will count the number of primitives
        /// processed by the Primitive Clipping stage of
        /// the pipeline.
        /// The counter¡¯s value is incremented each time a primitive reaches the
        /// primitive clipping stage.</summary>
        ClippingInvocations = 0x00000020,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT specifies that
        /// queries managed by the pool will count the number of primitives output
        /// by the Primitive Clipping stage of the
        /// pipeline.
        /// The counter¡¯s value is incremented each time a primitive passes the
        /// primitive clipping stage.
        /// The actual number of primitives output by the primitive clipping stage
        /// for a particular input primitive is implementation-dependent but must
        /// satisfy the following conditions:</summary>
        ClippingPrimitives = 0x00000040,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT
        /// specifies that queries managed by the pool will count the number of
        /// fragment shader invocations.
        /// The counter¡¯s value is incremented each time the fragment shader is
        /// invoked.</summary>
        FragmentShaderInvocations = 0x00000080,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT
        /// specifies that queries managed by the pool will count the number of
        /// patches processed by the tessellation control shader.
        /// The counter¡¯s value is incremented once for each patch for which a
        /// tessellation control shader is
        /// invoked.</summary>
        TessellationControlShaderPatches = 0x00000100,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT
        /// specifies that queries managed by the pool will count the number of
        /// invocations of the tessellation evaluation shader.
        /// The counter¡¯s value is incremented each time the tessellation evaluation
        /// shader is invoked.</summary>
        TessellationEvaluationShaderInvocations = 0x00000200,
        /// <summary>VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT
        /// specifies that queries managed by the pool will count the number of
        /// compute shader invocations.
        /// The counter¡¯s value is incremented every time the compute shader is
        /// invoked.
        /// Implementations may skip the execution of certain compute shader
        /// invocations or execute additional compute shader invocations for
        /// implementation-dependent reasons as long as the results of rendering
        /// otherwise remain unchanged.</summary>
        ComputeShaderInvocations = 0x00000400,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 101
    /// <summary>VkQueryResultFlagBits - Bitmask specifying how and when query results are returned</summary>
    [Flags]
    public enum VkQueryResultFlagBits {
        /// <summary>VK_QUERY_RESULT_64_BIT specifies the results will be written as an
        /// array of 64-bit unsigned integer values.
        /// If this bit is not set, the results will be written as an array of
        /// 32-bit unsigned integer values.</summary>
        _64 = 0x00000001,
        /// <summary>VK_QUERY_RESULT_WAIT_BIT specifies that Vulkan will wait for each
        /// query¡¯s status to become available before retrieving its results.</summary>
        Wait = 0x00000002,
        /// <summary>VK_QUERY_RESULT_WITH_AVAILABILITY_BIT specifies that the
        /// availability status accompanies the results.</summary>
        WithAvailability = 0x00000004,
        /// <summary>VK_QUERY_RESULT_PARTIAL_BIT specifies that returning partial
        /// results is acceptable.</summary>
        Partial = 0x00000008,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 102
    /// <summary>VkQueryType - Specify the type of queries managed by a query pool</summary>
    public enum VkQueryType {
        /// <summary>VK_QUERY_TYPE_OCCLUSION specifies an occlusion query.</summary>
        Occlusion = 0,
        /// <summary>VK_QUERY_TYPE_PIPELINE_STATISTICS specifies a pipeline statistics query.</summary>
        PipelineStatistics = 1,
        /// <summary>VK_QUERY_TYPE_TIMESTAMP specifies a timestamp query.</summary>
        Timestamp = 2,
        /// <summary>VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT specifies a
        /// transform feedback query.</summary>
        TransformFeedbackStreamExt = 1000028004,
        AccelerationStructureCompactedSizeNv = 1000165000,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 103
    /// <summary>VkQueueFlagBits - Bitmask specifying capabilities of queues in a queue family</summary>
    [Flags]
    public enum VkQueueFlagBits {
        /// <summary>VK_QUEUE_GRAPHICS_BIT specifies that queues in this queue family
        /// support graphics operations.</summary>
        Graphics = 0x00000001,
        /// <summary>VK_QUEUE_COMPUTE_BIT specifies that queues in this queue family
        /// support compute operations.</summary>
        Compute = 0x00000002,
        /// <summary>VK_QUEUE_TRANSFER_BIT specifies that queues in this queue family
        /// support transfer operations.</summary>
        Transfer = 0x00000004,
        /// <summary>VK_QUEUE_SPARSE_BINDING_BIT specifies that queues in this queue
        /// family support sparse memory management operations (see
        /// Sparse Resources).
        /// If any of the sparse resource features are enabled, then at least one
        /// queue family must support this bit.</summary>
        SparseBinding = 0x00000008,
        /// <summary>if VK_QUEUE_PROTECTED_BIT is set, then the queues in this queue
        /// family support the VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT bit.
        /// (see Protected Memory).
        /// If the protected memory physical device feature is supported, then at
        /// least one queue family of at least one physical device exposed by the
        /// implementation must support this bit.</summary>
        Protected = 0x00000010,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 104
    /// <summary>VkQueueGlobalPriorityEXT - Values specifying a system-wide queue priority</summary>
    public enum VkQueueGlobalPriorityEXT {
        /// <summary>VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT is below the system default.
        /// Useful for non-interactive tasks.</summary>
        LowExt = 128,
        /// <summary>VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT is the system default
        /// priority.</summary>
        MediumExt = 256,
        /// <summary>VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT is above the system default.</summary>
        HighExt = 512,
        /// <summary>VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT is the highest priority.
        /// Useful for critical tasks.</summary>
        RealtimeExt = 1024,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 105
    /// <summary>VkRasterizationOrderAMD - Specify rasterization order for a graphics pipeline</summary>
    public enum VkRasterizationOrderAMD {
        /// <summary>VK_RASTERIZATION_ORDER_STRICT_AMD specifies that operations for
        /// each primitive in a subpass must occur in primitive order.</summary>
        StrictAmd = 0,
        /// <summary>VK_RASTERIZATION_ORDER_RELAXED_AMD specifies that operations for
        /// each primitive in a subpass may not occur in primitive order.</summary>
        RelaxedAmd = 1,
        MaxEnumAmd = 0x7FFFFFFF,
    }
    // Enum: 106
    /// <summary>VkRayTracingShaderGroupTypeNV - Shader group types</summary>
    public enum VkRayTracingShaderGroupTypeNV {
        /// <summary>VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV indicates a shader
        /// group with a single VK_SHADER_STAGE_RAYGEN_BIT_NV,
        /// VK_SHADER_STAGE_MISS_BIT_NV, or
        /// VK_SHADER_STAGE_CALLABLE_BIT_NV shader in it.</summary>
        GeneralNv = 0,
        /// <summary>VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV specifies
        /// a shader group that only hits triangles and must not contain an
        /// intersection shader, only closest hit and any-hit.</summary>
        TrianglesHitGroupNv = 1,
        /// <summary>VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV specifies
        /// a shader group that only intersects with custom geometry and must
        /// contain an intersection shader and may contain closest hit and any-hit
        /// shaders.</summary>
        ProceduralHitGroupNv = 2,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 107
    /// <summary>VkResolveModeFlagBitsKHR - Bitmask indicating supported depth and stencil resolve modes</summary>
    [Flags]
    public enum VkResolveModeFlagBitsKHR {
        /// <summary>VK_RESOLVE_MODE_NONE_KHR indicates that no resolve operation is
        /// done.</summary>
        NoneKHR = 0,
        /// <summary>VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR indicates that result of the
        /// resolve operation is equal to the value of sample 0.</summary>
        SampleZeroKHR = 0x00000001,
        /// <summary>VK_RESOLVE_MODE_AVERAGE_BIT_KHR indicates that result of the
        /// resolve operation is the average of the sample values.</summary>
        AverageKHR = 0x00000002,
        /// <summary>VK_RESOLVE_MODE_MIN_BIT_KHR indicates that result of the resolve
        /// operation is the minimum of the sample values.</summary>
        MinKHR = 0x00000004,
        /// <summary>VK_RESOLVE_MODE_MAX_BIT_KHR indicates that result of the resolve
        /// operation is the maximum of the sample values.</summary>
        MaxKHR = 0x00000008,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 108
    /// <summary>VkResult - Vulkan command return codes</summary>
    public enum VkResult {
        /// <summary>VK_SUCCESS Command successfully completed</summary>
        Success = 0,
        /// <summary>VK_NOT_READY A fence or query has not yet completed</summary>
        NotReady = 1,
        /// <summary>VK_TIMEOUT A wait operation has not completed in the specified
        /// time</summary>
        Timeout = 2,
        /// <summary>VK_EVENT_SET An event is signaled</summary>
        EventSet = 3,
        /// <summary>VK_EVENT_RESET An event is unsignaled</summary>
        EventReset = 4,
        /// <summary>VK_INCOMPLETE A return array was too small for the result</summary>
        Incomplete = 5,
        /// <summary>VK_ERROR_OUT_OF_HOST_MEMORY A host memory allocation has failed.</summary>
        ErrorOutOfHostMemory = -1,
        /// <summary>VK_ERROR_OUT_OF_DEVICE_MEMORY A device memory allocation has
        /// failed.</summary>
        ErrorOutOfDeviceMemory = -2,
        /// <summary>VK_ERROR_INITIALIZATION_FAILED Initialization of an object could
        /// not be completed for implementation-specific reasons.</summary>
        ErrorInitializationFailed = -3,
        /// <summary>VK_ERROR_DEVICE_LOST The logical or physical device has been lost.
        /// See Lost Device</summary>
        ErrorDeviceLost = -4,
        /// <summary>VK_ERROR_MEMORY_MAP_FAILED Mapping of a memory object has failed.</summary>
        ErrorMemoryMapFailed = -5,
        /// <summary>VK_ERROR_LAYER_NOT_PRESENT A requested layer is not present or
        /// could not be loaded.</summary>
        ErrorLayerNotPresent = -6,
        /// <summary>VK_ERROR_EXTENSION_NOT_PRESENT A requested extension is not
        /// supported.</summary>
        ErrorExtensionNotPresent = -7,
        /// <summary>VK_ERROR_FEATURE_NOT_PRESENT A requested feature is not supported.</summary>
        ErrorFeatureNotPresent = -8,
        /// <summary>VK_ERROR_INCOMPATIBLE_DRIVER The requested version of Vulkan is
        /// not supported by the driver or is otherwise incompatible for
        /// implementation-specific reasons.</summary>
        ErrorIncompatibleDriver = -9,
        /// <summary>VK_ERROR_TOO_MANY_OBJECTS Too many objects of the type have
        /// already been created.</summary>
        ErrorTooManyObjects = -10,
        /// <summary>VK_ERROR_FORMAT_NOT_SUPPORTED A requested format is not supported
        /// on this device.</summary>
        ErrorFormatNotSupported = -11,
        /// <summary>VK_ERROR_FRAGMENTED_POOL A pool allocation has failed due to
        /// fragmentation of the pool¡¯s memory.
        /// This must only be returned if no attempt to allocate host or device
        /// memory was made to accommodate the new allocation.
        /// This should be returned in preference to
        /// VK_ERROR_OUT_OF_POOL_MEMORY, but only if the implementation is
        /// certain that the pool allocation failure was due to fragmentation.</summary>
        ErrorFragmentedPool = -12,
        /// <summary>VK_ERROR_OUT_OF_POOL_MEMORY A pool memory allocation has failed.
        /// This must only be returned if no attempt to allocate host or device
        /// memory was made to accommodate the new allocation.
        /// If the failure was definitely due to fragmentation of the pool,
        /// VK_ERROR_FRAGMENTED_POOLshould be returned instead.</summary>
        ErrorOutOfPoolMemory = -1000069000,
        /// <summary>VK_ERROR_INVALID_EXTERNAL_HANDLE An external handle is not a valid
        /// handle of the specified type.</summary>
        ErrorInvalidExternalHandle = -1000072003,
        /// <summary>VK_ERROR_SURFACE_LOST_KHR A surface is no longer available.</summary>
        ErrorSurfaceLostKHR = -1000000000,
        /// <summary>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR The requested window is already
        /// in use by Vulkan or another API in a manner which prevents it from being
        /// used again.</summary>
        ErrorNativeWindowInUseKHR = -1000000001,
        /// <summary>VK_SUBOPTIMAL_KHR A swapchain no longer matches the surface
        /// properties exactly, but can still be used to present to the surface
        /// successfully.</summary>
        SuboptimalKHR = 1000001003,
        /// <summary>VK_ERROR_OUT_OF_DATE_KHR A surface has changed in such a way that
        /// it is no longer compatible with the swapchain, and further presentation
        /// requests using the swapchain will fail.
        /// Applications must query the new surface properties and recreate their
        /// swapchain if they wish to continue presenting to the surface.</summary>
        ErrorOutOfDateKHR = -1000001004,
        /// <summary>VK_ERROR_INCOMPATIBLE_DISPLAY_KHR The display used by a swapchain
        /// does not use the same presentable image layout, or is incompatible in a
        /// way that prevents sharing an image.</summary>
        ErrorIncompatibleDisplayKHR = -1000003001,
        ErrorValidationFailedExt = -1000011001,
        /// <summary>VK_ERROR_INVALID_SHADER_NV One or more shaders failed to compile
        /// or link.
        /// More details are reported back to the application via
        /// html/vkspec.html#VK_EXT_debug_report if enabled.</summary>
        ErrorInvalidShaderNv = -1000012000,
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
        /// <summary>VK_ERROR_FRAGMENTATION_EXT A descriptor pool creation has failed
        /// due to fragmentation.</summary>
        ErrorFragmentationExt = -1000161000,
        ErrorNotPermittedExt = -1000174001,
        /// <summary>VK_ERROR_INVALID_DEVICE_ADDRESS_EXT A buffer creation failed
        /// because the requested address is not available.</summary>
        ErrorInvalidDeviceAddressExt = -1000244000,
        /// <summary>VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT An operation on a
        /// swapchain created with
        /// VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT failed as it
        /// did not have exlusive full-screen access.
        /// This may occur due to implementation-dependent reasons, outside of the
        /// application¡¯s control.</summary>
        ErrorFullScreenExclusiveModeLostExt = -1000255000,
        ErrorOutOfPoolMemoryKHR = ErrorOutOfPoolMemory,
        ErrorInvalidExternalHandleKHR = ErrorInvalidExternalHandle,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 109
    /// <summary>VkSampleCountFlagBits - Bitmask specifying sample counts supported for an image used for storage operations</summary>
    [Flags]
    public enum VkSampleCountFlagBits {
        /// <summary>VK_SAMPLE_COUNT_1_BIT specifies an image with one sample per
        /// pixel.</summary>
        _1 = 0x00000001,
        /// <summary>VK_SAMPLE_COUNT_2_BIT specifies an image with 2 samples per pixel.</summary>
        _2 = 0x00000002,
        /// <summary>VK_SAMPLE_COUNT_4_BIT specifies an image with 4 samples per pixel.</summary>
        _4 = 0x00000004,
        /// <summary>VK_SAMPLE_COUNT_8_BIT specifies an image with 8 samples per pixel.</summary>
        _8 = 0x00000008,
        /// <summary>VK_SAMPLE_COUNT_16_BIT specifies an image with 16 samples per
        /// pixel.</summary>
        _16 = 0x00000010,
        /// <summary>VK_SAMPLE_COUNT_32_BIT specifies an image with 32 samples per
        /// pixel.</summary>
        _32 = 0x00000020,
        /// <summary>VK_SAMPLE_COUNT_64_BIT specifies an image with 64 samples per
        /// pixel.</summary>
        _64 = 0x00000040,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 110
    /// <summary>VkSamplerAddressMode - Specify behavior of sampling with texture coordinates outside an image</summary>
    public enum VkSamplerAddressMode {
        /// <summary>VK_SAMPLER_ADDRESS_MODE_REPEAT specifies that the repeat wrap mode
        /// will be used.</summary>
        Repeat = 0,
        /// <summary>VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT specifies that the
        /// mirrored repeat wrap mode will be used.</summary>
        MirroredRepeat = 1,
        /// <summary>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE specifies that the clamp to
        /// edge wrap mode will be used.</summary>
        ClampToEdge = 2,
        /// <summary>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER specifies that the clamp
        /// to border wrap mode will be used.</summary>
        ClampToBorder = 3,
        /// <summary>VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE specifies that the
        /// mirror clamp to edge wrap mode will be used.
        /// This is only valid if the html/vkspec.html#VK_KHR_sampler_mirror_clamp_to_edge
        /// extension is enabled.</summary>
        MirrorClampToEdge = 4,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 111
    /// <summary>VkSamplerCreateFlagBits - Bitmask specifying additional parameters of sampler</summary>
    [Flags]
    public enum VkSamplerCreateFlagBits {
        /// <summary>
        ///   VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT
        /// specifies that the sampler will read from an image created with
        /// flags containing VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT.</summary>
        SubsampledExt = 0x00000001,
        /// <summary>VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT
        /// specifies that the implementation may use approximations when
        /// reconstructing a full color value for texture access from a subsampled
        /// image.</summary>
        SubsampledCoarseReconstructionExt = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 112
    /// <summary>VkSamplerMipmapMode - Specify mipmap mode used for texture lookups</summary>
    public enum VkSamplerMipmapMode {
        /// <summary>VK_SAMPLER_MIPMAP_MODE_NEAREST specifies nearest filtering.</summary>
        Nearest = 0,
        /// <summary>VK_SAMPLER_MIPMAP_MODE_LINEAR specifies linear filtering.</summary>
        Linear = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 113
    /// <summary>VkSamplerReductionModeEXT - Specify reduction mode for texture filtering</summary>
    public enum VkSamplerReductionModeEXT {
        /// <summary>VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT specifies that
        /// texel values are combined by computing a weighted average of values in
        /// the footprint, using weights as specified in
        /// the image operations chapter.</summary>
        WeightedAverageExt = 0,
        /// <summary>VK_SAMPLER_REDUCTION_MODE_MIN_EXT specifies that texel values are
        /// combined by taking the component-wise minimum of values in the footprint
        /// with non-zero weights.</summary>
        MinExt = 1,
        /// <summary>VK_SAMPLER_REDUCTION_MODE_MAX_EXT specifies that texel values are
        /// combined by taking the component-wise maximum of values in the footprint
        /// with non-zero weights.</summary>
        MaxExt = 2,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 114
    /// <summary>VkSamplerYcbcrModelConversion - Color model component of a color space</summary>
    public enum VkSamplerYcbcrModelConversion {
        /// <summary>VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY specifies that the
        /// input values to the conversion are unmodified.</summary>
        RgbIdentity = 0,
        /// <summary>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY specifies no
        /// model conversion but the inputs are range expanded as for Y¡¯CBCR.</summary>
        YcbcrIdentity = 1,
        /// <summary>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 specifies the color
        /// model conversion from Y¡¯CBCR to R¡¯G¡¯B' defined in BT.709 and
        /// described in the ¡°BT.709 Y¡¯CBCR conversion¡± section of the
        /// Khronos Data Format Specification.</summary>
        Ycbcr709 = 2,
        /// <summary>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 specifies the color
        /// model conversion from Y¡¯CBCR to R¡¯G¡¯B' defined in BT.601 and
        /// described in the ¡°BT.601 Y¡¯CBCR conversion¡± section of the
        /// Khronos Data Format Specification.</summary>
        Ycbcr601 = 3,
        /// <summary>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 specifies the color
        /// model conversion from Y¡¯CBCR to R¡¯G¡¯B' defined in BT.2020 and
        /// described in the ¡°BT.2020 Y¡¯CBCR conversion¡± section of the
        /// Khronos Data Format Specification.</summary>
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
        /// <summary>VK_SAMPLER_YCBCR_RANGE_ITU_FULL specifies that the full range of
        /// the encoded values are valid and interpreted according to the ITU ¡°full
        /// range¡± quantization rules.</summary>
        ItuFull = 0,
        /// <summary>VK_SAMPLER_YCBCR_RANGE_ITU_NARROW specifies that headroom and foot
        /// room are reserved in the numerical range of encoded values, and the
        /// remaining values are expanded according to the ITU ¡°narrow range¡±
        /// quantization rules.</summary>
        ItuNarrow = 1,
        ItuFullKHR = ItuFull,
        ItuNarrowKHR = ItuNarrow,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 116
    /// <summary>VkScopeNV - Specify SPIR-V scope</summary>
    public enum VkScopeNV {
        /// <summary>VK_SCOPE_DEVICE_NV corresponds to SPIR-V Device scope.</summary>
        DeviceNv = 1,
        /// <summary>VK_SCOPE_WORKGROUP_NV corresponds to SPIR-V Workgroup scope.</summary>
        WorkgroupNv = 2,
        /// <summary>VK_SCOPE_SUBGROUP_NV corresponds to SPIR-V Subgroup scope.</summary>
        SubgroupNv = 3,
        /// <summary>VK_SCOPE_QUEUE_FAMILY_NV corresponds to SPIR-V QueueFamilyKHR
        /// scope.</summary>
        QueueFamilyNv = 5,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 117
    /// <summary>VkSemaphoreImportFlagBits - Bitmask specifying additional parameters of semaphore payload import</summary>
    [Flags]
    public enum VkSemaphoreImportFlagBits {
        /// <summary>VK_SEMAPHORE_IMPORT_TEMPORARY_BIT specifies that the semaphore
        /// payload will be imported only temporarily, as described in
        /// Importing Semaphore Payloads,
        /// regardless of the permanence of handleType.</summary>
        Temporary = 0x00000001,
        TemporaryKHR = Temporary,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 118
    /// <summary>VkShaderInfoTypeAMD - Enum specifying which type of shader info to query</summary>
    public enum VkShaderInfoTypeAMD {
        /// <summary>VK_SHADER_INFO_TYPE_STATISTICS_AMD specifies that device resources
        /// used by a shader will be queried.</summary>
        StatisticsAmd = 0,
        /// <summary>VK_SHADER_INFO_TYPE_BINARY_AMD specifies that
        /// implementation-specific information will be queried.</summary>
        BinaryAmd = 1,
        /// <summary>VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD specifies that human-readable
        /// dissassembly of a shader.</summary>
        DisassemblyAmd = 2,
        MaxEnumAmd = 0x7FFFFFFF,
    }
    // Enum: 119
    /// <summary>VkShaderStageFlagBits - Bitmask specifying a pipeline stage</summary>
    [Flags]
    public enum VkShaderStageFlagBits {
        /// <summary>VK_SHADER_STAGE_VERTEX_BIT specifies the vertex stage.</summary>
        Vertex = 0x00000001,
        /// <summary>VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT specifies the
        /// tessellation control stage.</summary>
        TessellationControl = 0x00000002,
        /// <summary>VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT specifies the
        /// tessellation evaluation stage.</summary>
        TessellationEvaluation = 0x00000004,
        /// <summary>VK_SHADER_STAGE_GEOMETRY_BIT specifies the geometry stage.</summary>
        Geometry = 0x00000008,
        /// <summary>VK_SHADER_STAGE_FRAGMENT_BIT specifies the fragment stage.</summary>
        Fragment = 0x00000010,
        /// <summary>VK_SHADER_STAGE_COMPUTE_BIT specifies the compute stage.</summary>
        Compute = 0x00000020,
        /// <summary>VK_SHADER_STAGE_ALL_GRAPHICS is a combination of bits used as
        /// shorthand to specify all graphics stages defined above (excluding the
        /// compute stage).</summary>
        AllGraphics = 0x0000001F,
        /// <summary>VK_SHADER_STAGE_ALL is a combination of bits used as shorthand to
        /// specify all shader stages supported by the device, including all
        /// additional stages which are introduced by extensions.</summary>
        All = 0x7FFFFFFF,
        /// <summary>VK_SHADER_STAGE_RAYGEN_BIT_NV specifies the ray generation stage.</summary>
        RaygenNv = 0x00000100,
        /// <summary>VK_SHADER_STAGE_ANY_HIT_BIT_NV specifies the any-hit stage.</summary>
        AnyHitNv = 0x00000200,
        /// <summary>VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV specifies the closest hit
        /// stage.</summary>
        ClosestHitNv = 0x00000400,
        /// <summary>VK_SHADER_STAGE_MISS_BIT_NV specifies the miss stage.</summary>
        MissNv = 0x00000800,
        /// <summary>VK_SHADER_STAGE_INTERSECTION_BIT_NV specifies the intersection
        /// stage.</summary>
        IntersectionNv = 0x00001000,
        /// <summary>VK_SHADER_STAGE_CALLABLE_BIT_NV specifies the callable stage.</summary>
        CallableNv = 0x00002000,
        /// <summary>VK_SHADER_STAGE_TASK_BIT_NV specifies the task stage.</summary>
        TaskNv = 0x00000040,
        /// <summary>VK_SHADER_STAGE_MESH_BIT_NV specifies the mesh stage.</summary>
        MeshNv = 0x00000080,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 120
    /// <summary>VkShadingRatePaletteEntryNV - Shading rate image palette entry types</summary>
    public enum VkShadingRatePaletteEntryNV {
        /// <summary>The following table indicates the width and height (in pixels) of each
        /// fragment generated using the indicated shading rate, as well as the maximum
        /// number of fragment shader invocations launched for each fragment.
        /// When processing regions of a primitive that have a shading rate of
        /// VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV, no fragments will be
        /// generated in that region.</summary>
        NoInvocationsNv = 0,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV</summary>
        _16InvocationsPerPixelNv = 1,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV</summary>
        _8InvocationsPerPixelNv = 2,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV</summary>
        _4InvocationsPerPixelNv = 3,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV</summary>
        _2InvocationsPerPixelNv = 4,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV</summary>
        _1InvocationPerPixelNv = 5,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV</summary>
        _1InvocationPer2x1PixelsNv = 6,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV</summary>
        _1InvocationPer1x2PixelsNv = 7,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV</summary>
        _1InvocationPer2x2PixelsNv = 8,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV</summary>
        _1InvocationPer4x2PixelsNv = 9,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV</summary>
        _1InvocationPer2x4PixelsNv = 10,
        /// <summary>class="tableblock"
        ///   VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV</summary>
        _1InvocationPer4x4PixelsNv = 11,
        MaxEnumNv = 0x7FFFFFFF,
    }
    // Enum: 121
    /// <summary>VkSharingMode - Buffer and image sharing modes</summary>
    public enum VkSharingMode {
        /// <summary>VK_SHARING_MODE_EXCLUSIVE specifies that access to any range or
        /// image subresource of the object will be exclusive to a single queue
        /// family at a time.</summary>
        Exclusive = 0,
        /// <summary>VK_SHARING_MODE_CONCURRENT specifies that concurrent access to any
        /// range or image subresource of the object from multiple queue families is
        /// supported.</summary>
        Concurrent = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 122
    /// <summary>VkSparseImageFormatFlagBits - Bitmask specifying additional information about a sparse image resource</summary>
    [Flags]
    public enum VkSparseImageFormatFlagBits {
        /// <summary>VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT specifies that the image
        /// uses a single mip tail region for all array layers.</summary>
        SingleMiptail = 0x00000001,
        /// <summary>VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT specifies that the
        /// first mip level whose dimensions are not integer multiples of the
        /// corresponding dimensions of the sparse image block begins the mip tail
        /// region.</summary>
        AlignedMipSize = 0x00000002,
        /// <summary>VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT specifies that
        /// the image uses non-standard sparse image block dimensions, and the
        /// imageGranularity values do not match the standard sparse image
        /// block dimensions for the given format.</summary>
        NonstandardBlockSize = 0x00000004,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 123
    /// <summary>VkSparseMemoryBindFlagBits - Bitmask specifying usage of a sparse memory binding operation</summary>
    [Flags]
    public enum VkSparseMemoryBindFlagBits {
        /// <summary>VK_SPARSE_MEMORY_BIND_METADATA_BIT specifies that the memory being
        /// bound is only for the metadata aspect.</summary>
        Metadata = 0x00000001,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 124
    /// <summary>VkStencilFaceFlagBits - Bitmask specifying sets of stencil state for which to update the compare mask</summary>
    [Flags]
    public enum VkStencilFaceFlagBits {
        /// <summary>VK_STENCIL_FACE_FRONT_BIT specifies that only the front set of
        /// stencil state is updated.</summary>
        Front = 0x00000001,
        /// <summary>VK_STENCIL_FACE_BACK_BIT specifies that only the back set of
        /// stencil state is updated.</summary>
        Back = 0x00000002,
        /// <summary>VK_STENCIL_FRONT_AND_BACK is the combination of
        /// VK_STENCIL_FACE_FRONT_BIT and VK_STENCIL_FACE_BACK_BIT, and
        /// specifies that both sets of stencil state are updated.</summary>
        FrontAndBack = 0x00000003,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 125
    /// <summary>VkStencilOp - Stencil comparison function</summary>
    public enum VkStencilOp {
        /// <summary>VK_STENCIL_OP_KEEP keeps the current value.</summary>
        Keep = 0,
        /// <summary>VK_STENCIL_OP_ZERO sets the value to 0.</summary>
        Zero = 1,
        /// <summary>VK_STENCIL_OP_REPLACE sets the value to reference.</summary>
        Replace = 2,
        /// <summary>VK_STENCIL_OP_INCREMENT_AND_CLAMP increments the current value and
        /// clamps to the maximum representable unsigned value.</summary>
        IncrementAndClamp = 3,
        /// <summary>VK_STENCIL_OP_DECREMENT_AND_CLAMP decrements the current value and
        /// clamps to 0.</summary>
        DecrementAndClamp = 4,
        /// <summary>VK_STENCIL_OP_INVERT bitwise-inverts the current value.</summary>
        Invert = 5,
        /// <summary>VK_STENCIL_OP_INCREMENT_AND_WRAP increments the current value and
        /// wraps to 0 when the maximum value would have been exceeded.</summary>
        IncrementAndWrap = 6,
        /// <summary>VK_STENCIL_OP_DECREMENT_AND_WRAP decrements the current value and
        /// wraps to the maximum possible value when the value would go below 0.</summary>
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
        /// <summary>The values VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO and
        /// VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO are reserved for internal
        /// use by the loader, and do not have corresponding Vulkan structures in this
        /// Specification.</summary>
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
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_BASIC_BIT
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// GroupNonUniform capability.</summary>
        Basic = 0x00000001,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_VOTE_BIT specifies
        /// the device will accept SPIR-V shader modules that contain the
        /// GroupNonUniformVote capability.</summary>
        Vote = 0x00000002,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_ARITHMETIC_BIT specifies the device will
        /// accept SPIR-V shader modules that contain the
        /// GroupNonUniformArithmetic capability.</summary>
        Arithmetic = 0x00000004,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_BALLOT_BIT
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// GroupNonUniformBallot capability.</summary>
        Ballot = 0x00000008,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_SHUFFLE_BIT
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// GroupNonUniformShuffle capability.</summary>
        Shuffle = 0x00000010,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT specifies the device will
        /// accept SPIR-V shader modules that contain the
        /// GroupNonUniformShuffleRelative capability.</summary>
        ShuffleRelative = 0x00000020,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_CLUSTERED_BIT
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// GroupNonUniformClustered capability.</summary>
        Clustered = 0x00000040,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_QUAD_BIT specifies
        /// the device will accept SPIR-V shader modules that contain the
        /// GroupNonUniformQuad capability.</summary>
        Quad = 0x00000080,
        /// <summary>
        ///   VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV specifies the device will
        /// accept SPIR-V shader modules that contain the
        /// GroupNonUniformPartitionedNV capability.</summary>
        PartitionedNv = 0x00000100,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 128
    /// <summary>VkSubpassContents - Specify how commands in the first subpass of a render pass are provided</summary>
    public enum VkSubpassContents {
        /// <summary>VK_SUBPASS_CONTENTS_INLINE specifies that the contents of the
        /// subpass will be recorded inline in the primary command buffer, and
        /// secondary command buffers must not be executed within the subpass.</summary>
        Inline = 0,
        /// <summary>VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS specifies that the
        /// contents are recorded in secondary command buffers that will be called
        /// from the primary command buffer, and vkCmdExecuteCommands is the
        /// only valid command on the command buffer until vkCmdNextSubpass or
        /// vkCmdEndRenderPass.</summary>
        SecondaryCommandBuffers = 1,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 129
    /// <summary>VkSubpassDescriptionFlagBits - Bitmask specifying usage of a subpass</summary>
    [Flags]
    public enum VkSubpassDescriptionFlagBits {
        /// <summary>VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX specifies that
        /// shaders compiled for this subpass write the attributes for all views in
        /// a single invocation of each vertex processing stage.
        /// All pipelines compiled against a subpass that includes this bit must
        /// write per-view attributes to the *PerViewNV[] shader outputs, in
        /// addition to the non-per-view (e.g. Position) outputs.</summary>
        PerViewAttributesNvx = 0x00000001,
        /// <summary>VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX specifies
        /// that shaders compiled for this subpass use per-view positions which only
        /// differ in value in the x component.
        /// Per-view viewport mask can also be used.</summary>
        PerViewPositionXOnlyNvx = 0x00000002,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 130
    /// <summary>VkSurfaceCounterFlagBitsEXT - Surface-relative counter types</summary>
    [Flags]
    public enum VkSurfaceCounterFlagBitsEXT {
        /// <summary>VK_SURFACE_COUNTER_VBLANK_EXT specifies a counter incrementing
        /// once every time a vertical blanking period occurs on the display
        /// associated with the surface.</summary>
        VblankExt = 0x00000001,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 131
    /// <summary>VkSurfaceTransformFlagBitsKHR - presentation transforms supported on a device</summary>
    [Flags]
    public enum VkSurfaceTransformFlagBitsKHR {
        /// <summary>VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR specifies that image content
        /// is presented without being transformed.</summary>
        IdentityKHR = 0x00000001,
        /// <summary>VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR specifies that image
        /// content is rotated 90 degrees clockwise.</summary>
        Rotate90KHR = 0x00000002,
        /// <summary>VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR specifies that image
        /// content is rotated 180 degrees clockwise.</summary>
        Rotate180KHR = 0x00000004,
        /// <summary>VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR specifies that image
        /// content is rotated 270 degrees clockwise.</summary>
        Rotate270KHR = 0x00000008,
        /// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR specifies that
        /// image content is mirrored horizontally.</summary>
        HorizontalMirrorKHR = 0x00000010,
        /// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR specifies
        /// that image content is mirrored horizontally, then rotated 90 degrees
        /// clockwise.</summary>
        HorizontalMirrorRotate90KHR = 0x00000020,
        /// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR
        /// specifies that image content is mirrored horizontally, then rotated 180
        /// degrees clockwise.</summary>
        HorizontalMirrorRotate180KHR = 0x00000040,
        /// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR
        /// specifies that image content is mirrored horizontally, then rotated 270
        /// degrees clockwise.</summary>
        HorizontalMirrorRotate270KHR = 0x00000080,
        /// <summary>VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR specifies that the
        /// presentation transform is not specified, and is instead determined by
        /// platform-specific considerations and mechanisms outside Vulkan.</summary>
        InheritKHR = 0x00000100,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 132
    /// <summary>VkSwapchainCreateFlagBitsKHR - Bitmask controlling swapchain creation</summary>
    [Flags]
    public enum VkSwapchainCreateFlagBitsKHR {
        /// <summary>VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR specifies
        /// that images created from the swapchain (i.e. with the swapchain
        /// member of VkImageSwapchainCreateInfoKHR set to this swapchain¡¯s
        /// handle) must use VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT.</summary>
        SplitInstanceBindRegionsKHR = 0x00000001,
        /// <summary>VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR specifies that images
        /// created from the swapchain are protected images.</summary>
        ProtectedKHR = 0x00000002,
        /// <summary>VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR specifies that the
        /// images of the swapchain can be used to create a VkImageView with
        /// a different format than what the swapchain was created with.
        /// The list of allowed image view formats are specified by chaining an
        /// instance of the VkImageFormatListCreateInfoKHR structure to the
        /// pNext chain of VkSwapchainCreateInfoKHR.
        /// In addition, this flag also specifies that the swapchain can be created
        /// with usage flags that are not supported for the format the swapchain is
        /// created with but are supported for at least one of the allowed image
        /// view formats.</summary>
        MutableFormatKHR = 0x00000004,
        MaxEnumKHR = 0x7FFFFFFF,
    }
    // Enum: 133
    /// <summary>VkSystemAllocationScope - Allocation scope</summary>
    public enum VkSystemAllocationScope {
        /// <summary>VK_SYSTEM_ALLOCATION_SCOPE_COMMAND specifies that the allocation
        /// is scoped to the duration of the Vulkan command.</summary>
        Command = 0,
        /// <summary>VK_SYSTEM_ALLOCATION_SCOPE_OBJECT specifies that the allocation is
        /// scoped to the lifetime of the Vulkan object that is being created or
        /// used.</summary>
        Object = 1,
        /// <summary>VK_SYSTEM_ALLOCATION_SCOPE_CACHE specifies that the allocation is
        /// scoped to the lifetime of a VkPipelineCache
        /// or VkValidationCacheEXT
        /// object.</summary>
        Cache = 2,
        /// <summary>VK_SYSTEM_ALLOCATION_SCOPE_DEVICE specifies that the allocation is
        /// scoped to the lifetime of the Vulkan device.</summary>
        Device = 3,
        /// <summary>VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE specifies that the allocation
        /// is scoped to the lifetime of the Vulkan instance.</summary>
        Instance = 4,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 134
    /// <summary>VkTessellationDomainOrigin - Enum describing tessellation domain origin</summary>
    public enum VkTessellationDomainOrigin {
        /// <summary>VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT specifies that the origin
        /// of the domain space is in the upper left corner, as shown in figure
        /// html/vkspec.html#img-tessellation-topology-ul.</summary>
        UpperLeft = 0,
        /// <summary>VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT specifies that the origin
        /// of the domain space is in the lower left corner, as shown in figure
        /// html/vkspec.html#img-tessellation-topology-ll.</summary>
        LowerLeft = 1,
        UpperLeftKHR = UpperLeft,
        LowerLeftKHR = LowerLeft,
        MaxEnum = 0x7FFFFFFF,
    }
    // Enum: 135
    /// <summary>VkTimeDomainEXT - Supported time domains</summary>
    public enum VkTimeDomainEXT {
        /// <summary>VK_TIME_DOMAIN_DEVICE_EXT specifies the device time domain.
        /// Timestamp values in this time domain are comparable with device
        /// timestamp values captured using vkCmdWriteTimestamp and are
        /// defined to be incrementing according to the
        /// timestampPeriod of the device.</summary>
        DeviceExt = 0,
        /// <summary>VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT specifies the CLOCK_MONOTONIC
        /// time domain available on POSIX platforms.</summary>
        ClockMonotonicExt = 1,
        /// <summary>VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT specifies the
        /// CLOCK_MONOTONIC_RAW time domain available on POSIX platforms.</summary>
        ClockMonotonicRawExt = 2,
        /// <summary>VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT specifies the
        /// performance counter (QPC) time domain available on Windows.</summary>
        QueryPerformanceCounterExt = 3,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 136
    /// <summary>VkValidationCacheHeaderVersionEXT - Encode validation cache version</summary>
    public enum VkValidationCacheHeaderVersionEXT {
        /// <summary>VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT specifies version one
        /// of the validation cache.</summary>
        OneExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 137
    /// <summary>VkValidationCheckEXT - Specify validation checks to disable</summary>
    public enum VkValidationCheckEXT {
        /// <summary>VK_VALIDATION_CHECK_ALL_EXT specifies that all validation checks
        /// are disabled.</summary>
        AllExt = 0,
        /// <summary>VK_VALIDATION_CHECK_SHADERS_EXT specifies that shader validation
        /// is disabled.</summary>
        ShadersExt = 1,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 138
    /// <summary>VkValidationFeatureDisableEXT - Specify validation features to disable</summary>
    public enum VkValidationFeatureDisableEXT {
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_ALL_EXT specifies that all
        /// validation checks are disabled.</summary>
        AllExt = 0,
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT specifies that shader
        /// validation is disabled.
        /// This feature is enabled by default.</summary>
        ShadersExt = 1,
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT specifies that
        /// thread safety validation is disabled.
        /// This feature is enabled by default.</summary>
        ThreadSafetyExt = 2,
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT specifies that
        /// stateless parameter validation is disabled.
        /// This feature is enabled by default.</summary>
        ApiParametersExt = 3,
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT specifies that
        /// object lifetime validation is disabled.
        /// This feature is enabled by default.</summary>
        ObjectLifetimesExt = 4,
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT specifies that core
        /// validation checks are disabled.
        /// This feature is enabled by default.
        /// If this feature is disabled, the shader validation and GPU-assisted
        /// validation features are also disabled.</summary>
        CoreChecksExt = 5,
        /// <summary>VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT specifies that
        /// protection against duplicate non-dispatchable object handles is
        /// disabled.
        /// This feature is enabled by default.</summary>
        UniqueHandlesExt = 6,
        MaxEnumExt = 0x7FFFFFFF,
    }
    // Enum: 139
    /// <summary>VkValidationFeatureEnableEXT - Specify validation features to enable</summary>
    public enum VkValidationFeatureEnableEXT {
        /// <summary>VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT specifies that
        /// GPU-assisted validation is enabled.
        /// Activating this feature instruments shader programs to generate
        /// additional diagnostic data.
        /// This feature is disabled by default.</summary>
        GpuAssistedExt = 0,
        /// <summary>VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT
        /// specifies that the validation layers reserve a descriptor set binding
        /// slot for their own use.
        /// The layer reports a value for
        /// VkPhysicalDeviceLimits::maxBoundDescriptorSets that is one
        /// less than the value reported by the device.
        /// If the device supports the binding of only one descriptor set, the
        /// validation layer does not perform GPU-assisted validation.
        /// This feature is disabled by default.
        /// The GPU-assisted validation feature must be enabled in order to use this
        /// feature.</summary>
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
        /// <summary>VK_VERTEX_INPUT_RATE_VERTEX specifies that vertex attribute
        /// addressing is a function of the vertex index.</summary>
        Vertex = 0,
        /// <summary>VK_VERTEX_INPUT_RATE_INSTANCE specifies that vertex attribute
        /// addressing is a function of the instance index.</summary>
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
