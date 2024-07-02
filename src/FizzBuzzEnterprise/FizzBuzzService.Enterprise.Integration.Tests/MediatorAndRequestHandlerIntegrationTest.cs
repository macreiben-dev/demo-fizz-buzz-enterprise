using FizzBuzzService.Enterprise.MediaTRSpecifics;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NFluent;
using Xunit;

namespace FizzBuzzService.Enterprise.Integration.Tests;

public class MediatorAndRequestHandlerIntegrationTest
{
    private readonly ServiceProvider _serviceProvider;

    public MediatorAndRequestHandlerIntegrationTest()
    {
        ServiceCollection services = new();

        services.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceContainer).Assembly));

        services.AddScoped<IFizzBuzzServiceContainer, FakeFizzBuzzContainer>();

        _serviceProvider = services.BuildServiceProvider();
    }
    
    [Fact]
    public async Task THEN_should_invoke_fizzbuzz_service_container()
    {
        // ACT
        var target = _serviceProvider.GetService<IMediator>();

        var actual = await target.Send(new FizzBuzzRequest(1));

        // ASSERT
        Check.That(actual).IsEqualTo("that's a fake!");
    }
}