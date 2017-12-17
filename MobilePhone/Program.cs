using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    class Program {
        static void Main(string[] args) {
            SimCorpMobile scmobile = new SimCorpMobile();
            Console.WriteLine(scmobile.Description());
            //scmobile.Screen.Show();
            Console.ReadKey();
        }
    }
}
