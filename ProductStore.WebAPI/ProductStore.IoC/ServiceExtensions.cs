using Microsoft.Extensions.DependencyInjection;
using ProductStore.Business;
using ProductStore.Business.Interfaces;
using ProductStore.Data.Context;
using ProductStore.Data.Interfaces;
using ProductStore.Data.Interfaces.Repositories;
using ProductStore.Data.Repositories;
using System;

namespace ProductStore.Ioc
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryBusiness, CategoryBusiness>();
            services.AddScoped<IProductBusiness, ProductBusiness>();


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();

            services.AddScoped<IDbContext, ProductStoreContext>();

            return services;
        }
    }
}
