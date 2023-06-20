namespace Leetcode;

public class Solution2090
{
    public static int[] GetAverages(int[] nums, int k)
    {
        long sum = 0;
        var avgs = new int[nums.Length];
        Array.Fill(avgs, -1);

        for (var i = 0; i < nums.Length; i++)
        {
            if (i < k || i + k >= nums.Length) continue;
            if (sum == 0)
                for (var j = i - k; j <= i + k; j++)
                    sum += nums[j];
            else
                sum = sum - nums[i - k - 1] + nums[i + k];

            avgs[i] = (int) (sum / (2 * k + 1));
        }


        return avgs;
    }
}