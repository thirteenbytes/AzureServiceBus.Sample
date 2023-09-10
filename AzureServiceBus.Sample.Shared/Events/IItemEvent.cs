namespace AzureServiceBus.Sample.Shared.Events;

public interface IItemEvent
{
    Guid Id { get; init; }
    DateTimeOffset TimeStamp { get; init; }
}
