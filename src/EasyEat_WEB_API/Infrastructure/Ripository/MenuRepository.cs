using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class MenuRepository : Repository<Menu>, IMenuRepository
{
    public MenuRepository(DataContext dataContext) : base(dataContext)
    {
        
    }

    public Task<Menu?> GetMenuByAuthData()
    {
        throw new NotImplementedException();
    }
}