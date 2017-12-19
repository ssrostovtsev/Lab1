using System;

namespace MobilePhone {
    class Program {
        static void Main(string[] args) {
            OLEDScreen OLEDScreen = new OLEDScreen(768, 1024);
            LiPoBattery liPoBattery = new LiPoBattery(4100, 3.7, 83);
            MultiCoreCPU multiCoreCPU = new MultiCoreCPU("SnapDragon", 2.1, 2);
            SimCorpMobile scmobile = new SimCorpMobile(OLEDScreen, liPoBattery, multiCoreCPU);
            Console.WriteLine(scmobile.Description());
            ScreenContent screenContent = new ScreenContent("***Screen content data***");
            scmobile.Screen.Show(screenContent);
            Console.WriteLine();
            ///without calling Description
            Console.WriteLine(scmobile.Screen.ToString());
            Console.WriteLine(scmobile.Battery.ToString());
            Console.WriteLine(scmobile.CPU.ToString());
            Console.ReadKey();
        }
    }
}
