using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using static Vulkan.vkAPI;
using System.Numerics;
using VkDeviceSize = System.UInt64;
using static Demo01.Texture.VulkanNative;
using System.Diagnostics;

namespace Demo01.Texture {
    /// <summary>
    /// Encapsulates access to a Vulkan buffer backed up by device memory.
    /// <para>To be filled by an external source like the VulkanDevice.</para>
    /// </summary>
    public unsafe class vksBuffer {

        public VkBuffer buffer;
        public VkDevice device;
        public VkDeviceMemory memory;
        public VkDescriptorBufferInfo descriptor;
        public VkDeviceSize size = 0;
        public VkDeviceSize alignment = 0;
        public IntPtr mapped = IntPtr.Zero;

        /// <summary>
        /// Usage flags to be filled by external source at buffer creation (to query at some later point).
        /// </summary>
        public VkBufferUsageFlagBits usageFlags;

        /// <summary>
        /// Memory propertys flags to be filled by external source at buffer creation (to query at some later point).
        /// </summary>
        public VkMemoryPropertyFlagBits memoryPropertyFlags;

        /// <summary>
        /// Map a memory range of this buffer. If successful, mapped points to the specified buffer range.
        /// </summary>
        /// <param name="size"> (Optional) Size of the memory range to map. Pass WholeSize to map the complete buffer range.</param>
        /// <param name="offset">(Optional) Byte offset from beginning.</param>
        /// <returns>VkResult of the buffer mapping call.</returns>
        public VkResult map(VkDeviceSize size = WholeSize, VkDeviceSize offset = 0) {
            IntPtr mappedLocal;
            var result = vkMapMemory(device, memory, offset, size, 0, &mappedLocal);
            mapped = mappedLocal;
            return result;
        }

        /// <summary>
        /// Unmap a mapped memory range.
        /// </summary>
        public void unmap() {
            if (mapped != IntPtr.Zero) {
                vkUnmapMemory(device, memory);
                mapped = IntPtr.Zero;
            }
        }

        /// <summary>
        /// Attach the allocated memory block to the buffer.
        /// </summary>
        /// <param name="offset">(Optional) Byte offset (from the beginning) for the memory region to bind.</param>
        /// <returns>VkResult of the bindBufferMemory call</returns>
        public VkResult bind(VkDeviceSize offset = 0) {
            return vkBindBufferMemory(device, buffer, memory, offset);
        }

        /// <summary>
        /// Setup the default descriptor for this buffer.
        /// </summary>
        /// <param name="size">(Optional) Size of the memory range of the descriptor.</param>
        /// <param name="offset">(Optional) Byte offset from beginning.</param>
        public void setupDescriptor(VkDeviceSize size = WholeSize, VkDeviceSize offset = 0) {
            descriptor.offset = offset;
            descriptor.buffer = buffer;
            descriptor.range = size;
        }

        /// <summary>
        /// Copies the specified data to the mapped buffer.
        /// </summary>
        /// <param name="data">Pointer to the data to copy.</param>
        /// <param name="size">Size of the data to copy in machine units.</param>
        public void copyTo(void* data, VkDeviceSize size) {
            Debug.Assert(mapped != null);
            Debug.Assert(size <= uint.MaxValue);
            Unsafe.CopyBlock(mapped, data, (uint)size);
        }

        /// <summary>
        /// Flush a memory range of the buffer to make it visible to the device.
        /// </summary>
        /// <param name="size">(Optional) Size of the memory range to flush. Pass WholeSize to flush the complete buffer range.</param>
        /// <param name="offset">(Optional) Byte offset from beginning.</param>
        /// <returns>VkResult of the flush call.</returns>
        public VkResult flush(VkDeviceSize size = WholeSize, VkDeviceSize offset = 0) {
            VkMappedMemoryRange mappedRange = new VkMappedMemoryRange();
            mappedRange.sType = MappedMemoryRange;
            mappedRange.memory = memory;
            mappedRange.offset = offset;
            mappedRange.size = size;
            return vkFlushMappedMemoryRanges(device, 1, &mappedRange);
        }

        /// <summary>
        /// Invalidate a memory range of the buffer to make it visible to the host.
        /// </summary>
        /// <param name="size">(Optional) Size of the memory range to invalidate. Pass WholeSize to invalidate the complete buffer range.</param>
        /// <param name="offset">(Optional) Byte offset from beginning.</param>
        /// <returns>VkResult of the invalidate call</returns>
        public VkResult invalidate(VkDeviceSize size = WholeSize, VkDeviceSize offset = 0) {
            VkMappedMemoryRange mappedRange = new VkMappedMemoryRange();
            mappedRange.sType = MappedMemoryRange;
            mappedRange.memory = memory;
            mappedRange.offset = offset;
            mappedRange.size = size;
            return vkInvalidateMappedMemoryRanges(device, 1, &mappedRange);
        }

        /// <summary>
        /// Release all Vulkan resources held by this buffer.
        /// </summary>
        public void destroy() {
            if (buffer.handle != 0) {
                vkDestroyBuffer(device, buffer, null);
                buffer.handle = 0;
            }
            if (memory.handle != 0) {
                vkFreeMemory(device, memory, null);
                memory.handle = 0;
            }
        }

    }
}
