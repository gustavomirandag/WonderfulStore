using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String PhotoUrl { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
