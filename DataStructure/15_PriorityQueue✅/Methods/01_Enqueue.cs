using System;
using System.Collections.Generic;

// Minimal MinHeap implementation
public class MinHeap<T> where T : IComparable<T> {
    private List<T> heap;
    public MinHeap() { heap = new List<T>(); }
    public int Count => heap.Count;

    public void Insert(T item) {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    private void HeapifyUp(int index) {
        while (index > 0) {
            int parentIndex = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parentIndex]) < 0) {
                T temp = heap[index];
                heap[index] = heap[parentIndex];
                heap[parentIndex] = temp;
                index = parentIndex;
            } else break;
        }
    }
}

// PriorityQueue using MinHeap
public class PriorityQueue<T> where T : IComparable<T> {
    private MinHeap<T> heap;
    public PriorityQueue() {
        heap = new MinHeap<T>();
    }

    public void Enqueue(T item) {
        heap.Insert(item);
    }

    public int Count => heap.Count;
    public bool IsEmpty => Count == 0;

    // Dummy implementations for Peek, Dequeue, and Clear for completeness.
    // (They will be demonstrated in other separate programs.)
    public T Peek() { throw new NotImplementedException(); }
    public T Dequeue() { throw new NotImplementedException(); }
    public void Clear() { throw new NotImplementedException(); }
}


public class Program {
    public static void Main() {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        Console.WriteLine("Enqueue Demo:");

        // Enqueue a few elements.
        pq.Enqueue(10);
        pq.Enqueue(5);
        pq.Enqueue(20);

        // Display count to show items were enqueued.
        Console.WriteLine("Number of elements after enqueues: " + pq.Count);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
