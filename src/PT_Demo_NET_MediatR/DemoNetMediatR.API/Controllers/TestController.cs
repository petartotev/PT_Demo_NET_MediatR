using DemoNetMediatR.API.Contracts;
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
        var request = new ThingRequest { Id = 1, Name = "test", Description =  "test" };

        _mediator.Send(request);

        return Ok();
    }

    [HttpGet("ping")]
    public async Task<IActionResult> GetPing()
    {
        var request = new PingRequest();

        var result = await _mediator.Send(request);

        return Ok(result);
    }
}