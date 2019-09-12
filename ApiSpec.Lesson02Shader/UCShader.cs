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

namespace ApiSpec.Lesson02Shader {
    public partial class UCShader : UserControl {

        LessonShader lesson;

        protected readonly bool designMode;

        public UCShader() {
            InitializeComponent();

            this.designMode = this.DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
            if (this.designMode) {
                this.BackColor = Color.Red;
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (!this.designMode) {
                this.lesson = new LessonShader();
                this.lesson.Init(this.Handle, Process.GetCurrentProcess().Handle);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
            if (this.designMode) {
                base.OnPaintBackground(e);
            }
            else {
                var lesson = this.lesson;
                if (lesson != null) {
                    lesson.Render();
                }
                else {
                    base.OnPaintBackground(e);
                }
            }
        }
    }
}
