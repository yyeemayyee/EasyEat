using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IProgressRepository : IRepository<Progress>
{
    public Task<Progress?> GetProgressByAuthData();
}