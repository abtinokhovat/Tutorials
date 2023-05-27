using System.Text;

namespace Leetcode;

public static class Solution3
{
    public static string MergeAlternately(string word1, string word2)
    {
        var span1 = word1.ToCharArray();
        var span2 = word2.ToCharArray();

        var merged = new StringBuilder();

        while (span1.Length + span2.Length != 0)
        {
            if (span1.Length > 0)
            {
                merged.Append(span1[0]);
                span1 = span1.Skip(1).ToArray();   
            }

            if (span2.Length <= 0) continue;
            merged.Append(span2[0]);
            span2 = span2.Skip(1).ToArray();

        }

        return merged.ToString();
    }
}