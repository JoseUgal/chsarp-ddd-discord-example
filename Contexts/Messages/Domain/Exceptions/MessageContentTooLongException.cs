using InvalidDataException = Discord.Shared.Domain.Exceptions.InvalidDataException;

namespace Discord.Contexts.Messages.Domain.Exceptions;

public class MessageContentTooLongException : InvalidDataException
{
    public MessageContentTooLongException(string message) : base(message)
    {
    }
}