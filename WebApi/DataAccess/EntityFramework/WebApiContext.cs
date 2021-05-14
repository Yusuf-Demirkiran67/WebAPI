using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities.Concrete;

namespace WebApi.DataAccess.EntityFramework
{
    public class WebApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;
            Database = WebApi; Trusted_Connection = true");

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
