using Microsoft.Extensions.DependencyInjection;
using Thushar.Example.Project.Application.Contract.Interfaces;
using Thushar.Example.Project.Application.Services;
using Thushar.Example.Project.Domain;

namespace Thushar.Example.Project.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IUserAppService, UserAppService>();

            services.AddDomainService();
            return services;
        }
    }
}
