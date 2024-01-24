using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurationBase;

public class MenuDishConfiguration: EntityConfigurationBase<MenuDish>
{
    protected override void ConfigureNavigationProperties(EntityTypeBuilder<MenuDish> builder)
    {
        builder.HasKey(p => new { p.DishId, p.MenuId });
        
        builder
            .HasOne<Dish>(e => e.Dish)
            .WithMany(e => e.MenuDishes)
            .HasForeignKey(e => e.DishId);
        
        builder
            .HasOne<Menu>(e => e.Menu)
            .WithMany(e => e.MenuDishes)
            .HasForeignKey(e => e.MenuId);
    }
}