using DemoNetMediatR.API.Contracts;
using MediatR;

namespace DemoNetMediatR.API.Handlers;

public class PingRequestHandler : IRequestHandler<PingRequest, string>
{
    public Task<string> Handle(PingRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult("Pong");
    }
}
