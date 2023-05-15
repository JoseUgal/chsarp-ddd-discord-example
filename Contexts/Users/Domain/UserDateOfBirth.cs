using Discord.Contexts.Users.Domain.Exceptions;
using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Users.Domain;

public class UserDateOfBirth : ValueObject<DateTime>
{
    public UserDateOfBirth(DateTime value) : base(value)
    {
        EnsureIsAdult(value);
    }

    private static void EnsureIsAdult(DateTime value)
    {
        if (DateTime.Today.Subtract(value).TotalDays < 365.25 * 18)
            throw new UserTooYoungException($"{nameof(UserDateOfBirth)} are too young.");
    }
}