using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;

namespace Lesson01lear {
    unsafe class LessonClear {
        VkInstance vkIntance;
        VkSurfaceKhr vkSurface;
        VkPhysicalDevice vkPhysicalDevice;
        VkDevice vkDevice;
        VkQueue vkQueue;
        VkSurfaceCapabilitiesKhr vkSurfaceCapabilities;
        VkSwapchainKhr vKSwapchain;
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
            this.vkSurface = InitSurface(hwnd, processHandle);
            this.vkPhysicalDevice = InitPhysicalDevice();
            this.vkDevice = InitDevice(this.vkPhysicalDevice, this.vkSurface);
            this.vkQueue = this.vkDevice.GetDeviceQueue(0, 0);
            this.vkPhysicalDevice.GetSurfaceCapabilitiesKhr(this.vkSurface, out this.vkSurfaceCapabilities);
            VkSurfaceFormatKhr surfaceFormat = SelectFormat(this.vkPhysicalDevice, this.vkSurface);
            this.vKSwapchain = CreateSwapchain(this.vkSurface, surfaceFormat);
            this.vkImages = this.vkDevice.GetSwapchainImagesKHR(this.vKSwapchain);
            this.vkRenderPass = CreateRenderPass(this.vkDevice, surfaceFormat);
            this.vkFramebuffers = CreateFramebuffers(this.vkDevice, this.vkImages, surfaceFormat, this.vkRenderPass, this.vkSurfaceCapabilities);
            var fenceInfo = new VkFenceCreateInfo() { SType = VkStructureType.FenceCreateInfo };
            this.vkFence = this.vkDevice.CreateFence(&fenceInfo);
            var semaphoreInfo = new VkSemaphoreCreateInfo() { SType = VkStructureType.SemaphoreCreateInfo };
            this.vkSemaphore = this.vkDevice.CreateSemaphore(&semaphoreInfo);
            this.vkCommandBuffers = CreateCommandBuffers(this.vkDevice, this.vkImages, this.vkFramebuffers, this.vkRenderPass, this.vkSurfaceCapabilities);

            this.isInitialized = true;
        }

        VkCommandBuffer[] CreateCommandBuffers(VkDevice device, VkImage[] images, VkFramebuffer[] framebuffers, VkRenderPass renderPass, VkSurfaceCapabilitiesKhr surfaceCapabilities) {
            var createPoolInfo = new VkCommandPoolCreateInfo {
                SType = VkStructureType.CommandPoolCreateInfo,
                Flags = VkCommandPoolCreateFlags.ResetCommandBuffer
            };
            var commandPool = device.CreateCommandPool(&createPoolInfo);
            var commandBufferAllocateInfo = new VkCommandBufferAllocateInfo {
                SType = VkStructureType.CommandBufferAllocateInfo,
                Level = VkCommandBufferLevel.Primary,
                CommandPool = commandPool.handle,
                CommandBufferCount = (uint)images.Length
            };
            var buffers = device.AllocateCommandBuffers(&commandBufferAllocateInfo);
            for (int i = 0; i < images.Length; i++) {

                var commandBufferBeginInfo = new VkCommandBufferBeginInfo() {
                    SType = VkStructureType.CommandBufferBeginInfo
                };
                buffers[i].Begin(&commandBufferBeginInfo);
                var renderPassBeginInfo = new RenderPassBeginInfo {
                    Framebuffer = framebuffers[i].handle,
                    RenderPass = renderPass.handle,
                    ClearValues = new VkClearValue[] { new VkClearValue { Color = new VkClearColorValue(0.9f, 0.7f, 0.0f, 1.0f) } },
                    RenderArea = new VkRect2D {
                        Extent = surfaceCapabilities.CurrentExtent
                    }
                };
                buffers[i].CmdBeginRenderPass(renderPassBeginInfo, VkSubpassContents.Inline);
                buffers[i].CmdEndRenderPass();
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
                displayViews[i] = device.CreateImageView(&viewCreateInfo);
            }

            var framebuffers = new VkFramebuffer[images.Length];

            for (int i = 0; i < images.Length; i++) {
                var frameBufferCreateInfo = new FramebufferCreateInfo {
                    Layers = 1,
                    RenderPass = renderPass.handle,
                    Attachments = new UInt64[] { displayViews[i].handle },// new VkImageView[] { displayViews[i] },
                    Width = surfaceCapabilities.CurrentExtent.Width,
                    Height = surfaceCapabilities.CurrentExtent.Height
                };
                framebuffers[i] = device.CreateFramebuffer(frameBufferCreateInfo);
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
            var subpassDesc = new SubpassDescription {
                PipelineBindPoint = VkPipelineBindPoint.Graphics,
                ColorAttachments = new UInt32[] { attRef.Attachment }
            };
            var renderPassCreateInfo = new RenderPassCreateInfo {
                Attachments = new VkAttachmentDescription[] { attDesc },
                Subpasses = new VkSubpassDescription[] { *subpassDesc.info }
            };

            return device.CreateRenderPass(renderPassCreateInfo);
        }

        protected VkSwapchainKhr CreateSwapchain(VkSurfaceKhr surface, VkSurfaceFormatKhr surfaceFormat) {
            var compositeAlpha = this.vkSurfaceCapabilities.SupportedCompositeAlpha.HasFlag(VkCompositeAlphaFlagsKhr.Inherit)
                ? VkCompositeAlphaFlagsKhr.Inherit
                : VkCompositeAlphaFlagsKhr.Opaque;

            var swapchainInfo = new SwapchainCreateInfoKhr {
                Surface = surface.handle,
                MinImageCount = this.vkSurfaceCapabilities.MinImageCount,
                ImageFormat = surfaceFormat.Format,
                ImageColorSpace = surfaceFormat.ColorSpace,
                ImageExtent = this.vkSurfaceCapabilities.CurrentExtent,
                ImageUsage = VkImageUsageFlags.ColorAttachment,
                PreTransform = VkSurfaceTransformFlagsKhr.Identity,
                ImageArrayLayers = 1,
                ImageSharingMode = VkSharingMode.Exclusive,
                QueueFamilyIndices = new uint[] { 0 },
                PresentMode = VkPresentModeKhr.Fifo,
                CompositeAlpha = compositeAlpha
            };

            return this.vkDevice.CreateSwapchainKHR(swapchainInfo, null);
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

            uint nextIndex;
            for (nextIndex = 0; nextIndex < properties.Length; ++nextIndex) {
                VkBool32 supported;
                physicalDevice.GetSurfaceSupportKhr(nextIndex, surface, out supported);
                if (!supported) { continue; }

                if (properties[nextIndex].QueueFlags.HasFlag(VkQueueFlags.QueueGraphics)) break;
            }

            var queueInfo = new VkDeviceQueueCreateInfo();
            queueInfo.SType = VkStructureType.DeviceQueueCreateInfo;
            //queueInfo.QueuePriorities = new float[] { 1.0f }.ToPtr();
            Helper.Set(new float[] { 1.0f }, ref queueInfo.QueuePriorities, ref queueInfo.QueueCount);
            queueInfo.QueueFamilyIndex = nextIndex;

            var deviceInfo = new DeviceCreateInfo {
                EnabledExtensionNames = new string[] { "VK_KHR_swapchain" },
                QueueCreateInfos = new VkDeviceQueueCreateInfo[] { queueInfo },
            };

            VkDevice device;
            physicalDevice.CreateDevice(deviceInfo, null, out device);
            return device;
        }

        private VkPhysicalDevice InitPhysicalDevice() {
            VkPhysicalDevice[] physicalDevices;
            this.vkIntance.EnumeratePhysicalDevices(out physicalDevices);
            return physicalDevices[0];
        }

        private VkSurfaceKhr InitSurface(IntPtr hwnd, IntPtr processHandle) {
            var info = new VkWin32SurfaceCreateInfoKhr {
                SType = VkStructureType.Win32SurfaceCreateInfoKhr,
                Hwnd = hwnd,
                Hinstance = processHandle, //Process.GetCurrentProcess().Handle
            };
            return this.vkIntance.CreateWin32SurfaceKHR(ref info, null);
        }

        /// <summary>
        /// set up vkIntance.
        /// </summary>
        private VkInstance InitInstance() {
            VkLayerProperties[] layerProperties;
            Layer.EnumerateInstanceLayerProperties(out layerProperties).Check();

            var layersToEnable = layerProperties.Any(l => StringHelper.ToStringAnsi(l.LayerName) == "VK_LAYER_LUNARG_standard_validation")
                ? new[] { "VK_LAYER_LUNARG_standard_validation" }
                : new string[0];

            var appInfo = new UnmanagedArray<VkApplicationInfo>(1);
            var item = (VkApplicationInfo*)appInfo.header;
            {
                item->SType = VkStructureType.ApplicationInfo;
                uint version = Vulkan.Version.Make(1, 0, 0);
                item->ApiVersion = version;
            }
            var extensions = new string[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_report" };
            var info = new InstanceCreateInfo();
            info.EnabledExtensionNames = extensions;
            info.EnabledLayerNames = layersToEnable;
            info.ApplicationInfo = item;

            VkInstance result;
            VkInstance.Create(info, null, out result).Check();

            //this.vkInstance.EnableDebug(DebugCallback);

            appInfo.Dispose();

            return result;
        }

        public void Render() {
            if (!isInitialized) return;

            VkDevice device = this.vkDevice; VkSwapchainKhr swapchain = this.vKSwapchain;
            VkSemaphore semaphore = this.vkSemaphore; VkFence fence = this.vkFence;
            VkCommandBuffer[] commandBuffers = this.vkCommandBuffers;
            VkQueue queue = this.vkQueue;
            uint nextIndex = device.AcquireNextImageKHR(swapchain, ulong.MaxValue, semaphore);
            device.ResetFence(fence);
            var submitInfo = new SubmitInfo {
                WaitSemaphores = new UInt64[] { semaphore.handle },
                WaitDstStageMask = new VkPipelineStageFlags[] { VkPipelineStageFlags.AllGraphics },
                CommandBuffers = new IntPtr[] { commandBuffers[nextIndex].handle }
            };
            queue.Submit(submitInfo, fence);
            device.WaitForFence(fence, true, 100000000);
            var presentInfo = new PresentInfoKhr {
                Swapchains = new UInt64[] { swapchain.handle },
                ImageIndices = new uint[] { nextIndex }
            };
            queue.PresentKHR(presentInfo);
        }
    }
}
