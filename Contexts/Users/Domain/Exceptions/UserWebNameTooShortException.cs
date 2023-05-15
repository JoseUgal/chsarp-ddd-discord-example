using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Users.Domain.Exceptions;

public class UserWebNameTooShortException : InvalidDataException
{
    public UserWebNameTooShortException(string message): base(message) {}
}