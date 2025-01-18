# N-Ary Tree Implementation in C#

## Introduction
An N-Ary tree is a tree data structure where each node can have at most N children. This implementation in C# demonstrates how to create, search, and print an N-Ary tree.


![Screenshot 2025-01-18 151707](https://github.com/user-attachments/assets/f3e7efbe-5078-4cb4-87dd-f8f4157b3f43)


## Tree Node Class
The `TreeNode` class represents a node in the N-Ary tree. Each node has a value, a child, and a sibling.

```csharp
public class TreeNode
{
    public int Value;
    public TreeNode Child;
    public TreeNode Sibling;

    public TreeNode(int value)
    {
        Value = value;
    }
}
```

## N-Ary Tree Class
The `NAryTree` class contains methods to create the tree, search for a node, and print the tree in pre-order traversal.

```csharp
public class NAryTree
{
    public TreeNode Root;

    public TreeNode Search(TreeNode root, int value)
    {
        if (root == null) return null;
        if (value == root.Value) return root;
        TreeNode node = Search(root.Child, value);
        if (node == null) node = Search(root.Sibling, value);
        return node;
    }

    public void CreateNArray(int[] data)
    {
        TreeNode temp = null;
        if (Root != null) temp = Search(Root, data[0]);
        if (temp == null)
        {
            temp = new TreeNode(data[0]);
        }
        if (Root == null) Root = temp;
        TreeNode parent = temp;
        for (int j = 0; j < data[1]; j++)
        {
            if (j == 0)
            {
                parent.Child = new TreeNode(data[j + 2]);
                parent = parent.Child;
            }
            else
            {
                parent.Sibling = new TreeNode(data[j + 2]);
                parent = parent.Sibling;
            }
        }
    }

    public void Print()
    {
        PreOrder(Root);
    }

    public void PreOrder(TreeNode node)
    {
        if (node == null) return;
        Console.WriteLine(node.Value);
        PreOrder(node.Child);
        PreOrder(node.Sibling);
    }
}



// main class
class Program
{
    static void Main(string[] args)
    {
        NAryTree naryTree = new NAryTree();
        int[][] data = {
            new int[] { 1, 3, 2, 3, 4 },
            new int[] { 2, 3, 1, 6, 50 },
            new int[] { 3, 3, 8, 9, 10 },
            new int[] { 4, 3, 0, 0, 0, 0 }
        };
        for (int i = 0; i < data.GetLength(0); i++)
        {
            naryTree.CreateNArray(data[i]);
        }
        naryTree.Print();
        Console.ReadLine();
    }
}
```

### Real-World Applicatons
*• File Systems:* Many operating systems use N-Ary trees to represent the hierarchical structure of directories and files. 
                  Each directory can contain multiple files and subdirectories, making it a perfect fit for an N-Ary tree.

*• XML/HTML Parsing:* N-Ary trees are used to parse and represent XML and HTML documents. Each element in the document 
                      can have multiple child elements, which can be efficiently represented using an N-Ary tree.

*• Database Indexing:* N-Ary trees, particularly B-Trees and B+ Trees, are used in database indexing to allow quick data 
                       retrieval. These trees help in maintaining sorted data and allow searches, sequential access, 
                       insertions, and deletions in logarithmic time.

*• Game Development:* In game development, N-Ary trees can be used to represent game states and decision trees. Each node 
                      represents a possible state or decision, and the children represent the possible outcomes or 
                      subsequent decisions.

*• Network Routing:* N-Ary trees can be used in network routing algorithms to represent the possible paths data packets 
                     can take through a network. Each node represents a router, and the children represent the possible 
                     next hops.

*• Organizational Charts:* Companies often use N-Ary trees to represent organizational structures. Each node represents 
                           an employee, and the children represent the employees that report to them.


In conclusion, N-Ary trees are a versatile and powerful data structure that can be used to represent hierarchical data in various real-world applications. 
From file systems and XML/HTML parsing to database indexing and game development, N-Ary trees provide an efficient way to manage and traverse complex 
data structures. Their ability to handle multiple children per node makes them ideal for scenarios where data is naturally organized in a hierarchical manner.
