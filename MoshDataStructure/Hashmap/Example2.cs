namespace MoshDataStructure.Hashmap;

public class Example2
{
    public static char FirstRepeatedChar(string str)
    {
        var span = str.AsSpan();
        var set = new HashSet<char>();

        foreach (var ch in span)
        {
            if (set.Contains(ch)) return ch;
            set.Add(ch);
        }

        return char.MinValue;
    }
}