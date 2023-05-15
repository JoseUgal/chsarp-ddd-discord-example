namespace Discord.Contexts.Channels.Domain;

public interface IChannelRepository
{
    Task<Channel?> Search(ChannelId channelId);
}