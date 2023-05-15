using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Users.Domain.Exceptions;

public class UserEmailInvalidException : InvalidDataException
{
    public UserEmailInvalidException(string message) : base(message)
    {
    }
}