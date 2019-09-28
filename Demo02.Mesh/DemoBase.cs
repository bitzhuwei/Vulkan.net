using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using static Vulkan.VkStructureType;
using static Vulkan.vkAPI;
using static Demo02.Mesh.VulkanNative;
using System.Numerics;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Demo02.Mesh {
    public unsafe class DemoBase : IRenderer {
        public string title { get; set; } = "Vulkan Example";
        public string Name { get; set; } = "VulkanExample";
        public Settings Settings { get; } = new Settings();
        public VkInstance Instance { get; protected set; }
        public VkPhysicalDevice physicalDevice { get; protected set; }
        public vksVulkanDevice vulkanDevice { get; protected set; }
        public VkPhysicalDeviceFeatures enabledFeatures { get; protected set; }
        public string[] EnabledExtensions { get; }
        public VkDevice device { get; protected set; }
        public VkQueue queue { get; protected set; }
        public VkFormat DepthFormat { get; protected set; }
        public VulkanSwapchain Swapchain { get; } = new VulkanSwapchain();
        //public IntPtr Window { get; protected set; }
        public VkCommandPool cmdPool => _cmdPool;
        public uint width { get; protected set; } = 1280;
        public uint height { get; protected set; } = 720;
        public VkCommandBuffer[] drawCmdBuffers;
        public VkRenderPass renderPass => _renderPass;
        public VkPipelineCache pipelineCache => _pipelineCache;
        public VkFramebuffer[] frameBuffers;
        public VkPhysicalDeviceMemoryProperties DeviceMemoryProperties { get; set; }
        public VkPhysicalDeviceProperties DeviceProperties { get; protected set; }
        public VkPhysicalDeviceFeatures DeviceFeatures { get; protected set; }
        public System.Windows.Forms.Control NativeWindow;

        public UnmanagedArray<Semaphores> semaphores = new UnmanagedArray<Semaphores>(1);
        public Semaphores* GetSemaphoresPtr() {
            return (Semaphores*)semaphores.header;
        }

        public DepthStencil DepthStencil;
        public VkSubmitInfo* submitInfo;
        public VkPipelineStageFlagBits[] submitPipelineStages = CreateSubmitPipelineStages();
        private static VkPipelineStageFlagBits[] CreateSubmitPipelineStages()
            => new VkPipelineStageFlagBits[] { VkPipelineStageFlagBits.ColorAttachmentOutput };
        protected VkRenderPass _renderPass;
        private VkPipelineCache _pipelineCache;
        private VkCommandPool _cmdPool;
        protected VkDescriptorPool descriptorPool;

        // Destination dimensions for resizing the window
        private uint destWidth;
        private uint destHeight;
        private bool viewUpdated;
        private int frameCounter;
        protected float frameTimer;
        protected bool paused = false;
        protected bool prepared;

        // Defines a frame rate independent timer value clamped from -1.0...1.0
        // For use in animations, rotations, etc.
        //protected float timer = 0.0f; // TODO: undo
        // Multiplier for speeding up (or slowing down) the global timer
        //protected float timerSpeed = 0.25f; // TODO: undo

        protected float zoom;
        protected float zoomSpeed = 50f;
        protected Vector3 rotation;
        protected float rotationSpeed = 1f;
        protected Vector3 cameraPos = new Vector3();
        protected Vector2 mousePos;

        protected Camera camera = new Camera();

        protected VkClearColorValue defaultClearColor = GetDefaultClearColor();
        private static VkClearColorValue GetDefaultClearColor()
            => new VkClearColorValue(1f, 1f, 1f, 1.0f);
        //=> new VkClearColorValue(0.025f, 0.025f, 0.025f, 1.0f);

        // fps timer (one second interval)
        //float fpsTimer = 0.0f; // TODO: undo
        protected bool enableTextOverlay = false;
        //private uint lastFPS; // TODO: undo
        private readonly FrameTimeAverager _frameTimeAverager = new FrameTimeAverager(666);
        protected uint currentBuffer;
        protected List<VkShaderModule> shaderModules = new List<VkShaderModule>();

        //protected InputSnapshot snapshot;

        public void InitVulkan() {
            VkResult err;
            err = CreateInstance(false);
            if (err != VkResult.Success) {
                throw new InvalidOperationException("Could not create Vulkan instance. Error: " + err);
            }

            if (Settings.Validation) {

            }

            // Physical Device
            uint gpuCount = 0;
            vkEnumeratePhysicalDevices(Instance, &gpuCount, null);
            Debug.Assert(gpuCount > 0);
            // Enumerate devices
            IntPtr* physicalDevices = stackalloc IntPtr[(int)gpuCount];
            err = vkEnumeratePhysicalDevices(Instance, &gpuCount, (VkPhysicalDevice*)physicalDevices);
            if (err != VkResult.Success) {
                throw new InvalidOperationException("Could not enumerate physical devices.");
            }

            // GPU selection

            // Select physical Device to be used for the Vulkan example
            // Defaults to the first Device unless specified by command line

            uint selectedDevice = 0;
            // TODO: Implement arg parsing, etc.

            physicalDevice = ((VkPhysicalDevice*)physicalDevices)[selectedDevice];

            // Store properties (including limits) and features of the phyiscal Device
            // So examples can check against them and see if a feature is actually supported
            VkPhysicalDeviceProperties deviceProperties;
            vkGetPhysicalDeviceProperties(physicalDevice, &deviceProperties);
            DeviceProperties = deviceProperties;

            VkPhysicalDeviceFeatures deviceFeatures;
            vkGetPhysicalDeviceFeatures(physicalDevice, &deviceFeatures);
            DeviceFeatures = deviceFeatures;

            // Gather physical Device memory properties
            VkPhysicalDeviceMemoryProperties deviceMemoryProperties;
            vkGetPhysicalDeviceMemoryProperties(physicalDevice, &deviceMemoryProperties);
            DeviceMemoryProperties = deviceMemoryProperties;

            // Derived examples can override this to set actual features (based on above readings) to enable for logical device creation
            getEnabledFeatures();

            // Vulkan Device creation
            // This is handled by a separate class that gets a logical Device representation
            // and encapsulates functions related to a Device
            vulkanDevice = new vksVulkanDevice(physicalDevice);
            VkResult res = vulkanDevice.CreateLogicalDevice(enabledFeatures, EnabledExtensions);
            if (res != VkResult.Success) {
                throw new InvalidOperationException("Could not create Vulkan Device.");
            }
            device = vulkanDevice.LogicalDevice;

            // Get a graphics queue from the Device
            VkQueue queue;
            vkGetDeviceQueue(device, vulkanDevice.QFIndices.Graphics, 0, &queue);
            this.queue = queue;

            // Find a suitable depth format
            VkFormat depthFormat;
            uint validDepthFormat = Tools.getSupportedDepthFormat(physicalDevice, &depthFormat);
            Debug.Assert(validDepthFormat == True);
            DepthFormat = depthFormat;

            Swapchain.Connect(Instance, physicalDevice, device);

            // Create synchronization objects
            VkSemaphoreCreateInfo semaphoreCreateInfo = new VkSemaphoreCreateInfo();
            semaphoreCreateInfo.sType = SemaphoreCreateInfo;
            // Create a semaphore used to synchronize image presentation
            // Ensures that the image is displayed before we start submitting new commands to the queu
            vkCreateSemaphore(device, &semaphoreCreateInfo, null, &GetSemaphoresPtr()->PresentComplete);
            // Create a semaphore used to synchronize command submission
            // Ensures that the image is not presented until all commands have been sumbitted and executed
            vkCreateSemaphore(device, &semaphoreCreateInfo, null, &GetSemaphoresPtr()->RenderComplete);
            // Create a semaphore used to synchronize command submission
            // Ensures that the image is not presented until all commands for the text overlay have been sumbitted and executed
            // Will be inserted after the render complete semaphore if the text overlay is enabled
            vkCreateSemaphore(device, &semaphoreCreateInfo, null, &GetSemaphoresPtr()->TextOverlayComplete);

            // Set up submit info structure
            // Semaphores will stay the same during application lifetime
            // Command buffer submission info is set by each example
            submitInfo = VkSubmitInfo.Alloc();
            submitPipelineStages.Set(submitInfo);
            GetSemaphoresPtr()->PresentComplete.SetWaitSemaphores(submitInfo);
            GetSemaphoresPtr()->RenderComplete.SetSignalSemaphores(submitInfo);
        }

        protected virtual void getEnabledFeatures() {
            // Used in some derived classes.
        }

        private VkResult CreateInstance(bool enableValidation) {
            Settings.Validation = enableValidation;

            VkApplicationInfo appInfo = new VkApplicationInfo();
            {
                appInfo.sType = ApplicationInfo;
                appInfo.apiVersion = VkVersion.Make(1, 0, 0);
                Name.Set(ref appInfo.pApplicationName);
                Name.Set(ref appInfo.pEngineName);
            };

            var instanceExtensions = new List<string>();
            instanceExtensions.Add(Strings.VK_KHR_SURFACE_EXTENSION_NAME);
            instanceExtensions.Add(Strings.VK_KHR_WIN32_SURFACE_EXTENSION_NAME);

            VkInstanceCreateInfo instanceCreateInfo = new VkInstanceCreateInfo();
            instanceCreateInfo.sType = InstanceCreateInfo;
            instanceCreateInfo.pApplicationInfo = &appInfo;

            if (instanceExtensions.Count > 0) {
                if (enableValidation) {
                    instanceExtensions.Add(Strings.VK_EXT_DEBUG_REPORT_EXTENSION_NAME);
                }
                instanceExtensions.ToArray().Set(ref instanceCreateInfo.ppEnabledExtensionNames, ref instanceCreateInfo.enabledExtensionCount);
            }


            if (enableValidation) {
                var enabledLayerNames = new List<string>();
                enabledLayerNames.Add(Strings.StandardValidationLayeName);
                enabledLayerNames.ToArray().Set(ref instanceCreateInfo.ppEnabledLayerNames, ref instanceCreateInfo.enabledLayerCount);
            }

            VkInstance instance;
            VkResult result = vkCreateInstance(&instanceCreateInfo, null, &instance);
            Instance = instance;
            return result;
        }

        public IntPtr SetupWin32Window() {
            NativeWindow.Resize += NativeWindow_Resize;
            NativeWindow.MouseWheel += NativeWindow_MouseWheel;
            NativeWindow.MouseMove += NativeWindow_MouseMove;
            NativeWindow.MouseDown += NativeWindow_MouseDown;
            //NativeWindow.KeyDown += NativeWindow_KeyDown;
            return NativeWindow.Handle;
        }

        //private void NativeWindow_KeyDown(object sender, KeyEventArgs e) {
        //    if (e.Key == Key.F4 && (e.Modifiers & ModifierKeys.Alt) != 0 || e.Key == Key.Escape) {
        //        NativeWindow.Close();
        //    }

        //    keyPressed(e.Key);
        //}

        private void NativeWindow_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != 0) {
                mousePos = new Vector2(e.X, e.Y);
            }
        }

        private void NativeWindow_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                int posx = (int)e.X;
                int posy = (int)e.Y;
                zoom += (mousePos.Y - posy) * .005f * zoomSpeed;
                camera.translate(new Vector3(-0.0f, 0.0f, (mousePos.Y - posy) * .005f * zoomSpeed));
                mousePos = new Vector2(posx, posy);
                viewUpdated = true;
            }
            if (e.Button == MouseButtons.Left) {
                int posx = (int)e.X;
                int posy = (int)e.Y;
                rotation.X += (mousePos.Y - posy) * 1.25f * rotationSpeed;
                rotation.Y -= (mousePos.X - posx) * 1.25f * rotationSpeed;
                camera.rotate(new Vector3((mousePos.Y - posy) * camera.rotationSpeed, -(mousePos.X - posx) * camera.rotationSpeed, 0.0f));
                mousePos = new Vector2(posx, posy);
                viewUpdated = true;
            }
            if (e.Button == MouseButtons.Middle) {
                int posx = (int)e.X;
                int posy = (int)e.Y;
                cameraPos.X -= (mousePos.X - posx) * 0.01f;
                cameraPos.Y -= (mousePos.Y - posy) * 0.01f;
                camera.translate(new Vector3(-(mousePos.X - posx) * 0.01f, -(mousePos.Y - posy) * 0.01f, 0.0f));
                viewUpdated = true;
                mousePos.X = posx;
                mousePos.Y = posy;
            }
        }

        private void NativeWindow_MouseWheel(object sender, MouseEventArgs e) {
            var wheelDelta = e.Delta;
            zoom += wheelDelta * 0.005f * zoomSpeed;
            camera.translate(new Vector3(0.0f, 0.0f, wheelDelta * 0.005f * zoomSpeed));
            viewUpdated = true;
        }

        private void NativeWindow_Resize(object sender, EventArgs e) {
            windowResize();
        }

        public void InitSwapchain() {
            Swapchain.InitSurface(NativeWindow.Handle);
        }

        protected void prepareFrame() {
            // Acquire the next image from the swap chaing
            Swapchain.AcquireNextImage(((Semaphores*)semaphores.header)[0].PresentComplete, ref currentBuffer);
        }

        protected virtual void SetupRenderPass() {
            var attachments = new VkAttachmentDescription[2];
            // Color attachment
            attachments[0] = new VkAttachmentDescription();
            attachments[0].format = Swapchain.ColorFormat;
            attachments[0].samples = VkSampleCountFlagBits._1;
            attachments[0].loadOp = VkAttachmentLoadOp.Clear;
            attachments[0].storeOp = VkAttachmentStoreOp.Store;
            attachments[0].stencilLoadOp = VkAttachmentLoadOp.DontCare;
            attachments[0].stencilStoreOp = VkAttachmentStoreOp.DontCare;
            attachments[0].initialLayout = VkImageLayout.Undefined;
            attachments[0].finalLayout = VkImageLayout.PresentSrcKHR;
            // Depth attachment
            attachments[1] = new VkAttachmentDescription();
            attachments[1].format = DepthFormat;
            attachments[1].samples = VkSampleCountFlagBits._1;
            attachments[1].loadOp = VkAttachmentLoadOp.Clear;
            attachments[1].storeOp = VkAttachmentStoreOp.Store;
            attachments[1].stencilLoadOp = VkAttachmentLoadOp.DontCare;
            attachments[1].stencilStoreOp = VkAttachmentStoreOp.DontCare;
            attachments[1].initialLayout = VkImageLayout.Undefined;
            attachments[1].finalLayout = VkImageLayout.DepthStencilAttachmentOptimal;

            VkAttachmentReference colorReference = new VkAttachmentReference();
            colorReference.attachment = 0;
            colorReference.layout = VkImageLayout.ColorAttachmentOptimal;

            VkAttachmentReference depthReference = new VkAttachmentReference();
            depthReference.attachment = 1;
            depthReference.layout = VkImageLayout.DepthStencilAttachmentOptimal;

            VkSubpassDescription subpassDescription = new VkSubpassDescription();
            subpassDescription.pipelineBindPoint = VkPipelineBindPoint.Graphics;
            subpassDescription.colorAttachmentCount = 1;
            subpassDescription.pColorAttachments = &colorReference;
            subpassDescription.pDepthStencilAttachment = &depthReference;
            subpassDescription.inputAttachmentCount = 0;
            subpassDescription.pInputAttachments = null;
            subpassDescription.preserveAttachmentCount = 0;
            subpassDescription.pPreserveAttachments = null;
            subpassDescription.pResolveAttachments = null;

            // Subpass dependencies for layout transitions
            var dependencies = new VkSubpassDependency[2];
            dependencies[0].srcSubpass = SubpassExternal;
            dependencies[0].dstSubpass = 0;
            dependencies[0].srcStageMask = VkPipelineStageFlagBits.BottomOfPipe;
            dependencies[0].dstStageMask = VkPipelineStageFlagBits.ColorAttachmentOutput;
            dependencies[0].srcAccessMask = VkAccessFlagBits.MemoryRead;
            dependencies[0].dstAccessMask = (VkAccessFlagBits.ColorAttachmentRead | VkAccessFlagBits.ColorAttachmentWrite);
            dependencies[0].dependencyFlags = VkDependencyFlagBits.ByRegion;

            dependencies[1].srcSubpass = 0;
            dependencies[1].dstSubpass = SubpassExternal;
            dependencies[1].srcStageMask = VkPipelineStageFlagBits.ColorAttachmentOutput;
            dependencies[1].dstStageMask = VkPipelineStageFlagBits.BottomOfPipe;
            dependencies[1].srcAccessMask = (VkAccessFlagBits.ColorAttachmentRead | VkAccessFlagBits.ColorAttachmentWrite);
            dependencies[1].dstAccessMask = VkAccessFlagBits.MemoryRead;
            dependencies[1].dependencyFlags = VkDependencyFlagBits.ByRegion;

            var renderPassInfo = VkRenderPassCreateInfo.Alloc();
            attachments.Set(renderPassInfo);
            subpassDescription.Set(renderPassInfo);
            dependencies.Set(renderPassInfo);
            VkRenderPass renderpass;
            vkCreateRenderPass(device, renderPassInfo, null, &renderpass);
            this._renderPass = renderpass;
        }

        private void CreatePipelineCache() {
            VkPipelineCacheCreateInfo pipelineCacheCreateInfo = new VkPipelineCacheCreateInfo();
            pipelineCacheCreateInfo.sType = PipelineCacheCreateInfo;
            VkPipelineCache cache;
            vkCreatePipelineCache(device, &pipelineCacheCreateInfo, null, &cache);
            this._pipelineCache = cache;
        }

        protected virtual void SetupFrameBuffer() {
            var attachments = new VkImageView[2];
            // Depth/Stencil attachment is the same for all frame buffers
            attachments[1] = DepthStencil.View;

            var frameBufferCreateInfo = VkFramebufferCreateInfo.Alloc();
            frameBufferCreateInfo->renderPass = renderPass;
            attachments.Set(frameBufferCreateInfo);
            frameBufferCreateInfo->width = width;
            frameBufferCreateInfo->height = height;
            frameBufferCreateInfo->layers = 1;

            // Create frame buffers for every swap chain image
            frameBuffers = new VkFramebuffer[Swapchain.ImageCount];
            for (uint i = 0; i < frameBuffers.Length; i++) {
                attachments[0] = Swapchain.Buffers[i].View;
                attachments.Set(frameBufferCreateInfo);
                VkFramebuffer framebuffer;
                vkCreateFramebuffer(device, frameBufferCreateInfo, null, &framebuffer);
                frameBuffers[i] = framebuffer;
            }
        }

        private void SetupSwapChain() {
            uint width, height;
            Swapchain.Create(&width, &height, Settings.VSync);

            this.width = width;
            this.height = height;
        }

        protected void submitFrame() {
            bool submitTextOverlay = false;
            /*
            if (submitTextOverlay)
            {
                // Wait for color attachment output to finish before rendering the text overlay
                VkPipelineStageFlags stageFlags = VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT;
                submitInfo.pWaitDstStageMask = &stageFlags;

                // Set semaphores
                // Wait for render complete semaphore
                submitInfo.waitSemaphoreCount = 1;
                submitInfo.pWaitSemaphores = &semaphores.renderComplete;
                // Signal ready with text overlay complete semaphpre
                submitInfo.signalSemaphoreCount = 1;
                submitInfo.pSignalSemaphores = &semaphores.textOverlayComplete;

                // Submit current text overlay command buffer
                submitInfo.commandBufferCount = 1;
                submitInfo.pCommandBuffers = &textOverlay->cmdBuffers[currentBuffer];
                Util.CheckResult(vkQueueSubmit(queue, 1, &submitInfo, VK_NULL_HANDLE));

                // Reset stage mask
                submitInfo.pWaitDstStageMask = &submitPipelineStages;
                // Reset wait and signal semaphores for rendering next frame
                // Wait for swap chain presentation to finish
                submitInfo.waitSemaphoreCount = 1;
                submitInfo.pWaitSemaphores = &semaphores.presentComplete;
                // Signal ready with offscreen semaphore
                submitInfo.signalSemaphoreCount = 1;
                submitInfo.pSignalSemaphores = &semaphores.renderComplete;
            }
            */

            Swapchain.QueuePresent(queue, currentBuffer, submitTextOverlay ? ((Semaphores*)semaphores.header)[0].TextOverlayComplete : ((Semaphores*)semaphores.header)[0].RenderComplete);

            vkQueueWaitIdle(queue);
        }

        private void CreateCommandPool() {
            VkCommandPoolCreateInfo cmdPoolInfo = new VkCommandPoolCreateInfo();
            cmdPoolInfo.sType = CommandPoolCreateInfo;
            cmdPoolInfo.queueFamilyIndex = Swapchain.QueueNodeIndex;
            cmdPoolInfo.flags = VkCommandPoolCreateFlagBits.ResetCommandBuffer;
            VkCommandPool pool;
            vkCreateCommandPool(device, &cmdPoolInfo, null, &pool);
            this._cmdPool = pool;
        }

        protected void createCommandBuffers() {
            // Create one command buffer for each swap chain image and reuse for rendering
            drawCmdBuffers = new VkCommandBuffer[Swapchain.ImageCount];

            VkCommandBufferAllocateInfo cmdBufAllocateInfo = new VkCommandBufferAllocateInfo();
            cmdBufAllocateInfo.sType = CommandBufferAllocateInfo;
            cmdBufAllocateInfo.level = VkCommandBufferLevel.Primary;
            cmdBufAllocateInfo.commandBufferCount = (UInt32)drawCmdBuffers.Length;
            cmdBufAllocateInfo.commandPool = cmdPool;

            //vkAllocateCommandBuffers(device, & cmdBufAllocateInfo, (VkCommandBuffer*)drawCmdBuffers.Data);
            fixed (VkCommandBuffer* pointer = drawCmdBuffers) {
                vkAllocateCommandBuffers(device, &cmdBufAllocateInfo, pointer);
            }
        }

        protected bool checkCommandBuffers() {
            foreach (var cmdBuffer in drawCmdBuffers) {
                if (cmdBuffer.handle == 0) {
                    return false;
                }
            }
            return true;
        }

        protected void destroyCommandBuffers() {
            fixed (VkCommandBuffer* pointer = drawCmdBuffers) {
                vkFreeCommandBuffers(device, cmdPool, (UInt32)drawCmdBuffers.Length, pointer);
            }
        }

        protected virtual void SetupDepthStencil() {
            VkImageCreateInfo image = new VkImageCreateInfo();
            image.sType = ImageCreateInfo;
            image.imageType = VkImageType._2d;
            image.format = DepthFormat;
            image.extent = new VkExtent3D() { width = width, height = height, depth = 1 };
            image.mipLevels = 1;
            image.arrayLayers = 1;
            image.samples = VkSampleCountFlagBits._1;
            image.tiling = VkImageTiling.Optimal;
            image.usage = (VkImageUsageFlagBits.DepthStencilAttachment | VkImageUsageFlagBits.TransferSrc);
            image.flags = 0;

            VkMemoryAllocateInfo mem_alloc = new VkMemoryAllocateInfo();
            mem_alloc.sType = MemoryAllocateInfo;
            mem_alloc.allocationSize = 0;
            mem_alloc.memoryTypeIndex = 0;

            VkImageViewCreateInfo depthStencilView = new VkImageViewCreateInfo();
            depthStencilView.sType = ImageViewCreateInfo;
            depthStencilView.viewType = VkImageViewType._2d;
            depthStencilView.format = DepthFormat;
            depthStencilView.flags = 0;
            depthStencilView.subresourceRange = new VkImageSubresourceRange();
            depthStencilView.subresourceRange.aspectMask = (VkImageAspectFlagBits.Depth | VkImageAspectFlagBits.Stencil);
            depthStencilView.subresourceRange.baseMipLevel = 0;
            depthStencilView.subresourceRange.levelCount = 1;
            depthStencilView.subresourceRange.baseArrayLayer = 0;
            depthStencilView.subresourceRange.layerCount = 1;

            {
                VkImage vkImage;
                vkCreateImage(device, &image, null, &vkImage);
                DepthStencil.Image = vkImage;
            }
            VkMemoryRequirements memReqs;
            vkGetImageMemoryRequirements(device, DepthStencil.Image, &memReqs);
            mem_alloc.allocationSize = memReqs.size;
            mem_alloc.memoryTypeIndex = vulkanDevice.getMemoryType(memReqs.memoryTypeBits, VkMemoryPropertyFlagBits.DeviceLocal);
            {
                VkDeviceMemory memory;
                vkAllocateMemory(device, &mem_alloc, null, &memory);
                DepthStencil.Mem = memory;
            }
            vkBindImageMemory(device, DepthStencil.Image, DepthStencil.Mem, 0);

            depthStencilView.image = DepthStencil.Image;
            {
                VkImageView imageView;
                vkCreateImageView(device, &depthStencilView, null, &imageView);
                DepthStencil.View = imageView;
            }
        }

        //public void RenderLoop() {
        //    destWidth = width;
        //    destHeight = height;
        //    while (NativeWindow.Exists) {
        //        var tStart = DateTime.Now;
        //        if (viewUpdated) {
        //            viewUpdated = false;
        //            viewChanged();
        //        }

        //        snapshot = NativeWindow.PumpEvents();

        //        if (!NativeWindow.Exists) {
        //            // Exit early if the window was closed this frame.
        //            break;
        //        }

        //        render();
        //        frameCounter++;
        //        var tEnd = DateTime.Now;
        //        var tDiff = tEnd - tStart;
        //        frameTimer = (float)tDiff.TotalMilliseconds / 1000.0f;
        //        _frameTimeAverager.AddTime(tDiff.TotalMilliseconds);
        //        /*
        //        camera.update(frameTimer);
        //        if (camera.moving())
        //        {
        //            viewUpdated = true;
        //        }
        //        */
        //        // Convert to clamped timer value
        //        if (!paused) {
        //            // TODO: undo
        //            //timer += timerSpeed * frameTimer;
        //            //if (timer > 1.0)
        //            //{
        //            //    timer -= 1.0f;
        //            //}
        //        }
        //        // TODO: undo
        //        //fpsTimer += (float)tDiff.TotalMilliseconds * 1000f;
        //        //if (fpsTimer > 1000.0f)
        //        //{
        //        //    if (!enableTextOverlay)
        //        //    {
        //        //        NativeWindow.Title = getWindowTitle();
        //        //    }
        //        //    lastFPS = (uint)(1.0f / frameTimer);
        //        //    // updateTextOverlay();
        //        //    fpsTimer = 0.0f;
        //        //    frameCounter = 0;
        //        //}
        //    }
        //    // Flush device to make sure all resources can be freed 
        //    vkDeviceWaitIdle(device);
        //}

        protected virtual void viewChanged() {
        }

        private string getWindowTitle() {
            var dp = DeviceProperties;
            string device = Encoding.UTF8.GetString(dp.deviceName, (int)MaxPhysicalDeviceNameSize);
            int firstNull = device.IndexOf('\0');
            device = device.Remove(firstNull);
            string windowTitle;
            windowTitle = title + " - " + device;
            if (!enableTextOverlay) {
                windowTitle += " - " + _frameTimeAverager.CurrentAverageFramesPerSecond.ToString("000.0 fps / ") + _frameTimeAverager.CurrentAverageFrameTime.ToString("#00.00 ms");
            }
            return windowTitle;
        }

        void windowResize() {
            if (!prepared) {
                return;
            }
            prepared = false;

            // Ensure all operations on the device have been finished before destroying resources
            vkDeviceWaitIdle(device);

            // Recreate swap chain
            width = destWidth;
            height = destHeight;
            SetupSwapChain();

            // Recreate the frame buffers

            vkDestroyImageView(device, DepthStencil.View, null);
            vkDestroyImage(device, DepthStencil.Image, null);
            vkFreeMemory(device, DepthStencil.Mem, null);
            SetupDepthStencil();

            for (uint i = 0; i < frameBuffers.Length; i++) {
                vkDestroyFramebuffer(device, frameBuffers[i], null);
            }
            SetupFrameBuffer();

            // Command buffers need to be recreated as they may store
            // references to the recreated frame buffer
            destroyCommandBuffers();
            createCommandBuffers();
            buildCommandBuffers();

            vkDeviceWaitIdle(device);

            if (enableTextOverlay) {
                //textOverlay->reallocateCommandBuffers();
                //updateTextOverlay();
            }

            // camera.updateAspectRatio((float)width / (float)height);

            // Notify derived class
            windowResized();
            viewChanged();

            prepared = true;
        }

        protected VkPipelineShaderStageCreateInfo loadShader(string fileName, VkShaderStageFlagBits stage) {
            VkPipelineShaderStageCreateInfo shaderStage = new VkPipelineShaderStageCreateInfo();
            shaderStage.sType = PipelineShaderStageCreateInfo;
            shaderStage.stage = stage;
            shaderStage.module = Tools.loadShader(fileName, device, stage);
            Strings.main.Set(ref shaderStage.pName);// todo : make param
            Debug.Assert(shaderStage.module.handle != 0);
            shaderModules.Add(shaderStage.module);
            return shaderStage;
        }

        protected VkCommandBuffer createCommandBuffer(VkCommandBufferLevel level, bool begin) {
            VkCommandBuffer cmdBuffer;

            VkCommandBufferAllocateInfo cmdBufAllocateInfo = new VkCommandBufferAllocateInfo();
            cmdBufAllocateInfo.sType = CommandBufferAllocateInfo;
            cmdBufAllocateInfo.commandPool = cmdPool;
            cmdBufAllocateInfo.level = level;
            cmdBufAllocateInfo.commandBufferCount = 1;

            vkAllocateCommandBuffers(device, &cmdBufAllocateInfo, &cmdBuffer);

            // If requested, also start the new command buffer
            if (begin) {
                VkCommandBufferBeginInfo cmdBufInfo = new VkCommandBufferBeginInfo();
                cmdBufInfo.sType = CommandBufferBeginInfo;
                vkBeginCommandBuffer(cmdBuffer, &cmdBufInfo);
            }

            return cmdBuffer;
        }

        protected void flushCommandBuffer(VkCommandBuffer commandBuffer, VkQueue queue, bool free) {
            if (commandBuffer.handle == 0) {
                return;
            }

            vkEndCommandBuffer(commandBuffer);

            VkSubmitInfo submitInfo = new VkSubmitInfo();
            submitInfo.sType = SubmitInfo;
            submitInfo.commandBufferCount = 1;
            submitInfo.pCommandBuffers = &commandBuffer;

            vkQueueSubmit(queue, 1, &submitInfo, new VkFence());
            vkQueueWaitIdle(queue);

            if (free) {
                vkFreeCommandBuffers(device, cmdPool, 1, &commandBuffer);
            }
        }

        protected string getAssetPath() {
            return Path.Combine(AppContext.BaseDirectory, "data/");
        }

        public virtual void Init(Control canvas) {
            this.NativeWindow = canvas;
            InitVulkan();
            SetupWin32Window();
            InitSwapchain();

            if (vulkanDevice.EnableDebugMarkers) {
                // vks::debugmarker::setup(Device);
            }

            CreateCommandPool();
            SetupSwapChain();
            createCommandBuffers();
            SetupDepthStencil();
            SetupRenderPass();
            CreatePipelineCache();
            SetupFrameBuffer();

            /* TODO: Implement text rendering
            if (enableTextOverlay)
            {
                // Load the text rendering shaders
                std::vector<VkPipelineShaderStageCreateInfo> shaderStages;
                shaderStages.push_back(loadShader(getAssetPath() + "shaders/base/textoverlay.vert.spv", VK_SHADER_STAGE_VERTEX_BIT));
                shaderStages.push_back(loadShader(getAssetPath() + "shaders/base/textoverlay.frag.spv", VK_SHADER_STAGE_FRAGMENT_BIT));
                textOverlay = new VulkanTextOverlay(
                    vulkanDevice,
                    queue,
                    frameBuffers,
                    swapChain.colorFormat,
                    depthFormat,
                    &width,
                    &height,
                    shaderStages
                    );
                updateTextOverlay();
            }
            */
        }

        public virtual void Render() {
            if (viewUpdated) {
                viewUpdated = false;
                viewChanged();
            }
        }

        protected virtual void windowResized() {
        }

        protected virtual void buildCommandBuffers() {
        }

        //protected virtual void keyPressed(Key key) {
        //}
    }

    public struct Semaphores {
        public VkSemaphore PresentComplete;
        public VkSemaphore RenderComplete;
        public VkSemaphore TextOverlayComplete;
    }

    public struct DepthStencil {
        public VkImage Image;
        public VkDeviceMemory Mem;
        public VkImageView View;
    }

    public class Settings {
        public bool Validation { get; set; } = false;
        public bool Fullscreen { get; set; } = false;
        public bool VSync { get; set; } = false;
    }
}
