using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public abstract class ScreenBase {
        public ScreenBase(int width, int height) {
            this.Width = width;
            this.Height = height;
        }
        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
        public int Height  { get; set; }
        public int Width { get; set; }
    }
}
