namespace FizzBuzzService.Enterprise;

public class FizzBuzzServiceContainer : IFizzBuzzServiceContainer
{
    public string Compute(int requestOriginal)
    {
        return FizzBuzzBusiness.FizzBuzzService.Compute(requestOriginal);
    }
}