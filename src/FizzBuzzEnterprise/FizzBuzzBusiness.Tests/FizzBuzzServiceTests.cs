using NFluent;

namespace FizzBuzzBusiness.Tests;

public class FizzBuzzServiceTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(7)]
    [InlineData(8)]
    public void GIVEN_number_THEN_return_number_as_string(int original)
    {
        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo(original.ToString());
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GIVEN_divisible_by_3_THEN_return_Fizz(int original)
    {
        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("Fizz");
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void GIVEN_divisible_by_5_THEN_return_Buzz(int original)
    {
        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("Buzz");
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void GIVEN_divisible_by_3_and_5_THEN_return_FizzBuzz(
        int original)
    {
        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("FizzBuzz");
    }
}