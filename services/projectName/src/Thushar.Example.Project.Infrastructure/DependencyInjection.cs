using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Thushar.Example.Project.Domain.Interfaces;
using Thushar.Example.Project.Infrastructure.Repository;

namespace Thushar.Example.Project.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
