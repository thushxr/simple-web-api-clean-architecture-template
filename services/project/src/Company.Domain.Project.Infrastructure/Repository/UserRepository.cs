using Microsoft.EntityFrameworkCore;
using Company.Domain.Project.Domain.Interfaces;

namespace Company.Domain.Project.Infrastructure.Repository
{
    public class UserRepository(AppDbContext dbContext) : IUserRepository
    {
        public async Task<string?> GetUserNameAsync(Guid userId)
        {
            return await dbContext.Users
                .Where(u => u.Id == userId)
                .Select(u => u.Name)
                .FirstOrDefaultAsync();
        }
    }
}
