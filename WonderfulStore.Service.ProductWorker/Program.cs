using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Host;
using System.Threading.Tasks;
using WonderfulStore.Application;
using WonderfulStore.Application.Cqrs.Handlers;
using WonderfulStore.Domain.Services;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Infra.DataAccess.Repositories;
using WonderfulStore.Infra.DataAccess.Contexts;
using WonderfulStore.Service.ProductWorker.Properties;

namespace WonderfulStore.Service.ProductWorker
{

    public class Program
    {
        static async Task Main()
        {
            //Fake Dependency Injection
            Functions.ProductWorkerApp =
                new ProductWorkerApp(
                    new ProductCommandHandler(
                        new ProductService(
                            new ProductSqlServerRepository(
                                new WonderfulStoreContext())
                            )));
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
            });
            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }
    }


}
