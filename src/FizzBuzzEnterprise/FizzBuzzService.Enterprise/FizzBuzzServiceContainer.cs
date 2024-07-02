using FizzBuzzBusiness.Domain.Contracts;
using FizzBuzzService.Enterprise.MediaTRSpecifics;

namespace FizzBuzzService.Enterprise;

public class FizzBuzzServiceContainer : IFizzBuzzServiceContainer
{
    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceContainer(IFizzBuzzService fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }

    public string Compute(FizzBuzzRequest requestOriginal)
    {
        return _fizzBuzzService.ComputeFizzBuzz(requestOriginal.Original);
    }
}