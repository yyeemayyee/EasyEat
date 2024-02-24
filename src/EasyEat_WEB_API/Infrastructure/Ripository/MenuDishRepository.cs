using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class MenuDishRepository : Repository<MenuDish>, IMenuDishRepository
{
    public MenuDishRepository(DataContext dataContext) : base(dataContext)
    {
        
    }

    public Task<MenuDish?> GetMenuDishByAuthData()
    {
        throw new NotImplementedException();
    }
}