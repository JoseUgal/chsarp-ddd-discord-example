using Discord.Contexts.Messages.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Messages.Domain;

public class MessageContent : ValueObject<string>
{
    private const int MinCharacters = 1;
    private const int MaxCharacters = 2000;
    
    public MessageContent(string value) : base(value)
    {
        EnsureIsGreaterThanDefinedCharacters(value);
        EnsureIsLessThanDefinedCharacters(value);
    }
    
    private static void EnsureIsLessThanDefinedCharacters(string value)
    {
        if (value.Length > MaxCharacters)
            throw new MessageContentTooLongException($"{nameof(MessageContent)} must contains less than {MaxCharacters} characters");
    }
    
    private static void EnsureIsGreaterThanDefinedCharacters(string value)
    {
        if (value.Length < MinCharacters)
            throw new MessageContentTooShortException($"{nameof(MessageContent)} must contains more than {MinCharacters} characters");
    }
}