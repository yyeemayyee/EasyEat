using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurationBase;

public class UserConfiguration : EntityConfigurationBase<User>
{
    protected override void ConfigureNavigationProperties(EntityTypeBuilder<User> builder)
    {
        builder
            .HasOne(e => e.Userinfo)
            .WithOne(e => e.User)
            .HasForeignKey<Userinfo>(e => e.UserId)
            .IsRequired();
    }
}