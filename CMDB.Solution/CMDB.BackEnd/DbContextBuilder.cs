using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CMDB.BackEnd
{
    public class DbContextBuilder : IDesignTimeDbContextFactory<CMDBContext>
    {

        public static CMDBContext BuildContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CMDBContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=CMDBMORINGA;Trusted_Connection=True;");

            return new CMDBContext(optionsBuilder.Options);
        }

        public CMDBContext CreateDbContext(string[] args)
        {
            return BuildContext();
        }
    }
}
