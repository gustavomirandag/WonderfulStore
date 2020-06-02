using WonderfulStore.Application.Cqrs.CommandHandlers;
using WonderfulStore.Application.Cqrs.Commands;
using WonderfulStore.Application.Interfaces;

namespace WonderfulStore.Application
{
    public class ProductWorkerApp : IProductWorkerApp
    {
        private ProductCommandHandler _productCommandHandler;

        public ProductWorkerApp(ProductCommandHandler productCommandHandler)
        {
            _productCommandHandler = productCommandHandler;
        }

        public void AddProduct(AddProductCommand command)
        {
            _productCommandHandler.Handle(command);
        }

        public void UpdateProduct(UpdateProductCommand command)
        {
            _productCommandHandler.Handle(command);
        }
    }
}
