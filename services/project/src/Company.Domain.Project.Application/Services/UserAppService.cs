using Company.Domain.Project.Application.Contract.Interfaces;
using Company.Domain.Project.Domain.Entities;
using Company.Domain.Project.Domain.Interfaces;

namespace Company.Domain.Project.Application.Services
{
    public class UserAppService(IUserRepository userRepository) : IUserAppService
    {
        public async Task<string> GetUserName(Guid userId)
        {
            return await userRepository.GetUserNameAsync(userId);
        }
    }
}
