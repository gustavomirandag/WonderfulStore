using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Application.Cqrs.Handlers;
using WonderfulStore.Application.Interfaces;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Application
{
    public class ProductWorkerApp : IProductWorkerApp
    {
        private ProductCommandHandler _productCommandHandler;

        public ProductWorkerApp(ProductCommandHandler productCommandHandler)
        {
            _productCommandHandler = productCommandHandler;
        }

        public void AddProduct(AddProductCommand command)
        {
            _productCommandHandler.Handle(command);
        }

        public void UpdateProduct(UpdateProductCommand command)
        {
            _productCommandHandler.Handle(command);
        }
    }
}
