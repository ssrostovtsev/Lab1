﻿using System.Text;

namespace MobilePhone {
    public abstract class Mobile {
        public Mobile() { }
        public Mobile(ScreenBase screen, BatteryBase battery, CPUBase cpu) { }
        public abstract ScreenBase Screen { get; set; }
        public abstract BatteryBase Battery { get; set; }
        public abstract CPUBase CPU { get; set; }
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
