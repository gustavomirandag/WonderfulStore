using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Application.Cqrs.Commands
{
    public class AddProductCommand : ProductCommand
    {
        public const string CommandQueueName = "add-product-command";
        public override string QueueName => CommandQueueName;
    }
}
