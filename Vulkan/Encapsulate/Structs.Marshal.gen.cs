using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan {
    public unsafe static partial class Vk {
        private const int maxStructSize = 1024;
        internal static readonly byte[] zeros = new byte[maxStructSize];
        //internal static readonly List<IntPtr> allocList = new List<IntPtr>();
        //public static void Free() {
        //    foreach (var item in allocList) {
        //        Marshal.FreeHGlobal(item);
        //    }

        //    allocList.Clear();
        //}
    }
    // Struct: 0
    public unsafe partial struct VkAccelerationStructureCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAccelerationStructureCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAccelerationStructureCreateInfoNV"/>.</returns>
        public static VkAccelerationStructureCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAccelerationStructureCreateInfoNV);
            var info = (VkAccelerationStructureCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AccelerationStructureCreateInfoNv; }

            return info;
        }
    }

    // Struct: 1
    public unsafe partial struct VkAccelerationStructureInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAccelerationStructureInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAccelerationStructureInfoNV"/>.</returns>
        public static VkAccelerationStructureInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAccelerationStructureInfoNV);
            var info = (VkAccelerationStructureInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AccelerationStructureInfoNv; }

            return info;
        }
    }

    // Struct: 2
    public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAccelerationStructureMemoryRequirementsInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAccelerationStructureMemoryRequirementsInfoNV"/>.</returns>
        public static VkAccelerationStructureMemoryRequirementsInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAccelerationStructureMemoryRequirementsInfoNV);
            var info = (VkAccelerationStructureMemoryRequirementsInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AccelerationStructureMemoryRequirementsInfoNv; }

            return info;
        }
    }

    // Struct: 3
    public unsafe partial struct VkAcquireNextImageInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAcquireNextImageInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAcquireNextImageInfoKHR"/>.</returns>
        public static VkAcquireNextImageInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAcquireNextImageInfoKHR);
            var info = (VkAcquireNextImageInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AcquireNextImageInfoKHR; }

            return info;
        }
    }

    // Struct: 4
    public unsafe partial struct VkAllocationCallbacks {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAllocationCallbacks"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAllocationCallbacks"/>.</returns>
        public static VkAllocationCallbacks* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAllocationCallbacks);
            var info = (VkAllocationCallbacks*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 5
    public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAndroidHardwareBufferFormatPropertiesANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAndroidHardwareBufferFormatPropertiesANDROID"/>.</returns>
        public static VkAndroidHardwareBufferFormatPropertiesANDROID* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAndroidHardwareBufferFormatPropertiesANDROID);
            var info = (VkAndroidHardwareBufferFormatPropertiesANDROID*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AndroidHardwareBufferFormatPropertiesAndroid; }

            return info;
        }
    }

    // Struct: 6
    public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAndroidHardwareBufferPropertiesANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAndroidHardwareBufferPropertiesANDROID"/>.</returns>
        public static VkAndroidHardwareBufferPropertiesANDROID* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAndroidHardwareBufferPropertiesANDROID);
            var info = (VkAndroidHardwareBufferPropertiesANDROID*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AndroidHardwareBufferPropertiesAndroid; }

            return info;
        }
    }

    // Struct: 7
    public unsafe partial struct VkAndroidHardwareBufferUsageANDROID {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAndroidHardwareBufferUsageANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAndroidHardwareBufferUsageANDROID"/>.</returns>
        public static VkAndroidHardwareBufferUsageANDROID* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAndroidHardwareBufferUsageANDROID);
            var info = (VkAndroidHardwareBufferUsageANDROID*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AndroidHardwareBufferUsageAndroid; }

            return info;
        }
    }

    // Struct: 8
    public unsafe partial struct VkAndroidSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAndroidSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAndroidSurfaceCreateInfoKHR"/>.</returns>
        public static VkAndroidSurfaceCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAndroidSurfaceCreateInfoKHR);
            var info = (VkAndroidSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AndroidSurfaceCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 9
    public unsafe partial struct VkApplicationInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkApplicationInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkApplicationInfo"/>.</returns>
        public static VkApplicationInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkApplicationInfo);
            var info = (VkApplicationInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ApplicationInfo; }

            return info;
        }
    }

    // Struct: 10
    public unsafe partial struct VkAttachmentDescription {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAttachmentDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAttachmentDescription"/>.</returns>
        public static VkAttachmentDescription* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAttachmentDescription);
            var info = (VkAttachmentDescription*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 11
    public unsafe partial struct VkAttachmentDescription2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAttachmentDescription2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAttachmentDescription2KHR"/>.</returns>
        public static VkAttachmentDescription2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAttachmentDescription2KHR);
            var info = (VkAttachmentDescription2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AttachmentDescription2KHR; }

            return info;
        }
    }

    // Struct: 12
    public unsafe partial struct VkAttachmentReference {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAttachmentReference"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAttachmentReference"/>.</returns>
        public static VkAttachmentReference* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAttachmentReference);
            var info = (VkAttachmentReference*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 13
    public unsafe partial struct VkAttachmentReference2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAttachmentReference2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAttachmentReference2KHR"/>.</returns>
        public static VkAttachmentReference2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAttachmentReference2KHR);
            var info = (VkAttachmentReference2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.AttachmentReference2KHR; }

            return info;
        }
    }

    // Struct: 14
    public unsafe partial struct VkAttachmentSampleLocationsEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkAttachmentSampleLocationsEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkAttachmentSampleLocationsEXT"/>.</returns>
        public static VkAttachmentSampleLocationsEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkAttachmentSampleLocationsEXT);
            var info = (VkAttachmentSampleLocationsEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 15
    public unsafe partial struct VkBaseInStructure {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBaseInStructure"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBaseInStructure"/>.</returns>
        public static VkBaseInStructure* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBaseInStructure);
            var info = (VkBaseInStructure*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = 0; }

            return info;
        }
    }

    // Struct: 16
    public unsafe partial struct VkBaseOutStructure {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBaseOutStructure"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBaseOutStructure"/>.</returns>
        public static VkBaseOutStructure* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBaseOutStructure);
            var info = (VkBaseOutStructure*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = 0; }

            return info;
        }
    }

    // Struct: 17
    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindAccelerationStructureMemoryInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindAccelerationStructureMemoryInfoNV"/>.</returns>
        public static VkBindAccelerationStructureMemoryInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindAccelerationStructureMemoryInfoNV);
            var info = (VkBindAccelerationStructureMemoryInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindAccelerationStructureMemoryInfoNv; }

            return info;
        }
    }

    // Struct: 18
    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindBufferMemoryDeviceGroupInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindBufferMemoryDeviceGroupInfo"/>.</returns>
        public static VkBindBufferMemoryDeviceGroupInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindBufferMemoryDeviceGroupInfo);
            var info = (VkBindBufferMemoryDeviceGroupInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindBufferMemoryDeviceGroupInfo; }

            return info;
        }
    }

    // Struct: 19
    public unsafe partial struct VkBindBufferMemoryInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindBufferMemoryInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindBufferMemoryInfo"/>.</returns>
        public static VkBindBufferMemoryInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindBufferMemoryInfo);
            var info = (VkBindBufferMemoryInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindBufferMemoryInfo; }

            return info;
        }
    }

    // Struct: 20
    public unsafe partial struct VkBindImageMemoryDeviceGroupInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindImageMemoryDeviceGroupInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindImageMemoryDeviceGroupInfo"/>.</returns>
        public static VkBindImageMemoryDeviceGroupInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindImageMemoryDeviceGroupInfo);
            var info = (VkBindImageMemoryDeviceGroupInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindImageMemoryDeviceGroupInfo; }

            return info;
        }
    }

    // Struct: 21
    public unsafe partial struct VkBindImageMemoryInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindImageMemoryInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindImageMemoryInfo"/>.</returns>
        public static VkBindImageMemoryInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindImageMemoryInfo);
            var info = (VkBindImageMemoryInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindImageMemoryInfo; }

            return info;
        }
    }

    // Struct: 22
    public unsafe partial struct VkBindImageMemorySwapchainInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindImageMemorySwapchainInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindImageMemorySwapchainInfoKHR"/>.</returns>
        public static VkBindImageMemorySwapchainInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindImageMemorySwapchainInfoKHR);
            var info = (VkBindImageMemorySwapchainInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindImageMemorySwapchainInfoKHR; }

            return info;
        }
    }

    // Struct: 23
    public unsafe partial struct VkBindImagePlaneMemoryInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindImagePlaneMemoryInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindImagePlaneMemoryInfo"/>.</returns>
        public static VkBindImagePlaneMemoryInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindImagePlaneMemoryInfo);
            var info = (VkBindImagePlaneMemoryInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindImagePlaneMemoryInfo; }

            return info;
        }
    }

    // Struct: 24
    public unsafe partial struct VkBindSparseInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBindSparseInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBindSparseInfo"/>.</returns>
        public static VkBindSparseInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBindSparseInfo);
            var info = (VkBindSparseInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BindSparseInfo; }

            return info;
        }
    }

    // Struct: 25
    public unsafe partial struct VkBufferCopy {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferCopy"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferCopy"/>.</returns>
        public static VkBufferCopy* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferCopy);
            var info = (VkBufferCopy*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 26
    public unsafe partial struct VkBufferCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferCreateInfo"/>.</returns>
        public static VkBufferCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferCreateInfo);
            var info = (VkBufferCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BufferCreateInfo; }

            return info;
        }
    }

    // Struct: 27
    public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferDeviceAddressCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferDeviceAddressCreateInfoEXT"/>.</returns>
        public static VkBufferDeviceAddressCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferDeviceAddressCreateInfoEXT);
            var info = (VkBufferDeviceAddressCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BufferDeviceAddressCreateInfoExt; }

            return info;
        }
    }

    // Struct: 28
    public unsafe partial struct VkBufferDeviceAddressInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferDeviceAddressInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferDeviceAddressInfoEXT"/>.</returns>
        public static VkBufferDeviceAddressInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferDeviceAddressInfoEXT);
            var info = (VkBufferDeviceAddressInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BufferDeviceAddressInfoExt; }

            return info;
        }
    }

    // Struct: 29
    public unsafe partial struct VkBufferImageCopy {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferImageCopy"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferImageCopy"/>.</returns>
        public static VkBufferImageCopy* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferImageCopy);
            var info = (VkBufferImageCopy*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 30
    public unsafe partial struct VkBufferMemoryBarrier {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferMemoryBarrier"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferMemoryBarrier"/>.</returns>
        public static VkBufferMemoryBarrier* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferMemoryBarrier);
            var info = (VkBufferMemoryBarrier*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BufferMemoryBarrier; }

            return info;
        }
    }

    // Struct: 31
    public unsafe partial struct VkBufferMemoryRequirementsInfo2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferMemoryRequirementsInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferMemoryRequirementsInfo2"/>.</returns>
        public static VkBufferMemoryRequirementsInfo2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferMemoryRequirementsInfo2);
            var info = (VkBufferMemoryRequirementsInfo2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BufferMemoryRequirementsInfo2; }

            return info;
        }
    }

    // Struct: 32
    public unsafe partial struct VkBufferViewCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkBufferViewCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkBufferViewCreateInfo"/>.</returns>
        public static VkBufferViewCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkBufferViewCreateInfo);
            var info = (VkBufferViewCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.BufferViewCreateInfo; }

            return info;
        }
    }

    // Struct: 33
    public unsafe partial struct VkCalibratedTimestampInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCalibratedTimestampInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCalibratedTimestampInfoEXT"/>.</returns>
        public static VkCalibratedTimestampInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCalibratedTimestampInfoEXT);
            var info = (VkCalibratedTimestampInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CalibratedTimestampInfoExt; }

            return info;
        }
    }

    // Struct: 34
    public unsafe partial struct VkCheckpointDataNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCheckpointDataNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCheckpointDataNV"/>.</returns>
        public static VkCheckpointDataNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCheckpointDataNV);
            var info = (VkCheckpointDataNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CheckpointDataNv; }

            return info;
        }
    }

    // Struct: 35
    public unsafe partial struct VkClearAttachment {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkClearAttachment"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkClearAttachment"/>.</returns>
        public static VkClearAttachment* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkClearAttachment);
            var info = (VkClearAttachment*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 36
    public unsafe partial struct VkClearColorValue {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkClearColorValue"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkClearColorValue"/>.</returns>
        public static VkClearColorValue* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkClearColorValue);
            var info = (VkClearColorValue*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 37
    public unsafe partial struct VkClearDepthStencilValue {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkClearDepthStencilValue"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkClearDepthStencilValue"/>.</returns>
        public static VkClearDepthStencilValue* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkClearDepthStencilValue);
            var info = (VkClearDepthStencilValue*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 38
    public unsafe partial struct VkClearRect {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkClearRect"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkClearRect"/>.</returns>
        public static VkClearRect* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkClearRect);
            var info = (VkClearRect*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 39
    public unsafe partial struct VkClearValue {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkClearValue"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkClearValue"/>.</returns>
        public static VkClearValue* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkClearValue);
            var info = (VkClearValue*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 40
    public unsafe partial struct VkCmdProcessCommandsInfoNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCmdProcessCommandsInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCmdProcessCommandsInfoNVX"/>.</returns>
        public static VkCmdProcessCommandsInfoNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCmdProcessCommandsInfoNVX);
            var info = (VkCmdProcessCommandsInfoNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CmdProcessCommandsInfoNvx; }

            return info;
        }
    }

    // Struct: 41
    public unsafe partial struct VkCmdReserveSpaceForCommandsInfoNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCmdReserveSpaceForCommandsInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCmdReserveSpaceForCommandsInfoNVX"/>.</returns>
        public static VkCmdReserveSpaceForCommandsInfoNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCmdReserveSpaceForCommandsInfoNVX);
            var info = (VkCmdReserveSpaceForCommandsInfoNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CmdReserveSpaceForCommandsInfoNvx; }

            return info;
        }
    }

    // Struct: 42
    public unsafe partial struct VkCoarseSampleLocationNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCoarseSampleLocationNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCoarseSampleLocationNV"/>.</returns>
        public static VkCoarseSampleLocationNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCoarseSampleLocationNV);
            var info = (VkCoarseSampleLocationNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 43
    public unsafe partial struct VkCoarseSampleOrderCustomNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCoarseSampleOrderCustomNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCoarseSampleOrderCustomNV"/>.</returns>
        public static VkCoarseSampleOrderCustomNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCoarseSampleOrderCustomNV);
            var info = (VkCoarseSampleOrderCustomNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 44
    public unsafe partial struct VkCommandBufferAllocateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCommandBufferAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCommandBufferAllocateInfo"/>.</returns>
        public static VkCommandBufferAllocateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCommandBufferAllocateInfo);
            var info = (VkCommandBufferAllocateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CommandBufferAllocateInfo; }

            return info;
        }
    }

    // Struct: 45
    public unsafe partial struct VkCommandBufferBeginInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCommandBufferBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCommandBufferBeginInfo"/>.</returns>
        public static VkCommandBufferBeginInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCommandBufferBeginInfo);
            var info = (VkCommandBufferBeginInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CommandBufferBeginInfo; }

            return info;
        }
    }

    // Struct: 46
    public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCommandBufferInheritanceConditionalRenderingInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCommandBufferInheritanceConditionalRenderingInfoEXT"/>.</returns>
        public static VkCommandBufferInheritanceConditionalRenderingInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCommandBufferInheritanceConditionalRenderingInfoEXT);
            var info = (VkCommandBufferInheritanceConditionalRenderingInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoExt; }

            return info;
        }
    }

    // Struct: 47
    public unsafe partial struct VkCommandBufferInheritanceInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCommandBufferInheritanceInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCommandBufferInheritanceInfo"/>.</returns>
        public static VkCommandBufferInheritanceInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCommandBufferInheritanceInfo);
            var info = (VkCommandBufferInheritanceInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CommandBufferInheritanceInfo; }

            return info;
        }
    }

    // Struct: 48
    public unsafe partial struct VkCommandPoolCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCommandPoolCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCommandPoolCreateInfo"/>.</returns>
        public static VkCommandPoolCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCommandPoolCreateInfo);
            var info = (VkCommandPoolCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CommandPoolCreateInfo; }

            return info;
        }
    }

    // Struct: 49
    public unsafe partial struct VkComponentMapping {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkComponentMapping"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkComponentMapping"/>.</returns>
        public static VkComponentMapping* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkComponentMapping);
            var info = (VkComponentMapping*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 50
    public unsafe partial struct VkComputePipelineCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkComputePipelineCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkComputePipelineCreateInfo"/>.</returns>
        public static VkComputePipelineCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkComputePipelineCreateInfo);
            var info = (VkComputePipelineCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ComputePipelineCreateInfo; }

            return info;
        }
    }

    // Struct: 51
    public unsafe partial struct VkConditionalRenderingBeginInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkConditionalRenderingBeginInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkConditionalRenderingBeginInfoEXT"/>.</returns>
        public static VkConditionalRenderingBeginInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkConditionalRenderingBeginInfoEXT);
            var info = (VkConditionalRenderingBeginInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ConditionalRenderingBeginInfoExt; }

            return info;
        }
    }

    // Struct: 52
    public unsafe partial struct VkConformanceVersionKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkConformanceVersionKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkConformanceVersionKHR"/>.</returns>
        public static VkConformanceVersionKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkConformanceVersionKHR);
            var info = (VkConformanceVersionKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 53
    public unsafe partial struct VkCooperativeMatrixPropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCooperativeMatrixPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCooperativeMatrixPropertiesNV"/>.</returns>
        public static VkCooperativeMatrixPropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCooperativeMatrixPropertiesNV);
            var info = (VkCooperativeMatrixPropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CooperativeMatrixPropertiesNv; }

            return info;
        }
    }

    // Struct: 54
    public unsafe partial struct VkCopyDescriptorSet {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkCopyDescriptorSet"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkCopyDescriptorSet"/>.</returns>
        public static VkCopyDescriptorSet* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkCopyDescriptorSet);
            var info = (VkCopyDescriptorSet*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.CopyDescriptorSet; }

            return info;
        }
    }

    // Struct: 55
    public unsafe partial struct VkD3D12FenceSubmitInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkD3D12FenceSubmitInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkD3D12FenceSubmitInfoKHR"/>.</returns>
        public static VkD3D12FenceSubmitInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkD3D12FenceSubmitInfoKHR);
            var info = (VkD3D12FenceSubmitInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.D3d12FenceSubmitInfoKHR; }

            return info;
        }
    }

    // Struct: 56
    public unsafe partial struct VkDebugMarkerMarkerInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugMarkerMarkerInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugMarkerMarkerInfoEXT"/>.</returns>
        public static VkDebugMarkerMarkerInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugMarkerMarkerInfoEXT);
            var info = (VkDebugMarkerMarkerInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugMarkerMarkerInfoExt; }

            return info;
        }
    }

    // Struct: 57
    public unsafe partial struct VkDebugMarkerObjectNameInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugMarkerObjectNameInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugMarkerObjectNameInfoEXT"/>.</returns>
        public static VkDebugMarkerObjectNameInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugMarkerObjectNameInfoEXT);
            var info = (VkDebugMarkerObjectNameInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugMarkerObjectNameInfoExt; }

            return info;
        }
    }

    // Struct: 58
    public unsafe partial struct VkDebugMarkerObjectTagInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugMarkerObjectTagInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugMarkerObjectTagInfoEXT"/>.</returns>
        public static VkDebugMarkerObjectTagInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugMarkerObjectTagInfoEXT);
            var info = (VkDebugMarkerObjectTagInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugMarkerObjectTagInfoExt; }

            return info;
        }
    }

    // Struct: 59
    public unsafe partial struct VkDebugReportCallbackCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugReportCallbackCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugReportCallbackCreateInfoEXT"/>.</returns>
        public static VkDebugReportCallbackCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugReportCallbackCreateInfoEXT);
            var info = (VkDebugReportCallbackCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugReportCallbackCreateInfoExt; }

            return info;
        }
    }

    // Struct: 60
    public unsafe partial struct VkDebugUtilsLabelEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugUtilsLabelEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugUtilsLabelEXT"/>.</returns>
        public static VkDebugUtilsLabelEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugUtilsLabelEXT);
            var info = (VkDebugUtilsLabelEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugUtilsLabelExt; }

            return info;
        }
    }

    // Struct: 61
    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugUtilsMessengerCallbackDataEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugUtilsMessengerCallbackDataEXT"/>.</returns>
        public static VkDebugUtilsMessengerCallbackDataEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugUtilsMessengerCallbackDataEXT);
            var info = (VkDebugUtilsMessengerCallbackDataEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugUtilsMessengerCallbackDataExt; }

            return info;
        }
    }

    // Struct: 62
    public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugUtilsMessengerCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugUtilsMessengerCreateInfoEXT"/>.</returns>
        public static VkDebugUtilsMessengerCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugUtilsMessengerCreateInfoEXT);
            var info = (VkDebugUtilsMessengerCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugUtilsMessengerCreateInfoExt; }

            return info;
        }
    }

    // Struct: 63
    public unsafe partial struct VkDebugUtilsObjectNameInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugUtilsObjectNameInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugUtilsObjectNameInfoEXT"/>.</returns>
        public static VkDebugUtilsObjectNameInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugUtilsObjectNameInfoEXT);
            var info = (VkDebugUtilsObjectNameInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugUtilsObjectNameInfoExt; }

            return info;
        }
    }

    // Struct: 64
    public unsafe partial struct VkDebugUtilsObjectTagInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDebugUtilsObjectTagInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDebugUtilsObjectTagInfoEXT"/>.</returns>
        public static VkDebugUtilsObjectTagInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDebugUtilsObjectTagInfoEXT);
            var info = (VkDebugUtilsObjectTagInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DebugUtilsObjectTagInfoExt; }

            return info;
        }
    }

    // Struct: 65
    public unsafe partial struct VkDedicatedAllocationBufferCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDedicatedAllocationBufferCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDedicatedAllocationBufferCreateInfoNV"/>.</returns>
        public static VkDedicatedAllocationBufferCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDedicatedAllocationBufferCreateInfoNV);
            var info = (VkDedicatedAllocationBufferCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DedicatedAllocationBufferCreateInfoNv; }

            return info;
        }
    }

    // Struct: 66
    public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDedicatedAllocationImageCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDedicatedAllocationImageCreateInfoNV"/>.</returns>
        public static VkDedicatedAllocationImageCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDedicatedAllocationImageCreateInfoNV);
            var info = (VkDedicatedAllocationImageCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DedicatedAllocationImageCreateInfoNv; }

            return info;
        }
    }

    // Struct: 67
    public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDedicatedAllocationMemoryAllocateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDedicatedAllocationMemoryAllocateInfoNV"/>.</returns>
        public static VkDedicatedAllocationMemoryAllocateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDedicatedAllocationMemoryAllocateInfoNV);
            var info = (VkDedicatedAllocationMemoryAllocateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DedicatedAllocationMemoryAllocateInfoNv; }

            return info;
        }
    }

    // Struct: 68
    public unsafe partial struct VkDescriptorBufferInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorBufferInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorBufferInfo"/>.</returns>
        public static VkDescriptorBufferInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorBufferInfo);
            var info = (VkDescriptorBufferInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 69
    public unsafe partial struct VkDescriptorImageInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorImageInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorImageInfo"/>.</returns>
        public static VkDescriptorImageInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorImageInfo);
            var info = (VkDescriptorImageInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 70
    public unsafe partial struct VkDescriptorPoolCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorPoolCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorPoolCreateInfo"/>.</returns>
        public static VkDescriptorPoolCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorPoolCreateInfo);
            var info = (VkDescriptorPoolCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorPoolCreateInfo; }

            return info;
        }
    }

    // Struct: 71
    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorPoolInlineUniformBlockCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorPoolInlineUniformBlockCreateInfoEXT"/>.</returns>
        public static VkDescriptorPoolInlineUniformBlockCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorPoolInlineUniformBlockCreateInfoEXT);
            var info = (VkDescriptorPoolInlineUniformBlockCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfoExt; }

            return info;
        }
    }

    // Struct: 72
    public unsafe partial struct VkDescriptorPoolSize {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorPoolSize"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorPoolSize"/>.</returns>
        public static VkDescriptorPoolSize* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorPoolSize);
            var info = (VkDescriptorPoolSize*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 73
    public unsafe partial struct VkDescriptorSetAllocateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetAllocateInfo"/>.</returns>
        public static VkDescriptorSetAllocateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetAllocateInfo);
            var info = (VkDescriptorSetAllocateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorSetAllocateInfo; }

            return info;
        }
    }

    // Struct: 74
    public unsafe partial struct VkDescriptorSetLayoutBinding {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetLayoutBinding"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetLayoutBinding"/>.</returns>
        public static VkDescriptorSetLayoutBinding* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetLayoutBinding);
            var info = (VkDescriptorSetLayoutBinding*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 75
    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetLayoutBindingFlagsCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetLayoutBindingFlagsCreateInfoEXT"/>.</returns>
        public static VkDescriptorSetLayoutBindingFlagsCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetLayoutBindingFlagsCreateInfoEXT);
            var info = (VkDescriptorSetLayoutBindingFlagsCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorSetLayoutBindingFlagsCreateInfoExt; }

            return info;
        }
    }

    // Struct: 76
    public unsafe partial struct VkDescriptorSetLayoutCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetLayoutCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetLayoutCreateInfo"/>.</returns>
        public static VkDescriptorSetLayoutCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetLayoutCreateInfo);
            var info = (VkDescriptorSetLayoutCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorSetLayoutCreateInfo; }

            return info;
        }
    }

    // Struct: 77
    public unsafe partial struct VkDescriptorSetLayoutSupport {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetLayoutSupport"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetLayoutSupport"/>.</returns>
        public static VkDescriptorSetLayoutSupport* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetLayoutSupport);
            var info = (VkDescriptorSetLayoutSupport*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorSetLayoutSupport; }

            return info;
        }
    }

    // Struct: 78
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetVariableDescriptorCountAllocateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetVariableDescriptorCountAllocateInfoEXT"/>.</returns>
        public static VkDescriptorSetVariableDescriptorCountAllocateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetVariableDescriptorCountAllocateInfoEXT);
            var info = (VkDescriptorSetVariableDescriptorCountAllocateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfoExt; }

            return info;
        }
    }

    // Struct: 79
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorSetVariableDescriptorCountLayoutSupportEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorSetVariableDescriptorCountLayoutSupportEXT"/>.</returns>
        public static VkDescriptorSetVariableDescriptorCountLayoutSupportEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorSetVariableDescriptorCountLayoutSupportEXT);
            var info = (VkDescriptorSetVariableDescriptorCountLayoutSupportEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupportExt; }

            return info;
        }
    }

    // Struct: 80
    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorUpdateTemplateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorUpdateTemplateCreateInfo"/>.</returns>
        public static VkDescriptorUpdateTemplateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorUpdateTemplateCreateInfo);
            var info = (VkDescriptorUpdateTemplateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DescriptorUpdateTemplateCreateInfo; }

            return info;
        }
    }

    // Struct: 81
    public unsafe partial struct VkDescriptorUpdateTemplateEntry {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDescriptorUpdateTemplateEntry"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDescriptorUpdateTemplateEntry"/>.</returns>
        public static VkDescriptorUpdateTemplateEntry* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDescriptorUpdateTemplateEntry);
            var info = (VkDescriptorUpdateTemplateEntry*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 82
    public unsafe partial struct VkDeviceCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceCreateInfo"/>.</returns>
        public static VkDeviceCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceCreateInfo);
            var info = (VkDeviceCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceCreateInfo; }

            return info;
        }
    }

    // Struct: 83
    public unsafe partial struct VkDeviceEventInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceEventInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceEventInfoEXT"/>.</returns>
        public static VkDeviceEventInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceEventInfoEXT);
            var info = (VkDeviceEventInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceEventInfoExt; }

            return info;
        }
    }

    // Struct: 84
    public unsafe partial struct VkDeviceGeneratedCommandsFeaturesNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGeneratedCommandsFeaturesNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGeneratedCommandsFeaturesNVX"/>.</returns>
        public static VkDeviceGeneratedCommandsFeaturesNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGeneratedCommandsFeaturesNVX);
            var info = (VkDeviceGeneratedCommandsFeaturesNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGeneratedCommandsFeaturesNvx; }

            return info;
        }
    }

    // Struct: 85
    public unsafe partial struct VkDeviceGeneratedCommandsLimitsNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGeneratedCommandsLimitsNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGeneratedCommandsLimitsNVX"/>.</returns>
        public static VkDeviceGeneratedCommandsLimitsNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGeneratedCommandsLimitsNVX);
            var info = (VkDeviceGeneratedCommandsLimitsNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGeneratedCommandsLimitsNvx; }

            return info;
        }
    }

    // Struct: 86
    public unsafe partial struct VkDeviceGroupBindSparseInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupBindSparseInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupBindSparseInfo"/>.</returns>
        public static VkDeviceGroupBindSparseInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupBindSparseInfo);
            var info = (VkDeviceGroupBindSparseInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupBindSparseInfo; }

            return info;
        }
    }

    // Struct: 87
    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupCommandBufferBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupCommandBufferBeginInfo"/>.</returns>
        public static VkDeviceGroupCommandBufferBeginInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupCommandBufferBeginInfo);
            var info = (VkDeviceGroupCommandBufferBeginInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupCommandBufferBeginInfo; }

            return info;
        }
    }

    // Struct: 88
    public unsafe partial struct VkDeviceGroupDeviceCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupDeviceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupDeviceCreateInfo"/>.</returns>
        public static VkDeviceGroupDeviceCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupDeviceCreateInfo);
            var info = (VkDeviceGroupDeviceCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupDeviceCreateInfo; }

            return info;
        }
    }

    // Struct: 89
    public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupPresentCapabilitiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupPresentCapabilitiesKHR"/>.</returns>
        public static VkDeviceGroupPresentCapabilitiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupPresentCapabilitiesKHR);
            var info = (VkDeviceGroupPresentCapabilitiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupPresentCapabilitiesKHR; }

            return info;
        }
    }

    // Struct: 90
    public unsafe partial struct VkDeviceGroupPresentInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupPresentInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupPresentInfoKHR"/>.</returns>
        public static VkDeviceGroupPresentInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupPresentInfoKHR);
            var info = (VkDeviceGroupPresentInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupPresentInfoKHR; }

            return info;
        }
    }

    // Struct: 91
    public unsafe partial struct VkDeviceGroupRenderPassBeginInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupRenderPassBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupRenderPassBeginInfo"/>.</returns>
        public static VkDeviceGroupRenderPassBeginInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupRenderPassBeginInfo);
            var info = (VkDeviceGroupRenderPassBeginInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupRenderPassBeginInfo; }

            return info;
        }
    }

    // Struct: 92
    public unsafe partial struct VkDeviceGroupSubmitInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupSubmitInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupSubmitInfo"/>.</returns>
        public static VkDeviceGroupSubmitInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupSubmitInfo);
            var info = (VkDeviceGroupSubmitInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupSubmitInfo; }

            return info;
        }
    }

    // Struct: 93
    public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceGroupSwapchainCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceGroupSwapchainCreateInfoKHR"/>.</returns>
        public static VkDeviceGroupSwapchainCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceGroupSwapchainCreateInfoKHR);
            var info = (VkDeviceGroupSwapchainCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceGroupSwapchainCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 94
    public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceMemoryOverallocationCreateInfoAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceMemoryOverallocationCreateInfoAMD"/>.</returns>
        public static VkDeviceMemoryOverallocationCreateInfoAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceMemoryOverallocationCreateInfoAMD);
            var info = (VkDeviceMemoryOverallocationCreateInfoAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceMemoryOverallocationCreateInfoAmd; }

            return info;
        }
    }

    // Struct: 95
    public unsafe partial struct VkDeviceQueueCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceQueueCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceQueueCreateInfo"/>.</returns>
        public static VkDeviceQueueCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceQueueCreateInfo);
            var info = (VkDeviceQueueCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceQueueCreateInfo; }

            return info;
        }
    }

    // Struct: 96
    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceQueueGlobalPriorityCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceQueueGlobalPriorityCreateInfoEXT"/>.</returns>
        public static VkDeviceQueueGlobalPriorityCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceQueueGlobalPriorityCreateInfoEXT);
            var info = (VkDeviceQueueGlobalPriorityCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceQueueGlobalPriorityCreateInfoExt; }

            return info;
        }
    }

    // Struct: 97
    public unsafe partial struct VkDeviceQueueInfo2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDeviceQueueInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDeviceQueueInfo2"/>.</returns>
        public static VkDeviceQueueInfo2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDeviceQueueInfo2);
            var info = (VkDeviceQueueInfo2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DeviceQueueInfo2; }

            return info;
        }
    }

    // Struct: 98
    public unsafe partial struct VkDispatchIndirectCommand {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDispatchIndirectCommand"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDispatchIndirectCommand"/>.</returns>
        public static VkDispatchIndirectCommand* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDispatchIndirectCommand);
            var info = (VkDispatchIndirectCommand*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 99
    public unsafe partial struct VkDisplayEventInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayEventInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayEventInfoEXT"/>.</returns>
        public static VkDisplayEventInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayEventInfoEXT);
            var info = (VkDisplayEventInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayEventInfoExt; }

            return info;
        }
    }

    // Struct: 100
    public unsafe partial struct VkDisplayModeCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayModeCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayModeCreateInfoKHR"/>.</returns>
        public static VkDisplayModeCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayModeCreateInfoKHR);
            var info = (VkDisplayModeCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayModeCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 101
    public unsafe partial struct VkDisplayModeParametersKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayModeParametersKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayModeParametersKHR"/>.</returns>
        public static VkDisplayModeParametersKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayModeParametersKHR);
            var info = (VkDisplayModeParametersKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 102
    public unsafe partial struct VkDisplayModeProperties2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayModeProperties2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayModeProperties2KHR"/>.</returns>
        public static VkDisplayModeProperties2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayModeProperties2KHR);
            var info = (VkDisplayModeProperties2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayModeProperties2KHR; }

            return info;
        }
    }

    // Struct: 103
    public unsafe partial struct VkDisplayModePropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayModePropertiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayModePropertiesKHR"/>.</returns>
        public static VkDisplayModePropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayModePropertiesKHR);
            var info = (VkDisplayModePropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 104
    public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayNativeHdrSurfaceCapabilitiesAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayNativeHdrSurfaceCapabilitiesAMD"/>.</returns>
        public static VkDisplayNativeHdrSurfaceCapabilitiesAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayNativeHdrSurfaceCapabilitiesAMD);
            var info = (VkDisplayNativeHdrSurfaceCapabilitiesAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAmd; }

            return info;
        }
    }

    // Struct: 105
    public unsafe partial struct VkDisplayPlaneCapabilities2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPlaneCapabilities2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPlaneCapabilities2KHR"/>.</returns>
        public static VkDisplayPlaneCapabilities2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPlaneCapabilities2KHR);
            var info = (VkDisplayPlaneCapabilities2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayPlaneCapabilities2KHR; }

            return info;
        }
    }

    // Struct: 106
    public unsafe partial struct VkDisplayPlaneCapabilitiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPlaneCapabilitiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPlaneCapabilitiesKHR"/>.</returns>
        public static VkDisplayPlaneCapabilitiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPlaneCapabilitiesKHR);
            var info = (VkDisplayPlaneCapabilitiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 107
    public unsafe partial struct VkDisplayPlaneInfo2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPlaneInfo2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPlaneInfo2KHR"/>.</returns>
        public static VkDisplayPlaneInfo2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPlaneInfo2KHR);
            var info = (VkDisplayPlaneInfo2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayPlaneInfo2KHR; }

            return info;
        }
    }

    // Struct: 108
    public unsafe partial struct VkDisplayPlaneProperties2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPlaneProperties2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPlaneProperties2KHR"/>.</returns>
        public static VkDisplayPlaneProperties2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPlaneProperties2KHR);
            var info = (VkDisplayPlaneProperties2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayPlaneProperties2KHR; }

            return info;
        }
    }

    // Struct: 109
    public unsafe partial struct VkDisplayPlanePropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPlanePropertiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPlanePropertiesKHR"/>.</returns>
        public static VkDisplayPlanePropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPlanePropertiesKHR);
            var info = (VkDisplayPlanePropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 110
    public unsafe partial struct VkDisplayPowerInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPowerInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPowerInfoEXT"/>.</returns>
        public static VkDisplayPowerInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPowerInfoEXT);
            var info = (VkDisplayPowerInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayPowerInfoExt; }

            return info;
        }
    }

    // Struct: 111
    public unsafe partial struct VkDisplayPresentInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPresentInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPresentInfoKHR"/>.</returns>
        public static VkDisplayPresentInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPresentInfoKHR);
            var info = (VkDisplayPresentInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayPresentInfoKHR; }

            return info;
        }
    }

    // Struct: 112
    public unsafe partial struct VkDisplayProperties2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayProperties2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayProperties2KHR"/>.</returns>
        public static VkDisplayProperties2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayProperties2KHR);
            var info = (VkDisplayProperties2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplayProperties2KHR; }

            return info;
        }
    }

    // Struct: 113
    public unsafe partial struct VkDisplayPropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplayPropertiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplayPropertiesKHR"/>.</returns>
        public static VkDisplayPropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplayPropertiesKHR);
            var info = (VkDisplayPropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 114
    public unsafe partial struct VkDisplaySurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDisplaySurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDisplaySurfaceCreateInfoKHR"/>.</returns>
        public static VkDisplaySurfaceCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDisplaySurfaceCreateInfoKHR);
            var info = (VkDisplaySurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DisplaySurfaceCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 115
    public unsafe partial struct VkDrawIndexedIndirectCommand {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDrawIndexedIndirectCommand"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDrawIndexedIndirectCommand"/>.</returns>
        public static VkDrawIndexedIndirectCommand* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDrawIndexedIndirectCommand);
            var info = (VkDrawIndexedIndirectCommand*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 116
    public unsafe partial struct VkDrawIndirectCommand {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDrawIndirectCommand"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDrawIndirectCommand"/>.</returns>
        public static VkDrawIndirectCommand* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDrawIndirectCommand);
            var info = (VkDrawIndirectCommand*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 117
    public unsafe partial struct VkDrawMeshTasksIndirectCommandNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDrawMeshTasksIndirectCommandNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDrawMeshTasksIndirectCommandNV"/>.</returns>
        public static VkDrawMeshTasksIndirectCommandNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDrawMeshTasksIndirectCommandNV);
            var info = (VkDrawMeshTasksIndirectCommandNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 118
    public unsafe partial struct VkDrmFormatModifierPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDrmFormatModifierPropertiesEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDrmFormatModifierPropertiesEXT"/>.</returns>
        public static VkDrmFormatModifierPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDrmFormatModifierPropertiesEXT);
            var info = (VkDrmFormatModifierPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 119
    public unsafe partial struct VkDrmFormatModifierPropertiesListEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkDrmFormatModifierPropertiesListEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkDrmFormatModifierPropertiesListEXT"/>.</returns>
        public static VkDrmFormatModifierPropertiesListEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkDrmFormatModifierPropertiesListEXT);
            var info = (VkDrmFormatModifierPropertiesListEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.DrmFormatModifierPropertiesListExt; }

            return info;
        }
    }

    // Struct: 120
    public unsafe partial struct VkEventCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkEventCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkEventCreateInfo"/>.</returns>
        public static VkEventCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkEventCreateInfo);
            var info = (VkEventCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.EventCreateInfo; }

            return info;
        }
    }

    // Struct: 121
    public unsafe partial struct VkExportFenceCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportFenceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportFenceCreateInfo"/>.</returns>
        public static VkExportFenceCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportFenceCreateInfo);
            var info = (VkExportFenceCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportFenceCreateInfo; }

            return info;
        }
    }

    // Struct: 122
    public unsafe partial struct VkExportFenceWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportFenceWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportFenceWin32HandleInfoKHR"/>.</returns>
        public static VkExportFenceWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportFenceWin32HandleInfoKHR);
            var info = (VkExportFenceWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportFenceWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 123
    public unsafe partial struct VkExportMemoryAllocateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportMemoryAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportMemoryAllocateInfo"/>.</returns>
        public static VkExportMemoryAllocateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportMemoryAllocateInfo);
            var info = (VkExportMemoryAllocateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportMemoryAllocateInfo; }

            return info;
        }
    }

    // Struct: 124
    public unsafe partial struct VkExportMemoryAllocateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportMemoryAllocateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportMemoryAllocateInfoNV"/>.</returns>
        public static VkExportMemoryAllocateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportMemoryAllocateInfoNV);
            var info = (VkExportMemoryAllocateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportMemoryAllocateInfoNv; }

            return info;
        }
    }

    // Struct: 125
    public unsafe partial struct VkExportMemoryWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportMemoryWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportMemoryWin32HandleInfoKHR"/>.</returns>
        public static VkExportMemoryWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportMemoryWin32HandleInfoKHR);
            var info = (VkExportMemoryWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportMemoryWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 126
    public unsafe partial struct VkExportMemoryWin32HandleInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportMemoryWin32HandleInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportMemoryWin32HandleInfoNV"/>.</returns>
        public static VkExportMemoryWin32HandleInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportMemoryWin32HandleInfoNV);
            var info = (VkExportMemoryWin32HandleInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportMemoryWin32HandleInfoNv; }

            return info;
        }
    }

    // Struct: 127
    public unsafe partial struct VkExportSemaphoreCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportSemaphoreCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportSemaphoreCreateInfo"/>.</returns>
        public static VkExportSemaphoreCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportSemaphoreCreateInfo);
            var info = (VkExportSemaphoreCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportSemaphoreCreateInfo; }

            return info;
        }
    }

    // Struct: 128
    public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExportSemaphoreWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExportSemaphoreWin32HandleInfoKHR"/>.</returns>
        public static VkExportSemaphoreWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExportSemaphoreWin32HandleInfoKHR);
            var info = (VkExportSemaphoreWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExportSemaphoreWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 129
    public unsafe partial struct VkExtensionProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExtensionProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExtensionProperties"/>.</returns>
        public static VkExtensionProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExtensionProperties);
            var info = (VkExtensionProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 130
    public unsafe partial struct VkExtent2D {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExtent2D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExtent2D"/>.</returns>
        public static VkExtent2D* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExtent2D);
            var info = (VkExtent2D*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 131
    public unsafe partial struct VkExtent3D {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExtent3D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExtent3D"/>.</returns>
        public static VkExtent3D* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExtent3D);
            var info = (VkExtent3D*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 132
    public unsafe partial struct VkExternalBufferProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalBufferProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalBufferProperties"/>.</returns>
        public static VkExternalBufferProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalBufferProperties);
            var info = (VkExternalBufferProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalBufferProperties; }

            return info;
        }
    }

    // Struct: 133
    public unsafe partial struct VkExternalFenceProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalFenceProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalFenceProperties"/>.</returns>
        public static VkExternalFenceProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalFenceProperties);
            var info = (VkExternalFenceProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalFenceProperties; }

            return info;
        }
    }

    // Struct: 134
    public unsafe partial struct VkExternalFormatANDROID {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalFormatANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalFormatANDROID"/>.</returns>
        public static VkExternalFormatANDROID* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalFormatANDROID);
            var info = (VkExternalFormatANDROID*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalFormatAndroid; }

            return info;
        }
    }

    // Struct: 135
    public unsafe partial struct VkExternalImageFormatProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalImageFormatProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalImageFormatProperties"/>.</returns>
        public static VkExternalImageFormatProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalImageFormatProperties);
            var info = (VkExternalImageFormatProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalImageFormatProperties; }

            return info;
        }
    }

    // Struct: 136
    public unsafe partial struct VkExternalImageFormatPropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalImageFormatPropertiesNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalImageFormatPropertiesNV"/>.</returns>
        public static VkExternalImageFormatPropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalImageFormatPropertiesNV);
            var info = (VkExternalImageFormatPropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 137
    public unsafe partial struct VkExternalMemoryBufferCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalMemoryBufferCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalMemoryBufferCreateInfo"/>.</returns>
        public static VkExternalMemoryBufferCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalMemoryBufferCreateInfo);
            var info = (VkExternalMemoryBufferCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalMemoryBufferCreateInfo; }

            return info;
        }
    }

    // Struct: 138
    public unsafe partial struct VkExternalMemoryImageCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalMemoryImageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalMemoryImageCreateInfo"/>.</returns>
        public static VkExternalMemoryImageCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalMemoryImageCreateInfo);
            var info = (VkExternalMemoryImageCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalMemoryImageCreateInfo; }

            return info;
        }
    }

    // Struct: 139
    public unsafe partial struct VkExternalMemoryImageCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalMemoryImageCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalMemoryImageCreateInfoNV"/>.</returns>
        public static VkExternalMemoryImageCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalMemoryImageCreateInfoNV);
            var info = (VkExternalMemoryImageCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalMemoryImageCreateInfoNv; }

            return info;
        }
    }

    // Struct: 140
    public unsafe partial struct VkExternalMemoryProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalMemoryProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalMemoryProperties"/>.</returns>
        public static VkExternalMemoryProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalMemoryProperties);
            var info = (VkExternalMemoryProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 141
    public unsafe partial struct VkExternalSemaphoreProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkExternalSemaphoreProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkExternalSemaphoreProperties"/>.</returns>
        public static VkExternalSemaphoreProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkExternalSemaphoreProperties);
            var info = (VkExternalSemaphoreProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ExternalSemaphoreProperties; }

            return info;
        }
    }

    // Struct: 142
    public unsafe partial struct VkFenceCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFenceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFenceCreateInfo"/>.</returns>
        public static VkFenceCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFenceCreateInfo);
            var info = (VkFenceCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.FenceCreateInfo; }

            return info;
        }
    }

    // Struct: 143
    public unsafe partial struct VkFenceGetFdInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFenceGetFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFenceGetFdInfoKHR"/>.</returns>
        public static VkFenceGetFdInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFenceGetFdInfoKHR);
            var info = (VkFenceGetFdInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.FenceGetFdInfoKHR; }

            return info;
        }
    }

    // Struct: 144
    public unsafe partial struct VkFenceGetWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFenceGetWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFenceGetWin32HandleInfoKHR"/>.</returns>
        public static VkFenceGetWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFenceGetWin32HandleInfoKHR);
            var info = (VkFenceGetWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.FenceGetWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 145
    public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFilterCubicImageViewImageFormatPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFilterCubicImageViewImageFormatPropertiesEXT"/>.</returns>
        public static VkFilterCubicImageViewImageFormatPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFilterCubicImageViewImageFormatPropertiesEXT);
            var info = (VkFilterCubicImageViewImageFormatPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.FilterCubicImageViewImageFormatPropertiesExt; }

            return info;
        }
    }

    // Struct: 146
    public unsafe partial struct VkFormatProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFormatProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFormatProperties"/>.</returns>
        public static VkFormatProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFormatProperties);
            var info = (VkFormatProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 147
    public unsafe partial struct VkFormatProperties2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFormatProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFormatProperties2"/>.</returns>
        public static VkFormatProperties2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFormatProperties2);
            var info = (VkFormatProperties2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.FormatProperties2; }

            return info;
        }
    }

    // Struct: 148
    public unsafe partial struct VkFramebufferCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkFramebufferCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkFramebufferCreateInfo"/>.</returns>
        public static VkFramebufferCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkFramebufferCreateInfo);
            var info = (VkFramebufferCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.FramebufferCreateInfo; }

            return info;
        }
    }

    // Struct: 149
    public unsafe partial struct VkGeometryAABBNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkGeometryAABBNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkGeometryAABBNV"/>.</returns>
        public static VkGeometryAABBNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkGeometryAABBNV);
            var info = (VkGeometryAABBNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.GeometryAabbNv; }

            return info;
        }
    }

    // Struct: 150
    public unsafe partial struct VkGeometryDataNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkGeometryDataNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkGeometryDataNV"/>.</returns>
        public static VkGeometryDataNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkGeometryDataNV);
            var info = (VkGeometryDataNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 151
    public unsafe partial struct VkGeometryNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkGeometryNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkGeometryNV"/>.</returns>
        public static VkGeometryNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkGeometryNV);
            var info = (VkGeometryNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.GeometryNv; }

            return info;
        }
    }

    // Struct: 152
    public unsafe partial struct VkGeometryTrianglesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkGeometryTrianglesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkGeometryTrianglesNV"/>.</returns>
        public static VkGeometryTrianglesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkGeometryTrianglesNV);
            var info = (VkGeometryTrianglesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.GeometryTrianglesNv; }

            return info;
        }
    }

    // Struct: 153
    public unsafe partial struct VkGraphicsPipelineCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkGraphicsPipelineCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkGraphicsPipelineCreateInfo"/>.</returns>
        public static VkGraphicsPipelineCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkGraphicsPipelineCreateInfo);
            var info = (VkGraphicsPipelineCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.GraphicsPipelineCreateInfo; }

            return info;
        }
    }

    // Struct: 154
    public unsafe partial struct VkHdrMetadataEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkHdrMetadataEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkHdrMetadataEXT"/>.</returns>
        public static VkHdrMetadataEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkHdrMetadataEXT);
            var info = (VkHdrMetadataEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.HdrMetadataExt; }

            return info;
        }
    }

    // Struct: 155
    public unsafe partial struct VkIOSSurfaceCreateInfoMVK {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkIOSSurfaceCreateInfoMVK"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkIOSSurfaceCreateInfoMVK"/>.</returns>
        public static VkIOSSurfaceCreateInfoMVK* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkIOSSurfaceCreateInfoMVK);
            var info = (VkIOSSurfaceCreateInfoMVK*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.IosSurfaceCreateInfoMvk; }

            return info;
        }
    }

    // Struct: 156
    public unsafe partial struct VkImageBlit {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageBlit"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageBlit"/>.</returns>
        public static VkImageBlit* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageBlit);
            var info = (VkImageBlit*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 157
    public unsafe partial struct VkImageCopy {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageCopy"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageCopy"/>.</returns>
        public static VkImageCopy* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageCopy);
            var info = (VkImageCopy*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 158
    public unsafe partial struct VkImageCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageCreateInfo"/>.</returns>
        public static VkImageCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageCreateInfo);
            var info = (VkImageCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageCreateInfo; }

            return info;
        }
    }

    // Struct: 159
    public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageDrmFormatModifierExplicitCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageDrmFormatModifierExplicitCreateInfoEXT"/>.</returns>
        public static VkImageDrmFormatModifierExplicitCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageDrmFormatModifierExplicitCreateInfoEXT);
            var info = (VkImageDrmFormatModifierExplicitCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoExt; }

            return info;
        }
    }

    // Struct: 160
    public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageDrmFormatModifierListCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageDrmFormatModifierListCreateInfoEXT"/>.</returns>
        public static VkImageDrmFormatModifierListCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageDrmFormatModifierListCreateInfoEXT);
            var info = (VkImageDrmFormatModifierListCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageDrmFormatModifierListCreateInfoExt; }

            return info;
        }
    }

    // Struct: 161
    public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageDrmFormatModifierPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageDrmFormatModifierPropertiesEXT"/>.</returns>
        public static VkImageDrmFormatModifierPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageDrmFormatModifierPropertiesEXT);
            var info = (VkImageDrmFormatModifierPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageDrmFormatModifierPropertiesExt; }

            return info;
        }
    }

    // Struct: 162
    public unsafe partial struct VkImageFormatListCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageFormatListCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageFormatListCreateInfoKHR"/>.</returns>
        public static VkImageFormatListCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageFormatListCreateInfoKHR);
            var info = (VkImageFormatListCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageFormatListCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 163
    public unsafe partial struct VkImageFormatProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageFormatProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageFormatProperties"/>.</returns>
        public static VkImageFormatProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageFormatProperties);
            var info = (VkImageFormatProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 164
    public unsafe partial struct VkImageFormatProperties2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageFormatProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageFormatProperties2"/>.</returns>
        public static VkImageFormatProperties2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageFormatProperties2);
            var info = (VkImageFormatProperties2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageFormatProperties2; }

            return info;
        }
    }

    // Struct: 165
    public unsafe partial struct VkImageMemoryBarrier {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageMemoryBarrier"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageMemoryBarrier"/>.</returns>
        public static VkImageMemoryBarrier* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageMemoryBarrier);
            var info = (VkImageMemoryBarrier*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageMemoryBarrier; }

            return info;
        }
    }

    // Struct: 166
    public unsafe partial struct VkImageMemoryRequirementsInfo2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageMemoryRequirementsInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageMemoryRequirementsInfo2"/>.</returns>
        public static VkImageMemoryRequirementsInfo2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageMemoryRequirementsInfo2);
            var info = (VkImageMemoryRequirementsInfo2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageMemoryRequirementsInfo2; }

            return info;
        }
    }

    // Struct: 167
    public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImagePipeSurfaceCreateInfoFUCHSIA"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImagePipeSurfaceCreateInfoFUCHSIA"/>.</returns>
        public static VkImagePipeSurfaceCreateInfoFUCHSIA* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImagePipeSurfaceCreateInfoFUCHSIA);
            var info = (VkImagePipeSurfaceCreateInfoFUCHSIA*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImagepipeSurfaceCreateInfoFuchsia; }

            return info;
        }
    }

    // Struct: 168
    public unsafe partial struct VkImagePlaneMemoryRequirementsInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImagePlaneMemoryRequirementsInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImagePlaneMemoryRequirementsInfo"/>.</returns>
        public static VkImagePlaneMemoryRequirementsInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImagePlaneMemoryRequirementsInfo);
            var info = (VkImagePlaneMemoryRequirementsInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImagePlaneMemoryRequirementsInfo; }

            return info;
        }
    }

    // Struct: 169
    public unsafe partial struct VkImageResolve {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageResolve"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageResolve"/>.</returns>
        public static VkImageResolve* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageResolve);
            var info = (VkImageResolve*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 170
    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageSparseMemoryRequirementsInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageSparseMemoryRequirementsInfo2"/>.</returns>
        public static VkImageSparseMemoryRequirementsInfo2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageSparseMemoryRequirementsInfo2);
            var info = (VkImageSparseMemoryRequirementsInfo2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageSparseMemoryRequirementsInfo2; }

            return info;
        }
    }

    // Struct: 171
    public unsafe partial struct VkImageStencilUsageCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageStencilUsageCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageStencilUsageCreateInfoEXT"/>.</returns>
        public static VkImageStencilUsageCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageStencilUsageCreateInfoEXT);
            var info = (VkImageStencilUsageCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageStencilUsageCreateInfoExt; }

            return info;
        }
    }

    // Struct: 172
    public unsafe partial struct VkImageSubresource {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageSubresource"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageSubresource"/>.</returns>
        public static VkImageSubresource* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageSubresource);
            var info = (VkImageSubresource*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 173
    public unsafe partial struct VkImageSubresourceLayers {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageSubresourceLayers"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageSubresourceLayers"/>.</returns>
        public static VkImageSubresourceLayers* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageSubresourceLayers);
            var info = (VkImageSubresourceLayers*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 174
    public unsafe partial struct VkImageSubresourceRange {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageSubresourceRange"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageSubresourceRange"/>.</returns>
        public static VkImageSubresourceRange* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageSubresourceRange);
            var info = (VkImageSubresourceRange*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 175
    public unsafe partial struct VkImageSwapchainCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageSwapchainCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageSwapchainCreateInfoKHR"/>.</returns>
        public static VkImageSwapchainCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageSwapchainCreateInfoKHR);
            var info = (VkImageSwapchainCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageSwapchainCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 176
    public unsafe partial struct VkImageViewASTCDecodeModeEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageViewASTCDecodeModeEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageViewASTCDecodeModeEXT"/>.</returns>
        public static VkImageViewASTCDecodeModeEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageViewASTCDecodeModeEXT);
            var info = (VkImageViewASTCDecodeModeEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageViewAstcDecodeModeExt; }

            return info;
        }
    }

    // Struct: 177
    public unsafe partial struct VkImageViewCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageViewCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageViewCreateInfo"/>.</returns>
        public static VkImageViewCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageViewCreateInfo);
            var info = (VkImageViewCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageViewCreateInfo; }

            return info;
        }
    }

    // Struct: 178
    public unsafe partial struct VkImageViewHandleInfoNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageViewHandleInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageViewHandleInfoNVX"/>.</returns>
        public static VkImageViewHandleInfoNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageViewHandleInfoNVX);
            var info = (VkImageViewHandleInfoNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageViewHandleInfoNvx; }

            return info;
        }
    }

    // Struct: 179
    public unsafe partial struct VkImageViewUsageCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImageViewUsageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImageViewUsageCreateInfo"/>.</returns>
        public static VkImageViewUsageCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImageViewUsageCreateInfo);
            var info = (VkImageViewUsageCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImageViewUsageCreateInfo; }

            return info;
        }
    }

    // Struct: 180
    public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportAndroidHardwareBufferInfoANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportAndroidHardwareBufferInfoANDROID"/>.</returns>
        public static VkImportAndroidHardwareBufferInfoANDROID* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportAndroidHardwareBufferInfoANDROID);
            var info = (VkImportAndroidHardwareBufferInfoANDROID*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportAndroidHardwareBufferInfoAndroid; }

            return info;
        }
    }

    // Struct: 181
    public unsafe partial struct VkImportFenceFdInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportFenceFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportFenceFdInfoKHR"/>.</returns>
        public static VkImportFenceFdInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportFenceFdInfoKHR);
            var info = (VkImportFenceFdInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportFenceFdInfoKHR; }

            return info;
        }
    }

    // Struct: 182
    public unsafe partial struct VkImportFenceWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportFenceWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportFenceWin32HandleInfoKHR"/>.</returns>
        public static VkImportFenceWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportFenceWin32HandleInfoKHR);
            var info = (VkImportFenceWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportFenceWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 183
    public unsafe partial struct VkImportMemoryFdInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportMemoryFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportMemoryFdInfoKHR"/>.</returns>
        public static VkImportMemoryFdInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportMemoryFdInfoKHR);
            var info = (VkImportMemoryFdInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportMemoryFdInfoKHR; }

            return info;
        }
    }

    // Struct: 184
    public unsafe partial struct VkImportMemoryHostPointerInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportMemoryHostPointerInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportMemoryHostPointerInfoEXT"/>.</returns>
        public static VkImportMemoryHostPointerInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportMemoryHostPointerInfoEXT);
            var info = (VkImportMemoryHostPointerInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportMemoryHostPointerInfoExt; }

            return info;
        }
    }

    // Struct: 185
    public unsafe partial struct VkImportMemoryWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportMemoryWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportMemoryWin32HandleInfoKHR"/>.</returns>
        public static VkImportMemoryWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportMemoryWin32HandleInfoKHR);
            var info = (VkImportMemoryWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportMemoryWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 186
    public unsafe partial struct VkImportMemoryWin32HandleInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportMemoryWin32HandleInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportMemoryWin32HandleInfoNV"/>.</returns>
        public static VkImportMemoryWin32HandleInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportMemoryWin32HandleInfoNV);
            var info = (VkImportMemoryWin32HandleInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportMemoryWin32HandleInfoNv; }

            return info;
        }
    }

    // Struct: 187
    public unsafe partial struct VkImportSemaphoreFdInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportSemaphoreFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportSemaphoreFdInfoKHR"/>.</returns>
        public static VkImportSemaphoreFdInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportSemaphoreFdInfoKHR);
            var info = (VkImportSemaphoreFdInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportSemaphoreFdInfoKHR; }

            return info;
        }
    }

    // Struct: 188
    public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkImportSemaphoreWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkImportSemaphoreWin32HandleInfoKHR"/>.</returns>
        public static VkImportSemaphoreWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkImportSemaphoreWin32HandleInfoKHR);
            var info = (VkImportSemaphoreWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ImportSemaphoreWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 189
    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkIndirectCommandsLayoutCreateInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkIndirectCommandsLayoutCreateInfoNVX"/>.</returns>
        public static VkIndirectCommandsLayoutCreateInfoNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkIndirectCommandsLayoutCreateInfoNVX);
            var info = (VkIndirectCommandsLayoutCreateInfoNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.IndirectCommandsLayoutCreateInfoNvx; }

            return info;
        }
    }

    // Struct: 190
    public unsafe partial struct VkIndirectCommandsLayoutTokenNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkIndirectCommandsLayoutTokenNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkIndirectCommandsLayoutTokenNVX"/>.</returns>
        public static VkIndirectCommandsLayoutTokenNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkIndirectCommandsLayoutTokenNVX);
            var info = (VkIndirectCommandsLayoutTokenNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 191
    public unsafe partial struct VkIndirectCommandsTokenNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkIndirectCommandsTokenNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkIndirectCommandsTokenNVX"/>.</returns>
        public static VkIndirectCommandsTokenNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkIndirectCommandsTokenNVX);
            var info = (VkIndirectCommandsTokenNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 192
    public unsafe partial struct VkInputAttachmentAspectReference {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkInputAttachmentAspectReference"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkInputAttachmentAspectReference"/>.</returns>
        public static VkInputAttachmentAspectReference* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkInputAttachmentAspectReference);
            var info = (VkInputAttachmentAspectReference*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 193
    public unsafe partial struct VkInstanceCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkInstanceCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkInstanceCreateInfo"/>.</returns>
        public static VkInstanceCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkInstanceCreateInfo);
            var info = (VkInstanceCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.InstanceCreateInfo; }

            return info;
        }
    }

    // Struct: 194
    public unsafe partial struct VkLayerProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkLayerProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkLayerProperties"/>.</returns>
        public static VkLayerProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkLayerProperties);
            var info = (VkLayerProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 195
    public unsafe partial struct VkMacOSSurfaceCreateInfoMVK {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMacOSSurfaceCreateInfoMVK"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMacOSSurfaceCreateInfoMVK"/>.</returns>
        public static VkMacOSSurfaceCreateInfoMVK* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMacOSSurfaceCreateInfoMVK);
            var info = (VkMacOSSurfaceCreateInfoMVK*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MacosSurfaceCreateInfoMvk; }

            return info;
        }
    }

    // Struct: 196
    public unsafe partial struct VkMappedMemoryRange {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMappedMemoryRange"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMappedMemoryRange"/>.</returns>
        public static VkMappedMemoryRange* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMappedMemoryRange);
            var info = (VkMappedMemoryRange*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MappedMemoryRange; }

            return info;
        }
    }

    // Struct: 197
    public unsafe partial struct VkMemoryAllocateFlagsInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryAllocateFlagsInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryAllocateFlagsInfo"/>.</returns>
        public static VkMemoryAllocateFlagsInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryAllocateFlagsInfo);
            var info = (VkMemoryAllocateFlagsInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryAllocateFlagsInfo; }

            return info;
        }
    }

    // Struct: 198
    public unsafe partial struct VkMemoryAllocateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryAllocateInfo"/>.</returns>
        public static VkMemoryAllocateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryAllocateInfo);
            var info = (VkMemoryAllocateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryAllocateInfo; }

            return info;
        }
    }

    // Struct: 199
    public unsafe partial struct VkMemoryBarrier {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryBarrier"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryBarrier"/>.</returns>
        public static VkMemoryBarrier* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryBarrier);
            var info = (VkMemoryBarrier*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryBarrier; }

            return info;
        }
    }

    // Struct: 200
    public unsafe partial struct VkMemoryDedicatedAllocateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryDedicatedAllocateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryDedicatedAllocateInfo"/>.</returns>
        public static VkMemoryDedicatedAllocateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryDedicatedAllocateInfo);
            var info = (VkMemoryDedicatedAllocateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryDedicatedAllocateInfo; }

            return info;
        }
    }

    // Struct: 201
    public unsafe partial struct VkMemoryDedicatedRequirements {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryDedicatedRequirements"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryDedicatedRequirements"/>.</returns>
        public static VkMemoryDedicatedRequirements* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryDedicatedRequirements);
            var info = (VkMemoryDedicatedRequirements*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryDedicatedRequirements; }

            return info;
        }
    }

    // Struct: 202
    public unsafe partial struct VkMemoryFdPropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryFdPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryFdPropertiesKHR"/>.</returns>
        public static VkMemoryFdPropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryFdPropertiesKHR);
            var info = (VkMemoryFdPropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryFdPropertiesKHR; }

            return info;
        }
    }

    // Struct: 203
    public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID"/>.</returns>
        public static VkMemoryGetAndroidHardwareBufferInfoANDROID* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryGetAndroidHardwareBufferInfoANDROID);
            var info = (VkMemoryGetAndroidHardwareBufferInfoANDROID*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryGetAndroidHardwareBufferInfoAndroid; }

            return info;
        }
    }

    // Struct: 204
    public unsafe partial struct VkMemoryGetFdInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryGetFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryGetFdInfoKHR"/>.</returns>
        public static VkMemoryGetFdInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryGetFdInfoKHR);
            var info = (VkMemoryGetFdInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryGetFdInfoKHR; }

            return info;
        }
    }

    // Struct: 205
    public unsafe partial struct VkMemoryGetWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryGetWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryGetWin32HandleInfoKHR"/>.</returns>
        public static VkMemoryGetWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryGetWin32HandleInfoKHR);
            var info = (VkMemoryGetWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryGetWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 206
    public unsafe partial struct VkMemoryHeap {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryHeap"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryHeap"/>.</returns>
        public static VkMemoryHeap* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryHeap);
            var info = (VkMemoryHeap*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 207
    public unsafe partial struct VkMemoryHostPointerPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryHostPointerPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryHostPointerPropertiesEXT"/>.</returns>
        public static VkMemoryHostPointerPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryHostPointerPropertiesEXT);
            var info = (VkMemoryHostPointerPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryHostPointerPropertiesExt; }

            return info;
        }
    }

    // Struct: 208
    public unsafe partial struct VkMemoryPriorityAllocateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryPriorityAllocateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryPriorityAllocateInfoEXT"/>.</returns>
        public static VkMemoryPriorityAllocateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryPriorityAllocateInfoEXT);
            var info = (VkMemoryPriorityAllocateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryPriorityAllocateInfoExt; }

            return info;
        }
    }

    // Struct: 209
    public unsafe partial struct VkMemoryRequirements {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryRequirements"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryRequirements"/>.</returns>
        public static VkMemoryRequirements* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryRequirements);
            var info = (VkMemoryRequirements*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 210
    public unsafe partial struct VkMemoryRequirements2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryRequirements2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryRequirements2"/>.</returns>
        public static VkMemoryRequirements2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryRequirements2);
            var info = (VkMemoryRequirements2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryRequirements2; }

            return info;
        }
    }

    // Struct: 211
    public unsafe partial struct VkMemoryType {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryType"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryType"/>.</returns>
        public static VkMemoryType* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryType);
            var info = (VkMemoryType*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 212
    public unsafe partial struct VkMemoryWin32HandlePropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMemoryWin32HandlePropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMemoryWin32HandlePropertiesKHR"/>.</returns>
        public static VkMemoryWin32HandlePropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMemoryWin32HandlePropertiesKHR);
            var info = (VkMemoryWin32HandlePropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MemoryWin32HandlePropertiesKHR; }

            return info;
        }
    }

    // Struct: 213
    public unsafe partial struct VkMetalSurfaceCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMetalSurfaceCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMetalSurfaceCreateInfoEXT"/>.</returns>
        public static VkMetalSurfaceCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMetalSurfaceCreateInfoEXT);
            var info = (VkMetalSurfaceCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MetalSurfaceCreateInfoExt; }

            return info;
        }
    }

    // Struct: 214
    public unsafe partial struct VkMultisamplePropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkMultisamplePropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkMultisamplePropertiesEXT"/>.</returns>
        public static VkMultisamplePropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkMultisamplePropertiesEXT);
            var info = (VkMultisamplePropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.MultisamplePropertiesExt; }

            return info;
        }
    }

    // Struct: 215
    public unsafe partial struct VkObjectTableCreateInfoNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTableCreateInfoNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTableCreateInfoNVX"/>.</returns>
        public static VkObjectTableCreateInfoNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTableCreateInfoNVX);
            var info = (VkObjectTableCreateInfoNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ObjectTableCreateInfoNvx; }

            return info;
        }
    }

    // Struct: 216
    public unsafe partial struct VkObjectTableDescriptorSetEntryNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTableDescriptorSetEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTableDescriptorSetEntryNVX"/>.</returns>
        public static VkObjectTableDescriptorSetEntryNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTableDescriptorSetEntryNVX);
            var info = (VkObjectTableDescriptorSetEntryNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 217
    public unsafe partial struct VkObjectTableEntryNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTableEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTableEntryNVX"/>.</returns>
        public static VkObjectTableEntryNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTableEntryNVX);
            var info = (VkObjectTableEntryNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 218
    public unsafe partial struct VkObjectTableIndexBufferEntryNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTableIndexBufferEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTableIndexBufferEntryNVX"/>.</returns>
        public static VkObjectTableIndexBufferEntryNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTableIndexBufferEntryNVX);
            var info = (VkObjectTableIndexBufferEntryNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 219
    public unsafe partial struct VkObjectTablePipelineEntryNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTablePipelineEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTablePipelineEntryNVX"/>.</returns>
        public static VkObjectTablePipelineEntryNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTablePipelineEntryNVX);
            var info = (VkObjectTablePipelineEntryNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 220
    public unsafe partial struct VkObjectTablePushConstantEntryNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTablePushConstantEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTablePushConstantEntryNVX"/>.</returns>
        public static VkObjectTablePushConstantEntryNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTablePushConstantEntryNVX);
            var info = (VkObjectTablePushConstantEntryNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 221
    public unsafe partial struct VkObjectTableVertexBufferEntryNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkObjectTableVertexBufferEntryNVX"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkObjectTableVertexBufferEntryNVX"/>.</returns>
        public static VkObjectTableVertexBufferEntryNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkObjectTableVertexBufferEntryNVX);
            var info = (VkObjectTableVertexBufferEntryNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 222
    public unsafe partial struct VkOffset2D {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkOffset2D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkOffset2D"/>.</returns>
        public static VkOffset2D* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkOffset2D);
            var info = (VkOffset2D*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 223
    public unsafe partial struct VkOffset3D {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkOffset3D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkOffset3D"/>.</returns>
        public static VkOffset3D* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkOffset3D);
            var info = (VkOffset3D*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 224
    public unsafe partial struct VkPastPresentationTimingGOOGLE {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPastPresentationTimingGOOGLE"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPastPresentationTimingGOOGLE"/>.</returns>
        public static VkPastPresentationTimingGOOGLE* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPastPresentationTimingGOOGLE);
            var info = (VkPastPresentationTimingGOOGLE*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 225
    public unsafe partial struct VkPhysicalDevice16BitStorageFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDevice16BitStorageFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDevice16BitStorageFeatures"/>.</returns>
        public static VkPhysicalDevice16BitStorageFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDevice16BitStorageFeatures);
            var info = (VkPhysicalDevice16BitStorageFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDevice16bitStorageFeatures; }

            return info;
        }
    }

    // Struct: 226
    public unsafe partial struct VkPhysicalDevice8BitStorageFeaturesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDevice8BitStorageFeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDevice8BitStorageFeaturesKHR"/>.</returns>
        public static VkPhysicalDevice8BitStorageFeaturesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDevice8BitStorageFeaturesKHR);
            var info = (VkPhysicalDevice8BitStorageFeaturesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDevice8bitStorageFeaturesKHR; }

            return info;
        }
    }

    // Struct: 227
    public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceASTCDecodeFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceASTCDecodeFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceASTCDecodeFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceASTCDecodeFeaturesEXT);
            var info = (VkPhysicalDeviceASTCDecodeFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceAstcDecodeFeaturesExt; }

            return info;
        }
    }

    // Struct: 228
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT);
            var info = (VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedFeaturesExt; }

            return info;
        }
    }

    // Struct: 229
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT);
            var info = (VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesExt; }

            return info;
        }
    }

    // Struct: 230
    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceBufferDeviceAddressFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceBufferDeviceAddressFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceBufferDeviceAddressFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceBufferDeviceAddressFeaturesEXT);
            var info = (VkPhysicalDeviceBufferDeviceAddressFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt; }

            return info;
        }
    }

    // Struct: 231
    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceComputeShaderDerivativesFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceComputeShaderDerivativesFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceComputeShaderDerivativesFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceComputeShaderDerivativesFeaturesNV);
            var info = (VkPhysicalDeviceComputeShaderDerivativesFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNv; }

            return info;
        }
    }

    // Struct: 232
    public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceConditionalRenderingFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceConditionalRenderingFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceConditionalRenderingFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceConditionalRenderingFeaturesEXT);
            var info = (VkPhysicalDeviceConditionalRenderingFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesExt; }

            return info;
        }
    }

    // Struct: 233
    public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceConservativeRasterizationPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceConservativeRasterizationPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceConservativeRasterizationPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceConservativeRasterizationPropertiesEXT);
            var info = (VkPhysicalDeviceConservativeRasterizationPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesExt; }

            return info;
        }
    }

    // Struct: 234
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceCooperativeMatrixFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceCooperativeMatrixFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceCooperativeMatrixFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceCooperativeMatrixFeaturesNV);
            var info = (VkPhysicalDeviceCooperativeMatrixFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNv; }

            return info;
        }
    }

    // Struct: 235
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV"/>.</returns>
        public static VkPhysicalDeviceCooperativeMatrixPropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV);
            var info = (VkPhysicalDeviceCooperativeMatrixPropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNv; }

            return info;
        }
    }

    // Struct: 236
    public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceCornerSampledImageFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceCornerSampledImageFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceCornerSampledImageFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceCornerSampledImageFeaturesNV);
            var info = (VkPhysicalDeviceCornerSampledImageFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNv; }

            return info;
        }
    }

    // Struct: 237
    public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV);
            var info = (VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv; }

            return info;
        }
    }

    // Struct: 238
    public unsafe partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDepthClipEnableFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDepthClipEnableFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceDepthClipEnableFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDepthClipEnableFeaturesEXT);
            var info = (VkPhysicalDeviceDepthClipEnableFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDepthClipEnableFeaturesExt; }

            return info;
        }
    }

    // Struct: 239
    public unsafe partial struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDepthStencilResolvePropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDepthStencilResolvePropertiesKHR"/>.</returns>
        public static VkPhysicalDeviceDepthStencilResolvePropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDepthStencilResolvePropertiesKHR);
            var info = (VkPhysicalDeviceDepthStencilResolvePropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDepthStencilResolvePropertiesKHR; }

            return info;
        }
    }

    // Struct: 240
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDescriptorIndexingFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDescriptorIndexingFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceDescriptorIndexingFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDescriptorIndexingFeaturesEXT);
            var info = (VkPhysicalDeviceDescriptorIndexingFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDescriptorIndexingFeaturesExt; }

            return info;
        }
    }

    // Struct: 241
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDescriptorIndexingPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDescriptorIndexingPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceDescriptorIndexingPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDescriptorIndexingPropertiesEXT);
            var info = (VkPhysicalDeviceDescriptorIndexingPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDescriptorIndexingPropertiesExt; }

            return info;
        }
    }

    // Struct: 242
    public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDiscardRectanglePropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDiscardRectanglePropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceDiscardRectanglePropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDiscardRectanglePropertiesEXT);
            var info = (VkPhysicalDeviceDiscardRectanglePropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesExt; }

            return info;
        }
    }

    // Struct: 243
    public unsafe partial struct VkPhysicalDeviceDriverPropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceDriverPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceDriverPropertiesKHR"/>.</returns>
        public static VkPhysicalDeviceDriverPropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceDriverPropertiesKHR);
            var info = (VkPhysicalDeviceDriverPropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceDriverPropertiesKHR; }

            return info;
        }
    }

    // Struct: 244
    public unsafe partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceExclusiveScissorFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceExclusiveScissorFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceExclusiveScissorFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceExclusiveScissorFeaturesNV);
            var info = (VkPhysicalDeviceExclusiveScissorFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceExclusiveScissorFeaturesNv; }

            return info;
        }
    }

    // Struct: 245
    public unsafe partial struct VkPhysicalDeviceExternalBufferInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceExternalBufferInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceExternalBufferInfo"/>.</returns>
        public static VkPhysicalDeviceExternalBufferInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceExternalBufferInfo);
            var info = (VkPhysicalDeviceExternalBufferInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceExternalBufferInfo; }

            return info;
        }
    }

    // Struct: 246
    public unsafe partial struct VkPhysicalDeviceExternalFenceInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceExternalFenceInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceExternalFenceInfo"/>.</returns>
        public static VkPhysicalDeviceExternalFenceInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceExternalFenceInfo);
            var info = (VkPhysicalDeviceExternalFenceInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceExternalFenceInfo; }

            return info;
        }
    }

    // Struct: 247
    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceExternalImageFormatInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceExternalImageFormatInfo"/>.</returns>
        public static VkPhysicalDeviceExternalImageFormatInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceExternalImageFormatInfo);
            var info = (VkPhysicalDeviceExternalImageFormatInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceExternalImageFormatInfo; }

            return info;
        }
    }

    // Struct: 248
    public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceExternalMemoryHostPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceExternalMemoryHostPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceExternalMemoryHostPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceExternalMemoryHostPropertiesEXT);
            var info = (VkPhysicalDeviceExternalMemoryHostPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesExt; }

            return info;
        }
    }

    // Struct: 249
    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceExternalSemaphoreInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceExternalSemaphoreInfo"/>.</returns>
        public static VkPhysicalDeviceExternalSemaphoreInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceExternalSemaphoreInfo);
            var info = (VkPhysicalDeviceExternalSemaphoreInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceExternalSemaphoreInfo; }

            return info;
        }
    }

    // Struct: 250
    public unsafe partial struct VkPhysicalDeviceFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFeatures"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFeatures"/>.</returns>
        public static VkPhysicalDeviceFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFeatures);
            var info = (VkPhysicalDeviceFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 251
    public unsafe partial struct VkPhysicalDeviceFeatures2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFeatures2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFeatures2"/>.</returns>
        public static VkPhysicalDeviceFeatures2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFeatures2);
            var info = (VkPhysicalDeviceFeatures2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceFeatures2; }

            return info;
        }
    }

    // Struct: 252
    public unsafe partial struct VkPhysicalDeviceFloat16Int8FeaturesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFloat16Int8FeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFloat16Int8FeaturesKHR"/>.</returns>
        public static VkPhysicalDeviceFloat16Int8FeaturesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFloat16Int8FeaturesKHR);
            var info = (VkPhysicalDeviceFloat16Int8FeaturesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceFloat16Int8FeaturesKHR; }

            return info;
        }
    }

    // Struct: 253
    public unsafe partial struct VkPhysicalDeviceFloatControlsPropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFloatControlsPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFloatControlsPropertiesKHR"/>.</returns>
        public static VkPhysicalDeviceFloatControlsPropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFloatControlsPropertiesKHR);
            var info = (VkPhysicalDeviceFloatControlsPropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceFloatControlsPropertiesKHR; }

            return info;
        }
    }

    // Struct: 254
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFragmentDensityMapFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFragmentDensityMapFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceFragmentDensityMapFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFragmentDensityMapFeaturesEXT);
            var info = (VkPhysicalDeviceFragmentDensityMapFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesExt; }

            return info;
        }
    }

    // Struct: 255
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFragmentDensityMapPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFragmentDensityMapPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceFragmentDensityMapPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFragmentDensityMapPropertiesEXT);
            var info = (VkPhysicalDeviceFragmentDensityMapPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesExt; }

            return info;
        }
    }

    // Struct: 256
    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV);
            var info = (VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesNv; }

            return info;
        }
    }

    // Struct: 257
    public unsafe partial struct VkPhysicalDeviceGroupProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceGroupProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceGroupProperties"/>.</returns>
        public static VkPhysicalDeviceGroupProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceGroupProperties);
            var info = (VkPhysicalDeviceGroupProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceGroupProperties; }

            return info;
        }
    }

    // Struct: 258
    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceHostQueryResetFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceHostQueryResetFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceHostQueryResetFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceHostQueryResetFeaturesEXT);
            var info = (VkPhysicalDeviceHostQueryResetFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceHostQueryResetFeaturesExt; }

            return info;
        }
    }

    // Struct: 259
    public unsafe partial struct VkPhysicalDeviceIDProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceIDProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceIDProperties"/>.</returns>
        public static VkPhysicalDeviceIDProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceIDProperties);
            var info = (VkPhysicalDeviceIDProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceIdProperties; }

            return info;
        }
    }

    // Struct: 260
    public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceImageDrmFormatModifierInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceImageDrmFormatModifierInfoEXT"/>.</returns>
        public static VkPhysicalDeviceImageDrmFormatModifierInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceImageDrmFormatModifierInfoEXT);
            var info = (VkPhysicalDeviceImageDrmFormatModifierInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoExt; }

            return info;
        }
    }

    // Struct: 261
    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceImageFormatInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceImageFormatInfo2"/>.</returns>
        public static VkPhysicalDeviceImageFormatInfo2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceImageFormatInfo2);
            var info = (VkPhysicalDeviceImageFormatInfo2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceImageFormatInfo2; }

            return info;
        }
    }

    // Struct: 262
    public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceImageViewImageFormatInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceImageViewImageFormatInfoEXT"/>.</returns>
        public static VkPhysicalDeviceImageViewImageFormatInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceImageViewImageFormatInfoEXT);
            var info = (VkPhysicalDeviceImageViewImageFormatInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceImageViewImageFormatInfoExt; }

            return info;
        }
    }

    // Struct: 263
    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceInlineUniformBlockFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceInlineUniformBlockFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceInlineUniformBlockFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceInlineUniformBlockFeaturesEXT);
            var info = (VkPhysicalDeviceInlineUniformBlockFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceInlineUniformBlockFeaturesExt; }

            return info;
        }
    }

    // Struct: 264
    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceInlineUniformBlockPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceInlineUniformBlockPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceInlineUniformBlockPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceInlineUniformBlockPropertiesEXT);
            var info = (VkPhysicalDeviceInlineUniformBlockPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceInlineUniformBlockPropertiesExt; }

            return info;
        }
    }

    // Struct: 265
    public unsafe partial struct VkPhysicalDeviceLimits {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceLimits"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceLimits"/>.</returns>
        public static VkPhysicalDeviceLimits* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceLimits);
            var info = (VkPhysicalDeviceLimits*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 266
    public unsafe partial struct VkPhysicalDeviceMaintenance3Properties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMaintenance3Properties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMaintenance3Properties"/>.</returns>
        public static VkPhysicalDeviceMaintenance3Properties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMaintenance3Properties);
            var info = (VkPhysicalDeviceMaintenance3Properties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMaintenance3Properties; }

            return info;
        }
    }

    // Struct: 267
    public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMemoryBudgetPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMemoryBudgetPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceMemoryBudgetPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMemoryBudgetPropertiesEXT);
            var info = (VkPhysicalDeviceMemoryBudgetPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesExt; }

            return info;
        }
    }

    // Struct: 268
    public unsafe partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMemoryPriorityFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMemoryPriorityFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceMemoryPriorityFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMemoryPriorityFeaturesEXT);
            var info = (VkPhysicalDeviceMemoryPriorityFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMemoryPriorityFeaturesExt; }

            return info;
        }
    }

    // Struct: 269
    public unsafe partial struct VkPhysicalDeviceMemoryProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMemoryProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMemoryProperties"/>.</returns>
        public static VkPhysicalDeviceMemoryProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMemoryProperties);
            var info = (VkPhysicalDeviceMemoryProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 270
    public unsafe partial struct VkPhysicalDeviceMemoryProperties2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMemoryProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMemoryProperties2"/>.</returns>
        public static VkPhysicalDeviceMemoryProperties2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMemoryProperties2);
            var info = (VkPhysicalDeviceMemoryProperties2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMemoryProperties2; }

            return info;
        }
    }

    // Struct: 271
    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMeshShaderFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMeshShaderFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceMeshShaderFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMeshShaderFeaturesNV);
            var info = (VkPhysicalDeviceMeshShaderFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesNv; }

            return info;
        }
    }

    // Struct: 272
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMeshShaderPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMeshShaderPropertiesNV"/>.</returns>
        public static VkPhysicalDeviceMeshShaderPropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMeshShaderPropertiesNV);
            var info = (VkPhysicalDeviceMeshShaderPropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesNv; }

            return info;
        }
    }

    // Struct: 273
    public unsafe partial struct VkPhysicalDeviceMultiviewFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMultiviewFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMultiviewFeatures"/>.</returns>
        public static VkPhysicalDeviceMultiviewFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMultiviewFeatures);
            var info = (VkPhysicalDeviceMultiviewFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMultiviewFeatures; }

            return info;
        }
    }

    // Struct: 274
    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX"/>.</returns>
        public static VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX);
            var info = (VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx; }

            return info;
        }
    }

    // Struct: 275
    public unsafe partial struct VkPhysicalDeviceMultiviewProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceMultiviewProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceMultiviewProperties"/>.</returns>
        public static VkPhysicalDeviceMultiviewProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceMultiviewProperties);
            var info = (VkPhysicalDeviceMultiviewProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceMultiviewProperties; }

            return info;
        }
    }

    // Struct: 276
    public unsafe partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDevicePCIBusInfoPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDevicePCIBusInfoPropertiesEXT"/>.</returns>
        public static VkPhysicalDevicePCIBusInfoPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDevicePCIBusInfoPropertiesEXT);
            var info = (VkPhysicalDevicePCIBusInfoPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDevicePciBusInfoPropertiesExt; }

            return info;
        }
    }

    // Struct: 277
    public unsafe partial struct VkPhysicalDevicePointClippingProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDevicePointClippingProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDevicePointClippingProperties"/>.</returns>
        public static VkPhysicalDevicePointClippingProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDevicePointClippingProperties);
            var info = (VkPhysicalDevicePointClippingProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDevicePointClippingProperties; }

            return info;
        }
    }

    // Struct: 278
    public unsafe partial struct VkPhysicalDeviceProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceProperties"/>.</returns>
        public static VkPhysicalDeviceProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceProperties);
            var info = (VkPhysicalDeviceProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 279
    public unsafe partial struct VkPhysicalDeviceProperties2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceProperties2"/>.</returns>
        public static VkPhysicalDeviceProperties2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceProperties2);
            var info = (VkPhysicalDeviceProperties2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceProperties2; }

            return info;
        }
    }

    // Struct: 280
    public unsafe partial struct VkPhysicalDeviceProtectedMemoryFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceProtectedMemoryFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceProtectedMemoryFeatures"/>.</returns>
        public static VkPhysicalDeviceProtectedMemoryFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceProtectedMemoryFeatures);
            var info = (VkPhysicalDeviceProtectedMemoryFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceProtectedMemoryFeatures; }

            return info;
        }
    }

    // Struct: 281
    public unsafe partial struct VkPhysicalDeviceProtectedMemoryProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceProtectedMemoryProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceProtectedMemoryProperties"/>.</returns>
        public static VkPhysicalDeviceProtectedMemoryProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceProtectedMemoryProperties);
            var info = (VkPhysicalDeviceProtectedMemoryProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceProtectedMemoryProperties; }

            return info;
        }
    }

    // Struct: 282
    public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDevicePushDescriptorPropertiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDevicePushDescriptorPropertiesKHR"/>.</returns>
        public static VkPhysicalDevicePushDescriptorPropertiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDevicePushDescriptorPropertiesKHR);
            var info = (VkPhysicalDevicePushDescriptorPropertiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDevicePushDescriptorPropertiesKHR; }

            return info;
        }
    }

    // Struct: 283
    public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceRayTracingPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceRayTracingPropertiesNV"/>.</returns>
        public static VkPhysicalDeviceRayTracingPropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceRayTracingPropertiesNV);
            var info = (VkPhysicalDeviceRayTracingPropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceRayTracingPropertiesNv; }

            return info;
        }
    }

    // Struct: 284
    public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV);
            var info = (VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNv; }

            return info;
        }
    }

    // Struct: 285
    public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSampleLocationsPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSampleLocationsPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceSampleLocationsPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSampleLocationsPropertiesEXT);
            var info = (VkPhysicalDeviceSampleLocationsPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceSampleLocationsPropertiesExt; }

            return info;
        }
    }

    // Struct: 286
    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT);
            var info = (VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceSamplerFilterMinmaxPropertiesExt; }

            return info;
        }
    }

    // Struct: 287
    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSamplerYcbcrConversionFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSamplerYcbcrConversionFeatures"/>.</returns>
        public static VkPhysicalDeviceSamplerYcbcrConversionFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSamplerYcbcrConversionFeatures);
            var info = (VkPhysicalDeviceSamplerYcbcrConversionFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures; }

            return info;
        }
    }

    // Struct: 288
    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceScalarBlockLayoutFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceScalarBlockLayoutFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceScalarBlockLayoutFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceScalarBlockLayoutFeaturesEXT);
            var info = (VkPhysicalDeviceScalarBlockLayoutFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceScalarBlockLayoutFeaturesExt; }

            return info;
        }
    }

    // Struct: 289
    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceShaderAtomicInt64FeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceShaderAtomicInt64FeaturesKHR"/>.</returns>
        public static VkPhysicalDeviceShaderAtomicInt64FeaturesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceShaderAtomicInt64FeaturesKHR);
            var info = (VkPhysicalDeviceShaderAtomicInt64FeaturesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceShaderAtomicInt64FeaturesKHR; }

            return info;
        }
    }

    // Struct: 290
    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceShaderCorePropertiesAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceShaderCorePropertiesAMD"/>.</returns>
        public static VkPhysicalDeviceShaderCorePropertiesAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceShaderCorePropertiesAMD);
            var info = (VkPhysicalDeviceShaderCorePropertiesAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceShaderCorePropertiesAmd; }

            return info;
        }
    }

    // Struct: 291
    public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceShaderDrawParametersFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceShaderDrawParametersFeatures"/>.</returns>
        public static VkPhysicalDeviceShaderDrawParametersFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceShaderDrawParametersFeatures);
            var info = (VkPhysicalDeviceShaderDrawParametersFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures; }

            return info;
        }
    }

    // Struct: 292
    public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceShaderImageFootprintFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceShaderImageFootprintFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceShaderImageFootprintFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceShaderImageFootprintFeaturesNV);
            var info = (VkPhysicalDeviceShaderImageFootprintFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceShaderImageFootprintFeaturesNv; }

            return info;
        }
    }

    // Struct: 293
    public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceShadingRateImageFeaturesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceShadingRateImageFeaturesNV"/>.</returns>
        public static VkPhysicalDeviceShadingRateImageFeaturesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceShadingRateImageFeaturesNV);
            var info = (VkPhysicalDeviceShadingRateImageFeaturesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNv; }

            return info;
        }
    }

    // Struct: 294
    public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceShadingRateImagePropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceShadingRateImagePropertiesNV"/>.</returns>
        public static VkPhysicalDeviceShadingRateImagePropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceShadingRateImagePropertiesNV);
            var info = (VkPhysicalDeviceShadingRateImagePropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNv; }

            return info;
        }
    }

    // Struct: 295
    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSparseImageFormatInfo2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSparseImageFormatInfo2"/>.</returns>
        public static VkPhysicalDeviceSparseImageFormatInfo2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSparseImageFormatInfo2);
            var info = (VkPhysicalDeviceSparseImageFormatInfo2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceSparseImageFormatInfo2; }

            return info;
        }
    }

    // Struct: 296
    public unsafe partial struct VkPhysicalDeviceSparseProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSparseProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSparseProperties"/>.</returns>
        public static VkPhysicalDeviceSparseProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSparseProperties);
            var info = (VkPhysicalDeviceSparseProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 297
    public unsafe partial struct VkPhysicalDeviceSubgroupProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSubgroupProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSubgroupProperties"/>.</returns>
        public static VkPhysicalDeviceSubgroupProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSubgroupProperties);
            var info = (VkPhysicalDeviceSubgroupProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceSubgroupProperties; }

            return info;
        }
    }

    // Struct: 298
    public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceSurfaceInfo2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceSurfaceInfo2KHR"/>.</returns>
        public static VkPhysicalDeviceSurfaceInfo2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceSurfaceInfo2KHR);
            var info = (VkPhysicalDeviceSurfaceInfo2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceSurfaceInfo2KHR; }

            return info;
        }
    }

    // Struct: 299
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceTransformFeedbackFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceTransformFeedbackFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceTransformFeedbackFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceTransformFeedbackFeaturesEXT);
            var info = (VkPhysicalDeviceTransformFeedbackFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesExt; }

            return info;
        }
    }

    // Struct: 300
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceTransformFeedbackPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceTransformFeedbackPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceTransformFeedbackPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceTransformFeedbackPropertiesEXT);
            var info = (VkPhysicalDeviceTransformFeedbackPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesExt; }

            return info;
        }
    }

    // Struct: 301
    public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceVariablePointersFeatures"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceVariablePointersFeatures"/>.</returns>
        public static VkPhysicalDeviceVariablePointersFeatures* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceVariablePointersFeatures);
            var info = (VkPhysicalDeviceVariablePointersFeatures*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceVariablePointersFeatures; }

            return info;
        }
    }

    // Struct: 302
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT);
            var info = (VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeaturesExt; }

            return info;
        }
    }

    // Struct: 303
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT"/>.</returns>
        public static VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT);
            var info = (VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesExt; }

            return info;
        }
    }

    // Struct: 304
    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceVulkanMemoryModelFeaturesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceVulkanMemoryModelFeaturesKHR"/>.</returns>
        public static VkPhysicalDeviceVulkanMemoryModelFeaturesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceVulkanMemoryModelFeaturesKHR);
            var info = (VkPhysicalDeviceVulkanMemoryModelFeaturesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceVulkanMemoryModelFeaturesKHR; }

            return info;
        }
    }

    // Struct: 305
    public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPhysicalDeviceYcbcrImageArraysFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPhysicalDeviceYcbcrImageArraysFeaturesEXT"/>.</returns>
        public static VkPhysicalDeviceYcbcrImageArraysFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPhysicalDeviceYcbcrImageArraysFeaturesEXT);
            var info = (VkPhysicalDeviceYcbcrImageArraysFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PhysicalDeviceYcbcrImageArraysFeaturesExt; }

            return info;
        }
    }

    // Struct: 306
    public unsafe partial struct VkPipelineCacheCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineCacheCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineCacheCreateInfo"/>.</returns>
        public static VkPipelineCacheCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineCacheCreateInfo);
            var info = (VkPipelineCacheCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineCacheCreateInfo; }

            return info;
        }
    }

    // Struct: 307
    public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineColorBlendAdvancedStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineColorBlendAdvancedStateCreateInfoEXT"/>.</returns>
        public static VkPipelineColorBlendAdvancedStateCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineColorBlendAdvancedStateCreateInfoEXT);
            var info = (VkPipelineColorBlendAdvancedStateCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoExt; }

            return info;
        }
    }

    // Struct: 308
    public unsafe partial struct VkPipelineColorBlendAttachmentState {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineColorBlendAttachmentState"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineColorBlendAttachmentState"/>.</returns>
        public static VkPipelineColorBlendAttachmentState* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineColorBlendAttachmentState);
            var info = (VkPipelineColorBlendAttachmentState*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 309
    public unsafe partial struct VkPipelineColorBlendStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineColorBlendStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineColorBlendStateCreateInfo"/>.</returns>
        public static VkPipelineColorBlendStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineColorBlendStateCreateInfo);
            var info = (VkPipelineColorBlendStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineColorBlendStateCreateInfo; }

            return info;
        }
    }

    // Struct: 310
    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineCoverageModulationStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineCoverageModulationStateCreateInfoNV"/>.</returns>
        public static VkPipelineCoverageModulationStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineCoverageModulationStateCreateInfoNV);
            var info = (VkPipelineCoverageModulationStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineCoverageModulationStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 311
    public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineCoverageToColorStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineCoverageToColorStateCreateInfoNV"/>.</returns>
        public static VkPipelineCoverageToColorStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineCoverageToColorStateCreateInfoNV);
            var info = (VkPipelineCoverageToColorStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineCoverageToColorStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 312
    public unsafe partial struct VkPipelineCreationFeedbackCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineCreationFeedbackCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineCreationFeedbackCreateInfoEXT"/>.</returns>
        public static VkPipelineCreationFeedbackCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineCreationFeedbackCreateInfoEXT);
            var info = (VkPipelineCreationFeedbackCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineCreationFeedbackCreateInfoExt; }

            return info;
        }
    }

    // Struct: 313
    public unsafe partial struct VkPipelineCreationFeedbackEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineCreationFeedbackEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineCreationFeedbackEXT"/>.</returns>
        public static VkPipelineCreationFeedbackEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineCreationFeedbackEXT);
            var info = (VkPipelineCreationFeedbackEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 314
    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineDepthStencilStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineDepthStencilStateCreateInfo"/>.</returns>
        public static VkPipelineDepthStencilStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineDepthStencilStateCreateInfo);
            var info = (VkPipelineDepthStencilStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineDepthStencilStateCreateInfo; }

            return info;
        }
    }

    // Struct: 315
    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineDiscardRectangleStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineDiscardRectangleStateCreateInfoEXT"/>.</returns>
        public static VkPipelineDiscardRectangleStateCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineDiscardRectangleStateCreateInfoEXT);
            var info = (VkPipelineDiscardRectangleStateCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineDiscardRectangleStateCreateInfoExt; }

            return info;
        }
    }

    // Struct: 316
    public unsafe partial struct VkPipelineDynamicStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineDynamicStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineDynamicStateCreateInfo"/>.</returns>
        public static VkPipelineDynamicStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineDynamicStateCreateInfo);
            var info = (VkPipelineDynamicStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineDynamicStateCreateInfo; }

            return info;
        }
    }

    // Struct: 317
    public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineInputAssemblyStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineInputAssemblyStateCreateInfo"/>.</returns>
        public static VkPipelineInputAssemblyStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineInputAssemblyStateCreateInfo);
            var info = (VkPipelineInputAssemblyStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineInputAssemblyStateCreateInfo; }

            return info;
        }
    }

    // Struct: 318
    public unsafe partial struct VkPipelineLayoutCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineLayoutCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineLayoutCreateInfo"/>.</returns>
        public static VkPipelineLayoutCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineLayoutCreateInfo);
            var info = (VkPipelineLayoutCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineLayoutCreateInfo; }

            return info;
        }
    }

    // Struct: 319
    public unsafe partial struct VkPipelineMultisampleStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineMultisampleStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineMultisampleStateCreateInfo"/>.</returns>
        public static VkPipelineMultisampleStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineMultisampleStateCreateInfo);
            var info = (VkPipelineMultisampleStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineMultisampleStateCreateInfo; }

            return info;
        }
    }

    // Struct: 320
    public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineRasterizationConservativeStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineRasterizationConservativeStateCreateInfoEXT"/>.</returns>
        public static VkPipelineRasterizationConservativeStateCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineRasterizationConservativeStateCreateInfoEXT);
            var info = (VkPipelineRasterizationConservativeStateCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineRasterizationConservativeStateCreateInfoExt; }

            return info;
        }
    }

    // Struct: 321
    public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineRasterizationDepthClipStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineRasterizationDepthClipStateCreateInfoEXT"/>.</returns>
        public static VkPipelineRasterizationDepthClipStateCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineRasterizationDepthClipStateCreateInfoEXT);
            var info = (VkPipelineRasterizationDepthClipStateCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoExt; }

            return info;
        }
    }

    // Struct: 322
    public unsafe partial struct VkPipelineRasterizationStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineRasterizationStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineRasterizationStateCreateInfo"/>.</returns>
        public static VkPipelineRasterizationStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineRasterizationStateCreateInfo);
            var info = (VkPipelineRasterizationStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineRasterizationStateCreateInfo; }

            return info;
        }
    }

    // Struct: 323
    public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineRasterizationStateRasterizationOrderAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineRasterizationStateRasterizationOrderAMD"/>.</returns>
        public static VkPipelineRasterizationStateRasterizationOrderAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineRasterizationStateRasterizationOrderAMD);
            var info = (VkPipelineRasterizationStateRasterizationOrderAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineRasterizationStateRasterizationOrderAmd; }

            return info;
        }
    }

    // Struct: 324
    public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineRasterizationStateStreamCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineRasterizationStateStreamCreateInfoEXT"/>.</returns>
        public static VkPipelineRasterizationStateStreamCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineRasterizationStateStreamCreateInfoEXT);
            var info = (VkPipelineRasterizationStateStreamCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineRasterizationStateStreamCreateInfoExt; }

            return info;
        }
    }

    // Struct: 325
    public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineRepresentativeFragmentTestStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineRepresentativeFragmentTestStateCreateInfoNV"/>.</returns>
        public static VkPipelineRepresentativeFragmentTestStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineRepresentativeFragmentTestStateCreateInfoNV);
            var info = (VkPipelineRepresentativeFragmentTestStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 326
    public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineSampleLocationsStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineSampleLocationsStateCreateInfoEXT"/>.</returns>
        public static VkPipelineSampleLocationsStateCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineSampleLocationsStateCreateInfoEXT);
            var info = (VkPipelineSampleLocationsStateCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineSampleLocationsStateCreateInfoExt; }

            return info;
        }
    }

    // Struct: 327
    public unsafe partial struct VkPipelineShaderStageCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineShaderStageCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineShaderStageCreateInfo"/>.</returns>
        public static VkPipelineShaderStageCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineShaderStageCreateInfo);
            var info = (VkPipelineShaderStageCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineShaderStageCreateInfo; }

            return info;
        }
    }

    // Struct: 328
    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineTessellationDomainOriginStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineTessellationDomainOriginStateCreateInfo"/>.</returns>
        public static VkPipelineTessellationDomainOriginStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineTessellationDomainOriginStateCreateInfo);
            var info = (VkPipelineTessellationDomainOriginStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo; }

            return info;
        }
    }

    // Struct: 329
    public unsafe partial struct VkPipelineTessellationStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineTessellationStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineTessellationStateCreateInfo"/>.</returns>
        public static VkPipelineTessellationStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineTessellationStateCreateInfo);
            var info = (VkPipelineTessellationStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineTessellationStateCreateInfo; }

            return info;
        }
    }

    // Struct: 330
    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineVertexInputDivisorStateCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineVertexInputDivisorStateCreateInfoEXT"/>.</returns>
        public static VkPipelineVertexInputDivisorStateCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineVertexInputDivisorStateCreateInfoEXT);
            var info = (VkPipelineVertexInputDivisorStateCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineVertexInputDivisorStateCreateInfoExt; }

            return info;
        }
    }

    // Struct: 331
    public unsafe partial struct VkPipelineVertexInputStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineVertexInputStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineVertexInputStateCreateInfo"/>.</returns>
        public static VkPipelineVertexInputStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineVertexInputStateCreateInfo);
            var info = (VkPipelineVertexInputStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineVertexInputStateCreateInfo; }

            return info;
        }
    }

    // Struct: 332
    public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineViewportCoarseSampleOrderStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineViewportCoarseSampleOrderStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportCoarseSampleOrderStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineViewportCoarseSampleOrderStateCreateInfoNV);
            var info = (VkPipelineViewportCoarseSampleOrderStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 333
    public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineViewportExclusiveScissorStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineViewportExclusiveScissorStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportExclusiveScissorStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineViewportExclusiveScissorStateCreateInfoNV);
            var info = (VkPipelineViewportExclusiveScissorStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 334
    public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineViewportShadingRateImageStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineViewportShadingRateImageStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportShadingRateImageStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineViewportShadingRateImageStateCreateInfoNV);
            var info = (VkPipelineViewportShadingRateImageStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 335
    public unsafe partial struct VkPipelineViewportStateCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineViewportStateCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineViewportStateCreateInfo"/>.</returns>
        public static VkPipelineViewportStateCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineViewportStateCreateInfo);
            var info = (VkPipelineViewportStateCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineViewportStateCreateInfo; }

            return info;
        }
    }

    // Struct: 336
    public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineViewportSwizzleStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineViewportSwizzleStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportSwizzleStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineViewportSwizzleStateCreateInfoNV);
            var info = (VkPipelineViewportSwizzleStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineViewportSwizzleStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 337
    public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPipelineViewportWScalingStateCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPipelineViewportWScalingStateCreateInfoNV"/>.</returns>
        public static VkPipelineViewportWScalingStateCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPipelineViewportWScalingStateCreateInfoNV);
            var info = (VkPipelineViewportWScalingStateCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PipelineViewportWScalingStateCreateInfoNv; }

            return info;
        }
    }

    // Struct: 338
    public unsafe partial struct VkPresentFrameTokenGGP {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPresentFrameTokenGGP"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPresentFrameTokenGGP"/>.</returns>
        public static VkPresentFrameTokenGGP* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPresentFrameTokenGGP);
            var info = (VkPresentFrameTokenGGP*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PresentFrameTokenGgp; }

            return info;
        }
    }

    // Struct: 339
    public unsafe partial struct VkPresentInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPresentInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPresentInfoKHR"/>.</returns>
        public static VkPresentInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPresentInfoKHR);
            var info = (VkPresentInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PresentInfoKHR; }

            return info;
        }
    }

    // Struct: 340
    public unsafe partial struct VkPresentRegionKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPresentRegionKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPresentRegionKHR"/>.</returns>
        public static VkPresentRegionKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPresentRegionKHR);
            var info = (VkPresentRegionKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 341
    public unsafe partial struct VkPresentRegionsKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPresentRegionsKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPresentRegionsKHR"/>.</returns>
        public static VkPresentRegionsKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPresentRegionsKHR);
            var info = (VkPresentRegionsKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PresentRegionsKHR; }

            return info;
        }
    }

    // Struct: 342
    public unsafe partial struct VkPresentTimeGOOGLE {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPresentTimeGOOGLE"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPresentTimeGOOGLE"/>.</returns>
        public static VkPresentTimeGOOGLE* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPresentTimeGOOGLE);
            var info = (VkPresentTimeGOOGLE*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 343
    public unsafe partial struct VkPresentTimesInfoGOOGLE {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPresentTimesInfoGOOGLE"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPresentTimesInfoGOOGLE"/>.</returns>
        public static VkPresentTimesInfoGOOGLE* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPresentTimesInfoGOOGLE);
            var info = (VkPresentTimesInfoGOOGLE*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.PresentTimesInfoGoogle; }

            return info;
        }
    }

    // Struct: 344
    public unsafe partial struct VkProtectedSubmitInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkProtectedSubmitInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkProtectedSubmitInfo"/>.</returns>
        public static VkProtectedSubmitInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkProtectedSubmitInfo);
            var info = (VkProtectedSubmitInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ProtectedSubmitInfo; }

            return info;
        }
    }

    // Struct: 345
    public unsafe partial struct VkPushConstantRange {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkPushConstantRange"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkPushConstantRange"/>.</returns>
        public static VkPushConstantRange* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkPushConstantRange);
            var info = (VkPushConstantRange*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 346
    public unsafe partial struct VkQueryPoolCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkQueryPoolCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkQueryPoolCreateInfo"/>.</returns>
        public static VkQueryPoolCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkQueryPoolCreateInfo);
            var info = (VkQueryPoolCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.QueryPoolCreateInfo; }

            return info;
        }
    }

    // Struct: 347
    public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkQueueFamilyCheckpointPropertiesNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkQueueFamilyCheckpointPropertiesNV"/>.</returns>
        public static VkQueueFamilyCheckpointPropertiesNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkQueueFamilyCheckpointPropertiesNV);
            var info = (VkQueueFamilyCheckpointPropertiesNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.QueueFamilyCheckpointPropertiesNv; }

            return info;
        }
    }

    // Struct: 348
    public unsafe partial struct VkQueueFamilyProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkQueueFamilyProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkQueueFamilyProperties"/>.</returns>
        public static VkQueueFamilyProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkQueueFamilyProperties);
            var info = (VkQueueFamilyProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 349
    public unsafe partial struct VkQueueFamilyProperties2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkQueueFamilyProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkQueueFamilyProperties2"/>.</returns>
        public static VkQueueFamilyProperties2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkQueueFamilyProperties2);
            var info = (VkQueueFamilyProperties2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.QueueFamilyProperties2; }

            return info;
        }
    }

    // Struct: 350
    public unsafe partial struct VkRayTracingPipelineCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRayTracingPipelineCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRayTracingPipelineCreateInfoNV"/>.</returns>
        public static VkRayTracingPipelineCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRayTracingPipelineCreateInfoNV);
            var info = (VkRayTracingPipelineCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RayTracingPipelineCreateInfoNv; }

            return info;
        }
    }

    // Struct: 351
    public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRayTracingShaderGroupCreateInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRayTracingShaderGroupCreateInfoNV"/>.</returns>
        public static VkRayTracingShaderGroupCreateInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRayTracingShaderGroupCreateInfoNV);
            var info = (VkRayTracingShaderGroupCreateInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RayTracingShaderGroupCreateInfoNv; }

            return info;
        }
    }

    // Struct: 352
    public unsafe partial struct VkRect2D {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRect2D"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRect2D"/>.</returns>
        public static VkRect2D* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRect2D);
            var info = (VkRect2D*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 353
    public unsafe partial struct VkRectLayerKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRectLayerKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRectLayerKHR"/>.</returns>
        public static VkRectLayerKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRectLayerKHR);
            var info = (VkRectLayerKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 354
    public unsafe partial struct VkRefreshCycleDurationGOOGLE {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRefreshCycleDurationGOOGLE"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRefreshCycleDurationGOOGLE"/>.</returns>
        public static VkRefreshCycleDurationGOOGLE* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRefreshCycleDurationGOOGLE);
            var info = (VkRefreshCycleDurationGOOGLE*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 355
    public unsafe partial struct VkRenderPassBeginInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassBeginInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassBeginInfo"/>.</returns>
        public static VkRenderPassBeginInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassBeginInfo);
            var info = (VkRenderPassBeginInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassBeginInfo; }

            return info;
        }
    }

    // Struct: 356
    public unsafe partial struct VkRenderPassCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassCreateInfo"/>.</returns>
        public static VkRenderPassCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassCreateInfo);
            var info = (VkRenderPassCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassCreateInfo; }

            return info;
        }
    }

    // Struct: 357
    public unsafe partial struct VkRenderPassCreateInfo2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassCreateInfo2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassCreateInfo2KHR"/>.</returns>
        public static VkRenderPassCreateInfo2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassCreateInfo2KHR);
            var info = (VkRenderPassCreateInfo2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassCreateInfo2KHR; }

            return info;
        }
    }

    // Struct: 358
    public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassFragmentDensityMapCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassFragmentDensityMapCreateInfoEXT"/>.</returns>
        public static VkRenderPassFragmentDensityMapCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassFragmentDensityMapCreateInfoEXT);
            var info = (VkRenderPassFragmentDensityMapCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassFragmentDensityMapCreateInfoExt; }

            return info;
        }
    }

    // Struct: 359
    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassInputAttachmentAspectCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassInputAttachmentAspectCreateInfo"/>.</returns>
        public static VkRenderPassInputAttachmentAspectCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassInputAttachmentAspectCreateInfo);
            var info = (VkRenderPassInputAttachmentAspectCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassInputAttachmentAspectCreateInfo; }

            return info;
        }
    }

    // Struct: 360
    public unsafe partial struct VkRenderPassMultiviewCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassMultiviewCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassMultiviewCreateInfo"/>.</returns>
        public static VkRenderPassMultiviewCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassMultiviewCreateInfo);
            var info = (VkRenderPassMultiviewCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassMultiviewCreateInfo; }

            return info;
        }
    }

    // Struct: 361
    public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkRenderPassSampleLocationsBeginInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkRenderPassSampleLocationsBeginInfoEXT"/>.</returns>
        public static VkRenderPassSampleLocationsBeginInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkRenderPassSampleLocationsBeginInfoEXT);
            var info = (VkRenderPassSampleLocationsBeginInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.RenderPassSampleLocationsBeginInfoExt; }

            return info;
        }
    }

    // Struct: 362
    public unsafe partial struct VkSampleLocationEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSampleLocationEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSampleLocationEXT"/>.</returns>
        public static VkSampleLocationEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSampleLocationEXT);
            var info = (VkSampleLocationEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 363
    public unsafe partial struct VkSampleLocationsInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSampleLocationsInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSampleLocationsInfoEXT"/>.</returns>
        public static VkSampleLocationsInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSampleLocationsInfoEXT);
            var info = (VkSampleLocationsInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SampleLocationsInfoExt; }

            return info;
        }
    }

    // Struct: 364
    public unsafe partial struct VkSamplerCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSamplerCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSamplerCreateInfo"/>.</returns>
        public static VkSamplerCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSamplerCreateInfo);
            var info = (VkSamplerCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SamplerCreateInfo; }

            return info;
        }
    }

    // Struct: 365
    public unsafe partial struct VkSamplerReductionModeCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSamplerReductionModeCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSamplerReductionModeCreateInfoEXT"/>.</returns>
        public static VkSamplerReductionModeCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSamplerReductionModeCreateInfoEXT);
            var info = (VkSamplerReductionModeCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SamplerReductionModeCreateInfoExt; }

            return info;
        }
    }

    // Struct: 366
    public unsafe partial struct VkSamplerYcbcrConversionCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSamplerYcbcrConversionCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSamplerYcbcrConversionCreateInfo"/>.</returns>
        public static VkSamplerYcbcrConversionCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSamplerYcbcrConversionCreateInfo);
            var info = (VkSamplerYcbcrConversionCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SamplerYcbcrConversionCreateInfo; }

            return info;
        }
    }

    // Struct: 367
    public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSamplerYcbcrConversionImageFormatProperties"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSamplerYcbcrConversionImageFormatProperties"/>.</returns>
        public static VkSamplerYcbcrConversionImageFormatProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSamplerYcbcrConversionImageFormatProperties);
            var info = (VkSamplerYcbcrConversionImageFormatProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SamplerYcbcrConversionImageFormatProperties; }

            return info;
        }
    }

    // Struct: 368
    public unsafe partial struct VkSamplerYcbcrConversionInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSamplerYcbcrConversionInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSamplerYcbcrConversionInfo"/>.</returns>
        public static VkSamplerYcbcrConversionInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSamplerYcbcrConversionInfo);
            var info = (VkSamplerYcbcrConversionInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SamplerYcbcrConversionInfo; }

            return info;
        }
    }

    // Struct: 369
    public unsafe partial struct VkSemaphoreCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSemaphoreCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSemaphoreCreateInfo"/>.</returns>
        public static VkSemaphoreCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSemaphoreCreateInfo);
            var info = (VkSemaphoreCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SemaphoreCreateInfo; }

            return info;
        }
    }

    // Struct: 370
    public unsafe partial struct VkSemaphoreGetFdInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSemaphoreGetFdInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSemaphoreGetFdInfoKHR"/>.</returns>
        public static VkSemaphoreGetFdInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSemaphoreGetFdInfoKHR);
            var info = (VkSemaphoreGetFdInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SemaphoreGetFdInfoKHR; }

            return info;
        }
    }

    // Struct: 371
    public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSemaphoreGetWin32HandleInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSemaphoreGetWin32HandleInfoKHR"/>.</returns>
        public static VkSemaphoreGetWin32HandleInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSemaphoreGetWin32HandleInfoKHR);
            var info = (VkSemaphoreGetWin32HandleInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SemaphoreGetWin32HandleInfoKHR; }

            return info;
        }
    }

    // Struct: 372
    public unsafe partial struct VkShaderModuleCreateInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkShaderModuleCreateInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkShaderModuleCreateInfo"/>.</returns>
        public static VkShaderModuleCreateInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkShaderModuleCreateInfo);
            var info = (VkShaderModuleCreateInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ShaderModuleCreateInfo; }

            return info;
        }
    }

    // Struct: 373
    public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkShaderModuleValidationCacheCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkShaderModuleValidationCacheCreateInfoEXT"/>.</returns>
        public static VkShaderModuleValidationCacheCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkShaderModuleValidationCacheCreateInfoEXT);
            var info = (VkShaderModuleValidationCacheCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ShaderModuleValidationCacheCreateInfoExt; }

            return info;
        }
    }

    // Struct: 374
    public unsafe partial struct VkShaderResourceUsageAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkShaderResourceUsageAMD"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkShaderResourceUsageAMD"/>.</returns>
        public static VkShaderResourceUsageAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkShaderResourceUsageAMD);
            var info = (VkShaderResourceUsageAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 375
    public unsafe partial struct VkShaderStatisticsInfoAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkShaderStatisticsInfoAMD"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkShaderStatisticsInfoAMD"/>.</returns>
        public static VkShaderStatisticsInfoAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkShaderStatisticsInfoAMD);
            var info = (VkShaderStatisticsInfoAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 376
    public unsafe partial struct VkShadingRatePaletteNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkShadingRatePaletteNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkShadingRatePaletteNV"/>.</returns>
        public static VkShadingRatePaletteNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkShadingRatePaletteNV);
            var info = (VkShadingRatePaletteNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 377
    public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSharedPresentSurfaceCapabilitiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSharedPresentSurfaceCapabilitiesKHR"/>.</returns>
        public static VkSharedPresentSurfaceCapabilitiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSharedPresentSurfaceCapabilitiesKHR);
            var info = (VkSharedPresentSurfaceCapabilitiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SharedPresentSurfaceCapabilitiesKHR; }

            return info;
        }
    }

    // Struct: 378
    public unsafe partial struct VkSparseBufferMemoryBindInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseBufferMemoryBindInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseBufferMemoryBindInfo"/>.</returns>
        public static VkSparseBufferMemoryBindInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseBufferMemoryBindInfo);
            var info = (VkSparseBufferMemoryBindInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 379
    public unsafe partial struct VkSparseImageFormatProperties {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageFormatProperties"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageFormatProperties"/>.</returns>
        public static VkSparseImageFormatProperties* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageFormatProperties);
            var info = (VkSparseImageFormatProperties*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 380
    public unsafe partial struct VkSparseImageFormatProperties2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageFormatProperties2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageFormatProperties2"/>.</returns>
        public static VkSparseImageFormatProperties2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageFormatProperties2);
            var info = (VkSparseImageFormatProperties2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SparseImageFormatProperties2; }

            return info;
        }
    }

    // Struct: 381
    public unsafe partial struct VkSparseImageMemoryBind {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageMemoryBind"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageMemoryBind"/>.</returns>
        public static VkSparseImageMemoryBind* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageMemoryBind);
            var info = (VkSparseImageMemoryBind*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 382
    public unsafe partial struct VkSparseImageMemoryBindInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageMemoryBindInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageMemoryBindInfo"/>.</returns>
        public static VkSparseImageMemoryBindInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageMemoryBindInfo);
            var info = (VkSparseImageMemoryBindInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 383
    public unsafe partial struct VkSparseImageMemoryRequirements {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageMemoryRequirements"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageMemoryRequirements"/>.</returns>
        public static VkSparseImageMemoryRequirements* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageMemoryRequirements);
            var info = (VkSparseImageMemoryRequirements*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 384
    public unsafe partial struct VkSparseImageMemoryRequirements2 {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageMemoryRequirements2"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageMemoryRequirements2"/>.</returns>
        public static VkSparseImageMemoryRequirements2* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageMemoryRequirements2);
            var info = (VkSparseImageMemoryRequirements2*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SparseImageMemoryRequirements2; }

            return info;
        }
    }

    // Struct: 385
    public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseImageOpaqueMemoryBindInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseImageOpaqueMemoryBindInfo"/>.</returns>
        public static VkSparseImageOpaqueMemoryBindInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseImageOpaqueMemoryBindInfo);
            var info = (VkSparseImageOpaqueMemoryBindInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 386
    public unsafe partial struct VkSparseMemoryBind {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSparseMemoryBind"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSparseMemoryBind"/>.</returns>
        public static VkSparseMemoryBind* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSparseMemoryBind);
            var info = (VkSparseMemoryBind*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 387
    public unsafe partial struct VkSpecializationInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSpecializationInfo"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSpecializationInfo"/>.</returns>
        public static VkSpecializationInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSpecializationInfo);
            var info = (VkSpecializationInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 388
    public unsafe partial struct VkSpecializationMapEntry {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSpecializationMapEntry"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSpecializationMapEntry"/>.</returns>
        public static VkSpecializationMapEntry* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSpecializationMapEntry);
            var info = (VkSpecializationMapEntry*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 389
    public unsafe partial struct VkStencilOpState {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkStencilOpState"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkStencilOpState"/>.</returns>
        public static VkStencilOpState* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkStencilOpState);
            var info = (VkStencilOpState*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 390
    public unsafe partial struct VkStreamDescriptorSurfaceCreateInfoGGP {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkStreamDescriptorSurfaceCreateInfoGGP"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkStreamDescriptorSurfaceCreateInfoGGP"/>.</returns>
        public static VkStreamDescriptorSurfaceCreateInfoGGP* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkStreamDescriptorSurfaceCreateInfoGGP);
            var info = (VkStreamDescriptorSurfaceCreateInfoGGP*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.StreamDescriptorSurfaceCreateInfoGgp; }

            return info;
        }
    }

    // Struct: 391
    public unsafe partial struct VkSubmitInfo {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubmitInfo"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubmitInfo"/>.</returns>
        public static VkSubmitInfo* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubmitInfo);
            var info = (VkSubmitInfo*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SubmitInfo; }

            return info;
        }
    }

    // Struct: 392
    public unsafe partial struct VkSubpassBeginInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassBeginInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassBeginInfoKHR"/>.</returns>
        public static VkSubpassBeginInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassBeginInfoKHR);
            var info = (VkSubpassBeginInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SubpassBeginInfoKHR; }

            return info;
        }
    }

    // Struct: 393
    public unsafe partial struct VkSubpassDependency {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassDependency"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassDependency"/>.</returns>
        public static VkSubpassDependency* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassDependency);
            var info = (VkSubpassDependency*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 394
    public unsafe partial struct VkSubpassDependency2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassDependency2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassDependency2KHR"/>.</returns>
        public static VkSubpassDependency2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassDependency2KHR);
            var info = (VkSubpassDependency2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SubpassDependency2KHR; }

            return info;
        }
    }

    // Struct: 395
    public unsafe partial struct VkSubpassDescription {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassDescription"/>.</returns>
        public static VkSubpassDescription* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassDescription);
            var info = (VkSubpassDescription*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 396
    public unsafe partial struct VkSubpassDescription2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassDescription2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassDescription2KHR"/>.</returns>
        public static VkSubpassDescription2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassDescription2KHR);
            var info = (VkSubpassDescription2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SubpassDescription2KHR; }

            return info;
        }
    }

    // Struct: 397
    public unsafe partial struct VkSubpassDescriptionDepthStencilResolveKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassDescriptionDepthStencilResolveKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassDescriptionDepthStencilResolveKHR"/>.</returns>
        public static VkSubpassDescriptionDepthStencilResolveKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassDescriptionDepthStencilResolveKHR);
            var info = (VkSubpassDescriptionDepthStencilResolveKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SubpassDescriptionDepthStencilResolveKHR; }

            return info;
        }
    }

    // Struct: 398
    public unsafe partial struct VkSubpassEndInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassEndInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassEndInfoKHR"/>.</returns>
        public static VkSubpassEndInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassEndInfoKHR);
            var info = (VkSubpassEndInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SubpassEndInfoKHR; }

            return info;
        }
    }

    // Struct: 399
    public unsafe partial struct VkSubpassSampleLocationsEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubpassSampleLocationsEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubpassSampleLocationsEXT"/>.</returns>
        public static VkSubpassSampleLocationsEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubpassSampleLocationsEXT);
            var info = (VkSubpassSampleLocationsEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 400
    public unsafe partial struct VkSubresourceLayout {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSubresourceLayout"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSubresourceLayout"/>.</returns>
        public static VkSubresourceLayout* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSubresourceLayout);
            var info = (VkSubresourceLayout*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 401
    public unsafe partial struct VkSurfaceCapabilities2EXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceCapabilities2EXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceCapabilities2EXT"/>.</returns>
        public static VkSurfaceCapabilities2EXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceCapabilities2EXT);
            var info = (VkSurfaceCapabilities2EXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceCapabilities2Ext; }

            return info;
        }
    }

    // Struct: 402
    public unsafe partial struct VkSurfaceCapabilities2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceCapabilities2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceCapabilities2KHR"/>.</returns>
        public static VkSurfaceCapabilities2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceCapabilities2KHR);
            var info = (VkSurfaceCapabilities2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceCapabilities2KHR; }

            return info;
        }
    }

    // Struct: 403
    public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceCapabilitiesFullScreenExclusiveEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceCapabilitiesFullScreenExclusiveEXT"/>.</returns>
        public static VkSurfaceCapabilitiesFullScreenExclusiveEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceCapabilitiesFullScreenExclusiveEXT);
            var info = (VkSurfaceCapabilitiesFullScreenExclusiveEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveExt; }

            return info;
        }
    }

    // Struct: 404
    public unsafe partial struct VkSurfaceCapabilitiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceCapabilitiesKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceCapabilitiesKHR"/>.</returns>
        public static VkSurfaceCapabilitiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceCapabilitiesKHR);
            var info = (VkSurfaceCapabilitiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 405
    public unsafe partial struct VkSurfaceFormat2KHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceFormat2KHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceFormat2KHR"/>.</returns>
        public static VkSurfaceFormat2KHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceFormat2KHR);
            var info = (VkSurfaceFormat2KHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceFormat2KHR; }

            return info;
        }
    }

    // Struct: 406
    public unsafe partial struct VkSurfaceFormatKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceFormatKHR"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceFormatKHR"/>.</returns>
        public static VkSurfaceFormatKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceFormatKHR);
            var info = (VkSurfaceFormatKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 407
    public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceFullScreenExclusiveInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceFullScreenExclusiveInfoEXT"/>.</returns>
        public static VkSurfaceFullScreenExclusiveInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceFullScreenExclusiveInfoEXT);
            var info = (VkSurfaceFullScreenExclusiveInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceFullScreenExclusiveInfoExt; }

            return info;
        }
    }

    // Struct: 408
    public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceFullScreenExclusiveWin32InfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceFullScreenExclusiveWin32InfoEXT"/>.</returns>
        public static VkSurfaceFullScreenExclusiveWin32InfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceFullScreenExclusiveWin32InfoEXT);
            var info = (VkSurfaceFullScreenExclusiveWin32InfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceFullScreenExclusiveWin32InfoExt; }

            return info;
        }
    }

    // Struct: 409
    public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSurfaceProtectedCapabilitiesKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSurfaceProtectedCapabilitiesKHR"/>.</returns>
        public static VkSurfaceProtectedCapabilitiesKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSurfaceProtectedCapabilitiesKHR);
            var info = (VkSurfaceProtectedCapabilitiesKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SurfaceProtectedCapabilitiesKHR; }

            return info;
        }
    }

    // Struct: 410
    public unsafe partial struct VkSwapchainCounterCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSwapchainCounterCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSwapchainCounterCreateInfoEXT"/>.</returns>
        public static VkSwapchainCounterCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSwapchainCounterCreateInfoEXT);
            var info = (VkSwapchainCounterCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SwapchainCounterCreateInfoExt; }

            return info;
        }
    }

    // Struct: 411
    public unsafe partial struct VkSwapchainCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSwapchainCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSwapchainCreateInfoKHR"/>.</returns>
        public static VkSwapchainCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSwapchainCreateInfoKHR);
            var info = (VkSwapchainCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SwapchainCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 412
    public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkSwapchainDisplayNativeHdrCreateInfoAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkSwapchainDisplayNativeHdrCreateInfoAMD"/>.</returns>
        public static VkSwapchainDisplayNativeHdrCreateInfoAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkSwapchainDisplayNativeHdrCreateInfoAMD);
            var info = (VkSwapchainDisplayNativeHdrCreateInfoAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAmd; }

            return info;
        }
    }

    // Struct: 413
    public unsafe partial struct VkTextureLODGatherFormatPropertiesAMD {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkTextureLODGatherFormatPropertiesAMD"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkTextureLODGatherFormatPropertiesAMD"/>.</returns>
        public static VkTextureLODGatherFormatPropertiesAMD* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkTextureLODGatherFormatPropertiesAMD);
            var info = (VkTextureLODGatherFormatPropertiesAMD*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.TextureLodGatherFormatPropertiesAmd; }

            return info;
        }
    }

    // Struct: 414
    public unsafe partial struct VkValidationCacheCreateInfoEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkValidationCacheCreateInfoEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkValidationCacheCreateInfoEXT"/>.</returns>
        public static VkValidationCacheCreateInfoEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkValidationCacheCreateInfoEXT);
            var info = (VkValidationCacheCreateInfoEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ValidationCacheCreateInfoExt; }

            return info;
        }
    }

    // Struct: 415
    public unsafe partial struct VkValidationFeaturesEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkValidationFeaturesEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkValidationFeaturesEXT"/>.</returns>
        public static VkValidationFeaturesEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkValidationFeaturesEXT);
            var info = (VkValidationFeaturesEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ValidationFeaturesExt; }

            return info;
        }
    }

    // Struct: 416
    public unsafe partial struct VkValidationFlagsEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkValidationFlagsEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkValidationFlagsEXT"/>.</returns>
        public static VkValidationFlagsEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkValidationFlagsEXT);
            var info = (VkValidationFlagsEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ValidationFlagsExt; }

            return info;
        }
    }

    // Struct: 417
    public unsafe partial struct VkVertexInputAttributeDescription {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkVertexInputAttributeDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkVertexInputAttributeDescription"/>.</returns>
        public static VkVertexInputAttributeDescription* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkVertexInputAttributeDescription);
            var info = (VkVertexInputAttributeDescription*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 418
    public unsafe partial struct VkVertexInputBindingDescription {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkVertexInputBindingDescription"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkVertexInputBindingDescription"/>.</returns>
        public static VkVertexInputBindingDescription* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkVertexInputBindingDescription);
            var info = (VkVertexInputBindingDescription*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 419
    public unsafe partial struct VkVertexInputBindingDivisorDescriptionEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkVertexInputBindingDivisorDescriptionEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkVertexInputBindingDivisorDescriptionEXT"/>.</returns>
        public static VkVertexInputBindingDivisorDescriptionEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkVertexInputBindingDivisorDescriptionEXT);
            var info = (VkVertexInputBindingDivisorDescriptionEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 420
    public unsafe partial struct VkViSurfaceCreateInfoNN {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkViSurfaceCreateInfoNN"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkViSurfaceCreateInfoNN"/>.</returns>
        public static VkViSurfaceCreateInfoNN* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkViSurfaceCreateInfoNN);
            var info = (VkViSurfaceCreateInfoNN*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.ViSurfaceCreateInfoNn; }

            return info;
        }
    }

    // Struct: 421
    public unsafe partial struct VkViewport {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkViewport"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkViewport"/>.</returns>
        public static VkViewport* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkViewport);
            var info = (VkViewport*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 422
    public unsafe partial struct VkViewportSwizzleNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkViewportSwizzleNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkViewportSwizzleNV"/>.</returns>
        public static VkViewportSwizzleNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkViewportSwizzleNV);
            var info = (VkViewportSwizzleNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 423
    public unsafe partial struct VkViewportWScalingNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkViewportWScalingNV"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkViewportWScalingNV"/>.</returns>
        public static VkViewportWScalingNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkViewportWScalingNV);
            var info = (VkViewportWScalingNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 424
    public unsafe partial struct VkWaylandSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWaylandSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWaylandSurfaceCreateInfoKHR"/>.</returns>
        public static VkWaylandSurfaceCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWaylandSurfaceCreateInfoKHR);
            var info = (VkWaylandSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.WaylandSurfaceCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 425
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWin32KeyedMutexAcquireReleaseInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWin32KeyedMutexAcquireReleaseInfoKHR"/>.</returns>
        public static VkWin32KeyedMutexAcquireReleaseInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWin32KeyedMutexAcquireReleaseInfoKHR);
            var info = (VkWin32KeyedMutexAcquireReleaseInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoKHR; }

            return info;
        }
    }

    // Struct: 426
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWin32KeyedMutexAcquireReleaseInfoNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWin32KeyedMutexAcquireReleaseInfoNV"/>.</returns>
        public static VkWin32KeyedMutexAcquireReleaseInfoNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWin32KeyedMutexAcquireReleaseInfoNV);
            var info = (VkWin32KeyedMutexAcquireReleaseInfoNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNv; }

            return info;
        }
    }

    // Struct: 427
    public unsafe partial struct VkWin32SurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWin32SurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWin32SurfaceCreateInfoKHR"/>.</returns>
        public static VkWin32SurfaceCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWin32SurfaceCreateInfoKHR);
            var info = (VkWin32SurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.Win32SurfaceCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 428
    public unsafe partial struct VkWriteDescriptorSet {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWriteDescriptorSet"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWriteDescriptorSet"/>.</returns>
        public static VkWriteDescriptorSet* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWriteDescriptorSet);
            var info = (VkWriteDescriptorSet*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.WriteDescriptorSet; }

            return info;
        }
    }

    // Struct: 429
    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWriteDescriptorSetAccelerationStructureNV"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWriteDescriptorSetAccelerationStructureNV"/>.</returns>
        public static VkWriteDescriptorSetAccelerationStructureNV* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWriteDescriptorSetAccelerationStructureNV);
            var info = (VkWriteDescriptorSetAccelerationStructureNV*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.WriteDescriptorSetAccelerationStructureNv; }

            return info;
        }
    }

    // Struct: 430
    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlockEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkWriteDescriptorSetInlineUniformBlockEXT"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkWriteDescriptorSetInlineUniformBlockEXT"/>.</returns>
        public static VkWriteDescriptorSetInlineUniformBlockEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkWriteDescriptorSetInlineUniformBlockEXT);
            var info = (VkWriteDescriptorSetInlineUniformBlockEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.WriteDescriptorSetInlineUniformBlockExt; }

            return info;
        }
    }

    // Struct: 431
    public unsafe partial struct VkXYColorEXT {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkXYColorEXT"/> in unmanaged memory.
        /// <para>No 'sType' member exists in this struct.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkXYColorEXT"/>.</returns>
        public static VkXYColorEXT* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkXYColorEXT);
            var info = (VkXYColorEXT*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }

            return info;
        }
    }

    // Struct: 432
    public unsafe partial struct VkXcbSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkXcbSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkXcbSurfaceCreateInfoKHR"/>.</returns>
        public static VkXcbSurfaceCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkXcbSurfaceCreateInfoKHR);
            var info = (VkXcbSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.XcbSurfaceCreateInfoKHR; }

            return info;
        }
    }

    // Struct: 433
    public unsafe partial struct VkXlibSurfaceCreateInfoKHR {
        /// <summary>
        /// Allocate <paramref name="count"/> instances of <see cref="VkXlibSurfaceCreateInfoKHR"/> in unmanaged memory.
        /// <para>The 'sType' member is already set up.</para>
        /// </summary>
        /// <param name="count">how many items to allocate?</param>
        /// <returns>A pointer to the instances of <see cref="VkXlibSurfaceCreateInfoKHR"/>.</returns>
        public static VkXlibSurfaceCreateInfoKHR* Alloc(int count = 1) {
            if (count <= 0) { return null; }

            int size = sizeof(VkXlibSurfaceCreateInfoKHR);
            var info = (VkXlibSurfaceCreateInfoKHR*)Marshal.AllocHGlobal(size * count);
            for (int i = 0; i < count; i++) { Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); }
            for (int i = 0; i < count; i++) { info[i].sType = VkStructureType.XlibSurfaceCreateInfoKHR; }

            return info;
        }
    }

}
