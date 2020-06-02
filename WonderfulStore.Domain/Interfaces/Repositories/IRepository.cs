using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Domain.Interfaces.Repositories
{
    public interface IRepository<TId,T>
    {
        //Repositório é APENAS um CRUD
        void Create(T entity);
        IEnumerable<T> ReadAll();
        T ReadById(TId id);
        void Update(T entity);
        void Delete(TId id);
    }
}
