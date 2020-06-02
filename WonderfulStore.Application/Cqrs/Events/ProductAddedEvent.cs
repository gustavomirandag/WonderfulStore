using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Application.Cqrs.Events
{
    public class ProductAddedEvent : ProductEvent
    {
        public const string EventQueueName = "product-added-event-queue";
        public override string QueueName => EventQueueName;
    }
}
