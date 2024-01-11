using MediatR;
using System.Text;

namespace DemoNetMediatR.API.Contracts;

public class ThingRequest : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine($"Id: {Id}")
            .AppendLine($"Name: {Name}")
            .AppendLine($"Description: {Description}")
            .ToString();
    }
}
