namespace Leetcode;

public static class Solution4
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var i = 0;
        var j = 0;

        var mergedLenght = nums1.Length + nums2.Length;

        var merged = new List<int>();

        for (var k = 0; k <= mergedLenght / 2; k++)
        {
            if (i < nums1.Length && (j >= nums2.Length || nums1[i] < nums2[j]))
            {
                merged.Add(nums1[i]);
                i++;
            }
            else
            {
                merged.Add(nums2[j]);
                j++;
            }
        }

        var result = mergedLenght % 2 == 0 
            ? (merged[mergedLenght / 2] + merged[(mergedLenght / 2) - 1]) / 2.0 
            : merged[mergedLenght / 2];
        return result;
    }
}