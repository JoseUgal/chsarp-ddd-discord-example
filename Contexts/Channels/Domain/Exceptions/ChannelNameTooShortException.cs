using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Channels.Domain.Exceptions;

public class ChannelNameTooShortException : InvalidDataException
{
    public ChannelNameTooShortException(string message) : base(message)
    {
    }
}