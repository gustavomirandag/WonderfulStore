using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Interfaces.Specifications;

namespace WonderfulStore.Domain.Validations
{
    public abstract class EntityValidationBase<T>
    {
        protected IEnumerable<ISpecification<T>> _specifications;

        protected EntityValidationBase(IEnumerable<ISpecification<T>> specifications)
        {
            _specifications = specifications;
        }

        public bool IsValid(T entity)
        {
            foreach (var specification in _specifications)
                if (!specification.IsSatisfiedBy(entity))
                    return false;
            return true;
        }
    }
}
