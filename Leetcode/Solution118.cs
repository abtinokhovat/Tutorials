namespace Leetcode;

public class Solution118
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var t = new List<IList<int>> {new[] {1}};

        for (var i = 1; i < numRows; i++)
        {
            var level = new List<int>(i + 1);
            var previousRow = t[i - 1];
            var prevValue = 0;

            for (var j = 0; j <= i; j++)
            {
                var currValue = j < previousRow.Count ? previousRow[j] : 0;
                level.Add(prevValue + currValue);
                prevValue = currValue;
            }

            t.Add(level);
        }

        return t;
    }

    public IList<int> GetRow(int rowIndex)
    {
        var row = new int[rowIndex + 1];

        // Fill the first element of the row with 1
        row[0] = 1;

        // Calculate the remaining elements of the row
        for (var i = 1; i <= rowIndex; i++)
        {
            var currValue = (long) row[i - 1] * (rowIndex - i + 1) / i;
            row[i] = (int) currValue;
        }

        return row;
    }
}