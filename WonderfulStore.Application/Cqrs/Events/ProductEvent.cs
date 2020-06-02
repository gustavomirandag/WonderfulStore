using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Application.Cqrs.Events
{
    public abstract class ProductEvent : Event
    {
        public Product Product { get; set; }
    }
}
