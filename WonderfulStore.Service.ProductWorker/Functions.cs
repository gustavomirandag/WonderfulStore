using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Application.Interfaces;

namespace WonderfulStore.Service.ProductWorker
{
    public class Functions
    {
        public static IProductWorkerApp ProductWorkerApp { get; set; }

        public static void ProcessAddProductCommand([ServiceBusTrigger(AddProductCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var command = JsonConvert.DeserializeObject<AddProductCommand>(message);
            ProductWorkerApp.AddProduct(command);
        }

        public static void ProcessUpdateProductCommand([ServiceBusTrigger(UpdateProductCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var command = JsonConvert.DeserializeObject<UpdateProductCommand>(message);
            ProductWorkerApp.UpdateProduct(command);
        }
    }
}
