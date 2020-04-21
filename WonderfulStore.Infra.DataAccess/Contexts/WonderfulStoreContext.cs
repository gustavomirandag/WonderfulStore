using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Infra.DataAccess.Contexts
{
    public class WonderfulStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:wonderfulstore-db-server.database.windows.net,1433;Initial Catalog=wonderfulstore-db;Persist Security Info=False;User ID=henrique;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
