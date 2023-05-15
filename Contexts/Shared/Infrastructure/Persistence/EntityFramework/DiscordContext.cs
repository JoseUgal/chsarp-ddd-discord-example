using Discord.Contexts.Channels.Domain;
using Discord.Contexts.Messages.Domain;
using Discord.Contexts.Servers.Domain;
using Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework.Configurations;
using Discord.Contexts.Users.Domain;
using Microsoft.EntityFrameworkCore;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;

public class DiscordContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Channel> Channels { get; set; }

    public DiscordContext(DbContextOptions<DiscordContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new ServerConfiguration());
        modelBuilder.ApplyConfiguration(new MessageConfiguration());
        modelBuilder.ApplyConfiguration(new ChannelConfiguration());
    }
}