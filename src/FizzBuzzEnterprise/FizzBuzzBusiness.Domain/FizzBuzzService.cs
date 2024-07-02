using FizzBuzzBusiness.Domain.Contracts;

namespace FizzBuzzBusiness;

public class FizzBuzzService : IFizzBuzzService
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";
    private const string FizzBuzz = Fizz + Buzz;
    
    public string ComputeFizzBuzz(int original)
    {
        return FizzBuzzService.Compute(original);
    }
    
    private static string Compute(int original)
    {
        if(DivisibleBy3(original) && DivisibleBy5(original))
        {
            return FizzBuzz;
        }
        
        if (DivisibleBy3(original))
        {
            return Fizz;
        }
        
        if(DivisibleBy5(original)) 
        {
            return Buzz;
        }
        
        return original.ToString();
    }

    private static bool DivisibleBy5(int original)
    {
        return original % 5 == 0;
    }

    private static bool DivisibleBy3(int original)
    {
        return original % 3 == 0;
    }
}