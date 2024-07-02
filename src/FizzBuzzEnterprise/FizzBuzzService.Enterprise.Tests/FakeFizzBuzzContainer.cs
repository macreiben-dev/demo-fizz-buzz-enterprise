namespace FizzBuzzService.Enterprise.Tests;

public class FakeFizzBuzzContainer : IFizzBuzzServiceContainer
{
    public string Compute(int n)
    {
        return "that's a fake!";
    }
}