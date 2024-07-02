using FizzBuzzService.Enterprise.MediaTRSpecifics;

namespace FizzBuzzService.Enterprise;

public interface IFizzBuzzServiceContainer 
{
    string Compute(FizzBuzzRequest requestOriginal);
}