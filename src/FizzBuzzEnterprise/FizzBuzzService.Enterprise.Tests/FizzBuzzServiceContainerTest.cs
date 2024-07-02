using FizzBuzzBusiness.Domain.Contracts;
using FizzBuzzService.Enterprise.MediaTRSpecifics;
using NFluent;
using NSubstitute;

namespace FizzBuzzService.Enterprise.Tests;

public class FizzBuzzServiceContainerTest
{
    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceContainerTest()
    {
        _fizzBuzzService = Substitute.For<IFizzBuzzService>();
    }

    private FizzBuzzServiceContainer GetTarget()
    {
        return new FizzBuzzServiceContainer(_fizzBuzzService);
    }
    
    [Fact]
    public void THEN_container_invoke_service()
    {
        _fizzBuzzService.ComputeFizzBuzz(1)
            .Returns("that alright");

        var actual = GetTarget().Compute(new FizzBuzzRequest(1));

        Check.That(actual).IsEqualTo("that alright");
    }
}