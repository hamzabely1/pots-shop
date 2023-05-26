using Api.Business.Service;
using Api.Business.Service.Contract;
using Api.Data.Context;
using Api.Data.Context.Contract;
using Api.Data.Entity;
using Api.Data.Repository;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;



namespace Api.Ioc.Test
{
    public static class IocTest
    {
        public static IServiceCollection ConfigureInjectionDependencyRepositoryTest(this IServiceCollection services)
        {
            services.ConfigureInjectionDependencyRepository();


            return services;
        }
        public static IServiceCollection ConfigureInjectionDependencyServiceTest(this IServiceCollection services)
        {
            // Injections des Dépendances
            // - Service

            services.ConfigureInjectionDependencyService();

            return services;
        }
        public static IServiceCollection ConfigureDBContextTest(this IServiceCollection services)
        {

            services.AddDbContext<IDBContext, DBContext>(options =>
                 options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()));


            return services;
        }
    }
}
