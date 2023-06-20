using Leetcode;

namespace TestLeetCode;

public class TestSolution2221
{
    [Fact]
    public void TriangularSum_SingleElementArray_ReturnsElementValue()
    {
        // Arrange
        int[] nums = {5};

        // Act
        var result = Solution2221.TriangularSum(nums);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void TriangularSum_PositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] nums = {1, 2, 3, 4, 5};

        // Act
        var result = Solution2221.TriangularSum(nums);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void TriangularSum_PositiveNumbers_ReturnsCorrectSum1()
    {
        // Arrange
        int[] nums = {5, 6, 7, 1, 9};

        // Act
        var result = Solution2221.TriangularSum(nums);

        // Assert
        Assert.Equal(4, result);
    }
}