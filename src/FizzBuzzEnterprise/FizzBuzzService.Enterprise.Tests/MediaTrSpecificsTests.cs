using FizzBuzzService.Enterprise.MediaTRSpecifics;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NFluent;

namespace FizzBuzzService.Enterprise.Tests;

public class MediaTrSpecificsTests
{
    private readonly ServiceProvider _service;
    private readonly IMediator _mediator;

    public MediaTrSpecificsTests()
    {
        ServiceCollection collection = new ServiceCollection();

        collection.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceImpl).Assembly));

        collection.AddScoped<FizzBuzzServiceImpl>();
        
        _service = collection.BuildServiceProvider();
        
        _mediator = _service.GetRequiredService<IMediator>();
    }

    [Fact]
    public void GIVEN_1_AND_event_sent_THEN_1()
    {
        var actual = _mediator.Send(new FizzBuzzRequest(1)).Result;
        
        Check.That(actual).IsEqualTo("1");
    }
}