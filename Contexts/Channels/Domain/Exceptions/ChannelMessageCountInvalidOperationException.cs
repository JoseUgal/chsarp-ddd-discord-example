using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Channels.Domain.Exceptions;

public class ChannelMessageCountInvalidOperationException : InvalidDataException
{
    public ChannelMessageCountInvalidOperationException(string message) : base(message)
    {
    }
}