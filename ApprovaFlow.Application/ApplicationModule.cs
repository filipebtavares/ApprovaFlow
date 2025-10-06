using Microsoft.Extensions.DependencyInjection;
using FluentValidation;


namespace ApprovaFlow.Application
{
    public static class  ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddValidation (this IServiceCollection services)
        {
            
            return services;
        }
    }
}
