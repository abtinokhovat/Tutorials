using MoshDataStructure1.Hashmap;

namespace TestMoshDataStructure1.Hashmap;

public class TestExample1
{
    [Fact]
    public void TestCase1()
    {
        const string str = "a green apple";
        const char expected = 'g';

        var result = Example1.FirstNotRepeatedChar(str);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase2()
    {
        const string str = "aa bb cc";
        const char expected = char.MinValue;

        var result = Example1.FirstNotRepeatedChar(str);
        Assert.Equal(expected, result);
    }
}