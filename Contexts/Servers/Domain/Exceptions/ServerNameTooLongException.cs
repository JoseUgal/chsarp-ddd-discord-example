using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Servers.Domain.Exceptions;

public class ServerNameTooLongException : InvalidDataException
{
    public ServerNameTooLongException(string message) : base(message)
    {
    }
}