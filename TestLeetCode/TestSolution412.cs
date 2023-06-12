using Leetcode;

namespace TestLeetCode;

public class TestSolution412
{
    [Fact]
    public void FizzBuzz_ShouldReturnArrayOfStrings()
    {
        // Arrange
        const int number = 3;
        string[] expected = {"1", "2", "Fizz"};

        // Act
        var result = Solution412.FizzBuzz(number);

        // Assert
        Assert.Equal(expected, result);
    }
}