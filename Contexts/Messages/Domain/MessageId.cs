using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Messages.Domain;

public class MessageId : Uuid
{
    public MessageId(string value) : base(value)
    {
    }
}