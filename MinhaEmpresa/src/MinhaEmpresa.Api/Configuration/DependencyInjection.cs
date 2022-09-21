using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MinhaEmpresa.Business.Interfaces;
using MinhaEmpresa.Business.Notifications;
using MinhaEmpresa.Business.Servicecs;
using MinhaEmpresa.Data.Context;
using MinhaEmpresa.Data.Repository;
using MinhaEmpresa.Identity.Exensions;

namespace MinhaEmpresa.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IExampleRepository, ExampleRepository>();
            services.AddScoped<IExampleService, ExampleService>();
            


            services.AddScoped<INotificator, Notificator>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            return services;
        }
    }
}
