using System;
using System.Collections.Generic;

public class MinHeap<T> where T : IComparable<T> {
    private List<T> heap;

    public MinHeap() {
        heap = new List<T>();
    }

    // Returns the number of elements in the heap.
    public int Count => heap.Count;

    // Inserts a new item into the heap.
    public void Insert(T item) {
        heap.Add(item);
        HeapifyUp(Count - 1);
    }

    // Returns the minimum element without removing it.
    public T Peek() {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");
        return heap[0];
    }

    // Extracts (removes and returns) the minimum element.
    public T ExtractMin() {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");

        T min = heap[0];
        // Move the last element to the root.
        heap[0] = heap[Count - 1];
        heap.RemoveAt(Count - 1);
        HeapifyDown(0);
        return min;
    }

    // Returns true if the heap is empty.
    public bool IsEmpty => Count == 0;

    // Internal method: restores the heap property by moving element up.
    private void HeapifyUp(int index) {
        while (index > 0) {
            int parentIndex = (index - 1) / 2;
            // If current element is smaller than its parent, swap them.
            if (heap[index].CompareTo(heap[parentIndex]) < 0) {
                Swap(index, parentIndex);
                index = parentIndex;
            } else break;
        }
    }

    // Internal method: restores the heap property by moving element down.
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

    // Helper to swap two elements in the list.
    private void Swap(int i, int j) {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}


public class Program {
    public static void Main() {
        // Create a min-heap for integers.
        MinHeap<int> minHeap = new MinHeap<int>();

        // Demonstrate Insert.
        int[] itemsToInsert = { 15, 10, 20, 17, 8, 25 };
        Console.WriteLine("Inserting items: " + string.Join(", ", itemsToInsert));
        foreach (int item in itemsToInsert) {
            minHeap.Insert(item);
        }

        // Demonstrate Peek.
        Console.WriteLine("\nPeek minimum: " + minHeap.Peek());

        // Demonstrate ExtractMin.
        Console.WriteLine("\nExtracting items:");
        while (!minHeap.IsEmpty) {
            Console.Write(minHeap.ExtractMin() + " ");
        }
        Console.WriteLine("\n\nHeap Methods Demo Completed.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
