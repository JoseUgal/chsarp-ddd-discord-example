using Discord.Shared.Domain.Entities;

namespace Discord.Contexts.Messages.Domain;

public class Message : Entity
{
    public MessageId Id { get; }
    public MessageContent Content { get; }
    public MessageTextToSpeech TextToSpeech { get; }

    private Message(MessageId id, MessageContent content, MessageTextToSpeech textToSpeech)
    {
        Id = id;
        Content = content;
        TextToSpeech = textToSpeech;
    }

    public static Message Create(MessageId id, MessageContent content, MessageTextToSpeech textToSpeech)
    {
        var message = new Message(id, content, textToSpeech);

        return message;
    }
}