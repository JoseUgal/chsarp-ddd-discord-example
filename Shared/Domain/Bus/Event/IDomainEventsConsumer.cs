namespace Discord.Shared.Domain.Bus.Event;

public interface IDomainEventsConsumer
{
    Task Consume();
}