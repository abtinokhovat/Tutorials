namespace MoshDataStructure.Tree;

public interface ITree
{
    void Insert(int value);
    bool Find(int value);
    string TraverseInOrder();
    string TraversePreOrder();
    string TraversePostOrder();
}

public class BinaryTree : ITree
{
    // Level Order Constructor
    public BinaryTree(IEnumerable<int> nodes)
    {
        foreach (var node in nodes) Insert(node);
    }

    public Node? Root { get; set; }

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
        var nearestNode = FindNearestNode(value);
        return nearestNode.Value == value;
    }

    public string TraverseInOrder()
    {
        var str = TraverseInOrder(Root);
        return str.Remove(str.Length - 1, 1);
    }

    public string TraversePreOrder()
    {
        var str = TraversePreOrder(Root);
        return str.Remove(str.Length - 1, 1);
    }

    public string TraversePostOrder()
    {
        var str = TraversePostOrder(Root);
        return str.Remove(str.Length - 1, 1);
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

    private static string TraversePreOrder(Node? node)
    {
        var str = "";
        if (node == null) return "";
        str += $"{node.Value},";
        str += TraversePreOrder(node.Left);
        str += TraversePreOrder(node.Right);
        return str;
    }

    private static string TraversePostOrder(Node? node)
    {
        var str = "";
        if (node == null) return "";
        str += TraversePostOrder(node.Left);
        str += TraversePostOrder(node.Right);
        str += $"{node.Value},";
        return str;
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