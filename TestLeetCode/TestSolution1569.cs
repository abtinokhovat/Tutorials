using Leetcode;

namespace TestLeetCode;

public class TestSolution1569
{
    [Fact]
    public void NumOfWays1()
    {
        // Arrange
        var nums = new[] {2, 1, 3};

        // Act
        var result = Solution1569.NumOfWays(nums);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void NumOfWays2()
    {
        // Arrange
        var nums = new[] {3, 4, 5, 1, 2};

        // Act
        var result = Solution1569.NumOfWays(nums);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void NumOfWays3()
    {
        // Arrange
        var nums = new[] {1, 2, 3};

        // Act
        var result = Solution1569.NumOfWays(nums);

        // Assert
        Assert.Equal(0, result);
    }
}