using System;

namespace ApiSpec.Generated {
    public unsafe struct VkBool32 {
        private UInt32 value;

        public VkBool32(bool v) {
            this.value = v ? 1u : 0u;
        }

        public override string ToString() {
            return $"{nameof(VkBool32)}: {this.value != 0}";
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
    }

    public unsafe struct VkSampleMask {
        public UInt32 value;

        public override string ToString() {
            return $"{nameof(VkSampleMask)}: {this.value}";
        }
    }
}
