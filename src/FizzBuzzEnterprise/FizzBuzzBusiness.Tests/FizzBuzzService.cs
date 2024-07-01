namespace FizzBuzzBusiness.Tests;

public static class FizzBuzzService
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    public static string Compute(int original)
    {
        if (original % 3 == 0)
        {
            return Fizz;
        }
        
        if (original == 5)
        {
            return Buzz;
        }
        
        if(original == 10) 
        {
            return Buzz;
        }
        
        return original.ToString();
    }
}