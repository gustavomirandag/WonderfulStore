using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Application.Cqrs.Events;
using WonderfulStore.Application.Models.Interfaces;
using WonderfulStore.Domain.Services;

namespace WonderfulStore.Application.Cqrs.CommandHandlers
{
    public class ProductCommandHandler : IProductCommandHandler
    {
        private ProductService _productService;
        private readonly IMediatorHandler _bus;

        public ProductCommandHandler(ProductService productService, IMediatorHandler bus)
        {
            _productService = productService;
            _bus = bus;
        }

        public void Handle(AddProductCommand command)
        {
            //Chama a implementação do Caso de Uso que está
            //no Building Block de serviço
            _productService.AddProduct(command.Product);

            _bus.Enqueue<ProductAddedEvent>(new ProductAddedEvent { Product = command.Product }, ProductAddedEvent.EventQueueName);
        }

        public void Handle(UpdateProductCommand command)
        {
            _productService.UpdateProduct(command.Product);

            _bus.Enqueue<ProductUpdatedEvent>(new ProductUpdatedEvent { Product = command.Product }, ProductUpdatedEvent.EventQueueName);
        }
    }
}
