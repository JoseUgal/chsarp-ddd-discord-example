using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Channels.Domain;

public class ChannelMessageCount : ValueObject<int>
{
    public ChannelMessageCount(int value) : base(value)
    {
    }
}