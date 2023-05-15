using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Users.Domain.Exceptions;

public class UserWebNameTooLongException : InvalidDataException
{
    public UserWebNameTooLongException(string message): base(message) {}
}