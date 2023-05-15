using Discord.Contexts.Messages.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable(nameof(DiscordContext.Messages));

        #region Properties

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(v => v.Value, v => new MessageId(v));
        
        builder.Property(x => x.Content)
            .HasConversion(v => v.Value, v => new MessageContent(v));
        
        builder.Property(x => x.TextToSpeech)
            .HasConversion(v => v.Value, v => new MessageTextToSpeech(v));
        
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