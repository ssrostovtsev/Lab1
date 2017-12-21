using System;

namespace MobilePhone {
    class Program {
        static void Main(string[] args) {
            OLEDScreen OLEDScreen = new OLEDScreen(768, 1024);
            LiPoBattery liPoBattery = new LiPoBattery(4100, 3.7, 83);
            MultiCoreCPU multiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
            SimCorpMobile scmobile = new SimCorpMobile(OLEDScreen, liPoBattery, multiCoreCPU);
            ConsoleOutput consoleOutput = new ConsoleOutput();
            scmobile.PlaybackComponent = new iPhoneHeadset(consoleOutput);
            scmobile.Play("My Song");
            scmobile.ChargeComponent = new WirelessCharger(consoleOutput);
            scmobile.Charge(5.0, 1.0);
            Console.ReadKey();
        }
    }
}
