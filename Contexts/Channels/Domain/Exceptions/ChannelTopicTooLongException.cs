using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Channels.Domain.Exceptions;

public class ChannelTopicTooLongException : InvalidDataException
{
    public ChannelTopicTooLongException(string message) : base(message)
    {
    }
}