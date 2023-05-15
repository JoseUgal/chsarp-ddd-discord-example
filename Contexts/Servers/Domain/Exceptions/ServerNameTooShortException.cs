using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Servers.Domain.Exceptions;

public class ServerNameTooShortException : InvalidDataException
{
    public ServerNameTooShortException(string message) : base(message)
    {
    }
}