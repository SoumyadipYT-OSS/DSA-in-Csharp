using System;
using System.Collections.Generic;


// Minimal MinHeap implementation (only Insert needed for Clear demo)
public class MinHeap<T> where T : IComparable<T> {
    private List<T> heap;
    public MinHeap() { heap = new List<T>(); }
    public int Count => heap.Count;

    public void Insert(T item) {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    // For this demo, we do not need Peek or ExtractMin.
    private void HeapifyUp(int index) {
        while (index > 0) {
            int parent = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parent]) < 0) {
                T temp = heap[index];
                heap[index] = heap[parent];
                heap[parent] = temp;
                index = parent;
            } else break;
        }
    }

    public void Clear() {
        heap.Clear();
    }
}

// PriorityQueue wrapping the MinHeap
public class PriorityQueue<T> where T : IComparable<T> {
    private MinHeap<T> heap;
    public PriorityQueue() { heap = new MinHeap<T>(); }

    public void Enqueue(T item) { heap.Insert(item); }
    public int Count => heap.Count;
    public bool IsEmpty => Count == 0;

    public void Clear() { heap.Clear(); }

    // Dummy implementations for Peek and Dequeue.
    public T Peek() { throw new NotImplementedException(); }
    public T Dequeue() { throw new NotImplementedException(); }
}


public class Program {
    public static void Main() {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        Console.WriteLine("Clear Demo:");

        // Enqueue some elements.
        pq.Enqueue(5);
        pq.Enqueue(15);
        pq.Enqueue(25);
        Console.WriteLine("Count before clear: " + pq.Count);

        // Clear the queue.
        pq.Clear();
        Console.WriteLine("Count after clear: " + pq.Count);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
