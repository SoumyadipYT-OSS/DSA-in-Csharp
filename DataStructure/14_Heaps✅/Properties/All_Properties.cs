using System;
using System.Collections.Generic;

public class MinHeap<T> where T : IComparable<T> {
    private List<T> heap;

    public MinHeap() {
        heap = new List<T>();
    }

    public int Count => heap.Count;
    public bool IsEmpty => Count == 0;

    public void Insert(T item) {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    public T ExtractMin() {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");
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
                Swap(index, parent);
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


public class Program {
    public static void Main() {
        MinHeap<int> heap = new MinHeap<int>();
        Console.WriteLine("Heap initially empty: " + heap.IsEmpty);
        Console.WriteLine("Current Count: " + heap.Count);

        heap.Insert(45);
        heap.Insert(30);
        heap.Insert(55);
        heap.Insert(20);

        Console.WriteLine("\nAfter insertions:");
        Console.WriteLine("Is heap empty? " + heap.IsEmpty);
        Console.WriteLine("Number of elements: " + heap.Count);

        // Remove two elements.
        heap.ExtractMin();
        heap.ExtractMin();

        Console.WriteLine("\nAfter extracting two minimum elements:");
        Console.WriteLine("Number of elements: " + heap.Count);

        Console.WriteLine("\nHeap Properties Demo Completed.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
