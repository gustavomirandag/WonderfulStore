using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Application.Models.Interfaces
{
    public interface IMediatorHandler
    {
        bool Enqueue<T>(T command, string queueName);
    }
}
