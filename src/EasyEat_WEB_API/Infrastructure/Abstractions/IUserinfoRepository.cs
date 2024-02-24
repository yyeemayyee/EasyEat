using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IUserinfoRepository : IRepository<Userinfo>
{
    public Task<User?> GetUserinfoByAuthData();
}