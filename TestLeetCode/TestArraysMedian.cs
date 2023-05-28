using Leetcode;

namespace TestLeetCode;

public class TestArraysMedian
{
    [Fact]
    public void Testcase1()
    {
        int[] nums1 = {1, 3};
        int[] nums2 = {2};

        var result = Solution4.FindMedianSortedArrays(nums1, nums2);

        Assert.Equal(2.0000, result);
    }

    [Fact]
    public void Testcase2()
    {
        int[] nums1 = {1, 2};
        int[] nums2 = {3, 4};

        var result = Solution4.FindMedianSortedArrays(nums1, nums2);

        Assert.Equal(2.5000, result);
    }
    
    [Fact]
    public void Testcase3()
    {
        int[] nums1 = {2};
        int[] nums2 = {1, 3};

        var result = Solution4.FindMedianSortedArrays(nums1, nums2);

        Assert.Equal(2.0000, result);
    }
    
    [Fact]
    public void Testcase4()
    {
        int[] nums1 = {2};
        var nums2 = Array.Empty<int>();

        var result = Solution4.FindMedianSortedArrays(nums1, nums2);

        Assert.Equal(2.0000, result);
    }
}