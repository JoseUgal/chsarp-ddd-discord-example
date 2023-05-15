using Discord.Contexts.Users.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Users.Domain;

public class UserWebName : ValueObject<string>
{
    private const int MinCharacters = 3;
    private const int MaxCharacters = 32;
    
    private static readonly List<string> InvalidNames = new() { "everyone", "here" };
    private static readonly List<string> InvalidStrings = new() { "@", "#", ":", "```", "discord" };
    
    public UserWebName(string value) : base(value)
    {
        EnsureNotEqualDefinedNames(value);
        EnsureNotContainsDefinedStrings(value);
        EnsureIsLessThanDefinedCharacters(value);
        EnsureIsGreaterThanDefinedCharacters(value);
    }

    private static void EnsureNotEqualDefinedNames(string value)
    {
        if (InvalidNames.Contains(value))
            throw new UserWebNameInvalidValueException($"{nameof(UserWebName)} can't be equal to special names");
    }
    
    private static void EnsureNotContainsDefinedStrings(string value)
    {
        if (InvalidStrings.Exists(value.Contains))
            throw new UserWebNameInvalidCharacterException($"{nameof(UserWebName)} can't contains special characters");
    }

    private static void EnsureIsLessThanDefinedCharacters(string value)
    {
        if (value.Length > MaxCharacters)
            throw new UserWebNameTooLongException($"{nameof(UserWebName)} must contains less than {MaxCharacters} characters");
    }
    
    private static void EnsureIsGreaterThanDefinedCharacters(string value)
    {
        if (value.Length < MinCharacters)
            throw new UserWebNameTooShortException($"{nameof(UserWebName)} must contains more than {MinCharacters} characters");
    }
}