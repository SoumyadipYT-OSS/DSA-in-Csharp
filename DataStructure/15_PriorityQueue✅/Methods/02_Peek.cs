using System;
using System.Collections.Generic;

// Minimal MinHeap implementation with Peek capability
public class MinHeap<T> where T : IComparable<T> {
    private List<T> heap;
    public MinHeap() { heap = new List<T>(); }
    public int Count => heap.Count;

    public void Insert(T item) {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    public T Peek() {
        if (Count == 0) throw new InvalidOperationException("Heap is empty!");
        return heap[0];
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
    public PriorityQueue() { heap = new MinHeap<T>(); }

    public void Enqueue(T item) { heap.Insert(item); }
    public T Peek() { return heap.Peek(); }
    public int Count => heap.Count;
    public bool IsEmpty => Count == 0;

    // Dummy implementations for Dequeue and Clear.
    public T Dequeue() { throw new NotImplementedException(); }
    public void Clear() { throw new NotImplementedException(); }
}


public class Program {
    public static void Main() {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        Console.WriteLine("Peek Demo:");

        // Enqueue some elements.
        pq.Enqueue(15);
        pq.Enqueue(3);
        pq.Enqueue(7);

        // Peek at the highest-priority (minimum) element.
        Console.WriteLine("Element at the front (Peek): " + pq.Peek());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
