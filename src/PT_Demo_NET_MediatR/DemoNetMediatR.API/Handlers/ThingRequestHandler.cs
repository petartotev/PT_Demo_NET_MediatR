using DemoNetMediatR.API.Contracts;
using MediatR;

namespace DemoNetMediatR.API.Handlers;

public class ThingRequestHandler : IRequestHandler<ThingRequest>
{
    public Task Handle(ThingRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine(request.ToString());

        return Task.CompletedTask;
    }
}
