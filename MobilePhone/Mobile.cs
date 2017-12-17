using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract CPUBase CPU { get; }
        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }
        public string Description() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()} ({Screen.Width}X{Screen.Height})");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()} ({Battery.Capacity} mAh; {Battery.Voltage} V; {Battery.ChargeLevel} %)");
            descriptionBuilder.AppendLine($"CPU Type: {CPU.ToString()} ({CPU.Name}; {CPU.Frequency} GHz; {CPU.Cores} cores)");

            return descriptionBuilder.ToString();
        }

    }
}
