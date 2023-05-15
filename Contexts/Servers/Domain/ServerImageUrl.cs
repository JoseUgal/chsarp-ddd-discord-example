using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Servers.Domain;

public class ServerImageUrl : ValueObject<string>
{
    public ServerImageUrl(string value) : base(value)
    {
    }
}