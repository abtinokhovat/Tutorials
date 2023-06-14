using MoshDataStructure.Hashmap;

namespace TestMoshDataStructure.Hashmap;

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