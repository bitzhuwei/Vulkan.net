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

    clearValues.Set(ref info);
```
.