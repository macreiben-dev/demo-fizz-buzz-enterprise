using System.ComponentModel.Design;
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
    
    [Fact]
    public void GIVEN_5_THEN_Buzz()
    {
        var original = 5;

        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("Buzz");
    }

    [Fact]
    public void GIVEN_10_THEN_Buzz()
    {
        var original = 10;

        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("Buzz");
    }
}