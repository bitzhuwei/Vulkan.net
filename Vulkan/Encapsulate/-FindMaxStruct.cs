//using System;
//using Vulkan;

//namespace Vulkan.Research {
//    static unsafe class FindMaxStruct {
//        public static void Find() {
//            int max = 0;
//            int index = -1;
//            for (int i = 0; i < sizes.Length; i++) {
//                if (sizes[i] > max) {
//                    index = i;
//                    max = sizes[i];
//                }
//            }

//            Console.WriteLine($"sizes[{index}] = {max} is the max one.");
//        }
//        static int[] sizes = new int[] {
//            // Struct: 0
//            sizeof(VkAccelerationStructureCreateInfoNV),
//            // Struct: 1
//            sizeof(VkAccelerationStructureInfoNV),
//            // Struct: 2
//            sizeof(VkAccelerationStructureMemoryRequirementsInfoNV),
//            // Struct: 3
//            sizeof(VkAcquireNextImageInfoKHR),
//            // Struct: 4
//            sizeof(VkAllocationCallbacks),
//            // Struct: 5
//            sizeof(VkAndroidHardwareBufferFormatPropertiesANDROID),
//            // Struct: 6
//            sizeof(VkAndroidHardwareBufferPropertiesANDROID),
//            // Struct: 7
//            sizeof(VkAndroidHardwareBufferUsageANDROID),
//            // Struct: 8
//            sizeof(VkAndroidSurfaceCreateInfoKHR),
//            // Struct: 9
//            sizeof(VkApplicationInfo),
//            // Struct: 10
//            sizeof(VkAttachmentDescription),
//            // Struct: 11
//            sizeof(VkAttachmentDescription2KHR),
//            // Struct: 12
//            sizeof(VkAttachmentReference),
//            // Struct: 13
//            sizeof(VkAttachmentReference2KHR),
//            // Struct: 14
//            sizeof(VkAttachmentSampleLocationsEXT),
//            // Struct: 15
//            sizeof(VkBaseInStructure),
//            // Struct: 16
//            sizeof(VkBaseOutStructure),
//            // Struct: 17
//            sizeof(VkBindAccelerationStructureMemoryInfoNV),
//            // Struct: 18
//            sizeof(VkBindBufferMemoryDeviceGroupInfo),
//            // Struct: 19
//            sizeof(VkBindBufferMemoryInfo),
//            // Struct: 20
//            sizeof(VkBindImageMemoryDeviceGroupInfo),
//            // Struct: 21
//            sizeof(VkBindImageMemoryInfo),
//            // Struct: 22
//            sizeof(VkBindImageMemorySwapchainInfoKHR),
//            // Struct: 23
//            sizeof(VkBindImagePlaneMemoryInfo),
//            // Struct: 24
//            sizeof(VkBindSparseInfo),
//            // Struct: 25
//            sizeof(VkBufferCopy),
//            // Struct: 26
//            sizeof(VkBufferCreateInfo),
//            // Struct: 27
//            sizeof(VkBufferDeviceAddressCreateInfoEXT),
//            // Struct: 28
//            sizeof(VkBufferDeviceAddressInfoEXT),
//            // Struct: 29
//            sizeof(VkBufferImageCopy),
//            // Struct: 30
//            sizeof(VkBufferMemoryBarrier),
//            // Struct: 31
//            sizeof(VkBufferMemoryRequirementsInfo2),
//            // Struct: 32
//            sizeof(VkBufferViewCreateInfo),
//            // Struct: 33
//            sizeof(VkCalibratedTimestampInfoEXT),
//            // Struct: 34
//            sizeof(VkCheckpointDataNV),
//            // Struct: 35
//            sizeof(VkClearAttachment),
//            // Struct: 36
//            sizeof(VkClearColorValue),
//            // Struct: 37
//            sizeof(VkClearDepthStencilValue),
//            // Struct: 38
//            sizeof(VkClearRect),
//            // Struct: 39
//            sizeof(VkClearValue),
//            // Struct: 40
//            sizeof(VkCmdProcessCommandsInfoNVX),
//            // Struct: 41
//            sizeof(VkCmdReserveSpaceForCommandsInfoNVX),
//            // Struct: 42
//            sizeof(VkCoarseSampleLocationNV),
//            // Struct: 43
//            sizeof(VkCoarseSampleOrderCustomNV),
//            // Struct: 44
//            sizeof(VkCommandBufferAllocateInfo),
//            // Struct: 45
//            sizeof(VkCommandBufferBeginInfo),
//            // Struct: 46
//            sizeof(VkCommandBufferInheritanceConditionalRenderingInfoEXT),
//            // Struct: 47
//            sizeof(VkCommandBufferInheritanceInfo),
//            // Struct: 48
//            sizeof(VkCommandPoolCreateInfo),
//            // Struct: 49
//            sizeof(VkComponentMapping),
//            // Struct: 50
//            sizeof(VkComputePipelineCreateInfo),
//            // Struct: 51
//            sizeof(VkConditionalRenderingBeginInfoEXT),
//            // Struct: 52
//            sizeof(VkConformanceVersionKHR),
//            // Struct: 53
//            sizeof(VkCooperativeMatrixPropertiesNV),
//            // Struct: 54
//            sizeof(VkCopyDescriptorSet),
//            // Struct: 55
//            sizeof(VkD3D12FenceSubmitInfoKHR),
//            // Struct: 56
//            sizeof(VkDebugMarkerMarkerInfoEXT),
//            // Struct: 57
//            sizeof(VkDebugMarkerObjectNameInfoEXT),
//            // Struct: 58
//            sizeof(VkDebugMarkerObjectTagInfoEXT),
//            // Struct: 59
//            sizeof(VkDebugReportCallbackCreateInfoEXT),
//            // Struct: 60
//            sizeof(VkDebugUtilsLabelEXT),
//            // Struct: 61
//            sizeof(VkDebugUtilsMessengerCallbackDataEXT),
//            // Struct: 62
//            sizeof(VkDebugUtilsMessengerCreateInfoEXT),
//            // Struct: 63
//            sizeof(VkDebugUtilsObjectNameInfoEXT),
//            // Struct: 64
//            sizeof(VkDebugUtilsObjectTagInfoEXT),
//            // Struct: 65
//            sizeof(VkDedicatedAllocationBufferCreateInfoNV),
//            // Struct: 66
//            sizeof(VkDedicatedAllocationImageCreateInfoNV),
//            // Struct: 67
//            sizeof(VkDedicatedAllocationMemoryAllocateInfoNV),
//            // Struct: 68
//            sizeof(VkDescriptorBufferInfo),
//            // Struct: 69
//            sizeof(VkDescriptorImageInfo),
//            // Struct: 70
//            sizeof(VkDescriptorPoolCreateInfo),
//            // Struct: 71
//            sizeof(VkDescriptorPoolInlineUniformBlockCreateInfoEXT),
//            // Struct: 72
//            sizeof(VkDescriptorPoolSize),
//            // Struct: 73
//            sizeof(VkDescriptorSetAllocateInfo),
//            // Struct: 74
//            sizeof(VkDescriptorSetLayoutBinding),
//            // Struct: 75
//            sizeof(VkDescriptorSetLayoutBindingFlagsCreateInfoEXT),
//            // Struct: 76
//            sizeof(VkDescriptorSetLayoutCreateInfo),
//            // Struct: 77
//            sizeof(VkDescriptorSetLayoutSupport),
//            // Struct: 78
//            sizeof(VkDescriptorSetVariableDescriptorCountAllocateInfoEXT),
//            // Struct: 79
//            sizeof(VkDescriptorSetVariableDescriptorCountLayoutSupportEXT),
//            // Struct: 80
//            sizeof(VkDescriptorUpdateTemplateCreateInfo),
//            // Struct: 81
//            sizeof(VkDescriptorUpdateTemplateEntry),
//            // Struct: 82
//            sizeof(VkDeviceCreateInfo),
//            // Struct: 83
//            sizeof(VkDeviceEventInfoEXT),
//            // Struct: 84
//            sizeof(VkDeviceGeneratedCommandsFeaturesNVX),
//            // Struct: 85
//            sizeof(VkDeviceGeneratedCommandsLimitsNVX),
//            // Struct: 86
//            sizeof(VkDeviceGroupBindSparseInfo),
//            // Struct: 87
//            sizeof(VkDeviceGroupCommandBufferBeginInfo),
//            // Struct: 88
//            sizeof(VkDeviceGroupDeviceCreateInfo),
//            // Struct: 89
//            sizeof(VkDeviceGroupPresentCapabilitiesKHR),
//            // Struct: 90
//            sizeof(VkDeviceGroupPresentInfoKHR),
//            // Struct: 91
//            sizeof(VkDeviceGroupRenderPassBeginInfo),
//            // Struct: 92
//            sizeof(VkDeviceGroupSubmitInfo),
//            // Struct: 93
//            sizeof(VkDeviceGroupSwapchainCreateInfoKHR),
//            // Struct: 94
//            sizeof(VkDeviceMemoryOverallocationCreateInfoAMD),
//            // Struct: 95
//            sizeof(VkDeviceQueueCreateInfo),
//            // Struct: 96
//            sizeof(VkDeviceQueueGlobalPriorityCreateInfoEXT),
//            // Struct: 97
//            sizeof(VkDeviceQueueInfo2),
//            // Struct: 98
//            sizeof(VkDispatchIndirectCommand),
//            // Struct: 99
//            sizeof(VkDisplayEventInfoEXT),
//            // Struct: 100
//            sizeof(VkDisplayModeCreateInfoKHR),
//            // Struct: 101
//            sizeof(VkDisplayModeParametersKHR),
//            // Struct: 102
//            sizeof(VkDisplayModeProperties2KHR),
//            // Struct: 103
//            sizeof(VkDisplayModePropertiesKHR),
//            // Struct: 104
//            sizeof(VkDisplayNativeHdrSurfaceCapabilitiesAMD),
//            // Struct: 105
//            sizeof(VkDisplayPlaneCapabilities2KHR),
//            // Struct: 106
//            sizeof(VkDisplayPlaneCapabilitiesKHR),
//            // Struct: 107
//            sizeof(VkDisplayPlaneInfo2KHR),
//            // Struct: 108
//            sizeof(VkDisplayPlaneProperties2KHR),
//            // Struct: 109
//            sizeof(VkDisplayPlanePropertiesKHR),
//            // Struct: 110
//            sizeof(VkDisplayPowerInfoEXT),
//            // Struct: 111
//            sizeof(VkDisplayPresentInfoKHR),
//            // Struct: 112
//            sizeof(VkDisplayProperties2KHR),
//            // Struct: 113
//            sizeof(VkDisplayPropertiesKHR),
//            // Struct: 114
//            sizeof(VkDisplaySurfaceCreateInfoKHR),
//            // Struct: 115
//            sizeof(VkDrawIndexedIndirectCommand),
//            // Struct: 116
//            sizeof(VkDrawIndirectCommand),
//            // Struct: 117
//            sizeof(VkDrawMeshTasksIndirectCommandNV),
//            // Struct: 118
//            sizeof(VkDrmFormatModifierPropertiesEXT),
//            // Struct: 119
//            sizeof(VkDrmFormatModifierPropertiesListEXT),
//            // Struct: 120
//            sizeof(VkEventCreateInfo),
//            // Struct: 121
//            sizeof(VkExportFenceCreateInfo),
//            // Struct: 122
//            sizeof(VkExportFenceWin32HandleInfoKHR),
//            // Struct: 123
//            sizeof(VkExportMemoryAllocateInfo),
//            // Struct: 124
//            sizeof(VkExportMemoryAllocateInfoNV),
//            // Struct: 125
//            sizeof(VkExportMemoryWin32HandleInfoKHR),
//            // Struct: 126
//            sizeof(VkExportMemoryWin32HandleInfoNV),
//            // Struct: 127
//            sizeof(VkExportSemaphoreCreateInfo),
//            // Struct: 128
//            sizeof(VkExportSemaphoreWin32HandleInfoKHR),
//            // Struct: 129
//            sizeof(VkExtensionProperties),
//            // Struct: 130
//            sizeof(VkExtent2D),
//            // Struct: 131
//            sizeof(VkExtent3D),
//            // Struct: 132
//            sizeof(VkExternalBufferProperties),
//            // Struct: 133
//            sizeof(VkExternalFenceProperties),
//            // Struct: 134
//            sizeof(VkExternalFormatANDROID),
//            // Struct: 135
//            sizeof(VkExternalImageFormatProperties),
//            // Struct: 136
//            sizeof(VkExternalImageFormatPropertiesNV),
//            // Struct: 137
//            sizeof(VkExternalMemoryBufferCreateInfo),
//            // Struct: 138
//            sizeof(VkExternalMemoryImageCreateInfo),
//            // Struct: 139
//            sizeof(VkExternalMemoryImageCreateInfoNV),
//            // Struct: 140
//            sizeof(VkExternalMemoryProperties),
//            // Struct: 141
//            sizeof(VkExternalSemaphoreProperties),
//            // Struct: 142
//            sizeof(VkFenceCreateInfo),
//            // Struct: 143
//            sizeof(VkFenceGetFdInfoKHR),
//            // Struct: 144
//            sizeof(VkFenceGetWin32HandleInfoKHR),
//            // Struct: 145
//            sizeof(VkFilterCubicImageViewImageFormatPropertiesEXT),
//            // Struct: 146
//            sizeof(VkFormatProperties),
//            // Struct: 147
//            sizeof(VkFormatProperties2),
//            // Struct: 148
//            sizeof(VkFramebufferCreateInfo),
//            // Struct: 149
//            sizeof(VkGeometryAABBNV),
//            // Struct: 150
//            sizeof(VkGeometryDataNV),
//            // Struct: 151
//            sizeof(VkGeometryNV),
//            // Struct: 152
//            sizeof(VkGeometryTrianglesNV),
//            // Struct: 153
//            sizeof(VkGraphicsPipelineCreateInfo),
//            // Struct: 154
//            sizeof(VkHdrMetadataEXT),
//            // Struct: 155
//            sizeof(VkIOSSurfaceCreateInfoMVK),
//            // Struct: 156
//            sizeof(VkImageBlit),
//            // Struct: 157
//            sizeof(VkImageCopy),
//            // Struct: 158
//            sizeof(VkImageCreateInfo),
//            // Struct: 159
//            sizeof(VkImageDrmFormatModifierExplicitCreateInfoEXT),
//            // Struct: 160
//            sizeof(VkImageDrmFormatModifierListCreateInfoEXT),
//            // Struct: 161
//            sizeof(VkImageDrmFormatModifierPropertiesEXT),
//            // Struct: 162
//            sizeof(VkImageFormatListCreateInfoKHR),
//            // Struct: 163
//            sizeof(VkImageFormatProperties),
//            // Struct: 164
//            sizeof(VkImageFormatProperties2),
//            // Struct: 165
//            sizeof(VkImageMemoryBarrier),
//            // Struct: 166
//            sizeof(VkImageMemoryRequirementsInfo2),
//            // Struct: 167
//            sizeof(VkImagePipeSurfaceCreateInfoFUCHSIA),
//            // Struct: 168
//            sizeof(VkImagePlaneMemoryRequirementsInfo),
//            // Struct: 169
//            sizeof(VkImageResolve),
//            // Struct: 170
//            sizeof(VkImageSparseMemoryRequirementsInfo2),
//            // Struct: 171
//            sizeof(VkImageStencilUsageCreateInfoEXT),
//            // Struct: 172
//            sizeof(VkImageSubresource),
//            // Struct: 173
//            sizeof(VkImageSubresourceLayers),
//            // Struct: 174
//            sizeof(VkImageSubresourceRange),
//            // Struct: 175
//            sizeof(VkImageSwapchainCreateInfoKHR),
//            // Struct: 176
//            sizeof(VkImageViewASTCDecodeModeEXT),
//            // Struct: 177
//            sizeof(VkImageViewCreateInfo),
//            // Struct: 178
//            sizeof(VkImageViewHandleInfoNVX),
//            // Struct: 179
//            sizeof(VkImageViewUsageCreateInfo),
//            // Struct: 180
//            sizeof(VkImportAndroidHardwareBufferInfoANDROID),
//            // Struct: 181
//            sizeof(VkImportFenceFdInfoKHR),
//            // Struct: 182
//            sizeof(VkImportFenceWin32HandleInfoKHR),
//            // Struct: 183
//            sizeof(VkImportMemoryFdInfoKHR),
//            // Struct: 184
//            sizeof(VkImportMemoryHostPointerInfoEXT),
//            // Struct: 185
//            sizeof(VkImportMemoryWin32HandleInfoKHR),
//            // Struct: 186
//            sizeof(VkImportMemoryWin32HandleInfoNV),
//            // Struct: 187
//            sizeof(VkImportSemaphoreFdInfoKHR),
//            // Struct: 188
//            sizeof(VkImportSemaphoreWin32HandleInfoKHR),
//            // Struct: 189
//            sizeof(VkIndirectCommandsLayoutCreateInfoNVX),
//            // Struct: 190
//            sizeof(VkIndirectCommandsLayoutTokenNVX),
//            // Struct: 191
//            sizeof(VkIndirectCommandsTokenNVX),
//            // Struct: 192
//            sizeof(VkInputAttachmentAspectReference),
//            // Struct: 193
//            sizeof(VkInstanceCreateInfo),
//            // Struct: 194
//            sizeof(VkLayerProperties),
//            // Struct: 195
//            sizeof(VkMacOSSurfaceCreateInfoMVK),
//            // Struct: 196
//            sizeof(VkMappedMemoryRange),
//            // Struct: 197
//            sizeof(VkMemoryAllocateFlagsInfo),
//            // Struct: 198
//            sizeof(VkMemoryAllocateInfo),
//            // Struct: 199
//            sizeof(VkMemoryBarrier),
//            // Struct: 200
//            sizeof(VkMemoryDedicatedAllocateInfo),
//            // Struct: 201
//            sizeof(VkMemoryDedicatedRequirements),
//            // Struct: 202
//            sizeof(VkMemoryFdPropertiesKHR),
//            // Struct: 203
//            sizeof(VkMemoryGetAndroidHardwareBufferInfoANDROID),
//            // Struct: 204
//            sizeof(VkMemoryGetFdInfoKHR),
//            // Struct: 205
//            sizeof(VkMemoryGetWin32HandleInfoKHR),
//            // Struct: 206
//            sizeof(VkMemoryHeap),
//            // Struct: 207
//            sizeof(VkMemoryHostPointerPropertiesEXT),
//            // Struct: 208
//            sizeof(VkMemoryPriorityAllocateInfoEXT),
//            // Struct: 209
//            sizeof(VkMemoryRequirements),
//            // Struct: 210
//            sizeof(VkMemoryRequirements2),
//            // Struct: 211
//            sizeof(VkMemoryType),
//            // Struct: 212
//            sizeof(VkMemoryWin32HandlePropertiesKHR),
//            // Struct: 213
//            sizeof(VkMetalSurfaceCreateInfoEXT),
//            // Struct: 214
//            sizeof(VkMultisamplePropertiesEXT),
//            // Struct: 215
//            sizeof(VkObjectTableCreateInfoNVX),
//            // Struct: 216
//            sizeof(VkObjectTableDescriptorSetEntryNVX),
//            // Struct: 217
//            sizeof(VkObjectTableEntryNVX),
//            // Struct: 218
//            sizeof(VkObjectTableIndexBufferEntryNVX),
//            // Struct: 219
//            sizeof(VkObjectTablePipelineEntryNVX),
//            // Struct: 220
//            sizeof(VkObjectTablePushConstantEntryNVX),
//            // Struct: 221
//            sizeof(VkObjectTableVertexBufferEntryNVX),
//            // Struct: 222
//            sizeof(VkOffset2D),
//            // Struct: 223
//            sizeof(VkOffset3D),
//            // Struct: 224
//            sizeof(VkPastPresentationTimingGOOGLE),
//            // Struct: 225
//            sizeof(VkPhysicalDevice16BitStorageFeatures),
//            // Struct: 226
//            sizeof(VkPhysicalDevice8BitStorageFeaturesKHR),
//            // Struct: 227
//            sizeof(VkPhysicalDeviceASTCDecodeFeaturesEXT),
//            // Struct: 228
//            sizeof(VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT),
//            // Struct: 229
//            sizeof(VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT),
//            // Struct: 230
//            sizeof(VkPhysicalDeviceBufferDeviceAddressFeaturesEXT),
//            // Struct: 231
//            sizeof(VkPhysicalDeviceComputeShaderDerivativesFeaturesNV),
//            // Struct: 232
//            sizeof(VkPhysicalDeviceConditionalRenderingFeaturesEXT),
//            // Struct: 233
//            sizeof(VkPhysicalDeviceConservativeRasterizationPropertiesEXT),
//            // Struct: 234
//            sizeof(VkPhysicalDeviceCooperativeMatrixFeaturesNV),
//            // Struct: 235
//            sizeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV),
//            // Struct: 236
//            sizeof(VkPhysicalDeviceCornerSampledImageFeaturesNV),
//            // Struct: 237
//            sizeof(VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV),
//            // Struct: 238
//            sizeof(VkPhysicalDeviceDepthClipEnableFeaturesEXT),
//            // Struct: 239
//            sizeof(VkPhysicalDeviceDepthStencilResolvePropertiesKHR),
//            // Struct: 240
//            sizeof(VkPhysicalDeviceDescriptorIndexingFeaturesEXT),
//            // Struct: 241
//            sizeof(VkPhysicalDeviceDescriptorIndexingPropertiesEXT),
//            // Struct: 242
//            sizeof(VkPhysicalDeviceDiscardRectanglePropertiesEXT),
//            // Struct: 243
//            sizeof(VkPhysicalDeviceDriverPropertiesKHR),
//            // Struct: 244
//            sizeof(VkPhysicalDeviceExclusiveScissorFeaturesNV),
//            // Struct: 245
//            sizeof(VkPhysicalDeviceExternalBufferInfo),
//            // Struct: 246
//            sizeof(VkPhysicalDeviceExternalFenceInfo),
//            // Struct: 247
//            sizeof(VkPhysicalDeviceExternalImageFormatInfo),
//            // Struct: 248
//            sizeof(VkPhysicalDeviceExternalMemoryHostPropertiesEXT),
//            // Struct: 249
//            sizeof(VkPhysicalDeviceExternalSemaphoreInfo),
//            // Struct: 250
//            sizeof(VkPhysicalDeviceFeatures),
//            // Struct: 251
//            sizeof(VkPhysicalDeviceFeatures2),
//            // Struct: 252
//            sizeof(VkPhysicalDeviceFloat16Int8FeaturesKHR),
//            // Struct: 253
//            sizeof(VkPhysicalDeviceFloatControlsPropertiesKHR),
//            // Struct: 254
//            sizeof(VkPhysicalDeviceFragmentDensityMapFeaturesEXT),
//            // Struct: 255
//            sizeof(VkPhysicalDeviceFragmentDensityMapPropertiesEXT),
//            // Struct: 256
//            sizeof(VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV),
//            // Struct: 257
//            sizeof(VkPhysicalDeviceGroupProperties),
//            // Struct: 258
//            sizeof(VkPhysicalDeviceHostQueryResetFeaturesEXT),
//            // Struct: 259
//            sizeof(VkPhysicalDeviceIDProperties),
//            // Struct: 260
//            sizeof(VkPhysicalDeviceImageDrmFormatModifierInfoEXT),
//            // Struct: 261
//            sizeof(VkPhysicalDeviceImageFormatInfo2),
//            // Struct: 262
//            sizeof(VkPhysicalDeviceImageViewImageFormatInfoEXT),
//            // Struct: 263
//            sizeof(VkPhysicalDeviceInlineUniformBlockFeaturesEXT),
//            // Struct: 264
//            sizeof(VkPhysicalDeviceInlineUniformBlockPropertiesEXT),
//            // Struct: 265
//            sizeof(VkPhysicalDeviceLimits),
//            // Struct: 266
//            sizeof(VkPhysicalDeviceMaintenance3Properties),
//            // Struct: 267
//            sizeof(VkPhysicalDeviceMemoryBudgetPropertiesEXT),
//            // Struct: 268
//            sizeof(VkPhysicalDeviceMemoryPriorityFeaturesEXT),
//            // Struct: 269
//            sizeof(VkPhysicalDeviceMemoryProperties),
//            // Struct: 270
//            sizeof(VkPhysicalDeviceMemoryProperties2),
//            // Struct: 271
//            sizeof(VkPhysicalDeviceMeshShaderFeaturesNV),
//            // Struct: 272
//            sizeof(VkPhysicalDeviceMeshShaderPropertiesNV),
//            // Struct: 273
//            sizeof(VkPhysicalDeviceMultiviewFeatures),
//            // Struct: 274
//            sizeof(VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX),
//            // Struct: 275
//            sizeof(VkPhysicalDeviceMultiviewProperties),
//            // Struct: 276
//            sizeof(VkPhysicalDevicePCIBusInfoPropertiesEXT),
//            // Struct: 277
//            sizeof(VkPhysicalDevicePointClippingProperties),
//            // Struct: 278
//            sizeof(VkPhysicalDeviceProperties),
//            // Struct: 279
//            sizeof(VkPhysicalDeviceProperties2),
//            // Struct: 280
//            sizeof(VkPhysicalDeviceProtectedMemoryFeatures),
//            // Struct: 281
//            sizeof(VkPhysicalDeviceProtectedMemoryProperties),
//            // Struct: 282
//            sizeof(VkPhysicalDevicePushDescriptorPropertiesKHR),
//            // Struct: 283
//            sizeof(VkPhysicalDeviceRayTracingPropertiesNV),
//            // Struct: 284
//            sizeof(VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV),
//            // Struct: 285
//            sizeof(VkPhysicalDeviceSampleLocationsPropertiesEXT),
//            // Struct: 286
//            sizeof(VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT),
//            // Struct: 287
//            sizeof(VkPhysicalDeviceSamplerYcbcrConversionFeatures),
//            // Struct: 288
//            sizeof(VkPhysicalDeviceScalarBlockLayoutFeaturesEXT),
//            // Struct: 289
//            sizeof(VkPhysicalDeviceShaderAtomicInt64FeaturesKHR),
//            // Struct: 290
//            sizeof(VkPhysicalDeviceShaderCorePropertiesAMD),
//            // Struct: 291
//            sizeof(VkPhysicalDeviceShaderDrawParametersFeatures),
//            // Struct: 292
//            sizeof(VkPhysicalDeviceShaderImageFootprintFeaturesNV),
//            // Struct: 293
//            sizeof(VkPhysicalDeviceShadingRateImageFeaturesNV),
//            // Struct: 294
//            sizeof(VkPhysicalDeviceShadingRateImagePropertiesNV),
//            // Struct: 295
//            sizeof(VkPhysicalDeviceSparseImageFormatInfo2),
//            // Struct: 296
//            sizeof(VkPhysicalDeviceSparseProperties),
//            // Struct: 297
//            sizeof(VkPhysicalDeviceSubgroupProperties),
//            // Struct: 298
//            sizeof(VkPhysicalDeviceSurfaceInfo2KHR),
//            // Struct: 299
//            sizeof(VkPhysicalDeviceTransformFeedbackFeaturesEXT),
//            // Struct: 300
//            sizeof(VkPhysicalDeviceTransformFeedbackPropertiesEXT),
//            // Struct: 301
//            sizeof(VkPhysicalDeviceVariablePointersFeatures),
//            // Struct: 302
//            sizeof(VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT),
//            // Struct: 303
//            sizeof(VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT),
//            // Struct: 304
//            sizeof(VkPhysicalDeviceVulkanMemoryModelFeaturesKHR),
//            // Struct: 305
//            sizeof(VkPhysicalDeviceYcbcrImageArraysFeaturesEXT),
//            // Struct: 306
//            sizeof(VkPipelineCacheCreateInfo),
//            // Struct: 307
//            sizeof(VkPipelineColorBlendAdvancedStateCreateInfoEXT),
//            // Struct: 308
//            sizeof(VkPipelineColorBlendAttachmentState),
//            // Struct: 309
//            sizeof(VkPipelineColorBlendStateCreateInfo),
//            // Struct: 310
//            sizeof(VkPipelineCoverageModulationStateCreateInfoNV),
//            // Struct: 311
//            sizeof(VkPipelineCoverageToColorStateCreateInfoNV),
//            // Struct: 312
//            sizeof(VkPipelineCreationFeedbackCreateInfoEXT),
//            // Struct: 313
//            sizeof(VkPipelineCreationFeedbackEXT),
//            // Struct: 314
//            sizeof(VkPipelineDepthStencilStateCreateInfo),
//            // Struct: 315
//            sizeof(VkPipelineDiscardRectangleStateCreateInfoEXT),
//            // Struct: 316
//            sizeof(VkPipelineDynamicStateCreateInfo),
//            // Struct: 317
//            sizeof(VkPipelineInputAssemblyStateCreateInfo),
//            // Struct: 318
//            sizeof(VkPipelineLayoutCreateInfo),
//            // Struct: 319
//            sizeof(VkPipelineMultisampleStateCreateInfo),
//            // Struct: 320
//            sizeof(VkPipelineRasterizationConservativeStateCreateInfoEXT),
//            // Struct: 321
//            sizeof(VkPipelineRasterizationDepthClipStateCreateInfoEXT),
//            // Struct: 322
//            sizeof(VkPipelineRasterizationStateCreateInfo),
//            // Struct: 323
//            sizeof(VkPipelineRasterizationStateRasterizationOrderAMD),
//            // Struct: 324
//            sizeof(VkPipelineRasterizationStateStreamCreateInfoEXT),
//            // Struct: 325
//            sizeof(VkPipelineRepresentativeFragmentTestStateCreateInfoNV),
//            // Struct: 326
//            sizeof(VkPipelineSampleLocationsStateCreateInfoEXT),
//            // Struct: 327
//            sizeof(VkPipelineShaderStageCreateInfo),
//            // Struct: 328
//            sizeof(VkPipelineTessellationDomainOriginStateCreateInfo),
//            // Struct: 329
//            sizeof(VkPipelineTessellationStateCreateInfo),
//            // Struct: 330
//            sizeof(VkPipelineVertexInputDivisorStateCreateInfoEXT),
//            // Struct: 331
//            sizeof(VkPipelineVertexInputStateCreateInfo),
//            // Struct: 332
//            sizeof(VkPipelineViewportCoarseSampleOrderStateCreateInfoNV),
//            // Struct: 333
//            sizeof(VkPipelineViewportExclusiveScissorStateCreateInfoNV),
//            // Struct: 334
//            sizeof(VkPipelineViewportShadingRateImageStateCreateInfoNV),
//            // Struct: 335
//            sizeof(VkPipelineViewportStateCreateInfo),
//            // Struct: 336
//            sizeof(VkPipelineViewportSwizzleStateCreateInfoNV),
//            // Struct: 337
//            sizeof(VkPipelineViewportWScalingStateCreateInfoNV),
//            // Struct: 338
//            sizeof(VkPresentFrameTokenGGP),
//            // Struct: 339
//            sizeof(VkPresentInfoKHR),
//            // Struct: 340
//            sizeof(VkPresentRegionKHR),
//            // Struct: 341
//            sizeof(VkPresentRegionsKHR),
//            // Struct: 342
//            sizeof(VkPresentTimeGOOGLE),
//            // Struct: 343
//            sizeof(VkPresentTimesInfoGOOGLE),
//            // Struct: 344
//            sizeof(VkProtectedSubmitInfo),
//            // Struct: 345
//            sizeof(VkPushConstantRange),
//            // Struct: 346
//            sizeof(VkQueryPoolCreateInfo),
//            // Struct: 347
//            sizeof(VkQueueFamilyCheckpointPropertiesNV),
//            // Struct: 348
//            sizeof(VkQueueFamilyProperties),
//            // Struct: 349
//            sizeof(VkQueueFamilyProperties2),
//            // Struct: 350
//            sizeof(VkRayTracingPipelineCreateInfoNV),
//            // Struct: 351
//            sizeof(VkRayTracingShaderGroupCreateInfoNV),
//            // Struct: 352
//            sizeof(VkRect2D),
//            // Struct: 353
//            sizeof(VkRectLayerKHR),
//            // Struct: 354
//            sizeof(VkRefreshCycleDurationGOOGLE),
//            // Struct: 355
//            sizeof(VkRenderPassBeginInfo),
//            // Struct: 356
//            sizeof(VkRenderPassCreateInfo),
//            // Struct: 357
//            sizeof(VkRenderPassCreateInfo2KHR),
//            // Struct: 358
//            sizeof(VkRenderPassFragmentDensityMapCreateInfoEXT),
//            // Struct: 359
//            sizeof(VkRenderPassInputAttachmentAspectCreateInfo),
//            // Struct: 360
//            sizeof(VkRenderPassMultiviewCreateInfo),
//            // Struct: 361
//            sizeof(VkRenderPassSampleLocationsBeginInfoEXT),
//            // Struct: 362
//            sizeof(VkSampleLocationEXT),
//            // Struct: 363
//            sizeof(VkSampleLocationsInfoEXT),
//            // Struct: 364
//            sizeof(VkSamplerCreateInfo),
//            // Struct: 365
//            sizeof(VkSamplerReductionModeCreateInfoEXT),
//            // Struct: 366
//            sizeof(VkSamplerYcbcrConversionCreateInfo),
//            // Struct: 367
//            sizeof(VkSamplerYcbcrConversionImageFormatProperties),
//            // Struct: 368
//            sizeof(VkSamplerYcbcrConversionInfo),
//            // Struct: 369
//            sizeof(VkSemaphoreCreateInfo),
//            // Struct: 370
//            sizeof(VkSemaphoreGetFdInfoKHR),
//            // Struct: 371
//            sizeof(VkSemaphoreGetWin32HandleInfoKHR),
//            // Struct: 372
//            sizeof(VkShaderModuleCreateInfo),
//            // Struct: 373
//            sizeof(VkShaderModuleValidationCacheCreateInfoEXT),
//            // Struct: 374
//            sizeof(VkShaderResourceUsageAMD),
//            // Struct: 375
//            sizeof(VkShaderStatisticsInfoAMD),
//            // Struct: 376
//            sizeof(VkShadingRatePaletteNV),
//            // Struct: 377
//            sizeof(VkSharedPresentSurfaceCapabilitiesKHR),
//            // Struct: 378
//            sizeof(VkSparseBufferMemoryBindInfo),
//            // Struct: 379
//            sizeof(VkSparseImageFormatProperties),
//            // Struct: 380
//            sizeof(VkSparseImageFormatProperties2),
//            // Struct: 381
//            sizeof(VkSparseImageMemoryBind),
//            // Struct: 382
//            sizeof(VkSparseImageMemoryBindInfo),
//            // Struct: 383
//            sizeof(VkSparseImageMemoryRequirements),
//            // Struct: 384
//            sizeof(VkSparseImageMemoryRequirements2),
//            // Struct: 385
//            sizeof(VkSparseImageOpaqueMemoryBindInfo),
//            // Struct: 386
//            sizeof(VkSparseMemoryBind),
//            // Struct: 387
//            sizeof(VkSpecializationInfo),
//            // Struct: 388
//            sizeof(VkSpecializationMapEntry),
//            // Struct: 389
//            sizeof(VkStencilOpState),
//            // Struct: 390
//            sizeof(VkStreamDescriptorSurfaceCreateInfoGGP),
//            // Struct: 391
//            sizeof(VkSubmitInfo),
//            // Struct: 392
//            sizeof(VkSubpassBeginInfoKHR),
//            // Struct: 393
//            sizeof(VkSubpassDependency),
//            // Struct: 394
//            sizeof(VkSubpassDependency2KHR),
//            // Struct: 395
//            sizeof(VkSubpassDescription),
//            // Struct: 396
//            sizeof(VkSubpassDescription2KHR),
//            // Struct: 397
//            sizeof(VkSubpassDescriptionDepthStencilResolveKHR),
//            // Struct: 398
//            sizeof(VkSubpassEndInfoKHR),
//            // Struct: 399
//            sizeof(VkSubpassSampleLocationsEXT),
//            // Struct: 400
//            sizeof(VkSubresourceLayout),
//            // Struct: 401
//            sizeof(VkSurfaceCapabilities2EXT),
//            // Struct: 402
//            sizeof(VkSurfaceCapabilities2KHR),
//            // Struct: 403
//            sizeof(VkSurfaceCapabilitiesFullScreenExclusiveEXT),
//            // Struct: 404
//            sizeof(VkSurfaceCapabilitiesKHR),
//            // Struct: 405
//            sizeof(VkSurfaceFormat2KHR),
//            // Struct: 406
//            sizeof(VkSurfaceFormatKHR),
//            // Struct: 407
//            sizeof(VkSurfaceFullScreenExclusiveInfoEXT),
//            // Struct: 408
//            sizeof(VkSurfaceFullScreenExclusiveWin32InfoEXT),
//            // Struct: 409
//            sizeof(VkSurfaceProtectedCapabilitiesKHR),
//            // Struct: 410
//            sizeof(VkSwapchainCounterCreateInfoEXT),
//            // Struct: 411
//            sizeof(VkSwapchainCreateInfoKHR),
//            // Struct: 412
//            sizeof(VkSwapchainDisplayNativeHdrCreateInfoAMD),
//            // Struct: 413
//            sizeof(VkTextureLODGatherFormatPropertiesAMD),
//            // Struct: 414
//            sizeof(VkValidationCacheCreateInfoEXT),
//            // Struct: 415
//            sizeof(VkValidationFeaturesEXT),
//            // Struct: 416
//            sizeof(VkValidationFlagsEXT),
//            // Struct: 417
//            sizeof(VkVertexInputAttributeDescription),
//            // Struct: 418
//            sizeof(VkVertexInputBindingDescription),
//            // Struct: 419
//            sizeof(VkVertexInputBindingDivisorDescriptionEXT),
//            // Struct: 420
//            sizeof(VkViSurfaceCreateInfoNN),
//            // Struct: 421
//            sizeof(VkViewport),
//            // Struct: 422
//            sizeof(VkViewportSwizzleNV),
//            // Struct: 423
//            sizeof(VkViewportWScalingNV),
//            // Struct: 424
//            sizeof(VkWaylandSurfaceCreateInfoKHR),
//            // Struct: 425
//            sizeof(VkWin32KeyedMutexAcquireReleaseInfoKHR),
//            // Struct: 426
//            sizeof(VkWin32KeyedMutexAcquireReleaseInfoNV),
//            // Struct: 427
//            sizeof(VkWin32SurfaceCreateInfoKHR),
//            // Struct: 428
//            sizeof(VkWriteDescriptorSet),
//            // Struct: 429
//            sizeof(VkWriteDescriptorSetAccelerationStructureNV),
//            // Struct: 430
//            sizeof(VkWriteDescriptorSetInlineUniformBlockEXT),
//            // Struct: 431
//            sizeof(VkXYColorEXT),
//            // Struct: 432
//            sizeof(VkXcbSurfaceCreateInfoKHR),
//            // Struct: 433
//            sizeof(VkXlibSurfaceCreateInfoKHR),
//        };

//    }
//}
