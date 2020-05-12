using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Application.Cqrs.Commands
{
    public abstract class ProductCommand : Command
    {
        public Product Product { get; set; }
    }
}
