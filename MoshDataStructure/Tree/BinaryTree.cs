using MoshDataStructure.CustomExtensions;

namespace MoshDataStructure.Tree;

public interface ITree
{
    void Insert(int value);
    bool Find(int value);
    string TraverseInOrder();
    string TraversePreOrder();
    string TraversePostOrder();
    bool Equals(BinaryTree tree);
    bool ValidateBst();
    List<int> GetNodesAtDistance(int level);
}

public class BinaryTree : ITree
{
    public BinaryTree()
    {
    }

    // Level Order Constructor
    public BinaryTree(IEnumerable<int> values)
    {
        foreach (var value in values) Insert(value);
    }
    
    // create tree level order
    public BinaryTree(IReadOnlyList<int> values)
    {
        Root = CreateTreeLevelOrder(values, 0);
    }

    private static Node? CreateTreeLevelOrder(IReadOnlyList<int> values, int index)
    {
        if (index >= values.Count)
            return null;

        var node = new Node(values[index])
        {
            Left = CreateTreeLevelOrder(values, 2 * index + 1),
            Right = CreateTreeLevelOrder(values, 2 * index + 2)
        };

        return node;
    }

    public Node? Root { get; set; }

    public int Height => CalcHeight(Root);

    public int Min
    {
        get
        {
            if (Root is null) throw new InvalidOperationException("Cannot calculate minimum value when tree is Empty");
            return MinValue(Root);
        }
    }

    public void Insert(int value)
    {
        var newNode = new Node(value);
        var nearestNode = FindNearestNode(value);

        // if tree was empty
        if (nearestNode is null)
        {
            Root = newNode;
            return;
        }

        if (value > nearestNode.Value)
        {
            nearestNode.Right = newNode;
            return;
        }

        nearestNode.Left = newNode;
    }

    public bool Find(int value)
    {
        if (Root == null) return false;
        var nearestNode = FindNearestNode(value);
        return nearestNode.Value == value;
    }

    public string TraverseInOrder()
    {
        var str = TraverseInOrder(Root);
        return str.RemoveLast();
    }

    public string TraversePreOrder()
    {
        var str = TraversePreOrder(Root);
        return str.RemoveLast();
    }

    public string TraversePostOrder()
    {
        var str = TraversePostOrder(Root);
        return str.RemoveLast();
    }

    public Dictionary<int, List<int>> TraverseLevelOrder()
    {
        var levels = new Dictionary<int, List<int>>();
        return TraverseLevelOrder(Root, levels);
    }

    public bool Equals(BinaryTree tree)
    {
        return tree is not null && EqualsTo(Root, tree.Root);
    }
    
    public List<int> GetNodesAtDistance(int distance)
    {
        var list = new List<int>();
        return distance < 0 || distance > Height ? list : GetNodesAtDistance(Root, distance, list);
    }

    public bool ValidateBst()
    {
        //return ValidateBstRecursive(Root);
        return ValidateBst(Root, int.MinValue, int.MaxValue);
    }

    public bool ValidateBstRecursive()
    {
        return ValidateBstRecursive(Root);
        //return ValidateBst(Root, int.MinValue, int.MaxValue);
    }
    
    private static List<int> GetNodesAtDistance(Node? root, int distance, List<int> list)
    {
        if (root is null) return list;
        if (distance == 0)
        {
            list.Add(root.Value);
        }
        else
        {
            distance--;
            GetNodesAtDistance(root.Left, distance, list);
            GetNodesAtDistance(root.Right, distance, list);
        }

        return list;
    }

    private static bool ValidateBst(Node? root, int min, int max)
    {
        if (root is null) return true;
        if (root.Value > max || root.Value <= min) return false;
        var com1 = ValidateBst(root.Left, min, root.Value - 1);
        var com2 = ValidateBst(root.Right, root.Value + 1, max);
        return com1 && com2;
    }

    private static bool ValidateBstRecursive(Node? root)
    {
        if (root is null) return true;
        // if value is in range of left and right values traverse else false
        if (IsLeaf(root)) return true;

        if (root.Left is not null && root.Value < root.Left.Value) return false;
        if (root.Right is not null && root.Value > root.Right.Value) return false;

        var com1 = ValidateBstRecursive(root.Left);
        var com2 = ValidateBstRecursive(root.Right);
        return com1 && com2;
    }

    private static bool EqualsTo(Node? root1, Node? root2)
    {
        if (root1 is null && root2 is null) return true;
        if (root1 is null || root2 is null) return false;
        if (root1.Value != root2.Value) return false;
        var com1 = EqualsTo(root1.Left, root2.Left);
        var com2 = EqualsTo(root1.Right, root2.Right);
        return com1 && com2;
    }

    private static string TraverseInOrder(Node? node)
    {
        var str = "";
        if (node == null) return "";
        str += TraverseInOrder(node.Left);
        str += $"{node.Value},";
        str += TraverseInOrder(node.Right);
        return str;
    }

    private static string TraversePreOrder(Node? root)
    {
        var str = "";
        if (root == null) return "";
        str += $"{root.Value},";
        str += TraversePreOrder(root.Left);
        str += TraversePreOrder(root.Right);
        return str;
    }

    private static string TraversePostOrder(Node? root)
    {
        var str = "";
        if (root == null) return "";
        str += TraversePostOrder(root.Left);
        str += TraversePostOrder(root.Right);
        str += $"{root.Value},";
        return str;
    }

    private static int CalcHeight(Node? root)
    {
        if (root is null) return -1;
        if (IsLeaf(root)) return 0;

        var minLeft = CalcHeight(root.Left);
        var minRight = CalcHeight(root.Right);

        var height = Math.Max(minLeft, minRight);
        return height + 1;
    }

    private static int MinValue(Node? root)
    {
        if (root is null) return int.MaxValue;
        if (IsLeaf(root)) return root.Value;

        var min = Math.Min(Math.Min(MinValue(root.Left), MinValue(root.Right)), root.Value);

        return min;
    }

    private static bool IsLeaf(Node? root)
    {
        return root!.Left is null && root.Right is null;
    }

    private Node FindNearestNode(int value)
    {
        if (Root is null) return null!;

        var root = Root;

        while (true)
        {
            if (value == root.Value) return root;
            if (value < root.Value)
            {
                if (root.Left is null) return root;

                root = root.Left;
                continue;
            }

            if (root.Right is null) return root;
            root = root.Right;
        }
    }

    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }

        public int Value { get; set; }

        public Node? Left { get; set; }

        public Node? Right { get; set; }
    }
}