using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IMenuRepository : IRepository<Menu>
{
    public Task<Menu?> GetMenuByAuthData();
}