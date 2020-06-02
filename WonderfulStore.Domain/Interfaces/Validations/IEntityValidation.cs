using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Domain.Interfaces.Validations
{
    public interface IEntityValidation<T>
    {
        public abstract bool IsValid(T entity);
    }
}
