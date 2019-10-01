using System;
using System.Collections.Generic;
using System.Text;
using CMDB.BackEnd.Manager;
using CMDB.FrontEnd.Controller;

namespace CMDB.FrontEnd
{
    public class ConsoleController
    {
        private readonly MenuController _menuController;
        private readonly ConfigurationItemController _configurationItemController;
        public ConsoleController()
        {
            _menuController = new MenuController(new List<string>
            {
                "Add CI.",
                "List CI's"
            });

            _configurationItemController = new ConfigurationItemController(new ConfigurationItemManager(), this);
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("CMDB Application MAIN");
            CreateMenu();
        }


        public void CreateMenu()
        {
            _menuController.PrintMenu();
            int selected = _menuController.SelectMenuOption();
            if (selected == 1)
            {
                AddConfigurationItem();
            }
        }

        public void AddConfigurationItem()
        {
            
            Console.WriteLine("Introduzca el nombre del configuration item:");
            _configurationItemController.CaptureData();


        }

        public static void saveCI()
        {
            Console.WriteLine("Guardando Configuration Item");
        }

        public static void listAllCI()
        {
            Console.WriteLine("Listando todos los configuration item:");
        }
    }
}
