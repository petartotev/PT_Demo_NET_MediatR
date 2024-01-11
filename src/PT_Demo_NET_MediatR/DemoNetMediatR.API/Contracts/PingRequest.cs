using MediatR;

namespace DemoNetMediatR.API.Contracts;

public class PingRequest : IRequest<string>
{
}
