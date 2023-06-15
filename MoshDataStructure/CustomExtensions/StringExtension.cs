namespace MoshDataStructure.CustomExtensions;

public static class StringExtension
{
    public static string RemoveLast(this string value)
    {
        return value is null or "" ? string.Empty : value.Remove(value.Length - 1, 1);
    }
}