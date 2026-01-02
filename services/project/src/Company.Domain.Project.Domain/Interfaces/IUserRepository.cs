namespace Company.Domain.Project.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<string?> GetUserNameAsync(Guid userId);
    }
}
