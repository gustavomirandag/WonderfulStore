using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces.Repositories;

namespace WonderfulStore.Infra.DataAccess.Repositories
{
    public abstract class RepositoryBase<TId, T> : IRepository<TId, T> where T : TEntity<TId>
    {
        private DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(TId id)
        {
            var entity = ReadById(id);
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> ReadAll()
        {
            return _context.Set<T>();
        }

        public T ReadById(TId id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
