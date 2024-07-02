using FizzBuzzService.Enterprise;

namespace FizzBuzz.Api.Tests;

public class FakeFizzBuzzContainer : IFizzBuzzServiceContainer
{
    public string Compute(int n)
    {
        return "that's a fake!";
    }
}