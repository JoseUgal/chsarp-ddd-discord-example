using Discord.Contexts.Shared.Infrastructure.Persistence.EntityFramework;
using Discord.Contexts.Users.Domain;
using Microsoft.EntityFrameworkCore;

namespace Discord.Contexts.Users.Infrastructure.Persistence.EntityFramework;

public class EntityFrameworkUserRepository : EntityFrameworkRepository<User>, IUserRepository
{
    public EntityFrameworkUserRepository(DbContext context) : base(context) { }
    
    public async Task<User?> Search(UserId userId)
    {
        return await Collection.FindAsync(userId);
    }

    public async Task Save(User user)
    {
        Collection.Update(user);

        await SaveChanges();
    }
}