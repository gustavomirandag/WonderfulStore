using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using WonderfulStore.Application.Models.Interfaces;
using WonderfulStore.Infra.Messaging.Properties;

namespace WonderfulStore.Infra.Messaging
{
    public class AzureServiceBusQueue : IMediatorHandler
    {
        private readonly string _connectionString;

        public AzureServiceBusQueue()
        {
            _connectionString = Resources.ServiceBusConnectionString;
        }

        public bool Enqueue<T>(T command, string queueName)
        {
            var message = JsonConvert.SerializeObject(command);
            SendMessageAsync(message, queueName).Wait();
            return true;
        }

        private async Task SendMessageAsync(string message, string queueName)
        {
            var queueClient = new QueueClient(_connectionString, queueName);
            var encodedMessage = new Message(Encoding.UTF8.GetBytes(message));
            await queueClient.SendAsync(encodedMessage);
            await queueClient.CloseAsync();
        }
    }
}
