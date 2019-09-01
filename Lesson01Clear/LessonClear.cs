using System;
using System.Linq;
using Vulkan;

namespace Lesson01Clear {
    unsafe class LessonClear {
        VkInstance vkIntance;
        VkSurfaceKhr vkSurface;
        VkPhysicalDevice vkPhysicalDevice;

        VkDevice vkDevice;
        VkQueue vkQueue;
        VkSwapchainKhr vkSwapchain;
        VkImage[] vkImages;
        VkRenderPass vkRenderPass;
        VkFramebuffer[] vkFramebuffers;
        VkFence vkFence;
        VkSemaphore vkSemaphore;
        VkCommandBuffer[] vkCommandBuffers;
        bool isInitialized = false;

        public void Init(IntPtr hwnd, IntPtr processHandle) {
            if (this.isInitialized) { return; }

            this.vkIntance = InitInstance();
            this.vkSurface = InitSurface(this.vkIntance, hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice(this.vkIntance);
            VkSurfaceFormatKhr surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.vkSurface);
            VkSurfaceCapabilitiesKhr surfaceCapabilities;
            this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out surfaceCapabilities);

            this.vkDevice = InitDevice(this.vkPhysicalDevice, this.vkSurface);

            this.vkQueue = this.vkDevice.GetDeviceQueue(0, 0);
            this.vkSwapchain = CreateSwapchain(this.vkDevice, this.vkSurface, surfaceFormat, surfaceCapabilities);
            this.vkImages = this.vkDevice.GetSwapchainImagesKHR(this.vkSwapchain);
            this.vkRenderPass = CreateRenderPass(this.vkDevice, surfaceFormat);
            this.vkFramebuffers = CreateFramebuffers(this.vkDevice, this.vkImages, surfaceFormat, this.vkRenderPass, surfaceCapabilities);

            var fenceInfo = new VkFenceCreateInfo { SType = VkStructureType.FenceCreateInfo };
            this.vkFence = this.vkDevice.CreateFence(ref fenceInfo);
            var semaphoreInfo = new VkSemaphoreCreateInfo { SType = VkStructureType.SemaphoreCreateInfo };
            this.vkSemaphore = this.vkDevice.CreateSemaphore(ref semaphoreInfo);

            this.vkCommandBuffers = CreateCommandBuffers(this.vkDevice, this.vkImages, this.vkFramebuffers, this.vkRenderPass, surfaceCapabilities);

            this.isInitialized = true;
        }

        VkCommandBuffer[] CreateCommandBuffers(VkDevice device, VkImage[] images, VkFramebuffer[] framebuffers, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var createPoolInfo = new VkCommandPoolCreateInfo {
                SType = VkStructureType.CommandPoolCreateInfo,
                Flags = VkCommandPoolCreateFlags.ResetCommandBuffer
            };
            var commandPool = device.CreateCommandPool(ref createPoolInfo);
            var commandBufferAllocateInfo = new VkCommandBufferAllocateInfo {
                SType = VkStructureType.CommandBufferAllocateInfo,
                Level = VkCommandBufferLevel.Primary,
                CommandPool = commandPool.handle,
                CommandBufferCount = (uint)images.Length
            };
            VkCommandBuffer[] buffers = device.AllocateCommandBuffers(ref commandBufferAllocateInfo);
            var clearColors = new[] {
                new VkClearColorValue(0.9f, 0.7f, 0.0f, 1.0f),
                new VkClearColorValue(0.1f, 0.3f, 1.0f, 1.0f),
            };
            for (int i = 0; i < images.Length; i++) {
                var commandBufferBeginInfo = new VkCommandBufferBeginInfo { SType = VkStructureType.CommandBufferBeginInfo };
                buffers[i].Begin(ref commandBufferBeginInfo);
                {
                    var renderPassBeginInfo = new VkRenderPassBeginInfo();
                    {
                        renderPassBeginInfo.SType = VkStructureType.RenderPassBeginInfo;
                        renderPassBeginInfo.Framebuffer = framebuffers[i].handle;
                        renderPassBeginInfo.RenderPass = renderPass.handle;
                        new VkClearValue[] { new VkClearValue { Color = clearColors[i] } }.Set(ref renderPassBeginInfo.ClearValues, ref renderPassBeginInfo.ClearValueCount);
                        renderPassBeginInfo.RenderArea = new VkRect2D { Extent = surfaceCapabilities.CurrentExtent };
                    }
                    buffers[i].CmdBeginRenderPass(ref renderPassBeginInfo, VkSubpassContents.Inline);
                    {
                        // nothing to do in this lesson.
                    }
                    buffers[i].CmdEndRenderPass();
                }
                buffers[i].End();
            }
            return buffers;
        }

        protected VkFramebuffer[] CreateFramebuffers(VkDevice device, VkImage[] images, VkSurfaceFormatKhr surfaceFormat, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var displayViews = new VkImageView[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var viewCreateInfo = new VkImageViewCreateInfo {
                    SType = VkStructureType.ImageViewCreateInfo,
                    Image = images[i].handle,
                    ViewType = VkImageViewType.View2D,
                    Format = surfaceFormat.Format,
                    Components = new VkComponentMapping {
                        R = VkComponentSwizzle.R,
                        G = VkComponentSwizzle.G,
                        B = VkComponentSwizzle.B,
                        A = VkComponentSwizzle.A
                    },
                    SubresourceRange = new VkImageSubresourceRange {
                        AspectMask = VkImageAspectFlags.Color,
                        LevelCount = 1,
                        LayerCount = 1
                    }
                };
                displayViews[i] = device.CreateImageView(ref viewCreateInfo);
            }

            var framebuffers = new VkFramebuffer[images.Length];
            for (int i = 0; i < images.Length; i++) {
                var frameBufferCreateInfo = new VkFramebufferCreateInfo();
                {
                    frameBufferCreateInfo.SType = VkStructureType.FramebufferCreateInfo;
                    frameBufferCreateInfo.Layers = 1;
                    frameBufferCreateInfo.RenderPass = renderPass.handle;
                    new UInt64[] { displayViews[i].handle }.Set(ref frameBufferCreateInfo.Attachments, ref frameBufferCreateInfo.AttachmentCount);
                    frameBufferCreateInfo.Width = surfaceCapabilities.CurrentExtent.Width;
                    frameBufferCreateInfo.Height = surfaceCapabilities.CurrentExtent.Height;
                }
                framebuffers[i] = device.CreateFramebuffer(ref frameBufferCreateInfo);
            }

            return framebuffers;
        }

        protected VkRenderPass CreateRenderPass(VkDevice device, VkSurfaceFormatKhr surfaceFormat) {
            var attDesc = new VkAttachmentDescription {
                Format = surfaceFormat.Format,
                Samples = VkSampleCountFlags.Count1,
                LoadOp = VkAttachmentLoadOp.Clear,
                StoreOp = VkAttachmentStoreOp.Store,
                StencilLoadOp = VkAttachmentLoadOp.DontCare,
                StencilStoreOp = VkAttachmentStoreOp.DontCare,
                InitialLayout = VkImageLayout.Undefined,
                FinalLayout = VkImageLayout.PresentSrcKhr
            };
            var attRef = new VkAttachmentReference { Layout = VkImageLayout.ColorAttachmentOptimal };
            var subpassDesc = new VkSubpassDescription();
            {
                subpassDesc.PipelineBindPoint = VkPipelineBindPoint.Graphics;
                new UInt32[] { attRef.Attachment }.Set(ref subpassDesc.ColorAttachments, ref subpassDesc.ColorAttachmentCount);
            }
            var renderPassCreateInfo = new VkRenderPassCreateInfo();
            {
                renderPassCreateInfo.SType = VkStructureType.RenderPassCreateInfo;
                new VkAttachmentDescription[] { attDesc }.Set(ref renderPassCreateInfo.Attachments, ref renderPassCreateInfo.AttachmentCount);
                new VkSubpassDescription[] { subpassDesc }.Set(ref renderPassCreateInfo.Subpasses, ref renderPassCreateInfo.SubpassCount);
            }

            return device.CreateRenderPass(ref renderPassCreateInfo);
        }

        protected VkSwapchainKhr CreateSwapchain(VkDevice device, VkSurfaceKhr surface, VkSurfaceFormatKhr surfaceFormat, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var compositeAlpha = surfaceCapabilities.SupportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKhr.Inherit)
                ? VkCompositeAlphaFlagsKhr.Inherit
                : VkCompositeAlphaFlagsKhr.Opaque;
            var swapchainInfo = new VkSwapchainCreateInfoKhr();
            {
                swapchainInfo.SType = VkStructureType.SwapchainCreateInfoKhr;
                swapchainInfo.Surface = surface.handle;
                swapchainInfo.MinImageCount = surfaceCapabilities.MinImageCount;
                swapchainInfo.ImageFormat = surfaceFormat.Format;
                swapchainInfo.ImageColorSpace = surfaceFormat.ColorSpace;
                swapchainInfo.ImageExtent = surfaceCapabilities.CurrentExtent;
                swapchainInfo.ImageUsage = VkImageUsageFlags.ColorAttachment;
                swapchainInfo.PreTransform = VkSurfaceTransformFlagsKhr.Identity;
                swapchainInfo.ImageArrayLayers = 1;
                swapchainInfo.ImageSharingMode = VkSharingMode.Exclusive;
                new uint[] { 0 }.Set(ref swapchainInfo.QueueFamilyIndices, ref swapchainInfo.QueueFamilyIndexCount);
                swapchainInfo.PresentMode = VkPresentModeKhr.Fifo;
                swapchainInfo.CompositeAlpha = compositeAlpha;
            }

            return device.CreateSwapchainKHR(ref swapchainInfo, null);
        }

        protected VkSurfaceFormatKhr SelectFormat(VkPhysicalDevice physicalDevice, VkSurfaceKhr surface) {
            VkSurfaceFormatKhr[] formats;
            physicalDevice.GetSurfaceFormatsKhr(surface, out formats);
            foreach (var f in formats)
                if (f.Format == VkFormat.R8G8B8A8Unorm || f.Format == VkFormat.B8G8R8A8Unorm)
                    return f;

            throw new System.Exception("didn't find the R8G8B8A8Unorm or B8G8R8A8Unorm format");
        }

        private VkDevice InitDevice(VkPhysicalDevice physicalDevice, VkSurfaceKhr surface) {
            VkQueueFamilyProperties[] properties = physicalDevice.GetQueueFamilyProperties();
            uint index;
            for (index = 0; index < properties.Length; ++index) {
                VkBool32 supported;
                physicalDevice.GetSurfaceSupportKhr(index, surface, out supported);
                if (!supported) { continue; }

                if (properties[index].QueueFlags.HasFlag(VkQueueFlags.QueueGraphics)) break;
            }

            var queueInfo = new VkDeviceQueueCreateInfo();
            {
                queueInfo.SType = VkStructureType.DeviceQueueCreateInfo;
                new float[] { 1.0f }.Set(ref queueInfo.QueuePriorities, ref queueInfo.QueueCount);
                queueInfo.QueueFamilyIndex = index;
            }

            var deviceInfo = new VkDeviceCreateInfo();
            {
                deviceInfo.SType = VkStructureType.DeviceCreateInfo;
                new string[] { "VK_KHR_swapchain" }.Set(ref deviceInfo.EnabledExtensionNames, ref deviceInfo.EnabledExtensionCount);
                new VkDeviceQueueCreateInfo[] { queueInfo }.Set(ref deviceInfo.QueueCreateInfos, ref deviceInfo.QueueCreateInfoCount);
            }

            VkDevice device;
            physicalDevice.CreateDevice(ref deviceInfo, null, out device);

            return device;
        }

        private VkPhysicalDevice InitPhysicalDevice(VkInstance instance) {
            VkPhysicalDevice[] physicalDevices;
            instance.EnumeratePhysicalDevices(out physicalDevices);
            return physicalDevices[0];
        }

        private VkSurfaceKhr InitSurface(VkInstance instance, IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKhr {
                SType = VkStructureType.Win32SurfaceCreateInfoKhr,
                Hwnd = hwnd,
                Hinstance = processHandle, //Process.GetCurrentProcess().Handle
            };
            return instance.CreateWin32SurfaceKHR(ref info, null);
        }

        private VkInstance InitInstance() {
            VkLayerProperties[] layerProperties;
            Layer.EnumerateInstanceLayerProperties(out layerProperties);
            string[] layersToEnable = layerProperties.Any(l => StringHelper.ToStringAnsi(l.LayerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = new VkApplicationInfo();
            {
                appInfo.SType = VkStructureType.ApplicationInfo;
                uint version = Vulkan.Version.Make(1, 0, 0);
                appInfo.ApiVersion = version;
            }

            var extensions = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" };

            var info = new VkInstanceCreateInfo();
            {
                info.SType = VkStructureType.InstanceCreateInfo;
                extensions.Set(ref info.EnabledExtensionNames, ref info.EnabledExtensionCount);
                layersToEnable.Set(ref info.EnabledLayerNames, ref info.EnabledLayerCount);
                info.ApplicationInfo = (IntPtr)(&appInfo);
            }

            VkInstance result;
            VkInstance.Create(ref info, null, out result).Check();

            return result;
        }


        private VkSubmitInfo[] submitInfos;
        private VkPresentInfoKhr[] presentInfos;

        private void InitRenderParams() {
            VkDevice device = this.vkDevice; VkSwapchainKhr swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;

            submitInfos = new VkSubmitInfo[2]; presentInfos = new VkPresentInfoKhr[2];
            for (uint index = 0; index < 2; index++) {
                var submitInfo = new VkSubmitInfo();
                {
                    new UInt64[] { semaphore.handle }.Set(ref submitInfo.WaitSemaphores, ref submitInfo.WaitSemaphoreCount);
                    // I have to use int instead of enum VkPipelineStageFlags.
                    new int[] { (int)VkPipelineStageFlags.AllGraphics }.Set(ref submitInfo.WaitDstStageMask, ref submitInfo.WaitSemaphoreCount);
                    new IntPtr[] { commandBuffers[index].handle }.Set(ref submitInfo.CommandBuffers, ref submitInfo.CommandBufferCount);
                }
                submitInfos[index] = submitInfo;
                var presentInfo = new VkPresentInfoKhr();
                {
                    presentInfo.SType = VkStructureType.PresentInfoKhr;
                    new UInt64[] { swapchain.handle }.Set(ref presentInfo.Swapchains, ref presentInfo.SwapchainCount);
                    new uint[] { index }.Set(ref presentInfo.ImageIndices, ref presentInfo.SwapchainCount);
                }
                presentInfos[index] = presentInfo;
            }
        }

        public void Render() {
            if (!isInitialized) return;
            if (this.submitInfos == null) {
                InitRenderParams();
            }

            VkDevice device = this.vkDevice; VkSwapchainKhr swapchain = this.vkSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;
            uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            device.ResetFence(fence);

            queue.Submit(ref this.submitInfos[nextIndex], fence);
            device.WaitForFence(fence, true, 100000000);
            queue.PresentKHR(ref this.presentInfos[nextIndex]);
        }
    }
}
