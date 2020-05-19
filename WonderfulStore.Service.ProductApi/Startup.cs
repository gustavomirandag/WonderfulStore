using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WonderfulStore.Application;
using WonderfulStore.Application.Interfaces;
using WonderfulStore.Application.Models.Interfaces;
using WonderfulStore.Domain.Interfaces.Repositories;
using WonderfulStore.Infra.DataAccess.Contexts;
using WonderfulStore.Infra.DataAccess.Repositories;
using WonderfulStore.Infra.Messaging;

namespace WonderfulStore.Service.ProductApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<DbContext, WonderfulStoreContext>();
            services.AddScoped<IProductRepository, ProductSqlServerRepository>();
            services.AddScoped<IMediatorHandler, AzureServiceBusQueue>();
            services.AddScoped<IProductApiApp, ProductApiApp>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
