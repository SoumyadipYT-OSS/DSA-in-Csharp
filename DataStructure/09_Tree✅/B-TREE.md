# B-Tree

A B-Tree is a self-balancing tree data structure that maintains sorted data and allows searches, sequential access, insertions, and deletions in logarithmic time. It is commonly used in databases and file systems.

## Properties

1. **Balanced**: All leaf nodes are at the same depth.
2. **Node Capacity**: Each node can contain multiple keys and children.
3. **Sorted**: Keys within a node are sorted.
4. **Height**: The height of the tree is kept low by splitting and merging nodes.


![Uploading Screenshot 2025-01-14 002917.png…]()


## Operations

### Insertion

1. Insert the key into the appropriate node.
2. If the node exceeds its capacity, split it and propagate the split upwards.

### Deletion

1. Remove the key from the appropriate node.
2. If the node falls below its minimum capacity, merge it with a sibling or redistribute keys.

## Example

Here's a simple example of a B-Tree in C#:

```csharp
public class BTreeNode
{
    public int[] Keys;
    public BTreeNode[] Children;
    public int Degree;
    public bool IsLeaf;

    public BTreeNode(int degree, bool isLeaf)
    {
        Degree = degree;
        IsLeaf = isLeaf;
        Keys = new int[2 * degree - 1];
        Children = new BTreeNode[2 * degree];
    }
}

public class BTree
{
    private BTreeNode root;
    private int degree;

    public BTree(int degree)
    {
        this.degree = degree;
        root = new BTreeNode(degree, true);
    }

    public void Insert(int key)
    {
        // Insertion logic here
    }

    public void Delete(int key)
    {
        // Deletion logic here
    }

    public BTreeNode Search(int key)
    {
        // Search logic here
        return null;
    }
}
```


### Real-World Applications:
*• Databases:*  Used for indexing and quick data retrieval.

*• File Systems:* Organizing files and directories.

*• Networking:* Routing algorithms.

*• Operating Systems:* Managing memory and file systems.
