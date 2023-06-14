using MoshDataStructure.Tree;
using Xunit.Abstractions;

namespace TestMoshDataStructure.Tree;

public class TestBinaryTree
{
    private readonly ITestOutputHelper _testOutputHelper;

    public TestBinaryTree(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Builder_InOrder()
    {
        var tree = new BinaryTree(new[] {20, 10, 30, 6, 14, 24, 3, 8, 26});
        var i = tree.TraverseInOrder();
        var p = tree.TraversePreOrder();
        var ps = tree.TraversePostOrder();

        _testOutputHelper.WriteLine(i);
        _testOutputHelper.WriteLine(p);
        _testOutputHelper.WriteLine(ps);
    }
}