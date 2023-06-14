using Leetcode;

namespace TestLeetCode;

public class TestSolution226
{
    [Fact]
    public void TestExample1()
    {
        // Input: [4,2,7,1,3,6,9]
        // Output: [4,7,2,9,6,3,1]

        // Create the tree
        var root = new Solution226.TreeNode(new List<int> {4, 2, 7, 1, 3, 6, 9});

        var solution = new Solution226();

        // Invert the tree
        var invertedRoot = solution.InvertTree(root);

        // Check the inverted tree structure
        Assert.Equal(4, invertedRoot.val);
        Assert.Equal(7, invertedRoot.left.val);
        Assert.Equal(2, invertedRoot.right.val);
        Assert.Equal(9, invertedRoot.left.left.val);
        Assert.Equal(6, invertedRoot.left.right.val);
        Assert.Equal(3, invertedRoot.right.left.val);
        Assert.Equal(1, invertedRoot.right.right.val);
    }

    [Fact]
    public void TestExample2()
    {
        // Input: [2,1,3]
        // Output: [2,3,1]

        // Create the tree
        var root = new Solution226.TreeNode(new List<int> {2, 1, 3});

        var solution = new Solution226();

        // Invert the tree
        var invertedRoot = solution.InvertTree(root);

        // Check the inverted tree structure
        Assert.Equal(2, invertedRoot.val);
        Assert.Equal(3, invertedRoot.left.val);
        Assert.Equal(1, invertedRoot.right.val);
    }

    [Fact]
    public void TestExample3()
    {
        // Input: []
        // Output: []

        Solution226.TreeNode root = null; // Empty tree

        var solution = new Solution226();

        // Invert the tree
        var invertedRoot = solution.InvertTree(root);

        // Check that the inverted tree is also empty
        Assert.Null(invertedRoot);
    }
}