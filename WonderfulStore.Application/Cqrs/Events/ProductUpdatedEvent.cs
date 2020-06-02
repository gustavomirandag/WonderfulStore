using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Application.Cqrs.Events
{
    public class ProductUpdatedEvent : ProductEvent
    {
        public const string EventQueueName = "product-updated-event-queue";
        public override string QueueName => EventQueueName;
    }
}
