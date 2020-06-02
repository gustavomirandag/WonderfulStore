using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Interfaces.Specifications;

namespace WonderfulStore.Domain.Entities
{
    public class Product : TEntity<Guid>
    {
        public String Name { get; set; }
        public String PhotoUrl { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
