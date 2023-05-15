using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Users.Domain;

public class UserId : Uuid
{
    public UserId(string value) : base(value)
    {
    }
}