namespace Discord.Shared.Domain.Bus.Event;

public interface IDomainEventSubscriber<TEvent> : IDomainEventSubscriberBase
    where TEvent : DomainEvent
{
    async Task IDomainEventSubscriberBase.On(DomainEvent @event)
    {
        if (@event is TEvent msg)
            await On(msg);
    }
}