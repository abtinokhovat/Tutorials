namespace Leetcode;

public class Solution412
{
    public static IList<string> FizzBuzz(int n)
    {
        var strings = new string[n];
        for (var i = 1; i <= n; i++) strings[i - 1] = Find(i);

        return strings;
    }

    private static string Find(int n)
    {
        if (n % 3 == 0) return n % 5 == 0 ? "FizzBuzz" : "Fizz";
        return n % 5 == 0 ? "Buzz" : n.ToString();
    }
}