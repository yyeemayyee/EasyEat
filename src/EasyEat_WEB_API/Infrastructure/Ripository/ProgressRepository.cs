using Domain.Entity;
using Infrastructure.Abstractions;

namespace Infrastructure.Ripository;

public class ProgressRepository : Repository<Progress>, ProgressRepository
{
    public ProgressRepository(DataContext dataContext) : base(dataContext)
    {
        
    }
}