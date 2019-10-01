using System;
using System.Collections.Generic;

namespace CMDB.FrontEnd.Controller
{
    public class MenuController
    {
        private readonly List<string> _menuItems;
        public MenuController(List<string> menuItems)
        {
            _menuItems = menuItems;
        }


        public void PrintMenu()
        {
            Console.WriteLine("MENU");
            for (int i = 0; i < _menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {_menuItems[i]}");
            }
            Console.WriteLine($"{_menuItems.Count + 1}) Exit");
        }

        public int SelectMenuOption()
        {
            Console.Write("Select an Option: ");
            string option = Console.ReadLine();

            int parsed = Int32.Parse(option);

            if (parsed == _menuItems.Count + 1)
            {
                Environment.Exit(0);
                return 0;
            }

            return parsed;
        }

        
    }
}
