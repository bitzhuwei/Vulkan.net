using System;

namespace ApiSpec.Generated {
    // Enum: 0
    /// <summary>VkAccelerationStructureMemoryRequirementsTypeNV - Acceleration structure memory requirement type</summary>
    public enum VkAccelerationStructureMemoryRequirementsTypeNV {
        /// <summary><code>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV</code>
        /// requests the memory requirement for the <code>VkAccelerationStructureNV</code>
        /// backing store.</summary>
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = 0,
        /// <summary><code>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV</code>
        /// requests the memory requirement for scratch space during the initial
        /// build.</summary>
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = 1,
        /// <summary><code>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV</code>
        /// requests the memory requirement for scratch space during an update.</summary>
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = 2,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 1
    /// <summary>VkAccelerationStructureTypeNV - Type of acceleration structure</summary>
    public enum VkAccelerationStructureTypeNV {
        /// <summary><code>VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV</code> is a top-level
        /// acceleration structure containing instance data referring to
        /// bottom-level level acceleration structures.</summary>
        VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV = 0,
        /// <summary><code>VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV</code> is a bottom-level
        /// acceleration structure containing the AABBs or geometry to be
        /// intersected.</summary>
        VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV = 1,
        VK_ACCELERATION_STRUCTURE_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 2
    /// <summary>VkAccessFlagBits - Bitmask specifying memory access types that will participate in a memory dependency</summary>
    public enum VkAccessFlagBits {
        /// <summary><code>VK_ACCESS_INDIRECT_COMMAND_READ_BIT</code> specifies read access to
        /// indirect command data read as part of an indirect drawing or dispatch
        /// command.</summary>
        VK_ACCESS_INDIRECT_COMMAND_READ_BIT = 0x00000001,
        /// <summary><code>VK_ACCESS_INDEX_READ_BIT</code> specifies read access to an index buffer
        /// as part of an indexed drawing command, bound by
        /// <a href="#vkCmdBindIndexBuffer">vkCmdBindIndexBuffer</a>.</summary>
        VK_ACCESS_INDEX_READ_BIT = 0x00000002,
        /// <summary><code>VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT</code> specifies read access to a
        /// vertex buffer as part of a drawing command, bound by
        /// <a href="#vkCmdBindVertexBuffers">vkCmdBindVertexBuffers</a>.</summary>
        VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT = 0x00000004,
        /// <summary><code>VK_ACCESS_UNIFORM_READ_BIT</code> specifies read access to a
        /// <a href="vkspec.html#descriptorsets-uniformbuffer">uniform buffer</a>.</summary>
        VK_ACCESS_UNIFORM_READ_BIT = 0x00000008,
        /// <summary><code>VK_ACCESS_INPUT_ATTACHMENT_READ_BIT</code> specifies read access to an
        /// <a href="vkspec.html#renderpass">input attachment</a> within a render pass during fragment
        /// shading.</summary>
        VK_ACCESS_INPUT_ATTACHMENT_READ_BIT = 0x00000010,
        /// <summary><code>VK_ACCESS_SHADER_READ_BIT</code> specifies read access to a
        /// <a href="vkspec.html#descriptorsets-storagebuffer">storage buffer</a>,
        /// <a href="vkspec.html#descriptorsets-physical-storage-buffer">physical storage buffer</a>,
        /// <a href="vkspec.html#descriptorsets-uniformtexelbuffer">uniform texel buffer</a>,
        /// <a href="vkspec.html#descriptorsets-storagetexelbuffer">storage texel buffer</a>,
        /// <a href="vkspec.html#descriptorsets-sampledimage">sampled image</a>, or
        /// <a href="vkspec.html#descriptorsets-storageimage">storage image</a>.</summary>
        VK_ACCESS_SHADER_READ_BIT = 0x00000020,
        /// <summary><code>VK_ACCESS_SHADER_WRITE_BIT</code> specifies write access to a
        /// <a href="vkspec.html#descriptorsets-storagebuffer">storage buffer</a>,
        /// <a href="vkspec.html#descriptorsets-physical-storage-buffer">physical storage buffer</a>,
        /// <a href="vkspec.html#descriptorsets-storagetexelbuffer">storage texel buffer</a>, or
        /// <a href="vkspec.html#descriptorsets-storageimage">storage image</a>.</summary>
        VK_ACCESS_SHADER_WRITE_BIT = 0x00000040,
        /// <summary><code>VK_ACCESS_COLOR_ATTACHMENT_READ_BIT</code> specifies read access to a
        /// <a href="vkspec.html#renderpass">color attachment</a>, such as via <a href="vkspec.html#framebuffer-blending">blending</a>, <a href="vkspec.html#framebuffer-logicop">logic operations</a>, or via certain
        /// <a href="vkspec.html#renderpass-load-store-ops">subpass load operations</a>.
        /// It does not include <a href="vkspec.html#framebuffer-blend-advanced">advanced blend
        /// operations</a>.</summary>
        VK_ACCESS_COLOR_ATTACHMENT_READ_BIT = 0x00000080,
        /// <summary><code>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</code> specifies write access to a
        /// <a href="#renderpass">color, resolve, or depth/stencil resolve attachment</a>
        /// during a <a href="vkspec.html#renderpass">render pass</a> or via certain
        /// <a href="vkspec.html#renderpass-load-store-ops">subpass load and store operations</a>.</summary>
        VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT = 0x00000100,
        /// <summary><code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT</code> specifies read access
        /// to a <a href="vkspec.html#renderpass">depth/stencil attachment</a>, via <a href="vkspec.html#fragops-ds-state">depth or stencil operations</a> or via certain
        /// <a href="vkspec.html#renderpass-load-store-ops">subpass load operations</a>.</summary>
        VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 0x00000200,
        /// <summary><code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</code> specifies write
        /// access to a <a href="vkspec.html#renderpass">depth/stencil attachment</a>, via
        /// <a href="vkspec.html#fragops-ds-state">depth or stencil operations</a> or via certain
        /// <a href="vkspec.html#renderpass-load-store-ops">subpass load and store operations</a>.</summary>
        VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 0x00000400,
        /// <summary><code>VK_ACCESS_TRANSFER_READ_BIT</code> specifies read access to an image or
        /// buffer in a <a href="vkspec.html#copies">copy</a> operation.</summary>
        VK_ACCESS_TRANSFER_READ_BIT = 0x00000800,
        /// <summary><code>VK_ACCESS_TRANSFER_WRITE_BIT</code> specifies write access to an image or
        /// buffer in a <a href="vkspec.html#clears">clear</a> or <a href="vkspec.html#copies">copy</a> operation.</summary>
        VK_ACCESS_TRANSFER_WRITE_BIT = 0x00001000,
        /// <summary><code>VK_ACCESS_HOST_READ_BIT</code> specifies read access by a host operation.
        /// Accesses of this type are not performed through a resource, but directly
        /// on memory.</summary>
        VK_ACCESS_HOST_READ_BIT = 0x00002000,
        /// <summary><code>VK_ACCESS_HOST_WRITE_BIT</code> specifies write access by a host
        /// operation.
        /// Accesses of this type are not performed through a resource, but directly
        /// on memory.</summary>
        VK_ACCESS_HOST_WRITE_BIT = 0x00004000,
        /// <summary><code>VK_ACCESS_MEMORY_READ_BIT</code> specifies read access via non-specific
        /// entities.
        /// These entities include the Vulkan device and host, but <strong class="purple">may</strong> also include
        /// entities external to the Vulkan device or otherwise not part of the core
        /// Vulkan pipeline.
        /// When included in a destination access mask, makes all available writes
        /// visible to all future read accesses on entities known to the Vulkan
        /// device.</summary>
        VK_ACCESS_MEMORY_READ_BIT = 0x00008000,
        /// <summary><code>VK_ACCESS_MEMORY_WRITE_BIT</code> specifies write access via non-specific
        /// entities.
        /// These entities include the Vulkan device and host, but <strong class="purple">may</strong> also include
        /// entities external to the Vulkan device or otherwise not part of the core
        /// Vulkan pipeline.
        /// When included in a source access mask, all writes that are performed by
        /// entities known to the Vulkan device are made available.
        /// When included in a destination access mask, makes all available writes
        /// visible to all future write accesses on entities known to the Vulkan
        /// device.</summary>
        VK_ACCESS_MEMORY_WRITE_BIT = 0x00010000,
        /// <summary><code>VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT</code> specifies write access
        /// to a transform feedback buffer made when transform feedback is active.</summary>
        VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 0x02000000,
        /// <summary><code>VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT</code> specifies read
        /// access to a transform feedback counter buffer which is read when
        /// <code>vkCmdBeginTransformFeedbackEXT</code> executes.</summary>
        VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 0x04000000,
        /// <summary><code>VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT</code> specifies write
        /// access to a transform feedback counter buffer which is written when
        /// <code>vkCmdEndTransformFeedbackEXT</code> executes.</summary>
        VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 0x08000000,
        /// <summary><code>VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT</code> specifies read access
        /// to a predicate as part of conditional rendering.</summary>
        VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT = 0x00100000,
        /// <summary><code>VK_ACCESS_COMMAND_PROCESS_READ_BIT_NVX</code> specifies reads from
        /// <code>VkBuffer</code> inputs to <a href="#vkCmdProcessCommandsNVX">vkCmdProcessCommandsNVX</a>.</summary>
        VK_ACCESS_COMMAND_PROCESS_READ_BIT_NVX = 0x00020000,
        /// <summary><code>VK_ACCESS_COMMAND_PROCESS_WRITE_BIT_NVX</code> specifies writes to the
        /// target command buffer in <a href="#vkCmdProcessCommandsNVX">vkCmdProcessCommandsNVX</a>.</summary>
        VK_ACCESS_COMMAND_PROCESS_WRITE_BIT_NVX = 0x00040000,
        /// <summary><code>VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT</code> is similar to
        /// <code>VK_ACCESS_COLOR_ATTACHMENT_READ_BIT</code>, but also includes
        /// <a href="vkspec.html#framebuffer-blend-advanced">advanced blend operations</a>.</summary>
        VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 0x00080000,
        /// <summary><code>VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV</code> specifies read access to
        /// a shading rate image as part of a drawing command, as bound by
        /// <a href="#vkCmdBindShadingRateImageNV">vkCmdBindShadingRateImageNV</a>.</summary>
        VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV = 0x00800000,
        /// <summary><code>VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV</code> specifies read access
        /// to an acceleration structure as part of a trace or build command.</summary>
        VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV = 0x00200000,
        /// <summary><code>VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV</code> specifies write
        /// access to an acceleration structure as part of a build command.</summary>
        VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV = 0x00400000,
        /// <summary><code>VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT</code> specifies read access
        /// to a <a href="vkspec.html#renderpass-fragmentdensitymapattachment">fragment density map
        /// attachment</a> during dynamic <a href="vkspec.html#fragmentdensitymapops">fragment density
        /// map operations</a></summary>
        VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 0x01000000,
        VK_ACCESS_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 3
    /// <summary>VkAttachmentDescriptionFlagBits - Bitmask specifying additional properties of an attachment</summary>
    public enum VkAttachmentDescriptionFlagBits {
        /// <summary><code>VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT</code> specifies that the
        /// attachment aliases the same device memory as other attachments.</summary>
        VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = 0x00000001,
        VK_ATTACHMENT_DESCRIPTION_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 4
    /// <summary>VkAttachmentLoadOp - Specify how contents of an attachment are treated at the beginning of a subpass</summary>
    public enum VkAttachmentLoadOp {
        /// <summary><code>VK_ATTACHMENT_LOAD_OP_LOAD</code> specifies that the previous contents of
        /// the image within the render area will be preserved.
        /// For attachments with a depth/stencil format, this uses the access type
        /// <code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT</code>.
        /// For attachments with a color format, this uses the access type
        /// <code>VK_ACCESS_COLOR_ATTACHMENT_READ_BIT</code>.</summary>
        VK_ATTACHMENT_LOAD_OP_LOAD = 0,
        /// <summary><code>VK_ATTACHMENT_LOAD_OP_CLEAR</code> specifies that the contents within the
        /// render area will be cleared to a uniform value, which is specified when
        /// a render pass instance is begun.
        /// For attachments with a depth/stencil format, this uses the access type
        /// <code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</code>.
        /// For attachments with a color format, this uses the access type
        /// <code>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</code>.</summary>
        VK_ATTACHMENT_LOAD_OP_CLEAR = 1,
        /// <summary><code>VK_ATTACHMENT_LOAD_OP_DONT_CARE</code> specifies that the previous
        /// contents within the area need not be preserved; the contents of the
        /// attachment will be undefined inside the render area.
        /// For attachments with a depth/stencil format, this uses the access type
        /// <code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</code>.
        /// For attachments with a color format, this uses the access type
        /// <code>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</code>.</summary>
        VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,
        VK_ATTACHMENT_LOAD_OP_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 5
    /// <summary>VkAttachmentStoreOp - Specify how contents of an attachment are treated at the end of a subpass</summary>
    public enum VkAttachmentStoreOp {
        /// <summary><code>VK_ATTACHMENT_STORE_OP_STORE</code> specifies the contents generated
        /// during the render pass and within the render area are written to memory.
        /// For attachments with a depth/stencil format, this uses the access type
        /// <code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</code>.
        /// For attachments with a color format, this uses the access type
        /// <code>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</code>.</summary>
        VK_ATTACHMENT_STORE_OP_STORE = 0,
        /// <summary><code>VK_ATTACHMENT_STORE_OP_DONT_CARE</code> specifies the contents within the
        /// render area are not needed after rendering, and <strong class="purple">may</strong> be discarded; the
        /// contents of the attachment will be undefined inside the render area.
        /// For attachments with a depth/stencil format, this uses the access type
        /// <code>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</code>.
        /// For attachments with a color format, this uses the access type
        /// <code>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</code>.</summary>
        VK_ATTACHMENT_STORE_OP_DONT_CARE = 1,
        VK_ATTACHMENT_STORE_OP_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 6
    /// <summary>VkBlendFactor - Framebuffer blending factors</summary>
    public enum VkBlendFactor {
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ZERO</code></summary>
        VK_BLEND_FACTOR_ZERO = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE</code></summary>
        VK_BLEND_FACTOR_ONE = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_SRC_COLOR</code></summary>
        VK_BLEND_FACTOR_SRC_COLOR = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_DST_COLOR</code></summary>
        VK_BLEND_FACTOR_DST_COLOR = 4,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR = 5,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_SRC_ALPHA</code></summary>
        VK_BLEND_FACTOR_SRC_ALPHA = 6,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA = 7,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_DST_ALPHA</code></summary>
        VK_BLEND_FACTOR_DST_ALPHA = 8,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA = 9,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_CONSTANT_COLOR</code></summary>
        VK_BLEND_FACTOR_CONSTANT_COLOR = 10,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR = 11,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_CONSTANT_ALPHA</code></summary>
        VK_BLEND_FACTOR_CONSTANT_ALPHA = 12,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA = 13,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_SRC_ALPHA_SATURATE</code></summary>
        VK_BLEND_FACTOR_SRC_ALPHA_SATURATE = 14,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_SRC1_COLOR</code></summary>
        VK_BLEND_FACTOR_SRC1_COLOR = 15,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR = 16,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_SRC1_ALPHA</code></summary>
        VK_BLEND_FACTOR_SRC1_ALPHA = 17,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA</code></summary>
        VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA = 18,
        VK_BLEND_FACTOR_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 7
    /// <summary>VkBlendOp - Framebuffer blending operations</summary>
    public enum VkBlendOp {
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_OP_ADD</code></summary>
        VK_BLEND_OP_ADD = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_OP_SUBTRACT</code></summary>
        VK_BLEND_OP_SUBTRACT = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_OP_REVERSE_SUBTRACT</code></summary>
        VK_BLEND_OP_REVERSE_SUBTRACT = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_OP_MIN</code></summary>
        VK_BLEND_OP_MIN = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_BLEND_OP_MAX</code></summary>
        VK_BLEND_OP_MAX = 4,
        VK_BLEND_OP_ZERO_EXT = 1000148000,
        VK_BLEND_OP_SRC_EXT = 1000148001,
        VK_BLEND_OP_DST_EXT = 1000148002,
        VK_BLEND_OP_SRC_OVER_EXT = 1000148003,
        VK_BLEND_OP_DST_OVER_EXT = 1000148004,
        VK_BLEND_OP_SRC_IN_EXT = 1000148005,
        VK_BLEND_OP_DST_IN_EXT = 1000148006,
        VK_BLEND_OP_SRC_OUT_EXT = 1000148007,
        VK_BLEND_OP_DST_OUT_EXT = 1000148008,
        VK_BLEND_OP_SRC_ATOP_EXT = 1000148009,
        VK_BLEND_OP_DST_ATOP_EXT = 1000148010,
        VK_BLEND_OP_XOR_EXT = 1000148011,
        VK_BLEND_OP_MULTIPLY_EXT = 1000148012,
        VK_BLEND_OP_SCREEN_EXT = 1000148013,
        VK_BLEND_OP_OVERLAY_EXT = 1000148014,
        VK_BLEND_OP_DARKEN_EXT = 1000148015,
        VK_BLEND_OP_LIGHTEN_EXT = 1000148016,
        VK_BLEND_OP_COLORDODGE_EXT = 1000148017,
        VK_BLEND_OP_COLORBURN_EXT = 1000148018,
        VK_BLEND_OP_HARDLIGHT_EXT = 1000148019,
        VK_BLEND_OP_SOFTLIGHT_EXT = 1000148020,
        VK_BLEND_OP_DIFFERENCE_EXT = 1000148021,
        VK_BLEND_OP_EXCLUSION_EXT = 1000148022,
        VK_BLEND_OP_INVERT_EXT = 1000148023,
        VK_BLEND_OP_INVERT_RGB_EXT = 1000148024,
        VK_BLEND_OP_LINEARDODGE_EXT = 1000148025,
        VK_BLEND_OP_LINEARBURN_EXT = 1000148026,
        VK_BLEND_OP_VIVIDLIGHT_EXT = 1000148027,
        VK_BLEND_OP_LINEARLIGHT_EXT = 1000148028,
        VK_BLEND_OP_PINLIGHT_EXT = 1000148029,
        VK_BLEND_OP_HARDMIX_EXT = 1000148030,
        VK_BLEND_OP_HSL_HUE_EXT = 1000148031,
        VK_BLEND_OP_HSL_SATURATION_EXT = 1000148032,
        VK_BLEND_OP_HSL_COLOR_EXT = 1000148033,
        VK_BLEND_OP_HSL_LUMINOSITY_EXT = 1000148034,
        VK_BLEND_OP_PLUS_EXT = 1000148035,
        VK_BLEND_OP_PLUS_CLAMPED_EXT = 1000148036,
        VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT = 1000148037,
        VK_BLEND_OP_PLUS_DARKER_EXT = 1000148038,
        VK_BLEND_OP_MINUS_EXT = 1000148039,
        VK_BLEND_OP_MINUS_CLAMPED_EXT = 1000148040,
        VK_BLEND_OP_CONTRAST_EXT = 1000148041,
        VK_BLEND_OP_INVERT_OVG_EXT = 1000148042,
        VK_BLEND_OP_RED_EXT = 1000148043,
        VK_BLEND_OP_GREEN_EXT = 1000148044,
        VK_BLEND_OP_BLUE_EXT = 1000148045,
        VK_BLEND_OP_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 8
    /// <summary>VkBlendOverlapEXT - Enumerant specifying the blend overlap parameter</summary>
    public enum VkBlendOverlapEXT {
        /// <summary><code>VK_BLEND_OVERLAP_UNCORRELATED_EXT</code> specifies that there is no
        /// correlation between the source and destination coverage.</summary>
        VK_BLEND_OVERLAP_UNCORRELATED_EXT = 0,
        /// <summary><code>VK_BLEND_OVERLAP_DISJOINT_EXT</code> specifies that the source and
        /// destination coverage are considered to have minimal overlap.</summary>
        VK_BLEND_OVERLAP_DISJOINT_EXT = 1,
        /// <summary><code>VK_BLEND_OVERLAP_CONJOINT_EXT</code> specifies that the source and
        /// destination coverage are considered to have maximal overlap.</summary>
        VK_BLEND_OVERLAP_CONJOINT_EXT = 2,
        VK_BLEND_OVERLAP_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 9
    /// <summary>VkBorderColor - Specify border color used for texture lookups</summary>
    public enum VkBorderColor {
        /// <summary><code>VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK</code> specifies a transparent,
        /// floating-point format, black color.</summary>
        VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = 0,
        /// <summary><code>VK_BORDER_COLOR_INT_TRANSPARENT_BLACK</code> specifies a transparent,
        /// integer format, black color.</summary>
        VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = 1,
        /// <summary><code>VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK</code> specifies an opaque,
        /// floating-point format, black color.</summary>
        VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = 2,
        /// <summary><code>VK_BORDER_COLOR_INT_OPAQUE_BLACK</code> specifies an opaque, integer
        /// format, black color.</summary>
        VK_BORDER_COLOR_INT_OPAQUE_BLACK = 3,
        /// <summary><code>VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE</code> specifies an opaque,
        /// floating-point format, white color.</summary>
        VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = 4,
        /// <summary><code>VK_BORDER_COLOR_INT_OPAQUE_WHITE</code> specifies an opaque, integer
        /// format, white color.</summary>
        VK_BORDER_COLOR_INT_OPAQUE_WHITE = 5,
        VK_BORDER_COLOR_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 10
    /// <summary>VkBufferCreateFlagBits - Bitmask specifying additional parameters of a buffer</summary>
    public enum VkBufferCreateFlagBits {
        /// <summary><code>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</code> specifies that the buffer will
        /// be backed using sparse memory binding.</summary>
        VK_BUFFER_CREATE_SPARSE_BINDING_BIT = 0x00000001,
        /// <summary><code>VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT</code> specifies that the buffer
        /// <strong class="purple">can</strong> be partially backed using sparse memory binding.
        /// Buffers created with this flag <strong class="purple">must</strong> also be created with the
        /// <code>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</code> flag.</summary>
        VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 0x00000002,
        /// <summary><code>VK_BUFFER_CREATE_SPARSE_ALIASED_BIT</code> specifies that the buffer will
        /// be backed using sparse memory binding with memory ranges that might also
        /// simultaneously be backing another buffer (or another portion of the same
        /// buffer).
        /// Buffers created with this flag <strong class="purple">must</strong> also be created with the
        /// <code>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</code> flag.</summary>
        VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 0x00000004,
        /// <summary><code>VK_BUFFER_CREATE_PROTECTED_BIT</code> specifies that the buffer is a
        /// protected buffer.</summary>
        VK_BUFFER_CREATE_PROTECTED_BIT = 0x00000008,
        /// <summary><code>VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT</code> specifies
        /// that the buffer’s address <strong class="purple">can</strong> be saved and reused on a subsequent run
        /// (e.g. for trace capture and replay), see
        /// <a href="#VkBufferDeviceAddressCreateInfoEXT">VkBufferDeviceAddressCreateInfoEXT</a> for more detail.</summary>
        VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = 0x00000010,
        VK_BUFFER_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 11
    /// <summary>VkBufferUsageFlagBits - Bitmask specifying allowed usage of a buffer</summary>
    public enum VkBufferUsageFlagBits {
        /// <summary><code>VK_BUFFER_USAGE_TRANSFER_SRC_BIT</code> specifies that the buffer <strong class="purple">can</strong> be
        /// used as the source of a <em>transfer command</em> (see the definition of
        /// <a href="vkspec.html#synchronization-pipeline-stages-transfer"><code>VK_PIPELINE_STAGE_TRANSFER_BIT</code></a>).</summary>
        VK_BUFFER_USAGE_TRANSFER_SRC_BIT = 0x00000001,
        /// <summary><code>VK_BUFFER_USAGE_TRANSFER_DST_BIT</code> specifies that the buffer <strong class="purple">can</strong> be
        /// used as the destination of a transfer command.</summary>
        VK_BUFFER_USAGE_TRANSFER_DST_BIT = 0x00000002,
        /// <summary><code>VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT</code> specifies that the buffer
        /// <strong class="purple">can</strong> be used to create a <code>VkBufferView</code> suitable for occupying a
        /// <code>VkDescriptorSet</code> slot of type
        /// <code>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</code>.</summary>
        VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = 0x00000004,
        /// <summary><code>VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT</code> specifies that the buffer
        /// <strong class="purple">can</strong> be used to create a <code>VkBufferView</code> suitable for occupying a
        /// <code>VkDescriptorSet</code> slot of type
        /// <code>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</code>.</summary>
        VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = 0x00000008,
        /// <summary><code>VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT</code> specifies that the buffer <strong class="purple">can</strong>
        /// be used in a <code>VkDescriptorBufferInfo</code> suitable for occupying a
        /// <code>VkDescriptorSet</code> slot either of type
        /// <code>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER</code> or
        /// <code>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC</code>.</summary>
        VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = 0x00000010,
        /// <summary><code>VK_BUFFER_USAGE_STORAGE_BUFFER_BIT</code> specifies that the buffer <strong class="purple">can</strong>
        /// be used in a <code>VkDescriptorBufferInfo</code> suitable for occupying a
        /// <code>VkDescriptorSet</code> slot either of type
        /// <code>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER</code> or
        /// <code>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC</code>.</summary>
        VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = 0x00000020,
        /// <summary><code>VK_BUFFER_USAGE_INDEX_BUFFER_BIT</code> specifies that the buffer is
        /// suitable for passing as the <code>buffer</code> parameter to
        /// <code>vkCmdBindIndexBuffer</code>.</summary>
        VK_BUFFER_USAGE_INDEX_BUFFER_BIT = 0x00000040,
        /// <summary><code>VK_BUFFER_USAGE_VERTEX_BUFFER_BIT</code> specifies that the buffer is
        /// suitable for passing as an element of the <code>pBuffers</code> array to
        /// <code>vkCmdBindVertexBuffers</code>.</summary>
        VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = 0x00000080,
        /// <summary><code>VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT</code> specifies that the buffer is
        /// suitable for passing as the <code>buffer</code> parameter to
        /// <code>vkCmdDrawIndirect</code>, <code>vkCmdDrawIndexedIndirect</code>,
        /// <code>vkCmdDrawMeshTasksIndirectNV</code>,
        /// <code>vkCmdDrawMeshTasksIndirectCountNV</code>,
        /// or <code>vkCmdDispatchIndirect</code>.
        /// It is also suitable for passing as the <code>buffer</code> member of
        /// <code>VkIndirectCommandsTokenNVX</code>, or <code>sequencesCountBuffer</code> or
        /// <code>sequencesIndexBuffer</code> member of <code>VkCmdProcessCommandsInfoNVX</code></summary>
        VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = 0x00000100,
        /// <summary><code>VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT</code> specifies that
        /// the buffer is suitable for using for binding as a transform feedback
        /// buffer with <a href="#vkCmdBindTransformFeedbackBuffersEXT">vkCmdBindTransformFeedbackBuffersEXT</a>.</summary>
        VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = 0x00000800,
        /// <summary><code>VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT</code>
        /// specifies that the buffer is suitable for using as a counter buffer with
        /// <a href="#vkCmdBeginTransformFeedbackEXT">vkCmdBeginTransformFeedbackEXT</a> and
        /// <a href="#vkCmdEndTransformFeedbackEXT">vkCmdEndTransformFeedbackEXT</a>.</summary>
        VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = 0x00001000,
        /// <summary><code>VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT</code> specifies that the
        /// buffer is suitable for passing as the <code>buffer</code> parameter to
        /// <a href="#vkCmdBeginConditionalRenderingEXT">vkCmdBeginConditionalRenderingEXT</a>.</summary>
        VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT = 0x00000200,
        /// <summary><code>VK_BUFFER_USAGE_RAY_TRACING_BIT_NV</code> specifies that the buffer is
        /// suitable for use in <a href="#vkCmdTraceRaysNV">vkCmdTraceRaysNV</a> and
        /// <a href="#vkCmdBuildAccelerationStructureNV">vkCmdBuildAccelerationStructureNV</a>.</summary>
        VK_BUFFER_USAGE_RAY_TRACING_BIT_NV = 0x00000400,
        /// <summary><code>VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT</code> specifies that the
        /// buffer <strong class="purple">can</strong> be used to retrieve a buffer device address via
        /// <a href="#vkGetBufferDeviceAddressEXT">vkGetBufferDeviceAddressEXT</a> and use that address to access the
        /// buffer’s memory from a shader.</summary>
        VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT = 0x00020000,
        VK_BUFFER_USAGE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 12
    /// <summary>VkBuildAccelerationStructureFlagBitsNV - Bitmask specifying additional parameters for acceleration structure builds</summary>
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsNV {
        /// <summary><code>VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV</code> indicates that
        /// the specified acceleration structure <strong class="purple">can</strong> be updated with <code>update</code>
        /// of <code>VK_TRUE</code> in <a href="#vkCmdBuildAccelerationStructureNV">vkCmdBuildAccelerationStructureNV</a>.</summary>
        VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV = 0x00000001,
        /// <summary><code>VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV</code> indicates
        /// that the specified acceleration structure <strong class="purple">can</strong> act as the source for
        /// <a href="#vkCmdCopyAccelerationStructureNV">vkCmdCopyAccelerationStructureNV</a> with <code>mode</code> of
        /// <code>VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV</code> to produce a
        /// compacted acceleration structure.</summary>
        VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV = 0x00000002,
        /// <summary><code>VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV</code> indicates
        /// that the given acceleration structure build <strong class="purple">should</strong> prioritize trace
        /// performance over build time.</summary>
        VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV = 0x00000004,
        /// <summary><code>VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV</code> indicates
        /// that the given acceleration structure build <strong class="purple">should</strong> prioritize build
        /// time over trace performance.</summary>
        VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV = 0x00000008,
        /// <summary><code>VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV</code> indicates that
        /// this acceleration structure <strong class="purple">should</strong> minimize the size of the scratch
        /// memory and the final result build, potentially at the expense of build
        /// time or trace performance.</summary>
        VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV = 0x00000010,
        VK_BUILD_ACCELERATION_STRUCTURE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 13
    /// <summary>VkChromaLocation - Position of downsampled chroma samples</summary>
    public enum VkChromaLocation {
        /// <summary><code>VK_CHROMA_LOCATION_COSITED_EVEN</code> specifies that downsampled chroma
        /// samples are aligned with luma samples with even coordinates.</summary>
        VK_CHROMA_LOCATION_COSITED_EVEN = 0,
        /// <summary><code>VK_CHROMA_LOCATION_MIDPOINT</code> specifies that downsampled chroma
        /// samples are located half way between each even luma sample and the
        /// nearest higher odd luma sample.</summary>
        VK_CHROMA_LOCATION_MIDPOINT = 1,
        VK_CHROMA_LOCATION_COSITED_EVEN_KHR = VK_CHROMA_LOCATION_COSITED_EVEN,
        VK_CHROMA_LOCATION_MIDPOINT_KHR = VK_CHROMA_LOCATION_MIDPOINT,
        VK_CHROMA_LOCATION_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 14
    /// <summary>VkCoarseSampleOrderTypeNV - Shading rate image sample ordering types</summary>
    public enum VkCoarseSampleOrderTypeNV {
        /// <summary><code>VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV</code> specifies that coverage
        /// samples will be ordered in an implementation-dependent manner.</summary>
        VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = 0,
        /// <summary><code>VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV</code> specifies that coverage
        /// samples will be ordered according to the array of custom orderings
        /// provided in either the <code>pCustomSampleOrders</code> member of
        /// <code>VkPipelineViewportCoarseSampleOrderStateCreateInfoNV</code> or the
        /// <code>pCustomSampleOrders</code> member of <a href="#vkCmdSetCoarseSampleOrderNV">vkCmdSetCoarseSampleOrderNV</a>.</summary>
        VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = 1,
        /// <summary><code>VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV</code> specifies that coverage
        /// samples will be ordered sequentially, sorted first by pixel coordinate
        /// (in row-major order) and then by coverage sample number.</summary>
        VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = 2,
        /// <summary><code>VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV</code> specifies that
        /// coverage samples will be ordered sequentially, sorted first by coverage
        /// sample number and then by pixel coordinate (in row-major order).</summary>
        VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = 3,
        VK_COARSE_SAMPLE_ORDER_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 15
    /// <summary>VkColorComponentFlagBits - Bitmask controlling which components are written to the framebuffer</summary>
    public enum VkColorComponentFlagBits {
        /// <summary><code>VK_COLOR_COMPONENT_R_BIT</code> specifies that the <span class="eq">R</span> value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        VK_COLOR_COMPONENT_R_BIT = 0x00000001,
        /// <summary><code>VK_COLOR_COMPONENT_G_BIT</code> specifies that the <span class="eq">G</span> value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        VK_COLOR_COMPONENT_G_BIT = 0x00000002,
        /// <summary><code>VK_COLOR_COMPONENT_B_BIT</code> specifies that the <span class="eq">B</span> value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        VK_COLOR_COMPONENT_B_BIT = 0x00000004,
        /// <summary><code>VK_COLOR_COMPONENT_A_BIT</code> specifies that the <span class="eq">A</span> value is
        /// written to the color attachment for the appropriate sample.
        /// Otherwise, the value in memory is unmodified.</summary>
        VK_COLOR_COMPONENT_A_BIT = 0x00000008,
        VK_COLOR_COMPONENT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 16
    /// <summary>VkColorSpaceKHR - supported color space of the presentation engine</summary>
    public enum VkColorSpaceKHR {
        /// <summary><code>VK_COLOR_SPACE_SRGB_NONLINEAR_KHR</code> specifies support for the sRGB
        /// color space.</summary>
        VK_COLOR_SPACE_SRGB_NONLINEAR_KHR = 0,
        /// <summary><code>VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT</code> specifies support for the
        /// Display-P3 color space and applies an sRGB-like transfer function
        /// (defined below).</summary>
        VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT = 1000104001,
        /// <summary><code>VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT</code> specifies support for the
        /// extended sRGB color space and applies a linear transfer function.</summary>
        VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT = 1000104002,
        /// <summary><code>VK_COLOR_SPACE_DCI_P3_LINEAR_EXT</code> specifies support for the DCI-P3
        /// color space and applies a linear OETF.</summary>
        VK_COLOR_SPACE_DCI_P3_LINEAR_EXT = 1000104003,
        /// <summary><code>VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT</code> specifies support for the
        /// DCI-P3 color space and applies the Gamma 2.6 OETF.</summary>
        VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT = 1000104004,
        /// <summary><code>VK_COLOR_SPACE_BT709_LINEAR_EXT</code> specifies support for the BT709
        /// color space and applies a linear OETF.</summary>
        VK_COLOR_SPACE_BT709_LINEAR_EXT = 1000104005,
        /// <summary><code>VK_COLOR_SPACE_BT709_NONLINEAR_EXT</code> specifies support for the BT709
        /// color space and applies the SMPTE 170M OETF.</summary>
        VK_COLOR_SPACE_BT709_NONLINEAR_EXT = 1000104006,
        /// <summary><code>VK_COLOR_SPACE_BT2020_LINEAR_EXT</code> specifies support for the BT2020
        /// color space and applies a linear OETF.</summary>
        VK_COLOR_SPACE_BT2020_LINEAR_EXT = 1000104007,
        /// <summary><code>VK_COLOR_SPACE_HDR10_ST2084_EXT</code> specifies support for the HDR10
        /// (BT2020 color) space and applies the SMPTE ST2084 Perceptual Quantizer
        /// (PQ) OETF.</summary>
        VK_COLOR_SPACE_HDR10_ST2084_EXT = 1000104008,
        /// <summary><code>VK_COLOR_SPACE_DOLBYVISION_EXT</code> specifies support for the Dolby
        /// Vision (BT2020 color space), proprietary encoding, and applies the SMPTE
        /// ST2084 OETF.</summary>
        VK_COLOR_SPACE_DOLBYVISION_EXT = 1000104009,
        /// <summary><code>VK_COLOR_SPACE_HDR10_HLG_EXT</code> specifies support for the HDR10
        /// (BT2020 color space) and applies the Hybrid Log Gamma (HLG) OETF.</summary>
        VK_COLOR_SPACE_HDR10_HLG_EXT = 1000104010,
        /// <summary><code>VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT</code> specifies support for the
        /// AdobeRGB color space and applies a linear OETF.</summary>
        VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT = 1000104011,
        /// <summary><code>VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT</code> specifies support for the
        /// AdobeRGB color space and applies the Gamma 2.2 OETF.</summary>
        VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT = 1000104012,
        /// <summary><code>VK_COLOR_SPACE_PASS_THROUGH_EXT</code> specifies that color components
        /// are used “as is”.
        /// This is intended to allow applications to supply data for color spaces
        /// not described here.</summary>
        VK_COLOR_SPACE_PASS_THROUGH_EXT = 1000104013,
        /// <summary><code>VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT</code> specifies support for
        /// the extended sRGB color space and applies an sRGB transfer function.</summary>
        VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT = 1000104014,
        /// <summary><code>VK_COLOR_SPACE_DISPLAY_NATIVE_AMD</code> specifies support for the
        /// display’s native color space.
        /// This matches the color space expectations of AMD’s FreeSync2 standard,
        /// for displays supporting it.</summary>
        VK_COLOR_SPACE_DISPLAY_NATIVE_AMD = 1000213000,
        VK_COLORSPACE_SRGB_NONLINEAR_KHR = VK_COLOR_SPACE_SRGB_NONLINEAR_KHR,
        VK_COLOR_SPACE_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 17
    /// <summary>VkCommandBufferLevel - Enumerant specifying a command buffer level</summary>
    public enum VkCommandBufferLevel {
        /// <summary><code>VK_COMMAND_BUFFER_LEVEL_PRIMARY</code> specifies a primary command
        /// buffer.</summary>
        VK_COMMAND_BUFFER_LEVEL_PRIMARY = 0,
        /// <summary><code>VK_COMMAND_BUFFER_LEVEL_SECONDARY</code> specifies a secondary command
        /// buffer.</summary>
        VK_COMMAND_BUFFER_LEVEL_SECONDARY = 1,
        VK_COMMAND_BUFFER_LEVEL_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 18
    /// <summary>VkCommandBufferResetFlagBits - Bitmask controlling behavior of a command buffer reset</summary>
    public enum VkCommandBufferResetFlagBits {
        /// <summary><code>VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT</code> specifies that most
        /// or all memory resources currently owned by the command buffer <strong class="purple">should</strong> be
        /// returned to the parent command pool.
        /// If this flag is not set, then the command buffer <strong class="purple">may</strong> hold onto memory
        /// resources and reuse them when recording commands.
        /// <code>commandBuffer</code> is moved to the <a href="vkspec.html#commandbuffers-lifecycle">initial
        /// state</a>.</summary>
        VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = 0x00000001,
        VK_COMMAND_BUFFER_RESET_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 19
    /// <summary>VkCommandBufferUsageFlagBits - Bitmask specifying usage behavior for command buffer</summary>
    public enum VkCommandBufferUsageFlagBits {
        /// <summary><code>VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT</code> specifies that each
        /// recording of the command buffer will only be submitted once, and the
        /// command buffer will be reset and recorded again between each submission.</summary>
        VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = 0x00000001,
        /// <summary><code>VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT</code> specifies that a
        /// secondary command buffer is considered to be entirely inside a render
        /// pass.
        /// If this is a primary command buffer, then this bit is ignored.</summary>
        VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = 0x00000002,
        /// <summary><code>VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT</code> specifies that a
        /// command buffer <strong class="purple">can</strong> be resubmitted to a queue while it is in the
        /// <em>pending state</em>, and recorded into multiple primary command buffers.</summary>
        VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = 0x00000004,
        VK_COMMAND_BUFFER_USAGE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 20
    /// <summary>VkCommandPoolCreateFlagBits - Bitmask specifying usage behavior for a command pool</summary>
    public enum VkCommandPoolCreateFlagBits {
        /// <summary><code>VK_COMMAND_POOL_CREATE_TRANSIENT_BIT</code> specifies that command
        /// buffers allocated from the pool will be short-lived, meaning that they
        /// will be reset or freed in a relatively short timeframe.
        /// This flag <strong class="purple">may</strong> be used by the implementation to control memory
        /// allocation behavior within the pool.</summary>
        VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = 0x00000001,
        /// <summary><code>VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT</code> allows any command
        /// buffer allocated from a pool to be individually reset to the
        /// <a href="vkspec.html#commandbuffers-lifecycle">initial state</a>; either by calling
        /// <a href="#vkResetCommandBuffer">vkResetCommandBuffer</a>, or via the implicit reset when calling
        /// <a href="#vkBeginCommandBuffer">vkBeginCommandBuffer</a>.
        /// If this flag is not set on a pool, then <code>vkResetCommandBuffer</code><strong class="purple">must</strong>
        /// not be called for any command buffer allocated from that pool.</summary>
        VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 0x00000002,
        /// <summary><code>VK_COMMAND_POOL_CREATE_PROTECTED_BIT</code> specifies that command
        /// buffers allocated from the pool are protected command buffers.
        /// If the protected memory feature is not enabled, the
        /// <code>VK_COMMAND_POOL_CREATE_PROTECTED_BIT</code> bit of <code>flags</code><strong class="purple">must</strong> not
        /// be set.</summary>
        VK_COMMAND_POOL_CREATE_PROTECTED_BIT = 0x00000004,
        VK_COMMAND_POOL_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 21
    /// <summary>VkCommandPoolResetFlagBits - Bitmask controlling behavior of a command pool reset</summary>
    public enum VkCommandPoolResetFlagBits {
        /// <summary><code>VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT</code> specifies that
        /// resetting a command pool recycles all of the resources from the command
        /// pool back to the system.</summary>
        VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT = 0x00000001,
        VK_COMMAND_POOL_RESET_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 22
    /// <summary>VkCompareOp - Stencil comparison function</summary>
    public enum VkCompareOp {
        /// <summary><code>VK_COMPARE_OP_NEVER</code> specifies that the test never passes.</summary>
        VK_COMPARE_OP_NEVER = 0,
        /// <summary><code>VK_COMPARE_OP_LESS</code> specifies that the test passes when <span class="eq">R &lt;
        /// S</span>.</summary>
        VK_COMPARE_OP_LESS = 1,
        /// <summary><code>VK_COMPARE_OP_EQUAL</code> specifies that the test passes when <span class="eq">R =
        /// S</span>.</summary>
        VK_COMPARE_OP_EQUAL = 2,
        /// <summary><code>VK_COMPARE_OP_LESS_OR_EQUAL</code> specifies that the test passes when
        /// <span class="eq">R ≤ S</span>.</summary>
        VK_COMPARE_OP_LESS_OR_EQUAL = 3,
        /// <summary><code>VK_COMPARE_OP_GREATER</code> specifies that the test passes when <span class="eq">R &gt;
        /// S</span>.</summary>
        VK_COMPARE_OP_GREATER = 4,
        /// <summary><code>VK_COMPARE_OP_NOT_EQUAL</code> specifies that the test passes when <span class="eq">R
        /// ≠ S</span>.</summary>
        VK_COMPARE_OP_NOT_EQUAL = 5,
        /// <summary><code>VK_COMPARE_OP_GREATER_OR_EQUAL</code> specifies that the test passes when
        /// <span class="eq">R ≥ S</span>.</summary>
        VK_COMPARE_OP_GREATER_OR_EQUAL = 6,
        /// <summary><code>VK_COMPARE_OP_ALWAYS</code> specifies that the test always passes.</summary>
        VK_COMPARE_OP_ALWAYS = 7,
        VK_COMPARE_OP_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 23
    /// <summary>VkComponentSwizzle - Specify how a component is swizzled</summary>
    public enum VkComponentSwizzle {
        /// <summary><code>VK_COMPONENT_SWIZZLE_IDENTITY</code> specifies that the component is set
        /// to the identity swizzle.</summary>
        VK_COMPONENT_SWIZZLE_IDENTITY = 0,
        /// <summary><code>VK_COMPONENT_SWIZZLE_ZERO</code> specifies that the component is set to
        /// zero.</summary>
        VK_COMPONENT_SWIZZLE_ZERO = 1,
        /// <summary><code>VK_COMPONENT_SWIZZLE_ONE</code> specifies that the component is set to
        /// either 1 or 1.0, depending on whether the type of the image view format
        /// is integer or floating-point respectively, as determined by the
        /// <a href="vkspec.html#formats-definition">Format Definition</a> section for each
        /// <a href="#VkFormat">VkFormat</a>.</summary>
        VK_COMPONENT_SWIZZLE_ONE = 2,
        /// <summary><code>VK_COMPONENT_SWIZZLE_R</code> specifies that the component is set to the
        /// value of the R component of the image.</summary>
        VK_COMPONENT_SWIZZLE_R = 3,
        /// <summary><code>VK_COMPONENT_SWIZZLE_G</code> specifies that the component is set to the
        /// value of the G component of the image.</summary>
        VK_COMPONENT_SWIZZLE_G = 4,
        /// <summary><code>VK_COMPONENT_SWIZZLE_B</code> specifies that the component is set to the
        /// value of the B component of the image.</summary>
        VK_COMPONENT_SWIZZLE_B = 5,
        /// <summary><code>VK_COMPONENT_SWIZZLE_A</code> specifies that the component is set to the
        /// value of the A component of the image.</summary>
        VK_COMPONENT_SWIZZLE_A = 6,
        VK_COMPONENT_SWIZZLE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 24
    /// <summary>VkComponentTypeNV - Specify SPIR-V cooperative matrix component type</summary>
    public enum VkComponentTypeNV {
        /// <summary><code>VK_COMPONENT_TYPE_FLOAT16_NV</code> corresponds to SPIR-V
        /// <code>OpTypeFloat</code> 16.</summary>
        VK_COMPONENT_TYPE_FLOAT16_NV = 0,
        /// <summary><code>VK_COMPONENT_TYPE_FLOAT32_NV</code> corresponds to SPIR-V
        /// <code>OpTypeFloat</code> 32.</summary>
        VK_COMPONENT_TYPE_FLOAT32_NV = 1,
        /// <summary><code>VK_COMPONENT_TYPE_FLOAT64_NV</code> corresponds to SPIR-V
        /// <code>OpTypeFloat</code> 64.</summary>
        VK_COMPONENT_TYPE_FLOAT64_NV = 2,
        /// <summary><code>VK_COMPONENT_TYPE_SINT8_NV</code> corresponds to SPIR-V <code>OpTypeInt</code> 8
        /// 1.</summary>
        VK_COMPONENT_TYPE_SINT8_NV = 3,
        /// <summary><code>VK_COMPONENT_TYPE_SINT16_NV</code> corresponds to SPIR-V <code>OpTypeInt</code>
        /// 16 1.</summary>
        VK_COMPONENT_TYPE_SINT16_NV = 4,
        /// <summary><code>VK_COMPONENT_TYPE_SINT32_NV</code> corresponds to SPIR-V <code>OpTypeInt</code>
        /// 32 1.</summary>
        VK_COMPONENT_TYPE_SINT32_NV = 5,
        /// <summary><code>VK_COMPONENT_TYPE_SINT64_NV</code> corresponds to SPIR-V <code>OpTypeInt</code>
        /// 64 1.</summary>
        VK_COMPONENT_TYPE_SINT64_NV = 6,
        /// <summary><code>VK_COMPONENT_TYPE_UINT8_NV</code> corresponds to SPIR-V <code>OpTypeInt</code> 8
        /// 0.</summary>
        VK_COMPONENT_TYPE_UINT8_NV = 7,
        /// <summary><code>VK_COMPONENT_TYPE_UINT16_NV</code> corresponds to SPIR-V <code>OpTypeInt</code>
        /// 16 0.</summary>
        VK_COMPONENT_TYPE_UINT16_NV = 8,
        /// <summary><code>VK_COMPONENT_TYPE_UINT32_NV</code> corresponds to SPIR-V <code>OpTypeInt</code>
        /// 32 0.</summary>
        VK_COMPONENT_TYPE_UINT32_NV = 9,
        /// <summary><code>VK_COMPONENT_TYPE_UINT64_NV</code> corresponds to SPIR-V <code>OpTypeInt</code>
        /// 64 0.</summary>
        VK_COMPONENT_TYPE_UINT64_NV = 10,
        VK_COMPONENT_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 25
    /// <summary>VkCompositeAlphaFlagBitsKHR - alpha compositing modes supported on a device</summary>
    public enum VkCompositeAlphaFlagBitsKHR {
        /// <summary><code>VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR</code>: The alpha channel, if it
        /// exists, of the images is ignored in the compositing process.
        /// Instead, the image is treated as if it has a constant alpha of 1.0.</summary>
        VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,
        /// <summary><code>VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR</code>: The alpha channel, if
        /// it exists, of the images is respected in the compositing process.
        /// The non-alpha channels of the image are expected to already be
        /// multiplied by the alpha channel by the application.</summary>
        VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = 0x00000002,
        /// <summary><code>VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR</code>: The alpha channel, if
        /// it exists, of the images is respected in the compositing process.
        /// The non-alpha channels of the image are not expected to already be
        /// multiplied by the alpha channel by the application; instead, the
        /// compositor will multiply the non-alpha channels of the image by the
        /// alpha channel during compositing.</summary>
        VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = 0x00000004,
        /// <summary><code>VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR</code>: The way in which the
        /// presentation engine treats the alpha channel in the images is unknown to
        /// the Vulkan API.
        /// Instead, the application is responsible for setting the composite alpha
        /// blending mode using native window system commands.
        /// If the application does not set the blending mode using native window
        /// system commands, then a platform-specific default will be used.</summary>
        VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = 0x00000008,
        VK_COMPOSITE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 26
    /// <summary>VkConditionalRenderingFlagBitsEXT - Specify the behavior of conditional rendering</summary>
    public enum VkConditionalRenderingFlagBitsEXT {
        /// <summary><code>VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT</code> specifies the condition
        /// used to determine whether to discard rendering commands or not.
        /// That is, if the 32-bit predicate read from <code>buffer</code> memory at
        /// <code>offset</code> is zero, the rendering commands are not discarded, and if
        /// non zero, then they are discarded.</summary>
        VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT = 0x00000001,
        VK_CONDITIONAL_RENDERING_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 27
    /// <summary>VkConservativeRasterizationModeEXT - Specify the conservative rasterization mode</summary>
    public enum VkConservativeRasterizationModeEXT {
        /// <summary><code>VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT</code> specifies that
        /// conservative rasterization is disabled and rasterization proceeds as
        /// normal.</summary>
        VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT = 0,
        /// <summary><code>VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT</code> specifies that
        /// conservative rasterization is enabled in overestimation mode.</summary>
        VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT = 1,
        /// <summary><code>VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT</code> specifies
        /// that conservative rasterization is enabled in underestimation mode.</summary>
        VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT = 2,
        VK_CONSERVATIVE_RASTERIZATION_MODE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 28
    /// <summary>VkCopyAccelerationStructureModeNV - Acceleration structure copy mode</summary>
    public enum VkCopyAccelerationStructureModeNV {
        /// <summary><code>VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV</code> creates a direct copy
        /// of the acceleration structure specified in <code>src</code> into the one
        /// specified by <code>dst</code>.
        /// The <code>dst</code> acceleration structure <strong class="purple">must</strong> have been created with the
        /// same parameters as <code>src</code>.</summary>
        VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV = 0,
        /// <summary><code>VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV</code> creates a more
        /// compact version of an acceleration structure <code>src</code> into <code>dst</code>.
        /// The acceleration structure <code>dst</code><strong class="purple">must</strong> have been created with a
        /// <code>compactedSize</code> corresponding to the one returned by
        /// <a href="#vkCmdWriteAccelerationStructuresPropertiesNV">vkCmdWriteAccelerationStructuresPropertiesNV</a> after the build of
        /// the acceleration structure specified by <code>src</code>.</summary>
        VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV = 1,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 29
    /// <summary>VkCoverageModulationModeNV - Specify the discard rectangle mode</summary>
    public enum VkCoverageModulationModeNV {
        /// <summary><code>VK_COVERAGE_MODULATION_MODE_NONE_NV</code> specifies that no components
        /// are multiplied by the modulation factor.</summary>
        VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,
        /// <summary><code>VK_COVERAGE_MODULATION_MODE_RGB_NV</code> specifies that the red, green,
        /// and blue components are multiplied by the modulation factor.</summary>
        VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,
        /// <summary><code>VK_COVERAGE_MODULATION_MODE_ALPHA_NV</code> specifies that the alpha
        /// component is multiplied by the modulation factor.</summary>
        VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,
        /// <summary><code>VK_COVERAGE_MODULATION_MODE_RGBA_NV</code> specifies that all components
        /// are multiplied by the modulation factor.</summary>
        VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3,
        VK_COVERAGE_MODULATION_MODE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 30
    /// <summary>VkCullModeFlagBits - Bitmask controlling triangle culling</summary>
    public enum VkCullModeFlagBits {
        /// <summary><code>VK_CULL_MODE_NONE</code> specifies that no triangles are discarded</summary>
        VK_CULL_MODE_NONE = 0,
        /// <summary><code>VK_CULL_MODE_FRONT_BIT</code> specifies that front-facing triangles are
        /// discarded</summary>
        VK_CULL_MODE_FRONT_BIT = 0x00000001,
        /// <summary><code>VK_CULL_MODE_BACK_BIT</code> specifies that back-facing triangles are
        /// discarded</summary>
        VK_CULL_MODE_BACK_BIT = 0x00000002,
        /// <summary><code>VK_CULL_MODE_FRONT_AND_BACK</code> specifies that all triangles are
        /// discarded.</summary>
        VK_CULL_MODE_FRONT_AND_BACK = 0x00000003,
        VK_CULL_MODE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 31
    /// <summary>VkDebugReportFlagBitsEXT - Bitmask specifying events which cause a debug report callback</summary>
    [Flags]
    public enum VkDebugReportFlagBitsEXT {
        /// <summary><code>VK_DEBUG_REPORT_INFORMATION_BIT_EXT</code> specifies an informational
        /// message such as resource details that may be handy when debugging an
        /// application.</summary>
        VK_DEBUG_REPORT_INFORMATION_BIT_EXT = 0x00000001,
        /// <summary><code>VK_DEBUG_REPORT_WARNING_BIT_EXT</code> specifies use of Vulkan that <strong class="purple">may</strong>
        /// expose an app bug.
        /// Such cases may not be immediately harmful, such as a fragment shader
        /// outputting to a location with no attachment.
        /// Other cases <strong class="purple">may</strong> point to behavior that is almost certainly bad when
        /// unintended such as using an image whose memory has not been filled.
        /// In general if you see a warning but you know that the behavior is
        /// intended/desired, then simply ignore the warning.</summary>
        VK_DEBUG_REPORT_WARNING_BIT_EXT = 0x00000002,
        /// <summary><code>VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT</code> specifies a
        /// potentially non-optimal use of Vulkan, e.g. using
        /// <a href="#vkCmdClearColorImage">vkCmdClearColorImage</a> when setting
        /// <a href="#VkAttachmentDescription">VkAttachmentDescription</a>::<code>loadOp</code> to
        /// <code>VK_ATTACHMENT_LOAD_OP_CLEAR</code> would have worked.</summary>
        VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = 0x00000004,
        /// <summary><code>VK_DEBUG_REPORT_ERROR_BIT_EXT</code> specifies that the application has
        /// violated a valid usage condition of the specification.</summary>
        VK_DEBUG_REPORT_ERROR_BIT_EXT = 0x00000008,
        /// <summary><code>VK_DEBUG_REPORT_DEBUG_BIT_EXT</code> specifies diagnostic information
        /// from the implementation and layers.</summary>
        VK_DEBUG_REPORT_DEBUG_BIT_EXT = 0x00000010,
        VK_DEBUG_REPORT_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 32
    /// <summary>VkDebugReportObjectTypeEXT - Specify the type of an object handle</summary>
    public enum VkDebugReportObjectTypeEXT {
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = 4,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = 5,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = 6,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = 7,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = 8,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = 9,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = 10,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = 11,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = 12,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = 13,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = 14,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = 15,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = 16,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = 17,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = 18,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = 19,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = 20,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = 21,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = 22,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = 23,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = 24,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = 25,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = 26,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = 27,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = 28,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = 29,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = 30,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_OBJECT_TABLE_NVX_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_OBJECT_TABLE_NVX_EXT = 31,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX_EXT = 32,
        VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = 33,
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = 1000156000,
        /// <summary>class="tableblock">
        ///   <code>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT</code></summary>
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = 1000085000,
        VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = 1000165000,
        VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT,
        VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT,
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT,
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT,
        VK_DEBUG_REPORT_OBJECT_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 33
    /// <summary>VkDebugUtilsMessageSeverityFlagBitsEXT - Bitmask specifying which severities of events cause a debug messenger callback</summary>
    public enum VkDebugUtilsMessageSeverityFlagBitsEXT {
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT</code> specifies the most
        /// verbose output indicating all diagnostic messages from the Vulkan
        /// loader, layers, and drivers should be captured.</summary>
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = 0x00000001,
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT</code> specifies an
        /// informational message such as resource details that may be handy when
        /// debugging an application.</summary>
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = 0x00000010,
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT</code> specifies use of
        /// Vulkan that <strong class="purple">may</strong> expose an app bug.
        /// Such cases may not be immediately harmful, such as a fragment shader
        /// outputting to a location with no attachment.
        /// Other cases <strong class="purple">may</strong> point to behavior that is almost certainly bad when
        /// unintended such as using an image whose memory has not been filled.
        /// In general if you see a warning but you know that the behavior is
        /// intended/desired, then simply ignore the warning.</summary>
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = 0x00000100,
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT</code> specifies that the
        /// application has violated a valid usage condition of the specification.</summary>
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = 0x00001000,
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 34
    /// <summary>VkDebugUtilsMessageTypeFlagBitsEXT - Bitmask specifying which types of events cause a debug messenger callback</summary>
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT {
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT</code> specifies that some
        /// general event has occurred.
        /// This is typically a non-specification, non-performance event.</summary>
        VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT = 0x00000001,
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT</code> specifies that
        /// something has occurred during validation against the Vulkan
        /// specification that may indicate invalid behavior.</summary>
        VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT = 0x00000002,
        /// <summary><code>VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT</code> specifies a
        /// potentially non-optimal use of Vulkan, e.g. using
        /// <a href="#vkCmdClearColorImage">vkCmdClearColorImage</a> when setting
        /// <a href="#VkAttachmentDescription">VkAttachmentDescription</a>::<code>loadOp</code> to
        /// <code>VK_ATTACHMENT_LOAD_OP_CLEAR</code> would have worked.</summary>
        VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT = 0x00000004,
        VK_DEBUG_UTILS_MESSAGE_TYPE_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 35
    /// <summary>VkDependencyFlagBits - Bitmask specifying how execution and memory dependencies are formed</summary>
    public enum VkDependencyFlagBits {
        /// <summary><code>VK_DEPENDENCY_BY_REGION_BIT</code> specifies that dependencies will be
        /// <a href="vkspec.html#synchronization-framebuffer-regions">framebuffer-local</a>.</summary>
        VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,
        /// <summary><code>VK_DEPENDENCY_DEVICE_GROUP_BIT</code> specifies that dependencies are
        /// <a href="vkspec.html#synchronization-device-local-dependencies">non-device-local
        /// dependency</a>.</summary>
        VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x00000004,
        /// <summary><code>VK_DEPENDENCY_VIEW_LOCAL_BIT</code> specifies that a
        /// <a href="vkspec.html#synchronization-pipeline-barriers-subpass-self-dependencies">subpass
        /// has more than one view</a>.</summary>
        VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x00000002,
        VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,
        VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT,
        VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 36
    /// <summary>VkDescriptorBindingFlagBitsEXT - Bitmask specifying descriptor set layout binding properties</summary>
    public enum VkDescriptorBindingFlagBitsEXT {
        /// <summary><code>VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT</code> indicates that if
        /// descriptors in this binding are updated between when the descriptor set
        /// is bound in a command buffer and when that command buffer is submitted
        /// to a queue, then the submission will use the most recently set
        /// descriptors for this binding and the updates do not invalidate the
        /// command buffer.
        /// Descriptor bindings created with this flag are also partially exempt
        /// from the external synchronization requirement in
        /// <a href="#vkUpdateDescriptorSetWithTemplateKHR">vkUpdateDescriptorSetWithTemplateKHR</a> and
        /// <a href="#vkUpdateDescriptorSets">vkUpdateDescriptorSets</a>.
        /// They <strong class="purple">can</strong> be updated concurrently with the set being bound to a command
        /// buffer in another thread, but not concurrently with the set being reset
        /// or freed.</summary>
        VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT = 0x00000001,
        /// <summary><code>VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT</code>
        /// indicates that descriptors in this binding <strong class="purple">can</strong> be updated after a
        /// command buffer has bound this descriptor set, or while a command buffer
        /// that uses this descriptor set is pending execution, as long as the
        /// descriptors that are updated are not used by those command buffers.
        /// If <code>VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT</code> is also set, then
        /// descriptors <strong class="purple">can</strong> be updated as long as they are not dynamically used by
        /// any shader invocations.
        /// If <code>VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT</code> is not set, then
        /// descriptors <strong class="purple">can</strong> be updated as long as they are not statically used by
        /// any shader invocations.</summary>
        VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = 0x00000002,
        /// <summary><code>VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT</code> indicates that
        /// descriptors in this binding that are not <em>dynamically used</em> need not
        /// contain valid descriptors at the time the descriptors are consumed.
        /// A descriptor is dynamically used if any shader invocation executes an
        /// instruction that performs any memory access using the descriptor.</summary>
        VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT = 0x00000004,
        /// <summary><code>VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT</code> indicates
        /// that this descriptor binding has a variable size that will be specified
        /// when a descriptor set is allocated using this layout.
        /// The value of <code>descriptorCount</code> is treated as an upper bound on the
        /// size of the binding.
        /// This <strong class="purple">must</strong> only be used for the last binding in the descriptor set
        /// layout (i.e. the binding with the largest value of <code>binding</code>).
        /// For the purposes of counting against limits such as
        /// <code>maxDescriptorSet</code>* and <code>maxPerStageDescriptor</code>*, the full value
        /// of <code>descriptorCount</code> is counted
        /// , except for descriptor bindings with a descriptor type of
        /// <code>VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT</code> where
        /// <code>descriptorCount</code> specifies the upper bound on the byte size of the
        /// binding, thus it counts against the <a href="vkspec.html#limits-maxInlineUniformBlockSize"><code>maxInlineUniformBlockSize</code></a> limit instead.
        /// .</summary>
        VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT = 0x00000008,
        VK_DESCRIPTOR_BINDING_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 37
    /// <summary>VkDescriptorPoolCreateFlagBits - Bitmask specifying certain supported operations on a descriptor pool</summary>
    public enum VkDescriptorPoolCreateFlagBits {
        /// <summary><code>VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT</code> specifies that
        /// descriptor sets <strong class="purple">can</strong> return their individual allocations to the pool,
        /// i.e. all of <a href="#vkAllocateDescriptorSets">vkAllocateDescriptorSets</a>, <a href="#vkFreeDescriptorSets">vkFreeDescriptorSets</a>,
        /// and <a href="#vkResetDescriptorPool">vkResetDescriptorPool</a> are allowed.
        /// Otherwise, descriptor sets allocated from the pool <strong class="purple">must</strong> not be
        /// individually freed back to the pool, i.e. only
        /// <a href="#vkAllocateDescriptorSets">vkAllocateDescriptorSets</a> and <a href="#vkResetDescriptorPool">vkResetDescriptorPool</a> are
        /// allowed.</summary>
        VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = 0x00000001,
        /// <summary><code>VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT</code> specifies that
        /// descriptor sets allocated from this pool <strong class="purple">can</strong> include bindings with the
        /// <code>VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT</code> bit set.
        /// It is valid to allocate descriptor sets that have bindings that do not
        /// set the <code>VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT</code> bit from a
        /// pool that has <code>VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT</code>
        /// set.</summary>
        VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT = 0x00000002,
        VK_DESCRIPTOR_POOL_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 38
    /// <summary>VkDescriptorSetLayoutCreateFlagBits - Bitmask specifying descriptor set layout properties</summary>
    public enum VkDescriptorSetLayoutCreateFlagBits {
        /// <summary><code>VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR</code> specifies
        /// that descriptor sets <strong class="purple">must</strong> not be allocated using this layout, and
        /// descriptors are instead pushed by <a href="#vkCmdPushDescriptorSetKHR">vkCmdPushDescriptorSetKHR</a>.</summary>
        VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR = 0x00000001,
        /// <summary><code>VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT</code>
        /// specifies that descriptor sets using this layout <strong class="purple">must</strong> be allocated from
        /// a descriptor pool created with the
        /// <code>VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT</code> bit set.
        /// Descriptor set layouts created with this bit set have alternate limits
        /// for the maximum number of descriptors per-stage and per-pipeline layout.
        /// The non-UpdateAfterBind limits only count descriptors in sets created
        /// without this flag.
        /// The UpdateAfterBind limits count all descriptors, but the limits <strong class="purple">may</strong> be
        /// higher than the non-UpdateAfterBind limits.</summary>
        VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT = 0x00000002,
        VK_DESCRIPTOR_SET_LAYOUT_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 39
    /// <summary>VkDescriptorType - Specifies the type of a descriptor in a descriptor set</summary>
    public enum VkDescriptorType {
        /// <summary><code>VK_DESCRIPTOR_TYPE_SAMPLER</code> specifies a <a href="vkspec.html#descriptorsets-sampler">sampler descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_SAMPLER = 0,
        /// <summary><code>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</code> specifies a
        /// <a href="vkspec.html#descriptorsets-combinedimagesampler">combined image sampler
        /// descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = 1,
        /// <summary><code>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</code> specifies a
        /// <a href="vkspec.html#descriptorsets-sampledimage">sampled image descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = 2,
        /// <summary><code>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</code> specifies a
        /// <a href="vkspec.html#descriptorsets-storageimage">storage image descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = 3,
        /// <summary><code>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</code> specifies a
        /// <a href="vkspec.html#descriptorsets-uniformtexelbuffer">uniform texel buffer descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = 4,
        /// <summary><code>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</code> specifies a
        /// <a href="vkspec.html#descriptorsets-storagetexelbuffer">storage texel buffer descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = 5,
        /// <summary><code>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER</code> specifies a
        /// <a href="vkspec.html#descriptorsets-uniformbuffer">uniform buffer descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = 6,
        /// <summary><code>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER</code> specifies a
        /// <a href="vkspec.html#descriptorsets-storagebuffer">storage buffer descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = 7,
        /// <summary><code>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC</code> specifies a
        /// <a href="vkspec.html#descriptorsets-uniformbufferdynamic">dynamic uniform buffer
        /// descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = 8,
        /// <summary><code>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC</code> specifies a
        /// <a href="vkspec.html#descriptorsets-storagebufferdynamic">dynamic storage buffer
        /// descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = 9,
        /// <summary><code>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</code> specifies an
        /// <a href="vkspec.html#descriptorsets-inputattachment">input attachment descriptor</a>.</summary>
        VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = 10,
        /// <summary><code>VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT</code> specifies an
        /// <a href="vkspec.html#descriptorsets-inlineuniformblock">inline uniform block</a>.</summary>
        VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT = 1000138000,
        VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,
        VK_DESCRIPTOR_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 40
    /// <summary>VkDescriptorUpdateTemplateType - Indicates the valid usage of the descriptor update template</summary>
    public enum VkDescriptorUpdateTemplateType {
        /// <summary><code>VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET</code> specifies that
        /// the descriptor update template will be used for descriptor set updates
        /// only.</summary>
        VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET = 0,
        /// <summary><code>VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR</code> specifies
        /// that the descriptor update template will be used for push descriptor
        /// updates only.</summary>
        VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = 1,
        VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR = VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET,
        VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 41
    /// <summary>VkDeviceEventTypeEXT - Events that can occur on a device object</summary>
    public enum VkDeviceEventTypeEXT {
        /// <summary><code>VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT</code> specifies that the fence
        /// is signaled when a display is plugged into or unplugged from the
        /// specified device.
        /// Applications <strong class="purple">can</strong> use this notification to determine when they need to
        /// re-enumerate the available displays on a device.</summary>
        VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT = 0,
        VK_DEVICE_EVENT_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 42
    /// <summary>VkDeviceGroupPresentModeFlagBitsKHR - Bitmask specifying supported device group present modes</summary>
    public enum VkDeviceGroupPresentModeFlagBitsKHR {
        /// <summary><code>VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR</code> specifies that any
        /// physical device with a presentation engine <strong class="purple">can</strong> present its own
        /// swapchain images.</summary>
        VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = 0x00000001,
        /// <summary><code>VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR</code> specifies that any
        /// physical device with a presentation engine <strong class="purple">can</strong> present swapchain images
        /// from any physical device in its <code>presentMask</code>.</summary>
        VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = 0x00000002,
        /// <summary><code>VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR</code> specifies that any
        /// physical device with a presentation engine <strong class="purple">can</strong> present the sum of
        /// swapchain images from any physical devices in its <code>presentMask</code>.</summary>
        VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = 0x00000004,
        /// <summary><code>VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR</code> specifies
        /// that multiple physical devices with a presentation engine <strong class="purple">can</strong> each
        /// present their own swapchain images.</summary>
        VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = 0x00000008,
        VK_DEVICE_GROUP_PRESENT_MODE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 43
    /// <summary>VkDeviceQueueCreateFlagBits - Bitmask specifying behavior of the queue</summary>
    public enum VkDeviceQueueCreateFlagBits {
        /// <summary><code>VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT</code> specifies that the device
        /// queue is a protected-capable queue.
        /// If the protected memory feature is not enabled, the
        /// <code>VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT</code> bit of <code>flags</code><strong class="purple">must</strong> not
        /// be set.</summary>
        VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT = 0x00000001,
        VK_DEVICE_QUEUE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 44
    /// <summary>VkDiscardRectangleModeEXT - Specify the discard rectangle mode</summary>
    public enum VkDiscardRectangleModeEXT {
        /// <summary><code>VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT</code> specifies that a fragment
        /// within any discard rectangle satisfies the test.</summary>
        VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT = 0,
        /// <summary><code>VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT</code> specifies that a fragment
        /// not within any of the discard rectangles satisfies the test.</summary>
        VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT = 1,
        VK_DISCARD_RECTANGLE_MODE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 45
    /// <summary>VkDisplayEventTypeEXT - Events that can occur on a display object</summary>
    public enum VkDisplayEventTypeEXT {
        /// <summary><code>VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT</code> specifies that the fence
        /// is signaled when the first pixel of the next display refresh cycle
        /// leaves the display engine for the display.</summary>
        VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT = 0,
        VK_DISPLAY_EVENT_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 46
    /// <summary>VkDisplayPlaneAlphaFlagBitsKHR - Alpha blending type</summary>
    public enum VkDisplayPlaneAlphaFlagBitsKHR {
        /// <summary><code>VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR</code> specifies that the source
        /// image will be treated as opaque.</summary>
        VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,
        /// <summary><code>VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR</code> specifies that a global
        /// alpha value <strong class="purple">must</strong> be specified that will be applied to all pixels in the
        /// source image.</summary>
        VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = 0x00000002,
        /// <summary><code>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR</code> specifies that the alpha
        /// value will be determined by the alpha channel of the source image’s
        /// pixels.
        /// If the source format contains no alpha values, no blending will be
        /// applied.
        /// The source alpha values are not premultiplied into the source image’s
        /// other color channels.</summary>
        VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = 0x00000004,
        /// <summary><code>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR</code> is
        /// equivalent to <code>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR</code>, except the
        /// source alpha values are assumed to be premultiplied into the source
        /// image’s other color channels.</summary>
        VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = 0x00000008,
        VK_DISPLAY_PLANE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 47
    /// <summary>VkDisplayPowerStateEXT - Possible power states for a display</summary>
    public enum VkDisplayPowerStateEXT {
        /// <summary><code>VK_DISPLAY_POWER_STATE_OFF_EXT</code> specifies that the display is
        /// powered down.</summary>
        VK_DISPLAY_POWER_STATE_OFF_EXT = 0,
        /// <summary><code>VK_DISPLAY_POWER_STATE_SUSPEND_EXT</code> specifies that the display is
        /// put into a low power mode, from which it <strong class="purple">may</strong> be able to transition back
        /// to <code>VK_DISPLAY_POWER_STATE_ON_EXT</code> more quickly than if it were in
        /// <code>VK_DISPLAY_POWER_STATE_OFF_EXT</code>.
        /// This state <strong class="purple">may</strong> be the same as <code>VK_DISPLAY_POWER_STATE_OFF_EXT</code>.</summary>
        VK_DISPLAY_POWER_STATE_SUSPEND_EXT = 1,
        /// <summary><code>VK_DISPLAY_POWER_STATE_ON_EXT</code> specifies that the display is
        /// powered on.</summary>
        VK_DISPLAY_POWER_STATE_ON_EXT = 2,
        VK_DISPLAY_POWER_STATE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 48
    /// <summary>VkDriverIdKHR - Khronos driver IDs</summary>
    public enum VkDriverIdKHR {
        VK_DRIVER_ID_AMD_PROPRIETARY_KHR = 1,
        VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = 2,
        VK_DRIVER_ID_MESA_RADV_KHR = 3,
        VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = 4,
        VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = 5,
        VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = 6,
        VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = 7,
        VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = 8,
        VK_DRIVER_ID_ARM_PROPRIETARY_KHR = 9,
        VK_DRIVER_ID_GOOGLE_PASTEL_KHR = 10,
        VK_DRIVER_ID_GGP_PROPRIETARY_KHR = 11,
        VK_DRIVER_ID_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 49
    /// <summary>VkDynamicState - Indicate which dynamic state is taken from dynamic state commands</summary>
    public enum VkDynamicState {
        /// <summary><code>VK_DYNAMIC_STATE_VIEWPORT</code> specifies that the <code>pViewports</code>
        /// state in <code>VkPipelineViewportStateCreateInfo</code> will be ignored and
        /// <strong class="purple">must</strong> be set dynamically with <a href="#vkCmdSetViewport">vkCmdSetViewport</a> before any draw
        /// commands.
        /// The number of viewports used by a pipeline is still specified by the
        /// <code>viewportCount</code> member of <code>VkPipelineViewportStateCreateInfo</code>.</summary>
        VK_DYNAMIC_STATE_VIEWPORT = 0,
        /// <summary><code>VK_DYNAMIC_STATE_SCISSOR</code> specifies that the <code>pScissors</code> state
        /// in <code>VkPipelineViewportStateCreateInfo</code> will be ignored and <strong class="purple">must</strong> be
        /// set dynamically with <a href="#vkCmdSetScissor">vkCmdSetScissor</a> before any draw commands.
        /// The number of scissor rectangles used by a pipeline is still specified
        /// by the <code>scissorCount</code> member of
        /// <code>VkPipelineViewportStateCreateInfo</code>.</summary>
        VK_DYNAMIC_STATE_SCISSOR = 1,
        /// <summary><code>VK_DYNAMIC_STATE_LINE_WIDTH</code> specifies that the <code>lineWidth</code>
        /// state in <code>VkPipelineRasterizationStateCreateInfo</code> will be ignored
        /// and <strong class="purple">must</strong> be set dynamically with <a href="#vkCmdSetLineWidth">vkCmdSetLineWidth</a> before any
        /// draw commands that generate line primitives for the rasterizer.</summary>
        VK_DYNAMIC_STATE_LINE_WIDTH = 2,
        /// <summary><code>VK_DYNAMIC_STATE_DEPTH_BIAS</code> specifies that the
        /// <code>depthBiasConstantFactor</code>, <code>depthBiasClamp</code> and
        /// <code>depthBiasSlopeFactor</code> states in
        /// <code>VkPipelineRasterizationStateCreateInfo</code> will be ignored and <strong class="purple">must</strong>
        /// be set dynamically with <a href="#vkCmdSetDepthBias">vkCmdSetDepthBias</a> before any draws are
        /// performed with <code>depthBiasEnable</code> in
        /// <code>VkPipelineRasterizationStateCreateInfo</code> set to <code>VK_TRUE</code>.</summary>
        VK_DYNAMIC_STATE_DEPTH_BIAS = 3,
        /// <summary><code>VK_DYNAMIC_STATE_BLEND_CONSTANTS</code> specifies that the
        /// <code>blendConstants</code> state in <code>VkPipelineColorBlendStateCreateInfo</code>
        /// will be ignored and <strong class="purple">must</strong> be set dynamically with
        /// <a href="#vkCmdSetBlendConstants">vkCmdSetBlendConstants</a> before any draws are performed with a
        /// pipeline state with <code>VkPipelineColorBlendAttachmentState</code> member
        /// <code>blendEnable</code> set to <code>VK_TRUE</code> and any of the blend functions
        /// using a constant blend color.</summary>
        VK_DYNAMIC_STATE_BLEND_CONSTANTS = 4,
        /// <summary><code>VK_DYNAMIC_STATE_DEPTH_BOUNDS</code> specifies that the
        /// <code>minDepthBounds</code> and <code>maxDepthBounds</code> states of
        /// <a href="#VkPipelineDepthStencilStateCreateInfo">VkPipelineDepthStencilStateCreateInfo</a> will be ignored and <strong class="purple">must</strong> be
        /// set dynamically with <a href="#vkCmdSetDepthBounds">vkCmdSetDepthBounds</a> before any draws are
        /// performed with a pipeline state with
        /// <code>VkPipelineDepthStencilStateCreateInfo</code> member
        /// <code>depthBoundsTestEnable</code> set to <code>VK_TRUE</code>.</summary>
        VK_DYNAMIC_STATE_DEPTH_BOUNDS = 5,
        /// <summary><code>VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK</code> specifies that the
        /// <code>compareMask</code> state in <code>VkPipelineDepthStencilStateCreateInfo</code>
        /// for both <code>front</code> and <code>back</code> will be ignored and <strong class="purple">must</strong> be set
        /// dynamically with <a href="#vkCmdSetStencilCompareMask">vkCmdSetStencilCompareMask</a> before any draws are
        /// performed with a pipeline state with
        /// <code>VkPipelineDepthStencilStateCreateInfo</code> member
        /// <code>stencilTestEnable</code> set to <code>VK_TRUE</code></summary>
        VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = 6,
        /// <summary><code>VK_DYNAMIC_STATE_STENCIL_WRITE_MASK</code> specifies that the
        /// <code>writeMask</code> state in <code>VkPipelineDepthStencilStateCreateInfo</code> for
        /// both <code>front</code> and <code>back</code> will be ignored and <strong class="purple">must</strong> be set
        /// dynamically with <a href="#vkCmdSetStencilWriteMask">vkCmdSetStencilWriteMask</a> before any draws are
        /// performed with a pipeline state with
        /// <code>VkPipelineDepthStencilStateCreateInfo</code> member
        /// <code>stencilTestEnable</code> set to <code>VK_TRUE</code></summary>
        VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = 7,
        /// <summary><code>VK_DYNAMIC_STATE_STENCIL_REFERENCE</code> specifies that the
        /// <code>reference</code> state in <code>VkPipelineDepthStencilStateCreateInfo</code> for
        /// both <code>front</code> and <code>back</code> will be ignored and <strong class="purple">must</strong> be set
        /// dynamically with <a href="#vkCmdSetStencilReference">vkCmdSetStencilReference</a> before any draws are
        /// performed with a pipeline state with
        /// <code>VkPipelineDepthStencilStateCreateInfo</code> member
        /// <code>stencilTestEnable</code> set to <code>VK_TRUE</code></summary>
        VK_DYNAMIC_STATE_STENCIL_REFERENCE = 8,
        /// <summary><code>VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV</code> specifies that the
        /// <code>pViewportScalings</code> state in
        /// <a href="#VkPipelineViewportWScalingStateCreateInfoNV">VkPipelineViewportWScalingStateCreateInfoNV</a> will be ignored and
        /// <strong class="purple">must</strong> be set dynamically with <a href="#vkCmdSetViewportWScalingNV">vkCmdSetViewportWScalingNV</a> before
        /// any draws are performed with a pipeline state with
        /// <a href="#VkPipelineViewportWScalingStateCreateInfoNV">VkPipelineViewportWScalingStateCreateInfoNV</a> member
        /// <code>viewportScalingEnable</code> set to <code>VK_TRUE</code></summary>
        VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000087000,
        /// <summary><code>VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT</code> specifies that the
        /// <code>pDiscardRectangles</code> state in
        /// <a href="#VkPipelineDiscardRectangleStateCreateInfoEXT">VkPipelineDiscardRectangleStateCreateInfoEXT</a> will be ignored and
        /// <strong class="purple">must</strong> be set dynamically with <a href="#vkCmdSetDiscardRectangleEXT">vkCmdSetDiscardRectangleEXT</a> before
        /// any draw or clear commands.
        /// The <a href="#VkDiscardRectangleModeEXT">VkDiscardRectangleModeEXT</a> and the number of active discard
        /// rectangles is still specified by the <code>discardRectangleMode</code> and
        /// <code>discardRectangleCount</code> members of
        /// <code>VkPipelineDiscardRectangleStateCreateInfoEXT</code>.</summary>
        VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000099000,
        /// <summary><code>VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT</code> specifies that the
        /// <code>sampleLocationsInfo</code> state in
        /// <a href="#VkPipelineSampleLocationsStateCreateInfoEXT">VkPipelineSampleLocationsStateCreateInfoEXT</a> will be ignored and
        /// <strong class="purple">must</strong> be set dynamically with <a href="#vkCmdSetSampleLocationsEXT">vkCmdSetSampleLocationsEXT</a> before
        /// any draw or clear commands.
        /// Enabling custom sample locations is still indicated by the
        /// <code>sampleLocationsEnable</code> member of
        /// <code>VkPipelineSampleLocationsStateCreateInfoEXT</code>.</summary>
        VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000143000,
        /// <summary><code>VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV</code> specifies that
        /// the <code>pShadingRatePalettes</code> state in
        /// <a href="#VkPipelineViewportShadingRateImageStateCreateInfoNV">VkPipelineViewportShadingRateImageStateCreateInfoNV</a> will be
        /// ignored and <strong class="purple">must</strong> be set dynamically with
        /// <a href="#vkCmdSetViewportShadingRatePaletteNV">vkCmdSetViewportShadingRatePaletteNV</a> before any draw commands.</summary>
        VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000164004,
        /// <summary><code>VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV</code> specifies that
        /// the coarse sample order state in
        /// <a href="#VkPipelineViewportCoarseSampleOrderStateCreateInfoNV">VkPipelineViewportCoarseSampleOrderStateCreateInfoNV</a> will be
        /// ignored and <strong class="purple">must</strong> be set dynamically with
        /// <a href="#vkCmdSetCoarseSampleOrderNV">vkCmdSetCoarseSampleOrderNV</a> before any draw commands.</summary>
        VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000164006,
        /// <summary><code>VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV</code> specifies that the
        /// <code>pExclusiveScissors</code> state in
        /// <code>VkPipelineViewportExclusiveScissorStateCreateInfoNV</code> will be
        /// ignored and <strong class="purple">must</strong> be set dynamically with
        /// <a href="#vkCmdSetExclusiveScissorNV">vkCmdSetExclusiveScissorNV</a> before any draw commands.
        /// The number of exclusive scissor rectangles used by a pipeline is still
        /// specified by the <code>exclusiveScissorCount</code> member of
        /// <code>VkPipelineViewportExclusiveScissorStateCreateInfoNV</code>.</summary>
        VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000205001,
        VK_DYNAMIC_STATE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 50
    /// <summary>VkExternalFenceFeatureFlagBits - Bitfield describing features of an external fence handle type</summary>
    public enum VkExternalFenceFeatureFlagBits {
        /// <summary><code>VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT</code> specifies handles of this
        /// type <strong class="purple">can</strong> be exported from Vulkan fence objects.</summary>
        VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = 0x00000001,
        /// <summary><code>VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT</code> specifies handles of this
        /// type <strong class="purple">can</strong> be imported to Vulkan fence objects.</summary>
        VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = 0x00000002,
        VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT,
        VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT,
        VK_EXTERNAL_FENCE_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 51
    /// <summary>VkExternalFenceHandleTypeFlagBits - Bitmask of valid external fence handle types</summary>
    public enum VkExternalFenceHandleTypeFlagBits {
        /// <summary><code>VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT</code> specifies a POSIX file
        /// descriptor handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It <strong class="purple">must</strong> be compatible with the POSIX system calls <code>dup</code>, <code>dup2</code>,
        /// <code>close</code>, and the non-standard system call <code>dup3</code>.
        /// Additionally, it <strong class="purple">must</strong> be transportable over a socket using an
        /// <code>SCM_RIGHTS</code> control message.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan fence object.</summary>
        VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,
        /// <summary><code>VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT</code> specifies an NT
        /// handle that has only limited valid usage outside of Vulkan and other
        /// compatible APIs.
        /// It <strong class="purple">must</strong> be compatible with the functions <code>DuplicateHandle</code>,
        /// <code>CloseHandle</code>, <code>CompareObjectHandles</code>, <code>GetHandleInformation</code>,
        /// and <code>SetHandleInformation</code>.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan fence object.</summary>
        VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,
        /// <summary><code>VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT</code> specifies a
        /// global share handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It is not compatible with any native APIs.
        /// It does not own a reference to the underlying synchronization primitive
        /// represented by its Vulkan fence object, and will therefore become
        /// invalid when all Vulkan fence objects associated with it are destroyed.</summary>
        VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,
        /// <summary><code>VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT</code> specifies a POSIX file
        /// descriptor handle to a Linux Sync File or Android Fence.
        /// It can be used with any native API accepting a valid sync file or fence
        /// as input.
        /// It owns a reference to the underlying synchronization primitive
        /// associated with the file descriptor.
        /// Implementations which support importing this handle type <strong class="purple">must</strong> accept
        /// any type of sync or fence FD supported by the native system they are
        /// running on.</summary>
        VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT = 0x00000008,
        VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT,
        VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT,
        VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,
        VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT,
        VK_EXTERNAL_FENCE_HANDLE_TYPE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 52
    /// <summary>VkExternalMemoryFeatureFlagBits - Bitmask specifying features of an external memory handle type</summary>
    public enum VkExternalMemoryFeatureFlagBits {
        /// <summary><code>VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT</code> specifies that
        /// images or buffers created with the specified parameters and handle type
        /// <strong class="purple">must</strong> use the mechanisms defined by <a href="#VkMemoryDedicatedRequirements">VkMemoryDedicatedRequirements</a>
        /// and <a href="#VkMemoryDedicatedAllocateInfo">VkMemoryDedicatedAllocateInfo</a> to create (or import) a
        /// dedicated allocation for the image or buffer.</summary>
        VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT = 0x00000001,
        /// <summary><code>VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT</code> specifies that handles
        /// of this type <strong class="purple">can</strong> be exported from Vulkan memory objects.</summary>
        VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT = 0x00000002,
        /// <summary><code>VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT</code> specifies that handles
        /// of this type <strong class="purple">can</strong> be imported as Vulkan memory objects.</summary>
        VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT = 0x00000004,
        VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT,
        VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT,
        VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT,
        VK_EXTERNAL_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 53
    /// <summary>VkExternalMemoryFeatureFlagBitsNV - Bitmask specifying external memory features</summary>
    public enum VkExternalMemoryFeatureFlagBitsNV {
        /// <summary><code>VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV</code> specifies that
        /// external memory of the specified type <strong class="purple">must</strong> be created as a dedicated
        /// allocation when used in the manner specified.</summary>
        VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = 0x00000001,
        /// <summary><code>VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV</code> specifies that the
        /// implementation supports exporting handles of the specified type.</summary>
        VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = 0x00000002,
        /// <summary><code>VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV</code> specifies that the
        /// implementation supports importing handles of the specified type.</summary>
        VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = 0x00000004,
        VK_EXTERNAL_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 54
    /// <summary>VkExternalMemoryHandleTypeFlagBits - Bit specifying external memory handle types</summary>
    public enum VkExternalMemoryHandleTypeFlagBits {
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT</code> specifies a POSIX
        /// file descriptor handle that has only limited valid usage outside of
        /// Vulkan and other compatible APIs.
        /// It <strong class="purple">must</strong> be compatible with the POSIX system calls <code>dup</code>, <code>dup2</code>,
        /// <code>close</code>, and the non-standard system call <code>dup3</code>.
        /// Additionally, it <strong class="purple">must</strong> be transportable over a socket using an
        /// <code>SCM_RIGHTS</code> control message.
        /// It owns a reference to the underlying memory resource represented by its
        /// Vulkan memory object.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT</code> specifies an NT
        /// handle that has only limited valid usage outside of Vulkan and other
        /// compatible APIs.
        /// It <strong class="purple">must</strong> be compatible with the functions <code>DuplicateHandle</code>,
        /// <code>CloseHandle</code>, <code>CompareObjectHandles</code>, <code>GetHandleInformation</code>,
        /// and <code>SetHandleInformation</code>.
        /// It owns a reference to the underlying memory resource represented by its
        /// Vulkan memory object.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT</code> specifies a
        /// global share handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It is not compatible with any native APIs.
        /// It does not own a reference to the underlying memory resource
        /// represented its Vulkan memory object, and will therefore become invalid
        /// when all Vulkan memory objects associated with it are destroyed.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT</code> specifies an NT
        /// handle returned by <code>IDXGIResource1</code>::<code>CreateSharedHandle</code>
        /// referring to a Direct3D 10 or 11 texture resource.
        /// It owns a reference to the memory used by the Direct3D resource.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT = 0x00000008,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT</code> specifies a
        /// global share handle returned by <code>IDXGIResource</code>::<code>GetSharedHandle</code>
        /// referring to a Direct3D 10 or 11 texture resource.
        /// It does not own a reference to the underlying Direct3D resource, and
        /// will therefore become invalid when all Vulkan memory objects and
        /// Direct3D resources associated with it are destroyed.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT = 0x00000010,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT</code> specifies an NT
        /// handle returned by <code>ID3D12Device</code>::<code>CreateSharedHandle</code> referring
        /// to a Direct3D 12 heap resource.
        /// It owns a reference to the resources used by the Direct3D heap.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT = 0x00000020,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT</code> specifies an NT
        /// handle returned by <code>ID3D12Device</code>::<code>CreateSharedHandle</code> referring
        /// to a Direct3D 12 committed resource.
        /// It owns a reference to the memory used by the Direct3D resource.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT = 0x00000040,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT</code> is a file
        /// descriptor for a Linux dma_buf.
        /// It owns a reference to the underlying memory resource represented by its
        /// Vulkan memory object.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT = 0x00000200,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID</code>
        /// specifies an <a href="#AHardwareBuffer">AHardwareBuffer</a> object defined by the Android NDK.
        /// See <a href="vkspec.html#memory-external-android-hardware-buffer">Android Hardware Buffers</a>
        /// for more details of this handle type.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID = 0x00000400,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT</code> specifies a
        /// host pointer returned by a host memory allocation command.
        /// It does not own a reference to the underlying memory resource, and will
        /// therefore become invalid if the host memory is freed.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT = 0x00000080,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT</code>
        /// specifies a host pointer to <em>host mapped foreign memory</em>.
        /// It does not own a reference to the underlying memory resource, and will
        /// therefore become invalid if the foreign memory is unmapped or otherwise
        /// becomes no longer available.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT = 0x00000100,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 55
    /// <summary>VkExternalMemoryHandleTypeFlagBitsNV - Bitmask specifying external memory handle types</summary>
    public enum VkExternalMemoryHandleTypeFlagBitsNV {
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV</code> specifies a
        /// handle to memory returned by <a href="#vkGetMemoryWin32HandleNV">vkGetMemoryWin32HandleNV</a>, or one
        /// duplicated from such a handle using <code>DuplicateHandle()</code>.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV = 0x00000001,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV</code> specifies a
        /// handle to memory returned by <a href="#vkGetMemoryWin32HandleNV">vkGetMemoryWin32HandleNV</a>.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV = 0x00000002,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV</code> specifies a
        /// valid NT handle to memory returned by
        /// <code>IDXGIResource1::CreateSharedHandle</code>, or a handle duplicated from such a
        /// handle using <code>DuplicateHandle()</code>.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV = 0x00000004,
        /// <summary><code>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV</code> specifies a
        /// handle to memory returned by <code>IDXGIResource::GetSharedHandle()</code>.</summary>
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV = 0x00000008,
        VK_EXTERNAL_MEMORY_HANDLE_TYPE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 56
    /// <summary>VkExternalSemaphoreFeatureFlagBits - Bitfield describing features of an external semaphore handle type</summary>
    public enum VkExternalSemaphoreFeatureFlagBits {
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT</code> specifies that
        /// handles of this type <strong class="purple">can</strong> be exported from Vulkan semaphore objects.</summary>
        VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT = 0x00000001,
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT</code> specifies that
        /// handles of this type <strong class="purple">can</strong> be imported as Vulkan semaphore objects.</summary>
        VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT = 0x00000002,
        VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT,
        VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT,
        VK_EXTERNAL_SEMAPHORE_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 57
    /// <summary>VkExternalSemaphoreHandleTypeFlagBits - Bitmask of valid external semaphore handle types</summary>
    public enum VkExternalSemaphoreHandleTypeFlagBits {
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT</code> specifies a POSIX
        /// file descriptor handle that has only limited valid usage outside of
        /// Vulkan and other compatible APIs.
        /// It <strong class="purple">must</strong> be compatible with the POSIX system calls <code>dup</code>, <code>dup2</code>,
        /// <code>close</code>, and the non-standard system call <code>dup3</code>.
        /// Additionally, it <strong class="purple">must</strong> be transportable over a socket using an
        /// <code>SCM_RIGHTS</code> control message.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan semaphore object.</summary>
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT</code> specifies an NT
        /// handle that has only limited valid usage outside of Vulkan and other
        /// compatible APIs.
        /// It <strong class="purple">must</strong> be compatible with the functions <code>DuplicateHandle</code>,
        /// <code>CloseHandle</code>, <code>CompareObjectHandles</code>, <code>GetHandleInformation</code>,
        /// and <code>SetHandleInformation</code>.
        /// It owns a reference to the underlying synchronization primitive
        /// represented by its Vulkan semaphore object.</summary>
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT</code> specifies a
        /// global share handle that has only limited valid usage outside of Vulkan
        /// and other compatible APIs.
        /// It is not compatible with any native APIs.
        /// It does not own a reference to the underlying synchronization primitive
        /// represented its Vulkan semaphore object, and will therefore become
        /// invalid when all Vulkan semaphore objects associated with it are
        /// destroyed.</summary>
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT</code> specifies an NT
        /// handle returned by <code>ID3D12Device</code>::<code>CreateSharedHandle</code> referring
        /// to a Direct3D 12 fence.
        /// It owns a reference to the underlying synchronization primitive
        /// associated with the Direct3D fence.</summary>
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT = 0x00000008,
        /// <summary><code>VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT</code> specifies a POSIX
        /// file descriptor handle to a Linux Sync File or Android Fence object.
        /// It can be used with any native API accepting a valid sync file or fence
        /// as input.
        /// It owns a reference to the underlying synchronization primitive
        /// associated with the file descriptor.
        /// Implementations which support importing this handle type <strong class="purple">must</strong> accept
        /// any type of sync or fence FD supported by the native system they are
        /// running on.</summary>
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT = 0x00000010,
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT,
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT,
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT,
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT_KHR = VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT,
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 58
    /// <summary>VkFenceCreateFlagBits - Bitmask specifying initial state and behavior of a fence</summary>
    public enum VkFenceCreateFlagBits {
        /// <summary><code>VK_FENCE_CREATE_SIGNALED_BIT</code> specifies that the fence object is
        /// created in the signaled state.
        /// Otherwise, it is created in the unsignaled state.</summary>
        VK_FENCE_CREATE_SIGNALED_BIT = 0x00000001,
        VK_FENCE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 59
    /// <summary>VkFenceImportFlagBits - Bitmask specifying additional parameters of fence payload import</summary>
    public enum VkFenceImportFlagBits {
        /// <summary><code>VK_FENCE_IMPORT_TEMPORARY_BIT</code> specifies that the fence payload
        /// will be imported only temporarily, as described in
        /// <a href="vkspec.html#synchronization-fences-importing">Importing Fence Payloads</a>,
        /// regardless of the permanence of <code>handleType</code>.</summary>
        VK_FENCE_IMPORT_TEMPORARY_BIT = 0x00000001,
        VK_FENCE_IMPORT_TEMPORARY_BIT_KHR = VK_FENCE_IMPORT_TEMPORARY_BIT,
        VK_FENCE_IMPORT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 60
    /// <summary>VkFilter - Specify filters used for texture lookups</summary>
    public enum VkFilter {
        /// <summary><code>VK_FILTER_NEAREST</code> specifies nearest filtering.</summary>
        VK_FILTER_NEAREST = 0,
        /// <summary><code>VK_FILTER_LINEAR</code> specifies linear filtering.</summary>
        VK_FILTER_LINEAR = 1,
        VK_FILTER_CUBIC_IMG = 1000015000,
        /// <summary><code>VK_FILTER_CUBIC_EXT</code> specifies cubic filtering.</summary>
        VK_FILTER_CUBIC_EXT = VK_FILTER_CUBIC_IMG,
        VK_FILTER_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 61
    /// <summary>VkFormat - Available image formats</summary>
    public enum VkFormat {
        /// <summary><code>VK_FORMAT_UNDEFINED</code> specifies that the format is not specified.</summary>
        VK_FORMAT_UNDEFINED = 0,
        /// <summary><code>VK_FORMAT_R4G4_UNORM_PACK8</code> specifies a two-component, 8-bit packed
        /// unsigned normalized format that has a 4-bit R component in bits 4..7,
        /// and a 4-bit G component in bits 0..3.</summary>
        VK_FORMAT_R4G4_UNORM_PACK8 = 1,
        /// <summary><code>VK_FORMAT_R4G4B4A4_UNORM_PACK16</code> specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 4-bit R component in bits
        /// 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in bits
        /// 4..7, and a 4-bit A component in bits 0..3.</summary>
        VK_FORMAT_R4G4B4A4_UNORM_PACK16 = 2,
        /// <summary><code>VK_FORMAT_B4G4R4A4_UNORM_PACK16</code> specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 4-bit B component in bits
        /// 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in bits
        /// 4..7, and a 4-bit A component in bits 0..3.</summary>
        VK_FORMAT_B4G4R4A4_UNORM_PACK16 = 3,
        /// <summary><code>VK_FORMAT_R5G6B5_UNORM_PACK16</code> specifies a three-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit R component in bits
        /// 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component in
        /// bits 0..4.</summary>
        VK_FORMAT_R5G6B5_UNORM_PACK16 = 4,
        /// <summary><code>VK_FORMAT_B5G6R5_UNORM_PACK16</code> specifies a three-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit B component in bits
        /// 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component in
        /// bits 0..4.</summary>
        VK_FORMAT_B5G6R5_UNORM_PACK16 = 5,
        /// <summary><code>VK_FORMAT_R5G5B5A1_UNORM_PACK16</code> specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit R component in bits
        /// 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in bits
        /// 1..5, and a 1-bit A component in bit 0.</summary>
        VK_FORMAT_R5G5B5A1_UNORM_PACK16 = 6,
        /// <summary><code>VK_FORMAT_B5G5R5A1_UNORM_PACK16</code> specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit B component in bits
        /// 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in bits
        /// 1..5, and a 1-bit A component in bit 0.</summary>
        VK_FORMAT_B5G5R5A1_UNORM_PACK16 = 7,
        /// <summary><code>VK_FORMAT_A1R5G5B5_UNORM_PACK16</code> specifies a four-component, 16-bit
        /// packed unsigned normalized format that has a 1-bit A component in bit
        /// 15, a 5-bit R component in bits 10..14, a 5-bit G component in bits
        /// 5..9, and a 5-bit B component in bits 0..4.</summary>
        VK_FORMAT_A1R5G5B5_UNORM_PACK16 = 8,
        /// <summary><code>VK_FORMAT_R8_UNORM</code> specifies a one-component, 8-bit unsigned
        /// normalized format that has a single 8-bit R component.</summary>
        VK_FORMAT_R8_UNORM = 9,
        /// <summary><code>VK_FORMAT_R8_SNORM</code> specifies a one-component, 8-bit signed
        /// normalized format that has a single 8-bit R component.</summary>
        VK_FORMAT_R8_SNORM = 10,
        /// <summary><code>VK_FORMAT_R8_USCALED</code> specifies a one-component, 8-bit unsigned
        /// scaled integer format that has a single 8-bit R component.</summary>
        VK_FORMAT_R8_USCALED = 11,
        /// <summary><code>VK_FORMAT_R8_SSCALED</code> specifies a one-component, 8-bit signed
        /// scaled integer format that has a single 8-bit R component.</summary>
        VK_FORMAT_R8_SSCALED = 12,
        /// <summary><code>VK_FORMAT_R8_UINT</code> specifies a one-component, 8-bit unsigned
        /// integer format that has a single 8-bit R component.</summary>
        VK_FORMAT_R8_UINT = 13,
        /// <summary><code>VK_FORMAT_R8_SINT</code> specifies a one-component, 8-bit signed integer
        /// format that has a single 8-bit R component.</summary>
        VK_FORMAT_R8_SINT = 14,
        /// <summary><code>VK_FORMAT_R8_SRGB</code> specifies a one-component, 8-bit unsigned
        /// normalized format that has a single 8-bit R component stored with sRGB
        /// nonlinear encoding.</summary>
        VK_FORMAT_R8_SRGB = 15,
        /// <summary><code>VK_FORMAT_R8G8_UNORM</code> specifies a two-component, 16-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, and an 8-bit
        /// G component in byte 1.</summary>
        VK_FORMAT_R8G8_UNORM = 16,
        /// <summary><code>VK_FORMAT_R8G8_SNORM</code> specifies a two-component, 16-bit signed
        /// normalized format that has an 8-bit R component in byte 0, and an 8-bit
        /// G component in byte 1.</summary>
        VK_FORMAT_R8G8_SNORM = 17,
        /// <summary><code>VK_FORMAT_R8G8_USCALED</code> specifies a two-component, 16-bit unsigned
        /// scaled integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.</summary>
        VK_FORMAT_R8G8_USCALED = 18,
        /// <summary><code>VK_FORMAT_R8G8_SSCALED</code> specifies a two-component, 16-bit signed
        /// scaled integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.</summary>
        VK_FORMAT_R8G8_SSCALED = 19,
        /// <summary><code>VK_FORMAT_R8G8_UINT</code> specifies a two-component, 16-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.</summary>
        VK_FORMAT_R8G8_UINT = 20,
        /// <summary><code>VK_FORMAT_R8G8_SINT</code> specifies a two-component, 16-bit signed
        /// integer format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.</summary>
        VK_FORMAT_R8G8_SINT = 21,
        /// <summary><code>VK_FORMAT_R8G8_SRGB</code> specifies a two-component, 16-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, and an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1.</summary>
        VK_FORMAT_R8G8_SRGB = 22,
        /// <summary><code>VK_FORMAT_R8G8B8_UNORM</code> specifies a three-component, 24-bit
        /// unsigned normalized format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, and an 8-bit B component in byte 2.</summary>
        VK_FORMAT_R8G8B8_UNORM = 23,
        /// <summary><code>VK_FORMAT_R8G8B8_SNORM</code> specifies a three-component, 24-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        VK_FORMAT_R8G8B8_SNORM = 24,
        /// <summary><code>VK_FORMAT_R8G8B8_USCALED</code> specifies a three-component, 24-bit
        /// unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit B component in byte 2.</summary>
        VK_FORMAT_R8G8B8_USCALED = 25,
        /// <summary><code>VK_FORMAT_R8G8B8_SSCALED</code> specifies a three-component, 24-bit
        /// signed scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        VK_FORMAT_R8G8B8_SSCALED = 26,
        /// <summary><code>VK_FORMAT_R8G8B8_UINT</code> specifies a three-component, 24-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        VK_FORMAT_R8G8B8_UINT = 27,
        /// <summary><code>VK_FORMAT_R8G8B8_SINT</code> specifies a three-component, 24-bit signed
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.</summary>
        VK_FORMAT_R8G8B8_SINT = 28,
        /// <summary><code>VK_FORMAT_R8G8B8_SRGB</code> specifies a three-component, 24-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 2.</summary>
        VK_FORMAT_R8G8B8_SRGB = 29,
        /// <summary><code>VK_FORMAT_B8G8R8_UNORM</code> specifies a three-component, 24-bit
        /// unsigned normalized format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, and an 8-bit R component in byte 2.</summary>
        VK_FORMAT_B8G8R8_UNORM = 30,
        /// <summary><code>VK_FORMAT_B8G8R8_SNORM</code> specifies a three-component, 24-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        VK_FORMAT_B8G8R8_SNORM = 31,
        /// <summary><code>VK_FORMAT_B8G8R8_USCALED</code> specifies a three-component, 24-bit
        /// unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit R component in byte 2.</summary>
        VK_FORMAT_B8G8R8_USCALED = 32,
        /// <summary><code>VK_FORMAT_B8G8R8_SSCALED</code> specifies a three-component, 24-bit
        /// signed scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        VK_FORMAT_B8G8R8_SSCALED = 33,
        /// <summary><code>VK_FORMAT_B8G8R8_UINT</code> specifies a three-component, 24-bit unsigned
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        VK_FORMAT_B8G8R8_UINT = 34,
        /// <summary><code>VK_FORMAT_B8G8R8_SINT</code> specifies a three-component, 24-bit signed
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.</summary>
        VK_FORMAT_B8G8R8_SINT = 35,
        /// <summary><code>VK_FORMAT_B8G8R8_SRGB</code> specifies a three-component, 24-bit unsigned
        /// normalized format that has an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 2.</summary>
        VK_FORMAT_B8G8R8_SRGB = 36,
        /// <summary><code>VK_FORMAT_R8G8B8A8_UNORM</code> specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit B component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_UNORM = 37,
        /// <summary><code>VK_FORMAT_R8G8B8A8_SNORM</code> specifies a four-component, 32-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_SNORM = 38,
        /// <summary><code>VK_FORMAT_R8G8B8A8_USCALED</code> specifies a four-component, 32-bit
        /// unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_USCALED = 39,
        /// <summary><code>VK_FORMAT_R8G8B8A8_SSCALED</code> specifies a four-component, 32-bit
        /// signed scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_SSCALED = 40,
        /// <summary><code>VK_FORMAT_R8G8B8A8_UINT</code> specifies a four-component, 32-bit
        /// unsigned integer format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit B component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_UINT = 41,
        /// <summary><code>VK_FORMAT_R8G8B8A8_SINT</code> specifies a four-component, 32-bit signed
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_SINT = 42,
        /// <summary><code>VK_FORMAT_R8G8B8A8_SRGB</code> specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit R component stored with
        /// sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.</summary>
        VK_FORMAT_R8G8B8A8_SRGB = 43,
        /// <summary><code>VK_FORMAT_B8G8R8A8_UNORM</code> specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit R component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_UNORM = 44,
        /// <summary><code>VK_FORMAT_B8G8R8A8_SNORM</code> specifies a four-component, 32-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_SNORM = 45,
        /// <summary><code>VK_FORMAT_B8G8R8A8_USCALED</code> specifies a four-component, 32-bit
        /// unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_USCALED = 46,
        /// <summary><code>VK_FORMAT_B8G8R8A8_SSCALED</code> specifies a four-component, 32-bit
        /// signed scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_SSCALED = 47,
        /// <summary><code>VK_FORMAT_B8G8R8A8_UINT</code> specifies a four-component, 32-bit
        /// unsigned integer format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit R component in byte 2, and an
        /// 8-bit A component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_UINT = 48,
        /// <summary><code>VK_FORMAT_B8G8R8A8_SINT</code> specifies a four-component, 32-bit signed
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_SINT = 49,
        /// <summary><code>VK_FORMAT_B8G8R8A8_SRGB</code> specifies a four-component, 32-bit
        /// unsigned normalized format that has an 8-bit B component stored with
        /// sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.</summary>
        VK_FORMAT_B8G8R8A8_SRGB = 50,
        /// <summary><code>VK_FORMAT_A8B8G8R8_UNORM_PACK32</code> specifies a four-component, 32-bit
        /// packed unsigned normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_UNORM_PACK32 = 51,
        /// <summary><code>VK_FORMAT_A8B8G8R8_SNORM_PACK32</code> specifies a four-component, 32-bit
        /// packed signed normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_SNORM_PACK32 = 52,
        /// <summary><code>VK_FORMAT_A8B8G8R8_USCALED_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned scaled integer format that has an 8-bit A
        /// component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit
        /// G component in bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_USCALED_PACK32 = 53,
        /// <summary><code>VK_FORMAT_A8B8G8R8_SSCALED_PACK32</code> specifies a four-component,
        /// 32-bit packed signed scaled integer format that has an 8-bit A component
        /// in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_SSCALED_PACK32 = 54,
        /// <summary><code>VK_FORMAT_A8B8G8R8_UINT_PACK32</code> specifies a four-component, 32-bit
        /// packed unsigned integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_UINT_PACK32 = 55,
        /// <summary><code>VK_FORMAT_A8B8G8R8_SINT_PACK32</code> specifies a four-component, 32-bit
        /// packed signed integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in
        /// bits 8..15, and an 8-bit R component in bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_SINT_PACK32 = 56,
        /// <summary><code>VK_FORMAT_A8B8G8R8_SRGB_PACK32</code> specifies a four-component, 32-bit
        /// packed unsigned normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component stored with sRGB nonlinear encoding in bits
        /// 16..23, an 8-bit G component stored with sRGB nonlinear encoding in bits
        /// 8..15, and an 8-bit R component stored with sRGB nonlinear encoding in
        /// bits 0..7.</summary>
        VK_FORMAT_A8B8G8R8_SRGB_PACK32 = 57,
        /// <summary><code>VK_FORMAT_A2R10G10B10_UNORM_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        VK_FORMAT_A2R10G10B10_UNORM_PACK32 = 58,
        /// <summary><code>VK_FORMAT_A2R10G10B10_SNORM_PACK32</code> specifies a four-component,
        /// 32-bit packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        VK_FORMAT_A2R10G10B10_SNORM_PACK32 = 59,
        /// <summary><code>VK_FORMAT_A2R10G10B10_USCALED_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit
        /// G component in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        VK_FORMAT_A2R10G10B10_USCALED_PACK32 = 60,
        /// <summary><code>VK_FORMAT_A2R10G10B10_SSCALED_PACK32</code> specifies a four-component,
        /// 32-bit packed signed scaled integer format that has a 2-bit A component
        /// in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        VK_FORMAT_A2R10G10B10_SSCALED_PACK32 = 61,
        /// <summary><code>VK_FORMAT_A2R10G10B10_UINT_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned integer format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        VK_FORMAT_A2R10G10B10_UINT_PACK32 = 62,
        /// <summary><code>VK_FORMAT_A2R10G10B10_SINT_PACK32</code> specifies a four-component,
        /// 32-bit packed signed integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in
        /// bits 10..19, and a 10-bit B component in bits 0..9.</summary>
        VK_FORMAT_A2R10G10B10_SINT_PACK32 = 63,
        /// <summary><code>VK_FORMAT_A2B10G10R10_UNORM_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        VK_FORMAT_A2B10G10R10_UNORM_PACK32 = 64,
        /// <summary><code>VK_FORMAT_A2B10G10R10_SNORM_PACK32</code> specifies a four-component,
        /// 32-bit packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        VK_FORMAT_A2B10G10R10_SNORM_PACK32 = 65,
        /// <summary><code>VK_FORMAT_A2B10G10R10_USCALED_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit
        /// G component in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        VK_FORMAT_A2B10G10R10_USCALED_PACK32 = 66,
        /// <summary><code>VK_FORMAT_A2B10G10R10_SSCALED_PACK32</code> specifies a four-component,
        /// 32-bit packed signed scaled integer format that has a 2-bit A component
        /// in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        VK_FORMAT_A2B10G10R10_SSCALED_PACK32 = 67,
        /// <summary><code>VK_FORMAT_A2B10G10R10_UINT_PACK32</code> specifies a four-component,
        /// 32-bit packed unsigned integer format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        VK_FORMAT_A2B10G10R10_UINT_PACK32 = 68,
        /// <summary><code>VK_FORMAT_A2B10G10R10_SINT_PACK32</code> specifies a four-component,
        /// 32-bit packed signed integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in
        /// bits 10..19, and a 10-bit R component in bits 0..9.</summary>
        VK_FORMAT_A2B10G10R10_SINT_PACK32 = 69,
        /// <summary><code>VK_FORMAT_R16_UNORM</code> specifies a one-component, 16-bit unsigned
        /// normalized format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_UNORM = 70,
        /// <summary><code>VK_FORMAT_R16_SNORM</code> specifies a one-component, 16-bit signed
        /// normalized format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_SNORM = 71,
        /// <summary><code>VK_FORMAT_R16_USCALED</code> specifies a one-component, 16-bit unsigned
        /// scaled integer format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_USCALED = 72,
        /// <summary><code>VK_FORMAT_R16_SSCALED</code> specifies a one-component, 16-bit signed
        /// scaled integer format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_SSCALED = 73,
        /// <summary><code>VK_FORMAT_R16_UINT</code> specifies a one-component, 16-bit unsigned
        /// integer format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_UINT = 74,
        /// <summary><code>VK_FORMAT_R16_SINT</code> specifies a one-component, 16-bit signed
        /// integer format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_SINT = 75,
        /// <summary><code>VK_FORMAT_R16_SFLOAT</code> specifies a one-component, 16-bit signed
        /// floating-point format that has a single 16-bit R component.</summary>
        VK_FORMAT_R16_SFLOAT = 76,
        /// <summary><code>VK_FORMAT_R16G16_UNORM</code> specifies a two-component, 32-bit unsigned
        /// normalized format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_UNORM = 77,
        /// <summary><code>VK_FORMAT_R16G16_SNORM</code> specifies a two-component, 32-bit signed
        /// normalized format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_SNORM = 78,
        /// <summary><code>VK_FORMAT_R16G16_USCALED</code> specifies a two-component, 32-bit
        /// unsigned scaled integer format that has a 16-bit R component in bytes
        /// 0..1, and a 16-bit G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_USCALED = 79,
        /// <summary><code>VK_FORMAT_R16G16_SSCALED</code> specifies a two-component, 32-bit signed
        /// scaled integer format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_SSCALED = 80,
        /// <summary><code>VK_FORMAT_R16G16_UINT</code> specifies a two-component, 32-bit unsigned
        /// integer format that has a 16-bit R component in bytes 0..1, and a 16-bit
        /// G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_UINT = 81,
        /// <summary><code>VK_FORMAT_R16G16_SINT</code> specifies a two-component, 32-bit signed
        /// integer format that has a 16-bit R component in bytes 0..1, and a 16-bit
        /// G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_SINT = 82,
        /// <summary><code>VK_FORMAT_R16G16_SFLOAT</code> specifies a two-component, 32-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.</summary>
        VK_FORMAT_R16G16_SFLOAT = 83,
        /// <summary><code>VK_FORMAT_R16G16B16_UNORM</code> specifies a three-component, 48-bit
        /// unsigned normalized format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        VK_FORMAT_R16G16B16_UNORM = 84,
        /// <summary><code>VK_FORMAT_R16G16B16_SNORM</code> specifies a three-component, 48-bit
        /// signed normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        VK_FORMAT_R16G16B16_SNORM = 85,
        /// <summary><code>VK_FORMAT_R16G16B16_USCALED</code> specifies a three-component, 48-bit
        /// unsigned scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.</summary>
        VK_FORMAT_R16G16B16_USCALED = 86,
        /// <summary><code>VK_FORMAT_R16G16B16_SSCALED</code> specifies a three-component, 48-bit
        /// signed scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.</summary>
        VK_FORMAT_R16G16B16_SSCALED = 87,
        /// <summary><code>VK_FORMAT_R16G16B16_UINT</code> specifies a three-component, 48-bit
        /// unsigned integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        VK_FORMAT_R16G16B16_UINT = 88,
        /// <summary><code>VK_FORMAT_R16G16B16_SINT</code> specifies a three-component, 48-bit
        /// signed integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.</summary>
        VK_FORMAT_R16G16B16_SINT = 89,
        /// <summary><code>VK_FORMAT_R16G16B16_SFLOAT</code> specifies a three-component, 48-bit
        /// signed floating-point format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.</summary>
        VK_FORMAT_R16G16B16_SFLOAT = 90,
        /// <summary><code>VK_FORMAT_R16G16B16A16_UNORM</code> specifies a four-component, 64-bit
        /// unsigned normalized format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_UNORM = 91,
        /// <summary><code>VK_FORMAT_R16G16B16A16_SNORM</code> specifies a four-component, 64-bit
        /// signed normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_SNORM = 92,
        /// <summary><code>VK_FORMAT_R16G16B16A16_USCALED</code> specifies a four-component, 64-bit
        /// unsigned scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_USCALED = 93,
        /// <summary><code>VK_FORMAT_R16G16B16A16_SSCALED</code> specifies a four-component, 64-bit
        /// signed scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_SSCALED = 94,
        /// <summary><code>VK_FORMAT_R16G16B16A16_UINT</code> specifies a four-component, 64-bit
        /// unsigned integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_UINT = 95,
        /// <summary><code>VK_FORMAT_R16G16B16A16_SINT</code> specifies a four-component, 64-bit
        /// signed integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5,
        /// and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_SINT = 96,
        /// <summary><code>VK_FORMAT_R16G16B16A16_SFLOAT</code> specifies a four-component, 64-bit
        /// signed floating-point format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.</summary>
        VK_FORMAT_R16G16B16A16_SFLOAT = 97,
        /// <summary><code>VK_FORMAT_R32_UINT</code> specifies a one-component, 32-bit unsigned
        /// integer format that has a single 32-bit R component.</summary>
        VK_FORMAT_R32_UINT = 98,
        /// <summary><code>VK_FORMAT_R32_SINT</code> specifies a one-component, 32-bit signed
        /// integer format that has a single 32-bit R component.</summary>
        VK_FORMAT_R32_SINT = 99,
        /// <summary><code>VK_FORMAT_R32_SFLOAT</code> specifies a one-component, 32-bit signed
        /// floating-point format that has a single 32-bit R component.</summary>
        VK_FORMAT_R32_SFLOAT = 100,
        /// <summary><code>VK_FORMAT_R32G32_UINT</code> specifies a two-component, 64-bit unsigned
        /// integer format that has a 32-bit R component in bytes 0..3, and a 32-bit
        /// G component in bytes 4..7.</summary>
        VK_FORMAT_R32G32_UINT = 101,
        /// <summary><code>VK_FORMAT_R32G32_SINT</code> specifies a two-component, 64-bit signed
        /// integer format that has a 32-bit R component in bytes 0..3, and a 32-bit
        /// G component in bytes 4..7.</summary>
        VK_FORMAT_R32G32_SINT = 102,
        /// <summary><code>VK_FORMAT_R32G32_SFLOAT</code> specifies a two-component, 64-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3, and a
        /// 32-bit G component in bytes 4..7.</summary>
        VK_FORMAT_R32G32_SFLOAT = 103,
        /// <summary><code>VK_FORMAT_R32G32B32_UINT</code> specifies a three-component, 96-bit
        /// unsigned integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.</summary>
        VK_FORMAT_R32G32B32_UINT = 104,
        /// <summary><code>VK_FORMAT_R32G32B32_SINT</code> specifies a three-component, 96-bit
        /// signed integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.</summary>
        VK_FORMAT_R32G32B32_SINT = 105,
        /// <summary><code>VK_FORMAT_R32G32B32_SFLOAT</code> specifies a three-component, 96-bit
        /// signed floating-point format that has a 32-bit R component in bytes
        /// 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in
        /// bytes 8..11.</summary>
        VK_FORMAT_R32G32B32_SFLOAT = 106,
        /// <summary><code>VK_FORMAT_R32G32B32A32_UINT</code> specifies a four-component, 128-bit
        /// unsigned integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11,
        /// and a 32-bit A component in bytes 12..15.</summary>
        VK_FORMAT_R32G32B32A32_UINT = 107,
        /// <summary><code>VK_FORMAT_R32G32B32A32_SINT</code> specifies a four-component, 128-bit
        /// signed integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11,
        /// and a 32-bit A component in bytes 12..15.</summary>
        VK_FORMAT_R32G32B32A32_SINT = 108,
        /// <summary><code>VK_FORMAT_R32G32B32A32_SFLOAT</code> specifies a four-component, 128-bit
        /// signed floating-point format that has a 32-bit R component in bytes
        /// 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes
        /// 8..11, and a 32-bit A component in bytes 12..15.</summary>
        VK_FORMAT_R32G32B32A32_SFLOAT = 109,
        /// <summary><code>VK_FORMAT_R64_UINT</code> specifies a one-component, 64-bit unsigned
        /// integer format that has a single 64-bit R component.</summary>
        VK_FORMAT_R64_UINT = 110,
        /// <summary><code>VK_FORMAT_R64_SINT</code> specifies a one-component, 64-bit signed
        /// integer format that has a single 64-bit R component.</summary>
        VK_FORMAT_R64_SINT = 111,
        /// <summary><code>VK_FORMAT_R64_SFLOAT</code> specifies a one-component, 64-bit signed
        /// floating-point format that has a single 64-bit R component.</summary>
        VK_FORMAT_R64_SFLOAT = 112,
        /// <summary><code>VK_FORMAT_R64G64_UINT</code> specifies a two-component, 128-bit unsigned
        /// integer format that has a 64-bit R component in bytes 0..7, and a 64-bit
        /// G component in bytes 8..15.</summary>
        VK_FORMAT_R64G64_UINT = 113,
        /// <summary><code>VK_FORMAT_R64G64_SINT</code> specifies a two-component, 128-bit signed
        /// integer format that has a 64-bit R component in bytes 0..7, and a 64-bit
        /// G component in bytes 8..15.</summary>
        VK_FORMAT_R64G64_SINT = 114,
        /// <summary><code>VK_FORMAT_R64G64_SFLOAT</code> specifies a two-component, 128-bit signed
        /// floating-point format that has a 64-bit R component in bytes 0..7, and a
        /// 64-bit G component in bytes 8..15.</summary>
        VK_FORMAT_R64G64_SFLOAT = 115,
        /// <summary><code>VK_FORMAT_R64G64B64_UINT</code> specifies a three-component, 192-bit
        /// unsigned integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in bytes
        /// 16..23.</summary>
        VK_FORMAT_R64G64B64_UINT = 116,
        /// <summary><code>VK_FORMAT_R64G64B64_SINT</code> specifies a three-component, 192-bit
        /// signed integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in bytes
        /// 16..23.</summary>
        VK_FORMAT_R64G64B64_SINT = 117,
        /// <summary><code>VK_FORMAT_R64G64B64_SFLOAT</code> specifies a three-component, 192-bit
        /// signed floating-point format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in
        /// bytes 16..23.</summary>
        VK_FORMAT_R64G64B64_SFLOAT = 118,
        /// <summary><code>VK_FORMAT_R64G64B64A64_UINT</code> specifies a four-component, 256-bit
        /// unsigned integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23,
        /// and a 64-bit A component in bytes 24..31.</summary>
        VK_FORMAT_R64G64B64A64_UINT = 119,
        /// <summary><code>VK_FORMAT_R64G64B64A64_SINT</code> specifies a four-component, 256-bit
        /// signed integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23,
        /// and a 64-bit A component in bytes 24..31.</summary>
        VK_FORMAT_R64G64B64A64_SINT = 120,
        /// <summary><code>VK_FORMAT_R64G64B64A64_SFLOAT</code> specifies a four-component, 256-bit
        /// signed floating-point format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes
        /// 16..23, and a 64-bit A component in bytes 24..31.</summary>
        VK_FORMAT_R64G64B64A64_SFLOAT = 121,
        /// <summary><code>VK_FORMAT_B10G11R11_UFLOAT_PACK32</code> specifies a three-component,
        /// 32-bit packed unsigned floating-point format that has a 10-bit B
        /// component in bits 22..31, an 11-bit G component in bits 11..21, an
        /// 11-bit R component in bits 0..10.
        /// See <a href="vkspec.html#fundamentals-fp10" class="bare">html/vkspec.html#fundamentals-fp10</a> and <a href="vkspec.html#fundamentals-fp11" class="bare">html/vkspec.html#fundamentals-fp11</a>.</summary>
        VK_FORMAT_B10G11R11_UFLOAT_PACK32 = 122,
        /// <summary><code>VK_FORMAT_E5B9G9R9_UFLOAT_PACK32</code> specifies a three-component,
        /// 32-bit packed unsigned floating-point format that has a 5-bit shared
        /// exponent in bits 27..31, a 9-bit B component mantissa in bits 18..26, a
        /// 9-bit G component mantissa in bits 9..17, and a 9-bit R component
        /// mantissa in bits 0..8.</summary>
        VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 = 123,
        /// <summary><code>VK_FORMAT_D16_UNORM</code> specifies a one-component, 16-bit unsigned
        /// normalized format that has a single 16-bit depth component.</summary>
        VK_FORMAT_D16_UNORM = 124,
        /// <summary><code>VK_FORMAT_X8_D24_UNORM_PACK32</code> specifies a two-component, 32-bit
        /// format that has 24 unsigned normalized bits in the depth component and,
        /// optionally:, 8 bits that are unused.</summary>
        VK_FORMAT_X8_D24_UNORM_PACK32 = 125,
        /// <summary><code>VK_FORMAT_D32_SFLOAT</code> specifies a one-component, 32-bit signed
        /// floating-point format that has 32-bits in the depth component.</summary>
        VK_FORMAT_D32_SFLOAT = 126,
        /// <summary><code>VK_FORMAT_S8_UINT</code> specifies a one-component, 8-bit unsigned
        /// integer format that has 8-bits in the stencil component.</summary>
        VK_FORMAT_S8_UINT = 127,
        /// <summary><code>VK_FORMAT_D16_UNORM_S8_UINT</code> specifies a two-component, 24-bit
        /// format that has 16 unsigned normalized bits in the depth component and 8
        /// unsigned integer bits in the stencil component.</summary>
        VK_FORMAT_D16_UNORM_S8_UINT = 128,
        /// <summary><code>VK_FORMAT_D24_UNORM_S8_UINT</code> specifies a two-component, 32-bit
        /// packed format that has 8 unsigned integer bits in the stencil component,
        /// and 24 unsigned normalized bits in the depth component.</summary>
        VK_FORMAT_D24_UNORM_S8_UINT = 129,
        /// <summary><code>VK_FORMAT_D32_SFLOAT_S8_UINT</code> specifies a two-component format that
        /// has 32 signed float bits in the depth component and 8 unsigned integer
        /// bits in the stencil component.
        /// There are optionally: 24-bits that are unused.</summary>
        VK_FORMAT_D32_SFLOAT_S8_UINT = 130,
        /// <summary><code>VK_FORMAT_BC1_RGB_UNORM_BLOCK</code> specifies a three-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data.
        /// This format has no alpha and is considered opaque.</summary>
        VK_FORMAT_BC1_RGB_UNORM_BLOCK = 131,
        /// <summary><code>VK_FORMAT_BC1_RGB_SRGB_BLOCK</code> specifies a three-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding.
        /// This format has no alpha and is considered opaque.</summary>
        VK_FORMAT_BC1_RGB_SRGB_BLOCK = 132,
        /// <summary><code>VK_FORMAT_BC1_RGBA_UNORM_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data, and
        /// provides 1 bit of alpha.</summary>
        VK_FORMAT_BC1_RGBA_UNORM_BLOCK = 133,
        /// <summary><code>VK_FORMAT_BC1_RGBA_SRGB_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding, and provides 1 bit of alpha.</summary>
        VK_FORMAT_BC1_RGBA_SRGB_BLOCK = 134,
        /// <summary><code>VK_FORMAT_BC2_UNORM_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values.</summary>
        VK_FORMAT_BC2_UNORM_BLOCK = 135,
        /// <summary><code>VK_FORMAT_BC2_SRGB_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values with sRGB nonlinear encoding.</summary>
        VK_FORMAT_BC2_SRGB_BLOCK = 136,
        /// <summary><code>VK_FORMAT_BC3_UNORM_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values.</summary>
        VK_FORMAT_BC3_UNORM_BLOCK = 137,
        /// <summary><code>VK_FORMAT_BC3_SRGB_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RGBA texel data
        /// with the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values with sRGB nonlinear encoding.</summary>
        VK_FORMAT_BC3_SRGB_BLOCK = 138,
        /// <summary><code>VK_FORMAT_BC4_UNORM_BLOCK</code> specifies a one-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized red texel data.</summary>
        VK_FORMAT_BC4_UNORM_BLOCK = 139,
        /// <summary><code>VK_FORMAT_BC4_SNORM_BLOCK</code> specifies a one-component,
        /// block-compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of signed normalized red texel data.</summary>
        VK_FORMAT_BC4_SNORM_BLOCK = 140,
        /// <summary><code>VK_FORMAT_BC5_UNORM_BLOCK</code> specifies a two-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RG texel data with
        /// the first 64 bits encoding red values followed by 64 bits encoding green
        /// values.</summary>
        VK_FORMAT_BC5_UNORM_BLOCK = 141,
        /// <summary><code>VK_FORMAT_BC5_SNORM_BLOCK</code> specifies a two-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of signed normalized RG texel data with
        /// the first 64 bits encoding red values followed by 64 bits encoding green
        /// values.</summary>
        VK_FORMAT_BC5_SNORM_BLOCK = 142,
        /// <summary><code>VK_FORMAT_BC6H_UFLOAT_BLOCK</code> specifies a three-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned floating-point RGB texel data.</summary>
        VK_FORMAT_BC6H_UFLOAT_BLOCK = 143,
        /// <summary><code>VK_FORMAT_BC6H_SFLOAT_BLOCK</code> specifies a three-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of signed floating-point RGB texel data.</summary>
        VK_FORMAT_BC6H_SFLOAT_BLOCK = 144,
        /// <summary><code>VK_FORMAT_BC7_UNORM_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_BC7_UNORM_BLOCK = 145,
        /// <summary><code>VK_FORMAT_BC7_SRGB_BLOCK</code> specifies a four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4×4 rectangle of unsigned normalized RGBA texel data
        /// with sRGB nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_BC7_SRGB_BLOCK = 146,
        /// <summary><code>VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK</code> specifies a three-component,
        /// ETC2 compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data.
        /// This format has no alpha and is considered opaque.</summary>
        VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK = 147,
        /// <summary><code>VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK</code> specifies a three-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes a
        /// 4×4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding.
        /// This format has no alpha and is considered opaque.</summary>
        VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK = 148,
        /// <summary><code>VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK</code> specifies a four-component,
        /// ETC2 compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data, and
        /// provides 1 bit of alpha.</summary>
        VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK = 149,
        /// <summary><code>VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK</code> specifies a four-component,
        /// ETC2 compressed format where each 64-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding, and provides 1 bit of alpha.</summary>
        VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK = 150,
        /// <summary><code>VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK</code> specifies a four-component,
        /// ETC2 compressed format where each 128-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding RGB
        /// values.</summary>
        VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK = 151,
        /// <summary><code>VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK</code> specifies a four-component,
        /// ETC2 compressed format where each 128-bit compressed texel block encodes
        /// a 4×4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding RGB
        /// values with sRGB nonlinear encoding applied.</summary>
        VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK = 152,
        /// <summary><code>VK_FORMAT_EAC_R11_UNORM_BLOCK</code> specifies a one-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes a
        /// 4×4 rectangle of unsigned normalized red texel data.</summary>
        VK_FORMAT_EAC_R11_UNORM_BLOCK = 153,
        /// <summary><code>VK_FORMAT_EAC_R11_SNORM_BLOCK</code> specifies a one-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes a
        /// 4×4 rectangle of signed normalized red texel data.</summary>
        VK_FORMAT_EAC_R11_SNORM_BLOCK = 154,
        /// <summary><code>VK_FORMAT_EAC_R11G11_UNORM_BLOCK</code> specifies a two-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4×4 rectangle of unsigned normalized RG texel data with the first
        /// 64 bits encoding red values followed by 64 bits encoding green values.</summary>
        VK_FORMAT_EAC_R11G11_UNORM_BLOCK = 155,
        /// <summary><code>VK_FORMAT_EAC_R11G11_SNORM_BLOCK</code> specifies a two-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4×4 rectangle of signed normalized RG texel data with the first 64
        /// bits encoding red values followed by 64 bits encoding green values.</summary>
        VK_FORMAT_EAC_R11G11_SNORM_BLOCK = 156,
        /// <summary><code>VK_FORMAT_ASTC_4x4_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4×4 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_4x4_UNORM_BLOCK = 157,
        /// <summary><code>VK_FORMAT_ASTC_4x4_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 4×4 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_4x4_SRGB_BLOCK = 158,
        /// <summary><code>VK_FORMAT_ASTC_5x4_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5×4 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_5x4_UNORM_BLOCK = 159,
        /// <summary><code>VK_FORMAT_ASTC_5x4_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5×4 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_5x4_SRGB_BLOCK = 160,
        /// <summary><code>VK_FORMAT_ASTC_5x5_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5×5 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_5x5_UNORM_BLOCK = 161,
        /// <summary><code>VK_FORMAT_ASTC_5x5_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 5×5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_5x5_SRGB_BLOCK = 162,
        /// <summary><code>VK_FORMAT_ASTC_6x5_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6×5 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_6x5_UNORM_BLOCK = 163,
        /// <summary><code>VK_FORMAT_ASTC_6x5_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6×5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_6x5_SRGB_BLOCK = 164,
        /// <summary><code>VK_FORMAT_ASTC_6x6_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6×6 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_6x6_UNORM_BLOCK = 165,
        /// <summary><code>VK_FORMAT_ASTC_6x6_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 6×6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_6x6_SRGB_BLOCK = 166,
        /// <summary><code>VK_FORMAT_ASTC_8x5_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8×5 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_8x5_UNORM_BLOCK = 167,
        /// <summary><code>VK_FORMAT_ASTC_8x5_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8×5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_8x5_SRGB_BLOCK = 168,
        /// <summary><code>VK_FORMAT_ASTC_8x6_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8×6 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_8x6_UNORM_BLOCK = 169,
        /// <summary><code>VK_FORMAT_ASTC_8x6_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8×6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_8x6_SRGB_BLOCK = 170,
        /// <summary><code>VK_FORMAT_ASTC_8x8_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8×8 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_8x8_UNORM_BLOCK = 171,
        /// <summary><code>VK_FORMAT_ASTC_8x8_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes an
        /// 8×8 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_8x8_SRGB_BLOCK = 172,
        /// <summary><code>VK_FORMAT_ASTC_10x5_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×5 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_10x5_UNORM_BLOCK = 173,
        /// <summary><code>VK_FORMAT_ASTC_10x5_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_10x5_SRGB_BLOCK = 174,
        /// <summary><code>VK_FORMAT_ASTC_10x6_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×6 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_10x6_UNORM_BLOCK = 175,
        /// <summary><code>VK_FORMAT_ASTC_10x6_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_10x6_SRGB_BLOCK = 176,
        /// <summary><code>VK_FORMAT_ASTC_10x8_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×8 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_10x8_UNORM_BLOCK = 177,
        /// <summary><code>VK_FORMAT_ASTC_10x8_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×8 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_10x8_SRGB_BLOCK = 178,
        /// <summary><code>VK_FORMAT_ASTC_10x10_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×10 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_10x10_UNORM_BLOCK = 179,
        /// <summary><code>VK_FORMAT_ASTC_10x10_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 10×10 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_10x10_SRGB_BLOCK = 180,
        /// <summary><code>VK_FORMAT_ASTC_12x10_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12×10 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_12x10_UNORM_BLOCK = 181,
        /// <summary><code>VK_FORMAT_ASTC_12x10_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12×10 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_12x10_SRGB_BLOCK = 182,
        /// <summary><code>VK_FORMAT_ASTC_12x12_UNORM_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12×12 rectangle of unsigned normalized RGBA texel data.</summary>
        VK_FORMAT_ASTC_12x12_UNORM_BLOCK = 183,
        /// <summary><code>VK_FORMAT_ASTC_12x12_SRGB_BLOCK</code> specifies a four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes a
        /// 12×12 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.</summary>
        VK_FORMAT_ASTC_12x12_SRGB_BLOCK = 184,
        /// <summary><code>VK_FORMAT_G8B8G8R8_422_UNORM</code> specifies a four-component, 32-bit
        /// format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2×1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has an 8-bit G component for the even <em>i</em> coordinate in byte
        /// 0, an 8-bit B component in byte 1, an 8-bit G component for the odd <em>i</em>
        /// coordinate in byte 2, and an 8-bit R component in byte 3.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_G8B8G8R8_422_UNORM = 1000156000,
        /// <summary><code>VK_FORMAT_B8G8R8G8_422_UNORM</code> specifies a four-component, 32-bit
        /// format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2×1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has an 8-bit B component in byte 0, an 8-bit G component for
        /// the even <em>i</em> coordinate in byte 1, an 8-bit R component in byte 2, and
        /// an 8-bit G component for the odd <em>i</em> coordinate in byte 3.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_B8G8R8G8_422_UNORM = 1000156001,
        /// <summary><code>VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has an 8-bit G component in plane
        /// 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2.
        /// The horizontal and vertical dimensions of the R and B planes are halved
        /// relative to the image dimensions, and each R and B component is shared
        /// with the G components for which \(\lfloor i_G \times 0.5
        /// \rfloor = i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B
        /// = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM = 1000156002,
        /// <summary><code>VK_FORMAT_G8_B8R8_2PLANE_420_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has an 8-bit G component in plane
        /// 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B
        /// component in byte 0 and an 8-bit R component in byte 1.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G8_B8R8_2PLANE_420_UNORM = 1000156003,
        /// <summary><code>VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has an 8-bit G component in plane
        /// 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM = 1000156004,
        /// <summary><code>VK_FORMAT_G8_B8R8_2PLANE_422_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has an 8-bit G component in plane
        /// 0, and a two-component, 16-bit BR plane 1 consisting of an 8-bit B
        /// component in byte 0 and an 8-bit R component in byte 1.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G8_B8R8_2PLANE_422_UNORM = 1000156005,
        /// <summary><code>VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has an 8-bit G component in plane
        /// 0, an 8-bit B component in plane 1, and an 8-bit R component in plane 2.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.</summary>
        VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM = 1000156006,
        /// <summary><code>VK_FORMAT_R10X6_UNORM_PACK16</code> specifies a one-component, 16-bit
        /// unsigned normalized format that has a single 10-bit R component in the
        /// top 10 bits of a 16-bit word, with the bottom 6 bits set to 0.</summary>
        VK_FORMAT_R10X6_UNORM_PACK16 = 1000156007,
        /// <summary><code>VK_FORMAT_R10X6G10X6_UNORM_2PACK16</code> specifies a two-component,
        /// 32-bit unsigned normalized format that has a 10-bit R component in the
        /// top 10 bits of the word in bytes 0..1, and a 10-bit G component in the
        /// top 10 bits of the word in bytes 2..3, with the bottom 6 bits of each
        /// word set to 0.</summary>
        VK_FORMAT_R10X6G10X6_UNORM_2PACK16 = 1000156008,
        /// <summary><code>VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16</code> specifies a
        /// four-component, 64-bit unsigned normalized format that has a 10-bit R
        /// component in the top 10 bits of the word in bytes 0..1, a 10-bit G
        /// component in the top 10 bits of the word in bytes 2..3, a 10-bit B
        /// component in the top 10 bits of the word in bytes 4..5, and a 10-bit A
        /// component in the top 10 bits of the word in bytes 6..7, with the bottom
        /// 6 bits of each word set to 0.</summary>
        VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 = 1000156009,
        /// <summary><code>VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16</code> specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2×1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 10-bit G component for the even <em>i</em> coordinate in the
        /// top 10 bits of the word in bytes 0..1, a 10-bit B component in the top
        /// 10 bits of the word in bytes 2..3, a 10-bit G component for the odd <em>i</em>
        /// coordinate in the top 10 bits of the word in bytes 4..5, and a 10-bit R
        /// component in the top 10 bits of the word in bytes 6..7, with the bottom
        /// 6 bits of each word set to 0.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 = 1000156010,
        /// <summary><code>VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16</code> specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2×1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 10-bit B component in the top 10 bits of the word in
        /// bytes 0..1, a 10-bit G component for the even <em>i</em> coordinate in the top
        /// 10 bits of the word in bytes 2..3, a 10-bit R component in the top 10
        /// bits of the word in bytes 4..5, and a 10-bit G component for the odd <em>i</em>
        /// coordinate in the top 10 bits of the word in bytes 6..7, with the bottom
        /// 6 bits of each word set to 0.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 = 1000156011,
        /// <summary><code>VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 10-bit G component
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
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 = 1000156012,
        /// <summary><code>VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits
        /// of the word in bytes 0..1, and a 10-bit R component in the top 10 bits
        /// of the word in bytes 2..3, the bottom 6 bits of each word set to 0.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 = 1000156013,
        /// <summary><code>VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component
        /// in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R
        /// component in the top 10 bits of each 16-bit word of plane 2, with the
        /// bottom 6 bits of each word set to 0.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 = 1000156014,
        /// <summary><code>VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 10-bit B component in the top 10 bits
        /// of the word in bytes 0..1, and a 10-bit R component in the top 10 bits
        /// of the word in bytes 2..3, the bottom 6 bits of each word set to 0.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 = 1000156015,
        /// <summary><code>VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 10-bit G component
        /// in the top 10 bits of each 16-bit word of plane 0, a 10-bit B component
        /// in the top 10 bits of each 16-bit word of plane 1, and a 10-bit R
        /// component in the top 10 bits of each 16-bit word of plane 2, with the
        /// bottom 6 bits of each word set to 0.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.</summary>
        VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 = 1000156016,
        /// <summary><code>VK_FORMAT_R12X4_UNORM_PACK16</code> specifies a one-component, 16-bit
        /// unsigned normalized format that has a single 12-bit R component in the
        /// top 12 bits of a 16-bit word, with the bottom 4 bits set to 0.</summary>
        VK_FORMAT_R12X4_UNORM_PACK16 = 1000156017,
        /// <summary><code>VK_FORMAT_R12X4G12X4_UNORM_2PACK16</code> specifies a two-component,
        /// 32-bit unsigned normalized format that has a 12-bit R component in the
        /// top 12 bits of the word in bytes 0..1, and a 12-bit G component in the
        /// top 12 bits of the word in bytes 2..3, with the bottom 4 bits of each
        /// word set to 0.</summary>
        VK_FORMAT_R12X4G12X4_UNORM_2PACK16 = 1000156018,
        /// <summary><code>VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16</code> specifies a
        /// four-component, 64-bit unsigned normalized format that has a 12-bit R
        /// component in the top 12 bits of the word in bytes 0..1, a 12-bit G
        /// component in the top 12 bits of the word in bytes 2..3, a 12-bit B
        /// component in the top 12 bits of the word in bytes 4..5, and a 12-bit A
        /// component in the top 12 bits of the word in bytes 6..7, with the bottom
        /// 4 bits of each word set to 0.</summary>
        VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 = 1000156019,
        /// <summary><code>VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16</code> specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2×1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 12-bit G component for the even <em>i</em> coordinate in the
        /// top 12 bits of the word in bytes 0..1, a 12-bit B component in the top
        /// 12 bits of the word in bytes 2..3, a 12-bit G component for the odd <em>i</em>
        /// coordinate in the top 12 bits of the word in bytes 4..5, and a 12-bit R
        /// component in the top 12 bits of the word in bytes 6..7, with the bottom
        /// 4 bits of each word set to 0.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 = 1000156020,
        /// <summary><code>VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16</code> specifies a
        /// four-component, 64-bit format containing a pair of G components, an R
        /// component, and a B component, collectively encoding a 2×1
        /// rectangle of unsigned normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 12-bit B component in the top 12 bits of the word in
        /// bytes 0..1, a 12-bit G component for the even <em>i</em> coordinate in the top
        /// 12 bits of the word in bytes 2..3, a 12-bit R component in the top 12
        /// bits of the word in bytes 4..5, and a 12-bit G component for the odd <em>i</em>
        /// coordinate in the top 12 bits of the word in bytes 6..7, with the bottom
        /// 4 bits of each word set to 0.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 = 1000156021,
        /// <summary><code>VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 12-bit G component
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
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 = 1000156022,
        /// <summary><code>VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits
        /// of the word in bytes 0..1, and a 12-bit R component in the top 12 bits
        /// of the word in bytes 2..3, the bottom 4 bits of each word set to 0.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 = 1000156023,
        /// <summary><code>VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component
        /// in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R
        /// component in the top 12 bits of each 16-bit word of plane 2, with the
        /// bottom 4 bits of each word set to 0.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 = 1000156024,
        /// <summary><code>VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, and a two-component,
        /// 32-bit BR plane 1 consisting of a 12-bit B component in the top 12 bits
        /// of the word in bytes 0..1, and a 12-bit R component in the top 12 bits
        /// of the word in bytes 2..3, the bottom 4 bits of each word set to 0.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 = 1000156025,
        /// <summary><code>VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16</code> specifies an
        /// unsigned normalized <em>multi-planar format</em> that has a 12-bit G component
        /// in the top 12 bits of each 16-bit word of plane 0, a 12-bit B component
        /// in the top 12 bits of each 16-bit word of plane 1, and a 12-bit R
        /// component in the top 12 bits of each 16-bit word of plane 2, with the
        /// bottom 4 bits of each word set to 0.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.</summary>
        VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 = 1000156026,
        /// <summary><code>VK_FORMAT_G16B16G16R16_422_UNORM</code> specifies a four-component,
        /// 64-bit format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2×1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 16-bit G component for the even <em>i</em> coordinate in the
        /// word in bytes 0..1, a 16-bit B component in the word in bytes 2..3, a
        /// 16-bit G component for the odd <em>i</em> coordinate in the word in bytes 4..5,
        /// and a 16-bit R component in the word in bytes 6..7.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_G16B16G16R16_422_UNORM = 1000156027,
        /// <summary><code>VK_FORMAT_B16G16R16G16_422_UNORM</code> specifies a four-component,
        /// 64-bit format containing a pair of G components, an R component, and a B
        /// component, collectively encoding a 2×1 rectangle of unsigned
        /// normalized RGB texel data.
        /// One G value is present at each <em>i</em> coordinate, with the B and R values
        /// shared across both G values and thus recorded at half the horizontal
        /// resolution of the image.
        /// This format has a 16-bit B component in the word in bytes 0..1, a 16-bit
        /// G component for the even <em>i</em> coordinate in the word in bytes 2..3, a
        /// 16-bit R component in the word in bytes 4..5, and a 16-bit G component
        /// for the odd <em>i</em> coordinate in the word in bytes 6..7.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.
        /// For the purposes of the constraints on copy extents, this format is
        /// treated as a compressed format with a 2×1 compressed texel block.</summary>
        VK_FORMAT_B16G16R16G16_422_UNORM = 1000156028,
        /// <summary><code>VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has a 16-bit G component in each
        /// 16-bit word of plane 0, a 16-bit B component in each 16-bit word of
        /// plane 1, and a 16-bit R component in each 16-bit word of plane 2.
        /// The horizontal and vertical dimensions of the R and B planes are halved
        /// relative to the image dimensions, and each R and B component is shared
        /// with the G components for which \(\lfloor i_G \times 0.5
        /// \rfloor = i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B
        /// = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM = 1000156029,
        /// <summary><code>VK_FORMAT_G16_B16R16_2PLANE_420_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has a 16-bit G component in each
        /// 16-bit word of plane 0, and a two-component, 32-bit BR plane 1
        /// consisting of a 16-bit B component in the word in bytes 0..1, and a
        /// 16-bit R component in the word in bytes 2..3.
        /// The horizontal and vertical dimensions of the BR plane is halved
        /// relative to the image dimensions, and each R and B value is shared with
        /// the G components for which \(\lfloor i_G \times 0.5 \rfloor =
        /// i_B = i_R\) and \(\lfloor j_G \times 0.5 \rfloor = j_B = j_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width and height that is a
        /// multiple of two.</summary>
        VK_FORMAT_G16_B16R16_2PLANE_420_UNORM = 1000156030,
        /// <summary><code>VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has a 16-bit G component in each
        /// 16-bit word of plane 0, a 16-bit B component in each 16-bit word of
        /// plane 1, and a 16-bit R component in each 16-bit word of plane 2.
        /// The horizontal dimension of the R and B plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM = 1000156031,
        /// <summary><code>VK_FORMAT_G16_B16R16_2PLANE_422_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has a 16-bit G component in each
        /// 16-bit word of plane 0, and a two-component, 32-bit BR plane 1
        /// consisting of a 16-bit B component in the word in bytes 0..1, and a
        /// 16-bit R component in the word in bytes 2..3.
        /// The horizontal dimensions of the BR plane is halved relative to the
        /// image dimensions, and each R and B value is shared with the G components
        /// for which \(\lfloor i_G \times 0.5 \rfloor = i_B = i_R\).
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the BR plane.
        /// Images in this format <strong class="purple">must</strong> be defined with a width that is a multiple
        /// of two.</summary>
        VK_FORMAT_G16_B16R16_2PLANE_422_UNORM = 1000156032,
        /// <summary><code>VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM</code> specifies an unsigned
        /// normalized <em>multi-planar format</em> that has a 16-bit G component in each
        /// 16-bit word of plane 0, a 16-bit B component in each 16-bit word of
        /// plane 1, and a 16-bit R component in each 16-bit word of plane 2.
        /// Each plane has the same dimensions and each R, G and B component
        /// contributes to a single texel.
        /// The location of each plane when this image is in linear layout can be
        /// determined via <a href="#vkGetImageSubresourceLayout">vkGetImageSubresourceLayout</a>, using
        /// <code>VK_IMAGE_ASPECT_PLANE_0_BIT</code> for the G plane,
        /// <code>VK_IMAGE_ASPECT_PLANE_1_BIT</code> for the B plane, and
        /// <code>VK_IMAGE_ASPECT_PLANE_2_BIT</code> for the R plane.</summary>
        VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM = 1000156033,
        VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG = 1000054000,
        VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG = 1000054001,
        VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG = 1000054002,
        VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG = 1000054003,
        VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG = 1000054004,
        VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG = 1000054005,
        VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG = 1000054006,
        VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG = 1000054007,
        VK_FORMAT_G8B8G8R8_422_UNORM_KHR = VK_FORMAT_G8B8G8R8_422_UNORM,
        VK_FORMAT_B8G8R8G8_422_UNORM_KHR = VK_FORMAT_B8G8R8G8_422_UNORM,
        VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM,
        VK_FORMAT_G8_B8R8_2PLANE_420_UNORM_KHR = VK_FORMAT_G8_B8R8_2PLANE_420_UNORM,
        VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM,
        VK_FORMAT_G8_B8R8_2PLANE_422_UNORM_KHR = VK_FORMAT_G8_B8R8_2PLANE_422_UNORM,
        VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM,
        VK_FORMAT_R10X6_UNORM_PACK16_KHR = VK_FORMAT_R10X6_UNORM_PACK16,
        VK_FORMAT_R10X6G10X6_UNORM_2PACK16_KHR = VK_FORMAT_R10X6G10X6_UNORM_2PACK16,
        VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR = VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16,
        VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR = VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16,
        VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR = VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16,
        VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16,
        VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16,
        VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16,
        VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16,
        VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16,
        VK_FORMAT_R12X4_UNORM_PACK16_KHR = VK_FORMAT_R12X4_UNORM_PACK16,
        VK_FORMAT_R12X4G12X4_UNORM_2PACK16_KHR = VK_FORMAT_R12X4G12X4_UNORM_2PACK16,
        VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR = VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16,
        VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR = VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16,
        VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR = VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16,
        VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16,
        VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16,
        VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16,
        VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16,
        VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16,
        VK_FORMAT_G16B16G16R16_422_UNORM_KHR = VK_FORMAT_G16B16G16R16_422_UNORM,
        VK_FORMAT_B16G16R16G16_422_UNORM_KHR = VK_FORMAT_B16G16R16G16_422_UNORM,
        VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM,
        VK_FORMAT_G16_B16R16_2PLANE_420_UNORM_KHR = VK_FORMAT_G16_B16R16_2PLANE_420_UNORM,
        VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM,
        VK_FORMAT_G16_B16R16_2PLANE_422_UNORM_KHR = VK_FORMAT_G16_B16R16_2PLANE_422_UNORM,
        VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM,
        VK_FORMAT_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 62
    /// <summary>VkFormatFeatureFlagBits - Bitmask specifying features supported by a buffer</summary>
    public enum VkFormatFeatureFlagBits {
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</code> specifies that an image view
        /// <strong class="purple">can</strong> be <a href="vkspec.html#descriptorsets-sampledimage">sampled from</a>.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = 0x00000001,
        /// <summary><code>VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT</code> specifies that an image view
        /// <strong class="purple">can</strong> be used as a <a href="vkspec.html#descriptorsets-storageimage">storage images</a>.</summary>
        VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = 0x00000002,
        /// <summary><code>VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT</code> specifies that an image
        /// view <strong class="purple">can</strong> be used as storage image that supports atomic operations.</summary>
        VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = 0x00000004,
        /// <summary><code>VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT</code> specifies that the
        /// format <strong class="purple">can</strong> be used to create a buffer view that <strong class="purple">can</strong> be bound to a
        /// <code>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</code> descriptor.</summary>
        VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = 0x00000008,
        /// <summary><code>VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT</code> specifies that the
        /// format <strong class="purple">can</strong> be used to create a buffer view that <strong class="purple">can</strong> be bound to a
        /// <code>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</code> descriptor.</summary>
        VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = 0x00000010,
        /// <summary><code>VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT</code> specifies that
        /// atomic operations are supported on
        /// <code>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</code> with this format.</summary>
        VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x00000020,
        /// <summary><code>VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT</code> specifies that the format <strong class="purple">can</strong>
        /// be used as a vertex attribute format
        /// (<code>VkVertexInputAttributeDescription</code>::<code>format</code>).</summary>
        VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = 0x00000040,
        /// <summary><code>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT</code> specifies that an image
        /// view <strong class="purple">can</strong> be used as a framebuffer color attachment and as an input
        /// attachment.</summary>
        VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = 0x00000080,
        /// <summary><code>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT</code> specifies that an
        /// image view <strong class="purple">can</strong> be used as a framebuffer color attachment that supports
        /// blending and as an input attachment.</summary>
        VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = 0x00000100,
        /// <summary><code>VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT</code> specifies that an
        /// image view <strong class="purple">can</strong> be used as a framebuffer depth/stencil attachment and as
        /// an input attachment.</summary>
        VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x00000200,
        /// <summary><code>VK_FORMAT_FEATURE_BLIT_SRC_BIT</code> specifies that an image <strong class="purple">can</strong> be
        /// used as <code>srcImage</code> for the <code>vkCmdBlitImage</code> command.</summary>
        VK_FORMAT_FEATURE_BLIT_SRC_BIT = 0x00000400,
        /// <summary><code>VK_FORMAT_FEATURE_BLIT_DST_BIT</code> specifies that an image <strong class="purple">can</strong> be
        /// used as <code>dstImage</code> for the <code>vkCmdBlitImage</code> command.</summary>
        VK_FORMAT_FEATURE_BLIT_DST_BIT = 0x00000800,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT</code> specifies that
        /// if <code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</code> is also set, an image view
        /// <strong class="purple">can</strong> be used with a sampler that has either of <code>magFilter</code> or
        /// <code>minFilter</code> set to <code>VK_FILTER_LINEAR</code>, or <code>mipmapMode</code> set
        /// to <code>VK_SAMPLER_MIPMAP_MODE_LINEAR</code>.
        /// If <code>VK_FORMAT_FEATURE_BLIT_SRC_BIT</code> is also set, an image can be
        /// used as the <code>srcImage</code> to <a href="#vkCmdBlitImage">vkCmdBlitImage</a> with a <code>filter</code>
        /// of <code>VK_FILTER_LINEAR</code>.
        /// This bit <strong class="purple">must</strong> only be exposed for formats that also support the
        /// <code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</code> or
        /// <code>VK_FORMAT_FEATURE_BLIT_SRC_BIT</code>.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 0x00001000,
        /// <summary><code>VK_FORMAT_FEATURE_TRANSFER_SRC_BIT</code> specifies that an image <strong class="purple">can</strong> be
        /// used as a source image for <a href="vkspec.html#copies">copy commands</a>.</summary>
        VK_FORMAT_FEATURE_TRANSFER_SRC_BIT = 0x00004000,
        /// <summary><code>VK_FORMAT_FEATURE_TRANSFER_DST_BIT</code> specifies that an image <strong class="purple">can</strong> be
        /// used as a destination image for <a href="vkspec.html#copies">copy commands</a> and <a href="vkspec.html#clears">clear commands</a>.</summary>
        VK_FORMAT_FEATURE_TRANSFER_DST_BIT = 0x00008000,
        /// <summary><code>VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT</code> specifies that an
        /// application <strong class="purple">can</strong> define a <a href="vkspec.html#samplers-YCbCr-conversion">sampler Y’C<sub>B</sub>C<sub>R</sub>
        /// conversion</a> using this format as a source, and that an image of this
        /// format <strong class="purple">can</strong> be used with a <code>VkSamplerYcbcrConversionCreateInfo</code><code>xChromaOffset</code> and/or <code>yChromaOffset</code> of
        /// <code>VK_CHROMA_LOCATION_MIDPOINT</code>.
        /// Otherwise both <code>xChromaOffset</code> and <code>yChromaOffset</code><strong class="purple">must</strong> be
        /// <code>VK_CHROMA_LOCATION_COSITED_EVEN</code>.
        /// If a format does not incorporate chroma downsampling (it is not a
        /// “422” or “420” format) but the implementation supports sampler
        /// Y’C<sub>B</sub>C<sub>R</sub> conversion for this format, the implementation <strong class="purple">must</strong> set
        /// <code>VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT</code>.</summary>
        VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT = 0x00020000,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT</code>
        /// specifies that the format can do linear sampler filtering
        /// (min/magFilter) whilst sampler Y’C<sub>B</sub>C<sub>R</sub> conversion is enabled.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 0x00040000,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT</code>
        /// specifies that the format can have different chroma, min, and mag
        /// filters.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 0x00080000,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT</code>
        /// specifies that reconstruction is explicit, as described in
        /// <a href="vkspec.html#textures-chroma-reconstruction" class="bare">html/vkspec.html#textures-chroma-reconstruction</a>.
        /// If this bit is not present, reconstruction is implicit by default.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 0x00100000,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT</code>
        /// specifies that reconstruction <strong class="purple">can</strong> be forcibly made explicit by setting
        /// <a href="#VkSamplerYcbcrConversionCreateInfo">VkSamplerYcbcrConversionCreateInfo</a>::<code>forceExplicitReconstruction</code>
        /// to <code>VK_TRUE</code>.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x00200000,
        /// <summary><code>VK_FORMAT_FEATURE_DISJOINT_BIT</code> specifies that a multi-planar image
        /// <strong class="purple">can</strong> have the <code>VK_IMAGE_CREATE_DISJOINT_BIT</code> set during image
        /// creation.
        /// An implementation <strong class="purple">must</strong> not set <code>VK_FORMAT_FEATURE_DISJOINT_BIT</code> for
        /// <em>single-plane formats</em>.</summary>
        VK_FORMAT_FEATURE_DISJOINT_BIT = 0x00400000,
        /// <summary><code>VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT</code> specifies that an
        /// application <strong class="purple">can</strong> define a <a href="vkspec.html#samplers-YCbCr-conversion">sampler Y’C<sub>B</sub>C<sub>R</sub>
        /// conversion</a> using this format as a source, and that an image of this
        /// format <strong class="purple">can</strong> be used with a <code>VkSamplerYcbcrConversionCreateInfo</code><code>xChromaOffset</code> and/or <code>yChromaOffset</code> of
        /// <code>VK_CHROMA_LOCATION_COSITED_EVEN</code>.
        /// Otherwise both <code>xChromaOffset</code> and <code>yChromaOffset</code><strong class="purple">must</strong> be
        /// <code>VK_CHROMA_LOCATION_MIDPOINT</code>.
        /// If neither <code>VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT</code> nor
        /// <code>VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT</code> is set, the
        /// application <strong class="purple">must</strong> not define a <a href="vkspec.html#samplers-YCbCr-conversion">sampler
        /// Y’C<sub>B</sub>C<sub>R</sub> conversion</a> using this format as a source.</summary>
        VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT = 0x00800000,
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG = 0x00002000,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT</code> specifies
        /// <code>VkImage</code><strong class="purple">can</strong> be used as a sampled image with a min or max
        /// <a href="#VkSamplerReductionModeEXT">VkSamplerReductionModeEXT</a>.
        /// This bit <strong class="purple">must</strong> only be exposed for formats that also support the
        /// <code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</code>.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT = 0x00010000,
        /// <summary><code>VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT</code> specifies that an
        /// image view <strong class="purple">can</strong> be used as a
        /// <a href="vkspec.html#renderpass-fragmentdensitymapattachment">fragment density map
        /// attachment</a>.</summary>
        VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x01000000,
        VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR = VK_FORMAT_FEATURE_TRANSFER_SRC_BIT,
        VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR = VK_FORMAT_FEATURE_TRANSFER_DST_BIT,
        VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT,
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT,
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT,
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT,
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT,
        VK_FORMAT_FEATURE_DISJOINT_BIT_KHR = VK_FORMAT_FEATURE_DISJOINT_BIT,
        VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT,
        /// <summary><code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT</code> specifies
        /// that <code>VkImage</code><strong class="purple">can</strong> be used with a sampler that has either of
        /// <code>magFilter</code> or <code>minFilter</code> set to <code>VK_FILTER_CUBIC_EXT</code>, or
        /// be the source image for a blit with <code>filter</code> set to
        /// <code>VK_FILTER_CUBIC_EXT</code>.
        /// This bit <strong class="purple">must</strong> only be exposed for formats that also support the
        /// <code>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</code>.
        /// If the format being queried is a depth/stencil format, this only
        /// specifies that the depth aspect is cubic filterable.</summary>
        VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG,
        VK_FORMAT_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 63
    /// <summary>VkFrontFace - Interpret polygon front-facing orientation</summary>
    public enum VkFrontFace {
        /// <summary><code>VK_FRONT_FACE_COUNTER_CLOCKWISE</code> specifies that a triangle with
        /// positive area is considered front-facing.</summary>
        VK_FRONT_FACE_COUNTER_CLOCKWISE = 0,
        /// <summary><code>VK_FRONT_FACE_CLOCKWISE</code> specifies that a triangle with negative
        /// area is considered front-facing.</summary>
        VK_FRONT_FACE_CLOCKWISE = 1,
        VK_FRONT_FACE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 64
    /// <summary>VkFullScreenExclusiveEXT - Hint values an application can specify affecting full-screen transition behavior</summary>
    public enum VkFullScreenExclusiveEXT {
        /// <summary><code>VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT</code> indicates the implementation
        /// <strong class="purple">should</strong> determine the appropriate full-screen method by whatever means
        /// it deems appropriate.</summary>
        VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = 0,
        /// <summary><code>VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT</code> indicates the implementation
        /// <strong class="purple">may</strong> use full-screen exclusive mechanisms when available.
        /// Such mechanisms <strong class="purple">may</strong> result in better performance and/or the
        /// availability of different presentation capabilities, but <strong class="purple">may</strong> require a
        /// more disruptive transition during swapchain initialization, first
        /// presentation and/or destruction.</summary>
        VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = 1,
        /// <summary><code>VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT</code> indicates the
        /// implementation <strong class="purple">should</strong> avoid using full-screen mechanisms which rely on
        /// disruptive transitions.</summary>
        VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = 2,
        /// <summary><code>VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT</code> indicates the
        /// application will manage full-screen exclusive mode by using the
        /// <a href="#vkAcquireFullScreenExclusiveModeEXT">vkAcquireFullScreenExclusiveModeEXT</a> and
        /// <a href="#vkReleaseFullScreenExclusiveModeEXT">vkReleaseFullScreenExclusiveModeEXT</a> commands.</summary>
        VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = 3,
        VK_FULL_SCREEN_EXCLUSIVE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 65
    /// <summary>VkGeometryFlagBitsNV - Bitmask specifying additional parameters for a geometry</summary>
    public enum VkGeometryFlagBitsNV {
        /// <summary><code>VK_GEOMETRY_OPAQUE_BIT_NV</code> indicates that this geometry does not
        /// invoke the any-hit shaders even if present in a hit group.</summary>
        VK_GEOMETRY_OPAQUE_BIT_NV = 0x00000001,
        /// <summary><code>VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV</code> indicates that
        /// the implementation <strong class="purple">must</strong> only call the any-hit shader a single time for
        /// each primitive in this geometry.
        /// If this bit is absent an implementation <strong class="purple">may</strong> invoke the any-hit shader
        /// more than once for this geometry.</summary>
        VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV = 0x00000002,
        VK_GEOMETRY_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 66
    /// <summary>VkGeometryInstanceFlagBitsNV - Instance flag bits</summary>
    public enum VkGeometryInstanceFlagBitsNV {
        /// <summary><code>VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV</code> disables face
        /// culling for this instance.</summary>
        VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV = 0x00000001,
        /// <summary><code>VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV</code>
        /// indicates that the front face of the triangle for culling purposes is
        /// the face that is counter clockwise in object space relative to the ray
        /// origin.
        /// Because the facing is determined in object space, an instance transform
        /// matrix does not change the winding, but a geometry transform does.</summary>
        VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV = 0x00000002,
        /// <summary><code>VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV</code> causes this instance to
        /// act as though <code>VK_GEOMETRY_OPAQUE_BIT_NV</code> were specified on all
        /// geometries referenced by this instance.
        /// This behavior <strong class="purple">can</strong> be overridden by the ray flag
        /// <code>gl_RayFlagsNoOpaqueNV</code>.</summary>
        VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV = 0x00000004,
        /// <summary><code>VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV</code> causes this instance
        /// to act as though <code>VK_GEOMETRY_OPAQUE_BIT_NV</code> were not specified on
        /// all geometries referenced by this instance.
        /// This behavior <strong class="purple">can</strong> be overridden by the ray flag
        /// <code>gl_RayFlagsOpaqueNV</code>.</summary>
        VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV = 0x00000008,
        VK_GEOMETRY_INSTANCE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 67
    /// <summary>VkGeometryTypeNV - Enum specifying which type of geometry is provided</summary>
    public enum VkGeometryTypeNV {
        /// <summary><code>VK_GEOMETRY_TYPE_TRIANGLES_NV</code> indicates that the <code>triangles</code>
        /// of <a href="#VkGeometryDataNV">VkGeometryDataNV</a> contains valid data.</summary>
        VK_GEOMETRY_TYPE_TRIANGLES_NV = 0,
        /// <summary><code>VK_GEOMETRY_TYPE_AABBS_NV</code> indicates that the <code>aabbs</code> of
        /// <a href="#VkGeometryDataNV">VkGeometryDataNV</a> contains valid data.</summary>
        VK_GEOMETRY_TYPE_AABBS_NV = 1,
        VK_GEOMETRY_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 68
    /// <summary>VkImageAspectFlagBits - Bitmask specifying which aspects of an image are included in a view</summary>
    public enum VkImageAspectFlagBits {
        /// <summary><code>VK_IMAGE_ASPECT_COLOR_BIT</code> specifies the color aspect.</summary>
        VK_IMAGE_ASPECT_COLOR_BIT = 0x00000001,
        /// <summary><code>VK_IMAGE_ASPECT_DEPTH_BIT</code> specifies the depth aspect.</summary>
        VK_IMAGE_ASPECT_DEPTH_BIT = 0x00000002,
        /// <summary><code>VK_IMAGE_ASPECT_STENCIL_BIT</code> specifies the stencil aspect.</summary>
        VK_IMAGE_ASPECT_STENCIL_BIT = 0x00000004,
        /// <summary><code>VK_IMAGE_ASPECT_METADATA_BIT</code> specifies the metadata aspect, used
        /// for sparse <a href="vkspec.html#sparsememory">sparse resource</a> operations.</summary>
        VK_IMAGE_ASPECT_METADATA_BIT = 0x00000008,
        VK_IMAGE_ASPECT_PLANE_0_BIT = 0x00000010,
        VK_IMAGE_ASPECT_PLANE_1_BIT = 0x00000020,
        VK_IMAGE_ASPECT_PLANE_2_BIT = 0x00000040,
        VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = 0x00000080,
        VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = 0x00000100,
        VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = 0x00000200,
        VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = 0x00000400,
        VK_IMAGE_ASPECT_PLANE_0_BIT_KHR = VK_IMAGE_ASPECT_PLANE_0_BIT,
        VK_IMAGE_ASPECT_PLANE_1_BIT_KHR = VK_IMAGE_ASPECT_PLANE_1_BIT,
        VK_IMAGE_ASPECT_PLANE_2_BIT_KHR = VK_IMAGE_ASPECT_PLANE_2_BIT,
        VK_IMAGE_ASPECT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 69
    /// <summary>VkImageCreateFlagBits - Bitmask specifying additional parameters of an image</summary>
    public enum VkImageCreateFlagBits {
        /// <summary><code>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</code> specifies that the image will
        /// be backed using sparse memory binding.</summary>
        VK_IMAGE_CREATE_SPARSE_BINDING_BIT = 0x00000001,
        /// <summary><code>VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT</code> specifies that the image <strong class="purple">can</strong>
        /// be partially backed using sparse memory binding.
        /// Images created with this flag <strong class="purple">must</strong> also be created with the
        /// <code>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</code> flag.</summary>
        VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = 0x00000002,
        /// <summary><code>VK_IMAGE_CREATE_SPARSE_ALIASED_BIT</code> specifies that the image will
        /// be backed using sparse memory binding with memory ranges that might also
        /// simultaneously be backing another image (or another portion of the same
        /// image).
        /// Images created with this flag <strong class="purple">must</strong> also be created with the
        /// <code>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</code> flag</summary>
        VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = 0x00000004,
        /// <summary><code>VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT</code> specifies that the image <strong class="purple">can</strong>
        /// be used to create a <code>VkImageView</code> with a different format from the
        /// image.
        /// For <a href="vkspec.html#formats-requiring-sampler-ycbcr-conversion">multi-planar</a> formats,
        /// <code>VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT</code> specifies that a
        /// <code>VkImageView</code> can be created of a <em>plane</em> of the image.</summary>
        VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = 0x00000008,
        /// <summary><code>VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT</code> specifies that the image <strong class="purple">can</strong>
        /// be used to create a <code>VkImageView</code> of type
        /// <code>VK_IMAGE_VIEW_TYPE_CUBE</code> or <code>VK_IMAGE_VIEW_TYPE_CUBE_ARRAY</code>.</summary>
        VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = 0x00000010,
        /// <summary><code>VK_IMAGE_CREATE_ALIAS_BIT</code> specifies that two images created with
        ///     the same creation parameters and aliased to the same memory <strong class="purple">can</strong>
        ///     interpret the contents of the memory consistently with each other,
        ///     subject to the rules described in the <a href="vkspec.html#resources-memory-aliasing">Memory
        ///     Aliasing</a> section.
        ///     This flag further specifies that each plane of a <em>disjoint</em> image <strong class="purple">can</strong>
        ///     share an in-memory non-linear representation with single-plane images,
        ///     and that a single-plane image <strong class="purple">can</strong> share an in-memory non-linear
        ///     representation with a plane of a multi-planar disjoint image, according
        ///     to the rules in <a href="vkspec.html#formats-compatible-planes" class="bare">html/vkspec.html#formats-compatible-planes</a>.
        ///     If the <code>pNext</code> chain includes a
        /// <a href="#VkExternalMemoryImageCreateInfo">VkExternalMemoryImageCreateInfo</a>
        /// or
        /// <a href="#VkExternalMemoryImageCreateInfoNV">VkExternalMemoryImageCreateInfoNV</a>
        ///     structure whose <code>handleTypes</code> member is not <code>0</code>, it is as if
        ///     <code>VK_IMAGE_CREATE_ALIAS_BIT</code> is set.</summary>
        VK_IMAGE_CREATE_ALIAS_BIT = 0x00000400,
        /// <summary><code>VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</code> specifies that the
        /// image <strong class="purple">can</strong> be used with a non-zero value of the
        /// <code>splitInstanceBindRegionCount</code> member of a
        /// <a href="#VkBindImageMemoryDeviceGroupInfo">VkBindImageMemoryDeviceGroupInfo</a> structure passed into
        /// <a href="#vkBindImageMemory2">vkBindImageMemory2</a>.
        /// This flag also has the effect of making the image use the standard
        /// sparse image block dimensions.</summary>
        VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT = 0x00000040,
        /// <summary><code>VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT</code> specifies that the image
        /// <strong class="purple">can</strong> be used to create a <code>VkImageView</code> of type
        /// <code>VK_IMAGE_VIEW_TYPE_2D</code> or <code>VK_IMAGE_VIEW_TYPE_2D_ARRAY</code>.</summary>
        VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT = 0x00000020,
        /// <summary><code>VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT</code> specifies that the
        /// image having a compressed format <strong class="purple">can</strong> be used to create a
        /// <code>VkImageView</code> with an uncompressed format where each texel in the
        /// image view corresponds to a compressed texel block of the image.</summary>
        VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT = 0x00000080,
        /// <summary><code>VK_IMAGE_CREATE_EXTENDED_USAGE_BIT</code> specifies that the image <strong class="purple">can</strong>
        /// be created with usage flags that are not supported for the format the
        /// image is created with but are supported for at least one format a
        /// <code>VkImageView</code> created from the image <strong class="purple">can</strong> have.</summary>
        VK_IMAGE_CREATE_EXTENDED_USAGE_BIT = 0x00000100,
        /// <summary><code>VK_IMAGE_CREATE_PROTECTED_BIT</code> specifies that the image is a
        /// protected image.</summary>
        VK_IMAGE_CREATE_PROTECTED_BIT = 0x00000800,
        /// <summary><code>VK_IMAGE_CREATE_DISJOINT_BIT</code> specifies that an image with a
        /// <a href="vkspec.html#formats-requiring-sampler-ycbcr-conversion">multi-planar format</a><strong class="purple">must</strong>
        /// have each plane separately bound to memory, rather than having a single
        /// memory binding for the whole image; the presence of this bit
        /// distinguishes a <em>disjoint image</em> from an image without this bit set.</summary>
        VK_IMAGE_CREATE_DISJOINT_BIT = 0x00000200,
        /// <summary><code>VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV</code> specifies that the image is
        /// a <a href="vkspec.html#resources-images-corner-sampled">corner-sampled image</a>.</summary>
        VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV = 0x00002000,
        /// <summary><code>VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT</code>
        /// specifies that an image with a depth or depth/stencil format <strong class="purple">can</strong> be
        /// used with custom sample locations when used as a depth/stencil
        /// attachment.</summary>
        VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x00001000,
        /// <summary><code>VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT</code> specifies that an image <strong class="purple">can</strong> be
        /// in a subsampled format which <strong class="purple">may</strong> be more optimal when written as an
        /// attachment by a render pass that has a fragment density map attachment.
        /// Accessing a subsampled image has additional considerations:</summary>
        VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT = 0x00004000,
        VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT,
        VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT,
        VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT,
        VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR = VK_IMAGE_CREATE_EXTENDED_USAGE_BIT,
        VK_IMAGE_CREATE_DISJOINT_BIT_KHR = VK_IMAGE_CREATE_DISJOINT_BIT,
        VK_IMAGE_CREATE_ALIAS_BIT_KHR = VK_IMAGE_CREATE_ALIAS_BIT,
        VK_IMAGE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 70
    /// <summary>VkImageLayout - Layout of image and image subresources</summary>
    public enum VkImageLayout {
        /// <summary><code>VK_IMAGE_LAYOUT_UNDEFINED</code> does not support device access.
        /// This layout <strong class="purple">must</strong> only be used as the <code>initialLayout</code> member of
        /// <code>VkImageCreateInfo</code> or <code>VkAttachmentDescription</code>, or as the
        /// <code>oldLayout</code> in an image transition.
        /// When transitioning out of this layout, the contents of the memory are
        /// not guaranteed to be preserved.</summary>
        VK_IMAGE_LAYOUT_UNDEFINED = 0,
        /// <summary><code>VK_IMAGE_LAYOUT_GENERAL</code> supports all types of device access.</summary>
        VK_IMAGE_LAYOUT_GENERAL = 1,
        /// <summary><code>VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL</code>
        ///   <strong class="purple">must</strong> only be used as a
        /// color or resolve attachment in a <code>VkFramebuffer</code>.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2,
        /// <summary><code>VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL</code>
        ///   <strong class="purple">must</strong> only be
        /// used as a depth/stencil
        /// or depth/stencil resolve
        /// attachment in a <code>VkFramebuffer</code>.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3,
        /// <summary><code>VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL</code>
        ///   <strong class="purple">must</strong> only be used
        /// as a read-only depth/stencil attachment in a <code>VkFramebuffer</code> and/or
        /// as a read-only image in a shader (which <strong class="purple">can</strong> be read as a sampled image,
        /// combined image/sampler and/or input attachment).
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT</code> usage bit enabled.
        /// Only image views created with a <code>usage</code> value including
        /// <code>VK_IMAGE_USAGE_SAMPLED_BIT</code><strong class="purple">can</strong> be used as a sampled image or
        /// combined image/sampler in a shader.
        /// Similarly, only image views created with a <code>usage</code> value including
        /// <code>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</code><strong class="purple">can</strong> be used as input
        /// attachments.</summary>
        VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4,
        /// <summary><code>VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL</code>
        ///   <strong class="purple">must</strong> only be used as a
        /// read-only image in a shader (which <strong class="purple">can</strong> be read as a sampled image,
        /// combined image/sampler and/or input attachment).
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_SAMPLED_BIT</code> or
        /// <code>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5,
        /// <summary><code>VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL</code>
        ///   <strong class="purple">must</strong> only be used as a
        /// source image of a transfer command (see the definition of
        /// <a href="vkspec.html#synchronization-pipeline-stages-transfer"><code>VK_PIPELINE_STAGE_TRANSFER_BIT</code></a>).
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_TRANSFER_SRC_BIT</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = 6,
        /// <summary><code>VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL</code>
        ///   <strong class="purple">must</strong> only be used as a
        /// destination image of a transfer command.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_TRANSFER_DST_BIT</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = 7,
        /// <summary><code>VK_IMAGE_LAYOUT_PREINITIALIZED</code> does not support device access.
        /// This layout <strong class="purple">must</strong> only be used as the <code>initialLayout</code> member of
        /// <code>VkImageCreateInfo</code> or <code>VkAttachmentDescription</code>, or as the
        /// <code>oldLayout</code> in an image transition.
        /// When transitioning out of this layout, the contents of the memory are
        /// preserved.
        /// This layout is intended to be used as the initial layout for an image
        /// whose contents are written by the host, and hence the data <strong class="purple">can</strong> be
        /// written to memory immediately, without first executing a layout
        /// transition.
        /// Currently, <code>VK_IMAGE_LAYOUT_PREINITIALIZED</code> is only useful with
        /// <a href="vkspec.html#glossary-linear-resource">linear</a> images because there is not a
        /// standard layout defined for <code>VK_IMAGE_TILING_OPTIMAL</code> images.</summary>
        VK_IMAGE_LAYOUT_PREINITIALIZED = 8,
        /// <summary><code>VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL</code>: <strong class="purple">must</strong>
        /// only be used as a depth/stencil attachment in a <code>VkFramebuffer</code>,
        /// where the depth aspect is read-only, and/or as a read-only image in a
        /// shader (which <strong class="purple">can</strong> be read as a sampled image, combined image/sampler
        /// and/or input attachment) where only the depth aspect is accessed.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT</code> usage bit enabled.
        /// Only image views created with a <code>usage</code> value including
        /// <code>VK_IMAGE_USAGE_SAMPLED_BIT</code><strong class="purple">can</strong> be used as a sampled image or
        /// combined image/sampler in a shader.
        /// Similarly, only image views created with a <code>usage</code> value including
        /// <code>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</code><strong class="purple">can</strong> be used as input
        /// attachments.</summary>
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = 1000117000,
        /// <summary><code>VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL</code>: <strong class="purple">must</strong>
        /// only be used as a depth/stencil attachment in a <code>VkFramebuffer</code>,
        /// where the stencil aspect is read-only, and/or as a read-only image in a
        /// shader (which <strong class="purple">can</strong> be read as a sampled image, combined image/sampler
        /// and/or input attachment) where only the stencil aspect is accessed.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT</code> usage bit enabled.
        /// Only image views created with a <code>usage</code> value including
        /// <code>VK_IMAGE_USAGE_SAMPLED_BIT</code><strong class="purple">can</strong> be used as a sampled image or
        /// combined image/sampler in a shader.
        /// Similarly, only image views created with a <code>usage</code> value including
        /// <code>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</code><strong class="purple">can</strong> be used as input
        /// attachments.</summary>
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = 1000117001,
        /// <summary><code>VK_IMAGE_LAYOUT_PRESENT_SRC_KHR</code>
        ///   <strong class="purple">must</strong> only be used for presenting
        /// a presentable image for display.
        /// A swapchain’s image <strong class="purple">must</strong> be transitioned to this layout before calling
        /// <a href="#vkQueuePresentKHR">vkQueuePresentKHR</a>, and <strong class="purple">must</strong> be transitioned away from this layout
        /// after calling <a href="#vkAcquireNextImageKHR">vkAcquireNextImageKHR</a>.</summary>
        VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = 1000001002,
        /// <summary><code>VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR</code> is valid only for shared
        /// presentable images, and <strong class="purple">must</strong> be used for any usage the image supports.</summary>
        VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = 1000111000,
        /// <summary><code>VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV</code>
        ///   <strong class="purple">must</strong> only be used as a
        /// read-only <a href="vkspec.html#primsrast-shading-rate-image">shading-rate-image</a>.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV = 1000164003,
        /// <summary><code>VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT</code>
        ///   <strong class="purple">must</strong> only be
        /// used as a fragment density map attachment in a <code>VkRenderPass</code>.
        /// This layout is valid only for image subresources of images created with
        /// the <code>VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT</code> usage bit enabled.</summary>
        VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = 1000218000,
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL,
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL,
        VK_IMAGE_LAYOUT_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 71
    /// <summary>VkImageTiling - Specifies the tiling arrangement of data in an image</summary>
    public enum VkImageTiling {
        /// <summary><code>VK_IMAGE_TILING_OPTIMAL</code> specifies optimal tiling (texels are laid
        /// out in an implementation-dependent arrangement, for more optimal memory
        /// access).</summary>
        VK_IMAGE_TILING_OPTIMAL = 0,
        /// <summary><code>VK_IMAGE_TILING_LINEAR</code> specifies linear tiling (texels are laid
        /// out in memory in row-major order, possibly with some padding on each
        /// row).</summary>
        VK_IMAGE_TILING_LINEAR = 1,
        /// <summary><code>VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT</code> indicates that the image’s
        /// tiling is defined by a <a href="vkspec.html#glossary-drm-format-modifier">Linux DRM format
        /// modifier</a>.
        /// The modifier is specified at image creation with
        /// <a href="#VkImageDrmFormatModifierListCreateInfoEXT">VkImageDrmFormatModifierListCreateInfoEXT</a> or
        /// <a href="#VkImageDrmFormatModifierExplicitCreateInfoEXT">VkImageDrmFormatModifierExplicitCreateInfoEXT</a>, and <strong class="purple">can</strong> be queried
        /// with <a href="#vkGetImageDrmFormatModifierPropertiesEXT">vkGetImageDrmFormatModifierPropertiesEXT</a>.</summary>
        VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = 1000158000,
        VK_IMAGE_TILING_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 72
    /// <summary>VkImageType - Specifies the type of an image object</summary>
    public enum VkImageType {
        /// <summary><code>VK_IMAGE_TYPE_1D</code> specifies a one-dimensional image.</summary>
        VK_IMAGE_TYPE_1D = 0,
        /// <summary><code>VK_IMAGE_TYPE_2D</code> specifies a two-dimensional image.</summary>
        VK_IMAGE_TYPE_2D = 1,
        /// <summary><code>VK_IMAGE_TYPE_3D</code> specifies a three-dimensional image.</summary>
        VK_IMAGE_TYPE_3D = 2,
        VK_IMAGE_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 73
    /// <summary>VkImageUsageFlagBits - Bitmask specifying intended usage of an image</summary>
    public enum VkImageUsageFlagBits {
        /// <summary><code>VK_IMAGE_USAGE_TRANSFER_SRC_BIT</code> specifies that the image <strong class="purple">can</strong> be
        /// used as the source of a transfer command.</summary>
        VK_IMAGE_USAGE_TRANSFER_SRC_BIT = 0x00000001,
        /// <summary><code>VK_IMAGE_USAGE_TRANSFER_DST_BIT</code> specifies that the image <strong class="purple">can</strong> be
        /// used as the destination of a transfer command.</summary>
        VK_IMAGE_USAGE_TRANSFER_DST_BIT = 0x00000002,
        /// <summary><code>VK_IMAGE_USAGE_SAMPLED_BIT</code> specifies that the image <strong class="purple">can</strong> be used
        /// to create a <code>VkImageView</code> suitable for occupying a
        /// <code>VkDescriptorSet</code> slot either of type
        /// <code>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</code> or
        /// <code>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</code>, and be sampled by a
        /// shader.</summary>
        VK_IMAGE_USAGE_SAMPLED_BIT = 0x00000004,
        /// <summary><code>VK_IMAGE_USAGE_STORAGE_BIT</code> specifies that the image <strong class="purple">can</strong> be used
        /// to create a <code>VkImageView</code> suitable for occupying a
        /// <code>VkDescriptorSet</code> slot of type
        /// <code>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</code>.</summary>
        VK_IMAGE_USAGE_STORAGE_BIT = 0x00000008,
        /// <summary><code>VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT</code> specifies that the image <strong class="purple">can</strong>
        /// be used to create a <code>VkImageView</code> suitable for use as a color or
        /// resolve attachment in a <code>VkFramebuffer</code>.</summary>
        VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 0x00000010,
        /// <summary><code>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT</code> specifies that the
        /// image <strong class="purple">can</strong> be used to create a <code>VkImageView</code> suitable for use as a
        /// depth/stencil
        /// or depth/stencil resolve
        /// attachment in a <code>VkFramebuffer</code>.</summary>
        VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x00000020,
        /// <summary><code>VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT</code> specifies that the memory
        /// bound to this image will have been allocated with the
        /// <code>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</code> (see <a href="vkspec.html#memory" class="bare">html/vkspec.html#memory</a> for more
        /// detail).
        /// This bit <strong class="purple">can</strong> be set for any image that <strong class="purple">can</strong> be used to create a
        /// <code>VkImageView</code> suitable for use as a color, resolve, depth/stencil,
        /// or input attachment.</summary>
        VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 0x00000040,
        /// <summary><code>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</code> specifies that the image <strong class="purple">can</strong>
        /// be used to create a <code>VkImageView</code> suitable for occupying
        /// <code>VkDescriptorSet</code> slot of type
        /// <code>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</code>; be read from a shader as an
        /// input attachment; and be used as an input attachment in a framebuffer.</summary>
        VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 0x00000080,
        /// <summary><code>VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV</code> specifies that the image
        /// <strong class="purple">can</strong> be used to create a <code>VkImageView</code> suitable for use as a
        /// <a href="vkspec.html#primsrast-shading-rate-image">shading rate image</a>.</summary>
        VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV = 0x00000100,
        VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x00000200,
        VK_IMAGE_USAGE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 74
    /// <summary>VkImageViewCreateFlagBits - Bitmask specifying additional parameters of an image view</summary>
    public enum VkImageViewCreateFlagBits {
        /// <summary><code>VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT</code>
        /// prohibits the implementation from accessing the fragment density map by
        /// the host during <code>vkCmdBeginRenderPass</code> as the contents are expected
        /// to change after recording</summary>
        VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT = 0x00000001,
        VK_IMAGE_VIEW_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 75
    /// <summary>VkImageViewType - Image view types</summary>
    public enum VkImageViewType {
        VK_IMAGE_VIEW_TYPE_1D = 0,
        VK_IMAGE_VIEW_TYPE_2D = 1,
        VK_IMAGE_VIEW_TYPE_3D = 2,
        VK_IMAGE_VIEW_TYPE_CUBE = 3,
        VK_IMAGE_VIEW_TYPE_1D_ARRAY = 4,
        VK_IMAGE_VIEW_TYPE_2D_ARRAY = 5,
        VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = 6,
        VK_IMAGE_VIEW_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 76
    /// <summary>VkIndexType - Type of index buffer indices</summary>
    public enum VkIndexType {
        /// <summary><code>VK_INDEX_TYPE_UINT16</code> specifies that indices are 16-bit unsigned
        /// integer values.</summary>
        VK_INDEX_TYPE_UINT16 = 0,
        /// <summary><code>VK_INDEX_TYPE_UINT32</code> specifies that indices are 32-bit unsigned
        /// integer values.</summary>
        VK_INDEX_TYPE_UINT32 = 1,
        /// <summary><code>VK_INDEX_TYPE_NONE_NV</code> specifies that no indices are provided.</summary>
        VK_INDEX_TYPE_NONE_NV = 1000165000,
        VK_INDEX_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 77
    /// <summary>VkIndirectCommandsLayoutUsageFlagBitsNVX - Bitmask specifying allowed usage of an indirect commands layout</summary>
    public enum VkIndirectCommandsLayoutUsageFlagBitsNVX {
        /// <summary><code>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVX</code>
        /// specifies that the processing of sequences <strong class="purple">can</strong> happen at an
        /// implementation-dependent order, which is not guaranteed to be coherent
        /// across multiple invocations.</summary>
        VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVX = 0x00000001,
        /// <summary><code>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_SPARSE_SEQUENCES_BIT_NVX</code>
        /// specifies that there is likely a high difference between allocated
        /// number of sequences and actually used.</summary>
        VK_INDIRECT_COMMANDS_LAYOUT_USAGE_SPARSE_SEQUENCES_BIT_NVX = 0x00000002,
        /// <summary><code>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EMPTY_EXECUTIONS_BIT_NVX</code>
        /// specifies that there are likely many draw or dispatch calls that are
        /// zero-sized (zero grid dimension, no primitives to render).</summary>
        VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EMPTY_EXECUTIONS_BIT_NVX = 0x00000004,
        /// <summary><code>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX</code>
        /// specifies that the input data for the sequences is not implicitly
        /// indexed from 0..sequencesUsed but a user provided <code>VkBuffer</code>
        /// encoding the index is provided.</summary>
        VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX = 0x00000008,
        VK_INDIRECT_COMMANDS_LAYOUT_USAGE_FLAG_BITS_MAX_ENUM_NVX = 0x7FFFFFFF
    }
    // Enum: 78
    /// <summary>VkIndirectCommandsTokenTypeNVX - Enum specifying</summary>
    public enum VkIndirectCommandsTokenTypeNVX {
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NVX = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_DESCRIPTOR_SET_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DESCRIPTOR_SET_NVX = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NVX = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NVX = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NVX = 4,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NVX = 5,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NVX = 6,
        /// <summary>class="tableblock">
        ///   <code>VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NVX</code></summary>
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NVX = 7,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_MAX_ENUM_NVX = 0x7FFFFFFF
    }
    // Enum: 79
    /// <summary>VkInternalAllocationType - Allocation type</summary>
    public enum VkInternalAllocationType {
        /// <summary><code>VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE</code> specifies that the
        /// allocation is intended for execution by the host.</summary>
        VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE = 0,
        VK_INTERNAL_ALLOCATION_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 80
    /// <summary>VkLogicOp - Framebuffer logical operations</summary>
    public enum VkLogicOp {
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_CLEAR</code></summary>
        VK_LOGIC_OP_CLEAR = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_AND</code></summary>
        VK_LOGIC_OP_AND = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_AND_REVERSE</code></summary>
        VK_LOGIC_OP_AND_REVERSE = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_COPY</code></summary>
        VK_LOGIC_OP_COPY = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_AND_INVERTED</code></summary>
        VK_LOGIC_OP_AND_INVERTED = 4,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_NO_OP</code></summary>
        VK_LOGIC_OP_NO_OP = 5,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_XOR</code></summary>
        VK_LOGIC_OP_XOR = 6,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_OR</code></summary>
        VK_LOGIC_OP_OR = 7,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_NOR</code></summary>
        VK_LOGIC_OP_NOR = 8,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_EQUIVALENT</code></summary>
        VK_LOGIC_OP_EQUIVALENT = 9,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_INVERT</code></summary>
        VK_LOGIC_OP_INVERT = 10,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_OR_REVERSE</code></summary>
        VK_LOGIC_OP_OR_REVERSE = 11,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_COPY_INVERTED</code></summary>
        VK_LOGIC_OP_COPY_INVERTED = 12,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_OR_INVERTED</code></summary>
        VK_LOGIC_OP_OR_INVERTED = 13,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_NAND</code></summary>
        VK_LOGIC_OP_NAND = 14,
        /// <summary>class="tableblock">
        ///   <code>VK_LOGIC_OP_SET</code></summary>
        VK_LOGIC_OP_SET = 15,
        VK_LOGIC_OP_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 81
    /// <summary>VkMemoryAllocateFlagBits - Bitmask specifying flags for a device memory allocation</summary>
    public enum VkMemoryAllocateFlagBits {
        /// <summary><code>VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT</code> specifies that memory will be
        /// allocated for the devices in
        /// <a href="#VkMemoryAllocateFlagsInfo">VkMemoryAllocateFlagsInfo</a>::<code>deviceMask</code>.</summary>
        VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = 0x00000001,
        VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT,
        VK_MEMORY_ALLOCATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 82
    /// <summary>VkMemoryHeapFlagBits - Bitmask specifying attribute flags for a heap</summary>
    public enum VkMemoryHeapFlagBits {
        /// <summary><code>VK_MEMORY_HEAP_DEVICE_LOCAL_BIT</code> specifies that the heap
        /// corresponds to device local memory.
        /// Device local memory <strong class="purple">may</strong> have different performance characteristics than
        /// host local memory, and <strong class="purple">may</strong> support different memory property flags.</summary>
        VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = 0x00000001,
        /// <summary><code>VK_MEMORY_HEAP_MULTI_INSTANCE_BIT</code> specifies that in a logical
        /// device representing more than one physical device, there is a
        /// per-physical device instance of the heap memory.
        /// By default, an allocation from such a heap will be replicated to each
        /// physical device’s instance of the heap.</summary>
        VK_MEMORY_HEAP_MULTI_INSTANCE_BIT = 0x00000002,
        VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR = VK_MEMORY_HEAP_MULTI_INSTANCE_BIT,
        VK_MEMORY_HEAP_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 83
    /// <summary>VkMemoryOverallocationBehaviorAMD - Specify memory overallocation behavior</summary>
    public enum VkMemoryOverallocationBehaviorAMD {
        /// <summary><code>VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD</code> lets the
        /// implementation decide if overallocation should be allowed.</summary>
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = 0,
        /// <summary><code>VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD</code> specifies
        /// overallocation is allowed if platform permits.</summary>
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = 1,
        /// <summary><code>VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD</code> specifies the
        /// application is not allowed to allocate device memory beyond the heap
        /// sizes reported by <a href="#VkPhysicalDeviceMemoryProperties">VkPhysicalDeviceMemoryProperties</a>.
        /// Allocations that are not explicitly made by the application within the
        /// scope of the Vulkan instance are not accounted for.</summary>
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = 2,
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_MAX_ENUM_AMD = 0x7FFFFFFF
    }
    // Enum: 84
    /// <summary>VkMemoryPropertyFlagBits - Bitmask specifying properties for a memory type</summary>
    public enum VkMemoryPropertyFlagBits {
        /// <summary><code>VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT</code> bit specifies that memory
        /// allocated with this type is the most efficient for device access.
        /// This property will be set if and only if the memory type belongs to a
        /// heap with the <code>VK_MEMORY_HEAP_DEVICE_LOCAL_BIT</code> set.</summary>
        VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = 0x00000001,
        /// <summary><code>VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT</code> bit specifies that memory
        /// allocated with this type <strong class="purple">can</strong> be mapped for host access using
        /// <a href="#vkMapMemory">vkMapMemory</a>.</summary>
        VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 0x00000002,
        /// <summary><code>VK_MEMORY_PROPERTY_HOST_COHERENT_BIT</code> bit specifies that the host
        /// cache management commands <a href="#vkFlushMappedMemoryRanges">vkFlushMappedMemoryRanges</a> and
        /// <a href="#vkInvalidateMappedMemoryRanges">vkInvalidateMappedMemoryRanges</a> are not needed to flush host writes
        /// to the device or make device writes visible to the host, respectively.</summary>
        VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = 0x00000004,
        /// <summary><code>VK_MEMORY_PROPERTY_HOST_CACHED_BIT</code> bit specifies that memory
        /// allocated with this type is cached on the host.
        /// Host memory accesses to uncached memory are slower than to cached
        /// memory, however uncached memory is always host coherent.</summary>
        VK_MEMORY_PROPERTY_HOST_CACHED_BIT = 0x00000008,
        /// <summary><code>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</code> bit specifies that the
        /// memory type only allows device access to the memory.
        /// Memory types <strong class="purple">must</strong> not have both
        /// <code>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</code> and
        /// <code>VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT</code> set.
        /// Additionally, the object’s backing memory <strong class="purple">may</strong> be provided by the
        /// implementation lazily as specified in <a href="vkspec.html#memory-device-lazy_allocation">Lazily Allocated Memory</a>.</summary>
        VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 0x00000010,
        /// <summary><code>VK_MEMORY_PROPERTY_PROTECTED_BIT</code> bit specifies that the memory
        /// type only allows device access to the memory, and allows protected queue
        /// operations to access the memory.
        /// Memory types <strong class="purple">must</strong> not have <code>VK_MEMORY_PROPERTY_PROTECTED_BIT</code> set
        /// and any of <code>VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT</code> set, or
        /// <code>VK_MEMORY_PROPERTY_HOST_COHERENT_BIT</code> set, or
        /// <code>VK_MEMORY_PROPERTY_HOST_CACHED_BIT</code> set.</summary>
        VK_MEMORY_PROPERTY_PROTECTED_BIT = 0x00000020,
        VK_MEMORY_PROPERTY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 85
    /// <summary>VkObjectEntryTypeNVX - Enum specifying object table entry type</summary>
    public enum VkObjectEntryTypeNVX {
        /// <summary><code>VK_OBJECT_ENTRY_TYPE_DESCRIPTOR_SET_NVX</code> specifies a
        /// <code>VkDescriptorSet</code> resource entry that is registered via
        /// <code>VkObjectTableDescriptorSetEntryNVX</code>.</summary>
        VK_OBJECT_ENTRY_TYPE_DESCRIPTOR_SET_NVX = 0,
        /// <summary><code>VK_OBJECT_ENTRY_TYPE_PIPELINE_NVX</code> specifies a <code>VkPipeline</code>
        /// resource entry that is registered via
        /// <code>VkObjectTablePipelineEntryNVX</code>.</summary>
        VK_OBJECT_ENTRY_TYPE_PIPELINE_NVX = 1,
        /// <summary><code>VK_OBJECT_ENTRY_TYPE_INDEX_BUFFER_NVX</code> specifies a <code>VkBuffer</code>
        /// resource entry that is registered via
        /// <code>VkObjectTableIndexBufferEntryNVX</code>.</summary>
        VK_OBJECT_ENTRY_TYPE_INDEX_BUFFER_NVX = 2,
        /// <summary><code>VK_OBJECT_ENTRY_TYPE_VERTEX_BUFFER_NVX</code> specifies a <code>VkBuffer</code>
        /// resource entry that is registered via
        /// <code>VkObjectTableVertexBufferEntryNVX</code>.</summary>
        VK_OBJECT_ENTRY_TYPE_VERTEX_BUFFER_NVX = 3,
        /// <summary><code>VK_OBJECT_ENTRY_TYPE_PUSH_CONSTANT_NVX</code> specifies the resource
        /// entry is registered via <code>VkObjectTablePushConstantEntryNVX</code>.</summary>
        VK_OBJECT_ENTRY_TYPE_PUSH_CONSTANT_NVX = 4,
        VK_OBJECT_ENTRY_TYPE_MAX_ENUM_NVX = 0x7FFFFFFF
    }
    // Enum: 86
    /// <summary>VkObjectEntryUsageFlagBitsNVX - Bitmask specifying allowed usage of an object entry</summary>
    public enum VkObjectEntryUsageFlagBitsNVX {
        /// <summary><code>VK_OBJECT_ENTRY_USAGE_GRAPHICS_BIT_NVX</code> specifies that the resource
        /// is bound to <code>VK_PIPELINE_BIND_POINT_GRAPHICS</code></summary>
        VK_OBJECT_ENTRY_USAGE_GRAPHICS_BIT_NVX = 0x00000001,
        /// <summary><code>VK_OBJECT_ENTRY_USAGE_COMPUTE_BIT_NVX</code> specifies that the resource
        /// is bound to <code>VK_PIPELINE_BIND_POINT_COMPUTE</code></summary>
        VK_OBJECT_ENTRY_USAGE_COMPUTE_BIT_NVX = 0x00000002,
        VK_OBJECT_ENTRY_USAGE_FLAG_BITS_MAX_ENUM_NVX = 0x7FFFFFFF
    }
    // Enum: 87
    /// <summary>VkObjectType - Specify an enumeration to track object handle types</summary>
    public enum VkObjectType {
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_UNKNOWN</code></summary>
        VK_OBJECT_TYPE_UNKNOWN = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_INSTANCE</code></summary>
        VK_OBJECT_TYPE_INSTANCE = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_PHYSICAL_DEVICE</code></summary>
        VK_OBJECT_TYPE_PHYSICAL_DEVICE = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DEVICE</code></summary>
        VK_OBJECT_TYPE_DEVICE = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_QUEUE</code></summary>
        VK_OBJECT_TYPE_QUEUE = 4,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_SEMAPHORE</code></summary>
        VK_OBJECT_TYPE_SEMAPHORE = 5,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_COMMAND_BUFFER</code></summary>
        VK_OBJECT_TYPE_COMMAND_BUFFER = 6,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_FENCE</code></summary>
        VK_OBJECT_TYPE_FENCE = 7,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DEVICE_MEMORY</code></summary>
        VK_OBJECT_TYPE_DEVICE_MEMORY = 8,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_BUFFER</code></summary>
        VK_OBJECT_TYPE_BUFFER = 9,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_IMAGE</code></summary>
        VK_OBJECT_TYPE_IMAGE = 10,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_EVENT</code></summary>
        VK_OBJECT_TYPE_EVENT = 11,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_QUERY_POOL</code></summary>
        VK_OBJECT_TYPE_QUERY_POOL = 12,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_BUFFER_VIEW</code></summary>
        VK_OBJECT_TYPE_BUFFER_VIEW = 13,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_IMAGE_VIEW</code></summary>
        VK_OBJECT_TYPE_IMAGE_VIEW = 14,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_SHADER_MODULE</code></summary>
        VK_OBJECT_TYPE_SHADER_MODULE = 15,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_PIPELINE_CACHE</code></summary>
        VK_OBJECT_TYPE_PIPELINE_CACHE = 16,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_PIPELINE_LAYOUT</code></summary>
        VK_OBJECT_TYPE_PIPELINE_LAYOUT = 17,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_RENDER_PASS</code></summary>
        VK_OBJECT_TYPE_RENDER_PASS = 18,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_PIPELINE</code></summary>
        VK_OBJECT_TYPE_PIPELINE = 19,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT</code></summary>
        VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = 20,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_SAMPLER</code></summary>
        VK_OBJECT_TYPE_SAMPLER = 21,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DESCRIPTOR_POOL</code></summary>
        VK_OBJECT_TYPE_DESCRIPTOR_POOL = 22,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DESCRIPTOR_SET</code></summary>
        VK_OBJECT_TYPE_DESCRIPTOR_SET = 23,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_FRAMEBUFFER</code></summary>
        VK_OBJECT_TYPE_FRAMEBUFFER = 24,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_COMMAND_POOL</code></summary>
        VK_OBJECT_TYPE_COMMAND_POOL = 25,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION</code></summary>
        VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION = 1000156000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE</code></summary>
        VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE = 1000085000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_SURFACE_KHR</code></summary>
        VK_OBJECT_TYPE_SURFACE_KHR = 1000000000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_SWAPCHAIN_KHR</code></summary>
        VK_OBJECT_TYPE_SWAPCHAIN_KHR = 1000001000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DISPLAY_KHR</code></summary>
        VK_OBJECT_TYPE_DISPLAY_KHR = 1000002000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DISPLAY_MODE_KHR</code></summary>
        VK_OBJECT_TYPE_DISPLAY_MODE_KHR = 1000002001,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT</code></summary>
        VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = 1000011000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_OBJECT_TABLE_NVX</code></summary>
        VK_OBJECT_TYPE_OBJECT_TABLE_NVX = 1000086000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX</code></summary>
        VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX = 1000086001,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT</code></summary>
        VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = 1000128000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_VALIDATION_CACHE_EXT</code></summary>
        VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = 1000160000,
        /// <summary>class="tableblock">
        ///   <code>VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV</code></summary>
        VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,
        VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR = VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE,
        VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR = VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION,
        VK_OBJECT_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 88
    /// <summary>VkPeerMemoryFeatureFlagBits - Bitmask specifying supported peer memory features</summary>
    public enum VkPeerMemoryFeatureFlagBits {
        /// <summary><code>VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT</code> specifies that the memory <strong class="purple">can</strong>
        /// be accessed as the source of a <a href="#vkCmdCopyBuffer">vkCmdCopyBuffer</a>,
        /// <a href="#vkCmdCopyImage">vkCmdCopyImage</a>, <a href="#vkCmdCopyBufferToImage">vkCmdCopyBufferToImage</a>, or
        /// <a href="#vkCmdCopyImageToBuffer">vkCmdCopyImageToBuffer</a> command.</summary>
        VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = 0x00000001,
        /// <summary><code>VK_PEER_MEMORY_FEATURE_COPY_DST_BIT</code> specifies that the memory <strong class="purple">can</strong>
        /// be accessed as the destination of a <a href="#vkCmdCopyBuffer">vkCmdCopyBuffer</a>,
        /// <a href="#vkCmdCopyImage">vkCmdCopyImage</a>, <a href="#vkCmdCopyBufferToImage">vkCmdCopyBufferToImage</a>, or
        /// <a href="#vkCmdCopyImageToBuffer">vkCmdCopyImageToBuffer</a> command.</summary>
        VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = 0x00000002,
        /// <summary><code>VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT</code> specifies that the memory
        /// <strong class="purple">can</strong> be read as any memory access type.</summary>
        VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = 0x00000004,
        /// <summary><code>VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT</code> specifies that the memory
        /// <strong class="purple">can</strong> be written as any memory access type.
        /// Shader atomics are considered to be writes.</summary>
        VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = 0x00000008,
        VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT,
        VK_PEER_MEMORY_FEATURE_COPY_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_DST_BIT,
        VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT,
        VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT,
        VK_PEER_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 89
    /// <summary>VkPhysicalDeviceType - Supported physical device types</summary>
    public enum VkPhysicalDeviceType {
        /// <summary><code>VK_PHYSICAL_DEVICE_TYPE_OTHER</code> - the device does not match any
        /// other available types.</summary>
        VK_PHYSICAL_DEVICE_TYPE_OTHER = 0,
        /// <summary><code>VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU</code> - the device is typically
        /// one embedded in or tightly coupled with the host.</summary>
        VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = 1,
        /// <summary><code>VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU</code> - the device is typically a
        /// separate processor connected to the host via an interlink.</summary>
        VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = 2,
        /// <summary><code>VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU</code> - the device is typically a
        /// virtual node in a virtualization environment.</summary>
        VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = 3,
        /// <summary><code>VK_PHYSICAL_DEVICE_TYPE_CPU</code> - the device is typically running on
        /// the same processors as the host.</summary>
        VK_PHYSICAL_DEVICE_TYPE_CPU = 4,
        VK_PHYSICAL_DEVICE_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 90
    /// <summary>VkPipelineBindPoint - Specify the bind point of a pipeline object to a command buffer</summary>
    public enum VkPipelineBindPoint {
        /// <summary><code>VK_PIPELINE_BIND_POINT_GRAPHICS</code> specifies binding as a graphics
        /// pipeline.</summary>
        VK_PIPELINE_BIND_POINT_GRAPHICS = 0,
        /// <summary><code>VK_PIPELINE_BIND_POINT_COMPUTE</code> specifies binding as a compute
        /// pipeline.</summary>
        VK_PIPELINE_BIND_POINT_COMPUTE = 1,
        /// <summary><code>VK_PIPELINE_BIND_POINT_RAY_TRACING_NV</code> specifies binding as a ray
        /// tracing pipeline.</summary>
        VK_PIPELINE_BIND_POINT_RAY_TRACING_NV = 1000165000,
        VK_PIPELINE_BIND_POINT_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 91
    /// <summary>VkPipelineCacheHeaderVersion - Encode pipeline cache version</summary>
    public enum VkPipelineCacheHeaderVersion {
        /// <summary><code>VK_PIPELINE_CACHE_HEADER_VERSION_ONE</code> specifies version one of the
        /// pipeline cache.</summary>
        VK_PIPELINE_CACHE_HEADER_VERSION_ONE = 1,
        VK_PIPELINE_CACHE_HEADER_VERSION_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 92
    /// <summary>VkPipelineCreateFlagBits - Bitmask controlling how a pipeline is created</summary>
    public enum VkPipelineCreateFlagBits {
        /// <summary><code>VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT</code> specifies that the
        /// created pipeline will not be optimized.
        /// Using this flag <strong class="purple">may</strong> reduce the time taken to create the pipeline.</summary>
        VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x00000001,
        /// <summary><code>VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT</code> specifies that the
        /// pipeline to be created is allowed to be the parent of a pipeline that
        /// will be created in a subsequent call to <a href="#vkCreateGraphicsPipelines">vkCreateGraphicsPipelines</a>
        /// or <a href="#vkCreateComputePipelines">vkCreateComputePipelines</a>.</summary>
        VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x00000002,
        /// <summary><code>VK_PIPELINE_CREATE_DERIVATIVE_BIT</code> specifies that the pipeline to
        /// be created will be a child of a previously created parent pipeline.</summary>
        VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x00000004,
        /// <summary><code>VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT</code> specifies that
        /// any shader input variables decorated as <code>ViewIndex</code> will be assigned
        /// values as if they were decorated as <code>DeviceIndex</code>.</summary>
        VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = 0x00000008,
        /// <summary><code>VK_PIPELINE_CREATE_DISPATCH_BASE</code> specifies that a compute pipeline
        /// <strong class="purple">can</strong> be used with <a href="#vkCmdDispatchBase">vkCmdDispatchBase</a> with a non-zero base
        /// workgroup.</summary>
        VK_PIPELINE_CREATE_DISPATCH_BASE = 0x00000010,
        /// <summary><code>VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV</code> specifies that a pipeline
        /// is created with all shaders in the deferred state.
        /// Before using the pipeline the application <strong class="purple">must</strong> call
        /// <a href="#vkCompileDeferredNV">vkCompileDeferredNV</a> exactly once on each shader in the pipeline
        /// before using the pipeline.</summary>
        VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = 0x00000020,
        VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR = VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT,
        VK_PIPELINE_CREATE_DISPATCH_BASE_KHR = VK_PIPELINE_CREATE_DISPATCH_BASE,
        VK_PIPELINE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 93
    /// <summary>VkPipelineCreationFeedbackFlagBitsEXT - Bitmask specifying pipeline or pipeline stage creation feedback</summary>
    public enum VkPipelineCreationFeedbackFlagBitsEXT {
        /// <summary><code>VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT</code> indicates that the
        /// feedback information is valid.</summary>
        VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = 0x00000001,
        /// <summary><code>VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT</code>
        /// indicates that a readily usable pipeline or pipeline stage was found in
        /// the <code>pipelineCache</code> specified by the application in the pipeline
        /// creation command.</summary>
        VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = 0x00000002,
        /// <summary><code>VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT</code>
        /// indicates that the base pipeline specified by the
        /// <code>basePipelineHandle</code> or <code>basePipelineIndex</code> member of the
        /// <code>Vk*PipelineCreateInfo</code> structure was used to accelerate the
        /// creation of the pipeline.</summary>
        VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT = 0x00000004,
        VK_PIPELINE_CREATION_FEEDBACK_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 94
    /// <summary>VkPipelineStageFlagBits - Bitmask specifying pipeline stages</summary>
    public enum VkPipelineStageFlagBits {
        /// <summary><code>VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT</code> specifies the stage of the
        /// pipeline where any commands are initially received by the queue.</summary>
        VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = 0x00000001,
        /// <summary><code>VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT</code> specifies the stage of the
        /// pipeline where Draw/DispatchIndirect data structures are consumed.
        /// This stage also includes reading commands written by
        /// <a href="#vkCmdProcessCommandsNVX">vkCmdProcessCommandsNVX</a>.</summary>
        VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = 0x00000002,
        /// <summary><code>VK_PIPELINE_STAGE_VERTEX_INPUT_BIT</code> specifies the stage of the
        /// pipeline where vertex and index buffers are consumed.</summary>
        VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = 0x00000004,
        /// <summary><code>VK_PIPELINE_STAGE_VERTEX_SHADER_BIT</code> specifies the vertex shader
        /// stage.</summary>
        VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = 0x00000008,
        /// <summary><code>VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT</code> specifies the
        /// tessellation control shader stage.</summary>
        VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT = 0x00000010,
        /// <summary><code>VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT</code> specifies the
        /// tessellation evaluation shader stage.</summary>
        VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT = 0x00000020,
        /// <summary><code>VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT</code> specifies the geometry
        /// shader stage.</summary>
        VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = 0x00000040,
        /// <summary><code>VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT</code> specifies the fragment
        /// shader stage.</summary>
        VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = 0x00000080,
        /// <summary><code>VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT</code> specifies the stage of
        /// the pipeline where early fragment tests (depth and stencil tests before
        /// fragment shading) are performed.
        /// This stage also includes <a href="vkspec.html#renderpass-load-store-ops">subpass load
        /// operations</a> for framebuffer attachments with a depth/stencil format.</summary>
        VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = 0x00000100,
        /// <summary><code>VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT</code> specifies the stage of
        /// the pipeline where late fragment tests (depth and stencil tests after
        /// fragment shading) are performed.
        /// This stage also includes <a href="vkspec.html#renderpass-load-store-ops">subpass store
        /// operations</a> for framebuffer attachments with a depth/stencil format.</summary>
        VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = 0x00000200,
        /// <summary><code>VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT</code> specifies the stage
        /// of the pipeline after blending where the final color values are output
        /// from the pipeline.
        /// This stage also includes <a href="vkspec.html#renderpass-load-store-ops">subpass load and
        /// store operations</a> and multisample resolve operations for framebuffer
        /// attachments with a color
        /// or depth/stencil
        /// format.</summary>
        VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = 0x00000400,
        /// <summary><code>VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT</code> specifies the execution of a
        /// compute shader.</summary>
        VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = 0x00000800,
        /// <summary><a id="synchronization-pipeline-stages-transfer"></a>
        ///   <code>VK_PIPELINE_STAGE_TRANSFER_BIT</code> specifies the execution of copy
        /// commands.
        /// This includes the operations resulting from all <a href="vkspec.html#copies">copy
        /// commands</a>, <a href="vkspec.html#clears">clear commands</a> (with the exception of
        /// <a href="#vkCmdClearAttachments">vkCmdClearAttachments</a>), and <a href="#vkCmdCopyQueryPoolResults">vkCmdCopyQueryPoolResults</a>.</summary>
        VK_PIPELINE_STAGE_TRANSFER_BIT = 0x00001000,
        /// <summary><code>VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT</code> specifies the final stage in
        /// the pipeline where operations generated by all commands complete
        /// execution.</summary>
        VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT = 0x00002000,
        /// <summary><code>VK_PIPELINE_STAGE_HOST_BIT</code> specifies a pseudo-stage indicating
        /// execution on the host of reads/writes of device memory.
        /// This stage is not invoked by any commands recorded in a command buffer.</summary>
        VK_PIPELINE_STAGE_HOST_BIT = 0x00004000,
        /// <summary><code>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT</code> specifies the execution of all
        /// graphics pipeline stages, and is equivalent to the logical OR of:</summary>
        VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT = 0x00008000,
        /// <summary><code>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</code> is equivalent to the logical OR
        /// of every other pipeline stage flag that is supported on the queue it is
        /// used with.</summary>
        VK_PIPELINE_STAGE_ALL_COMMANDS_BIT = 0x00010000,
        /// <summary><code>VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT</code></summary>
        VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT = 0x01000000,
        /// <summary><code>VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT</code></summary>
        VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT = 0x00040000,
        /// <summary><code>VK_PIPELINE_STAGE_COMMAND_PROCESS_BIT_NVX</code> specifies the stage of
        /// the pipeline where device-side generation of commands via
        /// <a href="#vkCmdProcessCommandsNVX">vkCmdProcessCommandsNVX</a> is handled.</summary>
        VK_PIPELINE_STAGE_COMMAND_PROCESS_BIT_NVX = 0x00020000,
        /// <summary><code>VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV</code></summary>
        VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV = 0x00400000,
        /// <summary><code>VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV</code> specifies the
        /// execution of the ray tracing shader stages.</summary>
        VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV = 0x00200000,
        /// <summary><code>VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV</code> specifies
        /// the execution of <a href="#vkCmdBuildAccelerationStructureNV">vkCmdBuildAccelerationStructureNV</a>,
        /// <a href="#vkCmdCopyAccelerationStructureNV">vkCmdCopyAccelerationStructureNV</a>, and
        /// <a href="#vkCmdWriteAccelerationStructuresPropertiesNV">vkCmdWriteAccelerationStructuresPropertiesNV</a>.</summary>
        VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV = 0x02000000,
        /// <summary><code>VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV</code> specifies the task shader
        /// stage.</summary>
        VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV = 0x00080000,
        /// <summary><code>VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV</code> specifies the mesh shader
        /// stage.</summary>
        VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV = 0x00100000,
        /// <summary><code>VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT</code></summary>
        VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 0x00800000,
        VK_PIPELINE_STAGE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 95
    /// <summary>VkPointClippingBehavior - Enum specifying the point clipping behavior</summary>
    public enum VkPointClippingBehavior {
        /// <summary><code>VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES</code> specifies that the
        /// primitive is discarded if the vertex lies outside any clip plane,
        /// including the planes bounding the view volume.</summary>
        VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = 0,
        /// <summary><code>VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY</code> specifies that
        /// the primitive is discarded only if the vertex lies outside any user clip
        /// plane.</summary>
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = 1,
        VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR = VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES,
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR = VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY,
        VK_POINT_CLIPPING_BEHAVIOR_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 96
    /// <summary>VkPolygonMode - Control polygon rasterization mode</summary>
    public enum VkPolygonMode {
        /// <summary><code>VK_POLYGON_MODE_FILL</code> specifies that polygons are rendered using
        /// the polygon rasterization rules in this section.</summary>
        VK_POLYGON_MODE_FILL = 0,
        /// <summary><code>VK_POLYGON_MODE_LINE</code> specifies that polygon edges are drawn as
        /// line segments.</summary>
        VK_POLYGON_MODE_LINE = 1,
        /// <summary><code>VK_POLYGON_MODE_POINT</code> specifies that polygon vertices are drawn as
        /// points.</summary>
        VK_POLYGON_MODE_POINT = 2,
        /// <summary><code>VK_POLYGON_MODE_FILL_RECTANGLE_NV</code> specifies that polygons are
        /// rendered using polygon rasterization rules, modified to consider a
        /// sample within the primitive if the sample location is inside the
        /// axis-aligned bounding box of the triangle after projection.
        /// Note that the barycentric weights used in attribute interpolation <strong class="purple">can</strong>
        /// extend outside the range <span class="eq">[0,1]</span> when these primitives are shaded.
        /// Special treatment is given to a sample position on the boundary edge of
        /// the bounding box.
        /// In such a case, if two rectangles lie on either side of a common edge
        /// (with identical endpoints) on which a sample position lies, then exactly
        /// one of the triangles <strong class="purple">must</strong> produce a fragment that covers that sample
        /// during rasterization.</summary>
        VK_POLYGON_MODE_FILL_RECTANGLE_NV = 1000153000,
        VK_POLYGON_MODE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 97
    /// <summary>VkPresentModeKHR - presentation mode supported for a surface</summary>
    public enum VkPresentModeKHR {
        /// <summary><code>VK_PRESENT_MODE_IMMEDIATE_KHR</code> specifies that the presentation
        /// engine does not wait for a vertical blanking period to update the
        /// current image, meaning this mode <strong class="purple">may</strong> result in visible tearing.
        /// No internal queuing of presentation requests is needed, as the requests
        /// are applied immediately.</summary>
        VK_PRESENT_MODE_IMMEDIATE_KHR = 0,
        /// <summary><code>VK_PRESENT_MODE_MAILBOX_KHR</code> specifies that the presentation engine
        /// waits for the next vertical blanking period to update the current image.
        /// Tearing <strong class="purple">cannot</strong> be observed.
        /// An internal single-entry queue is used to hold pending presentation
        /// requests.
        /// If the queue is full when a new presentation request is received, the
        /// new request replaces the existing entry, and any images associated with
        /// the prior entry become available for re-use by the application.
        /// One request is removed from the queue and processed during each vertical
        /// blanking period in which the queue is non-empty.</summary>
        VK_PRESENT_MODE_MAILBOX_KHR = 1,
        /// <summary><code>VK_PRESENT_MODE_FIFO_KHR</code> specifies that the presentation engine
        /// waits for the next vertical blanking period to update the current image.
        /// Tearing <strong class="purple">cannot</strong> be observed.
        /// An internal queue is used to hold pending presentation requests.
        /// New requests are appended to the end of the queue, and one request is
        /// removed from the beginning of the queue and processed during each
        /// vertical blanking period in which the queue is non-empty.
        /// This is the only value of <code>presentMode</code> that is <strong class="purple">required</strong> to be
        /// supported.</summary>
        VK_PRESENT_MODE_FIFO_KHR = 2,
        /// <summary><code>VK_PRESENT_MODE_FIFO_RELAXED_KHR</code> specifies that the presentation
        /// engine generally waits for the next vertical blanking period to update
        /// the current image.
        /// If a vertical blanking period has already passed since the last update
        /// of the current image then the presentation engine does not wait for
        /// another vertical blanking period for the update, meaning this mode <strong class="purple">may</strong>
        /// result in visible tearing in this case.
        /// This mode is useful for reducing visual stutter with an application that
        /// will mostly present a new image before the next vertical blanking
        /// period, but may occasionally be late, and present a new image just after
        /// the next vertical blanking period.
        /// An internal queue is used to hold pending presentation requests.
        /// New requests are appended to the end of the queue, and one request is
        /// removed from the beginning of the queue and processed during or after
        /// each vertical blanking period in which the queue is non-empty.</summary>
        VK_PRESENT_MODE_FIFO_RELAXED_KHR = 3,
        /// <summary><code>VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR</code> specifies that the
        /// presentation engine and application have concurrent access to a single
        /// image, which is referred to as a <em>shared presentable image</em>.
        /// The presentation engine is only required to update the current image
        /// after a new presentation request is received.
        /// Therefore the application <strong class="purple">must</strong> make a presentation request whenever an
        /// update is required.
        /// However, the presentation engine <strong class="purple">may</strong> update the current image at any
        /// point, meaning this mode <strong class="purple">may</strong> result in visible tearing.</summary>
        VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = 1000111000,
        /// <summary><code>VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR</code> specifies that the
        /// presentation engine and application have concurrent access to a single
        /// image, which is referred to as a <em>shared presentable image</em>.
        /// The presentation engine periodically updates the current image on its
        /// regular refresh cycle.
        /// The application is only required to make one initial presentation
        /// request, after which the presentation engine <strong class="purple">must</strong> update the current
        /// image without any need for further presentation requests.
        /// The application <strong class="purple">can</strong> indicate the image contents have been updated by
        /// making a presentation request, but this does not guarantee the timing of
        /// when it will be updated.
        /// This mode <strong class="purple">may</strong> result in visible tearing if rendering to the image is
        /// not timed correctly.</summary>
        VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = 1000111001,
        VK_PRESENT_MODE_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 98
    /// <summary>VkPrimitiveTopology - Supported primitive topologies</summary>
    public enum VkPrimitiveTopology {
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_POINT_LIST</code> specifies a series of
        /// <a href="vkspec.html#drawing-point-lists">separate point primitives</a>.</summary>
        VK_PRIMITIVE_TOPOLOGY_POINT_LIST = 0,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_LINE_LIST</code> specifies a series of
        /// <a href="vkspec.html#drawing-line-lists">separate line primitives</a>.</summary>
        VK_PRIMITIVE_TOPOLOGY_LINE_LIST = 1,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_LINE_STRIP</code> specifies a series of
        /// <a href="vkspec.html#drawing-line-strips">connected line primitives</a> with consecutive lines
        /// sharing a vertex.</summary>
        VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = 2,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST</code> specifies a series of
        /// <a href="vkspec.html#drawing-triangle-lists">separate triangle primitives</a>.</summary>
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = 3,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP</code> specifies a series of
        /// <a href="vkspec.html#drawing-triangle-strips">connected triangle primitives</a> with
        /// consecutive triangles sharing an edge.</summary>
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = 4,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN</code> specifies a series of
        /// <a href="vkspec.html#drawing-triangle-fans">connected triangle primitives</a> with all
        /// triangles sharing a common vertex.</summary>
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = 5,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY</code> specifies a series
        /// <a href="vkspec.html#drawing-line-lists-with-adjacency">separate line primitives with
        /// adjacency</a>.</summary>
        VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY = 6,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY</code> specifies a series
        /// <a href="vkspec.html#drawing-line-strips-with-adjacency">connected line primitives with
        /// adjacency</a>, with consecutive primitives sharing three vertices.</summary>
        VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY = 7,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY</code> specifies a
        /// series <a href="vkspec.html#drawing-line-lists-with-adjacency">separate triangle primitives
        /// with adjacency</a>.</summary>
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY = 8,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY</code> specifies
        /// <a href="vkspec.html#drawing-line-lists-with-adjacency">connected triangle primitives with
        /// adjacency</a>, with consecutive triangles sharing an edge.</summary>
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY = 9,
        /// <summary><code>VK_PRIMITIVE_TOPOLOGY_PATCH_LIST</code> specifies
        /// <a href="vkspec.html#drawing-patch-lists">separate patch primitives</a>.</summary>
        VK_PRIMITIVE_TOPOLOGY_PATCH_LIST = 10,
        VK_PRIMITIVE_TOPOLOGY_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 99
    /// <summary>VkQueryControlFlagBits - Bitmask specifying constraints on a query</summary>
    public enum VkQueryControlFlagBits {
        /// <summary><code>VK_QUERY_CONTROL_PRECISE_BIT</code> specifies the precision of
        /// <a href="vkspec.html#queries-occlusion">occlusion queries</a>.</summary>
        VK_QUERY_CONTROL_PRECISE_BIT = 0x00000001,
        VK_QUERY_CONTROL_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 100
    /// <summary>VkQueryPipelineStatisticFlagBits - Bitmask specifying queried pipeline statistics</summary>
    public enum VkQueryPipelineStatisticFlagBits {
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT</code> specifies
        /// that queries managed by the pool will count the number of vertices
        /// processed by the <a href="vkspec.html#drawing">input assembly</a> stage.
        /// Vertices corresponding to incomplete primitives <strong class="purple">may</strong> contribute to the
        /// count.</summary>
        VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT = 0x00000001,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// primitives processed by the <a href="vkspec.html#drawing">input assembly</a> stage.
        /// If primitive restart is enabled, restarting the primitive topology has
        /// no effect on the count.
        /// Incomplete primitives <strong class="purple">may</strong> be counted.</summary>
        VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT = 0x00000002,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// vertex shader invocations.
        /// This counter’s value is incremented each time a vertex shader is
        /// <a href="vkspec.html#shaders-vertex-execution">invoked</a>.</summary>
        VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT = 0x00000004,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// geometry shader invocations.
        /// This counter’s value is incremented each time a geometry shader is
        /// <a href="vkspec.html#shaders-geometry-execution">invoked</a>.
        /// In the case of <a href="vkspec.html#geometry-invocations">instanced geometry shaders</a>, the
        /// geometry shader invocations count is incremented for each separate
        /// instanced invocation.</summary>
        VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT = 0x00000008,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// primitives generated by geometry shader invocations.
        /// The counter’s value is incremented each time the geometry shader emits a
        /// primitive.
        /// Restarting primitive topology using the SPIR-V instructions
        /// <code>OpEndPrimitive</code> or <code>OpEndStreamPrimitive</code> has no effect on the
        /// geometry shader output primitives count.</summary>
        VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT = 0x00000010,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT</code> specifies
        /// that queries managed by the pool will count the number of primitives
        /// processed by the <a href="vkspec.html#vertexpostproc-clipping">Primitive Clipping</a> stage of
        /// the pipeline.
        /// The counter’s value is incremented each time a primitive reaches the
        /// primitive clipping stage.</summary>
        VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT = 0x00000020,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT</code> specifies that
        /// queries managed by the pool will count the number of primitives output
        /// by the <a href="vkspec.html#vertexpostproc-clipping">Primitive Clipping</a> stage of the
        /// pipeline.
        /// The counter’s value is incremented each time a primitive passes the
        /// primitive clipping stage.
        /// The actual number of primitives output by the primitive clipping stage
        /// for a particular input primitive is implementation-dependent but <strong class="purple">must</strong>
        /// satisfy the following conditions:</summary>
        VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT = 0x00000040,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// fragment shader invocations.
        /// The counter’s value is incremented each time the fragment shader is
        /// <a href="vkspec.html#shaders-fragment-execution">invoked</a>.</summary>
        VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT = 0x00000080,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// patches processed by the tessellation control shader.
        /// The counter’s value is incremented once for each patch for which a
        /// tessellation control shader is
        /// <a href="vkspec.html#shaders-tessellation-control-execution">invoked</a>.</summary>
        VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT = 0x00000100,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// invocations of the tessellation evaluation shader.
        /// The counter’s value is incremented each time the tessellation evaluation
        /// shader is <a href="vkspec.html#shaders-tessellation-evaluation-execution">invoked</a>.</summary>
        VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT = 0x00000200,
        /// <summary><code>VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT</code>
        /// specifies that queries managed by the pool will count the number of
        /// compute shader invocations.
        /// The counter’s value is incremented every time the compute shader is
        /// invoked.
        /// Implementations <strong class="purple">may</strong> skip the execution of certain compute shader
        /// invocations or execute additional compute shader invocations for
        /// implementation-dependent reasons as long as the results of rendering
        /// otherwise remain unchanged.</summary>
        VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT = 0x00000400,
        VK_QUERY_PIPELINE_STATISTIC_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 101
    /// <summary>VkQueryResultFlagBits - Bitmask specifying how and when query results are returned</summary>
    public enum VkQueryResultFlagBits {
        /// <summary><code>VK_QUERY_RESULT_64_BIT</code> specifies the results will be written as an
        /// array of 64-bit unsigned integer values.
        /// If this bit is not set, the results will be written as an array of
        /// 32-bit unsigned integer values.</summary>
        VK_QUERY_RESULT_64_BIT = 0x00000001,
        /// <summary><code>VK_QUERY_RESULT_WAIT_BIT</code> specifies that Vulkan will wait for each
        /// query’s status to become available before retrieving its results.</summary>
        VK_QUERY_RESULT_WAIT_BIT = 0x00000002,
        /// <summary><code>VK_QUERY_RESULT_WITH_AVAILABILITY_BIT</code> specifies that the
        /// availability status accompanies the results.</summary>
        VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = 0x00000004,
        /// <summary><code>VK_QUERY_RESULT_PARTIAL_BIT</code> specifies that returning partial
        /// results is acceptable.</summary>
        VK_QUERY_RESULT_PARTIAL_BIT = 0x00000008,
        VK_QUERY_RESULT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 102
    /// <summary>VkQueryType - Specify the type of queries managed by a query pool</summary>
    public enum VkQueryType {
        /// <summary><code>VK_QUERY_TYPE_OCCLUSION</code> specifies an <a href="vkspec.html#queries-occlusion">occlusion query</a>.</summary>
        VK_QUERY_TYPE_OCCLUSION = 0,
        /// <summary><code>VK_QUERY_TYPE_PIPELINE_STATISTICS</code> specifies a <a href="vkspec.html#queries-pipestats">pipeline statistics query</a>.</summary>
        VK_QUERY_TYPE_PIPELINE_STATISTICS = 1,
        /// <summary><code>VK_QUERY_TYPE_TIMESTAMP</code> specifies a <a href="vkspec.html#queries-timestamps">timestamp query</a>.</summary>
        VK_QUERY_TYPE_TIMESTAMP = 2,
        /// <summary><code>VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT</code> specifies a
        /// <a href="vkspec.html#queries-transform-feedback">transform feedback query</a>.</summary>
        VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = 1000028004,
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = 1000165000,
        VK_QUERY_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 103
    /// <summary>VkQueueFlagBits - Bitmask specifying capabilities of queues in a queue family</summary>
    public enum VkQueueFlagBits {
        /// <summary><code>VK_QUEUE_GRAPHICS_BIT</code> specifies that queues in this queue family
        /// support graphics operations.</summary>
        VK_QUEUE_GRAPHICS_BIT = 0x00000001,
        /// <summary><code>VK_QUEUE_COMPUTE_BIT</code> specifies that queues in this queue family
        /// support compute operations.</summary>
        VK_QUEUE_COMPUTE_BIT = 0x00000002,
        /// <summary><code>VK_QUEUE_TRANSFER_BIT</code> specifies that queues in this queue family
        /// support transfer operations.</summary>
        VK_QUEUE_TRANSFER_BIT = 0x00000004,
        /// <summary><code>VK_QUEUE_SPARSE_BINDING_BIT</code> specifies that queues in this queue
        /// family support sparse memory management operations (see
        /// <a href="vkspec.html#sparsememory">Sparse Resources</a>).
        /// If any of the sparse resource features are enabled, then at least one
        /// queue family <strong class="purple">must</strong> support this bit.</summary>
        VK_QUEUE_SPARSE_BINDING_BIT = 0x00000008,
        /// <summary>if <code>VK_QUEUE_PROTECTED_BIT</code> is set, then the queues in this queue
        /// family support the <code>VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT</code> bit.
        /// (see <a href="vkspec.html#memory-protected-memory">Protected Memory</a>).
        /// If the protected memory physical device feature is supported, then at
        /// least one queue family of at least one physical device exposed by the
        /// implementation <strong class="purple">must</strong> support this bit.</summary>
        VK_QUEUE_PROTECTED_BIT = 0x00000010,
        VK_QUEUE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 104
    /// <summary>VkQueueGlobalPriorityEXT - Values specifying a system-wide queue priority</summary>
    public enum VkQueueGlobalPriorityEXT {
        /// <summary><code>VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT</code> is below the system default.
        /// Useful for non-interactive tasks.</summary>
        VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = 128,
        /// <summary><code>VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT</code> is the system default
        /// priority.</summary>
        VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = 256,
        /// <summary><code>VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT</code> is above the system default.</summary>
        VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = 512,
        /// <summary><code>VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT</code> is the highest priority.
        /// Useful for critical tasks.</summary>
        VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = 1024,
        VK_QUEUE_GLOBAL_PRIORITY_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 105
    /// <summary>VkRasterizationOrderAMD - Specify rasterization order for a graphics pipeline</summary>
    public enum VkRasterizationOrderAMD {
        /// <summary><code>VK_RASTERIZATION_ORDER_STRICT_AMD</code> specifies that operations for
        /// each primitive in a subpass <strong class="purple">must</strong> occur in <a href="vkspec.html#drawing-primitive-order">primitive order</a>.</summary>
        VK_RASTERIZATION_ORDER_STRICT_AMD = 0,
        /// <summary><code>VK_RASTERIZATION_ORDER_RELAXED_AMD</code> specifies that operations for
        /// each primitive in a subpass <strong class="purple">may</strong> not occur in <a href="vkspec.html#drawing-primitive-order">primitive order</a>.</summary>
        VK_RASTERIZATION_ORDER_RELAXED_AMD = 1,
        VK_RASTERIZATION_ORDER_MAX_ENUM_AMD = 0x7FFFFFFF
    }
    // Enum: 106
    /// <summary>VkRayTracingShaderGroupTypeNV - Shader group types</summary>
    public enum VkRayTracingShaderGroupTypeNV {
        /// <summary><code>VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV</code> indicates a shader
        /// group with a single <code>VK_SHADER_STAGE_RAYGEN_BIT_NV</code>,
        /// <code>VK_SHADER_STAGE_MISS_BIT_NV</code>, or
        /// <code>VK_SHADER_STAGE_CALLABLE_BIT_NV</code> shader in it.</summary>
        VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV = 0,
        /// <summary><code>VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV</code> specifies
        /// a shader group that only hits triangles and <strong class="purple">must</strong> not contain an
        /// intersection shader, only closest hit and any-hit.</summary>
        VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV = 1,
        /// <summary><code>VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV</code> specifies
        /// a shader group that only intersects with custom geometry and <strong class="purple">must</strong>
        /// contain an intersection shader and <strong class="purple">may</strong> contain closest hit and any-hit
        /// shaders.</summary>
        VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV = 2,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 107
    /// <summary>VkResolveModeFlagBitsKHR - Bitmask indicating supported depth and stencil resolve modes</summary>
    public enum VkResolveModeFlagBitsKHR {
        /// <summary><code>VK_RESOLVE_MODE_NONE_KHR</code> indicates that no resolve operation is
        /// done.</summary>
        VK_RESOLVE_MODE_NONE_KHR = 0,
        /// <summary><code>VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR</code> indicates that result of the
        /// resolve operation is equal to the value of sample 0.</summary>
        VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = 0x00000001,
        /// <summary><code>VK_RESOLVE_MODE_AVERAGE_BIT_KHR</code> indicates that result of the
        /// resolve operation is the average of the sample values.</summary>
        VK_RESOLVE_MODE_AVERAGE_BIT_KHR = 0x00000002,
        /// <summary><code>VK_RESOLVE_MODE_MIN_BIT_KHR</code> indicates that result of the resolve
        /// operation is the minimum of the sample values.</summary>
        VK_RESOLVE_MODE_MIN_BIT_KHR = 0x00000004,
        /// <summary><code>VK_RESOLVE_MODE_MAX_BIT_KHR</code> indicates that result of the resolve
        /// operation is the maximum of the sample values.</summary>
        VK_RESOLVE_MODE_MAX_BIT_KHR = 0x00000008,
        VK_RESOLVE_MODE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 108
    /// <summary>VkResult - Vulkan command return codes</summary>
    public enum VkResult {
        /// <summary><code>VK_SUCCESS</code> Command successfully completed</summary>
        VK_SUCCESS = 0,
        /// <summary><code>VK_NOT_READY</code> A fence or query has not yet completed</summary>
        VK_NOT_READY = 1,
        /// <summary><code>VK_TIMEOUT</code> A wait operation has not completed in the specified
        /// time</summary>
        VK_TIMEOUT = 2,
        /// <summary><code>VK_EVENT_SET</code> An event is signaled</summary>
        VK_EVENT_SET = 3,
        /// <summary><code>VK_EVENT_RESET</code> An event is unsignaled</summary>
        VK_EVENT_RESET = 4,
        /// <summary><code>VK_INCOMPLETE</code> A return array was too small for the result</summary>
        VK_INCOMPLETE = 5,
        /// <summary><code>VK_ERROR_OUT_OF_HOST_MEMORY</code> A host memory allocation has failed.</summary>
        VK_ERROR_OUT_OF_HOST_MEMORY = -1,
        /// <summary><code>VK_ERROR_OUT_OF_DEVICE_MEMORY</code> A device memory allocation has
        /// failed.</summary>
        VK_ERROR_OUT_OF_DEVICE_MEMORY = -2,
        /// <summary><code>VK_ERROR_INITIALIZATION_FAILED</code> Initialization of an object could
        /// not be completed for implementation-specific reasons.</summary>
        VK_ERROR_INITIALIZATION_FAILED = -3,
        /// <summary><code>VK_ERROR_DEVICE_LOST</code> The logical or physical device has been lost.
        /// See <a href="vkspec.html#devsandqueues-lost-device">Lost Device</a></summary>
        VK_ERROR_DEVICE_LOST = -4,
        /// <summary><code>VK_ERROR_MEMORY_MAP_FAILED</code> Mapping of a memory object has failed.</summary>
        VK_ERROR_MEMORY_MAP_FAILED = -5,
        /// <summary><code>VK_ERROR_LAYER_NOT_PRESENT</code> A requested layer is not present or
        /// could not be loaded.</summary>
        VK_ERROR_LAYER_NOT_PRESENT = -6,
        /// <summary><code>VK_ERROR_EXTENSION_NOT_PRESENT</code> A requested extension is not
        /// supported.</summary>
        VK_ERROR_EXTENSION_NOT_PRESENT = -7,
        /// <summary><code>VK_ERROR_FEATURE_NOT_PRESENT</code> A requested feature is not supported.</summary>
        VK_ERROR_FEATURE_NOT_PRESENT = -8,
        /// <summary><code>VK_ERROR_INCOMPATIBLE_DRIVER</code> The requested version of Vulkan is
        /// not supported by the driver or is otherwise incompatible for
        /// implementation-specific reasons.</summary>
        VK_ERROR_INCOMPATIBLE_DRIVER = -9,
        /// <summary><code>VK_ERROR_TOO_MANY_OBJECTS</code> Too many objects of the type have
        /// already been created.</summary>
        VK_ERROR_TOO_MANY_OBJECTS = -10,
        /// <summary><code>VK_ERROR_FORMAT_NOT_SUPPORTED</code> A requested format is not supported
        /// on this device.</summary>
        VK_ERROR_FORMAT_NOT_SUPPORTED = -11,
        /// <summary><code>VK_ERROR_FRAGMENTED_POOL</code> A pool allocation has failed due to
        /// fragmentation of the pool’s memory.
        /// This <strong class="purple">must</strong> only be returned if no attempt to allocate host or device
        /// memory was made to accommodate the new allocation.
        /// This <strong class="purple">should</strong> be returned in preference to
        /// <code>VK_ERROR_OUT_OF_POOL_MEMORY</code>, but only if the implementation is
        /// certain that the pool allocation failure was due to fragmentation.</summary>
        VK_ERROR_FRAGMENTED_POOL = -12,
        /// <summary><code>VK_ERROR_OUT_OF_POOL_MEMORY</code> A pool memory allocation has failed.
        /// This <strong class="purple">must</strong> only be returned if no attempt to allocate host or device
        /// memory was made to accommodate the new allocation.
        /// If the failure was definitely due to fragmentation of the pool,
        /// <code>VK_ERROR_FRAGMENTED_POOL</code><strong class="purple">should</strong> be returned instead.</summary>
        VK_ERROR_OUT_OF_POOL_MEMORY = -1000069000,
        /// <summary><code>VK_ERROR_INVALID_EXTERNAL_HANDLE</code> An external handle is not a valid
        /// handle of the specified type.</summary>
        VK_ERROR_INVALID_EXTERNAL_HANDLE = -1000072003,
        /// <summary><code>VK_ERROR_SURFACE_LOST_KHR</code> A surface is no longer available.</summary>
        VK_ERROR_SURFACE_LOST_KHR = -1000000000,
        /// <summary><code>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</code> The requested window is already
        /// in use by Vulkan or another API in a manner which prevents it from being
        /// used again.</summary>
        VK_ERROR_NATIVE_WINDOW_IN_USE_KHR = -1000000001,
        /// <summary><code>VK_SUBOPTIMAL_KHR</code> A swapchain no longer matches the surface
        /// properties exactly, but <strong class="purple">can</strong> still be used to present to the surface
        /// successfully.</summary>
        VK_SUBOPTIMAL_KHR = 1000001003,
        /// <summary><code>VK_ERROR_OUT_OF_DATE_KHR</code> A surface has changed in such a way that
        /// it is no longer compatible with the swapchain, and further presentation
        /// requests using the swapchain will fail.
        /// Applications <strong class="purple">must</strong> query the new surface properties and recreate their
        /// swapchain if they wish to continue presenting to the surface.</summary>
        VK_ERROR_OUT_OF_DATE_KHR = -1000001004,
        /// <summary><code>VK_ERROR_INCOMPATIBLE_DISPLAY_KHR</code> The display used by a swapchain
        /// does not use the same presentable image layout, or is incompatible in a
        /// way that prevents sharing an image.</summary>
        VK_ERROR_INCOMPATIBLE_DISPLAY_KHR = -1000003001,
        VK_ERROR_VALIDATION_FAILED_EXT = -1000011001,
        /// <summary><code>VK_ERROR_INVALID_SHADER_NV</code> One or more shaders failed to compile
        /// or link.
        /// More details are reported back to the application via
        /// <code><a href="vkspec.html#VK_EXT_debug_report" class="bare">html/vkspec.html#VK_EXT_debug_report</a></code> if enabled.</summary>
        VK_ERROR_INVALID_SHADER_NV = -1000012000,
        VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT = -1000158000,
        /// <summary><code>VK_ERROR_FRAGMENTATION_EXT</code> A descriptor pool creation has failed
        /// due to fragmentation.</summary>
        VK_ERROR_FRAGMENTATION_EXT = -1000161000,
        VK_ERROR_NOT_PERMITTED_EXT = -1000174001,
        /// <summary><code>VK_ERROR_INVALID_DEVICE_ADDRESS_EXT</code> A buffer creation failed
        /// because the requested address is not available.</summary>
        VK_ERROR_INVALID_DEVICE_ADDRESS_EXT = -1000244000,
        /// <summary><code>VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</code> An operation on a
        /// swapchain created with
        /// <code>VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT</code> failed as it
        /// did not have exlusive full-screen access.
        /// This <strong class="purple">may</strong> occur due to implementation-dependent reasons, outside of the
        /// application’s control.</summary>
        VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT = -1000255000,
        VK_ERROR_OUT_OF_POOL_MEMORY_KHR = VK_ERROR_OUT_OF_POOL_MEMORY,
        VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR = VK_ERROR_INVALID_EXTERNAL_HANDLE,
        VK_RESULT_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 109
    /// <summary>VkSampleCountFlagBits - Bitmask specifying sample counts supported for an image used for storage operations</summary>
    public enum VkSampleCountFlagBits {
        /// <summary><code>VK_SAMPLE_COUNT_1_BIT</code> specifies an image with one sample per
        /// pixel.</summary>
        VK_SAMPLE_COUNT_1_BIT = 0x00000001,
        /// <summary><code>VK_SAMPLE_COUNT_2_BIT</code> specifies an image with 2 samples per pixel.</summary>
        VK_SAMPLE_COUNT_2_BIT = 0x00000002,
        /// <summary><code>VK_SAMPLE_COUNT_4_BIT</code> specifies an image with 4 samples per pixel.</summary>
        VK_SAMPLE_COUNT_4_BIT = 0x00000004,
        /// <summary><code>VK_SAMPLE_COUNT_8_BIT</code> specifies an image with 8 samples per pixel.</summary>
        VK_SAMPLE_COUNT_8_BIT = 0x00000008,
        /// <summary><code>VK_SAMPLE_COUNT_16_BIT</code> specifies an image with 16 samples per
        /// pixel.</summary>
        VK_SAMPLE_COUNT_16_BIT = 0x00000010,
        /// <summary><code>VK_SAMPLE_COUNT_32_BIT</code> specifies an image with 32 samples per
        /// pixel.</summary>
        VK_SAMPLE_COUNT_32_BIT = 0x00000020,
        /// <summary><code>VK_SAMPLE_COUNT_64_BIT</code> specifies an image with 64 samples per
        /// pixel.</summary>
        VK_SAMPLE_COUNT_64_BIT = 0x00000040,
        VK_SAMPLE_COUNT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 110
    /// <summary>VkSamplerAddressMode - Specify behavior of sampling with texture coordinates outside an image</summary>
    public enum VkSamplerAddressMode {
        /// <summary><code>VK_SAMPLER_ADDRESS_MODE_REPEAT</code> specifies that the repeat wrap mode
        /// will be used.</summary>
        VK_SAMPLER_ADDRESS_MODE_REPEAT = 0,
        /// <summary><code>VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT</code> specifies that the
        /// mirrored repeat wrap mode will be used.</summary>
        VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = 1,
        /// <summary><code>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE</code> specifies that the clamp to
        /// edge wrap mode will be used.</summary>
        VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = 2,
        /// <summary><code>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER</code> specifies that the clamp
        /// to border wrap mode will be used.</summary>
        VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = 3,
        /// <summary><code>VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE</code> specifies that the
        /// mirror clamp to edge wrap mode will be used.
        /// This is only valid if the <code><a href="vkspec.html#VK_KHR_sampler_mirror_clamp_to_edge" class="bare">html/vkspec.html#VK_KHR_sampler_mirror_clamp_to_edge</a></code>
        /// extension is enabled.</summary>
        VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = 4,
        VK_SAMPLER_ADDRESS_MODE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 111
    /// <summary>VkSamplerCreateFlagBits - Bitmask specifying additional parameters of sampler</summary>
    public enum VkSamplerCreateFlagBits {
        /// <summary><a id="samplers-subsamplesampler"></a>
        ///   <code>VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT</code>
        /// specifies that the sampler will read from an image created with
        /// <code>flags</code> containing <code>VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT</code>.</summary>
        VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = 0x00000001,
        /// <summary><code>VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT</code>
        /// specifies that the implementation <strong class="purple">may</strong> use approximations when
        /// reconstructing a full color value for texture access from a subsampled
        /// image.</summary>
        VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = 0x00000002,
        VK_SAMPLER_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 112
    /// <summary>VkSamplerMipmapMode - Specify mipmap mode used for texture lookups</summary>
    public enum VkSamplerMipmapMode {
        /// <summary><code>VK_SAMPLER_MIPMAP_MODE_NEAREST</code> specifies nearest filtering.</summary>
        VK_SAMPLER_MIPMAP_MODE_NEAREST = 0,
        /// <summary><code>VK_SAMPLER_MIPMAP_MODE_LINEAR</code> specifies linear filtering.</summary>
        VK_SAMPLER_MIPMAP_MODE_LINEAR = 1,
        VK_SAMPLER_MIPMAP_MODE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 113
    /// <summary>VkSamplerReductionModeEXT - Specify reduction mode for texture filtering</summary>
    public enum VkSamplerReductionModeEXT {
        /// <summary><code>VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT</code> specifies that
        /// texel values are combined by computing a weighted average of values in
        /// the footprint, using weights as specified in
        /// <a href="vkspec.html#textures-unnormalized-to-integer">the image operations chapter</a>.</summary>
        VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT = 0,
        /// <summary><code>VK_SAMPLER_REDUCTION_MODE_MIN_EXT</code> specifies that texel values are
        /// combined by taking the component-wise minimum of values in the footprint
        /// with non-zero weights.</summary>
        VK_SAMPLER_REDUCTION_MODE_MIN_EXT = 1,
        /// <summary><code>VK_SAMPLER_REDUCTION_MODE_MAX_EXT</code> specifies that texel values are
        /// combined by taking the component-wise maximum of values in the footprint
        /// with non-zero weights.</summary>
        VK_SAMPLER_REDUCTION_MODE_MAX_EXT = 2,
        VK_SAMPLER_REDUCTION_MODE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 114
    /// <summary>VkSamplerYcbcrModelConversion - Color model component of a color space</summary>
    public enum VkSamplerYcbcrModelConversion {
        /// <summary><code>VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY</code> specifies that the
        /// input values to the conversion are unmodified.</summary>
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY = 0,
        /// <summary><code>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY</code> specifies no
        /// model conversion but the inputs are range expanded as for Y’C<sub>B</sub>C<sub>R</sub>.</summary>
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY = 1,
        /// <summary><code>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709</code> specifies the color
        /// model conversion from Y’C<sub>B</sub>C<sub>R</sub> to R’G’B' defined in BT.709 and
        /// described in the “BT.709 Y’C<sub>B</sub>C<sub>R</sub> conversion” section of the
        /// <a href="vkspec.html#data-format">Khronos Data Format Specification</a>.</summary>
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 = 2,
        /// <summary><code>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601</code> specifies the color
        /// model conversion from Y’C<sub>B</sub>C<sub>R</sub> to R’G’B' defined in BT.601 and
        /// described in the “BT.601 Y’C<sub>B</sub>C<sub>R</sub> conversion” section of the
        /// <a href="vkspec.html#data-format">Khronos Data Format Specification</a>.</summary>
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 = 3,
        /// <summary><code>VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020</code> specifies the color
        /// model conversion from Y’C<sub>B</sub>C<sub>R</sub> to R’G’B' defined in BT.2020 and
        /// described in the “BT.2020 Y’C<sub>B</sub>C<sub>R</sub> conversion” section of the
        /// <a href="vkspec.html#data-format">Khronos Data Format Specification</a>.</summary>
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 = 4,
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY,
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY,
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709,
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601,
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020,
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 115
    /// <summary>VkSamplerYcbcrRange - Range of encoded values in a color space</summary>
    public enum VkSamplerYcbcrRange {
        /// <summary><code>VK_SAMPLER_YCBCR_RANGE_ITU_FULL</code> specifies that the full range of
        /// the encoded values are valid and interpreted according to the ITU “full
        /// range” quantization rules.</summary>
        VK_SAMPLER_YCBCR_RANGE_ITU_FULL = 0,
        /// <summary><code>VK_SAMPLER_YCBCR_RANGE_ITU_NARROW</code> specifies that headroom and foot
        /// room are reserved in the numerical range of encoded values, and the
        /// remaining values are expanded according to the ITU “narrow range”
        /// quantization rules.</summary>
        VK_SAMPLER_YCBCR_RANGE_ITU_NARROW = 1,
        VK_SAMPLER_YCBCR_RANGE_ITU_FULL_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_FULL,
        VK_SAMPLER_YCBCR_RANGE_ITU_NARROW_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_NARROW,
        VK_SAMPLER_YCBCR_RANGE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 116
    /// <summary>VkScopeNV - Specify SPIR-V scope</summary>
    public enum VkScopeNV {
        /// <summary><code>VK_SCOPE_DEVICE_NV</code> corresponds to SPIR-V <code>Device</code> scope.</summary>
        VK_SCOPE_DEVICE_NV = 1,
        /// <summary><code>VK_SCOPE_WORKGROUP_NV</code> corresponds to SPIR-V <code>Workgroup</code> scope.</summary>
        VK_SCOPE_WORKGROUP_NV = 2,
        /// <summary><code>VK_SCOPE_SUBGROUP_NV</code> corresponds to SPIR-V <code>Subgroup</code> scope.</summary>
        VK_SCOPE_SUBGROUP_NV = 3,
        /// <summary><code>VK_SCOPE_QUEUE_FAMILY_NV</code> corresponds to SPIR-V <code>QueueFamilyKHR</code>
        /// scope.</summary>
        VK_SCOPE_QUEUE_FAMILY_NV = 5,
        VK_SCOPE_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 117
    /// <summary>VkSemaphoreImportFlagBits - Bitmask specifying additional parameters of semaphore payload import</summary>
    public enum VkSemaphoreImportFlagBits {
        /// <summary><code>VK_SEMAPHORE_IMPORT_TEMPORARY_BIT</code> specifies that the semaphore
        /// payload will be imported only temporarily, as described in
        /// <a href="vkspec.html#synchronization-semaphores-importing">Importing Semaphore Payloads</a>,
        /// regardless of the permanence of <code>handleType</code>.</summary>
        VK_SEMAPHORE_IMPORT_TEMPORARY_BIT = 0x00000001,
        VK_SEMAPHORE_IMPORT_TEMPORARY_BIT_KHR = VK_SEMAPHORE_IMPORT_TEMPORARY_BIT,
        VK_SEMAPHORE_IMPORT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 118
    /// <summary>VkShaderInfoTypeAMD - Enum specifying which type of shader info to query</summary>
    public enum VkShaderInfoTypeAMD {
        /// <summary><code>VK_SHADER_INFO_TYPE_STATISTICS_AMD</code> specifies that device resources
        /// used by a shader will be queried.</summary>
        VK_SHADER_INFO_TYPE_STATISTICS_AMD = 0,
        /// <summary><code>VK_SHADER_INFO_TYPE_BINARY_AMD</code> specifies that
        /// implementation-specific information will be queried.</summary>
        VK_SHADER_INFO_TYPE_BINARY_AMD = 1,
        /// <summary><code>VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD</code> specifies that human-readable
        /// dissassembly of a shader.</summary>
        VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = 2,
        VK_SHADER_INFO_TYPE_MAX_ENUM_AMD = 0x7FFFFFFF
    }
    // Enum: 119
    /// <summary>VkShaderStageFlagBits - Bitmask specifying a pipeline stage</summary>
    public enum VkShaderStageFlagBits {
        /// <summary><code>VK_SHADER_STAGE_VERTEX_BIT</code> specifies the vertex stage.</summary>
        VK_SHADER_STAGE_VERTEX_BIT = 0x00000001,
        /// <summary><code>VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT</code> specifies the
        /// tessellation control stage.</summary>
        VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = 0x00000002,
        /// <summary><code>VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT</code> specifies the
        /// tessellation evaluation stage.</summary>
        VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = 0x00000004,
        /// <summary><code>VK_SHADER_STAGE_GEOMETRY_BIT</code> specifies the geometry stage.</summary>
        VK_SHADER_STAGE_GEOMETRY_BIT = 0x00000008,
        /// <summary><code>VK_SHADER_STAGE_FRAGMENT_BIT</code> specifies the fragment stage.</summary>
        VK_SHADER_STAGE_FRAGMENT_BIT = 0x00000010,
        /// <summary><code>VK_SHADER_STAGE_COMPUTE_BIT</code> specifies the compute stage.</summary>
        VK_SHADER_STAGE_COMPUTE_BIT = 0x00000020,
        /// <summary><code>VK_SHADER_STAGE_ALL_GRAPHICS</code> is a combination of bits used as
        /// shorthand to specify all graphics stages defined above (excluding the
        /// compute stage).</summary>
        VK_SHADER_STAGE_ALL_GRAPHICS = 0x0000001F,
        /// <summary><code>VK_SHADER_STAGE_ALL</code> is a combination of bits used as shorthand to
        /// specify all shader stages supported by the device, including all
        /// additional stages which are introduced by extensions.</summary>
        VK_SHADER_STAGE_ALL = 0x7FFFFFFF,
        /// <summary><code>VK_SHADER_STAGE_RAYGEN_BIT_NV</code> specifies the ray generation stage.</summary>
        VK_SHADER_STAGE_RAYGEN_BIT_NV = 0x00000100,
        /// <summary><code>VK_SHADER_STAGE_ANY_HIT_BIT_NV</code> specifies the any-hit stage.</summary>
        VK_SHADER_STAGE_ANY_HIT_BIT_NV = 0x00000200,
        /// <summary><code>VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV</code> specifies the closest hit
        /// stage.</summary>
        VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV = 0x00000400,
        /// <summary><code>VK_SHADER_STAGE_MISS_BIT_NV</code> specifies the miss stage.</summary>
        VK_SHADER_STAGE_MISS_BIT_NV = 0x00000800,
        /// <summary><code>VK_SHADER_STAGE_INTERSECTION_BIT_NV</code> specifies the intersection
        /// stage.</summary>
        VK_SHADER_STAGE_INTERSECTION_BIT_NV = 0x00001000,
        /// <summary><code>VK_SHADER_STAGE_CALLABLE_BIT_NV</code> specifies the callable stage.</summary>
        VK_SHADER_STAGE_CALLABLE_BIT_NV = 0x00002000,
        /// <summary><code>VK_SHADER_STAGE_TASK_BIT_NV</code> specifies the task stage.</summary>
        VK_SHADER_STAGE_TASK_BIT_NV = 0x00000040,
        /// <summary><code>VK_SHADER_STAGE_MESH_BIT_NV</code> specifies the mesh stage.</summary>
        VK_SHADER_STAGE_MESH_BIT_NV = 0x00000080,
        VK_SHADER_STAGE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 120
    /// <summary>VkShadingRatePaletteEntryNV - Shading rate image palette entry types</summary>
    public enum VkShadingRatePaletteEntryNV {
        /// <summary>The following table indicates the width and height (in pixels) of each
        /// fragment generated using the indicated shading rate, as well as the maximum
        /// number of fragment shader invocations launched for each fragment.
        /// When processing regions of a primitive that have a shading rate of
        /// <code>VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV</code>, no fragments will be
        /// generated in that region.</summary>
        VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = 0,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = 1,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = 2,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = 3,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = 4,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = 5,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = 6,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = 7,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = 8,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = 10,
        /// <summary>class="tableblock">
        ///   <code>VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV</code></summary>
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = 11,
        VK_SHADING_RATE_PALETTE_ENTRY_MAX_ENUM_NV = 0x7FFFFFFF
    }
    // Enum: 121
    /// <summary>VkSharingMode - Buffer and image sharing modes</summary>
    public enum VkSharingMode {
        /// <summary><code>VK_SHARING_MODE_EXCLUSIVE</code> specifies that access to any range or
        /// image subresource of the object will be exclusive to a single queue
        /// family at a time.</summary>
        VK_SHARING_MODE_EXCLUSIVE = 0,
        /// <summary><code>VK_SHARING_MODE_CONCURRENT</code> specifies that concurrent access to any
        /// range or image subresource of the object from multiple queue families is
        /// supported.</summary>
        VK_SHARING_MODE_CONCURRENT = 1,
        VK_SHARING_MODE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 122
    /// <summary>VkSparseImageFormatFlagBits - Bitmask specifying additional information about a sparse image resource</summary>
    public enum VkSparseImageFormatFlagBits {
        /// <summary><code>VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT</code> specifies that the image
        /// uses a single mip tail region for all array layers.</summary>
        VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = 0x00000001,
        /// <summary><code>VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT</code> specifies that the
        /// first mip level whose dimensions are not integer multiples of the
        /// corresponding dimensions of the sparse image block begins the mip tail
        /// region.</summary>
        VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = 0x00000002,
        /// <summary><code>VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT</code> specifies that
        /// the image uses non-standard sparse image block dimensions, and the
        /// <code>imageGranularity</code> values do not match the standard sparse image
        /// block dimensions for the given format.</summary>
        VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = 0x00000004,
        VK_SPARSE_IMAGE_FORMAT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 123
    /// <summary>VkSparseMemoryBindFlagBits - Bitmask specifying usage of a sparse memory binding operation</summary>
    public enum VkSparseMemoryBindFlagBits {
        /// <summary><code>VK_SPARSE_MEMORY_BIND_METADATA_BIT</code> specifies that the memory being
        /// bound is only for the metadata aspect.</summary>
        VK_SPARSE_MEMORY_BIND_METADATA_BIT = 0x00000001,
        VK_SPARSE_MEMORY_BIND_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 124
    /// <summary>VkStencilFaceFlagBits - Bitmask specifying sets of stencil state for which to update the compare mask</summary>
    public enum VkStencilFaceFlagBits {
        /// <summary><code>VK_STENCIL_FACE_FRONT_BIT</code> specifies that only the front set of
        /// stencil state is updated.</summary>
        VK_STENCIL_FACE_FRONT_BIT = 0x00000001,
        /// <summary><code>VK_STENCIL_FACE_BACK_BIT</code> specifies that only the back set of
        /// stencil state is updated.</summary>
        VK_STENCIL_FACE_BACK_BIT = 0x00000002,
        /// <summary><code>VK_STENCIL_FRONT_AND_BACK</code> is the combination of
        /// <code>VK_STENCIL_FACE_FRONT_BIT</code> and <code>VK_STENCIL_FACE_BACK_BIT</code>, and
        /// specifies that both sets of stencil state are updated.</summary>
        VK_STENCIL_FRONT_AND_BACK = 0x00000003,
        VK_STENCIL_FACE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 125
    /// <summary>VkStencilOp - Stencil comparison function</summary>
    public enum VkStencilOp {
        /// <summary><code>VK_STENCIL_OP_KEEP</code> keeps the current value.</summary>
        VK_STENCIL_OP_KEEP = 0,
        /// <summary><code>VK_STENCIL_OP_ZERO</code> sets the value to 0.</summary>
        VK_STENCIL_OP_ZERO = 1,
        /// <summary><code>VK_STENCIL_OP_REPLACE</code> sets the value to <code>reference</code>.</summary>
        VK_STENCIL_OP_REPLACE = 2,
        /// <summary><code>VK_STENCIL_OP_INCREMENT_AND_CLAMP</code> increments the current value and
        /// clamps to the maximum representable unsigned value.</summary>
        VK_STENCIL_OP_INCREMENT_AND_CLAMP = 3,
        /// <summary><code>VK_STENCIL_OP_DECREMENT_AND_CLAMP</code> decrements the current value and
        /// clamps to 0.</summary>
        VK_STENCIL_OP_DECREMENT_AND_CLAMP = 4,
        /// <summary><code>VK_STENCIL_OP_INVERT</code> bitwise-inverts the current value.</summary>
        VK_STENCIL_OP_INVERT = 5,
        /// <summary><code>VK_STENCIL_OP_INCREMENT_AND_WRAP</code> increments the current value and
        /// wraps to 0 when the maximum value would have been exceeded.</summary>
        VK_STENCIL_OP_INCREMENT_AND_WRAP = 6,
        /// <summary><code>VK_STENCIL_OP_DECREMENT_AND_WRAP</code> decrements the current value and
        /// wraps to the maximum possible value when the value would go below 0.</summary>
        VK_STENCIL_OP_DECREMENT_AND_WRAP = 7,
        VK_STENCIL_OP_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 126
    /// <summary>VkStructureType - Vulkan structure types (<code>stype</code>)</summary>
    public enum VkStructureType {
        VK_STRUCTURE_TYPE_APPLICATION_INFO = 0,
        VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1,
        VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2,
        VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3,
        VK_STRUCTURE_TYPE_SUBMIT_INFO = 4,
        VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = 5,
        VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 6,
        VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = 7,
        VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 8,
        VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 9,
        VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 10,
        VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 11,
        VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 12,
        VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 13,
        VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 14,
        VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 15,
        VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 16,
        VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 17,
        VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 18,
        VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 19,
        VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 20,
        VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 21,
        VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 22,
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = 23,
        VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 24,
        VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 25,
        VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 26,
        VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = 27,
        VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 28,
        VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 29,
        VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 30,
        VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 31,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 32,
        VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 33,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = 34,
        VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 35,
        VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 36,
        VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 37,
        VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 38,
        VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = 39,
        VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = 40,
        VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = 41,
        VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = 42,
        VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 43,
        VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 44,
        VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 45,
        VK_STRUCTURE_TYPE_MEMORY_BARRIER = 46,
        /// <summary>The values <code>VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO</code> and
        /// <code>VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO</code> are reserved for internal
        /// use by the loader, and do not have corresponding Vulkan structures in this
        /// Specification.</summary>
        VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = 47,
        VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = 48,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES = 1000094000,
        VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO = 1000157000,
        VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO = 1000157001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES = 1000083000,
        VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS = 1000127000,
        VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO = 1000127001,
        VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO = 1000060000,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO = 1000060003,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO = 1000060004,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO = 1000060005,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO = 1000060006,
        VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO = 1000060013,
        VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO = 1000060014,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES = 1000070000,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO = 1000070001,
        VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2 = 1000146000,
        VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2 = 1000146001,
        VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2 = 1000146002,
        VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2 = 1000146003,
        VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2 = 1000146004,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2 = 1000059000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2 = 1000059001,
        VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2 = 1000059002,
        VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2 = 1000059003,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2 = 1000059004,
        VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2 = 1000059005,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2 = 1000059006,
        VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2 = 1000059007,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2 = 1000059008,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES = 1000117000,
        VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO = 1000117001,
        VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO = 1000117002,
        VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO = 1000117003,
        VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO = 1000053000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES = 1000053001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES = 1000053002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES = 1000120000,
        VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO = 1000145000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES = 1000145001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES = 1000145002,
        VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2 = 1000145003,
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO = 1000156000,
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO = 1000156001,
        VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO = 1000156002,
        VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO = 1000156003,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES = 1000156004,
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES = 1000156005,
        VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO = 1000085000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO = 1000071000,
        VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES = 1000071001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO = 1000071002,
        VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES = 1000071003,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES = 1000071004,
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO = 1000072000,
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO = 1000072001,
        VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO = 1000072002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO = 1000112000,
        VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES = 1000112001,
        VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO = 1000113000,
        VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO = 1000077000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO = 1000076000,
        VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES = 1000076001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES = 1000168000,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT = 1000168001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES = 1000063000,
        VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = 1000001000,
        VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = 1000001001,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = 1000060007,
        VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = 1000060008,
        VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = 1000060009,
        VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = 1000060010,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = 1000060011,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = 1000060012,
        VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = 1000002000,
        VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = 1000002001,
        VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = 1000003000,
        VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = 1000004000,
        VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = 1000005000,
        VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = 1000006000,
        VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = 1000008000,
        VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = 1000009000,
        VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = 1000011000,
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = 1000018000,
        VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = 1000022000,
        VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = 1000022001,
        VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = 1000022002,
        VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = 1000026000,
        VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = 1000026001,
        VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = 1000026002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = 1000028000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = 1000028001,
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = 1000028002,
        VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = 1000030000,
        VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = 1000041000,
        VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = 1000049000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = 1000050000,
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = 1000056000,
        VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = 1000056001,
        VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057000,
        VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057001,
        VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = 1000058000,
        VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = 1000061000,
        VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = 1000062000,
        VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = 1000067000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = 1000067001,
        VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073000,
        VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073001,
        VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = 1000073002,
        VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = 1000073003,
        VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = 1000074000,
        VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = 1000074001,
        VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = 1000074002,
        VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = 1000075000,
        VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078000,
        VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078001,
        VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = 1000078002,
        VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = 1000078003,
        VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = 1000079000,
        VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = 1000079001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR = 1000080000,
        VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = 1000081000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = 1000081001,
        VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = 1000081002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR = 1000082000,
        VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = 1000084000,
        VK_STRUCTURE_TYPE_OBJECT_TABLE_CREATE_INFO_NVX = 1000086000,
        VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NVX = 1000086001,
        VK_STRUCTURE_TYPE_CMD_PROCESS_COMMANDS_INFO_NVX = 1000086002,
        VK_STRUCTURE_TYPE_CMD_RESERVE_SPACE_FOR_COMMANDS_INFO_NVX = 1000086003,
        VK_STRUCTURE_TYPE_DEVICE_GENERATED_COMMANDS_LIMITS_NVX = 1000086004,
        VK_STRUCTURE_TYPE_DEVICE_GENERATED_COMMANDS_FEATURES_NVX = 1000086005,
        VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = 1000087000,
        VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = 1000090000,
        VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = 1000091000,
        VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = 1000091001,
        VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = 1000091002,
        VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = 1000091003,
        VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = 1000092000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = 1000097000,
        VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = 1000098000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = 1000099000,
        VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = 1000099001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = 1000101000,
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = 1000101001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = 1000102000,
        VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = 1000102001,
        VK_STRUCTURE_TYPE_HDR_METADATA_EXT = 1000105000,
        VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR = 1000109000,
        VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR = 1000109001,
        VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR = 1000109002,
        VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR = 1000109003,
        VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR = 1000109004,
        VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR = 1000109005,
        VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR = 1000109006,
        VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = 1000111000,
        VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114000,
        VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114001,
        VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = 1000114002,
        VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = 1000115000,
        VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = 1000115001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = 1000119000,
        VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = 1000119001,
        VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = 1000119002,
        VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = 1000121000,
        VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = 1000121001,
        VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = 1000121002,
        VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = 1000121003,
        VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = 1000121004,
        VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = 1000122000,
        VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = 1000123000,
        VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = 1000128000,
        VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = 1000128001,
        VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = 1000128002,
        VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = 1000128003,
        VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = 1000128004,
        VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = 1000129000,
        VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = 1000129001,
        VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = 1000129002,
        VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129003,
        VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129004,
        VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = 1000129005,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT = 1000130000,
        VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT = 1000130001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT = 1000138000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT = 1000138001,
        VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT = 1000138002,
        VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT = 1000138003,
        VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = 1000143000,
        VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = 1000143001,
        VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = 1000143002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = 1000143003,
        VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = 1000143004,
        VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR = 1000147000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = 1000148000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = 1000148001,
        VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = 1000148002,
        VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = 1000149000,
        VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = 1000152000,
        VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = 1000158000,
        VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = 1000158001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = 1000158002,
        VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = 1000158003,
        VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = 1000158004,
        VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = 1000158005,
        VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160000,
        VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160001,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT = 1000161000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT = 1000161001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT = 1000161002,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT = 1000161003,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT = 1000161004,
        VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = 1000164000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = 1000164001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = 1000164002,
        VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = 1000164005,
        VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = 1000165000,
        VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000165001,
        VK_STRUCTURE_TYPE_GEOMETRY_NV = 1000165003,
        VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = 1000165004,
        VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = 1000165005,
        VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = 1000165006,
        VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = 1000165007,
        VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = 1000165008,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = 1000165009,
        VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = 1000165011,
        VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = 1000165012,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = 1000166000,
        VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = 1000166001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = 1000170000,
        VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = 1000170001,
        VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT = 1000174000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR = 1000177000,
        VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = 1000178000,
        VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = 1000178001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = 1000178002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR = 1000180000,
        VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT = 1000184000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = 1000185000,
        VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = 1000189000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = 1000190000,
        VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT = 1000190001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT = 1000190002,
        VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = 1000191000,
        VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT = 1000192000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR = 1000196000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR = 1000197000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR = 1000199000,
        VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR = 1000199001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV = 1000201000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = 1000202000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = 1000202001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV = 1000203000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = 1000204000,
        VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = 1000205000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = 1000205002,
        VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = 1000206000,
        VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = 1000206001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR = 1000211000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = 1000212000,
        VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = 1000213000,
        VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = 1000213001,
        VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = 1000214000,
        VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = 1000217000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = 1000218000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = 1000218001,
        VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = 1000218002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT = 1000221000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = 1000237000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = 1000238000,
        VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = 1000238001,
        VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = 1000239000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = 1000240000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = 1000244000,
        VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT = 1000244001,
        VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = 1000244002,
        VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT = 1000246000,
        VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = 1000247000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = 1000249000,
        VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249002,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = 1000252000,
        VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = 1000255000,
        VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = 1000255002,
        VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = 1000255001,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT = 1000261000,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES,
        VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT,
        VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2,
        VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2,
        VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2,
        VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2,
        VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2,
        VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO,
        VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO,
        VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES,
        VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO,
        VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO,
        VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES,
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO,
        VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO,
        VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO,
        VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES,
        VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES,
        VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO,
        VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT = VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO,
        VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES,
        VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES,
        VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO,
        VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO,
        VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES,
        VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS,
        VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO,
        VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2,
        VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2,
        VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2,
        VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2,
        VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2,
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO,
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO,
        VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO,
        VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES,
        VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES,
        VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO,
        VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES,
        VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT,
        VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT,
        VK_STRUCTURE_TYPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 127
    /// <summary>VkSubgroupFeatureFlagBits - Enum describing what subgroup operations are supported</summary>
    public enum VkSubgroupFeatureFlagBits {
        /// <summary><a id="features-subgroup-basic"></a>
        ///   <code>VK_SUBGROUP_FEATURE_BASIC_BIT</code>
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniform</code> capability.</summary>
        VK_SUBGROUP_FEATURE_BASIC_BIT = 0x00000001,
        /// <summary><a id="features-subgroup-vote"></a>
        ///   <code>VK_SUBGROUP_FEATURE_VOTE_BIT</code> specifies
        /// the device will accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformVote</code> capability.</summary>
        VK_SUBGROUP_FEATURE_VOTE_BIT = 0x00000002,
        /// <summary><a id="features-subgroup-arithmetic"></a>
        ///   <code>VK_SUBGROUP_FEATURE_ARITHMETIC_BIT</code> specifies the device will
        /// accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformArithmetic</code> capability.</summary>
        VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 0x00000004,
        /// <summary><a id="features-subgroup-ballot"></a>
        ///   <code>VK_SUBGROUP_FEATURE_BALLOT_BIT</code>
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformBallot</code> capability.</summary>
        VK_SUBGROUP_FEATURE_BALLOT_BIT = 0x00000008,
        /// <summary><a id="features-subgroup-shuffle"></a>
        ///   <code>VK_SUBGROUP_FEATURE_SHUFFLE_BIT</code>
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformShuffle</code> capability.</summary>
        VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 0x00000010,
        /// <summary><a id="features-subgroup-shuffle-relative"></a>
        ///   <code>VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT</code> specifies the device will
        /// accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformShuffleRelative</code> capability.</summary>
        VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 0x00000020,
        /// <summary><a id="features-subgroup-clustered"></a>
        ///   <code>VK_SUBGROUP_FEATURE_CLUSTERED_BIT</code>
        /// specifies the device will accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformClustered</code> capability.</summary>
        VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 0x00000040,
        /// <summary><a id="features-subgroup-quad"></a>
        ///   <code>VK_SUBGROUP_FEATURE_QUAD_BIT</code> specifies
        /// the device will accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformQuad</code> capability.</summary>
        VK_SUBGROUP_FEATURE_QUAD_BIT = 0x00000080,
        /// <summary><a id="features-subgroup-partitioned"></a>
        ///   <code>VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV</code> specifies the device will
        /// accept SPIR-V shader modules that contain the
        /// <code>GroupNonUniformPartitionedNV</code> capability.</summary>
        VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100,
        VK_SUBGROUP_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 128
    /// <summary>VkSubpassContents - Specify how commands in the first subpass of a render pass are provided</summary>
    public enum VkSubpassContents {
        /// <summary><code>VK_SUBPASS_CONTENTS_INLINE</code> specifies that the contents of the
        /// subpass will be recorded inline in the primary command buffer, and
        /// secondary command buffers <strong class="purple">must</strong> not be executed within the subpass.</summary>
        VK_SUBPASS_CONTENTS_INLINE = 0,
        /// <summary><code>VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS</code> specifies that the
        /// contents are recorded in secondary command buffers that will be called
        /// from the primary command buffer, and <a href="#vkCmdExecuteCommands">vkCmdExecuteCommands</a> is the
        /// only valid command on the command buffer until <a href="#vkCmdNextSubpass">vkCmdNextSubpass</a> or
        /// <a href="#vkCmdEndRenderPass">vkCmdEndRenderPass</a>.</summary>
        VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS = 1,
        VK_SUBPASS_CONTENTS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 129
    /// <summary>VkSubpassDescriptionFlagBits - Bitmask specifying usage of a subpass</summary>
    public enum VkSubpassDescriptionFlagBits {
        /// <summary><code>VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX</code> specifies that
        /// shaders compiled for this subpass write the attributes for all views in
        /// a single invocation of each vertex processing stage.
        /// All pipelines compiled against a subpass that includes this bit <strong class="purple">must</strong>
        /// write per-view attributes to the <code>*PerViewNV[]</code> shader outputs, in
        /// addition to the non-per-view (e.g. <code>Position</code>) outputs.</summary>
        VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX = 0x00000001,
        /// <summary><code>VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX</code> specifies
        /// that shaders compiled for this subpass use per-view positions which only
        /// differ in value in the x component.
        /// Per-view viewport mask <strong class="purple">can</strong> also be used.</summary>
        VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX = 0x00000002,
        VK_SUBPASS_DESCRIPTION_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 130
    /// <summary>VkSurfaceCounterFlagBitsEXT - Surface-relative counter types</summary>
    public enum VkSurfaceCounterFlagBitsEXT {
        /// <summary><code>VK_SURFACE_COUNTER_VBLANK_EXT</code> specifies a counter incrementing
        /// once every time a vertical blanking period occurs on the display
        /// associated with the surface.</summary>
        VK_SURFACE_COUNTER_VBLANK_EXT = 0x00000001,
        VK_SURFACE_COUNTER_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 131
    /// <summary>VkSurfaceTransformFlagBitsKHR - presentation transforms supported on a device</summary>
    public enum VkSurfaceTransformFlagBitsKHR {
        /// <summary><code>VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR</code> specifies that image content
        /// is presented without being transformed.</summary>
        VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR = 0x00000001,
        /// <summary><code>VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR</code> specifies that image
        /// content is rotated 90 degrees clockwise.</summary>
        VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR = 0x00000002,
        /// <summary><code>VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR</code> specifies that image
        /// content is rotated 180 degrees clockwise.</summary>
        VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR = 0x00000004,
        /// <summary><code>VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR</code> specifies that image
        /// content is rotated 270 degrees clockwise.</summary>
        VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR = 0x00000008,
        /// <summary><code>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR</code> specifies that
        /// image content is mirrored horizontally.</summary>
        VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR = 0x00000010,
        /// <summary><code>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR</code> specifies
        /// that image content is mirrored horizontally, then rotated 90 degrees
        /// clockwise.</summary>
        VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR = 0x00000020,
        /// <summary><code>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR</code>
        /// specifies that image content is mirrored horizontally, then rotated 180
        /// degrees clockwise.</summary>
        VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = 0x00000040,
        /// <summary><code>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR</code>
        /// specifies that image content is mirrored horizontally, then rotated 270
        /// degrees clockwise.</summary>
        VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = 0x00000080,
        /// <summary><code>VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR</code> specifies that the
        /// presentation transform is not specified, and is instead determined by
        /// platform-specific considerations and mechanisms outside Vulkan.</summary>
        VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR = 0x00000100,
        VK_SURFACE_TRANSFORM_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 132
    /// <summary>VkSwapchainCreateFlagBitsKHR - Bitmask controlling swapchain creation</summary>
    public enum VkSwapchainCreateFlagBitsKHR {
        /// <summary><code>VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR</code> specifies
        /// that images created from the swapchain (i.e. with the <code>swapchain</code>
        /// member of <a href="#VkImageSwapchainCreateInfoKHR">VkImageSwapchainCreateInfoKHR</a> set to this swapchain’s
        /// handle) <strong class="purple">must</strong> use <code>VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</code>.</summary>
        VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000001,
        /// <summary><code>VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR</code> specifies that images
        /// created from the swapchain are protected images.</summary>
        VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = 0x00000002,
        /// <summary><code>VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR</code> specifies that the
        /// images of the swapchain <strong class="purple">can</strong> be used to create a <code>VkImageView</code> with
        /// a different format than what the swapchain was created with.
        /// The list of allowed image view formats are specified by chaining an
        /// instance of the <a href="#VkImageFormatListCreateInfoKHR">VkImageFormatListCreateInfoKHR</a> structure to the
        /// <code>pNext</code> chain of <code>VkSwapchainCreateInfoKHR</code>.
        /// In addition, this flag also specifies that the swapchain <strong class="purple">can</strong> be created
        /// with usage flags that are not supported for the format the swapchain is
        /// created with but are supported for at least one of the allowed image
        /// view formats.</summary>
        VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = 0x00000004,
        VK_SWAPCHAIN_CREATE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }
    // Enum: 133
    /// <summary>VkSystemAllocationScope - Allocation scope</summary>
    public enum VkSystemAllocationScope {
        /// <summary><code>VK_SYSTEM_ALLOCATION_SCOPE_COMMAND</code> specifies that the allocation
        /// is scoped to the duration of the Vulkan command.</summary>
        VK_SYSTEM_ALLOCATION_SCOPE_COMMAND = 0,
        /// <summary><code>VK_SYSTEM_ALLOCATION_SCOPE_OBJECT</code> specifies that the allocation is
        /// scoped to the lifetime of the Vulkan object that is being created or
        /// used.</summary>
        VK_SYSTEM_ALLOCATION_SCOPE_OBJECT = 1,
        /// <summary><code>VK_SYSTEM_ALLOCATION_SCOPE_CACHE</code> specifies that the allocation is
        /// scoped to the lifetime of a <code>VkPipelineCache</code>
        /// or <code>VkValidationCacheEXT</code>
        /// object.</summary>
        VK_SYSTEM_ALLOCATION_SCOPE_CACHE = 2,
        /// <summary><code>VK_SYSTEM_ALLOCATION_SCOPE_DEVICE</code> specifies that the allocation is
        /// scoped to the lifetime of the Vulkan device.</summary>
        VK_SYSTEM_ALLOCATION_SCOPE_DEVICE = 3,
        /// <summary><code>VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE</code> specifies that the allocation
        /// is scoped to the lifetime of the Vulkan instance.</summary>
        VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE = 4,
        VK_SYSTEM_ALLOCATION_SCOPE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 134
    /// <summary>VkTessellationDomainOrigin - Enum describing tessellation domain origin</summary>
    public enum VkTessellationDomainOrigin {
        /// <summary><code>VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT</code> specifies that the origin
        /// of the domain space is in the upper left corner, as shown in figure
        /// <a href="vkspec.html#img-tessellation-topology-ul" class="bare">html/vkspec.html#img-tessellation-topology-ul</a>.</summary>
        VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT = 0,
        /// <summary><code>VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT</code> specifies that the origin
        /// of the domain space is in the lower left corner, as shown in figure
        /// <a href="vkspec.html#img-tessellation-topology-ll" class="bare">html/vkspec.html#img-tessellation-topology-ll</a>.</summary>
        VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT = 1,
        VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT,
        VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT,
        VK_TESSELLATION_DOMAIN_ORIGIN_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 135
    /// <summary>VkTimeDomainEXT - Supported time domains</summary>
    public enum VkTimeDomainEXT {
        /// <summary><code>VK_TIME_DOMAIN_DEVICE_EXT</code> specifies the device time domain.
        /// Timestamp values in this time domain are comparable with device
        /// timestamp values captured using <a href="#vkCmdWriteTimestamp">vkCmdWriteTimestamp</a> and are
        /// defined to be incrementing according to the
        /// <a href="vkspec.html#limits-timestampPeriod">timestampPeriod</a> of the device.</summary>
        VK_TIME_DOMAIN_DEVICE_EXT = 0,
        /// <summary><code>VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT</code> specifies the CLOCK_MONOTONIC
        /// time domain available on POSIX platforms.</summary>
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = 1,
        /// <summary><code>VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT</code> specifies the
        /// CLOCK_MONOTONIC_RAW time domain available on POSIX platforms.</summary>
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = 2,
        /// <summary><code>VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT</code> specifies the
        /// performance counter (QPC) time domain available on Windows.</summary>
        VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = 3,
        VK_TIME_DOMAIN_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 136
    /// <summary>VkValidationCacheHeaderVersionEXT - Encode validation cache version</summary>
    public enum VkValidationCacheHeaderVersionEXT {
        /// <summary><code>VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT</code> specifies version one
        /// of the validation cache.</summary>
        VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT = 1,
        VK_VALIDATION_CACHE_HEADER_VERSION_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 137
    /// <summary>VkValidationCheckEXT - Specify validation checks to disable</summary>
    public enum VkValidationCheckEXT {
        /// <summary><code>VK_VALIDATION_CHECK_ALL_EXT</code> specifies that all validation checks
        /// are disabled.</summary>
        VK_VALIDATION_CHECK_ALL_EXT = 0,
        /// <summary><code>VK_VALIDATION_CHECK_SHADERS_EXT</code> specifies that shader validation
        /// is disabled.</summary>
        VK_VALIDATION_CHECK_SHADERS_EXT = 1,
        VK_VALIDATION_CHECK_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 138
    /// <summary>VkValidationFeatureDisableEXT - Specify validation features to disable</summary>
    public enum VkValidationFeatureDisableEXT {
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_ALL_EXT</code> specifies that all
        /// validation checks are disabled.</summary>
        VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = 0,
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT</code> specifies that shader
        /// validation is disabled.
        /// This feature is enabled by default.</summary>
        VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = 1,
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT</code> specifies that
        /// thread safety validation is disabled.
        /// This feature is enabled by default.</summary>
        VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = 2,
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT</code> specifies that
        /// stateless parameter validation is disabled.
        /// This feature is enabled by default.</summary>
        VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = 3,
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT</code> specifies that
        /// object lifetime validation is disabled.
        /// This feature is enabled by default.</summary>
        VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = 4,
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT</code> specifies that core
        /// validation checks are disabled.
        /// This feature is enabled by default.
        /// If this feature is disabled, the shader validation and GPU-assisted
        /// validation features are also disabled.</summary>
        VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = 5,
        /// <summary><code>VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT</code> specifies that
        /// protection against duplicate non-dispatchable object handles is
        /// disabled.
        /// This feature is enabled by default.</summary>
        VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = 6,
        VK_VALIDATION_FEATURE_DISABLE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 139
    /// <summary>VkValidationFeatureEnableEXT - Specify validation features to enable</summary>
    public enum VkValidationFeatureEnableEXT {
        /// <summary><code>VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT</code> specifies that
        /// GPU-assisted validation is enabled.
        /// Activating this feature instruments shader programs to generate
        /// additional diagnostic data.
        /// This feature is disabled by default.</summary>
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = 0,
        /// <summary><code>VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT</code>
        /// specifies that the validation layers reserve a descriptor set binding
        /// slot for their own use.
        /// The layer reports a value for
        /// <a href="#VkPhysicalDeviceLimits">VkPhysicalDeviceLimits</a>::<code>maxBoundDescriptorSets</code> that is one
        /// less than the value reported by the device.
        /// If the device supports the binding of only one descriptor set, the
        /// validation layer does not perform GPU-assisted validation.
        /// This feature is disabled by default.
        /// The GPU-assisted validation feature must be enabled in order to use this
        /// feature.</summary>
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,
        VK_VALIDATION_FEATURE_ENABLE_MAX_ENUM_EXT = 0x7FFFFFFF
    }
    // Enum: 140
    /// <summary>VkVendorId - Khronos vendor IDs</summary>
    public enum VkVendorId {
        VK_VENDOR_ID_VIV = 0x10001,
        VK_VENDOR_ID_VSI = 0x10002,
        VK_VENDOR_ID_KAZAN = 0x10003,
        VK_VENDOR_ID_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 141
    /// <summary>VkVertexInputRate - Specify rate at which vertex attributes are pulled from buffers</summary>
    public enum VkVertexInputRate {
        /// <summary><code>VK_VERTEX_INPUT_RATE_VERTEX</code> specifies that vertex attribute
        /// addressing is a function of the vertex index.</summary>
        VK_VERTEX_INPUT_RATE_VERTEX = 0,
        /// <summary><code>VK_VERTEX_INPUT_RATE_INSTANCE</code> specifies that vertex attribute
        /// addressing is a function of the instance index.</summary>
        VK_VERTEX_INPUT_RATE_INSTANCE = 1,
        VK_VERTEX_INPUT_RATE_MAX_ENUM = 0x7FFFFFFF
    }
    // Enum: 142
    /// <summary>VkViewportCoordinateSwizzleNV - Specify how a viewport coordinate is swizzled</summary>
    public enum VkViewportCoordinateSwizzleNV {
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = 0,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = 1,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = 2,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = 3,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = 4,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = 5,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = 6,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = 7,
        VK_VIEWPORT_COORDINATE_SWIZZLE_MAX_ENUM_NV = 0x7FFFFFFF
    }
}
