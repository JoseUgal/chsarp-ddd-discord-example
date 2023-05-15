using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Channels.Domain;

public class ChannelId : Uuid
{
    public ChannelId(string value) : base(value)
    {
    }
}