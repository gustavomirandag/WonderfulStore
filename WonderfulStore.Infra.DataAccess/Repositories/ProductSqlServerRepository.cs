using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Infra.DataAccess.Contexts;

namespace WonderfulStore.Infra.DataAccess.Repositories
{
    public class ProductSqlServerRepository : IProductRepository
    {
        private DbContext _context;

        public ProductSqlServerRepository(DbContext context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            _context.Set<Product>().Add(product);
        }

        public void Delete(Guid id)
        {
            var product = ReadById(id);
            _context.Set<Product>().Remove(product);
        }

        public IEnumerable<Product> ReadAll()
        {
            return _context.Set<Product>();
        }

        public Product ReadById(Guid id)
        {
            return _context.Set<Product>().Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Set<Product>().Update(product);
        }
    }
}
