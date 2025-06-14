using Xunit; 
using MathLibrary; 
 
namespace MathLibrary.Tests;

/// <summary> 
/// ةلادل تارابتخا ىلع يوتحت Multiply. 
/// </summary> 
public class CalculatorTests
{
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange 


        int a = 2, b = 3;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        // Arrange 
        int a = 0, b = 5;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
    {
        // Arrange 
        int a = -2, b = 3;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        // Arrange 
        int a = -2, b = -3;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(6, result);
    } 
      [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10, b = 2;

        // Act
        int result = Calculator.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_NegativeAndPositiveNumber_ReturnsNegative()
    {
        // Arrange
        int a = -9, b = 3;

        // Act
        int result = Calculator.Divide(a, b);

        // Assert
        Assert.Equal(-3, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 5, b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        int number = 8;

        // Act
        bool result = Calculator.IsEven(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        // Arrange
        int number = 7;

        // Act
        bool result = Calculator.IsEven(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        // Arrange
        int number = 0;

        // Act
        bool result = Calculator.IsEven(number);

        // Assert
        Assert.True(result);
    }

}

