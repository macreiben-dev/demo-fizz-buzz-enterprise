namespace FizzBuzzBusiness.Tests;

public static class FizzBuzzService
{
    private const string Fizz = "Fizz";

    public static string Compute(int original)
    {
        if (original == 3)
        {
            return Fizz;
        }
        
        return original.ToString();
    }
}