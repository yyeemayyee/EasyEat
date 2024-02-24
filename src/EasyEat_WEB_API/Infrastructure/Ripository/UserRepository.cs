using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(DataContext dataContext) : base(dataContext)
    {
        
    }
    public Task<User?> GetUserByAuthData(string login, string password)
    {
        return Task.FromResult(_dataContext.Set<User>()
            .AsQueryable().FirstOrDefault(p => p.Login == login && p.Password == password));
    }
}