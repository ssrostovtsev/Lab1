using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    class LiIonBattery : BatteryBase {
        public LiIonBattery(int capacity, double voltage, int chargeLevel) : base(capacity, voltage, chargeLevel) { }
        public override string ToString() {
            return "LiIon Battery";
        }
    }
}
