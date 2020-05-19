using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Models.Interfaces;

namespace WonderfulStore.Infra.Messaging
{
    public class AzureStorageAccountQueue : IMediatorHandler
    {
        public bool SendCommand<T>(T command, string queueName)
        {
            throw new NotImplementedException();
        }
    }
}
