using Thushar.Example.Project.Application.Contract.Interfaces;
using Thushar.Example.Project.Domain.Entities;
using Thushar.Example.Project.Domain.Interfaces;

namespace Thushar.Example.Project.Application.Services
{
    public class UserAppService(IUserRepository userRepository) : IUserAppService
    {
        public async Task<string> GetUserName(Guid userId)
        {
            return await userRepository.GetUserNameAsync(userId);
        }
    }
}
