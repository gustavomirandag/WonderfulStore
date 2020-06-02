using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Domain.Interfaces.Services;
using WonderfulStore.Domain.Interfaces.UoW;
using WonderfulStore.Domain.Interfaces.Validations;

namespace WonderfulStore.Domain.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _uow;
        private IProductRepository _productRepository;
        private IRemoveProductValidation _removeProductValidation;

        public ProductService(IUnitOfWork uow, IProductRepository productRepository, IRemoveProductValidation removeProductValidation)
        {
            _uow = uow;
            _productRepository = productRepository;
            _removeProductValidation = removeProductValidation;
        }

        public void AddProduct(Product product)
        {
            _uow.BeginTransaction();
            product.Id = Guid.NewGuid();
            _productRepository.Create(product);
            _uow.Commit();
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
            _uow.BeginTransaction();
            _productRepository.Update(product);
            _uow.Commit();
        }

        public void RemoveProductById(Guid id)
        {
            var product = GetProductById(id);
            if (!_removeProductValidation.IsValid(product))
                return;

            _uow.BeginTransaction();
            _productRepository.Delete(id);
            _uow.Commit();
        }
    }
}
