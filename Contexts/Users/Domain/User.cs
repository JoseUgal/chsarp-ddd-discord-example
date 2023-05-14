using Discord.Shared.Domain.Aggregate;

namespace Discord.Contexts.Users.Domain;

public class User : AggregateRoot
{
    public UserId Id { get; }

    public User(UserId id)
    {
        Id = id;
    }
}