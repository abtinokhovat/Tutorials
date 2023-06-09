using Leetcode;

namespace TestLeetCode;

public class ProgramTests
{
    [Fact]
    public void AddTwoNumbers_ShouldReturnCorrectSum_WhenGivenExample1()
    {
        // Arrange
        var l1 = new ListNode(new List<int> {2, 4, 3});
        var l2 = new ListNode(new List<int> {5, 6, 4});

        // Act
        var sum = Solution1.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal("7 -> 0 -> 8", sum.ToString());
    }

    [Fact]
    public void AddTwoNumbers_ShouldReturnCorrectSum_WhenGivenExample2()
    {
        // Arrange
        var l1 = new ListNode(new List<int> {0});
        var l2 = new ListNode(new List<int> {0});

        // Act
        var sum = Solution1.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal("0", sum.ToString());
    }

    [Fact]
    public void AddTwoNumbers_ShouldReturnCorrectSum_WhenGivenExample3()
    {
        // Arrange
        var l2 = new ListNode(new List<int> {9, 9, 9, 9, 9, 9, 9});
        var l1 = new ListNode(new List<int> {9, 9, 9, 9});

        // Act
        var sum = Solution1.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal("8 -> 9 -> 9 -> 9 -> 0 -> 0 -> 0 -> 1", sum.ToString());
    }

    [Fact]
    public void AddTwoNumbers_ShouldReturnCorrectSum_WhenGivenExample4()
    {
        // Arrange
        var l1 = new ListNode(new List<int> {9, 9, 9, 9, 9, 9, 9});
        var l2 = new ListNode(new List<int> {9, 9, 9, 9});

        // Act
        var sum = Solution1.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal("8 -> 9 -> 9 -> 9 -> 0 -> 0 -> 0 -> 1", sum.ToString());
    }

    [Fact]
    public void AddTwoNumbers_ShouldReturnCorrectSum_WhenGivenExample5()
    {
        // Arrange
        var l1 = new ListNode(new List<int> {1, 6, 0, 3, 3, 6, 7, 2, 0, 1});
        var l2 = new ListNode(new List<int> {6, 3, 0, 8, 9, 6, 6, 9, 6, 1});

        // Act
        var sum = Solution1.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal("7 -> 9 -> 0 -> 1 -> 3 -> 3 -> 4 -> 2 -> 7 -> 2", sum.ToString());
    }
}