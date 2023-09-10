using AzureServiceBus.Sample.Shared;
using AzureServiceBus.Sample.Shared.Events;
using MassTransit;

namespace AzureServiceBus.Sample.ConsumerApi.Consumers;

public class ItemCreatedConsumer : IConsumer<ItemCreatedEvent>
{
    private readonly EventContainer _container;
    
    public ItemCreatedConsumer(EventContainer container)
    {
        _container = container;
    }

    public Task Consume(ConsumeContext<ItemCreatedEvent> context)
    {
        _container.AddEvent(context.Message);                
        return Task.CompletedTask;
    }
}
