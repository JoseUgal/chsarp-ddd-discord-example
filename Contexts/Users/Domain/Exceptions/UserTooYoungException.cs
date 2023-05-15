using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Users.Domain.Exceptions;

public class UserTooYoungException : InvalidDataException
{
    public UserTooYoungException(string message) : base(message)
    {
    }
}