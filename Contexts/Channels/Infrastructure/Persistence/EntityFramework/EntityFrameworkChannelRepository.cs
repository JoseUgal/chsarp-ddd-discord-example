using Discord.Contexts.Channels.Domain;
using Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Discord.Contexts.Channels.Infrastructure.Persistence.EntityFramework;

public class EntityFrameworkChannelRepository : EntityFrameworkRepository<Channel>, IChannelRepository
{
    public EntityFrameworkChannelRepository(DbContext context) : base(context)
    {
    }

    public async Task<Channel?> Search(ChannelId channelId)
    {
        return await Collection.FindAsync(channelId);
    }
}