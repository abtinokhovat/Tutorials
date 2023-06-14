using Leetcode;

namespace TestLeetCode;

public class TestSolution5
{
    [Fact]
    public void TestCase0()
    {
        const string str = "a";
        const string expected = "a";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase1()
    {
        const string str = "";
        const string expected = "";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase2()
    {
        const string str = "bab";
        const string expected = "bab";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase3()
    {
        const string str = "cbbd";
        const string expected = "bb";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase4()
    {
        const string str = "axxaddad";
        const string expected = "axxa";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase5()
    {
        const string str = "mbccdab";
        const string expected = "cc";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase6()
    {
        const string str = "mbccdab";
        const string expected = "cc";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase7()
    {
        const string str = "nlmppdjjdmd";
        const string expected = "djjd";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase8()
    {
        const string str = "abccba";
        const string expected = "abccba";

        var result = Solution5.LongestPalindrome(str);
        Assert.Equal(expected, result);
    }
}