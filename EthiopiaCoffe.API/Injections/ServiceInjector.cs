﻿using EthiopiaCoffe.Infrastructure.Mapping;
using EthiopiaCoffe.Infrastructure.Services;
using EthiopiaCoffe.Persistence.UnitOfWorks;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Reflection;

namespace EthiopiaCoffe.API.Injections
{
    public static class ServiceInjector 
    {
        public static IServiceCollection InjectServices(this IServiceCollection services)
        {
         
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(ProductObjectMap)));
            return services;

        }
    }
}
