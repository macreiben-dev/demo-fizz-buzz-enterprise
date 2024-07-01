namespace FizzBuzzService.Enterprise;

public class FizzBuzzServiceImpl : IFizzBuzzServiceImpl
{
    public string Compute(int requestOriginal)
    {
        return FizzBuzzBusiness.FizzBuzzService.Compute(requestOriginal);
    }
}