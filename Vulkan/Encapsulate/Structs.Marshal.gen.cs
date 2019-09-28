using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe static partial class Vk {
        private const int maxStructSize = 1024;
        internal static readonly byte[] zeros = new byte[maxStructSize];
    }
    // Struct: 0
    public unsafe partial struct VkAccelerationStructureCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkAccelerationStructureCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAccelerationStructureCreateInfoNV"/>.</returns>
        public static VkAccelerationStructureCreateInfoNV* Alloc() {
            int size = sizeof(VkAccelerationStructureCreateInfoNV);
            var info = (VkAccelerationStructureCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AccelerationStructureCreateInfoNv;

            return info;
        }
    }

    // Struct: 1
    public unsafe partial struct VkAccelerationStructureInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkAccelerationStructureInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAccelerationStructureInfoNV"/>.</returns>
        public static VkAccelerationStructureInfoNV* Alloc() {
            int size = sizeof(VkAccelerationStructureInfoNV);
            var info = (VkAccelerationStructureInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AccelerationStructureInfoNv;

            return info;
        }
    }

    // Struct: 2
    public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkAccelerationStructureMemoryRequirementsInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAccelerationStructureMemoryRequirementsInfoNV"/>.</returns>
        public static VkAccelerationStructureMemoryRequirementsInfoNV* Alloc() {
            int size = sizeof(VkAccelerationStructureMemoryRequirementsInfoNV);
            var info = (VkAccelerationStructureMemoryRequirementsInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AccelerationStructureMemoryRequirementsInfoNv;

            return info;
        }
    }

    // Struct: 3
    public unsafe partial struct VkAcquireNextImageInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkAcquireNextImageInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAcquireNextImageInfoKHR"/>.</returns>
        public static VkAcquireNextImageInfoKHR* Alloc() {
            int size = sizeof(VkAcquireNextImageInfoKHR);
            var info = (VkAcquireNextImageInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AcquireNextImageInfoKHR;

            return info;
        }
    }

    // Struct: 4
    public unsafe partial struct VkAllocationCallbacks {
        /// <summary>
        /// Allocate an instance of <see cref="VkAllocationCallbacks"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAllocationCallbacks"/>.</returns>
        public static VkAllocationCallbacks* Alloc() {
            int size = sizeof(VkAllocationCallbacks);
            var info = (VkAllocationCallbacks*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 5
    public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID {
        /// <summary>
        /// Allocate an instance of <see cref="VkAndroidHardwareBufferFormatPropertiesANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAndroidHardwareBufferFormatPropertiesANDROID"/>.</returns>
        public static VkAndroidHardwareBufferFormatPropertiesANDROID* Alloc() {
            int size = sizeof(VkAndroidHardwareBufferFormatPropertiesANDROID);
            var info = (VkAndroidHardwareBufferFormatPropertiesANDROID*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AndroidHardwareBufferFormatPropertiesAndroid;

            return info;
        }
    }

    // Struct: 6
    public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID {
        /// <summary>
        /// Allocate an instance of <see cref="VkAndroidHardwareBufferPropertiesANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAndroidHardwareBufferPropertiesANDROID"/>.</returns>
        public static VkAndroidHardwareBufferPropertiesANDROID* Alloc() {
            int size = sizeof(VkAndroidHardwareBufferPropertiesANDROID);
            var info = (VkAndroidHardwareBufferPropertiesANDROID*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AndroidHardwareBufferPropertiesAndroid;

            return info;
        }
    }

    // Struct: 7
    public unsafe partial struct VkAndroidHardwareBufferUsageANDROID {
        /// <summary>
        /// Allocate an instance of <see cref="VkAndroidHardwareBufferUsageANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAndroidHardwareBufferUsageANDROID"/>.</returns>
        public static VkAndroidHardwareBufferUsageANDROID* Alloc() {
            int size = sizeof(VkAndroidHardwareBufferUsageANDROID);
            var info = (VkAndroidHardwareBufferUsageANDROID*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AndroidHardwareBufferUsageAndroid;

            return info;
        }
    }

    // Struct: 8
    public unsafe partial struct VkAndroidSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkAndroidSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAndroidSurfaceCreateInfoKHR"/>.</returns>
        public static VkAndroidSurfaceCreateInfoKHR* Alloc() {
            int size = sizeof(VkAndroidSurfaceCreateInfoKHR);
            var info = (VkAndroidSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AndroidSurfaceCreateInfoKHR;

            return info;
        }
    }

    // Struct: 9
    public unsafe partial struct VkApplicationInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkApplicationInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkApplicationInfo"/>.</returns>
        public static VkApplicationInfo* Alloc() {
            int size = sizeof(VkApplicationInfo);
            var info = (VkApplicationInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ApplicationInfo;

            return info;
        }
    }

    // Struct: 10
    public unsafe partial struct VkAttachmentDescription {
        /// <summary>
        /// Allocate an instance of <see cref="VkAttachmentDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAttachmentDescription"/>.</returns>
        public static VkAttachmentDescription* Alloc() {
            int size = sizeof(VkAttachmentDescription);
            var info = (VkAttachmentDescription*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 11
    public unsafe partial struct VkAttachmentDescription2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkAttachmentDescription2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAttachmentDescription2KHR"/>.</returns>
        public static VkAttachmentDescription2KHR* Alloc() {
            int size = sizeof(VkAttachmentDescription2KHR);
            var info = (VkAttachmentDescription2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AttachmentDescription2KHR;

            return info;
        }
    }

    // Struct: 12
    public unsafe partial struct VkAttachmentReference {
        /// <summary>
        /// Allocate an instance of <see cref="VkAttachmentReference"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAttachmentReference"/>.</returns>
        public static VkAttachmentReference* Alloc() {
            int size = sizeof(VkAttachmentReference);
            var info = (VkAttachmentReference*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 13
    public unsafe partial struct VkAttachmentReference2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkAttachmentReference2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAttachmentReference2KHR"/>.</returns>
        public static VkAttachmentReference2KHR* Alloc() {
            int size = sizeof(VkAttachmentReference2KHR);
            var info = (VkAttachmentReference2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.AttachmentReference2KHR;

            return info;
        }
    }

    // Struct: 14
    public unsafe partial struct VkAttachmentSampleLocationsEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkAttachmentSampleLocationsEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkAttachmentSampleLocationsEXT"/>.</returns>
        public static VkAttachmentSampleLocationsEXT* Alloc() {
            int size = sizeof(VkAttachmentSampleLocationsEXT);
            var info = (VkAttachmentSampleLocationsEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 15
    public unsafe partial struct VkBaseInStructure {
        /// <summary>
        /// Allocate an instance of <see cref="VkBaseInStructure"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBaseInStructure"/>.</returns>
        public static VkBaseInStructure* Alloc() {
            int size = sizeof(VkBaseInStructure);
            var info = (VkBaseInStructure*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = 0;

            return info;
        }
    }

    // Struct: 16
    public unsafe partial struct VkBaseOutStructure {
        /// <summary>
        /// Allocate an instance of <see cref="VkBaseOutStructure"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBaseOutStructure"/>.</returns>
        public static VkBaseOutStructure* Alloc() {
            int size = sizeof(VkBaseOutStructure);
            var info = (VkBaseOutStructure*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = 0;

            return info;
        }
    }

    // Struct: 17
    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindAccelerationStructureMemoryInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindAccelerationStructureMemoryInfoNV"/>.</returns>
        public static VkBindAccelerationStructureMemoryInfoNV* Alloc() {
            int size = sizeof(VkBindAccelerationStructureMemoryInfoNV);
            var info = (VkBindAccelerationStructureMemoryInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindAccelerationStructureMemoryInfoNv;

            return info;
        }
    }

    // Struct: 18
    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindBufferMemoryDeviceGroupInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindBufferMemoryDeviceGroupInfo"/>.</returns>
        public static VkBindBufferMemoryDeviceGroupInfo* Alloc() {
            int size = sizeof(VkBindBufferMemoryDeviceGroupInfo);
            var info = (VkBindBufferMemoryDeviceGroupInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindBufferMemoryDeviceGroupInfo;

            return info;
        }
    }

    // Struct: 19
    public unsafe partial struct VkBindBufferMemoryInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindBufferMemoryInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindBufferMemoryInfo"/>.</returns>
        public static VkBindBufferMemoryInfo* Alloc() {
            int size = sizeof(VkBindBufferMemoryInfo);
            var info = (VkBindBufferMemoryInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindBufferMemoryInfo;

            return info;
        }
    }

    // Struct: 20
    public unsafe partial struct VkBindImageMemoryDeviceGroupInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindImageMemoryDeviceGroupInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindImageMemoryDeviceGroupInfo"/>.</returns>
        public static VkBindImageMemoryDeviceGroupInfo* Alloc() {
            int size = sizeof(VkBindImageMemoryDeviceGroupInfo);
            var info = (VkBindImageMemoryDeviceGroupInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindImageMemoryDeviceGroupInfo;

            return info;
        }
    }

    // Struct: 21
    public unsafe partial struct VkBindImageMemoryInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindImageMemoryInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindImageMemoryInfo"/>.</returns>
        public static VkBindImageMemoryInfo* Alloc() {
            int size = sizeof(VkBindImageMemoryInfo);
            var info = (VkBindImageMemoryInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindImageMemoryInfo;

            return info;
        }
    }

    // Struct: 22
    public unsafe partial struct VkBindImageMemorySwapchainInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindImageMemorySwapchainInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindImageMemorySwapchainInfoKHR"/>.</returns>
        public static VkBindImageMemorySwapchainInfoKHR* Alloc() {
            int size = sizeof(VkBindImageMemorySwapchainInfoKHR);
            var info = (VkBindImageMemorySwapchainInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindImageMemorySwapchainInfoKHR;

            return info;
        }
    }

    // Struct: 23
    public unsafe partial struct VkBindImagePlaneMemoryInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindImagePlaneMemoryInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindImagePlaneMemoryInfo"/>.</returns>
        public static VkBindImagePlaneMemoryInfo* Alloc() {
            int size = sizeof(VkBindImagePlaneMemoryInfo);
            var info = (VkBindImagePlaneMemoryInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindImagePlaneMemoryInfo;

            return info;
        }
    }

    // Struct: 24
    public unsafe partial struct VkBindSparseInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBindSparseInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBindSparseInfo"/>.</returns>
        public static VkBindSparseInfo* Alloc() {
            int size = sizeof(VkBindSparseInfo);
            var info = (VkBindSparseInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BindSparseInfo;

            return info;
        }
    }

    // Struct: 25
    public unsafe partial struct VkBufferCopy {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferCopy"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferCopy"/>.</returns>
        public static VkBufferCopy* Alloc() {
            int size = sizeof(VkBufferCopy);
            var info = (VkBufferCopy*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 26
    public unsafe partial struct VkBufferCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferCreateInfo"/>.</returns>
        public static VkBufferCreateInfo* Alloc() {
            int size = sizeof(VkBufferCreateInfo);
            var info = (VkBufferCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BufferCreateInfo;

            return info;
        }
    }

    // Struct: 27
    public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferDeviceAddressCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferDeviceAddressCreateInfoEXT"/>.</returns>
        public static VkBufferDeviceAddressCreateInfoEXT* Alloc() {
            int size = sizeof(VkBufferDeviceAddressCreateInfoEXT);
            var info = (VkBufferDeviceAddressCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BufferDeviceAddressCreateInfoExt;

            return info;
        }
    }

    // Struct: 28
    public unsafe partial struct VkBufferDeviceAddressInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferDeviceAddressInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferDeviceAddressInfoEXT"/>.</returns>
        public static VkBufferDeviceAddressInfoEXT* Alloc() {
            int size = sizeof(VkBufferDeviceAddressInfoEXT);
            var info = (VkBufferDeviceAddressInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BufferDeviceAddressInfoExt;

            return info;
        }
    }

    // Struct: 29
    public unsafe partial struct VkBufferImageCopy {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferImageCopy"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferImageCopy"/>.</returns>
        public static VkBufferImageCopy* Alloc() {
            int size = sizeof(VkBufferImageCopy);
            var info = (VkBufferImageCopy*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 30
    public unsafe partial struct VkBufferMemoryBarrier {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferMemoryBarrier"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferMemoryBarrier"/>.</returns>
        public static VkBufferMemoryBarrier* Alloc() {
            int size = sizeof(VkBufferMemoryBarrier);
            var info = (VkBufferMemoryBarrier*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BufferMemoryBarrier;

            return info;
        }
    }

    // Struct: 31
    public unsafe partial struct VkBufferMemoryRequirementsInfo2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferMemoryRequirementsInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferMemoryRequirementsInfo2"/>.</returns>
        public static VkBufferMemoryRequirementsInfo2* Alloc() {
            int size = sizeof(VkBufferMemoryRequirementsInfo2);
            var info = (VkBufferMemoryRequirementsInfo2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BufferMemoryRequirementsInfo2;

            return info;
        }
    }

    // Struct: 32
    public unsafe partial struct VkBufferViewCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkBufferViewCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkBufferViewCreateInfo"/>.</returns>
        public static VkBufferViewCreateInfo* Alloc() {
            int size = sizeof(VkBufferViewCreateInfo);
            var info = (VkBufferViewCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.BufferViewCreateInfo;

            return info;
        }
    }

    // Struct: 33
    public unsafe partial struct VkCalibratedTimestampInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkCalibratedTimestampInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCalibratedTimestampInfoEXT"/>.</returns>
        public static VkCalibratedTimestampInfoEXT* Alloc() {
            int size = sizeof(VkCalibratedTimestampInfoEXT);
            var info = (VkCalibratedTimestampInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CalibratedTimestampInfoExt;

            return info;
        }
    }

    // Struct: 34
    public unsafe partial struct VkCheckpointDataNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkCheckpointDataNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCheckpointDataNV"/>.</returns>
        public static VkCheckpointDataNV* Alloc() {
            int size = sizeof(VkCheckpointDataNV);
            var info = (VkCheckpointDataNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CheckpointDataNv;

            return info;
        }
    }

    // Struct: 35
    public unsafe partial struct VkClearAttachment {
        /// <summary>
        /// Allocate an instance of <see cref="VkClearAttachment"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkClearAttachment"/>.</returns>
        public static VkClearAttachment* Alloc() {
            int size = sizeof(VkClearAttachment);
            var info = (VkClearAttachment*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 36
    public unsafe partial struct VkClearColorValue {
        /// <summary>
        /// Allocate an instance of <see cref="VkClearColorValue"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkClearColorValue"/>.</returns>
        public static VkClearColorValue* Alloc() {
            int size = sizeof(VkClearColorValue);
            var info = (VkClearColorValue*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 37
    public unsafe partial struct VkClearDepthStencilValue {
        /// <summary>
        /// Allocate an instance of <see cref="VkClearDepthStencilValue"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkClearDepthStencilValue"/>.</returns>
        public static VkClearDepthStencilValue* Alloc() {
            int size = sizeof(VkClearDepthStencilValue);
            var info = (VkClearDepthStencilValue*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 38
    public unsafe partial struct VkClearRect {
        /// <summary>
        /// Allocate an instance of <see cref="VkClearRect"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkClearRect"/>.</returns>
        public static VkClearRect* Alloc() {
            int size = sizeof(VkClearRect);
            var info = (VkClearRect*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 39
    public unsafe partial struct VkClearValue {
        /// <summary>
        /// Allocate an instance of <see cref="VkClearValue"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkClearValue"/>.</returns>
        public static VkClearValue* Alloc() {
            int size = sizeof(VkClearValue);
            var info = (VkClearValue*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 40
    public unsafe partial struct VkCmdProcessCommandsInfoNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkCmdProcessCommandsInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCmdProcessCommandsInfoNVX"/>.</returns>
        public static VkCmdProcessCommandsInfoNVX* Alloc() {
            int size = sizeof(VkCmdProcessCommandsInfoNVX);
            var info = (VkCmdProcessCommandsInfoNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CmdProcessCommandsInfoNvx;

            return info;
        }
    }

    // Struct: 41
    public unsafe partial struct VkCmdReserveSpaceForCommandsInfoNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkCmdReserveSpaceForCommandsInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCmdReserveSpaceForCommandsInfoNVX"/>.</returns>
        public static VkCmdReserveSpaceForCommandsInfoNVX* Alloc() {
            int size = sizeof(VkCmdReserveSpaceForCommandsInfoNVX);
            var info = (VkCmdReserveSpaceForCommandsInfoNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CmdReserveSpaceForCommandsInfoNvx;

            return info;
        }
    }

    // Struct: 42
    public unsafe partial struct VkCoarseSampleLocationNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkCoarseSampleLocationNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCoarseSampleLocationNV"/>.</returns>
        public static VkCoarseSampleLocationNV* Alloc() {
            int size = sizeof(VkCoarseSampleLocationNV);
            var info = (VkCoarseSampleLocationNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 43
    public unsafe partial struct VkCoarseSampleOrderCustomNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkCoarseSampleOrderCustomNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCoarseSampleOrderCustomNV"/>.</returns>
        public static VkCoarseSampleOrderCustomNV* Alloc() {
            int size = sizeof(VkCoarseSampleOrderCustomNV);
            var info = (VkCoarseSampleOrderCustomNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 44
    public unsafe partial struct VkCommandBufferAllocateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkCommandBufferAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCommandBufferAllocateInfo"/>.</returns>
        public static VkCommandBufferAllocateInfo* Alloc() {
            int size = sizeof(VkCommandBufferAllocateInfo);
            var info = (VkCommandBufferAllocateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CommandBufferAllocateInfo;

            return info;
        }
    }

    // Struct: 45
    public unsafe partial struct VkCommandBufferBeginInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkCommandBufferBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCommandBufferBeginInfo"/>.</returns>
        public static VkCommandBufferBeginInfo* Alloc() {
            int size = sizeof(VkCommandBufferBeginInfo);
            var info = (VkCommandBufferBeginInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CommandBufferBeginInfo;

            return info;
        }
    }

    // Struct: 46
    public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkCommandBufferInheritanceConditionalRenderingInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCommandBufferInheritanceConditionalRenderingInfoEXT"/>.</returns>
        public static VkCommandBufferInheritanceConditionalRenderingInfoEXT* Alloc() {
            int size = sizeof(VkCommandBufferInheritanceConditionalRenderingInfoEXT);
            var info = (VkCommandBufferInheritanceConditionalRenderingInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoExt;

            return info;
        }
    }

    // Struct: 47
    public unsafe partial struct VkCommandBufferInheritanceInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkCommandBufferInheritanceInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCommandBufferInheritanceInfo"/>.</returns>
        public static VkCommandBufferInheritanceInfo* Alloc() {
            int size = sizeof(VkCommandBufferInheritanceInfo);
            var info = (VkCommandBufferInheritanceInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CommandBufferInheritanceInfo;

            return info;
        }
    }

    // Struct: 48
    public unsafe partial struct VkCommandPoolCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkCommandPoolCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCommandPoolCreateInfo"/>.</returns>
        public static VkCommandPoolCreateInfo* Alloc() {
            int size = sizeof(VkCommandPoolCreateInfo);
            var info = (VkCommandPoolCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CommandPoolCreateInfo;

            return info;
        }
    }

    // Struct: 49
    public unsafe partial struct VkComponentMapping {
        /// <summary>
        /// Allocate an instance of <see cref="VkComponentMapping"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkComponentMapping"/>.</returns>
        public static VkComponentMapping* Alloc() {
            int size = sizeof(VkComponentMapping);
            var info = (VkComponentMapping*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 50
    public unsafe partial struct VkComputePipelineCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkComputePipelineCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkComputePipelineCreateInfo"/>.</returns>
        public static VkComputePipelineCreateInfo* Alloc() {
            int size = sizeof(VkComputePipelineCreateInfo);
            var info = (VkComputePipelineCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ComputePipelineCreateInfo;

            return info;
        }
    }

    // Struct: 51
    public unsafe partial struct VkConditionalRenderingBeginInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkConditionalRenderingBeginInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkConditionalRenderingBeginInfoEXT"/>.</returns>
        public static VkConditionalRenderingBeginInfoEXT* Alloc() {
            int size = sizeof(VkConditionalRenderingBeginInfoEXT);
            var info = (VkConditionalRenderingBeginInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ConditionalRenderingBeginInfoExt;

            return info;
        }
    }

    // Struct: 52
    public unsafe partial struct VkConformanceVersionKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkConformanceVersionKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkConformanceVersionKHR"/>.</returns>
        public static VkConformanceVersionKHR* Alloc() {
            int size = sizeof(VkConformanceVersionKHR);
            var info = (VkConformanceVersionKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 53
    public unsafe partial struct VkCooperativeMatrixPropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkCooperativeMatrixPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCooperativeMatrixPropertiesNV"/>.</returns>
        public static VkCooperativeMatrixPropertiesNV* Alloc() {
            int size = sizeof(VkCooperativeMatrixPropertiesNV);
            var info = (VkCooperativeMatrixPropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CooperativeMatrixPropertiesNv;

            return info;
        }
    }

    // Struct: 54
    public unsafe partial struct VkCopyDescriptorSet {
        /// <summary>
        /// Allocate an instance of <see cref="VkCopyDescriptorSet"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkCopyDescriptorSet"/>.</returns>
        public static VkCopyDescriptorSet* Alloc() {
            int size = sizeof(VkCopyDescriptorSet);
            var info = (VkCopyDescriptorSet*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.CopyDescriptorSet;

            return info;
        }
    }

    // Struct: 55
    public unsafe partial struct VkD3D12FenceSubmitInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkD3D12FenceSubmitInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkD3D12FenceSubmitInfoKHR"/>.</returns>
        public static VkD3D12FenceSubmitInfoKHR* Alloc() {
            int size = sizeof(VkD3D12FenceSubmitInfoKHR);
            var info = (VkD3D12FenceSubmitInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.D3d12FenceSubmitInfoKHR;

            return info;
        }
    }

    // Struct: 56
    public unsafe partial struct VkDebugMarkerMarkerInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugMarkerMarkerInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugMarkerMarkerInfoEXT"/>.</returns>
        public static VkDebugMarkerMarkerInfoEXT* Alloc() {
            int size = sizeof(VkDebugMarkerMarkerInfoEXT);
            var info = (VkDebugMarkerMarkerInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugMarkerMarkerInfoExt;

            return info;
        }
    }

    // Struct: 57
    public unsafe partial struct VkDebugMarkerObjectNameInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugMarkerObjectNameInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugMarkerObjectNameInfoEXT"/>.</returns>
        public static VkDebugMarkerObjectNameInfoEXT* Alloc() {
            int size = sizeof(VkDebugMarkerObjectNameInfoEXT);
            var info = (VkDebugMarkerObjectNameInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugMarkerObjectNameInfoExt;

            return info;
        }
    }

    // Struct: 58
    public unsafe partial struct VkDebugMarkerObjectTagInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugMarkerObjectTagInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugMarkerObjectTagInfoEXT"/>.</returns>
        public static VkDebugMarkerObjectTagInfoEXT* Alloc() {
            int size = sizeof(VkDebugMarkerObjectTagInfoEXT);
            var info = (VkDebugMarkerObjectTagInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugMarkerObjectTagInfoExt;

            return info;
        }
    }

    // Struct: 59
    public unsafe partial struct VkDebugReportCallbackCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugReportCallbackCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugReportCallbackCreateInfoEXT"/>.</returns>
        public static VkDebugReportCallbackCreateInfoEXT* Alloc() {
            int size = sizeof(VkDebugReportCallbackCreateInfoEXT);
            var info = (VkDebugReportCallbackCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugReportCallbackCreateInfoExt;

            return info;
        }
    }

    // Struct: 60
    public unsafe partial struct VkDebugUtilsLabelEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugUtilsLabelEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugUtilsLabelEXT"/>.</returns>
        public static VkDebugUtilsLabelEXT* Alloc() {
            int size = sizeof(VkDebugUtilsLabelEXT);
            var info = (VkDebugUtilsLabelEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugUtilsLabelExt;

            return info;
        }
    }

    // Struct: 61
    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugUtilsMessengerCallbackDataEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugUtilsMessengerCallbackDataEXT"/>.</returns>
        public static VkDebugUtilsMessengerCallbackDataEXT* Alloc() {
            int size = sizeof(VkDebugUtilsMessengerCallbackDataEXT);
            var info = (VkDebugUtilsMessengerCallbackDataEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugUtilsMessengerCallbackDataExt;

            return info;
        }
    }

    // Struct: 62
    public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugUtilsMessengerCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugUtilsMessengerCreateInfoEXT"/>.</returns>
        public static VkDebugUtilsMessengerCreateInfoEXT* Alloc() {
            int size = sizeof(VkDebugUtilsMessengerCreateInfoEXT);
            var info = (VkDebugUtilsMessengerCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugUtilsMessengerCreateInfoExt;

            return info;
        }
    }

    // Struct: 63
    public unsafe partial struct VkDebugUtilsObjectNameInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugUtilsObjectNameInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugUtilsObjectNameInfoEXT"/>.</returns>
        public static VkDebugUtilsObjectNameInfoEXT* Alloc() {
            int size = sizeof(VkDebugUtilsObjectNameInfoEXT);
            var info = (VkDebugUtilsObjectNameInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugUtilsObjectNameInfoExt;

            return info;
        }
    }

    // Struct: 64
    public unsafe partial struct VkDebugUtilsObjectTagInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDebugUtilsObjectTagInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDebugUtilsObjectTagInfoEXT"/>.</returns>
        public static VkDebugUtilsObjectTagInfoEXT* Alloc() {
            int size = sizeof(VkDebugUtilsObjectTagInfoEXT);
            var info = (VkDebugUtilsObjectTagInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DebugUtilsObjectTagInfoExt;

            return info;
        }
    }

    // Struct: 65
    public unsafe partial struct VkDedicatedAllocationBufferCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkDedicatedAllocationBufferCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDedicatedAllocationBufferCreateInfoNV"/>.</returns>
        public static VkDedicatedAllocationBufferCreateInfoNV* Alloc() {
            int size = sizeof(VkDedicatedAllocationBufferCreateInfoNV);
            var info = (VkDedicatedAllocationBufferCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DedicatedAllocationBufferCreateInfoNv;

            return info;
        }
    }

    // Struct: 66
    public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkDedicatedAllocationImageCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDedicatedAllocationImageCreateInfoNV"/>.</returns>
        public static VkDedicatedAllocationImageCreateInfoNV* Alloc() {
            int size = sizeof(VkDedicatedAllocationImageCreateInfoNV);
            var info = (VkDedicatedAllocationImageCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DedicatedAllocationImageCreateInfoNv;

            return info;
        }
    }

    // Struct: 67
    public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkDedicatedAllocationMemoryAllocateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDedicatedAllocationMemoryAllocateInfoNV"/>.</returns>
        public static VkDedicatedAllocationMemoryAllocateInfoNV* Alloc() {
            int size = sizeof(VkDedicatedAllocationMemoryAllocateInfoNV);
            var info = (VkDedicatedAllocationMemoryAllocateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DedicatedAllocationMemoryAllocateInfoNv;

            return info;
        }
    }

    // Struct: 68
    public unsafe partial struct VkDescriptorBufferInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorBufferInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorBufferInfo"/>.</returns>
        public static VkDescriptorBufferInfo* Alloc() {
            int size = sizeof(VkDescriptorBufferInfo);
            var info = (VkDescriptorBufferInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 69
    public unsafe partial struct VkDescriptorImageInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorImageInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorImageInfo"/>.</returns>
        public static VkDescriptorImageInfo* Alloc() {
            int size = sizeof(VkDescriptorImageInfo);
            var info = (VkDescriptorImageInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 70
    public unsafe partial struct VkDescriptorPoolCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorPoolCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorPoolCreateInfo"/>.</returns>
        public static VkDescriptorPoolCreateInfo* Alloc() {
            int size = sizeof(VkDescriptorPoolCreateInfo);
            var info = (VkDescriptorPoolCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorPoolCreateInfo;

            return info;
        }
    }

    // Struct: 71
    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorPoolInlineUniformBlockCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorPoolInlineUniformBlockCreateInfoEXT"/>.</returns>
        public static VkDescriptorPoolInlineUniformBlockCreateInfoEXT* Alloc() {
            int size = sizeof(VkDescriptorPoolInlineUniformBlockCreateInfoEXT);
            var info = (VkDescriptorPoolInlineUniformBlockCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfoExt;

            return info;
        }
    }

    // Struct: 72
    public unsafe partial struct VkDescriptorPoolSize {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorPoolSize"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorPoolSize"/>.</returns>
        public static VkDescriptorPoolSize* Alloc() {
            int size = sizeof(VkDescriptorPoolSize);
            var info = (VkDescriptorPoolSize*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 73
    public unsafe partial struct VkDescriptorSetAllocateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetAllocateInfo"/>.</returns>
        public static VkDescriptorSetAllocateInfo* Alloc() {
            int size = sizeof(VkDescriptorSetAllocateInfo);
            var info = (VkDescriptorSetAllocateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorSetAllocateInfo;

            return info;
        }
    }

    // Struct: 74
    public unsafe partial struct VkDescriptorSetLayoutBinding {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetLayoutBinding"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetLayoutBinding"/>.</returns>
        public static VkDescriptorSetLayoutBinding* Alloc() {
            int size = sizeof(VkDescriptorSetLayoutBinding);
            var info = (VkDescriptorSetLayoutBinding*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 75
    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetLayoutBindingFlagsCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetLayoutBindingFlagsCreateInfoEXT"/>.</returns>
        public static VkDescriptorSetLayoutBindingFlagsCreateInfoEXT* Alloc() {
            int size = sizeof(VkDescriptorSetLayoutBindingFlagsCreateInfoEXT);
            var info = (VkDescriptorSetLayoutBindingFlagsCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorSetLayoutBindingFlagsCreateInfoExt;

            return info;
        }
    }

    // Struct: 76
    public unsafe partial struct VkDescriptorSetLayoutCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetLayoutCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetLayoutCreateInfo"/>.</returns>
        public static VkDescriptorSetLayoutCreateInfo* Alloc() {
            int size = sizeof(VkDescriptorSetLayoutCreateInfo);
            var info = (VkDescriptorSetLayoutCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorSetLayoutCreateInfo;

            return info;
        }
    }

    // Struct: 77
    public unsafe partial struct VkDescriptorSetLayoutSupport {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetLayoutSupport"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetLayoutSupport"/>.</returns>
        public static VkDescriptorSetLayoutSupport* Alloc() {
            int size = sizeof(VkDescriptorSetLayoutSupport);
            var info = (VkDescriptorSetLayoutSupport*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorSetLayoutSupport;

            return info;
        }
    }

    // Struct: 78
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetVariableDescriptorCountAllocateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetVariableDescriptorCountAllocateInfoEXT"/>.</returns>
        public static VkDescriptorSetVariableDescriptorCountAllocateInfoEXT* Alloc() {
            int size = sizeof(VkDescriptorSetVariableDescriptorCountAllocateInfoEXT);
            var info = (VkDescriptorSetVariableDescriptorCountAllocateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfoExt;

            return info;
        }
    }

    // Struct: 79
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorSetVariableDescriptorCountLayoutSupportEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorSetVariableDescriptorCountLayoutSupportEXT"/>.</returns>
        public static VkDescriptorSetVariableDescriptorCountLayoutSupportEXT* Alloc() {
            int size = sizeof(VkDescriptorSetVariableDescriptorCountLayoutSupportEXT);
            var info = (VkDescriptorSetVariableDescriptorCountLayoutSupportEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupportExt;

            return info;
        }
    }

    // Struct: 80
    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorUpdateTemplateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorUpdateTemplateCreateInfo"/>.</returns>
        public static VkDescriptorUpdateTemplateCreateInfo* Alloc() {
            int size = sizeof(VkDescriptorUpdateTemplateCreateInfo);
            var info = (VkDescriptorUpdateTemplateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DescriptorUpdateTemplateCreateInfo;

            return info;
        }
    }

    // Struct: 81
    public unsafe partial struct VkDescriptorUpdateTemplateEntry {
        /// <summary>
        /// Allocate an instance of <see cref="VkDescriptorUpdateTemplateEntry"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDescriptorUpdateTemplateEntry"/>.</returns>
        public static VkDescriptorUpdateTemplateEntry* Alloc() {
            int size = sizeof(VkDescriptorUpdateTemplateEntry);
            var info = (VkDescriptorUpdateTemplateEntry*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 82
    public unsafe partial struct VkDeviceCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceCreateInfo"/>.</returns>
        public static VkDeviceCreateInfo* Alloc() {
            int size = sizeof(VkDeviceCreateInfo);
            var info = (VkDeviceCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceCreateInfo;

            return info;
        }
    }

    // Struct: 83
    public unsafe partial struct VkDeviceEventInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceEventInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceEventInfoEXT"/>.</returns>
        public static VkDeviceEventInfoEXT* Alloc() {
            int size = sizeof(VkDeviceEventInfoEXT);
            var info = (VkDeviceEventInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceEventInfoExt;

            return info;
        }
    }

    // Struct: 84
    public unsafe partial struct VkDeviceGeneratedCommandsFeaturesNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGeneratedCommandsFeaturesNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGeneratedCommandsFeaturesNVX"/>.</returns>
        public static VkDeviceGeneratedCommandsFeaturesNVX* Alloc() {
            int size = sizeof(VkDeviceGeneratedCommandsFeaturesNVX);
            var info = (VkDeviceGeneratedCommandsFeaturesNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGeneratedCommandsFeaturesNvx;

            return info;
        }
    }

    // Struct: 85
    public unsafe partial struct VkDeviceGeneratedCommandsLimitsNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGeneratedCommandsLimitsNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGeneratedCommandsLimitsNVX"/>.</returns>
        public static VkDeviceGeneratedCommandsLimitsNVX* Alloc() {
            int size = sizeof(VkDeviceGeneratedCommandsLimitsNVX);
            var info = (VkDeviceGeneratedCommandsLimitsNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGeneratedCommandsLimitsNvx;

            return info;
        }
    }

    // Struct: 86
    public unsafe partial struct VkDeviceGroupBindSparseInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupBindSparseInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupBindSparseInfo"/>.</returns>
        public static VkDeviceGroupBindSparseInfo* Alloc() {
            int size = sizeof(VkDeviceGroupBindSparseInfo);
            var info = (VkDeviceGroupBindSparseInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupBindSparseInfo;

            return info;
        }
    }

    // Struct: 87
    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupCommandBufferBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupCommandBufferBeginInfo"/>.</returns>
        public static VkDeviceGroupCommandBufferBeginInfo* Alloc() {
            int size = sizeof(VkDeviceGroupCommandBufferBeginInfo);
            var info = (VkDeviceGroupCommandBufferBeginInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupCommandBufferBeginInfo;

            return info;
        }
    }

    // Struct: 88
    public unsafe partial struct VkDeviceGroupDeviceCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupDeviceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupDeviceCreateInfo"/>.</returns>
        public static VkDeviceGroupDeviceCreateInfo* Alloc() {
            int size = sizeof(VkDeviceGroupDeviceCreateInfo);
            var info = (VkDeviceGroupDeviceCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupDeviceCreateInfo;

            return info;
        }
    }

    // Struct: 89
    public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupPresentCapabilitiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupPresentCapabilitiesKHR"/>.</returns>
        public static VkDeviceGroupPresentCapabilitiesKHR* Alloc() {
            int size = sizeof(VkDeviceGroupPresentCapabilitiesKHR);
            var info = (VkDeviceGroupPresentCapabilitiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupPresentCapabilitiesKHR;

            return info;
        }
    }

    // Struct: 90
    public unsafe partial struct VkDeviceGroupPresentInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupPresentInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupPresentInfoKHR"/>.</returns>
        public static VkDeviceGroupPresentInfoKHR* Alloc() {
            int size = sizeof(VkDeviceGroupPresentInfoKHR);
            var info = (VkDeviceGroupPresentInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupPresentInfoKHR;

            return info;
        }
    }

    // Struct: 91
    public unsafe partial struct VkDeviceGroupRenderPassBeginInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupRenderPassBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupRenderPassBeginInfo"/>.</returns>
        public static VkDeviceGroupRenderPassBeginInfo* Alloc() {
            int size = sizeof(VkDeviceGroupRenderPassBeginInfo);
            var info = (VkDeviceGroupRenderPassBeginInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupRenderPassBeginInfo;

            return info;
        }
    }

    // Struct: 92
    public unsafe partial struct VkDeviceGroupSubmitInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupSubmitInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupSubmitInfo"/>.</returns>
        public static VkDeviceGroupSubmitInfo* Alloc() {
            int size = sizeof(VkDeviceGroupSubmitInfo);
            var info = (VkDeviceGroupSubmitInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupSubmitInfo;

            return info;
        }
    }

    // Struct: 93
    public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceGroupSwapchainCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceGroupSwapchainCreateInfoKHR"/>.</returns>
        public static VkDeviceGroupSwapchainCreateInfoKHR* Alloc() {
            int size = sizeof(VkDeviceGroupSwapchainCreateInfoKHR);
            var info = (VkDeviceGroupSwapchainCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;

            return info;
        }
    }

    // Struct: 94
    public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceMemoryOverallocationCreateInfoAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceMemoryOverallocationCreateInfoAMD"/>.</returns>
        public static VkDeviceMemoryOverallocationCreateInfoAMD* Alloc() {
            int size = sizeof(VkDeviceMemoryOverallocationCreateInfoAMD);
            var info = (VkDeviceMemoryOverallocationCreateInfoAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceMemoryOverallocationCreateInfoAmd;

            return info;
        }
    }

    // Struct: 95
    public unsafe partial struct VkDeviceQueueCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceQueueCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceQueueCreateInfo"/>.</returns>
        public static VkDeviceQueueCreateInfo* Alloc() {
            int size = sizeof(VkDeviceQueueCreateInfo);
            var info = (VkDeviceQueueCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceQueueCreateInfo;

            return info;
        }
    }

    // Struct: 96
    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceQueueGlobalPriorityCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceQueueGlobalPriorityCreateInfoEXT"/>.</returns>
        public static VkDeviceQueueGlobalPriorityCreateInfoEXT* Alloc() {
            int size = sizeof(VkDeviceQueueGlobalPriorityCreateInfoEXT);
            var info = (VkDeviceQueueGlobalPriorityCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceQueueGlobalPriorityCreateInfoExt;

            return info;
        }
    }

    // Struct: 97
    public unsafe partial struct VkDeviceQueueInfo2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkDeviceQueueInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDeviceQueueInfo2"/>.</returns>
        public static VkDeviceQueueInfo2* Alloc() {
            int size = sizeof(VkDeviceQueueInfo2);
            var info = (VkDeviceQueueInfo2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DeviceQueueInfo2;

            return info;
        }
    }

    // Struct: 98
    public unsafe partial struct VkDispatchIndirectCommand {
        /// <summary>
        /// Allocate an instance of <see cref="VkDispatchIndirectCommand"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDispatchIndirectCommand"/>.</returns>
        public static VkDispatchIndirectCommand* Alloc() {
            int size = sizeof(VkDispatchIndirectCommand);
            var info = (VkDispatchIndirectCommand*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 99
    public unsafe partial struct VkDisplayEventInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayEventInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayEventInfoEXT"/>.</returns>
        public static VkDisplayEventInfoEXT* Alloc() {
            int size = sizeof(VkDisplayEventInfoEXT);
            var info = (VkDisplayEventInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayEventInfoExt;

            return info;
        }
    }

    // Struct: 100
    public unsafe partial struct VkDisplayModeCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayModeCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayModeCreateInfoKHR"/>.</returns>
        public static VkDisplayModeCreateInfoKHR* Alloc() {
            int size = sizeof(VkDisplayModeCreateInfoKHR);
            var info = (VkDisplayModeCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayModeCreateInfoKHR;

            return info;
        }
    }

    // Struct: 101
    public unsafe partial struct VkDisplayModeParametersKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayModeParametersKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayModeParametersKHR"/>.</returns>
        public static VkDisplayModeParametersKHR* Alloc() {
            int size = sizeof(VkDisplayModeParametersKHR);
            var info = (VkDisplayModeParametersKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 102
    public unsafe partial struct VkDisplayModeProperties2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayModeProperties2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayModeProperties2KHR"/>.</returns>
        public static VkDisplayModeProperties2KHR* Alloc() {
            int size = sizeof(VkDisplayModeProperties2KHR);
            var info = (VkDisplayModeProperties2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayModeProperties2KHR;

            return info;
        }
    }

    // Struct: 103
    public unsafe partial struct VkDisplayModePropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayModePropertiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayModePropertiesKHR"/>.</returns>
        public static VkDisplayModePropertiesKHR* Alloc() {
            int size = sizeof(VkDisplayModePropertiesKHR);
            var info = (VkDisplayModePropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 104
    public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayNativeHdrSurfaceCapabilitiesAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayNativeHdrSurfaceCapabilitiesAMD"/>.</returns>
        public static VkDisplayNativeHdrSurfaceCapabilitiesAMD* Alloc() {
            int size = sizeof(VkDisplayNativeHdrSurfaceCapabilitiesAMD);
            var info = (VkDisplayNativeHdrSurfaceCapabilitiesAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAmd;

            return info;
        }
    }

    // Struct: 105
    public unsafe partial struct VkDisplayPlaneCapabilities2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPlaneCapabilities2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPlaneCapabilities2KHR"/>.</returns>
        public static VkDisplayPlaneCapabilities2KHR* Alloc() {
            int size = sizeof(VkDisplayPlaneCapabilities2KHR);
            var info = (VkDisplayPlaneCapabilities2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayPlaneCapabilities2KHR;

            return info;
        }
    }

    // Struct: 106
    public unsafe partial struct VkDisplayPlaneCapabilitiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPlaneCapabilitiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPlaneCapabilitiesKHR"/>.</returns>
        public static VkDisplayPlaneCapabilitiesKHR* Alloc() {
            int size = sizeof(VkDisplayPlaneCapabilitiesKHR);
            var info = (VkDisplayPlaneCapabilitiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 107
    public unsafe partial struct VkDisplayPlaneInfo2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPlaneInfo2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPlaneInfo2KHR"/>.</returns>
        public static VkDisplayPlaneInfo2KHR* Alloc() {
            int size = sizeof(VkDisplayPlaneInfo2KHR);
            var info = (VkDisplayPlaneInfo2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayPlaneInfo2KHR;

            return info;
        }
    }

    // Struct: 108
    public unsafe partial struct VkDisplayPlaneProperties2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPlaneProperties2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPlaneProperties2KHR"/>.</returns>
        public static VkDisplayPlaneProperties2KHR* Alloc() {
            int size = sizeof(VkDisplayPlaneProperties2KHR);
            var info = (VkDisplayPlaneProperties2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayPlaneProperties2KHR;

            return info;
        }
    }

    // Struct: 109
    public unsafe partial struct VkDisplayPlanePropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPlanePropertiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPlanePropertiesKHR"/>.</returns>
        public static VkDisplayPlanePropertiesKHR* Alloc() {
            int size = sizeof(VkDisplayPlanePropertiesKHR);
            var info = (VkDisplayPlanePropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 110
    public unsafe partial struct VkDisplayPowerInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPowerInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPowerInfoEXT"/>.</returns>
        public static VkDisplayPowerInfoEXT* Alloc() {
            int size = sizeof(VkDisplayPowerInfoEXT);
            var info = (VkDisplayPowerInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayPowerInfoExt;

            return info;
        }
    }

    // Struct: 111
    public unsafe partial struct VkDisplayPresentInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPresentInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPresentInfoKHR"/>.</returns>
        public static VkDisplayPresentInfoKHR* Alloc() {
            int size = sizeof(VkDisplayPresentInfoKHR);
            var info = (VkDisplayPresentInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayPresentInfoKHR;

            return info;
        }
    }

    // Struct: 112
    public unsafe partial struct VkDisplayProperties2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayProperties2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayProperties2KHR"/>.</returns>
        public static VkDisplayProperties2KHR* Alloc() {
            int size = sizeof(VkDisplayProperties2KHR);
            var info = (VkDisplayProperties2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplayProperties2KHR;

            return info;
        }
    }

    // Struct: 113
    public unsafe partial struct VkDisplayPropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplayPropertiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplayPropertiesKHR"/>.</returns>
        public static VkDisplayPropertiesKHR* Alloc() {
            int size = sizeof(VkDisplayPropertiesKHR);
            var info = (VkDisplayPropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 114
    public unsafe partial struct VkDisplaySurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkDisplaySurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDisplaySurfaceCreateInfoKHR"/>.</returns>
        public static VkDisplaySurfaceCreateInfoKHR* Alloc() {
            int size = sizeof(VkDisplaySurfaceCreateInfoKHR);
            var info = (VkDisplaySurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DisplaySurfaceCreateInfoKHR;

            return info;
        }
    }

    // Struct: 115
    public unsafe partial struct VkDrawIndexedIndirectCommand {
        /// <summary>
        /// Allocate an instance of <see cref="VkDrawIndexedIndirectCommand"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDrawIndexedIndirectCommand"/>.</returns>
        public static VkDrawIndexedIndirectCommand* Alloc() {
            int size = sizeof(VkDrawIndexedIndirectCommand);
            var info = (VkDrawIndexedIndirectCommand*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 116
    public unsafe partial struct VkDrawIndirectCommand {
        /// <summary>
        /// Allocate an instance of <see cref="VkDrawIndirectCommand"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDrawIndirectCommand"/>.</returns>
        public static VkDrawIndirectCommand* Alloc() {
            int size = sizeof(VkDrawIndirectCommand);
            var info = (VkDrawIndirectCommand*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 117
    public unsafe partial struct VkDrawMeshTasksIndirectCommandNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkDrawMeshTasksIndirectCommandNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDrawMeshTasksIndirectCommandNV"/>.</returns>
        public static VkDrawMeshTasksIndirectCommandNV* Alloc() {
            int size = sizeof(VkDrawMeshTasksIndirectCommandNV);
            var info = (VkDrawMeshTasksIndirectCommandNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 118
    public unsafe partial struct VkDrmFormatModifierPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDrmFormatModifierPropertiesEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDrmFormatModifierPropertiesEXT"/>.</returns>
        public static VkDrmFormatModifierPropertiesEXT* Alloc() {
            int size = sizeof(VkDrmFormatModifierPropertiesEXT);
            var info = (VkDrmFormatModifierPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 119
    public unsafe partial struct VkDrmFormatModifierPropertiesListEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkDrmFormatModifierPropertiesListEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkDrmFormatModifierPropertiesListEXT"/>.</returns>
        public static VkDrmFormatModifierPropertiesListEXT* Alloc() {
            int size = sizeof(VkDrmFormatModifierPropertiesListEXT);
            var info = (VkDrmFormatModifierPropertiesListEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.DrmFormatModifierPropertiesListExt;

            return info;
        }
    }

    // Struct: 120
    public unsafe partial struct VkEventCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkEventCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkEventCreateInfo"/>.</returns>
        public static VkEventCreateInfo* Alloc() {
            int size = sizeof(VkEventCreateInfo);
            var info = (VkEventCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.EventCreateInfo;

            return info;
        }
    }

    // Struct: 121
    public unsafe partial struct VkExportFenceCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportFenceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportFenceCreateInfo"/>.</returns>
        public static VkExportFenceCreateInfo* Alloc() {
            int size = sizeof(VkExportFenceCreateInfo);
            var info = (VkExportFenceCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportFenceCreateInfo;

            return info;
        }
    }

    // Struct: 122
    public unsafe partial struct VkExportFenceWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportFenceWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportFenceWin32HandleInfoKHR"/>.</returns>
        public static VkExportFenceWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkExportFenceWin32HandleInfoKHR);
            var info = (VkExportFenceWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportFenceWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 123
    public unsafe partial struct VkExportMemoryAllocateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportMemoryAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportMemoryAllocateInfo"/>.</returns>
        public static VkExportMemoryAllocateInfo* Alloc() {
            int size = sizeof(VkExportMemoryAllocateInfo);
            var info = (VkExportMemoryAllocateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportMemoryAllocateInfo;

            return info;
        }
    }

    // Struct: 124
    public unsafe partial struct VkExportMemoryAllocateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportMemoryAllocateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportMemoryAllocateInfoNV"/>.</returns>
        public static VkExportMemoryAllocateInfoNV* Alloc() {
            int size = sizeof(VkExportMemoryAllocateInfoNV);
            var info = (VkExportMemoryAllocateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportMemoryAllocateInfoNv;

            return info;
        }
    }

    // Struct: 125
    public unsafe partial struct VkExportMemoryWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportMemoryWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportMemoryWin32HandleInfoKHR"/>.</returns>
        public static VkExportMemoryWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkExportMemoryWin32HandleInfoKHR);
            var info = (VkExportMemoryWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportMemoryWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 126
    public unsafe partial struct VkExportMemoryWin32HandleInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportMemoryWin32HandleInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportMemoryWin32HandleInfoNV"/>.</returns>
        public static VkExportMemoryWin32HandleInfoNV* Alloc() {
            int size = sizeof(VkExportMemoryWin32HandleInfoNV);
            var info = (VkExportMemoryWin32HandleInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportMemoryWin32HandleInfoNv;

            return info;
        }
    }

    // Struct: 127
    public unsafe partial struct VkExportSemaphoreCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportSemaphoreCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportSemaphoreCreateInfo"/>.</returns>
        public static VkExportSemaphoreCreateInfo* Alloc() {
            int size = sizeof(VkExportSemaphoreCreateInfo);
            var info = (VkExportSemaphoreCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportSemaphoreCreateInfo;

            return info;
        }
    }

    // Struct: 128
    public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkExportSemaphoreWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExportSemaphoreWin32HandleInfoKHR"/>.</returns>
        public static VkExportSemaphoreWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkExportSemaphoreWin32HandleInfoKHR);
            var info = (VkExportSemaphoreWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExportSemaphoreWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 129
    public unsafe partial struct VkExtensionProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkExtensionProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExtensionProperties"/>.</returns>
        public static VkExtensionProperties* Alloc() {
            int size = sizeof(VkExtensionProperties);
            var info = (VkExtensionProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 130
    public unsafe partial struct VkExtent2D {
        /// <summary>
        /// Allocate an instance of <see cref="VkExtent2D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExtent2D"/>.</returns>
        public static VkExtent2D* Alloc() {
            int size = sizeof(VkExtent2D);
            var info = (VkExtent2D*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 131
    public unsafe partial struct VkExtent3D {
        /// <summary>
        /// Allocate an instance of <see cref="VkExtent3D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExtent3D"/>.</returns>
        public static VkExtent3D* Alloc() {
            int size = sizeof(VkExtent3D);
            var info = (VkExtent3D*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 132
    public unsafe partial struct VkExternalBufferProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalBufferProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalBufferProperties"/>.</returns>
        public static VkExternalBufferProperties* Alloc() {
            int size = sizeof(VkExternalBufferProperties);
            var info = (VkExternalBufferProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalBufferProperties;

            return info;
        }
    }

    // Struct: 133
    public unsafe partial struct VkExternalFenceProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalFenceProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalFenceProperties"/>.</returns>
        public static VkExternalFenceProperties* Alloc() {
            int size = sizeof(VkExternalFenceProperties);
            var info = (VkExternalFenceProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalFenceProperties;

            return info;
        }
    }

    // Struct: 134
    public unsafe partial struct VkExternalFormatANDROID {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalFormatANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalFormatANDROID"/>.</returns>
        public static VkExternalFormatANDROID* Alloc() {
            int size = sizeof(VkExternalFormatANDROID);
            var info = (VkExternalFormatANDROID*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalFormatAndroid;

            return info;
        }
    }

    // Struct: 135
    public unsafe partial struct VkExternalImageFormatProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalImageFormatProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalImageFormatProperties"/>.</returns>
        public static VkExternalImageFormatProperties* Alloc() {
            int size = sizeof(VkExternalImageFormatProperties);
            var info = (VkExternalImageFormatProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalImageFormatProperties;

            return info;
        }
    }

    // Struct: 136
    public unsafe partial struct VkExternalImageFormatPropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalImageFormatPropertiesNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalImageFormatPropertiesNV"/>.</returns>
        public static VkExternalImageFormatPropertiesNV* Alloc() {
            int size = sizeof(VkExternalImageFormatPropertiesNV);
            var info = (VkExternalImageFormatPropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 137
    public unsafe partial struct VkExternalMemoryBufferCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalMemoryBufferCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalMemoryBufferCreateInfo"/>.</returns>
        public static VkExternalMemoryBufferCreateInfo* Alloc() {
            int size = sizeof(VkExternalMemoryBufferCreateInfo);
            var info = (VkExternalMemoryBufferCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalMemoryBufferCreateInfo;

            return info;
        }
    }

    // Struct: 138
    public unsafe partial struct VkExternalMemoryImageCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalMemoryImageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalMemoryImageCreateInfo"/>.</returns>
        public static VkExternalMemoryImageCreateInfo* Alloc() {
            int size = sizeof(VkExternalMemoryImageCreateInfo);
            var info = (VkExternalMemoryImageCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalMemoryImageCreateInfo;

            return info;
        }
    }

    // Struct: 139
    public unsafe partial struct VkExternalMemoryImageCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalMemoryImageCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalMemoryImageCreateInfoNV"/>.</returns>
        public static VkExternalMemoryImageCreateInfoNV* Alloc() {
            int size = sizeof(VkExternalMemoryImageCreateInfoNV);
            var info = (VkExternalMemoryImageCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalMemoryImageCreateInfoNv;

            return info;
        }
    }

    // Struct: 140
    public unsafe partial struct VkExternalMemoryProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalMemoryProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalMemoryProperties"/>.</returns>
        public static VkExternalMemoryProperties* Alloc() {
            int size = sizeof(VkExternalMemoryProperties);
            var info = (VkExternalMemoryProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 141
    public unsafe partial struct VkExternalSemaphoreProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkExternalSemaphoreProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkExternalSemaphoreProperties"/>.</returns>
        public static VkExternalSemaphoreProperties* Alloc() {
            int size = sizeof(VkExternalSemaphoreProperties);
            var info = (VkExternalSemaphoreProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ExternalSemaphoreProperties;

            return info;
        }
    }

    // Struct: 142
    public unsafe partial struct VkFenceCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkFenceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFenceCreateInfo"/>.</returns>
        public static VkFenceCreateInfo* Alloc() {
            int size = sizeof(VkFenceCreateInfo);
            var info = (VkFenceCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.FenceCreateInfo;

            return info;
        }
    }

    // Struct: 143
    public unsafe partial struct VkFenceGetFdInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkFenceGetFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFenceGetFdInfoKHR"/>.</returns>
        public static VkFenceGetFdInfoKHR* Alloc() {
            int size = sizeof(VkFenceGetFdInfoKHR);
            var info = (VkFenceGetFdInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.FenceGetFdInfoKHR;

            return info;
        }
    }

    // Struct: 144
    public unsafe partial struct VkFenceGetWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkFenceGetWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFenceGetWin32HandleInfoKHR"/>.</returns>
        public static VkFenceGetWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkFenceGetWin32HandleInfoKHR);
            var info = (VkFenceGetWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.FenceGetWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 145
    public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkFilterCubicImageViewImageFormatPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFilterCubicImageViewImageFormatPropertiesEXT"/>.</returns>
        public static VkFilterCubicImageViewImageFormatPropertiesEXT* Alloc() {
            int size = sizeof(VkFilterCubicImageViewImageFormatPropertiesEXT);
            var info = (VkFilterCubicImageViewImageFormatPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.FilterCubicImageViewImageFormatPropertiesExt;

            return info;
        }
    }

    // Struct: 146
    public unsafe partial struct VkFormatProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkFormatProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFormatProperties"/>.</returns>
        public static VkFormatProperties* Alloc() {
            int size = sizeof(VkFormatProperties);
            var info = (VkFormatProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 147
    public unsafe partial struct VkFormatProperties2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkFormatProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFormatProperties2"/>.</returns>
        public static VkFormatProperties2* Alloc() {
            int size = sizeof(VkFormatProperties2);
            var info = (VkFormatProperties2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.FormatProperties2;

            return info;
        }
    }

    // Struct: 148
    public unsafe partial struct VkFramebufferCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkFramebufferCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkFramebufferCreateInfo"/>.</returns>
        public static VkFramebufferCreateInfo* Alloc() {
            int size = sizeof(VkFramebufferCreateInfo);
            var info = (VkFramebufferCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.FramebufferCreateInfo;

            return info;
        }
    }

    // Struct: 149
    public unsafe partial struct VkGeometryAABBNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkGeometryAABBNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkGeometryAABBNV"/>.</returns>
        public static VkGeometryAABBNV* Alloc() {
            int size = sizeof(VkGeometryAABBNV);
            var info = (VkGeometryAABBNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.GeometryAabbNv;

            return info;
        }
    }

    // Struct: 150
    public unsafe partial struct VkGeometryDataNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkGeometryDataNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkGeometryDataNV"/>.</returns>
        public static VkGeometryDataNV* Alloc() {
            int size = sizeof(VkGeometryDataNV);
            var info = (VkGeometryDataNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 151
    public unsafe partial struct VkGeometryNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkGeometryNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkGeometryNV"/>.</returns>
        public static VkGeometryNV* Alloc() {
            int size = sizeof(VkGeometryNV);
            var info = (VkGeometryNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.GeometryNv;

            return info;
        }
    }

    // Struct: 152
    public unsafe partial struct VkGeometryTrianglesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkGeometryTrianglesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkGeometryTrianglesNV"/>.</returns>
        public static VkGeometryTrianglesNV* Alloc() {
            int size = sizeof(VkGeometryTrianglesNV);
            var info = (VkGeometryTrianglesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.GeometryTrianglesNv;

            return info;
        }
    }

    // Struct: 153
    public unsafe partial struct VkGraphicsPipelineCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkGraphicsPipelineCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkGraphicsPipelineCreateInfo"/>.</returns>
        public static VkGraphicsPipelineCreateInfo* Alloc() {
            int size = sizeof(VkGraphicsPipelineCreateInfo);
            var info = (VkGraphicsPipelineCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.GraphicsPipelineCreateInfo;

            return info;
        }
    }

    // Struct: 154
    public unsafe partial struct VkHdrMetadataEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkHdrMetadataEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkHdrMetadataEXT"/>.</returns>
        public static VkHdrMetadataEXT* Alloc() {
            int size = sizeof(VkHdrMetadataEXT);
            var info = (VkHdrMetadataEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.HdrMetadataExt;

            return info;
        }
    }

    // Struct: 155
    public unsafe partial struct VkIOSSurfaceCreateInfoMVK {
        /// <summary>
        /// Allocate an instance of <see cref="VkIOSSurfaceCreateInfoMVK"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkIOSSurfaceCreateInfoMVK"/>.</returns>
        public static VkIOSSurfaceCreateInfoMVK* Alloc() {
            int size = sizeof(VkIOSSurfaceCreateInfoMVK);
            var info = (VkIOSSurfaceCreateInfoMVK*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.IosSurfaceCreateInfoMvk;

            return info;
        }
    }

    // Struct: 156
    public unsafe partial struct VkImageBlit {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageBlit"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageBlit"/>.</returns>
        public static VkImageBlit* Alloc() {
            int size = sizeof(VkImageBlit);
            var info = (VkImageBlit*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 157
    public unsafe partial struct VkImageCopy {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageCopy"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageCopy"/>.</returns>
        public static VkImageCopy* Alloc() {
            int size = sizeof(VkImageCopy);
            var info = (VkImageCopy*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 158
    public unsafe partial struct VkImageCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageCreateInfo"/>.</returns>
        public static VkImageCreateInfo* Alloc() {
            int size = sizeof(VkImageCreateInfo);
            var info = (VkImageCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageCreateInfo;

            return info;
        }
    }

    // Struct: 159
    public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageDrmFormatModifierExplicitCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageDrmFormatModifierExplicitCreateInfoEXT"/>.</returns>
        public static VkImageDrmFormatModifierExplicitCreateInfoEXT* Alloc() {
            int size = sizeof(VkImageDrmFormatModifierExplicitCreateInfoEXT);
            var info = (VkImageDrmFormatModifierExplicitCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoExt;

            return info;
        }
    }

    // Struct: 160
    public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageDrmFormatModifierListCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageDrmFormatModifierListCreateInfoEXT"/>.</returns>
        public static VkImageDrmFormatModifierListCreateInfoEXT* Alloc() {
            int size = sizeof(VkImageDrmFormatModifierListCreateInfoEXT);
            var info = (VkImageDrmFormatModifierListCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageDrmFormatModifierListCreateInfoExt;

            return info;
        }
    }

    // Struct: 161
    public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageDrmFormatModifierPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageDrmFormatModifierPropertiesEXT"/>.</returns>
        public static VkImageDrmFormatModifierPropertiesEXT* Alloc() {
            int size = sizeof(VkImageDrmFormatModifierPropertiesEXT);
            var info = (VkImageDrmFormatModifierPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageDrmFormatModifierPropertiesExt;

            return info;
        }
    }

    // Struct: 162
    public unsafe partial struct VkImageFormatListCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageFormatListCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageFormatListCreateInfoKHR"/>.</returns>
        public static VkImageFormatListCreateInfoKHR* Alloc() {
            int size = sizeof(VkImageFormatListCreateInfoKHR);
            var info = (VkImageFormatListCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageFormatListCreateInfoKHR;

            return info;
        }
    }

    // Struct: 163
    public unsafe partial struct VkImageFormatProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageFormatProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageFormatProperties"/>.</returns>
        public static VkImageFormatProperties* Alloc() {
            int size = sizeof(VkImageFormatProperties);
            var info = (VkImageFormatProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 164
    public unsafe partial struct VkImageFormatProperties2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageFormatProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageFormatProperties2"/>.</returns>
        public static VkImageFormatProperties2* Alloc() {
            int size = sizeof(VkImageFormatProperties2);
            var info = (VkImageFormatProperties2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageFormatProperties2;

            return info;
        }
    }

    // Struct: 165
    public unsafe partial struct VkImageMemoryBarrier {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageMemoryBarrier"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageMemoryBarrier"/>.</returns>
        public static VkImageMemoryBarrier* Alloc() {
            int size = sizeof(VkImageMemoryBarrier);
            var info = (VkImageMemoryBarrier*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageMemoryBarrier;

            return info;
        }
    }

    // Struct: 166
    public unsafe partial struct VkImageMemoryRequirementsInfo2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageMemoryRequirementsInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageMemoryRequirementsInfo2"/>.</returns>
        public static VkImageMemoryRequirementsInfo2* Alloc() {
            int size = sizeof(VkImageMemoryRequirementsInfo2);
            var info = (VkImageMemoryRequirementsInfo2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageMemoryRequirementsInfo2;

            return info;
        }
    }

    // Struct: 167
    public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA {
        /// <summary>
        /// Allocate an instance of <see cref="VkImagePipeSurfaceCreateInfoFUCHSIA"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImagePipeSurfaceCreateInfoFUCHSIA"/>.</returns>
        public static VkImagePipeSurfaceCreateInfoFUCHSIA* Alloc() {
            int size = sizeof(VkImagePipeSurfaceCreateInfoFUCHSIA);
            var info = (VkImagePipeSurfaceCreateInfoFUCHSIA*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImagepipeSurfaceCreateInfoFuchsia;

            return info;
        }
    }

    // Struct: 168
    public unsafe partial struct VkImagePlaneMemoryRequirementsInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkImagePlaneMemoryRequirementsInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImagePlaneMemoryRequirementsInfo"/>.</returns>
        public static VkImagePlaneMemoryRequirementsInfo* Alloc() {
            int size = sizeof(VkImagePlaneMemoryRequirementsInfo);
            var info = (VkImagePlaneMemoryRequirementsInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImagePlaneMemoryRequirementsInfo;

            return info;
        }
    }

    // Struct: 169
    public unsafe partial struct VkImageResolve {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageResolve"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageResolve"/>.</returns>
        public static VkImageResolve* Alloc() {
            int size = sizeof(VkImageResolve);
            var info = (VkImageResolve*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 170
    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageSparseMemoryRequirementsInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageSparseMemoryRequirementsInfo2"/>.</returns>
        public static VkImageSparseMemoryRequirementsInfo2* Alloc() {
            int size = sizeof(VkImageSparseMemoryRequirementsInfo2);
            var info = (VkImageSparseMemoryRequirementsInfo2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageSparseMemoryRequirementsInfo2;

            return info;
        }
    }

    // Struct: 171
    public unsafe partial struct VkImageStencilUsageCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageStencilUsageCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageStencilUsageCreateInfoEXT"/>.</returns>
        public static VkImageStencilUsageCreateInfoEXT* Alloc() {
            int size = sizeof(VkImageStencilUsageCreateInfoEXT);
            var info = (VkImageStencilUsageCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageStencilUsageCreateInfoExt;

            return info;
        }
    }

    // Struct: 172
    public unsafe partial struct VkImageSubresource {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageSubresource"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageSubresource"/>.</returns>
        public static VkImageSubresource* Alloc() {
            int size = sizeof(VkImageSubresource);
            var info = (VkImageSubresource*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 173
    public unsafe partial struct VkImageSubresourceLayers {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageSubresourceLayers"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageSubresourceLayers"/>.</returns>
        public static VkImageSubresourceLayers* Alloc() {
            int size = sizeof(VkImageSubresourceLayers);
            var info = (VkImageSubresourceLayers*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 174
    public unsafe partial struct VkImageSubresourceRange {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageSubresourceRange"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageSubresourceRange"/>.</returns>
        public static VkImageSubresourceRange* Alloc() {
            int size = sizeof(VkImageSubresourceRange);
            var info = (VkImageSubresourceRange*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 175
    public unsafe partial struct VkImageSwapchainCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageSwapchainCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageSwapchainCreateInfoKHR"/>.</returns>
        public static VkImageSwapchainCreateInfoKHR* Alloc() {
            int size = sizeof(VkImageSwapchainCreateInfoKHR);
            var info = (VkImageSwapchainCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageSwapchainCreateInfoKHR;

            return info;
        }
    }

    // Struct: 176
    public unsafe partial struct VkImageViewASTCDecodeModeEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageViewASTCDecodeModeEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageViewASTCDecodeModeEXT"/>.</returns>
        public static VkImageViewASTCDecodeModeEXT* Alloc() {
            int size = sizeof(VkImageViewASTCDecodeModeEXT);
            var info = (VkImageViewASTCDecodeModeEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageViewAstcDecodeModeExt;

            return info;
        }
    }

    // Struct: 177
    public unsafe partial struct VkImageViewCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageViewCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageViewCreateInfo"/>.</returns>
        public static VkImageViewCreateInfo* Alloc() {
            int size = sizeof(VkImageViewCreateInfo);
            var info = (VkImageViewCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageViewCreateInfo;

            return info;
        }
    }

    // Struct: 178
    public unsafe partial struct VkImageViewHandleInfoNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageViewHandleInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageViewHandleInfoNVX"/>.</returns>
        public static VkImageViewHandleInfoNVX* Alloc() {
            int size = sizeof(VkImageViewHandleInfoNVX);
            var info = (VkImageViewHandleInfoNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageViewHandleInfoNvx;

            return info;
        }
    }

    // Struct: 179
    public unsafe partial struct VkImageViewUsageCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkImageViewUsageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImageViewUsageCreateInfo"/>.</returns>
        public static VkImageViewUsageCreateInfo* Alloc() {
            int size = sizeof(VkImageViewUsageCreateInfo);
            var info = (VkImageViewUsageCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImageViewUsageCreateInfo;

            return info;
        }
    }

    // Struct: 180
    public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportAndroidHardwareBufferInfoANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportAndroidHardwareBufferInfoANDROID"/>.</returns>
        public static VkImportAndroidHardwareBufferInfoANDROID* Alloc() {
            int size = sizeof(VkImportAndroidHardwareBufferInfoANDROID);
            var info = (VkImportAndroidHardwareBufferInfoANDROID*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportAndroidHardwareBufferInfoAndroid;

            return info;
        }
    }

    // Struct: 181
    public unsafe partial struct VkImportFenceFdInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportFenceFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportFenceFdInfoKHR"/>.</returns>
        public static VkImportFenceFdInfoKHR* Alloc() {
            int size = sizeof(VkImportFenceFdInfoKHR);
            var info = (VkImportFenceFdInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportFenceFdInfoKHR;

            return info;
        }
    }

    // Struct: 182
    public unsafe partial struct VkImportFenceWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportFenceWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportFenceWin32HandleInfoKHR"/>.</returns>
        public static VkImportFenceWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkImportFenceWin32HandleInfoKHR);
            var info = (VkImportFenceWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportFenceWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 183
    public unsafe partial struct VkImportMemoryFdInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportMemoryFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportMemoryFdInfoKHR"/>.</returns>
        public static VkImportMemoryFdInfoKHR* Alloc() {
            int size = sizeof(VkImportMemoryFdInfoKHR);
            var info = (VkImportMemoryFdInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportMemoryFdInfoKHR;

            return info;
        }
    }

    // Struct: 184
    public unsafe partial struct VkImportMemoryHostPointerInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportMemoryHostPointerInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportMemoryHostPointerInfoEXT"/>.</returns>
        public static VkImportMemoryHostPointerInfoEXT* Alloc() {
            int size = sizeof(VkImportMemoryHostPointerInfoEXT);
            var info = (VkImportMemoryHostPointerInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportMemoryHostPointerInfoExt;

            return info;
        }
    }

    // Struct: 185
    public unsafe partial struct VkImportMemoryWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportMemoryWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportMemoryWin32HandleInfoKHR"/>.</returns>
        public static VkImportMemoryWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkImportMemoryWin32HandleInfoKHR);
            var info = (VkImportMemoryWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportMemoryWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 186
    public unsafe partial struct VkImportMemoryWin32HandleInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportMemoryWin32HandleInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportMemoryWin32HandleInfoNV"/>.</returns>
        public static VkImportMemoryWin32HandleInfoNV* Alloc() {
            int size = sizeof(VkImportMemoryWin32HandleInfoNV);
            var info = (VkImportMemoryWin32HandleInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportMemoryWin32HandleInfoNv;

            return info;
        }
    }

    // Struct: 187
    public unsafe partial struct VkImportSemaphoreFdInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportSemaphoreFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportSemaphoreFdInfoKHR"/>.</returns>
        public static VkImportSemaphoreFdInfoKHR* Alloc() {
            int size = sizeof(VkImportSemaphoreFdInfoKHR);
            var info = (VkImportSemaphoreFdInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportSemaphoreFdInfoKHR;

            return info;
        }
    }

    // Struct: 188
    public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkImportSemaphoreWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkImportSemaphoreWin32HandleInfoKHR"/>.</returns>
        public static VkImportSemaphoreWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkImportSemaphoreWin32HandleInfoKHR);
            var info = (VkImportSemaphoreWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ImportSemaphoreWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 189
    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkIndirectCommandsLayoutCreateInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkIndirectCommandsLayoutCreateInfoNVX"/>.</returns>
        public static VkIndirectCommandsLayoutCreateInfoNVX* Alloc() {
            int size = sizeof(VkIndirectCommandsLayoutCreateInfoNVX);
            var info = (VkIndirectCommandsLayoutCreateInfoNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.IndirectCommandsLayoutCreateInfoNvx;

            return info;
        }
    }

    // Struct: 190
    public unsafe partial struct VkIndirectCommandsLayoutTokenNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkIndirectCommandsLayoutTokenNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkIndirectCommandsLayoutTokenNVX"/>.</returns>
        public static VkIndirectCommandsLayoutTokenNVX* Alloc() {
            int size = sizeof(VkIndirectCommandsLayoutTokenNVX);
            var info = (VkIndirectCommandsLayoutTokenNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 191
    public unsafe partial struct VkIndirectCommandsTokenNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkIndirectCommandsTokenNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkIndirectCommandsTokenNVX"/>.</returns>
        public static VkIndirectCommandsTokenNVX* Alloc() {
            int size = sizeof(VkIndirectCommandsTokenNVX);
            var info = (VkIndirectCommandsTokenNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 192
    public unsafe partial struct VkInputAttachmentAspectReference {
        /// <summary>
        /// Allocate an instance of <see cref="VkInputAttachmentAspectReference"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkInputAttachmentAspectReference"/>.</returns>
        public static VkInputAttachmentAspectReference* Alloc() {
            int size = sizeof(VkInputAttachmentAspectReference);
            var info = (VkInputAttachmentAspectReference*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 193
    public unsafe partial struct VkInstanceCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkInstanceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkInstanceCreateInfo"/>.</returns>
        public static VkInstanceCreateInfo* Alloc() {
            int size = sizeof(VkInstanceCreateInfo);
            var info = (VkInstanceCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.InstanceCreateInfo;

            return info;
        }
    }

    // Struct: 194
    public unsafe partial struct VkLayerProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkLayerProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkLayerProperties"/>.</returns>
        public static VkLayerProperties* Alloc() {
            int size = sizeof(VkLayerProperties);
            var info = (VkLayerProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 195
    public unsafe partial struct VkMacOSSurfaceCreateInfoMVK {
        /// <summary>
        /// Allocate an instance of <see cref="VkMacOSSurfaceCreateInfoMVK"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMacOSSurfaceCreateInfoMVK"/>.</returns>
        public static VkMacOSSurfaceCreateInfoMVK* Alloc() {
            int size = sizeof(VkMacOSSurfaceCreateInfoMVK);
            var info = (VkMacOSSurfaceCreateInfoMVK*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MacosSurfaceCreateInfoMvk;

            return info;
        }
    }

    // Struct: 196
    public unsafe partial struct VkMappedMemoryRange {
        /// <summary>
        /// Allocate an instance of <see cref="VkMappedMemoryRange"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMappedMemoryRange"/>.</returns>
        public static VkMappedMemoryRange* Alloc() {
            int size = sizeof(VkMappedMemoryRange);
            var info = (VkMappedMemoryRange*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MappedMemoryRange;

            return info;
        }
    }

    // Struct: 197
    public unsafe partial struct VkMemoryAllocateFlagsInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryAllocateFlagsInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryAllocateFlagsInfo"/>.</returns>
        public static VkMemoryAllocateFlagsInfo* Alloc() {
            int size = sizeof(VkMemoryAllocateFlagsInfo);
            var info = (VkMemoryAllocateFlagsInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryAllocateFlagsInfo;

            return info;
        }
    }

    // Struct: 198
    public unsafe partial struct VkMemoryAllocateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryAllocateInfo"/>.</returns>
        public static VkMemoryAllocateInfo* Alloc() {
            int size = sizeof(VkMemoryAllocateInfo);
            var info = (VkMemoryAllocateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryAllocateInfo;

            return info;
        }
    }

    // Struct: 199
    public unsafe partial struct VkMemoryBarrier {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryBarrier"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryBarrier"/>.</returns>
        public static VkMemoryBarrier* Alloc() {
            int size = sizeof(VkMemoryBarrier);
            var info = (VkMemoryBarrier*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryBarrier;

            return info;
        }
    }

    // Struct: 200
    public unsafe partial struct VkMemoryDedicatedAllocateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryDedicatedAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryDedicatedAllocateInfo"/>.</returns>
        public static VkMemoryDedicatedAllocateInfo* Alloc() {
            int size = sizeof(VkMemoryDedicatedAllocateInfo);
            var info = (VkMemoryDedicatedAllocateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryDedicatedAllocateInfo;

            return info;
        }
    }

    // Struct: 201
    public unsafe partial struct VkMemoryDedicatedRequirements {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryDedicatedRequirements"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryDedicatedRequirements"/>.</returns>
        public static VkMemoryDedicatedRequirements* Alloc() {
            int size = sizeof(VkMemoryDedicatedRequirements);
            var info = (VkMemoryDedicatedRequirements*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryDedicatedRequirements;

            return info;
        }
    }

    // Struct: 202
    public unsafe partial struct VkMemoryFdPropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryFdPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryFdPropertiesKHR"/>.</returns>
        public static VkMemoryFdPropertiesKHR* Alloc() {
            int size = sizeof(VkMemoryFdPropertiesKHR);
            var info = (VkMemoryFdPropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryFdPropertiesKHR;

            return info;
        }
    }

    // Struct: 203
    public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID"/>.</returns>
        public static VkMemoryGetAndroidHardwareBufferInfoANDROID* Alloc() {
            int size = sizeof(VkMemoryGetAndroidHardwareBufferInfoANDROID);
            var info = (VkMemoryGetAndroidHardwareBufferInfoANDROID*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryGetAndroidHardwareBufferInfoAndroid;

            return info;
        }
    }

    // Struct: 204
    public unsafe partial struct VkMemoryGetFdInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryGetFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryGetFdInfoKHR"/>.</returns>
        public static VkMemoryGetFdInfoKHR* Alloc() {
            int size = sizeof(VkMemoryGetFdInfoKHR);
            var info = (VkMemoryGetFdInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryGetFdInfoKHR;

            return info;
        }
    }

    // Struct: 205
    public unsafe partial struct VkMemoryGetWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryGetWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryGetWin32HandleInfoKHR"/>.</returns>
        public static VkMemoryGetWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkMemoryGetWin32HandleInfoKHR);
            var info = (VkMemoryGetWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryGetWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 206
    public unsafe partial struct VkMemoryHeap {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryHeap"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryHeap"/>.</returns>
        public static VkMemoryHeap* Alloc() {
            int size = sizeof(VkMemoryHeap);
            var info = (VkMemoryHeap*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 207
    public unsafe partial struct VkMemoryHostPointerPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryHostPointerPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryHostPointerPropertiesEXT"/>.</returns>
        public static VkMemoryHostPointerPropertiesEXT* Alloc() {
            int size = sizeof(VkMemoryHostPointerPropertiesEXT);
            var info = (VkMemoryHostPointerPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryHostPointerPropertiesExt;

            return info;
        }
    }

    // Struct: 208
    public unsafe partial struct VkMemoryPriorityAllocateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryPriorityAllocateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryPriorityAllocateInfoEXT"/>.</returns>
        public static VkMemoryPriorityAllocateInfoEXT* Alloc() {
            int size = sizeof(VkMemoryPriorityAllocateInfoEXT);
            var info = (VkMemoryPriorityAllocateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryPriorityAllocateInfoExt;

            return info;
        }
    }

    // Struct: 209
    public unsafe partial struct VkMemoryRequirements {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryRequirements"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryRequirements"/>.</returns>
        public static VkMemoryRequirements* Alloc() {
            int size = sizeof(VkMemoryRequirements);
            var info = (VkMemoryRequirements*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 210
    public unsafe partial struct VkMemoryRequirements2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryRequirements2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryRequirements2"/>.</returns>
        public static VkMemoryRequirements2* Alloc() {
            int size = sizeof(VkMemoryRequirements2);
            var info = (VkMemoryRequirements2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryRequirements2;

            return info;
        }
    }

    // Struct: 211
    public unsafe partial struct VkMemoryType {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryType"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryType"/>.</returns>
        public static VkMemoryType* Alloc() {
            int size = sizeof(VkMemoryType);
            var info = (VkMemoryType*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 212
    public unsafe partial struct VkMemoryWin32HandlePropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkMemoryWin32HandlePropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMemoryWin32HandlePropertiesKHR"/>.</returns>
        public static VkMemoryWin32HandlePropertiesKHR* Alloc() {
            int size = sizeof(VkMemoryWin32HandlePropertiesKHR);
            var info = (VkMemoryWin32HandlePropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MemoryWin32HandlePropertiesKHR;

            return info;
        }
    }

    // Struct: 213
    public unsafe partial struct VkMetalSurfaceCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkMetalSurfaceCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMetalSurfaceCreateInfoEXT"/>.</returns>
        public static VkMetalSurfaceCreateInfoEXT* Alloc() {
            int size = sizeof(VkMetalSurfaceCreateInfoEXT);
            var info = (VkMetalSurfaceCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MetalSurfaceCreateInfoExt;

            return info;
        }
    }

    // Struct: 214
    public unsafe partial struct VkMultisamplePropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkMultisamplePropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkMultisamplePropertiesEXT"/>.</returns>
        public static VkMultisamplePropertiesEXT* Alloc() {
            int size = sizeof(VkMultisamplePropertiesEXT);
            var info = (VkMultisamplePropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.MultisamplePropertiesExt;

            return info;
        }
    }

    // Struct: 215
    public unsafe partial struct VkObjectTableCreateInfoNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTableCreateInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTableCreateInfoNVX"/>.</returns>
        public static VkObjectTableCreateInfoNVX* Alloc() {
            int size = sizeof(VkObjectTableCreateInfoNVX);
            var info = (VkObjectTableCreateInfoNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ObjectTableCreateInfoNvx;

            return info;
        }
    }

    // Struct: 216
    public unsafe partial struct VkObjectTableDescriptorSetEntryNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTableDescriptorSetEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTableDescriptorSetEntryNVX"/>.</returns>
        public static VkObjectTableDescriptorSetEntryNVX* Alloc() {
            int size = sizeof(VkObjectTableDescriptorSetEntryNVX);
            var info = (VkObjectTableDescriptorSetEntryNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 217
    public unsafe partial struct VkObjectTableEntryNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTableEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTableEntryNVX"/>.</returns>
        public static VkObjectTableEntryNVX* Alloc() {
            int size = sizeof(VkObjectTableEntryNVX);
            var info = (VkObjectTableEntryNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 218
    public unsafe partial struct VkObjectTableIndexBufferEntryNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTableIndexBufferEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTableIndexBufferEntryNVX"/>.</returns>
        public static VkObjectTableIndexBufferEntryNVX* Alloc() {
            int size = sizeof(VkObjectTableIndexBufferEntryNVX);
            var info = (VkObjectTableIndexBufferEntryNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 219
    public unsafe partial struct VkObjectTablePipelineEntryNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTablePipelineEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTablePipelineEntryNVX"/>.</returns>
        public static VkObjectTablePipelineEntryNVX* Alloc() {
            int size = sizeof(VkObjectTablePipelineEntryNVX);
            var info = (VkObjectTablePipelineEntryNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 220
    public unsafe partial struct VkObjectTablePushConstantEntryNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTablePushConstantEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTablePushConstantEntryNVX"/>.</returns>
        public static VkObjectTablePushConstantEntryNVX* Alloc() {
            int size = sizeof(VkObjectTablePushConstantEntryNVX);
            var info = (VkObjectTablePushConstantEntryNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 221
    public unsafe partial struct VkObjectTableVertexBufferEntryNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkObjectTableVertexBufferEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkObjectTableVertexBufferEntryNVX"/>.</returns>
        public static VkObjectTableVertexBufferEntryNVX* Alloc() {
            int size = sizeof(VkObjectTableVertexBufferEntryNVX);
            var info = (VkObjectTableVertexBufferEntryNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 222
    public unsafe partial struct VkOffset2D {
        /// <summary>
        /// Allocate an instance of <see cref="VkOffset2D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkOffset2D"/>.</returns>
        public static VkOffset2D* Alloc() {
            int size = sizeof(VkOffset2D);
            var info = (VkOffset2D*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 223
    public unsafe partial struct VkOffset3D {
        /// <summary>
        /// Allocate an instance of <see cref="VkOffset3D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkOffset3D"/>.</returns>
        public static VkOffset3D* Alloc() {
            int size = sizeof(VkOffset3D);
            var info = (VkOffset3D*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 224
    public unsafe partial struct VkPastPresentationTimingGOOGLE {
        /// <summary>
        /// Allocate an instance of <see cref="VkPastPresentationTimingGOOGLE"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPastPresentationTimingGOOGLE"/>.</returns>
        public static VkPastPresentationTimingGOOGLE* Alloc() {
            int size = sizeof(VkPastPresentationTimingGOOGLE);
            var info = (VkPastPresentationTimingGOOGLE*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 225
    public unsafe partial struct VkPhysicalDevice16BitStorageFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDevice16BitStorageFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDevice16BitStorageFeatures"/>.</returns>
        public static VkPhysicalDevice16BitStorageFeatures* Alloc() {
            int size = sizeof(VkPhysicalDevice16BitStorageFeatures);
            var info = (VkPhysicalDevice16BitStorageFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDevice16bitStorageFeatures;

            return info;
        }
    }

    // Struct: 226
    public unsafe partial struct VkPhysicalDevice8BitStorageFeaturesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDevice8BitStorageFeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDevice8BitStorageFeaturesKHR"/>.</returns>
        public static VkPhysicalDevice8BitStorageFeaturesKHR* Alloc() {
            int size = sizeof(VkPhysicalDevice8BitStorageFeaturesKHR);
            var info = (VkPhysicalDevice8BitStorageFeaturesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDevice8bitStorageFeaturesKHR;

            return info;
        }
    }

    // Struct: 227
    public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceASTCDecodeFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceASTCDecodeFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceASTCDecodeFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceASTCDecodeFeaturesEXT);
            var info = (VkPhysicalDeviceASTCDecodeFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceAstcDecodeFeaturesExt;

            return info;
        }
    }

    // Struct: 228
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT);
            var info = (VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedFeaturesExt;

            return info;
        }
    }

    // Struct: 229
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT);
            var info = (VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesExt;

            return info;
        }
    }

    // Struct: 230
    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceBufferDeviceAddressFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceBufferDeviceAddressFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceBufferDeviceAddressFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceBufferDeviceAddressFeaturesEXT);
            var info = (VkPhysicalDeviceBufferDeviceAddressFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt;

            return info;
        }
    }

    // Struct: 231
    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceComputeShaderDerivativesFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceComputeShaderDerivativesFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceComputeShaderDerivativesFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceComputeShaderDerivativesFeaturesNV);
            var info = (VkPhysicalDeviceComputeShaderDerivativesFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNv;

            return info;
        }
    }

    // Struct: 232
    public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceConditionalRenderingFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceConditionalRenderingFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceConditionalRenderingFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceConditionalRenderingFeaturesEXT);
            var info = (VkPhysicalDeviceConditionalRenderingFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesExt;

            return info;
        }
    }

    // Struct: 233
    public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceConservativeRasterizationPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceConservativeRasterizationPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceConservativeRasterizationPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceConservativeRasterizationPropertiesEXT);
            var info = (VkPhysicalDeviceConservativeRasterizationPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesExt;

            return info;
        }
    }

    // Struct: 234
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceCooperativeMatrixFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceCooperativeMatrixFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceCooperativeMatrixFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceCooperativeMatrixFeaturesNV);
            var info = (VkPhysicalDeviceCooperativeMatrixFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNv;

            return info;
        }
    }

    // Struct: 235
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV"/>.</returns>
        public static VkPhysicalDeviceCooperativeMatrixPropertiesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV);
            var info = (VkPhysicalDeviceCooperativeMatrixPropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNv;

            return info;
        }
    }

    // Struct: 236
    public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceCornerSampledImageFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceCornerSampledImageFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceCornerSampledImageFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceCornerSampledImageFeaturesNV);
            var info = (VkPhysicalDeviceCornerSampledImageFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNv;

            return info;
        }
    }

    // Struct: 237
    public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV);
            var info = (VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv;

            return info;
        }
    }

    // Struct: 238
    public unsafe partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDepthClipEnableFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDepthClipEnableFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceDepthClipEnableFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceDepthClipEnableFeaturesEXT);
            var info = (VkPhysicalDeviceDepthClipEnableFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDepthClipEnableFeaturesExt;

            return info;
        }
    }

    // Struct: 239
    public unsafe partial struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDepthStencilResolvePropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDepthStencilResolvePropertiesKHR"/>.</returns>
        public static VkPhysicalDeviceDepthStencilResolvePropertiesKHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceDepthStencilResolvePropertiesKHR);
            var info = (VkPhysicalDeviceDepthStencilResolvePropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDepthStencilResolvePropertiesKHR;

            return info;
        }
    }

    // Struct: 240
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDescriptorIndexingFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDescriptorIndexingFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceDescriptorIndexingFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceDescriptorIndexingFeaturesEXT);
            var info = (VkPhysicalDeviceDescriptorIndexingFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDescriptorIndexingFeaturesExt;

            return info;
        }
    }

    // Struct: 241
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDescriptorIndexingPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDescriptorIndexingPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceDescriptorIndexingPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceDescriptorIndexingPropertiesEXT);
            var info = (VkPhysicalDeviceDescriptorIndexingPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDescriptorIndexingPropertiesExt;

            return info;
        }
    }

    // Struct: 242
    public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDiscardRectanglePropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDiscardRectanglePropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceDiscardRectanglePropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceDiscardRectanglePropertiesEXT);
            var info = (VkPhysicalDeviceDiscardRectanglePropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesExt;

            return info;
        }
    }

    // Struct: 243
    public unsafe partial struct VkPhysicalDeviceDriverPropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceDriverPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceDriverPropertiesKHR"/>.</returns>
        public static VkPhysicalDeviceDriverPropertiesKHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceDriverPropertiesKHR);
            var info = (VkPhysicalDeviceDriverPropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceDriverPropertiesKHR;

            return info;
        }
    }

    // Struct: 244
    public unsafe partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceExclusiveScissorFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceExclusiveScissorFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceExclusiveScissorFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceExclusiveScissorFeaturesNV);
            var info = (VkPhysicalDeviceExclusiveScissorFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceExclusiveScissorFeaturesNv;

            return info;
        }
    }

    // Struct: 245
    public unsafe partial struct VkPhysicalDeviceExternalBufferInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceExternalBufferInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceExternalBufferInfo"/>.</returns>
        public static VkPhysicalDeviceExternalBufferInfo* Alloc() {
            int size = sizeof(VkPhysicalDeviceExternalBufferInfo);
            var info = (VkPhysicalDeviceExternalBufferInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceExternalBufferInfo;

            return info;
        }
    }

    // Struct: 246
    public unsafe partial struct VkPhysicalDeviceExternalFenceInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceExternalFenceInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceExternalFenceInfo"/>.</returns>
        public static VkPhysicalDeviceExternalFenceInfo* Alloc() {
            int size = sizeof(VkPhysicalDeviceExternalFenceInfo);
            var info = (VkPhysicalDeviceExternalFenceInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceExternalFenceInfo;

            return info;
        }
    }

    // Struct: 247
    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceExternalImageFormatInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceExternalImageFormatInfo"/>.</returns>
        public static VkPhysicalDeviceExternalImageFormatInfo* Alloc() {
            int size = sizeof(VkPhysicalDeviceExternalImageFormatInfo);
            var info = (VkPhysicalDeviceExternalImageFormatInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceExternalImageFormatInfo;

            return info;
        }
    }

    // Struct: 248
    public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceExternalMemoryHostPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceExternalMemoryHostPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceExternalMemoryHostPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceExternalMemoryHostPropertiesEXT);
            var info = (VkPhysicalDeviceExternalMemoryHostPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesExt;

            return info;
        }
    }

    // Struct: 249
    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceExternalSemaphoreInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceExternalSemaphoreInfo"/>.</returns>
        public static VkPhysicalDeviceExternalSemaphoreInfo* Alloc() {
            int size = sizeof(VkPhysicalDeviceExternalSemaphoreInfo);
            var info = (VkPhysicalDeviceExternalSemaphoreInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceExternalSemaphoreInfo;

            return info;
        }
    }

    // Struct: 250
    public unsafe partial struct VkPhysicalDeviceFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFeatures"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFeatures"/>.</returns>
        public static VkPhysicalDeviceFeatures* Alloc() {
            int size = sizeof(VkPhysicalDeviceFeatures);
            var info = (VkPhysicalDeviceFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 251
    public unsafe partial struct VkPhysicalDeviceFeatures2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFeatures2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFeatures2"/>.</returns>
        public static VkPhysicalDeviceFeatures2* Alloc() {
            int size = sizeof(VkPhysicalDeviceFeatures2);
            var info = (VkPhysicalDeviceFeatures2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceFeatures2;

            return info;
        }
    }

    // Struct: 252
    public unsafe partial struct VkPhysicalDeviceFloat16Int8FeaturesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFloat16Int8FeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFloat16Int8FeaturesKHR"/>.</returns>
        public static VkPhysicalDeviceFloat16Int8FeaturesKHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceFloat16Int8FeaturesKHR);
            var info = (VkPhysicalDeviceFloat16Int8FeaturesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceFloat16Int8FeaturesKHR;

            return info;
        }
    }

    // Struct: 253
    public unsafe partial struct VkPhysicalDeviceFloatControlsPropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFloatControlsPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFloatControlsPropertiesKHR"/>.</returns>
        public static VkPhysicalDeviceFloatControlsPropertiesKHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceFloatControlsPropertiesKHR);
            var info = (VkPhysicalDeviceFloatControlsPropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceFloatControlsPropertiesKHR;

            return info;
        }
    }

    // Struct: 254
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFragmentDensityMapFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFragmentDensityMapFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceFragmentDensityMapFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceFragmentDensityMapFeaturesEXT);
            var info = (VkPhysicalDeviceFragmentDensityMapFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesExt;

            return info;
        }
    }

    // Struct: 255
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFragmentDensityMapPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFragmentDensityMapPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceFragmentDensityMapPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceFragmentDensityMapPropertiesEXT);
            var info = (VkPhysicalDeviceFragmentDensityMapPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesExt;

            return info;
        }
    }

    // Struct: 256
    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV);
            var info = (VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesNv;

            return info;
        }
    }

    // Struct: 257
    public unsafe partial struct VkPhysicalDeviceGroupProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceGroupProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceGroupProperties"/>.</returns>
        public static VkPhysicalDeviceGroupProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceGroupProperties);
            var info = (VkPhysicalDeviceGroupProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceGroupProperties;

            return info;
        }
    }

    // Struct: 258
    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceHostQueryResetFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceHostQueryResetFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceHostQueryResetFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceHostQueryResetFeaturesEXT);
            var info = (VkPhysicalDeviceHostQueryResetFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceHostQueryResetFeaturesExt;

            return info;
        }
    }

    // Struct: 259
    public unsafe partial struct VkPhysicalDeviceIDProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceIDProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceIDProperties"/>.</returns>
        public static VkPhysicalDeviceIDProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceIDProperties);
            var info = (VkPhysicalDeviceIDProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceIdProperties;

            return info;
        }
    }

    // Struct: 260
    public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceImageDrmFormatModifierInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceImageDrmFormatModifierInfoEXT"/>.</returns>
        public static VkPhysicalDeviceImageDrmFormatModifierInfoEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceImageDrmFormatModifierInfoEXT);
            var info = (VkPhysicalDeviceImageDrmFormatModifierInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoExt;

            return info;
        }
    }

    // Struct: 261
    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceImageFormatInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceImageFormatInfo2"/>.</returns>
        public static VkPhysicalDeviceImageFormatInfo2* Alloc() {
            int size = sizeof(VkPhysicalDeviceImageFormatInfo2);
            var info = (VkPhysicalDeviceImageFormatInfo2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceImageFormatInfo2;

            return info;
        }
    }

    // Struct: 262
    public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceImageViewImageFormatInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceImageViewImageFormatInfoEXT"/>.</returns>
        public static VkPhysicalDeviceImageViewImageFormatInfoEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceImageViewImageFormatInfoEXT);
            var info = (VkPhysicalDeviceImageViewImageFormatInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceImageViewImageFormatInfoExt;

            return info;
        }
    }

    // Struct: 263
    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceInlineUniformBlockFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceInlineUniformBlockFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceInlineUniformBlockFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceInlineUniformBlockFeaturesEXT);
            var info = (VkPhysicalDeviceInlineUniformBlockFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceInlineUniformBlockFeaturesExt;

            return info;
        }
    }

    // Struct: 264
    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceInlineUniformBlockPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceInlineUniformBlockPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceInlineUniformBlockPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceInlineUniformBlockPropertiesEXT);
            var info = (VkPhysicalDeviceInlineUniformBlockPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceInlineUniformBlockPropertiesExt;

            return info;
        }
    }

    // Struct: 265
    public unsafe partial struct VkPhysicalDeviceLimits {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceLimits"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceLimits"/>.</returns>
        public static VkPhysicalDeviceLimits* Alloc() {
            int size = sizeof(VkPhysicalDeviceLimits);
            var info = (VkPhysicalDeviceLimits*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 266
    public unsafe partial struct VkPhysicalDeviceMaintenance3Properties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMaintenance3Properties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMaintenance3Properties"/>.</returns>
        public static VkPhysicalDeviceMaintenance3Properties* Alloc() {
            int size = sizeof(VkPhysicalDeviceMaintenance3Properties);
            var info = (VkPhysicalDeviceMaintenance3Properties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMaintenance3Properties;

            return info;
        }
    }

    // Struct: 267
    public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMemoryBudgetPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMemoryBudgetPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceMemoryBudgetPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceMemoryBudgetPropertiesEXT);
            var info = (VkPhysicalDeviceMemoryBudgetPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesExt;

            return info;
        }
    }

    // Struct: 268
    public unsafe partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMemoryPriorityFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMemoryPriorityFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceMemoryPriorityFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceMemoryPriorityFeaturesEXT);
            var info = (VkPhysicalDeviceMemoryPriorityFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMemoryPriorityFeaturesExt;

            return info;
        }
    }

    // Struct: 269
    public unsafe partial struct VkPhysicalDeviceMemoryProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMemoryProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMemoryProperties"/>.</returns>
        public static VkPhysicalDeviceMemoryProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceMemoryProperties);
            var info = (VkPhysicalDeviceMemoryProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 270
    public unsafe partial struct VkPhysicalDeviceMemoryProperties2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMemoryProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMemoryProperties2"/>.</returns>
        public static VkPhysicalDeviceMemoryProperties2* Alloc() {
            int size = sizeof(VkPhysicalDeviceMemoryProperties2);
            var info = (VkPhysicalDeviceMemoryProperties2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMemoryProperties2;

            return info;
        }
    }

    // Struct: 271
    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMeshShaderFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMeshShaderFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceMeshShaderFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceMeshShaderFeaturesNV);
            var info = (VkPhysicalDeviceMeshShaderFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesNv;

            return info;
        }
    }

    // Struct: 272
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMeshShaderPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMeshShaderPropertiesNV"/>.</returns>
        public static VkPhysicalDeviceMeshShaderPropertiesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceMeshShaderPropertiesNV);
            var info = (VkPhysicalDeviceMeshShaderPropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesNv;

            return info;
        }
    }

    // Struct: 273
    public unsafe partial struct VkPhysicalDeviceMultiviewFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMultiviewFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMultiviewFeatures"/>.</returns>
        public static VkPhysicalDeviceMultiviewFeatures* Alloc() {
            int size = sizeof(VkPhysicalDeviceMultiviewFeatures);
            var info = (VkPhysicalDeviceMultiviewFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMultiviewFeatures;

            return info;
        }
    }

    // Struct: 274
    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX"/>.</returns>
        public static VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX* Alloc() {
            int size = sizeof(VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX);
            var info = (VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx;

            return info;
        }
    }

    // Struct: 275
    public unsafe partial struct VkPhysicalDeviceMultiviewProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceMultiviewProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceMultiviewProperties"/>.</returns>
        public static VkPhysicalDeviceMultiviewProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceMultiviewProperties);
            var info = (VkPhysicalDeviceMultiviewProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceMultiviewProperties;

            return info;
        }
    }

    // Struct: 276
    public unsafe partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDevicePCIBusInfoPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDevicePCIBusInfoPropertiesEXT"/>.</returns>
        public static VkPhysicalDevicePCIBusInfoPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDevicePCIBusInfoPropertiesEXT);
            var info = (VkPhysicalDevicePCIBusInfoPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDevicePciBusInfoPropertiesExt;

            return info;
        }
    }

    // Struct: 277
    public unsafe partial struct VkPhysicalDevicePointClippingProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDevicePointClippingProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDevicePointClippingProperties"/>.</returns>
        public static VkPhysicalDevicePointClippingProperties* Alloc() {
            int size = sizeof(VkPhysicalDevicePointClippingProperties);
            var info = (VkPhysicalDevicePointClippingProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDevicePointClippingProperties;

            return info;
        }
    }

    // Struct: 278
    public unsafe partial struct VkPhysicalDeviceProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceProperties"/>.</returns>
        public static VkPhysicalDeviceProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceProperties);
            var info = (VkPhysicalDeviceProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 279
    public unsafe partial struct VkPhysicalDeviceProperties2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceProperties2"/>.</returns>
        public static VkPhysicalDeviceProperties2* Alloc() {
            int size = sizeof(VkPhysicalDeviceProperties2);
            var info = (VkPhysicalDeviceProperties2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceProperties2;

            return info;
        }
    }

    // Struct: 280
    public unsafe partial struct VkPhysicalDeviceProtectedMemoryFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceProtectedMemoryFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceProtectedMemoryFeatures"/>.</returns>
        public static VkPhysicalDeviceProtectedMemoryFeatures* Alloc() {
            int size = sizeof(VkPhysicalDeviceProtectedMemoryFeatures);
            var info = (VkPhysicalDeviceProtectedMemoryFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceProtectedMemoryFeatures;

            return info;
        }
    }

    // Struct: 281
    public unsafe partial struct VkPhysicalDeviceProtectedMemoryProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceProtectedMemoryProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceProtectedMemoryProperties"/>.</returns>
        public static VkPhysicalDeviceProtectedMemoryProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceProtectedMemoryProperties);
            var info = (VkPhysicalDeviceProtectedMemoryProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceProtectedMemoryProperties;

            return info;
        }
    }

    // Struct: 282
    public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDevicePushDescriptorPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDevicePushDescriptorPropertiesKHR"/>.</returns>
        public static VkPhysicalDevicePushDescriptorPropertiesKHR* Alloc() {
            int size = sizeof(VkPhysicalDevicePushDescriptorPropertiesKHR);
            var info = (VkPhysicalDevicePushDescriptorPropertiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDevicePushDescriptorPropertiesKHR;

            return info;
        }
    }

    // Struct: 283
    public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceRayTracingPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceRayTracingPropertiesNV"/>.</returns>
        public static VkPhysicalDeviceRayTracingPropertiesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceRayTracingPropertiesNV);
            var info = (VkPhysicalDeviceRayTracingPropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceRayTracingPropertiesNv;

            return info;
        }
    }

    // Struct: 284
    public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV);
            var info = (VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNv;

            return info;
        }
    }

    // Struct: 285
    public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSampleLocationsPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSampleLocationsPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceSampleLocationsPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceSampleLocationsPropertiesEXT);
            var info = (VkPhysicalDeviceSampleLocationsPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceSampleLocationsPropertiesExt;

            return info;
        }
    }

    // Struct: 286
    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT);
            var info = (VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceSamplerFilterMinmaxPropertiesExt;

            return info;
        }
    }

    // Struct: 287
    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSamplerYcbcrConversionFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSamplerYcbcrConversionFeatures"/>.</returns>
        public static VkPhysicalDeviceSamplerYcbcrConversionFeatures* Alloc() {
            int size = sizeof(VkPhysicalDeviceSamplerYcbcrConversionFeatures);
            var info = (VkPhysicalDeviceSamplerYcbcrConversionFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures;

            return info;
        }
    }

    // Struct: 288
    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceScalarBlockLayoutFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceScalarBlockLayoutFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceScalarBlockLayoutFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceScalarBlockLayoutFeaturesEXT);
            var info = (VkPhysicalDeviceScalarBlockLayoutFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceScalarBlockLayoutFeaturesExt;

            return info;
        }
    }

    // Struct: 289
    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceShaderAtomicInt64FeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceShaderAtomicInt64FeaturesKHR"/>.</returns>
        public static VkPhysicalDeviceShaderAtomicInt64FeaturesKHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceShaderAtomicInt64FeaturesKHR);
            var info = (VkPhysicalDeviceShaderAtomicInt64FeaturesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceShaderAtomicInt64FeaturesKHR;

            return info;
        }
    }

    // Struct: 290
    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceShaderCorePropertiesAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceShaderCorePropertiesAMD"/>.</returns>
        public static VkPhysicalDeviceShaderCorePropertiesAMD* Alloc() {
            int size = sizeof(VkPhysicalDeviceShaderCorePropertiesAMD);
            var info = (VkPhysicalDeviceShaderCorePropertiesAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceShaderCorePropertiesAmd;

            return info;
        }
    }

    // Struct: 291
    public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceShaderDrawParametersFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceShaderDrawParametersFeatures"/>.</returns>
        public static VkPhysicalDeviceShaderDrawParametersFeatures* Alloc() {
            int size = sizeof(VkPhysicalDeviceShaderDrawParametersFeatures);
            var info = (VkPhysicalDeviceShaderDrawParametersFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures;

            return info;
        }
    }

    // Struct: 292
    public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceShaderImageFootprintFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceShaderImageFootprintFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceShaderImageFootprintFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceShaderImageFootprintFeaturesNV);
            var info = (VkPhysicalDeviceShaderImageFootprintFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceShaderImageFootprintFeaturesNv;

            return info;
        }
    }

    // Struct: 293
    public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceShadingRateImageFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceShadingRateImageFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceShadingRateImageFeaturesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceShadingRateImageFeaturesNV);
            var info = (VkPhysicalDeviceShadingRateImageFeaturesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNv;

            return info;
        }
    }

    // Struct: 294
    public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceShadingRateImagePropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceShadingRateImagePropertiesNV"/>.</returns>
        public static VkPhysicalDeviceShadingRateImagePropertiesNV* Alloc() {
            int size = sizeof(VkPhysicalDeviceShadingRateImagePropertiesNV);
            var info = (VkPhysicalDeviceShadingRateImagePropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNv;

            return info;
        }
    }

    // Struct: 295
    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSparseImageFormatInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSparseImageFormatInfo2"/>.</returns>
        public static VkPhysicalDeviceSparseImageFormatInfo2* Alloc() {
            int size = sizeof(VkPhysicalDeviceSparseImageFormatInfo2);
            var info = (VkPhysicalDeviceSparseImageFormatInfo2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceSparseImageFormatInfo2;

            return info;
        }
    }

    // Struct: 296
    public unsafe partial struct VkPhysicalDeviceSparseProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSparseProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSparseProperties"/>.</returns>
        public static VkPhysicalDeviceSparseProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceSparseProperties);
            var info = (VkPhysicalDeviceSparseProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 297
    public unsafe partial struct VkPhysicalDeviceSubgroupProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSubgroupProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSubgroupProperties"/>.</returns>
        public static VkPhysicalDeviceSubgroupProperties* Alloc() {
            int size = sizeof(VkPhysicalDeviceSubgroupProperties);
            var info = (VkPhysicalDeviceSubgroupProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceSubgroupProperties;

            return info;
        }
    }

    // Struct: 298
    public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceSurfaceInfo2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceSurfaceInfo2KHR"/>.</returns>
        public static VkPhysicalDeviceSurfaceInfo2KHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceSurfaceInfo2KHR);
            var info = (VkPhysicalDeviceSurfaceInfo2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceSurfaceInfo2KHR;

            return info;
        }
    }

    // Struct: 299
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceTransformFeedbackFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceTransformFeedbackFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceTransformFeedbackFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceTransformFeedbackFeaturesEXT);
            var info = (VkPhysicalDeviceTransformFeedbackFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesExt;

            return info;
        }
    }

    // Struct: 300
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceTransformFeedbackPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceTransformFeedbackPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceTransformFeedbackPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceTransformFeedbackPropertiesEXT);
            var info = (VkPhysicalDeviceTransformFeedbackPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesExt;

            return info;
        }
    }

    // Struct: 301
    public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceVariablePointersFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceVariablePointersFeatures"/>.</returns>
        public static VkPhysicalDeviceVariablePointersFeatures* Alloc() {
            int size = sizeof(VkPhysicalDeviceVariablePointersFeatures);
            var info = (VkPhysicalDeviceVariablePointersFeatures*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceVariablePointersFeatures;

            return info;
        }
    }

    // Struct: 302
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT);
            var info = (VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeaturesExt;

            return info;
        }
    }

    // Struct: 303
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT);
            var info = (VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesExt;

            return info;
        }
    }

    // Struct: 304
    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceVulkanMemoryModelFeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceVulkanMemoryModelFeaturesKHR"/>.</returns>
        public static VkPhysicalDeviceVulkanMemoryModelFeaturesKHR* Alloc() {
            int size = sizeof(VkPhysicalDeviceVulkanMemoryModelFeaturesKHR);
            var info = (VkPhysicalDeviceVulkanMemoryModelFeaturesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceVulkanMemoryModelFeaturesKHR;

            return info;
        }
    }

    // Struct: 305
    public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPhysicalDeviceYcbcrImageArraysFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPhysicalDeviceYcbcrImageArraysFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceYcbcrImageArraysFeaturesEXT* Alloc() {
            int size = sizeof(VkPhysicalDeviceYcbcrImageArraysFeaturesEXT);
            var info = (VkPhysicalDeviceYcbcrImageArraysFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PhysicalDeviceYcbcrImageArraysFeaturesExt;

            return info;
        }
    }

    // Struct: 306
    public unsafe partial struct VkPipelineCacheCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineCacheCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineCacheCreateInfo"/>.</returns>
        public static VkPipelineCacheCreateInfo* Alloc() {
            int size = sizeof(VkPipelineCacheCreateInfo);
            var info = (VkPipelineCacheCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineCacheCreateInfo;

            return info;
        }
    }

    // Struct: 307
    public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineColorBlendAdvancedStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineColorBlendAdvancedStateCreateInfoEXT"/>.</returns>
        public static VkPipelineColorBlendAdvancedStateCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineColorBlendAdvancedStateCreateInfoEXT);
            var info = (VkPipelineColorBlendAdvancedStateCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoExt;

            return info;
        }
    }

    // Struct: 308
    public unsafe partial struct VkPipelineColorBlendAttachmentState {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineColorBlendAttachmentState"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineColorBlendAttachmentState"/>.</returns>
        public static VkPipelineColorBlendAttachmentState* Alloc() {
            int size = sizeof(VkPipelineColorBlendAttachmentState);
            var info = (VkPipelineColorBlendAttachmentState*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 309
    public unsafe partial struct VkPipelineColorBlendStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineColorBlendStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineColorBlendStateCreateInfo"/>.</returns>
        public static VkPipelineColorBlendStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineColorBlendStateCreateInfo);
            var info = (VkPipelineColorBlendStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineColorBlendStateCreateInfo;

            return info;
        }
    }

    // Struct: 310
    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineCoverageModulationStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineCoverageModulationStateCreateInfoNV"/>.</returns>
        public static VkPipelineCoverageModulationStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineCoverageModulationStateCreateInfoNV);
            var info = (VkPipelineCoverageModulationStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineCoverageModulationStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 311
    public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineCoverageToColorStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineCoverageToColorStateCreateInfoNV"/>.</returns>
        public static VkPipelineCoverageToColorStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineCoverageToColorStateCreateInfoNV);
            var info = (VkPipelineCoverageToColorStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineCoverageToColorStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 312
    public unsafe partial struct VkPipelineCreationFeedbackCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineCreationFeedbackCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineCreationFeedbackCreateInfoEXT"/>.</returns>
        public static VkPipelineCreationFeedbackCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineCreationFeedbackCreateInfoEXT);
            var info = (VkPipelineCreationFeedbackCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineCreationFeedbackCreateInfoExt;

            return info;
        }
    }

    // Struct: 313
    public unsafe partial struct VkPipelineCreationFeedbackEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineCreationFeedbackEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineCreationFeedbackEXT"/>.</returns>
        public static VkPipelineCreationFeedbackEXT* Alloc() {
            int size = sizeof(VkPipelineCreationFeedbackEXT);
            var info = (VkPipelineCreationFeedbackEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 314
    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineDepthStencilStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineDepthStencilStateCreateInfo"/>.</returns>
        public static VkPipelineDepthStencilStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineDepthStencilStateCreateInfo);
            var info = (VkPipelineDepthStencilStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineDepthStencilStateCreateInfo;

            return info;
        }
    }

    // Struct: 315
    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineDiscardRectangleStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineDiscardRectangleStateCreateInfoEXT"/>.</returns>
        public static VkPipelineDiscardRectangleStateCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineDiscardRectangleStateCreateInfoEXT);
            var info = (VkPipelineDiscardRectangleStateCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineDiscardRectangleStateCreateInfoExt;

            return info;
        }
    }

    // Struct: 316
    public unsafe partial struct VkPipelineDynamicStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineDynamicStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineDynamicStateCreateInfo"/>.</returns>
        public static VkPipelineDynamicStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineDynamicStateCreateInfo);
            var info = (VkPipelineDynamicStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineDynamicStateCreateInfo;

            return info;
        }
    }

    // Struct: 317
    public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineInputAssemblyStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineInputAssemblyStateCreateInfo"/>.</returns>
        public static VkPipelineInputAssemblyStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineInputAssemblyStateCreateInfo);
            var info = (VkPipelineInputAssemblyStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineInputAssemblyStateCreateInfo;

            return info;
        }
    }

    // Struct: 318
    public unsafe partial struct VkPipelineLayoutCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineLayoutCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineLayoutCreateInfo"/>.</returns>
        public static VkPipelineLayoutCreateInfo* Alloc() {
            int size = sizeof(VkPipelineLayoutCreateInfo);
            var info = (VkPipelineLayoutCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineLayoutCreateInfo;

            return info;
        }
    }

    // Struct: 319
    public unsafe partial struct VkPipelineMultisampleStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineMultisampleStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineMultisampleStateCreateInfo"/>.</returns>
        public static VkPipelineMultisampleStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineMultisampleStateCreateInfo);
            var info = (VkPipelineMultisampleStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineMultisampleStateCreateInfo;

            return info;
        }
    }

    // Struct: 320
    public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineRasterizationConservativeStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineRasterizationConservativeStateCreateInfoEXT"/>.</returns>
        public static VkPipelineRasterizationConservativeStateCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineRasterizationConservativeStateCreateInfoEXT);
            var info = (VkPipelineRasterizationConservativeStateCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineRasterizationConservativeStateCreateInfoExt;

            return info;
        }
    }

    // Struct: 321
    public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineRasterizationDepthClipStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineRasterizationDepthClipStateCreateInfoEXT"/>.</returns>
        public static VkPipelineRasterizationDepthClipStateCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineRasterizationDepthClipStateCreateInfoEXT);
            var info = (VkPipelineRasterizationDepthClipStateCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoExt;

            return info;
        }
    }

    // Struct: 322
    public unsafe partial struct VkPipelineRasterizationStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineRasterizationStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineRasterizationStateCreateInfo"/>.</returns>
        public static VkPipelineRasterizationStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineRasterizationStateCreateInfo);
            var info = (VkPipelineRasterizationStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineRasterizationStateCreateInfo;

            return info;
        }
    }

    // Struct: 323
    public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineRasterizationStateRasterizationOrderAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineRasterizationStateRasterizationOrderAMD"/>.</returns>
        public static VkPipelineRasterizationStateRasterizationOrderAMD* Alloc() {
            int size = sizeof(VkPipelineRasterizationStateRasterizationOrderAMD);
            var info = (VkPipelineRasterizationStateRasterizationOrderAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineRasterizationStateRasterizationOrderAmd;

            return info;
        }
    }

    // Struct: 324
    public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineRasterizationStateStreamCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineRasterizationStateStreamCreateInfoEXT"/>.</returns>
        public static VkPipelineRasterizationStateStreamCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineRasterizationStateStreamCreateInfoEXT);
            var info = (VkPipelineRasterizationStateStreamCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineRasterizationStateStreamCreateInfoExt;

            return info;
        }
    }

    // Struct: 325
    public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineRepresentativeFragmentTestStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineRepresentativeFragmentTestStateCreateInfoNV"/>.</returns>
        public static VkPipelineRepresentativeFragmentTestStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineRepresentativeFragmentTestStateCreateInfoNV);
            var info = (VkPipelineRepresentativeFragmentTestStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 326
    public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineSampleLocationsStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineSampleLocationsStateCreateInfoEXT"/>.</returns>
        public static VkPipelineSampleLocationsStateCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineSampleLocationsStateCreateInfoEXT);
            var info = (VkPipelineSampleLocationsStateCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineSampleLocationsStateCreateInfoExt;

            return info;
        }
    }

    // Struct: 327
    public unsafe partial struct VkPipelineShaderStageCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineShaderStageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineShaderStageCreateInfo"/>.</returns>
        public static VkPipelineShaderStageCreateInfo* Alloc() {
            int size = sizeof(VkPipelineShaderStageCreateInfo);
            var info = (VkPipelineShaderStageCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineShaderStageCreateInfo;

            return info;
        }
    }

    // Struct: 328
    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineTessellationDomainOriginStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineTessellationDomainOriginStateCreateInfo"/>.</returns>
        public static VkPipelineTessellationDomainOriginStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineTessellationDomainOriginStateCreateInfo);
            var info = (VkPipelineTessellationDomainOriginStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo;

            return info;
        }
    }

    // Struct: 329
    public unsafe partial struct VkPipelineTessellationStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineTessellationStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineTessellationStateCreateInfo"/>.</returns>
        public static VkPipelineTessellationStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineTessellationStateCreateInfo);
            var info = (VkPipelineTessellationStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineTessellationStateCreateInfo;

            return info;
        }
    }

    // Struct: 330
    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineVertexInputDivisorStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineVertexInputDivisorStateCreateInfoEXT"/>.</returns>
        public static VkPipelineVertexInputDivisorStateCreateInfoEXT* Alloc() {
            int size = sizeof(VkPipelineVertexInputDivisorStateCreateInfoEXT);
            var info = (VkPipelineVertexInputDivisorStateCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineVertexInputDivisorStateCreateInfoExt;

            return info;
        }
    }

    // Struct: 331
    public unsafe partial struct VkPipelineVertexInputStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineVertexInputStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineVertexInputStateCreateInfo"/>.</returns>
        public static VkPipelineVertexInputStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineVertexInputStateCreateInfo);
            var info = (VkPipelineVertexInputStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineVertexInputStateCreateInfo;

            return info;
        }
    }

    // Struct: 332
    public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineViewportCoarseSampleOrderStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineViewportCoarseSampleOrderStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportCoarseSampleOrderStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineViewportCoarseSampleOrderStateCreateInfoNV);
            var info = (VkPipelineViewportCoarseSampleOrderStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 333
    public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineViewportExclusiveScissorStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineViewportExclusiveScissorStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportExclusiveScissorStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineViewportExclusiveScissorStateCreateInfoNV);
            var info = (VkPipelineViewportExclusiveScissorStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 334
    public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineViewportShadingRateImageStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineViewportShadingRateImageStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportShadingRateImageStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineViewportShadingRateImageStateCreateInfoNV);
            var info = (VkPipelineViewportShadingRateImageStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 335
    public unsafe partial struct VkPipelineViewportStateCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineViewportStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineViewportStateCreateInfo"/>.</returns>
        public static VkPipelineViewportStateCreateInfo* Alloc() {
            int size = sizeof(VkPipelineViewportStateCreateInfo);
            var info = (VkPipelineViewportStateCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineViewportStateCreateInfo;

            return info;
        }
    }

    // Struct: 336
    public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineViewportSwizzleStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineViewportSwizzleStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportSwizzleStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineViewportSwizzleStateCreateInfoNV);
            var info = (VkPipelineViewportSwizzleStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineViewportSwizzleStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 337
    public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkPipelineViewportWScalingStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPipelineViewportWScalingStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportWScalingStateCreateInfoNV* Alloc() {
            int size = sizeof(VkPipelineViewportWScalingStateCreateInfoNV);
            var info = (VkPipelineViewportWScalingStateCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PipelineViewportWScalingStateCreateInfoNv;

            return info;
        }
    }

    // Struct: 338
    public unsafe partial struct VkPresentFrameTokenGGP {
        /// <summary>
        /// Allocate an instance of <see cref="VkPresentFrameTokenGGP"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPresentFrameTokenGGP"/>.</returns>
        public static VkPresentFrameTokenGGP* Alloc() {
            int size = sizeof(VkPresentFrameTokenGGP);
            var info = (VkPresentFrameTokenGGP*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PresentFrameTokenGgp;

            return info;
        }
    }

    // Struct: 339
    public unsafe partial struct VkPresentInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPresentInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPresentInfoKHR"/>.</returns>
        public static VkPresentInfoKHR* Alloc() {
            int size = sizeof(VkPresentInfoKHR);
            var info = (VkPresentInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PresentInfoKHR;

            return info;
        }
    }

    // Struct: 340
    public unsafe partial struct VkPresentRegionKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPresentRegionKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPresentRegionKHR"/>.</returns>
        public static VkPresentRegionKHR* Alloc() {
            int size = sizeof(VkPresentRegionKHR);
            var info = (VkPresentRegionKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 341
    public unsafe partial struct VkPresentRegionsKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkPresentRegionsKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPresentRegionsKHR"/>.</returns>
        public static VkPresentRegionsKHR* Alloc() {
            int size = sizeof(VkPresentRegionsKHR);
            var info = (VkPresentRegionsKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PresentRegionsKHR;

            return info;
        }
    }

    // Struct: 342
    public unsafe partial struct VkPresentTimeGOOGLE {
        /// <summary>
        /// Allocate an instance of <see cref="VkPresentTimeGOOGLE"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPresentTimeGOOGLE"/>.</returns>
        public static VkPresentTimeGOOGLE* Alloc() {
            int size = sizeof(VkPresentTimeGOOGLE);
            var info = (VkPresentTimeGOOGLE*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 343
    public unsafe partial struct VkPresentTimesInfoGOOGLE {
        /// <summary>
        /// Allocate an instance of <see cref="VkPresentTimesInfoGOOGLE"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPresentTimesInfoGOOGLE"/>.</returns>
        public static VkPresentTimesInfoGOOGLE* Alloc() {
            int size = sizeof(VkPresentTimesInfoGOOGLE);
            var info = (VkPresentTimesInfoGOOGLE*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.PresentTimesInfoGoogle;

            return info;
        }
    }

    // Struct: 344
    public unsafe partial struct VkProtectedSubmitInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkProtectedSubmitInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkProtectedSubmitInfo"/>.</returns>
        public static VkProtectedSubmitInfo* Alloc() {
            int size = sizeof(VkProtectedSubmitInfo);
            var info = (VkProtectedSubmitInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ProtectedSubmitInfo;

            return info;
        }
    }

    // Struct: 345
    public unsafe partial struct VkPushConstantRange {
        /// <summary>
        /// Allocate an instance of <see cref="VkPushConstantRange"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkPushConstantRange"/>.</returns>
        public static VkPushConstantRange* Alloc() {
            int size = sizeof(VkPushConstantRange);
            var info = (VkPushConstantRange*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 346
    public unsafe partial struct VkQueryPoolCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkQueryPoolCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkQueryPoolCreateInfo"/>.</returns>
        public static VkQueryPoolCreateInfo* Alloc() {
            int size = sizeof(VkQueryPoolCreateInfo);
            var info = (VkQueryPoolCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.QueryPoolCreateInfo;

            return info;
        }
    }

    // Struct: 347
    public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkQueueFamilyCheckpointPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkQueueFamilyCheckpointPropertiesNV"/>.</returns>
        public static VkQueueFamilyCheckpointPropertiesNV* Alloc() {
            int size = sizeof(VkQueueFamilyCheckpointPropertiesNV);
            var info = (VkQueueFamilyCheckpointPropertiesNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.QueueFamilyCheckpointPropertiesNv;

            return info;
        }
    }

    // Struct: 348
    public unsafe partial struct VkQueueFamilyProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkQueueFamilyProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkQueueFamilyProperties"/>.</returns>
        public static VkQueueFamilyProperties* Alloc() {
            int size = sizeof(VkQueueFamilyProperties);
            var info = (VkQueueFamilyProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 349
    public unsafe partial struct VkQueueFamilyProperties2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkQueueFamilyProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkQueueFamilyProperties2"/>.</returns>
        public static VkQueueFamilyProperties2* Alloc() {
            int size = sizeof(VkQueueFamilyProperties2);
            var info = (VkQueueFamilyProperties2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.QueueFamilyProperties2;

            return info;
        }
    }

    // Struct: 350
    public unsafe partial struct VkRayTracingPipelineCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkRayTracingPipelineCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRayTracingPipelineCreateInfoNV"/>.</returns>
        public static VkRayTracingPipelineCreateInfoNV* Alloc() {
            int size = sizeof(VkRayTracingPipelineCreateInfoNV);
            var info = (VkRayTracingPipelineCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RayTracingPipelineCreateInfoNv;

            return info;
        }
    }

    // Struct: 351
    public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkRayTracingShaderGroupCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRayTracingShaderGroupCreateInfoNV"/>.</returns>
        public static VkRayTracingShaderGroupCreateInfoNV* Alloc() {
            int size = sizeof(VkRayTracingShaderGroupCreateInfoNV);
            var info = (VkRayTracingShaderGroupCreateInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RayTracingShaderGroupCreateInfoNv;

            return info;
        }
    }

    // Struct: 352
    public unsafe partial struct VkRect2D {
        /// <summary>
        /// Allocate an instance of <see cref="VkRect2D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRect2D"/>.</returns>
        public static VkRect2D* Alloc() {
            int size = sizeof(VkRect2D);
            var info = (VkRect2D*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 353
    public unsafe partial struct VkRectLayerKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkRectLayerKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRectLayerKHR"/>.</returns>
        public static VkRectLayerKHR* Alloc() {
            int size = sizeof(VkRectLayerKHR);
            var info = (VkRectLayerKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 354
    public unsafe partial struct VkRefreshCycleDurationGOOGLE {
        /// <summary>
        /// Allocate an instance of <see cref="VkRefreshCycleDurationGOOGLE"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRefreshCycleDurationGOOGLE"/>.</returns>
        public static VkRefreshCycleDurationGOOGLE* Alloc() {
            int size = sizeof(VkRefreshCycleDurationGOOGLE);
            var info = (VkRefreshCycleDurationGOOGLE*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 355
    public unsafe partial struct VkRenderPassBeginInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassBeginInfo"/>.</returns>
        public static VkRenderPassBeginInfo* Alloc() {
            int size = sizeof(VkRenderPassBeginInfo);
            var info = (VkRenderPassBeginInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassBeginInfo;

            return info;
        }
    }

    // Struct: 356
    public unsafe partial struct VkRenderPassCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassCreateInfo"/>.</returns>
        public static VkRenderPassCreateInfo* Alloc() {
            int size = sizeof(VkRenderPassCreateInfo);
            var info = (VkRenderPassCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassCreateInfo;

            return info;
        }
    }

    // Struct: 357
    public unsafe partial struct VkRenderPassCreateInfo2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassCreateInfo2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassCreateInfo2KHR"/>.</returns>
        public static VkRenderPassCreateInfo2KHR* Alloc() {
            int size = sizeof(VkRenderPassCreateInfo2KHR);
            var info = (VkRenderPassCreateInfo2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassCreateInfo2KHR;

            return info;
        }
    }

    // Struct: 358
    public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassFragmentDensityMapCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassFragmentDensityMapCreateInfoEXT"/>.</returns>
        public static VkRenderPassFragmentDensityMapCreateInfoEXT* Alloc() {
            int size = sizeof(VkRenderPassFragmentDensityMapCreateInfoEXT);
            var info = (VkRenderPassFragmentDensityMapCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassFragmentDensityMapCreateInfoExt;

            return info;
        }
    }

    // Struct: 359
    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassInputAttachmentAspectCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassInputAttachmentAspectCreateInfo"/>.</returns>
        public static VkRenderPassInputAttachmentAspectCreateInfo* Alloc() {
            int size = sizeof(VkRenderPassInputAttachmentAspectCreateInfo);
            var info = (VkRenderPassInputAttachmentAspectCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassInputAttachmentAspectCreateInfo;

            return info;
        }
    }

    // Struct: 360
    public unsafe partial struct VkRenderPassMultiviewCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassMultiviewCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassMultiviewCreateInfo"/>.</returns>
        public static VkRenderPassMultiviewCreateInfo* Alloc() {
            int size = sizeof(VkRenderPassMultiviewCreateInfo);
            var info = (VkRenderPassMultiviewCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassMultiviewCreateInfo;

            return info;
        }
    }

    // Struct: 361
    public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkRenderPassSampleLocationsBeginInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkRenderPassSampleLocationsBeginInfoEXT"/>.</returns>
        public static VkRenderPassSampleLocationsBeginInfoEXT* Alloc() {
            int size = sizeof(VkRenderPassSampleLocationsBeginInfoEXT);
            var info = (VkRenderPassSampleLocationsBeginInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.RenderPassSampleLocationsBeginInfoExt;

            return info;
        }
    }

    // Struct: 362
    public unsafe partial struct VkSampleLocationEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSampleLocationEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSampleLocationEXT"/>.</returns>
        public static VkSampleLocationEXT* Alloc() {
            int size = sizeof(VkSampleLocationEXT);
            var info = (VkSampleLocationEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 363
    public unsafe partial struct VkSampleLocationsInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSampleLocationsInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSampleLocationsInfoEXT"/>.</returns>
        public static VkSampleLocationsInfoEXT* Alloc() {
            int size = sizeof(VkSampleLocationsInfoEXT);
            var info = (VkSampleLocationsInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SampleLocationsInfoExt;

            return info;
        }
    }

    // Struct: 364
    public unsafe partial struct VkSamplerCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSamplerCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSamplerCreateInfo"/>.</returns>
        public static VkSamplerCreateInfo* Alloc() {
            int size = sizeof(VkSamplerCreateInfo);
            var info = (VkSamplerCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SamplerCreateInfo;

            return info;
        }
    }

    // Struct: 365
    public unsafe partial struct VkSamplerReductionModeCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSamplerReductionModeCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSamplerReductionModeCreateInfoEXT"/>.</returns>
        public static VkSamplerReductionModeCreateInfoEXT* Alloc() {
            int size = sizeof(VkSamplerReductionModeCreateInfoEXT);
            var info = (VkSamplerReductionModeCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SamplerReductionModeCreateInfoExt;

            return info;
        }
    }

    // Struct: 366
    public unsafe partial struct VkSamplerYcbcrConversionCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSamplerYcbcrConversionCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSamplerYcbcrConversionCreateInfo"/>.</returns>
        public static VkSamplerYcbcrConversionCreateInfo* Alloc() {
            int size = sizeof(VkSamplerYcbcrConversionCreateInfo);
            var info = (VkSamplerYcbcrConversionCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SamplerYcbcrConversionCreateInfo;

            return info;
        }
    }

    // Struct: 367
    public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkSamplerYcbcrConversionImageFormatProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSamplerYcbcrConversionImageFormatProperties"/>.</returns>
        public static VkSamplerYcbcrConversionImageFormatProperties* Alloc() {
            int size = sizeof(VkSamplerYcbcrConversionImageFormatProperties);
            var info = (VkSamplerYcbcrConversionImageFormatProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SamplerYcbcrConversionImageFormatProperties;

            return info;
        }
    }

    // Struct: 368
    public unsafe partial struct VkSamplerYcbcrConversionInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSamplerYcbcrConversionInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSamplerYcbcrConversionInfo"/>.</returns>
        public static VkSamplerYcbcrConversionInfo* Alloc() {
            int size = sizeof(VkSamplerYcbcrConversionInfo);
            var info = (VkSamplerYcbcrConversionInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SamplerYcbcrConversionInfo;

            return info;
        }
    }

    // Struct: 369
    public unsafe partial struct VkSemaphoreCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSemaphoreCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSemaphoreCreateInfo"/>.</returns>
        public static VkSemaphoreCreateInfo* Alloc() {
            int size = sizeof(VkSemaphoreCreateInfo);
            var info = (VkSemaphoreCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SemaphoreCreateInfo;

            return info;
        }
    }

    // Struct: 370
    public unsafe partial struct VkSemaphoreGetFdInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSemaphoreGetFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSemaphoreGetFdInfoKHR"/>.</returns>
        public static VkSemaphoreGetFdInfoKHR* Alloc() {
            int size = sizeof(VkSemaphoreGetFdInfoKHR);
            var info = (VkSemaphoreGetFdInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SemaphoreGetFdInfoKHR;

            return info;
        }
    }

    // Struct: 371
    public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSemaphoreGetWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSemaphoreGetWin32HandleInfoKHR"/>.</returns>
        public static VkSemaphoreGetWin32HandleInfoKHR* Alloc() {
            int size = sizeof(VkSemaphoreGetWin32HandleInfoKHR);
            var info = (VkSemaphoreGetWin32HandleInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SemaphoreGetWin32HandleInfoKHR;

            return info;
        }
    }

    // Struct: 372
    public unsafe partial struct VkShaderModuleCreateInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkShaderModuleCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkShaderModuleCreateInfo"/>.</returns>
        public static VkShaderModuleCreateInfo* Alloc() {
            int size = sizeof(VkShaderModuleCreateInfo);
            var info = (VkShaderModuleCreateInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ShaderModuleCreateInfo;

            return info;
        }
    }

    // Struct: 373
    public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkShaderModuleValidationCacheCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkShaderModuleValidationCacheCreateInfoEXT"/>.</returns>
        public static VkShaderModuleValidationCacheCreateInfoEXT* Alloc() {
            int size = sizeof(VkShaderModuleValidationCacheCreateInfoEXT);
            var info = (VkShaderModuleValidationCacheCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ShaderModuleValidationCacheCreateInfoExt;

            return info;
        }
    }

    // Struct: 374
    public unsafe partial struct VkShaderResourceUsageAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkShaderResourceUsageAMD"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkShaderResourceUsageAMD"/>.</returns>
        public static VkShaderResourceUsageAMD* Alloc() {
            int size = sizeof(VkShaderResourceUsageAMD);
            var info = (VkShaderResourceUsageAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 375
    public unsafe partial struct VkShaderStatisticsInfoAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkShaderStatisticsInfoAMD"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkShaderStatisticsInfoAMD"/>.</returns>
        public static VkShaderStatisticsInfoAMD* Alloc() {
            int size = sizeof(VkShaderStatisticsInfoAMD);
            var info = (VkShaderStatisticsInfoAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 376
    public unsafe partial struct VkShadingRatePaletteNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkShadingRatePaletteNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkShadingRatePaletteNV"/>.</returns>
        public static VkShadingRatePaletteNV* Alloc() {
            int size = sizeof(VkShadingRatePaletteNV);
            var info = (VkShadingRatePaletteNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 377
    public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSharedPresentSurfaceCapabilitiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSharedPresentSurfaceCapabilitiesKHR"/>.</returns>
        public static VkSharedPresentSurfaceCapabilitiesKHR* Alloc() {
            int size = sizeof(VkSharedPresentSurfaceCapabilitiesKHR);
            var info = (VkSharedPresentSurfaceCapabilitiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SharedPresentSurfaceCapabilitiesKHR;

            return info;
        }
    }

    // Struct: 378
    public unsafe partial struct VkSparseBufferMemoryBindInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseBufferMemoryBindInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseBufferMemoryBindInfo"/>.</returns>
        public static VkSparseBufferMemoryBindInfo* Alloc() {
            int size = sizeof(VkSparseBufferMemoryBindInfo);
            var info = (VkSparseBufferMemoryBindInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 379
    public unsafe partial struct VkSparseImageFormatProperties {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageFormatProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageFormatProperties"/>.</returns>
        public static VkSparseImageFormatProperties* Alloc() {
            int size = sizeof(VkSparseImageFormatProperties);
            var info = (VkSparseImageFormatProperties*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 380
    public unsafe partial struct VkSparseImageFormatProperties2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageFormatProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageFormatProperties2"/>.</returns>
        public static VkSparseImageFormatProperties2* Alloc() {
            int size = sizeof(VkSparseImageFormatProperties2);
            var info = (VkSparseImageFormatProperties2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SparseImageFormatProperties2;

            return info;
        }
    }

    // Struct: 381
    public unsafe partial struct VkSparseImageMemoryBind {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageMemoryBind"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageMemoryBind"/>.</returns>
        public static VkSparseImageMemoryBind* Alloc() {
            int size = sizeof(VkSparseImageMemoryBind);
            var info = (VkSparseImageMemoryBind*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 382
    public unsafe partial struct VkSparseImageMemoryBindInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageMemoryBindInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageMemoryBindInfo"/>.</returns>
        public static VkSparseImageMemoryBindInfo* Alloc() {
            int size = sizeof(VkSparseImageMemoryBindInfo);
            var info = (VkSparseImageMemoryBindInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 383
    public unsafe partial struct VkSparseImageMemoryRequirements {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageMemoryRequirements"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageMemoryRequirements"/>.</returns>
        public static VkSparseImageMemoryRequirements* Alloc() {
            int size = sizeof(VkSparseImageMemoryRequirements);
            var info = (VkSparseImageMemoryRequirements*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 384
    public unsafe partial struct VkSparseImageMemoryRequirements2 {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageMemoryRequirements2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageMemoryRequirements2"/>.</returns>
        public static VkSparseImageMemoryRequirements2* Alloc() {
            int size = sizeof(VkSparseImageMemoryRequirements2);
            var info = (VkSparseImageMemoryRequirements2*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SparseImageMemoryRequirements2;

            return info;
        }
    }

    // Struct: 385
    public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseImageOpaqueMemoryBindInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseImageOpaqueMemoryBindInfo"/>.</returns>
        public static VkSparseImageOpaqueMemoryBindInfo* Alloc() {
            int size = sizeof(VkSparseImageOpaqueMemoryBindInfo);
            var info = (VkSparseImageOpaqueMemoryBindInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 386
    public unsafe partial struct VkSparseMemoryBind {
        /// <summary>
        /// Allocate an instance of <see cref="VkSparseMemoryBind"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSparseMemoryBind"/>.</returns>
        public static VkSparseMemoryBind* Alloc() {
            int size = sizeof(VkSparseMemoryBind);
            var info = (VkSparseMemoryBind*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 387
    public unsafe partial struct VkSpecializationInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSpecializationInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSpecializationInfo"/>.</returns>
        public static VkSpecializationInfo* Alloc() {
            int size = sizeof(VkSpecializationInfo);
            var info = (VkSpecializationInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 388
    public unsafe partial struct VkSpecializationMapEntry {
        /// <summary>
        /// Allocate an instance of <see cref="VkSpecializationMapEntry"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSpecializationMapEntry"/>.</returns>
        public static VkSpecializationMapEntry* Alloc() {
            int size = sizeof(VkSpecializationMapEntry);
            var info = (VkSpecializationMapEntry*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 389
    public unsafe partial struct VkStencilOpState {
        /// <summary>
        /// Allocate an instance of <see cref="VkStencilOpState"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkStencilOpState"/>.</returns>
        public static VkStencilOpState* Alloc() {
            int size = sizeof(VkStencilOpState);
            var info = (VkStencilOpState*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 390
    public unsafe partial struct VkStreamDescriptorSurfaceCreateInfoGGP {
        /// <summary>
        /// Allocate an instance of <see cref="VkStreamDescriptorSurfaceCreateInfoGGP"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkStreamDescriptorSurfaceCreateInfoGGP"/>.</returns>
        public static VkStreamDescriptorSurfaceCreateInfoGGP* Alloc() {
            int size = sizeof(VkStreamDescriptorSurfaceCreateInfoGGP);
            var info = (VkStreamDescriptorSurfaceCreateInfoGGP*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.StreamDescriptorSurfaceCreateInfoGgp;

            return info;
        }
    }

    // Struct: 391
    public unsafe partial struct VkSubmitInfo {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubmitInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubmitInfo"/>.</returns>
        public static VkSubmitInfo* Alloc() {
            int size = sizeof(VkSubmitInfo);
            var info = (VkSubmitInfo*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SubmitInfo;

            return info;
        }
    }

    // Struct: 392
    public unsafe partial struct VkSubpassBeginInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassBeginInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassBeginInfoKHR"/>.</returns>
        public static VkSubpassBeginInfoKHR* Alloc() {
            int size = sizeof(VkSubpassBeginInfoKHR);
            var info = (VkSubpassBeginInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SubpassBeginInfoKHR;

            return info;
        }
    }

    // Struct: 393
    public unsafe partial struct VkSubpassDependency {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassDependency"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassDependency"/>.</returns>
        public static VkSubpassDependency* Alloc() {
            int size = sizeof(VkSubpassDependency);
            var info = (VkSubpassDependency*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 394
    public unsafe partial struct VkSubpassDependency2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassDependency2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassDependency2KHR"/>.</returns>
        public static VkSubpassDependency2KHR* Alloc() {
            int size = sizeof(VkSubpassDependency2KHR);
            var info = (VkSubpassDependency2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SubpassDependency2KHR;

            return info;
        }
    }

    // Struct: 395
    public unsafe partial struct VkSubpassDescription {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassDescription"/>.</returns>
        public static VkSubpassDescription* Alloc() {
            int size = sizeof(VkSubpassDescription);
            var info = (VkSubpassDescription*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 396
    public unsafe partial struct VkSubpassDescription2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassDescription2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassDescription2KHR"/>.</returns>
        public static VkSubpassDescription2KHR* Alloc() {
            int size = sizeof(VkSubpassDescription2KHR);
            var info = (VkSubpassDescription2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SubpassDescription2KHR;

            return info;
        }
    }

    // Struct: 397
    public unsafe partial struct VkSubpassDescriptionDepthStencilResolveKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassDescriptionDepthStencilResolveKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassDescriptionDepthStencilResolveKHR"/>.</returns>
        public static VkSubpassDescriptionDepthStencilResolveKHR* Alloc() {
            int size = sizeof(VkSubpassDescriptionDepthStencilResolveKHR);
            var info = (VkSubpassDescriptionDepthStencilResolveKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SubpassDescriptionDepthStencilResolveKHR;

            return info;
        }
    }

    // Struct: 398
    public unsafe partial struct VkSubpassEndInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassEndInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassEndInfoKHR"/>.</returns>
        public static VkSubpassEndInfoKHR* Alloc() {
            int size = sizeof(VkSubpassEndInfoKHR);
            var info = (VkSubpassEndInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SubpassEndInfoKHR;

            return info;
        }
    }

    // Struct: 399
    public unsafe partial struct VkSubpassSampleLocationsEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubpassSampleLocationsEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubpassSampleLocationsEXT"/>.</returns>
        public static VkSubpassSampleLocationsEXT* Alloc() {
            int size = sizeof(VkSubpassSampleLocationsEXT);
            var info = (VkSubpassSampleLocationsEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 400
    public unsafe partial struct VkSubresourceLayout {
        /// <summary>
        /// Allocate an instance of <see cref="VkSubresourceLayout"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSubresourceLayout"/>.</returns>
        public static VkSubresourceLayout* Alloc() {
            int size = sizeof(VkSubresourceLayout);
            var info = (VkSubresourceLayout*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 401
    public unsafe partial struct VkSurfaceCapabilities2EXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceCapabilities2EXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceCapabilities2EXT"/>.</returns>
        public static VkSurfaceCapabilities2EXT* Alloc() {
            int size = sizeof(VkSurfaceCapabilities2EXT);
            var info = (VkSurfaceCapabilities2EXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceCapabilities2Ext;

            return info;
        }
    }

    // Struct: 402
    public unsafe partial struct VkSurfaceCapabilities2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceCapabilities2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceCapabilities2KHR"/>.</returns>
        public static VkSurfaceCapabilities2KHR* Alloc() {
            int size = sizeof(VkSurfaceCapabilities2KHR);
            var info = (VkSurfaceCapabilities2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceCapabilities2KHR;

            return info;
        }
    }

    // Struct: 403
    public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceCapabilitiesFullScreenExclusiveEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceCapabilitiesFullScreenExclusiveEXT"/>.</returns>
        public static VkSurfaceCapabilitiesFullScreenExclusiveEXT* Alloc() {
            int size = sizeof(VkSurfaceCapabilitiesFullScreenExclusiveEXT);
            var info = (VkSurfaceCapabilitiesFullScreenExclusiveEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveExt;

            return info;
        }
    }

    // Struct: 404
    public unsafe partial struct VkSurfaceCapabilitiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceCapabilitiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceCapabilitiesKHR"/>.</returns>
        public static VkSurfaceCapabilitiesKHR* Alloc() {
            int size = sizeof(VkSurfaceCapabilitiesKHR);
            var info = (VkSurfaceCapabilitiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 405
    public unsafe partial struct VkSurfaceFormat2KHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceFormat2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceFormat2KHR"/>.</returns>
        public static VkSurfaceFormat2KHR* Alloc() {
            int size = sizeof(VkSurfaceFormat2KHR);
            var info = (VkSurfaceFormat2KHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceFormat2KHR;

            return info;
        }
    }

    // Struct: 406
    public unsafe partial struct VkSurfaceFormatKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceFormatKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceFormatKHR"/>.</returns>
        public static VkSurfaceFormatKHR* Alloc() {
            int size = sizeof(VkSurfaceFormatKHR);
            var info = (VkSurfaceFormatKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 407
    public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceFullScreenExclusiveInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceFullScreenExclusiveInfoEXT"/>.</returns>
        public static VkSurfaceFullScreenExclusiveInfoEXT* Alloc() {
            int size = sizeof(VkSurfaceFullScreenExclusiveInfoEXT);
            var info = (VkSurfaceFullScreenExclusiveInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceFullScreenExclusiveInfoExt;

            return info;
        }
    }

    // Struct: 408
    public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceFullScreenExclusiveWin32InfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceFullScreenExclusiveWin32InfoEXT"/>.</returns>
        public static VkSurfaceFullScreenExclusiveWin32InfoEXT* Alloc() {
            int size = sizeof(VkSurfaceFullScreenExclusiveWin32InfoEXT);
            var info = (VkSurfaceFullScreenExclusiveWin32InfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceFullScreenExclusiveWin32InfoExt;

            return info;
        }
    }

    // Struct: 409
    public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSurfaceProtectedCapabilitiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSurfaceProtectedCapabilitiesKHR"/>.</returns>
        public static VkSurfaceProtectedCapabilitiesKHR* Alloc() {
            int size = sizeof(VkSurfaceProtectedCapabilitiesKHR);
            var info = (VkSurfaceProtectedCapabilitiesKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SurfaceProtectedCapabilitiesKHR;

            return info;
        }
    }

    // Struct: 410
    public unsafe partial struct VkSwapchainCounterCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkSwapchainCounterCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSwapchainCounterCreateInfoEXT"/>.</returns>
        public static VkSwapchainCounterCreateInfoEXT* Alloc() {
            int size = sizeof(VkSwapchainCounterCreateInfoEXT);
            var info = (VkSwapchainCounterCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SwapchainCounterCreateInfoExt;

            return info;
        }
    }

    // Struct: 411
    public unsafe partial struct VkSwapchainCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkSwapchainCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSwapchainCreateInfoKHR"/>.</returns>
        public static VkSwapchainCreateInfoKHR* Alloc() {
            int size = sizeof(VkSwapchainCreateInfoKHR);
            var info = (VkSwapchainCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SwapchainCreateInfoKHR;

            return info;
        }
    }

    // Struct: 412
    public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkSwapchainDisplayNativeHdrCreateInfoAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkSwapchainDisplayNativeHdrCreateInfoAMD"/>.</returns>
        public static VkSwapchainDisplayNativeHdrCreateInfoAMD* Alloc() {
            int size = sizeof(VkSwapchainDisplayNativeHdrCreateInfoAMD);
            var info = (VkSwapchainDisplayNativeHdrCreateInfoAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAmd;

            return info;
        }
    }

    // Struct: 413
    public unsafe partial struct VkTextureLODGatherFormatPropertiesAMD {
        /// <summary>
        /// Allocate an instance of <see cref="VkTextureLODGatherFormatPropertiesAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkTextureLODGatherFormatPropertiesAMD"/>.</returns>
        public static VkTextureLODGatherFormatPropertiesAMD* Alloc() {
            int size = sizeof(VkTextureLODGatherFormatPropertiesAMD);
            var info = (VkTextureLODGatherFormatPropertiesAMD*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.TextureLodGatherFormatPropertiesAmd;

            return info;
        }
    }

    // Struct: 414
    public unsafe partial struct VkValidationCacheCreateInfoEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkValidationCacheCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkValidationCacheCreateInfoEXT"/>.</returns>
        public static VkValidationCacheCreateInfoEXT* Alloc() {
            int size = sizeof(VkValidationCacheCreateInfoEXT);
            var info = (VkValidationCacheCreateInfoEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ValidationCacheCreateInfoExt;

            return info;
        }
    }

    // Struct: 415
    public unsafe partial struct VkValidationFeaturesEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkValidationFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkValidationFeaturesEXT"/>.</returns>
        public static VkValidationFeaturesEXT* Alloc() {
            int size = sizeof(VkValidationFeaturesEXT);
            var info = (VkValidationFeaturesEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ValidationFeaturesExt;

            return info;
        }
    }

    // Struct: 416
    public unsafe partial struct VkValidationFlagsEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkValidationFlagsEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkValidationFlagsEXT"/>.</returns>
        public static VkValidationFlagsEXT* Alloc() {
            int size = sizeof(VkValidationFlagsEXT);
            var info = (VkValidationFlagsEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ValidationFlagsExt;

            return info;
        }
    }

    // Struct: 417
    public unsafe partial struct VkVertexInputAttributeDescription {
        /// <summary>
        /// Allocate an instance of <see cref="VkVertexInputAttributeDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkVertexInputAttributeDescription"/>.</returns>
        public static VkVertexInputAttributeDescription* Alloc() {
            int size = sizeof(VkVertexInputAttributeDescription);
            var info = (VkVertexInputAttributeDescription*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 418
    public unsafe partial struct VkVertexInputBindingDescription {
        /// <summary>
        /// Allocate an instance of <see cref="VkVertexInputBindingDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkVertexInputBindingDescription"/>.</returns>
        public static VkVertexInputBindingDescription* Alloc() {
            int size = sizeof(VkVertexInputBindingDescription);
            var info = (VkVertexInputBindingDescription*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 419
    public unsafe partial struct VkVertexInputBindingDivisorDescriptionEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkVertexInputBindingDivisorDescriptionEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkVertexInputBindingDivisorDescriptionEXT"/>.</returns>
        public static VkVertexInputBindingDivisorDescriptionEXT* Alloc() {
            int size = sizeof(VkVertexInputBindingDivisorDescriptionEXT);
            var info = (VkVertexInputBindingDivisorDescriptionEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 420
    public unsafe partial struct VkViSurfaceCreateInfoNN {
        /// <summary>
        /// Allocate an instance of <see cref="VkViSurfaceCreateInfoNN"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkViSurfaceCreateInfoNN"/>.</returns>
        public static VkViSurfaceCreateInfoNN* Alloc() {
            int size = sizeof(VkViSurfaceCreateInfoNN);
            var info = (VkViSurfaceCreateInfoNN*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.ViSurfaceCreateInfoNn;

            return info;
        }
    }

    // Struct: 421
    public unsafe partial struct VkViewport {
        /// <summary>
        /// Allocate an instance of <see cref="VkViewport"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkViewport"/>.</returns>
        public static VkViewport* Alloc() {
            int size = sizeof(VkViewport);
            var info = (VkViewport*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 422
    public unsafe partial struct VkViewportSwizzleNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkViewportSwizzleNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkViewportSwizzleNV"/>.</returns>
        public static VkViewportSwizzleNV* Alloc() {
            int size = sizeof(VkViewportSwizzleNV);
            var info = (VkViewportSwizzleNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 423
    public unsafe partial struct VkViewportWScalingNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkViewportWScalingNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkViewportWScalingNV"/>.</returns>
        public static VkViewportWScalingNV* Alloc() {
            int size = sizeof(VkViewportWScalingNV);
            var info = (VkViewportWScalingNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 424
    public unsafe partial struct VkWaylandSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkWaylandSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWaylandSurfaceCreateInfoKHR"/>.</returns>
        public static VkWaylandSurfaceCreateInfoKHR* Alloc() {
            int size = sizeof(VkWaylandSurfaceCreateInfoKHR);
            var info = (VkWaylandSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.WaylandSurfaceCreateInfoKHR;

            return info;
        }
    }

    // Struct: 425
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkWin32KeyedMutexAcquireReleaseInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWin32KeyedMutexAcquireReleaseInfoKHR"/>.</returns>
        public static VkWin32KeyedMutexAcquireReleaseInfoKHR* Alloc() {
            int size = sizeof(VkWin32KeyedMutexAcquireReleaseInfoKHR);
            var info = (VkWin32KeyedMutexAcquireReleaseInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoKHR;

            return info;
        }
    }

    // Struct: 426
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkWin32KeyedMutexAcquireReleaseInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWin32KeyedMutexAcquireReleaseInfoNV"/>.</returns>
        public static VkWin32KeyedMutexAcquireReleaseInfoNV* Alloc() {
            int size = sizeof(VkWin32KeyedMutexAcquireReleaseInfoNV);
            var info = (VkWin32KeyedMutexAcquireReleaseInfoNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNv;

            return info;
        }
    }

    // Struct: 427
    public unsafe partial struct VkWin32SurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkWin32SurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWin32SurfaceCreateInfoKHR"/>.</returns>
        public static VkWin32SurfaceCreateInfoKHR* Alloc() {
            int size = sizeof(VkWin32SurfaceCreateInfoKHR);
            var info = (VkWin32SurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.Win32SurfaceCreateInfoKHR;

            return info;
        }
    }

    // Struct: 428
    public unsafe partial struct VkWriteDescriptorSet {
        /// <summary>
        /// Allocate an instance of <see cref="VkWriteDescriptorSet"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWriteDescriptorSet"/>.</returns>
        public static VkWriteDescriptorSet* Alloc() {
            int size = sizeof(VkWriteDescriptorSet);
            var info = (VkWriteDescriptorSet*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.WriteDescriptorSet;

            return info;
        }
    }

    // Struct: 429
    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV {
        /// <summary>
        /// Allocate an instance of <see cref="VkWriteDescriptorSetAccelerationStructureNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWriteDescriptorSetAccelerationStructureNV"/>.</returns>
        public static VkWriteDescriptorSetAccelerationStructureNV* Alloc() {
            int size = sizeof(VkWriteDescriptorSetAccelerationStructureNV);
            var info = (VkWriteDescriptorSetAccelerationStructureNV*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.WriteDescriptorSetAccelerationStructureNv;

            return info;
        }
    }

    // Struct: 430
    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlockEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkWriteDescriptorSetInlineUniformBlockEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkWriteDescriptorSetInlineUniformBlockEXT"/>.</returns>
        public static VkWriteDescriptorSetInlineUniformBlockEXT* Alloc() {
            int size = sizeof(VkWriteDescriptorSetInlineUniformBlockEXT);
            var info = (VkWriteDescriptorSetInlineUniformBlockEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.WriteDescriptorSetInlineUniformBlockExt;

            return info;
        }
    }

    // Struct: 431
    public unsafe partial struct VkXYColorEXT {
        /// <summary>
        /// Allocate an instance of <see cref="VkXYColorEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkXYColorEXT"/>.</returns>
        public static VkXYColorEXT* Alloc() {
            int size = sizeof(VkXYColorEXT);
            var info = (VkXYColorEXT*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);

            return info;
        }
    }

    // Struct: 432
    public unsafe partial struct VkXcbSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkXcbSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkXcbSurfaceCreateInfoKHR"/>.</returns>
        public static VkXcbSurfaceCreateInfoKHR* Alloc() {
            int size = sizeof(VkXcbSurfaceCreateInfoKHR);
            var info = (VkXcbSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.XcbSurfaceCreateInfoKHR;

            return info;
        }
    }

    // Struct: 433
    public unsafe partial struct VkXlibSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate an instance of <see cref="VkXlibSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <returns>A pointer to the instance of <see cref="VkXlibSurfaceCreateInfoKHR"/>.</returns>
        public static VkXlibSurfaceCreateInfoKHR* Alloc() {
            int size = sizeof(VkXlibSurfaceCreateInfoKHR);
            var info = (VkXlibSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size);
            Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);
            info->sType = VkStructureType.XlibSurfaceCreateInfoKHR;

            return info;
        }
    }

}
