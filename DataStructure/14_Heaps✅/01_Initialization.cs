// Simple example on Min-Heap initialization in C#

using System;
using System.Collections.Generic;

public class MinHeap<T> where T : IComparable<T> {
    // Underlying dynamic storage for heap elements.
    private List<T> heap;

    // Default constructor initializes an empty heap.
    public MinHeap() {
        heap = new List<T>();
    }

    // Optional: Constructor with pre-specified capacity.
    public MinHeap(int capacity) {
        heap = new List<T>(capacity);
    }

    // Property to expose the current number of elements.
    public int Count => heap.Count;

    // Helper method to display the heap's contents (for debugging/visualization).
    public void PrintHeap() {
        Console.WriteLine("Heap elements:");
        foreach (T item in heap) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // (Insertion, deletion, and other heap operations would be implemented here.)
}

public class Program {
    public static void Main() {
        // Initialize the min-heap.
        MinHeap<int> minHeap = new MinHeap<int>();

        // For now, since we are focusing on initialization, we'll only show that the heap starts empty.
        Console.WriteLine("Heap initialized.");
        Console.WriteLine("Current heap count: " + minHeap.Count);

        // Display the (empty) heap.
        minHeap.PrintHeap();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
