using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class MenuRepository : Repository<Menu>, MenuRepository
{
    public MenuRepository(DataContext dataContext) : base(dataContext)
    {
        
    }
}