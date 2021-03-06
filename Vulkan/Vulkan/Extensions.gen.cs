﻿using System;
using System.Runtime.InteropServices;

namespace Vulkan {
    public unsafe static partial class vkAPI {
        public const string VK_KHR_16bit_storage = "VK_KHR_16bit_storage";
        public const string VK_KHR_8bit_storage = "VK_KHR_8bit_storage";
        public const string VK_KHR_android_surface = "VK_KHR_android_surface";
        public const string VK_KHR_bind_memory2 = "VK_KHR_bind_memory2";
        public const string VK_KHR_create_renderpass2 = "VK_KHR_create_renderpass2";
        public const string VK_KHR_dedicated_allocation = "VK_KHR_dedicated_allocation";
        public const string VK_KHR_depth_stencil_resolve = "VK_KHR_depth_stencil_resolve";
        public const string VK_KHR_descriptor_update_template = "VK_KHR_descriptor_update_template";
        public const string VK_KHR_device_group = "VK_KHR_device_group";
        public const string VK_KHR_device_group_creation = "VK_KHR_device_group_creation";
        public const string VK_KHR_display = "VK_KHR_display";
        public const string VK_KHR_display_swapchain = "VK_KHR_display_swapchain";
        public const string VK_KHR_draw_indirect_count = "VK_KHR_draw_indirect_count";
        public const string VK_KHR_driver_properties = "VK_KHR_driver_properties";
        public const string VK_KHR_external_fence = "VK_KHR_external_fence";
        public const string VK_KHR_external_fence_capabilities = "VK_KHR_external_fence_capabilities";
        public const string VK_KHR_external_fence_fd = "VK_KHR_external_fence_fd";
        public const string VK_KHR_external_fence_win32 = "VK_KHR_external_fence_win32";
        public const string VK_KHR_external_memory = "VK_KHR_external_memory";
        public const string VK_KHR_external_memory_capabilities = "VK_KHR_external_memory_capabilities";
        public const string VK_KHR_external_memory_fd = "VK_KHR_external_memory_fd";
        public const string VK_KHR_external_memory_win32 = "VK_KHR_external_memory_win32";
        public const string VK_KHR_external_semaphore = "VK_KHR_external_semaphore";
        public const string VK_KHR_external_semaphore_capabilities = "VK_KHR_external_semaphore_capabilities";
        public const string VK_KHR_external_semaphore_fd = "VK_KHR_external_semaphore_fd";
        public const string VK_KHR_external_semaphore_win32 = "VK_KHR_external_semaphore_win32";
        public const string VK_KHR_get_display_properties2 = "VK_KHR_get_display_properties2";
        public const string VK_KHR_get_memory_requirements2 = "VK_KHR_get_memory_requirements2";
        public const string VK_KHR_get_physical_device_properties2 = "VK_KHR_get_physical_device_properties2";
        public const string VK_KHR_get_surface_capabilities2 = "VK_KHR_get_surface_capabilities2";
        public const string VK_KHR_image_format_list = "VK_KHR_image_format_list";
        public const string VK_KHR_incremental_present = "VK_KHR_incremental_present";
        public const string VK_KHR_maintenance1 = "VK_KHR_maintenance1";
        public const string VK_KHR_maintenance2 = "VK_KHR_maintenance2";
        public const string VK_KHR_maintenance3 = "VK_KHR_maintenance3";
        public const string VK_KHR_multiview = "VK_KHR_multiview";
        public const string VK_KHR_push_descriptor = "VK_KHR_push_descriptor";
        public const string VK_KHR_relaxed_block_layout = "VK_KHR_relaxed_block_layout";
        public const string VK_KHR_sampler_mirror_clamp_to_edge = "VK_KHR_sampler_mirror_clamp_to_edge";
        public const string VK_KHR_sampler_ycbcr_conversion = "VK_KHR_sampler_ycbcr_conversion";
        public const string VK_KHR_shader_atomic_int64 = "VK_KHR_shader_atomic_int64";
        public const string VK_KHR_shader_draw_parameters = "VK_KHR_shader_draw_parameters";
        public const string VK_KHR_shader_float16_int8 = "VK_KHR_shader_float16_int8";
        public const string VK_KHR_shader_float_controls = "VK_KHR_shader_float_controls";
        public const string VK_KHR_shared_presentable_image = "VK_KHR_shared_presentable_image";
        public const string VK_KHR_storage_buffer_storage_class = "VK_KHR_storage_buffer_storage_class";
        public const string VK_KHR_surface = "VK_KHR_surface";
        public const string VK_KHR_surface_protected_capabilities = "VK_KHR_surface_protected_capabilities";
        public const string VK_KHR_swapchain = "VK_KHR_swapchain";
        public const string VK_KHR_swapchain_mutable_format = "VK_KHR_swapchain_mutable_format";
        public const string VK_KHR_variable_pointers = "VK_KHR_variable_pointers";
        public const string VK_KHR_vulkan_memory_model = "VK_KHR_vulkan_memory_model";
        public const string VK_KHR_wayland_surface = "VK_KHR_wayland_surface";
        public const string VK_KHR_win32_keyed_mutex = "VK_KHR_win32_keyed_mutex";
        public const string VK_KHR_win32_surface = "VK_KHR_win32_surface";
        public const string VK_KHR_xcb_surface = "VK_KHR_xcb_surface";
        public const string VK_KHR_xlib_surface = "VK_KHR_xlib_surface";
        public const string VK_EXT_acquire_xlib_display = "VK_EXT_acquire_xlib_display";
        public const string VK_EXT_astc_decode_mode = "VK_EXT_astc_decode_mode";
        public const string VK_EXT_blend_operation_advanced = "VK_EXT_blend_operation_advanced";
        public const string VK_EXT_buffer_device_address = "VK_EXT_buffer_device_address";
        public const string VK_EXT_calibrated_timestamps = "VK_EXT_calibrated_timestamps";
        public const string VK_EXT_conditional_rendering = "VK_EXT_conditional_rendering";
        public const string VK_EXT_conservative_rasterization = "VK_EXT_conservative_rasterization";
        public const string VK_EXT_debug_marker = "VK_EXT_debug_marker";
        public const string VK_EXT_debug_report = "VK_EXT_debug_report";
        public const string VK_EXT_debug_utils = "VK_EXT_debug_utils";
        public const string VK_EXT_depth_clip_enable = "VK_EXT_depth_clip_enable";
        public const string VK_EXT_depth_range_unrestricted = "VK_EXT_depth_range_unrestricted";
        public const string VK_EXT_descriptor_indexing = "VK_EXT_descriptor_indexing";
        public const string VK_EXT_direct_mode_display = "VK_EXT_direct_mode_display";
        public const string VK_EXT_discard_rectangles = "VK_EXT_discard_rectangles";
        public const string VK_EXT_display_control = "VK_EXT_display_control";
        public const string VK_EXT_display_surface_counter = "VK_EXT_display_surface_counter";
        public const string VK_EXT_external_memory_dma_buf = "VK_EXT_external_memory_dma_buf";
        public const string VK_EXT_external_memory_host = "VK_EXT_external_memory_host";
        public const string VK_EXT_filter_cubic = "VK_EXT_filter_cubic";
        public const string VK_EXT_fragment_density_map = "VK_EXT_fragment_density_map";
        public const string VK_EXT_full_screen_exclusive = "VK_EXT_full_screen_exclusive";
        public const string VK_EXT_global_priority = "VK_EXT_global_priority";
        public const string VK_EXT_hdr_metadata = "VK_EXT_hdr_metadata";
        public const string VK_EXT_host_query_reset = "VK_EXT_host_query_reset";
        public const string VK_EXT_image_drm_format_modifier = "VK_EXT_image_drm_format_modifier";
        public const string VK_EXT_inline_uniform_block = "VK_EXT_inline_uniform_block";
        public const string VK_EXT_memory_budget = "VK_EXT_memory_budget";
        public const string VK_EXT_memory_priority = "VK_EXT_memory_priority";
        public const string VK_EXT_metal_surface = "VK_EXT_metal_surface";
        public const string VK_EXT_pci_bus_info = "VK_EXT_pci_bus_info";
        public const string VK_EXT_pipeline_creation_feedback = "VK_EXT_pipeline_creation_feedback";
        public const string VK_EXT_post_depth_coverage = "VK_EXT_post_depth_coverage";
        public const string VK_EXT_queue_family_foreign = "VK_EXT_queue_family_foreign";
        public const string VK_EXT_sample_locations = "VK_EXT_sample_locations";
        public const string VK_EXT_sampler_filter_minmax = "VK_EXT_sampler_filter_minmax";
        public const string VK_EXT_scalar_block_layout = "VK_EXT_scalar_block_layout";
        public const string VK_EXT_separate_stencil_usage = "VK_EXT_separate_stencil_usage";
        public const string VK_EXT_shader_stencil_export = "VK_EXT_shader_stencil_export";
        public const string VK_EXT_shader_subgroup_ballot = "VK_EXT_shader_subgroup_ballot";
        public const string VK_EXT_shader_subgroup_vote = "VK_EXT_shader_subgroup_vote";
        public const string VK_EXT_shader_viewport_index_layer = "VK_EXT_shader_viewport_index_layer";
        public const string VK_EXT_swapchain_colorspace = "VK_EXT_swapchain_colorspace";
        public const string VK_EXT_transform_feedback = "VK_EXT_transform_feedback";
        public const string VK_EXT_validation_cache = "VK_EXT_validation_cache";
        public const string VK_EXT_validation_features = "VK_EXT_validation_features";
        public const string VK_EXT_validation_flags = "VK_EXT_validation_flags";
        public const string VK_EXT_vertex_attribute_divisor = "VK_EXT_vertex_attribute_divisor";
        public const string VK_EXT_ycbcr_image_arrays = "VK_EXT_ycbcr_image_arrays";
        public const string VK_AMD_buffer_marker = "VK_AMD_buffer_marker";
        public const string VK_AMD_display_native_hdr = "VK_AMD_display_native_hdr";
        public const string VK_AMD_draw_indirect_count = "VK_AMD_draw_indirect_count";
        public const string VK_AMD_gcn_shader = "VK_AMD_gcn_shader";
        public const string VK_AMD_gpu_shader_half_float = "VK_AMD_gpu_shader_half_float";
        public const string VK_AMD_gpu_shader_int16 = "VK_AMD_gpu_shader_int16";
        public const string VK_AMD_memory_overallocation_behavior = "VK_AMD_memory_overallocation_behavior";
        public const string VK_AMD_mixed_attachment_samples = "VK_AMD_mixed_attachment_samples";
        public const string VK_AMD_negative_viewport_height = "VK_AMD_negative_viewport_height";
        public const string VK_AMD_rasterization_order = "VK_AMD_rasterization_order";
        public const string VK_AMD_shader_ballot = "VK_AMD_shader_ballot";
        public const string VK_AMD_shader_core_properties = "VK_AMD_shader_core_properties";
        public const string VK_AMD_shader_explicit_vertex_parameter = "VK_AMD_shader_explicit_vertex_parameter";
        public const string VK_AMD_shader_fragment_mask = "VK_AMD_shader_fragment_mask";
        public const string VK_AMD_shader_image_load_store_lod = "VK_AMD_shader_image_load_store_lod";
        public const string VK_AMD_shader_info = "VK_AMD_shader_info";
        public const string VK_AMD_shader_trinary_minmax = "VK_AMD_shader_trinary_minmax";
        public const string VK_AMD_texture_gather_bias_lod = "VK_AMD_texture_gather_bias_lod";
        public const string VK_ANDROID_external_memory_android_hardware_buffer = "VK_ANDROID_external_memory_android_hardware_buffer";
        public const string VK_FUCHSIA_imagepipe_surface = "VK_FUCHSIA_imagepipe_surface";
        public const string VK_GGP_frame_token = "VK_GGP_frame_token";
        public const string VK_GGP_stream_descriptor_surface = "VK_GGP_stream_descriptor_surface";
        public const string VK_GOOGLE_decorate_string = "VK_GOOGLE_decorate_string";
        public const string VK_GOOGLE_display_timing = "VK_GOOGLE_display_timing";
        public const string VK_GOOGLE_hlsl_functionality1 = "VK_GOOGLE_hlsl_functionality1";
        public const string VK_IMG_filter_cubic = "VK_IMG_filter_cubic";
        public const string VK_IMG_format_pvrtc = "VK_IMG_format_pvrtc";
        public const string VK_MVK_ios_surface = "VK_MVK_ios_surface";
        public const string VK_MVK_macos_surface = "VK_MVK_macos_surface";
        public const string VK_NN_vi_surface = "VK_NN_vi_surface";
        public const string VK_NVX_device_generated_commands = "VK_NVX_device_generated_commands";
        public const string VK_NVX_image_view_handle = "VK_NVX_image_view_handle";
        public const string VK_NVX_multiview_per_view_attributes = "VK_NVX_multiview_per_view_attributes";
        public const string VK_NV_clip_space_w_scaling = "VK_NV_clip_space_w_scaling";
        public const string VK_NV_compute_shader_derivatives = "VK_NV_compute_shader_derivatives";
        public const string VK_NV_cooperative_matrix = "VK_NV_cooperative_matrix";
        public const string VK_NV_corner_sampled_image = "VK_NV_corner_sampled_image";
        public const string VK_NV_dedicated_allocation = "VK_NV_dedicated_allocation";
        public const string VK_NV_dedicated_allocation_image_aliasing = "VK_NV_dedicated_allocation_image_aliasing";
        public const string VK_NV_device_diagnostic_checkpoints = "VK_NV_device_diagnostic_checkpoints";
        public const string VK_NV_external_memory = "VK_NV_external_memory";
        public const string VK_NV_external_memory_capabilities = "VK_NV_external_memory_capabilities";
        public const string VK_NV_external_memory_win32 = "VK_NV_external_memory_win32";
        public const string VK_NV_fill_rectangle = "VK_NV_fill_rectangle";
        public const string VK_NV_fragment_coverage_to_color = "VK_NV_fragment_coverage_to_color";
        public const string VK_NV_fragment_shader_barycentric = "VK_NV_fragment_shader_barycentric";
        public const string VK_NV_framebuffer_mixed_samples = "VK_NV_framebuffer_mixed_samples";
        public const string VK_NV_geometry_shader_passthrough = "VK_NV_geometry_shader_passthrough";
        public const string VK_NV_glsl_shader = "VK_NV_glsl_shader";
        public const string VK_NV_mesh_shader = "VK_NV_mesh_shader";
        public const string VK_NV_ray_tracing = "VK_NV_ray_tracing";
        public const string VK_NV_representative_fragment_test = "VK_NV_representative_fragment_test";
        public const string VK_NV_sample_mask_override_coverage = "VK_NV_sample_mask_override_coverage";
        public const string VK_NV_scissor_exclusive = "VK_NV_scissor_exclusive";
        public const string VK_NV_shader_image_footprint = "VK_NV_shader_image_footprint";
        public const string VK_NV_shader_subgroup_partitioned = "VK_NV_shader_subgroup_partitioned";
        public const string VK_NV_shading_rate_image = "VK_NV_shading_rate_image";
        public const string VK_NV_viewport_array2 = "VK_NV_viewport_array2";
        public const string VK_NV_viewport_swizzle = "VK_NV_viewport_swizzle";
        public const string VK_NV_win32_keyed_mutex = "VK_NV_win32_keyed_mutex";

    }
}
