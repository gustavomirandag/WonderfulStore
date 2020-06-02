using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces.Specifications;
using WonderfulStore.Domain.Interfaces.Validations;

namespace WonderfulStore.Domain.Validations
{
    public class RemoveProductValidation : EntityValidationBase<Product>
    {
        public RemoveProductValidation(IEnumerable<ISpecification<Product>> specifications)
            :base(specifications)
        {
        }
    }
}
