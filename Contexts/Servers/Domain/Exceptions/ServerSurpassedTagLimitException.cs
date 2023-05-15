using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Servers.Domain.Exceptions;

public class ServerSurpassedTagLimitException : InvalidDataException
{
    public ServerSurpassedTagLimitException(string message) : base(message)
    {
    }
}