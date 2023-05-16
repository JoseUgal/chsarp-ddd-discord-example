namespace Discord.Shared.Domain.Bus.Event;

public interface IEventBus
{
    Task Publish(List<DomainEvent> events);
}