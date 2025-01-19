# Segment Tree

## Introduction
A Segment Tree is a data structure that allows efficient range queries and updates. It is particularly useful for problems involving intervals or segments, such as finding the sum, minimum, or maximum of elements in a given range.


![Screenshot 2025-01-19 113345](https://github.com/user-attachments/assets/1d12f020-ae66-4969-be95-6ac80da047e1)


## Why Use a Segment Tree?
- **Efficient Range Queries**: Segment Trees provide O(log n) time complexity for range queries.
- **Efficient Updates**: Segment Trees allow updates to elements in O(log n) time.
- **Dynamic Data**: Segment Trees can handle dynamic data, making them suitable for applications where data changes frequently.

## Terminologies
- **Node**: The fundamental part of a tree, which contains data.
- **Root**: The topmost node of a tree.
- **Leaf**: A node with no children.
- **Parent**: A node that has one or more children.
- **Child**: A node that has a parent.
- **Segment**: A range of elements represented by a node in the Segment Tree.

## Properties of a Segment Tree
- **Balanced Tree**: A Segment Tree is a balanced binary tree.
- **Range Representation**: Each node in the Segment Tree represents a range of elements.
- **Efficient Operations**: Segment Trees provide efficient range queries and updates.

## Example Code Snippet
Here's a simple example of a Segment Tree in C#:

```csharp
using System;

public class SegmentTree
{
    private int[] tree;
    private int n;

    public SegmentTree(int[] arr)
    {
        n = arr.Length;
        tree = new int[2 * n];
        Build(arr);
    }

    private void Build(int[] arr)
    {
        for (int i = 0; i < n; i++)
            tree[n + i] = arr[i];
        for (int i = n - 1; i > 0; --i)
            tree[i] = tree[i * 2] + tree[i * 2 + 1];
    }

    public void Update(int pos, int value)
    {
        pos += n;
        tree[pos] = value;
        while (pos > 1)
        {
            pos /= 2;
            tree[pos] = tree[2 * pos] + tree[2 * pos + 1];
        }
    }

    public int Query(int left, int right)
    {
        left += n;
        right += n;
        int sum = 0;
        while (left < right)
        {
            if ((left & 1) == 1)
                sum += tree[left++];
            if ((right & 1) == 1)
                sum += tree[--right];
            left /= 2;
            right /= 2;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9, 11 };
        SegmentTree segmentTree = new SegmentTree(arr);

        Console.WriteLine("Sum of values in given range = " + segmentTree.Query(1, 5));
        segmentTree.Update(1, 10);
        Console.WriteLine("Updated sum of values in given range = " + segmentTree.Query(1, 5));
    }
}
```



### Real-World Applications
*• Range Sum Queries:* Used in scenarios where t he sum of elements in a given range needs to be calculated frequently.

*• Range Minimum/Maximum Queries:* Used in scenarios where the minimum or maximum of elements in a given range needs to be found.

*• Interval Scheduling:* Used in scheduling problems where intervals need to be managed efficiently.

*• Image Processing:* Used in image processing algorithms that involve range queries and updates.


This implementation provides a basic structure for a Segment Tree in C#. It includes methods for building the tree, 
updating elements, and querying ranges. This can be further extended to include more functionalities as needed.
