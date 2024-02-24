using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IUserRepository : IRepository<User>
{
    public Task<User?> GetUserByAuthData(string login, string password);
}