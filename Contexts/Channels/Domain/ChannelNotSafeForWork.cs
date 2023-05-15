using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Channels.Domain;

public class ChannelNotSafeForWork : ValueObject<bool>
{
    public ChannelNotSafeForWork(bool value) : base(value)
    {
    }
}