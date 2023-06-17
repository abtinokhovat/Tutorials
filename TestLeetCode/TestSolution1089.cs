using Leetcode;

namespace TestLeetCode;

public class TestSolution1089
{
    [Fact]
    public void DuplicateZeros1()
    {
        // Arrange
        var nums = new[] {1, 0, 2, 3, 0, 4, 5, 0};
        var expected = new[] {1, 0, 0, 2, 3, 0, 0, 4};

        // Act
        Solution1089.DuplicateZeros(nums);

        // Assert
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void DuplicateZeros2()
    {
        // Arrange
        var nums = new[] {1, 2, 3};
        var expected = new[] {1, 2, 3};

        // Act
        Solution1089.DuplicateZeros(nums);

        // Assert
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void DuplicateZeros3()
    {
        // Arrange
        var nums = new[] {0, 0, 0, 0, 0, 0, 0};
        var expected = new[] {0, 0, 0, 0, 0, 0, 0};

        // Act
        Solution1089.DuplicateZeros(nums);

        // Assert
        Assert.Equal(expected, nums);
    }
}