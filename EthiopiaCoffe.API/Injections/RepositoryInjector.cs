using EthiopiaCoffe.Persistence.Repositories;
using EthiopiaCoffe.Repository.Repositories;

namespace EthiopiaCoffe.API.Injections
{
    public static class RepositoryInjector
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));

            return services;
        }
    }
}
