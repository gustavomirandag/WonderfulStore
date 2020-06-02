using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Guid,Product>
    {
    }
}
