using EthiopiaCoffe.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EthiopiaCoffe.API.Injections
{
    public static class DatabaseInjector
    {
    
        public static IServiceCollection InjectEFCoreForSqlServer(this IServiceCollection services,   IConfiguration configuration )
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("SqlServer"), option =>
                {
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext))!.GetName().Name);
                });
            });
            return services;

        }
    }
}
