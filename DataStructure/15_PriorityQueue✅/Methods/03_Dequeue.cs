using System;
using System.Collections.Generic;

// Minimal MinHeap implementation with ExtractMin (used for Dequeue)
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

    public T ExtractMin() {
        if (Count == 0) throw new InvalidOperationException("Heap is empty!");
        T min = heap[0];
        heap[0] = heap[Count - 1];
        heap.RemoveAt(Count - 1);
        HeapifyDown(0);
        return min;
    }

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

    private void HeapifyDown(int index) {
        int lastIndex = Count - 1;
        while (index < Count) {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int smallest = index;
            if (left <= lastIndex && heap[left].CompareTo(heap[smallest]) < 0)
                smallest = left;
            if (right <= lastIndex && heap[right].CompareTo(heap[smallest]) < 0)
                smallest = right;
            if (smallest != index) {
                T temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                index = smallest;
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
    public T Dequeue() { return heap.ExtractMin(); }
    public int Count => heap.Count;
    public bool IsEmpty => Count == 0;

    // Dummy Clear for now.
    public void Clear() { throw new NotImplementedException(); }
}


public class Program {
    public static void Main() {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        Console.WriteLine("Dequeue Demo:");

        // Enqueue elements.
        pq.Enqueue(30);
        pq.Enqueue(10);
        pq.Enqueue(20);

        // Dequeue elements until the queue is empty.
        Console.WriteLine("Dequeued elements in order:");
        while (!pq.IsEmpty) {
            Console.Write(pq.Dequeue() + " ");
        }
        Console.WriteLine("\nFinal Count: " + pq.Count);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
