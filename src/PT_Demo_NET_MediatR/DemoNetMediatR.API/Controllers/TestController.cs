using DemoNetMediatR.API.Contracts.Notifications;
using DemoNetMediatR.API.Contracts.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoNetMediatR.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    private readonly ILogger<TestController> _logger;
    private readonly IMediator _mediator;

    public TestController(ILogger<TestController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet("thing")]
    public IActionResult GetThing()
    {
        // ThingRequest : IRequest (a.k.a. Command, 1 request : 1 request handler)
        var request = new ThingRequest { Id = 1, Name = "test", Description =  "test" };

        // Handler may or may not return a value.
        _mediator.Send(request);

        return Ok();
    }

    [HttpGet("ping")]
    public async Task<IActionResult> GetPing()
    {
        // PingRequest : IRequest<string> (a.k.a. Command, 1 request : 1 request handler)
        var request = new PingRequest();

        // Handler may or may not return a value.
        var result = await _mediator.Send(request);

        return Ok(result);
    }

    [HttpGet("notify")]
    public async Task<IActionResult> GetNotified()
    {
        // MyNotification : INotification (a.k.a. Event, 1 notification : 1 notification handler)
        var request = new MyNotification { NotificationValue = DateTime.Now.ToString()};

        // Handler may not return a value.
        await _mediator.Publish(request);

        return Ok();
    }
}