using System;
using System.Collections.Generic;

// Minimal MinHeap implementation used as the underlying container.
public class MinHeap<T> where T : IComparable<T> {
    private List<T> heap;

    public MinHeap() {
        heap = new List<T>();
    }

    public int Count => heap.Count;

    public void Insert(T item) {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    public T Peek() {
        if (Count == 0)
            throw new InvalidOperationException("Heap is empty!");
        return heap[0];
    }

    public T ExtractMin() {
        if (Count == 0)
            throw new InvalidOperationException("Heap is empty!");
        T min = heap[0];
        heap[0] = heap[Count - 1];
        heap.RemoveAt(Count - 1);
        HeapifyDown(0);
        return min;
    }

    private void HeapifyUp(int index) {
        while (index > 0) {
            int parentIndex = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parentIndex]) < 0) {
                Swap(index, parentIndex);
                index = parentIndex;
            } else break;
        }
    }

    private void HeapifyDown(int index) {
        int lastIndex = Count - 1;
        while (index < Count) {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int smallest = index;
            if (leftChildIndex <= lastIndex && heap[leftChildIndex].CompareTo(heap[smallest]) < 0)
                smallest = leftChildIndex;
            if (rightChildIndex <= lastIndex && heap[rightChildIndex].CompareTo(heap[smallest]) < 0)
                smallest = rightChildIndex;
            if (smallest != index) {
                Swap(index, smallest);
                index = smallest;
            } else break;
        }
    }

    private void Swap(int i, int j) {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}

// PriorityQueue built on top of the MinHeap.
public class PriorityQueue<T> where T : IComparable<T> {
    private MinHeap<T> heap;

    public PriorityQueue() {
        heap = new MinHeap<T>();
    }

    public void Enqueue(T item) {
        heap.Insert(item);
    }

    public T Dequeue() {
        return heap.ExtractMin();
    }

    public T Peek() {
        return heap.Peek();
    }

    public int Count => heap.Count;
    public bool IsEmpty => Count == 0;

    public void Clear() {
        while (!IsEmpty) {
            Dequeue();
        }
    }
}


public class Program {
    public static void Main() {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        Console.WriteLine("IsEmpty Property Demo:");

        // Initially, the queue is empty.
        Console.WriteLine("Is PriorityQueue empty? " + pq.IsEmpty);

        // Enqueue an element.
        pq.Enqueue(100);
        Console.WriteLine("After one enqueue, is PriorityQueue empty? " + pq.IsEmpty);

        // Dequeue the element.
        pq.Dequeue();
        Console.WriteLine("After dequeuing the element, is PriorityQueue empty? " + pq.IsEmpty);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
