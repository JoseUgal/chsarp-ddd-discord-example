using Discord.Contexts.Channels.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework.Configurations;

public class ChannelConfiguration : IEntityTypeConfiguration<Channel>
{
    public void Configure(EntityTypeBuilder<Channel> builder)
    {
        builder.ToTable(nameof(DiscordContext.Messages));

        #region Properties

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(v => v.Value, v => new ChannelId(v));
        
        builder.Property(x => x.Name)
            .HasConversion(v => v.Value, v => new ChannelName(v));
        
        builder.Property(x => x.Topic)
            .HasConversion(v => v.Value, v => new ChannelTopic(v));
        
        builder.Property(x => x.MessageCount)
            .HasConversion(v => v.Value, v => new ChannelMessageCount(v));

        builder.Property(x => x.NotSafeForWork)
            .HasConversion(v => v.Value, v => new ChannelNotSafeForWork(v));
        
        builder.Property(x => x.SortType);
        
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