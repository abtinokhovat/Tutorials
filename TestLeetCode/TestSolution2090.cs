using Leetcode;

namespace TestLeetCode;

public class TestSolution2090
{
    [Fact]
    public void Case1()
    {
        // Arrange
        var nums = new[] {7, 4, 3, 9, 1, 8, 5, 2, 6};
        const int k = 3;

        var expected = new[] {-1, -1, -1, 5, 4, 4, -1, -1, -1};

        // Act
        var result = Solution2090.GetAverages(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Case2()
    {
        // Arrange
        var nums = new[] {100000};
        const int k = 0;

        var expected = new[] {100000};

        // Act
        var result = Solution2090.GetAverages(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Case3()
    {
        // Arrange
        var nums = new[] {8};
        const int k = 100000;

        var expected = new[] {-1};

        // Act
        var result = Solution2090.GetAverages(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Case4()
    {
        // Arrange
        var nums = TestSolution2090Data.Input;
        const int k = 40000;

        var expected = TestSolution2090Data.Output;

        // Act
        var result = Solution2090.GetAverages(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    private class Data
    {
        public int[] Input { get; }
        public int[] Output { get; }
    }
}