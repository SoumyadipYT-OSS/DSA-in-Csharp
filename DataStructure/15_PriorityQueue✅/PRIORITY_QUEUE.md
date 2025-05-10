# PriorityQueue in C#

## Table of Contents
1. [Introduction](#introduction)
2. [What is a PriorityQueue?](#what-is-a-priorityqueue)
3. [Initialization of a PriorityQueue](#initialization-of-a-priorityqueue)
4. [PriorityQueue Implementation in C# (Initialization)](#priorityqueue-implementation-in-c-initialization)
5. [Conclusion](#conclusion)
6. [References](#references)

---

## Introduction
A **PriorityQueue** is an abstract data type where each element is associated with a "priority" and elements are served based on their priority (rather than just the order in which they were inserted). In many implementations, a Heap (often a Min‑Heap or Max‑Heap) serves as the underlying data structure for efficient priority retrieval.

## What is a PriorityQueue?
- **Abstract Concept:** A priority queue lets you insert elements and always extract the one with the highest priority (or lowest value in the case of a Min‑PriorityQueue).
- **Common Operations:**  
  - **Enqueue:** Insert an element into the queue.
  - **Peek:** Look at the element with the highest priority without removing it.
  - **Dequeue:** Remove and return the element with the highest priority.
- **Underlying Implementation:**  
  - Often implemented using a Heap. In our example, we use a **Min‑Heap** where the smallest element (being the highest priority) is always available at the root.

## Initialization of a PriorityQueue
Initialization of a PriorityQueue involves setting up its underlying storage. Here, we encapsulate our Heap (or Min‑Heap) within the PriorityQueue class. The initialization will:
- Create an instance of the Heap.
- Provide a constructor to set up an empty PriorityQueue ready to accept elements.

## PriorityQueue Implementation in C# (Initialization)
Below is the C# code that defines a generic `PriorityQueue<T>` based on a Min‑Heap implementation. This code focuses on initialization, laying the foundation for later adding methods such as Enqueue, Dequeue, and Peek.

```csharp
using System;
using System.Collections.Generic;

// First, here's our basic MinHeap implementation used as the underlying container.
public class MinHeap<T> where T : IComparable<T>
{
    private List<T> heap;

    public MinHeap()
    {
        heap = new List<T>();
    }

    public MinHeap(int capacity)
    {
        heap = new List<T>(capacity);
    }

    public int Count => heap.Count;

    public void Insert(T item)
    {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    public T Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }
        return heap[0];
    }

    public T ExtractMin()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        T min = heap[0];
        heap[0] = heap[Count - 1];
        heap.RemoveAt(Count - 1);
        HeapifyDown(0);
        return min;
    }

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
            else break;
        }
    }

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
            else break;
        }
    }

    private void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}

// Now, we build the PriorityQueue which wraps the MinHeap.
public class PriorityQueue<T> where T : IComparable<T>
{
    private MinHeap<T> heap;

    // Constructor to initialize the PriorityQueue.
    public PriorityQueue()
    {
        heap = new MinHeap<T>();
    }

    // Optional: Constructor with initial capacity.
    public PriorityQueue(int capacity)
    {
        heap = new MinHeap<T>(capacity);
    }
    
    // (Other methods such as Enqueue, Dequeue, and Peek will be added later.)
}

public class Program
{
    public static void Main()
    {
        // Initialize an empty PriorityQueue.
        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
        
        Console.WriteLine("PriorityQueue initialized successfully!");
        
        // (At this point, the PriorityQueue is created with its underlying heap,
        // and is ready for further operations such as Enqueue and Dequeue.)
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
```

## Conclusion
In this document, we have introduced the concept of a PriorityQueue and its underlying implementation using a Min‑Heap in C#. The provided code initializes a PriorityQueue and prepares it for further operations. In future sections, we will implement methods to add, remove, and peek at elements in the queue based on their priority.
This foundational understanding of PriorityQueues is essential for implementing more complex data structures and algorithms that rely on priority-based processing.

## References
- [Priority Queue - Wikipedia](https://en.wikipedia.org/wiki/Priority_queue)
- [Heap (data structure) - Wikipedia](https://en.wikipedia.org/wiki/Heap_(data_structure))
- [Data Structures and Algorithms in C#](https://www.c-sharpcorner.com/article/data-structures-and-algorithms-in-c-sharp/)