using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Servers.Domain.Exceptions;

public class ServerDescriptionTooLongException : InvalidDataException
{
    public ServerDescriptionTooLongException(string message) : base(message)
    {
    }
}