using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Users.Domain.Exceptions;

public class UserWebNameInvalidCharacterException : InvalidDataException
{
    public UserWebNameInvalidCharacterException(string message): base(message) {}
}