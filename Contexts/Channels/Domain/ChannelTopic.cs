using Discord.Contexts.Channels.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Channels.Domain;

public class ChannelTopic : ValueObject<string>
{
    private const int MaxCharacters = 1024;
    
    public ChannelTopic(string value) : base(value)
    {
        EnsureIsLessThanDefinedCharacters(value);
    }
    
    private static void EnsureIsLessThanDefinedCharacters(string value)
    {
        if (value.Length > MaxCharacters)
            throw new ChannelTopicTooLongException($"{nameof(ChannelTopic)} must contains less than {MaxCharacters} characters");
    }
}