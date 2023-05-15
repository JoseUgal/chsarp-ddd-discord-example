namespace Discord.Shared.Domain.Exceptions;

public abstract class InvalidDataException : Exception
{
    protected InvalidDataException(string message): base(message)
    {}
}