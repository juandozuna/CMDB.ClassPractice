using System;
using System.Collections.Generic;
using System.Text;
using CMDB.BackEnd.Manager;
using CMDB.BackEnd.Models;
using NUnit.Framework;

namespace CMDB.BackEndTest
{
    public class ConfigurationItemTests
    {
        private ConfigurationItemManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new ConfigurationItemManager();
        }

        [Test]
        public void Given_An_Id_Get_Configuration_Item()
        {
            ConfigurationItem item = manager.GetItem(1);

            Assert.That(item, !Is.Null);
        }

        [Test]
        public void Given_A_Configuration_Item_Save_Object()
        {
            var item = new ConfigurationItem
            {
                Deprecated = false,
                Description = "Moringa is life",
                Name = "Juan",
                Version = "1.0.0"
            };

            manager.AddItem(item);

            Assert.That(item.Id, !Is.Null);
        }

        [TestCase("Juan")]
        [TestCase("Moringa")]
        [TestCase("Moringa 2")]
        public void Given_A_Configuration_Item_Name_Get_CI(string name)
        {
            ConfigurationItem item = manager.GetItemByName(name);

            Assert.That(item, !Is.Null);
            Assert.That(item.Name, Is.EqualTo(name));
        }

    }
}
