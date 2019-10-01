using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMDB.BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace CMDB.BackEnd.Manager
{
    public class ConfigurationItemManager
    {
        private readonly CMDBContext _dbContext;
        private readonly DbSet<ConfigurationItem> _set;

        public ConfigurationItemManager()
        {
            _dbContext = DbContextBuilder.BuildContext();
            _set = _dbContext.ConfigurationItem;
        }

        public void AddItem(ConfigurationItem configurationItem)
        {
            _dbContext.Add(configurationItem);
            _dbContext.SaveChanges();
        }


        public ConfigurationItem GetItem(int i) => _set.Find(i);

        public ConfigurationItem GetItemByName(string name)
            => _set.FirstOrDefault(ci => ci.Name == name);
    }
}
