using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Domain.Interfaces.Specifications
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
