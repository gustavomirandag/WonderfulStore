using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Infra.DataAccess.Properties;

namespace WonderfulStore.Infra.DataAccess.Contexts
{
    public class WonderfulStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Resources.DbConnectionString);
        }

        public WonderfulStoreContext()
        {
            Database.EnsureCreated();
        }
    }
}
