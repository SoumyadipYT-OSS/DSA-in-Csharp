
using static System.Console;

namespace _01_BinaryTree;


public class Program
{
    static void Main()
    {
        BinaryTree binaryTree = new();

        binaryTree.Insert(8);
        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(1);
        binaryTree.Insert(11);
        binaryTree.Insert(6);

        WriteLine("In-Order Traversal");
        binaryTree.InOrderTraversal(binaryTree.Root);
        WriteLine();

        WriteLine("Pre-Order Traversal");
        binaryTree.PreOrderTraversal(binaryTree.Root);
        WriteLine();

        WriteLine("Post-Order Traversal");
        binaryTree.PostOrderTraversal(binaryTree.Root);
        WriteLine();
    }
}