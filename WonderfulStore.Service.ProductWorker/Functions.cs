using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WonderfulStore.Application.Cqrs.Commands;

namespace WonderfulStore.Service.ProductWorker
{
    public class Functions
    {
        public static async Task ProcessAddProductCommand([ServiceBusTrigger(AddProductCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);

        }
    }
}
