
using System.Diagnostics;
using ApprovaFlow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApprovaFlow.Infrastructure
{
    public static  class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration config)
        {
            service.AddDataBase(config);

            return service;
        }


        private static IServiceCollection AddDataBase(this IServiceCollection service, IConfiguration config)
        {
            var connectString = config.GetConnectionString("ApprovaFlowCs");

            service.AddDbContext<ApprovaFlowDb>(o => o.UseSqlServer(connectString));
            return service;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}
