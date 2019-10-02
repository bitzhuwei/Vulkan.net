using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.vkAPI;
using static Vulkan.VkStructureType;
using static Demo.Texture.VulkanNative;
using System.Numerics;
using System.Diagnostics;

namespace Demo.Texture {
    public unsafe class vksVulkanDevice {
        public const ulong DEFAULT_FENCE_TIMEOUT = 100000000000;

        public VkPhysicalDevice PhysicalDevice { get; private set; }
        public VkPhysicalDeviceProperties properties { get; private set; }
        public VkPhysicalDeviceFeatures features { get; private set; }
        public VkPhysicalDeviceMemoryProperties MemoryProperties { get; private set; }
        public VkQueueFamilyProperties[] QueueFamilyProperties;
        public List<string> SuppertedExcentions { get; } = new List<string>();
        public VkDevice LogicalDevice => _logicalDevice;
        public VkCommandPool CommandPool { get; private set; }
        public bool EnableDebugMarkers { get; internal set; }

        public QueueFamilyIndices QFIndices;
        private VkDevice _logicalDevice;

        public vksVulkanDevice(VkPhysicalDevice physicalDevice) {
            Debug.Assert(physicalDevice.handle != 0);
            PhysicalDevice = physicalDevice;

            // Store Properties features, limits and properties of the physical device for later use
            // Device properties also contain limits and sparse properties
            VkPhysicalDeviceProperties properties;
            vkGetPhysicalDeviceProperties(physicalDevice, &properties);
            this.properties = properties;
            // Features should be checked by the examples before using them
            VkPhysicalDeviceFeatures features;
            vkGetPhysicalDeviceFeatures(physicalDevice, &features);
            this.features = features;
            // Memory properties are used regularly for creating all kinds of buffers
            VkPhysicalDeviceMemoryProperties memoryProperties;
            vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memoryProperties);
            MemoryProperties = memoryProperties;
            // Queue family properties, used for setting up requested queues upon device creation
            uint queueFamilyCount = 0;
            vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &queueFamilyCount, null);
            Debug.Assert(queueFamilyCount > 0);
            QueueFamilyProperties = new VkQueueFamilyProperties[queueFamilyCount];
            fixed (VkQueueFamilyProperties* pointer = QueueFamilyProperties) {
                vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &queueFamilyCount, pointer);
            }

            // Get list of supported extensions
            uint extCount = 0;
            vkEnumerateDeviceExtensionProperties(physicalDevice, IntPtr.Zero, &extCount, null);
            if (extCount > 0) {
                VkExtensionProperties* extensions = stackalloc VkExtensionProperties[(int)extCount];
                if (vkEnumerateDeviceExtensionProperties(physicalDevice, IntPtr.Zero, &extCount, extensions) == VkResult.Success) {
                    for (uint i = 0; i < extCount; i++) {
                        var ext = extensions[i];
                        // supportedExtensions.push_back(ext.extensionName);
                        // TODO: fixed-length char arrays are not being parsed correctly.
                    }
                }
            }
        }


        public VkResult CreateLogicalDevice(
            VkPhysicalDeviceFeatures enabledFeatures,
            string[] enabledExtensions,
            bool useSwapChain = true,
            VkQueueFlagBits requestedQueueTypes = VkQueueFlagBits.Graphics | VkQueueFlagBits.Compute) {
            // Desired queues need to be requested upon logical device creation
            // Due to differing queue family configurations of Vulkan implementations this can be a bit tricky, especially if the application
            // requests different queue types

            var queueCreateInfos = new List<VkDeviceQueueCreateInfo>();
            float defaultQueuePriority = 0.0f;

            // Graphics queue
            if ((requestedQueueTypes & VkQueueFlagBits.Graphics) != 0) {
                QFIndices.Graphics = GetQueueFamilyIndex(VkQueueFlagBits.Graphics);
                VkDeviceQueueCreateInfo queueInfo = new VkDeviceQueueCreateInfo();
                queueInfo.sType = DeviceQueueCreateInfo;
                queueInfo.queueFamilyIndex = QFIndices.Graphics;
                queueInfo.queueCount = 1;
                queueInfo.pQueuePriorities = &defaultQueuePriority;
                queueCreateInfos.Add(queueInfo);
            }
            else {
                QFIndices.Graphics = 0;
            }

            // Dedicated compute queue
            if ((requestedQueueTypes & VkQueueFlagBits.Compute) != 0) {
                QFIndices.Compute = GetQueueFamilyIndex(VkQueueFlagBits.Compute);
                if (QFIndices.Compute != QFIndices.Graphics) {
                    // If compute family index differs, we need an additional queue create info for the compute queue
                    VkDeviceQueueCreateInfo queueInfo = new VkDeviceQueueCreateInfo();
                    queueInfo.sType = DeviceQueueCreateInfo;
                    queueInfo.queueFamilyIndex = QFIndices.Compute;
                    queueInfo.queueCount = 1;
                    queueInfo.pQueuePriorities = &defaultQueuePriority;
                    queueCreateInfos.Add(queueInfo);
                }
            }
            else {
                // Else we use the same queue
                QFIndices.Compute = QFIndices.Graphics;
            }

            // Dedicated transfer queue
            if ((requestedQueueTypes & VkQueueFlagBits.Transfer) != 0) {
                QFIndices.Transfer = GetQueueFamilyIndex(VkQueueFlagBits.Transfer);
                if (QFIndices.Transfer != QFIndices.Graphics && QFIndices.Transfer != QFIndices.Compute) {
                    // If compute family index differs, we need an additional queue create info for the transfer queue
                    VkDeviceQueueCreateInfo queueInfo = new VkDeviceQueueCreateInfo();
                    queueInfo.sType = DeviceQueueCreateInfo;
                    queueInfo.queueFamilyIndex = QFIndices.Transfer;
                    queueInfo.queueCount = 1;
                    queueInfo.pQueuePriorities = &defaultQueuePriority;
                    queueCreateInfos.Add(queueInfo);
                }
            }
            else {
                // Else we use the same queue
                QFIndices.Transfer = QFIndices.Graphics;
            }

            // Create the logical device representation
            //using (NativeList<IntPtr> deviceExtensions = new NativeList<IntPtr>(enabledExtensions)) {
            var deviceExtensions = new List<string>();
            if (useSwapChain) {
                // If the device will be used for presenting to a display via a swapchain we need to request the swapchain extension
                deviceExtensions.Add(Strings.VK_KHR_SWAPCHAIN_EXTENSION_NAME);
            }

            var deviceCreateInfo = VkDeviceCreateInfo.Alloc();
            //deviceCreateInfo.queueCreateInfoCount = (uint)queueCreateInfos.Count;
            //deviceCreateInfo.pQueueCreateInfos = (VkDeviceQueueCreateInfo*)queueCreateInfos.Data.ToPointer();
            //{
            //    VkDeviceQueueCreateInfo[] array = queueCreateInfos.ToArray();
            //    IntPtr ptr = IntPtr.Zero;
            //    array.Set(ref ptr, ref deviceCreateInfo.queueCreateInfoCount);
            //    deviceCreateInfo.pQueueCreateInfos = (VkDeviceQueueCreateInfo*)ptr;
            //}
            queueCreateInfos.ToArray().Set(deviceCreateInfo);
            deviceCreateInfo->pEnabledFeatures = &enabledFeatures;

            if (deviceExtensions.Count > 0) {
                string[] array = deviceExtensions.ToArray();
                array.SetExtensions(deviceCreateInfo);
            }

            VkDevice device;
            VkResult result = vkCreateDevice(PhysicalDevice, deviceCreateInfo, null, &device);
            this._logicalDevice = device;
            if (result == VkResult.Success) {
                // Create a default command pool for graphics command buffers
                CommandPool = CreateCommandPool(QFIndices.Graphics);
            }

            return result;
        }

        private uint GetQueueFamilyIndex(VkQueueFlagBits queueFlags) {
            // Dedicated queue for compute
            // Try to find a queue family index that supports compute but not graphics
            if ((queueFlags & VkQueueFlagBits.Compute) != 0) {
                for (uint i = 0; i < QueueFamilyProperties.Length; i++) {
                    if (((QueueFamilyProperties[i].queueFlags & queueFlags) != 0)
                        && (QueueFamilyProperties[i].queueFlags & VkQueueFlagBits.Graphics) == 0) {
                        return i;
                    }
                }
            }

            // Dedicated queue for transfer
            // Try to find a queue family index that supports transfer but not graphics and compute
            if ((queueFlags & VkQueueFlagBits.Transfer) != 0) {
                for (uint i = 0; i < QueueFamilyProperties.Length; i++) {
                    if (((QueueFamilyProperties[i].queueFlags & queueFlags) != 0)
                        && (QueueFamilyProperties[i].queueFlags & VkQueueFlagBits.Graphics) == 0
                        && (QueueFamilyProperties[i].queueFlags & VkQueueFlagBits.Compute) == 0) {
                        return i;
                    }
                }
            }

            // For other queue types or if no separate compute queue is present, return the first one to support the requested flags
            for (uint i = 0; i < QueueFamilyProperties.Length; i++) {
                if ((QueueFamilyProperties[i].queueFlags & queueFlags) != 0) {
                    return i;
                }
            }

            throw new InvalidOperationException("Could not find a matching queue family index");
        }

        private VkCommandPool CreateCommandPool(
            uint queueFamilyIndex,
            VkCommandPoolCreateFlagBits createFlags = VkCommandPoolCreateFlagBits.ResetCommandBuffer) {
            VkCommandPoolCreateInfo cmdPoolInfo = new VkCommandPoolCreateInfo();
            cmdPoolInfo.sType = CommandPoolCreateInfo;
            cmdPoolInfo.queueFamilyIndex = queueFamilyIndex;
            cmdPoolInfo.flags = createFlags;
            VkCommandPool cmdPool;
            vkCreateCommandPool(LogicalDevice, &cmdPoolInfo, null, &cmdPool);
            return cmdPool;
        }

        /**
        * Create a buffer on the device
        *
        * @param usageFlags Usage flag bitmask for the buffer (i.e. index, vertex, uniform buffer)
        * @param memoryPropertyFlags Memory properties for this buffer (i.e. device local, host visible, coherent)
        * @param buffer Pointer to a vk::Vulkan buffer object
        * @param size Size of the buffer in byes
        * @param data Pointer to the data that should be copied to the buffer after creation (optional, if not set, no data is copied over)
        *
        * @return Success if buffer handle and memory have been created and (optionally passed) data has been copied
        */
        public VkResult createBuffer(VkBufferUsageFlagBits usageFlags, VkMemoryPropertyFlagBits memoryPropertyFlags, vksBuffer buffer, ulong size, void* data = null) {
            buffer.device = _logicalDevice;

            // Create the buffer handle
            VkBufferCreateInfo bufferCreateInfo = new VkBufferCreateInfo();
            bufferCreateInfo.sType = BufferCreateInfo;
            bufferCreateInfo.usage = usageFlags;
            bufferCreateInfo.size = size;
            {
                VkBuffer vkBuffer;
                vkCreateBuffer(_logicalDevice, &bufferCreateInfo, null, &vkBuffer);
                buffer.buffer = vkBuffer;
            }

            // Create the memory backing up the buffer handle
            VkMemoryRequirements memReqs;
            VkMemoryAllocateInfo memAlloc = new VkMemoryAllocateInfo();
            memAlloc.sType = MemoryAllocateInfo;
            vkGetBufferMemoryRequirements(_logicalDevice, buffer.buffer, &memReqs);
            memAlloc.allocationSize = memReqs.size;
            // Find a memory type index that fits the properties of the buffer
            memAlloc.memoryTypeIndex = getMemoryType(memReqs.memoryTypeBits, memoryPropertyFlags);
            {
                VkDeviceMemory memory;
                vkAllocateMemory(_logicalDevice, &memAlloc, null, &memory);
                buffer.memory = memory;
            }

            buffer.alignment = memReqs.alignment;
            buffer.size = memAlloc.allocationSize;
            buffer.usageFlags = usageFlags;
            buffer.memoryPropertyFlags = memoryPropertyFlags;

            // If a pointer to the buffer data has been passed, map the buffer and copy over the data
            if (data != null) {
                buffer.map();
                Unsafe.CopyBlock(buffer.mapped, data, (uint)size);
                buffer.unmap();
            }

            // Initialize a default descriptor that covers the whole buffer size
            buffer.setupDescriptor();

            // Attach the memory to the buffer object
            return buffer.bind();
        }

        public VkResult createBuffer(VkBufferUsageFlagBits usageFlags, VkMemoryPropertyFlagBits memoryPropertyFlags, vksBuffer buffer, ulong size, IntPtr data)
            => createBuffer(usageFlags, memoryPropertyFlags, buffer, size, data.ToPointer());

        /**
        * Create a buffer on the device
        *
        * @param usageFlags Usage flag bitmask for the buffer (i.e. index, vertex, uniform buffer)
        * @param memoryPropertyFlags Memory properties for this buffer (i.e. device local, host visible, coherent)
        * @param size Size of the buffer in byes
        * @param buffer Pointer to the buffer handle acquired by the function
        * @param memory Pointer to the memory handle acquired by the function
        * @param data Pointer to the data that should be copied to the buffer after creation (optional, if not set, no data is copied over)
        *
        * @return Success if buffer handle and memory have been created and (optionally passed) data has been copied
        */
        public VkResult createBuffer(VkBufferUsageFlagBits usageFlags, VkMemoryPropertyFlagBits memoryPropertyFlags, ulong size, VkBuffer* buffer, VkDeviceMemory* memory, void* data = null) {
            // Create the buffer handle
            VkBufferCreateInfo bufferCreateInfo = new VkBufferCreateInfo();
            bufferCreateInfo.sType = BufferCreateInfo;
            bufferCreateInfo.usage = usageFlags;
            bufferCreateInfo.size = size;
            bufferCreateInfo.sharingMode = VkSharingMode.Exclusive;
            vkCreateBuffer(LogicalDevice, &bufferCreateInfo, null, buffer);

            // Create the memory backing up the buffer handle
            VkMemoryRequirements memReqs;
            VkMemoryAllocateInfo memAlloc = new VkMemoryAllocateInfo();
            memAlloc.sType = MemoryAllocateInfo;
            vkGetBufferMemoryRequirements(LogicalDevice, *buffer, &memReqs);
            memAlloc.allocationSize = memReqs.size;
            // Find a memory type index that fits the properties of the buffer
            memAlloc.memoryTypeIndex = getMemoryType(memReqs.memoryTypeBits, memoryPropertyFlags);
            vkAllocateMemory(LogicalDevice, &memAlloc, null, memory);

            // If a pointer to the buffer data has been passed, map the buffer and copy over the data
            if (data != null) {
                IntPtr mapped;
                vkMapMemory(LogicalDevice, *memory, 0, size, 0, &mapped);
                Unsafe.CopyBlock(mapped, data, (uint)size);
                // If host coherency hasn't been requested, do a manual flush to make writes visible
                if ((memoryPropertyFlags & VkMemoryPropertyFlagBits.HostCoherent) == 0) {
                    VkMappedMemoryRange mappedRange = new VkMappedMemoryRange();
                    mappedRange.memory = *memory;
                    mappedRange.offset = 0;
                    mappedRange.size = size;
                    vkFlushMappedMemoryRanges(LogicalDevice, 1, &mappedRange);
                }
                vkUnmapMemory(LogicalDevice, *memory);
            }

            // Attach the memory to the buffer object
            vkBindBufferMemory(LogicalDevice, *buffer, *memory, 0);

            return VkResult.Success;
        }

        public VkResult createBuffer(VkBufferUsageFlagBits usageFlags, VkMemoryPropertyFlagBits memoryPropertyFlags, ulong size, out VkBuffer buffer, out VkDeviceMemory memory, void* data = null) {
            VkBuffer b;
            VkDeviceMemory dm;
            VkResult result = createBuffer(usageFlags, memoryPropertyFlags, size, &b, &dm, data);
            buffer = b;
            memory = dm;
            return result;
        }

        public VkCommandBuffer createCommandBuffer(VkCommandBufferLevel level, bool begin = false) {
            VkCommandBufferAllocateInfo cmdBufAllocateInfo = new VkCommandBufferAllocateInfo();
            cmdBufAllocateInfo.sType = CommandBufferAllocateInfo;
            cmdBufAllocateInfo.commandPool = CommandPool;
            cmdBufAllocateInfo.level = level;
            cmdBufAllocateInfo.commandBufferCount = 1;

            VkCommandBuffer cmdBuffer;
            vkAllocateCommandBuffers(_logicalDevice, &cmdBufAllocateInfo, &cmdBuffer);

            // If requested, also start recording for the new command buffer
            if (begin) {
                VkCommandBufferBeginInfo cmdBufInfo = new VkCommandBufferBeginInfo();
                cmdBufInfo.sType = CommandBufferBeginInfo;
                vkBeginCommandBuffer(cmdBuffer, &cmdBufInfo);
            }

            return cmdBuffer;
        }

        /**
		* Finish command buffer recording and submit it to a queue
		*
		* @param commandBuffer Command buffer to flush
		* @param queue Queue to submit the command buffer to 
		* @param free (Optional) Free the command buffer once it has been submitted (Defaults to true)
		*
		* @note The queue that the command buffer is submitted to must be from the same family index as the pool it was allocated from
		* @note Uses a fence to ensure command buffer has finished executing
		*/
        public void flushCommandBuffer(VkCommandBuffer commandBuffer, VkQueue queue, bool free = true) {
            if (commandBuffer.handle == 0) {
                return;
            }

            vkEndCommandBuffer(commandBuffer);

            VkSubmitInfo submitInfo = new VkSubmitInfo();
            submitInfo.sType = SubmitInfo;
            submitInfo.commandBufferCount = 1;
            submitInfo.pCommandBuffers = &commandBuffer;

            // Create fence to ensure that the command buffer has finished executing
            VkFenceCreateInfo fenceInfo = new VkFenceCreateInfo();
            fenceInfo.sType = FenceCreateInfo;
            fenceInfo.flags = 0;
            VkFence fence;
            vkCreateFence(_logicalDevice, &fenceInfo, null, &fence);

            // Submit to the queue
            vkQueueSubmit(queue, 1, &submitInfo, fence);
            // Wait for the fence to signal that command buffer has finished executing
            vkWaitForFences(_logicalDevice, 1, &fence, true, DEFAULT_FENCE_TIMEOUT);

            vkDestroyFence(_logicalDevice, fence, null);

            if (free) {
                vkFreeCommandBuffers(_logicalDevice, CommandPool, 1, &commandBuffer);
            }
        }

        /**
        * Get the index of a memory type that has all the requested property bits set
        *
        * @param typeBits Bitmask with bits set for each memory type supported by the resource to request for (from VkMemoryRequirements)
        * @param properties Bitmask of properties for the memory type to request
        * @param (Optional) memTypeFound Pointer to a bool that is set to true if a matching memory type has been found
        * 
        * @return Index of the requested memory type
        *
        * @throw Throws an exception if memTypeFound is null and no memory type could be found that supports the requested properties
        */
        public uint getMemoryType(uint typeBits, VkMemoryPropertyFlagBits properties, uint* memTypeFound = null) {
            for (uint i = 0; i < MemoryProperties.memoryTypeCount; i++) {
                if ((typeBits & 1) == 1) {
                    if ((MemoryProperties.GetMemoryType(i).propertyFlags & properties) == properties) {
                        if (memTypeFound != null) {
                            *memTypeFound = True;
                        }
                        return i;
                    }
                }
                typeBits >>= 1;
            }

            if (memTypeFound != null) {
                *memTypeFound = False;
                return 0;
            }
            else {
                throw new InvalidOperationException("Could not find a matching memory type");
            }
        }

        public struct QueueFamilyIndices {
            public uint Graphics;
            public uint Compute;
            public uint Transfer;
        }
    }
}
