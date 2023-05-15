using Discord.Shared.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;

public abstract class EntityFrameworkRepository<TEntity> 
    where TEntity : Entity
{
    private readonly DbContext _context;
    protected readonly DbSet<TEntity> Collection;

    protected EntityFrameworkRepository(DbContext context)
    {
        _context = context;
        Collection = context.Set<TEntity>();
    }

    protected async Task SaveChanges () => await _context.SaveChangesAsync();
}