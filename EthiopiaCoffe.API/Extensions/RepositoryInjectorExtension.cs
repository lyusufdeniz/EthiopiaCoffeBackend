using EthiopiaCoffe.Persistence.Repositories;
using EthiopiaCoffe.Repository.Repositories;

namespace EthiopiaCoffe.API.Extensions
{
    public static class RepositoryInjectorExtension
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddScoped(typeof(IOfferRepository), typeof(OfferRepository));
            return services;
        }
    }
}
