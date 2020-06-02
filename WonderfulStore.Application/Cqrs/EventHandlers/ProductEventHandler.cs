using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Application.Cqrs.Events;
using WonderfulStore.Application.Models.Interfaces;

namespace WonderfulStore.Application.Cqrs.EventHandlers
{
    public class ProductEventHandler : EventHandler, IProductEventHandler
    {
        public void Handle(ProductAddedEvent domainEvent){
            throw new NotImplementedException();
        }

        public void Handle(ProductUpdatedEvent domainEvent)
        {
            throw new NotImplementedException();
        }

    }
}
