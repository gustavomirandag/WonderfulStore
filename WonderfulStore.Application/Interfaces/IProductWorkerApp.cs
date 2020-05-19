using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Application.Interfaces
{
    public interface IProductWorkerApp
    {
        void AddProduct(AddProductCommand command);
        void UpdateProduct(UpdateProductCommand command);
    }
}
