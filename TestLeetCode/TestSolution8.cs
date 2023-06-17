using Leetcode;

namespace TestLeetCode;

public class TestSolution8
{
    [Fact]
    public void Atoi_WithStringWithoutCharShouldReturnsTheNumber()
    {
        // Arrange
        const string str = "4321";
        const int expected = 4321;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringWithCharAfterShouldReturnsTheNumber()
    {
        // Arrange
        const string str = "4321 aklsdjf";
        const int expected = 4321;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringWithCharBeforeShouldReturnsZero()
    {
        // Arrange
        const string str = "aklsdjf 4321";
        const int expected = 0;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringWithNegativeBeforeShouldReturnsZero()
    {
        // Arrange
        const string str = "aklsdjf -4321";
        const int expected = 0;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringWithTwoNegativesBeforeShouldReturnZer0()
    {
        // Arrange
        const string str = "aklsdjf --4321";
        const int expected = 0;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringWithPositiveBeforeShouldReturnsZero()
    {
        // Arrange
        const string str = "+123 aklsdjf";
        const int expected = 123;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringContainingBiggerThanIntMaxShouldReturnIntMax()
    {
        // Arrange
        const string str = "2894359823958279438570924835792843759823475902375";
        const int expected = int.MaxValue;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringContainingLowerThanIntMinShouldReturnIntMin()
    {
        // Arrange
        const string str = "-2894359823958279438570924835792843759823475902375";
        const int expected = int.MinValue;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }

    [Fact]
    public void Atoi_WithStringNotContainingNumberShouldReturnZero()
    {
        // Arrange
        const string str = "saklffjlasdf lasdjkhf kjasl";
        const int expected = 0;

        // Act
        var number = Solution8.MyAtoi(str);

        // Assert
        Assert.Equal(expected, number);
    }
}