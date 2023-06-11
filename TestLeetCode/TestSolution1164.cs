using Leetcode;

namespace TestLeetCode;

public class TestSolution1164
{
    [Fact]
    public void TestExample1()
    {
        var snapshotArray = new Solution1164.SnapshotArray(3);
        snapshotArray.Set(0, 5);
        var snap1 = snapshotArray.Snap();
        snapshotArray.Set(0, 6);
        var value1 = snapshotArray.Get(0, 0);

        Assert.Equal(0, value1);
        Assert.Equal(1, snap1);
    }

    [Fact]
    public void TestExample2()
    {
        var snapshotArray = new Solution1164.SnapshotArray(4);
        var snap1 = snapshotArray.Snap();
        var snap2 = snapshotArray.Snap();
        var value1 = snapshotArray.Get(3, 1);
        snapshotArray.Set(2, 4);
        var snap3 = snapshotArray.Snap();
        snapshotArray.Set(1, 4);

        Assert.Equal(0, snap1);
        Assert.Equal(1, snap2);
        Assert.Equal(0, value1);
        Assert.Equal(2, snap3);
    }
}