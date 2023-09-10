using AzureServiceBus.Sample.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureServiceBus.Sample.ConsumerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConsumeController : ControllerBase
{
    private readonly EventContainer _container;

    public ConsumeController(EventContainer container)
    {
        _container = container;
    }

    [HttpGet]
    public Task<IActionResult> GetEvents()
    {
        IActionResult result = Ok(_container.ItemEvents);
        return Task.FromResult(result);        
    }
}
