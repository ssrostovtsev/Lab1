using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    class LiPoBattery : BatteryBase {
        public LiPoBattery(int capacity, double voltage, int chargeLevel) : base(capacity, voltage, chargeLevel) { }
        public override string ToString() {
            return "LiPo Battery";
        }
    }
}
