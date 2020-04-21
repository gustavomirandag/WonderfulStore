using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Domain.Interfaces.Services;

namespace WonderfulStore.Domain.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            _productRepository.Create(product);
            _productRepository.SaveChanges();
        }

        public Product GetProductById(Guid id)
        {
            return _productRepository.ReadById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.ReadAll();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.SaveChanges();
        }

        public void RemoveProductById(Guid id)
        {
            _productRepository.Delete(id);
            _productRepository.SaveChanges();
        }
    }
}
