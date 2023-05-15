using Discord.Contexts.Servers.Domain;
using Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Discord.Contexts.Servers.Infrastructure.Persistence.EntityFramework;

public class EntityFrameworkServerRepository : EntityFrameworkRepository<Server>, IServerRepository
{
    public EntityFrameworkServerRepository(DbContext context) : base(context)
    {
    }

    public async Task<Server?> Search(ServerId serverId)
    {
        return await Collection.FindAsync(serverId);
    }
}