using System;
using System.Collections.Generic;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Domain.Interfaces.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid id);
        void RemoveProductById(Guid id);
        void UpdateProduct(Product product);
    }
}