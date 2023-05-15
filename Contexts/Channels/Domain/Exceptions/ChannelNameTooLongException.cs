using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Channels.Domain.Exceptions;

public class ChannelNameTooLongException : InvalidDataException
{
    public ChannelNameTooLongException(string message) : base(message)
    {
    }
}