﻿using EthiopiaCoffe.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EthiopiaCoffe.API.Extensions
{
    public static class DatabaseInjectorExtension
    {

        public static IServiceCollection InjectEFCoreForSqlServer(this IServiceCollection services, IConfiguration configuration)
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
