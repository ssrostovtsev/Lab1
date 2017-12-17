using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public class RetinaScreen : ColorfulScreen {
        public RetinaScreen(int width, int height) : base(width,height) { }
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(RetinaScreen)}");
        }
        public override string ToString() {
            return "Retina Screen";
        }

    }
}
