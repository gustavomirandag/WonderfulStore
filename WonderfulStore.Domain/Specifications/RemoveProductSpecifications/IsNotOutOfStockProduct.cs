using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces.Specifications;

namespace WonderfulStore.Domain.Specifications.ProductSpecifications
{
    public class IsNotOutOfStockProduct : IProductSpecification
    {
        public bool IsSatisfiedBy(Product product)
        {
            if (product.Quantity <= 0)
                return false; //Product is out of stock
            return true;
        }
    }
}
