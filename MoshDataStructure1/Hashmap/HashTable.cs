namespace MoshDataStructure1.Hashmap;

public interface IHashTable
{
    void Put(int key, string value);
    string Get(int key);
    void Remove(int key);
}

public class HashTable : IHashTable
{
    public HashTable()
    {
        Entries = new LinkedList<Entry>[5];

        for (var i = 0; i < Entries.Length; i++) Entries[i] = new LinkedList<Entry>();
    }

    private LinkedList<Entry>[] Entries { get; }

    public void Put(int key, string value)
    {
        var (bucket, entry) = this.GetBucketAndEntry(key);

        // if key exists replace it
        if (entry != null)
        {
            entry.Value = value;
            return;
        }

        // if key doesnt exists add
        bucket.AddLast(new Entry(key, value));

    }

    public string Get(int key)
    {
        var entry = this.GetEntry(key);
        return entry?.Value!;
    }

    public void Remove(int key)
    {
        var (bucket, entry) = this.GetBucketAndEntry(key);
        if (entry == null) throw new Exception("Key does not exist.");
        
        bucket.Remove(entry);
    }

    public bool Contains(int key)
    {
        return this.GetBucket(key).Any(element => element.Key == key);
    }

    private int Hash(int number)
    {
        return number % Entries.Length;
    }

    private LinkedList<Entry> GetBucket(int key)
    {
        return Entries[Hash(key)];
    }

    private Entry GetEntry(int key)
    {
        return this.GetBucketAndEntry(key).Item2;
    }

    private Tuple<LinkedList<Entry>, Entry> GetBucketAndEntry(int key)
    {
        var x = new Dictionary<int, int[]>();

        var bucket = this.GetBucket(key);
        var entry = bucket.FirstOrDefault(entry => entry.Key == key)!;

        return new Tuple<LinkedList<Entry>, Entry>(bucket, entry);
    }

    private class Entry
    {
        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
        }

        public int Key { get; set; }
        public string Value { get; set; }
    }
}