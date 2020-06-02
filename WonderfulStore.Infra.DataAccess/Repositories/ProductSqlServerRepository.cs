using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WonderfulStore.Domain.Entities;
using WonderfulStore.Domain.Interfaces;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Infra.DataAccess.Contexts;

namespace WonderfulStore.Infra.DataAccess.Repositories
{
    public class ProductSqlServerRepository : RepositoryBase<Guid,Product>, IProductRepository
    {
        public ProductSqlServerRepository(DbContext context)
            :base(context)
        {
        }
    }
}
