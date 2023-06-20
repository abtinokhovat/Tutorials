namespace Leetcode;

public class Solution2221
{
    public static int TriangularSum(int[] nums)
    {
        for (var i = nums.Length - 1; i >= 0; i--)
        for (var j = 0; i > j; j++)
            nums[j] += nums[j + 1] % 10;

        return nums[0] % 10;
    }
}