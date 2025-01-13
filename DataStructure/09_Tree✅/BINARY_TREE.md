# Binary Tree

## Introduction
A Binary Tree is a hierarchical data structure in which each node has at most two children, referred to as the left child and the right child. It is used to represent and organize data in a way that is easy to navigate and search.

## Why Use a Binary Tree?
- **Efficient Searching and Sorting**: Binary Trees allow for efficient searching, insertion, and deletion operations.
- **Hierarchical Data Representation**: They are ideal for representing hierarchical data such as file systems.
- **Dynamic Growth**: Binary Trees can grow and shrink dynamically, making them suitable for applications where data changes frequently.

- ![2rTqYlcrnWtICedt131tDft0CmkzZaViExJX](https://github.com/user-attachments/assets/0fc5e0ff-50f2-4d25-a851-ab1c3e17276a)

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
- **Sibling Nodes**: Nodes that share the same parent.
- **Ancestor Node**: Any node on the path from the root to that node.
- **Descendant Node**: Any node on the path from that node to a leaf.
- **Degree of a Node**: The number of children a node has.
- **Degree of a Tree**: The maximum degree of any node in the tree.

## Types of Binary Trees
- **Full Binary Tree**: Every node has either 0 or 2 children.
- **Complete Binary Tree**: All levels are completely filled except possibly the last level, which is filled from left to right.
- **Perfect Binary Tree**: All internal nodes have two children and all leaf nodes are at the same level.
- **Balanced Binary Tree**: The height of the left and right subtrees of any node differ by at most one.
- **Binary Search Tree (BST)**: A binary tree where the left child contains values less than the parent, and the right child contains values greater than the parent.

## Tree Traversal Methods
- **In-order Traversal**: Visit the left subtree, the root, and then the right subtree.
- **Pre-order Traversal**: Visit the root, the left subtree, and then the right subtree.
- **Post-order Traversal**: Visit the left subtree, the right subtree, and then the root.
- **Level-order Traversal**: Visit nodes level by level from top to bottom.

## Example Code Snippet
Here's a simple example of a Binary Search Tree in C#:

```csharp
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
}
```


### Real-World Applications:
*• File Systems:* Organizing files and directories.

*• Databases:* Indexing for quick data retrieval.

*• Networking:* Routing algorithms.

*• Artificial Intelligence:* Decision trees and game trees.


In essence, Binary Trees are a fundamental 
data structure that provides efficient ways 
to manage and organize data hierarchically.

