using Discord.Contexts.Servers.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework.Configurations;

public class ServerConfiguration : IEntityTypeConfiguration<Server>
{
    public void Configure(EntityTypeBuilder<Server> builder)
    {
        builder.ToTable(nameof(DiscordContext.Servers));

        #region Properties

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(v => v.Value, v => new ServerId(v));
        
        builder.Property(x => x.Name)
            .HasConversion(v => v.Value, v => new ServerName(v));
        
        builder.Property(x => x.Description)
            .HasConversion(v => v.Value, v => new ServerDescription(v));

        builder.Property(x => x.Tags);
        
        builder.Property(x => x.ImageUrl)
            .HasConversion(v => v == null ? null : v.Value, v => v == null ? null : new ServerImageUrl(v));

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