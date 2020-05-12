using System;
using System.Collections.Generic;
using System.Text;

namespace WonderfulStore.Application.Cqrs.Commands
{
    public abstract class Command
    {
        public abstract string QueueName { get; }
        public DateTime Timestamp  { get; set; }

        public Command()
        {
            Timestamp = new DateTime();
        }
    }
}
