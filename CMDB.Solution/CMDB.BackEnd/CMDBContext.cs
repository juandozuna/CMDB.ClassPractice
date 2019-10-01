using System;
using System.Collections.Generic;
using System.Text;
using CMDB.BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace CMDB.BackEnd
{
    public class CMDBContext:DbContext
    {

        public CMDBContext(DbContextOptions options):base(options)
        { }

        internal DbSet<ConfigurationItem> ConfigurationItem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
