# Full Binary Tree

## Introduction
A Full Binary Tree, also known as a Proper Binary Tree or Strict Binary Tree, is a type of binary tree in which every node has either 0 or 2 children. This means that no node in a full binary tree has only one child.

## Why Use a Full Binary Tree?
- **Predictable Structure**: The full binary tree has a predictable structure, making it easier to implement certain algorithms.
- **Efficient Memory Usage**: Since each node has either 0 or 2 children, memory usage can be more efficient compared to other types of binary trees.
- **Balanced Operations**: Operations such as insertion, deletion, and traversal can be more balanced and efficient.





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

## Properties of a Full Binary Tree
- **Every node has 0 or 2 children**: No node has only one child.
- **Height of the tree**: The height of a full binary tree with `n` nodes is at least `log2(n+1)` and at most `n-1`.
- **Number of leaf nodes**: A full binary tree with `n` internal nodes has `n+1` leaf nodes.

## Example Code Snippet
Here's a simple example of a Full Binary Tree in C#:

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

public class FullBinaryTree
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
        FullBinaryTree tree = new FullBinaryTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("In-order traversal of the full binary tree:");
        tree.InOrderTraversal(tree.Root);
    }
}
```


### Real-World Applications
*• Decision Trees:* Used in machine learning for decision-making processes.

*• Expression Trees:* Used in compilers to represent expressions.

*• Hierarchical Data Representation:* Useful for representing hierarchical data such as organizational structures.


In essence, Full Binary Trees are a fundamental data structure 
that provides efficient ways to manage and organize data hierarchically.