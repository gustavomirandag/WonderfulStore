using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using WonderfulStore.Application.Models.Interfaces;

namespace WonderfulStore.Infra.Messaging
{
    public class AzureStorageAccountQueue : IMediatorHandler
    {
        private readonly string _connectionString;

        public bool SendCommand<T>(T command, string queueName)
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
