using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class DishRepository : Repository<Dish>, IDishRepository
{
    public DishRepository(DataContext dataContext) : base(dataContext)
    {
        
    }
    public Task<User?> GetUserByAuthData(string login, string password, string email)
    {
        return Task.FromResult(_dataContext.Set<User>()
            .AsQueryable().FirstOrDefault(p => p.Login == login && p.Password == password && p.Email == email));
    }

    public Task<Dish?> GetDishByAuthData()
    {
        throw new NotImplementedException();
    }
}