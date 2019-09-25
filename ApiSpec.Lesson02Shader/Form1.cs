using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiSpec.Lesson02Shader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ucShader1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.U) {
                this.ucShader1.UpdateSize();
            }
        }
    }
}
