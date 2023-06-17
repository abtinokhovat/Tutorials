namespace Leetcode;

public class Solution8
{
    public static int MyAtoi(string s)
    {
        var span = s.AsSpan().TrimStart(); // Trim leading whitespace
        var sign = 1;

        if (span.Length > 0 && (span[0] == '+' || span[0] == '-'))
        {
            sign = span[0] == '-' ? -1 : 1;
            span = span[1..]; // Remove the sign character
        }

        var number = 0;

        foreach (var ch in span)
        {
            if (!char.IsDigit(ch)) break; // Stop processing if non-digit character is encountered

            var digit = ch - '0'; // Convert char to digit value

            // Check for overflow
            if (number > int.MaxValue / 10 || (number == int.MaxValue / 10 && digit > int.MaxValue % 10))
                return sign > 0 ? int.MaxValue : int.MinValue;

            number = number * 10 + digit; // Add digit to the number
        }

        return number * sign;
    }
}