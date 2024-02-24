using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class UserinfoRepository : Repository<Userinfo>, UserinfoRepository
{
    public UserinfoRepository(DataContext dataContext) : base(dataContext)
    {
        
    }
}