using Discord.Shared.Domain.ValueObjects;

namespace Discord.Contexts.Messages.Domain;

public class MessageTextToSpeech : ValueObject<bool>
{
    public MessageTextToSpeech(bool value) : base(value)
    {
    }
}