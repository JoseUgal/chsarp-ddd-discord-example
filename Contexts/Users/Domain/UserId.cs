using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Users.Domain;

public class UserId : Uuid
{
    protected UserId(string value) : base(value)
    {
    }
}