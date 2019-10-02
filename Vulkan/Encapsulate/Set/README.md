# Synteax sugar.
from
```
    var clearValues = new VkClearValue[] { ... }
    var info = new VkRenderPassBeginInfo();

	IntPtr ptr = (IntPtr)info.pClearValues;
    clearValues.Set(ref ptr, ref info.clearValueCount);
    info.pClearValues = (VkClearValue*)ptr;
```
to
```
    var clearValues = new VkClearValue[] { ... }
    var info = new VkRenderPassBeginInfo();

    clearValues.Set(&info);
```
where `Set(..)` is:
```
public static void Set<T>(this T[] value, 
    ref IntPtr target, ref UInt32 count) where T : struct {
    {   // free unmanaged memory.
        if (target != IntPtr.Zero) {
            Marshal.FreeHGlobal(target);
            target = IntPtr.Zero;
            count = 0;
        }
    }
    {
        count = (UInt32)value.Length;

        if (typeof(T).IsEnum) { // if T is an enum type.(eg. enum VkResult : int { .. } )
            Type underlying = typeof(T).GetEnumUnderlyingType(); // underlying : int
            int elementSize = Marshal.SizeOf(underlying); // elementSize : sizeof(int) = 4

            int byteLength = (int)(count * elementSize);
            IntPtr array = Marshal.AllocHGlobal(byteLength);
            switch (elementSize) {
                case 1: {
                    var dst = (byte*)array;
                    for (int i = 0; i < value.Length; i++) {
                        dst[i] = Convert.ToByte(value[i]);
                    }
                }
                break;
                case 2: {
                    var dst = (Int16*)array;
                    for (int i = 0; i < value.Length; i++) {
                        dst[i] = Convert.ToInt16(value[i]);
                    }
                }
                break;
                case 4: {
                    var dst = (Int32*)array;
                    for (int i = 0; i < value.Length; i++) {
                        dst[i] = Convert.ToInt32(value[i]);
                    }
                }
                break;
                case 8: {
                    var dst = (Int64*)array;
                    for (int i = 0; i < value.Length; i++) {
                        dst[i] = Convert.ToInt64(value[i]);
                    }
                }
                break;
                default:
                    throw new ArgumentException(
					    string.Format("Unknown type({0}) length", typeof(T)));
            }

            target = array;
        }
        else {
            int elementSize = Marshal.SizeOf<T>();

            int byteLength = (int)(count * elementSize);
            IntPtr array = Marshal.AllocHGlobal(byteLength);
            var dst = (byte*)array;
            GCHandle pin = GCHandle.Alloc(value, GCHandleType.Pinned);
            IntPtr address = Marshal.UnsafeAddrOfPinnedArrayElement(value, 0);
            var src = (byte*)address;
            for (int i = 0; i < byteLength; i++) {
                dst[i] = src[i];
            }
            //System.Buffer.MemoryCopy(src, dst, byteLength, byteLength);
            pin.Free();

            target = array;
        }
    }
}
```
.