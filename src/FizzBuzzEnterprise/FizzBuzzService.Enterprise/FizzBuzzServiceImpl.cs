namespace FizzBuzzService.Enterprise;

public class FizzBuzzServiceImpl
{
    public string Compute(int requestOriginal)
    {
        return FizzBuzzBusiness.FizzBuzzService.Compute(requestOriginal);
    }
}