using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Application.Cqrs.EventHandlers;
using WonderfulStore.Application.Cqrs.Events;
using WonderfulStore.Application.Interfaces;
using WonderfulStore.Application.Models.Interfaces;

namespace WonderfulStore.Service.ProductWorker
{
    public class Functions
    {
        public readonly IProductWorkerApp _productWorkerApp;
        public readonly IProductEventHandler _eventHandler;

        public Functions(IProductWorkerApp productWorkerApp, IProductEventHandler eventHandler)
        {
            _productWorkerApp = productWorkerApp;
            _eventHandler = eventHandler;
        }

        public void ProcessAddProductCommand([ServiceBusTrigger(AddProductCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var command = JsonConvert.DeserializeObject<AddProductCommand>(message);
            _productWorkerApp.AddProduct(command);
        }

        public void ProcessUpdateProductCommand([ServiceBusTrigger(UpdateProductCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var command = JsonConvert.DeserializeObject<UpdateProductCommand>(message);
            _productWorkerApp.UpdateProduct(command);
        }

        public void ProcessProductAddedEvent([ServiceBusTrigger(ProductAddedEvent.EventQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var domainEvent = JsonConvert.DeserializeObject<ProductAddedEvent>(message);
            _eventHandler.Handle(domainEvent);
        }

        public void ProcessProductUpdatedEvent([ServiceBusTrigger(ProductUpdatedEvent.EventQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var domainEvent = JsonConvert.DeserializeObject<ProductUpdatedEvent>(message);
            _eventHandler.Handle(domainEvent);
        }
    }
}
