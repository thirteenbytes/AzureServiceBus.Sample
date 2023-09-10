using AzureServiceBus.Sample.Shared.Events;
using Microsoft.Extensions.Logging;

namespace AzureServiceBus.Sample.Shared;

public class EventContainer
{
    private readonly ILogger<EventContainer> _logger;

    public EventContainer(ILogger<EventContainer> logger)
    {
        _logger = logger;
    }

    public List<IItemEvent> ItemEvents { get; init; } = new();

    public void AddEvent(IItemEvent itemEvent)
    {
        ItemEvents.Add(itemEvent);
        _logger.LogInformation("Item Created with Id: {Id}", itemEvent.Id);
    }
}
