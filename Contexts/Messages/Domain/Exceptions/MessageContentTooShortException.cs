using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Messages.Domain.Exceptions;

public class MessageContentTooShortException : InvalidDataException
{
    public MessageContentTooShortException(string message) : base(message)
    {
    }
}