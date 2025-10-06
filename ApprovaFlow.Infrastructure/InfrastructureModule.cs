
<<<<<<< HEAD
using System.Diagnostics;
=======
using System.Text;
>>>>>>> dd43734afb5e48e528c852123404df7029e50384
using ApprovaFlow.Infrastructure.Persistence;
using ApprovaFlow.Infrastructure.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace ApprovaFlow.Infrastructure
{
    public static  class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration config)
        {
            service.AddDataBase(config)
                .AddSecurity(config);

            return service;
        }


        private static IServiceCollection AddDataBase(this IServiceCollection service, IConfiguration config)
        {
            var connectString = config.GetConnectionString("ApprovaFlowCs");

            service.AddDbContext<ApprovaFlowDb>(o => o.UseSqlServer(connectString));
            return service;
        }

<<<<<<< HEAD
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
=======
        private static IServiceCollection AddSecurity(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IAuthService, AuthService>();


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(j =>
                {
                    j.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = config["Jwt:Issuer"],
                        ValidAudience = config["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]))
                    };
                });
>>>>>>> dd43734afb5e48e528c852123404df7029e50384
            return services;
        }
    }
}
