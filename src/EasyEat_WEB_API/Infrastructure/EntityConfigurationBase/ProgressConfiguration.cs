using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurationBase;

public class ProgressConfiguration: EntityConfigurationBase<Progress>
{
    protected override void ConfigureNavigationProperties(EntityTypeBuilder<Progress> builder)
    {
        builder
            .HasOne(e => e.Userinfo)
            .WithOne(e => e.Progress)
            .HasForeignKey<Progress>(e => e.UserinfoId)
            .IsRequired();
    }
}