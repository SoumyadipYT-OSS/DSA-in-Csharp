# Complete Binary Tree

## Introduction
A Complete Binary Tree is a type of binary tree in which all 
levels are completely filled except possibly the last level, which is filled from left to right. This ensures that the tree is as compact as possible.

## Why Use a Complete Binary Tree?
- **Efficient Memory Usage**: Complete binary trees make efficient use of memory by ensuring that nodes are as compact as possible.
- **Balanced Operations**: Operations such as insertion, deletion, and traversal can be more balanced and efficient.
- **Heap Implementation**: Complete binary trees are often used to implement binary heaps, which are useful in priority queues.

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

## Properties of a Complete Binary Tree
- **All levels are completely filled except possibly the last level**: The last level is filled from left to right.
- **Height of the tree**: The height of a complete binary tree with `n` nodes is `O(log n)`.
- **Number of nodes**: A complete binary tree with height `h` has between `2^h` and `2^(h+1) - 1` nodes.

## Example Code Snippet
Here's a simple example of a Complete Binary Tree in C#:

```csharp
using System;
using System.Collections.Generic;

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

public class CompleteBinaryTree
{
    public TreeNode Root;

    public void Insert(int value)
    {
        if (Root == null)
        {
            Root = new TreeNode(value);
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (current.Left == null)
            {
                current.Left = new TreeNode(value);
                break;
            }
            else
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right == null)
            {
                current.Right = new TreeNode(value);
                break;
            }
            else
            {
                queue.Enqueue(current.Right);
            }
        }
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
        CompleteBinaryTree tree = new CompleteBinaryTree();
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(3);
        tree.Insert(4);
        tree.Insert(5);
        tree.Insert(6);
        tree.Insert(7);

        Console.WriteLine("In-order traversal of the complete binary tree:");
        tree.InOrderTraversal(tree.Root);
    }
}
```
