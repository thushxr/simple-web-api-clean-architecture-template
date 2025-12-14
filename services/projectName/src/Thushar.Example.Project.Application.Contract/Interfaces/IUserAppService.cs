namespace Thushar.Example.Project.Application.Contract.Interfaces
{
    public interface IUserAppService
    {
        Task<string> GetUserName(Guid userId);
    }
}
