﻿using Api.Business.Service.Contract;
using Api.Business.Service.Services;
using Api.Data.Context;
using Api.Data.Context.Contract;
using Api.Data.Repository;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Api.Ioc
{
    public static class Ioc
    {
        public static IServiceCollection ConfigureInjectionDependencyRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryUser, RepositoryUser>();
            services.AddScoped<IRepositoryItem, RepositoryItem>();
            services.AddScoped<IRepositoryAddress, RepositoryAddress>();
            services.AddScoped<IRepositoryComments, RepositoryComments>();


            return services;
        }
        public static IServiceCollection ConfigureInjectionDependencyService(this IServiceCollection services)
        {
            // Injections des Dépendances
            // - Service

            services.AddScoped<IServiceUser, ServiceUser>();
            services.AddScoped<IServiceItem, ServiceItem>();
            services.AddScoped<IServiceComments, ServiceComments>();

            return services;
        }
        public static IServiceCollection ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("BddConnection");

            services.AddDbContext<IDBContext, DBContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());

            return services;
        }
    }
}
