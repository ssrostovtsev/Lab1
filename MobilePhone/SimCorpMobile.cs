using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public class SimCorpMobile : Mobile{
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen(768,1024);
        public override BatteryBase Battery { get { return vLiPoBattery; } }
        private readonly LiPoBattery vLiPoBattery = new LiPoBattery(4100,3.7,83);
        public override CPUBase CPU { get { return vMultiCoreCPU; } }
        private readonly MultiCoreCPU vMultiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
    }
}
