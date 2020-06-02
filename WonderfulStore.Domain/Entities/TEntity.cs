using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Interfaces.Specifications;

namespace WonderfulStore.Domain.Entities
{
    public abstract class TEntity<TId>
    {
        public TId Id { get; set; }
    }
}
