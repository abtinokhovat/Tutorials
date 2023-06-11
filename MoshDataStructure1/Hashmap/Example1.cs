namespace MoshDataStructure1.Hashmap;

public class Example1
{
    public static char FirstNotRepeatedChar(string str)
    {
        var hashMap = new Dictionary<char, int>();
        var span = str.AsSpan();

        foreach (var ch in span)
            if (hashMap.ContainsKey(ch))
                hashMap[ch]++;
            else
                hashMap.Add(ch, 1);

        return (from pair in hashMap where pair.Value == 1 select pair.Key).FirstOrDefault();
    }
}