using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Threading.Tasks;
using WonderfulStore.Application;
using WonderfulStore.Application.Cqrs.CommandHandlers;
using WonderfulStore.Application.Cqrs.EventHandlers;
using WonderfulStore.Application.Interfaces;
using WonderfulStore.Application.Models.Interfaces;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Domain.Interfaces.Services;
using WonderfulStore.Domain.Interfaces.Specifications;
using WonderfulStore.Domain.Interfaces.UoW;
using WonderfulStore.Domain.Services;
using WonderfulStore.Domain.Specifications.ProductSpecifications;
using WonderfulStore.Domain.Validations;
using WonderfulStore.Infra.DataAccess;
using WonderfulStore.Infra.DataAccess.Contexts;
using WonderfulStore.Infra.DataAccess.Repositories;
using WonderfulStore.Infra.Messaging;
using WonderfulStore.Service.ProductWorker.Properties;

namespace WonderfulStore.Service.ProductWorker
{

    public class Program
    {
        static async Task Main()
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddServiceBus(sbOptions =>
                {
                    sbOptions.ConnectionString = Resources.ServiceBusConnectionString;
                    sbOptions.MessageHandlerOptions.AutoComplete = true;
                    sbOptions.MessageHandlerOptions.MaxConcurrentCalls = 16;
                });
            }).ConfigureServices(services =>
            {
                services.AddSingleton<IMediatorHandler,AzureServiceBusQueue>();
                services.AddSingleton<IProductRepository, ProductSqlServerRepository>();
                services.AddSingleton<DbContext, WonderfulStoreContext>();
                services.AddSingleton<IUnitOfWork, UnitOfWork>();
                services.AddSingleton<IProductService, ProductService>();
                services.AddSingleton<IProductCommandHandler, ProductCommandHandler>();
                services.AddSingleton<IProductEventHandler, ProductEventHandler>();
                services.AddSingleton<IProductWorkerApp, ProductWorkerApp>();
            });
            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }
    }
}