using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Application.Interfaces
{
    public interface IProductApiApp
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        IEnumerable<Product> GetAllProducts();
    }
}
