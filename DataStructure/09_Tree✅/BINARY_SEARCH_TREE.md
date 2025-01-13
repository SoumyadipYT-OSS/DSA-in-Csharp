# Binary Search Tree (BST)

## Introduction
A Binary Search Tree (BST) is a type of binary tree in which each node has at most two children, referred to as the left child and the right child. The key property of a BST is that the left child of a node contains values less than the parent node, and the right child contains values greater than the parent node.

## Why Use a Binary Search Tree?
- **Efficient Searching**: BSTs allow for efficient searching, insertion, and deletion operations with an average time complexity of O(log n).
- **Ordered Data**: BSTs maintain data in a sorted order, which makes them useful for applications that require ordered data.
- **Dynamic Growth**: BSTs can grow and shrink dynamically, making them suitable for applications where data changes frequently.

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

## Properties of a Binary Search Tree
- **Left Child < Parent**: The value of the left child is less than the value of the parent node.
- **Right Child > Parent**: The value of the right child is greater than the value of the parent node.
- **No Duplicate Values**: Typically, BSTs do not contain duplicate values.

## Example Code Snippet
Here's a simple example of a Binary Search Tree in C#:

```csharp
using System;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public TreeNode Root;

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private TreeNode InsertRec(TreeNode root, int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        if (value < root.Value)
            root.Left = InsertRec(root.Left, value);
        else if (value > root.Value)
            root.Right = InsertRec(root.Right, value);

        return root;
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
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("In-order traversal of the binary search tree:");
        tree.InOrderTraversal(tree.Root);
    }
}
```


### Real-World Applications:
*• Databases:* Used for indexing and quick data retrieval.

*• File Systems:* Organizing files and directories.

*• Networking:* Routing algorithms.

*• Artificial Intelligence:* Decision trees and game trees.