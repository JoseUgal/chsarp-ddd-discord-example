using Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework.Configurations;
using Discord.Contexts.Users.Domain;
using Microsoft.EntityFrameworkCore;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;

public class DiscordContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DiscordContext(DbContextOptions<DiscordContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}