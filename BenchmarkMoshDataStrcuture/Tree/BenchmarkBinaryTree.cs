using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using MoshDataStructure.Tree;

namespace BenchmarkMoshDataStructure.Tree;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BenchmarkBinaryTree
{
    private readonly BinaryTree _tree = new();

    [GlobalSetup]
    public void GlobalSetup()
    {
        Seed(_tree, 1000);
    }

    private static void Seed(BinaryTree tree, int count)
    {
        for (var i = 0; i < count; i++)
        {
            var rand = new Random(count);
            tree.Insert(rand.Next() % 10 + 1);
        }
    }

    [Benchmark]
    public void ValidateTreeWithNotRecursiveAlgorithm()
    {
        _tree.ValidateBst();
    }

    [Benchmark]
    public void ValidateTreeWithRecursive()
    {
        _tree.ValidateBstRecursive();
    }
}