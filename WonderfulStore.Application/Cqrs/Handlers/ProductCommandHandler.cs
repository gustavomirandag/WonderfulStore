using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WonderfulStore.Application.Cqrs.Commands;

namespace WonderfulStore.Application.Cqrs.Handlers
{
    public class ProductCommandHandler
    {
        public async Task HandleAsync(AddProductCommand command)
        {
            //Chama a implementação do Caso de Uso que está
            //no Building Block de serviço
            throw new NotImplementedException();
        }

        public async Task HandleAsync(UpdateProductCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
