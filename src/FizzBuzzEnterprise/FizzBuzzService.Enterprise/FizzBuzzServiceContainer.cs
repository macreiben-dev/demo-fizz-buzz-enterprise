namespace FizzBuzzService.Enterprise;

public class FizzBuzzServiceContainer : IFizzBuzzServiceContainer
{
    public string Compute(int requestOriginal)
    {
        return new FizzBuzzBusiness.FizzBuzzService().ComputeFizzBuzz(requestOriginal);
    }
}