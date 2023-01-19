using Water_System_2;

namespace MenuWater_System_2
{
    public static class MainMenu
    {
        public static List<string> Options = new (){ "1. Register associate" };
        public static void Show(AssociateController myAsso)
        {
            Console.WriteLine(MenuLogic.GetOption(Options,0));
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    RegisterAssociateMenu.Show(myAsso);
                    break;

            }
        }
    }
}