using Leetcode;

namespace TestLeetCode;

public class TestMergeAlternately
{
    [Fact]
    public void Merge_Example0()
    {
        const string word1 = "";
        const string word2 = "";

        var merged = Solution3.MergeAlternately(word1, word2);

        Assert.Equal("", merged);
    }
    
    [Fact]
    public void Merge_Example1()
    {
        const string word1 = "abc";
        const string word2 = "pqr";

        var merged = Solution3.MergeAlternately(word1, word2);

        Assert.Equal("apbqcr", merged);
    }
    
    [Fact]
    public void Merge_Example2()
    {
        const string word1 = "ab";
        const string word2 = "pqrs";

        var merged = Solution3.MergeAlternately(word1, word2);

        Assert.Equal("apbqrs", merged);
    }
    
    [Fact]
    public void Merge_Example3()
    {
        const string word1 = "abcd";
        const string word2 = "pq";

        var merged = Solution3.MergeAlternately(word1, word2);

        Assert.Equal("apbqcd", merged);
    }
}