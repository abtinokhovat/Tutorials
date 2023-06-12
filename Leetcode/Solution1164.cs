namespace Leetcode;

public class Solution1164
{
    public class SnapshotArray
    {
        public SnapshotArray(int length)
        {
            LastSnapId = 0;
            Array = new List<Dictionary<int, int>>(length);

            // init with zero values
            for (var i = 0; i <= length; i++) Array.Add(new Dictionary<int, int> {[0] = 0});
        }

        private int LastSnapId { get; set; }

        private List<Dictionary<int, int>> Array { get; }

        public void Set(int index, int val)
        {
            Array[index][LastSnapId] = val;
        }

        public int Snap()
        {
            return LastSnapId++;
        }

        public int Get(int index, int snapId)
        {
            var dictionary = Array[index];

            while (!dictionary.ContainsKey(snapId)) --snapId;

            return dictionary[snapId];
        }
    }
}