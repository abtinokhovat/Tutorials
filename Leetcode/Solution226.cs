namespace Leetcode;

public class Solution226
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;
        var tree = new TreeNode(root.val);

        while (root.right == null && root.left == null)
        {
            InvertTree(root.left);
            InvertTree(root.right);

            tree.left = root.right;
            tree.right = root.left;
        }

        return tree;
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            val = val;
            left = left;
            right = right;
        }

        public TreeNode(IReadOnlyList<int> values)
        {
            if (values == null || values.Count == 0) throw new ArgumentException("Array cannot be null or empty.");

            val = values[0];
            left = BuildTree(values, 1);
        }

        private TreeNode? BuildTree(IReadOnlyList<int> values, int index)
        {
            if (index >= values.Count) return null;

            var left = BuildTree(values, 2 * index + 1);
            var right = BuildTree(values, 2 * index + 2);

            return new TreeNode(values[index], left, right);
        }
    }
}