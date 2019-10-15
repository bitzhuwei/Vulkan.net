using System;

namespace Vulkan {
    // Object Handles: 0
    public partial struct VkAccelerationStructureNV {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkAccelerationStructureNV left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkAccelerationStructureNV left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkAccelerationStructureNV right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkAccelerationStructureNV right) {
            return left != right.handle;
        }

        public static implicit operator VkAccelerationStructureNV(UInt64 v) {
            return new VkAccelerationStructureNV() { handle = v };
        }

        public static implicit operator UInt64(VkAccelerationStructureNV v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 1
    public partial struct VkBuffer {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkBuffer left, VkBuffer right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkBuffer left, VkBuffer right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkBuffer left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkBuffer left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkBuffer right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkBuffer right) {
            return left != right.handle;
        }

        public static implicit operator VkBuffer(UInt64 v) {
            return new VkBuffer() { handle = v };
        }

        public static implicit operator UInt64(VkBuffer v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 2
    public partial struct VkBufferView {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkBufferView left, VkBufferView right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkBufferView left, VkBufferView right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkBufferView left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkBufferView left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkBufferView right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkBufferView right) {
            return left != right.handle;
        }

        public static implicit operator VkBufferView(UInt64 v) {
            return new VkBufferView() { handle = v };
        }

        public static implicit operator UInt64(VkBufferView v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 3
    public partial struct VkCommandBuffer {
        //public UInt32 handle;
        // == !=
        public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkCommandBuffer left, UInt32 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkCommandBuffer left, UInt32 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt32 left, VkCommandBuffer right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt32 left, VkCommandBuffer right) {
            return left != right.handle;
        }

        public static implicit operator VkCommandBuffer(UInt32 v) {
            return new VkCommandBuffer() { handle = v };
        }

        public static implicit operator UInt32(VkCommandBuffer v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 4
    public partial struct VkCommandPool {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkCommandPool left, VkCommandPool right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkCommandPool left, VkCommandPool right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkCommandPool left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkCommandPool left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkCommandPool right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkCommandPool right) {
            return left != right.handle;
        }

        public static implicit operator VkCommandPool(UInt64 v) {
            return new VkCommandPool() { handle = v };
        }

        public static implicit operator UInt64(VkCommandPool v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 5
    public partial struct VkDebugReportCallbackEXT {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDebugReportCallbackEXT left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDebugReportCallbackEXT left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDebugReportCallbackEXT right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDebugReportCallbackEXT right) {
            return left != right.handle;
        }

        public static implicit operator VkDebugReportCallbackEXT(UInt64 v) {
            return new VkDebugReportCallbackEXT() { handle = v };
        }

        public static implicit operator UInt64(VkDebugReportCallbackEXT v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 6
    public partial struct VkDebugUtilsMessengerEXT {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDebugUtilsMessengerEXT left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDebugUtilsMessengerEXT left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDebugUtilsMessengerEXT right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDebugUtilsMessengerEXT right) {
            return left != right.handle;
        }

        public static implicit operator VkDebugUtilsMessengerEXT(UInt64 v) {
            return new VkDebugUtilsMessengerEXT() { handle = v };
        }

        public static implicit operator UInt64(VkDebugUtilsMessengerEXT v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 7
    /// <summary>VkDescriptorPool - Opaque handle to a descriptor pool object
    /// <para>A descriptor pool maintains a pool of descriptors, from which descriptorsets are allocated.Descriptor pools are externally synchronized, meaning that the applicationmust not allocate and/or free descriptor sets from the same pool inmultiple threads simultaneously.</para>
    /// <para>Descriptor pools are represented by VkDescriptorPool handles:</para>
    /// </summary>
    public partial struct VkDescriptorPool {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDescriptorPool left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDescriptorPool left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDescriptorPool right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDescriptorPool right) {
            return left != right.handle;
        }

        public static implicit operator VkDescriptorPool(UInt64 v) {
            return new VkDescriptorPool() { handle = v };
        }

        public static implicit operator UInt64(VkDescriptorPool v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 8
    public partial struct VkDescriptorSet {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDescriptorSet left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDescriptorSet left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDescriptorSet right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDescriptorSet right) {
            return left != right.handle;
        }

        public static implicit operator VkDescriptorSet(UInt64 v) {
            return new VkDescriptorSet() { handle = v };
        }

        public static implicit operator UInt64(VkDescriptorSet v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 9
    public partial struct VkDescriptorSetLayout {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDescriptorSetLayout left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDescriptorSetLayout left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDescriptorSetLayout right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDescriptorSetLayout right) {
            return left != right.handle;
        }

        public static implicit operator VkDescriptorSetLayout(UInt64 v) {
            return new VkDescriptorSetLayout() { handle = v };
        }

        public static implicit operator UInt64(VkDescriptorSetLayout v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 10
    public partial struct VkDescriptorUpdateTemplate {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDescriptorUpdateTemplate left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDescriptorUpdateTemplate left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDescriptorUpdateTemplate right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDescriptorUpdateTemplate right) {
            return left != right.handle;
        }

        public static implicit operator VkDescriptorUpdateTemplate(UInt64 v) {
            return new VkDescriptorUpdateTemplate() { handle = v };
        }

        public static implicit operator UInt64(VkDescriptorUpdateTemplate v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 11
    public partial struct VkDevice {
        //public UInt32 handle;
        // == !=
        public static bool operator ==(VkDevice left, VkDevice right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDevice left, VkDevice right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDevice left, UInt32 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDevice left, UInt32 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt32 left, VkDevice right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt32 left, VkDevice right) {
            return left != right.handle;
        }

        public static implicit operator VkDevice(UInt32 v) {
            return new VkDevice() { handle = v };
        }

        public static implicit operator UInt32(VkDevice v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 12
    public partial struct VkDeviceMemory {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDeviceMemory left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDeviceMemory left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDeviceMemory right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDeviceMemory right) {
            return left != right.handle;
        }

        public static implicit operator VkDeviceMemory(UInt64 v) {
            return new VkDeviceMemory() { handle = v };
        }

        public static implicit operator UInt64(VkDeviceMemory v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 13
    public partial struct VkDisplayKHR {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDisplayKHR left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDisplayKHR left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDisplayKHR right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDisplayKHR right) {
            return left != right.handle;
        }

        public static implicit operator VkDisplayKHR(UInt64 v) {
            return new VkDisplayKHR() { handle = v };
        }

        public static implicit operator UInt64(VkDisplayKHR v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 14
    public partial struct VkDisplayModeKHR {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkDisplayModeKHR left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkDisplayModeKHR left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkDisplayModeKHR right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkDisplayModeKHR right) {
            return left != right.handle;
        }

        public static implicit operator VkDisplayModeKHR(UInt64 v) {
            return new VkDisplayModeKHR() { handle = v };
        }

        public static implicit operator UInt64(VkDisplayModeKHR v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 15
    public partial struct VkEvent {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkEvent left, VkEvent right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkEvent left, VkEvent right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkEvent left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkEvent left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkEvent right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkEvent right) {
            return left != right.handle;
        }

        public static implicit operator VkEvent(UInt64 v) {
            return new VkEvent() { handle = v };
        }

        public static implicit operator UInt64(VkEvent v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 16
    public partial struct VkFence {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkFence left, VkFence right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkFence left, VkFence right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkFence left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkFence left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkFence right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkFence right) {
            return left != right.handle;
        }

        public static implicit operator VkFence(UInt64 v) {
            return new VkFence() { handle = v };
        }

        public static implicit operator UInt64(VkFence v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 17
    public partial struct VkFramebuffer {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkFramebuffer left, VkFramebuffer right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkFramebuffer left, VkFramebuffer right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkFramebuffer left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkFramebuffer left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkFramebuffer right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkFramebuffer right) {
            return left != right.handle;
        }

        public static implicit operator VkFramebuffer(UInt64 v) {
            return new VkFramebuffer() { handle = v };
        }

        public static implicit operator UInt64(VkFramebuffer v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 18
    public partial struct VkImage {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkImage left, VkImage right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkImage left, VkImage right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkImage left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkImage left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkImage right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkImage right) {
            return left != right.handle;
        }

        public static implicit operator VkImage(UInt64 v) {
            return new VkImage() { handle = v };
        }

        public static implicit operator UInt64(VkImage v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 19
    public partial struct VkImageView {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkImageView left, VkImageView right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkImageView left, VkImageView right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkImageView left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkImageView left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkImageView right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkImageView right) {
            return left != right.handle;
        }

        public static implicit operator VkImageView(UInt64 v) {
            return new VkImageView() { handle = v };
        }

        public static implicit operator UInt64(VkImageView v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 20
    public partial struct VkIndirectCommandsLayoutNVX {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkIndirectCommandsLayoutNVX left, VkIndirectCommandsLayoutNVX right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkIndirectCommandsLayoutNVX left, VkIndirectCommandsLayoutNVX right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkIndirectCommandsLayoutNVX left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkIndirectCommandsLayoutNVX left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkIndirectCommandsLayoutNVX right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkIndirectCommandsLayoutNVX right) {
            return left != right.handle;
        }

        public static implicit operator VkIndirectCommandsLayoutNVX(UInt64 v) {
            return new VkIndirectCommandsLayoutNVX() { handle = v };
        }

        public static implicit operator UInt64(VkIndirectCommandsLayoutNVX v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 21
    public partial struct VkInstance {
        //public UInt32 handle;
        // == !=
        public static bool operator ==(VkInstance left, VkInstance right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkInstance left, VkInstance right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkInstance left, UInt32 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkInstance left, UInt32 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt32 left, VkInstance right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt32 left, VkInstance right) {
            return left != right.handle;
        }

        public static implicit operator VkInstance(UInt32 v) {
            return new VkInstance() { handle = v };
        }

        public static implicit operator UInt32(VkInstance v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 22
    public partial struct VkObjectTableNVX {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkObjectTableNVX left, VkObjectTableNVX right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkObjectTableNVX left, VkObjectTableNVX right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkObjectTableNVX left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkObjectTableNVX left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkObjectTableNVX right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkObjectTableNVX right) {
            return left != right.handle;
        }

        public static implicit operator VkObjectTableNVX(UInt64 v) {
            return new VkObjectTableNVX() { handle = v };
        }

        public static implicit operator UInt64(VkObjectTableNVX v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 23
    public partial struct VkPhysicalDevice {
        //public UInt32 handle;
        // == !=
        public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkPhysicalDevice left, UInt32 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkPhysicalDevice left, UInt32 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt32 left, VkPhysicalDevice right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt32 left, VkPhysicalDevice right) {
            return left != right.handle;
        }

        public static implicit operator VkPhysicalDevice(UInt32 v) {
            return new VkPhysicalDevice() { handle = v };
        }

        public static implicit operator UInt32(VkPhysicalDevice v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 24
    public partial struct VkPipeline {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkPipeline left, VkPipeline right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkPipeline left, VkPipeline right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkPipeline left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkPipeline left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkPipeline right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkPipeline right) {
            return left != right.handle;
        }

        public static implicit operator VkPipeline(UInt64 v) {
            return new VkPipeline() { handle = v };
        }

        public static implicit operator UInt64(VkPipeline v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 25
    public partial struct VkPipelineCache {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkPipelineCache left, VkPipelineCache right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkPipelineCache left, VkPipelineCache right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkPipelineCache left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkPipelineCache left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkPipelineCache right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkPipelineCache right) {
            return left != right.handle;
        }

        public static implicit operator VkPipelineCache(UInt64 v) {
            return new VkPipelineCache() { handle = v };
        }

        public static implicit operator UInt64(VkPipelineCache v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 26
    public partial struct VkPipelineLayout {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkPipelineLayout left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkPipelineLayout left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkPipelineLayout right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkPipelineLayout right) {
            return left != right.handle;
        }

        public static implicit operator VkPipelineLayout(UInt64 v) {
            return new VkPipelineLayout() { handle = v };
        }

        public static implicit operator UInt64(VkPipelineLayout v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 27
    public partial struct VkQueryPool {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkQueryPool left, VkQueryPool right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkQueryPool left, VkQueryPool right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkQueryPool left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkQueryPool left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkQueryPool right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkQueryPool right) {
            return left != right.handle;
        }

        public static implicit operator VkQueryPool(UInt64 v) {
            return new VkQueryPool() { handle = v };
        }

        public static implicit operator UInt64(VkQueryPool v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 28
    public partial struct VkQueue {
        //public UInt32 handle;
        // == !=
        public static bool operator ==(VkQueue left, VkQueue right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkQueue left, VkQueue right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkQueue left, UInt32 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkQueue left, UInt32 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt32 left, VkQueue right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt32 left, VkQueue right) {
            return left != right.handle;
        }

        public static implicit operator VkQueue(UInt32 v) {
            return new VkQueue() { handle = v };
        }

        public static implicit operator UInt32(VkQueue v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 29
    public partial struct VkRenderPass {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkRenderPass left, VkRenderPass right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkRenderPass left, VkRenderPass right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkRenderPass left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkRenderPass left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkRenderPass right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkRenderPass right) {
            return left != right.handle;
        }

        public static implicit operator VkRenderPass(UInt64 v) {
            return new VkRenderPass() { handle = v };
        }

        public static implicit operator UInt64(VkRenderPass v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 30
    public partial struct VkSampler {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkSampler left, VkSampler right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkSampler left, VkSampler right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkSampler left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkSampler left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkSampler right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkSampler right) {
            return left != right.handle;
        }

        public static implicit operator VkSampler(UInt64 v) {
            return new VkSampler() { handle = v };
        }

        public static implicit operator UInt64(VkSampler v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 31
    public partial struct VkSamplerYcbcrConversion {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkSamplerYcbcrConversion left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkSamplerYcbcrConversion left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkSamplerYcbcrConversion right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkSamplerYcbcrConversion right) {
            return left != right.handle;
        }

        public static implicit operator VkSamplerYcbcrConversion(UInt64 v) {
            return new VkSamplerYcbcrConversion() { handle = v };
        }

        public static implicit operator UInt64(VkSamplerYcbcrConversion v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 32
    public partial struct VkSemaphore {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkSemaphore left, VkSemaphore right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkSemaphore left, VkSemaphore right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkSemaphore left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkSemaphore left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkSemaphore right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkSemaphore right) {
            return left != right.handle;
        }

        public static implicit operator VkSemaphore(UInt64 v) {
            return new VkSemaphore() { handle = v };
        }

        public static implicit operator UInt64(VkSemaphore v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 33
    public partial struct VkShaderModule {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkShaderModule left, VkShaderModule right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkShaderModule left, VkShaderModule right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkShaderModule left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkShaderModule left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkShaderModule right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkShaderModule right) {
            return left != right.handle;
        }

        public static implicit operator VkShaderModule(UInt64 v) {
            return new VkShaderModule() { handle = v };
        }

        public static implicit operator UInt64(VkShaderModule v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 34
    public partial struct VkSurfaceKHR {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkSurfaceKHR left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkSurfaceKHR left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkSurfaceKHR right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkSurfaceKHR right) {
            return left != right.handle;
        }

        public static implicit operator VkSurfaceKHR(UInt64 v) {
            return new VkSurfaceKHR() { handle = v };
        }

        public static implicit operator UInt64(VkSurfaceKHR v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 35
    public partial struct VkSwapchainKHR {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkSwapchainKHR left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkSwapchainKHR left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkSwapchainKHR right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkSwapchainKHR right) {
            return left != right.handle;
        }

        public static implicit operator VkSwapchainKHR(UInt64 v) {
            return new VkSwapchainKHR() { handle = v };
        }

        public static implicit operator UInt64(VkSwapchainKHR v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }

    // Object Handles: 36
    public partial struct VkValidationCacheEXT {
        //public UInt64 handle;
        // == !=
        public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right) {
            return left.handle == right.handle;
        }
        public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right) {
            return left.handle != right.handle;
        }

        public static bool operator ==(VkValidationCacheEXT left, UInt64 right) {
            return left.handle == right;
        }
        public static bool operator !=(VkValidationCacheEXT left, UInt64 right) {
            return left.handle != right;
        }

        public static bool operator ==(UInt64 left, VkValidationCacheEXT right) {
            return left == right.handle;
        }
        public static bool operator !=(UInt64 left, VkValidationCacheEXT right) {
            return left != right.handle;
        }

        public static implicit operator VkValidationCacheEXT(UInt64 v) {
            return new VkValidationCacheEXT() { handle = v };
        }

        public static implicit operator UInt64(VkValidationCacheEXT v) {
            return v.handle;
        }

        public override bool Equals(object obj) {
            return this.handle.Equals(obj);
        }

        public override int GetHashCode() {
            return this.handle.GetHashCode();
        }

    }


}
