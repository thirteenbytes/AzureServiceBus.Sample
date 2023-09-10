namespace AzureServiceBus.Sample.Shared.Events;

public class ItemCreatedEvent : IItemEvent
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTimeOffset TimeStamp { get; init; }
}
