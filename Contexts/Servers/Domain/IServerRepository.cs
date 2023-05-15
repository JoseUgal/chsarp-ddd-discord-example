namespace Discord.Contexts.Servers.Domain;

public interface IServerRepository
{
    Task<Server?> Search(ServerId serverId);
}