using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson01lear {
    public partial class UCClear : UserControl {

        LessonClear lesson;

        protected readonly bool designMode;

        public UCClear() {
            InitializeComponent();

            this.designMode = this.DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (!this.designMode) {
                this.lesson = new LessonClear();
                this.lesson.Init();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
            if (this.designMode) {
                base.OnPaintBackground(e);
            } else {
                var lesson = this.lesson;
                if (lesson != null) {
                    lesson.Render();
                } else {
                    base.OnPaintBackground(e);
                }
            }
        }
    }
}
