using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Servers.Domain.Exceptions;

public class ServerDuplicatedTagException : InvalidDataException
{
    public ServerDuplicatedTagException(string message) : base(message)
    {
    }
}