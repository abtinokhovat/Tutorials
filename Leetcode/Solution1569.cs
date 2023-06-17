using System.Numerics;

namespace Leetcode;

public class Solution1569
{
    public static int NumOfWays(int[] nums)
    {
        var c = new BigInteger(1);
        c = NumOfWaysSub(nums, c);

        c = (c - 1) % 1_000_000_007;
        return (int) c;
    }

    private static BigInteger NumOfWaysSub(int[] tree, BigInteger c)
    {
        if (tree.Length <= 1) return c;

        var (left, right) = DivideTree(tree);
        var updatedC = c * C(tree.Length - 1, left.Length);

        if (left.Length > 1) updatedC = NumOfWaysSub(left, updatedC);
        if (right.Length > 1) updatedC = NumOfWaysSub(right, updatedC);

        return updatedC;
    }

    private static (int[] left, int[] right) DivideTree(int[] tree)
    {
        var leftTree = new List<int>();
        var rightTree = new List<int>();

        var root = tree[0];

        if (tree.Length == 2)
        {
            if (root > tree[1]) return (new[] {tree[1]}, new int[] { });
            return (new int[] { }, new[] {tree[1]});
        }

        for (var i = 1; i < tree.Length; i++)
        {
            if (root > tree[i])
            {
                leftTree.Add(tree[i]);
                continue;
            }

            rightTree.Add(tree[i]);
        }

        return (leftTree.ToArray(), rightTree.ToArray());
    }

    private static BigInteger C(int n, int k)
    {
        switch (k)
        {
            case 1:
                return n;
            case 0:
                return 1;
        }

        if (n - k == 1) return n;

        var result = new BigInteger(1);

        for (var i = 1; i <= k; i++) result = result * (n - i + 1) / i;

        return result;
    }
}