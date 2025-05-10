# Heap Data Structure in C#

## Table of Contents
1. [Introduction](#introduction)
2. [What is a Heap?](#what-is-a-heap)
3. [Methods of a Heap](#methods-of-a-heap)
4. [Properties of a Heap](#properties-of-a-heap)
5. [Heap Implementation in C#](#heap-implementation-in-c)
6. [Conclusion](#conclusion)
7. [References](#references)

---

## Introduction
Heaps are fundamental tree-based data structures that enable efficient priority-based operations. They are used widely in algorithms (such as Dijkstra's shortest path or heap sort) and serve as the underlying implementation for priority queues. This document focuses on the **Min-Heap** variant, where the smallest element is always at the root, and explains its methods, properties, and implementation in C#.

---

## What is a Heap?
A Heap is a complete binary tree that satisfies the **heap property**. In a **Min-Heap**, every parent node is less than or equal to its children, ensuring that the smallest value is always at the root. Although logically a tree, heaps are typically implemented using a dynamic array (or `List<T>` in C#) where:
- The left child of the node at index `i` is at index `2 * i + 1`.
- The right child is at index `2 * i + 2`.
- The parent is at index `(i - 1) / 2`.

This array-based representation makes heaps memory efficient and easy to implement.

---

## Methods of a Heap
For our generic Min-Heap, the key methods include:

1. **Insert(T item):**
   - **Purpose:** Adds a new element to the heap.
   - **Process:** Appends the new item at the end of the list then calls *HeapifyUp* to restore the heap order.

2. **Peek():**
   - **Purpose:** Returns the minimum element (located at the root) without removing it.
   - **Usage:** Useful for checking the highest-priority item.

3. **ExtractMin():**
   - **Purpose:** Removes and returns the minimum element.
   - **Process:** Replaces the root with the last element, removes the last element, and then calls *HeapifyDown* to restore the heap property.

4. **HeapifyUp(int index):**
   - **Purpose:** A helper method that moves the element at the given index upward until the heap property is restored after an insertion.

5. **HeapifyDown(int index):**
   - **Purpose:** A helper method that moves the element at the given index downward until the heap property is restored after a deletion.

6. **Swap(int i, int j):**
   - **Purpose:** A utility method to swap the positions of two elements in the underlying array.

*Optional additional methods:*
- **Clear():** Empties the heap.
- Other variations might include methods to update elements, etc.

---

## Properties of a Heap
The essential properties of our Heap implementation include:

1. **Count:**
   - **Description:** Represents the number of elements currently stored in the heap.

2. **IsEmpty:**
   - **Description:** Returns a Boolean value indicating whether the heap contains any elements (derived from `Count == 0`).

---

## Heap Implementation in C#
Below is a complete C# implementation of a generic Min-Heap that encapsulates the methods and properties described above.

```csharp
using System;
using System.Collections.Generic;

public class MinHeap<T> where T : IComparable<T>
{
    // Underlying dynamic storage for heap elements.
    private List<T> heap;

    // Constructor: Initializes an empty heap.
    public MinHeap()
    {
        heap = new List<T>();
    }

    // Constructor: Initializes a heap with a specified capacity.
    public MinHeap(int capacity)
    {
        heap = new List<T>(capacity);
    }

    // Property: Returns the number of elements in the heap.
    public int Count => heap.Count;

    // Property: Indicates whether the heap is empty.
    public bool IsEmpty => Count == 0;

    // Insert: Adds a new item into the heap.
    public void Insert(T item)
    {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    // Peek: Returns the minimum element without removing it.
    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");
        return heap[0];
    }

    // ExtractMin: Removes and returns the minimum element from the heap.
    public T ExtractMin()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");

        T min = heap[0];
        // Move the last element into the root position.
        heap[0] = heap[Count - 1];
        heap.RemoveAt(Count - 1);
        HeapifyDown(0);
        return min;
    }

    // HeapifyUp: Restores the heap property by moving the element at 'index' upward.
    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parentIndex]) < 0)
            {
                Swap(index, parentIndex);
                index = parentIndex;
            }
            else
            {
                break;
            }
        }
    }

    // HeapifyDown: Restores the heap property by moving the element at 'index' downward.
    private void HeapifyDown(int index)
    {
        int lastIndex = Count - 1;
        while (index < Count)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int smallest = index;

            if (leftChildIndex <= lastIndex && heap[leftChildIndex].CompareTo(heap[smallest]) < 0)
                smallest = leftChildIndex;

            if (rightChildIndex <= lastIndex && heap[rightChildIndex].CompareTo(heap[smallest]) < 0)
                smallest = rightChildIndex;

            if (smallest != index)
            {
                Swap(index, smallest);
                index = smallest;
            }
            else
            {
                break;
            }
        }
    }

    // Swap: Exchanges the elements at indices i and j.
    private void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    // Optional: Clear the heap.
    public void Clear()
    {
        heap.Clear();
    }
}

public class Program
{
    public static void Main()
    {
        // Create a new Min-Heap for integers.
        MinHeap<int> minHeap = new MinHeap<int>();

        // Demonstrate Insert.
        Console.WriteLine("Inserting items: 15, 10, 20, 17, 8, 25");
        int[] items = { 15, 10, 20, 17, 8, 25 };
        foreach (int item in items)
        {
            minHeap.Insert(item);
        }

        // Check properties.
        Console.WriteLine("\nHeap Count: " + minHeap.Count);
        Console.WriteLine("Is Heap Empty? " + minHeap.IsEmpty);

        // Demonstrate Peek.
        Console.WriteLine("\nMinimum element (Peek): " + minHeap.Peek());

        // Demonstrate ExtractMin.
        Console.WriteLine("\nExtracting elements (in order):");
        while (!minHeap.IsEmpty)
        {
            Console.Write(minHeap.ExtractMin() + " ");
        }
        Console.WriteLine("\nHeap Count after extractions: " + minHeap.Count);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
```

## References
- [Heap Data Structure - Wikipedia](https://en.wikipedia.org/wiki/Heap_(data_structure))
- [C# Programming Guide - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/)]
- [Heap Sort - GeeksforGeeks](https://www.geeksforgeeks.org/heap-sort-2/)
