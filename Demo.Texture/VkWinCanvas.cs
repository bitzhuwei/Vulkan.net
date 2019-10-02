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

namespace Demo.Texture {
    public partial class VkWinCanvas : UserControl {

        IRenderer renderer = new TextureExample();

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
                this.renderer.Init(this);
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
                IRenderer renderer = this.renderer;
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
