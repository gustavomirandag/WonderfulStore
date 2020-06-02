using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Cqrs.Commands;

namespace WonderfulStore.Application.Models.Interfaces
{
    public interface IProductCommandHandler
    {
        public void Handle(AddProductCommand command);
        public void Handle(UpdateProductCommand command);
    }
}
