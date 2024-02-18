using Domain.Entity;

namespace Infrastructure.Abstractions;

public interface IRepository<T>
    where T : BaseEntity
{
    Task<T?> GetByIdAsync(int id);

    Task<List<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    void Update(T entity);

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}