using System.Text.RegularExpressions;
using Discord.Contexts.Users.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Users.Domain;

public partial class UserEmail : ValueObject<string>
{
    [GeneratedRegex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$")]
    private static partial Regex ValidEmailRegex();
    
    public UserEmail(string value) : base(value)
    {
        EnsureIsValidEmail(value);
    }

    private static void EnsureIsValidEmail(string value)
    {
        if (!ValidEmailRegex().IsMatch(value))
            throw new UserEmailInvalidException($"{nameof(UserEmail)} are invalid with value {value}");
    }
}