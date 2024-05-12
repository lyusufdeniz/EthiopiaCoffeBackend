using EthiopiaCoffe.Infrastructure.Mapping;
using EthiopiaCoffe.Infrastructure.Services;
using EthiopiaCoffe.Persistence.UnitOfWorks;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Reflection;

namespace EthiopiaCoffe.API.Extensions
{
    public static class ServiceInjectorExtension
    {
        public static IServiceCollection InjectServices(this IServiceCollection services)
        {


            //services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IOfferService), typeof(OfferService));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(ProductObjectMap)));
            return services;

        }
    }
}
