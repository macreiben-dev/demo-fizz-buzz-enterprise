using FizzBuzzService.Enterprise.MediaTRSpecifics;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NFluent;

namespace FizzBuzzService.Enterprise.Tests;

public class MediaTrSpecificsTests
{
    private readonly IMediator _mediator;

    public MediaTrSpecificsTests()
    {
        ServiceCollection collection = new ServiceCollection();

        collection.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceContainer).Assembly));

        collection.AddScoped<IFizzBuzzServiceContainer, FizzBuzzServiceContainer>();
        
        var service = collection.BuildServiceProvider();
        
        _mediator = service.GetRequiredService<IMediator>();
    }

    [Fact]
    public void GIVEN_1_AND_event_sent_THEN_1()
    {
        var actual = _mediator.Send(new FizzBuzzRequest(1)).Result;
        
        Check.That(actual).IsEqualTo("1");
    }
}