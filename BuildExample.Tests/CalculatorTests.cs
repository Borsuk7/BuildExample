using FluentAssertions;

namespace BuildExample.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(0, -1, -1)]
    [InlineData(2.5, 2.5, 5)]
    public void Add_Should_BeRight(double a, double b, double expected)
    {
        var result = Calculator.Add(a, b);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 1, -1)]
    [InlineData(0, -1, 1)]
    [InlineData(2.5, 2.5, 0)]
    public void Subtract_Should_BeRight(double a, double b, double expected)
    {
        var result = Calculator.Subtract(a, b);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(1, -1, -1)]
    [InlineData(2.5, 2.5, 6.25)]
    public void Multiply_Should_BeRight(double a, double b, double expected)
    {
        var result = Calculator.Multiply(a, b);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(1, -1, -1)]
    [InlineData(2.5, 2.5, 1)]
    public void Divide_Should_BeRight(double a, double b, double expected)
    {
        var result = Calculator.Divide(a, b);

        result.Should().Be(expected);
    }

    [Fact]
    public void Divide_Should_ThrowException_WhenDividedByZero()
    {
        const double a = 3;
        const double b = 0;

        Action act = () => Calculator.Divide(a, b);

        act.Should()
            .Throw<ArgumentException>()
            .WithParameterName(nameof(b));
    }
}
