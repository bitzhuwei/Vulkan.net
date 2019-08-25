using System;
using System.Collections.Generic;

namespace Vulkan {

    static class ResultHelper {
        public static VkResult Check(this VkResult result) {
            if (result != VkResult.Success) { throw new ResultException(result); }

            return result;
        }
    }

    public class ResultException : Exception {
        internal VkResult result;

        public VkResult Result {
            get { return result; }
        }

        internal ResultException(VkResult res) {
            result = res;
        }
    }

    public class Version {
        public static uint Make(uint major, uint minor, uint patch) {
            return (major << 22) | (minor << 12) | patch;
        }

        public static string ToString(uint version) {
            return string.Format("{0}.{1}.{2}", version >> 22, (version >> 12) & 0x3ff, version & 0xfff);
        }
    }

    public static class NativeMemoryDebug {
        static bool enabled;
        public static bool Enabled {
            get {
                return enabled;
            }
            set {
                if (value && value != enabled) {
                    lock (Allocations) {
                        Allocations = new Dictionary<IntPtr, int>();
                        AllocatedSize = 0;
                    }
                }
                enabled = value;
            }
        }

        public static int AllocatedSize { get; internal set; }

        public delegate void ReportCallbackDelegate(string format, params object[] args);
        public delegate string StackTraceDelegate();

        public static ReportCallbackDelegate ReportCallback = null;
        public static StackTraceDelegate StackTraceCallback = null;

        internal static Dictionary<IntPtr, int> Allocations = new Dictionary<IntPtr, int>();

        static public void Report(string format, params object[] args) {
            if (ReportCallback != null)
                ReportCallback(format, args);
        }

        static public string StackTrace() {
            return (StackTraceCallback == null) ? "" : StackTraceCallback();
        }
    }
}


