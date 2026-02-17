using static System.Console;

namespace _01_BinaryTree;


public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = Right = null!;
    }
}


public class BinaryTree
{
    public TreeNode? Root { get; private set; }
    
    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    private static TreeNode InsertRecursive(TreeNode? node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        else if (value < node.Value)
            node.Left = InsertRecursive(node.Left, value);

        else if (value > node.Value)
            node.Right = InsertRecursive(node.Right, value);

        return node;
    }
 
    public void InOrderTraversal(TreeNode? node)
    {
        if (node == null)
            return;

        InOrderTraversal(node.Left);
        Write($"{node.Value} ");
        InOrderTraversal(node.Right);
    }

    public void PreOrderTraversal(TreeNode? node)
    {
        if (node == null)
            return;

        Write($"{node.Value} ");
        PreOrderTraversal(node.Left);
        PreOrderTraversal(node.Right);
    }

    public void PostOrderTraversal(TreeNode? node)
    {
        if (node == null)
            return;

        PostOrderTraversal(node.Left);
        PostOrderTraversal(node.Right);
        Write($"{node.Value} ");
    }
}