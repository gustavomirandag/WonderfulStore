using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        //Repositório é APENAS um CRUD
        void Create(Product product);
        IEnumerable<Product> ReadAll();
        Product ReadById(Guid id);
        void Update(Product product);
        void Delete(Guid id);
        void SaveChanges();
    }
}
