using Discord.Shared.Domain.Bus.Event;

namespace Discord.Shared.Domain.Aggregate;

public abstract class AggregateRoot
{
    private List<DomainEvent> _domainEvents = new List<DomainEvent>();

    public List<DomainEvent> PullDomainEvents()
    {
        var events = _domainEvents;

        _domainEvents = new List<DomainEvent>();

        return events;
    }

    protected void Record(DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}