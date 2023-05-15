using Discord.Contexts.Channels.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Channels.Domain;

public class ChannelName : ValueObject<string>
{
    private const int MinCharacters = 1;
    private const int MaxCharacters = 100;
    
    public ChannelName(string value) : base(value)
    {
        EnsureIsLessThanDefinedCharacters(value);
        EnsureIsGreaterThanDefinedCharacters(value);
    }
    
    private static void EnsureIsLessThanDefinedCharacters(string value)
    {
        if (value.Length > MaxCharacters)
            throw new ChannelNameTooLongException($"{nameof(ChannelName)} must contains less than {MaxCharacters} characters");
    }
    
    private static void EnsureIsGreaterThanDefinedCharacters(string value)
    {
        if (value.Length < MinCharacters)
            throw new ChannelNameTooShortException($"{nameof(ChannelName)} must contains more than {MinCharacters} characters");
    }
}