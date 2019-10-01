using System;
using System.Collections.Generic;
using System.Text;
using CMDB.BackEnd.Manager;
using CMDB.BackEnd.Models;

namespace CMDB.FrontEnd.Controller
{
    public class ConfigurationItemController
    {
        private ConfigurationItemManager _configurationItemManager;
        private ConsoleController _consoleController;
        public ConfigurationItemController(
            ConfigurationItemManager configurationItemManager, ConsoleController consoleController)
        {
            _configurationItemManager = configurationItemManager;
            _consoleController = consoleController;
        }

        public void CaptureData()
        {
            ConfigurationItem ci = new ConfigurationItem();
            Console.Write("Name: ");
            ci.Name = Console.ReadLine();
            Console.Write("Version: ");
            ci.Version = Console.ReadLine();
            Console.Write("Description: ");
            ci.Description = Console.ReadLine();

            _configurationItemManager.AddItem(ci);
            Console.WriteLine("Saved");
            Console.ReadKey();
            _consoleController.Start();
        }

        private bool ValidateVersion()
        {
            return true;
        }
    }
}
