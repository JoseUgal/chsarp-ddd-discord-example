using Discord.Contexts.Channels.Domain;
using Discord.Contexts.Channels.Infrastructure.Persistence.EntityFramework;
using Discord.Contexts.Servers.Domain;
using Discord.Contexts.Servers.Infrastructure.Persistence.EntityFramework;
using Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;
using Discord.Contexts.Users.Domain;
using Discord.Contexts.Users.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Backend.Extensions.DependencyInjection;

public static class Infrastructure
{
    public static void AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DiscordContext>(options => 
                options.UseMySQL(connectionString, serverOptions => serverOptions.EnableRetryOnFailure()),
            ServiceLifetime.Transient
        );
        
        services.AddScoped<IChannelRepository, EntityFrameworkChannelRepository>();
        services.AddScoped<IServerRepository, EntityFrameworkServerRepository>();
        services.AddScoped<IUserRepository, EntityFrameworkUserRepository>();
    }
}