using FizzBuzzService.Enterprise.MediaTRSpecifics;

namespace FizzBuzzService.Enterprise.Integration.Tests;

public class FakeFizzBuzzContainer : IFizzBuzzServiceContainer
{
    public string Compute(FizzBuzzRequest n)
    {
        return "that's a fake!";
    }
}