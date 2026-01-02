using Microsoft.Extensions.DependencyInjection;
using Company.Domain.Project.Application.Contract.Interfaces;
using Company.Domain.Project.Application.Services;
using Company.Domain.Project.Domain;

namespace Company.Domain.Project.Application
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
