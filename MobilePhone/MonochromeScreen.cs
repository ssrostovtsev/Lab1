using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public class MonochromeScreen : ScreenBase{
        public MonochromeScreen(int width, int height) : base(width,height) { }
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}");
        }
        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}" + ", brightness is " + brightness);
        }
        public override string ToString() {
            return "Monochrome Screen";
        }
    }
}
