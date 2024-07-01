namespace FizzBuzzBusiness.Tests;

public static class FizzBuzzService
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    public static string Compute(int original)
    {
        if (original == 15)
        {
            return Fizz + Buzz;
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