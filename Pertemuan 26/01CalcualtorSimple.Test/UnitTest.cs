using System;
using _01CalcualtorSimple;
using Moq;
using Xunit;

public class CalcualtorTest
{
    [Fact]
    public void TestAddMethod()
    {
        //arrange
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(c => c.add(2, 3)).Returns(5);

        //act
        int result = mockCalculator.Object.add(2, 3);

        //assert
        Assert.Equal(5, result);
        mockCalculator.Verify(c => c.add(2, 3), Times.Once);
    }
    [Fact]
    public void TestSubtraction()
    {
        //Arrange
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(c => c.Subtract(7, 4)).Returns(3);

        //Act
        int result = mockCalculator.Object.Subtract(7, 4);

        //Assert
        Assert.Equal(3, result);
        mockCalculator.Verify(c => c.Subtract(7, 4), Times.Once);
    }
}
