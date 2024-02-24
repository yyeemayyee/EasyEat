using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IMenuDishRepository : IRepository<MenuDish>
{
    public Task<MenuDish?> GetMenuDishByAuthData();
}