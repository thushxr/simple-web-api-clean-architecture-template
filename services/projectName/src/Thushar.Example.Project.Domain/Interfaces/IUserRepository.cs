namespace Thushar.Example.Project.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<string?> GetUserNameAsync(Guid userId);
    }
}
