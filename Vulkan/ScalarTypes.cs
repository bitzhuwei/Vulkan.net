using System;

namespace Vulkan {
    public unsafe struct VkBool32 {
        private UInt32 value;

        public VkBool32(bool v) {
            this.value = v ? 1u : 0u;
        }

        public override string ToString() {
            return $"{nameof(VkBool32)}: {this.value != 0}";
        }

        public static bool operator !(VkBool32 v) {
            return (v.value == 0);
        }

        // == !=
        public static bool operator ==(VkBool32 left, VkBool32 right) {
            return left.value == right.value;
        }
        public static bool operator !=(VkBool32 left, VkBool32 right) {
            return left.value != right.value;
        }

        public static bool operator ==(VkBool32 left, bool right) {
            return (left.value != 0) == right;
        }
        public static bool operator !=(VkBool32 left, bool right) {
            return (left.value != 0) != right;
        }

        public static bool operator ==(bool left, VkBool32 right) {
            return left == (right.value != 0);
        }
        public static bool operator !=(bool left, VkBool32 right) {
            return left != (right.value != 0);
        }

        public static implicit operator VkBool32(bool v) {
            return new VkBool32(v);
        }

        public static implicit operator bool(VkBool32 v) {
            return (v.value != 0);
        }

        public override bool Equals(object obj) {
            return this.value.Equals(obj);
        }

        public override int GetHashCode() {
            return this.value.GetHashCode();
        }

    }

    public unsafe struct VkDeviceAddress {
        public UInt64 value;

        public override string ToString() {
            return $"{nameof(VkDeviceAddress)}: {this.value != 0}";
        }
    }

    public unsafe struct VkDeviceSize {
        public UInt64 value;

        public override string ToString() {
            return $"{nameof(VkDeviceSize)}: {this.value}";
        }

        public VkDeviceSize(UInt64 size) {
            this.value = size;
        }

        // == !=
        public static bool operator ==(VkDeviceSize left, VkDeviceSize right) {
            return left.value == right.value;
        }
        public static bool operator !=(VkDeviceSize left, VkDeviceSize right) {
            return left.value != right.value;
        }

        public static bool operator ==(VkDeviceSize left, UInt64 right) {
            return left.value == right;
        }
        public static bool operator !=(VkDeviceSize left, UInt64 right) {
            return left.value != right;
        }

        public static bool operator ==(UInt64 left, VkDeviceSize right) {
            return left == right.value;
        }
        public static bool operator !=(UInt64 left, VkDeviceSize right) {
            return left != right.value;
        }
        // > >=
        public static bool operator >(VkDeviceSize left, VkDeviceSize right) {
            return left.value > right.value;
        }
        public static bool operator >=(VkDeviceSize left, VkDeviceSize right) {
            return left.value >= right.value;
        }

        public static bool operator >(VkDeviceSize left, UInt64 right) {
            return left.value > right;
        }
        public static bool operator >=(VkDeviceSize left, UInt64 right) {
            return left.value >= right;
        }

        public static bool operator >(UInt64 left, VkDeviceSize right) {
            return left > right.value;
        }
        public static bool operator >=(UInt64 left, VkDeviceSize right) {
            return left >= right.value;
        }
        // < <=
        public static bool operator <(VkDeviceSize left, VkDeviceSize right) {
            return left.value < right.value;
        }
        public static bool operator <=(VkDeviceSize left, VkDeviceSize right) {
            return left.value <= right.value;
        }

        public static bool operator <(VkDeviceSize left, UInt64 right) {
            return left.value < right;
        }
        public static bool operator <=(VkDeviceSize left, UInt64 right) {
            return left.value <= right;
        }

        public static bool operator <(UInt64 left, VkDeviceSize right) {
            return left < right.value;
        }
        public static bool operator <=(UInt64 left, VkDeviceSize right) {
            return left <= right.value;
        }

        // implicit
        public static implicit operator VkDeviceSize(UInt64 v) {
            return new VkDeviceSize(v);
        }

        public static implicit operator VkDeviceSize(UInt32 v) {
            return new VkDeviceSize(v);
        }

        public static implicit operator VkDeviceSize(Int32 v) {
            return new VkDeviceSize((UInt64)v);
        }

        public static implicit operator UInt64(VkDeviceSize size) {
            return size.value;
        }

        public override bool Equals(object obj) {
            return this.value.Equals(obj);
        }

        public override int GetHashCode() {
            return this.value.GetHashCode();
        }
    }

    public unsafe struct VkFlags {
        public UInt32 value;

        public override string ToString() {
            return $"{nameof(VkFlags)}: {this.value}";
        }

        public VkFlags(UInt32 flags) {
            this.value = flags;
        }

        // == !=
        public static bool operator ==(VkFlags left, VkFlags right) {
            return left.value == right.value;
        }
        public static bool operator !=(VkFlags left, VkFlags right) {
            return left.value != right.value;
        }

        public static bool operator ==(VkFlags left, UInt32 right) {
            return left.value == right;
        }
        public static bool operator !=(VkFlags left, UInt32 right) {
            return left.value != right;
        }

        public static bool operator ==(UInt32 left, VkFlags right) {
            return left == right.value;
        }
        public static bool operator !=(UInt32 left, VkFlags right) {
            return left != right.value;
        }

        // implicit
        public static implicit operator VkFlags(UInt32 v) {
            return new VkFlags(v);
        }

        public static implicit operator UInt32(VkFlags size) {
            return size.value;
        }

        public override bool Equals(object obj) {
            return this.value.Equals(obj);
        }

        public override int GetHashCode() {
            return this.value.GetHashCode();
        }
    }

    public unsafe struct VkSampleMask {
        public UInt32 value;

        public override string ToString() {
            return $"{nameof(VkSampleMask)}: {this.value}";
        }
    }
}
