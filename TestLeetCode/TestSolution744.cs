using Leetcode;

namespace TestLeetCode;

public class TestSolution744
{
    [Fact]
    public void TestCase1()
    {
        char[] letters = {'c', 'f', 'j'};
        const char target = 'a';

        var result = Solution744.NextGreatestLetter(letters, target);

        Assert.Equal('c', result);
    }

    [Fact]
    public void TestCase2()
    {
        char[] letters = {'c', 'f', 'j'};
        const char target = 'c';

        var result = Solution744.NextGreatestLetter(letters, target);

        Assert.Equal('f', result);
    }

    [Fact]
    public void TestCase3()
    {
        char[] letters = {'x', 'x', 'y', 'y'};
        const char target = 'z';

        var result = Solution744.NextGreatestLetter(letters, target);

        Assert.Equal('x', result);
    }
    
    [Fact]
    public void TestCase4()
    {
        char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n'};
        const char target = 'a';

        var result = Solution744.NextGreatestLetter(letters, target);

        Assert.Equal('b', result);
    }
}