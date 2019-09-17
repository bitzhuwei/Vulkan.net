using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Cubes {
    /// <summary>
    /// 
    /// </summary>
    public interface IRenderer {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="canvas"></param>
        void Init(IntPtr canvas);

        /// <summary>
        /// 
        /// </summary>
        void Render();
    }
}
