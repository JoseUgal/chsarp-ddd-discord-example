using Discord.Contexts.Channels.Domain.Exceptions;
using Discord.Shared.Domain.Entities;

namespace Discord.Contexts.Channels.Domain;

public class Channel : Entity
{
    public ChannelId Id { get; }
    public ChannelName Name { get; private set; }
    public ChannelTopic Topic { get; private set; }
    public ChannelNotSafeForWork NotSafeForWork { get; private set; }
    public ChannelMessageCount MessageCount { get; private set; }
    public ChannelSortType SortType { get; private set; }

    private Channel(ChannelId id, ChannelName name, ChannelTopic topic, ChannelNotSafeForWork notSafeForWork)
    {
        Id = id;
        Name = name;
        Topic = topic;
        NotSafeForWork = notSafeForWork;
        MessageCount = new ChannelMessageCount(0);
        SortType = ChannelSortType.CREATION_DATE;
    }

    public static Channel Create(ChannelId id, ChannelName name, ChannelTopic topic, ChannelNotSafeForWork notSafeForWork)
    {
        var channel = new Channel(id, name, topic, notSafeForWork);

        return channel;
    }

    public void ChangeName(ChannelName name)
    {
        Name = name;
    }
    
    public void ChangeTopic(ChannelTopic topic)
    {
        Topic = topic;
    }
    
    public void ChangeNotSafeForWork(ChannelNotSafeForWork nsfw)
    {
        NotSafeForWork = nsfw;
    }
    
    public void ChangeSortType(ChannelSortType sortType)
    {
        SortType = sortType;
    }

    public void IncrementMessageCount()
    {
        MessageCount = new ChannelMessageCount(MessageCount.Value + 1);
    }
    
    public void DecrementMessageCount()
    {
        if (MessageCount.Value == 0)
            throw new ChannelMessageCountInvalidOperationException($"{nameof(MessageCount)} is zero and can't be reduced.");

        MessageCount = new ChannelMessageCount(MessageCount.Value - 1);
    }
}