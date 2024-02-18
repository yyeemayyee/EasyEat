using Domain.Entity;
using Infrastructure.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Ripository;

public class Repository<T>
    : IRepository<T>
    where T : BaseEntity
{
    protected readonly DataContext _dataContext;

    public Repository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public virtual async Task<List<T>> GetAllAsync()
    {
        return await _dataContext.Set<T>().ToListAsync();
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        return (await _dataContext.Set<T>().AddAsync(entity)).Entity;
    }

    public virtual void Update(T entity)
    {
        _dataContext.Entry(entity).State = EntityState.Modified;
    }

    /// <summary>
    /// Сохранить изменения.
    /// </summary>
    public virtual async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _dataContext.SaveChangesAsync(cancellationToken);
    }
}