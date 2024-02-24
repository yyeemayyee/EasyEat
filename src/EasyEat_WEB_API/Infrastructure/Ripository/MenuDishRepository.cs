using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class MenuDishRepository : Repository<MenuDish>, MenuDishRepository
{
    public MenuDishRepository(DataContext dataContext) : base(dataContext)
    {
        
    }
}