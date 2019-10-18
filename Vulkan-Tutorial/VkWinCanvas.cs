using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Vulkan_Tutorial;

namespace Vulkan {
    public partial class VkWinCanvas : UserControl {

        VulkanTutorial renderer;

        protected readonly bool designMode;

        private Timer timer = new Timer();

        public VkWinCanvas() {
            InitializeComponent();

            this.designMode = this.DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
            if (this.designMode) {
                this.BackColor = Color.Red;
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (!this.designMode) {
                this.renderer = new VulkanTutorial();
                this.renderer.Init(this.Handle, Process.GetCurrentProcess().Handle);
                this.timer.Interval = 50;
                this.timer.Tick += Timer_Tick;
                this.timer.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
            if (this.designMode) {
                base.OnPaintBackground(e);
            }
            else {
                var renderer = this.renderer;
                if (renderer != null) {
                    renderer.Render();
                }
                else {
                    base.OnPaintBackground(e);
                }
            }
        }
    }
}
