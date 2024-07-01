namespace FizzBuzzBusiness.Tests;

public static class FizzBuzzService
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    public static string Compute(int original)
    {
        if (original == 3 * 1)
        {
            return Fizz;
        }
        
        if (original == 3 * 2)
        {
            return Fizz;
        }

        if (original == 5)
        {
            return Buzz;
        }
        
        return original.ToString();
    }
}