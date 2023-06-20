using Leetcode;

namespace TestLeetCode;

public class TestSolution118
{
    [Fact]
    public void Generate_WithOneRow_ReturnsSingleRowList()
    {
        // Arrange
        const int numRows = 1;
        IList<IList<int>> expected = new List<IList<int>> {new List<int> {1}};

        // Act
        var result = Solution118.Generate(numRows);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Generate_WithThreeRows_ReturnsTriangleList()
    {
        // Arrange
        const int numRows = 3;
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1},
            new List<int> {1, 1},
            new List<int> {1, 2, 1}
        };

        // Act
        var result = Solution118.Generate(numRows);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Generate_WithFiveRows_ReturnsTriangleList()
    {
        // Arrange
        const int numRows = 5;
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1},
            new List<int> {1, 1},
            new List<int> {1, 2, 1},
            new List<int> {1, 3, 3, 1},
            new List<int> {1, 4, 6, 4, 1}
        };

        // Act
        var result = Solution118.Generate(numRows);

        // Assert
        Assert.Equal(expected, result);
    }
}