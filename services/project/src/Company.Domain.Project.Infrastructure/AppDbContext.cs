using Microsoft.EntityFrameworkCore;
using Company.Domain.Project.Domain.Entities;

namespace Company.Domain.Project.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
