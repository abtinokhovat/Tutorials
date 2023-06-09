using System.Numerics;

namespace Leetcode;

public class Solution1404
{
    public static int NumSteps(string s)
    {
        var decimalValue = StringToBinary(s);
        var count = 0;

        while (decimalValue != 1)
        {
            if (decimalValue % 2 == 0)
                decimalValue /= 2;
            else
                decimalValue++;
            count++;
        }

        return count;
    }

    private static BigInteger StringToBinary(string s)
    {
        var span = s.AsSpan();
        BigInteger decimalValue = 0;

        for (var i = 0; i < span.Length; i++)
        {
            var power = (BigInteger) Math.Pow(2, span.Length - i - 1);
            var bit = byte.Parse(span[i].ToString());
            decimalValue += bit * power;
        }

        return decimalValue;
    }
}