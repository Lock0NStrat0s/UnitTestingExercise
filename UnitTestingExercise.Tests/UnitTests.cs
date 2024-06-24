using System;
using Xunit;

namespace UnitTestingExercise.Tests;

public class UnitTests
{
    [Theory]
    [InlineData(2, 3, 5, 10)] //Add test data <-------
    [InlineData(1, -2, 1, 0)]
    [InlineData(1, 2, 3, 6)]
    public void AddTest(int num1, int num2, int num3, int expected)
    {
        //Start Step 3 here:

        //Arrange
        // create a Calculator object
        Calculator calc = new Calculator();

        //Act
        // call the Add method that is located in the Calculator class
        // and store its result in a variable named actual
        int actual = calc.Add(num1, num2, num3);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 5, 5)]//Add test data <-------
    [InlineData(-10, -5, -5)]
    [InlineData(-1, -5, 4)]
    public void SubtractTest(int minuend, int subtrhend, int expected)
    {
        //Start Step 5 here:

        //Arrange
        Calculator calc = new Calculator();

        //Act
        int actual = calc.Subtract(minuend, subtrhend);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 0, 0)]//Add test data <-------
    [InlineData(2, 3, 6)]
    [InlineData(-9, -9, 81)]
    public void MultiplyTest(int num1, int num2, int expected)
    {
        //Start Step 7 here:

        //Arrange
        Calculator calc = new Calculator();

        //Act
        int actual = calc.Multiply(num1, num2);

        //Assert
        Assert.Equal(expected, actual);

    }

    [Theory]
    [InlineData(0, 1, 0)]//Add test data <-------
    [InlineData(6, 3, 2)]
    [InlineData(81, -9, -9)]
    public void DivideTest(int num1, int num2, int expected)
    {
        //Arrange
        Calculator calc = new Calculator();

        //Act
        int actual = calc.Divide(num1, num2);

        //Assert
        Assert.Equal(expected, actual);

    }

}
