# Heap Tree

## Introduction
A Heap Tree is a specialized tree-based data structure that satisfies the heap property. In a max heap, for any given node I, the value of I is greater than or equal to the values of its children. In a min heap, the value of I is less than or equal to the values of its children.


![image](https://github.com/user-attachments/assets/bd8bfb4e-7c1f-42d9-bac2-d00adb4d4e5a)


## Why Use a Heap Tree?
- **Efficient Priority Queue**: Heap Trees are commonly used to implement priority queues.
- **Efficient Sorting**: Heapsort, an efficient sorting algorithm, is based on the heap data structure.
- **Dynamic Data**: Heap Trees can handle dynamic data, making them suitable for applications where data changes frequently.

## Terminologies
- **Node**: The fundamental part of a tree, which contains data.
- **Root**: The topmost node of a tree.
- **Leaf**: A node with no children.
- **Parent**: A node that has one or more children.
- **Child**: A node that has a parent.
- **Heap Property**: The property that defines the relationship between parent and child nodes in a heap.

## Properties of a Heap Tree
- **Complete Binary Tree**: A Heap Tree is a complete binary tree, meaning all levels are fully filled except possibly the last level, which is filled from left to right.
- **Heap Property**: In a max heap, the value of each node is greater than or equal to the values of its children. In a min heap, the value of each node is less than or equal to the values of its children.

## Example Code Snippet
Here's a simple example of a Max Heap in C#:

```csharp
using System;

public class MaxHeap
{
    private int[] heap;
    private int size;
    private int maxSize;

    public MaxHeap(int maxSize)
    {
        this.maxSize = maxSize;
        this.size = 0;
        heap = new int[this.maxSize + 1];
        heap[0] = int.MaxValue;
    }

    private int Parent(int pos) => pos / 2;
    private int LeftChild(int pos) => (2 * pos);
    private int RightChild(int pos) => (2 * pos) + 1;
    private bool IsLeaf(int pos) => pos >= (size / 2) && pos <= size;

    private void Swap(int fpos, int spos)
    {
        int tmp;
        tmp = heap[fpos];
        heap[fpos] = heap[spos];
        heap[spos] = tmp;
    }

    private void MaxHeapify(int pos)
    {
        if (!IsLeaf(pos))
        {
            if (heap[pos] < heap[LeftChild(pos)] || heap[pos] < heap[RightChild(pos)])
            {
                if (heap[LeftChild(pos)] > heap[RightChild(pos)])
                {
                    Swap(pos, LeftChild(pos));
                    MaxHeapify(LeftChild(pos));
                }
                else
                {
                    Swap(pos, RightChild(pos));
                    MaxHeapify(RightChild(pos));
                }
            }
        }
    }

    public void Insert(int element)
    {
        if (size >= maxSize)
        {
            return;
        }
        heap[++size] = element;
        int current = size;

        while (heap[current] > heap[Parent(current)])
        {
            Swap(current, Parent(current));
            current = Parent(current);
        }
    }

    public void Print()
    {
        for (int i = 1; i <= size / 2; i++)
        {
            Console.WriteLine(" PARENT : " + heap[i] + " LEFT CHILD : " + heap[2 * i] + " RIGHT CHILD :" + heap[2 * i + 1]);
        }
    }

    public void MaxHeap()
    {
        for (int pos = (size / 2); pos >= 1; pos--)
        {
            MaxHeapify(pos);
        }
    }

    public int Remove()
    {
        int popped = heap[1];
        heap[1] = heap[size--];
        MaxHeapify(1);
        return popped;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Max Heap is ");
        MaxHeap maxHeap = new MaxHeap(15);
        maxHeap.Insert(5);
        maxHeap.Insert(3);
        maxHeap.Insert(17);
        maxHeap.Insert(10);
        maxHeap.Insert(84);
        maxHeap.Insert(19);
        maxHeap.Insert(6);
        maxHeap.Insert(22);
        maxHeap.Insert(9);

        maxHeap.MaxHeap();

        maxHeap.Print();
        Console.WriteLine("The max val is " + maxHeap.Remove());
    }
}
```


### Real-World Applications
*• String Matching:* Used in scenarios where efficient string matching is required, such as search engines and text editors.

*• Bioinformatics:* Used in bioinformatics to analyze DNA sequences.

*• Data Compression:* Used in data compression algorithms to find repeated substrings.

*• Plagiarism Detection:* Used to detect plagiarism by finding common substrings between documents.
