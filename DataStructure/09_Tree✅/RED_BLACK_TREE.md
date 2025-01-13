# Red-Black Tree

A Red-Black Tree is a type of self-balancing binary search tree. Each node stores an extra bit representing "color" ("red" or "black"), used to ensure the tree remains balanced during insertions and deletions.

## Properties

1. **Red/Black Property**: Each node is either red or black.
2. **Root Property**: The root is always black.
3. **Leaf Property**: Every leaf (NIL node) is black.
4. **Red Property**: If a red node has children, then the children are always black (no two red nodes can be adjacent).
5. **Depth Property**: Every path from a given node to its descendant NIL nodes has the same number of black nodes.


![Screenshot 2025-01-13 125252](https://github.com/user-attachments/assets/05945c1f-0006-4235-95d5-e23581f08c96)


## Operations

### Insertion

1. Insert the new node as a red node.
2. Fix any violations of the Red-Black Tree properties.

### Deletion

1. Remove the node.
2. Fix any violations of the Red-Black Tree properties.

## Example

Here's a simple example of a Red-Black Tree in C#:

```csharp
public class RedBlackNode
{
    public int Data;
    public RedBlackNode Left;
    public RedBlackNode Right;
    public bool IsRed;

    public RedBlackNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
        IsRed = true; // New nodes are red by default
    }
}

public class RedBlackTree
{
    private RedBlackNode root;

    public void Insert(int data)
    {
        // Insertion logic here
    }

    public void Delete(int data)
    {
        // Deletion logic here
    }

    private void FixInsert(RedBlackNode node)
    {
        // Fixing logic here
    }

    private void FixDelete(RedBlackNode node)
    {
        // Fixing logic here
    }
}
```


### Real-World Applications
*• Databases:* Used for indexing and quick data retrieval.

*• File Systems:* Organizing files and directories.

*• Networking:* Routing algorithms.

*• Artificial Intelligence:* Decision trees and game trees.
