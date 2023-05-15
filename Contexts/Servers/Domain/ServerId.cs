using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Servers.Domain;

public class ServerId : Uuid
{
    public ServerId(string value) : base(value)
    {
    }
}