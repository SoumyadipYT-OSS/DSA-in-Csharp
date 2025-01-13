# AVL Tree

## Introduction
An AVL Tree is a type of self-balancing binary search tree named after its inventors, Adelson-Velsky and Landis. In an AVL tree, the heights of the two child subtrees of any node differ by at most one. If at any time they differ by more than one, rebalancing is performed to restore this property.

## Why Use an AVL Tree?
- **Self-Balancing**: AVL trees maintain their balance through rotations, ensuring that operations such as insertion, deletion, and searching are efficient.
- **Efficient Searching**: AVL trees provide O(log n) time complexity for search operations.
- **Dynamic Growth**: AVL trees can grow and shrink dynamically, making them suitable for applications where data changes frequently.

## Terminologies
- **Node**: The fundamental part of a tree, which contains data.
- **Root**: The topmost node of a tree.
- **Edge**: The connection between two nodes.
- **Leaf**: A node with no children.
- **Parent**: A node that has one or more children.
- **Child**: A node that has a parent.
- **Subtree**: A tree consisting of a node and its descendants.
- **Height**: The length of the longest path from the root to a leaf.
- **Depth**: The length of the path from the root to a node.
- **Balance Factor**: The difference in heights between the left and right subtrees of a node.

## Properties of an AVL Tree
- **Balance Factor**: The balance factor of a node is the height of its left subtree minus the height of its right subtree. An AVL tree maintains a balance factor of -1, 0, or 1 for all nodes.
- **Rotations**: To maintain balance, AVL trees perform rotations (left rotation, right rotation, left-right rotation, and right-left rotation) when nodes are inserted or deleted.

## Example Code Snippet
Here's a simple example of an AVL Tree in C#:

```csharp
using System;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;
    public int Height;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
        Height = 1;
    }
}

public class AVLTree
{
    public TreeNode Root;

    public int Height(TreeNode node)
    {
        return node == null ? 0 : node.Height;
    }

    public int BalanceFactor(TreeNode node)
    {
        return node == null ? 0 : Height(node.Left) - Height(node.Right);
    }

    public TreeNode RightRotate(TreeNode y)
    {
        TreeNode x = y.Left;
        TreeNode T2 = x.Right;

        x.Right = y;
        y.Left = T2;

        y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
        x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

        return x;
    }

    public TreeNode LeftRotate(TreeNode x)
    {
        TreeNode y = x.Right;
        TreeNode T2 = y.Left;

        y.Left = x;
        x.Right = T2;

        x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
        y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

        return y;
    }

    public TreeNode Insert(TreeNode node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        if (value < node.Value)
            node.Left = Insert(node.Left, value);
        else if (value > node.Value)
            node.Right = Insert(node.Right, value);
        else
            return node;

        node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;

        int balance = BalanceFactor(node);

        if (balance > 1 && value < node.Left.Value)
            return RightRotate(node);

        if (balance < -1 && value > node.Right.Value)
            return LeftRotate(node);

        if (balance > 1 && value > node.Left.Value)
        {
            node.Left = LeftRotate(node.Left);
            return RightRotate(node);
        }

        if (balance < -1 && value < node.Right.Value)
        {
            node.Right = RightRotate(node.Right);
            return LeftRotate(node);
        }

        return node;
    }

    public void InOrderTraversal(TreeNode node)
    {
        if (node == null)
            return;

        InOrderTraversal(node.Left);
        Console.Write(node.Value + " ");
        InOrderTraversal(node.Right);
    }
}

class Program
{
    static void Main()
    {
        AVLTree tree = new AVLTree();
        tree.Root = tree.Insert(tree.Root, 10);
        tree.Root = tree.Insert(tree.Root, 20);
        tree.Root = tree.Insert(tree.Root, 30);
        tree.Root = tree.Insert(tree.Root, 40);
        tree.Root = tree.Insert(tree.Root, 50);
        tree.Root = tree.Insert(tree.Root, 25);

        Console.WriteLine("In-order traversal of the AVL tree:");
        tree.InOrderTraversal(tree.Root);
    }
}
```

### Real-World Applications
*• Databases:* Used for indexing and quick data retrieval.

*• File Systems:* Organizing files and directories.

*• Networking:* Routing algorithms.

*• Artificial Intelligence:* Decision trees and game trees.