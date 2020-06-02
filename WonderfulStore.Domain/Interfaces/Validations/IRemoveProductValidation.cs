using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Validations;

namespace WonderfulStore.Domain.Interfaces.Validations
{
    public interface IRemoveProductValidation : IEntityValidation<Product>
    {
    }
}
