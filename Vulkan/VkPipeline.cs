using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan {
    public unsafe partial class VkPipeline : IDisposable {
        private readonly VkDevice device;
        private readonly UnmanagedArray<VkAllocationCallbacks> callbacks;
        public readonly UInt64 handle;

        public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, VkComputePipelineCreateInfo[] createInfos, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkPipeline[] pipelines) {
            if (device == null || createInfos == null || createInfos.Length == 0) { pipelines = null; return VkResult.Incomplete; }

            VkResult result = VkResult.Success;
            UInt32 count = (UInt32)createInfos.Length;
            var handles = new UInt64[count];
            fixed (UInt64* pointer = handles) {
                fixed (VkComputePipelineCreateInfo* pCreateInfos = createInfos) {
                    VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
                    result = vkAPI.vkCreateComputePipelines(device.handle,
                        pipelineCache != null ? pipelineCache.handle : default(UInt64),
                        count, pCreateInfos, pAllocator, pointer).Check();
                }
            }

            pipelines = new VkPipeline[count];
            for (int i = 0; i < count; i++) {
                pipelines[i] = new VkPipeline(device, callbacks, handles[i]);
            }

            return result;
        }

        public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, VkGraphicsPipelineCreateInfo[] createInfos, UnmanagedArray<VkAllocationCallbacks> callbacks, out VkPipeline[] pipelines) {
            if (device == null || createInfos == null || createInfos.Length == 0) { pipelines = null; return VkResult.Incomplete; }

            VkResult result = VkResult.Success;
            UInt32 count = (UInt32)createInfos.Length;
            var handles = new UInt64[count];
            fixed (UInt64* pointer = handles) {
                fixed (VkGraphicsPipelineCreateInfo* pCreateInfos = createInfos) {
                    VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
                    result = vkAPI.vkCreateGraphicsPipelines(device.handle,
                        pipelineCache != null ? pipelineCache.handle : default(UInt64),
                        count, pCreateInfos, pAllocator, pointer).Check();
                }
            }

            pipelines = new VkPipeline[count];
            for (int i = 0; i < count; i++) {
                pipelines[i] = new VkPipeline(device, callbacks, handles[i]);
            }

            return result;
        }

        private VkPipeline(VkDevice device, UnmanagedArray<VkAllocationCallbacks> callbacks, UInt64 handle) {
            this.device = device;
            this.callbacks = callbacks;
            this.handle = handle;
        }

        public override string ToString() => $"{nameof(VkPipeline)}, {handle}";

        /// <summary>
        /// Destruct instance of the class.
        /// </summary>
        ~VkPipeline() {
            this.Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        } // end sub

        /// <summary>
        /// Backing field to track whether Dispose has been called.
        /// </summary>
        private bool disposedValue = false;

        /// <summary>
        /// Dispose managed and unmanaged resources of this instance.
        /// </summary>
        /// <param name="disposing">If disposing equals true, managed and unmanaged resources can be disposed. If disposing equals false, only unmanaged resources can be disposed. </param>
        private void Dispose(bool disposing) {
            if (this.disposedValue == false) {
                if (disposing) {
                    // Dispose managed resources.
                    //DisposeManagedResources();
                }

                // Dispose unmanaged resources.
                VkAllocationCallbacks* pAllocator = callbacks != null ? (VkAllocationCallbacks*)callbacks.header : null;
                vkAPI.vkDestroyPipeline(this.device.handle, this.handle, pAllocator);
            }
            this.disposedValue = true;
        }
    }
}

