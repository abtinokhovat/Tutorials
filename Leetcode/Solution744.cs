namespace Leetcode;

public static class Solution744
{
    public static char NextGreatestLetter(char[] letters, char target)
    {
        if (letters[^1] <= target)
            return letters[0];
        
        var start = 0;
        var end = letters.Length - 1;

        while (start < end)
        {
            var mid = (start + end) / 2;
            if (target >= letters[mid])
                start = mid + 1;
            else
                end = mid;
        }

        return letters[start];
    }
}