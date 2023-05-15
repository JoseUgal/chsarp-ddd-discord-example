using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Users.Domain.Exceptions;

public class UserWebNameInvalidValueException : InvalidDataException
{
    public UserWebNameInvalidValueException(string message): base(message) {}
}