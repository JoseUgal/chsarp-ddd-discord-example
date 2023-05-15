using Discord.Contexts.Servers.Domain.Exceptions;
using Discord.Shared.Domain.Entities;

namespace Discord.Contexts.Servers.Domain;

public class Server : Entity
{
    private const int MAX_TAG_QUANTITY = 5;
    
    public ServerId Id { get; }
    public ServerName Name { get; private set; }
    public ServerDescription Description { get; private set; }
    public ServerImageUrl? ImageUrl { get; private set; }
    public ICollection<string> Tags { get; private set; }

    private Server(ServerId id, ServerName name, ServerDescription description,ServerImageUrl? imageUrl, ICollection<string>? tags)
    {
        Id = id;
        Name = name;
        Description = description;
        Tags = tags ?? new List<string>();
        ImageUrl = imageUrl;
    }

    public static Server Create(ServerId id, ServerName name, ServerDescription description, ServerImageUrl? imageUrl, ICollection<string>? tags)
    {
        var server = new Server(id, name, description, imageUrl, tags);

        return server;
    }

    public void ChangeName(ServerName name)
    {
        Name = name;
    }
    
    public void ChangeDescription(ServerDescription description)
    {
        Description = description;
    }
    
    public void ChangeImageUrl(ServerImageUrl? imageUrl)
    {
        ImageUrl = imageUrl;
    }

    public void AddTag(string tag)
    {
        if (Tags.Count == MAX_TAG_QUANTITY)
            throw new ServerSurpassedTagLimitException($"{nameof(Tags)} can't be more than {MAX_TAG_QUANTITY}");

        if (Tags.Contains(tag))
            throw new ServerDuplicatedTagException($"{nameof(Tags)} duplicated with value {tag}");
        
        Tags.Add(tag);
    }
    
    public void AddTags(IEnumerable<string> tags)
    {
        foreach (var tag in tags)
        {
            AddTag(tag);
        }
    }
}