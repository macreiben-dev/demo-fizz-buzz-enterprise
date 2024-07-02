using FizzBuzzBusiness.Domain.Contracts;

namespace FizzBuzzService.Enterprise;

public class FizzBuzzServiceContainer : IFizzBuzzServiceContainer
{
    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceContainer(IFizzBuzzService fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }

    public string Compute(int requestOriginal)
    {
        return _fizzBuzzService.ComputeFizzBuzz(requestOriginal);
    }
}