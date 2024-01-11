using DemoNetMediatR.ConsoleApp.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Net.NetworkInformation;

namespace DemoNetMediatR.ConsoleApp;

internal class Program
{
    static async Task Main(string[] args)
    {
        // Setup MediatR using a ServiceCollection
        var services = new ServiceCollection();
        services.AddMediatR(typeof(Program)).BuildServiceProvider();

        // Get an instance of Mediator from the ServiceProvider
        var mediator = provider.GetRequiredService<IMediator>();

        // Send a Ping request
        var response = await mediator.Send(new Ping());

        // Output the response
        Console.WriteLine(response);  // Outputs: Pong
    }
}