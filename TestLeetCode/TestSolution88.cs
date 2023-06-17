using Leetcode;

namespace TestLeetCode;

public class TestSolution88
{
    [Fact]
    public void Merge_ShouldConcatArrays()
    {
        // Arrange
        var nums1 = new[] {1, 2, 3, 0, 0, 0};
        var nums2 = new[] {4, 5, 6};

        var expected = new[] {1, 2, 3, 4, 5, 6};

        // Act
        Solution88.Merge(nums1, 3, nums2, 3);

        // Assert
        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_ShouldConcatArrays2()
    {
        // Arrange
        var nums1 = new[] {1, 2, 5, 0, 0, 0};
        var nums2 = new[] {2, 3, 6};

        var expected = new[] {1, 2, 2, 3, 5, 6};

        // Act
        Solution88.Merge(nums1, 3, nums2, 3);

        // Assert
        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_ShouldConcatArrays3()
    {
        // Arrange
        var nums1 = new[] {1, 2, 5, 0, 0, 0};
        var nums2 = new[] {2, 3, 6};

        var expected = new[] {1, 2, 2, 3, 5, 6};

        // Act
        Solution88.Merge(nums1, 3, nums2, 3);

        // Assert
        Assert.Equal(expected, nums1);
    }
}