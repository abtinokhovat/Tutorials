namespace Leetcode;

public class Solution88
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var p = m + n - 1;
        var left = m - 1;
        var right = n - 1;

        while (left >= 0 && right >= 0)
        {
            if (nums1[left] >= nums2[right])
            {
                nums1[p] = nums1[left];
                left--;
            }
            else
            {
                nums1[p] = nums2[right];
                right--;
            }

            p--;
        }

        while (right >= 0)
        {
            nums1[p] = nums2[right];
            right--;
            p--;
        }
    }
}