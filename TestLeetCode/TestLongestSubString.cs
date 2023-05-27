using Leetcode;

namespace TestLeetCode;

public class TestSolution2
{
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput1()
    {
        // Arrange
        var input = "abcabcbb";
        var expected = 3; // "abc"

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput2()
    {
        // Arrange
        var input = "bbbbb";
        var expected = 1; // "b"

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput3()
    {
        // Arrange
        var input = "pwwkew";
        var expected = 3; // "wke"

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput4()
    {
        // Arrange
        var input = "ohomm";
        var expected = 3; // "wke"

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput5()
    {
        // Arrange
        var input = "abdabczbdabcxamdb";
        var expected = 6; // "wke"

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput6()
    {
        // Arrange
        var input = "ckilbkd";
        var expected = 5; // "ilbkd"

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput7()
    {
        // Arrange
        var input = " ";
        var expected = 1; // " "

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput8()
    {
        // Arrange
        var input = "";
        var expected = 0;

        // Act
        var result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
}