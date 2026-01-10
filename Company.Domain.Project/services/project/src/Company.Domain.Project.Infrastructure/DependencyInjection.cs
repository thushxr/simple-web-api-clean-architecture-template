using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Company.Domain.Project.Domain.Interfaces;
using Company.Domain.Project.Infrastructure.Repository;

namespace Company.Domain.Project.Infrastructure
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
