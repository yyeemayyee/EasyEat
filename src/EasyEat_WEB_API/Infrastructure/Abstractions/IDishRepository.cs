using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IDishRepository : IRepository<Dish>
{
    public Task<Dish?> GetDishByAuthData();
}