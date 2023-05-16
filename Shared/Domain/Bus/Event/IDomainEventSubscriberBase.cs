namespace Discord.Shared.Domain.Bus.Event;

public interface IDomainEventSubscriberBase
{
    Task On(DomainEvent @event);
}