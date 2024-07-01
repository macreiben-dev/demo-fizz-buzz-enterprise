using System.ComponentModel.Design;
using NFluent;

namespace FizzBuzzBusiness.Tests;

public class FizzBuzzServiceTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]

    public void GIVEN_number_THEN_return_number_as_string(int original)
    {
        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo(original.ToString());
    }
    
    [Fact]
    public void GIVEN_3_THEN_Fizz()
    {
        var original = 3;

        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("Fizz");
    }
    
    [Fact]
    public void GIVEN_6_THEN_Fizz()
    {
        var original = 6;

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

}