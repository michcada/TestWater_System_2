using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuWater_System_2
{
    public static class MenuLogic
    {
        public static string GetOption(List<string> Options, int myIndex)
        {
            return Options[myIndex];
        }

        public static bool CanConvertToInt(string id)
        {
            return int.TryParse(id, out var idNum);
        }

        public static string ReturnToMainMenu()
        {
            MainMenu.Show();
            return "Returned to Main menu";
        }

    }
}
