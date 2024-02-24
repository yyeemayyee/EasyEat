using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class UserinfoRepository : Repository<Userinfo>, IUserinfoRepository
{
    public UserinfoRepository(DataContext dataContext) : base(dataContext)
    {
        
    }

    public Task<User?> GetUserinfoByAuthData()
    {
        throw new NotImplementedException();
    }
}