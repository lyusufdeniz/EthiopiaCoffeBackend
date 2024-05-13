using EthiopiaCoffe.Infrastructure.Mapping;
using EthiopiaCoffe.Infrastructure.Services;
using EthiopiaCoffe.Infrastructure.Validations.Category;
using EthiopiaCoffe.Persistence.UnitOfWorks;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace EthiopiaCoffe.API.Extensions
{
    public static class ServiceInjectorExtension
    {
        public static IServiceCollection InjectServices(this IServiceCollection services)
        {


            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IOfferService), typeof(OfferService));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(ProductObjectMap)));
           services.AddValidatorsFromAssemblyContaining(typeof(CategoryAddValidator));
            services.AddFluentValidationAutoValidation();

            return services;

        }
    }
}
