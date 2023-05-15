using Discord.Contexts.Servers.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Servers.Domain;

public class ServerName : ValueObject<string>
{
    private const int MinCharacters = 3;
    private const int MaxCharacters = 100;
    
    public ServerName(string value) : base(value)
    {
        EnsureIsGreaterThanDefinedCharacters(value);
        EnsureIsLessThanDefinedCharacters(value);
    }
    
    private static void EnsureIsLessThanDefinedCharacters(string value)
    {
        if (value.Length > MaxCharacters)
            throw new ServerNameTooLongException($"{nameof(ServerName)} must contains less than {MaxCharacters} characters");
    }
    
    private static void EnsureIsGreaterThanDefinedCharacters(string value)
    {
        if (value.Length < MinCharacters)
            throw new ServerNameTooShortException($"{nameof(ServerName)} must contains more than {MinCharacters} characters");
    }
}