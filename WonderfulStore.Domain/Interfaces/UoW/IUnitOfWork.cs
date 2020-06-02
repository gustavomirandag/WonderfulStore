using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Domain.Interfaces.UoW
{
    public interface IUnitOfWork
    {
        public void BeginTransaction();
        public bool Commit();
    }
}
