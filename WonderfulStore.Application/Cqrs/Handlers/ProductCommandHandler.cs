using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Domain.Services;

namespace WonderfulStore.Application.Cqrs.Handlers
{
    public class ProductCommandHandler
    {
        private ProductService _productService;

        public ProductCommandHandler(ProductService productService)
        {
            _productService = productService;
        }

        public void Handle(AddProductCommand command)
        {
            //Chama a implementação do Caso de Uso que está
            //no Building Block de serviço
            _productService.AddProduct(command.Product);
        }

        public void Handle(UpdateProductCommand command)
        {
            _productService.UpdateProduct(command.Product);
        }
    }
}
