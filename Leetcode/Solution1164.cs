namespace Leetcode;

public class Solution1164
{
    public class SnapshotArray {
        
        private int LastSnapId {get; set;}

        private List<Dictionary<int,int>> Array { get; set; }

        public SnapshotArray(int length) {

            this.LastSnapId = 0;
            this.Array = new List<Dictionary<int, int>>(length);

            // init with zero values
            for (var i = 0; i <= length; i++)
            {
                this.Array.Add(new Dictionary<int, int> {[0] = 0});
            }
        }
    
        public void Set(int index, int val) {
            this.Array[index][LastSnapId] = val;
        }
    
        public int Snap()
        {
            return LastSnapId++;
        }
    
        public int Get(int index, int snapId)
        {
            var dictionary = Array[index];
            
            while (!dictionary.ContainsKey(snapId))
            {
                --snapId;
            }

            return dictionary[snapId];
        }
    }
}