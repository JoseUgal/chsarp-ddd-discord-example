using Discord.Contexts.Servers.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Servers.Domain;

public class ServerDescription : ValueObject<string>
{
    private const int MaxCharacters = 190;
    
    public ServerDescription(string value) : base(value)
    {
        EnsureIsLessThanDefinedCharacters(value);
    }
    
    private static void EnsureIsLessThanDefinedCharacters(string value)
    {
        if (value.Length > MaxCharacters)
            throw new ServerDescriptionTooLongException($"{nameof(ServerDescription)} must contains less than {MaxCharacters} characters");
    }
}