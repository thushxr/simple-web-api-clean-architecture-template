using Microsoft.EntityFrameworkCore;
using Thushar.Example.Project.Domain.Entities;

namespace Thushar.Example.Project.Infrastructure
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
