using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Models.Interfaces;

namespace WonderfulStore.Infra.Messaging
{
    public class AzureServiceBusQueue : IMediatorHandler
    {
        public bool SendCommand<T>(T command, string queueName)
        {
            throw new NotImplementedException();
        }
    }
}
