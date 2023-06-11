using MoshDataStructure1.Hashmap;

namespace TestMoshDataStructure1.Hashmap;

public class TestExample2
{
    [Fact]
    public void TestCase1()
    {
        const string str = "green apple";
        const char expected = 'e';

        var result = Example2.FirstRepeatedChar(str);
        Assert.Equal(expected, result);
    }
}