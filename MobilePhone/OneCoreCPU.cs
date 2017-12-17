using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public class OneCoreCPU : CPUBase {
        public OneCoreCPU(string name, double frequency, int cores) : base(name, frequency,cores) {
            this.Cores = 1;
        }
        public override string ToString() {
            return "1 core CPU";
        }
    }
}
