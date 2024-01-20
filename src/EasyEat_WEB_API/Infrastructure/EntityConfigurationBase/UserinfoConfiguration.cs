using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurationBase;

public class UserinfoConfiguration : EntityConfigurationBase<Userinfo>
{
    protected override void ConfigureNavigationProperties(EntityTypeBuilder<Userinfo> builder)
    {
        builder
            .HasOne(e => e.User)
            .WithOne(e => e.Userinfo)
            .HasForeignKey<Userinfo>(e => e.UserId)
            .IsRequired();
    }
}