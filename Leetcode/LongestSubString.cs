namespace Leetcode;

public static class Solution2
{
    public static int LengthOfLongestSubstring(string s)
    {
        var str = "";
        var span = s.AsSpan();
        var counts = new int[span.Length > 0 ? span.Length : 1];

        for (var i = 0; i < span.Length; i++)
        {
            var ch = span[i];
            var found = str.IndexOf(ch);
            if (found != -1) str = str.Remove(0, found + 1) + ch;
            else str += ch;
            counts[i] = str.Length;
        }

        GC.Collect();
        return counts.Max();
    }
}