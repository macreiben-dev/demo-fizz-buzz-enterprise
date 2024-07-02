using FizzBuzzService.Enterprise;
using FizzBuzzService.Enterprise.MediaTRSpecifics;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NFluent;

namespace FizzBuzz.Api.Tests;

public class MediatRSpecificsTests
{
    private readonly ServiceProvider _serviceProvider;

    public MediatRSpecificsTests()
    {
        ServiceCollection services = new();

        services.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceContainer).Assembly));

        services.AddScoped<IFizzBuzzServiceContainer, FakeFizzBuzzContainer>();

        _serviceProvider = services.BuildServiceProvider();
    }
    
    [Fact]
    public async Task Test1()
    {
        // ACT
        var target = _serviceProvider.GetService<IMediator>();

        var actual = await target.Send(new FizzBuzzRequest(1));

        // ASSERT
        Check.That(actual).IsEqualTo("that's a fake!");
    }
}