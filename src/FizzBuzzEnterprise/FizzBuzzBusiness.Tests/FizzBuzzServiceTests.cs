using System.ComponentModel.Design;
using NFluent;

namespace FizzBuzzBusiness.Tests;

public class FizzBuzzServiceTests
{
    [Fact]
    public void GIVEN_1_THEN_1()
    {
        var original = 1;

        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("1");
    }
    
    [Fact]
    public void GIVEN_2_THEN_2()
    {
        var original = 2;

        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("2");
    }
    
    [Fact]
    public void GIVEN_3_THEN_Fizz()
    {
        var original = 3;

        var result = FizzBuzzService.Compute(original);

        Check.That(result).IsEqualTo("Fizz");
    }
}