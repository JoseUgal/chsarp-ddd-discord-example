using Discord.Contexts.Users.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(DiscordContext.Users));

        #region Properties

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(v => v.Value, v => new UserId(v));
        
        builder.Property(x => x.WebName)
            .HasConversion(v => v.Value, v => new UserWebName(v));
        
        builder.Property(x => x.Email)
            .HasConversion(v => v.Value, v => new UserEmail(v));
        
        builder.Property(x => x.DateOfBirth)
            .HasConversion(v => v.Value, v => new UserDateOfBirth(v));
        
        builder.Property(x => x.ImageUrl)
            .HasConversion(v => v == null ? null : v.Value, v => v == null ? null : new UserImageUrl(v));

        #endregion

        #region Traceable Properties

        builder.Property(x => x.CreatedAt);
        builder.Property(x => x.CreatedBy);
        builder.Property(x => x.ModifiedAt);
        builder.Property(x => x.ModifiedBy);
        builder.Property(x => x.DeletedAt);
        builder.Property(x => x.DeletedBy);

        #endregion
    }
}