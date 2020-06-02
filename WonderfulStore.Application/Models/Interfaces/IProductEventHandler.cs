using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Cqrs.Events;

namespace WonderfulStore.Application.Models.Interfaces
{
    public interface IProductEventHandler
    {
        public void Handle(ProductAddedEvent domainEvent);

        public void Handle(ProductUpdatedEvent domainEvent);
    }
}
