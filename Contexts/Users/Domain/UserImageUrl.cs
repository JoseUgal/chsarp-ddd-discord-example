using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Users.Domain;

public class UserImageUrl : ValueObject<string>
{
    public UserImageUrl(string value) : base(value)
    {
    }
}