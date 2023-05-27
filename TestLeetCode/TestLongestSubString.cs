using Leetcode;

namespace TestLeetCode;

using Xunit;

public class TestSolution2
{
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput1()
    {
        // Arrange
        string input = "abcabcbb";
        int expected = 3; // "abc"

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput2()
    {
        // Arrange
        string input = "bbbbb";
        int expected = 1; // "b"

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput3()
    {
        // Arrange
        string input = "pwwkew";
        int expected = 3; // "wke"

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput4()
    {
        // Arrange
        string input = "ohomm";
        int expected = 3; // "wke"

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput5()
    {
        // Arrange
        string input = "abdabczbdabcxamdb";
        int expected = 6; // "wke"

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput6()
    {
        // Arrange
        string input = "ckilbkd";
        int expected = 5; // "ilbkd"

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput7()
    {
        // Arrange
        string input = " ";
        int expected = 1; // " "

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_LengthOfLongestSubstring_ShouldReturnCorrectLength_ForInput8()
    {
        // Arrange
        string input = "";
        int expected = 0; 

        // Act
        int result = Solution2.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
