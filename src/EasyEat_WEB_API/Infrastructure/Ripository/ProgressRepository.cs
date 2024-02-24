using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class ProgressRepository : Repository<Progress>, IProgressRepository
{
    public ProgressRepository(DataContext dataContext) : base(dataContext)
    {
        
    }

    public Task<Progress?> GetProgressByAuthData()
    {
        throw new NotImplementedException();
    }
}