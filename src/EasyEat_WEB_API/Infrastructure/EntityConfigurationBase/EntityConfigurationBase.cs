using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurationBase;

public abstract class EntityConfigurationBase<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity: BaseEntity
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(p => p.Id);
    }
    
    protected virtual void ConfigureProperties(EntityTypeBuilder<TEntity> builder)
    {
    }

    protected virtual void ConfigureNavigationProperties(EntityTypeBuilder<TEntity> builder)
    {
    }

    protected virtual void ConfigureIndexes(EntityTypeBuilder<TEntity> builder)
    {
    }
}