using AzureServiceBus.Sample.Shared.Events;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace AzureServiceBus.Sample.PublisherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public PublishController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ItemModel item)
        {
            try
            {
                await _publishEndpoint.Publish(new ItemCreatedEvent
                {
                    Id = item.Id,
                    Name = item.Name,
                    TimeStamp = DateTimeOffset.Now
                });

                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

    public record ItemModel(Guid Id, string Name);
}
