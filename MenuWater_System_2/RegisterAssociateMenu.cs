using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_System_2;

namespace MenuWater_System_2
{
    public static class RegisterAssociateMenu
    {
        public static List<string> Options = new() {"First name: ", "Last name:", "Meter ID: "};
        public static void Show(AssociateController myAsso)
        {
            Console.WriteLine(MenuLogic.GetOption(Options, 0));
            string fName = Console.ReadLine();
            Console.WriteLine(MenuLogic.GetOption(Options,1));
            string lName = Console.ReadLine();
            Console.WriteLine(MenuLogic.GetOption(Options, 2));
            string meterIdString = Console.ReadLine();
         }
    }
}
