using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02.Mesh {
    /// <summary>
    /// 
    /// </summary>
    public interface IRenderer {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="canvas"></param>
        void Init(Control canvas);

        /// <summary>
        /// 
        /// </summary>
        void Render();
    }
}
