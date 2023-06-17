namespace Leetcode;

public class Solution1089
{
    public static void DuplicateZeros(int[] arr)
    {
        var indent = 0;
        var copy = new List<int>(arr);

        for (var i = 0; i < arr.Length; i++)
        {
            if (i + indent >= arr.Length) break;
            arr[i + indent] = copy[i];

            if (copy[i] == 0) continue;
            if (i + indent + 1 >= arr.Length) break;
            arr[i + indent + 1] = 0;
            indent++;
        }
    }
}